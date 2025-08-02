using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using UnityEngine.TestTools.Utils;

public class MeshTrianglePickerWindow : EditorWindow
{
    public enum ConnectedMode
    {
        ByVertex,
        ByUV
    }
    private ConnectedMode connectedMode = ConnectedMode.ByVertex;

    private GameObject targetObject; // 新增：目标模型对象
    private GameObject lastHitObject;
    private int lastTriangleIndex = -1;
    private int[] lastTriangleVertexIndices;
    private Vector3[] lastTriangleVertices;
    // 在类中添加
    private Vector3? lastHitPoint = null;
    private Mesh lastGeneratedMesh = null;

    private List<int> connectedTriangleIndices = new List<int>();
    private List<int[]> connectedTriangleVertexIndices = new List<int[]>();
    private List<Vector3[]> connectedTriangleVertices = new List<Vector3[]>();

    [MenuItem("Tools/三角形拾取与删除工具")]
    public static void ShowWindow()
    {
        GetWindow<MeshTrianglePickerWindow>("三角形拾取与删除");
    }

    private void OnEnable()
    {
        SceneView.duringSceneGui += OnSceneGUI;
    }
    private void OnDisable()
    {
        SceneView.duringSceneGui -= OnSceneGUI;
    }

    private void OnGUI()
    {
        GUILayout.Label("1. 先设置目标模型对象", EditorStyles.boldLabel);
        targetObject = (GameObject)EditorGUILayout.ObjectField("目标模型对象", targetObject, typeof(GameObject), true);

        if (targetObject == null)
        {
            EditorGUILayout.HelpBox("请先设置目标模型对象。", MessageType.Info);
            return;
        }
        GUILayout.Space(10);
        connectedMode = (ConnectedMode)EditorGUILayout.EnumPopup("关联方式", connectedMode);

        GUILayout.Space(10);
        GUILayout.Label("2. 在Scene视图中点击该模型以拾取三角形", EditorStyles.boldLabel);

        if (lastHitObject != null && lastTriangleVertexIndices != null)
        {
            GUILayout.Label($"对象: {lastHitObject.name}");
            GUILayout.Label($"三角形索引: {lastTriangleIndex}");
            GUILayout.Label("顶点索引: " + string.Join(", ", lastTriangleVertexIndices));
            GUILayout.Label("顶点坐标:");
            for (int i = 0; i < lastTriangleVertices.Length; i++)
            {
                GUILayout.Label($"  {i}: {lastTriangleVertices[i]}");
            }

            GUILayout.Space(10);
            GUILayout.Label($"相连三角形数量: {connectedTriangleIndices.Count}");

            if (GUILayout.Button("删除这些三角形"))
            {
                DeleteConnectedTriangles();
                lastHitObject = null;
                lastTriangleVertexIndices = null;
                lastTriangleVertices = null;
                connectedTriangleIndices.Clear();
                connectedTriangleVertexIndices.Clear();
                connectedTriangleVertices.Clear();
            }
        }
        else
        {
            GUILayout.Label("未选中三角形");
        }
        if (lastGeneratedMesh != null)
        {
            GUILayout.Space(10);
            if (GUILayout.Button("保存当前Mesh到本地"))
            {
                string path = EditorUtility.SaveFilePanelInProject("保存新Mesh", lastGeneratedMesh.name + ".asset", "asset", "选择保存路径");
                if (!string.IsNullOrEmpty(path))
                {
                    AssetDatabase.CreateAsset(Object.Instantiate(lastGeneratedMesh), path);
                    AssetDatabase.SaveAssets();
                    Debug.Log("Mesh已保存到: " + path);
                }
            }
        }

    }

