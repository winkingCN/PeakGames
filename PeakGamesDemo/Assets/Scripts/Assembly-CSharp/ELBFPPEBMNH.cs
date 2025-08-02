using System;

public class ELBFPPEBMNH : ECBKNMOGLEG
{
	public const int BJDHNMDAHOC = 1;

	internal const int AAMGKBBKBGC = 2;

	protected readonly CGDEGBGOKJO MBEMNOCDDBC;

	protected readonly int DLFPGGOCGNE;

	protected readonly int DDBLJEGHADO;

	protected readonly KJLBDGGBCCF OEOENDBGPLC;

	protected readonly KJLBDGGBCCF MHBEDFNGKOD;

	protected readonly byte[] FPKNPFPHCJK;

	protected readonly byte[] NFKKNDHGPFI;

	protected readonly int PDNNJKNGNJO;

	public ELBFPPEBMNH(CGDEGBGOKJO MBEMNOCDDBC, KJLBDGGBCCF OGICPKHDAGA, KJLBDGGBCCF FBACJKBJPPI, int NAJNLOODBFL, int DLFPGGOCGNE)
		: this(MBEMNOCDDBC, OGICPKHDAGA, FBACJKBJPPI, NAJNLOODBFL, DLFPGGOCGNE, 1)
	{
	}

	internal ELBFPPEBMNH(CGDEGBGOKJO MBEMNOCDDBC, KJLBDGGBCCF OGICPKHDAGA, KJLBDGGBCCF FBACJKBJPPI, int NAJNLOODBFL, int DLFPGGOCGNE, int PDNNJKNGNJO)
	{
		if (!KINEBFNENMB.OHGCLELCPMD(MBEMNOCDDBC))
		{
			throw new DEIDBCPPCMB(80);
		}
		this.PDNNJKNGNJO = PDNNJKNGNJO;
		int num;
		switch (PDNNJKNGNJO)
		{
		case 1:
			num = 4;
			DDBLJEGHADO = 8;
			break;
		case 2:
			num = 12;
			DDBLJEGHADO = 0;
			break;
		default:
			throw new DEIDBCPPCMB(80);
		}
		this.MBEMNOCDDBC = MBEMNOCDDBC;
		this.DLFPGGOCGNE = DLFPGGOCGNE;
		int num2 = 2 * NAJNLOODBFL + 2 * num;
		byte[] array = KINEBFNENMB.IJLFLBPLJHD(MBEMNOCDDBC, num2);
		int num3 = 0;
		JEMNCGMEABF jEMNCGMEABF = new JEMNCGMEABF(array, num3, NAJNLOODBFL);
		num3 += NAJNLOODBFL;
		JEMNCGMEABF jEMNCGMEABF2 = new JEMNCGMEABF(array, num3, NAJNLOODBFL);
		num3 += NAJNLOODBFL;
		byte[] array2 = NOGCEBKPPJE.EHLHBAMJLNI(array, num3, num3 + num);
		num3 += num;
		byte[] array3 = NOGCEBKPPJE.EHLHBAMJLNI(array, num3, num3 + num);
		num3 += num;
		if (num3 != num2)
		{
			throw new DEIDBCPPCMB(80);
		}
		JEMNCGMEABF iKNCPEPOKGJ;
		JEMNCGMEABF iKNCPEPOKGJ2;
		if (MBEMNOCDDBC.DLHCCNKGKJP)
		{
			OEOENDBGPLC = FBACJKBJPPI;
			MHBEDFNGKOD = OGICPKHDAGA;
			FPKNPFPHCJK = array3;
			NFKKNDHGPFI = array2;
			iKNCPEPOKGJ = jEMNCGMEABF2;
			iKNCPEPOKGJ2 = jEMNCGMEABF;
		}
		else
		{
			OEOENDBGPLC = OGICPKHDAGA;
			MHBEDFNGKOD = FBACJKBJPPI;
			FPKNPFPHCJK = array2;
			NFKKNDHGPFI = array3;
			iKNCPEPOKGJ = jEMNCGMEABF;
			iKNCPEPOKGJ2 = jEMNCGMEABF2;
		}
		byte[] fHCDMEEPPFG = new byte[num + DDBLJEGHADO];
		OEOENDBGPLC.DIOELAHNLKJ(true, new LPDNGJKFEFF(iKNCPEPOKGJ, 8 * DLFPGGOCGNE, fHCDMEEPPFG));
		MHBEDFNGKOD.DIOELAHNLKJ(false, new LPDNGJKFEFF(iKNCPEPOKGJ2, 8 * DLFPGGOCGNE, fHCDMEEPPFG));
	}

	public virtual int LBEOGHDBCJM(int DOILBJKOFDG)
	{
		return DOILBJKOFDG - DLFPGGOCGNE - DDBLJEGHADO;
	}

