using UnityEngine;

public class AIEKHPFNBHG : IBODGFKAHLF, FGGOGJLHPHD
{
	private static AndroidJavaObject BGDALCCGCLK = null;

	private static AIEKHPFNBHG FAONJPHAFFE = new AIEKHPFNBHG();

	private AIEKHPFNBHG()
	{
	}

	public void HDDMNMIHBKC(string JMHBADGAFLN, string CNKJPAGKAMJ, object[] MIDCNFGAIFA)
	{
	}

	public void GJGLBDBCJCL()
	{
		BGDALCCGCLK = NCHNJANOADK.FFKACBMBNNP().PKHBBNLFKHK().CallStatic<AndroidJavaObject>("getHelpshiftLogInstance", new object[0]);
	}

	private static void EDOFPFDEIDH()
	{
		if (BGDALCCGCLK == null)
		{
			NLPADEFLHIA.FFKACBMBNNP().GINHNILIDHL("helpshiftandroidlog", FAONJPHAFFE);
			NCHNJANOADK.FFKACBMBNNP().AGGHDGKNNGL(FAONJPHAFFE);
		}
	}

	public static int AAIEJDNAODP(string MOKLDCMGFFB, string DBONNDOKLCF)
	{
		EDOFPFDEIDH();
		NLPADEFLHIA.FFKACBMBNNP().BGONEKPEOJC();
		return BGDALCCGCLK.CallStatic<int>("v", new object[2] { MOKLDCMGFFB, DBONNDOKLCF });
	}

	public static int ELNCCDELMMH(string MOKLDCMGFFB, string DBONNDOKLCF)
	{
		EDOFPFDEIDH();
		NLPADEFLHIA.FFKACBMBNNP().BGONEKPEOJC();
		return BGDALCCGCLK.CallStatic<int>("d", new object[2] { MOKLDCMGFFB, DBONNDOKLCF });
	}

	public static int PLCFEOMGCFK(string MOKLDCMGFFB, string DBONNDOKLCF)
	{
		EDOFPFDEIDH();
		NLPADEFLHIA.FFKACBMBNNP().BGONEKPEOJC();
		return BGDALCCGCLK.CallStatic<int>("i", new object[2] { MOKLDCMGFFB, DBONNDOKLCF });
	}

	public static int PHFLBLJJMLI(string MOKLDCMGFFB, string DBONNDOKLCF)
	{
		EDOFPFDEIDH();
		NLPADEFLHIA.FFKACBMBNNP().BGONEKPEOJC();
		return BGDALCCGCLK.CallStatic<int>("w", new object[2] { MOKLDCMGFFB, DBONNDOKLCF });
	}

	public static int EKFOKNPODBK(string MOKLDCMGFFB, string DBONNDOKLCF)
	{
		EDOFPFDEIDH();
		NLPADEFLHIA.FFKACBMBNNP().BGONEKPEOJC();
		return BGDALCCGCLK.CallStatic<int>("e", new object[2] { MOKLDCMGFFB, DBONNDOKLCF });
	}
}
