using System.Collections.Generic;
using UnityEngine;

public class NCHNJANOADK : FGGOGJLHPHD
{
	private static NCHNJANOADK JCFBKPCPKGJ;

	private static bool ABMJJPCMKGC;

	private HashSet<IBODGFKAHLF> FKFEHMMNBIK = new HashSet<IBODGFKAHLF>();

	private AndroidJavaObject HPEHEKHNMCM;

	private AndroidJavaClass DLLKNELNNKA;

	private AndroidJavaClass AJCFCNOCDKL;

	private NCHNJANOADK()
	{
	}

	public static NCHNJANOADK FFKACBMBNNP()
	{
		if (JCFBKPCPKGJ == null)
		{
			JCFBKPCPKGJ = new NCHNJANOADK();
		}
		return JCFBKPCPKGJ;
	}

	public void NAAGKIKAGPB(IBODGFKAHLF NPKAPNKHGOG, AndroidJavaObject HPEHEKHNMCM)
	{
		this.HPEHEKHNMCM = HPEHEKHNMCM;
		DLLKNELNNKA = new AndroidJavaClass("com.helpshift.dex.HelpshiftDexLoader");
		AJCFCNOCDKL = new AndroidJavaClass("com.helpshift.supportCampaigns.UnityAPIDelegate");
		AGGHDGKNNGL(NPKAPNKHGOG);
		NLPADEFLHIA.FFKACBMBNNP().GINHNILIDHL("dexLoader", this);
		NLPADEFLHIA.FFKACBMBNNP().HOGHHPKJOKC("dexLoader", "loadHelpshiftDex", null, new object[1] { DLLKNELNNKA });
	}

	public void HDDMNMIHBKC(string JMHBADGAFLN, string CNKJPAGKAMJ, object[] MIDCNFGAIFA)
	{
		if (JMHBADGAFLN.Equals("loadHelpshiftDex"))
		{
			MFPPFEGEGLK((AndroidJavaClass)MIDCNFGAIFA[0]);
		}
	}

	private void MFPPFEGEGLK(AndroidJavaClass DLLKNELNNKA)
	{
		AJCFCNOCDKL.CallStatic("installDex", HPEHEKHNMCM);
		ABMJJPCMKGC = true;
		foreach (IBODGFKAHLF item in FKFEHMMNBIK)
		{
			item.GJGLBDBCJCL();
		}
	}

	public void AGGHDGKNNGL(IBODGFKAHLF NPKAPNKHGOG)
	{
		if (!FKFEHMMNBIK.Contains(NPKAPNKHGOG))
		{
			FKFEHMMNBIK.Add(NPKAPNKHGOG);
		}
		if (ABMJJPCMKGC)
		{
			NPKAPNKHGOG.GJGLBDBCJCL();
		}
	}

	public AndroidJavaClass PKHBBNLFKHK()
	{
		return DLLKNELNNKA;
	}
}