	public virtual byte[] BIIKEIOAPCJ(long MHCDKMMAMKP, byte NBFBPNNEKMN, byte[] NEOIPBBDIMB, int IBNDGNOIEEF, int NBEDPKHALCN)
	{
		byte[] array = new byte[FPKNPFPHCJK.Length + DDBLJEGHADO];
		switch (PDNNJKNGNJO)
		{
		case 1:
			Array.Copy(FPKNPFPHCJK, 0, array, 0, FPKNPFPHCJK.Length);
			KINEBFNENMB.JCMFNDAOIPC(MHCDKMMAMKP, array, FPKNPFPHCJK.Length);
			break;
		case 2:
		{
			KINEBFNENMB.JCMFNDAOIPC(MHCDKMMAMKP, array, array.Length - 8);
			for (int i = 0; i < FPKNPFPHCJK.Length; i++)
			{
				array[i] ^= FPKNPFPHCJK[i];
			}
			break;
		}
		default:
			throw new DEIDBCPPCMB(80);
		}
		int num = OEOENDBGPLC.ACLDAECDPFN(NBEDPKHALCN);
		byte[] array2 = new byte[DDBLJEGHADO + num];
		if (DDBLJEGHADO != 0)
		{
			Array.Copy(array, array.Length - DDBLJEGHADO, array2, 0, DDBLJEGHADO);
		}
		int dDBLJEGHADO = DDBLJEGHADO;
		byte[] cKJHHGBELEG = ELIMFJJGAMN(MHCDKMMAMKP, NBFBPNNEKMN, NBEDPKHALCN);
		LPDNGJKFEFF iJJHBEECMBP = new LPDNGJKFEFF(null, 8 * DLFPGGOCGNE, array, cKJHHGBELEG);
		try
		{
			OEOENDBGPLC.DIOELAHNLKJ(true, iJJHBEECMBP);
			dDBLJEGHADO += OEOENDBGPLC.POCAGALIPAI(NEOIPBBDIMB, IBNDGNOIEEF, NBEDPKHALCN, array2, dDBLJEGHADO);
			dDBLJEGHADO += OEOENDBGPLC.LCNOFBMOHHM(array2, dDBLJEGHADO);
		}
		catch (Exception cEDNDOAMNOC)
		{
			throw new DEIDBCPPCMB(80, cEDNDOAMNOC);
		}
		if (dDBLJEGHADO != array2.Length)
		{
			throw new DEIDBCPPCMB(80);
		}
		return array2;
	}

	public virtual byte[] OBMCLFEIPBL(long MHCDKMMAMKP, byte NBFBPNNEKMN, byte[] JNGDHEECGIG, int IBNDGNOIEEF, int NBEDPKHALCN)
	{
		if (LBEOGHDBCJM(NBEDPKHALCN) < 0)
		{
			throw new DEIDBCPPCMB(50);
		}
		byte[] array = new byte[NFKKNDHGPFI.Length + DDBLJEGHADO];
		switch (PDNNJKNGNJO)
		{
		case 1:
			Array.Copy(NFKKNDHGPFI, 0, array, 0, NFKKNDHGPFI.Length);
			Array.Copy(JNGDHEECGIG, IBNDGNOIEEF, array, array.Length - DDBLJEGHADO, DDBLJEGHADO);
			break;
		case 2:
		{
			KINEBFNENMB.JCMFNDAOIPC(MHCDKMMAMKP, array, array.Length - 8);
			for (int i = 0; i < NFKKNDHGPFI.Length; i++)
			{
				array[i] ^= NFKKNDHGPFI[i];
			}
			break;
		}
		default:
			throw new DEIDBCPPCMB(80);
		}
		int eLICNEDIBGB = IBNDGNOIEEF + DDBLJEGHADO;
		int nBEDPKHALCN = NBEDPKHALCN - DDBLJEGHADO;
		int num = MHBEDFNGKOD.ACLDAECDPFN(nBEDPKHALCN);
		byte[] array2 = new byte[num];
		int num2 = 0;
		byte[] cKJHHGBELEG = ELIMFJJGAMN(MHCDKMMAMKP, NBFBPNNEKMN, num);
		LPDNGJKFEFF iJJHBEECMBP = new LPDNGJKFEFF(null, 8 * DLFPGGOCGNE, array, cKJHHGBELEG);
		try
		{
			MHBEDFNGKOD.DIOELAHNLKJ(false, iJJHBEECMBP);
			num2 += MHBEDFNGKOD.POCAGALIPAI(JNGDHEECGIG, eLICNEDIBGB, nBEDPKHALCN, array2, num2);
			num2 += MHBEDFNGKOD.LCNOFBMOHHM(array2, num2);
		}
		catch (Exception cEDNDOAMNOC)
		{
			throw new DEIDBCPPCMB(20, cEDNDOAMNOC);
		}
		if (num2 != array2.Length)
		{
			throw new DEIDBCPPCMB(80);
		}
		return array2;
	}

	protected virtual byte[] ELIMFJJGAMN(long MHCDKMMAMKP, byte NBFBPNNEKMN, int NBEDPKHALCN)
	{
		byte[] array = new byte[13];
		KINEBFNENMB.JCMFNDAOIPC(MHCDKMMAMKP, array, 0);
		KINEBFNENMB.JBOHOOBEPAM(NBFBPNNEKMN, array, 8);
		KINEBFNENMB.PPCDKILMGFD(MBEMNOCDDBC.PJJKOIEAGJN, array, 9);
		KINEBFNENMB.PGBAOHFKNHN(NBEDPKHALCN, array, 11);
		return array;
	}
}