    private void OnSceneGUI(SceneView sceneView)
    {
        if (targetObject == null) return;

        Event e = Event.current;
        if (e.type == EventType.MouseDown && e.button == 0 && !e.alt)
        {
            Ray ray = HandleUtility.GUIPointToWorldRay(e.mousePosition);

            MeshFilter mf = targetObject.GetComponent<MeshFilter>();
            if (mf != null && mf.sharedMesh != null)
            {
                Mesh mesh = mf.sharedMesh;
                int[] triangles = mesh.triangles;
                Vector3[] vertices = mesh.vertices;

                float minDist = float.MaxValue;
                int hitTriIndex = -1;
                Vector3 hitPoint = Vector3.zero;

                // 先找到被点击的三角形
                for (int t = 0; t < triangles.Length; t += 3)
                {
                    Vector3 v0 = targetObject.transform.TransformPoint(vertices[triangles[t]]);
                    Vector3 v1 = targetObject.transform.TransformPoint(vertices[triangles[t + 1]]);
                    Vector3 v2 = targetObject.transform.TransformPoint(vertices[triangles[t + 2]]);

                    if (RayTriangleIntersection(ray, v0, v1, v2, out Vector3 point))
                    {
                        float dist = Vector3.Distance(ray.origin, point);
                        if (dist < minDist)
                        {
                            minDist = dist;
                            hitTriIndex = t / 3;
                            hitPoint = point;
                        }
                    }
                }

                if (hitTriIndex >= 0)
                {
                    lastHitPoint = hitPoint;
                    lastHitObject = targetObject;
                    lastTriangleIndex = hitTriIndex;
                    int i0 = triangles[hitTriIndex * 3 + 0];
                    int i1 = triangles[hitTriIndex * 3 + 1];
                    int i2 = triangles[hitTriIndex * 3 + 2];
                    lastTriangleVertexIndices = new int[] { i0, i1, i2 };
                    lastTriangleVertices = new Vector3[]
                    {
                    targetObject.transform.TransformPoint(vertices[i0]),
                    targetObject.transform.TransformPoint(vertices[i1]),
                    targetObject.transform.TransformPoint(vertices[i2])
                    };

                    // 基于UV递归查找所有关联三角形
                    List<(int triangleIndex, int[] vertexIndices, Vector3[] worldPositions)> connected;
                    if (connectedMode == ConnectedMode.ByVertex)
                        connected = FindConnectedTrianglesByVertex(mesh, targetObject.transform, lastTriangleVertexIndices, 0.0001f);
                    else
                        connected = FindConnectedTrianglesByUV(mesh, targetObject.transform, lastTriangleVertexIndices, 0.0001f);


                    connectedTriangleIndices.Clear();
                    connectedTriangleVertexIndices.Clear();
                    connectedTriangleVertices.Clear();
                    foreach (var item in connected)
                    {
                        connectedTriangleIndices.Add(item.triangleIndex);
                        connectedTriangleVertexIndices.Add(item.vertexIndices);
                        connectedTriangleVertices.Add(item.worldPositions);
                    }

                    Repaint();
                    e.Use();
                }
                else
                {
                    // 没有选中任何三角形，清空状态
                    lastHitPoint = null;
                    lastHitObject = null;
                    lastTriangleIndex = -1;
                    lastTriangleVertexIndices = null;
                    lastTriangleVertices = null;
                    connectedTriangleIndices.Clear();
                    connectedTriangleVertexIndices.Clear();
                    connectedTriangleVertices.Clear();
                    Repaint();
                }
            }
        }

        // 绘制红色小球：高亮所有相连三角形的顶点
        if (connectedTriangleVertices.Count > 0)
        {
            Handles.color = Color.red;
            foreach (var triVerts in connectedTriangleVertices)
            {
                foreach (var v in triVerts)
                {
                    Handles.SphereHandleCap(0, v, Quaternion.identity, HandleUtility.GetHandleSize(v) * 0.05f, EventType.Repaint);
                }
            }
        }

        // 绘制黄色交点
        if (lastHitPoint.HasValue)
        {
            Handles.color = Color.yellow;
            Handles.SphereHandleCap(0, lastHitPoint.Value, Quaternion.identity, HandleUtility.GetHandleSize(lastHitPoint.Value) * 0.08f, EventType.Repaint);
        }
    }
    public static List<(int triangleIndex, int[] vertexIndices, Vector3[] worldPositions)>
    FindConnectedTrianglesByVertex(Mesh mesh, Transform transform, int[] seedTriangleIndices, float positionEpsilon = 0.0001f)
    {
        int[] triangles = mesh.triangles;
        Vector3[] vertices = mesh.vertices;
        int triCount = triangles.Length / 3;

        // 1. 初始顶点世界坐标集合
        HashSet<Vector3> selectedPositions = new HashSet<Vector3>(new Vector3EqualityComparer(positionEpsilon));
        foreach (var idx in seedTriangleIndices)
            selectedPositions.Add(transform.TransformPoint(vertices[idx]));

        // 2. 递归扩展
        HashSet<int> visitedTriangles = new HashSet<int>();
        bool changed = true;
        while (changed)
        {
            changed = false;
            for (int t = 0; t < triCount; t++)
            {
                if (visitedTriangles.Contains(t)) continue;
                int ti0 = triangles[t * 3 + 0];
                int ti1 = triangles[t * 3 + 1];
                int ti2 = triangles[t * 3 + 2];
                Vector3 w0 = transform.TransformPoint(vertices[ti0]);
                Vector3 w1 = transform.TransformPoint(vertices[ti1]);
                Vector3 w2 = transform.TransformPoint(vertices[ti2]);

                if (selectedPositions.Contains(w0) || selectedPositions.Contains(w1) || selectedPositions.Contains(w2))
                {
                    visitedTriangles.Add(t);
                    if (selectedPositions.Add(w0)) changed = true;
                    if (selectedPositions.Add(w1)) changed = true;
                    if (selectedPositions.Add(w2)) changed = true;
                }
            }
        }

        // 3. 收集结果
        var result = new List<(int triangleIndex, int[] vertexIndices, Vector3[] worldPositions)>();
        foreach (int t in visitedTriangles)
        {
            int ti0 = triangles[t * 3 + 0];
            int ti1 = triangles[t * 3 + 1];
            int ti2 = triangles[t * 3 + 2];
            Vector3 w0 = transform.TransformPoint(vertices[ti0]);
            Vector3 w1 = transform.TransformPoint(vertices[ti1]);
            Vector3 w2 = transform.TransformPoint(vertices[ti2]);
            result.Add((t, new int[] { ti0, ti1, ti2 }, new Vector3[] { w0, w1, w2 }));
        }
        return result;
    }

