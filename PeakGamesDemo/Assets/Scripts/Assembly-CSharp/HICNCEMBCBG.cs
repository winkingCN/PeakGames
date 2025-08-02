using System.Collections.Generic;
using Caravan.Meta.LevelMeta;
using GamePlayScene.Mechanics;
using UnityEngine;

public class HICNCEMBCBG
{
	private readonly HDNHKJHOCHB[] JJGLGGEKJAE;

	private readonly List<ALIFCLNJKPH> CDMLDAGGCKF;

	private readonly List<ALIFCLNJKPH> OBLCJKKJBJB;

	public int NOKHLKEMOCF;

	public bool FBMKCAPINBJ;

	public List<int> DBLFDGPOLNG;

	public int MCIJGEAPGMJ;

	public int DJFGPBCGLEF;

	private int[] DLNHOENPFHJ;

	private DNJKLNPHPOF[] BFCJABBMHJP;

	private int[] FDPHFLBGEEN;

	private KFCEILFGADG NLKHKDBCLMB;

	private int ECHLEAFFFGB;

	private int FMEDGKDDFOG;

	private int AKKLDALGBIE;

	private FCPPDOMBLHL AJPNGAEMOMC;

	private readonly List<int> AMFOBLJIMKK = new List<int>();

	private int[] KPHLMKPFLIH;

	private NOALGNJECAD[] BIHIJLFLPPI;

	private HashSet<int> MKCJBIPMHHE = new HashSet<int>();

	public bool FACLJMKMCBD
	{
		get
		{
			return BFCJABBMHJP.Length > 0;
		}
	}

	public bool COMOHDMIFJN
	{
		get
		{
			return MCIJGEAPGMJ > 0;
		}
	}

	public FCPPDOMBLHL INFAGKCBEHL
	{
		get
		{
			return AJPNGAEMOMC;
		}
	}

	public List<int> DLJPFHJPABB
	{
		get
		{
			return AMFOBLJIMKK;
		}
	}

	public HICNCEMBCBG(GroupMetaData HACNHAFKGCH, FCPPDOMBLHL KEKPBEKCPNN)
	{
		HLKCFGJJBAP(HACNHAFKGCH.BarrelWeights);
		AJPNGAEMOMC = KEKPBEKCPNN;
		NOKHLKEMOCF = HACNHAFKGCH.Ratio;
		FBMKCAPINBJ = HACNHAFKGCH.UseForDrop == 1;
		MCIJGEAPGMJ = HACNHAFKGCH.DropInterval;
		DJFGPBCGLEF = HACNHAFKGCH.GeneratePerTurn;
		DBLFDGPOLNG = HACNHAFKGCH.DropPosList.IKBFGGABMKP();
		foreach (TiledObjectMetaData item2 in HACNHAFKGCH.Items)
		{
			AMFOBLJIMKK.Add(item2.Id);
		}
		List<DNJKLNPHPOF> list = new List<DNJKLNPHPOF>();
		List<int> list2 = new List<int>();
		List<int> list3 = new List<int>();
		int num = 0;
		foreach (TiledObjectMetaData item3 in HACNHAFKGCH.Items)
		{
			ALIFCLNJKPH id = (ALIFCLNJKPH)item3.Id;
			NOALGNJECAD hBBIFNLDKPO = id.AMLEHGPGGIC();
			ItemResourcesManager.GABGKBAKHDP.InitItem(hBBIFNLDKPO);
			DNJKLNPHPOF item = new DNJKLNPHPOF(hBBIFNLDKPO, id, new DLKLKMDJOOJ(item3.Properties));
			list.Add(item);
			int num2 = ((item3.Ratio == 0) ? 1 : item3.Ratio);
			num += num2;
			list3.Add(num);
			list2.Add(num2);
			switch (id)
			{
			case ALIFCLNJKPH.ColoredBallon1:
			case ALIFCLNJKPH.ColoredBallon2:
			case ALIFCLNJKPH.ColoredBallon3:
			case ALIFCLNJKPH.ColoredBallon4:
			case ALIFCLNJKPH.ColoredBallon5:
			case ALIFCLNJKPH.ColoredBallon6:
				if (OBLCJKKJBJB == null)
				{
					OBLCJKKJBJB = new List<ALIFCLNJKPH>();
				}
				OBLCJKKJBJB.Add(id);
				break;
			case ALIFCLNJKPH.Duck1:
			case ALIFCLNJKPH.Duck2:
			case ALIFCLNJKPH.Duck3:
			case ALIFCLNJKPH.Duck4:
			case ALIFCLNJKPH.Duck5:
				if (CDMLDAGGCKF == null)
				{
					CDMLDAGGCKF = new List<ALIFCLNJKPH>();
				}
				CDMLDAGGCKF.Add(id);
				break;
			}
		}
		if (HACNHAFKGCH.Conditions.Count > 0)
		{
			List<HDNHKJHOCHB> list4 = new List<HDNHKJHOCHB>();
			int count = HACNHAFKGCH.Conditions.Count;
			for (int i = 0; i < count; i++)
			{
				list4.Add(ADKNCEGPEOE(HACNHAFKGCH.Conditions[i]));
			}
			JJGLGGEKJAE = list4.ToArray();
		}
		BFCJABBMHJP = list.ToArray();
		DLNHOENPFHJ = list3.ToArray();
		FDPHFLBGEEN = list2.ToArray();
	}

