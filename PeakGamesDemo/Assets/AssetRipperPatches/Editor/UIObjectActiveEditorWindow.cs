using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.IO;

public class UIObjectActiveEditorWindow : EditorWindow
{
    private UIObjectRecordData recordData;
    private string jsonPath = "Assets/objectActiveData.json";
    private Vector2 scrollPos;
    private int selectedRecordIndex = -1;

    [MenuItem("Tools/UI 对象激活编辑器")]
    public static void ShowWindow()
    {
        GetWindow<UIObjectActiveEditorWindow>("UI对象激活编辑器");
    }

    private void OnEnable()
    {
        recordData = ScriptableObject.CreateInstance<UIObjectRecordData>();
        LoadFromJson();
    }

    private void OnGUI()
    {
        GUILayout.Label("对象激活记录管理", EditorStyles.boldLabel);

        if (GUILayout.Button("添加当前选中对象及其所有子对象名字"))
        {
            AddCurrentSelectionRecord();
        }

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("保存到 objectActiveData.json"))
        {
            SaveToJson();
        }
        if (GUILayout.Button("从 objectActiveData.json 读取"))
        {
            LoadFromJson();
        }
        GUILayout.EndHorizontal();

        GUILayout.Space(10);

        // 显示记录，与UIShowWindow风格一致
        scrollPos = GUILayout.BeginScrollView(scrollPos, GUILayout.Height(400));
        int deleteIndex = -1;
        for (int i = 0; i < recordData.records.Count; i++)
        {
            var rec = recordData.records[i];
            GUILayout.BeginVertical("box");
            GUILayout.BeginHorizontal();
            GUILayout.Label("displayName: " + rec.displayName, GUILayout.Width(200));
            if (rec.rootObject != null)
            {
                var obj = EditorGUILayout.ObjectField(rec.rootObject, typeof(GameObject), true, GUILayout.Width(200));
                if (obj != rec.rootObject && obj is GameObject go)
                {
                    rec.rootObject = go;
                }
            }
            else
            {
                GUILayout.Label(rec.rootName, GUILayout.Width(200));
            }
            if (GUILayout.Button("删除", GUILayout.Width(50)))
            {
                deleteIndex = i;
            }
            GUILayout.EndHorizontal();

            if (GUILayout.Button("展开/收起子对象", GUILayout.Width(100)))
            {
                selectedRecordIndex = selectedRecordIndex == i ? -1 : i;
            }

            if (selectedRecordIndex == i)
            {
                GUILayout.Label("所有子对象名字：");
                foreach (var name in rec.allNames)
                {
                    GUILayout.Label(name);
                }
            }
            GUILayout.EndVertical();
        }
        GUILayout.EndScrollView();

        if (deleteIndex >= 0)
        {
            recordData.records.RemoveAt(deleteIndex);
        }
    }

    private void AddCurrentSelectionRecord()
    {
        if (Selection.gameObjects == null || Selection.gameObjects.Length == 0)
        {
            Debug.LogWarning("请先选中对象");
            return;
        }
        string sceneName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
        foreach (var go in Selection.gameObjects)
        {
            var rec = new UIObjectRecord();
            rec.rootObject = go;
            rec.rootName = go.name;
            rec.displayName = sceneName;
            rec.displayObject = null; // 不存储
            rec.allNames.Clear();
            foreach (var t in go.GetComponentsInChildren<Transform>(true))
            {
                rec.allNames.Add(t.name);
            }
            recordData.records.Add(rec);
        }
        SaveToJson(); // 添加后立即保存
    }


    private void SaveToJson()
    {
        var exportList = new List<ExportRecord>();
        foreach (var rec in recordData.records)
        {
            exportList.Add(new ExportRecord
            {
                rootName = rec.rootName,
                allNames = rec.allNames,
                displayName = rec.displayName
            });
        }
        string json = JsonUtility.ToJson(new ExportRecordList { records = exportList }, true);
        File.WriteAllText(jsonPath, json, System.Text.Encoding.UTF8);
        AssetDatabase.Refresh();
        Debug.Log("已保存到 " + jsonPath);
    }

    private void LoadFromJson()
    {
        recordData.records.Clear();
        if (!File.Exists(jsonPath))
        {
            Debug.LogWarning("未找到 objectActiveData.json");
            return;
        }
        string json = File.ReadAllText(jsonPath, System.Text.Encoding.UTF8);
        var importList = JsonUtility.FromJson<ExportRecordList>(json);
        if (importList == null || importList.records == null) return;
        foreach (var rec in importList.records)
        {
            var newRec = new UIObjectRecord();
            newRec.rootName = rec.rootName;
            newRec.displayName = rec.displayName;
            newRec.displayObject = null;
            newRec.allNames = new List<string>(rec.allNames);
            recordData.records.Add(newRec);
        }
        Debug.Log("已从 objectActiveData.json 读取");
    }

    [System.Serializable]
    private class ExportRecordList
    {
        public List<ExportRecord> records;
    }
    [System.Serializable]
    private class ExportRecord
    {
        public string rootName;
        public string displayName;
        public List<string> allNames;
    }
}
