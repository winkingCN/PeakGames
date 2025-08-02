using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[System.Serializable]
public class DataNode
{
    public string Key;
    public int Level;
    public object Value;
    public List<DataNode> Children = new List<DataNode>();
    public DataNode Parent;
    public DataNode(int level, string key, object value = null)
    {
        Level = level;
        Key = key;
        Value = value;
    }
}

public class FlexibleDataStructureExtractor : MonoBehaviour
{
    public DataNode BuildStructure(string data)
    {
        if (string.IsNullOrEmpty(data))
        {
            return null;
        }

        string[] lines = data.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        if (lines.Length == 0)
        {
            return null;
        }

        DataNode root = null;
        Stack<DataNode> stack = new Stack<DataNode>();

        foreach (string line in lines)
        {
            string trimmedLine = line.Trim();
            if (string.IsNullOrEmpty(trimmedLine))
            {
                continue;
            }

            string[] parts = trimmedLine.Split(new[] { ':' }, 2);
            if (parts.Length != 2 || !int.TryParse(parts[0].Trim(), out int level))
            {
                Debug.LogError($"Invalid line format: {line}");
                continue;
            }

            string key = parts[1].Trim();
            DataNode newNode = new DataNode(level, key);

            if (root == null)
            {
                root = newNode;
                stack.Push(newNode);
            }
            else
            {
                while (stack.Count > 0 && level <= stack.Peek().Level)
                {
                    stack.Pop();
                }

                if (stack.Count > 0)
                {
                    var dd = stack.Peek();
                    newNode.Parent = dd;
                    dd.Children.Add(newNode);
                    stack.Push(newNode);
                }
                else if (level == 0) // Handle potential new root if initial root was popped
                {
                    root = newNode;
                    stack.Push(newNode);
                }
                else
                {
                    Debug.LogError($"Orphaned node at level {level}: {key}");
                }
            }

            // Try to extract array size if it's an "Array-#-" node
            if (key.StartsWith("Array-#-"))
            {
                newNode.Value = 0;
            }
            else if (key.Contains("=")) // Extract value if it's a key-value pair
            {
                string[] keyValueParts = key.Split('=');
                newNode.Key = keyValueParts[0].Trim();
                newNode.Value = keyValueParts[1].Trim();
            }
        }
        //UpdateArray(root);
        return root;
    }

