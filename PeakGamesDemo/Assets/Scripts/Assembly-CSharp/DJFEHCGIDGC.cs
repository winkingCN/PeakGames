using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Assets.Scripts.MapScene;
using UnityEngine;

public class DJFEHCGIDGC : DLDDFKDFKEF
{
	private static DJFEHCGIDGC KNPOFJNFLJB;

	private const int FHIIFBJOKND = 25;

	private const string OAKEMHOEFFO = "DailyBonus";

	private bool EHKGFHLBLME;

	private readonly MGNLLDDOHKN PJPGMNCCFDK;

	private Dictionary<NAAHKHPBAPA, int> BOHEILMDACJ;

	[CompilerGenerated]
	private static Func<KeyValuePair<NAAHKHPBAPA, int>, NAAHKHPBAPA> EBCOMJBLIPP;

	[CompilerGenerated]
	private static Func<KeyValuePair<NAAHKHPBAPA, int>, int> DNBOPLHGMHA;

	private string NMEGEKDKEGJ
	{
		get
		{
			return "DailyBonus" + LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM;
		}
	}

	public static DJFEHCGIDGC GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new DJFEHCGIDGC();
			}
			return KNPOFJNFLJB;
		}
	}

	public DJFEHCGIDGC()
	{
		PJPGMNCCFDK = MGNLLDDOHKN.GABGKBAKHDP;
	}

	public Dictionary<NAAHKHPBAPA, int> BEHOJDPIJEK()
	{
		BOHEILMDACJ = new Dictionary<NAAHKHPBAPA, int>
		{
			{
				NAAHKHPBAPA.Coins,
				50
			},
			{
				NAAHKHPBAPA.Life,
				5
			},
			{
				NAAHKHPBAPA.Anvil,
				1
			},
			{
				NAAHKHPBAPA.Bomb,
				1
			},
			{
				NAAHKHPBAPA.BoxingGlove,
				1
			},
			{
				NAAHKHPBAPA.Dice,
				1
			},
			{
				NAAHKHPBAPA.DiscoBall,
				1
			},
			{
				NAAHKHPBAPA.Hammer,
				1
			},
			{
				NAAHKHPBAPA.Rocket,
				1
			}
		};
		KeyValuePair<NAAHKHPBAPA, int>[] array = BOHEILMDACJ.ToArray();
		for (int num = array.Length - 1; num >= 0; num--)
		{
			int num2 = UnityEngine.Random.Range(0, num + 1);
			KeyValuePair<NAAHKHPBAPA, int> keyValuePair = array[num];
			array[num] = array[num2];
			array[num2] = keyValuePair;
		}
		BOHEILMDACJ = array.ToDictionary((KeyValuePair<NAAHKHPBAPA, int> BENKLGPHLGI) => BENKLGPHLGI.Key, (KeyValuePair<NAAHKHPBAPA, int> BENKLGPHLGI) => BENKLGPHLGI.Value);
		return BOHEILMDACJ;
	}

	public KeyValuePair<NAAHKHPBAPA, int> HNENNHMGDAN(int EDDNOJDPMCF)
	{
		KeyValuePair<NAAHKHPBAPA, int> result = CPFHJBNNLHB(EDDNOJDPMCF);
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Bonus, "Daily Bonus Reward: {0}", result.Key);
		return result;
	}

	public KeyValuePair<NAAHKHPBAPA, int> CPFHJBNNLHB(int EDDNOJDPMCF)
	{
		KeyValuePair<NAAHKHPBAPA, int>[] array = BOHEILMDACJ.ToArray();
		return array[EDDNOJDPMCF];
	}

	public bool NPDHFFPKPLF()
	{
		int num = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC();
		return EHKGFHLBLME && num >= 25 && !DNFKADNNPCD();
	}

	public bool DNFKADNNPCD()
	{
		return !PJPGMNCCFDK.LDKAMIIEFMN(NMEGEKDKEGJ);
	}

	private void KOFBINFEFLG(bool EDDNOJDPMCF)
	{
		string eDDNOJDPMCF = DateTime.UtcNow.GMEBBNOHJFJ().ToString();
		PJPGMNCCFDK.JGMDDMNGDJO(NMEGEKDKEGJ, eDDNOJDPMCF, (!EDDNOJDPMCF) ? 1 : 0);
	}

	public void OMOKOKFNBKI()
	{
		EHKGFHLBLME = false;
	}

	public void HCJIILJLEJB(bool HMENAFHINME)
	{
		bool flag = DNFKADNNPCD();
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Bonus, "Daily Bonus availability: {0}, Waiting for old Daily Bonus to claim: {1}", HMENAFHINME, flag);
		if (!flag)
		{
			EHKGFHLBLME = HMENAFHINME;
		}
	}

	public void IMIJOKIKJPG()
	{
		KOFBINFEFLG(true);
	}

	public void PJEOJFGDDAD(NAAHKHPBAPA FFOEHDKOCDC, int NNIDKMJGAJO)
	{
		LFOEBDEFPDP(FFOEHDKOCDC, NNIDKMJGAJO);
		GOEPBLOOFNN();
		KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
		{
			new JMKANEEICJF()
		});
	}

	public void FMJNECDNGPA(bool EDDNOJDPMCF)
	{
		KOFBINFEFLG(false);
		HCJIILJLEJB(EDDNOJDPMCF);
	}

	public void GOEPBLOOFNN()
	{
		if (MapManager.Instance != null)
		{
			MapManager.Instance.NewMapContent.DailyBonusDisplay.Prepare();
		}
	}

	public long MDEBPEGEMLA()
	{
		long result;
		long.TryParse(PJPGMNCCFDK.LIANKDMAHFM(NMEGEKDKEGJ), out result);
		long num = DateTime.UtcNow.GMEBBNOHJFJ() - result;
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Bonus, "Claim request sent, Claim Time: {0}, Duration: {1}", result, num);
		return num;
	}

	private static void LFOEBDEFPDP(NAAHKHPBAPA FFOEHDKOCDC, int NNIDKMJGAJO)
	{
		switch (FFOEHDKOCDC)
		{
		case NAAHKHPBAPA.Coins:
		{
			int aCFDIDGFPKJ = GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(FFOEHDKOCDC, NNIDKMJGAJO);
			GEBAAFFGKJG.GABGKBAKHDP.IBFMAELGBGP(aCFDIDGFPKJ);
			break;
		}
		case NAAHKHPBAPA.Life:
			CAGBGIHKHEJ.GABGKBAKHDP.LCNJBFJEFNA(NNIDKMJGAJO);
			break;
		default:
			GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(FFOEHDKOCDC, NNIDKMJGAJO);
			break;
		}
	}

	[CompilerGenerated]
	private static NAAHKHPBAPA HJEPCGNFAKC(KeyValuePair<NAAHKHPBAPA, int> BENKLGPHLGI)
	{
		return BENKLGPHLGI.Key;
	}

	[CompilerGenerated]
	private static int AKDAGHKIHKN(KeyValuePair<NAAHKHPBAPA, int> BENKLGPHLGI)
	{
		return BENKLGPHLGI.Value;
	}
}
