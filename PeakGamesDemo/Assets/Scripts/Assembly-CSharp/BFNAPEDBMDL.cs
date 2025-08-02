using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

internal class BFNAPEDBMDL
{
	private PLGGNEJEIIP IKNCPEPOKGJ;

	private bool MAEALKEJALK;

	private int FFLMHILGJIP;

	public virtual void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		if (IJJHBEECMBP is MDAKJDOFCEP)
		{
			IJJHBEECMBP = ((MDAKJDOFCEP)IJJHBEECMBP).KPJHHAAOFOH;
		}
		if (!(IJJHBEECMBP is PLGGNEJEIIP))
		{
			throw new InvalidKeyException("Not an RSA key");
		}
		IKNCPEPOKGJ = (PLGGNEJEIIP)IJJHBEECMBP;
		this.MAEALKEJALK = MAEALKEJALK;
		FFLMHILGJIP = IKNCPEPOKGJ.FILOMPHGFKD.BitLength;
	}

	public virtual int IBGFCPAGGON()
	{
		if (MAEALKEJALK)
		{
			return (FFLMHILGJIP - 1) / 8;
		}
		return (FFLMHILGJIP + 7) / 8;
	}

	public virtual int JOKDJPBGMFH()
	{
		if (MAEALKEJALK)
		{
			return (FFLMHILGJIP + 7) / 8;
		}
		return (FFLMHILGJIP - 1) / 8;
	}

	public virtual BigInteger IHLMGDNBCEK(byte[] HMFPNMDMONK, int ELICNEDIBGB, int DBGBBFPPDCE)
	{
		int num = (FFLMHILGJIP + 7) / 8;
		if (DBGBBFPPDCE > num)
		{
			throw new DataLengthException("input too large for RSA cipher.");
		}
		BigInteger bigInteger = new BigInteger(1, HMFPNMDMONK, ELICNEDIBGB, DBGBBFPPDCE);
		if (bigInteger.JLPDKNFCNPO(IKNCPEPOKGJ.FILOMPHGFKD) >= 0)
		{
			throw new DataLengthException("input too large for RSA cipher.");
		}
		return bigInteger;
	}

	public virtual byte[] GKOAIFHOLOC(BigInteger DIDHNNMKJFE)
	{
		byte[] array = DIDHNNMKJFE.MEOCDOOKOLH();
		if (MAEALKEJALK)
		{
			int num = JOKDJPBGMFH();
			if (array.Length < num)
			{
				byte[] array2 = new byte[num];
				array.CopyTo(array2, array2.Length - array.Length);
				array = array2;
			}
		}
		return array;
	}

	public virtual BigInteger DPACJDFHLKB(BigInteger MOPCLEEGDFB)
	{
		if (IKNCPEPOKGJ is ELKMCBFPHBP)
		{
			ELKMCBFPHBP eLKMCBFPHBP = (ELKMCBFPHBP)IKNCPEPOKGJ;
			BigInteger bigInteger = eLKMCBFPHBP.MBIJHANOCOC;
			BigInteger bigInteger2 = eLKMCBFPHBP.FNPELDEHJKL;
			BigInteger eKFOKNPODBK = eLKMCBFPHBP.OLMGFAMCEPN;
			BigInteger eKFOKNPODBK2 = eLKMCBFPHBP.ECMGIOFKOBP;
			BigInteger hIMINGHNIKN = eLKMCBFPHBP.MLCIDFCJAPM;
			BigInteger bigInteger3 = MOPCLEEGDFB.FGLDMFGEDAD(bigInteger).ICEOCBALAGC(eKFOKNPODBK, bigInteger);
			BigInteger bigInteger4 = MOPCLEEGDFB.FGLDMFGEDAD(bigInteger2).ICEOCBALAGC(eKFOKNPODBK2, bigInteger2);
			BigInteger bigInteger5 = bigInteger3.FBGIHKPECCO(bigInteger4);
			bigInteger5 = bigInteger5.IBJBIGNPNEM(hIMINGHNIKN);
			bigInteger5 = bigInteger5.MODIHOCEKBK(bigInteger);
			BigInteger bigInteger6 = bigInteger5.IBJBIGNPNEM(bigInteger2);
			return bigInteger6.JEACJNAKLDJ(bigInteger4);
		}
		return MOPCLEEGDFB.ICEOCBALAGC(IKNCPEPOKGJ.MFIHJHFAEFB, IKNCPEPOKGJ.FILOMPHGFKD);
	}
}
