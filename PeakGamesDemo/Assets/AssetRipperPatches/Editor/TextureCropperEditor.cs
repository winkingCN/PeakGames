using UnityEngine;
using UnityEditor;
using UnityEditorInternal;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

public class TextureCropperEditor : EditorWindow
{
    private List<Texture2D> _spriteTextures = new List<Texture2D>();
    private ReorderableList _spritesList;

    private Vector2 _scrollPosition;


    [MenuItem("Tools/裁剪图片透明度")]
    public static void ShowWindow()
    {
        GetWindow<TextureCropperEditor>("Texture Cropper");
    }

    private void OnEnable()
    {
        _spritesList = new ReorderableList(_spriteTextures, typeof(Texture2D), true, true, true, true);
        _spritesList.drawHeaderCallback = DrawHeader;
        _spritesList.drawElementCallback = DrawElement;
        _spritesList.onAddCallback = OnAddTexture;
        _spritesList.onRemoveCallback = OnRemoveTexture;
    }
    private void OnDisable()
    {
        _spriteTextures.Clear();
    }
    private Vector2 point;

    private void OnGUI()
    {
        _scrollPosition = EditorGUILayout.BeginScrollView(_scrollPosition); // 添加滚动视图
        GUILayout.Label("Texture Cropper Settings", EditorStyles.boldLabel);
        EditorGUILayout.Space();
        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Clear Textures", GUILayout.Width(120)))
        {
            _spriteTextures.Clear();
            _spritesList.list = _spriteTextures;
        }

        if (GUILayout.Button("Add Texture", GUILayout.Width(120)))
        {
            AddTexture();
        }
        EditorGUILayout.EndHorizontal();

        // 可重排序列表
        EditorGUILayout.Space();
        point = EditorGUILayout.BeginScrollView(point);
        _spritesList.DoLayoutList();
        EditorGUILayout.EndScrollView();

        // 开始裁剪按钮
        EditorGUILayout.Space();
        if (GUILayout.Button("Crop Selected Textures"))
        {
            CropSelectedTextures();
        }
        EditorGUILayout.EndScrollView();
    }

    private void DrawHeader(Rect rect)
    {
        EditorGUI.LabelField(rect, "Textures");
    }

    private void DrawElement(Rect rect, int index, bool isActive, bool isFocused)
    {
        _spriteTextures[index] = EditorGUI.ObjectField(new Rect(rect.x, rect.y, rect.width, EditorGUIUtility.singleLineHeight), GUIContent.none, _spriteTextures[index], typeof(Texture2D), false) as Texture2D;
    }

    private void OnAddTexture(ReorderableList list)
    {
        AddTexture();
    }

    private void AddTexture()
    {
        var objs = Selection.objects;
        foreach(var obj in objs)
        {
            if(obj is Texture2D text)
            {
                if(_spriteTextures.Contains(text) == false)
                {
                    _spriteTextures.Add(text);
                }
            }
        }
       
    }


    private void OnRemoveTexture(ReorderableList list)
    {
        _spriteTextures.RemoveAt(list.index);
        _spritesList.list = _spriteTextures;
    }

    // 右键菜单项
    [MenuItem("Assets/裁剪图片透明度", false, 100)]
    private static void CropTextureContextMenu()
    {
        TextureCropperEditor window = GetWindow<TextureCropperEditor>("Texture Cropper");
        window._spriteTextures = Selection.GetFiltered<Texture2D>(SelectionMode.Assets).ToList();
        window._spritesList.list = window._spriteTextures;
    }


    private void CropSelectedTextures()
    {
        if (_spriteTextures == null || _spriteTextures.Count == 0)
        {
            Debug.LogWarning("No textures selected for cropping.");
            return;
        }

        foreach (var texture in _spriteTextures)
        {
            if (texture == null) continue;
            var path = AssetDatabase.GetAssetPath(texture);
            TextureImporter textureImporter = AssetImporter.GetAtPath(path) as TextureImporter;
            if (textureImporter == null)
            {
                Debug.LogError($"Failed to get TextureImporter for {texture.name}.");
                continue;
            }

            bool isReadable = textureImporter.isReadable;

            if (!isReadable)
            {
                //设置可读写
                textureImporter.isReadable = true;
                textureImporter.textureType = TextureImporterType.Sprite;
                textureImporter.spriteImportMode = SpriteImportMode.Single;
                textureImporter.SaveAndReimport();
            }


            Texture2D croppedTexture = CropTexture(texture);


            if (!isReadable) //如果之前是不可读写，处理完设置回不可读写
            {
                textureImporter.isReadable = false;
                textureImporter.SaveAndReimport();
            }

            if (croppedTexture == null)
            {
                continue; // 跳过
            }
            var originalTexture = texture;
            string texturePath = AssetDatabase.GetAssetPath(texture); // 获取texture的assetpath
            string textureName = Path.GetFileNameWithoutExtension(texturePath); // 获取文件名
            string savePath = path;  // 新的保存路径
            Sprite originalSprite = AssetDatabase.LoadAssetAtPath<Sprite>(AssetDatabase.GetAssetPath(originalTexture));
            byte[] bytes = croppedTexture.EncodeToPNG();
            File.WriteAllBytes(savePath, bytes);
            if (originalSprite == null)
            {
                Debug.LogWarning($"Texture {originalTexture.name} does not have associated sprite data");
                return;
            }

            textureImporter.textureType = TextureImporterType.Sprite;
            textureImporter.spriteImportMode = SpriteImportMode.Single;
            textureImporter.spritePixelsPerUnit = originalSprite.pixelsPerUnit; // 保存 pixelsPerUnit


            // 计算新的边框
            Rect originalRect = new Rect(0, 0, originalTexture.width, originalTexture.height);
            Rect croppedRect = new Rect(1, 1, croppedTexture.width - 2, croppedTexture.height - 2); //去掉透明边框

            Vector4 newBorder = MapBorder(originalRect, croppedRect, originalSprite.border);

            textureImporter.spriteBorder = newBorder;
            textureImporter.SaveAndReimport();

            AssetDatabase.ImportAsset(savePath, ImportAssetOptions.ForceUpdate);
           

            // 创建新的 Sprite 并复制设置
            //CreateCroppedSprite(texture, croppedTexture, savePath, textureName);


            Debug.Log($"Cropped Sprite saved to: {savePath}");
        }
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        Debug.Log("All selected textures processed.");
    }


