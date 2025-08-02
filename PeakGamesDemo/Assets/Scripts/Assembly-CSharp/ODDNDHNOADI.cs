using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;

public class ODDNDHNOADI
{
	private const int NIFFALJKFCA = 0;

	private const int OOABINMMLIM = 100;

	private const int IHKBNNIOLKG = 101;

	private const int MLIALPCLFLG = 1;

	private const int KAMANFLGJCH = 2;

	private const int DKJEHIAFBFI = 3;

	private const int OHJGGJHNIND = 4;

	private const int JPNPLCBMIFO = 5;

	public const int IKGJLDOFECH = -2;

	public const int AEIPBOIBGPB = -1;

	private readonly bool BHNPEJOCCCP = true;

	private readonly string JNGNMIOMFBJ;

	private IntPtr ADMBPFDAJOA;

	private bool JFJLDNGACNC { get; set; }

	public ODDNDHNOADI(string JKMOJDFHELN, string MKAKJFFNFOM)
	{
		JNGNMIOMFBJ = MKAKJFFNFOM;
		string text = Path.Combine(Application.streamingAssetsPath, JKMOJDFHELN);
		if (File.Exists(JNGNMIOMFBJ))
		{
			return;
		}
		if (text.Contains("://"))
		{
			WWW wWW = new WWW(text);
			while (!wWW.isDone)
			{
			}
			if (string.IsNullOrEmpty(wWW.error))
			{
				File.WriteAllBytes(JNGNMIOMFBJ, wWW.bytes);
			}
			else
			{
				BHNPEJOCCCP = false;
			}
		}
		else if (File.Exists(text))
		{
			File.Copy(text, JNGNMIOMFBJ, true);
		}
		else
		{
			BHNPEJOCCCP = false;
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.DatabaseManager, "ERROR: the file DB named " + JKMOJDFHELN + " doesn't exist in the StreamingAssets Folder, please copy it there.");
		}
	}

	public void NKKOEHGDNKD()
	{
		if (JFJLDNGACNC)
		{
			LCCKKDKBOEN(ADMBPFDAJOA);
		}
		JFJLDNGACNC = false;
	}

	public void OMBKLCBCMGP(string HKCKEACCMMA)
	{
		if (!BHNPEJOCCCP)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.DatabaseManager, "ERROR: Can't execute the query, verify DB origin file");
			return;
		}
		PDCIEICKKIL();
		if (!JFJLDNGACNC)
		{
			throw new MHDGEFBACLA(-1, "SQLite database is not open.");
		}
		IntPtr lNONHPBOJOB = JIMBAPGACIJ(HKCKEACCMMA);
		int num = ONAEHNIFLEM(lNONHPBOJOB);
		if (num != 101)
		{
			int num2 = LKEALELJHHH(ADMBPFDAJOA);
			throw new MHDGEFBACLA(num2, "Could not execute SQL statement.(" + num + ") ErrorCode:" + num2);
		}
		GMLAAHJKCJF(lNONHPBOJOB);
	}

	public MBBJJJGFIKD KLGGEBEDDJJ(string HKCKEACCMMA)
	{
		if (!BHNPEJOCCCP)
		{
			return null;
		}
		MBBJJJGFIKD mBBJJJGFIKD = new MBBJJJGFIKD();
		PDCIEICKKIL();
		if (!JFJLDNGACNC)
		{
			throw new MHDGEFBACLA(-1, "SQLite database is not open.");
		}
		IntPtr lNONHPBOJOB = JIMBAPGACIJ(HKCKEACCMMA);
		int num = KPCDCOBFNNN(lNONHPBOJOB);
		for (int i = 0; i < num; i++)
		{
			string item = Marshal.PtrToStringAnsi(FHJJLEMMAFM(lNONHPBOJOB, i));
			mBBJJJGFIKD.LDEJFNHFMCI.Add(item);
		}
		while (ONAEHNIFLEM(lNONHPBOJOB) == 100)
		{
			object[] array = new object[num];
			for (int j = 0; j < num; j++)
			{
				switch (MJEBDGBPACI(lNONHPBOJOB, j))
				{
				case 1:
					array[j] = ODAEBOPHKOP(lNONHPBOJOB, j);
					break;
				case 3:
				{
					IntPtr ptr = KCMAMMEAPMJ(lNONHPBOJOB, j);
					array[j] = Marshal.PtrToStringAnsi(ptr);
					break;
				}
				case 2:
					array[j] = DIIAOKOPCLO(lNONHPBOJOB, j);
					break;
				case 4:
				{
					IntPtr source = IHEIGABPAPC(lNONHPBOJOB, j);
					int num2 = NBEBFEMLIGL(lNONHPBOJOB, j);
					byte[] array2 = new byte[num2];
					Marshal.Copy(source, array2, 0, num2);
					array[j] = array2;
					break;
				}
				case 5:
					array[j] = null;
					break;
				}
			}
			mBBJJJGFIKD.EFECDJHHKPP(array);
		}
		GMLAAHJKCJF(lNONHPBOJOB);
		return mBBJJJGFIKD;
	}

	[DllImport("sqlite3", EntryPoint = "sqlite3_errcode")]
	internal static extern int CMLHKOKLFBO(IntPtr MCJLPIPNPGJ);

	[DllImport("sqlite3", EntryPoint = "sqlite3_extended_errcode")]
	internal static extern int LKEALELJHHH(IntPtr MCJLPIPNPGJ);

	[DllImport("sqlite3", EntryPoint = "sqlite3_changes")]
	internal static extern int DDJAONNGOKA(IntPtr MCJLPIPNPGJ);

	[DllImport("sqlite3", EntryPoint = "sqlite3_open")]
	private static extern int HNNEGOINAJJ(string CCKEDMJMOJD, out IntPtr MCJLPIPNPGJ);

	[DllImport("sqlite3", EntryPoint = "sqlite3_close")]
	private static extern int LCCKKDKBOEN(IntPtr MCJLPIPNPGJ);

	[DllImport("sqlite3", EntryPoint = "sqlite3_prepare_v2")]
	private static extern int IOEEAFKPEOB(IntPtr MCJLPIPNPGJ, string IDIELEGJJCE, int OFOIFHKEGCG, out IntPtr KGGOFBOHIKL, IntPtr HOBHGDJFOEM);

	[DllImport("sqlite3", EntryPoint = "sqlite3_step")]
	private static extern int ONAEHNIFLEM(IntPtr LNONHPBOJOB);

	[DllImport("sqlite3", EntryPoint = "sqlite3_finalize")]
	private static extern int DBLPODAKJEH(IntPtr LNONHPBOJOB);

	[DllImport("sqlite3", EntryPoint = "sqlite3_errmsg")]
	private static extern IntPtr LKBJPLKBMLF(IntPtr MCJLPIPNPGJ);

	[DllImport("sqlite3", EntryPoint = "sqlite3_column_count")]
	private static extern int KPCDCOBFNNN(IntPtr LNONHPBOJOB);

	[DllImport("sqlite3", EntryPoint = "sqlite3_column_name")]
	private static extern IntPtr FHJJLEMMAFM(IntPtr LNONHPBOJOB, int CBDNFCOBIOM);

	[DllImport("sqlite3", EntryPoint = "sqlite3_column_type")]
	private static extern int MJEBDGBPACI(IntPtr LNONHPBOJOB, int CBDNFCOBIOM);

	[DllImport("sqlite3", EntryPoint = "sqlite3_column_int")]
	private static extern int ODAEBOPHKOP(IntPtr LNONHPBOJOB, int CBDNFCOBIOM);

	[DllImport("sqlite3", EntryPoint = "sqlite3_column_text")]
	private static extern IntPtr KCMAMMEAPMJ(IntPtr LNONHPBOJOB, int CBDNFCOBIOM);

	[DllImport("sqlite3", EntryPoint = "sqlite3_column_double")]
	private static extern double DIIAOKOPCLO(IntPtr LNONHPBOJOB, int CBDNFCOBIOM);

	[DllImport("sqlite3", EntryPoint = "sqlite3_column_blob")]
	private static extern IntPtr IHEIGABPAPC(IntPtr LNONHPBOJOB, int CBDNFCOBIOM);

	[DllImport("sqlite3", EntryPoint = "sqlite3_column_bytes")]
	private static extern int NBEBFEMLIGL(IntPtr LNONHPBOJOB, int CBDNFCOBIOM);

	private IntPtr JIMBAPGACIJ(string HKCKEACCMMA)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(HKCKEACCMMA);
		int oFOIFHKEGCG = bytes.Length;
		IntPtr KGGOFBOHIKL;
		int num = IOEEAFKPEOB(ADMBPFDAJOA, HKCKEACCMMA, oFOIFHKEGCG, out KGGOFBOHIKL, IntPtr.Zero);
		if (num != 0)
		{
			IntPtr ptr = LKBJPLKBMLF(ADMBPFDAJOA);
			throw new MHDGEFBACLA(num, Marshal.PtrToStringAnsi(ptr) + " FullQuery=|" + HKCKEACCMMA + "|");
		}
		return KGGOFBOHIKL;
	}

	private static void GMLAAHJKCJF(IntPtr LNONHPBOJOB)
	{
		int num = DBLPODAKJEH(LNONHPBOJOB);
		if (num != 0)
		{
			throw new MHDGEFBACLA(num, "Could not finalize SQL statement.");
		}
	}

	private void PDCIEICKKIL()
	{
		if (!JFJLDNGACNC)
		{
			PDCIEICKKIL(JNGNMIOMFBJ);
		}
	}

	private void PDCIEICKKIL(string LCCKDPIBKPJ)
	{
		int num = HNNEGOINAJJ(LCCKDPIBKPJ, out ADMBPFDAJOA);
		if (num != 0)
		{
			throw new MHDGEFBACLA(num, "Could not open database file: " + LCCKDPIBKPJ);
		}
		JFJLDNGACNC = true;
	}
}