    private void UpdateArray(DataNode node)
    {
        if (node.Key == "Array-#-")
        {
            var par = node.Parent;
            if (par.Children.Count >= 2)
            {
                var len = par.Children.Count;
                for (var x = 2; x < len;)
                {
                    if (par.Children.Count > x)
                    {
                        par.Children[x].Children[0].Parent = node;
                        node.Children.Add(par.Children[x].Children[0]);
                        par.Children.RemoveAt(x);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if(par.Children.Count == 1)
            {
                for(var x =0;x < node.Children.Count;x++)
                {
                    if (node.Children[x].Children.Count > 0)
                    {
                        node.Children[x].Children[0].Parent = node;
                        node.Children.Insert(0,node.Children[x].Children[0]);
                        node.Children.RemoveAt(x);
                    }
                }
                for (var x = 0; x < node.Children.Count; )
                {
                    if (node.Children[x].Children.Count ==0 )
                    {
                        node.Children.RemoveAt(x);
                    }
                    else
                    {
                        x++;
                    }
                }
            }
        }
        for(var x =0;x < node.Children.Count;x++)
        {
            UpdateArray(node.Children[x]);
        }
    }

    public void PrintStructure(DataNode node, int depth = 0)
    {
        if (node == null)
        {
            return;
        }

        Debug.Log($"{new string('-', depth * 2)}Level: {node.Level}, Key: {node.Key}, Value: {node.Value}");

        foreach (DataNode child in node.Children)
        {
            PrintStructure(child, depth + 1);
        }
    }
    private int GetLevel(string line, int indentUnit)
    {
        int level = 0;
        while (level * indentUnit < line.Length && line[level * indentUnit] == ' ')
        {
            level++;
        }
        return level;
    }


    // 遍历结构并打印 Key 和 Level
    public string PrintKeysWithLevel(string data, int indentUnit = 1)
    {
        if (string.IsNullOrEmpty(data))
        {
            Debug.Log("Data is empty.");
            return "";
        }
        var datas = "";
        string[] lines = data.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string line in lines)
        {
            if (!string.IsNullOrWhiteSpace(line))
            {
                int level = GetLevel(line, indentUnit);
                string trimmedLine = line.TrimStart(' ');
                string key = "";

                if (trimmedLine.Contains("="))
                {
                    key = trimmedLine.Split('=')[0].Trim();
                    key = key.Split(" ")[key.Split(" ").Length - 1];
                }
                else if (trimmedLine.Contains("Array Array"))  
                {
                    key = "Array-#-";
                }
                else
                {
                    string[] parts = trimmedLine.Split(' ');
                    if (parts.Length > 0 && !parts[0].StartsWith("[")) // Avoid treating array index as key
                    {
                        key = parts[parts.Length - 1];
                    }
                    else if (parts[0].StartsWith("["))
                    {
                        key = trimmedLine.Replace("[", "").Replace("]", ""); // Keep array index as key for clarity
                    }
                }

                if (!string.IsNullOrEmpty(key))
                {
                    datas += $"{level} : {key}\n";
                    Debug.Log($"{level} : {key}");
                }
            }
        }
        return datas;
    }

    public List<string> GetHierarchyToKey(DataNode root, string targetKey)
    {
        List<string> hierarchy = new List<string>();
        if (FindPathToKey(root, targetKey, hierarchy))
        {
            //hierarchy.Reverse(); // Reverse to get the top-down path
            return hierarchy;
        }
        return null; // Key not found
    }
    public bool IsArray(DataNode node)
    {
        if (node == null)
        {
            return false;
        }
        if (node.Key != "Array-#-" )
        {
            return true;
        }

        foreach (DataNode child in node.Children)
        {
            if (IsArray(child))
            {
                return true;
            }
        }
        return false;
    }
    private bool FindPathToKey(DataNode node, string targetKey, List<string> path)
    {
        if (node == null)
        {
            return false;
        }
        if(node.Key!= "Array-#-"&& node.Parent != null)
        {
            if(node.Parent.Children.Count == 1 && node.Children.Count == 1)
            {
                path.Add("0");
            }
            else
            {
                path.Add($"{node.Key}");
            }
        }

        if (node.Key == targetKey)
        {
            return true;
        }

        foreach (DataNode child in node.Children)
        {
            if (FindPathToKey(child, targetKey, path))
            {
                return true;
            }
        }
        if(path.Count > 0)
            path.RemoveAt(path.Count - 1); // Backtrack if not found in this branch
        return false;
    }

    public string FormatHierarchy(List<string> hierarchy)
    {
        if (hierarchy == null || hierarchy.Count == 0)
        {
            return "";
        }

        string formattedHierarchy = "";
        for (int i = 0; i < hierarchy.Count - 1; i++)
        {
            formattedHierarchy += hierarchy[i];
            // Determine the index if the next level down is an array element
            if (i < hierarchy.Count - 2 && hierarchy[i + 1] == "Array-#-" && int.TryParse(hierarchy[i + 2], out int arrayIndex))
            {
                // We don't explicitly store the array index in the DataNode key,
                // so we need to infer it based on the structure.
                // This requires traversing the actual DataNode structure.
                DataNode currentNode = root;
                for (int j = 0; j <= i; j++)
                {
                    if (currentNode != null)
                    {
                        string currentKey = hierarchy[j];
                        if (currentKey == "Array-#-")
                        {
                            // Move to the correct array element
                            if (j < hierarchy.Count - 1 && int.TryParse(hierarchy[j + 1], out int index))
                            {
                                if (currentNode.Children.Count > index)
                                {
                                    currentNode = currentNode.Children[index];
                                    j++; // Skip the index in the hierarchy for the next iteration
                                }
                                else
                                {
                                    currentNode = null;
                                    break;
                                }
                            }
                            else
                            {
                                currentNode = null;
                                break;
                            }
                        }
                        else
                        {
                            currentNode = currentNode.Children.FirstOrDefault(child => child.Key == currentKey);
                            if (currentNode == null) break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                if (currentNode != null && currentNode.Children.Count > arrayIndex)
                {
                    // Find the index of the "Array" node among its siblings
                    DataNode parent = null;
                    DataNode tempRoot = root;
                    List<DataNode> pathFromRoot = new List<DataNode>();
                    Stack<DataNode> nodeStack = new Stack<DataNode>();
                    nodeStack.Push(tempRoot);
                    Dictionary<DataNode, DataNode> parentMap = new Dictionary<DataNode, DataNode>();
                    parentMap[tempRoot] = null;

                    while (nodeStack.Count > 0)
                    {
                        DataNode current = nodeStack.Pop();
                        if (current == currentNode.Parent) // Assuming we can access parent, if not, we need a more complex search
                        {
                            parent = current;
                            break;
                        }
                        foreach (var child in current.Children)
                        {
                            nodeStack.Push(child);
                            parentMap[child] = current;
                        }
                    }

                    if (parent != null)
                    {
                        int indexInParent = parent.Children.IndexOf(currentNode);
                        formattedHierarchy += $"={indexInParent}";
                    }
                    else
                    {
                        formattedHierarchy += "=<?>"; // Cannot determine index
                    }
                }
                else
                {
                    formattedHierarchy += "=<?>"; // Cannot determine index
                }
                i++; // Skip the array key in the next iteration
                i++; // Skip the array index in the next iteration
            }
            else
            {
                // For non-array elements, we need to find the index among siblings at the next level
                DataNode currentNode = root;
                for (int j = 0; j <= i; j++)
                {
                    if (currentNode != null)
                    {
                        string currentKey = hierarchy[j];
                        currentNode = currentNode.Children.FirstOrDefault(child => child.Key == currentKey);
                        if (currentNode == null) break;
                    }
                    else
                    {
                        break;
                    }
                }

                if (currentNode != null && i < hierarchy.Count - 1)
                {
                    DataNode parent = null;
                    DataNode tempRoot = root;
                    Stack<DataNode> nodeStack = new Stack<DataNode>();
                    nodeStack.Push(tempRoot);
                    Dictionary<DataNode, DataNode> parentMap = new Dictionary<DataNode, DataNode>();
                    parentMap[tempRoot] = null;

                    while (nodeStack.Count > 0)
                    {
                        DataNode current = nodeStack.Pop();
                        if (current.Children.Contains(currentNode))
                        {
                            parent = current;
                            break;
                        }
                        foreach (var child in current.Children)
                        {
                            nodeStack.Push(child);
                            parentMap[child] = current;
                        }
                    }

                    if (parent != null)
                    {
                        int indexInParent = parent.Children.IndexOf(currentNode);
                        formattedHierarchy += $"={indexInParent}";
                    }
                }
            }
        }
        formattedHierarchy += $"={hierarchy.Last()}";
        return formattedHierarchy;
    }


    public string targetField = "translations";
    public DataNode root;
    public void Awake()
    {
        string data = @"
0 MonoBehaviour Base
 0 PPtr<GameObject> m_GameObject
  0 int m_FileID = 0
  0 SInt64 m_PathID = 0
 1 UInt8 m_Enabled = 1
 0 PPtr<MonoScript> m_Script
  0 int m_FileID = 1
  0 SInt64 m_PathID = 3533
 1 string m_Name = ""LocData""
 0 int selectedSheetIndex = 0
 0 LocalizationSheet sheetVersions
  1 Array Array (1 items)
   0 int size = 1
   [0]
    0 LocalizationSheet data
     1 string name = ""MonsterSurvivors - Keywords""
     0 string languageCodes
      1 Array Array (10 items)
       0 int size = 10
       [0]
        1 string data = ""EN""
     0 LocalizationRow translationRows
      1 Array Array (2066 items)
       0 int size = 2066
       [0]
        0 LocalizationRow data
         1 string key = ""langName""
         0 string translations
          1 Array Array (10 items)
           0 int size = 10
           [0]
            1 string data = ""English""

";
        var processedData = PrintKeysWithLevel(data);
        root = BuildStructure(processedData);

        Debug.LogError("--- Parsed Structure ---");
        PrintStructure(root);

        List<string> hierarchyList = GetHierarchyToKey(root, targetField);

       
        if (hierarchyList != null)
        {
            var arrData = string.Join("=", hierarchyList);
            if (IsArray(root))
            {
                var dd = arrData.Replace("=data=", "=-Array-=");
                Debug.LogError(dd);
            }
            arrData = arrData.Replace("=data=", "=0=");
            Debug.Log(arrData);
        }
        else
        {
            Debug.LogError($"'{targetField}' not found in the structure.");
        }
    }
}