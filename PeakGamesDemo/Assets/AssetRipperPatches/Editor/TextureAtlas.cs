using System.Collections.Generic;
using System.IO;

using TreeEditor;

using UnityEditor;

using UnityEngine;

using static UnityEditor.Progress;

[CustomEditor(typeof(TextureAtlas))]
public class TextureAtlasEditor : Editor
{
    private TextureAtlas _textureAtlas;
    private SpriteReplaceData seleReplace;
    private void OnEnable()
    {
        _textureAtlas = (TextureAtlas)target;
    }
    private List<string> UIDatas = new List<string>();
    private string[] UIItemNames;
    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        if(seleReplace == null)
        {
            seleReplace = _textureAtlas.replaceDatas[0];
        }
        if(UIDatas.Count ==0)
        {
            if(Directory.Exists(Application.dataPath + "\\UI"))
            {
                var dirs = Directory.GetDirectories(Application.dataPath + "\\UI");
                foreach (var dir in dirs)
                 {
                    UIDatas.Add(Path.GetFileName(dir));
                }
                UIItemNames = UIDatas.ToArray();
            }
           
        }
        Texture2D texture = _textureAtlas.texture;
        if (texture != null)
        {
            GUILayout.BeginHorizontal();
            var size = 141;
            if (GUILayout.Button(texture, GUILayout.Width(size), GUILayout.Height(size)))
            {
                EditorGUIUtility.PingObject(texture);
            }
            if (seleReplace != null)
            {
                if(seleReplace.spriteIcon != null)
                {
                    if (GUILayout.Button(seleReplace.spriteIcon, GUILayout.Width(size), GUILayout.Height(size)))
                    {
                        EditorGUIUtility.PingObject(seleReplace.spriteIcon);
                    }
                }
                if(seleReplace.texture != null)
                {
                    if (seleReplace.newTexture == null)
                    {
                        seleReplace.UpdateSprite();
                    }
                    if (GUILayout.Button(seleReplace.newTexture, GUILayout.Width(size), GUILayout.Height(size)))
                    {
                        EditorGUIUtility.PingObject(seleReplace.newTexture);
                    }
                }
            }
            GUILayout.EndHorizontal();
            EditorGUILayout.BeginHorizontal();
            _textureAtlas.Path = EditorGUILayout.TextField(_textureAtlas.Path);
            if(GUILayout.Button("选择导出地址"))
            {
                string folderPath = EditorUtility.OpenFolderPanel("Select Asset Path", Application.dataPath, "");
                if (!string.IsNullOrEmpty(folderPath))
                {
                    _textureAtlas.Path = folderPath;
                }
            }
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.BeginHorizontal();
            if(UIItemNames != null)
            {
                _textureAtlas.BaseIdx = EditorGUILayout.Popup("UI类型", _textureAtlas.BaseIdx, UIItemNames);
            }
            if(GUILayout.Button("Save"))
            {
                SaveTexture(Application.dataPath.Replace("Assets", AssetDatabase.GetAssetPath(_textureAtlas.texture)));
            }
            if (GUILayout.Button("Save As"))
            {
                string folderPath = EditorUtility.OpenFolderPanel("Select Asset Path", Application.dataPath, "");
                if (!string.IsNullOrEmpty(folderPath))
                {
                    _textureAtlas.Path = folderPath;
                    SaveTexture(folderPath);
                }
            }
            if (GUILayout.Button("查找引用预设"))
            {
                string path = AssetDatabase.GetAssetPath(_textureAtlas.texture);
                string guid = AssetDatabase.AssetPathToGUID(path);
                FindReferences(guid);
            }
            EditorGUILayout.EndHorizontal();
        }
        EditorGUILayout.LabelField("Sprite Replace Data", EditorStyles.boldLabel);
        Point = EditorGUILayout.BeginScrollView(Point,GUILayout.Height(495));
        if (_textureAtlas != null && _textureAtlas.replaceDatas != null)
        {
            for (int i = 0; i < _textureAtlas.replaceDatas.Count; i++)
            {
                DrawSpriteReplaceData(_textureAtlas.replaceDatas[i]);
            }
        }
        EditorGUILayout.EndScrollView();
        serializedObject.ApplyModifiedProperties();
        if(Time.time - time > 1)
        {
            Save();
            time = Time.time;
        }
    }
    private void FindReferences(string targetGUID)
    {
        if (string.IsNullOrEmpty(targetGUID))
        {
            Debug.LogError("Please enter a valid GUID.");
            return;
        }
        string[] guids = AssetDatabase.FindAssets("t:Prefab");
        foreach (string guid in guids)
        {
            string prefabPath = AssetDatabase.GUIDToAssetPath(guid);
            if(File.Exists(prefabPath))
            {
                var data = File.ReadAllText(prefabPath);
                if(data.Contains(targetGUID))
                {
                    Debug.Log(prefabPath);
                }    
            }
        }
    }
    private float time;

    private void SaveTexture(string path)
    {
        var text = _textureAtlas.texture.Copy();
        foreach (var data in _textureAtlas.replaceDatas)
        {
            text.SpriteToTexture(data.sprite, data.GetNewTexture2D());
        }
        //if (File.Exists(path))
        //{
        //    File.Delete(path);
        //}
        File.WriteAllBytes(path, text.EncodeToPNG());
        AssetDatabase.Refresh();
    }
    private Vector2 Point;
    void DrawSpriteReplaceData(SpriteReplaceData data)
    {
        EditorGUILayout.BeginHorizontal();
        Sprite sprite = data.sprite;
        if(data.spriteTexture == null)
        {
            data.spriteTexture = sprite.ToTexture(); 
            data.spriteIcon = sprite.ToTexture();
        }
        if (data.spriteTexture != null)
        {
            if (GUILayout.Button(data.spriteTexture, GUILayout.Width(60), GUILayout.Height(60)))
            {
                EditorGUIUtility.PingObject(sprite);
            }
        }
        else
        {
            GUILayout.Box("No Sprite", GUILayout.Width(60), GUILayout.Height(60));
        }
        EditorGUILayout.BeginVertical();
        EditorGUILayout.BeginHorizontal();
        Texture2D tex = data.texture;
        if (tex != null)
        {
            if(data.texture == null)
            {
                data.UpdateSprite();
            }
            
            if (GUILayout.Button(data.texture, GUILayout.Width(60), GUILayout.Height(60)))
            {
                if (data.texture != null)
                {
                    EditorGUIUtility.PingObject(data.texture);
                }
                UIFolderDisplayWindow.ShowWindowTexture(UIItemNames[_textureAtlas.BaseIdx], data, (text) =>
                {
                    data.texture = text;
                    EditorGUIUtility.PingObject(text);
                    data.UpdateSprite(true);
                    SetSele(data);
                });
            }
            
            EditorGUILayout.BeginVertical();
        }
        else
        {
            EditorGUILayout.BeginVertical();
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("图片选择"))
            {
                
                UIFolderDisplayWindow.ShowWindowTexture(UIItemNames[_textureAtlas.BaseIdx], data, (Texture2D text) =>
                {
                    data.texture = text;
                    data.isNewText = true;
                    EditorGUIUtility.PingObject(text);
                    data.UpdateSprite(true);
                    SetSele(data);
                });
            }
           
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            if (GUILayout.Button(data.isShow ? "▼" : "▶ ", GUILayout.Width(20)))
            {
                OnButtonClick(data);
            }
            GUILayout.Label(sprite.name);
            var color = GUI.color;
            GUI.color = data.isNewText ? Color.green : color;
            if(GUILayout.Button(data.isNewText?"选中图片":"原始图片"))
            {
                data.isNewText = !data.isNewText;
                data.UpdateSprite(false,true);
                SetSele(data);
            }
            if(GUILayout.Button("导出图片"))
            {
                data.GetNewTexture2D().Save("Assets/TextureToData/" + data.sprite.name + ".png");
            }
            GUI.color = color;
           
            GUILayout.EndHorizontal();
            ShowToolEditor(data);
        }
        if (tex != null)
        {
            GUILayout.BeginHorizontal();
            if (GUILayout.Button(data.isShow ? "▼" : "▶ ",GUILayout.Width(20)))
            {
                OnButtonClick(data);
            }
            GUILayout.Label(sprite.name);
            var color = GUI.color;
            if(GUILayout.Button("X"))
            {
                data.texture = null;
                data.isNewText = false;
            }
            GUI.color = data.isNewText ? Color.green : color;
            if (GUILayout.Button(data.isNewText ? "选中图片" : "原始图片"))
            {
                data.isNewText = !data.isNewText; 
                data.UpdateSprite(false,true);
                SetSele(data);
            }
            GUI.color = color;
            if (GUILayout.Button("图片生成"))
            {
                data.GetNewTexture2D().Save("Assets/TextureToData/"+data.sprite.name+".png");
                EditorGUIUtility.PingObject(AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/TextureToData/" + data.sprite.name + ".png"));
            }
            GUILayout.EndHorizontal();
            if(GUILayout.Button(data.IsSFBL ? "完全缩放": "等比缩放"))
            {
                data.IsSFBL = !data.IsSFBL;
            }
            ShowToolEditor(data);
        }
        EditorGUILayout.EndVertical();
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.EndVertical();
        EditorGUILayout.EndHorizontal();
    }
    void Save()
    {
        EditorUtility.SetDirty(_textureAtlas);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
    private string[] colorName = new string[] { "Color", "HSV","HSVList" };
    void ShowToolEditor(SpriteReplaceData data)
    {
        if(data.isShow)
        {
            EditorGUI.BeginChangeCheck();
            
            data.SeleColorIdx = GUILayout.Toolbar(data.SeleColorIdx, colorName);
            if(EditorGUI.EndChangeCheck())
            {
                data.UpdateSprite();
                SetSele(data);
            }
            if(data.SeleColorIdx == 1)
            {
                GUILayout.BeginHorizontal();
                GUILayout.Label("HSV添加值:");
                data.Add = EditorGUILayout.Slider(data.Add, 0.1f, 10f);
                GUILayout.EndHorizontal();

                
                EditorGUI.BeginChangeCheck();
                GUILayout.BeginHorizontal();
                GUILayout.Label("H ");
                if (GUILayout.Button("<", GUILayout.Width(25)))
                {
                    data.H -= data.Add;
                    if (data.H < -360)
                    {
                        data.H = 360;
                    }
                }
                data.H = EditorGUILayout.Slider(data.H, -360, 360);
                if (GUILayout.Button(">", GUILayout.Width(25)))
                {
                    data.H += data.Add;
                    if (data.H > 360)
                    {
                        data.H = -360;
                    }
                }
                GUILayout.EndHorizontal();
                GUILayout.BeginHorizontal();
                GUILayout.Label("S ");
                if (GUILayout.Button("<", GUILayout.Width(25)))
                {
                    data.S -= data.Add;
                    if (data.S < -100)
                    {
                        data.S = 100;
                    }
                }
                data.S = EditorGUILayout.Slider(data.S, -100, 100);
                if (GUILayout.Button(">", GUILayout.Width(25)))
                {
                    data.S += data.Add;
                    if (data.S > 100)
                    {
                        data.S = -100;
                    }
                }
                GUILayout.EndHorizontal();
                GUILayout.BeginHorizontal();
                GUILayout.Label("V ");
                if (GUILayout.Button("<", GUILayout.Width(25)))
                {
                    data.V -= data.Add;
                    if (data.V < -100)
                    {
                        data.V = 100;
                    }
                }
                data.V = EditorGUILayout.Slider(data.V, -100, 100);
                if (GUILayout.Button(">", GUILayout.Width(25)))
                {
                    data.V += data.Add;
                    if (data.V > 100)
                    {
                        data.V = -100;
                    }
                }
                GUILayout.EndHorizontal();
                if (EditorGUI.EndChangeCheck())
                {
                    data.UpdateSprite();
                    SetSele(data);
                }
            }
            else if(data.SeleColorIdx == 0)
            {
                EditorGUI.BeginChangeCheck();
                data.color = EditorGUILayout.ColorField(data.color);
                if (EditorGUI.EndChangeCheck())
                {
                    data.UpdateSprite();
                    SetSele(data);
                }
            }
            else if(data.SeleColorIdx == 2)
            {
                GUILayout.BeginHorizontal();
                if (GUILayout.Button(data.IsHSVData ? "▼" : "▶ ", GUILayout.Width(20)))
                {
                    data.IsHSVData = !data.IsHSVData;
                    if(data.IsHSVData)
                    {
                        if(data.IdxHSVData.Count == 0)
                        {
                            data.UpdateSprite();
                        }    
                    }
                    SetSele(data);
                }
                GUILayout.Label("HSV范围调整 "+data.IdxHSVData.Count);
                GUILayout.EndHorizontal();
                if (data.IsHSVData)
                {
                    data.HSVPoint = GUILayout.BeginScrollView(data.HSVPoint, GUILayout.Height(150));
                    foreach (KeyValuePair<int, List<TextureHSVData>> item in data.IdxHSVData)
                    {
                        if (item.Value.Count > 0)
                        {
                            var item1 = item.Value[0];
                            GUILayout.BeginHorizontal();
                            GUILayout.Space(20);
                            if (GUILayout.Button(item1.isShow ? "▼" : "▶ ", GUILayout.Width(20)))
                            {
                                item1.isShow = !item1.isShow;
                            }
                            GUILayout.Label(item.Key + " -- " + item.Value.Count);
                            GUILayout.EndHorizontal();

                            if (item1.isShow)
                            {
                                for (int i = 0; i < item.Value.Count; i++)
                                {
                                    GUILayout.BeginHorizontal();
                                    GUILayout.Space(40);
                                    GUILayout.Label(item.Value[i].H.ToString());
                                    EditorGUILayout.ColorField(item.Value[i].color);
                                    item.Value[i].colorCB = EditorGUILayout.ColorField(item.Value[i].colorCB);
                                    GUILayout.EndHorizontal();
                                }
                            }
                        }

                    }
                    GUILayout.EndScrollView();
                }
            }
        }
    }
    void OnButtonClick(SpriteReplaceData data)
    {
        data.UpdateSprite();
        SetSele(data);
    }
    private void SetSele(SpriteReplaceData data)
    {
        if (data == seleReplace && data.isShow) return;
        data.isShow = !data.isShow;
        if (data.isShow)
        {
            seleReplace = data;

        }
        foreach (var item in _textureAtlas.replaceDatas)
        {
            if (item != data)
            {
                item.isShow = false;
            }
        }
    }
    [MenuItem("Assets/UI对象")]
    private static void ToTextureAtlas()
    {
        if(Selection.activeObject != null)
        {
            var path = AssetDatabase.GetAssetPath(Selection.activeObject);
            var datas = AssetDatabase.LoadAllAssetsAtPath(path);
            if (datas.Length > 1)
            {
                var textData = ScriptableObject.CreateInstance<TextureAtlas>();
                textData.AddDatas(datas);
                AssetDatabase.CreateAsset(textData, path.Replace(Path.GetExtension(path), ".asset"));
            }
        }
    }

}
[System.Serializable]
public class SpriteReplaceData
{
    public string Name;
    public Sprite sprite;
    public Texture2D spriteTexture;
    public Texture2D spriteIcon;
    public Texture2D texture;
    public Texture2D newTexture;
    public bool isShow;
    public bool isNewText;
    public bool IsSFBL = false;
    public float Add;
    public int SeleColorIdx;
    public bool IsHSVData;
    public Dictionary<int, TextureHSVData> hsvData = new Dictionary<int, TextureHSVData>();
    public Dictionary<int, List<TextureHSVData>> IdxHSVData = new Dictionary<int, List<TextureHSVData>>();
    public List<TextureHSVData> hsvList = new List<TextureHSVData>();
    public Vector2 minMaxHSV;
    public Vector2 HSVPoint;
    public Color color = Color.white;
    public float H;
    public float S;
    public float V;
    public float Max
    {
        get
        {
            var max = 0;
            foreach(var data in hsvList)
            {
                if(data.H > max)
                {
                    max = data.H;
                }
            }
            return max;
        }
    }
    public float Min
    {
        get
        {
            var min = 369;
            foreach (var data in hsvList)
            {
                if (data.H < min)
                {
                    min = data.H;
                }
            }
            return min;
        }
    }
    public string KeyNames
    {
        get
        {
            if (texture != null)
            {
                var path = AssetDatabase.GetAssetPath(texture);
                var name = Path.GetFileName(Path.GetDirectoryName(path));
                return name;
            }
            return "";
        }
    }
    public string BaseNames
    {
        get
        {
            if (texture != null)
            {
                var path = AssetDatabase.GetAssetPath(texture);
                var name = Path.GetFileName(Path.GetDirectoryName(Path.GetDirectoryName(path)));
                return name;
            }
            return "";
        }
    }
    public Texture2D GetNewTexture2D()
    {
        Texture2D text = null;
        if(isNewText)
        {
            var newSprite = SpriteScaler.GenerateScaledSprite(texture, spriteIcon.width, spriteIcon.height,IsSFBL);
            text = newSprite.texture;
        }
        else
        {
            text = sprite.ToTexture();
        }
        if (SeleColorIdx == 0)
        {
            text.ApplyColorFilterAndWrite(text, color);
        }
        else if (SeleColorIdx == 1)
        {
            text.ApplyHSVToTexture(text, H, S, V);
        }
        return text;
    }
    public void UpdateSprite(bool isTrue = false,bool IsNewTextUpdate =false)
    {
        if(color.a ==0)
        {
            color = Color.white;
        }
        if(spriteIcon == null)
        {
            spriteIcon = sprite.ToTexture();
        }
        if(spriteTexture  == null)
        {
            spriteTexture = sprite.ToTexture();
        }
        if(isTrue)
        {
            newTexture = null;
        }
        if(newTexture == null && texture != null || isTrue)
        {
            if(newTexture == null)
            {
                newTexture = new Texture2D(texture.width,texture.height);
                texture.SetTextureReadable();
                newTexture.SetPixels(texture.GetPixels());
                newTexture.Apply();
            }
            else
            {
                texture.SetTextureReadable();
                newTexture.SetPixels(texture.GetPixels());
                newTexture.Apply();
            }
        }
        if(isNewText)
        {
            if(SeleColorIdx == 0)
            {
                if(texture != null)
                {
                    texture.ApplyColorFilterAndWrite( newTexture, color);
                }
            }
            else
            {
                if(texture != null)
                {
                    texture.ApplyHSVToTexture(newTexture, H, S, V);
                }
            }
            if (IsNewTextUpdate || hsvList.Count == 0 || IdxHSVData.Count == 0)
            {
                InitShowTexture(texture);
            }
        }
        else
        {
            if (SeleColorIdx == 0)
            {
                spriteTexture.ApplyColorFilterAndWrite( spriteIcon, color);
            }
            else
            {
                spriteTexture.ApplyHSVToTexture(spriteIcon, H, S, V);
            }
            if (IsNewTextUpdate || hsvList.Count == 0|| IdxHSVData.Count == 0)
            {
                InitShowTexture(spriteTexture);
            }
        }
        
    }

