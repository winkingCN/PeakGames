using System;
using System.Collections;
using System.IO;

public abstract class KKHDKCFMKNN : HMPLNBAPPNE
{
	protected readonly int MOCPBMMDBBD;

	protected IList CFGIHFFACPK;

	protected CGDEGBGOKJO COOBIGONLDK;

	public virtual bool GPEPNOJIMAB
	{
		get
		{
			return false;
		}
	}

	protected KKHDKCFMKNN(int EBOOFBMGNDI, IList GMLLEBDADDP)
	{
		MOCPBMMDBBD = EBOOFBMGNDI;
		CFGIHFFACPK = GMLLEBDADDP;
	}

	protected virtual NKOAICPNEJH MNPNCAOHANP(Stream MOPCLEEGDFB)
	{
		NKOAICPNEJH nKOAICPNEJH = NKOAICPNEJH.DHCLOMIANOE(COOBIGONLDK, MOPCLEEGDFB);
		FBMKOGABPFL fBMKOGABPFL = nKOAICPNEJH.GOFDFGBGLFC;
		if (fBMKOGABPFL != null)
		{
			KINEBFNENMB.EFCELAHEJPB(CFGIHFFACPK, fBMKOGABPFL);
		}
		return nKOAICPNEJH;
	}

	public virtual void DIOELAHNLKJ(CGDEGBGOKJO MBEMNOCDDBC)
	{
		COOBIGONLDK = MBEMNOCDDBC;
		OBDIBELBBEO oBDIBELBBEO = MBEMNOCDDBC.BEHNDIMGDKM;
		if (KINEBFNENMB.ABIOLEEPEHN(oBDIBELBBEO))
		{
			if (CFGIHFFACPK == null)
			{
				switch (MOCPBMMDBBD)
				{
				case 3:
				case 7:
				case 22:
					CFGIHFFACPK = KINEBFNENMB.IDCKEKJKMMF();
					break;
				case 16:
				case 17:
					CFGIHFFACPK = KINEBFNENMB.OAHOCHINHOL();
					break;
				case 1:
				case 5:
				case 9:
				case 15:
				case 18:
				case 19:
				case 23:
					CFGIHFFACPK = KINEBFNENMB.ELNLEELJJCJ();
					break;
				case 13:
				case 14:
				case 21:
				case 24:
					break;
				default:
					throw new InvalidOperationException("unsupported key exchange algorithm");
				}
			}
		}
		else if (CFGIHFFACPK != null)
		{
			throw new InvalidOperationException("supported_signature_algorithms not allowed for " + oBDIBELBBEO);
		}
	}

	public abstract void PHFBGHEJBHM();

	public virtual void BGLKKBMEEEK(PAJJBHMEFKE EIMEPDCAJLE)
	{
		if (CFGIHFFACPK != null)
		{
		}
	}

	public virtual void OPECIECMFCD(OPCLIKBOHJP BGFNAKMFCHD)
	{
		BGLKKBMEEEK(BGFNAKMFCHD.BIBHHNBEJJM);
	}

	public virtual byte[] DMJCNEDKPEA()
	{
		if (GPEPNOJIMAB)
		{
			throw new DEIDBCPPCMB(80);
		}
		return null;
	}

	public virtual void EDBOAAHOOMB()
	{
		if (GPEPNOJIMAB)
		{
			throw new DEIDBCPPCMB(10);
		}
	}

	public virtual void OJGCPPFDPBN(Stream MOPCLEEGDFB)
	{
		if (!GPEPNOJIMAB)
		{
			throw new DEIDBCPPCMB(10);
		}
	}

	public abstract void JNMIHCPINHE(OOKLBMMBONO FJLPCHOBGAM);

	public virtual void IPDLGANAAKE()
	{
	}

	public abstract void FBGFHDOCEOO(OPCLIKBOHJP CLBMIAJGDMO);

	public virtual void KHJELAAEAPK(PAJJBHMEFKE HDJIOCGDIKM)
	{
	}

	public abstract void BAILJOPLLNN(Stream BILGCJNPJGJ);

	public virtual void DHMEHGEGGCB(Stream MOPCLEEGDFB)
	{
		throw new DEIDBCPPCMB(80);
	}

	public abstract byte[] CGMFKLNEDAP();
}
