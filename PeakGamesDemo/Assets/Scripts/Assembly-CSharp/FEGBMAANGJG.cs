using System;
using Org.BouncyCastle.Crypto;

public class FEGBMAANGJG : HLDJIHIKIEB
{
	private readonly DGCIOOEELCP IEDPBFAFGGJ;

	private byte[] DJDKLOJBJCO;

	private int MNIGMJPFNDA;

	public override string KFKMEPMEBND
	{
		get
		{
			return IEDPBFAFGGJ.KFKMEPMEBND;
		}
	}

	public FEGBMAANGJG(DGCIOOEELCP IEDPBFAFGGJ)
	{
		this.IEDPBFAFGGJ = IEDPBFAFGGJ;
	}

	internal int IGDFCNFPGOK()
	{
		return MNIGMJPFNDA;
	}

	public override int BDIGGHEPIIP()
	{
		return IEDPBFAFGGJ.IBGFCPAGGON();
	}

	public override int ACLDAECDPFN(int EOFAGACBNFP)
	{
		return IEDPBFAFGGJ.JOKDJPBGMFH();
	}

	public override int MIMJCMAODEK(int EOFAGACBNFP)
	{
		return 0;
	}

	public override void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		OMOKOKFNBKI();
		IEDPBFAFGGJ.DIOELAHNLKJ(MAEALKEJALK, IJJHBEECMBP);
		DJDKLOJBJCO = new byte[IEDPBFAFGGJ.IBGFCPAGGON() + (MAEALKEJALK ? 1 : 0)];
		MNIGMJPFNDA = 0;
	}

	public override byte[] HBCJNPGKMDP(byte MOPCLEEGDFB)
	{
		if (MNIGMJPFNDA >= DJDKLOJBJCO.Length)
		{
			throw new DataLengthException("attempt to process message to long for cipher");
		}
		DJDKLOJBJCO[MNIGMJPFNDA++] = MOPCLEEGDFB;
		return null;
	}

	public override byte[] POCAGALIPAI(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP)
	{
		if (EOFAGACBNFP < 1)
		{
			return null;
		}
		if (MOPCLEEGDFB == null)
		{
			throw new ArgumentNullException("input");
		}
		if (MNIGMJPFNDA + EOFAGACBNFP > DJDKLOJBJCO.Length)
		{
			throw new DataLengthException("attempt to process message to long for cipher");
		}
		Array.Copy(MOPCLEEGDFB, ELICNEDIBGB, DJDKLOJBJCO, MNIGMJPFNDA, EOFAGACBNFP);
		MNIGMJPFNDA += EOFAGACBNFP;
		return null;
	}

	public override byte[] LCNOFBMOHHM()
	{
		byte[] result = ((MNIGMJPFNDA <= 0) ? HLDJIHIKIEB.FKFAEPHOLIB : IEDPBFAFGGJ.DPACJDFHLKB(DJDKLOJBJCO, 0, MNIGMJPFNDA));
		OMOKOKFNBKI();
		return result;
	}

	public override byte[] LCNOFBMOHHM(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP)
	{
		POCAGALIPAI(MOPCLEEGDFB, ELICNEDIBGB, EOFAGACBNFP);
		return LCNOFBMOHHM();
	}

	public override void OMOKOKFNBKI()
	{
		if (DJDKLOJBJCO != null)
		{
			Array.Clear(DJDKLOJBJCO, 0, DJDKLOJBJCO.Length);
			MNIGMJPFNDA = 0;
		}
	}
}
