using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using Utils.Game;

public class GBFAPADEBEC
{
	private static GBFAPADEBEC KNPOFJNFLJB;

	private static readonly object PMNIJFDFBNN = new object();

	public static bool EPKFCLFNLAB = true;

	private readonly KCAHJNEHNHD COKBBOMNKDP;

	public static bool HCADONMOIDE { get; set; }

	[MethodImpl(MethodImplOptions.Synchronized)]
	private GBFAPADEBEC()
	{
		lock (PMNIJFDFBNN)
		{
			if (Application.platform == RuntimePlatform.IPhonePlayer)
			{
				Environment.SetEnvironmentVariable("MONO_REFLECTION_SERIALIZER", "yes");
			}
			COKBBOMNKDP = new KCAHJNEHNHD(Application.persistentDataPath);
			COKBBOMNKDP.ILNNDCGJCKG(PBIIDJOKNEK.LogManager, string.Empty);
			COKBBOMNKDP.ILNNDCGJCKG(PBIIDJOKNEK.LogManager, "**************************************************");
			COKBBOMNKDP.ILNNDCGJCKG(PBIIDJOKNEK.LogManager, "***********   LOG MANAGER IS INITED   ************");
			COKBBOMNKDP.ILNNDCGJCKG(PBIIDJOKNEK.LogManager, "**************************************************");
			COKBBOMNKDP.ILNNDCGJCKG(PBIIDJOKNEK.LogManager, string.Empty);
		}
	}

	private static void DIOELAHNLKJ()
	{
		if (!EPKFCLFNLAB || KNPOFJNFLJB != null)
		{
			return;
		}
		lock (PMNIJFDFBNN)
		{
			if (KNPOFJNFLJB != null)
			{
				return;
			}
			try
			{
				KNPOFJNFLJB = new GBFAPADEBEC();
			}
			catch (Exception ex)
			{
				Debug.LogError("Error on initing LogManager:" + ex.Message);
			}
		}
	}

	private static string EAJBCEKAOMN(string OEFCOJLNCKP, object[] GLGKHJMHOFP)
	{
		return (GLGKHJMHOFP != null) ? string.Format(OEFCOJLNCKP, GLGKHJMHOFP) : OEFCOJLNCKP;
	}

	public static void PFGLLCEKCGI(PBIIDJOKNEK MOKLDCMGFFB, string OEFCOJLNCKP, params object[] GLGKHJMHOFP)
	{
		if (!EPKFCLFNLAB)
		{
			return;
		}
		if (KNPOFJNFLJB == null)
		{
			DIOELAHNLKJ();
		}
		if (KNPOFJNFLJB != null)
		{
			if (OEFCOJLNCKP.Length > 7500)
			{
				OEFCOJLNCKP = OEFCOJLNCKP.Substring(0, 7500);
			}
			if (HCADONMOIDE)
			{
				Debug.Log(EAJBCEKAOMN(string.Concat(MOKLDCMGFFB, ":", OEFCOJLNCKP), GLGKHJMHOFP));
			}
			else
			{
				KNPOFJNFLJB.COKBBOMNKDP.ILNNDCGJCKG(MOKLDCMGFFB, OEFCOJLNCKP, GLGKHJMHOFP);
			}
		}
	}

	public static void LCNJJMBLOHE(PBIIDJOKNEK MOKLDCMGFFB, string OEFCOJLNCKP, params object[] GLGKHJMHOFP)
	{
		if (!EPKFCLFNLAB)
		{
			return;
		}
		if (KNPOFJNFLJB == null)
		{
			DIOELAHNLKJ();
		}
		if (KNPOFJNFLJB != null)
		{
			if (OEFCOJLNCKP.Length > 7500)
			{
				OEFCOJLNCKP = OEFCOJLNCKP.Substring(0, 7500);
			}
			if (HCADONMOIDE)
			{
				Debug.LogError(EAJBCEKAOMN(string.Concat(MOKLDCMGFFB, ":", OEFCOJLNCKP), GLGKHJMHOFP));
			}
			else
			{
				KNPOFJNFLJB.COKBBOMNKDP.ILNNDCGJCKG(MOKLDCMGFFB, OEFCOJLNCKP, GLGKHJMHOFP, DGLNAIKJGHP.Error);
			}
		}
	}

