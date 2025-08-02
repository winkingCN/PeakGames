using System.Collections;

public class LLINHKMIBFP
{
	public const int DGEFLFACBGC = 188;

	public const int ENMNLALPOJB = 12748;

	public const int KPAFAJKLCJM = 13004;

	public const int CEOOPPKFPHN = 13260;

	public const int PLADFCIAGKA = 13516;

	public const int HCIMKPBDMDM = 13772;

	public const int OPCIBCMDCCF = 14028;

	public const int NGIAAOJNPJI = 14284;

	public const int BEJAOMNHOBB = 14540;

	public const int KJECJMHFDLN = 14796;

	public const int ENDPEDJMHHO = 16588;

	private static readonly IDictionary CDAGFKJOJJI = DHPIKEBEHNA();

	private static IDictionary DHPIKEBEHNA()
	{
		IDictionary dictionary = LHFGHNFJIKM.JBEOCJEMGCE();
		dictionary.Add("RIPEMD128", 13004);
		dictionary.Add("RIPEMD160", 12748);
		dictionary.Add("SHA-1", 13260);
		dictionary.Add("SHA-224", 14540);
		dictionary.Add("SHA-256", 13516);
		dictionary.Add("SHA-384", 14028);
		dictionary.Add("SHA-512", 13772);
		dictionary.Add("SHA-512/224", 14796);
		dictionary.Add("SHA-512/256", 16588);
		dictionary.Add("Whirlpool", 14284);
		return FKHLBMJPCIM.PNHDAKINPLD(dictionary);
	}

	public static int LFDPFEKIKII(BJLAMONNNDD HABFKBCEIBN)
	{
		return (int)CDAGFKJOJJI[HABFKBCEIBN.KFKMEPMEBND];
	}

	public static bool PMLGCANEMIO(BJLAMONNNDD HABFKBCEIBN)
	{
		return !CDAGFKJOJJI.Contains(HABFKBCEIBN.KFKMEPMEBND);
	}
}
