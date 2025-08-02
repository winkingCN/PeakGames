using UnityEngine;
using UnityEditor;
using UnityEngine.Networking;
using System.Threading.Tasks;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


public class TextSegment
{
    public enum Type
    {
        TEXT,
        TAG,
        NEWLINE
    }

    public Type type;
    public string content;

    public TextSegment(Type type, string content)
    {
        this.type = type;
        this.content = content;
    }
}
[System.Serializable]
public class GeminiRequest
{
    public Contents[] contents;
}
[System.Serializable]
public class Contents
{
    public Parts[] parts;
}

[System.Serializable]
public class Parts
{
    public string text;
}
public class APIResponseEditor : EditorWindow
{
    private string apiUrl = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key=AIzaSyChP7fKKlH-A8MRplG3MrWEnTdVmSkK20w"; // Example public API
    private bool showRawResponse = false;
    private int scriptMaxNum = 3500;
    private int scriptNum = 0;
    private string selectedFolderPath = "";
    private string selectedFolderPath1 = "";
    [MenuItem("Window/软著脚本生成与翻译游戏")]
    public static void ShowWindow()
    {
        GetWindow<APIResponseEditor>("API Response");
    }
    private static List<string> outRZScriptPaths = new List<string>();
    private static List<string> files = new List<string>();
    private static List<Dictionary<string, string>> fyDatas = new List<Dictionary<string, string>>();
    private void OnGUI()
    {
        GUILayout.Label("选择包含 C# 脚本的文件夹", EditorStyles.boldLabel);
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.TextField("文件夹路径:", selectedFolderPath);
        if (GUILayout.Button("脚本", GUILayout.Width(80)))
        {
            string path = EditorUtility.OpenFolderPanel("选择文件夹", "", "");
            if (!string.IsNullOrEmpty(path))
            {
                selectedFolderPath = path;
            }
        }
        EditorGUILayout.EndHorizontal();
        if (GUILayout.Button("生成软著源码"))
        {
            outRZScriptPaths.Clear();
            scriptNum = 0;
            GetAllFiles(selectedFolderPath);
            RZScriptPaths();
        }

        GUILayout.Label("选择翻译文本", EditorStyles.boldLabel);
        EditorGUILayout.BeginHorizontal();

        Rect dropArea = GUILayoutUtility.GetRect(0, 20, GUILayout.ExpandWidth(true));
        selectedFolderPath = EditorGUI.TextField(dropArea, "文件夹路径:", selectedFolderPath);

        // 拖拽支持
        Event evt = Event.current;
        if (dropArea.Contains(evt.mousePosition))
        {
            if (evt.type == EventType.DragUpdated || evt.type == EventType.DragPerform)
            {
                DragAndDrop.visualMode = DragAndDropVisualMode.Copy;
                if (evt.type == EventType.DragPerform)
                {
                    DragAndDrop.AcceptDrag();
                    if (DragAndDrop.paths != null && DragAndDrop.paths.Length > 0)
                    {
                        selectedFolderPath = DragAndDrop.paths[0];
                        if (selectedFolderPath.StartsWith("Assets/"))
                        {
                            selectedFolderPath = Application.dataPath + selectedFolderPath.Replace("Assets/", "/");
                        }
                        GUI.FocusControl(null); // 取消输入焦点，防止TextField被选中
                        Repaint();
                    }
                }
                evt.Use();
            }
        }
        if (GUILayout.Button("翻译", GUILayout.Width(80)))
        {
            string path = EditorUtility.OpenFilePanel("选择文件", "", "");
            if (!string.IsNullOrEmpty(path))
            {
                selectedFolderPath = path;
            }
        }
        EditorGUILayout.EndHorizontal();
        if (GUILayout.Button("生成中文翻译"))
        {
            if (selectedFolderPath.StartsWith("Assets/"))
            {
                selectedFolderPath = Application.dataPath + selectedFolderPath.Replace("Assets/", "/");
            }
            outRZScriptPaths.Clear();
            scriptNum = 0;
            var jsonDatas = File.ReadAllText(selectedFolderPath);
            selectedFolderPath1 = Path.GetDirectoryName(selectedFolderPath) + "\\" + Path.GetFileNameWithoutExtension(selectedFolderPath) + "-old.txt";
            var dic = TrimDictionaryKeys(JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonDatas));
            if (File.Exists(selectedFolderPath1) == false)
            {
                var datas = JsonConvert.SerializeObject(dic, Formatting.Indented);
                File.WriteAllText(selectedFolderPath1, datas);
            }
            var jsonDatas1 = File.ReadAllText(selectedFolderPath1);
            var dic1 = TrimDictionaryKeys(JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonDatas1));
            var oldDatas = new Dictionary<string, string>();
            var sdData = GetDifferentKeys(dic, dic1);
            if (sdData != null && sdData.Count > 0)
            {
                foreach (var sd in sdData)
                {
                    if (dic.ContainsKey(sd.Key) == false)
                    {
                        dic.Add(sd.Key, sd.Value);
                    }
                }
                var datas = JsonConvert.SerializeObject(dic, Formatting.Indented);
                File.WriteAllText(selectedFolderPath, datas);
            }
            sdData = GetDifferentKeys(dic1, dic);
            if (sdData != null && sdData.Count > 0)
            {
                foreach (var sd in sdData)
                {
                    Debug.LogError(sd.Key);
                }
                Debug.LogError("多出来的数据");

            }
            Debug.Log("开始");
            fyDatas.Clear();
            files.Clear();
            var data = new Dictionary<string, string>();
            var num = 0;

