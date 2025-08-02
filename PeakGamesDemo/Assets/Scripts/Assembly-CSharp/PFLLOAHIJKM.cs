using System;

public class PFLLOAHIJKM : PPHLCNGICDP, AJJIDDMILFB, BJLAMONNNDD
{
	public override string KFKMEPMEBND
	{
		get
		{
			return "SHAKE" + GHDKCGGHACP;
		}
	}

	public PFLLOAHIJKM()
		: this(128)
	{
	}

	public PFLLOAHIJKM(int EAJFCEBGGIG)
		: base(OLCOKILNIDB(EAJFCEBGGIG))
	{
	}

	public PFLLOAHIJKM(PFLLOAHIJKM JKHLMLIANAI)
		: base(JKHLMLIANAI)
	{
	}

	private static int OLCOKILNIDB(int EAJFCEBGGIG)
	{
		if (EAJFCEBGGIG == 128 || EAJFCEBGGIG == 256)
		{
			return EAJFCEBGGIG;
		}
		throw new ArgumentException(EAJFCEBGGIG + " not supported for SHAKE", "bitLength");
	}

	public override int LCNOFBMOHHM(byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		return LCNOFBMOHHM(BILGCJNPJGJ, EMAKNGBIFDC, EEMLLAMENHO());
	}

	public virtual int LCNOFBMOHHM(byte[] BILGCJNPJGJ, int EMAKNGBIFDC, int OMGEKFPBCME)
	{
		JPNHGEDFOOC(BILGCJNPJGJ, EMAKNGBIFDC, OMGEKFPBCME);
		OMOKOKFNBKI();
		return OMGEKFPBCME;
	}

	public virtual int JPNHGEDFOOC(byte[] BILGCJNPJGJ, int EMAKNGBIFDC, int OMGEKFPBCME)
	{
		if (!FIHFLDGIADB)
		{
			EMBMFDGDCJG(new byte[1] { 15 }, 0, 4L);
		}
		IOBPJDNCOGD(BILGCJNPJGJ, EMAKNGBIFDC, (long)OMGEKFPBCME * 8L);
		return OMGEKFPBCME;
	}

	protected override int LCNOFBMOHHM(byte[] BILGCJNPJGJ, int EMAKNGBIFDC, byte AHPFMEIDAGJ, int EMKPJGGIPPL)
	{
		return LCNOFBMOHHM(BILGCJNPJGJ, EMAKNGBIFDC, EEMLLAMENHO(), AHPFMEIDAGJ, EMKPJGGIPPL);
	}

	protected virtual int LCNOFBMOHHM(byte[] BILGCJNPJGJ, int EMAKNGBIFDC, int OMGEKFPBCME, byte AHPFMEIDAGJ, int EMKPJGGIPPL)
	{
		if (EMKPJGGIPPL < 0 || EMKPJGGIPPL > 7)
		{
			throw new ArgumentException("must be in the range [0,7]", "partialBits");
		}
		int num = (AHPFMEIDAGJ & ((1 << EMKPJGGIPPL) - 1)) | (15 << EMKPJGGIPPL);
		int num2 = EMKPJGGIPPL + 4;
		if (num2 >= 8)
		{
			CNLGMLEAJJN[0] = (byte)num;
			EMBMFDGDCJG(CNLGMLEAJJN, 0, 8L);
			num2 -= 8;
			num >>= 8;
		}
		if (num2 > 0)
		{
			CNLGMLEAJJN[0] = (byte)num;
			EMBMFDGDCJG(CNLGMLEAJJN, 0, num2);
		}
		IOBPJDNCOGD(BILGCJNPJGJ, EMAKNGBIFDC, (long)OMGEKFPBCME * 8L);
		OMOKOKFNBKI();
		return OMGEKFPBCME;
	}

	public override MIPBJNJHNGA FDCFKGAEJFF()
	{
		return new PFLLOAHIJKM(this);
	}
}
