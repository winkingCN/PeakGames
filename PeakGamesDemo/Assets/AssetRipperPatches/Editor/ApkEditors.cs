
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using UnityEditor;

using UnityEngine;
using UnityEngine.Networking;
//using UnityEngine.Networking.Types;

namespace ApkTest
{
    [System.Serializable]
    public class ApkInfo
    {
        public string AppUrl;
        public string AppID
        {
            get
            {
                return Path.GetFileName(AppUrl);
            }
        }
        public string ImageUrl;
        public string Title;
        public bool IsOldApk = false;
        public Texture2D ImageTexture;
        public List<string> names = new List<string>();
        public List<string> urls = new List<string>();

        private Vector2 scrollPosition;
        public bool isLoadAllUrl = false;
        public string url = "";

        public List<string> ApkUrls = new List<string>();
        public List<float> progress = new List<float>();
        public List<bool> loadProgres = new List<bool>();

        public string ApkURL = "";
        public bool isLoadMain = false;
        public float loadProgress = 0;
        public float loadTime = 0;
        public string Size = "";

        public int GetApkIdx = -2;
        public void ShowGUI()
        {
            GUILayout.BeginHorizontal();

            GUIContent buttonContent = new GUIContent(ImageTexture, Title); // tooltip is the title

            if (GUILayout.Button(buttonContent, GUILayout.Width(70), GUILayout.Height(70)))
            {
                Debug.Log("Button Clicked: " + Title + ", URL: " + AppID);
                Application.OpenURL(AppUrl);
            }
            GUILayout.BeginVertical();
            GUILayout.Label(Title+"  "+Size);
            if(GUILayout.Button("ApkId: "+AppID))
            {
                GUIUtility.systemCopyBuffer = AppID;
            }
            if (isLoadMain)
            {
                EditorGUI.ProgressBar(EditorGUILayout.GetControlRect(GUILayout.Height(20)), loadProgress, "Download Progress " + (loadProgress * 100f).ToString("F2") + "%");
                if (string.IsNullOrEmpty(Size)  && Time.time - loadTime > 30)
                {
                    Debug.Log(Time.time+"   "+loadTime);
                    isLoadMain = false;
                }
            }
            else
            {
                if( File.Exists(ApkURL) || File.Exists(ApkURL+".apk") || File.Exists(ApkURL + ".xapk"))
                {
                    GUILayout.BeginHorizontal();
                    var color = GUI.color;
                    GUI.color = Color.red;
                    if (GUILayout.Button("刪除APK"))
                    {
                        if (ApkURL.EndsWith("apk") == false)
                        {
                            if (File.Exists(ApkURL + ".apk"))
                            {
                                ApkURL += ".apk";
                            }
                            else
                            {
                                ApkURL += ".xapk";
                            }
                        }
                        File.Delete(ApkURL);
                    }
                    GUI.color = Color.green;
                    if (GUILayout.Button("导出工程"))
                    {
                        ExportDeom(ApkURL);
                        
                    }
                    GUI.color = color;
                    if (GUILayout.Button("打开文件夹"))
                    {
                        EditorUtility.RevealInFinder(ApkURL);
                    }
                    GUILayout.EndHorizontal();
                }
                else if(Directory.Exists(ApkURL))
                {
                    GUILayout.BeginHorizontal();
                    var color = GUI.color;
                    GUI.color = Color.red;
                    if(Directory.GetFiles(ApkURL,"*apk").Length > 0)
                    {
                        if (GUILayout.Button("刪除Unity工程"))
                        {
                            Directory.Delete(ApkURL,true);
                        }
                    }
                    else
                    {
                        if (GUILayout.Button("刪除工程"))
                        {
                            Directory.Delete(ApkURL,true);
                        }
                    }
                    GUI.color = color;
                    if (GUILayout.Button("打开文件夹"))
                    {
                        EditorUtility.RevealInFinder(ApkURL);
                    }
                    GUILayout.EndHorizontal();
                }
                else
                {
                    if (GUILayout.Button("下载最新APK"))
                    {
                        isLoadMain = true;
                        loadTime = Time.time;
                        url = "https://apk.support/download-app/" + AppID;
                        GetApkIdx = -1;
                        StartCoroutine(GetApkUrl(), window);
                        Debug.Log(url);
                    }
                }
            }

            IsOldApk = EditorGUILayout.Foldout(IsOldApk, "历史版本");
            if (IsOldApk)
            {
                if (LoadApkURLs())
                {
                    scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, GUILayout.Height(125));
                    for (var x = 0; x < names.Count; ++x)
                    {
                        if (loadProgres[x])
                        {
                            EditorGUI.ProgressBar(EditorGUILayout.GetControlRect(GUILayout.Height(20)), progress[x], "Download Progress " + (progress[x] * 100f).ToString("F2") + "%");
                        }
                        else
                        {
                            if (File.Exists(ApkUrls[x]) || File.Exists(ApkUrls[x] + ".apk") || File.Exists(ApkUrls[x] + ".xapk"))
                            {
                                GUILayout.BeginHorizontal();
                                var color = GUI.color;
                                GUI.color = Color.red;
                                if (GUILayout.Button("刪除APK"))
                                {
                                    if (ApkUrls[x].EndsWith("apk") == false)
                                    {
                                        if (File.Exists(ApkUrls[x] + ".apk"))
                                        {
                                            ApkUrls[x] += ".apk";
                                        }
                                        else
                                        {
                                            ApkUrls[x] += ".xapk";
                                        }
                                    }
                                    File.Delete(ApkUrls[x]);
                                }
                                GUI.color = Color.green;
                                if (GUILayout.Button("导出工程"))
                                {
                                    ExportDeom(ApkUrls[x]);
                                }
                                
                                GUI.color = color; 
                                if (GUILayout.Button("打开文件夹"))
                                {
                                    EditorUtility.RevealInFinder(ApkUrls[x]);
                                }
                                GUILayout.EndHorizontal();
                            }
                            else if (Directory.Exists(ApkUrls[x]))
                            {
                                GUILayout.BeginHorizontal();
                                var color = GUI.color;
                                GUI.color = Color.red;
                                if (Directory.GetFiles(ApkUrls[x],"*apk").Length > 0)
                                {
                                    if (GUILayout.Button("刪除Unity工程"))
                                    {
                                        Directory.Delete(ApkUrls[x],true);
                                    }
                                }
                                else
                                {
                                    if (GUILayout.Button("刪除工程"))
                                    {
                                        Directory.Delete(ApkUrls[x],true);
                                    }
                                }
                                GUI.color = color;
                                if (GUILayout.Button("打开文件夹"))
                                {
                                    EditorUtility.RevealInFinder(ApkUrls[x]);
                                }
                                GUILayout.EndHorizontal();
                            }
                            else
                            {
                                if (GUILayout.Button(names[x], GUILayout.Width(310)))
                                {
                                    url = urls[x];
                                    GetApkIdx = x;
                                    StartCoroutine(GetApkUrl(), window);
                                    Debug.Log(url);
                                }
                            }
                        }
                    }
                    EditorGUILayout.EndScrollView();
                }
            }
            GUILayout.EndVertical();
            GUILayout.EndHorizontal();
        }
        public void ExportDeom(string path = "")
        {
            if(path == "")
            {
                path = ApkURL;
            }
            
            if (File.Exists(path + ".apk"))
            {
                path += ".apk";
            }
            else if(File.Exists(path+".xapk")) 
            {
                path += ".xapk";
            }
            else
            {
                return;
            }
            if (ZipFileHelper.CheckZipFileContainsTarget(path, "unity default resources"))
            {
                Debug.LogError("Unity 工程包");
                //ExportAssets(path);
                ExportAssetsAsync(path, (success, message) =>
                {
                    if (success)
                    {
                        Debug.Log($"Export completed successfully! Output: {message}");
                    }
                    else
                    {
                        Debug.LogError($"Export failed: {message}");
                    }
                });
            }
            else
            {

                Debug.LogError("非 Unity 工程包");
                var name = Path.GetFileNameWithoutExtension(path);
                string outputPath = Path.GetDirectoryName(path) + "/" + Path.GetFileNameWithoutExtension(path)+"/"+Path.GetFileName(path);
                var dcPath = Path.GetDirectoryName(path) + "/" + name;
                if(Directory.Exists(dcPath))
                {
                    Directory.Delete(dcPath, true);
                }
                ZipFileHelper.ExtractZipFileAndDelete(path, dcPath);
                var files = Directory.GetFiles(dcPath, "*.apk");
                foreach( var file in files)
                {
                    var n1 = Path.GetFileNameWithoutExtension(file);
                    var dc = Path.GetDirectoryName(file) + "/" + n1;
                    ZipFileHelper.ExtractZipFileAndDelete(file, dc);
                }
            }
            
        }
        /// <summary>
        /// 异步导出 XAPK 文件
        /// </summary>
        /// <param name="xapkPath">XAPK 文件路径</param>
        /// <param name="onComplete">导出完成后的回调</param>
        public static async void ExportAssetsAsync(string xapkPath, Action<bool, string> onComplete)
        {
            string outputPath = Path.GetDirectoryName(xapkPath) + "/" + Path.GetFileNameWithoutExtension(xapkPath);
            string assetRipperPath = Application.dataPath.Replace("/Assets", "") + "/Tools/AssetRipper.GUI.Free.exe"; // AssetRipper 路径
            string arguments = $"--export \"{xapkPath}#{outputPath}\"";

            Debug.Log($"Exporting assets to: {outputPath}");

            // 如果输出目录已存在，删除它
            if (Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath, true);
            }

