using System;

public class AEFLFOFIBCC : ECBKNMOGLEG
{
	protected readonly CGDEGBGOKJO MBEMNOCDDBC;

	protected readonly byte[] NIGIDKELODA;

	protected readonly bool HHGGGKFKLHD;

	protected readonly bool DHHNHJLANEO;

	protected readonly JMPFLJGHAIM OEOENDBGPLC;

	protected readonly JMPFLJGHAIM MHBEDFNGKOD;

	protected readonly LHAMCHLCIFH GCOJOEILALI;

	protected readonly LHAMCHLCIFH NNOMIOBGOCM;

	public virtual LHAMCHLCIFH OHGHDNLEMFC
	{
		get
		{
			return GCOJOEILALI;
		}
	}

	public virtual LHAMCHLCIFH NENBJPJCNCH
	{
		get
		{
			return NNOMIOBGOCM;
		}
	}

	public AEFLFOFIBCC(CGDEGBGOKJO MBEMNOCDDBC, JMPFLJGHAIM OGICPKHDAGA, JMPFLJGHAIM FBACJKBJPPI, BJLAMONNNDD FPIFEGNLIEG, BJLAMONNNDD LLJMCJPMGHL, int NAJNLOODBFL)
	{
		this.MBEMNOCDDBC = MBEMNOCDDBC;
		NIGIDKELODA = new byte[256];
		MBEMNOCDDBC.EMBMHGPGOIP.GOADFPHGDJG(NIGIDKELODA);
		HHGGGKFKLHD = KINEBFNENMB.IJOEFFKABJB(MBEMNOCDDBC);
		DHHNHJLANEO = MBEMNOCDDBC.HFMNBFOAPOP.DHHNHJLANEO;
		int num = 2 * NAJNLOODBFL + FPIFEGNLIEG.EEMLLAMENHO() + LLJMCJPMGHL.EEMLLAMENHO();
		if (!HHGGGKFKLHD)
		{
			num += OGICPKHDAGA.BDIGGHEPIIP() + FBACJKBJPPI.BDIGGHEPIIP();
		}
		byte[] array = KINEBFNENMB.IJLFLBPLJHD(MBEMNOCDDBC, num);
		int num2 = 0;
		LHAMCHLCIFH lHAMCHLCIFH = new LHAMCHLCIFH(MBEMNOCDDBC, FPIFEGNLIEG, array, num2, FPIFEGNLIEG.EEMLLAMENHO());
		num2 += FPIFEGNLIEG.EEMLLAMENHO();
		LHAMCHLCIFH lHAMCHLCIFH2 = new LHAMCHLCIFH(MBEMNOCDDBC, LLJMCJPMGHL, array, num2, LLJMCJPMGHL.EEMLLAMENHO());
		num2 += LLJMCJPMGHL.EEMLLAMENHO();
		JEMNCGMEABF iJJHBEECMBP = new JEMNCGMEABF(array, num2, NAJNLOODBFL);
		num2 += NAJNLOODBFL;
		JEMNCGMEABF iJJHBEECMBP2 = new JEMNCGMEABF(array, num2, NAJNLOODBFL);
		num2 += NAJNLOODBFL;
		byte[] nDEFBOJOALL;
		byte[] nDEFBOJOALL2;
		if (HHGGGKFKLHD)
		{
			nDEFBOJOALL = new byte[OGICPKHDAGA.BDIGGHEPIIP()];
			nDEFBOJOALL2 = new byte[FBACJKBJPPI.BDIGGHEPIIP()];
		}
		else
		{
			nDEFBOJOALL = NOGCEBKPPJE.EHLHBAMJLNI(array, num2, num2 + OGICPKHDAGA.BDIGGHEPIIP());
			num2 += OGICPKHDAGA.BDIGGHEPIIP();
			nDEFBOJOALL2 = NOGCEBKPPJE.EHLHBAMJLNI(array, num2, num2 + FBACJKBJPPI.BDIGGHEPIIP());
			num2 += FBACJKBJPPI.BDIGGHEPIIP();
		}
		if (num2 != num)
		{
			throw new DEIDBCPPCMB(80);
		}
		IGMAJHKIIPK iJJHBEECMBP3;
		IGMAJHKIIPK iJJHBEECMBP4;
		if (MBEMNOCDDBC.DLHCCNKGKJP)
		{
			GCOJOEILALI = lHAMCHLCIFH2;
			NNOMIOBGOCM = lHAMCHLCIFH;
			OEOENDBGPLC = FBACJKBJPPI;
			MHBEDFNGKOD = OGICPKHDAGA;
			iJJHBEECMBP3 = new CHCELGDKEJG(iJJHBEECMBP2, nDEFBOJOALL2);
			iJJHBEECMBP4 = new CHCELGDKEJG(iJJHBEECMBP, nDEFBOJOALL);
		}
		else
		{
			GCOJOEILALI = lHAMCHLCIFH;
			NNOMIOBGOCM = lHAMCHLCIFH2;
			OEOENDBGPLC = OGICPKHDAGA;
			MHBEDFNGKOD = FBACJKBJPPI;
			iJJHBEECMBP3 = new CHCELGDKEJG(iJJHBEECMBP, nDEFBOJOALL);
			iJJHBEECMBP4 = new CHCELGDKEJG(iJJHBEECMBP2, nDEFBOJOALL2);
		}
		OEOENDBGPLC.DIOELAHNLKJ(true, iJJHBEECMBP3);
		MHBEDFNGKOD.DIOELAHNLKJ(false, iJJHBEECMBP4);
	}

