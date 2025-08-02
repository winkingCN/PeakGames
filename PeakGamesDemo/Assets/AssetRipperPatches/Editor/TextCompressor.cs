using UnityEngine;
using UnityEditor;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System;

/// <summary>
/// 文本压缩/解压缩工具 - Unity编辑器扩展
/// </summary>
public class TextCompressor : EditorWindow
{
    private enum OperationType
    {
        Compress,
        Decompress
    }

    private static OperationType operationType = OperationType.Compress;
    private static string outputPath = "";
    private static bool overwriteOriginal = false;
    private static string[] selectedFiles;

    /// <summary>
    /// 注册压缩菜单项
    /// </summary>
    [MenuItem("Assets/压缩 Text", false, 10)]
    private static void CompressText()
    {
        operationType = OperationType.Compress;
        InitializeAndShowWindow();
    }

    /// <summary>
    /// 注册解压缩菜单项
    /// </summary>
    [MenuItem("Assets/解压 Text", false, 11)]
    private static void DecompressText()
    {
        operationType = OperationType.Decompress;
        InitializeAndShowWindow();
    }

    /// <summary>
    /// 验证压缩菜单项是否可用
    /// </summary>
    [MenuItem("Assets/压缩 Text", true)]
    private static bool ValidateCompressText()
    {
        return GetSelectedTextFiles().Length > 0;
    }

    /// <summary>
    /// 验证解压缩菜单项是否可用
    /// </summary>
    [MenuItem("Assets/解压 Text", true)]
    private static bool ValidateDecompressText()
    {
        return GetSelectedTextFiles().Length > 0;
    }

    /// <summary>
    /// 初始化并显示窗口
    /// </summary>
    private static void InitializeAndShowWindow()
    {
        // 获取选中的文件
        selectedFiles = GetSelectedTextFiles();

        if (selectedFiles.Length == 0)
        {
            EditorUtility.DisplayDialog("文本处理工具", "请选择文本文件(.txt, .json, .xml等)", "确定");
            return;
        }

        // 打开确认窗口
        TextCompressor window = GetWindow<TextCompressor>(operationType == OperationType.Compress ? "文本压缩工具" : "文本解压缩工具");
        window.minSize = new Vector2(400, 200);
        window.ShowUtility();
    }

    /// <summary>
    /// 获取选中的文本文件
    /// </summary>
    private static string[] GetSelectedTextFiles()
    {
        string[] guids = Selection.assetGUIDs;
        List<string> textFiles = new List<string>();

        foreach (string guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            if (IsTextFile(path))
            {
                textFiles.Add(path);
            }
        }

        return textFiles.ToArray();
    }

    /// <summary>
    /// 检查文件是否为文本文件
    /// </summary>
    private static bool IsTextFile(string path)
    {
        string extension = Path.GetExtension(path).ToLower();
        string[] textExtensions = { ".txt", ".json", ".xml", ".csv", ".html", ".css", ".js", ".lua", ".yaml", ".md" };

        return textExtensions.Contains(extension);
    }

    /// <summary>
    /// 绘制窗口UI
    /// </summary>
    private void OnGUI()
    {
        GUILayout.Label(operationType == OperationType.Compress ? "文本压缩工具" : "文本解压缩工具", EditorStyles.boldLabel);
        GUILayout.Space(10);

        if (operationType == OperationType.Compress)
        {
            GUILayout.Label("操作将替换文本中的换行符为\\n，双引号\"为\\\"", EditorStyles.wordWrappedLabel);
        }
        else
        {
            GUILayout.Label("操作将替换文本中的\\n为换行符，\\\"为双引号\"", EditorStyles.wordWrappedLabel);
        }

        GUILayout.Space(10);

        EditorGUILayout.LabelField("选中的文件:", selectedFiles.Length + "个文本文件");

        foreach (string file in selectedFiles)
        {
            EditorGUILayout.LabelField("  - " + Path.GetFileName(file));
        }

        GUILayout.Space(10);

        overwriteOriginal = EditorGUILayout.Toggle("覆盖原文件", overwriteOriginal);

        if (!overwriteOriginal)
        {
            EditorGUILayout.BeginHorizontal();
            outputPath = EditorGUILayout.TextField("输出文件夹", outputPath);

            if (GUILayout.Button("浏览...", GUILayout.Width(80)))
            {
                string folder = EditorUtility.OpenFolderPanel("选择输出文件夹", Application.dataPath, "");
                if (!string.IsNullOrEmpty(folder))
                {
                    outputPath = folder;
                }
            }
            EditorGUILayout.EndHorizontal();
        }

        GUILayout.Space(20);

        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("取消", GUILayout.Height(30)))
        {
            Close();
        }

