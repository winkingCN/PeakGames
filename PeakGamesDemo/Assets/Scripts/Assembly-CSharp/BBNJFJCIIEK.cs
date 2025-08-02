using Org.BouncyCastle.Math;

public class BBNJFJCIIEK
{
	public static readonly string MIBNLJLILLI = "bc_fixed_point";

	public static int JNHBFPGDMPI(BHPIABAGAPB FMFABAKPMLB)
	{
		BigInteger bigInteger = FMFABAKPMLB.BHIJCAOHDCM;
		return (bigInteger != null) ? bigInteger.BitLength : (FMFABAKPMLB.PJNLBAHOKGC + 1);
	}

	public static PMICNCFLGDI LMIIAMHHFPE(LJCCHFLFGJG DAPLBLGNCPK)
	{
		if (DAPLBLGNCPK != null && DAPLBLGNCPK is PMICNCFLGDI)
		{
			return (PMICNCFLGDI)DAPLBLGNCPK;
		}
		return new PMICNCFLGDI();
	}

	public static PMICNCFLGDI KPMDCFDMLFE(JGAFKLGGBGF HPHBDNBJPHB, int PNMOKJEFIDI)
	{
		BHPIABAGAPB bHPIABAGAPB = HPHBDNBJPHB.ECFGFKNLLGH;
		int num = 1 << PNMOKJEFIDI;
		PMICNCFLGDI pMICNCFLGDI = LMIIAMHHFPE(bHPIABAGAPB.IBLDMGPNNBD(HPHBDNBJPHB, MIBNLJLILLI));
		JGAFKLGGBGF[] array = pMICNCFLGDI.JJFOMCAIJPO;
		if (array == null || array.Length < num)
		{
			int num2 = JNHBFPGDMPI(bHPIABAGAPB);
			int eKFOKNPODBK = (num2 + PNMOKJEFIDI - 1) / PNMOKJEFIDI;
			JGAFKLGGBGF[] array2 = new JGAFKLGGBGF[PNMOKJEFIDI];
			array2[0] = HPHBDNBJPHB;
			for (int i = 1; i < PNMOKJEFIDI; i++)
			{
				array2[i] = array2[i - 1].BMHHHPFDNMA(eKFOKNPODBK);
			}
			bHPIABAGAPB.NPDHPEDPAPA(array2);
			array = new JGAFKLGGBGF[num];
			array[0] = bHPIABAGAPB.EFOLNCNGADB;
			for (int num3 = PNMOKJEFIDI - 1; num3 >= 0; num3--)
			{
				JGAFKLGGBGF bCIHLCMFAEK = array2[num3];
				int num4 = 1 << num3;
				for (int j = num4; j < num; j += num4 << 1)
				{
					array[j] = array[j - num4].JEACJNAKLDJ(bCIHLCMFAEK);
				}
			}
			bHPIABAGAPB.NPDHPEDPAPA(array);
			pMICNCFLGDI.JJFOMCAIJPO = array;
			pMICNCFLGDI.EMFKAPJMDCC = PNMOKJEFIDI;
			bHPIABAGAPB.OOGGMOCFMHH(HPHBDNBJPHB, MIBNLJLILLI, pMICNCFLGDI);
		}
		return pMICNCFLGDI;
	}
}