            // 创建 Process 对象
            var process = new System.Diagnostics.Process
            {
                StartInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = assetRipperPath,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            try
            {
                // 启动进程
                process.Start();

                // 异步读取输出和错误信息
                string output = await process.StandardOutput.ReadToEndAsync();
                string error = await process.StandardError.ReadToEndAsync();

                // 等待进程结束
                await Task.Run(() => process.WaitForExit());

                // 输出日志
                Debug.Log($"AssetRipper Output:\n{output}");
                if (!string.IsNullOrEmpty(error))
                {
                    Debug.LogError($"AssetRipper Error:\n{error}");
                }

                // 移动 XAPK 文件到输出目录
                File.Move(xapkPath, outputPath + "/" + Path.GetFileName(xapkPath));

                // 在 Finder/Explorer 中显示输出目录
                EditorUtility.RevealInFinder(outputPath);

                // 调用回调，表示成功
                onComplete?.Invoke(true, outputPath);
            }
            catch (Exception e)
            {
                Debug.LogError($"Failed to start AssetRipper: {e.Message}");

                // 调用回调，表示失败
                onComplete?.Invoke(false, e.Message);
            }
            finally
            {
                process.Dispose(); // 释放进程资源
            }
        }
        public void LoadMainAapk()
        {
            if (File.Exists(ApkURL) || File.Exists(ApkURL + ".apk") || File.Exists(ApkURL + ".xapk") )
            {
            }
            else
            {
                if (isLoadMain) return;
                isLoadMain = true;
                loadTime = Time.time;
                url = "https://apk.support/download-app/" + AppID;
                GetApkIdx = -1;
                StartCoroutine(GetApkUrl(), window);
            }
        }
        public void DeleAPK()
        {
            if (File.Exists(ApkURL) || File.Exists(ApkURL + ".apk") || File.Exists(ApkURL + ".xapk") )
            {
                if (ApkURL.EndsWith("apk") == false)
                {
                    if (File.Exists(ApkURL + ".apk"))
                    {
                        ApkURL += ".apk";
                    }
                    else
                    {
                        ApkURL += ".xapk";
                    }
                }
                File.Delete(ApkURL);
            }
        }
        private IEnumerator GetApkUrl()
        {
            WWWForm form = new WWWForm();
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
            WWW www = new WWW(url, null, headers);
            float startTime = Time.realtimeSinceStartup;
            while (!www.isDone)
            {
                yield return null;
                if (Time.realtimeSinceStartup - startTime > 20)
                {
                    www.Dispose(); //Prevent memory leak
                    Debug.LogError("Failed to get web page: Timeout");
                    break;
                }

            }
            if (!string.IsNullOrEmpty(www.error))
            {
                Debug.LogError("Failed to get web page: " + www.error);
                www.Dispose(); //Prevent memory leak
            }
            else
            {
                string htmlContent = www.text;
                ParseXAPKDownloads(htmlContent);
                www.Dispose(); //Prevent memory leak
            }
        }
        public void ParseXAPKDownloads(string htmlContent)
        {
            loadTime = Time.time;
            Debug.Log(loadTime);
            // Regular expression to extract XAPK information.  This is more lenient with whitespace.
            string pattern = @"<a rel=""nofollow noreferrer"" href=""(?<url>.*?)"">\s*" +
                             @"<div class=""downloading_tinfo"">\s*" +
                             @"<div class=""dinfo"">\s*" +
                             @"<div class=""apptitle""><span class=""anameinfo"">(?<appName>.*?)</span></div>\s*" +
                            @"<div class=""apptitle""><span class=""dsizeinfo"">(?<size>.*?)</span>\s*";

            Regex regex = new Regex(pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(htmlContent);

            if (matches.Count > 0)
            {
                Debug.LogError("XApk");

                foreach (Match match in matches)
                {
                    Debug.Log(match.Groups["url"].Value);
                    int targetIndex = GetApkIdx == -1 ? -1 : GetApkIdx;
                    string downloadURL = match.Groups["url"].Value;
                    Size = match.Groups["size"].Value;
                    if (targetIndex == -1) 
                    {
                        StartCoroutine(DownloadAndSaveFile(downloadURL, AppID + ".xapk", (progressValue) => { loadProgress = progressValue; 
                            EditorUtility.SetDirty(window); // 标记窗口已更改
                            window.Repaint();
                            loadTime = Time.time;
                        }), window);
                    }
                    else if (targetIndex > -1) // Historical Version Download
                    {
                        loadProgres[targetIndex] = true;  
                        progress[targetIndex] = 0f;
                        StartCoroutine(DownloadAndSaveFile(downloadURL, names[targetIndex] + ".xapk", (progressValue) => { progress[targetIndex] = progressValue; 
                            EditorUtility.SetDirty(window); 
                            window.Repaint();
                        }), window);
                    }
                    break;
                }
            }
            else
            {
                pattern = @"<a rel=""nofollow noreferrer"" href=""(?<url>.*?)"">\s*" +
                            @"<div class=""downloading_tinfo"">\s*" +
                            @"<div class=""dinfo"">\s*" +
                            @"<div class=""apptitle""><span class=""anameinfo"">(?<appName>.*?)</span></div>\s*" +
                            @"<div class=""apptitle""><span class=""dsizeinfo"">(?<size>.*?)</span>\s*";

                regex = new Regex(pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                matches = regex.Matches(htmlContent);
                Debug.LogError("Apk");
               
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    { // 下面是获取到的资源下载的地址 在下面添加下载的启动代码
                        Debug.Log(match.Groups["url"].Value);
                        Size = match.Groups["size"].Value;
                        int targetIndex = GetApkIdx == -1 ? -1 : GetApkIdx;

                        string downloadURL = match.Groups["url"].Value;

                        if (targetIndex == -1) // Main APK Download
                        {
                            StartCoroutine(DownloadAndSaveFile(downloadURL, AppID + ".apk", (progressValue) => { loadProgress = progressValue; 
                                EditorUtility.SetDirty(window); // 标记窗口已更改
                                window.Repaint();
                                loadTime = Time.time;
                            }), window);
                        }
                        else if (targetIndex > -1) // Historical Version Download
                        {
                            loadProgres[targetIndex] = true; 
                            progress[targetIndex] = 0f;
                            StartCoroutine(DownloadAndSaveFile(downloadURL, names[targetIndex] + ".apk", (progressValue) => 
                            { 
                                progress[targetIndex] = progressValue;
                                EditorUtility.SetDirty(window); // 标记窗口已更改
                                window.Repaint();
                            }), window);
                        }
                        break;
                    }
                }
                else
                {
                    if (GetApkIdx == -1) // Main APK Download
                    {
                        isLoadMain = false;
                    }
                    else if (GetApkIdx > -1)
                    {
                        loadProgres[GetApkIdx] = false;
                    }
                    Debug.LogError("获取下载地址失败");
                }
            }
        }

        private IEnumerator DownloadAndSaveFile(string url, string fileName, Action<float> onProgress)
        {
            string savePath = Path.Combine(ApkEditors.ApkFilePath, fileName);
            if (GetApkIdx > -1)
            {
                var path = Path.Combine(ApkEditors.ApkFilePath, AppID);
                if(Directory.Exists(path) == false)
                {
                    Directory.CreateDirectory(path);
                }
                savePath = Path.Combine(path, fileName);
            }
            Debug.LogError(url);
             loadTime = Time.time;
            using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
            {
                // Set request headers (User-Agent and Referer)
                webRequest.SetRequestHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");
                webRequest.SetRequestHeader("Referer", "https://apk.support/"); // Change to actual website URL if different

                // Set timeout (optional)
                webRequest.timeout = 3000000; // Timeout in seconds

                // Create a download handler for saving to a file.
                DownloadHandlerFile downloadHandler = new DownloadHandlerFile(savePath);
                downloadHandler.removeFileOnAbort = true; // Remove partial file on abort
                webRequest.downloadHandler = downloadHandler;

                // Send the request and get the download progress
                UnityWebRequestAsyncOperation operation = webRequest.SendWebRequest();

                while (!operation.isDone)
                {
                    if (webRequest.result == UnityWebRequest.Result.ConnectionError || webRequest.result == UnityWebRequest.Result.ProtocolError)
                    {
                        Debug.LogError("Download failed: " + webRequest.error);
                        if (onProgress != null) onProgress(0); //Reset progress if error happened
                        isLoadMain = false;
                        if (GetApkIdx > -1)
                        {
                            loadProgres[GetApkIdx] = false; //Removed due to confusing logic, set to false on download start
                        }

                        //Clean up the file
                        downloadHandler.Dispose();
                        if (File.Exists(savePath))
                        {
                            File.Delete(savePath);
                        }
                        yield break;
                    }

                    float progressValue = webRequest.downloadProgress;

                    // Invoke the progress callback
                    onProgress?.Invoke(progressValue);
                    yield return null;
                }

                // Check for errors after the download is complete
                if (webRequest.result == UnityWebRequest.Result.ConnectionError || webRequest.result == UnityWebRequest.Result.ProtocolError)
                {
                    Debug.LogError("Download failed: " + webRequest.error);
                    if (onProgress != null) onProgress(0); //Reset progress if error happened
                   
                    if (GetApkIdx > -1)
                    {
                        loadProgres[GetApkIdx] = false; //Removed due to confusing logic, set to false on download start
                    }
                    else
                    {
                        isLoadMain = false;
                    }

                    //Clean up the file
                    downloadHandler.Dispose();
                    if (File.Exists(savePath))
                    {
                        File.Delete(savePath);
                    }
                    EditorUtility.SetDirty(window); // 标记窗口已更改
                    window.Repaint();
                }
                else
                {
                    Debug.Log("Download complete! File saved to: " + savePath);
                    isLoadMain = false; //Reset flag when main apk has finished downloading
                    EditorUtility.SetDirty(window); // 标记窗口已更改
                    window.Repaint();
                    if (GetApkIdx > -1)
                    {
                        loadProgres[GetApkIdx] = false; //Reset when single apk download has finished.
                    }
                }
            }
        }

        public bool LoadApkURLs()
        {
            if (urls.Count == 0 && isLoadAllUrl == false)
            {
                isLoadAllUrl = true;
                StartCoroutine(LoadApkUrl(), window);
                return false;
            }
            else if (urls.Count == 0)
            {
                return false;
            }
            return true;
        }
        private IEnumerator LoadApkUrl()
        {
            WWWForm form = new WWWForm();
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
            WWW www = new WWW(AppUrl, null, headers);
            float startTime = Time.realtimeSinceStartup;
            while (!www.isDone)
            {
                yield return null;
                if (Time.realtimeSinceStartup - startTime > 20)
                {
                    www.Dispose(); //Prevent memory leak
                    Debug.LogError("Failed to get web page: Timeout");
                    break;
                }

            }
            if (!string.IsNullOrEmpty(www.error))
            {
                Debug.LogError("Failed to get web page: " + www.error);
                www.Dispose(); //Prevent memory leak
            }
            else
            {
                string htmlContent = www.text;
                ParseDownloadTable(htmlContent);
                www.Dispose(); //Prevent memory leak
            }
        }
        public void ParseDownloadTable(string htmlContent)
        {
            names.Clear();
            urls.Clear();
            ApkUrls.Clear();
            progress.Clear();
            loadProgres.Clear();

            string tablePattern = @"<table class=""custom-table"">.*?</table>";
            Regex tableRegex = new Regex(tablePattern, RegexOptions.Singleline);
            Match tableMatch = tableRegex.Match(htmlContent);

            if (tableMatch.Success)
            {
                string tableContent = tableMatch.Value;
                string rowPattern = @"<a href=""(?<url>/download-app/.*?)""[^>]*>(?<text>.*?)</a>";
                Regex rowRegex = new Regex(rowPattern, RegexOptions.Singleline);
                MatchCollection rowMatches = rowRegex.Matches(tableContent);

                if (rowMatches.Count > 0)
                {
                    foreach (Match match in rowMatches)
                    {
                        urls.Add("https://apk.support"+match.Groups["url"].Value);
                        names.Add(match.Groups["text"].Value);
                        ApkUrls.Add(ApkEditors.ApkFilePath+"\\"+AppID+"\\"+ match.Groups["text"].Value);
                        progress.Add(0);
                        loadProgres.Add(false);
                    }
                    window.Save();
                }
            }
            else
            {
                urls.Add("https://apk.support/download-app/" + AppID);
                names.Add("首包");
                Debug.LogWarning("No <table> with class 'custom-table' found.  " + AppUrl);
            }
        }
        private IEnumerator LoadImage()
        {
            ApkURL = ApkEditors.ApkFilePath+"\\"+ AppID;
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
            WWW www = new WWW(ImageUrl, null, headers);
            float startTime = Time.realtimeSinceStartup;
            while (!www.isDone)
            {
                yield return null;
                if (Time.realtimeSinceStartup - startTime > 20)
                {
                    www.Dispose(); //Prevent memory leak
                    Debug.LogError("Failed to load image: Timeout");
                    ImageTexture = Texture2D.blackTexture;
                    break;
                }

            }
            if (!string.IsNullOrEmpty(www.error))
            {
                Debug.LogError("Failed to load image: " + www.error);
                ImageTexture = Texture2D.blackTexture; // Assign a default black texture
                www.Dispose(); //Prevent memory leak
            }
            else
            {
                ImageTexture = www.texture;
                www.Dispose(); //Prevent memory leak
            }
        }
        private ApkEditors window;
        public void Load(ApkEditors editor)
        {
            window = editor;
            StartCoroutine(LoadImage(), editor);
        }
        private EditorCoroutineInstance StartCoroutine(IEnumerator coroutine, EditorWindow editorWindow)
        {
            var instance = new EditorCoroutineInstance(coroutine, editorWindow);
            instance.Start();
            return instance;
        }
    }