	private void HLKCFGJJBAP(string JKPAOAEOEPM)
	{
		if (string.IsNullOrEmpty(JKPAOAEOEPM))
		{
			BIHIJLFLPPI = new NOALGNJECAD[3]
			{
				NOALGNJECAD.Rocket,
				NOALGNJECAD.Bomb,
				NOALGNJECAD.DiscoBall
			};
			KPHLMKPFLIH = new int[3] { 1, 2, 3 };
			return;
		}
		List<NOALGNJECAD> list = new List<NOALGNJECAD>();
		List<int> list2 = new List<int>();
		int num = 0;
		string[] array = JKPAOAEOEPM.Split(',');
		if (array.Length > 0)
		{
			int i = 0;
			for (int num2 = array.Length; i < num2; i++)
			{
				string[] array2 = array[i].Split(':');
				string text = array2[0];
				int num3 = int.Parse(array2[1]);
				NOALGNJECAD item;
				switch (text)
				{
				default:
					item = NOALGNJECAD.Rocket;
					break;
				case "b":
					item = NOALGNJECAD.Bomb;
					break;
				case "d":
					item = NOALGNJECAD.DiscoBall;
					break;
				}
				num += num3;
				list.Add(item);
				list2.Add(num);
			}
		}
		BIHIJLFLPPI = list.ToArray();
		KPHLMKPFLIH = list2.ToArray();
	}