            foreach (var fyData in dic)
            {
                if (fyData.Key != "")
                {
                    if (fyData.Value != "")
                    {
                        oldDatas.Add(TrimOnlySpaces(fyData.Key), fyData.Value);
                    }
                    else
                    {
                        data.Add(TrimOnlySpaces(fyData.Key), fyData.Value);
                        num++;
                        if (num >= 100)
                        {
                            num = 0;
                            fyDatas.Add(data);
                            data = new Dictionary<string, string>();
                        }
                    }
                }
            }
            if (data.Count > 0 && data.Count < 100)
            {
                fyDatas.Add(data);
            }
            if (oldDatas.Count > 0)
            {
                fyDatas.Insert(0, oldDatas);
                scriptNum = 1;
            }
            AIFyPaths();
        }
        if (GUILayout.Button("XML转Json格式"))
        {
            var dic = new Dictionary<string, string>();
            var dic1 = new Dictionary<string, string>();
            var xml = new System.Xml.XmlDocument();
            xml.Load(selectedFolderPath);
            foreach (System.Xml.XmlNode node in xml.DocumentElement.ChildNodes)
            {
                if (node.NodeType == System.Xml.XmlNodeType.Element)
                {
                    string key = node.InnerText;
                    dic[key] = "";
                    dic1[(key)] = TrimOnlySpaces(key);
                }
            }
            var path = selectedFolderPath.Replace(".xml", "_key.json");
            selectedFolderPath = selectedFolderPath.Replace(".xml", ".json");
            var datas = JsonConvert.SerializeObject(dic, Formatting.Indented);
            File.WriteAllText(selectedFolderPath, datas);
            File.WriteAllText(path, JsonConvert.SerializeObject(dic1, Formatting.Indented));
            AssetDatabase.Refresh();
        }
        if (GUILayout.Button("Json数据转换成XML格式数据"))
        {
            var keyPaht = selectedFolderPath.Replace(".json", "_key.json");
            var dic0 = (JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(keyPaht)));
            var dic1 = TrimDictionaryKeys(JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(selectedFolderPath)));
            var path = selectedFolderPath.Replace(".json", ".xml");
            if (File.Exists(path))
            {
                var xml = new System.Xml.XmlDocument();
                xml.Load(path);
                foreach (System.Xml.XmlNode node in xml.DocumentElement.ChildNodes)
                {
                    if (node.NodeType == System.Xml.XmlNodeType.Element)
                    {
                        if (dic0.TryGetValue(node.InnerText, out var key))
                        {
                            if (dic1.TryGetValue(key, out var value))
                            {
                                node.InnerText = value; // 更新节点的文本内容
                            }
                            else
                            {
                                Debug.LogError("没有找到翻译   " + node.InnerText);
                            }
                        }
                        else
                        {
                            Debug.LogError(node.InnerText);
                        }
                    }
                }
                xml.Save(path); // 保存修改到原文件
                AssetDatabase.Refresh();
            }
        }
        if (GUILayout.Button("优化翻译"))
        {
            UpdateFYData();
        }
        if (GUILayout.Button("中文"))
        {
            var jsonDatas = File.ReadAllText(selectedFolderPath);
            var dic = TrimDictionaryKeys(JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonDatas));
            Dictionary<string, string> newDics = new Dictionary<string, string>();
            foreach (var item in dic)
            {
                newDics[item.Value] = item.Value;
            }
            selectedFolderPath1 = Path.GetDirectoryName(selectedFolderPath) + "\\" + Path.GetFileNameWithoutExtension(selectedFolderPath) + "-中文.json";
            var datas = JsonConvert.SerializeObject(newDics, Formatting.Indented);
            File.WriteAllText(selectedFolderPath1, datas);
        }
    }
    /// <summary>
    /// 返回一个新字典，所有 key 去除首尾空格
    /// </summary>
    /// <param name="source">原始字典</param>
    /// <returns>key 已去除首尾空格的新字典</returns>
    public Dictionary<string, string> TrimDictionaryKeys(Dictionary<string, string> source)
    {
        var result = new Dictionary<string, string>();
        foreach (var kv in source)
        {
            var trimmedKey = TrimOnlySpaces(kv.Key);
            // 避免 key 重复
            if (!result.ContainsKey(trimmedKey))
                result.Add(trimmedKey, kv.Value);
        }
        return result;
    }

    /// <summary>
    /// 对比两个字典，将 key 不同的项存储到新字典并输出
    /// </summary>
    /// <param name="dictA">第一个字典</param>
    /// <param name="dictB">第二个字典</param>
    /// <returns>包含所有 key 不同项的新字典</returns>
    public Dictionary<string, string> GetDifferentKeys(Dictionary<string, string> dictA, Dictionary<string, string> dictB)
    {
        var result = new Dictionary<string, string>();
        foreach (var kv in dictB)
        {
            if (!dictA.ContainsKey(kv.Key))
            {
                result[kv.Key] = kv.Value;
            }
        }
        return result;
    }

    public string TrimOnlySpaces(string input)
    {
        if (input == null) return null;
        return RemoveLeadingAndTrailingQuote(Regex.Replace(input, @"^\s+|\s+$", "", RegexOptions.None));
    }
    private async void AIFyPaths()
    {
        if (fyDatas.Count > 0 && scriptNum < fyDatas.Count)
        {

            try
            {
                await AiFy();
            }
            catch (FileNotFoundException)
            {
                AIFyPaths(); // Try the next file
            }
            catch (IOException e)
            {
                AIFyPaths(); // Try the next file
            }
        }
        else
        {

            Debug.LogError("完成");

        }
    }
    public string MergeFyDatasToJson()
    {
        var merged = new Dictionary<string, string>();
        foreach (var dict in fyDatas)
        {
            if (dict == null) continue;
            foreach (var kv in dict)
            {
                // 如果 key 已存在，可以选择覆盖或跳过，这里选择覆盖
                merged[kv.Key] = kv.Value;
            }
        }
        return JsonConvert.SerializeObject(merged, Formatting.Indented);
    }
    public string RemoveFirstAndLastChar(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length <= 2)
            return string.Empty;
        return input.Substring(1, input.Length - 2);
    }
    public async void UpdateFYData()
    {
        string escapedText = JsonConvert.SerializeObject($@"作为游戏翻译专家帮我将文档中的不合适的翻译列举出来重新翻译并按照相同的格式并剔除不需要修改的只输出需要优化的:{File.ReadAllText(selectedFolderPath)}");

        GeminiRequest request = new GeminiRequest
        {
            contents = new Contents[]
             {
                new Contents
                {
                    parts = new Parts[]
                    {
                        new Parts { text = escapedText }
                    }
                }
             }
        };
        string jsonPayload = JsonConvert.SerializeObject(request, Newtonsoft.Json.Formatting.Indented); // Use Formatting.Indented for readability in the Inspector
        Debug.Log(jsonPayload);
        var newData = new Dictionary<string, string>();
        var num = apiPath.Split("\n").Length;
        await FetchDataFromAPI(jsonPayload, (_apiResponse) =>
        {
            if (_apiResponse != "")
            {
                _apiResponse = _apiResponse.Replace("```", "");
                var dic = ParseTranslationFile(_apiResponse);
                var jsonDatas = File.ReadAllText(selectedFolderPath);
                selectedFolderPath1 = Path.GetDirectoryName(selectedFolderPath) + "\\" + Path.GetFileNameWithoutExtension(selectedFolderPath) + "-old.txt";
                var dicData = TrimDictionaryKeys(JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonDatas));
                foreach (var ddd in dic)
                {
                    if (dicData.ContainsKey(ddd.Key))
                    {
                        Debug.Log(ddd.Key + "     " + ddd.Value + "  ========  " + dicData[ddd.Key]);
                        if (ddd.Key.Contains("<") && ParseText(ddd.Key).Count == ParseText(ddd.Value).Count)
                        {
                            dicData[ddd.Key] = ddd.Value;
                        }
                        else
                        {
                            dicData[ddd.Key] = ddd.Value;
                        }
                    }
                    else
                    {
                        Debug.LogError(ddd.Key + "     " + ddd.Value);
                    }
                }
                var datas = JsonConvert.SerializeObject(dicData, Formatting.Indented);
                File.WriteAllText(selectedFolderPath, datas);
            }
        });
    }
    public static List<TextSegment> ParseText(string text)
    {
        List<TextSegment> segments = new List<TextSegment>();
        Regex pattern = new Regex(@"<[^>]+>|\n");
        Match matcher = pattern.Match(text);
        int lastEnd = 0;
        var max = text.Length;
        while (matcher.Success)
        {
            if (matcher.Index > lastEnd)
            {
                // 添加纯文本段落
                segments.Add(new TextSegment(TextSegment.Type.TEXT, text.Substring(lastEnd, matcher.Index - lastEnd)));
            }
            // 添加标签或换行符
            string match = matcher.Value;
            if (match == "\n")
            {
                segments.Add(new TextSegment(TextSegment.Type.NEWLINE, "\n"));
            }
            else
            {
                segments.Add(new TextSegment(TextSegment.Type.TAG, match));
            }
            lastEnd = matcher.Length + matcher.Index;
            matcher = matcher.NextMatch();
        }

        if (lastEnd < text.Length)
        {
            // 添加剩余的纯文本段落
            segments.Add(new TextSegment(TextSegment.Type.TEXT, text.Substring(lastEnd)));
        }

        return segments;
    }
    public Dictionary<string, string> ParseTranslationFile(string filePath)
    {
        var translations = new Dictionary<string, string>();

        try
        {
            // Read all lines from the file
            string[] lines = filePath.Split("\n");

            foreach (string line in lines)
            {
                if (line.Contains(":"))
                {
                    var list = line.Split(":");
                    translations[TrimOnlySpaces(list[0])] = TrimOnlySpaces(list[1]);
                }
            }
        }
        catch (System.Exception ex)
        {
            Debug.LogError($"Error parsing translation file: {ex.Message}");
            return null; // Or throw the exception, depending on your error handling strategy
        }

        return translations;
    }
    public async Task AiFy()
    {
        apiPath = ConvertDictionaryToJson(fyDatas[scriptNum]);
        while (apiPath == "")
        {
            scriptNum++;
            if (scriptNum < fyDatas.Count)
            {
                apiPath = ConvertDictionaryToJson(fyDatas[scriptNum]);
            }
            else
            {
                Debug.LogError("翻译完毕");
                return;
            }
        }
        string escapedText = JsonConvert.SerializeObject($@"作为一个游戏翻译专家帮我将传入的游戏文案翻译成中文,格式为相同的格式返回，并填写到相应的key中:{apiPath}");
        Debug.Log(escapedText);
        GeminiRequest request = new GeminiRequest
        {
            contents = new Contents[]
             {
                new Contents
                {
                    parts = new Parts[]
                    {
                        new Parts { text = escapedText }
                    }
                }
             }
        };
        string jsonPayload = JsonConvert.SerializeObject(request, Newtonsoft.Json.Formatting.Indented); // Use Formatting.Indented for readability in the Inspector
        Debug.Log(jsonPayload);
        var newData = new Dictionary<string, string>();
        var num = apiPath.Split("\n").Length;
        await FetchDataFromAPI(jsonPayload, (_apiResponse) =>
        {
            if (_apiResponse != "")
            {
                _apiResponse = _apiResponse.Replace("```", "");
                Debug.LogError(_apiResponse);
                var dic = ParseSimpleJsonToDictionary(_apiResponse);
                if (dic != null)
                {
                    foreach (var iii in dic)
                    {
                        newData[(RemoveLeadingAndTrailingQuote(iii.Key))] = RemoveLeadingAndTrailingQuote(iii.Value);
                    }
                    dic.Clear();
                    foreach (var iii in newData)
                    {
                        dic.Add(iii.Key, iii.Value);
                    }
                    newData.Clear();
                    var old = fyDatas[scriptNum];
                    foreach (var fyData in old)
                    {
                        if (fyData.Value != "")
                        {
                            newData.Add(fyData.Key, fyData.Value);
                        }
                    }

                    foreach (var itd in newData)
                    {
                        old.Remove(itd.Key);
                    }
                    Dictionary<string, string> dataList = new Dictionary<string, string>();
                    if (old.Count < dic.Count && num == dic.Count)
                    {
                        var dicList = new Dictionary<int, Dictionary<string, KeyValuePair<string, string>>>();
                        foreach (var fyData in dic)
                        {
                            if (fyData.Key.Contains("#-"))
                            {
                                var items = fyData.Key.Split("#-");
                                var id = int.Parse(items[0]);
                                if (dicList.TryGetValue(id, out var ddic) == false)
                                {
                                    ddic = new Dictionary<string, KeyValuePair<string, string>>();
                                    dicList.Add(id, ddic);
                                }
                                ddic.Add(items[1], fyData);
                            }
                        }


                        foreach (var it in dicList)
                        {
                            var id = 0;
                            dataList.Clear();
                            foreach (var itm in old)
                            {
                                if (id == it.Key)
                                {
                                    var lenDatas = itm.Key.Split("\n");
                                    var idd = 0;
                                    for (var i = 0; i < it.Value.Count; ++i)
                                    {
                                        if (it.Value[i.ToString()].Value == "")
                                        {
                                            var d = it.Value[i.ToString()].Key.Split("#-");
                                            while (lenDatas[idd] == "")
                                            {
                                                idd++;
                                            }
                                            lenDatas[idd] = d[d.Length - 1];
                                            idd++;
                                        }
                                        else
                                        {
                                            var d = it.Value[i.ToString()].Value.Split("#-");
                                            while (lenDatas[idd] == "")
                                            {
                                                idd++;
                                            }
                                            lenDatas[idd] = d[d.Length - 1];
                                            idd++;
                                        }

                                    }
                                    dataList.Add(itm.Key, ToArrayList(lenDatas));
                                    break;
                                }
                                else
                                {
                                    id++;
                                }
                            }
                            foreach (var dd in dataList)
                            {
                                old[dd.Key] = dd.Value;
                            }
                        }
                    }
                    dataList.Clear();
                    foreach (var fyData in dic)
                    {
                        if (old.ContainsKey(fyData.Key))
                        {
                            newData.Add(fyData.Key, fyData.Value);
                            old.Remove(fyData.Key);
                        }
                        else
                        {
                            dataList.Add(fyData.Key, fyData.Value);
                        }
                    }

                    if (old.Count == 0)
                    {
                        fyDatas[scriptNum] = newData;
                    }
                    else
                    {
                        foreach (var ii in dataList)
                        {
                            var key = "";
                            foreach (var ol in old)
                            {
                                if (ol.Key.Contains(ii.Key))
                                {
                                    newData.Add(ii.Key, ii.Value);
                                    key = ol.Key;
                                    //old.Remove(fyData.Key);
                                    break;
                                }
                            }
                            if (key != "")
                            {
                                old.Remove(key);
                            }
                        }
                        foreach (var ne in newData)
                        {
                            old.Add(ne.Key, ne.Value);
                        }
                    }
                    var datas = MergeFyDatasToJson();
                    File.WriteAllText(selectedFolderPath, datas);
                    scriptNum++;
                }
            }

            if (IsError == false)
                AIFyPaths();
            else
                Debug.LogError("翻译失败");

        });
    }
    public static Dictionary<string, string> ParseSimpleJsonToDictionary(string json)
    {
        Dictionary<string, string> result = new Dictionary<string, string>();

        // 1. 移除 JSON 字符串开头和结尾的花括号 {}
        json = json.Trim().Trim('{', '}');

        // 2. 按逗号和换行符分割成单独的键值对字符串
        // 这里需要更智能的分割，因为值中可能包含逗号。
        // 对于你提供的这种简单结构，我们可以先将所有内容看作一行，然后根据",\""分割
        // 更健壮的做法是使用正则表达式，但为了“不使用JSON形式”，我们尝试字符串操作

        // 替换掉所有空白字符和换行符，让它成为一行，方便后续处理
        json = json.Replace("\r", "");

        // 分割字符串，但要避免分割引号内的逗号。这仍然是挑战。
        // 对于你给的格式，键值对之间是 ","
        string[] pairs = json.Split("\n");

        foreach (string pair in pairs)
        {
            // 找到第一个冒号 ":" 的位置，它将键和值分开
            int colonIndex = pair.IndexOf(':');
            if (colonIndex > 0)
            {
                string key = pair.Substring(0, colonIndex).Trim();
                string value = pair.Substring(colonIndex + 1).Trim();

                // 移除键和值两边的双引号
                if (key.StartsWith("\"") && key.EndsWith("\""))
                {
                    key = key.Substring(1, key.Length - 2);
                }
                if (value.StartsWith("\"") && value.EndsWith("\""))
                {
                    value = value.Substring(1, value.Length - 2);
                }

                // 处理最后一个元素后可能多出的引号
                if (value.EndsWith("\""))
                {
                    value = value.Substring(0, value.Length - 1);
                }
                if (value.StartsWith("\""))
                {
                    value = value.Substring(1, value.Length - 1);
                }

                result[key] = value;
            }
        }
        return result;
    }
    public static string RemoveLeadingAndTrailingQuote(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        int start = 0;
        int end = input.Length;

        // 删除首部连续的 \ 或 "
        while (start < end && (input[start] == '\\' || input[start] == '\"'))
            start++;

        // 删除尾部连续的 \ 或 "
        while (end > start && (input[end - 1] == '\\' || input[end - 1] == '\"'))
            end--;

        return NormalizeBackslashes(input.Substring(start, end - start).ToLower());
    }
    public static string NormalizeBackslashes(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        var sb = new StringBuilder();
        int i = 0;
        while (i < input.Length)
        {
            if (input[i] == '\\')
            {
                int slashCount = 1;
                int j = i + 1;
                // 统计连续的反斜杠数量
                while (j < input.Length && input[j] == '\\')
                {
                    slashCount++;
                    j++;
                }

                // 检查下一个非\字符
                char nextChar = (j < input.Length) ? input[j] : '\0';

                if (slashCount >= 2)
                {
                    if (nextChar == '"' || nextChar == 'n' || nextChar == '\\')
                    {
                        sb.Append('\\');
                    }
                    else
                    {
                        sb.Append('\\').Append('\\');
                    }
                    i += slashCount;
                }
                else
                {
                    sb.Append('\\');
                    i++;
                }
            }
            else
            {
                sb.Append(input[i]);
                i++;
            }
        }
        return sb.ToString();
    }
    private string ToArrayList(string[] data)
    {
        var d = "";
        for (var x = 0; x < data.Length; ++x)
        {
            d += data[x];
        }
        return d;
    }
    public string ConvertDictionaryToJson(Dictionary<string, string> dictionary)
    {
        var data = "";
        var idx = 0;
        foreach (var da in dictionary)
        {
            if (da.Value == "" && da.Key != "")
            {
                if (da.Key.Contains('\n'))
                {
                    var list = da.Key.Split("\n");
                    var ii = 0;
                    foreach (var it in list)
                    {
                        if (it != "")
                        {

                            data += "\"" + idx + "#-" + ii + "#-" + it + "\"" + "\n";
                            ii++;
                        }
                    }
                }
                else
                {
                    data += "\"" + da.Key + "\"" + "\n";
                }
                idx++;
            }
        }
        if (string.IsNullOrEmpty(data) || data.Length == 1)
            return string.Empty;
        if (data.Length == 0)
            return data;
        return data.Substring(0, data.Length - 1);
    }
    private static List<string> GetAllFiles(string folderPath)
    {
        files.Clear();
        string[] filePaths = Directory.GetFiles(folderPath, "*.cs", SearchOption.AllDirectories);
        files.AddRange(filePaths);
        if (files.Count == 0)
        {
            EditorUtility.DisplayDialog("提示", "该文件夹下没有找到任何 C# 脚本文件。", "好的");
            return files;
        }
        return files;
    }
    /// <summary>
    /// 删除给定代码字符串中的注释。
    /// </summary>
    /// <param name="code">要处理的代码字符串。</param>
    /// <returns>删除注释后的代码字符串。</returns>
    private static string RemoveComments(string code)
    {
        // 移除单行注释 (//...)
        code = Regex.Replace(code, @"//.*", "");
        // 移除多行注释 (/* ... */)
        code = Regex.Replace(code, @"/\*[\s\S]*?\*/", "");
        // 移除空行（包括只包含空白字符的行）
        code = Regex.Replace(code, @"^\s*$\n|\r", "", RegexOptions.Multiline);
        // 移除连续的多个空行，只保留一个
        code = Regex.Replace(code, @"(\r?\n\s*){2,}", "\r\n");
        return code;
    }
    private async void RZScriptPaths()
    {
        if (files.Count > 0)
        {
            if (scriptNum < scriptMaxNum)
            {
                var idx = Random.Range(0, files.Count);
                apiPath = files[idx];
                files.RemoveAt(idx);
                var data = File.ReadAllText(apiPath);
                if (data != "")
                {
                    string jsonPayload = $@"{{
                        ""contents"": [{{
                            ""parts"": [{{""text"": ""{"帮我将下面的Unity3D引擎的C#脚本补全，不需要注释，以及解释介绍。代码如下:" + RemoveComments(data)}""}}]
                        }}]
                    }}";
                    await FetchDataFromAPI(jsonPayload, (ass) =>
                    {
                        if (ass != "")
                        {
                            File.WriteAllText(apiPath, (ass));
                            List<string> paths = new List<string>();
                            paths.Clear();
                            scriptNum += File.ReadAllLines(apiPath).Length;
                            outRZScriptPaths.Add(apiPath);
                        }
                        Debug.LogError(apiPath);
                        if (IsError == false)
                            RZScriptPaths();
                        Repaint();

                    });
                }

                else
                {
                    RZScriptPaths();
                }
            }
            else
            {
                var path = Path.GetDirectoryName(selectedFolderPath) + "/Scripts";
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, true);
                }
                Directory.CreateDirectory(path);
                foreach (var filePath in outRZScriptPaths)
                {
                    try
                    {
                        if (File.Exists(filePath))
                        {
                            string fileName = Path.GetFileName(filePath);
                            string destFile = Path.Combine(path, fileName);
                            File.Copy(filePath, destFile, true);
                            Debug.Log($"已复制文件: {fileName} 到目标文件夹");
                        }
                        else
                        {
                            Debug.LogWarning($"源文件不存在: {filePath}");
                        }
                    }
                    catch (IOException e)
                    {
                        Debug.LogError($"复制文件时发生错误: {filePath}\n{e.Message}");
                    }
                }
                EditorUtility.DisplayDialog("完成", $"已生成 {outRZScriptPaths.Count} 个脚本，并保存到 {path} 目录。", "确定");
                outRZScriptPaths.Clear();
            }
        }
    }
    private string apiPath = "";
    private string apiResponse;
    private bool IsError = false;
    private async Task FetchDataFromAPI(string promptText, System.Action<string> action)
    {
        Debug.LogError(scriptNum);
        // Create the JSON payload


        using (UnityWebRequest webRequest = new UnityWebRequest(apiUrl, "POST"))
        {
            byte[] bodyRaw = Encoding.UTF8.GetBytes(promptText);
            webRequest.uploadHandler = new UploadHandlerRaw(bodyRaw);
            webRequest.downloadHandler = new DownloadHandlerBuffer();
            webRequest.SetRequestHeader("Content-Type", "application/json");

            // Request and wait for the desired page.
            var asyncOperation = webRequest.SendWebRequest();

            while (!asyncOperation.isDone)
            {
                await Task.Delay(100); // Keep the editor responsive
            }

            if (webRequest.result == UnityWebRequest.Result.Success)
            {
                string rawResponse = webRequest.downloadHandler.text;

                if (showRawResponse)
                {
                    apiResponse = rawResponse;
                }
                else
                {
                    try
                    {
                        // Parse the JSON response
                        JObject jsonResponse = JObject.Parse(rawResponse);

                        // Extract the text content
                        string textContent = jsonResponse["candidates"]?[0]?["content"]?["parts"]?[0]?["text"]?.ToString();

                        if (!string.IsNullOrEmpty(textContent))
                        {
                            apiResponse = textContent;
                            apiResponse = RemoveComments(ExtractCodeJsonFromMarkdown(apiResponse));
                            if (apiResponse != "")
                            {
                                if (apiResponse.Contains("\"english\": {"))
                                {
                                    apiResponse = RemoveFirstAndLastChar(apiResponse.Replace("\"english\": {", "{"));
                                }
                                apiResponse = apiResponse.Replace("\\\\", "\\").Replace("\",", "");
                                Debug.LogError(apiResponse);
                                action?.Invoke(apiResponse);
                            }
                        }
                        else
                        {
                            IsError = true;
                            apiResponse = "No text content found in the response.";
                            action?.Invoke("");
                            Debug.LogError(apiResponse);
                        }
                    }
                    catch (System.Exception e)
                    {
                        action?.Invoke("");
                        IsError = true;
                        apiResponse = $"Error parsing JSON: {e.Message}\n\nRaw response: {rawResponse}";
                        Debug.Log(apiResponse);

                    }

                }
            }
            else
            {
                IsError = true;
                action?.Invoke("");
                apiResponse = $"Error: {webRequest.error}\nResponse: {webRequest.downloadHandler.text}";
                Debug.LogError(apiResponse);
                Debug.LogError(promptText);
            }

        }
    }
    /// <summary>
    /// 从Markdown格式的文本中提取代码块。
    /// 提取```csharp和```之间的代码。
    /// </summary>
    /// <param name="markdown">包含代码块的Markdown文本</param>
    /// <returns>提取出的代码，如果没有找到则返回原文本</returns>
    private static string ExtractCodeFromMarkdown(string markdown)
    {
        // 使用正则表达式查找```csharp和```之间的内容
        string pattern = @"```csharp\s*([\s\S]*?)\s*```";

        // 查找匹配项
        Match match = Regex.Match(markdown, pattern);

        if (match.Success && match.Groups.Count > 1)
        {
            // 返回第一个捕获组（代码块内容）
            return match.Groups[1].Value.Trim();
        }

        // 如果没有找到csharp代码块，尝试查找普通代码块
        pattern = @"```\s*([\s\S]*?)\s*```";
        match = Regex.Match(markdown, pattern);

        if (match.Success && match.Groups.Count > 1)
        {
            return match.Groups[1].Value.Trim();
        }

        // 如果没有找到任何代码块，返回原始文本
        return "";
    }
    private static string ExtractCodeJsonFromMarkdown(string markdown)
    {
        // 使用正则表达式查找```csharp和```之间的内容
        string pattern = @"```json\s*([\s\S]*?)\s*```";

        // 查找匹配项
        Match match = Regex.Match(markdown, pattern);

        if (match.Success && match.Groups.Count > 1)
        {
            // 返回第一个捕获组（代码块内容）
            return match.Groups[1].Value.Trim();
        }

        // 如果没有找到csharp代码块，尝试查找普通代码块
        pattern = @"```\s*([\s\S]*?)\s*```";
        match = Regex.Match(markdown, pattern);

        if (match.Success && match.Groups.Count > 1)
        {
            return match.Groups[1].Value.Trim();
        }

        // 如果没有找到任何代码块，返回原始文本
        return markdown;
    }
}