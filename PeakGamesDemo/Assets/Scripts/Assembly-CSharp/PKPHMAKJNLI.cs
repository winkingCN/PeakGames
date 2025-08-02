using System;
using Org.BouncyCastle.Math;

public class PKPHMAKJNLI : KLOGJEJCNNM
{
	protected override JGAFKLGGBGF OJGDKAJCDJK(JGAFKLGGBGF HPHBDNBJPHB, BigInteger BENKLGPHLGI)
	{
		int num = Math.Max(2, Math.Min(16, PKCOEDNEJGL(BENKLGPHLGI.BitLength)));
		PPENFIKGBIK pPENFIKGBIK = ABHJGAELGKM.KPMDCFDMLFE(HPHBDNBJPHB, num, true);
		JGAFKLGGBGF[] array = pPENFIKGBIK.JJFOMCAIJPO;
		JGAFKLGGBGF[] array2 = pPENFIKGBIK.JNABIODEPNL;
		int[] array3 = ABHJGAELGKM.GCJNNGOMNFC(num, BENKLGPHLGI);
		JGAFKLGGBGF jGAFKLGGBGF = HPHBDNBJPHB.ECFGFKNLLGH.EFOLNCNGADB;
		int num2 = array3.Length;
		if (num2 > 1)
		{
			int num3 = array3[--num2];
			int num4 = num3 >> 16;
			int num5 = num3 & 0xFFFF;
			int num6 = Math.Abs(num4);
			JGAFKLGGBGF[] array4 = ((num4 >= 0) ? array : array2);
			if (num6 << 2 < 1 << num)
			{
				int num7 = IOPFKLMMOOP.PEPOPLOJOBE[num6];
				int num8 = num - num7;
				int num9 = num6 ^ (1 << num7 - 1);
				int num10 = (1 << num - 1) - 1;
				int num11 = (num9 << num8) + 1;
				jGAFKLGGBGF = array4[num10 >> 1].JEACJNAKLDJ(array4[num11 >> 1]);
				num5 -= num8;
			}
			else
			{
				jGAFKLGGBGF = array4[num6 >> 1];
			}
			jGAFKLGGBGF = jGAFKLGGBGF.BMHHHPFDNMA(num5);
		}
		while (num2 > 0)
		{
			int num12 = array3[--num2];
			int num13 = num12 >> 16;
			int eKFOKNPODBK = num12 & 0xFFFF;
			int num14 = Math.Abs(num13);
			JGAFKLGGBGF[] array5 = ((num13 >= 0) ? array : array2);
			JGAFKLGGBGF bCIHLCMFAEK = array5[num14 >> 1];
			jGAFKLGGBGF = jGAFKLGGBGF.GFLGEFHLIGE(bCIHLCMFAEK);
			jGAFKLGGBGF = jGAFKLGGBGF.BMHHHPFDNMA(eKFOKNPODBK);
		}
		return jGAFKLGGBGF;
	}

	protected virtual int PKCOEDNEJGL(int IODPDKHNDIE)
	{
		return ABHJGAELGKM.PKCOEDNEJGL(IODPDKHNDIE);
	}
}
