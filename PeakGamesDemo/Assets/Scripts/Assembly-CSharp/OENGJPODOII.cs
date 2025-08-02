using Org.BouncyCastle.Math;

public class OENGJPODOII : BBIBEHOGPHK, EEDGOJILEDE
{
	protected readonly BHPIABAGAPB DNLENPOIJNE;

	protected readonly LEACCAIJMEP CLMJOPEDICI;

	protected readonly LFADADGHPPC GMGCEKMJKAL;

	public virtual LFADADGHPPC ABJHMAEGCCD
	{
		get
		{
			return GMGCEKMJKAL;
		}
	}

	public virtual bool KGPNOBKADCP
	{
		get
		{
			return true;
		}
	}

	public OENGJPODOII(BHPIABAGAPB NINILENHPHE, LEACCAIJMEP IJJHBEECMBP)
	{
		DNLENPOIJNE = NINILENHPHE;
		CLMJOPEDICI = IJJHBEECMBP;
		GMGCEKMJKAL = new IHNCFFPEECN(NINILENHPHE.HFENNGHNFLF(IJJHBEECMBP.CGIGOMNCJJP));
	}

	public virtual BigInteger[] MCNKLDGABBN(BigInteger BENKLGPHLGI)
	{
		int lLIEHCKNJEM = CLMJOPEDICI.HFJHAFCIBDJ;
		BigInteger bigInteger = LGMEGKEHCPD(BENKLGPHLGI, CLMJOPEDICI.OENMHODKPOE, lLIEHCKNJEM);
		BigInteger bigInteger2 = LGMEGKEHCPD(BENKLGPHLGI, CLMJOPEDICI.ACBLCPEFOMO, lLIEHCKNJEM);
		BigInteger[] array = CLMJOPEDICI.MHHEJIALEAF;
		BigInteger[] array2 = CLMJOPEDICI.FKAMEJDFKCD;
		BigInteger bigInteger3 = BENKLGPHLGI.FBGIHKPECCO(bigInteger.IBJBIGNPNEM(array[0]).JEACJNAKLDJ(bigInteger2.IBJBIGNPNEM(array2[0])));
		BigInteger bigInteger4 = bigInteger.IBJBIGNPNEM(array[1]).JEACJNAKLDJ(bigInteger2.IBJBIGNPNEM(array2[1])).BHKOFHMDACN();
		return new BigInteger[2] { bigInteger3, bigInteger4 };
	}

	protected virtual BigInteger LGMEGKEHCPD(BigInteger BENKLGPHLGI, BigInteger HJMBDGKAOBP, int LLIEHCKNJEM)
	{
		bool flag = HJMBDGKAOBP.SignValue < 0;
		BigInteger bigInteger = BENKLGPHLGI.IBJBIGNPNEM(HJMBDGKAOBP.DKGOFCBJBPB());
		bool flag2 = bigInteger.NJHNJHGDCIJ(LLIEHCKNJEM - 1);
		bigInteger = bigInteger.ABOIOKBIANB(LLIEHCKNJEM);
		if (flag2)
		{
			bigInteger = bigInteger.JEACJNAKLDJ(BigInteger.One);
		}
		return (!flag) ? bigInteger : bigInteger.BHKOFHMDACN();
	}
}