	public static void KIFFBFPEMGP(PBIIDJOKNEK MOKLDCMGFFB, string OEFCOJLNCKP, params object[] GLGKHJMHOFP)
	{
		if (!EPKFCLFNLAB)
		{
			return;
		}
		if (KNPOFJNFLJB == null)
		{
			DIOELAHNLKJ();
		}
		if (KNPOFJNFLJB != null)
		{
			if (OEFCOJLNCKP.Length > 7500)
			{
				OEFCOJLNCKP = OEFCOJLNCKP.Substring(0, 7500);
			}
			if (HCADONMOIDE)
			{
				Debug.LogWarning(EAJBCEKAOMN(string.Concat(MOKLDCMGFFB, ":", OEFCOJLNCKP), GLGKHJMHOFP));
			}
			else
			{
				KNPOFJNFLJB.COKBBOMNKDP.ILNNDCGJCKG(MOKLDCMGFFB, OEFCOJLNCKP, GLGKHJMHOFP, DGLNAIKJGHP.Warning);
			}
		}
	}

	public static void HGGCKNOEIOM(PBIIDJOKNEK MOKLDCMGFFB, GamePlayRecord HPFPDJHBNIE)
	{
		if (!EPKFCLFNLAB)
		{
			return;
		}
		if (KNPOFJNFLJB == null)
		{
			DIOELAHNLKJ();
		}
		if (KNPOFJNFLJB != null)
		{
			if (HCADONMOIDE)
			{
				Debug.Log(string.Concat(MOKLDCMGFFB, ":", HPFPDJHBNIE));
			}
			else
			{
				KNPOFJNFLJB.COKBBOMNKDP.ILNNDCGJCKG(MOKLDCMGFFB, null, null, DGLNAIKJGHP.Log, HPFPDJHBNIE);
			}
		}
	}

	public static void IOCHPGEBNEE()
	{
		if (KNPOFJNFLJB != null)
		{
			KNPOFJNFLJB.COKBBOMNKDP.KIFBCOFOBAE();
		}
	}

	public static void CPGJCKCOABM()
	{
		if (KNPOFJNFLJB == null)
		{
			DIOELAHNLKJ();
		}
		if (KNPOFJNFLJB != null)
		{
			KNPOFJNFLJB.COKBBOMNKDP.CPGJCKCOABM();
		}
	}

	public static void IGDBIMMIMBE(int HJLKIKDFKBH)
	{
		if (KNPOFJNFLJB == null)
		{
			DIOELAHNLKJ();
		}
		if (KNPOFJNFLJB != null)
		{
			KNPOFJNFLJB.COKBBOMNKDP.IGDBIMMIMBE(HJLKIKDFKBH);
		}
	}

	public static void IIHHGNAACEG(NCHDGFIAHLI NFKAOGEGJMI)
	{
		if (!EPKFCLFNLAB)
		{
			if (NFKAOGEGJMI != null)
			{
				NFKAOGEGJMI(false, null);
			}
			return;
		}
		if (KNPOFJNFLJB == null)
		{
			DIOELAHNLKJ();
		}
		if (KNPOFJNFLJB == null)
		{
			if (NFKAOGEGJMI != null)
			{
				NFKAOGEGJMI(false, null);
			}
			return;
		}
		try
		{
			KNPOFJNFLJB.COKBBOMNKDP.EMPALCMOADM(NFKAOGEGJMI);
		}
		catch (Exception)
		{
			if (NFKAOGEGJMI != null)
			{
				NFKAOGEGJMI(false, null);
			}
		}
	}

	public static void OMOKOKFNBKI()
	{
		if (KNPOFJNFLJB != null)
		{
			EPKFCLFNLAB = false;
			KNPOFJNFLJB.COKBBOMNKDP.NMCJJLGANMC();
			KNPOFJNFLJB = null;
			EPKFCLFNLAB = true;
			DIOELAHNLKJ();
			PFGLLCEKCGI(PBIIDJOKNEK.LogManager, "LogManager is reset.");
		}
	}
}
