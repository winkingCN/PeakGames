using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class TexturePixelProcessor : EditorWindow
{
    [MenuItem("Assets/去除精灵外像素数据", false, 200)]
    public static void ProcessTexturePixels()
    {
        var selectedTexture = Selection.objects ;
        foreach(var texture in selectedTexture )
        {
            if (texture is Texture2D text)
            {
                ProcessPixels(text);
            }
        }
        AssetDatabase.Refresh();
    }

    static void ProcessPixels(Texture2D texture)
    {
        texture.SetTextureReadable();
        List<Sprite> sprites = GetSpritesUsingTexture(texture);
        if (sprites.Count == 0) return;
        List<Rect> rects = new List<Rect>();
        foreach (Sprite sprite in sprites)
        {
            //获取精灵在纹理中的实际矩形
            Rect spriteTextureRect = GetSpriteTextureRect(sprite);
            rects.Add(spriteTextureRect);
        }
        bool hasSprites = sprites.Count > 0;

        // 如果没有精灵使用该纹理，将所有像素设置为透明
        if (!hasSprites)
        {
            Debug.Log("Texture is not used by any Sprite.");
            ProcessPixelsWithoutSprite(texture);
            return;
        }


        // 1. 读取纹理的像素数据
        Color[] pixels = texture.GetPixels();
        int width = texture.width;
        int height = texture.height;


        // 2. 遍历每一个像素
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                bool isPixelInAnySprite = false; // 标记像素是否在任何一个精灵范围内
                foreach (var spriteTextureRect in rects)
                {
                    float textureX = x;
                    float textureY = height - 1 - y;

                    if (spriteTextureRect.Contains(new Vector2(textureX, textureY)))
                    {
                        isPixelInAnySprite = true;
                        break; // 如果像素在一个精灵范围内，则不需要检查其他精灵
                    }
                }

                if (!isPixelInAnySprite)
                {
                    int index = y * width + x;
                    pixels[index] = Color.clear; // 设置透明
                }
            }
        }

        // 3. 将修改后的像素设置回纹理
        texture.SetPixels(pixels);
        texture.Apply();

        // 4. 保存修改
        string texturePath = AssetDatabase.GetAssetPath(texture);
        byte[] textureBytes = texture.EncodeToPNG(); // PNG可以保留透明信息
        File.WriteAllBytes(texturePath, textureBytes);
        AssetDatabase.ImportAsset(texturePath);

        Debug.Log("Texture processed successfully!");
    }

    // 如果没有精灵使用该纹理，将所有像素设置为透明
    static void ProcessPixelsWithoutSprite(Texture2D texture)
    {
        Color[] pixels = new Color[texture.width * texture.height];
        for (int i = 0; i < pixels.Length; ++i)
        {
            pixels[i] = Color.clear;
        }

        texture.SetPixels(pixels);
        texture.Apply();

        // 保存修改
        string texturePath = AssetDatabase.GetAssetPath(texture);
        byte[] textureBytes = texture.EncodeToPNG(); // PNG可以保留透明信息
        File.WriteAllBytes(texturePath, textureBytes);
        AssetDatabase.ImportAsset(texturePath);

        Debug.Log("Texture processed successfully! (No Sprite Detected)");
    }


    // 获取所有使用给定纹理的精灵
    static List<Sprite> GetSpritesUsingTexture(Texture2D texture)
    {
        List<Sprite> sprites = new List<Sprite>();
        var objs = AssetDatabase.LoadAllAssetsAtPath(AssetDatabase.GetAssetPath(texture));
        foreach(var obj in objs )
        {
            if(obj is Sprite sprite)
            {
                sprites.Add(sprite);
            }
        }
        return sprites;
    }

    // 获取精灵在纹理中的实际矩形（考虑 pivot 和 textureRect）
    static Rect GetSpriteTextureRect(Sprite sprite)
    {
        Rect rect = sprite.textureRect; //精灵在纹理中的矩形
        Vector2 pivot = sprite.pivot;    // 获取精灵的中心点

        float textureWidth = sprite.texture.width;
        float textureHeight = sprite.texture.height;

        float left = rect.xMin;
        float bottom = textureHeight - rect.yMax;
        float width = rect.width;
        float height = rect.height;

        //  将精灵 pivot 的原点从精灵矩形中心点改为左下角
        float pivotX = pivot.x - rect.width * 0.5f;
        float pivotY = pivot.y - rect.height * 0.5f;

        // 将精灵的范围转换为纹理空间
        Rect spriteTextureRect = new Rect(left + pivotX, bottom + pivotY, width, height);

        return spriteTextureRect;

    }
}
public static class TextureTools 
{
    public static string GetFilePath(this Texture2D texture)
    {
        return AssetDatabase.GetAssetPath(texture).Replace("Assets",Application.dataPath);
    }