    public List<TextureHSVData> InitShowTexture(Texture2D texture)
    {
        var color = TextureTools.GetPixels(texture);
        float h, s, v = 0f;
        for (var x = 0; x < color.Length; ++x)
        {
            if (color[x].a > 0)
            {
                Color.RGBToHSV(color[x], out h, out s, out v);
                var HColor = (int)(h * 360);
                if (hsvData.ContainsKey(HColor) == false)
                {
                    hsvData.Add(HColor, new TextureHSVData(HColor, color[x]));
                }
            }
        }
        hsvList.Clear();
        foreach (var hsv in hsvData)
        {
            hsvList.Add(hsv.Value);
        }
        hsvList.Sort((a, b) =>
        {
            if (a.H > b.H)
            {
                return 1;
            }
            return -1;
        });
        var idx = 0;
        for (var x = 0; x < hsvList.Count; ++x)
        {
            if (x > 0)
            {
                if ((hsvList[x].H - hsvList[x - 1].H) == 1)
                {
                    hsvList[x].Idx = hsvList[x - 1].Idx;
                }
                else
                {
                    hsvList[x].Idx = idx;
                    idx++;
                }
            }
            else
            {
                hsvList[x].Idx = idx;
                idx++;
            }
        }
        IdxHSVData.Clear();
        foreach (var item in hsvList)
        {
            if(IdxHSVData.TryGetValue(item.Idx,out var list) == false)
            {
                list = new List<TextureHSVData>();
                IdxHSVData.Add(item.Idx, list);
            }
            list.Add(item);
        }
        minMaxHSV = new Vector2(Min, Max);
        return hsvList;
    }
    public SpriteReplaceData()
    {

    }
    public SpriteReplaceData(Sprite sp)
    {
        sprite = sp;
        Name = sp.name;
    }

}
public class TextureAtlas : ScriptableObject
{
    public string Path;
    public Texture2D texture;
    public int BaseIdx;
    public List<SpriteReplaceData> replaceDatas = new List<SpriteReplaceData>();
    public void AddDatas(Object[] datas)
    {
        foreach (var data in datas)
        {
            if (data is Texture2D)
            {
                texture = data as Texture2D;
            }
            else if (data is Sprite sprite)
            {
                replaceDatas.Add(new SpriteReplaceData(sprite));
            }
        }
    }
}
[System.Serializable]
public class TextureHSVData
{
    public int H;
    public Color color;
    public Color colorCB;
    [HideInInspector]
    public bool isShow;
    public int Idx = 1;
    [HideInInspector]
    public float addH;
    [HideInInspector]
    public float addS;
    [HideInInspector]
    public float addV;

    public float AddH
    {
        get
        {
            return addH / 360f;
        }
    }
    public float AddS
    {
        get
        {
            return addS * 0.01f;
        }
    }
    public float AddV
    {
        get
        {
            return addV * 0.01f;
        }
    }
    public TextureHSVData(int h, Color color)
    {
        H = h;
        //Idx = (int)(h  / 90f);
        colorCB = color;
        this.color = color;
    }
}