    [System.Serializable]
    public class ApkInfos
    {
        public List<ApkInfo> apkList = new List<ApkInfo>();
    }
    [System.Serializable]
    public class ApkGJ
    {

    }
    public class ApkEditors : EditorWindow
    {
        public static string apkName = "Ball Sort";
        private string url = "https://apk.support/search";
        private List<ApkInfo> apkList = new List<ApkInfo>();
        private Vector2 scrollPosition;
        private string downloadUrl = "https://apk.support";
        public static string ApkFilePath
        {
            get
            {
                var path = Path.GetDirectoryName(Path.GetDirectoryName(Application.dataPath)) + "/" + "GamePlayDemos/" + apkName;
                if (Directory.Exists(path) == false)
                {
                    Directory.CreateDirectory(path);
                }
                return path;
            }
        }
        [MenuItem("Tools/Novel List Fetcher")]
        public static void ShowWindow()
        {
            var text = GetWindow<ApkEditors>("Novel List Fetcher");
            text.minSize = new Vector2(400, 630);
            text.maxSize = new Vector2(400, 630);
        }
        private int loadIdx = 0;
        private void OnGUI()
        {
            GUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("APKName", GUILayout.Width(60));
            apkName = EditorGUILayout.TextField(apkName);
            GUILayout.EndHorizontal();
            if (GUILayout.Button("获取APK 列表"))
            {
                loadIdx = 0;
                apkList.Clear();
                StartCoroutine(FetchAndParseCoroutine(), this);
            }
            if(IsApkInfos)
            {
                GUILayout.BeginHorizontal();
                if (GUILayout.Button("加载本地"))
                {
                    LoadApkInfo();
                }
                if(GUILayout.Button("保存数据"))
                {
                    Save();
                }
                if(GUILayout.Button("获取Ai提问数据"))
                {
                    var AiData = "下面是我想知道的所有的App的Id名字列表{\n";
                    foreach(var apk in apkList)
                    {
                        AiData += apk.AppID+"\n";
                    }
                    AiData += "}\n,我想知道这些根据这些app的id是否可以获取到所有的公司与公司地址帮我进行分类用json格式输出 格式如下:\n{appid,gs=公司名字,gj=国家地址}";
                    GUIUtility.systemCopyBuffer = AiData;
                }
                if(GUILayout.Button("粘贴板数据提取到国家"))
                {
                    var data = GUIUtility.systemCopyBuffer;

                }
                GUILayout.EndHorizontal();
            }
            
            if (apkList.Count > 0)
            {
                GUILayout.BeginHorizontal();
                if (GUILayout.Button("下载所有的"))
                {
                    for (var x = 0; x < apkList.Count; x++)
                    {
                        apkList[x].LoadMainAapk();
                    }
                }
                if(GUILayout.Button("删除所有APK包"))
                {
                    for (var x = 0; x < apkList.Count; x++)
                    {
                        apkList[x].DeleAPK();
                    }
                }
                if (GUILayout.Button("导出所有的包"))
                {
                    for (var x = 0; x < apkList.Count; x++)
                    {
                        apkList[x].ExportDeom();
                    }
                }
                GUILayout.EndHorizontal();
                
            }

            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, GUILayout.Height(550));
            foreach (ApkInfo apk in apkList)
            {
                apk.ShowGUI();
            }
            EditorGUILayout.EndScrollView();
        }
        
