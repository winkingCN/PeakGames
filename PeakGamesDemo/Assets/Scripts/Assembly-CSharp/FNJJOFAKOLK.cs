using Org.BouncyCastle.Math;

public class FNJJOFAKOLK : CFMMJCMIGNM
{
	private static readonly int[] GBKHNBIECFG = new int[5] { 3, 5, 17, 257, 65537 };

	private static readonly int KMDHKDJPNOG = GBKHNBIECFG[GBKHNBIECFG.Length - 1];

	private static readonly int FFPAJABDCOH = BigInteger.AGLOJCOAJIK(KMDHKDJPNOG).BitLength;

	protected static readonly BigInteger LEAKKKAONKD = BigInteger.One;

	protected static readonly BigInteger FADLMFALHKG = BigInteger.AGLOJCOAJIK(65537L);

	protected const int CIGJKEJCMLJ = 100;

	protected JCOILJHBCKN IJJHBEECMBP;

	public virtual void DIOELAHNLKJ(HPBPDALECOG IJJHBEECMBP)
	{
		if (IJJHBEECMBP is JCOILJHBCKN)
		{
			this.IJJHBEECMBP = (JCOILJHBCKN)IJJHBEECMBP;
		}
		else
		{
			this.IJJHBEECMBP = new JCOILJHBCKN(FADLMFALHKG, IJJHBEECMBP.IPFKDIJBGIM, IJJHBEECMBP.IBANINMCJPP, 100);
		}
	}

	public virtual HOHJPJDGOLF LOFCKPBODIJ()
	{
		int num3;
		BigInteger bigInteger;
		BigInteger bigInteger2;
		BigInteger bigInteger3;
		BigInteger bigInteger5;
		BigInteger bigInteger7;
		BigInteger bigInteger8;
		BigInteger bigInteger9;
		do
		{
			int num = IJJHBEECMBP.IBANINMCJPP;
			int num2 = (num + 1) / 2;
			num3 = num - num2;
			int num4 = num / 3;
			int num5 = num >> 2;
			bigInteger = IJJHBEECMBP.IHOPDFAGDAF;
			bigInteger2 = BGOBCJJJGAB(num2, bigInteger);
			while (true)
			{
				bigInteger3 = BGOBCJJJGAB(num3, bigInteger);
				BigInteger bigInteger4 = bigInteger3.FBGIHKPECCO(bigInteger2).DKGOFCBJBPB();
				if (bigInteger4.BitLength < num4)
				{
					continue;
				}
				bigInteger5 = bigInteger2.IBJBIGNPNEM(bigInteger3);
				if (bigInteger5.BitLength != num)
				{
					bigInteger2 = bigInteger2.HOACPDEKNMK(bigInteger3);
					continue;
				}
				if (ABHJGAELGKM.BKBGONMOPKI(bigInteger5) < num5)
				{
					bigInteger2 = BGOBCJJJGAB(num2, bigInteger);
					continue;
				}
				break;
			}
			if (bigInteger2.JLPDKNFCNPO(bigInteger3) < 0)
			{
				BigInteger bigInteger6 = bigInteger2;
				bigInteger2 = bigInteger3;
				bigInteger3 = bigInteger6;
			}
			bigInteger7 = bigInteger2.FBGIHKPECCO(LEAKKKAONKD);
			bigInteger8 = bigInteger3.FBGIHKPECCO(LEAKKKAONKD);
			BigInteger hIMINGHNIKN = bigInteger7.LBDAFCOKNPE(bigInteger8);
			BigInteger cEKMAJAHNAG = bigInteger7.MCPDGENJCDB(hIMINGHNIKN).IBJBIGNPNEM(bigInteger8);
			bigInteger9 = bigInteger.DDENLEMHHAM(cEKMAJAHNAG);
		}
		while (bigInteger9.BitLength <= num3);
		BigInteger iLBNMEGNMAN = bigInteger9.FGLDMFGEDAD(bigInteger7);
		BigInteger fIKFHCHACNL = bigInteger9.FGLDMFGEDAD(bigInteger8);
		BigInteger nKADLNIOCAI = bigInteger3.DDENLEMHHAM(bigInteger2);
		return new HOHJPJDGOLF(new PLGGNEJEIIP(false, bigInteger5, bigInteger), new ELKMCBFPHBP(bigInteger5, bigInteger, bigInteger9, bigInteger2, bigInteger3, iLBNMEGNMAN, fIKFHCHACNL, nKADLNIOCAI));
	}

	protected virtual BigInteger BGOBCJJJGAB(int EMDNDDBLJGO, BigInteger EKFOKNPODBK)
	{
		bool flag = EKFOKNPODBK.BitLength <= FFPAJABDCOH && NOGCEBKPPJE.KMDACNACKII(GBKHNBIECFG, EKFOKNPODBK.IntValue);
		BigInteger bigInteger;
		do
		{
			bigInteger = new BigInteger(EMDNDDBLJGO, 1, IJJHBEECMBP.IPFKDIJBGIM);
		}
		while (bigInteger.MODIHOCEKBK(EKFOKNPODBK).Equals(LEAKKKAONKD) || !bigInteger.LKECIHLDEIP(IJJHBEECMBP.NPKPLHGJFAJ, true) || (!flag && !EKFOKNPODBK.LBDAFCOKNPE(bigInteger.FBGIHKPECCO(LEAKKKAONKD)).Equals(LEAKKKAONKD)));
		return bigInteger;
	}
}
