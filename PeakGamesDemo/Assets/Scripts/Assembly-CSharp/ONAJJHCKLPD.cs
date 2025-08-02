using System;

public class ONAJJHCKLPD : PPHLCNGICDP
{
	public override string KFKMEPMEBND
	{
		get
		{
			return "SHA3-" + GHDKCGGHACP;
		}
	}

	public ONAJJHCKLPD()
		: this(256)
	{
	}

	public ONAJJHCKLPD(int EAJFCEBGGIG)
		: base(OLCOKILNIDB(EAJFCEBGGIG))
	{
	}

	public ONAJJHCKLPD(ONAJJHCKLPD JKHLMLIANAI)
		: base(JKHLMLIANAI)
	{
	}

	private static int OLCOKILNIDB(int EAJFCEBGGIG)
	{
		if (EAJFCEBGGIG == 224 || EAJFCEBGGIG == 256 || EAJFCEBGGIG == 384 || EAJFCEBGGIG == 512)
		{
			return EAJFCEBGGIG;
		}
		throw new ArgumentException(EAJFCEBGGIG + " not supported for SHA-3", "bitLength");
	}

	public override int LCNOFBMOHHM(byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		EMBMFDGDCJG(new byte[1] { 2 }, 0, 2L);
		return base.LCNOFBMOHHM(BILGCJNPJGJ, EMAKNGBIFDC);
	}

	protected override int LCNOFBMOHHM(byte[] BILGCJNPJGJ, int EMAKNGBIFDC, byte AHPFMEIDAGJ, int EMKPJGGIPPL)
	{
		if (EMKPJGGIPPL < 0 || EMKPJGGIPPL > 7)
		{
			throw new ArgumentException("must be in the range [0,7]", "partialBits");
		}
		int num = (AHPFMEIDAGJ & ((1 << EMKPJGGIPPL) - 1)) | (2 << EMKPJGGIPPL);
		int num2 = EMKPJGGIPPL + 2;
		if (num2 >= 8)
		{
			CNLGMLEAJJN[0] = (byte)num;
			EMBMFDGDCJG(CNLGMLEAJJN, 0, 8L);
			num2 -= 8;
			num >>= 8;
		}
		return base.LCNOFBMOHHM(BILGCJNPJGJ, EMAKNGBIFDC, (byte)num, num2);
	}

	public override MIPBJNJHNGA FDCFKGAEJFF()
	{
		return new ONAJJHCKLPD(this);
	}
}