        private IEnumerator FetchAndParseCoroutine()
        {
            float startTime = Time.realtimeSinceStartup;
            string encodedApkName = System.Uri.EscapeDataString(apkName); // URL encode the apk name
            string requestUrl = $"{url}?q={encodedApkName}";
            Debug.Log(requestUrl);
            using (UnityWebRequest www = UnityWebRequest.Get(requestUrl))
            {
                www.timeout = 20; // 设置超时时间

                // 添加 User-Agent 头信息 (有时可以解决 403 错误)
                www.SetRequestHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36"); // 更新 User-Agent

                yield return www.SendWebRequest();
                while (!www.isDone)
                {
                    yield return null;
                    if (Time.realtimeSinceStartup - startTime > 20)
                    {
                        www.Dispose(); //Prevent memory leak
                        Debug.LogError("Failed to get web page: Timeout");
                        break;
                    }

                }
                if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
                {
                    Debug.LogError($"Failed to get web page: {www.error}");
                }
                else
                {
                    string htmlContent = www.downloadHandler.text;
                    ParseHtml(htmlContent);
                }
            }
        }

        private void ParseHtml(string htmlContent)
        {
            string pattern = @"<a href=""(?<app_url>/app/.*?)"" title=""(?<title>.*?) APK"">.*?<div class=""seo_img"">.*?<img.*?data-src=""(?<image_url>.*?)""";

            Regex regex = new Regex(pattern, RegexOptions.Singleline);
            MatchCollection matches = regex.Matches(htmlContent);

            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    ApkInfo apkInfo = new ApkInfo();
                    apkInfo.AppUrl = downloadUrl + match.Groups["app_url"].Value;
                    apkInfo.ImageUrl = match.Groups["image_url"].Value;
                    apkInfo.Title = match.Groups["title"].Value;

                    apkList.Add(apkInfo);
                    apkInfo.Load(this);
                }
                Save();
            }
            else
            {
                Debug.LogWarning("No APK entries found in the HTML.");
            }
            EditorUtility.SetDirty(this);
            this.Repaint();
        }


        public EditorCoroutineInstance StartCoroutine(IEnumerator coroutine, EditorWindow editorWindow)
        {
            var instance = new EditorCoroutineInstance(coroutine, editorWindow);
            instance.Start();
            return instance;
        }
        public bool IsApkInfos
        {
            get
            {
                if (File.Exists(ApkFilePath + "/" + apkName + ".json"))
                {
                    return true;
                }
                return false;
            }
        }
        public bool LoadApkInfo()
        {
            if(IsApkInfos)
            {
                var infos = JsonUtility.FromJson<ApkInfos>(File.ReadAllText(ApkFilePath + "/" + apkName + ".json"));
                apkList.Clear();
                apkList.AddRange(infos.apkList);
                foreach(var apk in apkList)
                {
                    apk.Load(this);
                }
            }
            return false;
        }
        public void Save()
        {
            ApkInfos infos = new ApkInfos();
            infos.apkList.AddRange(apkList);
            File.WriteAllText(ApkFilePath + "/" + apkName + ".json", JsonUtility.ToJson(infos));
        }
    }
   
    #region 异步方法
    public class IgnoreCertificateErrorHandler : CertificateHandler
    {
        protected override bool ValidateCertificate(byte[] certificateData)
        {
            return true;
        }
    }
    public class EditorCoroutineInstance
    {
        private readonly IEnumerator _coroutine;
        private readonly EditorWindow _editorWindow;
        private readonly MonoScript _monoScript;

        private bool _isRunning;
        private bool _isStopped;

        public bool IsRunning { get { return _isRunning; } }

        private static readonly Queue<EditorCoroutineInstance> _coroutineQueue = new Queue<EditorCoroutineInstance>();
        private static bool _isQueueProcessing = false;
        private static float _lastCoroutineEndTime = 0f;
        private static float _executionInterval = 0.06f; // Interval between coroutine starts in seconds

        public EditorCoroutineInstance(IEnumerator coroutine, EditorWindow editorWindow)
        {
            _coroutine = coroutine;
            _editorWindow = editorWindow;
            _monoScript = null;
        }

        public EditorCoroutineInstance(IEnumerator coroutine, MonoScript monoScript)
        {
            _coroutine = coroutine;
            _editorWindow = null;
            _monoScript = monoScript;
        }

        public void Start()
        {
            // Check if the last coroutine ended less than the interval ago
            if (Time.realtimeSinceStartup - _lastCoroutineEndTime < _executionInterval)
            {
                // Enqueue the coroutine
                _coroutineQueue.Enqueue(this);
            }
            else
            {
                // Start the coroutine immediately
                StartCoroutineInternal();
            }

            // Ensure EditorUpdate is running
            if (!_isQueueProcessing)
            {
                _isQueueProcessing = true;
                EditorApplication.update += EditorUpdateQueue;
            }
        }

        private void StartCoroutineInternal()
        {
            if (_editorWindow == null) return;
            if (_isRunning)
            {
                Debug.LogWarning("Coroutine already running.");
                return;
            }

            _isRunning = true;
            _isStopped = false;  // Reset isStopped when starting.

            if (_editorWindow != null)
            {
                EditorApplication.update += EditorUpdateSingle;
            }
            else if (_monoScript != null)
            {
                EditorApplication.update += EditorUpdateSingle;
            }
            else
            {
                Debug.LogError("Coroutine has no target (EditorWindow or MonoScript), stopping.");
                Stop();
            }
        }

        public void Stop()
        {
            if (!_isRunning)
                return;

            _isRunning = false;
            _isStopped = true;
            if (_editorWindow != null)
                EditorApplication.update -= EditorUpdateSingle;
            if (_monoScript != null)
                EditorApplication.update -= EditorUpdateSingle;

            _lastCoroutineEndTime = Time.realtimeSinceStartup;

            //if queue is empty, remove EditorUpdateQueue;
            if (_coroutineQueue.Count == 0)
            {
                EditorApplication.update -= EditorUpdateQueue;
                _isQueueProcessing = false;
            }

        }

        //Single coroutine execution update loop
        private void EditorUpdateSingle()
        {
            if (!_isRunning || _coroutine == null)
                return;

            try
            {
                if (!_coroutine.MoveNext())
                {
                    Stop();
                }
            }
            catch (Exception e)
            {
                Debug.LogException(e);
                Stop();
            }
        }

        //Checks if is time to execute a new coroutine from the queue
        private static void EditorUpdateQueue()
        {

            if (_coroutineQueue.Count == 0)
            {
                EditorApplication.update -= EditorUpdateQueue;
                _isQueueProcessing = false;
                return;
            }

            if (Time.realtimeSinceStartup - _lastCoroutineEndTime >= _executionInterval)
            {
                EditorCoroutineInstance instance = _coroutineQueue.Dequeue(); // Get the next coroutine and remove it from queue

                if (instance != null)
                {
                    instance.StartCoroutineInternal();
                }
            }
        }
    }
    #endregion
    public static class ZipFileHelper
    {
        /// <summary>
        /// 检查 ZIP 文件是否包含指定文件名，而不进行解压.
        /// </summary>
        /// <param name="zipFilePath">ZIP 文件的完整路径.</param>
        /// <param name="targetFileName">要查找的目标文件名 (例如: "MyFile.txt").</param>
        /// <returns>如果找到目标文件，则返回 true；否则返回 false.</returns>
        public static bool CheckZipFileContainsTarget(string zipFilePath, string targetFileName)
        {
            if (!File.Exists(zipFilePath))
            {
                Debug.LogError("ZIP file not found: " + zipFilePath);
                return false;
            }

            try
            {
                using (ZipArchive archive = ZipFile.OpenRead(zipFilePath))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        if (entry.Name == targetFileName)
                        {
                            //Debug.Log("Found target file: " + targetFileName + " in ZIP archive.");
                            return true;
                        }
                        else if (entry.Name.EndsWith(".apk", StringComparison.OrdinalIgnoreCase)) // 忽略大小写比较
                        {
                            // 处理嵌入的 APK 文件
                            using (Stream apkStream = entry.Open())
                            {
                                if (CheckApkStreamForTarget(apkStream, targetFileName))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }

                //Debug.Log("Target file not found: " + targetFileName + " in ZIP archive.");
                return false;
            }
            catch (Exception e)
            {
                Debug.LogError("Error processing ZIP file: " + e.Message);
                return false;
            }
        }

        /// <summary>
        /// 检查 APK 文件流中是否包含指定文件名。
        /// </summary>
        /// <param name="apkStream">APK 文件的流.</param>
        /// <param name="targetFileName">要查找的目标文件名.</param>
        /// <returns>如果找到目标文件，则返回 true；否则返回 false.</returns>
        private static bool CheckApkStreamForTarget(Stream apkStream, string targetFileName)
        {
            try
            {
                using (ZipArchive apkArchive = new ZipArchive(apkStream, ZipArchiveMode.Read))
                {
                    foreach (ZipArchiveEntry apkEntry in apkArchive.Entries)
                    {
                        if (apkEntry.Name == targetFileName)
                        {
                            //Debug.Log("Found target file: " + targetFileName + " in APK archive.");
                            return true;
                        }
                    }
                }
                //Debug.Log("Target file not found in APK archive.");
                return false;
            }
            catch (Exception e)
            {
                Debug.LogError("Error processing APK archive: " + e.Message);
                return false;
            }
        }


        /// <summary>
        /// 在指定目录及其子目录中搜索 ZIP 文件，并检查它们是否包含特定文件。
        /// </summary>
        /// <param name="searchDirectory">要搜索的根目录。</param>
        /// <param name="targetFileName">要查找的文件名（例如："unity default resources"）。</param>
        /// <returns>如果找到目标文件，则返回 true，否则返回 false。</returns>
        public static bool SearchZipFilesForTarget(string searchDirectory, string targetFileName)
        {
            if (!Directory.Exists(searchDirectory))
            {
                Debug.LogError("Directory not found: " + searchDirectory);
                return false;
            }

            string[] zipFiles = Directory.GetFiles(searchDirectory, "*.zip", SearchOption.AllDirectories);

            foreach (string zipFile in zipFiles)
            {
                if (CheckZipFileContainsTarget(zipFile, targetFileName))
                {
                    return true; // 找到了，直接返回
                }
            }

            return false; // 没有找到
        }

        /// <summary>
        /// 解压指定的 ZIP 文件到指定目录。
        /// </summary>
        /// <param name="zipFilePath">ZIP 文件的完整路径。</param>
        /// <param name="extractPath">要解压到的目标目录。</param>
        /// <param name="overwriteFiles">指示是否覆盖现有文件的标志。默认为 false。</param>
        public static void ExtractZipFile(string zipFilePath, string extractPath, bool overwriteFiles = false)
        {
            if (!File.Exists(zipFilePath))
            {
                Debug.LogError("ZIP file not found: " + zipFilePath);
                return;
            }

            if (!Directory.Exists(extractPath))
            {
                Directory.CreateDirectory(extractPath);
            }

            try
            {
                using (ZipArchive archive = ZipFile.OpenRead(zipFilePath))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        string fullPath = Path.Combine(extractPath, entry.FullName);

                        // 确保目录存在
                        string directoryPath = Path.GetDirectoryName(fullPath);
                        if (!string.IsNullOrEmpty(directoryPath) && !Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }

                        if (string.IsNullOrEmpty(entry.Name)) // 如果是目录条目，则跳过（ZipArchive 已经创建了目录）
                            continue;

                        if (File.Exists(fullPath) && !overwriteFiles)
                        {
                            Debug.LogWarning("File already exists: " + fullPath + ". Skipping extraction.  Set overwriteFiles to true to overwrite.");
                            continue;
                        }

                        entry.ExtractToFile(fullPath, overwriteFiles);

                        //Debug.Log("Extracted: " + entry.FullName + " to " + fullPath);
                    }
                }
                Debug.Log("Successfully extracted ZIP file to: " + extractPath);
            }
            catch (Exception e)
            {
                Debug.LogError("Error extracting ZIP file: " + e.Message);
            }
        }

        /// <summary>
        /// 解压指定的 ZIP 文件到指定目录，解压后删除 ZIP 文件。
        /// </summary>
        /// <param name="zipFilePath">ZIP 文件的完整路径。</param>
        /// <param name="extractPath">要解压到的目标目录。</param>
        /// <param name="overwriteFiles">指示是否覆盖现有文件的标志。默认为 false。</param>
        public static void ExtractZipFileAndDelete(string zipFilePath, string extractPath, bool overwriteFiles = false)
        {
            ExtractZipFile(zipFilePath, extractPath, overwriteFiles);

            try
            {
                File.Delete(zipFilePath);
                Debug.Log("Successfully deleted ZIP file: " + zipFilePath);
            }
            catch (Exception e)
            {
                Debug.LogError("Error deleting ZIP file: " + e.Message);
            }
        }

    }
}