using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Math;

public class ABFMEJBCEFO : KKHDKCFMKNN
{
	protected EKFAMINKCJP PJMPLLIKCCG;

	protected CLBPDHGBHML FKADCPDDCJD;

	protected COEMJAGOFJJ CAACNJEGLIP;

	protected KLOLEKONHBE DPBONCANGGJ;

	protected AEIKMJPPOMN NDIOOHBIMGN;

	protected GBBNCENGABI HKCLMCFFABJ;

	public override bool GPEPNOJIMAB
	{
		get
		{
			switch (MOCPBMMDBBD)
			{
			case 3:
			case 5:
			case 11:
				return true;
			default:
				return false;
			}
		}
	}

	protected virtual int HGAEINPDJKK
	{
		get
		{
			return 1024;
		}
	}

	public ABFMEJBCEFO(int EBOOFBMGNDI, IList GMLLEBDADDP, CLBPDHGBHML FIIGKOBJLJF)
		: base(EBOOFBMGNDI, GMLLEBDADDP)
	{
		switch (EBOOFBMGNDI)
		{
		case 7:
		case 9:
			PJMPLLIKCCG = null;
			break;
		case 5:
			PJMPLLIKCCG = new MIKBJEJODHC();
			break;
		case 3:
			PJMPLLIKCCG = new KBJEGPDMPNE();
			break;
		default:
			throw new InvalidOperationException("unsupported key exchange algorithm");
		}
		FKADCPDDCJD = FIIGKOBJLJF;
	}

	public override void DIOELAHNLKJ(CGDEGBGOKJO MBEMNOCDDBC)
	{
		base.DIOELAHNLKJ(MBEMNOCDDBC);
		if (PJMPLLIKCCG != null)
		{
			PJMPLLIKCCG.DIOELAHNLKJ(MBEMNOCDDBC);
		}
	}

	public override void PHFBGHEJBHM()
	{
		throw new DEIDBCPPCMB(10);
	}

	public override void BGLKKBMEEEK(PAJJBHMEFKE EIMEPDCAJLE)
	{
		if (EIMEPDCAJLE.DHIKCKFGKID)
		{
			throw new DEIDBCPPCMB(42);
		}
		NGNPCPDMGBC nGNPCPDMGBC = EIMEPDCAJLE.IGGCPKOFOMP(0);
		MHBCFNELGOJ mJHHKCCPFEE = nGNPCPDMGBC.KBGJHCMPCGH;
		try
		{
			CAACNJEGLIP = JHGHHFDFJEG.HCBKCKKDGCP(mJHHKCCPFEE);
		}
		catch (Exception cEDNDOAMNOC)
		{
			throw new DEIDBCPPCMB(43, cEDNDOAMNOC);
		}
		if (PJMPLLIKCCG == null)
		{
			try
			{
				HKCLMCFFABJ = DBBCMLDCNPN.BJEGIOHKNMM((GBBNCENGABI)CAACNJEGLIP);
				FKADCPDDCJD = IBLKJLFKPBE(HKCLMCFFABJ.KPJHHAAOFOH);
			}
			catch (InvalidCastException cEDNDOAMNOC2)
			{
				throw new DEIDBCPPCMB(46, cEDNDOAMNOC2);
			}
			KINEBFNENMB.EPMGOMGGBIE(nGNPCPDMGBC, 8);
		}
		else
		{
			if (!PJMPLLIKCCG.GNODDNDEEMI(CAACNJEGLIP))
			{
				throw new DEIDBCPPCMB(46);
			}
			KINEBFNENMB.EPMGOMGGBIE(nGNPCPDMGBC, 128);
		}
		base.BGLKKBMEEEK(EIMEPDCAJLE);
	}

	public override void JNMIHCPINHE(OOKLBMMBONO FJLPCHOBGAM)
	{
		byte[] array = FJLPCHOBGAM.JBMMCGPHNBP;
		for (int i = 0; i < array.Length; i++)
		{
			switch (array[i])
			{
			case 1:
			case 2:
			case 3:
			case 4:
			case 64:
				continue;
			}
			throw new DEIDBCPPCMB(47);
		}
	}

	public override void FBGFHDOCEOO(OPCLIKBOHJP CLBMIAJGDMO)
	{
		if (CLBMIAJGDMO is KLOLEKONHBE)
		{
			DPBONCANGGJ = (KLOLEKONHBE)CLBMIAJGDMO;
		}
		else if (!(CLBMIAJGDMO is IAJODODPMMG))
		{
			throw new DEIDBCPPCMB(80);
		}
	}

	public override void BAILJOPLLNN(Stream BILGCJNPJGJ)
	{
		if (DPBONCANGGJ == null)
		{
			NDIOOHBIMGN = DBBCMLDCNPN.MAJEAJCJMKA(COOBIGONLDK.KMLKPFPCFLA, FKADCPDDCJD, BILGCJNPJGJ);
		}
	}

	public override void KHJELAAEAPK(PAJJBHMEFKE HDJIOCGDIKM)
	{
	}

	public override void DHMEHGEGGCB(Stream MOPCLEEGDFB)
	{
		if (HKCLMCFFABJ == null)
		{
			BigInteger cNLILOEEBOJ = DBBCMLDCNPN.EEMLKMCJOAA(MOPCLEEGDFB);
			HKCLMCFFABJ = DBBCMLDCNPN.BJEGIOHKNMM(new GBBNCENGABI(cNLILOEEBOJ, FKADCPDDCJD));
		}
	}

	public override byte[] CGMFKLNEDAP()
	{
		if (DPBONCANGGJ != null)
		{
			return DPBONCANGGJ.LEMDLODGMFN(HKCLMCFFABJ);
		}
		if (NDIOOHBIMGN != null)
		{
			return DBBCMLDCNPN.HDGPOLMDDPK(HKCLMCFFABJ, NDIOOHBIMGN);
		}
		throw new DEIDBCPPCMB(80);
	}

	protected virtual CLBPDHGBHML IBLKJLFKPBE(CLBPDHGBHML IJJHBEECMBP)
	{
		if (IJJHBEECMBP.MBIJHANOCOC.BitLength < HGAEINPDJKK)
		{
			throw new DEIDBCPPCMB(71);
		}
		return DBBCMLDCNPN.IBLKJLFKPBE(IJJHBEECMBP);
	}
}
