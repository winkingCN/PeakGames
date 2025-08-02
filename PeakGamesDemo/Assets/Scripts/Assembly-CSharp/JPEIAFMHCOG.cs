using System;
using Org.BouncyCastle.Math;

public class JPEIAFMHCOG : KLOGJEJCNNM
{
	protected override JGAFKLGGBGF OJGDKAJCDJK(JGAFKLGGBGF HPHBDNBJPHB, BigInteger BENKLGPHLGI)
	{
		BHPIABAGAPB bHPIABAGAPB = HPHBDNBJPHB.ECFGFKNLLGH;
		int num = BBNJFJCIIEK.JNHBFPGDMPI(bHPIABAGAPB);
		if (BENKLGPHLGI.BitLength > num)
		{
			throw new InvalidOperationException("fixed-point comb doesn't support scalars larger than the curve order");
		}
		int pNMOKJEFIDI = HPCDIIDODOM(num);
		PMICNCFLGDI pMICNCFLGDI = BBNJFJCIIEK.KPMDCFDMLFE(HPHBDNBJPHB, pNMOKJEFIDI);
		JGAFKLGGBGF[] array = pMICNCFLGDI.JJFOMCAIJPO;
		int num2 = pMICNCFLGDI.EMFKAPJMDCC;
		int num3 = (num + num2 - 1) / num2;
		JGAFKLGGBGF jGAFKLGGBGF = bHPIABAGAPB.EFOLNCNGADB;
		int num4 = num3 * num2 - 1;
		for (int i = 0; i < num3; i++)
		{
			int num5 = 0;
			for (int num6 = num4 - i; num6 >= 0; num6 -= num3)
			{
				num5 <<= 1;
				if (BENKLGPHLGI.NJHNJHGDCIJ(num6))
				{
					num5 |= 1;
				}
			}
			jGAFKLGGBGF = jGAFKLGGBGF.GFLGEFHLIGE(array[num5]);
		}
		return jGAFKLGGBGF;
	}

	protected virtual int HPCDIIDODOM(int ACGLIHGLAEB)
	{
		return (ACGLIHGLAEB <= 257) ? 5 : 6;
	}
}
