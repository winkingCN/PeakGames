using UnityEditor;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using System.IO;
using System.Collections.Generic;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class UIShowWindow : EditorWindow
{
    private const string SceneName = "UIWorkspaceScene.unity";
    private static string ScenePath => $"Assets/{SceneName}";
    private Vector2 scrollPos;
    private Vector2 scrollPos1;
    private List<GameObject> selectedObjects = new List<GameObject>();
    private UIObjectRecordData recordData;
    private string recordAssetPath = "Assets/UIObjectRecordData.asset";
    private string recordAssetJsonPath = "Assets/UIObjectRecordData.json";
    private int selectedRecordIndex = -1;

    private void LoadOrCreateRecordData()
    {
        ShowAllCellChildren();
        recordData = new UIObjectRecordData();
        //recordData = AssetDatabase.LoadAssetAtPath<UIObjectRecordData>(recordAssetPath);
        //if (recordData == null)
        //{
        //    recordData = ScriptableObject.CreateInstance<UIObjectRecordData>();
        //    AssetDatabase.CreateAsset(recordData, recordAssetPath);
        //}
        if (File.Exists(recordAssetJsonPath))
        {
            var mainCanvas = GetMainCanvas();
            if (mainCanvas == null) return;

            foreach (Transform child in mainCanvas.transform)
            {
                if (child.name.StartsWith("Cell_"))
                {
                    child.gameObject.SetActive(true);
                    child.GetChild(0).transform.gameObject.SetActive(true);
                }
            }
            string json = File.ReadAllText(recordAssetJsonPath, System.Text.Encoding.UTF8);
            var importList = JsonUtility.FromJson<ExportRecordList>(json);
            if (recordData.records.Count < importList.records.Count)
            {
                if (importList == null || importList.records == null)
                {
                    Debug.LogError("JSON格式不正确或无数据");
                    return;
                }
                recordData.records.Clear();
                int successCount = 0;
                int failCount = 0; 
                HashSet<string> games = new HashSet<string>();
                foreach (var rec in importList.records)
                {
                    
                    var newRecord = new UIObjectRecord();
                    newRecord.rootName = rec.rootName;
                    newRecord.allNames = new List<string>(rec.allNames);
                    newRecord.displayName = rec.PanleName;
                    newRecord.displayObject = GameObject.Find(newRecord.displayName);
                    newRecord.rootObject = GameObject.Find(newRecord.rootName);
                    
                    if (newRecord.rootObject != null)
                    {
                        newRecord.rootObject.SetActive(false);
                        successCount++;
                    }
                    else
                    {
                        SetActiveRecursive(newRecord.displayObject, true);
                        newRecord.rootObject = GameObject.Find(newRecord.rootName);
                        if(newRecord.rootObject != null)
                        {
                            newRecord.rootObject.SetActive(false);
                        }
                        failCount++;
                    }
                    if (newRecord.rootObject == null)
                    {
                        Debug.LogError("meizhaod" + newRecord.rootName, newRecord.displayObject);
                    }
                    recordData.records.Add(newRecord);
                }
            }
            
        }
      
        foreach (var rec in recordData.records)
        {
            if (rec.rootObject == null)
            {
                if(rec.displayObject == null)
                {
                    rec.displayObject = GameObject.Find(rec.displayName);
                }
                if (rec.rootObject == null)
                {
                    rec.rootObject = GameObject.Find(rec.rootName);
                }
                if (rec.rootObject == null)
                {
                    SetActiveRecursive(rec.displayObject, true);
                    rec.rootObject = GameObject.Find(rec.rootName);
                }
                
            }
        }
    }

    [MenuItem("Tools/UI Show Window")]
    public static void ShowWindow()
    {
        var windp = GetWindow<UIShowWindow>("UI Show Window");
        windp.Init();
    }

    private void Init()
    {
        LoadOrCreateRecordData();
        //ShowAllObjectsInScene();
    }
    private void ShowAllObjectsInScene()
    {
        var mainCanvas = GetMainCanvas();
        if (mainCanvas == null) return;

        foreach (Transform child in mainCanvas.transform)
        {
            if (child.name.StartsWith("Cell_"))
            {
                child.gameObject.SetActive(true);
                child.GetChild(0).transform.gameObject.SetActive(true);
            }
        } 
        Debug.Log("已将所有对象设置为显示");
    }

    private void SetActiveRecursive(GameObject obj, bool active)
    {
        if (obj == null) return;
        obj.SetActive(active);
        if (obj.name.ToLower().StartsWith("background"))
        {
            var im = obj.GetComponent<Image>();
            if(im != null)
            {
                im.enabled = false;
            }
        }
        foreach (Transform child in obj.transform)
        {
            SetActiveRecursive(child.gameObject, active);
        }
    }


    //private void OnSelectionChange()
    //{
    //    RefreshSelection();
    //    Repaint();
    //}

    private void RefreshSelection()
    {
        selectedObjects.Clear();
        foreach (var obj in Selection.gameObjects)
        {
            selectedObjects.Add(obj);
        }
    }
    private GameObject FindTopmostCellParent(GameObject obj)
    {
        GameObject topCell = null;
        Transform current = obj != null ? obj.transform : null;
        while (current != null)
        {
            if (current.name.StartsWith("Cell_"))
            {
                topCell = current.gameObject;
            }
            current = current.parent;
        }
        return topCell;
    }

    private void ShowAllCellChildren()
    {
        int cellCount = 0, showCount = 0;
        var mainCanvas = GetMainCanvas();
        if (mainCanvas == null) return;
        foreach (Transform child in mainCanvas.transform)
        {
            if (child.name.StartsWith("Cell_"))
            {
                cellCount++;
                foreach (Transform cellChild in child)
                {
                    cellChild.gameObject.SetActive(true);
                    var rect = cellChild.GetComponent<RectTransform>();
                    if (rect != null)
                    {
                        rect.localScale = Vector3.one;
                        var raycas = cellChild.GetComponent<GraphicRaycaster>();
                        if (raycas != null)
                        {
                            GameObject.DestroyImmediate(raycas);
                        }
                        var cas = cellChild.GetComponent<CanvasScaler>();
                        if (cas != null)
                        {
                            GameObject.DestroyImmediate(cas);
                        }
                        var canvas = cellChild.GetComponent<Canvas>();
                        if (canvas != null)
                        {
                            GameObject.DestroyImmediate(canvas);
                        }
                    }
                    showCount++;
                }
            }
        }
        Debug.LogError($"已打开 {cellCount} 个Cell_对象下的 {showCount} 个子对象");
    }
    private GameObject GetMainCanvas()
    {
        return GameObject.Find("UIWorkspace_Canvas");
    }


    private void ShowCellChildrenRecursive(GameObject obj, ref int cellCount, ref int showCount)
    {
        if (obj.name.StartsWith("Cell_"))
        {
            cellCount++;
            foreach (Transform child in obj.transform)
            {
                child.gameObject.SetActive(true);
                var rect = child.GetComponent<RectTransform>();
                if(rect != null)
                {
                    rect.localScale = Vector3.one;
                    var raycas = child.GetComponent<GraphicRaycaster>();
                    if(raycas != null)
                    {
                        GameObject.DestroyImmediate(raycas);
                    }
                    var cas = child.GetComponent<CanvasScaler>();
                    if (cas != null)
                    {
                        GameObject.DestroyImmediate(cas);
                    }
                    var canvas = child.GetComponent<Canvas>();
                    if (canvas != null)
                    {
                        GameObject.DestroyImmediate(canvas);
                    }
                }
            }
        }
        foreach (Transform child in obj.transform)
        {
            ShowCellChildrenRecursive(child.gameObject, ref cellCount, ref showCount);
        }
    }


    private void HideAllRecordCells()
    {
        HashSet<GameObject> cellsToHide = new HashSet<GameObject>();
        foreach (var record in recordData.records)
        {
            var obj = record.rootObject;
            if (obj == null) continue;
            Transform parent = obj.transform.parent;
            while (parent != null)
            {
                if (parent.name.StartsWith("Cell_"))
                {
                    cellsToHide.Add(parent.gameObject);
                    break;
                }
                parent = parent.parent;
            }
        }

        List<GameObject> allCells = new List<GameObject>();
        CollectCellsUnderMainCanvas(allCells);

        int hideCount = 0, showCount = 0;
        foreach (var cell in allCells)
        {
            if (cellsToHide.Contains(cell))
            {
                if (cell.activeSelf)
                {
                    cell.SetActive(false);
                    hideCount++;
                }
            }
            else
            {
                if (!cell.activeSelf)
                {
                    cell.SetActive(true);
                    showCount++;
                }
            }
        }

        Debug.LogError($"已隐藏记录中的Cell_对象：{hideCount} 个，已打开未记录的Cell_对象：{showCount} 个");
    }
    private void CollectCellsUnderMainCanvas(List<GameObject> list)
    {
        var mainCanvas = GetMainCanvas();
        if (mainCanvas == null) return;
        foreach (Transform child in mainCanvas.transform)
        {
            if (child.name.StartsWith("Cell_"))
            {
                list.Add(child.gameObject);
            }
            // 如果Cell_对象下还有嵌套Cell_，可递归
            CollectCellsRecursive(child.gameObject, list);
        }
    }

    private void GroupCellsByRow()
    {
        cellRows.Clear();
        List<GameObject> allCells = new List<GameObject>();
        CollectCellsUnderMainCanvas(allCells);

        float yTolerance = 1f;
        foreach (var cell in allCells)
        {
            var rt = cell.GetComponent<RectTransform>();
            float y = rt != null ? rt.anchoredPosition.y : cell.transform.position.y;
            bool found = false;
            for (int i = 0; i < cellRows.Count; i++)
            {
                if (cellRows[i].Count > 0)
                {
                    var first = cellRows[i][0];
                    var firstRt = first.GetComponent<RectTransform>();
                    float firstY = firstRt != null ? firstRt.anchoredPosition.y : first.transform.position.y;
                    if (Mathf.Abs(firstY - y) < yTolerance)
                    {
                        cellRows[i].Add(cell);
                        found = true;
                        break;
                    }
                }
            }
            if (!found)
            {
                cellRows.Add(new List<GameObject> { cell });
            }
        }
        maxCellRow = Mathf.Max(0, cellRows.Count - 1);
    }


    private void ShowOnlyRecordCells()
    {
        // 1. 收集 recordData 中所有 rootObject 的最近 Cell_ 父对象
        HashSet<GameObject> recordCells = new HashSet<GameObject>();
        foreach (var record in recordData.records)
        {
            var obj = record.rootObject;
            if (obj == null) continue;
            Transform parent = obj.transform.parent;
            while (parent != null)
            {
                if (parent.name.StartsWith("Cell_"))
                {
                    recordCells.Add(parent.gameObject);
                    break;
                }
                parent = parent.parent;
            }
        }

        // 2. 收集场景中所有 Cell_ 开头的对象
        List<GameObject> allCells = new List<GameObject>();
        foreach (var root in SceneManager.GetActiveScene().GetRootGameObjects())
        {
            CollectCellsRecursive(root, allCells);
        }

        // 3. 遍历所有 Cell_，在 recordCells 中的 SetActive(true)，不在的 SetActive(false)
        int showCount = 0, hideCount = 0;
        foreach (var cell in allCells)
        {
            if (recordCells.Contains(cell))
            {
                if (!cell.activeSelf)
                {
                    cell.SetActive(true);
                    showCount++;
                }
            }
            else
            {
                if (cell.activeSelf)
                {
                    cell.SetActive(false);
                    hideCount++;
                }
            }
        }

        Debug.LogError($"已打开记录中的Cell_对象：{showCount} 个，隐藏未记录的Cell_对象：{hideCount} 个");
    }

    // 递归收集所有Cell_对象
    private void CollectCellsRecursive(GameObject obj, List<GameObject> list)
    {
        if (obj.name.StartsWith("Cell_"))
        {
            list.Add(obj);
        }
        foreach (Transform child in obj.transform)
        {
            CollectCellsRecursive(child.gameObject, list);
        }
    }

    private void CreateAndSaveScene()
    {
        // 1. 创建新场景
        var newScene = EditorSceneManager.NewScene(NewSceneSetup.DefaultGameObjects, NewSceneMode.Single);

        // 2. 创建主Canvas
        GameObject mainCanvasGO = new GameObject("UIWorkspace_Canvas", typeof(Canvas), typeof(RectTransform));
        Canvas mainCanvas = mainCanvasGO.GetComponent<Canvas>();
        mainCanvas.renderMode = RenderMode.ScreenSpaceOverlay;
        RectTransform mainCanvasRect = mainCanvasGO.GetComponent<RectTransform>();
        mainCanvasRect.sizeDelta = new Vector2(1920, 1080); // 可根据需要调整

        SceneManager.MoveGameObjectToScene(mainCanvasGO, newScene);

        List<GameObject> sceneCanvasCopies = new List<GameObject>();
        string[] allSceneGuids = AssetDatabase.FindAssets("t:Scene", new[] { "Assets" });
        foreach (string guid in allSceneGuids)
        {
            string scenePath = AssetDatabase.GUIDToAssetPath(guid);
            if (scenePath == ScenePath) continue; // 跳过自己

            var tempScene = EditorSceneManager.OpenScene(scenePath, OpenSceneMode.Additive);
            foreach (GameObject rootObj in tempScene.GetRootGameObjects())
            {
                var canvas = rootObj.GetComponentsInChildren<Canvas>(true);
                if (canvas.Length > 0)
                {
                    GameObject canvasCopy = Object.Instantiate(rootObj);
                    canvasCopy.name = rootObj.name;
                    sceneCanvasCopies.Add(canvasCopy);
                }
            }
            EditorSceneManager.CloseScene(tempScene, true);
        }
        // 3. 收集所有UI预设和场景Canvas
        List<GameObject> uiPrefabs = new List<GameObject>();
        string[] allPrefabGuids = AssetDatabase.FindAssets("t:Prefab", new[] { "Assets" });
        Debug.LogError(allPrefabGuids.Length);
        foreach (string guid in allPrefabGuids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>(path);
            if (prefab != null && prefab.GetComponentInChildren<RectTransform>(true) != null)
            {
                uiPrefabs.Add(prefab);
            }
        }

        // 获取分辨率
        Vector2 screenSize = GetGameViewSize();
        float cellWidth = screenSize.x;
        float cellHeight = screenSize.y;
        int index = 0;
        // 计算布局
        int totalCount = uiPrefabs.Count + sceneCanvasCopies.Count;
        if (totalCount > 0)
        {
            int colCount = Mathf.CeilToInt(Mathf.Sqrt(totalCount));
            int rowCount = Mathf.CeilToInt((float)totalCount / colCount);
            float padding = 100;

            // 计算格子区域
            float cellAreaWidth = cellWidth + padding;
            float cellAreaHeight = cellHeight + padding;

            // 实例化并布局UI预设
          
            for (int i = 0; i < uiPrefabs.Count; i++)
            {
                var prefab = uiPrefabs[i];

                // 1. 创建格子容器
                GameObject cellGO = new GameObject($"Cell_{index}", typeof(RectTransform));
                cellGO.transform.SetParent(mainCanvasGO.transform, false);
                RectTransform cellRect = cellGO.GetComponent<RectTransform>();
                cellRect.anchorMin = cellRect.anchorMax = new Vector2(0, 1);
                cellRect.pivot = new Vector2(0, 1);
                cellRect.sizeDelta = new Vector2(cellWidth, cellHeight);

                int row = index / colCount;
                int col = index % colCount;
                cellRect.anchoredPosition = new Vector2(
                    col * cellAreaWidth + padding / 2,
                    -row * cellAreaHeight - padding / 2
                );

                // 2. 实例化预设并放到cell下
                GameObject instance = (GameObject)PrefabUtility.InstantiatePrefab(prefab, newScene);
                instance.transform.SetParent(cellGO.transform, false);
                index++;
            }
            // 实例化并布局场景Canvas
            for (int i = 0; i < sceneCanvasCopies.Count; i++)
            {
                var canvasCopy = sceneCanvasCopies[i];

                // 1. 创建格子容器
                GameObject cellGO = new GameObject($"Cell_{index}", typeof(RectTransform));
                cellGO.transform.SetParent(mainCanvasGO.transform, false);
                RectTransform cellRect = cellGO.GetComponent<RectTransform>();
                cellRect.anchorMin = cellRect.anchorMax = new Vector2(0, 1);
                cellRect.pivot = new Vector2(0, 1);
                cellRect.sizeDelta = new Vector2(cellWidth, cellHeight);


                int row = index / colCount;
                int col = index % colCount;
                cellRect.anchoredPosition = new Vector2(
                    col * cellAreaWidth + padding / 2,
                    -row * cellAreaHeight - padding / 2
                );


                // 2. 放到cell下
                SceneManager.MoveGameObjectToScene(canvasCopy, newScene);
                canvasCopy.transform.SetParent(cellGO.transform, false);

                // 可选：重置本地变换
                RectTransform rt = canvasCopy.GetComponent<RectTransform>();
                if (rt != null)
                {
                    rt.anchorMin = new Vector2(0, 1);
                    rt.anchorMax = new Vector2(0, 1);
                    rt.pivot = new Vector2(0, 1);
                    rt.anchoredPosition = Vector2.zero;
                    rt.sizeDelta = cellRect.sizeDelta;
                    rt.localScale = Vector3.one;
                    rt.localRotation = Quaternion.identity;
                }

                index++;
            }
        }
        

       




        // 8. 保存新场景
        EditorSceneManager.SaveScene(newScene, ScenePath);
        AssetDatabase.Refresh();
        Debug.LogError($"已创建并保存场景：{SceneName}");
    }
    private Vector2 GetGameViewSize()
    {
#if UNITY_EDITOR
        System.Type T = System.Type.GetType("UnityEditor.GameView,UnityEditor");
        System.Reflection.MethodInfo GetSizeOfMainGameView = T.GetMethod("GetSizeOfMainGameView", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
        if (GetSizeOfMainGameView != null)
        {
            object res = GetSizeOfMainGameView.Invoke(null, null);
            return (Vector2)res;
        }
#endif
        return new Vector2(1920, 1080); // 默认值
    }
    private string searchText = "";
    private List<int> searchResultIndices = new List<int>();

    private void OnGUI()
    {
        GUILayout.Label("UI 场景管理", EditorStyles.boldLabel);

        if (!File.Exists(ScenePath))
        {
            if (GUILayout.Button("初始化 UI 工作场景"))
            {
                CreateAndSaveScene();
                ShowAllCellChildren();
                GroupCellsByRow();
                currentCellRow = 0;
                ShowCellRow(currentCellRow);
            }
        }
        else
        {
            if (GUILayout.Button("打开 UI 工作场景"))
            {
                EditorSceneManager.OpenScene(ScenePath, OpenSceneMode.Single);
            }

            GUILayout.Space(10);
            GUILayout.Label("当前选中的对象：", EditorStyles.label);
            scrollPos1 = GUILayout.BeginScrollView(scrollPos1, GUILayout.Height(50));
            foreach (var obj in selectedObjects)
            {
                GUILayout.Label(obj.name);
            }
            GUILayout.EndScrollView();
        }
        if(GUILayout.Button("打开所有对象"))
        {
            ShowAllObjectsInScene();
        }
        GUILayout.Space(5);
        GUILayout.Label("查询记录", EditorStyles.boldLabel);
        GUILayout.BeginHorizontal();
        searchText = GUILayout.TextField(searchText, GUILayout.Width(200));
        if (GUILayout.Button("查询", GUILayout.Width(60)))
        {
            searchResultIndices.Clear();
            if (!string.IsNullOrEmpty(searchText) && recordData != null)
            {
                for (int i = 0; i < recordData.records.Count; i++)
                {
                    var rec = recordData.records[i];
                    if ((rec.rootObject != null && rec.rootObject.name.Contains(searchText)) ||
                        (!string.IsNullOrEmpty(rec.rootName) && rec.rootName.Contains(searchText)) ||
                        (!string.IsNullOrEmpty(rec.displayName) && rec.displayName.Contains(searchText)))
                    {
                        searchResultIndices.Add(i);
                    }
                }
            }
        }
        GUILayout.EndHorizontal();

        if (searchResultIndices.Count > 0)
        {
            GUILayout.Label($"查询结果（共{searchResultIndices.Count}项）：", EditorStyles.label);
            int deleteIndex = -1;
            foreach (var idx in searchResultIndices)
            {
                var rec = recordData.records[idx];
                GUILayout.BeginHorizontal("box");
                GUILayout.Label(rec.rootObject != null ? rec.rootObject.name : rec.rootName, GUILayout.Width(200));
                GUILayout.Label(rec.displayName, GUILayout.Width(200));
                if (GUILayout.Button("删除", GUILayout.Width(50)))
                {
                    deleteIndex = idx;
                }
                GUILayout.EndHorizontal();
            }
            if (deleteIndex >= 0)
            {
                DeleteRecord(deleteIndex);
                searchResultIndices.Remove(deleteIndex);
                searchResultIndices.Clear();
                if (!string.IsNullOrEmpty(searchText) && recordData != null)
                {
                    for (int i = 0; i < recordData.records.Count; i++)
                    {
                        var rec = recordData.records[i];
                        if ((rec.rootObject != null && rec.rootObject.name.Contains(searchText)) ||
                            (!string.IsNullOrEmpty(rec.rootName) && rec.rootName.Contains(searchText)) ||
                            (!string.IsNullOrEmpty(rec.displayName) && rec.displayName.Contains(searchText)))
                        {
                            searchResultIndices.Add(i);
                        }
                    }
                }
            }
        }
        
        
        GUILayout.Space(5);
        GUILayout.Label("对象记录管理", EditorStyles.boldLabel);

        if (GUILayout.Button("添加当前选中对象及其所有子对象名字"))
        {
            AddCurrentSelectionRecord();
        }
        if (GUILayout.Button("打开所有Cell_对象下的对象并显示"))
        {
            ShowAllCellChildren();
        }
        if (recordData != null && recordData.records.Count > 0)
        {
            if (GUILayout.Button("隐藏所有记录对象"))
            {
                foreach (var record in recordData.records)
                {
                    var obj = record.rootObject;
                    if (obj == null) continue;
                    obj.SetActive(false);
                }
            }

            if (GUILayout.Button("隐藏所有记录对象的上层Cell_对象"))
            {
                HideAllRecordCells();
            }
            if (recordData != null && recordData.records.Count > 0)
            {
                if (GUILayout.Button("选中的对象都打开其他全部隐藏"))
                {
                    ShowOnlyRecordCells();
                }
            }

        }
        if (GUILayout.Button("打开非选中的对象"))
        {
            // 1. 收集所有选中对象的 Cell_ 父对象
            HashSet<GameObject> selectedCells = new HashSet<GameObject>();
            foreach (var obj in Selection.gameObjects)
            {
                var cell = FindTopmostCellParent(obj);
                if (cell != null)
                    selectedCells.Add(cell);
            }
            Debug.Log(selectedCells.Count);
            // 2. 打开选中对象及其所有子对象
            foreach (var obj in Selection.gameObjects)
            {
                SetActiveRecursive(obj, true);
            }

            // 3. 隐藏 recordData.records 中 rootObject 是选中Cell_对象的
            foreach (var rec in recordData.records)
            {
                if (rec.rootObject != null && selectedCells.Contains(rec.displayObject))
                {
                    rec.rootObject.SetActive(false);
                }
            }

            Debug.Log("已打开选中对象及其子对象，且隐藏了选中Cell_对象对应的记录对象。");
        }
        if(GUILayout.Button("关闭非选中的对象"))
        {
            // 1. 收集所有选中对象的 Cell_ 父对象
            HashSet<GameObject> selectedCells = new HashSet<GameObject>();
            foreach (var obj in Selection.gameObjects)
            {
                var cell = FindTopmostCellParent(obj);
                if (cell != null)
                    selectedCells.Add(cell);
            }
            Debug.Log(selectedCells.Count);
            // 2. 打开选中对象及其所有子对象
            foreach (var obj in Selection.gameObjects)
            {
                SetActiveRecursive(obj, false);
            }
            // 3. 隐藏 recordData.records 中 rootObject 是选中Cell_ 对象的
            foreach (var rec in recordData.records)
            {
                if (rec.rootObject != null && selectedCells.Contains(rec.displayObject))
                {
                    SetActiveRecursive(rec.rootObject,true);
                    //rec.rootObject.SetActive(true);
                    SetActiveWithParents(rec.rootObject, true);
                }
            }
            Debug.Log("已关闭非选中对象，且打开了选中Cell_对象对应的记录对象。");
        }

        if (GUILayout.Button("分组Cell_对象"))
        {
            GroupCellsByRow();
            currentCellRow = 0;
            ShowCellRow(currentCellRow);
        }

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("上一行", GUILayout.Width(60)))
        {
            if (cellRows.Count == 0) GroupCellsByRow();
            currentCellRow = Mathf.Max(0, currentCellRow - 1);
            ShowCellRow(currentCellRow);
        }
        GUILayout.Label($"当前行: {currentCellRow + 1} / {Mathf.Max(1, cellRows.Count)}", GUILayout.Width(120));
        if (GUILayout.Button("下一行", GUILayout.Width(60)))
        {
            if (cellRows.Count == 0) GroupCellsByRow();
            currentCellRow = Mathf.Min(cellRows.Count - 1, currentCellRow + 1);
            ShowCellRow(currentCellRow);
        }
        GUILayout.EndHorizontal();

        if (GUILayout.Button("保存记录"))
        {
            SaveRecordData();
        }

        if (GUILayout.Button("重新加载记录"))
        {
            ReloadRecordData();
        }
        if (GUILayout.Button("导出记录为JSON"))
        {
            ExportRecordsToJson();
        }
        if (GUILayout.Button("从JSON导入记录"))
        {
            ImportRecordsFromJson();
        }
        GUILayout.Space(5);
        if (recordData != null)
        {
            scrollPos = GUILayout.BeginScrollView(scrollPos, GUILayout.Height(300));
            int deleteIndex = -1;
            for (int i = 0; i < recordData.records.Count; i++)
            {
                var rec = recordData.records[i];
                GUILayout.BeginVertical("box");
                GUILayout.BeginHorizontal();
                if (rec.rootObject != null)
                {
                    if (rec.displayObject == null && rec.rootObject != null)
                    {
                        // 优先查找最近的 Cell_ 父节点
                        GameObject found = null;
                        Transform parent = rec.rootObject.transform.parent;
                        while (parent != null)
                        {
                            if (parent.name.StartsWith("Cell_"))
                            {
                                found = parent.gameObject;
                                break;
                            }
                            parent = parent.parent;
                        }
                        // 如果没有Cell_父节点，则用rootObject本身
                        rec.displayObject = found != null ? found : rec.rootObject;
                        rec.displayName = rec.displayObject.name;
                        //EditorUtility.SetDirty(recordData);
                        //AssetDatabase.SaveAssets();
                    }
                    EditorGUILayout.ObjectField(rec.displayObject, typeof(GameObject), true, GUILayout.Width(200));
                    
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
                DeleteRecord(deleteIndex);
            }

        }
    }
    private void SetActiveWithParents(GameObject obj, bool active)
    {
        if (obj == null) return;
        // 递归设置父级为active
        Transform t = obj.transform;
        while (t != null)
        {
            if (!t.gameObject.activeInHierarchy)
                t.gameObject.SetActive(active);
            t = t.parent;
        }
    }

    private int currentCellRow = 0;
    private int maxCellRow = 0;
    private List<List<GameObject>> cellRows = new List<List<GameObject>>();

    //private void GroupCellsByRow()
    //{
    //    // 清空旧数据
    //    cellRows.Clear();

    //    // 收集所有Cell_对象
    //    List<GameObject> allCells = new List<GameObject>();
    //    foreach (var root in SceneManager.GetActiveScene().GetRootGameObjects())
    //    {
    //        CollectCellsRecursive(root, allCells);
    //    }

    //    // 按y坐标分组（假设Cell_对象的RectTransform.anchoredPosition.y为行分组依据）
    //    // 这里假设y坐标相同即为同一行，实际可根据你的布局调整容差
    //    float yTolerance = 1f;
    //    foreach (var cell in allCells)
    //    {
    //        var rt = cell.GetComponent<RectTransform>();
    //        float y = rt != null ? rt.anchoredPosition.y : cell.transform.position.y;
    //        bool found = false;
    //        for (int i = 0; i < cellRows.Count; i++)
    //        {
    //            if (cellRows[i].Count > 0)
    //            {
    //                var first = cellRows[i][0];
    //                var firstRt = first.GetComponent<RectTransform>();
    //                float firstY = firstRt != null ? firstRt.anchoredPosition.y : first.transform.position.y;
    //                if (Mathf.Abs(firstY - y) < yTolerance)
    //                {
    //                    cellRows[i].Add(cell);
    //                    found = true;
    //                    break;
    //                }
    //            }
    //        }
    //        if (!found)
    //        {
    //            cellRows.Add(new List<GameObject> { cell });
    //        }
    //    }
    //    maxCellRow = Mathf.Max(0, cellRows.Count - 1);
    //}

    private void ShowCellRow(int row)
    {
        if (cellRows.Count == 0) GroupCellsByRow();
        if(recordData == null)
        {
            recordData = new UIObjectRecordData();
        }    
        HashSet<GameObject> selectedCells = new HashSet<GameObject>();
        // 遍历所有行
        for (int i = 0; i < cellRows.Count; i++)
        {
            foreach (var cell in cellRows[i])
            {
                // 如果是当前行，显示Cell对象；否则隐藏
                cell.SetActive(i == row);

                // 遍历 recordData.records，检查是否有 displayObject 与当前 cell 相同
                foreach (var record in recordData.records)
                {
                    if (record.displayObject == cell)
                    {
                        // 如果匹配，将 rootObject 设置为不显示
                        if (record.rootObject != null)
                        {
                            record.rootObject.SetActive(false);
                        }
                    }
                }
                if (i == row)
                {
                    SetActiveRecursive(cell, true);
                    if (cell != null)
                        selectedCells.Add(cell);
                }
            }
        }
        

        // 3. 隐藏 recordData.records 中 rootObject 是选中Cell_对象的
        foreach (var rec in recordData.records)
        {
            if(rec.displayObject!=null && rec.displayObject.activeInHierarchy)
            {
                if (rec.rootObject != null )
                {
                    if (selectedCells.Contains(rec.displayObject))
                    {
                        rec.rootObject.SetActive(false);
                    }
                    else
                    {
                        Debug.LogError(rec.displayName, rec.rootObject);
                    }
                }
                else
                {
                    Debug.LogError(rec.displayName);
                }
            }
            else
            {
              
            }
        }

    }


    private void ImportRecordsFromJson()
    {
        string path = EditorUtility.OpenFilePanel("导入JSON", Application.dataPath, "json");
        if (string.IsNullOrEmpty(path))
            return;

        string json = File.ReadAllText(path, System.Text.Encoding.UTF8);
        var importList = JsonUtility.FromJson<ExportRecordList>(json);
        if (importList == null || importList.records == null)
        {
            Debug.LogError("JSON格式不正确或无数据");
            return;
        }
        recordData.records.Clear();
        int successCount = 0;
        int failCount = 0; 
        var mainCanvas = GetMainCanvas();
        if (mainCanvas == null) return;

        foreach (Transform child in mainCanvas.transform)
        {
            if (child.name.StartsWith("Cell_"))
            {
                child.gameObject.SetActive(true);
                child.GetChild(0).transform.gameObject.SetActive(true);
            }
        }
        foreach (var rec in importList.records)
        {
            var newRecord = new UIObjectRecord();
            newRecord.rootName = rec.rootName;
            newRecord.allNames = new List<string>(rec.allNames);
            newRecord.displayName = rec.PanleName;
            newRecord.displayObject = GameObject.Find(newRecord.displayName);
            newRecord.rootObject = GameObject.Find(newRecord.rootName);
            if (newRecord.rootObject != null)
            {

                successCount++;
            }
            else
            {
                SetActiveRecursive(newRecord.displayObject, true);
                newRecord.rootObject = GameObject.Find(newRecord.rootName);
                failCount++;
            }

            recordData.records.Add(newRecord);
        }
        
        EditorUtility.SetDirty(recordData);
        AssetDatabase.SaveAssets();
        Debug.LogError(
            $"已从JSON导入记录。成功关联对象：{successCount} 个 未找到对象：{failCount} 个"
        );
    }

    

    private void AddCurrentSelectionRecord()
    {
        if (Selection.gameObjects == null || Selection.gameObjects.Length == 0)
        {
            Debug.LogError("请先选中一个或多个对象");
            return;
        }
        var objs = Selection.gameObjects;
        foreach(var root in objs)
        {
            string rootName = root.name;
            var record = new UIObjectRecord();
            record.rootObject = root; // 记录引用
            record.rootName = rootName;
            var all = root.GetComponentsInChildren<Transform>(true);
            Transform parent = record.rootObject.transform.parent;
            GameObject found = null;
            while (parent != null)
            {
                if (parent.name.StartsWith("Cell_"))
                {
                    found = parent.gameObject;
                    break;
                }
                parent = parent.parent;
            }
            // 如果没有Cell_父节点，则用rootObject本身
            record.displayObject = found != null ? found : record.rootObject;
            record.displayName = record.displayObject.name;
            foreach (var t in all)
            {
                record.allNames.Add(t.name);
            }
            root.gameObject.SetActive(false);
            recordData.records.Add(record);
        }
        EditorUtility.SetDirty(recordData);
        ExportUnityRecordsToJson();
        AssetDatabase.SaveAssets();
    } 

    private void DeleteRecord(int index)
    {
        if (index >= 0 && index < recordData.records.Count)
        {
            recordData.records.RemoveAt(index);

            ExportUnityRecordsToJson();
            EditorUtility.SetDirty(recordData);
            AssetDatabase.SaveAssets();
        }
    }

    private void SaveRecordData()
    {
        ExportUnityRecordsToJson();
        EditorUtility.SetDirty(recordData);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }

    private void ReloadRecordData()
    {
        recordData = AssetDatabase.LoadAssetAtPath<UIObjectRecordData>(recordAssetPath);
        if(recordData == null)
        {
            recordData = new UIObjectRecordData();
        }
    }

    private void ExportRecordsToJson()
    {
        if (recordData == null || recordData.records.Count == 0)
        {
            Debug.LogError("没有可导出的记录");
            return;
        }

        // 构造导出用的简化数据结构
        var exportList = new List<ExportRecord>();
        foreach (var rec in recordData.records)
        {
            exportList.Add(new ExportRecord
            {
                rootName = rec.rootObject != null ? rec.rootObject.name : rec.rootName,
                allNames = rec.allNames,
                PanleName = rec.displayName
            });
        }

        string json = JsonUtility.ToJson(new ExportRecordList { records = exportList }, true);

        string path = EditorUtility.SaveFilePanel(
            "导出为JSON",
            Application.dataPath,
            "UIObjectRecords.json",
            "json"
        );
        if (!string.IsNullOrEmpty(path))
        {
            File.WriteAllText(path, json, System.Text.Encoding.UTF8);
            Debug.LogError($"已导出到:\n{path}");
            AssetDatabase.Refresh();
        }
    }
    private void ExportUnityRecordsToJson()
    {
        if (recordData == null || recordData.records.Count == 0)
        {
            Debug.LogError("没有可导出的记录");
            return;
        }

        // 构造导出用的简化数据结构
        var exportList = new List<ExportRecord>();
        foreach (var rec in recordData.records)
        {
            exportList.Add(new ExportRecord
            {
                rootName = rec.rootObject != null ? rec.rootObject.name : rec.rootName,
                allNames = rec.allNames,
                PanleName = rec.displayName
            });
        }

        string json = JsonUtility.ToJson(new ExportRecordList { records = exportList }, true);

      
        File.WriteAllText(recordAssetJsonPath, json, System.Text.Encoding.UTF8);
        AssetDatabase.Refresh();
    }
    // 用于导出JSON的结构
    [System.Serializable]
    private class ExportRecordList
    {
        public List<ExportRecord> records;
    }

    [System.Serializable]
    private class ExportRecord
    {
        public string PanleName;
        public string rootName;
        public List<string> allNames;
    }



}