        if (GUILayout.Button(operationType == OperationType.Compress ? "执行压缩" : "执行解压缩", GUILayout.Height(30)))
        {
            ProcessFiles();
            Close();
        }
        EditorGUILayout.EndHorizontal();
    }

    /// <summary>
    /// 处理选中的文件
    /// </summary>
    private void ProcessFiles()
    {
        try
        {
            if (selectedFiles.Length == 0)
                return;

            int processedCount = 0;

            foreach (string filePath in selectedFiles)
            {
                try
                {
                    // 读取文件内容
                    string content = File.ReadAllText(filePath, Encoding.UTF8);

                    // 处理文本
                    string processedContent = operationType == OperationType.Compress ? CompressText(content) : DecompressText(content);

                    // 保存处理后的文本
                    string outputFilePath = GetOutputFilePath(filePath);
                    File.WriteAllText(outputFilePath, processedContent, Encoding.UTF8);

                    processedCount++;
                }
                catch (Exception ex)
                {
                    Debug.LogError($"处理文件 {filePath} 时出错: {ex.Message}");
                }
            }

            // 刷新资产数据库
            AssetDatabase.Refresh();

            // 显示结果
            string operationName = operationType == OperationType.Compress ? "压缩" : "解压缩";
            EditorUtility.DisplayDialog($"文本{operationName}完成",
                $"成功处理 {processedCount} 个文件，失败 {selectedFiles.Length - processedCount} 个文件", "确定");
        }
        catch (Exception ex)
        {
            Debug.LogError($"处理过程中出错: {ex.Message}");
            EditorUtility.DisplayDialog("错误", $"处理过程中发生错误: {ex.Message}", "确定");
        }
    }

    /// <summary>
    /// 压缩文本：替换换行符和双引号
    /// </summary>
    private string CompressText(string text)
    {
        // 替换换行符为\n
        text = text.Replace("\\n", "\\\\n");
        text = text.Replace("\r\n", "\\r\\n");
        // 替换双引号为\"
        text = text.Replace("\"", "\\\"");

        return text;
    }

    /// <summary>
    /// 解压缩文本：还原换行符和双引号
    /// </summary>
    private string DecompressText(string text)
    {
        // 替换\"为"
        text = text.Replace("\\\"", "\"");

        // 替换\n为换行符（先替换为临时标记，避免双重替换）
        text = text.Replace("\\n", "\n");

        return text;
    }

    /// <summary>
    /// 获取输出文件路径
    /// </summary>
    private string GetOutputFilePath(string originalPath)
    {
        if (overwriteOriginal)
            return originalPath;

        string fileName = Path.GetFileName(originalPath);
        string outputFolder = outputPath;

        // 如果未选择输出文件夹，使用与原文件相同的目录
        if (string.IsNullOrEmpty(outputFolder))
        {
            outputFolder = Path.GetDirectoryName(originalPath);
        }

        // 如果输出文件夹不是项目目录的子目录，尝试创建相对路径
        if (!outputFolder.Contains(Application.dataPath))
        {
            string projectName = Path.GetFileName(Application.dataPath);
            outputFolder = Path.Combine(Application.dataPath, operationType == OperationType.Compress ? "CompressedText" : "DecompressedText", projectName);
            Directory.CreateDirectory(outputFolder);
        }

        return Path.Combine(outputFolder, fileName);
    }
}