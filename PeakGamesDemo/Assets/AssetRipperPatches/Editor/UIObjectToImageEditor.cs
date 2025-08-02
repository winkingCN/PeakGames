using UnityEngine;
using UnityEditor;
using System.IO;

public class UIObjectToImageEditor : EditorWindow
{
    private RectTransform _targetUIObject;
    private string _savePath = "Assets/UI/UIImages/UIParent";
    private string _fileName = "UI_Snapshot.png";
    private Color _backgroundColor = Color.clear; // 可设置背景颜色

    [MenuItem("Tools/UI To Image")]
    public static void ShowWindow()
    {
        GetWindow<UIObjectToImageEditor>("UI To Image");
    }

    private void OnGUI()
    {
        GUILayout.Label("UI 对象转换成图片", EditorStyles.boldLabel);

        _targetUIObject = (RectTransform)EditorGUILayout.ObjectField("目标 UI 对象", _targetUIObject, typeof(RectTransform), true);
        _savePath = EditorGUILayout.TextField("保存路径", _savePath);
        _fileName = EditorGUILayout.TextField("文件名", _fileName);
        _backgroundColor = EditorGUILayout.ColorField("背景颜色", _backgroundColor);

        if (GUILayout.Button("转换并保存"))
        {
            if (_targetUIObject == null)
            {
                EditorUtility.DisplayDialog("错误", "请选择一个有效的 UI 对象", "确定");
                return;
            }

            if (!Directory.Exists(_savePath))
            {
                Directory.CreateDirectory(_savePath);
            }

            SaveUIObjectToImage();
        }
    }

    private void SaveUIObjectToImage()
    {
        // 1. 获取 UI 对象 (已在 OnGUI 中完成)
        if (_targetUIObject == null)
        {
            Debug.LogError("请选择一个有效的 UI 对象!");
            return;
        }

        // 计算目标UI的大小
        Rect rect = _targetUIObject.rect;
        int width = Mathf.RoundToInt(rect.width);
        int height = Mathf.RoundToInt(rect.height);

        if (width <= 0 || height <= 0)
        {
            Debug.LogError("UI 对象宽高必须大于0");
            return;
        }

        // 2. 创建 Render Texture
        RenderTexture renderTexture = new RenderTexture(width, height, 24);

        Canvas canvas = null;
        Transform current = _targetUIObject.parent; // 从父对象开始查找
        while (current != null)
        {
            canvas = current.GetComponent<Canvas>();
            if (canvas != null) break;
            current = current.parent;
        }
        
        Camera targetCamera = null;
        canvas.renderMode = RenderMode.ScreenSpaceCamera;
        

        // 3. 创建临时相机，或者使用Canvas相机
        GameObject cameraGo;
        Camera tempCamera;
        if (targetCamera == null)
        {
            cameraGo = new GameObject("TempCamera");
            tempCamera = cameraGo.AddComponent<Camera>();
            tempCamera.transform.position = _targetUIObject.position; // 使用UI位置
            tempCamera.orthographic = true;
            tempCamera.orthographicSize = height * 0.5f;
            tempCamera.clearFlags = CameraClearFlags.SolidColor; // 使用颜色
            tempCamera.backgroundColor = _backgroundColor; // 设置背景色
            tempCamera.targetTexture = renderTexture;
            canvas.worldCamera = tempCamera;
            // 计算相机位置
            Vector3 pos = _targetUIObject.position;
            pos.z = -10; // 防止相机被其他UI遮挡
            tempCamera.transform.position = pos;
        }
        else
        {
            cameraGo = targetCamera.gameObject;
            tempCamera = targetCamera;
            tempCamera.targetTexture = renderTexture;
        }

        //  调整相机范围
        int uiLayer = LayerMask.NameToLayer("UI"); // 确保相机能看到 UI 层
        tempCamera.cullingMask = 1 << uiLayer;

        // 渲染目标对象
        tempCamera.Render();

        // 4. 读取 RenderTexture 内容
        Texture2D texture = new Texture2D(width, height, TextureFormat.RGBA32, false);
        RenderTexture.active = renderTexture;
        texture.ReadPixels(new Rect(0, 0, width, height), 0, 0);
        texture.Apply();

        // 5. 保存为 PNG 文件
        byte[] bytes = texture.EncodeToPNG();
        string fullPath = Path.Combine(_savePath, _fileName);
        File.WriteAllBytes(fullPath, bytes);
        AssetDatabase.Refresh();
        Debug.Log(fullPath);
        TextureImporter textureImporter = AssetImporter.GetAtPath(fullPath) as TextureImporter;
        textureImporter.isReadable = true;
        textureImporter.textureCompression = TextureImporterCompression.Uncompressed;
        textureImporter.spriteImportMode = SpriteImportMode.Single;
        textureImporter.textureType = TextureImporterType.Sprite;
        textureImporter.SaveAndReimport();
        AssetDatabase.ImportAsset(fullPath, ImportAssetOptions.ForceUpdate | ImportAssetOptions.ForceSynchronousImport);
        AssetDatabase.Refresh();
        // 清理资源
        RenderTexture.active = null;
        //DestroyImmediate(renderTexture);
        if (targetCamera == null)
        {
            DestroyImmediate(cameraGo);
        }
        else
        {
            tempCamera.targetTexture = null; // 不影响原相机
        }
        AssetDatabase.Refresh(); // 刷新资源，让 Unity 更新
        Debug.Log($"UI 对象已保存到: {fullPath}");
    }
}