    public static void Save(this Texture2D texture)
    {
        texture.Apply();
        File.WriteAllBytes(texture.GetFilePath(), texture.EncodeToPNG());
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
    public static void Save(this Texture2D texture,string path)
    {
        texture.Apply();
        if(Directory.Exists(Path.GetDirectoryName(path)) == false)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path));
        }
        File.WriteAllBytes(path, texture.EncodeToPNG());
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
    public static void SetTextureReadable(this Texture text,bool isTrue = false)
    {
        if (text.isReadable == false|| isTrue)
        {
            var path1 = AssetDatabase.GetAssetPath(text);
            TextureImporter textureImporter = AssetImporter.GetAtPath(path1) as TextureImporter;
            textureImporter.isReadable = true;
            textureImporter.textureCompression = TextureImporterCompression.Uncompressed;
            textureImporter.SaveAndReimport();
            AssetDatabase.ImportAsset(path1, ImportAssetOptions.ForceUpdate | ImportAssetOptions.ForceSynchronousImport);
            AssetDatabase.Refresh();
        }
    }

    public static void SetTextureToSprite(this Texture2D text)
    {
        var path = AssetDatabase.GetAssetPath(text);
        TextureImporter textureImporter = AssetImporter.GetAtPath(path) as TextureImporter;
        textureImporter.textureType = TextureImporterType.Sprite;
        textureImporter.filterMode = FilterMode.Point;
        textureImporter.isReadable = true;
        textureImporter.SaveAndReimport();
        AssetDatabase.ImportAsset(path, ImportAssetOptions.ForceUpdate | ImportAssetOptions.ForceSynchronousImport);
        
    }
    public static Color[] GetPixels(Texture2D texture)
    {
        if (texture.isReadable)
        {
            return texture.GetPixels();
        }
        else
        {
#if UNITY_EDITOR
            Texture2D tt = new Texture2D(1, 1); // 初始化一个Texture2D
            byte[] imageBytes = File.ReadAllBytes(AssetDatabase.GetAssetPath(texture));
            tt.LoadImage(imageBytes); // 从byte数组加载图片
            tt.Apply();

            return tt.GetPixels();
#else
        return null;
#endif
        }
    }
    /// <summary>
    /// 通过 HSV 值调整纹理颜色。
    /// </summary>
    /// <param name="texture">要修改的纹理。</param>
    /// <param name="tex">修改后的纹理。</param>
    /// <param name="h">色相，范围 0-360。</param>
    /// <param name="s">饱和度，范围 0-100。</param>
    /// <param name="v">亮度，范围 0-100。</param>
    public static void ApplyHSVToTexture(this Texture2D texture, Texture2D tex, float h, float s, float v)
    {
        texture.SetTextureReadable();
        var colors = texture.GetPixels();
        var idx = 0;

        // 将输入的HSV值转换为 0-1 范围
        float hNormalized = h / 360f;
        float sNormalized = s / 100f;
        float vNormalized = v / 100f;

        for (int y = 0; y < texture.height; y++)
        {
            idx = y * texture.width;
            for (int x = 0; x < texture.width; x++)
            {
                Color originalColor = colors[idx + x];

                if (originalColor.a > 0)
                {
                    var a = originalColor.a;
                    Color.RGBToHSV(originalColor, out float h1, out float s1, out float v1);
                    Color newColor;
                    if (hNormalized == 0 && sNormalized == 0 && vNormalized == 0)
                    {
                        newColor = originalColor;
                    }
                    else
                    {
                        h1 += hNormalized;
                        s1 += sNormalized;
                        v1 += vNormalized;
                        h1 %= 1f;
                        if (h1 < 0)
                        {
                            h1 = 1 + h1;
                        }

                        s1 = s1 > 1f ? 1f : s1;
                        v1 = v1 > 1f ? 1f : v1;
                        s1 = s1 < 0f ? 0f : s1;
                        v1 = v1 < 0f ? 0f : v1;
                        newColor = Color.HSVToRGB(h1, s1, v1);
                        newColor.a = a;
                        colors[idx + x] = newColor;
                    }
                }
            }
        }
        tex.SetPixels(colors);
        tex.Apply();
    }
    public static void ApplyColorFilterAndWrite(this Texture2D sourceTexture, Texture2D targetTexture, Color color)
    {
        if (sourceTexture == null)
        {
            Debug.LogError("Source texture is null!");
            return;
        }

        if (targetTexture == null)
        {
            Debug.LogError("Target texture is null!");
            return;
        }

        if (sourceTexture.width != targetTexture.width || sourceTexture.height != targetTexture.height)
        {
            Debug.LogError("Source and target textures must have the same dimensions.");
            return;
        }

        // 获取源纹理的所有像素颜色
        Color[] sourcePixels = sourceTexture.GetPixels();
        Color[] newPixels = new Color[sourcePixels.Length];

        // 遍历源纹理的每个像素，并应用颜色滤镜
        for (int i = 0; i < sourcePixels.Length; i++)
        {
            // 将颜色与源像素颜色相乘
            newPixels[i] = sourcePixels[i] * color;
        }
        // 将修改后的像素应用到目标纹理
        targetTexture.SetPixels(newPixels);
        targetTexture.Apply();
    }
    public static void DrawMinMaxSlider(ref float xValue, ref float yValue, float minValue, float maxValue)
    {
        var fieldWidth = EditorGUIUtility.fieldWidth;
        EditorGUILayout.BeginHorizontal();
        EditorGUI.BeginChangeCheck();
        xValue = EditorGUILayout.FloatField( xValue, GUILayout.Width(40));
        EditorGUILayout.MinMaxSlider(ref xValue, ref yValue, minValue, maxValue);
        yValue = EditorGUILayout.FloatField( yValue, GUILayout.Width(40));
        xValue = Mathf.Clamp(xValue, minValue, Mathf.Min(maxValue, yValue));
        yValue = Mathf.Clamp(yValue, Mathf.Max(minValue, xValue), maxValue);
        if (EditorGUI.EndChangeCheck())
        {
            xValue = (float)System.Math.Round(xValue, 3);
            yValue = (float)System.Math.Round(yValue, 3);
        }
        EditorGUILayout.EndHorizontal();
    }
    public static void DrawMinMaxSlider(ref Vector2 value, float minValue, float maxValue)
    {
        var xValue = value.x;
        var yValue = value.y;
        EditorGUILayout.BeginHorizontal();
        EditorGUI.BeginChangeCheck();
        var fieldWidth = EditorGUIUtility.fieldWidth;
        xValue = EditorGUILayout.FloatField(xValue,GUILayout.Width(40));
        EditorGUILayout.MinMaxSlider(ref xValue, ref yValue, minValue, maxValue);
        yValue = EditorGUILayout.FloatField(yValue, GUILayout.Width(40));
        xValue = Mathf.Clamp(xValue, minValue, Mathf.Min(maxValue, yValue));
        yValue = Mathf.Clamp(yValue, Mathf.Max(minValue, xValue), maxValue);
        if (EditorGUI.EndChangeCheck())
        {
            xValue = (float)System.Math.Round(xValue, 3);
            yValue = (float)System.Math.Round(yValue, 3);
        }
        EditorGUILayout.EndHorizontal();
        value.x = xValue;
        value.y = yValue;
    }
    public static void SpriteToTexture(this Texture2D texture,Sprite sprite,Texture2D text)
    {
        text.SetTextureReadable();
        var rect = sprite.rect;
        texture.SetPixels((int)rect.x, (int)rect.y, (int)rect.width, (int)rect.height, text.GetPixels());
    }
    public static Texture2D ToTexture(this Sprite sprite)
    {
        if (sprite == null ||sprite.texture == null) return null;
        sprite.texture.SetTextureReadable();
        Texture2D texture = new Texture2D((int)sprite.rect.width, (int)sprite.rect.height);
        var pixels = sprite.texture.GetPixels((int)sprite.rect.x, (int)sprite.rect.y, (int)sprite.rect.width, (int)sprite.rect.height);
        texture.SetPixels(pixels);
        texture.Apply();
        return texture;
    }
    public static Texture2D ApplyOutColorline(this Texture2D sourceTexture,Texture2D previewTexture, int outlineThickness, Color outlineColor)
    {
        int width = sourceTexture.width;
        int height = sourceTexture.height;
        Debug.Log(width + "  " + height);
        if(previewTexture == null)
            previewTexture = new Texture2D(width + outlineThickness * 2, height + outlineThickness * 2);
        sourceTexture.SetTextureReadable();
        Color[] originalPixels = sourceTexture.GetPixels();
        Color[] newPixels = new Color[(width + outlineThickness * 2) * (height + outlineThickness * 2)];

        // 初始化新纹理的像素为透明
        for (int i = 0; i < newPixels.Length; i++)
        {
            newPixels[i] = Color.clear;
        }

        // 复制源纹理到中心
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                newPixels[(y + outlineThickness) * (width + outlineThickness * 2) + x + outlineThickness] = originalPixels[y * width + x];
            }
        }

        // 绘制轮廓
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                var color = originalPixels[y * width + x];
                if (color.a > 0)
                {
                    for (int oy = -outlineThickness; oy <= outlineThickness; oy++)
                    {
                        for (int ox = -outlineThickness; ox <= outlineThickness; ox++)
                        {
                            int nx = x + outlineThickness + ox;
                            int ny = y + outlineThickness + oy;

                            if (nx >= 0 && nx < width + outlineThickness * 2 && ny >= 0 && ny < height + outlineThickness * 2)
                            {
                                newPixels[(ny + outlineThickness) * (width + outlineThickness * 2) + nx + outlineThickness] = outlineColor;
                            }
                        }
                    }
                }
            }
        }
        // 恢复原像素透明度
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Color color = originalPixels[y * width + x];
                if (color.a > 0)
                {
                     var d = newPixels[(y + outlineThickness * 2) * (width + outlineThickness * 2) + x + outlineThickness * 2];
                     color = Color.Lerp(d,color,color.a);
                     color.a = 1;
                     newPixels[(y + outlineThickness * 2) * (width + outlineThickness * 2) + x + outlineThickness * 2] = color;
                }
                
            }
        }
        width = width + outlineThickness * 2;
        height = height + outlineThickness * 2;
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Color color = newPixels[y * width + x];
                if (color.a > 0)
                {
                    if (CalculateOpaque(x, y, width, height, newPixels))
                    {
                        color.a = 0.5f;
                        newPixels[y * width + x] = color;
                    }
                    
                }
            }
        }
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Color color = newPixels[y * width + x];
                if (color.a > 0)
                {
                    if (CalculateAllTouMing(x, y, width, height, newPixels))
                    {
                        color.a = 0.8f;
                        newPixels[y * width + x] = color;
                    }
                }
            }
        }
        previewTexture.SetPixels(newPixels);
        previewTexture.Apply();
        return previewTexture;
    }
    public static Texture2D Copy(this Texture2D texture)
    {
        texture.SetTextureReadable();
        int width = texture.width;
        int height = texture.height;
        Texture2D angle = new Texture2D(width , height);
        angle.SetPixels(texture.GetPixels());
        angle.Apply();
        return angle;
    }
    public static Texture2D AddAngle(this Texture2D texture,int size = 2)
    {
        int width = texture.width + size*2;
        int height = texture.height + size*2;
        Texture2D angle = new Texture2D(width, height);
        texture.SetTextureReadable();
        var color = texture.GetPixels();
        var newColor = angle.GetPixels();
        for (var x =0;x < width;++x)
        {
            for(var y = 0;y < height;++y)
            {
                if (x < size|| y < size||x >= width-size || y >= height -size)
                {
                    newColor[x + y * width] = Color.clear;
                }
                else
                {
                    newColor[x + y * width] = color[x - size + (y - size) * (width-size*2)];
                }
            }
        }
        angle.SetPixels(newColor);
        angle.Apply();
        return angle;
    }
    #region 过渡融合
    public static Texture2D ApplyColorFadeEffect(this Texture2D sourceTexture, int fadeLength, AnimationCurve curve = null)
    {
        int width = sourceTexture.width;
        int height = sourceTexture.height;
        var previewTexture = new Texture2D(width, height);
        sourceTexture.SetTextureReadable();
        Color[] originalPixels = sourceTexture.GetPixels();
        Color[] newPixels = sourceTexture.GetPixels();

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                int pixelIndex = y * width + x;
                Color originalColor = originalPixels[pixelIndex];
                float originalAlpha = originalColor.a;
                if (originalAlpha == 0)
                {
                    if (CalculateTransparentFadeAmount(x, y, width, height, originalPixels))
                    {
                        newPixels = UpdatePixel(sourceTexture,x, y, newPixels, fadeLength);
                    }
                }
                else
                {
                    if (CalculateOpaqueFadeAmount(x, y, width, height, originalPixels))
                    {
                        newPixels = UpdatePixel(sourceTexture,x, y, newPixels, fadeLength);
                    }
                }
            }
        }
        previewTexture.SetPixels(newPixels);
        previewTexture.Apply();
        return previewTexture;
    }
    private static Color[] UpdatePixel(Texture2D sourceTexture, int x, int y, Color[] pixels,int fadeLength)
    {
        int width = sourceTexture.width;
        int height = sourceTexture.height;
        var idx = 0;
        var max = fadeLength * fadeLength * 1f * 0.5f;
        for (int i = -fadeLength; i < fadeLength; i++)
        {
            for (int j = -fadeLength; j < fadeLength; j++)
            {
                int nx = x + i;
                int ny = y + j;
                if (nx >= 0 && nx < width && ny >= 0 && ny < height)
                {
                    idx = ny * width + nx;
                    if (pixels[idx].a > 0)
                    {
                        var color = pixels[idx];
                        var len = i * i + j * j * 1f;
                        var num = len / max;
                        if (color.a > num)
                            color.a = num;
                        pixels[idx] = color;
                    }
                }
            }
        }
        return pixels;
    }
    //计算透明度像素点
    private static bool CalculateTransparentFadeAmount(int x, int y, int width, int height, Color[] pixels)
    {
        bool foundOpaqueNeighbor = false;
        for (int dx = -1; dx <= 1; dx++)
        {
            for (int dy = -1; dy <= 1; dy++)
            {
                if (dx == 0 && dy == 0) continue;

                int nx = x + dx;
                int ny = y + dy;
                if (nx >= 0 && nx < width && ny >= 0 && ny < height)
                {
                    if (pixels[ny * width + nx].a > 0)
                    {
                        return true;
                    }

                }
            }
            if (foundOpaqueNeighbor)
                break;
        }
        return foundOpaqueNeighbor;
    }

    private static bool CalculateOpaqueFadeAmount(int x, int y, int width, int height, Color[] pixels)
    {
        bool foundTransparentNeighbor = false;
        if ((x == 0 || x == (width - 1)) || (y == 0 || y == (height - 1)))
        {
            if (pixels[y * width + x].a ==0)
            {
                return true;
            }
        }
        return foundTransparentNeighbor;
    }
    private static bool CalculateOpaque(int x, int y, int width, int height, Color[] pixels)
    {
        for (int dx = -1; dx <= 1; dx++)
        {
            for (int dy = -1; dy <= 1; dy++)
            {
                if (dx == 0 && dy == 0) continue;

                int nx = x + dx;
                int ny = y + dy;
                if (nx >= 0 && nx < width && ny >= 0 && ny < height)
                {
                    if (pixels[ny * width + nx].a == 0)
                    {
                        return true;
                    }

                }
            }
        }
        return false;
    }
    private static bool CalculateAllTouMing(int x, int y, int width, int height, Color[] pixels)
    {
        var num = 0;
        var angle = 0;
        for (int dx = -1; dx <= 1; dx++)
        {
            for (int dy = -1; dy <= 1; dy++)
            {
                if (dx == 0 && dy == 0) continue;

                int nx = x + dx;
                int ny = y + dy;
                if (nx >= 0 && nx < width && ny >= 0 && ny < height)
                {
                    num++;
                    if (pixels[ny * width + nx].a == 0)
                    {
                        return false;
                    }
                    else if (pixels[ny * width+nx].a < 0.5f)
                    {
                        angle++;
                    }
                }
            }
        }
        return angle > 0;
    }
    #endregion
}
