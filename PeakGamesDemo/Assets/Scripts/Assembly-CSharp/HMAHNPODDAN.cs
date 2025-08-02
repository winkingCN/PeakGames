using System;
using System.IO;

public class HMAHNPODDAN
{
	protected readonly byte CPEMMDNGOGD;

	protected readonly object PJLFBBEFIPJ;

	public virtual byte KNFNGFPAHEI
	{
		get
		{
			return CPEMMDNGOGD;
		}
	}

	public virtual object KFKIHMPOABC
	{
		get
		{
			return PJLFBBEFIPJ;
		}
	}

	public HMAHNPODDAN(byte JNJFAFKDFIH, object OMJOIIOONMO)
	{
		if (!OFAPJJLNFLP(JNJFAFKDFIH, OMJOIIOONMO))
		{
			throw new ArgumentException("not an instance of the correct type", "response");
		}
		CPEMMDNGOGD = JNJFAFKDFIH;
		PJLFBBEFIPJ = OMJOIIOONMO;
	}

	public virtual ELABOMJGNNG OMKEFFIMACC()
	{
		if (!OFAPJJLNFLP(1, PJLFBBEFIPJ))
		{
			throw new InvalidOperationException("'response' is not an OcspResponse");
		}
		return (ELABOMJGNNG)PJLFBBEFIPJ;
	}

	public virtual void LMDBBPLCJDM(Stream BILGCJNPJGJ)
	{
		KINEBFNENMB.JBOHOOBEPAM(CPEMMDNGOGD, BILGCJNPJGJ);
		byte cPEMMDNGOGD = CPEMMDNGOGD;
		if (cPEMMDNGOGD == 1)
		{
			byte[] gHPCHPOHELF = ((ELABOMJGNNG)PJLFBBEFIPJ).PPCPBIEGJKM("DER");
			KINEBFNENMB.GHMOBMODGDF(gHPCHPOHELF, BILGCJNPJGJ);
			return;
		}
		throw new DEIDBCPPCMB(80);
	}

	public static HMAHNPODDAN DHCLOMIANOE(Stream MOPCLEEGDFB)
	{
		byte b = KINEBFNENMB.HEEOKPLLJMG(MOPCLEEGDFB);
		if (b == 1)
		{
			byte[] nJPMJNHGDNE = KINEBFNENMB.MCBPCLGJPGF(MOPCLEEGDFB);
			object oMJOIIOONMO = ELABOMJGNNG.BJLJCGFMFOO(KINEBFNENMB.LCEOAGADAFB(nJPMJNHGDNE));
			return new HMAHNPODDAN(b, oMJOIIOONMO);
		}
		throw new DEIDBCPPCMB(50);
	}

	protected static bool OFAPJJLNFLP(byte JNJFAFKDFIH, object OMJOIIOONMO)
	{
		if (JNJFAFKDFIH == 1)
		{
			return OMJOIIOONMO is ELABOMJGNNG;
		}
		throw new ArgumentException("unsupported value", "statusType");
	}
}
