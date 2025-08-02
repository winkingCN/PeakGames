using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

using TMPro;

using UnityEditor;
using UnityEditor.SceneManagement;

using UnityEditorInternal;

using UnityEngine;

public class TextReplacementEditor : EditorWindow
{
    [MenuItem("Window/游戏源码解析")]
    static void Init()
    {
        TextReplacementEditor window = (TextReplacementEditor)EditorWindow.GetWindow(typeof(TextReplacementEditor));
        window.Show();
    }
   
    void OnGUI()
    {
        #region 脚本优化删除无用脚本
        IsClassDll = EditorGUILayout.Foldout(IsClassDll, "脚本优化删除无用脚本(项目根目录)");
        if (IsClassDll)
        {
            EditorGUILayout.BeginHorizontal();
            AssetDemoPath = EditorGUILayout.TextField(AssetDemoPath);
            if (GUILayout.Button("Select Asset Path"))
            {
                string folderPath = EditorUtility.OpenFolderPanel("Select Asset Path", Application.dataPath, "");
                if (!string.IsNullOrEmpty(folderPath))
                {
                    AssetDemoPath = folderPath;
                }
            }
            EditorGUILayout.EndHorizontal();
            IsCopyPackages = GUILayout.Toggle(IsCopyPackages, "是否拷貝覆蓋Packages文件");
            IsClassDelect = GUILayout.Toggle(IsClassDelect, "删除脚本方法");
            if (GUILayout.Button("开始操作处理"))
            {
                Debug.LogError(AssetDemoPath);
                var scriptPath = AssetDemoPath + "\\Assets\\Scripts\\";
                var PluginsPath = AssetDemoPath + "\\Assets\\Plugins\\";
                var Dlls = Path.GetDirectoryName(AssetDemoPath) + "\\Dlls\\";
                PluginsToScripts(PluginsPath, scriptPath);
                ScriptsToDlls(scriptPath, Dlls);
                ScriptsDelectErrorScripts(scriptPath, true);
                var editorPath = AssetDemoPath + "\\Assets\\Editor\\";
                if (Directory.Exists(editorPath) == false)
                {
                    Directory.CreateDirectory(editorPath);
                }

                var editor = Application.dataPath + "\\Scripts\\Editor\\GameEditor";
                var files = Directory.GetFiles(editor);
                foreach (var file in files)
                {
                    if(File.Exists(editorPath + Path.GetFileName(file)))
                    {
                        File.Delete(editorPath + Path.GetFileName(file));
                    }
                    File.Copy(file, editorPath + Path.GetFileName(file));
                }
                GetFontAssetsName(AssetDemoPath+"\\Assets\\");
                if (IsCopyPackages)
                {
                    var packagesPath = Path.GetDirectoryName(Path.GetDirectoryName(Application.dataPath)) + "\\Packages";
                    var path = AssetDemoPath + "\\Packages";
                    var packages = Directory.GetFiles(packagesPath);
                    foreach (var pack in packages)
                    {
                        var name = Path.GetFileName(pack);
                        if (File.Exists(path + "\\" + name))
                        {
                            File.Delete(path + "\\" + name);
                        }
                        File.Copy(pack, path + "\\" + name);
                    }
                    Debug.Log(path);
                    Debug.Log(packagesPath);
                }
                if(IsClassDelect)
                {
                    var list = new List<string>();
                    GetAllAssetPaths(list,scriptPath,"*.cs");
                    GetAllAssetPaths(list, PluginsPath, "*.cs");
                    foreach(var path in list)
                    {
                        if(path.Contains("/Editor/") == false)
                            RemoveMethods(path);
                    }
                }
                Debug.LogError("完成");
            }
        }
        #endregion

        #region 重新链接脚本引用
        isInitDLL = EditorGUILayout.Foldout(isInitDLL, "重新链接脚本引用");

        if (isInitDLL)
        {
            if (GUILayout.Button("AllDLL"))
            {
                LoadAllDll();
                csNames.Clear();
                guidDatas.Clear();
                foreach (var path in DllPaths)
                {
                    LoadAllClassGUID(path.Key);
                    LoadAllClassGUID(path.Value, false);
                }
                guidLists.Clear();
                var guidDataTexts = "";
                foreach (ClassGUIDDatas guid in csNames.Values)
                {
                    if (guid.NewGuid != "")
                    {
                        guidDatas.Add(guid.oldGuid, guid);
                        guidLists.Add(guid);
                        guidDataTexts += guid.Name + ":" + guid.NewGuid + "|";
                    }
                    else
                    {
                        Debug.LogError(guid.Name);
                    }

                }
                File.WriteAllText(Application.dataPath+"/UnityGUID.json", guidDataTexts);
            }
           
            guidPoint = EditorGUILayout.BeginScrollView(guidPoint);
            if (guidReordLists == null)
            {
                guidReordLists = new ReorderableList(guidLists, typeof(ClassGUIDDatas), true, true, false, false);
                guidReordLists.drawHeaderCallback = DrawHeader;
                guidReordLists.drawElementCallback = (rect, index, isActive, isFocused) =>
                {
                     //= EditorGUI.ObjectField(new Rect(rect.x, rect.y, rect.width, EditorGUIUtility.singleLineHeight), GUIContent.none, meshList[index], typeof(ClassGUIDDatas), false) as ClassGUIDDatas;
                    if(isFocused)
                    {
                        guidLists[index].Height = 24 * 3 ;
                        EditorGUI.LabelField(new Rect(rect.x, rect.y, rect.width, 24), guidLists[index].Name);
                        EditorGUI.LabelField(new Rect(rect.x, rect.y+24, rect.width, 24), guidLists[index].oldGuid);
                        EditorGUI.LabelField(new Rect(rect.x, rect.y+48, rect.width, 24), guidLists[index].NewGuid);
                    }
                    else
                    {
                        guidLists[index].Height = 24 ;
                        EditorGUI.LabelField(new Rect(rect.x, rect.y, rect.width, 24), guidLists[index].Name);
                    }
                }; 
                guidReordLists.elementHeightCallback = (int idx) =>
                {
                    return guidLists[idx].Height;
                };
                guidReordLists.onAddCallback = (ReorderableList list) =>
                {
                    guidLists.Add(null);
                };
                guidReordLists.onRemoveCallback = (ReorderableList list) =>
                {
                    guidLists.RemoveAt(list.index);
                };
            }
            guidReordLists.DoLayoutList();
            
            EditorGUILayout.EndScrollView();
            if (GUILayout.Button("Replace Text"))
            {
                ReplaceTextInFiles(AssetDatabase.FindAssets("t:Prefab"));
                GetFontAssets(Application.dataPath);
                ReplaceTextInFiles(AssetDatabase.FindAssets("t:Scene"));
                FontAssetData();
            }
         
        }
        #endregion

        #region 字体操作
        IsFont = EditorGUILayout.Foldout(IsFont, "字体操作");
        if(IsFont)
        {
            if (GUILayout.Button("初始化替换字体数据"))
            {
                var path = Application.dataPath;
                Debug.Log(path);
                var fontPath = path;
                for(var x = 0;x < 4;x++)
                {
                    fontPath =  Path.GetDirectoryName(fontPath);
                }
                fontPath += "\\Fonts";
                path += "\\NewFonts\\";
                if (Directory.Exists(path) == false)
                {
                    Directory.CreateDirectory(path);
                }
                var files = Directory.GetFiles(fontPath);
                foreach(var file in files)
                {
                    var name = Path.GetFileName(file);
                    if(File.Exists(path + name))
                    {
                        File.Delete(path + name);
                    }
                    File.Copy(file, path + name);
                }
                AssetDatabase.Refresh();
            }
            sourceFont = (TMP_FontAsset)EditorGUILayout.ObjectField(sourceFont, typeof(TMP_FontAsset), false);
            ToAssetTextureNameObj = (TMP_FontAsset)EditorGUILayout.ObjectField("字体图集替换对象", ToAssetTextureNameObj, typeof(TMP_FontAsset), false);
            if(sourceFont != null && ToAssetTextureNameObj != null)
            {
                if (GUILayout.Button("设置字体图集"))
                {
                    var fontPath = AssetDatabase.GetAssetPath(sourceFont);
                    var objs = AssetDatabase.LoadAllAssetsAtPath(fontPath);
                    var pngName = "";
                    foreach (var obj in objs)
                    {
                        if (obj is Texture2D text)
                        {
                            pngName = text.name;
                        }
                    }
                    if (string.IsNullOrEmpty(pngName) == false)
                    {
                        var path = fontPath.Replace("Assets", Application.dataPath);
                        Debug.Log(pngName);
                        var text = File.ReadAllText(path);
                        File.WriteAllText(path, text.Replace(pngName, ToAssetTextureNameObj.name+ " Atlas"));

                        AssetDatabase.Refresh();

                    }
                }
            }
            
            fontPoint = EditorGUILayout.BeginScrollView(fontPoint);
            if (FontLists == null)
            {
                FontLists = new ReorderableList(fontList, typeof(TMP_FontAsset), true, true, true, true);
                FontLists.drawHeaderCallback = DrawHeader;
                FontLists.drawElementCallback = (rect, index, isActive, isFocused) =>
                {
                    fontList[index] = EditorGUI.ObjectField(new Rect(rect.x, rect.y, rect.width, EditorGUIUtility.singleLineHeight), GUIContent.none, fontList[index], typeof(TMP_FontAsset), false) as TMP_FontAsset;
                };
                FontLists.onAddCallback = (ReorderableList list) =>
                {
                    fontList.Add(null);
                };

                FontLists.onRemoveCallback = (ReorderableList list) =>
                {
                    fontList.RemoveAt(list.index);
                }; 
            }
            FontLists.DoLayoutList();
            EditorGUILayout.EndScrollView();
            if (sourceFont != null && fontList.Count > 0)
            {
                if (GUILayout.Button("字体替换"))
                {
                    foreach (var font in fontList)
                    {
                        ReplaceFontData(sourceFont, font);
                    }
                }
                if(GUILayout.Button("打包资源"))
                {
                    ObjeceLists.Clear();
                    foreach(var font in fontList)
                    {
                        ObjeceLists.Add(font);
                    }
                    MeshToAssetButions(ObjeceLists,null);
                }
            }

            EditorGUILayout.Space(5);
            if(GUILayout.Button("加载字体"))
            {
                var fonts = GetAllTMPFontAssets();
                foreach (TMP_FontAsset font in fonts)
                {
                    if ("UnityFontSDF" == font.name)
                    {
                        sourceFont = font;
                       
                    }
                    else
                    {
                        if(fontList.Contains(font) == false)
                        {
                            fontList.Add(font);
                        }
                    }
                }
                fontList.Remove(sourceFont);
            }
            if (GUILayout.Button("清空"))
            {
                fontList.Clear();
            }
        }
        #endregion

        #region 相同名字数据收集
        IsAssetNames = EditorGUILayout.Foldout(IsAssetNames, "[游戏相同资源处理]");
        if (IsAssetNames)
        {
            IsRoot = GUILayout.Toggle(IsRoot, "资源位置锁定根目录");
            if (GUILayout.Button("资源处理生成配置表"))
            {
                InitGameAssetConfigs();
            }
        }
        #endregion

        #region 精灵数据转换到图集
        isSpriteToTextureAtlas = EditorGUILayout.Foldout(isSpriteToTextureAtlas, "精灵数据转换到图集");
        if (isSpriteToTextureAtlas)
        {

            if (GUILayout.Button("精灵数据转换图集"))
            {
                spriteToTextDatas.Clear();
                string[] guids = AssetDatabase.FindAssets("t:Sprite");
                foreach (var guid in guids)
                {
                    string pngPath = AssetDatabase.GUIDToAssetPath(guid);
                    if (pngPath.EndsWith(".asset") == true)
                    {
                        //Debug.Log(pngPath);
                        var text = AssetDatabase.LoadAssetAtPath<Sprite>(pngPath);
                        if (text != null)
                        {
                            var spritePath = AssetDatabase.GetAssetPath(text);
                            if (spritePath.EndsWith(".asset") && text.texture != null)
                            {
                               
                                if (spriteToTextDatas.TryGetValue(text.texture, out var list) == false)
                                {
                                    list = new List<Sprite>();
                                    spriteToTextDatas.Add(text.texture, list);
                                }
                                text.name = Path.GetFileNameWithoutExtension(spritePath);
                                list.Add(text);
                            }
                        }
                    }
                }
                foreach (var data in spriteToTextDatas)
                {
                    var allTextures = data.Value;
                    var atlasPath = AssetDatabase.GetAssetPath(data.Key);
                    var atlasTexture = data.Key;
                    var spriteDatas = new SpriteMetaData[allTextures.Count];
                    TextureImporter textureImporter = AssetImporter.GetAtPath(atlasPath) as TextureImporter;
                    textureImporter.textureType = TextureImporterType.Default;
                    textureImporter.filterMode = FilterMode.Point;
                    textureImporter.textureCompression = TextureImporterCompression.Uncompressed;
                    textureImporter.SaveAndReimport();
                    AssetDatabase.ImportAsset(atlasPath, ImportAssetOptions.ForceUpdate | ImportAssetOptions.ForceSynchronousImport);
                }
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
                List<string> atlas = new List<string>();
                foreach (KeyValuePair<Texture2D, List<Sprite>> data in spriteToTextDatas)
                {
                    var allTextures = data.Value;
                    var atlasPath = AssetDatabase.GetAssetPath(data.Key);
                    var atlasTexture = data.Key;
                    var spriteDatas = new SpriteMetaData[allTextures.Count];
                    TextureImporter textureImporter = AssetImporter.GetAtPath(atlasPath) as TextureImporter;
                    textureImporter.textureType = TextureImporterType.Sprite;
                    textureImporter.filterMode = FilterMode.Point;
                    if (allTextures.Count > 1)
                    {
                        textureImporter.spriteImportMode = SpriteImportMode.Multiple;
                        atlas.Add(atlasPath);
                    }
                    else
                    {
                        textureImporter.spriteImportMode = SpriteImportMode.Single;
                    }
                    for (int i = 0; i < allTextures.Count; i++)
                    {
                        Rect packedRect = allTextures[i].rect;
                        var spName = allTextures[i].name;
                        if (spName.Contains(AssetKey))
                        {
                            spName = spName.Split(AssetKey)[0];
                        }

                        spriteDatas[i] = new SpriteMetaData()
                        {
                            name = allTextures[i].name,
                            rect = new Rect(packedRect.x, packedRect.y, packedRect.width, packedRect.height),
                            pivot = allTextures[i].pivot/ packedRect.size,
                            border = allTextures[i].border,
                            alignment = 9
                        };
                    }
                    textureImporter.spritesheet = spriteDatas;
                    textureImporter.SaveAndReimport();
                    AssetDatabase.ImportAsset(atlasPath, ImportAssetOptions.ForceUpdate | ImportAssetOptions.ForceSynchronousImport);
                }
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
                foreach (KeyValuePair<Texture2D, List<Sprite>> data in spriteToTextDatas)
                {
                    var sprites = data.Value;
                    if (sprites.Count <= 1) continue;
                    var objs = AssetDatabase.LoadAllAssetsAtPath(AssetDatabase.GetAssetPath(data.Key));
                    Dictionary<string, Sprite> oldSprite = new Dictionary<string, Sprite>();
                    for (var x = 0; x < sprites.Count; ++x)
                    {
                        oldSprite.Add(sprites[x].name, sprites[x]);
                    }
                    for (var x = 0;x < objs.Length;++x)
                    {
                        if (objs[x] is Sprite  sp)
                        {
                            if (oldSprite.TryGetValue(sp.name,out var old))
                            {
                                var pixel = sp.pivot / sp.rect.size;
                                ModifySpriteSheet(data.Key,sp.name, GetPhysicsShapeToString(old, old.pixelsPerUnit, pixel));
                            }
                        }
                    }
                }
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }
            if(GUILayout.Button("图集生成配置"))
            {
                string[] guids = AssetDatabase.FindAssets("t:Texture2D");
                foreach(var guid in guids)
                {
                    string pngPath = AssetDatabase.GUIDToAssetPath(guid);
                    if(pngPath.StartsWith("Assets"))
                    {
                        var datas = AssetDatabase.LoadAllAssetsAtPath(pngPath);
                        if (datas.Length > 2)
                        {
                            var textData = ScriptableObject.CreateInstance<TextureAtlas>();
                            textData.AddDatas(datas);
                            AssetDatabase.CreateAsset(textData, pngPath.Replace(Path.GetExtension(pngPath), ".asset"));
                        }
                    }
                }
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }
            if(GUILayout.Button("删除 精灵"))
            {
                DeleSprite();
            }
            if (GUILayout.Button("拆分子图集"))
            {
                var oterPath = Application.dataPath + "/UI/";
                if (Directory.Exists(oterPath))
                {
                    List<string> pngPaths = new List<string>();
                    LoadAllTexture(oterPath, pngPaths);
                    Dictionary<string, string> datas = new Dictionary<string, string>();
                    for (var x = 0; x < pngPaths.Count; ++x)
                    {
                        var path = pngPaths[x];
                        var name = Path.GetFileName(path);
                        if(name.Contains("-#-"))
                        {
                            name = Path.GetDirectoryName(path) + "/" + name.Split("-#-")[0];
                            if(datas.ContainsKey(name))
                            {
                                File.Delete(path);
                                File.Delete(path+".meta");
                            }
                            else
                            {
                                datas.Add(name,"");
                            }
                        }
                    }
                    List<string> newPngPath = new List<string>();
                    for (var x = 0; x < pngPaths.Count; ++x)
                    {
                        SpriteToTexture(pngPaths[x]);
                    }
                    AssetDatabase.Refresh();

                    foreach(var path in newPngPath)
                    {
                        AssetDatabase.LoadAssetAtPath<Texture2D>(path).SetTextureToSprite();
                    }
                    AssetDatabase.Refresh();
                }
            }
            if(GUILayout.Button("导入其他工程图片精灵"))
            {
                var path = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Application.dataPath)));
                var dics = Directory.GetDirectories(path);
                foreach(var dic in dics)
                {
                    var name = Path.GetFileName(dic);
                    if(Directory.Exists( dic + "/" + name + "Demo"))
                    {
                        var folderPath = dic + "/" + name + "Demo/Assets";
                        if (Directory.Exists(folderPath) == false) continue;
                        var sprite = folderPath + "/Sprite";
                        var textures = folderPath + "/Texture2D";
                        var oterPath = Application.dataPath + "/UI/";
                        if (Directory.Exists(oterPath) == false)
                        {
                            Directory.CreateDirectory(oterPath);
                        }
                        oterPath += name + "/";
                        if (Directory.Exists(oterPath))
                        {
                            Directory.Delete(oterPath, true);
                        }
                        Directory.CreateDirectory(oterPath);
                        Directory.CreateDirectory(oterPath + "Sprites");
                        Directory.CreateDirectory(oterPath + "Textures");
                        var sprites = Directory.GetFiles(sprite);
                        foreach (var spri in sprites)
                        {
                            var spName = Path.GetFileName(spri);
                            File.Copy(spri, oterPath + "/Sprites/" + spName);
                        }
                        var texturess = Directory.GetFiles(textures);
                        foreach (var spri in texturess)
                        {
                            var spName = Path.GetFileName(spri);
                            File.Copy(spri, oterPath + "/Textures/" + spName);
                        }
                        AssetDatabase.Refresh();
                    }
                }
            }
        }
        #endregion

        #region 精灵图集替换

        isTextuleYinYong = EditorGUILayout.Foldout(isTextuleYinYong, "精灵图集替换");
        if (isTextuleYinYong)
        {
            SpriteAtlas = EditorGUILayout.ObjectField(SpriteAtlas, typeof(Texture2D), true) as Texture2D;
            pointSprite = EditorGUILayout.BeginScrollView(pointSprite);
            if (SpritesLists == null)
            {
                SpritesLists = new ReorderableList(SpriteTextures, typeof(Texture2D), true, true, true, true);
                SpritesLists.drawHeaderCallback = DrawHeader;
                SpritesLists.drawElementCallback = DrawElementSprite;
                SpritesLists.onAddCallback = OnAddElementSprite;
                SpritesLists.onRemoveCallback = OnRemoveElementSprite;
            }
            SpritesLists.DoLayoutList();
            EditorGUILayout.EndScrollView();
            if (GUILayout.Button("设置所有图片可读写"))
            {
                string[] guids = AssetDatabase.FindAssets("t:Texture2D");
                foreach (string guid in guids)
                {
                    string path = AssetDatabase.GUIDToAssetPath(guid);
                    var text = AssetDatabase.LoadAssetAtPath<Texture2D>(path);
                    text.SetTextureReadable(true);
                }
            }
            if (SpriteAtlas != null && SpriteTextures.Count > 0)
            {
                if (GUILayout.Button("替换图片"))
                {
                    SpriteToTextureAtlas(SpriteAtlas, SpriteTextures);
                }
            }
            if (SpriteAtlas != null)
            {
                if (GUILayout.Button("裁剪图集"))
                {
                    var sprites = GetSprites(SpriteAtlas);
                    var path = Path.GetDirectoryName(AssetDatabase.GetAssetPath(SpriteAtlas).Replace("Assets", Application.dataPath)) + "/" + SpriteAtlas.name;
                    Debug.Log(path);
                    if (Directory.Exists(path) == false)
                    {
                        Directory.CreateDirectory(path);
                    }
                    foreach (Sprite sprite in sprites.Values)
                    {
                        if (sprite != null)
                        {
                            Texture2D texture = new Texture2D((int)sprite.rect.width, (int)sprite.rect.height);
                            var pixels = sprite.texture.GetPixels((int)sprite.rect.x, (int)sprite.rect.y, (int)sprite.rect.width, (int)sprite.rect.height);
                            texture.SetPixels(pixels);
                            texture.Apply();
                            byte[] bytes = texture.EncodeToPNG();
                            File.WriteAllBytes(path + "/" + sprite.name + ".png", bytes);
                            AssetDatabase.Refresh();
                        }
                    }

                    AssetDatabase.Refresh();
                }
            }

            EditorGUILayout.BeginHorizontal();
            if (GUILayout.Button("添加选择图片"))
            {
                var objs = Selection.objects;
                foreach (var obj in objs)
                {
                    var text = obj as Texture2D;
                    if (text != null && SpriteTextures.Contains(text) == false)
                    {
                        SpriteTextures.Add(text);
                    }
                }
            }
            if (GUILayout.Button("清除图片列表"))
            {
                SpriteTextures.Clear();
            }
            EditorGUILayout.EndHorizontal();

        }
        #endregion

        #region 像素化
        IsTexturePixel = EditorGUILayout.Foldout(IsTexturePixel, "像素化");
        if (IsTexturePixel)
        {
            if (isPixelAll == false)
            {
                point = EditorGUILayout.BeginScrollView(point);
                if (pixelLists == null)
                {
                    pixelLists = new ReorderableList(pixelTextures, typeof(Texture2D), true, true, true, true);
                    pixelLists.drawHeaderCallback = DrawHeader;
                    pixelLists.drawElementCallback = DrawElement;
                    pixelLists.onAddCallback = OnAddElement;
                    pixelLists.onRemoveCallback = OnRemoveElement;
                }
                pixelLists.DoLayoutList();
                EditorGUILayout.EndScrollView();
            }

            isPixelAll = EditorGUILayout.Toggle(isPixelAll ? "像素化所有图片" : "像素化选中图片", isPixelAll);
            ZoomPixel = EditorGUILayout.Slider("像素压缩尺寸:", ZoomPixel, 0.05f, 1f);
            minPixelSize = (int)EditorGUILayout.Slider("像素压缩尺寸:", minPixelSize, 8, 128);
            if (GUILayout.Button(isPixelAll ? "像素化所有图片" : "像素化选中图片"))
            {
                if (isPixelAll)
                {
                    string[] guids = AssetDatabase.FindAssets("t:Texture2D");
                    foreach (var guid in guids)
                    {
                        string pngPath = AssetDatabase.GUIDToAssetPath(guid);
                        var name = Path.GetFileNameWithoutExtension(pngPath);
                        if (name.Contains("SDF ") == false && name.Contains("AreaTex") == false && name.Contains("LDR") == false && CheckIfImagePathIsValid(pngPath) && pngPath.StartsWith("Packages") == false)
                        {
                            var text = AssetDatabase.LoadAssetAtPath<Texture2D>(pngPath);
                            if (text != null && pixelTextures.Contains(text) == false)
                            {
                                pixelTextures.Add(text);
                            }
                        }
                    }
                }
                var pixelPath = Application.dataPath.Replace("Assets", "") + "pixelTexture\\";
                if (Directory.Exists(pixelPath))
                {
                    Directory.Delete(pixelPath, true);
                }
                Directory.CreateDirectory(pixelPath);
                foreach (var text in pixelTextures)
                {
                    var sizeW = (int)(text.width * ZoomPixel);
                    var sizeH = (int)(text.height * ZoomPixel);
                    if (sizeW < minPixelSize)
                    {
                        sizeW = minPixelSize;
                    }
                    if (sizeH < minPixelSize)
                    {
                        sizeH = minPixelSize;
                    }
                    var pixel = ScaleTexture(text, sizeW, sizeH);
                    pixel = ScaleTexture(pixel, text.width, text.height);
                    File.WriteAllBytes(pixelPath + text.name + ".png", pixel.EncodeToPNG());
                }
                if (isPixelAll)
                {
                    pixelTextures.Clear();
                }
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }
            if (isPixelAll == false)
            {
                if (GUILayout.Button("添加选择的图片对象"))
                {
                    foreach (Object obj in Selection.objects)
                    {
                        Texture2D sprite = obj as Texture2D;
                        if (sprite != null && pixelTextures.Contains(sprite) == false)
                        {
                            pixelTextures.Add(sprite);
                        }
                    }
                }
                if (GUILayout.Button("清除选择的图片"))
                {
                    pixelTextures.Clear();
                }
            }
        }
        #endregion

        #region 源码导出
        IsClassToWorld = EditorGUILayout.Foldout(IsClassToWorld, "源代码导出");
        if (IsClassToWorld)
        {
            EditorGUILayout.BeginHorizontal();
            AssetDemoPath = EditorGUILayout.TextField(AssetDemoPath);
            if (GUILayout.Button("Select Asset Path"))
            {
                string folderPath = EditorUtility.OpenFolderPanel("Select Asset Path", Application.dataPath, "");
                if (!string.IsNullOrEmpty(folderPath))
                {
                    AssetDemoPath = folderPath;
                }
            }
            EditorGUILayout.EndHorizontal();
            if (GUILayout.Button("导出源代码"))
            {
                classPathLists.Clear();
                LoadAllClass(AssetDemoPath);
            }
        }
        #endregion

        #region 资源打包
        isMesh = EditorGUILayout.Foldout(isMesh, "资源导出");
        if (isMesh)
        {
            pointMesh = EditorGUILayout.BeginScrollView(pointMesh);
            if (meshsLists == null)
            {
                meshsLists = new ReorderableList(meshList, typeof(Texture2D), true, true, true, true);
                meshsLists.drawHeaderCallback = DrawHeader;
                meshsLists.drawElementCallback = (rect, index, isActive, isFocused) =>
                {
                    meshList[index] = EditorGUI.ObjectField(new Rect(rect.x, rect.y,rect.width, EditorGUIUtility.singleLineHeight), GUIContent.none, meshList[index], typeof(Mesh), false) as Mesh;
                };
                meshsLists.onAddCallback = (ReorderableList list) =>
                {
                    meshList.Add(null);
                };
                
                meshsLists.onRemoveCallback = (ReorderableList list) =>
                {
                    meshList.RemoveAt(list.index);
                };
            }
            meshsLists.DoLayoutList();
            if (objsLists == null)
            {
                objsLists = new ReorderableList(ObjeceLists, typeof(Texture2D), true, true, true, true);
                objsLists.drawHeaderCallback = DrawHeader;
                objsLists.drawElementCallback = (rect, index, isActive, isFocused) =>
                {
                    ObjeceLists[index] = EditorGUI.ObjectField(new Rect(rect.x, rect.y, rect.width, EditorGUIUtility.singleLineHeight), GUIContent.none, ObjeceLists[index], typeof(Object), false) as Object;
                };
                objsLists.onAddCallback = (ReorderableList list) =>
                {
                    ObjeceLists.Add(null);
                };
                objsLists.onRemoveCallback = (ReorderableList list) =>
                {
                    ObjeceLists.RemoveAt(list.index);
                };
            }
            objsLists.DoLayoutList();
            EditorGUILayout.EndScrollView();
            if (GUILayout.Button("打包导出"))
            {
                MeshToAssetButions(ObjeceLists,meshList);
            }
            if (GUILayout.Button("添加选择Mesh"))
            {
                var objs = Selection.objects;
                foreach (var obj in objs)
                {
                    var mesh = obj as Mesh;
                    if (mesh != null && meshList.Contains(mesh) == false)
                    {
                        meshList.Add(mesh);
                    }
                    if (obj as Font || obj is AudioClip || obj is ScriptableObject || obj is Texture2D)
                    {
                        ObjeceLists.Add(obj);
                    }
                }
            }
            if (GUILayout.Button("清除Mesh列表"))
            {
                meshList.Clear();
            }
        }
        #endregion
    }
    private static string AssetKey = "-#-";
    #region Mesh打包
    private bool isMesh;
    private Vector2 pointMesh;
    private ReorderableList meshsLists;
    private ReorderableList objsLists;
    private List<Mesh> meshList = new List<Mesh>();
    private List<Object> ObjeceLists = new();
    private void MeshToAssetButions(List<Object> objList,List<Mesh> list1)
    {
        string outputPath = "Assets/AssetBundles/Android";
        if ((list1 == null || list1.Count == 0) && (objList == null || objList.Count == 0)) return;
        // 清理旧的AssetBundle
        if (System.IO.Directory.Exists(outputPath))
        {
            System.IO.Directory.Delete(outputPath, true);
        }
        System.IO.Directory.CreateDirectory(outputPath);
        List<AssetBundleBuild> buildMap = new List<AssetBundleBuild>();
        AssetBundleBuild build = new AssetBundleBuild();
        var meshAssetsPaths = new List<string>();
        var assetMesh = Application.dataPath + "/NewMesh";
        var newMeshPath = "Assets/NewMesh/";
        if (Directory.Exists(assetMesh))
        {
            Directory.Delete(assetMesh, true);
        }
        Directory.CreateDirectory(assetMesh);
        // 遍历所有选中的对象
        if(list1!=null)
        {
            for (var i = 0; i < list1.Count; ++i)
            {
                var mesh = list1[i];
                string meshName = mesh.name;
                string assetPath = AssetDatabase.GetAssetPath(mesh);
                if (Path.GetExtension(assetPath) != ".asset")
                {
                    var newMesh = GameObject.Instantiate(mesh);
                    newMesh.name = mesh.name;
                    assetPath = newMeshPath + newMesh.name + ".asset";
                    AssetDatabase.CreateAsset(newMesh, assetPath);
                }
                //string bundlePath = $"{outputPath}/{meshName}.assetbundle";
                if (meshAssetsPaths.Contains(assetPath) == false)
                    meshAssetsPaths.Add(assetPath);
            }
        }
        if(objList != null )
        {
            for (var i = 0; i < objList.Count; ++i)
            {
                var mesh = objList[i];
                string meshName = mesh.name;
                string assetPath = AssetDatabase.GetAssetPath(mesh);

                //string bundlePath = $"{outputPath}/{meshName}.assetbundle";
                if (meshAssetsPaths.Contains(assetPath) == false)
                    meshAssetsPaths.Add(assetPath);
            }
        }
        
        AssetDatabase.Refresh();
        build.assetNames = meshAssetsPaths.ToArray();
        build.assetBundleName = "MeshAssetsData.meshData";
        build.assetBundleVariant = "";
        buildMap.Add(build);
        BuildPipeline.BuildAssetBundles(outputPath, buildMap.ToArray(), BuildAssetBundleOptions.UncompressedAssetBundle, BuildTarget.Android);
        foreach(var assetName in assetBundelNames)
        {
            var path = Application.dataPath+"/" + assetName;
            if(Directory.Exists(path))
            {
                var filePath = path + "/" + assetName + ".json";
                var newPath = Application.dataPath + "\\AssetBundles\\Android\\" + assetName + ".json";
                if (File.Exists(filePath) && File.Exists(newPath) == false)
                {
                    File.Copy(filePath, newPath);
                }    
            }
        }
    }
    #endregion
    #region 源码导出
    private bool IsClassToWorld = false;
    private List<string> classPathLists = new();
    private void LoadAllClass(string path)
    {
        var dirs = Directory.GetDirectories(path);
        var files = Directory.GetFiles(path, ".cs");
        classPathLists.AddRange(files);
        foreach (var dir in dirs)
        {
            LoadAllClass(dir);
        }
    }
    public static string ReadAndCleanText(string filePath)
    {
        string[] inputLines = File.ReadAllLines(filePath);
        var sb = new System.Text.StringBuilder();
        foreach (string line in inputLines)
        {
            if (!string.IsNullOrWhiteSpace(line))
            {
                sb.AppendLine(line);
            }
        }
        return sb.ToString();
    }

    #endregion
    #region 相同名字数据收集
    private bool IsAssetNames = false;
    private bool IsRoot = false;
    private string[] assetBundelNames = new string[] { "Mesh" , "AudioClip", "Font" , "MonoBehaviour" , "TextAsset", "Texture2D" };

    private void InitGameAssetConfigs()
    {
        foreach(var assetName in assetBundelNames)
        {
            InitAssetDatas(assetName);
        }
        //InitAssetDatas("Mesh");
        //InitAssetDatas("AudioClip");
        //InitAssetDatas("Font");
        //InitAssetDatas("MonoBehaviour");
        //InitAssetDatas("TextAsset");
        //InitAssetDatas("Texture2D");
        AssetDatabase.Refresh();
    }
    private Dictionary<string, List<string>> assetDics = new Dictionary<string, List<string>>();
    private void InitAssetDatas(string AssetName)
    {
        string[] meshs = AssetDatabase.FindAssets("t:" + AssetName);

        assetDics.Clear();
        foreach (var guid in meshs)
        {
            string meshPath = AssetDatabase.GUIDToAssetPath(guid);
            if (meshPath.StartsWith("Assets"))
            {
                meshPath = Application.dataPath.Replace("Assets", meshPath);
                var name = Path.GetFileName(meshPath);
                var dirName = Path.GetFileName(Path.GetDirectoryName(meshPath));
                if (IsRoot && dirName != AssetName)
                {
                    continue;
                }
                if (name.Contains(AssetKey))
                {
                    name = name.Split(AssetKey)[0];
                }
                if (assetDics.TryGetValue(name, out var list) == false)
                {
                    list = new List<string>();
                    assetDics.Add(name, list);
                }
                list.Add(meshPath);
            }
        }
        Dictionary<string, Dictionary<string, List<string>>> assetBundles = new Dictionary<string, Dictionary<string, List<string>>>();
        foreach (var asset in assetDics)
        {
            if (asset.Value.Count >= 1)
            {
                AssetItem item = new AssetItem();
                foreach (var path in asset.Value)
                {
                    var name = Path.GetFileNameWithoutExtension(path);
                    var key = "";
                    if (name.Contains(AssetKey))
                    {
                        var data = name.Split(AssetKey);
                        name = data[0];
                        key = data[1];
                    }
                    item.assetName = name;
                    var md5 = GetMD5(path);
                    if (assetBundles.TryGetValue(name, out var list) == false)
                    {
                        list = new Dictionary<string, List<string>>();
                        assetBundles.Add(name, list);
                    }
                    if (list.TryGetValue(md5, out var dic) == false)
                    {
                        dic = new List<string>();
                        list.Add(md5, dic);
                    }
                    dic.Add(path);

                }
            }
        }
        if (assetBundles.Count > 0)
        {
            var assetConfigs = new AssetDatas(AssetName);
            foreach (var asset in assetBundles)
            {
                assetConfigs.AddAsset(asset.Key, asset.Value);
            }
            File.WriteAllText(assetConfigs.AssetPath + "/"+AssetName+".json", JsonUtility.ToJson(assetConfigs));
        }
    }
    [System.Serializable]
    private class AssetItem
    {
        public string assetName;
        public List<string> assetBundleName = new List<string>();
        public void AddAsset(int id, string key)
        {
            assetBundleName.Add(id + AssetKey + key);
        }
        public AssetItem(string assetName)
        {
            this.assetName = assetName;
        }
        public AssetItem() { }
    }
    [System.Serializable]
    private class AssetDatas
    {
        public string classType;
        public List<AssetItem> assetItems = new List<AssetItem>();
        public string AssetPath
        {
            get
            {
                return Application.dataPath + "/" + classType;
            }
        }
        public void AddAsset(string name, Dictionary<string, List<string>> assetDics)
        {
            var path = Application.dataPath + "/" + classType;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            if (assetDics.Count >= 1)
            {
                var item = new AssetItem(name);
                var namePath = path + "/" + name;


                var idx = 1;
                var id = -1;

                foreach (var data in assetDics)
                {
                    var list = data.Value;
                    if (list.Count == 0)
                    {
                        return;
                    }

                    foreach (var d in list)
                    {
                        if (d.Contains(AssetKey) == false)
                        {
                            id = 0;
                            break;
                        }
                    }
                    if (assetDics.Count == 1)
                    {
                        foreach (var d in list)
                        {
                            var n = Path.GetFileNameWithoutExtension(d);
                            var key = "";
                            if (n.Contains(AssetKey))
                            {
                                File.Delete(d);
                                var datas = n.Split(AssetKey);
                                item.AddAsset(id, datas[1]);
                            }
                            else
                            {
                                item.AddAsset(id, "");
                            }
                        }
                        break;
                    }
                    if (Directory.Exists(namePath) == false)
                    {
                        Directory.CreateDirectory(namePath);
                    }
                    if (id == 0)
                    {
                        File.Copy(list[0], namePath + "/" + name + "-#-0" + Path.GetExtension(list[0]));
                        File.Copy(list[0] + ".meta", namePath + "/" + name + "-#-" + idx + Path.GetExtension(list[0]) + ".meta");
                        foreach (var d in list)
                        {
                            File.Delete(d);
                            var n = Path.GetFileNameWithoutExtension(d);
                            var key = "";
                            if (n.Contains(AssetKey))
                            {
                                var datas = n.Split(AssetKey);
                                item.AddAsset(id, datas[1]);
                            }
                            else
                            {
                                item.AddAsset(id, "");
                            }
                        }
                    }
                    else
                    {
                        File.Copy(list[0], namePath + "/" + name + "-#-" + idx + Path.GetExtension(list[0]));
                        File.Copy(list[0] + ".meta", namePath + "/" + name + "-#-" + idx + Path.GetExtension(list[0]) + ".meta");
                        foreach (var d in list)
                        {
                            File.Delete(d);
                            var n = Path.GetFileNameWithoutExtension(d);
                            var key = "";
                            if (n.Contains(AssetKey))
                            {
                                var datas = n.Split(AssetKey);
                                item.AddAsset(idx, datas[1]);
                            }
                            else
                            {
                                Debug.LogError("错误");
                                item.AddAsset(id, "");
                            }
                        }
                        idx++;
                    }
                }
                if (item.assetBundleName.Count > 1)
                {
                    assetItems.Add(item);
                }
            }
        }
        public AssetDatas(string classType)
        {
            this.classType = classType;
        }
        public AssetDatas() { }

    }

    private string GetMD5(string path)
    {
        return ComputeMD5Hash(File.ReadAllBytes(path));
    }
    private string ComputeMD5Hash(byte[] bytes)
    {
        using (MD5 md5 = MD5.Create())
        {
            byte[] hashBytes = md5.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }

    #endregion
    #region 精灵数据转换到图集
    private bool isSpriteToTextureAtlas;
    private Dictionary<Texture2D, List<Sprite>> spriteToTextDatas = new Dictionary<Texture2D, List<Sprite>>();
    private Dictionary<SpriteData, List<SpriteKeyInfo>> textGuidDatas = new Dictionary<SpriteData, List<SpriteKeyInfo>>();

    [MenuItem("Assets/图片转换精灵")]
    private static void AssetSpriteToTexture()
    {
        var objs = Selection.objects;
        foreach(var obj in objs)
        {
            if(obj is Texture2D text)
            {
                SpriteToTexture(AssetDatabase.GetAssetPath(text));
            }
        }
        AssetDatabase.Refresh();
    }
    private static void SpriteToTexture(string path)
    {
        //var path = pngPaths[x];
        if (File.Exists(path))
        {
            path = path.Replace(Application.dataPath, "Assets");
            var objs = AssetDatabase.LoadAllAssetsAtPath(path);
            if (objs.Length > 2)
            {
                var dicName = "";
                if (path.Contains("-#-"))
                {
                    dicName = Path.GetDirectoryName(Path.GetDirectoryName(path)) + "/" + Path.GetFileName(path).Split("-#-")[0];
                }
                else
                {
                    dicName = Path.GetDirectoryName(Path.GetDirectoryName(path)) + "/" + Path.GetFileNameWithoutExtension(path);
                }
                if (Directory.Exists(dicName))
                {
                    Directory.Delete(dicName, true);
                }
                Directory.CreateDirectory(dicName);
                dicName += "/";
                foreach (var obj in objs)
                {
                    if (obj is Sprite sp)
                    {
                        var spname = sp.name;
                        if (spname.Contains("-#-"))
                        {
                            spname = spname.Split("-#-")[0];
                        }
                        File.WriteAllBytes(dicName + spname + ".png", sp.ToTexture().EncodeToPNG());
                        //newPngPath.Add(dicName.Replace(Application.dataPath, "Assets") + spname + ".png");
                    }
                }
                File.Delete(path);
            }
        }
    }
    #region 形状数据转换
    public void ModifySpriteSheet(Texture2D texture, string spriteName, List<Vector2[]> physicsShapesToAdd)
    {
        if (physicsShapesToAdd == null|| physicsShapesToAdd.Count == 0) return;
        string assetPath = AssetDatabase.GetAssetPath(texture)+".meta";
        Debug.Log(assetPath);
        List<string> lines = new List<string>(File.ReadAllLines(assetPath));

        bool foundSprite = false;
        bool foundPhysicsShape = false;
        int insertIndex = -1; // Index to insert new physicsShape data

        // 1. Iterate through the lines to find the target sprite and insertion point
        for (int i = 0; i < lines.Count; i++)
        {
            if (lines[i].Contains("name: " + spriteName))
            {
                foundSprite = true;
                insertIndex = -1; // Reset insertIndex
                foundPhysicsShape = false;
            }

            if (foundSprite)
            {
                if (lines[i].Contains("physicsShape:"))
                {
                    foundPhysicsShape = true;
                    insertIndex = i; 
                    break; 
                }
                else if (lines[i].Contains("- serializedVersion: "))
                {
                    insertIndex = i-1;
                    break;
                }
            }
        }


        // 2. Generate the new physicsShape data
        StringBuilder newPhysicsShapeData = new StringBuilder();
        newPhysicsShapeData.AppendLine("       physicsShape:");
        foreach (Vector2[] shape in physicsShapesToAdd)
        {
            
            for (var x = 0;x <  shape.Length;++x)
            {
                point = shape[x];
                if (x == 0)
                {
                    newPhysicsShapeData.AppendLine($"       - - {{x: {point.x}, y: {point.y}}}");
                }
                else if(x == shape.Length - 1)
                {
                    newPhysicsShapeData.Append($"         - {{x: {point.x}, y: {point.y}}}");
                }
                else
                {
                    newPhysicsShapeData.AppendLine($"         - {{x: {point.x}, y: {point.y}}}");
                }
            }
        }
        //Debug.LogError(newPhysicsShapeData.ToString());
        // 3. Insert or replace the physicsShape data in the list
        if (foundSprite)
        {
            if (insertIndex != -1)
            {
                if(foundPhysicsShape)
                {
                    lines.RemoveAt(insertIndex);
                }
                //Insert new data
                lines.Insert(insertIndex, newPhysicsShapeData.ToString());
            }
        }


        // 4. Write the modified content back to the file (DANGEROUS!)
        File.WriteAllLines(assetPath, lines.ToArray());
    }
    private List<Vector2[]> GetPhysicsShapeToString(Sprite sprite,float pixelsPerUnit,Vector2 pixel)
    {
        if (sprite == null) return null;
        var idx = sprite.GetPhysicsShapeCount();
        if (idx == 0) return null;
        var pivot = sprite.pivot;
        List<Vector2[]> physicsPaths = new List<Vector2[]>();
        if (idx > 0)
        {
            var list = new List<Vector2>();
            List<Vector2[]> datas = new List<Vector2[]>();
            for (var i = 0; i < idx; ++i)
            {
                list.Clear();
                sprite.GetPhysicsShape(0, list);
                physicsPaths.Add(list.ToArray());
            }
        }
        Texture2D texture = sprite.texture;
        Rect spriteRect = sprite.rect;
        float textureWidth = texture.width;
        float textureHeight = texture.height;
        float spriteWidth = spriteRect.width/pixelsPerUnit * pixel.x;
        float spriteHeight = spriteRect.height/pixelsPerUnit * pixel.y;
        var xMin = (int)(spriteRect.width / 2f);
        var yMin = (int)(spriteRect.height / 2f);
        Vector2 spritePivot = sprite.pivot;
        for (int i = 0; i < physicsPaths.Count; i++)
        {
            Vector2[] path = physicsPaths[i];
            for (int j = 0; j < path.Length; j++)
            {
                Vector2 point = path[j];

                float x = (point.x + spriteWidth)* pixelsPerUnit;
                float y = (point.y + spriteHeight)* pixelsPerUnit;
                point.x = (int)x- xMin;
                point.y = (int)y-yMin;
                path[j] = point;
                
            }
            physicsPaths[i] = path;
        }
        return physicsPaths;
    }
    #endregion
    public class SpriteData
    {
        public string guid;
        public SpriteSheetData spriteSheet;
        public class SpriteSheetData
        {
            public int serializedVersion;
            public List<SpriteInfo> sprites = new List<SpriteInfo>();
        }
        public SpriteInfo GetSprite(string name)
        {
            foreach(var info in spriteSheet.sprites)
            {
                if(info.name == name)
                {
                    return info;
                }
            }
            return null;
        }
        public class SpriteInfo
        {
            public string name;
            public string spriteID;
            public long internalID;  // Changed to long to handle negative values
        }
    }
    [System.Serializable]
    public class SpriteKeyInfo
    {
        public string name;
        public string guid;
        public int mainObjectFileID;
        public string textGUID;
    }
    public SpriteKeyInfo ExtractKeyInfo(string textData)
    {
        SpriteKeyInfo info = new SpriteKeyInfo();

        // Regular Expressions
        Regex guidRegex = new Regex(@"guid:\s*([a-f0-9]+)");
        Regex mainObjectFileIDRegex = new Regex(@"mainObjectFileID:\s*(\d+)");

        // Extract GUID
        Match guidMatch = guidRegex.Match(textData);
        if (guidMatch.Success)
        {
            info.guid = guidMatch.Groups[1].Value;
        }
        else
        {
            Debug.LogWarning("GUID not found.");
            return null; // Or handle the error as needed
        }

        // Extract MainObjectFileID
        Match mainObjectFileIDMatch = mainObjectFileIDRegex.Match(textData);
        if (mainObjectFileIDMatch.Success)
        {
            info.mainObjectFileID = int.Parse(mainObjectFileIDMatch.Groups[1].Value);
        }
        else
        {
            Debug.LogWarning("Main Object File ID not found.");
            return null; // Or handle the error as needed
        }
        //Debug.LogError(info.guid + "  " + info.mainObjectFileID);
        return info;
    }
    public void DeleSprite()
    {
        spriteToTextDatas.Clear();
        string[] guids = AssetDatabase.FindAssets("t:Sprite");
        foreach (var guid in guids)
        {
            string pngPath = AssetDatabase.GUIDToAssetPath(guid);
            if (pngPath.EndsWith(".asset") == true)
            {
               
                var text = AssetDatabase.LoadAssetAtPath<Sprite>(pngPath);
                if (text != null)
                {
                    var spritePath = AssetDatabase.GetAssetPath(text);
                    if (spritePath.EndsWith(".asset") && text.texture != null)
                    {
                        if (spriteToTextDatas.TryGetValue(text.texture, out var list) == false)
                        {
                            list = new List<Sprite>();
                            spriteToTextDatas.Add(text.texture, list);
                        }
                        text.name = Path.GetFileNameWithoutExtension(spritePath);
                        list.Add(text);
                    }
                }
            }
        }
        textGuidDatas.Clear();
        foreach (KeyValuePair<Texture2D, List<Sprite>> data in spriteToTextDatas)
        {
            var text = TextureToSpriteData(data.Key);
            var list = new List<SpriteKeyInfo>();
            foreach (var spri in data.Value)
            {
                list.Add(SpriteToSpriteData(spri));
            }
            textGuidDatas.Add(text, list);
            //break;
        }
        string[] prefabs = AssetDatabase.FindAssets("t:Prefab");
        string[] scripts = AssetDatabase.FindAssets("t:ScriptableObject");
        
        List<string> guidPaths = new List<string>();
        guidPaths.AddRange(prefabs);
        guidPaths.AddRange(scripts);

        List<string> prefabDatas = new();
        foreach (var guid in prefabs)
        {
            string pngPath = AssetDatabase.GUIDToAssetPath(guid);
            prefabDatas.Add( File.ReadAllText(pngPath));
        }
        foreach (var guid in scripts)
        {
            string pngPath = AssetDatabase.GUIDToAssetPath(guid);
            prefabDatas.Add(File.ReadAllText(pngPath));
        }
        foreach (var data in textGuidDatas)
        {
            SpriteData text = data.Key;
            if(data.Value.Count == 1)
            {
                foreach(var info in data.Value)
                {
                    for(var x =0;x< prefabDatas.Count;++x)
                    {
                        if(prefabDatas[x].Contains(info.guid))
                        {
                            var infoData = text.GetSprite(info.name);
                            if(infoData != null)
                            {
                                if (prefabDatas[x].Contains(info.guid + ", type: 2"))
                                {
                                    prefabDatas[x] = prefabDatas[x].Replace(info.guid + ", type: 2", text.guid + ", type: 3");
                                }
                                else if (prefabDatas[x].Contains(info.guid + ", type: 3"))
                                {
                                    prefabDatas[x] = prefabDatas[x].Replace(info.guid + ", type: 3", text.guid + ", type: 3");
                                }
                            }
                            else
                            {
                                Debug.LogError(info.name);
                            }
                            //Debug.LogError(AssetDatabase.GUIDToAssetPath(prefabs[x]),AssetDatabase.LoadAssetAtPath<GameObject>(AssetDatabase.GUIDToAssetPath(prefabs[x])));
                        }
                    }
                }
            }
            else
            {
                //Debug.LogError("==================" + text.guid);
                foreach (var info in data.Value)
                {
                    var infoData = text.GetSprite(info.name);
                    if (infoData != null)
                    {
                        for (var x = 0; x < prefabDatas.Count; ++x)
                        {
                            if (prefabDatas[x].Contains(info.guid))
                            {
                                if (prefabDatas[x].Contains(info.mainObjectFileID + ", guid: " + info.guid + ", type: 2"))
                                {
                                    prefabDatas[x] = prefabDatas[x].Replace(info.mainObjectFileID + ", guid: " + info.guid + ", type: 2", infoData.internalID + ", guid: " + text.guid + ", type: 3");
                                }
                                else if (prefabDatas[x].Contains(info.mainObjectFileID + ", guid: " + info.guid + ", type: 3"))
                                {
                                    prefabDatas[x] = prefabDatas[x].Replace(info.mainObjectFileID + ", guid: " + info.guid + ", type: 3", infoData.internalID + ", guid: " + text.guid + ", type: 3");
                                }
                                else
                                {
                                    Debug.LogError(AssetDatabase.GUIDToAssetPath(guidPaths[x]), AssetDatabase.LoadAssetAtPath<GameObject>(AssetDatabase.GUIDToAssetPath(guidPaths[x])));
                                }
                            }
                        }
                    }
                    else
                    {
                        Debug.LogError(info.name);
                    }

                }
            }
        }
        for (var x = 0; x < prefabDatas.Count; ++x)
        {
            string pngPath = AssetDatabase.GUIDToAssetPath(guidPaths[x]);
            File.WriteAllText(pngPath, prefabDatas[x]);
        }
        AssetDatabase.Refresh();
        foreach (var guid in guids)
        {
            string pngPath = AssetDatabase.GUIDToAssetPath(guid);
            if (pngPath.EndsWith(".asset") == true)
            {
                File.Delete(pngPath);
            }
        }
        AssetDatabase.Refresh();
    }
    public void LoadAllTexture(string path,List<string> textPaths)
    {
        var dics = Directory.GetDirectories(path);
        foreach (var dic in dics)
        {
            LoadAllTexture(dic, textPaths);
        }
        var files = Directory.GetFiles(path ,"*.png");
        textPaths.AddRange(files);
    }
    public SpriteKeyInfo SpriteToSpriteData(Sprite text)
    {
        var path = AssetDatabase.GetAssetPath(text);
        var name = Path.GetFileNameWithoutExtension(path);
        SpriteKeyInfo info = ExtractKeyInfo(File.ReadAllText(path + ".meta"));
        info.name = name;
        return info;
    }
    public SpriteData TextureToSpriteData(Texture2D text)
    {
        var path = AssetDatabase.GetAssetPath(text)+".meta";
        return ExtractData(File.ReadAllText(path));
    }
    public SpriteData ExtractData(string textData)
    {
        SpriteData data = new SpriteData();
        data.spriteSheet = new SpriteData.SpriteSheetData();

        // Regular Expressions
        Regex guidRegex = new Regex(@"guid:\s*([a-f0-9]+)");
        Regex spriteSheetSerializedVersionRegex = new Regex(@"spriteSheet:\s*serializedVersion:\s*(\d+)");
        Regex spriteSerializedVersionRegex = new Regex(@"sprites:\s*serializedVersion:\s*(\d+)");
        Regex spriteRegex = new Regex(
            @"serializedVersion:\s*2\s*" +
            @"name:\s*(?<name>[^\r\n]+)\s*" +
            @"(?:rect:\s*[\s\S]*?)?" +  // Non-greedy match for rect and its contents
            @"spriteID:\s*(?<spriteID>[a-f0-9]+)\s*" +
            @"internalID:\s*(?<internalID>-?\d+)", //Use named groups
            RegexOptions.Compiled);

        // Extract GUID
        Match guidMatch = guidRegex.Match(textData);
        if (guidMatch.Success)
        {
            data.guid = guidMatch.Groups[1].Value;
        }
        else
        {
            Debug.LogWarning("GUID not found.");
        }
        //Debug.LogError(data.guid);

        // Extract SpriteSheet SerializedVersion
        Match spriteSheetSerializedVersionMatch = spriteSheetSerializedVersionRegex.Match(textData);
        if (spriteSheetSerializedVersionMatch.Success)
        {
            data.spriteSheet.serializedVersion = int.Parse(spriteSheetSerializedVersionMatch.Groups[1].Value);
        }
        else
        {
            Debug.LogWarning("SpriteSheet SerializedVersion not found.");
        }


        // Extract Sprite Data
        MatchCollection spriteMatches = spriteRegex.Matches(textData);
        foreach (Match match in spriteMatches)
        {
            if (match.Success)
            {
                SpriteData.SpriteInfo spriteInfo = new SpriteData.SpriteInfo();
                spriteInfo.name = match.Groups["name"].Value.Trim();  //access named group 'name'
                spriteInfo.spriteID = match.Groups["spriteID"].Value; //access named group 'spriteID'
                spriteInfo.internalID = long.Parse(match.Groups["internalID"].Value); //access named group 'internalID'
                data.spriteSheet.sprites.Add(spriteInfo);
                //Debug.Log(spriteInfo.name+"  "+ spriteInfo.internalID);
            }
        }

        return data;
    }
    #endregion

    #region 精灵图集替换


    private bool isTextuleYinYong;
    private Vector2 pointSprite;
    private ReorderableList SpritesLists;
    private List<Texture2D> SpriteTextures = new();
    private Dictionary<string, Texture2D> textDics = new Dictionary<string, Texture2D>();
    private Texture2D SpriteAtlas;
    private Dictionary<string, Sprite> spriteDatas = new Dictionary<string, Sprite>();
    private Dictionary<Sprite, Texture2D> spriteToTextureDics = new Dictionary<Sprite, Texture2D>();
    private void SpriteToTextureAtlas(Texture2D texture, List<Texture2D> texts)
    {
        SetTextureReadable(texture);
        var sprites = GetSprites(texture);
        var dics = GetTextureToSprite(texts);
        spriteToTextureDics.Clear();
        foreach (var data in dics)
        {
            if (sprites.TryGetValue(data.Key, out var sprite))
            {
                spriteToTextureDics.Add(sprite, data.Value);
            }
        }
        foreach (var data in spriteToTextureDics)
        {
            texture.SpriteToTexture(data.Key, data.Value);
        }
        texture.Save();
    }
    public static string ExtractPhysicsShape(string path)
    {
        var yamlContent = File.ReadAllText(path);
        // 正则表达式匹配 m_PhysicsShape 块
        string pattern = @"m_PhysicsShape:\s*(-.*?(?=\nm_\w+:\s))"; // 使用 lazy quantifier 和 lookahead assertion
        Regex regex = new Regex(pattern, RegexOptions.Singleline); // Singleline 模式匹配多行文本
        Match match = regex.Match(yamlContent);

        if (match.Success)
        {
            return match.Value; // 返回整个匹配到的字符串，包括 "m_PhysicsShape:"
        }
        else
        {
            return null; // 未找到匹配项时返回 null
        }
    }
    private Dictionary<string, Texture2D> GetTextureToSprite(List<Texture2D> texts)
    {
        textDics.Clear();
        foreach (var text in texts)
        {
            if (text != null && textDics.ContainsKey(text.name) == false)
            {
                textDics.Add(text.name, text);
            }
        }
        return textDics;
    }
    private void SetTextureReadable(Texture text)
    {
        if (text.isReadable == false)
        {
            var path1 = AssetDatabase.GetAssetPath(text);
            TextureImporter textureImporter = AssetImporter.GetAtPath(path1) as TextureImporter;
            textureImporter.isReadable = true;
            textureImporter.textureCompression = TextureImporterCompression.Uncompressed;
            textureImporter.SaveAndReimport();
            AssetDatabase.ImportAsset(path1, ImportAssetOptions.ForceUpdate | ImportAssetOptions.ForceSynchronousImport);
            AssetDatabase.Refresh();
        }
    }
    private Dictionary<string, Sprite> GetSprites(Texture2D text)
    {
        spriteDatas.Clear();
        SetTextureReadable(text);
        var path = AssetDatabase.GetAssetPath(text);
        var objs = AssetDatabase.LoadAllAssetsAtPath(path);
        foreach (var obj in objs)
        {
            var sprite = obj as Sprite;
            if (sprite != null)
            {
                spriteDatas.Add(sprite.name, sprite);
            }
        }
        return spriteDatas;
    }
    private Color[] GetPixels(Texture2D source)
    {
        SetTextureReadable(source);
        return source.GetPixels();
    }
    #endregion
    #region 像素化  
    private bool IsTexturePixel = false;
    private float ZoomPixel = 0.1f;
    private int minPixelSize = 20;
    private bool isPixelAll = false;
    private Vector2 point;
    private ReorderableList pixelLists;
    private List<Texture2D> pixelTextures = new();
    private void DrawHeader(Rect rect)
    {
        EditorGUI.LabelField(rect, "Textures");
    }
    private void DrawElement(Rect rect, int index, bool isActive, bool isFocused)
    {
        pixelTextures[index] = EditorGUI.ObjectField(new Rect(rect.x, rect.y, rect.width, EditorGUIUtility.singleLineHeight), GUIContent.none, pixelTextures[index], typeof(Texture2D), false) as Texture2D;
    }
    private void OnAddElement(ReorderableList list)
    {
        pixelTextures.Add(null);
    }
    private void OnRemoveElement(ReorderableList list)
    {
        pixelTextures.RemoveAt(list.index);
    }
    private void OnAddElementSprite(ReorderableList list)
    {
        SpriteTextures.Add(null);
    }
    private void OnRemoveElementSprite(ReorderableList list)
    {
        SpriteTextures.RemoveAt(list.index);
    }
    private void DrawElementSprite(Rect rect, int index, bool isActive, bool isFocused)
    {
        SpriteTextures[index] = EditorGUI.ObjectField(new Rect(rect.x, rect.y, rect.width, EditorGUIUtility.singleLineHeight), GUIContent.none, SpriteTextures[index], typeof(Texture2D), false) as Texture2D;
    }
    bool CheckIfImagePathIsValid(string path)
    {
        string extension = System.IO.Path.GetExtension(path).ToLower();

        switch (extension)
        {
            case ".jpg":
            case ".jpeg":
            case ".png":
            case ".bmp":
            case ".tga":
            case ".tif":
                return true;

        }
        return false;
    }
    Texture2D ScaleTexture(Texture2D source, int targetWidth, int targetHeight)
    {
        if (source.isReadable == false)
        {
            var path = AssetDatabase.GetAssetPath(source);
            TextureImporter textureImporter = AssetImporter.GetAtPath(path) as TextureImporter;
            textureImporter.textureType = TextureImporterType.Sprite;
            textureImporter.filterMode = FilterMode.Point;
            textureImporter.isReadable = true;
            textureImporter.SaveAndReimport();
            AssetDatabase.ImportAsset(path, ImportAssetOptions.ForceUpdate | ImportAssetOptions.ForceSynchronousImport);
            AssetDatabase.Refresh();
        }


        Texture2D result = new Texture2D(targetWidth, targetHeight, TextureFormat.ARGB32, false);
        Color[] rpixels = result.GetPixels();
        float incX = ((float)source.width) / targetWidth;
        float incY = ((float)source.height) / targetHeight;
        var sourceText = source.GetPixels();
        for (int px = 0; px < targetWidth; ++px)
        {
            for (int py = 0; py < targetHeight; ++py)
            {
                rpixels[py * targetWidth + px] = NearestNeighborInterpolation(sourceText, source, px * incX, py * incY);
            }
        }

        result.SetPixels(rpixels);
        result.Apply();
        //File.WriteAllBytes(AssetDatabase.GetAssetPath(source), result.EncodeToPNG());
        return result;
    }
    Color NearestNeighborInterpolation(Color[] color, Texture2D texture, float x, float y)
    {
        int x1 = Mathf.RoundToInt(x);
        int y1 = Mathf.RoundToInt(y);

        if (x1 >= texture.width)
            x1 = texture.width - 1;
        if (y1 >= texture.height)
            y1 = texture.height - 1;

        return color[x1 + y1 * texture.width];
    }
    #endregion
    #region 脚本优化删除无用脚本
    private bool isInitDLL = false;
    private List<ClassGUIDDatas> guidLists = new List<ClassGUIDDatas>();
    private ReorderableList guidReordLists;
    private Vector2 guidPoint;
    private string AssetDemoPath = "";
    private void ScriptsToDlls(string path, string dllPath)
    {
        if (Directory.Exists(dllPath))
        {
            Directory.Delete(dllPath, true);
        }
        Directory.CreateDirectory(dllPath);
        var plugins = AssetDemoPath + "/Assets/Plugins/";
        var dires = Directory.GetDirectories(path);
        if (Directory.Exists(plugins) == false)
                    {
                        Directory.CreateDirectory(plugins);
                    }
        foreach (var dirPath in dires)
        {
            var name = Path.GetFileName(dirPath);
            if (name.Contains("Assembly-CSharp") == false)
            {
                Debug.LogError(name);
                Directory.Move(dirPath, dllPath + name);
            }
            else if (name.Contains("Newtonsoft.Json"))
            {
                if(File.Exists(plugins + name + ".dll") == false)
                {
                    
                    
                    //Directory.Move(dirPath, dllPath + "/Plugins/" + name);
                    var newPath = Path.GetDirectoryName(AssetDemoPath) + "\\AuxiliaryFiles\\GameAssemblies\\Newtonsoft.Json.dll";
                    File.Copy(newPath, plugins + name + ".dll");
                }
               
                if (Directory.Exists(dirPath))
                {
                    Directory.Delete(dirPath, true);
                }
            }
        }
        var dllFile = Directory.GetFiles(plugins, "*.dll");
        foreach (var file in dllFile)
        {
            var name = Path.GetFileName(file);
            if (IsUnityDll(name))
            {
                Debug.LogError(name);
                Directory.Move(file, dllPath + name);
            }
        }
        var dllSOPath =  Path.GetDirectoryName(AssetDemoPath) + "\\AuxiliaryFiles\\GameAssemblies";
        var soDllFiles = Directory.GetFiles(dllSOPath, "*.dll");
        foreach(var so in soDllFiles)
        {
            var name = Path.GetFileName(so);
            if (IsUnityDll(name) == false)
            {
                if (File.Exists(plugins + name) == false)
                {
                    Debug.LogError(name);
                    Directory.Move(so, plugins + name);
                }
            }
        }
    }
    private bool IsUnityDll(string name)
    {
        if (name.Contains("Unity.Notifications.Android") == false && (name.StartsWith("Unity.") || name.ToLower() == "cinemachine" || name.Contains("UnityEngine")) || name.Contains("System") || name.Contains("Assembly-CSharp"))
        {
            return true;
        }
        return false;
    }
    private void PluginsToScripts(string path, string scriptPath)
    {
        if (Directory.Exists(path) == false) return;
        var dires = Directory.GetDirectories(path);
        foreach (var dirPath in dires)
        {
            var name = Path.GetFileName(dirPath);
            Directory.Move(dirPath, scriptPath + name);
        }
    }
    private void ScriptsDelectErrorScripts(string path, bool isFalse = false)
    {
        var dires = Directory.GetDirectories(path);
        foreach (var dirPath in dires)
        {
            if (isFalse)
            {
                if (Directory.Exists(dirPath + "\\Properties"))
                {
                    Directory.Delete(dirPath + "\\Properties", true);
                }
                var asmdef = Directory.GetFiles(dirPath, "*.asmdef");
                foreach (var asmdefPath in asmdef)
                {
                    File.Delete(asmdefPath);
                }
                var cls = Directory.GetFiles(dirPath, "*_v1.cs");
                foreach (var asmdefPath in cls)
                {
                    File.Delete(asmdefPath);
                }
            }
            var newClass = Directory.GetFiles(dirPath, "*`1.cs");
            foreach (var asmdefPath in newClass)
            {
                File.Delete(asmdefPath);
            }
            ScriptsDelectErrorScripts(dirPath);
        }
    }
    #endregion
    #region Dll 引用修复
    [System.Serializable]
    public class ClassGUIDDatas
    {
        public string Name;
        public string oldGuid;
        public string NewGuid;
        public float Height = 24;
        public ClassGUIDDatas(string name, string guid)
        {
            Name = name;
            oldGuid = guid;
        }
       
        public override string ToString()
        {
            return Name + ": OldGUID:" + oldGuid + " - NewGuid:" + NewGuid;
        }
    }
    private Dictionary<string, ClassGUIDDatas> csNames = new Dictionary<string, ClassGUIDDatas>();
    private Dictionary<string, ClassGUIDDatas> guidDatas = new Dictionary<string, ClassGUIDDatas>();
    private bool IsCopyPackages = true;
    private bool IsClassDll = false;
    private bool IsClassDelect = false;
    private static void GetAllAssetPaths(List<string> list,string path,string end)
    {
        var files = Directory.GetFiles(path, end);
        list.AddRange(files);
        var dirs = Directory.GetDirectories(path);
        foreach(var dir in dirs)
        {
            GetAllAssetPaths(list, dir, end);
        }
    }
    void GetFontAssetsName(string path)
    {
        var dir = Directory.GetDirectories(path);
        foreach (var dir2 in dir)
        {
            GetFontAssetsName(dir2);
        }
        Debug.LogError("----------------TMP Font----------------");
        //if (path.Contains("font"))
        {
            var files = Directory.GetFiles(path, "*.asset");
            foreach (var file in files)
            {
                string fileContent = File.ReadAllText(file);
                if(fileContent.Contains("m_SourceFontFile"))
                {
                   var guid = ExtractGuidBetweenFields(fileContent);
                    if(guid != null && Path.GetFileNameWithoutExtension(file).Contains(guid) == false)
                    {
                        var fontPath = Path.GetDirectoryName(file);
                        File.Move(file, fontPath + Path.GetFileNameWithoutExtension(file) + "-" + guid + ".asset");
                        Debug.Log(fontPath);
                    }
                }
            }
        }
    }
    public static string ExtractGuidBetweenFields(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return null;
        }
        string startTag = "m_SourceFontFile: {";
        string endTag = "m_AtlasPopulationMode:";
        int startIndex = input.IndexOf(startTag, System.StringComparison.OrdinalIgnoreCase);

        if (startIndex == -1)
        {
            return null;
        }
        int endIndex = input.IndexOf(endTag, startIndex, System.StringComparison.OrdinalIgnoreCase);
        if (endIndex == -1)
        {
            return null;
        }
        startIndex += startTag.Length; // Skip "m_SourceFontFile: {"
        string inputString = input.Substring(startIndex, endIndex - startIndex);
        string pattern = @"guid: ([0-9a-fA-F]{32})";
        Match match = Regex.Match(inputString, pattern);
        if (match.Success && match.Groups.Count > 1)
        {
            return match.Groups[1].Value;
        }
        return null;
    }
    public static void RemoveMethods(string scriptPath)
    {
        var script = Path.GetFileNameWithoutExtension(scriptPath);
        if (string.IsNullOrEmpty(scriptPath))
        {
            Debug.LogError("无法获取脚本路径。");
            return;
        }

        try
        {
            string scriptContent = File.ReadAllText(scriptPath);
            string originalContent = scriptContent;

            // 删除所有特性，除了 [Serializable] 和 [NonSerialized]
            scriptContent = RemoveAllAttributesExcept(scriptContent, new[] { "Serializable", "NonSerialized", "System.Serializable", "System.NonSerialized" });

            // 使用正则表达式匹配方法定义
            // 匹配 public, private, protected, internal (可选)
            // static, virtual, abstract, override, async (可选)
            // 返回类型 (至少一个单词字符)
            // 方法名 (至少一个单词字符)
            // 参数列表 (圆括号内的内容)
            // 方法体 (大括号内的内容，允许嵌套)
            //string methodPattern = @"(?:public|private|protected|internal)?\s*(?:static|virtual|abstract|override|async|new|implicit|operator)?\s*(?:static|virtual|abstract|override|async|new|operator|implicit)?\s*\w+\s+\w+\s*\([^)]*\)\s*\{[^}]*\}";
            string methodPattern = @"(?:public|private|protected|internal)?\s*(?:static|virtual|abstract|async)?\s*\w+\s+\w+\s*\([^)]*\)\s*\{[^}]*\}";

            // 移除匹配到的所有方法
            scriptContent = Regex.Replace(scriptContent, methodPattern, "");

            if (scriptContent != originalContent)
            {
                File.WriteAllText(scriptPath, scriptContent);
                AssetDatabase.Refresh();
                Debug.Log($"成功删除脚本 {script} 中的所有方法和指定以外的特性。");
            }
            else
            {
                Debug.Log($"脚本 {script} 中没有找到可删除的方法或需要移除的特性。");
            }
        }
        catch (FileNotFoundException)
        {
            Debug.LogError($"找不到脚本文件: {scriptPath}");
            AddErrorComment(scriptPath, "错误：找不到脚本文件。");
        }
        catch (IOException e)
        {
            Debug.LogError($"读写文件时发生错误: {e.Message}");
            AddErrorComment(scriptPath, $"错误：读写文件时发生错误 - {e.Message}");
        }
        catch (System.Exception e)
        {
            Debug.LogError($"发生未知错误: {e.Message}");
            AddErrorComment(scriptPath, $"错误：发生未知错误 - {e.Message}");
        }
    }

    private static string RemoveAllAttributesExcept(string scriptContent, string[] excludedAttributes)
    {
        // 匹配所有特性
        string attributePattern = @"^\s*\[\s*(?!(" + string.Join("|", excludedAttributes.Select(Regex.Escape)) + @"))[^\]]+\s*\]\s*$\n";

        // 使用 RegexOptions.Multiline 允许 ^ 和 $ 匹配每一行的开始和结束
        return Regex.Replace(scriptContent, attributePattern, "", RegexOptions.Multiline);
    }

    private static void AddErrorComment(string scriptPath, string errorMessage)
    {
        try
        {
            string scriptContent = File.ReadAllText(scriptPath);
            string errorComment = "// ---------- ERROR: Operation Failed ----------\n" +
                                  "// " + errorMessage + "\n" +
                                  "// ---------- ----------------------------- ----------\n";

            // 检查是否已经添加过错误注释，避免重复添加
            if (!scriptContent.Contains(errorComment.Split('\n')[1]))
            {
                File.WriteAllText(scriptPath, errorComment + scriptContent);
                AssetDatabase.Refresh();
            }
        }
        catch (System.Exception e)
        {
            Debug.LogError($"添加错误注释时发生错误: {e.Message}");
        }
    }

    public void CopyDirectory(string sourceDirName, string destDirName, bool copySubDirs = true)
    {
        // 获取源目录的目录信息
        DirectoryInfo dir = new DirectoryInfo(sourceDirName);

        // 如果目标目录不存在，则创建它
        if (!dir.Exists)
        {
            throw new DirectoryNotFoundException(
                "Source directory does not exist or could not be found: "
                + sourceDirName);
        }

        // 如果目标目录不存在，则创建它
        if (!Directory.Exists(destDirName))
        {
            Directory.CreateDirectory(destDirName);
        }

        // 获取所有文件
        FileInfo[] files = dir.GetFiles();
        foreach (FileInfo file in files)
        {
            string temppath = Path.Combine(destDirName, file.Name);
            // 检查目标文件夹中是否存在同名文件
            if (!File.Exists(temppath))
            {
                // 如果不存在，则复制文件
                file.CopyTo(temppath, false);
            }
        }
        // 如果需要复制子目录，则递归复制
        if (copySubDirs)
        {
            DirectoryInfo[] subDirs = dir.GetDirectories();
            foreach (DirectoryInfo subdir in subDirs)
            {
                string temppath = Path.Combine(destDirName, subdir.Name);
                CopyDirectory(subdir.FullName, temppath, copySubDirs);
            }
        }
    }
    private Dictionary<string, string> DllPaths = new Dictionary<string, string>();
    private void LoadAllDll()
    {
        var path = Path.GetDirectoryName(Path.GetDirectoryName(Application.dataPath)) + "\\Dlls";
        var dirs = Directory.GetDirectories(path);
        Dictionary<string, string> dics = new Dictionary<string, string>();
        Dictionary<string, string> dicNames = new Dictionary<string, string>();
        foreach (var dir in dirs)
        {
            var name = Path.GetFileName(dir);

            if (name == "Cinemachine")
            {
                dics.Add("unity." + name.ToLower(), name);
            }
            else if (name.Contains("RenderPipelines"))
            {
                if (name.Split(".").Length == 4)
                {
                    name = Path.GetFileNameWithoutExtension(name);
                    var dirPath = Path.GetDirectoryName(dir) + "\\" + name;
                    if (Directory.Exists(dirPath) == false)
                    {
                        Directory.CreateDirectory(dirPath);
                    }
                    Debug.LogError(name);
                    CopyDirectory(dir, dirPath);
                    Directory.Delete(dir, true);
                }
                dics[name.ToLower().Replace("renderpipelines", "render-pipelines")] = name;
            }
            else
            {
                dics.Add(name.ToLower(), name);
            }
        }
        var packPath = Path.GetDirectoryName(Application.dataPath) + "\\Library\\PackageCache";
        var packs = Directory.GetDirectories(packPath);
    
        foreach (var dir in packs)
        {
            var name = Path.GetFileName(dir);
            var data = name.Split("@")[0].Replace("com.", "");
            if (dics.ContainsKey(data.ToLower()))
            {
                dicNames.Add(dics[data.ToLower()], name);
            }
        }
        DllPaths.Clear();
        foreach (var dir in dicNames)
        {
            Debug.LogError(dir.Key + "  " + dir.Value);
            DllPaths.Add(path + "\\" + dir.Key, packPath + "\\" + dir.Value);
        }
    }
    #endregion
    #region 读取场景与预设的空引用
    private bool IsObjeNull = false;
    private void LoadAllScene()
    {
        string[] guids = AssetDatabase.FindAssets("t:Scene");
        foreach (string guid in guids)
        {
            string scenePath = AssetDatabase.GUIDToAssetPath(guid);

            if (ModifySceneObjects(Path.GetFileNameWithoutExtension(scenePath)))
            {
                return;
            }
        }
    }
    private void LoadAllPrefabs()
    {
        string[] guids = AssetDatabase.FindAssets("t:Prefab");
        foreach (string guid in guids)
        {
            string prefabPath = AssetDatabase.GUIDToAssetPath(guid);
            GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>(prefabPath);
            if (prefab != null)
            {
                var tran = GetNullComponent(prefab.transform);
                if (tran != null)
                {
                    Debug.LogError(prefab.name, prefab);
                }
            }
        }
    }
    private void GetAllObjects(GameObject obj)
    {
        if (obj != null)
        {
            var objs = obj.GetComponentsInChildren<RectTransform>(true);
            for (var x = 0; x < objs.Length; ++x)
            {
                {
                    var list = objs[x].GetComponents<Component>();
                    for (var y = 0; y < list.Length; ++y)
                    {
                        if (list[y] == null)
                        {
                            Debug.LogError(objs[x].name, objs[x]);
                            break;
                        }
                    }
                }
            }
            var trans = obj.GetComponentsInChildren<Transform>(true);
            for (var x = 0; x < trans.Length; ++x)
            {
                {
                    var list = trans[x].GetComponents<Component>();
                    for (var y = 0; y < list.Length; ++y)
                    {
                        if (list[y] == null)
                        {
                            Debug.LogError(trans[x].name, trans[x]);
                            break;
                        }
                    }
                }
            }
        }
    }

    private Transform GetNullComponent(Transform trans, bool isChilder = true)
    {
        var coms = trans.GetComponents<Component>();
        foreach (var com in coms)
        {
            if (com == null)
            {
                return trans;
            }
        }
        if (isChilder)
        {
            var objs = trans.GetComponentsInChildren<Transform>(true);
            for (var y = 0; y < objs.Length; ++y)
            {
                if (GetNullComponent(objs[y], false))
                {
                    return objs[y];
                }
            }
            var rects = trans.GetComponentsInChildren<RectTransform>(true);
            for (var y = 0; y < rects.Length; ++y)
            {
                if (GetNullComponent(rects[y].transform, false))
                {
                    return objs[y];
                }
            }
        }

        return null;
    }
    bool ModifySceneObjects(string scenePath)
    {
        //string scenePath = "Assets/Scenes/"+ scene+".unity"; // Replace with your scene path
        EditorSceneManager.OpenScene(scenePath);
        var sceneName = Path.GetFileName(scenePath);
        var objs = GameObject.FindObjectsOfType<GameObject>(true);
        Debug.Log(objs.Length);
        var idx = 0;
        foreach (var obj in objs)
        {
            var tran = GetNullComponent(obj.transform);
            if (tran != null)
            {
                idx++;
                Debug.LogError(sceneName + "   Obj: ---   " + obj.name, obj);
            }
        }

        EditorSceneManager.SaveOpenScenes();
        if (idx > 0)
        {
            return true;
        }
        return false;
    }

    void ReplaceTextInFiles(string[] guids)
    {
        foreach (var guid in guids)
        {
            string filePath = AssetDatabase.GUIDToAssetPath(guid).Replace("Assets", Application.dataPath);
            string fileContent = File.ReadAllText(filePath);
            foreach (var id in guidDatas.Values)
            {
                fileContent = fileContent.Replace(id.oldGuid, id.NewGuid);
            }
            File.WriteAllText(filePath, fileContent);
        }
    }
    void GetFontAssets(string  path)
    {
        var dir = Directory.GetDirectories(path);
        foreach(var dir2 in dir)
        {
            GetFontAssets(dir2);
        }
        var files = Directory.GetFiles(path, "*.asset");
        foreach (var file in files)
        {
            string fileContent = File.ReadAllText(file);
            if(fileContent.Contains("m_SourceFontFile"))
            {
                foreach (var id in guidDatas.Values)
                {
                    fileContent = fileContent.Replace(id.oldGuid, id.NewGuid);
                }
                File.WriteAllText(file, fileContent);
            }
           
        }
    }
    void FontAssetData()
    {
        var assets = GetAllTMPFontAssets();
        foreach (var asset in assets)
        {
            var assetPath = AssetDatabase.GetAssetPath(asset);
            if (asset.atlasTextures != null)
            {
                for(var x = 0;x < asset.atlasTextures.Length;++x)
                {
                    var atlasPath = AssetDatabase.GetAssetPath(asset.atlasTextures[x]);
                    if (string.IsNullOrEmpty(atlasPath) || !atlasPath.EndsWith(",asset")) //判断是否是子资源
                    {
                        var mater = GameObject.Instantiate(asset.atlasTextures[x]);
                        mater.name = asset.atlasTextures[x].name;
                        AssetDatabase.AddObjectToAsset(mater, assetPath);
                        asset.atlasTextures[x] = mater;
                        EditorUtility.SetDirty(asset);
                    }
                }
                
            }
            if (asset.material != null)
            {
                var materialPaht = AssetDatabase.GetAssetPath(asset.material);
                if (string.IsNullOrEmpty(materialPaht) || !materialPaht.EndsWith(",asset"))//判断是否是子资源
                {
                    var mater = GameObject.Instantiate(asset.material);
                    mater.name = asset.material.name;
                    AssetDatabase.AddObjectToAsset(mater, assetPath);
                    asset.material = mater;
                    EditorUtility.SetDirty(asset);
                }
            }
        }
        AssetDatabase.SaveAssets(); //保存所有的asset资源
    
    }
    public static List<TMP_FontAsset> GetAllTMPFontAssets()
    {
        string[] guids = AssetDatabase.FindAssets("t:TMP_FontAsset");
        List<TMP_FontAsset> fontAssets = new List<TMP_FontAsset>();
        foreach (string guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            TMP_FontAsset fontAsset = AssetDatabase.LoadAssetAtPath<TMP_FontAsset>(path);
            if (fontAsset != null)
            {
                fontAssets.Add(fontAsset);
            }
        }

        return fontAssets;
    }

    void ReplaceTextInFiles(string directoryPath)
    {
        if (Directory.Exists(directoryPath) == false) return;
        string[] filePaths = Directory.GetFiles(directoryPath);
        foreach (string filePath in filePaths)
        {
            if (Path.GetExtension(filePath).ToLower() == ".meta")
                continue;

            string fileContent = File.ReadAllText(filePath);
            foreach (var guid in guidDatas.Values)
            {
                fileContent = fileContent.Replace(guid.oldGuid, guid.NewGuid);
            }
            File.WriteAllText(filePath, fileContent);
        }
    }
    private void LoadAllClassGUID(string path, bool isOld = true)
    {
        var dirs = Directory.GetDirectories(path);
        var files = Directory.GetFiles(path, "*.cs.meta");
        for (var x = 0; x < files.Length; ++x)
        {
            var name = (Path.GetFileNameWithoutExtension(files[x]));
            if (isOld)
            {
                if (csNames.ContainsKey(name))
                {
                    Debug.LogError(name + "名字重复了");
                }
                else
                {
                    var guids = File.ReadAllLines(files[x])[1];
                    csNames.Add(name, new ClassGUIDDatas(name, guids.Replace("guid: ", "")));
                }
            }
            else
            {
                if (csNames.TryGetValue(name, out var value))
                {
                    var guids = File.ReadAllLines(files[x])[1];
                    value.NewGuid = guids.Replace("guid: ", "");
                }
                else
                {
                    Debug.LogError(name + "名字没有找到");

                }
            }
        }
        for (var x = 0; x < dirs.Length; ++x)
        {
            LoadAllClassGUID(dirs[x], isOld);
        }
    }
    #endregion
    #region 字体
    private bool IsFont;
    private Vector2 fontPoint;
    public TMP_FontAsset sourceFont;
    private ReorderableList FontLists;
    private List<TMP_FontAsset> fontList = new List<TMP_FontAsset>();
    public TMP_FontAsset ToAssetTextureNameObj;
    private void ReplaceFontData(TMP_FontAsset source, TMP_FontAsset target)
    {
        if (source == null || target == null || source == target)
        {
            Debug.LogError("Source or target font is null.");
            return;
        }
        if (source.atlasTextures == null || source.atlasTextures.Length == 0 || target.atlasTextures == null || target.atlasTextures.Length == 0)
        {
            Debug.LogError("Source or target font atlas must not be null");
            return;
        }
        target.isMultiAtlasTexturesEnabled = source.isMultiAtlasTexturesEnabled;
        target.normalStyle = source.normalStyle;
        target.normalSpacingOffset = source.normalSpacingOffset;
        target.boldStyle = source.boldStyle;
        target.boldSpacing = source.boldSpacing;
        target.italicStyle = source.italicStyle;
        target.tabSize = source.tabSize;
        target.atlasTextures = source.atlasTextures;
        target.material = source.material;
        target.atlas = source.atlas;
        target.creationSettings = source.creationSettings;
        
        CopyCharacterTable(source, target);
        CopyGlyphTable(source, target);
        CopyFontFeatureTable(source, target);
        target.ReadFontAssetDefinition();
        EditorUtility.SetDirty(target);
        AssetDatabase.SaveAssets();
        var path = AssetDatabase.GetAssetPath(target);
        var datas = File.ReadAllText(path);
        datas = datas.Replace("m_AtlasWidth: " + target.atlasWidth, "m_AtlasWidth: " + source.atlasWidth).Replace("m_AtlasHeight: " + target.atlasHeight, "m_AtlasHeight: " + source.atlasHeight);
        File.WriteAllText(path, datas);
        AssetDatabase.Refresh();
    }

    private void CopyCharacterTable(TMP_FontAsset source, TMP_FontAsset target)
    {
        target.characterTable.Clear();
        foreach (var item in source.characterTable)
        {
            target.characterTable.Add(item);
        }
    }
    private void CopyGlyphTable(TMP_FontAsset source, TMP_FontAsset target)
    {
        target.glyphTable.Clear();
        foreach (var item in source.glyphTable)
        {
            target.glyphTable.Add(item);
        }
    }

    private void CopyFontFeatureTable(TMP_FontAsset source, TMP_FontAsset target)
    {
        target.fontFeatureTable.glyphPairAdjustmentRecords.Clear();
        foreach (var item in source.fontFeatureTable.glyphPairAdjustmentRecords)
        {
            target.fontFeatureTable.glyphPairAdjustmentRecords.Add(item);
        }

    }
    #endregion
}

