using System;
using System.Text;
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;


public class ChineseConvertTool
{
    private const int LOCALE_SYSTEM_DEFAULT = 0x0800;
    private const int LCMAP_SIMPLIFIED_CHINESE = 0x0002;
    private const int LCMAP_TRADITIONAL_CHINESE = 0x0008;

    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern int LCMapString(int Locale, int dwMapFlags, string lpSrcStr, int cchSrc, StringBuilder lpDestStr, int cchDest);

    public static string ConvertToSimplified(string traditional)
    {
        StringBuilder sb = new StringBuilder();
        int len = LCMapString(LOCALE_SYSTEM_DEFAULT, LCMAP_SIMPLIFIED_CHINESE, traditional, traditional.Length, sb, sb.Capacity);
        return sb.ToString();
    }

    public static string ConvertToTraditional(string simplified)
    {
        StringBuilder sb = new StringBuilder();
        int len = LCMapString(LOCALE_SYSTEM_DEFAULT, LCMAP_TRADITIONAL_CHINESE, simplified, simplified.Length, sb, sb.Capacity);
        return sb.ToString();
    }
}