	private HDNHKJHOCHB ADKNCEGPEOE(MapFieldEntry GBKPDDDJOFO)
	{
		string text = GBKPDDDJOFO.key.ToLowerInvariant();
		string value = GBKPDDDJOFO.value;
		switch (text)
		{
		case "countofballoon":
			return new GLMHPPCHCJN(NOALGNJECAD.Balloon, value);
		case "countofwatermelon":
			return new GLMHPPCHCJN(NOALGNJECAD.WaterMelon, value);
		case "countofcoloredballoon":
			return new GLMHPPCHCJN(NOALGNJECAD.ColoredBalloon, value);
		case "countofgiantduck":
			return new GLMHPPCHCJN(NOALGNJECAD.GiantDuck, value);
		case "countofduck":
			return new GLMHPPCHCJN(NOALGNJECAD.Duck, value);
		case "countofjelly":
			return new GLMHPPCHCJN(NOALGNJECAD.Jelly, value);
		default:
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.ItemGroup, "Cannot create condition. Unknown condition: {0}", text);
			return null;
		}
	}

	public bool EMOJFNJLEEL()
	{
		if (BFCJABBMHJP.Length == 0)
		{
			return false;
		}
		if (ECHLEAFFFGB != NLKHKDBCLMB.ABNJCFOELCB)
		{
			ECHLEAFFFGB = NLKHKDBCLMB.ABNJCFOELCB;
			FMEDGKDDFOG = 0;
		}
		if (JJGLGGEKJAE != null && JJGLGGEKJAE.Length > 0)
		{
			int num = JJGLGGEKJAE.Length;
			for (int i = 0; i < num; i++)
			{
				if (!JJGLGGEKJAE[i].KFEIOECKONB(NLKHKDBCLMB))
				{
					return false;
				}
			}
		}
		bool flag = DJFGPBCGLEF == 0 || FMEDGKDDFOG < DJFGPBCGLEF;
		return FACLJMKMCBD && flag;
	}

	public void LKGFHCJKIPE(KFCEILFGADG GIOFHACJEGA)
	{
		NLKHKDBCLMB = GIOFHACJEGA;
	}

	public DNJKLNPHPOF EGNAIPPHGPM(int NMPJCKJIOKL)
	{
		if (!EMOJFNJLEEL())
		{
			return MCJHHDACJBG.ICBPPNNACEJ;
		}
		DNJKLNPHPOF dNJKLNPHPOF = MOJEAICLNNL(NMPJCKJIOKL);
		if (!dNJKLNPHPOF.APDFDPJHIHE)
		{
			return MCJHHDACJBG.ICBPPNNACEJ;
		}
		ALIFCLNJKPH nGCKFDDHOFB = ALIFCLNJKPH.None;
		switch (dNJKLNPHPOF.OCHKLAKCFJC)
		{
		case NOALGNJECAD.Duck:
			nGCKFDDHOFB = FMLOEALEIHF();
			break;
		case NOALGNJECAD.ColoredBalloon:
			nGCKFDDHOFB = LDNJPCPBAOO();
			break;
		case NOALGNJECAD.DiscoBall:
			nGCKFDDHOFB = dNJKLNPHPOF.BFBNLNAHLHA;
			break;
		case NOALGNJECAD.Vase:
			nGCKFDDHOFB = dNJKLNPHPOF.BFBNLNAHLHA;
			break;
		}
		FMEDGKDDFOG++;
		return new DNJKLNPHPOF(dNJKLNPHPOF.OCHKLAKCFJC, nGCKFDDHOFB, dNJKLNPHPOF.GBBCHGMFNFH, AJPNGAEMOMC);
	}

	public ALIFCLNJKPH FMLOEALEIHF()
	{
		return (CDMLDAGGCKF != null) ? CDMLDAGGCKF[Random.Range(0, CDMLDAGGCKF.Count)] : ALIFCLNJKPH.None;
	}

	public ALIFCLNJKPH LDNJPCPBAOO()
	{
		return (OBLCJKKJBJB != null) ? OBLCJKKJBJB[BFGGHJGIHLJ.FDFDDKBDPEG(0, OBLCJKKJBJB.Count, 15)] : ALIFCLNJKPH.None;
	}

	public void HCFANPLOMNL(NOALGNJECAD PLCFEOMGCFK)
	{
		if (MKCJBIPMHHE.Contains((int)PLCFEOMGCFK))
		{
			return;
		}
		MKCJBIPMHHE.Add((int)PLCFEOMGCFK);
		List<DNJKLNPHPOF> list = new List<DNJKLNPHPOF>();
		List<int> list2 = new List<int>();
		List<int> list3 = new List<int>();
		int num = 0;
		for (int i = 0; i < BFCJABBMHJP.Length; i++)
		{
			NOALGNJECAD nOALGNJECAD = BFCJABBMHJP[i].OCHKLAKCFJC;
			if (nOALGNJECAD != PLCFEOMGCFK)
			{
				int num2 = FDPHFLBGEEN[i];
				num += num2;
				list.Add(BFCJABBMHJP[i]);
				list2.Add(num);
				list3.Add(num2);
			}
		}
		BFCJABBMHJP = list.ToArray();
		DLNHOENPFHJ = list2.ToArray();
		FDPHFLBGEEN = list3.ToArray();
	}

	public NOALGNJECAD HPBAMJALPMB()
	{
		if (BFCJABBMHJP.Length == 0)
		{
			return NOALGNJECAD.None;
		}
		int num = DLNHOENPFHJ.LLJKKEKFPFG();
		return (num != -1) ? BFCJABBMHJP[num].OCHKLAKCFJC : NOALGNJECAD.None;
	}

	public DNJKLNPHPOF MOJEAICLNNL(int NMPJCKJIOKL)
	{
		if (BFCJABBMHJP.Length == 0)
		{
			return MCJHHDACJBG.ICBPPNNACEJ;
		}
		int num = DLNHOENPFHJ.LLJKKEKFPFG(NMPJCKJIOKL);
		return (num == -1) ? MCJHHDACJBG.ICBPPNNACEJ : BFCJABBMHJP[num];
	}

	public int PDNDANPPGMK()
	{
		if (AMFOBLJIMKK.Count == 0)
		{
			return 0;
		}
		int num = DLNHOENPFHJ.LLJKKEKFPFG();
		if (num != -1)
		{
			return AMFOBLJIMKK[num];
		}
		return 0;
	}

	public bool DNKDIJEDFHO(int ENMLICFLHAO)
	{
		if (ENMLICFLHAO - AKKLDALGBIE <= MCIJGEAPGMJ)
		{
			return false;
		}
		AKKLDALGBIE = ENMLICFLHAO;
		return true;
	}

	public NOALGNJECAD IBPKFANBLIG()
	{
		int num = KPHLMKPFLIH.LLJKKEKFPFG();
		if (num != -1)
		{
			return BIHIJLFLPPI[num];
		}
		return NOALGNJECAD.None;
	}
}