    /// <summary>
    /// 查找与给定三角形顶点“UV相同/接近”的所有三角形（递归扩展）
    /// </summary>
    public static List<(int triangleIndex, int[] vertexIndices, Vector3[] worldPositions)>
        FindConnectedTrianglesByUV(Mesh mesh, Transform transform, int[] seedTriangleIndices, float uvEpsilon = 0.0001f)
    {
        int[] triangles = mesh.triangles;
        Vector3[] vertices = mesh.vertices;
        Vector2[] uvs = mesh.uv;
        int triCount = triangles.Length / 3;

        // 1. 初始顶点UV集合
        HashSet<Vector2> selectedUVs = new HashSet<Vector2>(new Vector2EqualityComparer(uvEpsilon));
        foreach (var idx in seedTriangleIndices)
            selectedUVs.Add(uvs[idx]);

        // 2. 递归扩展
        HashSet<int> visitedTriangles = new HashSet<int>();
        bool changed = true;
        while (changed)
        {
            changed = false;
            for (int t = 0; t < triCount; t++)
            {
                if (visitedTriangles.Contains(t)) continue;
                int ti0 = triangles[t * 3 + 0];
                int ti1 = triangles[t * 3 + 1];
                int ti2 = triangles[t * 3 + 2];
                Vector2 uv0 = uvs[ti0];
                Vector2 uv1 = uvs[ti1];
                Vector2 uv2 = uvs[ti2];

                // 如果三角形的任意顶点UV与已选UV集合重合，则加入
                if (selectedUVs.Contains(uv0) || selectedUVs.Contains(uv1) || selectedUVs.Contains(uv2))
                {
                    visitedTriangles.Add(t);
                    if (selectedUVs.Add(uv0)) changed = true;
                    if (selectedUVs.Add(uv1)) changed = true;
                    if (selectedUVs.Add(uv2)) changed = true;
                }
            }
        }

        // 3. 收集结果
        var result = new List<(int triangleIndex, int[] vertexIndices, Vector3[] worldPositions)>();
        foreach (int t in visitedTriangles)
        {
            int ti0 = triangles[t * 3 + 0];
            int ti1 = triangles[t * 3 + 1];
            int ti2 = triangles[t * 3 + 2];
            Vector3 w0 = transform.TransformPoint(vertices[ti0]);
            Vector3 w1 = transform.TransformPoint(vertices[ti1]);
            Vector3 w2 = transform.TransformPoint(vertices[ti2]);
            result.Add((t, new int[] { ti0, ti1, ti2 }, new Vector3[] { w0, w1, w2 }));
        }
        return result;
    }


    /// <summary>
    /// Vector3近似相等比较器（用于HashSet）
    /// </summary>
    class Vector3EqualityComparer : IEqualityComparer<Vector3>
    {
        private readonly float epsilon;
        public Vector3EqualityComparer(float epsilon) { this.epsilon = epsilon; }
        public bool Equals(Vector3 a, Vector3 b) => (a - b).sqrMagnitude < epsilon * epsilon;
        public int GetHashCode(Vector3 obj) => 0; // 只用于Contains，不用于字典key
    }

