using UnityEngine;
using UnityEngine.U2D;
using System.Collections.Generic;
using UnityEditor;

public class SpriteScaler : MonoBehaviour
{
    /// <summary>
    /// 生成指定大小的 Sprite 图片，支持 9 切片缩放。
    /// </summary>
    /// <param name="texture">原始纹理</param>
    /// <param name="newWidth">新图片的宽度</param>
    /// <param name="newHeight">新图片的高度</param>
    /// <param name="isBL">是否使用简单缩放（不保留宽高比）</param>
    /// <returns>生成的 Sprite 图片</returns>
    public static Sprite GenerateScaledSprite(Texture2D texture, float newWidth, float newHeight, bool isBL)
    {
        if (texture == null)
        {
            Debug.LogError("Error: Original Sprite is null.");
            return null;
        }
        var originalSprite = AssetDatabase.LoadAssetAtPath<Sprite>(AssetDatabase.GetAssetPath(texture));
        // 检查是否需要使用 9 切片
        if (originalSprite == null || originalSprite.border == Vector4.zero || isBL == false)
        {
            if (originalSprite == null)
            {
                originalSprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(texture.width * 0.5f, texture.height * 0.5f), 100);
            }
            return GenerateSimpleScaledSprite(originalSprite, newWidth, newHeight, isBL);
        }

        // 获取原始 Sprite 信息
        Texture2D originalTexture = originalSprite.texture;
        Rect originalRect = originalSprite.rect;
        Vector4 border = originalSprite.border;
        float pixelsPerUnit = originalSprite.pixelsPerUnit;


        int originalWidth = originalTexture.width;
        int originalHeight = originalTexture.height;

        float uvWidth = originalRect.width / originalWidth;
        float uvHeight = originalRect.height / originalHeight;
        float uvX = originalRect.x / originalWidth;
        float uvY = originalRect.y / originalHeight;


        // 计算 9 切片边框大小
        int left = Mathf.RoundToInt(border.x);
        int right = Mathf.RoundToInt(border.z);
        int top = Mathf.RoundToInt(border.w);
        int bottom = Mathf.RoundToInt(border.y);

        // 检查原始图片是否需要简单缩放
        if (originalWidth < left + right)
        {
            return GenerateSimpleScaledSprite(originalSprite, newWidth, newHeight, isBL);
        }
        if (originalHeight < top + bottom)
        {
            return GenerateSimpleScaledSprite(originalSprite, newWidth, newHeight, isBL);
        }

        // 调整 UV
        float uvLeft = uvX + (left / (float)originalWidth) * uvWidth;
        float uvRight = uvX + (1 - (right / (float)originalWidth)) * uvWidth;
        float uvTop = uvY + (1 - (top / (float)originalHeight)) * uvHeight;
        float uvBottom = uvY + (bottom / (float)originalHeight) * uvHeight;


        // 创建新纹理
        Texture2D newTexture = new Texture2D(Mathf.RoundToInt(newWidth), Mathf.RoundToInt(newHeight), originalTexture.format, false);
        newTexture.filterMode = originalTexture.filterMode;

        // 计算中心区域大小
        float centerWidth = newWidth - left - right;
        float centerHeight = newHeight - top - bottom;
        if (centerWidth < 0)
            centerWidth = 0;
        if (centerHeight < 0)
            centerHeight = 0;


        // 计算 UV 尺寸
        float uvWidthLeft = (left / (float)originalWidth) * uvWidth;
        float uvWidthRight = (right / (float)originalWidth) * uvWidth;
        float uvHeightTop = (top / (float)originalHeight) * uvHeight;
        float uvHeightBottom = (bottom / (float)originalHeight) * uvHeight;



        // 绘制 9 切片
        // Top Left
        DrawTexture(newTexture, originalTexture, 0, newHeight - top, left, top,
            uvX, uvTop, uvWidthLeft, uvHeightTop,
            uvWidth, uvHeight, pixelsPerUnit);

        // Top Center
        DrawTexture(newTexture, originalTexture, left, newHeight - top, centerWidth, top,
            uvLeft, uvTop, uvRight - uvLeft, uvHeightTop,
            uvWidth, uvHeight, pixelsPerUnit);

