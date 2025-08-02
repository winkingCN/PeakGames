using System;
using System.IO;

public class EDMNPIBGJHH : HLDJIHIKIEB
{
	private readonly BHLOIMJIIIK MFMIFDMEPPO;

	private bool MAEALKEJALK;

	private MemoryStream DJDKLOJBJCO = new MemoryStream();

	public override string KFKMEPMEBND
	{
		get
		{
			return "IES";
		}
	}

	public EDMNPIBGJHH(BHLOIMJIIIK MFMIFDMEPPO)
	{
		if (MFMIFDMEPPO == null)
		{
			throw new ArgumentNullException("engine");
		}
		this.MFMIFDMEPPO = MFMIFDMEPPO;
	}

	public override void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		this.MAEALKEJALK = MAEALKEJALK;
		throw LHFGHNFJIKM.HOAJHBJIAIC("IES");
	}

	public override int BDIGGHEPIIP()
	{
		return 0;
	}

	public override int ACLDAECDPFN(int HAPPHECIDKJ)
	{
		if (MFMIFDMEPPO == null)
		{
			throw new InvalidOperationException("cipher not initialised");
		}
		int num = HAPPHECIDKJ + (int)DJDKLOJBJCO.Length;
		return (!MAEALKEJALK) ? (num - 20) : (num + 20);
	}

	public override int MIMJCMAODEK(int HAPPHECIDKJ)
	{
		return 0;
	}

	public override byte[] HBCJNPGKMDP(byte MOPCLEEGDFB)
	{
		DJDKLOJBJCO.WriteByte(MOPCLEEGDFB);
		return null;
	}

	public override byte[] POCAGALIPAI(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP)
	{
		if (MOPCLEEGDFB == null)
		{
			throw new ArgumentNullException("input");
		}
		if (ELICNEDIBGB < 0)
		{
			throw new ArgumentException("inOff");
		}
		if (EOFAGACBNFP < 0)
		{
			throw new ArgumentException("length");
		}
		if (ELICNEDIBGB + EOFAGACBNFP > MOPCLEEGDFB.Length)
		{
			throw new ArgumentException("invalid offset/length specified for input array");
		}
		DJDKLOJBJCO.Write(MOPCLEEGDFB, ELICNEDIBGB, EOFAGACBNFP);
		return null;
	}

	public override byte[] LCNOFBMOHHM()
	{
		byte[] array = DJDKLOJBJCO.ToArray();
		OMOKOKFNBKI();
		return MFMIFDMEPPO.DPACJDFHLKB(array, 0, array.Length);
	}

	public override byte[] LCNOFBMOHHM(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP)
	{
		POCAGALIPAI(MOPCLEEGDFB, ELICNEDIBGB, EOFAGACBNFP);
		return LCNOFBMOHHM();
	}

	public override void OMOKOKFNBKI()
	{
		DJDKLOJBJCO.SetLength(0L);
	}
}
