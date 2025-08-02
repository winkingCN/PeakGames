using System.Collections.Generic;
using System.IO;
using System.Linq;

using UnityEditor;

using UnityEditorInternal;

using UnityEngine;
//using Utils;
public enum Anchor
{
    None,
    LowerLeft,
    LowerRight,
    UpperRight,
    UpperLeft
}
public class ImageOverlayEditorWindow : EditorWindow
{
    [MenuItem("Window/图片编辑器")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(ImageOverlayEditorWindow));
    }
    private void OnEnable()
    {
        InitRalu();
        InitSpriteToImage();
        InitTextureToSprite();
        InitSources();
        InitAlters();
    }
    private Vector2 allPoint;
    void OnGUI()
    {
        allPoint = EditorGUILayout.BeginScrollView(allPoint);
        RaleToggle = EditorGUILayout.Foldout(RaleToggle, "贴图规则组合");
        if (RaleToggle)
        {
            RaluGUI();
        }
        toTextToggle = EditorGUILayout.Foldout(toTextToggle, "精灵转换图片");
        if (toTextToggle)
        {
            ToSpriteGUI();
        }
        toTextureToSprite = EditorGUILayout.Foldout(toTextureToSprite, "图片转换精灵");
        if (toTextureToSprite)
        {
            TextureToSpriteGUI();
        }
        toSource = EditorGUILayout.Foldout(toSource, "缩放图片");
        if (toSource)
        {
            SourceGUI();
        }
        IaAlters = EditorGUILayout.Foldout(IaAlters, "图集打包");
        if (IaAlters)
        {
            point = EditorGUILayout.BeginScrollView(point);
            IsAddAngleTime = GUILayout.Toggle(IsAddAngleTime, "AddAngle");
            altersList.DoLayoutList();
            EditorGUILayout.EndScrollView();
            if (GUILayout.Button("选中添加到List"))
            {
                foreach (Object obj in Selection.objects)
                {
                    Texture2D sprite = obj as Texture2D;
                    if (sprite != null && allTextures.Contains(sprite) == false)
                    {
                        if(!IsAddAngleTime)
                        {
                            var name = sprite.name.ToLower();
                            if (name.StartsWith("ul")|| name.StartsWith("ur") || name.StartsWith("dl") || name.StartsWith("dr") || name.StartsWith("1_") 
                                || name.StartsWith("2_") || name.StartsWith("3_") || name.StartsWith("4_") || name.StartsWith("13_") || name.StartsWith("14_"))
                            {
                            }
                            else
                            {
                                allTextures.Add(sprite);
                            }
                        }
                        else
                        {
                            allTextures.Add(sprite);
                        }
                    }
                }
            }
            if (GUILayout.Button("Build Atlas"))
            {
                BuildSpriteAtlas();
            }

        }

        if (GUILayout.Button("清理数据"))
        {
            allTextures.Clear();
            sprites.Clear();
            mapLists.Clear();
            sourceTextures.Clear();
            for (int i = 0; i < imageListsB.Length; i++)
            {
                imageListsA[i].Clear();
                imageListsB[i].Clear();
            }
        }
        EditorGUILayout.EndScrollView();
    }

    #region 
    private bool IaAlters = false;
    private ReorderableList altersList;
    private bool IsAddAngleTime = false;
    private void InitAlters()
    {
        altersList = new ReorderableList(allTextures, typeof(Texture2D), true, true, true, true);
        altersList.drawHeaderCallback = DrawHeader;
        altersList.drawElementCallback = DrawElement;
        altersList.onAddCallback = OnAddElement;
        altersList.onRemoveCallback = OnRemoveElement;
        foreach (Object obj in Selection.objects)
        {
            var texture = obj as Texture2D;
            if (texture != null && allTextures.Contains(texture) == false)
            {
                allTextures.Add(texture);
            }
        }
    }
    public void BuildSpriteAtlas()
    {
        if (allTextures.Count > 0)
        {
            // Calculate the size of the atlas
            int width = 2048;
            int height = 2048;
            int maxTexturesPerRow = width / allTextures[0].width;
            Debug.Log(maxTexturesPerRow);
            // Pack textures into an atlas
            var atlasTexture = new Texture2D(width, height, TextureFormat.RGBA32, false);
          
            Rect[] rects = atlasTexture.PackTextures(allTextures.ToArray(), 0, 512);
            // Save the atlas texture
            byte[] bytes = atlasTexture.EncodeToPNG();
            string atlasPath = Path.GetDirectoryName(AssetDatabase.GetAssetPath(allTextures[0]));
            atlasPath = atlasPath + "/" + Path.GetFileName(atlasPath) + ".png";
            if (File.Exists(atlasPath + ".meta"))
            {
                File.Delete(atlasPath + ".meta");
            }
            File.WriteAllBytes(atlasPath, bytes);
            AssetDatabase.Refresh();
            // Create sprites and save them
            var spriteDatas = new SpriteMetaData[allTextures.Count];
            TextureImporter textureImporter = AssetImporter.GetAtPath(atlasPath) as TextureImporter;
            textureImporter.textureType = TextureImporterType.Sprite;
            textureImporter.spriteImportMode = SpriteImportMode.Multiple;
            textureImporter.filterMode = FilterMode.Point;
            width = atlasTexture.width;
            height = atlasTexture.height;
            Debug.Log(width + "x" + height);
            for (int i = 0; i < allTextures.Count; i++)
            {
                Rect packedRect = rects[i];
                spriteDatas[i] = new SpriteMetaData()
                {
                    name = allTextures[i].name,
                    rect = new Rect(packedRect.x * width, packedRect.y * height, packedRect.width * width, packedRect.height * height),
                    pivot = new Vector2(0.5f, 0.5f)
                };
            }
            textureImporter.spritesheet = spriteDatas;
            textureImporter.SaveAndReimport();
            AssetDatabase.ImportAsset(atlasPath, ImportAssetOptions.ForceUpdate | ImportAssetOptions.ForceSynchronousImport);

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            Debug.Log("Sprite Atlas created: " + atlasPath);
        }
        else
        {
            Debug.LogError("No textures added to the atlas.");
        }
    }
    private void DrawHeader(Rect rect)
    {
        EditorGUI.LabelField(rect, "Textures");
    }
    private void DrawElement(Rect rect, int index, bool isActive, bool isFocused)
    {
        allTextures[index] = EditorGUI.ObjectField(new Rect(rect.x, rect.y, rect.width, EditorGUIUtility.singleLineHeight), GUIContent.none, allTextures[index], typeof(Texture2D), false) as Texture2D;
    }
    private void OnAddElement(ReorderableList list)
    {
        allTextures.Add(null);
    }
    private void OnRemoveElement(ReorderableList list)
    {
        allTextures.RemoveAt(list.index);
    }
    #endregion
    #region 放大贴图
    private bool toSource = false;
    private List<Texture2D> sourceTextures = new List<Texture2D>();
    private ReorderableList sourceList;
    private int newWidth = 30;
    private int newHeight = 30;
    private int angleNum = 0;
    private Anchor selectedAnchors = Anchor.None;
    private void InitSources()
    {
        sourceList = new ReorderableList(sourceTextures, typeof(Texture2D));
        sourceTextures.Clear();
        foreach (Object obj in Selection.objects)
        {
            Texture2D sprite = obj as Texture2D;
            if (sprite != null)
            {
                sourceTextures.Add(sprite);
            }
        }
        sourceList.drawElementCallback = (rect, index, isActive, isFocused) =>
        {
            var element = sourceList.list[index];
            rect.x += 20;
            rect.width -= 20;
            sourceTextures[index] = (Texture2D)EditorGUI.ObjectField(new Rect(rect.x, rect.y, rect.width, EditorGUIUtility.singleLineHeight), sourceTextures[index], typeof(Texture2D), false);
        };
    }
    private void SourceGUI()
    {
        GUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("New Width:", GUILayout.Width(80));
        newWidth = EditorGUILayout.IntField(newWidth);
        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("New Height:", GUILayout.Width(80));
        newHeight = EditorGUILayout.IntField(newHeight);
        GUILayout.EndHorizontal();
        EditorGUILayout.LabelField("透明度宽度:", GUILayout.Width(80));
        angleNum = EditorGUILayout.IntField(angleNum);

        sourceList.elementHeight = EditorGUIUtility.singleLineHeight;
        sourceList.footerHeight = 20;

        sourceList.DoLayoutList();
        if (GUILayout.Button("选中添加到List"))
        {
            foreach (Object obj in Selection.objects)
            {
                Texture2D sprite = obj as Texture2D;
                if (sprite != null && sourceTextures.Contains(sprite) == false)
                {
                    sourceTextures.Add(sprite);
                }
            }
        }
        EditorGUILayout.BeginHorizontal();
        // Use EnumPopup for selecting the anchor
        selectedAnchors = (Anchor)EditorGUILayout.EnumPopup("Anchor", selectedAnchors);
        EditorGUILayout.EndHorizontal();
        if (GUILayout.Button("图片扩展透明"))
        {
            ResizeImages();
        }

        if(GUILayout.Button("双线性缩放图片"))
        {
            foreach (var texture in sourceTextures)
            {
                BiggerTex(texture,newWidth,newHeight);
            }
            AssetDatabase.Refresh();
        }
        if(GUILayout.Button("邻近像素缩放"))
        {
            foreach (var texture in sourceTextures)
            {
                ScaleTexture(texture, newWidth, newHeight);
            }
            AssetDatabase.Refresh();
        }
    }
    Texture2D ScaleTexture(Texture2D source, int targetWidth, int targetHeight)
    {
        if(source.isReadable == false)
        {
            var path = AssetDatabase.GetAssetPath(source);
            TextureImporter textureImporter = AssetImporter.GetAtPath(path) as TextureImporter;
            textureImporter.textureType = TextureImporterType.Sprite;
            textureImporter.spriteImportMode = SpriteImportMode.Single;
            textureImporter.filterMode = FilterMode.Point;

            textureImporter.spritePixelsPerUnit = 8;
            textureImporter.isReadable = true;
            textureImporter.SaveAndReimport();
            AssetDatabase.ImportAsset(path, ImportAssetOptions.ForceUpdate | ImportAssetOptions.ForceSynchronousImport);
            AssetDatabase.Refresh();
        }
       

        Texture2D result = new Texture2D(targetWidth, targetHeight, TextureFormat.ARGB32, false);
        Color[] rpixels = result.GetPixels(0);
        float incX = ((float)source.width) / targetWidth;
        float incY = ((float)source.height) / targetHeight;

        for (int px = 0; px < targetWidth; ++px)
        {
            for (int py = 0; py < targetHeight; ++py)
            {
                rpixels[py * targetWidth + px] = NearestNeighborInterpolation(source, px * incX, py * incY);
            }
        }

        result.SetPixels(rpixels);
        result.Apply();
        File.WriteAllBytes(AssetDatabase.GetAssetPath(source), result.EncodeToPNG());
        return result;
    }

    Color NearestNeighborInterpolation(Texture2D texture, float x, float y)
    {
        int x1 = Mathf.RoundToInt(x);
        int y1 = Mathf.RoundToInt(y);

        if (x1 >= texture.width)
            x1 = texture.width - 1;
        if (y1 >= texture.height)
            y1 = texture.height - 1;

        return texture.GetPixel(x1, y1);
    }
    public void BiggerTex(Texture2D source, int width,int height)
    {
        Texture2D newtex = new Texture2D(width, height);
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                float newx = (i + 0.5f) * ((float)source.width / (float)width);
                float newy = (j + 0.5f) * ((float)source.height / (float)height);

                float tx = (newx - ((int)newx + 0.5f)) / 1;
                float ty = (newy - ((int)newy + 0.5f)) / 1;

                float[] wx = new float[4]
                {
                    0.5f * (-tx + 2 * tx*tx + -tx*tx*tx),
                    0.5f*  (2 - 5 * tx*tx + 3 * tx*tx*tx),
                    0.5f  *(tx+ 4 *tx*tx - 3*tx*tx*tx),
                    0.5f * (-tx*tx + tx*tx*tx)
                };
                float[] wy = new float[4]
                {
                    0.5f * (-ty + 2 * ty*ty + -ty*ty*ty),
                    0.5f*  (2 - 5 * ty*ty + 3 * ty*ty*ty),
                    0.5f  *(ty+ 4 *ty*ty - 3*ty*ty*ty),
                    0.5f * (-ty*ty + ty*ty*ty)
                };

                Color b_1 = source.GetPixel((int)newx - 1, (int)newy - 1) * wx[0] +
                                    source.GetPixel((int)newx, (int)newy - 1) * wx[1] +
                                    source.GetPixel((int)newx + 1, (int)newy - 1) * wx[2] +
                                    source.GetPixel((int)newx + 2, (int)newy - 1) * wx[3];

                Color b_0 = source.GetPixel((int)newx - 1, (int)newy) * wx[0] +
                                    source.GetPixel((int)newx, (int)newy) * wx[1] +
                                    source.GetPixel((int)newx + 1, (int)newy) * wx[2] +
                                    source.GetPixel((int)newx + 2, (int)newy) * wx[3];

                Color b_11 = source.GetPixel((int)newx - 1, (int)newy + 1) * wx[0] +
                                    source.GetPixel((int)newx, (int)newy + 1) * wx[1] +
                                    source.GetPixel((int)newx + 1, (int)newy + 1) * wx[2] +
                                    source.GetPixel((int)newx + 2, (int)newy + 1) * wx[3];

                Color b_2 = source.GetPixel((int)newx - 1, (int)newy + 2) * wx[0] +
                                    source.GetPixel((int)newx, (int)newy + 2) * wx[1] +
                                    source.GetPixel((int)newx + 1, (int)newy + 2) * wx[2] +
                                    source.GetPixel((int)newx + 2, (int)newy + 2) * wx[3];

                Color c = b_1 * wy[0] + b_0 * wy[1] + b_11 * wy[2] + b_2 * wy[3];

                newtex.SetPixel(i, j, c);
            }
        }

        File.WriteAllBytes(AssetDatabase.GetAssetPath(source), newtex.EncodeToPNG());
    }
    void ResizeImages()
    {
        if (sourceTextures.Count == 0)
        {
            EditorUtility.DisplayDialog("Error", "Please add some textures to resize.", "OK");
            return;
        }

        foreach (var texture in sourceTextures)
        {
            if (texture == null)
            {
                continue; // Skip null textures
            }
            int width = Mathf.Max(1, newWidth);
            int height = Mathf.Max(1, newHeight);
            if (angleNum > 0)
            {
                width = texture.width + angleNum;
                height = texture.height + angleNum;
            }
           
            Texture2D newTexture = new Texture2D(width, height);

            Color[] pixels = texture.GetPixels();
            Color[] newPixels = new Color[width * height];

            // Set the background to transparent
            for (int i = 0; i < newPixels.Length; i++)
            {
                newPixels[i] = Color.clear;
            }

            int startX = 0;
            int startY = 0;

            // If no anchors are selected, default to centering the image
            if (selectedAnchors == Anchor.None)
            {
                startX = (width - texture.width) / 2;
                startY = (height - texture.height) / 2;
            }
            else
            {
                switch (selectedAnchors)
                {
                    case Anchor.UpperLeft:
                        startX = 0;
                        startY = 0;
                        break;
                    case Anchor.UpperRight:
                        startX = width - texture.width;
                        startY = 0;
                        break;
                    case Anchor.LowerLeft:
                        startX = 0;
                        startY = height - texture.height;
                        break;
                    case Anchor.LowerRight:
                        startX = width - texture.width;
                        startY = height - texture.height;
                        break;
                        // If you want to support multiple anchors, add additional logic here
                }
            }
            for (int y = 0; y < texture.height; y++)
            {
                for (int x = 0; x < texture.width; x++)
                {
                    int newX = startX + x;
                    int newY = startY + y;
                    if (newX >= 0 && newX < width && newY >= 0 && newY < height)
                    {
                        newPixels[newY * width + newX] = pixels[y * texture.width + x];
                    }
                }
            }
            newTexture.SetPixels(newPixels);
            newTexture.Apply();
            // Save the texture as an asset
            string path = AssetDatabase.GetAssetPath(texture);
            if (!string.IsNullOrEmpty(path))
            {
                byte[] bytes = newTexture.EncodeToPNG();
                System.IO.File.WriteAllBytes(path, bytes);
                AssetDatabase.Refresh();
            }
        }
    }
    #endregion
    #region 九宫处理设置贴图
    private ReorderableList textToSpriteReors;
    private bool toTextureToSprite = false;
    private int SpriteSize = 10;
    public List<Texture2D> allTextures = new List<Texture2D>();
    private void InitTextureToSprite()
    {
        foreach (Object obj in Selection.objects)
        {
            var sprite = obj as Texture2D;
            if (sprite != null && allTextures.Contains(sprite) == false)
            {
                allTextures.Add(sprite);
            }
        }
        textToSpriteReors = new ReorderableList(allTextures, typeof(Texture2D), true, true, true, true);
        textToSpriteReors.drawHeaderCallback = (Rect rect) =>
        {
            EditorGUI.LabelField(rect, "Selected Sprites");
        };
        textToSpriteReors.drawElementCallback = (Rect rect, int index, bool isActive, bool isFocused) =>
        {
            var sprite = allTextures[index];
            allTextures[index] = EditorGUI.ObjectField(new Rect(rect.x, rect.y, rect.width, EditorGUIUtility.singleLineHeight), GUIContent.none, sprite, typeof(Texture2D), false) as Texture2D;
        };
    }
    private string[] spriteNames = new string[]
    {  
        "DL",
        "Down",
        "DR",
        "Left",
        "",
        "Right",
        "UL",
        "Up",
        "UR",
    };
    Color32[] Erode(Texture2D texture)
    {
        Color32[] pixels = texture.GetPixels32();
        Color32[] tempPixels = new Color32[pixels.Length];

        // 遍历每个像素
        for (int y = 0; y < texture.height; y++)
        {
            for (int x = 0; x < texture.width; x++)
            {
                int index = y * texture.width + x;
                Color32 pixel = pixels[index];

                // 只考虑非透明的像素
                if (pixel.a > 0)
                {
                    // 检查上下左右是否有透明像素
                    bool shouldErode = false;
                    for (int offsetY = -1; offsetY <= 1; offsetY++)
                    {
                        for (int offsetX = -1; offsetX <= 1; offsetX++)
                        {
                            // 跳过当前像素和斜对角的像素
                            if (offsetX == 0 && offsetY == 0 || offsetX != 0 && offsetY != 0) continue;

                            int checkX = x + offsetX;
                            int checkY = y + offsetY;

                            // 确保不超出纹理边界
                            if (checkX >= 0 && checkX < texture.width && checkY >= 0 && checkY < texture.height)
                            {
                                int checkIndex = checkY * texture.width + checkX;
                                if (pixels[checkIndex].a == 0)
                                {
                                    shouldErode = true;
                                    break;
                                }
                            }
                        }
                        if (shouldErode) break;
                    }

                    // 如果上下左右有透明像素，则腐蚀当前像素
                    tempPixels[index] = shouldErode ? new Color32(0, 0, 0, 0) : pixel;
                }
                else
                {
                    tempPixels[index] = pixel; // 透明像素保持不变
                }
            }
        }

        return tempPixels;
    }
    Color32[] Erode(Texture2D texture, Color32 color1, Color32 color)
    {
        Color.RGBToHSV(color1, out var h, out var s, out var v);
        return Erode(texture, (int)(h *360f),color);
    }
    Color32[] Erode(Texture2D texture,int H,Color32 color)
    {
        Color32[] pixels = texture.GetPixels32();
        Color32[] tempPixels = new Color32[pixels.Length];

        // 遍历每个像素
        for (int y = 0; y < texture.height; y++)
        {
            for (int x = 0; x < texture.width; x++)
            {
                int index = y * texture.width + x;
                Color32 pixel = pixels[index];
                // 只考虑非透明的像素
                if (pixel.a > 0)
                {
                    Color.RGBToHSV(pixel,out var h, out var s, out var v);
                    // 检查上下左右是否有透明像素
                    bool shouldErode = false;
                    if (Mathf.Abs((int)(h * 360f) - H) < 2)
                    {
                        for (int offsetY = -1; offsetY <= 1; offsetY++)
                        {
                            for (int offsetX = -1; offsetX <= 1; offsetX++)
                            {
                                // 跳过当前像素和斜对角的像素

                                int checkX = x + offsetX;
                                int checkY = y + offsetY;

                                // 确保不超出纹理边界
                                if (checkX >= 0 && checkX < texture.width && checkY >= 0 && checkY < texture.height)
                                {
                                    int checkIndex = checkY * texture.width + checkX;
                                    Color.RGBToHSV(pixels[checkIndex], out var h1, out var s1, out var v1);
                                    if (Mathf.Abs((int)(h1 * 360f) - H) > 3)
                                    {
                                        shouldErode = true;
                                        break;
                                    }
                                }
                            }
                            if (shouldErode) break;
                        }

                        // 如果上下左右有透明像素，则腐蚀当前像素
                        tempPixels[index] = shouldErode ? color : pixel;
                    }
                    else
                    {
                        tempPixels[index] = pixel; // 透明像素保持不变
                    }
                   
                    // 如果上下左右有透明像素，则腐蚀当前像素
                    tempPixels[index] = shouldErode ? color : pixel;
                }
                else
                {
                    tempPixels[index] = pixel; // 透明像素保持不变
                }
            }
        }

        return tempPixels;
    }
    Color32[] Dilate(Texture2D texture)
    {
        Color32[] pixels = texture.GetPixels32();
        Color32[] tempPixels = new Color32[pixels.Length];

        // 遍历每个像素
        for (int y = 0; y < texture.height; y++)
        {
            for (int x = 0; x < texture.width; x++)
            {
                int index = y * texture.width + x;
                Color32 pixel = pixels[index];

                // 只考虑透明的像素
                if (pixel.a == 0)
                {
                    // 检查上下左右是否有非透明像素
                    bool shouldDilate = false;
                    for (int offsetY = -1; offsetY <= 1; offsetY++)
                    {
                        for (int offsetX = -1; offsetX <= 1; offsetX++)
                        {
                            // 跳过当前像素和斜对角的像素
                            if (offsetX == 0 && offsetY == 0 || offsetX != 0 && offsetY != 0) continue;

                            int checkX = x + offsetX;
                            int checkY = y + offsetY;

                            // 确保不超出纹理边界
                            if (checkX >= 0 && checkX < texture.width && checkY >= 0 && checkY < texture.height)
                            {
                                int checkIndex = checkY * texture.width + checkX;
                                if (pixels[checkIndex].a > 0)
                                {
                                    shouldDilate = true;
                                    break;
                                }
                            }
                        }
                        if (shouldDilate) break;
                    }

                    // 如果上下左右有非透明像素，则膨胀当前像素
                    tempPixels[index] = shouldDilate ? new Color32(255, 255, 255, 255) : pixel;
                }
                else
                {
                    tempPixels[index] = pixel; // 非透明像素保持不变
                }
            }
        }

        return tempPixels;
    }
    private Color32 color32;
    private Color32 toColor;
    private void TextureToSpriteGUI()
    {
        textToSpriteReors.DoLayoutList();
        SpriteSize = EditorGUILayout.IntField(SpriteSize);
        color32 = EditorGUILayout.ColorField(color32);
        toColor = EditorGUILayout.ColorField(toColor);
        if (GUILayout.Button("选中添加到List"))
        {
            foreach (Object obj in Selection.objects)
            {
                Texture2D sprite = obj as Texture2D;
                if (sprite != null && allTextures.Contains(sprite) == false)
                {
                    allTextures.Add(sprite);
                }
            }
        }
        if (GUILayout.Button("九宫生成"))
        {
            var spritesheet = new SpriteMetaData[9];
            for(var x = 0;x < 3;++x)
            {
                for (var y = 0; y < 3; ++y)
                {
                    spritesheet[y * 3 + x] = new SpriteMetaData
                    {
                        name = spriteNames[y * 3 + x ],
                        alignment = 9,
                        rect = new UnityEngine.Rect(x* SpriteSize, y* SpriteSize, SpriteSize, SpriteSize),
                        pivot = new Vector2(0.5f, 0.5f),
                        border = new Vector4(0, 0, 0, 0)
                    };

                }
            }
            
            for(int i = 0; i < allTextures.Count; i++)
            {
                for(int j = 0; j < spritesheet.Length; j++)
                {
                    var data1 = spritesheet[j];
                    data1.name = spriteNames[j] + "_" + i;
                    spritesheet[j] = data1;
                }
                var data = spritesheet[4];
                data.name = allTextures[i].name + "_0";
                spritesheet[4] = data;
                var texturePath = AssetDatabase.GetAssetPath(allTextures[i]);
                File.Delete(texturePath+".meta");
                AssetDatabase.Refresh();
                TextureImporter textureImporter = AssetImporter.GetAtPath(texturePath) as TextureImporter;
                textureImporter.textureType = TextureImporterType.Sprite;
                textureImporter.spriteImportMode = SpriteImportMode.Multiple;
                textureImporter.spritesheet = spritesheet;
                textureImporter.SaveAndReimport();
                AssetDatabase.ImportAsset(texturePath, ImportAssetOptions.ForceUpdate | ImportAssetOptions.ForceSynchronousImport);
            }
            AssetDatabase.Refresh();
        }
        if(GUILayout.Button("tileMap"))
        {
            var spritesheet = new SpriteMetaData[1];
            spritesheet[0] = new SpriteMetaData
            {
                alignment = 9,
                rect = new UnityEngine.Rect(0, 0, 16, 16),
                pivot = new Vector2(0.5f, 0.5f),
                border = new Vector4(0, 0, 0, 0)
            }; 
            for (int i = 0; i < allTextures.Count; i++)
            {
                
                var data = spritesheet[0];
                data.name = allTextures[i].name + "_0";
                spritesheet[0] = data;
                var texturePath = AssetDatabase.GetAssetPath(allTextures[i]);
                File.Delete(texturePath + ".meta");
                AssetDatabase.Refresh();
                TextureImporter textureImporter = AssetImporter.GetAtPath(texturePath) as TextureImporter;
                textureImporter.textureType = TextureImporterType.Sprite;
                textureImporter.spriteImportMode = SpriteImportMode.Multiple;
                textureImporter.spritesheet = spritesheet;
                textureImporter.filterMode = FilterMode.Point;
                textureImporter.spritePixelsPerUnit = 1;
                textureImporter.SaveAndReimport();
                AssetDatabase.ImportAsset(texturePath, ImportAssetOptions.ForceUpdate | ImportAssetOptions.ForceSynchronousImport);
            }
            AssetDatabase.Refresh();
        }
        if(GUILayout.Button("腐蚀"))
        {
            for(var i = 0; i < allTextures.Count;++i)
            {
                var text = allTextures[i];
                text.SetPixels32(Erode(text));
                text.Apply();
                File.WriteAllBytes(AssetDatabase.GetAssetPath(text), text.EncodeToPNG());
            }
            AssetDatabase.Refresh();
        }
        if (GUILayout.Button("腐蚀外部"))
        {
            for (var i = 0; i < allTextures.Count; ++i)
            {
                var text = allTextures[i];
                text.SetPixels32(Erode(text,color32,toColor));
                text.Apply();
                var data = text.EncodeToPNG();
                File.WriteAllBytes(AssetDatabase.GetAssetPath(text), data);
            }
            AssetDatabase.Refresh();
        }
        if (GUILayout.Button("膨胀"))
        {
            for (var i = 0; i < allTextures.Count; ++i)
            {
                var text = allTextures[i];
                text.SetPixels32(Dilate(text));
                text.Apply();
                File.WriteAllBytes(AssetDatabase.GetAssetPath(text), text.EncodeToPNG());
            }
            AssetDatabase.Refresh();
        }
    }

    #endregion

    #region  精灵转换图片
    private bool toTextToggle;
    private List<Sprite> sprites = new List<Sprite>();
    private Color colorToReplace = Color.clear;
    private ReorderableList reorderableList;
    private void InitSpriteToImage()
    {
        sprites.Clear();
        // 当窗口启用时，获取当前选择的对象
        foreach (Object obj in Selection.objects)
        {
            Sprite sprite = obj as Sprite;
            if (sprite != null)
            {
                sprites.Add(sprite);
            }
        }
        reorderableList = new ReorderableList(sprites, typeof(Sprite), true, true, true, true);
        reorderableList.drawHeaderCallback = (Rect rect) =>
        {
            EditorGUI.LabelField(rect, "Selected Sprites");
        };
        reorderableList.drawElementCallback = (Rect rect, int index, bool isActive, bool isFocused) =>
        {
            Sprite sprite = sprites[index];
            EditorGUI.ObjectField(new Rect(rect.x, rect.y, rect.width, EditorGUIUtility.singleLineHeight), GUIContent.none, sprite, typeof(Sprite), false);
        };
    }
    private void ToSpriteGUI()
    {
        reorderableList.DoLayoutList();
        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("Color to Replace:", GUILayout.Width(100));
        colorToReplace = EditorGUILayout.ColorField(colorToReplace);
        EditorGUILayout.EndHorizontal();
        if(GUILayout.Button("Add Selection Sprite"))
        {
            foreach (Object obj in Selection.objects)
            {
                Sprite sprite = obj as Sprite;
                if (sprite != null && sprites.Contains(sprite) == false)
                {
                    sprites.Add(sprite);
                }
                 if(obj as Texture2D)
                {
                    var spriteObjs = AssetDatabase.LoadAllAssetsAtPath(AssetDatabase.GetAssetPath(obj));
                    foreach(var sp in spriteObjs)
                    {
                        Sprite sps = sp as Sprite;
                        if (sps != null && sprites.Contains(sps) == false)
                        {
                            sprites.Add(sps);
                        }
                    }
                }
            }
        }
        if(GUILayout.Button("透明度添加"))
        {
            if (sprites.Count > 0)
            {
                foreach (Sprite sprite in sprites)
                {
                    if (sprite != null)
                    {
                        Texture2D texture = new Texture2D((int)sprite.rect.width, (int)sprite.rect.height, TextureFormat.RGBA32, false);
                        var pixels = sprite.texture.GetPixels((int)sprite.rect.x, (int)sprite.rect.y, (int)sprite.rect.width, (int)sprite.rect.height);
                        texture.SetPixels(pixels);
                        texture.Apply();
                        byte[] bytes = texture.EncodeToPNG();
                        File.WriteAllBytes(Path.GetDirectoryName(AssetDatabase.GetAssetPath(sprite.texture)) + "/" + sprite.name + ".png", bytes);
                        AssetDatabase.Refresh();
                        var pixel32 = AssetDatabase.LoadAssetAtPath<Texture2D>( AssetDatabase.GetAssetPath(sprite.texture)).GetPixels32();
                        for (var x = 0; x < pixel32.Length; x++)
                        {
                            if (pixel32[x].a < 10)
                            {
                                pixel32[x] = Color.clear;
                            }
                        }
                        texture.SetPixels32(pixel32);
                        texture.Apply();
                        bytes = texture.EncodeToPNG();
                        File.WriteAllBytes(Path.GetDirectoryName(AssetDatabase.GetAssetPath(sprite.texture)) + "/" + sprite.name + ".png", bytes);
                        AssetDatabase.Refresh();
                    }
                }

                AssetDatabase.Refresh();
                EditorUtility.DisplayDialog("Success", "Images converted successfully!", "OK");
            }
            else
            {
                EditorUtility.DisplayDialog("Error", "Please select at least one sprite!", "OK");
            }
        }
        if (GUILayout.Button("转换成蒙版图片"))
        {
            if (sprites.Count > 0)
            {
                foreach (Sprite sprite in sprites)
                {
                    if (sprite != null)
                    {
                        Texture2D texture = new Texture2D((int)sprite.rect.width, (int)sprite.rect.height, TextureFormat.ARGB32, false);
                        var pixels = sprite.texture.GetPixels((int)sprite.rect.x, (int)sprite.rect.y, texture.width, texture.height);
                        for (int i = 0; i < pixels.Length; i++)
                        {
                            if (pixels[i].a > 0.12f)
                            {
                                pixels[i] = Color.white;
                               
                            }
                            else
                            {
                                pixels[i] = Color.clear;
                            }
                        }
                        texture.SetPixels(pixels);
                        texture.Apply();
                        var  bytes = texture.EncodeToPNG();
                        File.WriteAllBytes(Path.GetDirectoryName(AssetDatabase.GetAssetPath(sprite.texture)) + "/" + sprite.name + ".png", bytes);
                    }
                }
                AssetDatabase.Refresh();
                EditorUtility.DisplayDialog("Success", "Images converted successfully!", "OK");
            }
            else
            {
                EditorUtility.DisplayDialog("Error", "Please select at least one sprite!", "OK");
            }
        }
        if (GUILayout.Button("Sprite To PNG"))
        {
            if (sprites.Count > 0)
            {
                var H1 = 0f;
                var H = 0f;
                var S = 0f;
                var V = 0f;
                foreach (Sprite sprite in sprites)
                {
                    if (sprite != null)
                    {
                        Debug.LogError((int)sprite.rect.width + "  " + (int)sprite.rect.height);
                        Texture2D texture = new Texture2D((int)sprite.rect.width, (int)sprite.rect.height, TextureFormat.ARGB32, false);
                        var pixels = sprite.texture.GetPixels((int)sprite.rect.x, (int)sprite.rect.y, texture.width, texture.height);
                        Debug.LogError((int)sprite.rect.x + "   " + (int)sprite.rect.y + "  " + pixels.Length + "  " + texture.width * texture.height);
                        for (int i = 0; i < pixels.Length; i++)
                        {
                            Color.RGBToHSV(colorToReplace, out H, out S, out V);
                            Color.RGBToHSV(pixels[i], out H1, out S, out V);
                            if ((int)(H1 * 360) == (int)(H * 360))
                            {
                                pixels[i].a = 0;
                            }
                        }

                        texture.SetPixels(pixels);
                        texture.Apply();

                        var bytes = texture.EncodeToPNG();
                        File.WriteAllBytes(Path.GetDirectoryName(AssetDatabase.GetAssetPath(sprite.texture)) + "/" + sprite.name + ".png", bytes);
                    }
                }

                AssetDatabase.Refresh();
                EditorUtility.DisplayDialog("Success", "Images converted successfully!", "OK");
            }
            else
            {
                EditorUtility.DisplayDialog("Error", "Please select at least one sprite!", "OK");
            }
        }
        if (GUILayout.Button("Sprite To PNG NoColor"))
        {
            if (sprites.Count > 0)
            {
                var idx = 0;
                foreach (Sprite sprite in sprites)
                {
                    if (sprite != null)
                    {
                        if(sprite.texture.isReadable == false)
                        {
                            TextureImporter importer = AssetImporter.GetAtPath(AssetDatabase.GetAssetPath(sprite.texture)) as TextureImporter;
                            if (importer != null)
                            {
                                importer.filterMode = FilterMode.Point;
                                importer.isReadable = true;
                                importer.SaveAndReimport();
                                EditorGUIUtility.PingObject(AssetDatabase.LoadAssetAtPath(AssetDatabase.GetAssetPath(sprite.texture), typeof(Texture)));
                            }
                        }
                        Texture2D texture = new Texture2D((int)sprite.rect.width, (int)sprite.rect.height, TextureFormat.ARGB32, false);
                        var pixels = sprite.texture.GetPixels((int)sprite.rect.x, (int)sprite.rect.y, texture.width, texture.height);
                        texture.SetPixels(pixels);
                        texture.Apply();

                        var bytes = texture.EncodeToPNG();
                        var name = sprite.name;
                        if (sprite.name == "")
                        {
                            name = idx.ToString();
                            idx++;
                        }
                        File.WriteAllBytes(Path.GetDirectoryName(AssetDatabase.GetAssetPath(sprite.texture)) + "/" + name + ".png", bytes);
                    }
                }

                AssetDatabase.Refresh();
                EditorUtility.DisplayDialog("Success", "Images converted successfully!", "OK");
            }
            else
            {
                EditorUtility.DisplayDialog("Error", "Please select at least one sprite!", "OK");
            }
        }
    }
   