        // Top Right
        DrawTexture(newTexture, originalTexture, newWidth - right, newHeight - top, right, top,
            uvRight, uvTop, 1 - uvRight - uvX, uvHeightTop,
            uvWidth, uvHeight, pixelsPerUnit);

        // Middle Left
        DrawTexture(newTexture, originalTexture, 0, bottom, left, centerHeight,
            uvX, uvBottom, uvWidthLeft, uvTop - uvBottom,
            uvWidth, uvHeight, pixelsPerUnit);

        // Middle Center
        DrawTexture(newTexture, originalTexture, left, bottom, centerWidth, centerHeight,
            uvLeft, uvBottom, uvRight - uvLeft, uvTop - uvBottom,
             uvWidth, uvHeight, pixelsPerUnit);

        // Middle Right
        DrawTexture(newTexture, originalTexture, newWidth - right, bottom, right, centerHeight,
            uvRight, uvBottom, 1 - uvRight - uvX, uvTop - uvBottom,
             uvWidth, uvHeight, pixelsPerUnit);

        // Bottom Left
        DrawTexture(newTexture, originalTexture, 0, 0, left, bottom,
            uvX, uvY, uvWidthLeft, uvHeightBottom,
            uvWidth, uvHeight, pixelsPerUnit);

        // Bottom Center
        DrawTexture(newTexture, originalTexture, left, 0, centerWidth, bottom,
           uvLeft, uvY, uvRight - uvLeft, uvHeightBottom,
            uvWidth, uvHeight, pixelsPerUnit);

        // Bottom Right
        DrawTexture(newTexture, originalTexture, newWidth - right, 0, right, bottom,
           uvRight, uvY, 1 - uvRight - uvX, uvHeightBottom,
            uvWidth, uvHeight, pixelsPerUnit);

        newTexture.Apply();

