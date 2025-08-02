using System;
using Org.BouncyCastle.Math;

public class AFOOEMDPOPO : DOGLMBOAGOG
{
	private AEIKMJPPOMN IKNCPEPOKGJ;

	private CLBPDHGBHML IFEEEDFDKMB;

	public virtual void DIOELAHNLKJ(IGMAJHKIIPK IJJHBEECMBP)
	{
		if (IJJHBEECMBP is MDAKJDOFCEP)
		{
			IJJHBEECMBP = ((MDAKJDOFCEP)IJJHBEECMBP).KPJHHAAOFOH;
		}
		if (!(IJJHBEECMBP is AEIKMJPPOMN))
		{
			throw new ArgumentException("DHEngine expects DHPrivateKeyParameters");
		}
		IKNCPEPOKGJ = (AEIKMJPPOMN)IJJHBEECMBP;
		IFEEEDFDKMB = IKNCPEPOKGJ.KPJHHAAOFOH;
	}

	public virtual int BGGKNJOAMKN()
	{
		return (IKNCPEPOKGJ.KPJHHAAOFOH.MBIJHANOCOC.BitLength + 7) / 8;
	}

	public virtual BigInteger CFEKCGNAKCD(IGMAJHKIIPK OAENDHNGECA)
	{
		if (IKNCPEPOKGJ == null)
		{
			throw new InvalidOperationException("Agreement algorithm not initialised");
		}
		GBBNCENGABI gBBNCENGABI = (GBBNCENGABI)OAENDHNGECA;
		if (!gBBNCENGABI.KPJHHAAOFOH.Equals(IFEEEDFDKMB))
		{
			throw new ArgumentException("Diffie-Hellman public key has wrong parameters.");
		}
		return gBBNCENGABI.MOAGLBJDKKL.ICEOCBALAGC(IKNCPEPOKGJ.CBPFFIBINEH, IFEEEDFDKMB.MBIJHANOCOC);
	}
}
