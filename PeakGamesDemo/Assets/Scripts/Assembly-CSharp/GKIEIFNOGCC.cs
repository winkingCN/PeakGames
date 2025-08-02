using System;
using Org.BouncyCastle.Math;

public class GKIEIFNOGCC : ADIMNCBLPFK
{
	private readonly PGNLPNFKAPJ MMHKCFMDOLN;

	private readonly byte[] ECPHBOJJFKH;

	private readonly byte[] GOCFBLLGPIL;

	private BigInteger IDHLPOFDLKJ;

	public virtual bool GFIOEICPIKI
	{
		get
		{
			return true;
		}
	}

	public GKIEIFNOGCC(BJLAMONNNDD HABFKBCEIBN)
	{
		MMHKCFMDOLN = new PGNLPNFKAPJ(HABFKBCEIBN);
		GOCFBLLGPIL = new byte[MMHKCFMDOLN.BKGLOJPPBIG()];
		ECPHBOJJFKH = new byte[MMHKCFMDOLN.BKGLOJPPBIG()];
	}

	public virtual void DIOELAHNLKJ(BigInteger IDHLPOFDLKJ, FBIJJFGLKMK GECCLOFELEC)
	{
		throw new InvalidOperationException("Operation not supported");
	}

	public void DIOELAHNLKJ(BigInteger IDHLPOFDLKJ, BigInteger ELNCCDELMMH, byte[] OEFCOJLNCKP)
	{
		this.IDHLPOFDLKJ = IDHLPOFDLKJ;
		NOGCEBKPPJE.MEBLOMPDLEJ(GOCFBLLGPIL, 1);
		NOGCEBKPPJE.MEBLOMPDLEJ(ECPHBOJJFKH, 0);
		byte[] array = new byte[(IDHLPOFDLKJ.BitLength + 7) / 8];
		byte[] array2 = ODBELJAHGIG.HOGKINKACAF(ELNCCDELMMH);
		Array.Copy(array2, 0, array, array.Length - array2.Length, array2.Length);
		byte[] array3 = new byte[(IDHLPOFDLKJ.BitLength + 7) / 8];
		BigInteger bigInteger = CLGCDMFPFHO(OEFCOJLNCKP);
		if (bigInteger.JLPDKNFCNPO(IDHLPOFDLKJ) >= 0)
		{
			bigInteger = bigInteger.FBGIHKPECCO(IDHLPOFDLKJ);
		}
		byte[] array4 = ODBELJAHGIG.HOGKINKACAF(bigInteger);
		Array.Copy(array4, 0, array3, array3.Length - array4.Length, array4.Length);
		MMHKCFMDOLN.DIOELAHNLKJ(new JEMNCGMEABF(ECPHBOJJFKH));
		MMHKCFMDOLN.GONEEEFEDGF(GOCFBLLGPIL, 0, GOCFBLLGPIL.Length);
		MMHKCFMDOLN.BPAJGOINFNL(0);
		MMHKCFMDOLN.GONEEEFEDGF(array, 0, array.Length);
		MMHKCFMDOLN.GONEEEFEDGF(array3, 0, array3.Length);
		MMHKCFMDOLN.LCNOFBMOHHM(ECPHBOJJFKH, 0);
		MMHKCFMDOLN.DIOELAHNLKJ(new JEMNCGMEABF(ECPHBOJJFKH));
		MMHKCFMDOLN.GONEEEFEDGF(GOCFBLLGPIL, 0, GOCFBLLGPIL.Length);
		MMHKCFMDOLN.LCNOFBMOHHM(GOCFBLLGPIL, 0);
		MMHKCFMDOLN.GONEEEFEDGF(GOCFBLLGPIL, 0, GOCFBLLGPIL.Length);
		MMHKCFMDOLN.BPAJGOINFNL(1);
		MMHKCFMDOLN.GONEEEFEDGF(array, 0, array.Length);
		MMHKCFMDOLN.GONEEEFEDGF(array3, 0, array3.Length);
		MMHKCFMDOLN.LCNOFBMOHHM(ECPHBOJJFKH, 0);
		MMHKCFMDOLN.DIOELAHNLKJ(new JEMNCGMEABF(ECPHBOJJFKH));
		MMHKCFMDOLN.GONEEEFEDGF(GOCFBLLGPIL, 0, GOCFBLLGPIL.Length);
		MMHKCFMDOLN.LCNOFBMOHHM(GOCFBLLGPIL, 0);
	}

	public virtual BigInteger BEEIBADAJMB()
	{
		byte[] array = new byte[(IDHLPOFDLKJ.BitLength + 7) / 8];
		BigInteger bigInteger;
		while (true)
		{
			int num;
			for (int i = 0; i < array.Length; i += num)
			{
				MMHKCFMDOLN.GONEEEFEDGF(GOCFBLLGPIL, 0, GOCFBLLGPIL.Length);
				MMHKCFMDOLN.LCNOFBMOHHM(GOCFBLLGPIL, 0);
				num = Math.Min(array.Length - i, GOCFBLLGPIL.Length);
				Array.Copy(GOCFBLLGPIL, 0, array, i, num);
			}
			bigInteger = CLGCDMFPFHO(array);
			if (bigInteger.SignValue > 0 && bigInteger.JLPDKNFCNPO(IDHLPOFDLKJ) < 0)
			{
				break;
			}
			MMHKCFMDOLN.GONEEEFEDGF(GOCFBLLGPIL, 0, GOCFBLLGPIL.Length);
			MMHKCFMDOLN.BPAJGOINFNL(0);
			MMHKCFMDOLN.LCNOFBMOHHM(ECPHBOJJFKH, 0);
			MMHKCFMDOLN.DIOELAHNLKJ(new JEMNCGMEABF(ECPHBOJJFKH));
			MMHKCFMDOLN.GONEEEFEDGF(GOCFBLLGPIL, 0, GOCFBLLGPIL.Length);
			MMHKCFMDOLN.LCNOFBMOHHM(GOCFBLLGPIL, 0);
		}
		return bigInteger;
	}

	private BigInteger CLGCDMFPFHO(byte[] LLIEHCKNJEM)
	{
		BigInteger bigInteger = new BigInteger(1, LLIEHCKNJEM);
		if (LLIEHCKNJEM.Length * 8 > IDHLPOFDLKJ.BitLength)
		{
			bigInteger = bigInteger.ABOIOKBIANB(LLIEHCKNJEM.Length * 8 - IDHLPOFDLKJ.BitLength);
		}
		return bigInteger;
	}
}
