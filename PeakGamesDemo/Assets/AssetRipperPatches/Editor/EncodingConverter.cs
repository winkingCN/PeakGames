using UnityEngine;
using UnityEditor;
using System.IO;
using System.Text;
using System.Collections.Generic;

public class EncodingConverter : EditorWindow
{
    [MenuItem("Assets/Convert to UTF-8 (with BOM)", false, 10)]
    private static void ConvertSelectedFiles()
    {
        if (EditorUtility.DisplayDialog("编码转换", "确定要将选中的文件转换为UTF-8 (with BOM) 格式吗？", "确定", "取消"))
        {
            int processedCount = 0;
            int errorCount = 0;

            foreach (var obj in Selection.objects)
            {
                string assetPath = AssetDatabase.GetAssetPath(obj);
                if (string.IsNullOrEmpty(assetPath)) continue;

                string fullPath = Path.Combine(Application.dataPath, "..", assetPath);
                if (!File.Exists(fullPath)) continue;

                // 过滤需要处理的文件类型
                string extension = Path.GetExtension(fullPath).ToLower();
                if (!IsTextFileExtension(extension)) continue;

                try
                {
                    ConvertFileToUtf8WithBom(fullPath);
                    processedCount++;
                }
                catch (System.Exception e)
                {
                    Debug.LogError($"转换文件 {assetPath} 时出错: {e.Message}");
                    errorCount++;
                }
            }

            if (processedCount > 0)
            {
                AssetDatabase.Refresh();
                EditorUtility.DisplayDialog("转换完成",
                    $"成功转换 {processedCount} 个文件\n失败: {errorCount} 个", "确定");
            }
            else
            {
                EditorUtility.DisplayDialog("转换结果", "未找到可处理的文本文件", "确定");
            }
        }
    }

    // 验证菜单项是否可用
    [MenuItem("Assets/Convert to UTF-8 (with BOM)", true)]
    private static bool ValidateConvertSelectedFiles()
    {
        foreach (var obj in Selection.objects)
        {
            string assetPath = AssetDatabase.GetAssetPath(obj);
            if (string.IsNullOrEmpty(assetPath)) continue;

            string extension = Path.GetExtension(assetPath).ToLower();
            if (IsTextFileExtension(extension))
                return true;
        }
        return false;
    }

    // 判断是否为需要处理的文本文件类型
    private static bool IsTextFileExtension(string extension)
    {
        string[] textExtensions = new[] {
            ".cs", ".js", ".txt", ".json", ".xml", ".html", ".css", ".shader",
            ".cginc", ".hlsl", ".glsl", ".md", ".lua", ".yaml", ".yml"
        };

        return System.Array.IndexOf(textExtensions, extension) >= 0;
    }

    // 转换文件编码到UTF-8 BOM
    private static void ConvertFileToUtf8WithBom(string filePath)
    {
        // 检测原始编码
        Encoding originalEncoding = DetectEncoding(filePath);

        // 读取文件内容
        string content;
        using (StreamReader reader = new StreamReader(filePath, originalEncoding))
        {
            content = reader.ReadToEnd();
        }

        // 如果已经是UTF-8 BOM，则不处理
        if (originalEncoding == Encoding.UTF8)
        {
            // 检查是否真的有BOM
            byte[] bytes = Encoding.UTF8.GetBytes(content);
            if (bytes.Length >= 3 && bytes[0] == 0xEF && bytes[1] == 0xBB && bytes[2] == 0xBF)
            {
                Debug.Log($"文件 {Path.GetFileName(filePath)} 已经是UTF-8 (with BOM) 格式");
                return;
            }
        }

        // 备份原始文件
        string backupPath = filePath + ".bak";
        File.Copy(filePath, backupPath, true);

        // 使用带BOM的UTF-8写入文件
        using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
        {
            writer.Write(content);
        }

        Debug.Log($"已将文件 {Path.GetFileName(filePath)} 从 {originalEncoding.EncodingName} 转换为 UTF-8 (with BOM)");
    }

    // 检测文件编码（不使用UDE库）
    // 改进版编码检测（增加更多编码尝试和验证逻辑）
    private static Encoding DetectEncoding(string filePath)
    {
        // 先检查BOM
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] bom = new byte[4];
            int bytesRead = fs.Read(bom, 0, 4);

            if (bytesRead >= 3 && bom[0] == 0xEF && bom[1] == 0xBB && bom[2] == 0xBF)
                return Encoding.UTF8;

            if (bytesRead >= 2 && bom[0] == 0xFF && bom[1] == 0xFE)
                return Encoding.Unicode;

            if (bytesRead >= 2 && bom[0] == 0xFE && bom[1] == 0xFF)
                return Encoding.BigEndianUnicode;

            if (bytesRead >= 4 && bom[0] == 0x00 && bom[1] == 0x00 && bom[2] == 0xFE && bom[3] == 0xFF)
                return Encoding.UTF32;
        }

        // 尝试常见编码（按可能性排序）
        List<Encoding> encodingsToTry = new List<Encoding>
    {
        Encoding.Default, // 系统默认编码
        Encoding.UTF8,
        Encoding.GetEncoding("GB18030"), // 中文
        Encoding.GetEncoding("Shift-JIS"), // 日文
        Encoding.GetEncoding("Windows-1252"), // 英文/西欧
        Encoding.GetEncoding("ISO-8859-1")
    };

        foreach (var encoding in encodingsToTry)
        {
            try
            {
                string content = File.ReadAllText(filePath, encoding);

                // 验证解码后的内容是否合理
                if (IsValidCSharpFile(content) || IsValidTextFile(content))
                    return encoding;
            }
            catch { /* 忽略解码错误 */ }
        }

        // 作为最后的手段，使用系统默认编码
        return Encoding.Default;
    }
    // 简单验证文本内容是否合理（避免二进制文件被误判）
    
    // 验证C#文件的特定逻辑
    private static bool IsValidCSharpFile(string content)
    {
        if (string.IsNullOrWhiteSpace(content)) return false;

        // 检查C#文件的常见特征
        int score = 0;
        if (content.Contains("using ")) score++;
        if (content.Contains("namespace ")) score++;
        if (content.Contains("class ")) score++;
        if (content.Contains("void ")) score++;
        if (content.Contains("public ")) score++;

        // 至少包含2个C#特征才认为有效
        return score >= 2;
    }

    // 通用文本文件验证
   
    // 简单验证文本内容是否合理（避免二进制文件被误判）
    private static bool IsValidTextFile(string content)
    {
        // 检查是否包含不可打印字符（高概率表示不是文本文件）
        int controlCharCount = 0;
        int totalChars = Mathf.Min(content.Length, 1000); // 只检查前1000个字符

        for (int i = 0; i < totalChars; i++)
        {
            char c = content[i];
            if ((c < 32 && c != '\t' && c != '\n' && c != '\r') || c > 127)
            {
                controlCharCount++;
                if (controlCharCount > totalChars * 0.1) // 超过10%的不可打印字符
                    return false;
            }
        }

        // 检查是否包含常见的文本文件特征
        return content.Contains(" ") || content.Contains("\n") ||
               content.Contains(".") || content.Contains(",");
    }
}