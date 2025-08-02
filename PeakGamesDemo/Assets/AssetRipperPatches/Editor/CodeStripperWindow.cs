using UnityEngine;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System;
using System.Linq;
using System.Text.RegularExpressions;

public class CodeStripperWindow : EditorWindow
{
    private string folderPath = "";
    private bool isProcessing = false;
    private string processingStatus = "";
    private Vector2 scrollPosition;
    private List<string> processedFiles = new List<string>();

    [MenuItem("Tools/代码处理工具")]
    public static void ShowWindow()
    {
        GetWindow<CodeStripperWindow>("代码处理工具");
    }

    private void OnGUI()
    {
        GUILayout.Label("C#代码处理工具", EditorStyles.boldLabel);
        GUILayout.Space(10);
      
        EditorGUILayout.BeginHorizontal();
        folderPath = EditorGUILayout.TextField("文件夹路径", folderPath);
        if (GUILayout.Button("浏览...", GUILayout.Width(80)))
        {
            string selectedPath = EditorUtility.OpenFolderPanel("选择文件夹", "", "");
            if (!string.IsNullOrEmpty(selectedPath))
            {
                folderPath = selectedPath;
            }
        }
        EditorGUILayout.EndHorizontal();

        GUILayout.Space(10);

        EditorGUI.BeginDisabledGroup(isProcessing || string.IsNullOrEmpty(folderPath));
        if (GUILayout.Button("开始处理", GUILayout.Height(40)))
        {
            ProcessFolder();
        }
        EditorGUI.EndDisabledGroup();

        GUILayout.Space(10);

        if (isProcessing)
        {
            EditorGUILayout.HelpBox(processingStatus, MessageType.Info);
            Repaint();
        }

        if (processedFiles.Count > 0)
        {
            GUILayout.Label("处理结果:", EditorStyles.boldLabel);
            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, GUILayout.MaxHeight(200));
            foreach (string file in processedFiles)
            {
                EditorGUILayout.LabelField(file);
            }
            EditorGUILayout.EndScrollView();
        }
    }

    private void ProcessFolder()
    {
        if (!Directory.Exists(folderPath))
        {
            EditorUtility.DisplayDialog("错误", "所选文件夹不存在！", "确定");
            return;
        }

        processedFiles.Clear();
        isProcessing = true;
        processingStatus = "开始处理...";
        Repaint();

        EditorApplication.delayCall += () =>
        {
            try
            {
                string[] files = Directory.GetFiles(folderPath, "*.cs", SearchOption.AllDirectories);
                int processedCount = 0;

                foreach (string file in files)
                {
                    processingStatus = $"正在处理: {Path.GetFileName(file)} ({processedCount + 1}/{files.Length})";
                    Repaint();

                    try
                    {
                        ProcessCode(file);
                        processedFiles.Add($"✔ {Path.GetFileName(file)}");
                    }
                    catch (System.Exception ex)
                    {
                        processedFiles.Add($"❌ {Path.GetFileName(file)} - 错误: {ex.Message}");
                    }

                    processedCount++;
                }

                processingStatus = $"处理完成！共处理 {processedFiles.Count} 个文件。";
                AssetDatabase.Refresh();
            }
            catch (System.Exception ex)
            {
                processingStatus = $"处理过程中发生错误: {ex.Message}";
            }
            finally
            {
                isProcessing = false;
            }
        };
    }
    public static string ProcessCode(string path)
    {
        var lines = File.ReadAllLines(path);
        var processedLines = new List<string>();
        bool inClassDeclaration = false;
        bool inMethodBody = false;
        int classDepth = 0;
        int currentLine = 0;
        bool isFF = false;
        bool isKong = false;

        while (currentLine < lines.Length)
        {
            string originalLine = lines[currentLine];
            string line = originalLine.TrimStart(); // 只移除行首空白，保留缩进信息
            string indent = originalLine.Substring(0, originalLine.Length - line.Length); // 获取原始缩进

            // 处理空行或注释行
            if ((string.IsNullOrWhiteSpace(line) || line.StartsWith("//") || line.StartsWith("/*")))
            {
                if (isKong == false)
                {
                    processedLines.Add(originalLine); // 直接添加原始行，保留缩进
                    currentLine++;
                    isKong = true;
                    continue;
                }
            }
            else
            {
                isKong = false;
            }

            // 检测类/结构体声明开始
            if (IsClassOrStructDeclaration(line))
            {
                classDepth++;
                inClassDeclaration = true;
                var className = RemoveInterfacesFromClassDeclaration(originalLine);
                //Debug.LogError(className);
                processedLines.Add(className); // 移除接口后的类声明
                currentLine++;
                continue;
            }

            // 检测类/结构体声明结束
            if (inClassDeclaration && line.Trim() == "}")
            {
                classDepth--;
                if (classDepth == 0)
                {
                    inClassDeclaration = false;
                }
                processedLines.Add(originalLine); // 保留原始缩进
                currentLine++;
                continue;
            }
            string fx = ProcessMethodDeclaration(line);
            if (fx.StartsWith("[") && (!line.Contains("SerializeField") && !line.Contains("Serializable") && !line.Contains("NonSerialized")))
            {
                if (!line.Contains("[]") && line.Contains("this[") == false && fx.EndsWith(";") == false)
                {
                    currentLine++;
                    continue;
                }

            }
            // 处理类内部的内容
            if (inClassDeclaration)
            {


                if (line.Contains("=>") && line.Contains(";") || (line.Contains("{") && line.Contains("}")))
                {
                    currentLine++;
                    continue;
                }
                int propertyEndLine;

                if (IsMethodDefinition(line))
                {
                    currentLine++;
                    continue;
                }
                // 处理方法声明
                if (IsMethodDeclaration(line.Trim()) && !inMethodBody || TryIdentifyExplicitInterfaceProperty(line) && !inMethodBody)
                {
                    string processedMethod = ProcessMethodDeclaration(originalLine); // 处理带缩进的原始行
                    currentLine++;
                    if (line.Contains("{") && line.Contains("}") || line.Contains("=>") && processedMethod.EndsWith(";"))
                    {
                        continue;
                    }
                    if (processedMethod.Contains(" abstract ") == false)
                    {
                        // 跳过方法体（改进版，正确处理嵌套括号）
                        inMethodBody = true;
                        int braceCount = 0; // 初始左括号计数
                        var isFirst = true;
                        while (currentLine < lines.Length && inMethodBody)
                        {
                            if (isFirst)
                            {
                                if (lines[currentLine].Trim() != "{")
                                {
                                    while (lines[currentLine].Trim() != "{")
                                    {
                                        currentLine++;
                                    }
                                    isFirst = false;
                                    braceCount++;
                                    currentLine++;
                                }
                                else
                                {
                                    isFirst = false;
                                    braceCount++;
                                    currentLine++;
                                }

                            }

                            if (currentLine >= lines.Length) break;

                            string bodyLine = lines[currentLine].Trim();

                            if (bodyLine.Contains("{"))
                            {
                                braceCount++;
                            }

                            if (bodyLine.Contains("}"))
                            {
                                braceCount--;
                            }
                            if (braceCount == 0)
                            {
                                inMethodBody = false;
                            }
                            currentLine++;
                        }
                    }
                    continue;
                }
                else if (line.Contains("abstract") && line.Contains(";"))
                {
                    currentLine++;
                    continue;
                }

                if (line == "{")
                {
                    classDepth++;
                }

                // 处理普通代码行（保留缩进）
                if (!inMethodBody && !string.IsNullOrWhiteSpace(line))
                {
                    processedLines.Add(originalLine);
                }
                currentLine++;
            }
            else
            {
                // 非类声明部分直接添加（保留缩进）
                processedLines.Add(originalLine);
                currentLine++;
            }
        }

        // 优化空行处理（合并连续空行）
        var optimizedLines = new List<string>();
        bool lastWasEmpty = false;
        foreach (string line in processedLines)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                if (!lastWasEmpty)
                {
                    optimizedLines.Add(line);
                    lastWasEmpty = true;
                }
            }
            else
            {
                optimizedLines.Add(line);
                lastWasEmpty = false;
            }
        }

        var data = string.Join(Environment.NewLine, optimizedLines);
        File.WriteAllText(path, data);

        return data;
    }
    private static string RemoveInterfacesFromClassDeclaration(string classLine)
    {
        string line = classLine.Trim();
        if (!line.Contains(":"))
        {
            // 没有继承任何类型，直接返回
            return classLine;
        }

        // 提取类名部分
        int colonIndex = line.IndexOf(':');
        string classNamePart = line.Substring(0, colonIndex).Trim();

        // 提取继承部分
        string inheritancePart = line.Substring(colonIndex + 1).Trim();

        // 分割继承列表
        string[] parts = SplitByTopLevelCommas(inheritancePart);

        // 筛选出需要保留的继承项（非接口）
        List<string> remainingInheritance = new List<string>();
        foreach (string part in parts)
        {
            string typeName = part.Trim();
            if (string.IsNullOrEmpty(typeName)) continue;

            // 如果不是接口，则保留
            if (!IsKnownInterface(typeName))
            {
                remainingInheritance.Add(typeName);
            }
        }

        // 构建新的继承部分
        string newInheritance = string.Join(", ", remainingInheritance);
        if (!string.IsNullOrEmpty(newInheritance))
        {
            return $"{classNamePart} : {newInheritance}";
        }
        else
        {
            // 没有保留任何继承项，移除冒号
            return classNamePart;
        }
    }

    private static bool IsMethodDefinition(string line)
    {
        // 移除行首行尾空白字符
        line = line.Trim();
        if (line.Contains(" delegate "))
        {
            return false;
        }
        // 检查是否包含返回类型
        bool hasReturnType = line.Split(' ').Length > 1;

        // 检查是否包含方法名（非关键字）
        bool hasMethodName = false;
        if (hasReturnType)
        {
            string[] parts = line.Split(new[] { ' ', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length > 1)
            {
                string possibleMethodName = parts[1];
                hasMethodName = !string.IsNullOrWhiteSpace(possibleMethodName) &&
                               !CSharpKeywords.Contains(possibleMethodName);
            }
        }

        // 检查是否是属性定义（排除属性）
        bool isProperty = line.Contains('{') && line.Contains('}');

        // 组合判断条件
        return line.EndsWith(");") && hasMethodName && !line.Contains("return ");//hasParameters && hasReturnType && hasMethodName && !isProperty &&
    }

    private static readonly HashSet<string> CSharpKeywords = new HashSet<string>
        {
            "abstract", "as", "base", "bool", "break", "byte", "case", "catch",
            "char", "checked", "class", "const", "continue", "decimal", "default",
            "do", "double", "else", "enum", "event", "explicit",
            "extern", "false", "finally", "fixed", "float", "for", "foreach",
            "goto", "if", "implicit", "in", "int", "interface", "internal",
            "is", "lock", "long", "namespace", "new", "null", "object", "operator",
            "out", "override", "params", "private static", "protected", "public", "readonly",
            "ref", "return", "sbyte", "sealed", "short", "sizeof", "stackalloc",
            "static", "string", "struct", "switch", "this", "throw", "true", "try",
            "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", "using",
            "virtual", "void", "volatile", "while"
        };
    private static bool IsMethodDeclaration(string line)
    {
        // 排除属性、事件
        if (line.Contains("get;") || line.Contains("set;") ||
            line.Contains("add;") || line.Contains("remove;"))  // 新增：排除索引器
            return false;


        if (line.Contains("this[") && line.Contains("]"))
        {
            return true;
        }
        if (line.Contains('.') && line.Contains('(') && line.Contains(')'))
        {
            string[] parts = line.Split('.');
            if (parts.Length >= 2)
            {
                string interfacePart = parts[0].Trim().Split(" ")[1];
                string methodPart = parts[1].Trim();

                // 检查是否符合接口命名约定且后面跟着方法名和参数列表
                if (IsKnownInterface(interfacePart) &&
                    methodPart.Contains("(") && methodPart.Contains(")"))
                {
                    return true;
                }
            }
        }
        // 支持方法和构造函数的正则表达式
        var methodRegex = new Regex(@"^\s*
        (public|private static|protected|internal|static|virtual|override|abstract|sealed)?\s*  # 可选的访问修饰符
        (?:[\w<>.,\[\]\s]+|\([^)]*\))?\s+  # 可选的返回类型（构造函数没有返回类型）
        \w+\s*  # 方法/构造函数名
        \(.*?\)  # 参数列表
        \s*$", RegexOptions.IgnorePatternWhitespace);

        return methodRegex.IsMatch(line);
    }
    private static string ProcessMethodDeclaration(string line)
    {
        // 将方法声明改为抽象方法或直接分号结尾
        if (line.Contains("{"))
        {
            // 移除大括号并添加分号
            return line.Substring(0, line.IndexOf('{')).Trim() + ";";
        }
        return line;
    }

    private static bool TryIdentifyExplicitInterfaceProperty(string codeLine)
    {
        string line = codeLine.Trim();
        if (string.IsNullOrEmpty(line)) return false;

        // 排除明显不是变量声明的情况
        if (line.Contains("(") && line.Contains(")") ||  // 方法声明
            line.Contains("event") ||                  // 事件声明
            line.Contains(":") ||                      // 继承声明
            line.Contains("[") ||                      // 特性声明
            line.StartsWith("class ") ||              // 类声明
            line.StartsWith("struct ") ||             // 结构体声明
                                                      //line.StartsWith("interface ") ||          // 接口声明
            line.StartsWith("enum ") ||               // 枚举声明
            line.StartsWith("//") || line.StartsWith("/*")) // 注释
        {
            return false;
        }
        if (line.EndsWith(";")) return false;
        if (line.Contains("IEnumerator<object>.Current")) return true;
        if (line.Contains("IEnumerator.Current")) return true;
        // 检测变量声明模式：[访问修饰符(可选)] + 类型 + 变量名
        string pattern = @"^\s*
        (private static|public|protected|internal|static|readonly|const)?\s*  # 访问修饰符
        [\w\<\>\[\]\.]+?\s+                                      # 属性类型
        \w+\s*                                                   # 属性名
        \{\s*                                                    # 左大括号
        (get|private static\s+get|protected\s+get|internal\s+get)?\s*;  # get访问器
        \s*
        (set|private static\s+set|protected\s+set|internal\s+set)?\s*;  # set访问器
        \s*\}\s*$";
        Regex regex = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);

        if (!regex.IsMatch(line)) return false;

        // 判断是否未以分号结尾或包含左大括号
        return !line.EndsWith(";") || line.Contains("{");
    }

    private static List<string> GetImplementedInterfaces(string classLine)
    {
        var interfaces = new List<string>();
        string line = classLine.Trim();

        // 查找类声明中的继承部分（格式: class Name : BaseClass, Interface1, Interface2）
        if (line.Contains(":"))
        {
            string inheritancePart = line.Substring(line.IndexOf(':') + 1).Trim();

            // 分割继承列表，处理泛型参数中的逗号
            string[] parts = SplitByTopLevelCommas(inheritancePart);

            // 第一个可能是基类，其余为接口
            bool isFirst = true;
            foreach (string part in parts)
            {
                string typeName = part.Trim();
                if (string.IsNullOrEmpty(typeName)) continue;

                if (IsKnownInterface(typeName))
                {
                    interfaces.Add(typeName);
                    continue;
                }

                // 如果是类/结构体，跳过
                if (IsClassOrStruct(typeName))
                    continue;
            }
        }

        return interfaces;
    }

    // 按顶级逗号分割（忽略泛型参数中的逗号）
    private static string[] SplitByTopLevelCommas(string input)
    {
        var result = new List<string>();
        int bracketDepth = 0;
        int genericDepth = 0;
        int startIndex = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];

            if (c == '<') genericDepth++;
            if (c == '>') genericDepth--;
            if (c == '(') bracketDepth++;
            if (c == ')') bracketDepth--;

            // 只处理顶级逗号
            if (c == ',' && bracketDepth == 0 && genericDepth == 0)
            {
                result.Add(input.Substring(startIndex, i - startIndex).Trim());
                startIndex = i + 1;
            }
        }

        // 添加最后一部分
        result.Add(input.Substring(startIndex).Trim());

        return result.ToArray();
    }

    // 判断是否为已知接口类型
    private static bool IsKnownInterface(string typeName)
    {
        // 预定义常见接口列表
        HashSet<string> knownInterfaces = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
    {
        "IEnumerable", "ICollection",
        "IList",  "IDictionary",
        "IReadOnlyCollection", "IReadOnlyList", "IReadOnlyDictionary",
        "IEquatable", "IComparable",  "ICloneable",
        "IDisposable", "INotifyPropertyChanged", "INotifyCollectionChanged","ABSAnimationComponent",
        "AppLovinPreInitializationService","CustomYieldInstruction","AndroidJavaProxy"
    };

        // 检查是否以I开头（接口命名约定）
        bool startsWithI = typeName.Length > 0 && typeName[0] == 'I' && char.IsUpper(typeName[1]);

        return knownInterfaces.Contains(typeName) || startsWithI;
    }

    // 判断是否为类或结构体
    private static bool IsClassOrStruct(string typeName)
    {
        // 预定义常见基类列表
        HashSet<string> knownBaseClasses = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
    {
        "Object", "ValueType", "Exception", "Attribute",
        "MonoBehaviour", "ScriptableObject", "Component",
        "UnityEngine.Object", "System.Object"
    };

        return knownBaseClasses.Contains(typeName) ||
               typeName.Contains("class ") ||
               typeName.Contains("struct ");
    }

    // 改进类声明检测方法，返回接口信息
    private static bool IsClassOrStructDeclaration(string line, out List<string> interfaces)
    {
        interfaces = new List<string>();
        if (line.Contains("class ") || line.Contains("struct ") || line.Contains("internal ") || line.Contains("interface ") || line.Contains("enum "))
        {
            interfaces = GetImplementedInterfaces(line);
            return true;
        }
        interfaces = null;
        return false;
    }

    // 修改原有的类声明检测方法调用
    private static bool IsClassOrStructDeclaration(string line)
    {
        List<string> interfaces;
        return IsClassOrStructDeclaration(line, out interfaces);
    }
}