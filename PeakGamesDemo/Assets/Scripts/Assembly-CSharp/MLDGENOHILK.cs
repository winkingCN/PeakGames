using System;
using System.Collections.Generic;

public static class MLDGENOHILK
{
	public static JPAALKCPGNB KPBBLFNNPKP(this GCJKICAPOFL GDNININLMFD, bool DPMPHKBBDIO, bool DAOINGJCKGL, KJKAIEHNGAL BGEDKGLJIGM = null)
	{
		JPAALKCPGNB jPAALKCPGNB = GDNININLMFD.FGMDNBEEJCN("cloned skin", DPMPHKBBDIO, DAOINGJCKGL);
		GDNININLMFD.NGKEKDBDPEN(jPAALKCPGNB);
		if (BGEDKGLJIGM != null)
		{
			GDNININLMFD.ODJKPILHIOD();
			BGEDKGLJIGM.FCHLOGCODOA(GDNININLMFD);
		}
		return jPAALKCPGNB;
	}

	public static JPAALKCPGNB FGMDNBEEJCN(this GCJKICAPOFL GDNININLMFD, string FOICJOHEDMH, bool DPMPHKBBDIO = false, bool HFLBINKHLMM = false, bool CANENDBIPLL = true)
	{
		JPAALKCPGNB jPAALKCPGNB = new JPAALKCPGNB(FOICJOHEDMH);
		JPAALKCPGNB jKHLMLIANAI = GDNININLMFD.MBBPBGHKLJM.IBBFJANAMLO;
		JPAALKCPGNB hLCFGIFLPPE = GDNININLMFD.HLCFGIFLPPE;
		if (DPMPHKBBDIO)
		{
			jKHLMLIANAI.BACJEDDPKIJ(jPAALKCPGNB, true, HFLBINKHLMM, CANENDBIPLL);
		}
		if (hLCFGIFLPPE != null)
		{
			hLCFGIFLPPE.BACJEDDPKIJ(jPAALKCPGNB, true, HFLBINKHLMM, CANENDBIPLL);
		}
		return jPAALKCPGNB;
	}

	public static JPAALKCPGNB BNKOCCCOFMO(this JPAALKCPGNB EACICEOMFBA)
	{
		JPAALKCPGNB jPAALKCPGNB = new JPAALKCPGNB(EACICEOMFBA.IOCMOCCFALN + " clone");
		Dictionary<JPAALKCPGNB.CNCHOJOHBLN, OAMNGFLKEFI> dictionary = jPAALKCPGNB.NLADLMOLKLK;
		foreach (KeyValuePair<JPAALKCPGNB.CNCHOJOHBLN, OAMNGFLKEFI> item in EACICEOMFBA.NLADLMOLKLK)
		{
			dictionary[item.Key] = item.Value;
		}
		return jPAALKCPGNB;
	}

	public static void AKOHILHADLB(this JPAALKCPGNB HLCFGIFLPPE, string NFKHLLDFHKO, string BKIFAMKMJID, OAMNGFLKEFI DFHHMKMLCFF, GCJKICAPOFL GDNININLMFD)
	{
		int num = GDNININLMFD.IBOGMECEHLD(NFKHLLDFHKO);
		if (GDNININLMFD == null)
		{
			throw new ArgumentNullException("skeleton", "skeleton cannot be null.");
		}
		if (num == -1)
		{
			throw new ArgumentException(string.Format("Slot '{0}' does not exist in skeleton.", NFKHLLDFHKO), "slotName");
		}
		HLCFGIFLPPE.DJJIHPJOEBF(num, BKIFAMKMJID, DFHHMKMLCFF);
	}

	public static OAMNGFLKEFI JGHJDGIANDD(this JPAALKCPGNB HLCFGIFLPPE, string NFKHLLDFHKO, string BKIFAMKMJID, GCJKICAPOFL GDNININLMFD)
	{
		int num = GDNININLMFD.IBOGMECEHLD(NFKHLLDFHKO);
		if (GDNININLMFD == null)
		{
			throw new ArgumentNullException("skeleton", "skeleton cannot be null.");
		}
		if (num == -1)
		{
			throw new ArgumentException(string.Format("Slot '{0}' does not exist in skeleton.", NFKHLLDFHKO), "slotName");
		}
		return HLCFGIFLPPE.JGHJDGIANDD(num, BKIFAMKMJID);
	}

