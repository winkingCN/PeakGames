using System.Collections.Generic;
using System.IO;


using UnityEditor;

using UnityEngine;

public class UIFolderDisplayWindow : EditorWindow
{
    private Vector2 scrollPosition;
    private string rootPath = "Assets/UI";
    private FolderItem rootItem;
    private const int ButtonWidth = 60;
    private const int ButtonHeight = 60;
    private const int IndentWidth = 20;
    private int buttonsPerRow;
    private static string seleItemName;
    private static SpriteReplaceData seleReplaceData;
    //
    private static UIFolderDisplayWindow window;
    [MenuItem("Window/UI Folder Display")]
    public static void ShowWindow()
    {
        window = GetWindow<UIFolderDisplayWindow>("UI Folder Display");
    }
    public static System.Action<Texture2D> textAction;
    public static void ShowWindowTexture(string seleItem, SpriteReplaceData replaceData, System.Action<Texture2D> action)
    {
        seleItemName = seleItem;
        textAction = action;
        seleReplaceData = replaceData;
        if(replaceData != null && replaceData.texture != null)
        {
            seleItemName = replaceData.BaseNames;
        }
        ShowWindow();
        window.OnInit();
    }
    public void OnInit()
    {
        if(rootItem == null)
        {
            rootItem = new FolderItem(rootPath, -1, "UI");
            rootItem.UpdateFile(seleItemName);
        }
    }

    void OnGUI()
    {
        scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition);
        if(rootItem == null)
        {
            OnInit();
        }
        rootItem.IsExpanded = true;
        CalculateButtonsPerRow();
        DisplayUI(rootItem, 0);
        EditorGUILayout.EndScrollView();
    }
    private void CalculateButtonsPerRow()
    {
        buttonsPerRow = Mathf.Max(1, (int)((position.width - IndentWidth) / ButtonWidth));
    }
    private void DisplayUI(FolderItem folderItem, int depth)
    {
        GUILayout.BeginHorizontal();
       
        if (folderItem.IsFolder)
        {
            GUILayout.Space(depth * IndentWidth);
            if (GUILayout.Button(folderItem.IsExpanded ? "▼" : "▶", GUILayout.Width(20)))
            {
                folderItem.IsExpanded = !folderItem.IsExpanded;
                folderItem.UpdateFile();
            }
            GUILayout.Label(folderItem.FolderName);
        }
        else if (folderItem.IsImage)
        {
            if (folderItem.texture != null)
            {
                if (GUILayout.Button(folderItem.texture, GUILayout.Width(ButtonWidth), GUILayout.Height(ButtonHeight)))
                {
                    SeleTexture2D(folderItem);
                }
            }
            else
            {
                if (GUILayout.Button(folderItem.FolderName, EditorStyles.label))
                {
                    SeleTexture2D(folderItem);
                }
            }
        }
        else
        {
            GUILayout.Label(folderItem.FolderName);
        }
        GUILayout.EndHorizontal();
        if (folderItem.IsFolder && folderItem.IsExpanded)
        {
            DisplayChildren(folderItem, depth);
        }
    }

    private void SeleTexture2D(FolderItem item)
    {
        Debug.Log("点击了图片：" + item.FolderName);
        EditorGUIUtility.PingObject(item.texture);
        if(textAction != null)
        {
            textAction.Invoke(item.texture);
        }
    }

    private void DisplayChildren(FolderItem folderItem, int depth)
    {
        int buttonCount = 0;
        foreach (var child in folderItem.Children)
        {
            if (child.IsImage)
            {
                if (buttonCount % buttonsPerRow == 0)
                {
                    GUILayout.BeginHorizontal();
                }
                DisplayUI(child, depth );
                if ((buttonCount + 1) % buttonsPerRow == 0 || buttonCount == folderItem.Children.Count - 1)
                {
                    GUILayout.EndHorizontal();
                }
                buttonCount++;
            }
            else
            {
                DisplayUI(child, depth+1);
            }
        }
    }
    // 自定义数据结构：存储文件夹和图片信息
    private class FolderItem
    {
        public string FolderPath;
        public string FolderName;
        public bool IsExpanded;
        private Texture2D text;
        public Texture2D texture
        {
            get
            {
                if(text == null)
                {
                    text = AssetDatabase.LoadAssetAtPath<Texture2D>(FolderPath);
                }
                return text;
            }
        }
        public int Depth;
        public List<FolderItem> Children;
        public bool IsFolder = true;
        public bool IsImage = false;
        private bool IsInit = false;
        public FolderItem(string path, int depth, string folderName)
        {
            FolderPath = path;
            FolderName = folderName;
            Depth = depth;
            IsExpanded = false;
            Children = new List<FolderItem>();
            IsFolder = true;
            IsImage = false;
        }
        public void UpdateFile(string sele = "")
        {
            if (IsInit) return;
            IsInit = true;
            var path = FolderPath;
            var imageName = "";
            if(seleReplaceData != null)
            {
                imageName = seleReplaceData.KeyNames;
            }
            string[] subDirectories = Directory.GetDirectories(path);
            if(subDirectories.Length > 0)
            {
                foreach (string subDir in subDirectories)
                {
                    var folderName = Path.GetFileName(subDir);
                    var folderItem = new FolderItem(subDir, Depth + 1, folderName);
                    Children.Add(folderItem);
                    if(imageName == folderName|| sele == folderName)
                    {
                        folderItem.IsExpanded = true;
                        folderItem.UpdateFile();
                    }
                    else
                    {
                        folderItem.IsExpanded = false;
                    }
                    folderItem.IsImage = false;
                }
            }
            else
            {
                IsFolder = true;
                IsImage = false;
                string[] files = Directory.GetFiles(path);
                foreach (string filePath in files)
                {
                    if (!filePath.EndsWith(".meta"))
                    {
                        var fileName = Path.GetFileName(filePath);
                        var folderItem = new FolderItem(filePath, Depth + 1, fileName);
                        Children.Add(folderItem);
                        folderItem.IsImage = true;
                        folderItem.IsFolder = false;
                    }
                }
            }
        }
    }
}