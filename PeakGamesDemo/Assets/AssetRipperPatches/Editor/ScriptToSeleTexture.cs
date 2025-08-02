#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class ScriptToSeleTexture
{
    
#if UNITY_EDITOR
    [MenuItem("Assets/选中Sprite跳转到Texture", false, 2000)]
    private static void SelectSpriteTexture()
    {
        // 获取当前选中的对象
        Object obj = Selection.activeObject;
        if (obj is Sprite sprite)
        {
            // 获取Sprite的Texture
            Texture2D texture = sprite.texture;
            if (texture != null)
            {
                // 选中Texture对象
                Selection.activeObject = texture;
                EditorGUIUtility.PingObject(texture);
            }
            else
            {
                EditorUtility.DisplayDialog("提示", "未找到Sprite的Texture。", "确定");
            }
        }
        else
        {
            EditorUtility.DisplayDialog("提示", "请先选中一个Sprite资源。", "确定");
        }
    }

    // 仅在选中Sprite时才显示菜单
    [MenuItem("Assets/选中Sprite跳转到Texture", true)]
    private static bool ValidateSelectSpriteTexture()
    {
        return Selection.activeObject is Sprite;
    }
#endif
}