    private Vector4 MapBorder(Rect originalRect, Rect croppedRect, Vector4 originalBorder)
    {
        float left = originalBorder.x * croppedRect.width / originalRect.width;
        float bottom = originalBorder.y * croppedRect.height / originalRect.height;
        float right = (originalRect.width - originalBorder.z) * croppedRect.width / originalRect.width;
        float top = (originalRect.height - originalBorder.w) * croppedRect.height / originalRect.height;

        return new Vector4(left, bottom, croppedRect.width - right, croppedRect.height - top);
    }
    private Texture2D CropTexture(Texture2D originalTexture)
    {
        if (originalTexture == null)
        {
            Debug.LogError("Original texture is null.");
            return null;
        }
        // 获取纹理的像素数据
        Color[] pixels = originalTexture.GetPixels();
        int width = originalTexture.width;
        int height = originalTexture.height;

        // 查找裁剪边界
        int minX = width;
        int maxX = 0;
        int minY = height;
        int maxY = 0;

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (pixels[y * width + x].a > 0) // 检测像素是否不透明
                {
                    minX = Mathf.Min(minX, x);
                    maxX = Mathf.Max(maxX, x);
                    minY = Mathf.Min(minY, y);
                    maxY = Mathf.Max(maxY, y);
                }
            }
        }

        // 计算裁剪后的尺寸
        int croppedWidth = maxX - minX + 1;
        int croppedHeight = maxY - minY + 1;

        if (croppedWidth <= 0 || croppedHeight <= 0)
        {
            Debug.LogWarning("Texture has no opaque area. Cropping skipped.");
            return null; // 如果裁剪尺寸为0，跳过裁剪
        }
        // 创建裁剪后的纹理
        Texture2D croppedTexture = new Texture2D(croppedWidth + 2, croppedHeight + 2, TextureFormat.RGBA32, false); // 加2以添加 1 像素透明边框
        Color[] croppedPixels = croppedTexture.GetPixels();

        // 将原图的非透明部分复制到新纹理 (注意偏移和加 1 像素的边框)
        for (int y = 0; y < croppedHeight; y++)
        {
            for (int x = 0; x < croppedWidth; x++)
            {
                croppedPixels[(y + 1) * (croppedWidth + 2) + (x + 1)] = pixels[(minY + y) * width + (minX + x)];
            }
        }

        // 设置透明边框
        for (int y = 0; y < croppedHeight + 2; y++)
        {
            for (int x = 0; x < croppedWidth + 2; x++)
            {
                if (x == 0 || x == croppedWidth + 1 || y == 0 || y == croppedHeight + 1)
                {
                    croppedPixels[y * (croppedWidth + 2) + x] = Color.clear;
                }
            }
        }

        croppedTexture.SetPixels(croppedPixels);
        croppedTexture.Apply();
        return croppedTexture;
    }

    [MenuItem("Assets/修改名字")]
    public static void TextureName()
    {
        var objs = Selection.objects;
        Dictionary<string,Texture2D> keys = new Dictionary<string, Texture2D>();
        foreach(var obj in objs)
        {
            if(obj is Texture2D text)
            {
                var path = AssetDatabase.GetAssetPath(obj);
                var newPath = GetTextureName(keys, path);
                if(path != newPath)
                {
                    path = path.Replace("Assets", Application.dataPath);
                    newPath = newPath.Replace("Assets", Application.dataPath);
                    File.Move(path, newPath);
                    File.Move(path + ".meta", newPath+".meta");
                }
            }
        }
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
    private static string GetTextureName(Dictionary<string, Texture2D> keys,string path)
    {
        var name = Path.GetFileNameWithoutExtension(path);
        if(keys.TryGetValue(name, out Texture2D tex) == false)
        {
            keys.Add(name, null);
            return path;
        }
        if (int.TryParse(name[name.Length-1].ToString(),out int id))
        {
            var c = name[name.Length - 1].ToString();
            name = name.Replace(c, "");
            name += (id+1)+ Path.GetExtension(path);
        }
        else
        {
            name += "1"+ Path.GetExtension(path);
        }
        Debug.Log(name);
        var newPath = GetTextureName(keys, Path.GetDirectoryName(path)+"\\"+name);
        if(File.Exists(newPath))
        {
            return GetTextureName(keys, newPath);
        }
        return newPath;
    }
}