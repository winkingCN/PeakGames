using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Math;

public class ABFMEKEBHNI : DGCIOOEELCP
{
	private PDOHMDOJDFK IKNCPEPOKGJ;

	private FBIJJFGLKMK GECCLOFELEC;

	private bool MAEALKEJALK;

	private int FFLMHILGJIP;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return "ElGamal";
		}
	}

	public virtual void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		if (IJJHBEECMBP is MDAKJDOFCEP)
		{
			MDAKJDOFCEP mDAKJDOFCEP = (MDAKJDOFCEP)IJJHBEECMBP;
			IKNCPEPOKGJ = (PDOHMDOJDFK)mDAKJDOFCEP.KPJHHAAOFOH;
			GECCLOFELEC = mDAKJDOFCEP.IPFKDIJBGIM;
		}
		else
		{
			IKNCPEPOKGJ = (PDOHMDOJDFK)IJJHBEECMBP;
			GECCLOFELEC = new FBIJJFGLKMK();
		}
		this.MAEALKEJALK = MAEALKEJALK;
		FFLMHILGJIP = IKNCPEPOKGJ.KPJHHAAOFOH.MBIJHANOCOC.BitLength;
		if (MAEALKEJALK)
		{
			if (!(IKNCPEPOKGJ is IOEANHAEOBK))
			{
				throw new ArgumentException("ElGamalPublicKeyParameters are required for encryption.");
			}
		}
		else if (!(IKNCPEPOKGJ is IDCNEBAGENN))
		{
			throw new ArgumentException("ElGamalPrivateKeyParameters are required for decryption.");
		}
	}

	public virtual int IBGFCPAGGON()
	{
		if (MAEALKEJALK)
		{
			return (FFLMHILGJIP - 1) / 8;
		}
		return 2 * ((FFLMHILGJIP + 7) / 8);
	}

	public virtual int JOKDJPBGMFH()
	{
		if (MAEALKEJALK)
		{
			return 2 * ((FFLMHILGJIP + 7) / 8);
		}
		return (FFLMHILGJIP - 1) / 8;
	}

	public virtual byte[] DPACJDFHLKB(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP)
	{
		if (IKNCPEPOKGJ == null)
		{
			throw new InvalidOperationException("ElGamal engine not initialised");
		}
		int num = ((!MAEALKEJALK) ? IBGFCPAGGON() : ((FFLMHILGJIP - 1 + 7) / 8));
		if (EOFAGACBNFP > num)
		{
			throw new DataLengthException("input too large for ElGamal cipher.\n");
		}
		BigInteger bigInteger = IKNCPEPOKGJ.KPJHHAAOFOH.MBIJHANOCOC;
		byte[] array;
		if (IKNCPEPOKGJ is IDCNEBAGENN)
		{
			int num2 = EOFAGACBNFP / 2;
			BigInteger bigInteger2 = new BigInteger(1, MOPCLEEGDFB, ELICNEDIBGB, num2);
			BigInteger hIMINGHNIKN = new BigInteger(1, MOPCLEEGDFB, ELICNEDIBGB + num2, num2);
			IDCNEBAGENN iDCNEBAGENN = (IDCNEBAGENN)IKNCPEPOKGJ;
			BigInteger bigInteger3 = bigInteger2.ICEOCBALAGC(bigInteger.FBGIHKPECCO(BigInteger.One).FBGIHKPECCO(iDCNEBAGENN.CBPFFIBINEH), bigInteger).IBJBIGNPNEM(hIMINGHNIKN).MODIHOCEKBK(bigInteger);
			array = bigInteger3.MEOCDOOKOLH();
		}
		else
		{
			BigInteger bigInteger4 = new BigInteger(1, MOPCLEEGDFB, ELICNEDIBGB, EOFAGACBNFP);
			if (bigInteger4.BitLength >= bigInteger.BitLength)
			{
				throw new DataLengthException("input too large for ElGamal cipher.\n");
			}
			IOEANHAEOBK iOEANHAEOBK = (IOEANHAEOBK)IKNCPEPOKGJ;
			BigInteger eDDNOJDPMCF = bigInteger.FBGIHKPECCO(BigInteger.Two);
			BigInteger bigInteger5;
			do
			{
				bigInteger5 = new BigInteger(bigInteger.BitLength, GECCLOFELEC);
			}
			while (bigInteger5.SignValue == 0 || bigInteger5.JLPDKNFCNPO(eDDNOJDPMCF) > 0);
			BigInteger bigInteger6 = IKNCPEPOKGJ.KPJHHAAOFOH.HBGOKILMBJG;
			BigInteger bigInteger7 = bigInteger6.ICEOCBALAGC(bigInteger5, bigInteger);
			BigInteger bigInteger8 = bigInteger4.IBJBIGNPNEM(iOEANHAEOBK.MOAGLBJDKKL.ICEOCBALAGC(bigInteger5, bigInteger)).MODIHOCEKBK(bigInteger);
			array = new byte[JOKDJPBGMFH()];
			byte[] array2 = bigInteger7.MEOCDOOKOLH();
			byte[] array3 = bigInteger8.MEOCDOOKOLH();
			array2.CopyTo(array, array.Length / 2 - array2.Length);
			array3.CopyTo(array, array.Length - array3.Length);
		}
		return array;
	}
}
