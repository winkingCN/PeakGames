using System.Collections;

public class ODCOKAIMCDB : PBJNLNCIIKM
{
	private IList APMCOKGOALN;

	public void DIOELAHNLKJ(byte[] AMFCENFNAJJ)
	{
		uint[] array = HIHDNGIBEPL.BGPMEOHBNNA(AMFCENFNAJJ);
		if (APMCOKGOALN == null || !NOGCEBKPPJE.ICKLINNFHKK(array, (uint[])APMCOKGOALN[0]))
		{
			APMCOKGOALN = LHFGHNFJIKM.PPPFFFBMGML(8);
			APMCOKGOALN.Add(array);
		}
	}

	public void GGMLLFLIGDP(long DELAPGFJHAP, byte[] BILGCJNPJGJ)
	{
		uint[] aMFCENFNAJJ = HIHDNGIBEPL.NMLPLBDAPDH();
		int num = 0;
		while (DELAPGFJHAP > 0)
		{
			if ((DELAPGFJHAP & 1) != 0)
			{
				DEMJGGBBCGI(num);
				HIHDNGIBEPL.IBJBIGNPNEM(aMFCENFNAJJ, (uint[])APMCOKGOALN[num]);
			}
			num++;
			DELAPGFJHAP >>= 1;
		}
		HIHDNGIBEPL.FAPNKANLPPN(aMFCENFNAJJ, BILGCJNPJGJ);
	}

	private void DEMJGGBBCGI(int DCBMAGOBBEC)
	{
		int num = APMCOKGOALN.Count;
		if (num <= DCBMAGOBBEC)
		{
			uint[] array = (uint[])APMCOKGOALN[num - 1];
			do
			{
				array = NOGCEBKPPJE.IKBFGGABMKP(array);
				HIHDNGIBEPL.IBJBIGNPNEM(array, array);
				APMCOKGOALN.Add(array);
			}
			while (++num <= DCBMAGOBBEC);
		}
	}
}
