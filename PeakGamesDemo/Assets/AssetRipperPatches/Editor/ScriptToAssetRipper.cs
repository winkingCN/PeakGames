using System;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;

public class ScriptToAssetRipper : EditorWindow
{
    private static string sourceDir = "";
    private static string lastSourceDirFile = "";

    [MenuItem("Tools/拷贝AssetRipperPatches脚本")]
    public static void CopyScriptsWithTxtExtension()
    {
        // 源目录：Assets/AssetRipperPatches
        InitPath();
        // 目标目录
        string defaultSourceDir = Path.Combine(Application.dataPath, "AssetRipperPatches");
        string projectRoot = "";
        if (defaultSourceDir == sourceDir)
        {
            projectRoot = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.dataPath).FullName).FullName).FullName;
        }
        else
        {
            projectRoot = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(sourceDir).FullName).FullName).FullName).FullName;
            var path = sourceDir;
            sourceDir = Path.Combine(Application.dataPath, "AssetRipperPatches"); ;
            CopyDirectoryToPath(path,false);
            sourceDir = defaultSourceDir;
        }
        string targetDir = Path.Combine(projectRoot, "AssetRipper/Source/AssetRipper.Export.UnityProjects/Assets/AssetRipperPatches");
        string targetDir1 = Path.Combine(projectRoot, "/AssetRipper/Source/0Bins/AssetRipper.GUI.Free/Debug/Assets/AssetRipperPatches");
        
        CopyDirectoryToPath(targetDir);
        CopyDirectoryToPath(targetDir1);
    }

    [MenuItem("Tools/拷贝AssetRipperPatches脚本(自定义源目录)")]
    public static void ShowWindow()
    {
        GetWindow<ScriptToAssetRipper>("拷贝AssetRipperPatches脚本");
    }

    private void OnEnable()
    {
        // 默认路径
        InitPath();
    }
    private static void InitPath()
    {
        string defaultSourceDir = Path.Combine(Application.dataPath, "AssetRipperPatches");
        lastSourceDirFile = Path.Combine(defaultSourceDir, "last_source_dir.txt");

        // 读取上次保存的路径
        if (File.Exists(lastSourceDirFile))
        {
            sourceDir = File.ReadAllText(lastSourceDirFile);
            if (!Directory.Exists(sourceDir))
            {
                sourceDir = defaultSourceDir;
            }
        }
        else
        {
            sourceDir = defaultSourceDir;
        }
    }
    private void OnGUI()
    {
        GUILayout.Label("选择源文件夹（将递归拷贝所有.cs文件并加.txt后缀）", EditorStyles.boldLabel);

        EditorGUILayout.BeginHorizontal();
        sourceDir = EditorGUILayout.TextField("源文件夹路径", sourceDir);
        if (GUILayout.Button("选择文件夹", GUILayout.Width(100)))
        {
            string path = EditorUtility.OpenFolderPanel("选择源文件夹", Application.dataPath, "");
            if (!string.IsNullOrEmpty(path))
            {
                sourceDir = path;
                // 保存路径
                try
                {
                    File.WriteAllText(lastSourceDirFile, sourceDir);
                }
                catch (System.Exception ex)
                {
                    Debug.LogWarning("保存路径失败: " + ex.Message);
                }
            }
        }
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.Space();

        if (GUILayout.Button("开始拷贝", GUILayout.Height(30)))
        {
            if (string.IsNullOrEmpty(sourceDir) || !Directory.Exists(sourceDir))
            {
                EditorUtility.DisplayDialog("错误", "请选择有效的源文件夹路径！", "确定");
                return;
            }
            var path = sourceDir;
            // 目标目录
            string projectRoot = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(sourceDir).FullName).FullName).FullName).FullName;
            string targetDir = Path.Combine(projectRoot, "AssetRipper/Source/AssetRipper.Export.UnityProjects/Assets/AssetRipperPatches");
            string targetDir1 = Path.Combine(projectRoot, "AssetRipper/Source/0Bins/AssetRipper.GUI.Free/Debug/Assets/AssetRipperPatches");
            projectRoot = sourceDir;
            sourceDir = Path.Combine(Application.dataPath, "AssetRipperPatches"); ;
            CopyDirectoryToPath(projectRoot,false);
            CopyDirectoryToPath(targetDir);
            CopyDirectoryToPath(targetDir1);
            sourceDir = path;
        }
        if(GUILayout.Button("还原工程代码", GUILayout.Height(30)))
        {
            if (string.IsNullOrEmpty(sourceDir) || !Directory.Exists(sourceDir))
            {
                EditorUtility.DisplayDialog("错误", "请选择有效的源文件夹路径！", "确定");
                return;
            }
            var projectRoot = Path.Combine(Application.dataPath, "AssetRipperPatches");

            CopyDirectoryToPath(projectRoot, false);
        }
    }

    private static void CopyDirectoryToPath(string targetDir, bool isAdd = true)
    {
        Debug.Log("源目录: " + sourceDir);
        Debug.Log("目标目录: " + targetDir);
        // 删除目标目录下所有 .cs 和 .cs.txt 文件
        if (Directory.Exists(targetDir))
        {
            foreach (var file in Directory.GetFiles(targetDir, "*.*", SearchOption.AllDirectories))
            {
                if (file.EndsWith(".cs") || file.EndsWith(".cs.txt"))
                {
                    File.Delete(file);
                }
            }
        }
        else
        {
            Directory.CreateDirectory(targetDir);
        }

        // 递归拷贝所有 .cs 文件并加 .txt 后缀，保持目录结构
        CopyCsFilesRecursively(sourceDir, targetDir, isAdd);

        Debug.Log("脚本拷贝完成！");
        AssetDatabase.Refresh();
        //EditorUtility.DisplayDialog("完成", "脚本拷贝完成！", "确定");
        //EditorUtility.RevealInFinder(targetDir);
    }

    private static void CopyCsFilesRecursively(string sourceDir, string targetDir,bool isAdd = true)
    {
        // 拷贝当前目录下的 .cs 文件
        foreach (var file in Directory.GetFiles(sourceDir, "*.cs", SearchOption.TopDirectoryOnly))
        {
            if (file.EndsWith(".meta")) continue;

            string relativePath = file.Substring(sourceDir.Length).TrimStart(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
            string targetFile = Path.Combine(targetDir, relativePath) + (isAdd ? ".txt" : "");
            string targetFileDir = Path.GetDirectoryName(targetFile);

            if (!Directory.Exists(targetFileDir))
                Directory.CreateDirectory(targetFileDir);

            try
            {
                // 始终以UTF-8编码写入目标文件
                File.WriteAllText(targetFile, File.ReadAllText(file), Encoding.UTF8);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"处理文件 {file} 时出错: {ex.Message}");
            }
        }


        // 递归处理子目录
        foreach (var dir in Directory.GetDirectories(sourceDir))
        {
            string dirName = Path.GetFileName(dir);
            string targetSubDir = Path.Combine(targetDir, dirName);
            CopyCsFilesRecursively(dir, targetSubDir, isAdd);
        }
    }// 检测文件编码并读取内容的辅助方法
}