        // 创建新的 Sprite
        return Sprite.Create(newTexture, new Rect(0, 0, newWidth, newHeight), originalSprite.pivot, pixelsPerUnit);
    }

    /// <summary>
    /// 生成简单缩放的 Sprite 图片，支持是否保留宽高比的缩放方式。
    /// </summary>
    /// <param name="originalSprite">原始 Sprite</param>
    /// <param name="newWidth">新图片的宽度</param>
    /// <param name="newHeight">新图片的高度</param>
    /// <param name="isBL">是否使用简单缩放（不保留宽高比）</param>
    /// <returns>生成的 Sprite 图片</returns>
    public static Sprite GenerateSimpleScaledSprite(Sprite originalSprite, float newWidth, float newHeight, bool isBL)
    {
        if (originalSprite == null)
        {
            Debug.LogError("Error: Original Sprite is null.");
            return null;
        }

        Texture2D originalTexture = originalSprite.texture;
        Rect originalRect = originalSprite.rect;
        float pixelsPerUnit = originalSprite.pixelsPerUnit;

        // 计算宽高比
        float originalAspect = originalRect.width / originalRect.height;
        float newAspect = newWidth / newHeight;

        Texture2D newTexture = new Texture2D(Mathf.RoundToInt(newWidth), Mathf.RoundToInt(newHeight), originalTexture.format, false);
        newTexture.filterMode = originalTexture.filterMode;

        Color[] originalPixels = originalTexture.GetPixels((int)originalRect.x, (int)originalRect.y, (int)originalRect.width, (int)originalRect.height);

        if (isBL == false)
        {
            // 保留宽高比的双线性缩放
            // 确定适合新尺寸的缩放后原始 Sprite 的大小
            float scaledWidth, scaledHeight;
            if (originalAspect > newAspect) // 原始图片更宽，按宽度适配
            {
                scaledWidth = newWidth;
                scaledHeight = newWidth / originalAspect;
            }
            else // 原始图片更高，按高度适配
            {
                scaledHeight = newHeight;
                scaledWidth = newHeight * originalAspect;
            }

            Texture2D tmpTexture = new Texture2D((int)originalRect.width, (int)originalRect.height, originalTexture.format, false);
            tmpTexture.SetPixels(originalPixels);
            tmpTexture.Apply();

            // 缩放临时纹理
            BilinearScale(tmpTexture, Mathf.RoundToInt(scaledWidth), Mathf.RoundToInt(scaledHeight));

            Color[] scaledPixels = tmpTexture.GetPixels();

            // 创建一个新的透明像素数组用于整个新纹理
            Color[] finalPixels = new Color[newTexture.width * newTexture.height];
            for (int i = 0; i < finalPixels.Length; i++)
            {
                finalPixels[i] = Color.clear;
            }

            // 计算偏移量以居中缩放后的图像
            int xOffset = Mathf.RoundToInt((newWidth - scaledWidth) / 2f);
            int yOffset = Mathf.RoundToInt((newHeight - scaledHeight) / 2f);

            // 将缩放后的像素复制到新纹理的中心
            for (int y = 0; y < Mathf.RoundToInt(scaledHeight); y++)
            {
                for (int x = 0; x < Mathf.RoundToInt(scaledWidth); x++)
                {
                    int scaledX = x;
                    int scaledY = y;
                    int finalX = x + xOffset;
                    int finalY = y + yOffset;

                    if (scaledX >= 0 && scaledX < scaledWidth && scaledY >= 0 && scaledY < scaledHeight &&
                        finalX >= 0 && finalX < newWidth && finalY >= 0 && finalX < newWidth && finalY < newHeight)
                    {
                        finalPixels[finalX + finalY * newTexture.width] = scaledPixels[scaledX + scaledY * Mathf.RoundToInt(scaledWidth)];
                    }
                }
            }

            newTexture.SetPixels(finalPixels);
            newTexture.Apply();
        }
        else
        {
            // 简单直接缩放（不保留宽高比）
            Color[] scaledPixels = SimpleScale(originalPixels, (int)originalRect.width, (int)originalRect.height, Mathf.RoundToInt(newWidth), Mathf.RoundToInt(newHeight));

            newTexture.SetPixels(scaledPixels);
            newTexture.Apply();
        }
        return Sprite.Create(newTexture, new Rect(0, 0, newWidth, newHeight), originalSprite.pivot, pixelsPerUnit);
    }

    /// <summary>
    /// 简单缩放（不保留宽高比），返回新的像素数据。
    /// </summary>
    /// <param name="originalColors">原始像素颜色数组</param>
    /// <param name="originalWidth">原始图片的宽度</param>
    /// <param name="originalHeight">原始图片的高度</param>
    /// <param name="newWidth">新图片的宽度</param>
    /// <param name="newHeight">新图片的高度</param>
    /// <returns>缩放后的像素颜色数组</returns>
    public static Color[] SimpleScale(Color[] originalColors, int originalWidth, int originalHeight, int newWidth, int newHeight)
    {
        Color[] scaledColors = new Color[newWidth * newHeight];

        float widthRatio = (float)originalWidth / newWidth;
        float heightRatio = (float)originalHeight / newHeight;

        for (int y = 0; y < newHeight; y++)
        {
            for (int x = 0; x < newWidth; x++)
            {
                int originalX = Mathf.FloorToInt(x * widthRatio);
                int originalY = Mathf.FloorToInt(y * heightRatio);

                scaledColors[x + y * newWidth] = originalColors[originalX + originalY * originalWidth];
            }
        }
        return scaledColors;
    }

    /// <summary>
    /// 使用双线性插值算法对纹理进行缩放。
    /// </summary>
    /// <param name="tex">原始纹理</param>
    /// <param name="newWidth">新纹理的宽度</param>
    /// <param name="newHeight">新纹理的高度</param>
    public static void BilinearScale(Texture2D tex, int newWidth, int newHeight)
    {
        Texture2D scaledTex = new Texture2D(newWidth, newHeight, tex.format, false);
        scaledTex.filterMode = FilterMode.Bilinear;

        float invW = 1.0f / (newWidth - 1);
        float invH = 1.0f / (newHeight - 1);

        Color[] scaledPixels = new Color[newWidth * newHeight];

        for (int y = 0; y < newHeight; y++)
        {
            for (int x = 0; x < newWidth; x++)
            {
                float fx = x * invW;
                float fy = y * invH;

                float u = fx * (tex.width - 1);
                float v = fy * (tex.height - 1);

                int x0 = Mathf.FloorToInt(u);
                int y0 = Mathf.FloorToInt(v);
                int x1 = Mathf.CeilToInt(u);
                int y1 = Mathf.CeilToInt(v);

                float u_ratio = u - x0;
                float v_ratio = v - y0;
                float u_opposite = 1 - u_ratio;
                float v_opposite = 1 - v_ratio;

                Color c00 = tex.GetPixel(x0, y0);
                Color c01 = tex.GetPixel(x0, y1);
                Color c10 = tex.GetPixel(x1, y0);
                Color c11 = tex.GetPixel(x1, y1);

                Color color = (c00 * u_opposite + c10 * u_ratio) * v_opposite + (c01 * u_opposite + c11 * u_ratio) * v_ratio;
                scaledPixels[x + y * newWidth] = color;
            }
        }

        scaledTex.SetPixels(scaledPixels);
        scaledTex.Apply();

        tex.Reinitialize(newWidth, newHeight);
        tex.SetPixels(scaledPixels);
        tex.Apply();
    }

    /// <summary>
    /// 将源纹理的指定区域绘制到目标纹理的指定位置，并进行缩放。
    /// </summary>
    /// <param name="targetTexture">目标纹理</param>
    /// <param name="sourceTexture">源纹理</param>
    /// <param name="x">目标纹理的 X 坐标</param>
    /// <param name="y">目标纹理的 Y 坐标</param>
    /// <param name="width">绘制区域的宽度</param>
    /// <param name="height">绘制区域的高度</param>
    /// <param name="sourceUVX">源纹理的 UV X 坐标</param>
    /// <param name="sourceUVY">源纹理的 UV Y 坐标</param>
    /// <param name="sourceUVWidth">源纹理的 UV 宽度</param>
    /// <param name="sourceUVHeight">源纹理的 UV 高度</param>
    /// <param name="uvWidth">源纹理的 UV 总宽度</param>
    /// <param name="uvHeight">源纹理的 UV 总高度</param>
    /// <param name="pixelsPerUnit">每单位的像素数</param>
    private static void DrawTexture(Texture2D targetTexture, Texture2D sourceTexture,
             float x, float y, float width, float height,
             float sourceUVX, float sourceUVY, float sourceUVWidth, float sourceUVHeight,
              float uvWidth, float uvHeight, float pixelsPerUnit)
    {
        if (width <= 0 || height <= 0)
        {
            return;
        }

        Color[] pixels = sourceTexture.GetPixels(
       Mathf.RoundToInt(sourceUVX * sourceTexture.width),
       Mathf.RoundToInt(sourceUVY * sourceTexture.height),
       Mathf.RoundToInt(sourceUVWidth * sourceTexture.width),
       Mathf.RoundToInt(sourceUVHeight * sourceTexture.height));

        Texture2D tmpTexture = new Texture2D(Mathf.RoundToInt(sourceUVWidth * sourceTexture.width), Mathf.RoundToInt(sourceUVHeight * sourceTexture.height), sourceTexture.format, false);
        tmpTexture.SetPixels(pixels);
        tmpTexture.Apply();

        Color[] newPixels = tmpTexture.GetPixels();
        if (newPixels.Length == 0) return;

        // 缩放像素
        Color[] scaledPixels = new Color[Mathf.RoundToInt(width) * Mathf.RoundToInt(height)];
        float widthScaleFactor = (float)tmpTexture.width / width;
        float heightScaleFactor = (float)tmpTexture.height / height;


        for (int yy = 0; yy < Mathf.RoundToInt(height); yy++)
        {
            for (int xx = 0; xx < Mathf.RoundToInt(width); xx++)
            {
                int originalX = Mathf.FloorToInt(xx * widthScaleFactor);
                int originalY = Mathf.FloorToInt(yy * heightScaleFactor);

                if (originalX < 0) originalX = 0;
                if (originalY < 0) originalY = 0;
                if (originalX >= tmpTexture.width) originalX = tmpTexture.width - 1;
                if (originalY >= tmpTexture.height) originalY = tmpTexture.height - 1;
                scaledPixels[xx + yy * Mathf.RoundToInt(width)] = tmpTexture.GetPixel(originalX, originalY);
            }
        }

        targetTexture.SetPixels(Mathf.RoundToInt(x), Mathf.RoundToInt(y), Mathf.RoundToInt(width), Mathf.RoundToInt(height), scaledPixels);
    }
}