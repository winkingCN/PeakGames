using System;
using System.Security.Cryptography;
using System.Text;

public class MJJHFBBMHAO
{
	public const string BOMAJGOJHGF = "ToonRocks";

	public const string MPBDOLPCPLI = "ToonRocksFun";

	public static string CJENHJMDHFN(string GIIPDDDFAMO)
	{
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		byte[] bytes = uTF8Encoding.GetBytes(GIIPDDDFAMO);
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array = mD5CryptoServiceProvider.ComputeHash(bytes);
		string text = string.Empty;
		for (int i = 0; i < array.Length; i++)
		{
			text += Convert.ToString(array[i], 16).PadLeft(2, '0');
		}
		return text.PadLeft(32, '0');
	}
}