#endregion

    #region 规则贴图处理
    List<Texture2D>[] imageListsB = new List<Texture2D>[4];
    List<Texture2D>[] imageListsA = new List<Texture2D>[4];
    private List<Texture2D> mapLists = new List<Texture2D>();
    private ReorderableList mapReorders;
    private ReorderableList[] sourceListA;
    private ReorderableList[] sourceListB;
    public Color color = Color.black;
    private Vector2 point;
    private Vector2 point1;
    private bool RaleToggle;
    private bool Bian = false;
    private bool Angle = false;
    private void RaluGUI()
    {
       
        Bian = EditorGUILayout.Foldout(Bian, "贴图规则边数据");
        if (Bian)
        {
            mapReorders.DoLayoutList();
            if (GUILayout.Button("选中添加到List"))
            {
                foreach (Object obj in Selection.objects)
                {
                    Texture2D sprite = obj as Texture2D;
                    if (sprite != null && mapLists.Contains(sprite) == false)
                    {
                        mapLists.Add(sprite);
                    }
                }
            }
            point = EditorGUILayout.BeginScrollView(point);
            for (var x = 0; x < sourceListB.Length; ++x)
            {
                sourceListB[x].elementHeight = EditorGUIUtility.singleLineHeight;
                sourceListB[x].footerHeight = 20;

                sourceListB[x].DoLayoutList();
                if (GUILayout.Button("选中添加到List"))
                {
                    foreach (Object obj in Selection.objects)
                    {
                        Texture2D sprite = obj as Texture2D;
                        if (sprite != null && imageListsB[x].Contains(sprite) == false)
                        {
                            imageListsB[x].Add(sprite);
                        }
                    }
                }
            }
            EditorGUILayout.EndScrollView();
        }
        Angle = EditorGUILayout.Foldout(Angle, "贴图规则角数据");
        if(Angle)
        {
            point1 = EditorGUILayout.BeginScrollView(point1);
            for (var x=  0;x < sourceListA.Length;++x)
            {
                sourceListA[x].elementHeight = EditorGUIUtility.singleLineHeight;
                sourceListA[x].footerHeight = 20;

                sourceListA[x].DoLayoutList();
                if (GUILayout.Button("选中添加到List"))
                {
                    foreach (Object obj in Selection.objects)
                    {
                        Texture2D sprite = obj as Texture2D;
                        if (sprite != null && imageListsA[x].Contains(sprite) == false)
                        {
                            imageListsA[x].Add(sprite);
                        }
                    }
                }
            }
            EditorGUILayout.EndScrollView();
        }
        color = EditorGUILayout.ColorField(color);
        if(GUILayout.Button("翻转"))
        {
            List<Texture2D> sprites = new List<Texture2D>();
            sprites.AddRange(imageListsB[1]);
            imageListsB[1].Clear();
            imageListsB[1].AddRange(imageListsB[0]);
            imageListsB[0].Clear();
            imageListsB[0].AddRange(sprites);
            sprites.Clear();
            sprites.AddRange(imageListsB[2]);
            imageListsB[2].Clear();
            imageListsB[2].AddRange(imageListsB[3]);
            imageListsB[3].Clear();
            imageListsB[3].AddRange(sprites);
            sprites.Clear();

        }
        if (GUILayout.Button("读取数据"))
        {
            imageListsB[0].Clear();
            imageListsB[1].Clear();
            imageListsB[2].Clear();
            imageListsB[3].Clear();
            mapLists.Clear();
            for (var x = 0; x < imageListsA.Length; x++)
            {
                imageListsA[x].Clear();
            }
            foreach (Object obj in Selection.objects)
            {
                Texture2D sprite = obj as Texture2D;
                if (sprite != null)
                {
                    if (sprite.name.ToLower().Contains("up"))
                    {
                        imageListsB[1].Add(sprite);
                    }
                    else if (sprite.name.ToLower().Contains("down"))
                    {
                        imageListsB[0].Add(sprite);
                    }
                    else if (sprite.name.ToLower().Contains("left"))
                    {
                        imageListsB[2].Add(sprite);
                    }
                    else if (sprite.name.ToLower().Contains("right"))
                    {
                        imageListsB[3].Add(sprite);
                    }
                    else if (sprite.name.ToLower().Contains("ul"))
                    {
                        imageListsA[1].Add(sprite);
                    }
                    else if (sprite.name.ToLower().Contains("ur"))
                    {
                        imageListsA[3].Add(sprite);
                    }
                    else if (sprite.name.ToLower().Contains("dl"))
                    {
                        imageListsA[0].Add(sprite);
                    }
                    else if (sprite.name.ToLower().Contains("dr"))
                    {
                        imageListsA[2].Add(sprite);
                    }
                    else if (sprite.name.Contains("_") && int.TryParse(sprite.name[0].ToString(), out int d) == false)
                    {
                        mapLists.Add(sprite);
                    }
                }
            }
        }
        if (GUILayout.Button("生成边组合"))
        {

        }
        //if (GUILayout.Button("组合Rule15"))
        //{
        //    To15Ralu();
        //}
        //if (GUILayout.Button("组合Rule48 Out"))
        //{
        //    ToRalu();
        //}
        //if(GUILayout.Button("组合Rule48"))
        //{
        //    ToRaluIn();
        //}
        //if(GUILayout.Button("组合Rule12"))
        //{
        //    ToRule12();
        //}

        //if (GUILayout.Button("上下旋转图片"))
        //{
        //    BianToDaa();
        //}
        //if (GUILayout.Button("角旋转图片"))
        //{
        //    JIaoToDaa();
        //}
    }

    public void ToRaluIn()
    {    
        RectInt[] UpRects = new RectInt[] { new RectInt(0, 6, 8, 2), new RectInt(0, 0, 8, 2), new RectInt(0, 0, 2, 8), new RectInt(6, 0, 2, 8), };
        RectInt[] BackRects = new RectInt[] { new RectInt(0, 0, 8, 2), new RectInt(0, 6, 8, 2), new RectInt(6, 0, 2, 8), new RectInt(0, 0, 2, 8), };
        var Len = 1;
        var id = 0;
        Debug.Log(imageListsB[0].Count);
        for (var y = 0;y < Len;y++)
        {
            var text = mapLists[UnityRandom.RangeInt(0, mapLists.Count)];
            for (var x = 0; x < UpRects.Length; ++x)
            {
                text = TextureToRect(text, imageListsB[x][y], BackRects[x], UpRects[x]);
            }
            DeleteAngleText(text, true, true, true, true);
            SaveTexture(text, Path.GetDirectoryName(AssetDatabase.GetAssetPath(imageListsB[0][0])) + "/" + (id) + "_" + y, false);
        }
        for (var y = 0; y < Len; y++)
        {
            var text = mapLists[UnityRandom.RangeInt(0, mapLists.Count)];
            for (var x = 0; x < UpRects.Length; ++x)
            {
                text = TextureToRect(text, imageListsB[x][y], BackRects[x], UpRects[x]);
            }
            DeleteAngleText(text, true, true, true, true);
            SaveTexture(text, Path.GetDirectoryName(AssetDatabase.GetAssetPath(imageListsB[0][0])) + "/" + (id) + "_" + y, false);
        }
        AssetDatabase.Refresh();
    }
    private void DeleteAngleText(Texture2D texture, bool ul = false, bool ur = false, bool dr = false, bool dl = false)
    {
        var datas = texture.GetPixels();
        if(ul)
        {
            datas[8 * 10] = new Color(0,0,0,0);
            datas[9 * 10+1] = new Color(0,0,0,0);
            datas[9 * 10] = new Color(0,0,0,0);
        }
        if (ur)
        {
            datas[8 * 10 + 9] = new Color(0, 0, 0, 0);
            datas[9 * 10 + 8] = new Color(0, 0, 0, 0);
            datas[9 * 10 + 9] = new Color(0, 0, 0, 0);
        }
        if (dl)
        {
            datas[0 * 10] = new Color(0, 0, 0, 0);
            datas[0 * 10 + 1] = new Color(0, 0, 0, 0);
            datas[1 * 10] = new Color(0, 0, 0, 0);
        }
        if (dr)
        {
            datas[0 * 10 + 9] = new Color(0, 0, 0, 0);
            datas[0 * 10 + 8] = new Color(0, 0, 0, 0);
            datas[1 * 10 + 9] = new Color(0, 0, 0, 0);
        }
        texture.SetPixels(datas);
        texture.Apply();
    }
    private Texture2D TextureToRect(Texture2D back, Texture2D up,RectInt backPoint,RectInt upPoint)
    {
        if(backPoint.width == upPoint.width && backPoint.height == upPoint.height)
        {
            Debug.Log(backPoint + "  " + upPoint);
            var text = new Texture2D(back.width, back.height, TextureFormat.ARGB32, false);
            var colors = back.GetPixels();
            var upColors = up.GetPixels();
            for(var y = 0; y < backPoint.height;y++)
            {
                for(var x = 0; x < backPoint.width;x++)
                {
                    var idx = (upPoint.y + y) * back.width + (x + upPoint.x);
                    if(idx >= upColors.Length)
                    {
                        colors[(backPoint.y + y) * back.width + (x + backPoint.x)] = new Color(0,0,0,0);
                    }
                    else
                    {
                        colors[(backPoint.y + y) * back.width + (x + backPoint.x)] = upColors[idx];
                    }
                }
            }
            text.SetPixels(colors);
            text.Apply();
            return text;
        }
        return null;
    }
    public void ToRule12(bool isOne = false)
    {
        var rule2 = UnityRandom.RangeCombination(15, 2);
        var Len = isOne ? 1 : sourceListB[0].count;
        var id = 9;
        var texts = imageListsB;
        for (var x = 0; x < Len; x++)
        {
            var idx = Random.Range(0, rule2.Length);
            var rule = rule2[idx];
            var idxs = UnityRandom.GetRandomSequence(rule.Length, rule.Length);
            CombineAndSave(texts[0][rule[idxs[0]]], texts[3][rule[idxs[1]]], (id + 0) + "_" + x);
            CombineAndSave(texts[1][rule[idxs[0]]], texts[3][rule[idxs[1]]], (id + 1) + "_" + x);
            CombineAndSave(texts[1][rule[idxs[0]]], texts[2][rule[idxs[1]]], (id + 2) + "_" + x);
            CombineAndSave(texts[0][rule[idxs[0]]], texts[2][rule[idxs[1]]], (id + 3) + "_" + x);
        }
        id = 13;
        var ruleAng2 = UnityRandom.RangeCombination(4, 2);
        for (var x = 0; x < Len; x++)
        {

            CombineAndSave(imageListsA[2][Random.Range(0, imageListsA[2].Count)], imageListsA[3][Random.Range(0, imageListsA[3].Count)], (id + 1) + "_" + x);
            CombineAndSave(imageListsA[0][Random.Range(0, imageListsA[0].Count)], imageListsA[1][Random.Range(0, imageListsA[1].Count)], (id + 0) + "_" + x);
        }
        for (int i = 0;i < mapLists.Count;++i)
        {
            var newPath = Application.dataPath + AssetDatabase.GetAssetPath(mapLists[i]).Replace("Assets", "").Replace(mapLists[i].name, 0 + "_" + i);
            if (File.Exists(newPath))
            {
                File.Delete(newPath);
            }
            File.Copy(Application.dataPath + AssetDatabase.GetAssetPath(mapLists[i]).Replace("Assets", ""), newPath);
        }
        var ids = new int[] { 5, 7, 8, 6 };
        for (var x = 0; x < imageListsB.Length; ++x)
        {
            for (var y = 0; y < imageListsB[x].Count; ++y)
            {
                var newPath = Application.dataPath + AssetDatabase.GetAssetPath(imageListsB[x][y]).Replace("Assets", "").Replace(imageListsB[x][y].name, ids[x] + "_" + y);
                if (File.Exists(newPath))
                {
                    File.Delete(newPath);
                }
                File.Copy(Application.dataPath + AssetDatabase.GetAssetPath(imageListsB[x][y]).Replace("Assets", ""), newPath);
            }
        }
        ids = new int[] { 2, 4, 3, 1 };
        for (var x = 0; x < imageListsA.Length; ++x)
        {
            for (var y = 0; y < imageListsA[x].Count; ++y)
            {
                var newPath = Application.dataPath + AssetDatabase.GetAssetPath(imageListsA[x][y]).Replace("Assets", "").Replace(imageListsA[x][y].name, ids[x] + "_" + y);
                if (File.Exists(newPath))
                {
                    File.Delete(newPath);
                }
                File.Copy(Application.dataPath + AssetDatabase.GetAssetPath(imageListsA[x][y]).Replace("Assets", ""), newPath);
            }
        }
        AssetDatabase.Refresh();
    }
   
    private void To15Ralu()
    {
        int[][] rule4 = UnityRandom.RangeCombination(15, 4);
        var rule3 = UnityRandom.RangeCombination(15, 3);
        var rule2 = UnityRandom.RangeCombination(15, 2);

        var ruleAng4 = UnityRandom.RangeCombination(4, 4);
        var ruleAng3 = UnityRandom.RangeCombination(4, 3);
        var ruleAng2 = UnityRandom.RangeCombination(4, 2);
        Debug.Log(rule4.Length + "  " + rule3.Length + "  " + rule2.Length);
        Debug.Log(ruleAng4.Length + "  " + ruleAng3.Length + "  " + ruleAng2.Length);
        if (imageListsB[0].Count > 0)
        {
            CombineRuleTexture(rule4, imageListsB, 4);
            CombineRuleTexture(rule3, imageListsB, 3);
            CombineRuleTexture(rule2, imageListsB, 2);
            var ids = new int[] { 27, 29, 30, 28 };
            for (var x = 0; x < imageListsB.Length; ++x)
            {
                for (var y = 0; y < imageListsB[x].Count; ++y)
                {
                    var newPath = Application.dataPath + AssetDatabase.GetAssetPath(imageListsB[x][y]).Replace("Assets", "").Replace(imageListsB[x][y].name, ids[x] + "_" + y);
                    if (File.Exists(newPath))
                    {
                        File.Delete(newPath);
                    }
                    File.Copy(Application.dataPath + AssetDatabase.GetAssetPath(imageListsB[x][y]).Replace("Assets", ""), newPath);
                }
            }
            AssetDatabase.Refresh();
        }
    }
    private void ToRalu()
    {
        int[][] rule4 = UnityRandom.RangeCombination(15, 4);
        var rule3 = UnityRandom.RangeCombination(15, 3);
        var rule2 = UnityRandom.RangeCombination(15, 2);

        var ruleAng4 = UnityRandom.RangeCombination(4, 4);
        var ruleAng3 = UnityRandom.RangeCombination(4, 3);
        var ruleAng2 = UnityRandom.RangeCombination(4, 2);
        Debug.Log(rule4.Length + "  " + rule3.Length + "  " + rule2.Length);
        Debug.Log(ruleAng4.Length + "  " + ruleAng3.Length + "  " + ruleAng2.Length);
        if (imageListsA[0].Count > 0)
        {
            var path = Application.dataPath.Replace("Assets","")+ AssetDatabase.GetAssetPath(imageListsA[0][0]);
            CombineRuleTexture(rule4, imageListsB, 4);
            CombineRuleTexture(rule3, imageListsB, 3);
            CombineRuleTexture(rule2, imageListsB, 2);

            CombineRuleTexture(ruleAng4, imageListsA, 4,false);
            CombineRuleTexture(ruleAng3, imageListsA, 3,false);
            CombineRuleTexture(ruleAng2, imageListsA, 2, false);

            CombineRuleTexture(rule2, imageListsB, imageListsA, 2, 1);
            CombineRuleTexture(rule2, imageListsB, imageListsA, 1, 2);
            CombineRuleTexture(rule2, imageListsB, imageListsA, 1, 1);
            var ids = new int[] { 27, 29, 30, 28 };
            for(var x = 0;x < imageListsB.Length;++x)
            {
                for (var y = 0; y < imageListsB[x].Count; ++y)
                {
                    var newPath = Application.dataPath + AssetDatabase.GetAssetPath(imageListsB[x][y]).Replace("Assets", "").Replace(imageListsB[x][y].name, ids[x] + "_" + y);
                    if(File.Exists(newPath))
                    {
                        File.Delete(newPath);
                    }
                    File.Copy(Application.dataPath + AssetDatabase.GetAssetPath(imageListsB[x][y]).Replace("Assets", ""), newPath);
                }
            }
            ids = new int[] { 42, 44, 43, 45 };
            for (var x = 0; x < imageListsA.Length; ++x)
            {
                for (var y = 0; y < imageListsA[x].Count; ++y)
                {
                    var newPath = Application.dataPath + AssetDatabase.GetAssetPath(imageListsA[x][y]).Replace("Assets", "").Replace(imageListsA[x][y].name, ids[x] + "_" + y);
                    if (File.Exists(newPath))
                    {
                        File.Delete(newPath);
                    }
                    File.Copy(Application.dataPath + AssetDatabase.GetAssetPath(imageListsA[x][y]).Replace("Assets", ""), newPath);
                }
            }
            AssetDatabase.Refresh();
        }
    }
    private void CombineRuleTexture(int[][] rules, List<Texture2D>[] texts, int num,bool bian = true, bool isOne = true)
    {
        var id = 0;
        var Len = 0; 
        switch (num)
        {
            case 4:
               
                if(bian == false)
                {
                    id = 31;
                }
                else
                {
                    id = 0;
                }
                Len = isOne ? 1: texts[0].Count;
              
                for(var x = 0;x < Len;x++)
                {
                    var idx = Random.Range(0, rules.Length);
                    var rule = rules[idx];
                    var idxs = UnityRandom.GetRandomSequence(rule.Length, rule.Length);
                    CombineAndSave(texts[0][rule[idxs[0]]], texts[1][rule[idxs[1]]], texts[2][rule[idxs[2]]], texts[3][rule[idxs[3]]],id+"_"+x);
                }
                break;
            case 3:
                if (bian == false)
                {
                    id = 32;
                }
                else
                {
                    id = 1;
                }
                Len = isOne ? 1 : texts[0].Count;
                for (var x = 0; x < Len; x++)
                {
                    var idx = Random.Range(0, rules.Length);
                    var rule = rules[idx];
                    var idxs = UnityRandom.GetRandomSequence(rule.Length, rule.Length);
                    if(bian)
                    {
                        CombineAndSave(texts[0][rule[idxs[0]]], texts[1][rule[idxs[1]]], texts[2][rule[idxs[2]]], id + "_" + x);
                        CombineAndSave(texts[0][rule[idxs[0]]], texts[1][rule[idxs[1]]], texts[3][rule[idxs[2]]], (id + 1) + "_" + x);
                        CombineAndSave(texts[0][rule[idxs[0]]], texts[3][rule[idxs[1]]], texts[2][rule[idxs[2]]], (id + 3) + "_" + x);
                        CombineAndSave(texts[3][rule[idxs[0]]], texts[1][rule[idxs[1]]], texts[2][rule[idxs[2]]], (id + 2) + "_" + x);
                    }
                    else
                    {
                        CombineAndSave(texts[0][rule[idxs[0]]], texts[1][rule[idxs[1]]], texts[2][rule[idxs[2]]], id + "_" + x);
                        CombineAndSave(texts[3][rule[idxs[0]]], texts[1][rule[idxs[1]]], texts[2][rule[idxs[2]]], (id + 1) + "_" + x);
                        CombineAndSave(texts[0][rule[idxs[0]]], texts[1][rule[idxs[1]]], texts[3][rule[idxs[2]]], (id + 2) + "_" + x);
                        CombineAndSave(texts[0][rule[idxs[0]]], texts[3][rule[idxs[1]]], texts[2][rule[idxs[2]]], (id + 3) + "_" + x);

                    }
                 
                }
                break;
            case 2:
                if (bian == false)
                {
                    id = 36;
                }
                else
                {
                    id = 5;
                }
                Len = isOne ? 1 : texts[0].Count;
                for (var x = 0; x < Len; x++)
                {
                    var idx = Random.Range(0, rules.Length);
                    var rule = rules[idx];
                    var idxs = UnityRandom.GetRandomSequence(rule.Length, rule.Length);
                    CombineAndSave(texts[2][rule[idxs[0]]], texts[3][rule[idxs[1]]], (id + 0) + "_" + x);
                    CombineAndSave(texts[0][rule[idxs[0]]], texts[1][rule[idxs[1]]], (id + 1) + "_" + x);

                }
                if (bian == false)
                {
                    id = 38;
                }
                else
                {
                    id = 11;
                }
                Len = isOne ? 1 : texts[0].Count;
                for (var x = 0; x < Len; x++)
                {
                    var idx = Random.Range(0, rules.Length);
                    var rule = rules[idx];
                    var idxs = UnityRandom.GetRandomSequence(rule.Length, rule.Length);
                    if (bian)
                    {
                        CombineAndSave(texts[0][rule[idxs[0]]], texts[2][rule[idxs[1]]], id + "_" + x);
                        CombineAndSave(texts[0][rule[idxs[0]]], texts[3][rule[idxs[1]]], (id + 1) + "_" + x);
                        CombineAndSave(texts[1][rule[idxs[0]]], texts[3][rule[idxs[1]]], (id + 2) + "_" + x);
                        CombineAndSave(texts[1][rule[idxs[0]]], texts[2][rule[idxs[1]]], (id + 3) + "_" + x);
                    }
                    else
                    {
                        CombineAndSave(texts[0][rule[idxs[0]]], texts[2][rule[idxs[1]]], id + "_" + x);
                        CombineAndSave(texts[1][rule[idxs[0]]], texts[2][rule[idxs[1]]], (id + 1) + "_" + x);
                        CombineAndSave(texts[1][rule[idxs[0]]], texts[3][rule[idxs[1]]], (id + 2) + "_" + x);
                        CombineAndSave(texts[0][rule[idxs[0]]], texts[3][rule[idxs[1]]], (id + 3) + "_" + x);
                    }
                }
                break;
        }
    }
    private void CombineRuleTexture(int[][] rules, List<Texture2D>[] bans, List<Texture2D>[] angles, int bian,int angle, bool isOne = true)
    {
        var id = 0;
        var Len = 0;
        if(bian == 2)
        {
            id = 7;
            Len = isOne ? 1 : bans[0].Count;
            for (var x = 0; x < Len; x++)
            {
                var idx = Random.Range(0, rules.Length);
                var rule = rules[idx];
                var idxs = UnityRandom.GetRandomSequence(rule.Length, rule.Length);
                CombineAndSave(bans[0][rule[idxs[0]]], bans[2][rule[idxs[1]]], angles[1][UnityRandom.RangeInt(0, angles[1].Count)], id + "_" + x);
                CombineAndSave(bans[0][rule[idxs[0]]], bans[3][rule[idxs[1]]], angles[3][UnityRandom.RangeInt(0, angles[1].Count)], (id + 1) + "_" + x);
                CombineAndSave(bans[1][rule[idxs[0]]], bans[3][rule[idxs[1]]], angles[0][UnityRandom.RangeInt(0, angles[1].Count)], (id + 2) + "_" + x);
                CombineAndSave(bans[1][rule[idxs[0]]], bans[2][rule[idxs[1]]], angles[2][UnityRandom.RangeInt(0, angles[1].Count)], (id + 3) + "_" + x);
            }
        }
        else
        {
            if(angle == 2)
            {
                id = 15;
                Len = isOne ? 1 : bans[0].Count;
                for (var x = 0; x < Len; x++)
                {
                    var idx = Random.Range(0, rules.Length);
                    CombineAndSave(angles[1][UnityRandom.RangeInt(0, angles[1].Count)], angles[3][UnityRandom.RangeInt(0, angles[3].Count)], bans[0][UnityRandom.RangeInt(0, bans[0].Count)], (id + 0) + "_" + x);
                    CombineAndSave(angles[0][UnityRandom.RangeInt(0, angles[0].Count)], angles[3][UnityRandom.RangeInt(0, angles[3].Count)], bans[3][UnityRandom.RangeInt(0, bans[3].Count)], (id + 1) + "_" + x);
                    CombineAndSave(angles[0][UnityRandom.RangeInt(0, angles[0].Count)], angles[2][UnityRandom.RangeInt(0, angles[2].Count)], bans[1][UnityRandom.RangeInt(0, bans[1].Count)], (id + 2)+ "_" + x);
                    CombineAndSave(angles[1][UnityRandom.RangeInt(0, angles[1].Count)], angles[2][UnityRandom.RangeInt(0, angles[2].Count)], bans[2][UnityRandom.RangeInt(0, bans[2].Count)], (id + 3) + "_" + x);
                }
            }
            else if(angle == 1)
            {
                id = 19;
                Len = isOne ? 1 : bans[0].Count;
                for (var x = 0; x < Len; x++)
                {
                    var idx = Random.Range(0, rules.Length);
                    CombineAndSave(angles[1][UnityRandom.RangeInt(0, angles[1].Count)], bans[0][UnityRandom.RangeInt(0, bans[0].Count)], (id + 0) + "_" + x);
                    CombineAndSave(angles[3][UnityRandom.RangeInt(0, angles[3].Count)], bans[0][UnityRandom.RangeInt(0, bans[0].Count)], (id + 1) + "_" + x);

                    CombineAndSave(angles[0][UnityRandom.RangeInt(0, angles[0].Count)],  bans[3][UnityRandom.RangeInt(0, bans[3].Count)], (id + 2) + "_" + x);
                    CombineAndSave(angles[3][UnityRandom.RangeInt(0, angles[3].Count)], bans[3][UnityRandom.RangeInt(0, bans[3].Count)], (id + 3) + "_" + x);

                    CombineAndSave(angles[0][UnityRandom.RangeInt(0, angles[0].Count)],  bans[1][UnityRandom.RangeInt(0, bans[1].Count)], (id + 4) + "_" + x);
                    CombineAndSave( angles[2][UnityRandom.RangeInt(0, angles[2].Count)], bans[1][UnityRandom.RangeInt(0, bans[1].Count)], (id + 5) + "_" + x);

                    CombineAndSave( angles[2][UnityRandom.RangeInt(0, angles[2].Count)], bans[2][UnityRandom.RangeInt(0, bans[2].Count)], (id + 6) + "_" + x);
                    CombineAndSave(angles[1][UnityRandom.RangeInt(0, angles[1].Count)],bans[2][UnityRandom.RangeInt(0, bans[2].Count)], (id + 7) + "_" + x);
                }
            }
        }
    }
    private string[] banNames = new string[] { "Down","Up","Left","Right"};
    private string[] AngNames = new string[] { "DL","UL","DR","UR"};
    private void InitRalu()
    {
        mapReorders = new ReorderableList(mapLists, typeof(Texture2D), true, true, true, true);
        mapReorders.drawElementCallback = (rect, index, isActive, isFocused) =>
        {
            rect.x += 20;
            rect.width -= 20;
            mapLists[index] = (Texture2D)EditorGUI.ObjectField(new Rect(rect.x, rect.y, rect.width, EditorGUIUtility.singleLineHeight), mapLists[index], typeof(Texture2D), false);
        };
        mapReorders.onAddCallback = (l) =>
        {
            mapLists.Add(null);
        };
        mapReorders.drawHeaderCallback = (rect) =>
        {
            GUI.Label(rect, "Map", EditorStyles.label);
        };
        sourceListB = new ReorderableList[4];
        for (var x = 0; x < sourceListB.Length; ++x)
        {
            imageListsB[x] = new List<Texture2D>();
            var list = imageListsB[x];
            sourceListB[x] = new ReorderableList(list, typeof(Texture2D), true, true, true, true);
            sourceListB[x].drawElementCallback = (rect, index, isActive, isFocused) =>
            {
                rect.x += 20;
                rect.width -= 20;
                list[index] = (Texture2D)EditorGUI.ObjectField(new Rect(rect.x, rect.y, rect.width, EditorGUIUtility.singleLineHeight), list[index], typeof(Texture2D), false);
            };
            sourceListB[x].onAddCallback = (l) =>
            {
                list.Add(null);
            };
            var name = banNames[x];
            sourceListB[x].drawHeaderCallback = (rect) =>
            {
                GUI.Label(rect, name, EditorStyles.label);
            };
        }
        sourceListA = new ReorderableList[4];
        for (var x  = 0; x < sourceListA.Length;++x)
        {
            imageListsA[x] = new List<Texture2D>();
            var list= imageListsA[x];
            sourceListA[x] = new ReorderableList(list, typeof(Texture2D), true, true, true, true);
            sourceListA[x].drawElementCallback = (rect, index, isActive, isFocused) =>
            {
                rect.x += 20;
                rect.width -= 20;
                list[index] = (Texture2D)EditorGUI.ObjectField(new Rect(rect.x, rect.y, rect.width, EditorGUIUtility.singleLineHeight), list[index], typeof(Texture2D), false);
            };
            sourceListA[x].onAddCallback = (l) =>
            {
                list.Add(null);
            }; 
            var name = AngNames[x];
            sourceListA[x].drawHeaderCallback = (rect) =>
            {
                GUI.Label(rect, name, EditorStyles.label);
            };
        }
    }
    private void JIaoToDaa()
    {
        for (int i = 0; i < imageListsA[0].Count; i++)
        {
            var texture = VerticalFlipTexture(imageListsA[0][i]);
            texture.name = "UL_" + imageListsA[1].Count;
            imageListsA[1].Add(texture);
            SaveTexture(texture, Path.GetDirectoryName(AssetDatabase.GetAssetPath(imageListsA[0][i])) + "/" + texture.name, false);
        }
        for (int i = 0; i < imageListsA[2].Count; i++)
        {
            var texture = VerticalFlipTexture(RotationRight90(imageListsA[2][i].GetPixels32(), 10, 10));
            texture.name = "UL__" + imageListsA[1].Count;
            imageListsA[1].Add(texture);
            SaveTexture(texture, Path.GetDirectoryName(AssetDatabase.GetAssetPath(imageListsA[2][i])) + "/" + texture.name, false);
        }
        for (int i = 0; i < imageListsA[3].Count; i++)
        {
            var texture = RotationLeft90(imageListsA[3][i].GetPixels32(), 10, 10);
            texture.name = "UL_" + imageListsA[1].Count;
            imageListsA[1].Add(texture);
            SaveTexture(texture, Path.GetDirectoryName(AssetDatabase.GetAssetPath(imageListsA[3][i])) + "/" + texture.name, false);
        }
        AssetDatabase.Refresh();
        for (int i = 0; i < imageListsA[0].Count; ++i)
        {
            File.Delete(AssetDatabase.GetAssetPath(imageListsA[0][i]));
        }
        for (int i = 0; i < imageListsA[2].Count; ++i)
        {
            File.Delete(AssetDatabase.GetAssetPath(imageListsA[2][i]));
        }
        for (int i = 0; i < imageListsA[3].Count; ++i)
        {
            File.Delete(AssetDatabase.GetAssetPath(imageListsA[3][i]));
        }
        imageListsA[0].Clear();
        imageListsA[2].Clear();
        imageListsA[3].Clear();
        for (int i = 0; i < imageListsA[1].Count; i++)
        {
            var texture = VerticalFlipTexture(imageListsA[1][i]);
            texture.name = "DR_" + imageListsA[3].Count;
            imageListsA[3].Add(texture);
            SaveTexture(texture, Path.GetDirectoryName(AssetDatabase.GetAssetPath(imageListsA[1][0])) + "/" + texture.name, false);
        }
        for (int i = 0; i < imageListsA[3].Count; i++)
        {
            var texture = HorizontalFlipTexture(imageListsA[3][i]);
            texture.name = "DL_" + imageListsA[2].Count;
            imageListsA[2].Add(texture);
            SaveTexture(texture, Path.GetDirectoryName(AssetDatabase.GetAssetPath(imageListsA[1][0])) + "/" + texture.name, false);
        }
        for (int i = 0; i < imageListsA[1].Count; i++)
        {
            var texture = HorizontalFlipTexture(imageListsA[1][i]);
            texture.name = "UR_" + imageListsA[0].Count;
            imageListsA[0].Add(texture);
            SaveTexture(texture, Path.GetDirectoryName(AssetDatabase.GetAssetPath(imageListsA[1][0])) + "/" + texture.name, false);
        }
        AssetDatabase.Refresh(); 
    }
    private void BianToDaa()
    {
        for (int i = 0; i < imageListsB[0].Count; i++)
        {
            var texture = VerticalFlipTexture(imageListsB[0][i]);
            texture.name = "Up_" + imageListsB[1].Count;
            imageListsB[1].Add(texture);
            SaveTexture(texture, Path.GetDirectoryName(AssetDatabase.GetAssetPath(imageListsB[0][i])) + "/" + texture.name, false);
        }
        for (int i = 0; i < imageListsB[2].Count; i++)
        {
            var texture = RotationRight90(imageListsB[2][i].GetPixels32(), imageListsB[2][i].width, imageListsB[2][i].height);
            texture.name = "Up_" + imageListsB[1].Count;
            imageListsB[1].Add(texture);
            SaveTexture(texture, Path.GetDirectoryName(AssetDatabase.GetAssetPath(imageListsB[2][i])) + "/" + texture.name, false);
        }
        for (int i = 0; i < imageListsB[3].Count; i++)
        {
            var texture = RotationLeft90(imageListsB[3][i].GetPixels32(), imageListsB[3][i].width, imageListsB[3][i].width);
            texture.name = "Up_" + imageListsB[1].Count;
            imageListsB[1].Add(texture);
            SaveTexture(texture, Path.GetDirectoryName(AssetDatabase.GetAssetPath(imageListsB[3][i])) + "/" + texture.name, false);
        }
        AssetDatabase.Refresh();
        for (int i = 0; i < imageListsB[0].Count; ++i)
        {
            File.Delete(AssetDatabase.GetAssetPath(imageListsB[0][i]));
        }
        for (int i = 0; i < imageListsB[2].Count; ++i)
        {
            File.Delete(AssetDatabase.GetAssetPath(imageListsB[2][i]));
        }
        for (int i = 0; i < imageListsB[3].Count; ++i)
        {
            File.Delete(AssetDatabase.GetAssetPath(imageListsB[3][i]));
        }
        imageListsB[0].Clear();
        imageListsB[2].Clear();
        imageListsB[3].Clear();
        for (int i = 0; i < imageListsB[1].Count; i++)
        {
            var texture = RotationLeft90(imageListsB[1][i].GetPixels32(), imageListsB[1][i].width, imageListsB[1][i].width);
            texture.name = "Right_" + imageListsB[3].Count;
            imageListsB[3].Add(texture);
            SaveTexture(texture, Path.GetDirectoryName(AssetDatabase.GetAssetPath(imageListsB[1][0])) + "/" + texture.name, false);
        }
        for (int i = 0; i < imageListsB[1].Count; i++)
        {
            var texture = RotationRight90(imageListsB[1][i].GetPixels32(), imageListsB[1][i].width, imageListsB[1][i].width);
            texture.name = "Left_" + imageListsB[2].Count;
            imageListsB[2].Add(texture);
            SaveTexture(texture, Path.GetDirectoryName(AssetDatabase.GetAssetPath(imageListsB[1][0])) + "/" + texture.name, false);
        }
        for (int i = 0; i < imageListsB[1].Count; i++)
        {
            var texture = VerticalFlipTexture(imageListsB[1][i]);
            texture.name = "Down_" + imageListsB[0].Count;
            imageListsB[0].Add(texture);
            SaveTexture(texture, Path.GetDirectoryName(AssetDatabase.GetAssetPath(imageListsB[1][0])) + "/" + texture.name, false);
        }
        AssetDatabase.Refresh();
    }

    void OverlayImages(Texture2D image1, Texture2D image2, Texture2D image3, Texture2D image4)
    {
        if (image1 == null || image2 == null || image3 == null || image4 == null)
        {
            Debug.LogError("Please assign all four images.");
            return;
        }

        // Two images overlay
        CombineAndSave(image1, image2, "CombinedImage_1_2");
        CombineAndSave(image1, image3, "CombinedImage_1_3");
        CombineAndSave(image1, image4, "CombinedImage_1_4");
        CombineAndSave(image2, image3, "CombinedImage_2_3");
        CombineAndSave(image2, image4, "CombinedImage_2_4");
        CombineAndSave(image3, image4, "CombinedImage_3_4");

        // Three images overlay
        CombineAndSave(image1, image2, image3, "CombinedImage_1_2_3");
        CombineAndSave(image1, image2, image4, "CombinedImage_1_2_4");
        CombineAndSave(image1, image3, image4, "CombinedImage_1_3_4");
        CombineAndSave(image2, image3, image4, "CombinedImage_2_3_4");

        // Four images overlay
        CombineAndSave(image1, image2, image3, image4, "CombinedImage_1_2_3_4");
        AssetDatabase.Refresh();
    }

    void CombineAndSave(Texture2D source1, Texture2D source2, string fileName)
    {
        Texture2D combinedImage = new Texture2D(source1.width, source1.height, TextureFormat.RGBA32, false);
        Graphics.CopyTexture(source1, combinedImage);

        OverlayOnto(ref combinedImage, source2);
        SaveTexture(combinedImage, Path.GetDirectoryName(AssetDatabase.GetAssetPath(source1)) + "/" + fileName, false);
    }

    void CombineAndSave(Texture2D source1, Texture2D source2, Texture2D source3, string fileName)
    {
        Texture2D combinedImage = new Texture2D(source1.width, source1.height, TextureFormat.RGBA32, false);
        Graphics.CopyTexture(source1, combinedImage);

        OverlayOnto(ref combinedImage, source2);
        OverlayOnto(ref combinedImage, source3);
        SaveTexture(combinedImage, Path.GetDirectoryName(AssetDatabase.GetAssetPath(source1)) + "/" + fileName,false);
    }

    void CombineAndSave(Texture2D source1, Texture2D source2, Texture2D source3, Texture2D source4, string fileName)
    {
        Texture2D combinedImage = new Texture2D(source1.width, source1.height, TextureFormat.RGBA32, false);
        Graphics.CopyTexture(source1, combinedImage);

        OverlayOnto(ref combinedImage, source2);
        OverlayOnto(ref combinedImage, source3);
        OverlayOnto(ref combinedImage, source4);
        SaveTexture(combinedImage, Path.GetDirectoryName(AssetDatabase.GetAssetPath(source1)) + "/" + fileName,false);
    }

    void OverlayOnto(ref Texture2D target, Texture2D source)
    {
        Color[] targetPixels = target.GetPixels();
        Color[] sourcePixels = source.GetPixels();

        for (int i = 0; i < targetPixels.Length; i++)
        {
            if (sourcePixels[i].a > 0)
            {
                targetPixels[i] = sourcePixels[i];
            }
        }

        target.SetPixels(targetPixels);
        target.Apply();
    }

    void SaveTexture(Texture2D texture, string fileName, bool isAdd = true)
    {
        if (isAdd)
            ChangeTransparentColor(texture, color);
        byte[] bytes = texture.EncodeToPNG();
        string path = Application.dataPath.Replace("Assets", "") + fileName + ".png";
        if (!string.IsNullOrEmpty(path))
        {
            System.IO.File.WriteAllBytes(path, bytes);

        }
    }
    public Texture2D RotateTexture(Texture2D texture, float angle)
    {
        Color[] pix = texture.GetPixels();
        Color[] newPix = new Color[pix.Length];
        int w = texture.width;
        int h = texture.height;
        float sin = Mathf.Sin(angle * Mathf.Deg2Rad);
        float cos = Mathf.Cos(angle * Mathf.Deg2Rad);
        for (int y = 0; y < h; y++)
        {
            for (int x = 0; x < w; x++)
            {
                int newX = (int)(cos * (x - (w - 1) * 0.5f) + (sin * (y - (h - 1) * 0.5f) + (w - 1) * 0.5f));
                int newY = (int)(-sin * (x - (w - 1) * 0.5f) + cos * (y - (h - 1) * 0.5f) + (h - 1) * 0.5f);
                Debug.Log(newX + ", " + newY + "  " + x + "  " + y);
                if (newX >= 0 && newX < w && newY >= 0 && newY < h)
                {
                    newPix[y * w + x] = pix[newY * w + newX];
                }
                else
                {
                    newPix[y * w + x] = Color.clear;
                }
            }
        }
        Texture2D newTexture = new Texture2D(w, h);
        newTexture.SetPixels(newPix);
        newTexture.Apply();
        return newTexture;
    }
    /// <summary>
    /// 图片顺时针旋转90度
    /// </summary>
    /// <param name="src">原图片二进制数据</param>
    /// <param name="srcW">原图片宽度</param>
    /// <param name="srcH">原图片高度</param>
    /// <param name="desTexture">输出目标图片</param>
    public static Texture2D RotationRight90(Color32[] src, int srcW, int srcH)
    {

        Color32[] des = new Color32[src.Length];
        for (int i = 0; i < srcH; i++)
        {
            for (int j = 0; j < srcW; j++)
            {
                des[(srcW - j - 1) * srcH + i] = src[i * srcW + j];
            }
        }

        Texture2D newTexture = new Texture2D(srcW, srcH);
        newTexture.SetPixels32(des);
        newTexture.Apply();
        return newTexture;
    }
    /// <summary>
    /// 图片逆时针旋转90度
    /// </summary>
    /// <param name="src">原图片二进制数据</param>
    /// <param name="srcW">原图片宽度</param>
    /// <param name="srcH">原图片高度</param>
    /// <param name="desTexture">输出目标图片</param>
    public static Texture2D RotationLeft90(Color32[] src, int srcW, int srcH)
    {
        Color32[] des = new Color32[src.Length];
        Texture2D desTexture = new Texture2D(srcH, srcW);
        for (int i = 0; i < srcW; i++)
        {
            for (int j = 0; j < srcH; j++)
            {
                des[i * srcH + j] = src[(srcH - 1 - j) * srcW + i];
            }
        }

        Texture2D newTexture = new Texture2D(srcW, srcH);
        newTexture.SetPixels32(des);
        newTexture.Apply();
        return newTexture;
    }
    /// <summary>
    /// 垂直翻转
    /// </summary>
    /// <param name="texture"></param>
    /// <returns></returns>
    public static Texture2D VerticalFlipTexture(Texture2D texture)
    {
        //得到图片的宽高
        int width = texture.width;
        int height = texture.height;

        Texture2D flipTexture = new Texture2D(width, height);
        for (int i = 0; i < height; i++)
        {
            flipTexture.SetPixels(0, i, width, 1, texture.GetPixels(0, height - i - 1, width, 1));
        }
        flipTexture.Apply();
        return flipTexture;
    }
    /// <summary>
    /// 水平翻转
    /// </summary>
    /// <param name="texture"></param>
    /// <returns></returns>
    public static Texture2D HorizontalFlipTexture(Texture2D texture)
    {
        //得到图片的宽高
        int width = texture.width;
        int height = texture.height;

        Texture2D flipTexture = new Texture2D(width, height);

        for (int i = 0; i < width; i++)
        {
            flipTexture.SetPixels(i, 0, 1, height, texture.GetPixels(width - i - 1, 0, 1, height));
        }
        flipTexture.Apply();

        return flipTexture;
    }
    /// <summary>
    /// 裁剪Texture2D
    /// </summary>
    /// <param name="originalTexture"></param>
    /// <param name="offsetX"></param>
    /// <param name="offsetY"></param>
    /// <param name="originalWidth"></param>
    /// <param name="originalHeight"></param>
    /// <returns></returns>
    public static Texture2D ScaleTextureCutOut(Texture2D originalTexture, int offsetX, int offsetY, float originalWidth, float originalHeight)
    {
        Texture2D newTexture = new Texture2D(Mathf.CeilToInt(originalWidth), Mathf.CeilToInt(originalHeight));
        int maxX = originalTexture.width - 1;
        int maxY = originalTexture.height - 1;
        for (int y = 0; y < newTexture.height; y++)
        {
            for (int x = 0; x < newTexture.width; x++)
            {
                float targetX = x + offsetX;
                float targetY = y + offsetY;
                int x1 = Mathf.Min(maxX, Mathf.FloorToInt(targetX));
                int y1 = Mathf.Min(maxY, Mathf.FloorToInt(targetY));
                int x2 = Mathf.Min(maxX, x1 + 1);
                int y2 = Mathf.Min(maxY, y1 + 1);

                float u = targetX - x1;
                float v = targetY - y1;
                float w1 = (1 - u) * (1 - v);
                float w2 = u * (1 - v);
                float w3 = (1 - u) * v;
                float w4 = u * v;
                Color color1 = originalTexture.GetPixel(x1, y1);
                Color color2 = originalTexture.GetPixel(x2, y1);
                Color color3 = originalTexture.GetPixel(x1, y2);
                Color color4 = originalTexture.GetPixel(x2, y2);
                Color color = new Color(Mathf.Clamp01(color1.r * w1 + color2.r * w2 + color3.r * w3 + color4.r * w4),
                                        Mathf.Clamp01(color1.g * w1 + color2.g * w2 + color3.g * w3 + color4.g * w4),
                                        Mathf.Clamp01(color1.b * w1 + color2.b * w2 + color3.b * w3 + color4.b * w4),
                                        Mathf.Clamp01(color1.a * w1 + color2.a * w2 + color3.a * w3 + color4.a * w4)
                                        );
                newTexture.SetPixel(x, y, color);
            }
        }
        newTexture.anisoLevel = 2;
        newTexture.Apply();
        return newTexture;
    }
    public void ChangeTransparentColor(Texture2D texture, Color newColor)
    {
        int width = texture.width;
        int height = texture.height;
        Color[] pixels = texture.GetPixels();
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                int index = y * width + x;
                Color currentPixel = pixels[index];
                // 只处理半透明像素
                if (currentPixel.a < 0.1f)
                {
                    // 检查上下左右是否有非透明像素
                    bool hasOpaqueNeighbor = false;
                    for (int offsetY = -1; offsetY <= 1 && !hasOpaqueNeighbor; offsetY++)
                    {
                        for (int offsetX = -1; offsetX <= 1 && !hasOpaqueNeighbor; offsetX++)
                        {
                            if (offsetX == 0 && offsetY == 0) continue; // 跳过当前像素
                            int checkX = x + offsetX;
                            int checkY = y + offsetY;
                            // 确保不越界
                            if (checkX >= 0 && checkX < width && checkY >= 0 && checkY < height)
                            {
                                int checkIndex = checkY * width + checkX;
                                Color neighborPixel = pixels[checkIndex];
                                // 如果邻居是非透明的，改变当前像素的颜色
                                if (neighborPixel.a >= 0.5f && neighborPixel.Equals(newColor) == false)
                                {
                                    hasOpaqueNeighbor = true;
                                    pixels[index] = new Color(newColor.r, newColor.g, newColor.b, newColor.a);
                                }
                            }
                        }
                    }
                }
            }
        }
        // 将修改后的像素数据应用回纹理
        texture.SetPixels(pixels);
        // 应用这些更改
        texture.Apply();
    }
    #endregion
}