	public virtual int LBEOGHDBCJM(int DOILBJKOFDG)
	{
		int num = OEOENDBGPLC.BDIGGHEPIIP();
		int num2 = GCOJOEILALI.PNBDAGKFOBN;
		int num3 = DOILBJKOFDG;
		if (HHGGGKFKLHD)
		{
			num3 -= num;
		}
		if (DHHNHJLANEO)
		{
			num3 -= num2;
			num3 -= num3 % num;
		}
		else
		{
			num3 -= num3 % num;
			num3 -= num2;
		}
		return num3 - 1;
	}

	public virtual byte[] BIIKEIOAPCJ(long MHCDKMMAMKP, byte NBFBPNNEKMN, byte[] NEOIPBBDIMB, int IBNDGNOIEEF, int NBEDPKHALCN)
	{
		int num = OEOENDBGPLC.BDIGGHEPIIP();
		int num2 = GCOJOEILALI.PNBDAGKFOBN;
		OBDIBELBBEO oBDIBELBBEO = MBEMNOCDDBC.PJJKOIEAGJN;
		int num3 = NBEDPKHALCN;
		if (!DHHNHJLANEO)
		{
			num3 += num2;
		}
		int num4 = num - 1 - num3 % num;
		if (!oBDIBELBBEO.KEDPJOBAJBA && !oBDIBELBBEO.NFEADLBGDGE)
		{
			int nHLJFKPLKLI = (255 - num4) / num;
			int num5 = BDOAMIBIJPD(MBEMNOCDDBC.KMLKPFPCFLA, nHLJFKPLKLI);
			num4 += num5 * num;
		}
		int num6 = NBEDPKHALCN + num2 + num4 + 1;
		if (HHGGGKFKLHD)
		{
			num6 += num;
		}
		byte[] array = new byte[num6];
		int num7 = 0;
		if (HHGGGKFKLHD)
		{
			byte[] array2 = new byte[num];
			MBEMNOCDDBC.EMBMHGPGOIP.GOADFPHGDJG(array2);
			OEOENDBGPLC.DIOELAHNLKJ(true, new CHCELGDKEJG(null, array2));
			Array.Copy(array2, 0, array, num7, num);
			num7 += num;
		}
		int num8 = num7;
		Array.Copy(NEOIPBBDIMB, IBNDGNOIEEF, array, num7, NBEDPKHALCN);
		num7 += NBEDPKHALCN;
		if (!DHHNHJLANEO)
		{
			byte[] array3 = GCOJOEILALI.OFLKIODCBJJ(MHCDKMMAMKP, NBFBPNNEKMN, NEOIPBBDIMB, IBNDGNOIEEF, NBEDPKHALCN);
			Array.Copy(array3, 0, array, num7, array3.Length);
			num7 += array3.Length;
		}
		for (int i = 0; i <= num4; i++)
		{
			array[num7++] = (byte)num4;
		}
		for (int j = num8; j < num7; j += num)
		{
			OEOENDBGPLC.DPACJDFHLKB(array, j, array, j);
		}
		if (DHHNHJLANEO)
		{
			byte[] array4 = GCOJOEILALI.OFLKIODCBJJ(MHCDKMMAMKP, NBFBPNNEKMN, array, 0, num7);
			Array.Copy(array4, 0, array, num7, array4.Length);
			num7 += array4.Length;
		}
		return array;
	}

