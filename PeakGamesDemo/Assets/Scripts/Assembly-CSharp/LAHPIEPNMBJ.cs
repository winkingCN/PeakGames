using System;
using Org.BouncyCastle.Math;

public class LAHPIEPNMBJ : ADIMNCBLPFK
{
	private BigInteger OKDPJHOEPBJ;

	private FBIJJFGLKMK GECCLOFELEC;

	public virtual bool GFIOEICPIKI
	{
		get
		{
			return false;
		}
	}

	public virtual void DIOELAHNLKJ(BigInteger IDHLPOFDLKJ, FBIJJFGLKMK GECCLOFELEC)
	{
		OKDPJHOEPBJ = IDHLPOFDLKJ;
		this.GECCLOFELEC = GECCLOFELEC;
	}

	public virtual void DIOELAHNLKJ(BigInteger IDHLPOFDLKJ, BigInteger ELNCCDELMMH, byte[] OEFCOJLNCKP)
	{
		throw new InvalidOperationException("Operation not supported");
	}

	public virtual BigInteger BEEIBADAJMB()
	{
		int bitLength = OKDPJHOEPBJ.BitLength;
		BigInteger bigInteger;
		do
		{
			bigInteger = new BigInteger(bitLength, GECCLOFELEC);
		}
		while (bigInteger.SignValue < 1 || bigInteger.JLPDKNFCNPO(OKDPJHOEPBJ) >= 0);
		return bigInteger;
	}
}
