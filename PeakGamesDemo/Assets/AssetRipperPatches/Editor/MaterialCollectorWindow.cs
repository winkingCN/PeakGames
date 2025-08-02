using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEditor;
using UnityEngine;
using TMPro; // 需确保已引用 TextMeshPro 命名空间
public class MaterialCollectorWindow : EditorWindow
{
    private Vector2 scrollPos;
    private List<Material> selectedMaterials = new List<Material>();

    [MenuItem("Tools/材质参数收集器")]
    public static void ShowWindow()
    {
        GetWindow<MaterialCollectorWindow>("材质参数收集器");
    }
   

    private void AddAllTMPFontMaterials()
    {
        // 查找所有TMP字体资源
        string[] guids = AssetDatabase.FindAssets("t:TMP_FontAsset");
        int addCount = 0;
        foreach (string guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            TMP_FontAsset fontAsset = AssetDatabase.LoadAssetAtPath<TMP_FontAsset>(path);
            if (fontAsset != null && fontAsset.material != null && !selectedMaterials.Contains(fontAsset.material))
            {
                selectedMaterials.Add(fontAsset.material);
                addCount++;
            }
        }
        Debug.Log($"已添加 {addCount} 个TMP字体材质球到列表");
    }

    private void OnGUI()
    {
        GUILayout.Label("选中一个或多个材质球", EditorStyles.boldLabel);

        if (GUILayout.Button("刷新选中材质"))
        {
            RefreshSelectedMaterials();
        }
        if (GUILayout.Button("添加所有TMP字体材质球"))
        {
            AddAllTMPFontMaterials();
        }

        if (selectedMaterials.Count == 0)
        {
            GUILayout.Label("未选中任何材质球");
            return;
        }

        scrollPos = GUILayout.BeginScrollView(scrollPos, GUILayout.Height(400));
        scrollPos = GUILayout.BeginScrollView(scrollPos, GUILayout.Height(400));
        for (int i = 0; i < selectedMaterials.Count; i++)
        {
            selectedMaterials[i] = EditorGUILayout.ObjectField(selectedMaterials[i], typeof(Material), false) as Material;
        }
        GUILayout.EndScrollView();

        GUILayout.EndScrollView();

        if (GUILayout.Button("导出为JSON"))
        {
            ExportAllDataToJson();
        }
    }

    private void RefreshSelectedMaterials()
    {
        selectedMaterials.Clear();
        foreach (var obj in Selection.objects)
        {
            if (obj is Material mat)
            {
                selectedMaterials.Add(mat);
            }
        }
    }

    private List<string> GetPropertiesByType(Material mat, ShaderUtil.ShaderPropertyType type)
    {
        var result = new List<string>();
#if UNITY_EDITOR
        var shader = mat.shader;
        int count = ShaderUtil.GetPropertyCount(shader);
        for (int i = 0; i < count; i++)
        {
            if (ShaderUtil.GetPropertyType(shader, i) == type)
            {
                result.Add(ShaderUtil.GetPropertyName(shader, i));
            }
        }
#endif
        return result;
    }

    [System.Serializable]
    public class MaterialExportList
    {
        public List<MaterialExportData> materials = new List<MaterialExportData>();
    }

    private void ExportAllDataToJson()
    {
        var exportList = new MaterialExportList();

        foreach (var mat in selectedMaterials)
        {
            if (mat == null) continue;
            var data = new MaterialExportData();
            data.name = mat.name;

            foreach (var prop in GetPropertiesByType(mat, ShaderUtil.ShaderPropertyType.Float))
            {
                float value = mat.GetFloat(prop);
                data.floats.Add(new FloatParam { key = prop, value = value });
                data.ints.Add(new IntParam { key = prop, value = Mathf.RoundToInt(value) });
            }
            foreach (var prop in GetPropertiesByType(mat, ShaderUtil.ShaderPropertyType.Color))
            {
                Color value = mat.GetColor(prop);
                data.colors.Add(new ColorParam { key = prop, value = new MyColor(value) });
            }
            exportList.materials.Add(data);
        }

        string json = JsonUtility.ToJson(exportList, true);

        string path = EditorUtility.SaveFilePanel(
            "导出材质参数为JSON",
            Application.dataPath,
            "MaterialParams.json",
            "json"
        );
        if (!string.IsNullOrEmpty(path))
        {
            File.WriteAllText(path, json, System.Text.Encoding.UTF8);
            Debug.Log("已导出到: " + path);
            AssetDatabase.Refresh();
        }
    }

}