	public virtual byte[] OBMCLFEIPBL(long MHCDKMMAMKP, byte NBFBPNNEKMN, byte[] JNGDHEECGIG, int IBNDGNOIEEF, int NBEDPKHALCN)
	{
		int num = MHBEDFNGKOD.BDIGGHEPIIP();
		int num2 = NNOMIOBGOCM.PNBDAGKFOBN;
		int num3 = num;
		num3 = ((!DHHNHJLANEO) ? Math.Max(num3, num2 + 1) : (num3 + num2));
		if (HHGGGKFKLHD)
		{
			num3 += num;
		}
		if (NBEDPKHALCN < num3)
		{
			throw new DEIDBCPPCMB(50);
		}
		int num4 = NBEDPKHALCN;
		if (DHHNHJLANEO)
		{
			num4 -= num2;
		}
		if (num4 % num != 0)
		{
			throw new DEIDBCPPCMB(21);
		}
		if (DHHNHJLANEO)
		{
			int num5 = IBNDGNOIEEF + NBEDPKHALCN;
			byte[] bCIHLCMFAEK = NOGCEBKPPJE.EHLHBAMJLNI(JNGDHEECGIG, num5 - num2, num5);
			byte[] mNIMEAMHNMI = NNOMIOBGOCM.OFLKIODCBJJ(MHCDKMMAMKP, NBFBPNNEKMN, JNGDHEECGIG, IBNDGNOIEEF, NBEDPKHALCN - num2);
			if (!NOGCEBKPPJE.PBBFCJBKJEN(mNIMEAMHNMI, bCIHLCMFAEK))
			{
				throw new DEIDBCPPCMB(20);
			}
		}
		if (HHGGGKFKLHD)
		{
			MHBEDFNGKOD.DIOELAHNLKJ(false, new CHCELGDKEJG(null, JNGDHEECGIG, IBNDGNOIEEF, num));
			IBNDGNOIEEF += num;
			num4 -= num;
		}
		for (int i = 0; i < num4; i += num)
		{
			MHBEDFNGKOD.DPACJDFHLKB(JNGDHEECGIG, IBNDGNOIEEF + i, JNGDHEECGIG, IBNDGNOIEEF + i);
		}
		int num6 = LPOKMKKNJDL(JNGDHEECGIG, IBNDGNOIEEF, num4, num, (!DHHNHJLANEO) ? num2 : 0);
		bool flag = num6 == 0;
		int num7 = num4 - num6;
		if (!DHHNHJLANEO)
		{
			num7 -= num2;
			int num8 = num7;
			int num9 = IBNDGNOIEEF + num8;
			byte[] bCIHLCMFAEK2 = NOGCEBKPPJE.EHLHBAMJLNI(JNGDHEECGIG, num9, num9 + num2);
			byte[] mNIMEAMHNMI2 = NNOMIOBGOCM.CHCPEFHOCJE(MHCDKMMAMKP, NBFBPNNEKMN, JNGDHEECGIG, IBNDGNOIEEF, num8, num4 - num2, NIGIDKELODA);
			flag |= !NOGCEBKPPJE.PBBFCJBKJEN(mNIMEAMHNMI2, bCIHLCMFAEK2);
		}
		if (flag)
		{
			throw new DEIDBCPPCMB(20);
		}
		return NOGCEBKPPJE.EHLHBAMJLNI(JNGDHEECGIG, IBNDGNOIEEF, IBNDGNOIEEF + num7);
	}

	protected virtual int LPOKMKKNJDL(byte[] GHPCHPOHELF, int JBAJPGIAPFF, int NBEDPKHALCN, int NONHELBCKCH, int DLFPGGOCGNE)
	{
		int num = JBAJPGIAPFF + NBEDPKHALCN;
		byte b = GHPCHPOHELF[num - 1];
		int num2 = b & 0xFF;
		int num3 = num2 + 1;
		int num4 = 0;
		byte b2 = 0;
		if ((KINEBFNENMB.NFEADLBGDGE(MBEMNOCDDBC) && num3 > NONHELBCKCH) || DLFPGGOCGNE + num3 > NBEDPKHALCN)
		{
			num3 = 0;
		}
		else
		{
			int num5 = num - num3;
			do
			{
				b2 |= (byte)(GHPCHPOHELF[num5++] ^ b);
			}
			while (num5 < num);
			num4 = num3;
			if (b2 != 0)
			{
				num3 = 0;
			}
		}
		byte[] nIGIDKELODA = NIGIDKELODA;
		while (num4 < 256)
		{
			b2 |= (byte)(nIGIDKELODA[num4++] ^ b);
		}
		nIGIDKELODA[0] ^= b2;
		return num3;
	}

	protected virtual int BDOAMIBIJPD(FBIJJFGLKMK GPGDCCMECGF, int NHLJFKPLKLI)
	{
		int aMFCENFNAJJ = GPGDCCMECGF.LIFIMLDFLGI();
		int val = DMAAFMEECCO(aMFCENFNAJJ);
		return Math.Min(val, NHLJFKPLKLI);
	}

	protected virtual int DMAAFMEECCO(int AMFCENFNAJJ)
	{
		if (AMFCENFNAJJ == 0)
		{
			return 32;
		}
		uint num = (uint)AMFCENFNAJJ;
		int num2 = 0;
		while ((num & 1) == 0)
		{
			num2++;
			num >>= 1;
		}
		return num2;
	}
}
