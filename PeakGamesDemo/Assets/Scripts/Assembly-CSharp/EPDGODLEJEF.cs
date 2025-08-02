using System;
using Org.BouncyCastle.Math;

public class EPDGODLEJEF : DGCIOOEELCP
{
	private readonly BFNAPEDBMDL BGELMEEBMHC = new BFNAPEDBMDL();

	private PLGGNEJEIIP IKNCPEPOKGJ;

	private FBIJJFGLKMK GECCLOFELEC;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return "RSA";
		}
	}

	public virtual void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK BOFHHECPKNF)
	{
		BGELMEEBMHC.DIOELAHNLKJ(MAEALKEJALK, BOFHHECPKNF);
		if (BOFHHECPKNF is MDAKJDOFCEP)
		{
			MDAKJDOFCEP mDAKJDOFCEP = (MDAKJDOFCEP)BOFHHECPKNF;
			IKNCPEPOKGJ = (PLGGNEJEIIP)mDAKJDOFCEP.KPJHHAAOFOH;
			GECCLOFELEC = mDAKJDOFCEP.IPFKDIJBGIM;
		}
		else
		{
			IKNCPEPOKGJ = (PLGGNEJEIIP)BOFHHECPKNF;
			GECCLOFELEC = new FBIJJFGLKMK();
		}
	}

	public virtual int IBGFCPAGGON()
	{
		return BGELMEEBMHC.IBGFCPAGGON();
	}

	public virtual int JOKDJPBGMFH()
	{
		return BGELMEEBMHC.JOKDJPBGMFH();
	}

	public virtual byte[] DPACJDFHLKB(byte[] HMFPNMDMONK, int ELICNEDIBGB, int DBGBBFPPDCE)
	{
		if (IKNCPEPOKGJ == null)
		{
			throw new InvalidOperationException("RSA engine not initialised");
		}
		BigInteger bigInteger = BGELMEEBMHC.IHLMGDNBCEK(HMFPNMDMONK, ELICNEDIBGB, DBGBBFPPDCE);
		BigInteger bigInteger6;
		if (IKNCPEPOKGJ is ELKMCBFPHBP)
		{
			ELKMCBFPHBP eLKMCBFPHBP = (ELKMCBFPHBP)IKNCPEPOKGJ;
			BigInteger bigInteger2 = eLKMCBFPHBP.IHOPDFAGDAF;
			if (bigInteger2 != null)
			{
				BigInteger bigInteger3 = eLKMCBFPHBP.FILOMPHGFKD;
				BigInteger bigInteger4 = ODBELJAHGIG.LJJCFCFGOCK(BigInteger.One, bigInteger3.FBGIHKPECCO(BigInteger.One), GECCLOFELEC);
				BigInteger mOPCLEEGDFB = bigInteger4.ICEOCBALAGC(bigInteger2, bigInteger3).IBJBIGNPNEM(bigInteger).MODIHOCEKBK(bigInteger3);
				BigInteger bigInteger5 = BGELMEEBMHC.DPACJDFHLKB(mOPCLEEGDFB);
				BigInteger hIMINGHNIKN = bigInteger4.DDENLEMHHAM(bigInteger3);
				bigInteger6 = bigInteger5.IBJBIGNPNEM(hIMINGHNIKN).MODIHOCEKBK(bigInteger3);
				if (!bigInteger.Equals(bigInteger6.ICEOCBALAGC(bigInteger2, bigInteger3)))
				{
					throw new InvalidOperationException("RSA engine faulty decryption/signing detected");
				}
			}
			else
			{
				bigInteger6 = BGELMEEBMHC.DPACJDFHLKB(bigInteger);
			}
		}
		else
		{
			bigInteger6 = BGELMEEBMHC.DPACJDFHLKB(bigInteger);
		}
		return BGELMEEBMHC.GKOAIFHOLOC(bigInteger6);
	}
}
