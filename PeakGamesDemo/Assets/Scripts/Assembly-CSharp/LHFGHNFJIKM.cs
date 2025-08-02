using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Security;

internal abstract class LHFGHNFJIKM
{
	private static readonly CompareInfo AHKJFPOACAI = CultureInfo.InvariantCulture.CompareInfo;

	internal static readonly string IAHDCIONPPF = KFGMHOKHCGD();

	private static string KFGMHOKHCGD()
	{
		return Environment.NewLine;
	}

	internal static bool CCEFNPKGKMA(string MNIMEAMHNMI, string BCIHLCMFAEK)
	{
		return string.Compare(MNIMEAMHNMI, BCIHLCMFAEK, StringComparison.OrdinalIgnoreCase) == 0;
	}

	internal static string IOBDBEEBKEA(string MLJAHFGMIDJ)
	{
		try
		{
			return Environment.GetEnvironmentVariable(MLJAHFGMIDJ);
		}
		catch (SecurityException)
		{
			return null;
		}
	}

	internal static Exception HOAJHBJIAIC(string OEFCOJLNCKP)
	{
		return new NotImplementedException(OEFCOJLNCKP);
	}

	internal static IList PPPFFFBMGML()
	{
		return new ArrayList();
	}

	internal static IList PPPFFFBMGML(int MDPEMCMPAMB)
	{
		return new ArrayList(MDPEMCMPAMB);
	}

	internal static IList PPPFFFBMGML(ICollection GDOLNBCOCDC)
	{
		return new ArrayList(GDOLNBCOCDC);
	}

	internal static IList PPPFFFBMGML(IEnumerable GDOLNBCOCDC)
	{
		ArrayList arrayList = new ArrayList();
		foreach (object item in GDOLNBCOCDC)
		{
			arrayList.Add(item);
		}
		return arrayList;
	}

	internal static IDictionary JBEOCJEMGCE()
	{
		return new Hashtable();
	}

	internal static IDictionary JBEOCJEMGCE(int MDPEMCMPAMB)
	{
		return new Hashtable(MDPEMCMPAMB);
	}

	internal static IDictionary JBEOCJEMGCE(IDictionary EAPGOBAJLJE)
	{
		return new Hashtable(EAPGOBAJLJE);
	}

	internal static string PHIJGAFNHBF(string IBBBMACIBGK)
	{
		return IBBBMACIBGK.ToLower(CultureInfo.InvariantCulture);
	}

	internal static string OGLCLCODHJI(string IBBBMACIBGK)
	{
		return IBBBMACIBGK.ToUpper(CultureInfo.InvariantCulture);
	}

	internal static void PCHCAFHEJJM(Stream IBBBMACIBGK)
	{
		IBBBMACIBGK.Close();
	}

	internal static void PCHCAFHEJJM(TextWriter LLIEHCKNJEM)
	{
		LLIEHCKNJEM.Close();
	}

	internal static int NFLFPHCMIOK(string JKHLMLIANAI, string EDDNOJDPMCF)
	{
		return AHKJFPOACAI.IndexOf(JKHLMLIANAI, EDDNOJDPMCF, CompareOptions.Ordinal);
	}

	internal static int MCHNHOKOCIL(string JKHLMLIANAI, string EDDNOJDPMCF)
	{
		return AHKJFPOACAI.LastIndexOf(JKHLMLIANAI, EDDNOJDPMCF, CompareOptions.Ordinal);
	}

	internal static bool GNEPOHDBAEJ(string JKHLMLIANAI, string AEKIHILHNPD)
	{
		return AHKJFPOACAI.IsPrefix(JKHLMLIANAI, AEKIHILHNPD, CompareOptions.Ordinal);
	}

	internal static bool BGIBPBNIHDL(string JKHLMLIANAI, string AAMFHHPNFNG)
	{
		return AHKJFPOACAI.IsSuffix(JKHLMLIANAI, AAMFHHPNFNG, CompareOptions.Ordinal);
	}

	internal static string JKHOEKAOLPM(object NEMEKIOEOLC)
	{
		return NEMEKIOEOLC.GetType().FullName;
	}
}
