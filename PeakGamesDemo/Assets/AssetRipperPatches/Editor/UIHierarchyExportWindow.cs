using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using System.IO;

public class UIHierarchyExportWindow : EditorWindow
{
    private List<GameObject> rootObjects = new List<GameObject>();
    private List<bool> infoFoldouts = new List<bool>();
    private List<bool> rectFoldouts = new List<bool>();
    private List<bool> compFoldouts = new List<bool>();
    private string autoExportPath = "Assets/UIHierarchyExport_Auto.json";

    [MenuItem("Tools/对象层级导出到JSON")]
    public static void ShowWindow()
    {
        var window = GetWindow<UIHierarchyExportWindow>("层级导出");
        window.LoadFromJsonOnOpen();
    }

    private void LoadFromJsonOnOpen()
    {
        rootObjects = new List<GameObject>();
        infoFoldouts = new List<bool>();
        rectFoldouts = new List<bool>();
        compFoldouts = new List<bool>();

        if (File.Exists(autoExportPath))
        {
            string json = File.ReadAllText(autoExportPath);
            var exportRoot = JsonUtility.FromJson<UIHierarchyExportRoot>(json);
            if (exportRoot != null && exportRoot.items != null)
            {
                foreach (var item in exportRoot.items)
                {
                    var go = FindGameObjectByPath(item.path);
                    rootObjects.Add(go);
                    infoFoldouts.Add(true);
                    rectFoldouts.Add(false);
                    compFoldouts.Add(false);
                }
            }
        }
    }
    private GameObject FindGameObjectByPath(string path)
    {
        if (string.IsNullOrEmpty(path)) return null;
        string[] names = path.Split('/');
        Transform current = null;
        foreach (var root in UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects())
        {
            if (root.name == names[0])
            {
                current = root.transform;
                break;
            }
        }
        if (current == null) return null;
        for (int i = 1; i < names.Length; i++)
        {
            current = current.Find(names[i]);
            if (current == null) return null;
        }
        return current.gameObject;
    }

    private Vector2 scroll;

