using System;
using System.IO;
using System.Text;
using UnityEngine;

public static class BOEMOLDHCJC
{
	public static bool GMGIINAJJMK(string CGHOFPJMKFM, string MBBPBGHKLJM)
	{
		try
		{
			string path = Application.persistentDataPath + "/" + CGHOFPJMKFM + ".loc";
			File.WriteAllText(path, MBBPBGHKLJM, Encoding.UTF8);
			return true;
		}
		catch (Exception)
		{
			Debug.LogError("Error saving file " + CGHOFPJMKFM);
			return false;
		}
	}

	public static string JIKNLJNFPFG(string CGHOFPJMKFM)
	{
		try
		{
			string path = Application.persistentDataPath + "/" + CGHOFPJMKFM + ".loc";
			return File.ReadAllText(path, Encoding.UTF8);
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void GIOCEEGBFKL(string CGHOFPJMKFM)
	{
		try
		{
			string path = Application.persistentDataPath + "/" + CGHOFPJMKFM + ".loc";
			File.Delete(path);
		}
		catch (Exception)
		{
		}
	}
}
