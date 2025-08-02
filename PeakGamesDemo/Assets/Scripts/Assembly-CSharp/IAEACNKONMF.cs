using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class IAEACNKONMF
{
	public static readonly AJLDDMLECNL CALMGKBNAKF = (float LLIEHCKNJEM) => LLIEHCKNJEM;

	public static readonly AJLDDMLECNL KBGOBJFGKMB = (float LLIEHCKNJEM) => LLIEHCKNJEM * LLIEHCKNJEM;

	public static readonly AJLDDMLECNL HODKKNPJMKM = (float LLIEHCKNJEM) => 1f - KBGOBJFGKMB(1f - LLIEHCKNJEM);

	public static readonly AJLDDMLECNL HNLJFCLHMPM = (float LLIEHCKNJEM) => (!(LLIEHCKNJEM <= 0.5f)) ? (HODKKNPJMKM(LLIEHCKNJEM * 2f - 1f) / 2f + 0.5f) : (KBGOBJFGKMB(LLIEHCKNJEM * 2f) / 2f);

	public static readonly AJLDDMLECNL FLCCHNEOEBK = (float LLIEHCKNJEM) => LLIEHCKNJEM * LLIEHCKNJEM * LLIEHCKNJEM;

	public static readonly AJLDDMLECNL PKFNLCBPKLD = (float LLIEHCKNJEM) => 1f - FLCCHNEOEBK(1f - LLIEHCKNJEM);

	public static readonly AJLDDMLECNL DNACMJEEOIM = (float LLIEHCKNJEM) => (!(LLIEHCKNJEM <= 0.5f)) ? (PKFNLCBPKLD(LLIEHCKNJEM * 2f - 1f) / 2f + 0.5f) : (FLCCHNEOEBK(LLIEHCKNJEM * 2f) / 2f);

	public static readonly AJLDDMLECNL BMCIMAKFLAJ = (float LLIEHCKNJEM) => LLIEHCKNJEM * LLIEHCKNJEM * (2.70158f * LLIEHCKNJEM - 1.70158f);

	public static readonly AJLDDMLECNL GLCHMPKGNLB = (float LLIEHCKNJEM) => 1f - BMCIMAKFLAJ(1f - LLIEHCKNJEM);

	public static readonly AJLDDMLECNL BGGLOKGCFHP = (float LLIEHCKNJEM) => (!(LLIEHCKNJEM <= 0.5f)) ? (GLCHMPKGNLB(LLIEHCKNJEM * 2f - 1f) / 2f + 0.5f) : (BMCIMAKFLAJ(LLIEHCKNJEM * 2f) / 2f);

	public static readonly AJLDDMLECNL PBHMKAADNDM = (float LLIEHCKNJEM) => Mathf.Pow(2f, 10f * (LLIEHCKNJEM - 1f));

	public static readonly AJLDDMLECNL CHALKCKPJAI = (float LLIEHCKNJEM) => 1f - PBHMKAADNDM(LLIEHCKNJEM);

	public static readonly AJLDDMLECNL BFCLINDBFCO = (float LLIEHCKNJEM) => (!(LLIEHCKNJEM < 0.5f)) ? (CHALKCKPJAI(LLIEHCKNJEM * 2f) / 2f) : (PBHMKAADNDM(LLIEHCKNJEM * 2f) / 2f);

	public static readonly AJLDDMLECNL HHIFIKCDIED = (float LLIEHCKNJEM) => 0f - Mathf.Cos((float)Math.PI / 2f * LLIEHCKNJEM) + 1f;

	public static readonly AJLDDMLECNL DAKOJGADIAA = (float LLIEHCKNJEM) => Mathf.Sin((float)Math.PI / 2f * LLIEHCKNJEM);

	public static readonly AJLDDMLECNL PPNDKMFJHFP = (float LLIEHCKNJEM) => (0f - Mathf.Cos((float)Math.PI * LLIEHCKNJEM)) / 2f + 0.5f;

	public static readonly AJLDDMLECNL MCMIBNCDPAA = (float LLIEHCKNJEM) => 1f - HBJGJPAKHOD(1f - LLIEHCKNJEM);

	public static readonly AJLDDMLECNL HBJGJPAKHOD = (float LLIEHCKNJEM) => Mathf.Pow(2f, -10f * LLIEHCKNJEM) * Mathf.Sin((LLIEHCKNJEM - 0.075f) * ((float)Math.PI * 2f) / 0.3f) + 1f;

	public static readonly AJLDDMLECNL CNGBHDBKBIH = (float LLIEHCKNJEM) => (!(LLIEHCKNJEM <= 0.5f)) ? (HBJGJPAKHOD(LLIEHCKNJEM * 2f - 1f) / 2f + 0.5f) : (MCMIBNCDPAA(LLIEHCKNJEM * 2f) / 2f);

	public static AJLDDMLECNL DKKKCFJGKCN(BJCJEPIOBMA NBFBPNNEKMN)
	{
		switch (NBFBPNNEKMN)
		{
		case BJCJEPIOBMA.Linear:
			return CALMGKBNAKF;
		case BJCJEPIOBMA.QuadIn:
			return KBGOBJFGKMB;
		case BJCJEPIOBMA.QuadOut:
			return HODKKNPJMKM;
		case BJCJEPIOBMA.QuadInOut:
			return HNLJFCLHMPM;
		case BJCJEPIOBMA.CubeIn:
			return FLCCHNEOEBK;
		case BJCJEPIOBMA.CubeOut:
			return PKFNLCBPKLD;
		case BJCJEPIOBMA.CubeInOut:
			return DNACMJEEOIM;
		case BJCJEPIOBMA.BackIn:
			return BMCIMAKFLAJ;
		case BJCJEPIOBMA.BackOut:
			return GLCHMPKGNLB;
		case BJCJEPIOBMA.BackInOut:
			return BGGLOKGCFHP;
		case BJCJEPIOBMA.ExpoIn:
			return PBHMKAADNDM;
		case BJCJEPIOBMA.ExpoOut:
			return CHALKCKPJAI;
		case BJCJEPIOBMA.ExpoInOut:
			return BFCLINDBFCO;
		case BJCJEPIOBMA.SineIn:
			return HHIFIKCDIED;
		case BJCJEPIOBMA.SineOut:
			return DAKOJGADIAA;
		case BJCJEPIOBMA.SineInOut:
			return PPNDKMFJHFP;
		case BJCJEPIOBMA.ElasticIn:
			return MCMIBNCDPAA;
		case BJCJEPIOBMA.ElasticOut:
			return HBJGJPAKHOD;
		case BJCJEPIOBMA.ElasticInOut:
			return CNGBHDBKBIH;
		default:
			return CALMGKBNAKF;
		}
	}

	[CompilerGenerated]
	private static float LAMHMCGFHNK(float LLIEHCKNJEM)
	{
		return LLIEHCKNJEM;
	}

	[CompilerGenerated]
	private static float CJICMKMCJBP(float LLIEHCKNJEM)
	{
		return LLIEHCKNJEM * LLIEHCKNJEM;
	}

	[CompilerGenerated]
	private static float OOJENNCGGKM(float LLIEHCKNJEM)
	{
		return 1f - KBGOBJFGKMB(1f - LLIEHCKNJEM);
	}

	[CompilerGenerated]
	private static float GFIAPNLPIII(float LLIEHCKNJEM)
	{
		return (!(LLIEHCKNJEM <= 0.5f)) ? (HODKKNPJMKM(LLIEHCKNJEM * 2f - 1f) / 2f + 0.5f) : (KBGOBJFGKMB(LLIEHCKNJEM * 2f) / 2f);
	}

	[CompilerGenerated]
	private static float KMJNEOGIGBP(float LLIEHCKNJEM)
	{
		return LLIEHCKNJEM * LLIEHCKNJEM * LLIEHCKNJEM;
	}

	[CompilerGenerated]
	private static float LOBIBNEHEBD(float LLIEHCKNJEM)
	{
		return 1f - FLCCHNEOEBK(1f - LLIEHCKNJEM);
	}

	[CompilerGenerated]
	private static float BFPIJGFNODH(float LLIEHCKNJEM)
	{
		return (!(LLIEHCKNJEM <= 0.5f)) ? (PKFNLCBPKLD(LLIEHCKNJEM * 2f - 1f) / 2f + 0.5f) : (FLCCHNEOEBK(LLIEHCKNJEM * 2f) / 2f);
	}

	[CompilerGenerated]
	private static float KLAMNAOLPFB(float LLIEHCKNJEM)
	{
		return LLIEHCKNJEM * LLIEHCKNJEM * (2.70158f * LLIEHCKNJEM - 1.70158f);
	}

	[CompilerGenerated]
	private static float KICEAECFNEC(float LLIEHCKNJEM)
	{
		return 1f - BMCIMAKFLAJ(1f - LLIEHCKNJEM);
	}

	[CompilerGenerated]
	private static float OLMMEJHAOKI(float LLIEHCKNJEM)
	{
		return (!(LLIEHCKNJEM <= 0.5f)) ? (GLCHMPKGNLB(LLIEHCKNJEM * 2f - 1f) / 2f + 0.5f) : (BMCIMAKFLAJ(LLIEHCKNJEM * 2f) / 2f);
	}

	[CompilerGenerated]
	private static float EFFMKJEDHKO(float LLIEHCKNJEM)
	{
		return Mathf.Pow(2f, 10f * (LLIEHCKNJEM - 1f));
	}

	[CompilerGenerated]
	private static float HHGNNPNDMGA(float LLIEHCKNJEM)
	{
		return 1f - PBHMKAADNDM(LLIEHCKNJEM);
	}

	[CompilerGenerated]
	private static float KBFKPEMOHJE(float LLIEHCKNJEM)
	{
		return (!(LLIEHCKNJEM < 0.5f)) ? (CHALKCKPJAI(LLIEHCKNJEM * 2f) / 2f) : (PBHMKAADNDM(LLIEHCKNJEM * 2f) / 2f);
	}

	[CompilerGenerated]
	private static float LNOHADFCPGD(float LLIEHCKNJEM)
	{
		return 0f - Mathf.Cos((float)Math.PI / 2f * LLIEHCKNJEM) + 1f;
	}

	[CompilerGenerated]
	private static float GJMCJCFFFAB(float LLIEHCKNJEM)
	{
		return Mathf.Sin((float)Math.PI / 2f * LLIEHCKNJEM);
	}

	[CompilerGenerated]
	private static float DMFAOKAPGEP(float LLIEHCKNJEM)
	{
		return (0f - Mathf.Cos((float)Math.PI * LLIEHCKNJEM)) / 2f + 0.5f;
	}

	[CompilerGenerated]
	private static float PDGDCPDHNID(float LLIEHCKNJEM)
	{
		return 1f - HBJGJPAKHOD(1f - LLIEHCKNJEM);
	}

	[CompilerGenerated]
	private static float GFJBNCNEDAF(float LLIEHCKNJEM)
	{
		return Mathf.Pow(2f, -10f * LLIEHCKNJEM) * Mathf.Sin((LLIEHCKNJEM - 0.075f) * ((float)Math.PI * 2f) / 0.3f) + 1f;
	}

	[CompilerGenerated]
	private static float DHAHBDIMFHH(float LLIEHCKNJEM)
	{
		return (!(LLIEHCKNJEM <= 0.5f)) ? (HBJGJPAKHOD(LLIEHCKNJEM * 2f - 1f) / 2f + 0.5f) : (MCMIBNCDPAA(LLIEHCKNJEM * 2f) / 2f);
	}
}