    private bool RayTriangleIntersection(Ray ray, Vector3 v0, Vector3 v1, Vector3 v2, out Vector3 hit)
    {
        hit = Vector3.zero;
        Vector3 edge1 = v1 - v0;
        Vector3 edge2 = v2 - v0;
        Vector3 h = Vector3.Cross(ray.direction, edge2);
        float a = Vector3.Dot(edge1, h);
        if (a > -Mathf.Epsilon && a < Mathf.Epsilon)
            return false; // 平行
        float f = 1.0f / a;
        Vector3 s = ray.origin - v0;
        float u = f * Vector3.Dot(s, h);
        if (u < 0.0f || u > 1.0f)
            return false;
        Vector3 q = Vector3.Cross(s, edge1);
        float v = f * Vector3.Dot(ray.direction, q);
        if (v < 0.0f || u + v > 1.0f)
            return false;
        float t = f * Vector3.Dot(edge2, q);
        if (t > Mathf.Epsilon)
        {
            hit = ray.origin + ray.direction * t;
            return true;
        }
        return false;
    }
    private void DeleteConnectedTriangles()
    {
        if (lastHitObject == null) return;
        MeshFilter mf = lastHitObject.GetComponent<MeshFilter>();
        if (mf == null || mf.sharedMesh == null) return;

        Mesh mesh = mf.sharedMesh;
        int subMeshCount = mesh.subMeshCount;

        Vector3[] vertices = mesh.vertices;
        Vector2[] uvs = mesh.uv;
        Vector3[] normals = mesh.normals;
        Color[] colors = mesh.colors;
        Vector4[] tangents = mesh.tangents;

        // 1. 统计所有未被删除的三角形索引（所有submesh都要处理）
        HashSet<int> usedVertexIndices = new HashSet<int>();
        List<int[]> newSubTriangles = new List<int[]>();

        int globalTriOffset = 0;
        for (int sub = 0; sub < subMeshCount; ++sub)
        {
            int[] triangles = mesh.GetTriangles(sub);
            List<int> newTriangles = new List<int>();
            int triCount = triangles.Length / 3;
            for (int t = 0; t < triCount; t++)
            {
                int globalTriIndex = globalTriOffset + t;
                // 删除所有被选中的三角形（不区分submesh）
                if (connectedTriangleIndices.Contains(globalTriIndex))
                    continue;

                int i0 = triangles[t * 3 + 0];
                int i1 = triangles[t * 3 + 1];
                int i2 = triangles[t * 3 + 2];
                newTriangles.Add(i0);
                newTriangles.Add(i1);
                newTriangles.Add(i2);
                usedVertexIndices.Add(i0);
                usedVertexIndices.Add(i1);
                usedVertexIndices.Add(i2);
            }
            newSubTriangles.Add(newTriangles.ToArray());
            globalTriOffset += triCount;
        }

        // 2. 建立旧索引到新索引的映射
        Dictionary<int, int> oldToNew = new Dictionary<int, int>();
        List<Vector3> newVertices = new List<Vector3>();
        List<Vector2> newUVs = new List<Vector2>();
        List<Vector3> newNormals = new List<Vector3>();
        List<Color> newColors = new List<Color>();
        List<Vector4> newTangents = new List<Vector4>();
        int newIndex = 0;
        for (int i = 0; i < vertices.Length; i++)
        {
            if (usedVertexIndices.Contains(i))
            {
                oldToNew[i] = newIndex++;
                newVertices.Add(vertices[i]);
                if (uvs != null && uvs.Length == vertices.Length) newUVs.Add(uvs[i]);
                if (normals != null && normals.Length == vertices.Length) newNormals.Add(normals[i]);
                if (colors != null && colors.Length == vertices.Length) newColors.Add(colors[i]);
                if (tangents != null && tangents.Length == vertices.Length) newTangents.Add(tangents[i]);
            }
        }

        // 3. remap 所有submesh的三角形索引
        List<int[]> remappedSubTriangles = new List<int[]>();
        for (int sub = 0; sub < subMeshCount; ++sub)
        {
            List<int> remapped = new List<int>();
            foreach (var idx in newSubTriangles[sub])
            {
                if (oldToNew.TryGetValue(idx, out int newIdx))
                    remapped.Add(newIdx);
            }
            remappedSubTriangles.Add(remapped.ToArray());
        }

        // 4. 创建新mesh并赋值
        Mesh newMesh = new Mesh();
        newMesh.name = mesh.name + "_modified";
        newMesh.vertices = newVertices.ToArray();
        if (uvs != null && uvs.Length == vertices.Length) newMesh.uv = newUVs.ToArray();
        if (normals != null && normals.Length == vertices.Length) newMesh.normals = newNormals.ToArray();
        if (colors != null && colors.Length == vertices.Length) newMesh.colors = newColors.ToArray();
        if (tangents != null && tangents.Length == vertices.Length) newMesh.tangents = newTangents.ToArray();

        newMesh.subMeshCount = subMeshCount;
        for (int sub = 0; sub < subMeshCount; ++sub)
        {
            newMesh.SetTriangles(remappedSubTriangles[sub], sub);
        }

        newMesh.RecalculateBounds();
        newMesh.RecalculateNormals();
        mf.sharedMesh = newMesh;
        lastGeneratedMesh = newMesh;
        Debug.Log("已删除选中的三角形及其相连三角形，并清理无用顶点，Mesh已直接替换到对象（未保存到本地）");
    }





}
