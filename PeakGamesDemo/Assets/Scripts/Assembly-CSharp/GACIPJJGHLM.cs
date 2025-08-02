using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

public class GACIPJJGHLM : IJNFIACGEKI
{
	protected readonly ADIMNCBLPFK KFEHJEMADHH;

	protected EBLJDAKGPFF IKNCPEPOKGJ;

	protected FBIJJFGLKMK GECCLOFELEC;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return "DSA";
		}
	}

	public GACIPJJGHLM()
	{
		KFEHJEMADHH = new LAHPIEPNMBJ();
	}

	public GACIPJJGHLM(ADIMNCBLPFK KFEHJEMADHH)
	{
		this.KFEHJEMADHH = KFEHJEMADHH;
	}

	public virtual void DIOELAHNLKJ(bool KGPBDABMHKH, IGMAJHKIIPK IJJHBEECMBP)
	{
		FBIJJFGLKMK mLJKIJIANBL = null;
		if (KGPBDABMHKH)
		{
			if (IJJHBEECMBP is MDAKJDOFCEP)
			{
				MDAKJDOFCEP mDAKJDOFCEP = (MDAKJDOFCEP)IJJHBEECMBP;
				mLJKIJIANBL = mDAKJDOFCEP.IPFKDIJBGIM;
				IJJHBEECMBP = mDAKJDOFCEP.KPJHHAAOFOH;
			}
			if (!(IJJHBEECMBP is OMGLOKJCNKO))
			{
				throw new InvalidKeyException("DSA private key required for signing");
			}
			IKNCPEPOKGJ = (OMGLOKJCNKO)IJJHBEECMBP;
		}
		else
		{
			if (!(IJJHBEECMBP is NFJLHCNCCHB))
			{
				throw new InvalidKeyException("DSA public key required for verification");
			}
			IKNCPEPOKGJ = (NFJLHCNCCHB)IJJHBEECMBP;
		}
		GECCLOFELEC = PMFIFBKAIBN(KGPBDABMHKH && !KFEHJEMADHH.GFIOEICPIKI, mLJKIJIANBL);
	}

	public virtual BigInteger[] HMJHAKCMGHC(byte[] OEFCOJLNCKP)
	{
		JEHNKJOKBGF jEHNKJOKBGF = IKNCPEPOKGJ.KPJHHAAOFOH;
		BigInteger bigInteger = jEHNKJOKBGF.FNPELDEHJKL;
		BigInteger bigInteger2 = OKNFNHPECJN(bigInteger, OEFCOJLNCKP);
		BigInteger bigInteger3 = ((OMGLOKJCNKO)IKNCPEPOKGJ).CBPFFIBINEH;
		if (KFEHJEMADHH.GFIOEICPIKI)
		{
			KFEHJEMADHH.DIOELAHNLKJ(bigInteger, bigInteger3, OEFCOJLNCKP);
		}
		else
		{
			KFEHJEMADHH.DIOELAHNLKJ(bigInteger, GECCLOFELEC);
		}
		BigInteger bigInteger4 = KFEHJEMADHH.BEEIBADAJMB();
		BigInteger bigInteger5 = jEHNKJOKBGF.HBGOKILMBJG.ICEOCBALAGC(bigInteger4, jEHNKJOKBGF.MBIJHANOCOC).MODIHOCEKBK(bigInteger);
		bigInteger4 = bigInteger4.DDENLEMHHAM(bigInteger).IBJBIGNPNEM(bigInteger2.JEACJNAKLDJ(bigInteger3.IBJBIGNPNEM(bigInteger5)));
		BigInteger bigInteger6 = bigInteger4.MODIHOCEKBK(bigInteger);
		return new BigInteger[2] { bigInteger5, bigInteger6 };
	}

	public virtual bool HLJBBONKPDG(byte[] OEFCOJLNCKP, BigInteger GPGDCCMECGF, BigInteger IBBBMACIBGK)
	{
		JEHNKJOKBGF jEHNKJOKBGF = IKNCPEPOKGJ.KPJHHAAOFOH;
		BigInteger bigInteger = jEHNKJOKBGF.FNPELDEHJKL;
		BigInteger bigInteger2 = OKNFNHPECJN(bigInteger, OEFCOJLNCKP);
		if (GPGDCCMECGF.SignValue <= 0 || bigInteger.JLPDKNFCNPO(GPGDCCMECGF) <= 0)
		{
			return false;
		}
		if (IBBBMACIBGK.SignValue <= 0 || bigInteger.JLPDKNFCNPO(IBBBMACIBGK) <= 0)
		{
			return false;
		}
		BigInteger hIMINGHNIKN = IBBBMACIBGK.DDENLEMHHAM(bigInteger);
		BigInteger eKFOKNPODBK = bigInteger2.IBJBIGNPNEM(hIMINGHNIKN).MODIHOCEKBK(bigInteger);
		BigInteger eKFOKNPODBK2 = GPGDCCMECGF.IBJBIGNPNEM(hIMINGHNIKN).MODIHOCEKBK(bigInteger);
		BigInteger cEKMAJAHNAG = jEHNKJOKBGF.MBIJHANOCOC;
		eKFOKNPODBK = jEHNKJOKBGF.HBGOKILMBJG.ICEOCBALAGC(eKFOKNPODBK, cEKMAJAHNAG);
		eKFOKNPODBK2 = ((NFJLHCNCCHB)IKNCPEPOKGJ).MOAGLBJDKKL.ICEOCBALAGC(eKFOKNPODBK2, cEKMAJAHNAG);
		BigInteger bigInteger3 = eKFOKNPODBK.IBJBIGNPNEM(eKFOKNPODBK2).MODIHOCEKBK(cEKMAJAHNAG).MODIHOCEKBK(bigInteger);
		return bigInteger3.Equals(GPGDCCMECGF);
	}

	protected virtual BigInteger OKNFNHPECJN(BigInteger IDHLPOFDLKJ, byte[] OEFCOJLNCKP)
	{
		int eOFAGACBNFP = Math.Min(OEFCOJLNCKP.Length, IDHLPOFDLKJ.BitLength / 8);
		return new BigInteger(1, OEFCOJLNCKP, 0, eOFAGACBNFP);
	}

	protected virtual FBIJJFGLKMK PMFIFBKAIBN(bool EJICKCGPFAH, FBIJJFGLKMK MLJKIJIANBL)
	{
		return (!EJICKCGPFAH) ? null : ((MLJKIJIANBL == null) ? new FBIJJFGLKMK() : MLJKIJIANBL);
	}
}