	public static void AKOHILHADLB(this JPAALKCPGNB HLCFGIFLPPE, int PBPEMFGPGFC, string BKIFAMKMJID, OAMNGFLKEFI DFHHMKMLCFF)
	{
		HLCFGIFLPPE.DJJIHPJOEBF(PBPEMFGPGFC, BKIFAMKMJID, DFHHMKMLCFF);
	}

	public static bool LLJEOGANPAD(this JPAALKCPGNB HLCFGIFLPPE, string NFKHLLDFHKO, string BKIFAMKMJID, GCJKICAPOFL GDNININLMFD)
	{
		int num = GDNININLMFD.IBOGMECEHLD(NFKHLLDFHKO);
		if (GDNININLMFD == null)
		{
			throw new ArgumentNullException("skeleton", "skeleton cannot be null.");
		}
		if (num == -1)
		{
			throw new ArgumentException(string.Format("Slot '{0}' does not exist in skeleton.", NFKHLLDFHKO), "slotName");
		}
		return HLCFGIFLPPE.LLJEOGANPAD(num, BKIFAMKMJID);
	}

	public static bool LLJEOGANPAD(this JPAALKCPGNB HLCFGIFLPPE, int PBPEMFGPGFC, string BKIFAMKMJID)
	{
		return HLCFGIFLPPE.NLADLMOLKLK.Remove(new JPAALKCPGNB.CNCHOJOHBLN(PBPEMFGPGFC, BKIFAMKMJID));
	}

	public static void BOPEPLONIFL(this JPAALKCPGNB HLCFGIFLPPE)
	{
		HLCFGIFLPPE.NLADLMOLKLK.Clear();
	}

	public static void GBKNDKCPBEH(this JPAALKCPGNB IPPHCKILFOA, JPAALKCPGNB JKHLMLIANAI)
	{
		JKHLMLIANAI.BACJEDDPKIJ(IPPHCKILFOA, true, false);
	}

	public static void BACJEDDPKIJ(this JPAALKCPGNB JKHLMLIANAI, JPAALKCPGNB IPPHCKILFOA, bool AJMAKDEFBOL, bool HFLBINKHLMM, bool CANENDBIPLL = true)
	{
		Dictionary<JPAALKCPGNB.CNCHOJOHBLN, OAMNGFLKEFI> dictionary = JKHLMLIANAI.NLADLMOLKLK;
		Dictionary<JPAALKCPGNB.CNCHOJOHBLN, OAMNGFLKEFI> dictionary2 = IPPHCKILFOA.NLADLMOLKLK;
		if (HFLBINKHLMM)
		{
			if (AJMAKDEFBOL)
			{
				foreach (KeyValuePair<JPAALKCPGNB.CNCHOJOHBLN, OAMNGFLKEFI> item in dictionary)
				{
					dictionary2[item.Key] = item.Value.BNKOCCCOFMO(CANENDBIPLL);
				}
				return;
			}
			{
				foreach (KeyValuePair<JPAALKCPGNB.CNCHOJOHBLN, OAMNGFLKEFI> item2 in dictionary)
				{
					if (!dictionary2.ContainsKey(item2.Key))
					{
						dictionary2.Add(item2.Key, item2.Value.BNKOCCCOFMO(CANENDBIPLL));
					}
				}
				return;
			}
		}
		if (AJMAKDEFBOL)
		{
			foreach (KeyValuePair<JPAALKCPGNB.CNCHOJOHBLN, OAMNGFLKEFI> item3 in dictionary)
			{
				dictionary2[item3.Key] = item3.Value;
			}
			return;
		}
		foreach (KeyValuePair<JPAALKCPGNB.CNCHOJOHBLN, OAMNGFLKEFI> item4 in dictionary)
		{
			if (!dictionary2.ContainsKey(item4.Key))
			{
				dictionary2.Add(item4.Key, item4.Value);
			}
		}
	}
}