    private void OnGUI()
    {
        while (infoFoldouts.Count < rootObjects.Count) infoFoldouts.Add(true);
        while (rectFoldouts.Count < rootObjects.Count) rectFoldouts.Add(false);
        while (compFoldouts.Count < rootObjects.Count) compFoldouts.Add(false);

        GUILayout.Label("批量选择UI根对象", EditorStyles.boldLabel);

        scroll = EditorGUILayout.BeginScrollView(scroll);

        for (int i = 0; i < rootObjects.Count; i++)
        {
            EditorGUILayout.BeginVertical("box");
            EditorGUILayout.BeginHorizontal();
            rootObjects[i] = (GameObject)EditorGUILayout.ObjectField("UI根对象", rootObjects[i], typeof(GameObject), true);
            if (GUILayout.Button("移除", GUILayout.Width(50)))
            {
                rootObjects.RemoveAt(i);
                i--;
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.EndVertical();
                continue;
            }
            EditorGUILayout.EndHorizontal();

            // 展示该对象的所有组件
            // 展示该对象的所有组件（可编辑 enabled 状态）
            if (rootObjects[i] != null)
            {
                var go = rootObjects[i];
                var t = go.transform;
                var rect = go.GetComponent<RectTransform>();
                 
                // 对象信息折叠
                infoFoldouts[i] = EditorGUILayout.Foldout(infoFoldouts[i], "对象信息", true);
                if (infoFoldouts[i])
                {
                    go.name = EditorGUILayout.TextField("Name", go.name);
                    EditorGUILayout.LabelField("Path", AnimationUtility.CalculateTransformPath(t, null));
                    go.SetActive(EditorGUILayout.Toggle("ActiveSelf", go.activeSelf));

                    Vector3 pos = EditorGUILayout.Vector3Field("Local Position", t.localPosition);
                    if (pos != t.localPosition) { Undo.RecordObject(t, "Edit Local Position"); t.localPosition = pos; EditorUtility.SetDirty(t); }
                    Vector3 scale = EditorGUILayout.Vector3Field("Local Scale", t.localScale);
                    if (scale != t.localScale) { Undo.RecordObject(t, "Edit Local Scale"); t.localScale = scale; EditorUtility.SetDirty(t); }
                    Vector3 rot = EditorGUILayout.Vector3Field("Local Rotation", t.localRotation.eulerAngles);
                    if (rot != t.localRotation.eulerAngles) { Undo.RecordObject(t, "Edit Local Rotation"); t.localRotation = Quaternion.Euler(rot); EditorUtility.SetDirty(t); }
                }

                // RectTransform 信息折叠
                if (rect != null)
                {
                    rectFoldouts[i] = EditorGUILayout.Foldout(rectFoldouts[i], "RectTransform 信息", true);
                    if (rectFoldouts[i])
                    {
                        Vector2 anchoredPos = EditorGUILayout.Vector2Field("Anchored Position", rect.anchoredPosition);
                        if (anchoredPos != rect.anchoredPosition) { Undo.RecordObject(rect, "Edit Anchored Position"); rect.anchoredPosition = anchoredPos; EditorUtility.SetDirty(rect); }
                        Vector2 sizeDelta = EditorGUILayout.Vector2Field("Size Delta", rect.sizeDelta);
                        if (sizeDelta != rect.sizeDelta) { Undo.RecordObject(rect, "Edit Size Delta"); rect.sizeDelta = sizeDelta; EditorUtility.SetDirty(rect); }
                        Vector2 anchorMin = EditorGUILayout.Vector2Field("Anchor Min", rect.anchorMin);
                        if (anchorMin != rect.anchorMin) { Undo.RecordObject(rect, "Edit Anchor Min"); rect.anchorMin = anchorMin; EditorUtility.SetDirty(rect); }
                        Vector2 anchorMax = EditorGUILayout.Vector2Field("Anchor Max", rect.anchorMax);
                        if (anchorMax != rect.anchorMax) { Undo.RecordObject(rect, "Edit Anchor Max"); rect.anchorMax = anchorMax; EditorUtility.SetDirty(rect); }
                        Vector2 pivot = EditorGUILayout.Vector2Field("Pivot", rect.pivot);
                        if (pivot != rect.pivot) { Undo.RecordObject(rect, "Edit Pivot"); rect.pivot = pivot; EditorUtility.SetDirty(rect); }
                    }
                }

                // 组件列表折叠
                compFoldouts[i] = EditorGUILayout.Foldout(compFoldouts[i], "组件列表（可编辑）", true);
                if (compFoldouts[i])
                {
                    var comps = go.GetComponents<Component>();
                    foreach (var comp in comps)
                    {
                        if (comp == null) continue;
                        var type = comp.GetType();
                        var enabledProp = type.GetProperty("enabled");
                        if (enabledProp != null && enabledProp.PropertyType == typeof(bool))
                        {
                            bool enabled = (bool)enabledProp.GetValue(comp, null);
                            bool newEnabled = EditorGUILayout.ToggleLeft(type.Name, enabled);
                            if (newEnabled != enabled)
                            {
                                Undo.RecordObject(comp as Object, "Toggle Component Enabled");
                                enabledProp.SetValue(comp, newEnabled, null);
                                EditorUtility.SetDirty(comp as Object);
                                AutoExportToJson(); 
                            }
                        }
                    }
                }
            }


            if (GUILayout.Button("移除", GUILayout.Width(50)))
            {
                rootObjects.RemoveAt(i);
                infoFoldouts.RemoveAt(i);
                rectFoldouts.RemoveAt(i);
                compFoldouts.RemoveAt(i);
                i--;
                AutoExportToJson();
                continue;
            }



            EditorGUILayout.EndVertical();
            GUILayout.Space(5);
        }

        EditorGUILayout.EndScrollView();

        GUILayout.Space(10);
        if (GUILayout.Button("添加选中对象"))
        {
            if (Selection.activeGameObject != null)
            {
                if (!rootObjects.Contains(Selection.activeGameObject))
                {
                    rootObjects.Add(Selection.activeGameObject);
                    infoFoldouts.Add(true);
                    rectFoldouts.Add(false);
                    compFoldouts.Add(false);
                    AutoExportToJson(); // 自动保存
                }
                else
                {
                    EditorUtility.DisplayDialog("提示", "该对象已在列表中", "确定");
                }
            }
            else
            {
                EditorUtility.DisplayDialog("提示", "请在层级面板中选中一个对象", "确定");
            }
        }



        GUILayout.Space(10);
        if (GUILayout.Button("导出所有对象到JSON"))
        {
            if (rootObjects.Count == 0)
            {
                EditorUtility.DisplayDialog("提示", "请先添加至少一个对象", "确定");
                return;
            }
            var allData = new List<UIObjectData>();
            foreach (var go in rootObjects)
            {
                if (go != null)
                    CollectRecursive(go, "", allData);
            }
            string json = JsonUtility.ToJson(new UIHierarchyExportRoot { items = allData }, true);
            string path = EditorUtility.SaveFilePanel("保存JSON", Application.dataPath, "UIHierarchyExport.json", "json");
            if (!string.IsNullOrEmpty(path))
            {
                File.WriteAllText(path, json);
                EditorUtility.RevealInFinder(path);
                Debug.Log("导出成功: " + path);
            }
        }

        GUILayout.Space(20);
        GUILayout.Label("说明：", EditorStyles.boldLabel);
        GUILayout.Label("1. 支持批量Transform、RectTransform数据导出", EditorStyles.wordWrappedLabel);
        GUILayout.Label("2. 支持常见UI组件（Image/Text/Button等）显示/隐藏状态导出", EditorStyles.wordWrappedLabel);
    }
    private void AutoExportToJson()
    {
        var allData = new List<UIObjectData>();
        foreach (var go in rootObjects)
        {
            if (go != null)
                CollectRecursive(go, "", allData);
        }
        string json = JsonUtility.ToJson(new UIHierarchyExportRoot { items = allData }, true);
        File.WriteAllText(autoExportPath, json);
        AssetDatabase.Refresh();
        Debug.Log("已自动保存到: " + autoExportPath);
    }

