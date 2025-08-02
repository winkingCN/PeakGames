using System;
using System.IO;
using Org.BouncyCastle.Crypto;

public abstract class HFGFAOLJPHF
{
	public static byte[] AANGBKGHEJJ(CGDEGBGOKJO MBEMNOCDDBC, PLGGNEJEIIP DKEGLHLDOED, Stream BILGCJNPJGJ)
	{
		byte[] array = new byte[48];
		MBEMNOCDDBC.KMLKPFPCFLA.NextBytes(array);
		KINEBFNENMB.PPCDKILMGFD(MBEMNOCDDBC.BEHNDIMGDKM, array, 0);
		ODMDKFPOHIL oDMDKFPOHIL = new ODMDKFPOHIL(new EPDGODLEJEF());
		oDMDKFPOHIL.DIOELAHNLKJ(true, new MDAKJDOFCEP(DKEGLHLDOED, MBEMNOCDDBC.KMLKPFPCFLA));
		try
		{
			byte[] array2 = oDMDKFPOHIL.DPACJDFHLKB(array, 0, array.Length);
			if (KINEBFNENMB.NFEADLBGDGE(MBEMNOCDDBC))
			{
				BILGCJNPJGJ.Write(array2, 0, array2.Length);
			}
			else
			{
				KINEBFNENMB.HIPJBHBLGEI(array2, BILGCJNPJGJ);
			}
		}
		catch (InvalidCipherTextException cEDNDOAMNOC)
		{
			throw new DEIDBCPPCMB(80, cEDNDOAMNOC);
		}
		return array;
	}

	public static byte[] JKPOBLLDCMM(CGDEGBGOKJO MBEMNOCDDBC, PLGGNEJEIIP IFACOJJALDO, byte[] HLIAONOOKAD)
	{
		OBDIBELBBEO oBDIBELBBEO = MBEMNOCDDBC.BEHNDIMGDKM;
		bool flag = false;
		byte[] array = new byte[48];
		MBEMNOCDDBC.KMLKPFPCFLA.NextBytes(array);
		byte[] array2 = NOGCEBKPPJE.IKBFGGABMKP(array);
		try
		{
			ODMDKFPOHIL oDMDKFPOHIL = new ODMDKFPOHIL(new EPDGODLEJEF(), array);
			oDMDKFPOHIL.DIOELAHNLKJ(false, new MDAKJDOFCEP(IFACOJJALDO, MBEMNOCDDBC.KMLKPFPCFLA));
			array2 = oDMDKFPOHIL.DPACJDFHLKB(HLIAONOOKAD, 0, HLIAONOOKAD.Length);
		}
		catch (Exception)
		{
		}
		if (!flag || !oBDIBELBBEO.BMJPEMBKPII(OBDIBELBBEO.PBNEGCKIBHE))
		{
			int num = (oBDIBELBBEO.LHJCOHDLJAO ^ (array2[0] & 0xFF)) | (oBDIBELBBEO.JBFBIHMBNDA ^ (array2[1] & 0xFF));
			num |= num >> 1;
			num |= num >> 2;
			num |= num >> 4;
			int num2 = ~((num & 1) - 1);
			for (int i = 0; i < 48; i++)
			{
				array2[i] = (byte)((array2[i] & ~num2) | (array[i] & num2));
			}
		}
		return array2;
	}
}
