using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using UnityEngine;
using caravan.protobuf.messages;

public class NDGOJGLPIJF : DLDDFKDFKEF
{
	public int AMKOJOKCELO;

	private readonly MGNLLDDOHKN PJPGMNCCFDK;

	private readonly HJBLKNBHMFJ ODEGDLHJOFN;

	private const string JAIAIDGGKEL = "ToonChest";

	public static int DGIKLPPBGHJ = 20;

	private static NDGOJGLPIJF KNPOFJNFLJB;

	public static NDGOJGLPIJF GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new NDGOJGLPIJF();
			}
			return KNPOFJNFLJB;
		}
	}

	public NDGOJGLPIJF()
	{
		PJPGMNCCFDK = MGNLLDDOHKN.GABGKBAKHDP;
		ODEGDLHJOFN = HJBLKNBHMFJ.GABGKBAKHDP;
		CKHHPNAOAEF();
	}

	public void CKHHPNAOAEF()
	{
		if (ODEGDLHJOFN.LIANKDMAHFM("StarChest_Available_Time") != null)
		{
			ODEGDLHJOFN.MFKBEDNLCJA("StarChest_Available_Time");
		}
		if (ODEGDLHJOFN.LIANKDMAHFM("StarChest_Old_Available_Time") != null)
		{
			ODEGDLHJOFN.MFKBEDNLCJA("StarChest_Old_Available_Time");
		}
		if (ODEGDLHJOFN.LIANKDMAHFM("StarChest_Marked") != null)
		{
			ODEGDLHJOFN.MFKBEDNLCJA("StarChest_Marked");
		}
	}

	public bool AEFOGGAOFEE()
	{
		int num = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC();
		return num >= 2;
	}

	public int KCJHDPCLPDL()
	{
		string text = PJPGMNCCFDK.LIANKDMAHFM("ToonChest");
		if (text != null)
		{
			return int.Parse(text);
		}
		PJPGMNCCFDK.JGMDDMNGDJO("ToonChest", "0");
		return 0;
	}

	public int DLDNDGEEIAB()
	{
		return (Mathf.FloorToInt(KCJHDPCLPDL() / 10) + 1) * 10;
	}

	public void EAMANKNAANK()
	{
		int num = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1;
		PJPGMNCCFDK.JGMDDMNGDJO("ToonChest", num.ToString());
	}

	public bool BMKIICIJGEK()
	{
		int num = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1;
		int num2 = DLDNDGEEIAB();
		return num >= num2;
	}

	public Dictionary<NAAHKHPBAPA, int> NCJMDKEBLMP()
	{
		int gIOFHACJEGA = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC();
		int[] array = new int[5] { 10, 15, 20, 25, 30 };
		List<NAAHKHPBAPA> list = ILJHFBNNOCH(gIOFHACJEGA);
		List<NAAHKHPBAPA> list2 = OMAKBBBJPCC(gIOFHACJEGA);
		Dictionary<NAAHKHPBAPA, int> dictionary = new Dictionary<NAAHKHPBAPA, int>();
		dictionary.Add(NAAHKHPBAPA.Coins, array[Random.Range(0, array.Length)]);
		dictionary.Add(list[Random.Range(0, list.Count)], 1);
		Dictionary<NAAHKHPBAPA, int> dictionary2 = dictionary;
		if (list2 != null)
		{
			dictionary2.Add(list2[Random.Range(0, list2.Count)], 1);
		}
		return dictionary2;
	}

	public Dictionary<NAAHKHPBAPA, int> DPDDOCIJHEG()
	{
		int num = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC();
		int[] array = new int[3] { 10, 15, 20 };
		List<NAAHKHPBAPA> list = ILJHFBNNOCH(num);
		List<NAAHKHPBAPA> list2 = OMAKBBBJPCC(num);
		Dictionary<NAAHKHPBAPA, int> dictionary = new Dictionary<NAAHKHPBAPA, int>();
		dictionary.Add(NAAHKHPBAPA.Coins, array[Random.Range(0, array.Length)]);
		Dictionary<NAAHKHPBAPA, int> dictionary2 = dictionary;
		if (num > 21 && Random.Range(0, 2) == 1 && CAGBGIHKHEJ.GABGKBAKHDP.ELEKFHDLKJJ() < 5)
		{
			if (list2 != null)
			{
				dictionary2.Add(list2[Random.Range(0, list2.Count)], 1);
			}
			else
			{
				dictionary2.Add(list[Random.Range(0, list.Count)], 1);
			}
			dictionary2.Add(NAAHKHPBAPA.Life, 5);
		}
		else if (list2 != null)
		{
			dictionary2.Add(list[Random.Range(0, list.Count)], 1);
			dictionary2.Add(list2[Random.Range(0, list2.Count)], 1);
		}
		else
		{
			int index = Random.Range(0, list.Count);
			dictionary2.Add(list[index], 1);
			list.RemoveAt(index);
			dictionary2.Add(list[Random.Range(0, list.Count)], 1);
		}
		return dictionary2;
	}

	public Dictionary<NAAHKHPBAPA, int> PIMFKHOCLPO()
	{
		int gIOFHACJEGA = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC();
		List<NAAHKHPBAPA> list = GFENFJFEMGH(gIOFHACJEGA);
		List<NAAHKHPBAPA> list2 = NEENCPMEJKO(gIOFHACJEGA);
		Dictionary<NAAHKHPBAPA, int> dictionary = new Dictionary<NAAHKHPBAPA, int>();
		dictionary.Add(NAAHKHPBAPA.Coins, 250);
		dictionary.Add(list[Random.Range(0, list.Count)], 3);
		Dictionary<NAAHKHPBAPA, int> dictionary2 = dictionary;
		if (list2 != null)
		{
			dictionary2.Add(list2[Random.Range(0, list2.Count)], 3);
		}
		return dictionary2;
	}

	public Dictionary<NAAHKHPBAPA, int> LLILLCFDGEB()
	{
		int gIOFHACJEGA = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC();
		List<NAAHKHPBAPA> list = GFENFJFEMGH(gIOFHACJEGA);
		List<NAAHKHPBAPA> list2 = NEENCPMEJKO(gIOFHACJEGA);
		Dictionary<NAAHKHPBAPA, int> dictionary = new Dictionary<NAAHKHPBAPA, int>();
		dictionary.Add(NAAHKHPBAPA.Coins, 250);
		dictionary.Add(list[Random.Range(0, list.Count)], 3);
		Dictionary<NAAHKHPBAPA, int> dictionary2 = dictionary;
		if (list2 != null)
		{
			dictionary2.Add(list2[Random.Range(0, list2.Count)], 3);
		}
		return dictionary2;
	}

	private List<NAAHKHPBAPA> OMAKBBBJPCC(int GIOFHACJEGA)
	{
		if (GIOFHACJEGA < 9)
		{
			return null;
		}
		List<NAAHKHPBAPA> list = new List<NAAHKHPBAPA>();
		list.Add(NAAHKHPBAPA.Hammer);
		List<NAAHKHPBAPA> list2 = list;
		if (GIOFHACJEGA >= 12)
		{
			list2.Add(NAAHKHPBAPA.BoxingGlove);
		}
		if (GIOFHACJEGA >= 16)
		{
			list2.Add(NAAHKHPBAPA.Anvil);
		}
		if (GIOFHACJEGA >= BoosterManager.EOEHGMKBEHF)
		{
			list2.Add(NAAHKHPBAPA.Dice);
		}
		return list2;
	}

	private List<NAAHKHPBAPA> ILJHFBNNOCH(int GIOFHACJEGA)
	{
		List<NAAHKHPBAPA> list = new List<NAAHKHPBAPA>();
		list.Add(NAAHKHPBAPA.Rocket);
		list.Add(NAAHKHPBAPA.Bomb);
		list.Add(NAAHKHPBAPA.DiscoBall);
		return list;
	}

	private List<NAAHKHPBAPA> NEENCPMEJKO(int GIOFHACJEGA)
	{
		if (GIOFHACJEGA < 9)
		{
			return null;
		}
		List<NAAHKHPBAPA> list = new List<NAAHKHPBAPA>();
		list.Add(NAAHKHPBAPA.Hammer);
		List<NAAHKHPBAPA> list2 = list;
		if (GIOFHACJEGA >= 12)
		{
			list2.Add(NAAHKHPBAPA.BoxingGlove);
		}
		if (GIOFHACJEGA >= 16)
		{
			list2.Add(NAAHKHPBAPA.Anvil);
		}
		return list2;
	}

	private List<NAAHKHPBAPA> GFENFJFEMGH(int GIOFHACJEGA)
	{
		List<NAAHKHPBAPA> list = new List<NAAHKHPBAPA>();
		list.Add(NAAHKHPBAPA.Rocket);
		list.Add(NAAHKHPBAPA.Bomb);
		list.Add(NAAHKHPBAPA.DiscoBall);
		List<NAAHKHPBAPA> list2 = list;
		if (GIOFHACJEGA >= BoosterManager.EOEHGMKBEHF)
		{
			list2.Add(NAAHKHPBAPA.Dice);
		}
		return list2;
	}

	public void PJNCDCKHGDK(ChestMetaData JAKCLPCOGFM = null)
	{
		string eDDNOJDPMCF = ((JAKCLPCOGFM != null) ? JAKCLPCOGFM.toonChest.ToString() : KCJHDPCLPDL().ToString());
		PJPGMNCCFDK.JGMDDMNGDJO("ToonChest", eDDNOJDPMCF, 1);
	}

	public bool NEEBONFOOCB()
	{
		return PJPGMNCCFDK.LDKAMIIEFMN("ToonChest");
	}

	public void OMOKOKFNBKI()
	{
		PJPGMNCCFDK.MFKBEDNLCJA("ToonChest");
	}
}