    [System.Serializable]
    public class UIHierarchyExportRoot
    {
        public List<UIObjectData> items;
    }

    [System.Serializable]
    public class UIComponentState
    {
        public string componentName;
        public bool enabled;
    }

    [System.Serializable]
    public class UIObjectData
    {
        public string name;
        public string path;
        public Vector3 localPosition;
        public Vector3 localScale;
        public Quaternion localRotation;
        public Vector2 anchoredPosition;
        public Vector2 sizeDelta;
        public Vector2 anchorMin;
        public Vector2 anchorMax;
        public Vector2 pivot;
        public bool activeSelf;
        public List<UIComponentState> components = new List<UIComponentState>();
    }

    private static readonly System.Type[] uiComponentTypes = new System.Type[]
    {
        typeof(UnityEngine.UI.Image),
        typeof(UnityEngine.UI.Text),
        typeof(UnityEngine.UI.Button),
        typeof(UnityEngine.UI.RawImage),
        typeof(TMPro.TextMeshProUGUI),
        typeof(TMPro.TMP_InputField),
        typeof(UnityEngine.UI.Toggle),
        typeof(UnityEngine.UI.Slider),
        typeof(UnityEngine.UI.Scrollbar),
        typeof(UnityEngine.UI.Dropdown),
        typeof(UnityEngine.CanvasGroup)
    };

    private void CollectRecursive(GameObject go, string parentPath, List<UIObjectData> list)
    {
        string path = string.IsNullOrEmpty(parentPath) ? go.name : parentPath + "/" + go.name;
        var data = new UIObjectData();
        data.name = go.name;
        data.path = path;
        data.activeSelf = go.activeSelf;

        // Transform
        data.localPosition = go.transform.localPosition;
        data.localScale = go.transform.localScale;
        data.localRotation = go.transform.localRotation;

        // RectTransform
        var rect = go.GetComponent<RectTransform>();
        if (rect != null)
        {
            data.anchoredPosition = rect.anchoredPosition;
            data.sizeDelta = rect.sizeDelta;
            data.anchorMin = rect.anchorMin;
            data.anchorMax = rect.anchorMax;
            data.pivot = rect.pivot;
        }

        // 组件收集
        // 组件收集（只收集有 enabled 属性的组件）
        var comps = go.GetComponents<Component>();
        foreach (var comp in comps)
        {
            if (comp == null) continue;
            var type = comp.GetType();
            var enabledProp = type.GetProperty("enabled");
            if (enabledProp != null && enabledProp.PropertyType == typeof(bool))
            {
                bool enabled = (bool)enabledProp.GetValue(comp, null);
                data.components.Add(new UIComponentState
                {
                    componentName = type.Name,
                    enabled = enabled
                });
            }
        }

        list.Add(data);
    }
}
