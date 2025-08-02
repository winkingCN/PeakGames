using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class BPPNANHCLJI : DLDDFKDFKEF
{
	private static BPPNANHCLJI KNPOFJNFLJB;

	private bool CLNJDHMKFBC;

	private int OJJGAAOJLOB;

	private long FEIMIJPCJDD;

	private const int FHIIFBJOKND = 35;

	private const string MHAICFMMPGD = "Calendar";

	private readonly List<Dictionary<NAAHKHPBAPA, int>> HHMBNOLODAE = new List<Dictionary<NAAHKHPBAPA, int>>
	{
		new Dictionary<NAAHKHPBAPA, int>
		{
			{
				NAAHKHPBAPA.Rocket,
				1
			},
			{
				NAAHKHPBAPA.Bomb,
				1
			}
		},
		new Dictionary<NAAHKHPBAPA, int> { 
		{
			NAAHKHPBAPA.Hammer,
			1
		} },
		new Dictionary<NAAHKHPBAPA, int> { 
		{
			NAAHKHPBAPA.Coins,
			50
		} },
		new Dictionary<NAAHKHPBAPA, int>
		{
			{
				NAAHKHPBAPA.Hammer,
				1
			},
			{
				NAAHKHPBAPA.Dice,
				1
			}
		},
		new Dictionary<NAAHKHPBAPA, int>
		{
			{
				NAAHKHPBAPA.BoxingGlove,
				1
			},
			{
				NAAHKHPBAPA.Anvil,
				1
			}
		},
		new Dictionary<NAAHKHPBAPA, int> { 
		{
			NAAHKHPBAPA.Coins,
			100
		} },
		new Dictionary<NAAHKHPBAPA, int>
		{
			{
				NAAHKHPBAPA.Hammer,
				1
			},
			{
				NAAHKHPBAPA.BoxingGlove,
				1
			},
			{
				NAAHKHPBAPA.Anvil,
				1
			},
			{
				NAAHKHPBAPA.Dice,
				1
			}
		}
	};

	private readonly MGNLLDDOHKN PJPGMNCCFDK;

	public static BPPNANHCLJI GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new BPPNANHCLJI();
			}
			return KNPOFJNFLJB;
		}
	}

	private static string JBKIEMEAAJF
	{
		get
		{
			return "Calendar" + LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM;
		}
	}

	public int GNJKGLPMMLL
	{
		get
		{
			return OJJGAAOJLOB;
		}
	}

	public long JGKCEBEAFDP
	{
		get
		{
			return FEIMIJPCJDD - DateTime.UtcNow.GMEBBNOHJFJ();
		}
	}

	public BPPNANHCLJI()
	{
		PJPGMNCCFDK = MGNLLDDOHKN.GABGKBAKHDP;
	}

	public bool EENHGEBKDLD()
	{
		int num = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC();
		return CLNJDHMKFBC && num >= 35 && !PNOLICHIGEC() && JGKCEBEAFDP > 2;
	}

	public void OBHDNHDPFGG(bool OMJOIIOONMO, int CCHAAJBNJHL, long FMPBJJMKCIG)
	{
		bool flag = PNOLICHIGEC();
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Bonus, "Waiting for old Calendar to claim: {0}", flag);
		if (!flag)
		{
			if (CCHAAJBNJHL < 0 || CCHAAJBNJHL > 7)
			{
				CCHAAJBNJHL = 1;
			}
			CLNJDHMKFBC = OMJOIIOONMO;
			OJJGAAOJLOB = CCHAAJBNJHL;
			FEIMIJPCJDD = DateTime.UtcNow.GMEBBNOHJFJ() + FMPBJJMKCIG;
		}
	}

	public void DNBHGBMPIDO(bool OMJOIIOONMO, int CCHAAJBNJHL, long FMPBJJMKCIG)
	{
		CPAHJIDDCCD(false);
		OBHDNHDPFGG(OMJOIIOONMO, CCHAAJBNJHL, FMPBJJMKCIG);
	}

	private void IMIJOKIKJPG()
	{
		CPAHJIDDCCD(true);
	}

	public bool PNOLICHIGEC()
	{
		return !PJPGMNCCFDK.LDKAMIIEFMN(JBKIEMEAAJF);
	}

	private void CPAHJIDDCCD(bool EDDNOJDPMCF)
	{
		string eDDNOJDPMCF = DateTime.UtcNow.GMEBBNOHJFJ().ToString();
		PJPGMNCCFDK.JGMDDMNGDJO(JBKIEMEAAJF, eDDNOJDPMCF, (!EDDNOJDPMCF) ? 1 : 0);
	}

	public long MDEBPEGEMLA()
	{
		long result;
		long.TryParse(PJPGMNCCFDK.LIANKDMAHFM(JBKIEMEAAJF), out result);
		long num = DateTime.UtcNow.GMEBBNOHJFJ() - result;
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Bonus, "Claim request sent, Claim Time: {0}, Duration: {1}", result, num);
		return num;
	}

	public void FOBPKLDNMGN()
	{
		BMGGEIDJLMK();
		Dictionary<NAAHKHPBAPA, int> dictionary = COMIIPHMBGK();
		foreach (KeyValuePair<NAAHKHPBAPA, int> item in dictionary)
		{
			LFOEBDEFPDP(item);
		}
		IMIJOKIKJPG();
		KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
		{
			new JOLEBCDGILA(),
			new NCHDJAAJNIG()
		});
	}

	private void LFOEBDEFPDP(KeyValuePair<NAAHKHPBAPA, int> JHPAEIHECAI)
	{
		NAAHKHPBAPA key = JHPAEIHECAI.Key;
		if (key == NAAHKHPBAPA.Coins)
		{
			int aCFDIDGFPKJ = GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(JHPAEIHECAI.Key, JHPAEIHECAI.Value, false);
			GEBAAFFGKJG.GABGKBAKHDP.IBFMAELGBGP(aCFDIDGFPKJ);
		}
		else
		{
			GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(JHPAEIHECAI.Key, JHPAEIHECAI.Value, false);
		}
	}

	private void BMGGEIDJLMK()
	{
		string iKNCPEPOKGJ = KHNLJAHGDPF.LDPCLGLPELI();
		StringBuilder stringBuilder = new StringBuilder(3);
		stringBuilder.Append(OJJGAAOJLOB).Append(':').Append(DateTime.UtcNow.GMEBBNOHJFJ() / 86400);
		HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO(iKNCPEPOKGJ, stringBuilder.ToString());
	}

	public Dictionary<NAAHKHPBAPA, int> COMIIPHMBGK()
	{
		int index = Mathf.Clamp(OJJGAAOJLOB - 1, 0, 6);
		return HHMBNOLODAE[index];
	}

	public void OMOKOKFNBKI()
	{
		CLNJDHMKFBC = false;
		OJJGAAOJLOB = 0;
		FEIMIJPCJDD = 0L;
	}
}
