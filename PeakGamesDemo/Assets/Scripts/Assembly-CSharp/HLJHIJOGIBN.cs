public static class HLJHIJOGIBN
{
	public static string LKHOELJMLID = "Store";

	public const string AKEGGHMKGNP = "KeyHighestBoughtPackage";

	public const string IAABOHIGNKA = "KeyHighestBoughtBundleNo";

	public const string NDECBMDIJAC = "Store";

	public const string EBGODEKPFGA = "Life";

	public const string MILOGCABBFM = "EGO-1";

	public const string JAOHBALAHEL = "EGO-2";

	public const string ELNINPLEFOJ = "EGO-3";

	public const string MFEAGMHKKGL = "EGO-4";

	public const string FMPCJKKIPPI = "EGO-5";

	public const string IAOIIMJGEKN = "Hammer";

	public const string FAJHEOLMFGO = "BoxingGlove";

	public const string MCKGOJDEDMK = "Anvil";

	public const string HJMMKIAFHEC = "Dice";

	public const string DMCODDEFKCD = "Rocket";

	public const string CDNPKPOBEKD = "Bomb";

	public const string PNIFPANHGDD = "DiscoBall";

	public const string FAMAJLMJAJL = "Offer";

	public const string IFLAIKOBJCJ = "UnlimitedLives";

	public const string JCHLAGJGGDF = "TeamCreate";

	public const string PBJCOFPHHDN = "Retry";

	public static string DAHOEMOBBKF(int NCOHJPBDDKB)
	{
		switch (NCOHJPBDDKB)
		{
		case 1:
			return "EGO-1";
		case 2:
			return "EGO-2";
		case 3:
			return "EGO-3";
		case 4:
			return "EGO-4";
		default:
			return (NCOHJPBDDKB < 5) ? null : "EGO-5";
		}
	}

	public static string PMHLLJMKMBK(NAAHKHPBAPA GEKKLIKPAPP)
	{
		string result = string.Empty;
		switch (GEKKLIKPAPP)
		{
		case NAAHKHPBAPA.Hammer:
			result = "Hammer";
			break;
		case NAAHKHPBAPA.Anvil:
			result = "Anvil";
			break;
		case NAAHKHPBAPA.BoxingGlove:
			result = "BoxingGlove";
			break;
		case NAAHKHPBAPA.Rocket:
			result = "Rocket";
			break;
		case NAAHKHPBAPA.Bomb:
			result = "Bomb";
			break;
		case NAAHKHPBAPA.DiscoBall:
			result = "DiscoBall";
			break;
		case NAAHKHPBAPA.Dice:
			result = "Dice";
			break;
		case NAAHKHPBAPA.Life:
			result = "Life";
			break;
		case NAAHKHPBAPA.UnlimitedLife:
			result = "UnlimitedLives";
			break;
		default:
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.BuyCoinsDialog, "Cannot convert to Trigger reason from InventoryItemType:{0}", GEKKLIKPAPP);
			break;
		case NAAHKHPBAPA.Extra5Moves:
			break;
		}
		return result;
	}
}
