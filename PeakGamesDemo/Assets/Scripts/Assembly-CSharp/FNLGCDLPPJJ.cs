using System;
using System.IO;

public class FNLGCDLPPJJ
{
	protected readonly byte CPEMMDNGOGD;

	protected readonly object KCKMABFOOLH;

	public virtual byte KNFNGFPAHEI
	{
		get
		{
			return CPEMMDNGOGD;
		}
	}

	public virtual object MPNJHFHEPKM
	{
		get
		{
			return KCKMABFOOLH;
		}
	}

	public FNLGCDLPPJJ(byte JNJFAFKDFIH, object MONIIALMCBH)
	{
		if (!OFAPJJLNFLP(JNJFAFKDFIH, MONIIALMCBH))
		{
			throw new ArgumentException("not an instance of the correct type", "request");
		}
		CPEMMDNGOGD = JNJFAFKDFIH;
		KCKMABFOOLH = MONIIALMCBH;
	}

	public virtual BFPDLNJCJCL EKHDJLPCLCH()
	{
		if (!OFAPJJLNFLP(1, KCKMABFOOLH))
		{
			throw new InvalidOperationException("'request' is not an OCSPStatusRequest");
		}
		return (BFPDLNJCJCL)KCKMABFOOLH;
	}

	public virtual void LMDBBPLCJDM(Stream BILGCJNPJGJ)
	{
		KINEBFNENMB.JBOHOOBEPAM(CPEMMDNGOGD, BILGCJNPJGJ);
		byte cPEMMDNGOGD = CPEMMDNGOGD;
		if (cPEMMDNGOGD == 1)
		{
			((BFPDLNJCJCL)KCKMABFOOLH).LMDBBPLCJDM(BILGCJNPJGJ);
			return;
		}
		throw new DEIDBCPPCMB(80);
	}

	public static FNLGCDLPPJJ DHCLOMIANOE(Stream MOPCLEEGDFB)
	{
		byte b = KINEBFNENMB.HEEOKPLLJMG(MOPCLEEGDFB);
		if (b == 1)
		{
			object mONIIALMCBH = BFPDLNJCJCL.DHCLOMIANOE(MOPCLEEGDFB);
			return new FNLGCDLPPJJ(b, mONIIALMCBH);
		}
		throw new DEIDBCPPCMB(50);
	}

	protected static bool OFAPJJLNFLP(byte JNJFAFKDFIH, object MONIIALMCBH)
	{
		if (JNJFAFKDFIH == 1)
		{
			return MONIIALMCBH is BFPDLNJCJCL;
		}
		throw new ArgumentException("unsupported value", "statusType");
	}
}
