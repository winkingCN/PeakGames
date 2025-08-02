using Assets.Scripts.Utils;
using UnityEngine;

public class MDGKDGMGGCL : DLDDFKDFKEF
{
	private const string CJJBAPCNOMB = "MusicEnabled";

	private const string HDNCHCIBOJP = "FxEnabled";

	private const string PABKLJPEKEO = "SelectedLang";

	private const string NEHJLBDPHLJ = "StartCounter";

	private const string ILICHMPJBAA = "ChatEnabled";

	private const string LIBHMNAKGEH = "BadWordFilter";

	private static MDGKDGMGGCL KNPOFJNFLJB;

	private readonly HJBLKNBHMFJ NJCPCACOCGB;

	public int BKKHDJKIIBP { get; private set; }

	public static MDGKDGMGGCL GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new MDGKDGMGGCL();
			}
			return KNPOFJNFLJB;
		}
	}

	private MDGKDGMGGCL()
	{
		NJCPCACOCGB = HJBLKNBHMFJ.GABGKBAKHDP;
		string text = NJCPCACOCGB.LIANKDMAHFM("StartCounter");
		if (text == null)
		{
			text = "1";
			BKKHDJKIIBP = 1;
		}
		else
		{
			int result;
			int.TryParse(text, out result);
			text = (BKKHDJKIIBP = result + 1).ToString();
		}
		NJCPCACOCGB.JGMDDMNGDJO("StartCounter", text);
	}

	public string PHOCMCOHANN()
	{
		return NJCPCACOCGB.LIANKDMAHFM("SelectedLang") ?? ENDFLKEHFJF(Application.systemLanguage);
	}

	public void DNNOFBIEFCF(string FCAKCGLLGCL)
	{
		NJCPCACOCGB.JGMDDMNGDJO("SelectedLang", FCAKCGLLGCL);
	}

	private static string ENDFLKEHFJF(SystemLanguage FABPFKFOFMM)
	{
		switch (FABPFKFOFMM)
		{
		case SystemLanguage.Turkish:
			return "tr";
		case SystemLanguage.French:
			return "fr";
		case SystemLanguage.German:
			return "de";
		case SystemLanguage.Italian:
			return "it";
		case SystemLanguage.Portuguese:
			return "pt-BR";
		case SystemLanguage.Spanish:
			return "es";
		case SystemLanguage.Russian:
			return "ru";
		case SystemLanguage.Japanese:
			return "ja";
		default:
			return "en";
		}
	}

	public void OMOKOKFNBKI()
	{
	}

	public bool APAAJANEIOD()
	{
		string text = NJCPCACOCGB.LIANKDMAHFM("ChatEnabled");
		if (text == null)
		{
			NJCPCACOCGB.JGMDDMNGDJO("ChatEnabled", "t");
			return true;
		}
		return "t".Equals(text);
	}

	public void FPGCGKIJOEI(bool AAIEJDNAODP)
	{
		NJCPCACOCGB.JGMDDMNGDJO("ChatEnabled", (!AAIEJDNAODP) ? "f" : "t");
	}

	public bool AGGMHHLFFDA()
	{
		string value = NJCPCACOCGB.LIANKDMAHFM("MusicEnabled");
		return "t".Equals(value);
	}

	public bool NBJEKKIECGE()
	{
		string value = NJCPCACOCGB.LIANKDMAHFM("FxEnabled");
		return "t".Equals(value);
	}

	public void OJKFPLOOKLA(bool AAIEJDNAODP)
	{
		NJCPCACOCGB.JGMDDMNGDJO("MusicEnabled", (!AAIEJDNAODP) ? "f" : "t");
		AudioManager.MMJKLIMKEHG = AAIEJDNAODP;
	}

	public void JFEDLJOAJEM(bool AAIEJDNAODP)
	{
		NJCPCACOCGB.JGMDDMNGDJO("FxEnabled", (!AAIEJDNAODP) ? "f" : "t");
		AudioManager.NAEBPOAPIFP = AAIEJDNAODP;
	}
}
