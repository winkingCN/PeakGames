using UnityEngine;

public class GDPPIIMADKC : FGGOGJLHPHD, IBODGFKAHLF
{
	private static string GPELMAHJNGB = "HelpshiftUnityPlugin";

	private static GDPPIIMADKC INHDFIKKFCP;

	private AndroidJavaObject HBFNDEEAHBJ;

	private GDPPIIMADKC()
	{
		NLPADEFLHIA.FFKACBMBNNP().GINHNILIDHL("HelpshiftInternalLogger", this);
		NCHNJANOADK.FFKACBMBNNP().AGGHDGKNNGL(this);
	}

	public static GDPPIIMADKC FFKACBMBNNP()
	{
		if (INHDFIKKFCP == null)
		{
			INHDFIKKFCP = new GDPPIIMADKC();
		}
		return INHDFIKKFCP;
	}

	private void OFEAFGKALEO(string DFBFLINFFBE, object[] MIDCNFGAIFA)
	{
		NLPADEFLHIA.FFKACBMBNNP().HOGHHPKJOKC("HelpshiftInternalLogger", "hsLoggerWithArgs", DFBFLINFFBE, MIDCNFGAIFA);
	}

	public void HDDMNMIHBKC(string JMHBADGAFLN, string CNKJPAGKAMJ, object[] MIDCNFGAIFA)
	{
		HBFNDEEAHBJ.CallStatic(CNKJPAGKAMJ, MIDCNFGAIFA);
	}

	public void GJGLBDBCJCL()
	{
		HBFNDEEAHBJ = NCHNJANOADK.FFKACBMBNNP().PKHBBNLFKHK().CallStatic<AndroidJavaObject>("getHSLoggerInstance", new object[0]);
	}

	public void ELNCCDELMMH(string OEFCOJLNCKP)
	{
		OFEAFGKALEO("d", new object[2] { GPELMAHJNGB, OEFCOJLNCKP });
	}

	public void EKFOKNPODBK(string OEFCOJLNCKP)
	{
		OFEAFGKALEO("e", new object[2] { GPELMAHJNGB, OEFCOJLNCKP });
	}

	public void PHFLBLJJMLI(string OEFCOJLNCKP)
	{
		OFEAFGKALEO("w", new object[2] { GPELMAHJNGB, OEFCOJLNCKP });
	}

	public void GNGLLMMGOJI(string OEFCOJLNCKP)
	{
		OFEAFGKALEO("f", new object[2] { GPELMAHJNGB, OEFCOJLNCKP });
	}
}
