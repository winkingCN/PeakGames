using System;
using System.Text;
using Org.BouncyCastle.Math;

internal class LADEDLPFBFM
{
	private readonly BigInteger BGGKMOLHAHB;

	private readonly int HJLOCAEAFMJ;

	public int CCEMPCIMBLB
	{
		get
		{
			return FKPPKKNDDCJ().IntValue;
		}
	}

	public long AKJIGPAAKPI
	{
		get
		{
			return FKPPKKNDDCJ().LongValue;
		}
	}

	public int GEBNMKAGJIG
	{
		get
		{
			return HJLOCAEAFMJ;
		}
	}

	public LADEDLPFBFM(BigInteger BGGKMOLHAHB, int HJLOCAEAFMJ)
	{
		if (HJLOCAEAFMJ < 0)
		{
			throw new ArgumentException("scale may not be negative");
		}
		this.BGGKMOLHAHB = BGGKMOLHAHB;
		this.HJLOCAEAFMJ = HJLOCAEAFMJ;
	}

	private LADEDLPFBFM(LADEDLPFBFM JGFNKHNADHP)
	{
		BGGKMOLHAHB = JGFNKHNADHP.BGGKMOLHAHB;
		HJLOCAEAFMJ = JGFNKHNADHP.HJLOCAEAFMJ;
	}

	public static LADEDLPFBFM BJLJCGFMFOO(BigInteger HIMINGHNIKN, int HJLOCAEAFMJ)
	{
		return new LADEDLPFBFM(HIMINGHNIKN.DOKHFLENGLF(HJLOCAEAFMJ), HJLOCAEAFMJ);
	}

	private void KDAPKLIJACN(LADEDLPFBFM BCIHLCMFAEK)
	{
		if (HJLOCAEAFMJ != BCIHLCMFAEK.HJLOCAEAFMJ)
		{
			throw new ArgumentException("Only SimpleBigDecimal of same scale allowed in arithmetic operations");
		}
	}

	public LADEDLPFBFM DHMHIGDLGNH(int KGDNBPHABID)
	{
		if (KGDNBPHABID < 0)
		{
			throw new ArgumentException("scale may not be negative");
		}
		if (KGDNBPHABID == HJLOCAEAFMJ)
		{
			return this;
		}
		return new LADEDLPFBFM(BGGKMOLHAHB.DOKHFLENGLF(KGDNBPHABID - HJLOCAEAFMJ), KGDNBPHABID);
	}

	public LADEDLPFBFM JEACJNAKLDJ(LADEDLPFBFM BCIHLCMFAEK)
	{
		KDAPKLIJACN(BCIHLCMFAEK);
		return new LADEDLPFBFM(BGGKMOLHAHB.JEACJNAKLDJ(BCIHLCMFAEK.BGGKMOLHAHB), HJLOCAEAFMJ);
	}

	public LADEDLPFBFM JEACJNAKLDJ(BigInteger BCIHLCMFAEK)
	{
		return new LADEDLPFBFM(BGGKMOLHAHB.JEACJNAKLDJ(BCIHLCMFAEK.DOKHFLENGLF(HJLOCAEAFMJ)), HJLOCAEAFMJ);
	}

	public LADEDLPFBFM BHKOFHMDACN()
	{
		return new LADEDLPFBFM(BGGKMOLHAHB.BHKOFHMDACN(), HJLOCAEAFMJ);
	}

	public LADEDLPFBFM FBGIHKPECCO(LADEDLPFBFM BCIHLCMFAEK)
	{
		return JEACJNAKLDJ(BCIHLCMFAEK.BHKOFHMDACN());
	}

	public LADEDLPFBFM FBGIHKPECCO(BigInteger BCIHLCMFAEK)
	{
		return new LADEDLPFBFM(BGGKMOLHAHB.FBGIHKPECCO(BCIHLCMFAEK.DOKHFLENGLF(HJLOCAEAFMJ)), HJLOCAEAFMJ);
	}

	public LADEDLPFBFM IBJBIGNPNEM(LADEDLPFBFM BCIHLCMFAEK)
	{
		KDAPKLIJACN(BCIHLCMFAEK);
		return new LADEDLPFBFM(BGGKMOLHAHB.IBJBIGNPNEM(BCIHLCMFAEK.BGGKMOLHAHB), HJLOCAEAFMJ + HJLOCAEAFMJ);
	}

	public LADEDLPFBFM IBJBIGNPNEM(BigInteger BCIHLCMFAEK)
	{
		return new LADEDLPFBFM(BGGKMOLHAHB.IBJBIGNPNEM(BCIHLCMFAEK), HJLOCAEAFMJ);
	}

	public LADEDLPFBFM MCPDGENJCDB(LADEDLPFBFM BCIHLCMFAEK)
	{
		KDAPKLIJACN(BCIHLCMFAEK);
		BigInteger bigInteger = BGGKMOLHAHB.DOKHFLENGLF(HJLOCAEAFMJ);
		return new LADEDLPFBFM(bigInteger.MCPDGENJCDB(BCIHLCMFAEK.BGGKMOLHAHB), HJLOCAEAFMJ);
	}

	public LADEDLPFBFM MCPDGENJCDB(BigInteger BCIHLCMFAEK)
	{
		return new LADEDLPFBFM(BGGKMOLHAHB.MCPDGENJCDB(BCIHLCMFAEK), HJLOCAEAFMJ);
	}

	public LADEDLPFBFM DOKHFLENGLF(int IDHLPOFDLKJ)
	{
		return new LADEDLPFBFM(BGGKMOLHAHB.DOKHFLENGLF(IDHLPOFDLKJ), HJLOCAEAFMJ);
	}

	public int JLPDKNFCNPO(LADEDLPFBFM HIMINGHNIKN)
	{
		KDAPKLIJACN(HIMINGHNIKN);
		return BGGKMOLHAHB.JLPDKNFCNPO(HIMINGHNIKN.BGGKMOLHAHB);
	}

	public int JLPDKNFCNPO(BigInteger HIMINGHNIKN)
	{
		return BGGKMOLHAHB.JLPDKNFCNPO(HIMINGHNIKN.DOKHFLENGLF(HJLOCAEAFMJ));
	}

	public BigInteger FKPPKKNDDCJ()
	{
		return BGGKMOLHAHB.ABOIOKBIANB(HJLOCAEAFMJ);
	}

	public BigInteger PPNDEMOHHCH()
	{
		LADEDLPFBFM lADEDLPFBFM = new LADEDLPFBFM(BigInteger.One, 1);
		return JEACJNAKLDJ(lADEDLPFBFM.DHMHIGDLGNH(HJLOCAEAFMJ)).FKPPKKNDDCJ();
	}

	public override string ToString()
	{
		if (HJLOCAEAFMJ == 0)
		{
			return BGGKMOLHAHB.ToString();
		}
		BigInteger bigInteger = FKPPKKNDDCJ();
		BigInteger bigInteger2 = BGGKMOLHAHB.FBGIHKPECCO(bigInteger.DOKHFLENGLF(HJLOCAEAFMJ));
		if (BGGKMOLHAHB.SignValue < 0)
		{
			bigInteger2 = BigInteger.One.DOKHFLENGLF(HJLOCAEAFMJ).FBGIHKPECCO(bigInteger2);
		}
		if (bigInteger.SignValue == -1 && !bigInteger2.Equals(BigInteger.Zero))
		{
			bigInteger = bigInteger.JEACJNAKLDJ(BigInteger.One);
		}
		string value = bigInteger.ToString();
		char[] array = new char[HJLOCAEAFMJ];
		string text = bigInteger2.NHMGCGBMCNM(2);
		int length = text.Length;
		int num = HJLOCAEAFMJ - length;
		for (int i = 0; i < num; i++)
		{
			array[i] = '0';
		}
		for (int j = 0; j < length; j++)
		{
			array[num + j] = text[j];
		}
		string value2 = new string(array);
		StringBuilder stringBuilder = new StringBuilder(value);
		stringBuilder.Append(".");
		stringBuilder.Append(value2);
		return stringBuilder.ToString();
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (this == NEMEKIOEOLC)
		{
			return true;
		}
		LADEDLPFBFM lADEDLPFBFM = NEMEKIOEOLC as LADEDLPFBFM;
		if (lADEDLPFBFM == null)
		{
			return false;
		}
		return BGGKMOLHAHB.Equals(lADEDLPFBFM.BGGKMOLHAHB) && HJLOCAEAFMJ == lADEDLPFBFM.HJLOCAEAFMJ;
	}

	public override int GetHashCode()
	{
		return BGGKMOLHAHB.GetHashCode() ^ HJLOCAEAFMJ;
	}
}
