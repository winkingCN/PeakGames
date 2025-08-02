using System;
using System.IO;

public class OAJOIGPAFEJ
{
	protected readonly byte IBAPOFAOOKA;

	protected readonly object GODIPKFIIFG;

	public virtual byte DMKHLENPOBD
	{
		get
		{
			return IBAPOFAOOKA;
		}
	}

	public virtual object PNGPLGHKFDI
	{
		get
		{
			return GODIPKFIIFG;
		}
	}

	public OAJOIGPAFEJ(byte OINILONPAGJ, object IOCMOCCFALN)
	{
		if (!OFAPJJLNFLP(OINILONPAGJ, IOCMOCCFALN))
		{
			throw new ArgumentException("not an instance of the correct type", "name");
		}
		IBAPOFAOOKA = OINILONPAGJ;
		GODIPKFIIFG = IOCMOCCFALN;
	}

	public virtual string OHNEEIPAKFG()
	{
		if (!OFAPJJLNFLP(0, GODIPKFIIFG))
		{
			throw new InvalidOperationException("'name' is not a HostName string");
		}
		return (string)GODIPKFIIFG;
	}

	public virtual void LMDBBPLCJDM(Stream BILGCJNPJGJ)
	{
		KINEBFNENMB.JBOHOOBEPAM(IBAPOFAOOKA, BILGCJNPJGJ);
		if (IBAPOFAOOKA == 0)
		{
			byte[] array = CCGLOIJJMKC.IFHLAPJLHNG((string)GODIPKFIIFG);
			if (array.Length < 1)
			{
				throw new DEIDBCPPCMB(80);
			}
			KINEBFNENMB.HIPJBHBLGEI(array, BILGCJNPJGJ);
			return;
		}
		throw new DEIDBCPPCMB(80);
	}

	public static OAJOIGPAFEJ DHCLOMIANOE(Stream MOPCLEEGDFB)
	{
		byte b = KINEBFNENMB.HEEOKPLLJMG(MOPCLEEGDFB);
		if (b == 0)
		{
			byte[] array = KINEBFNENMB.HDGCNMILKAA(MOPCLEEGDFB);
			if (array.Length < 1)
			{
				throw new DEIDBCPPCMB(50);
			}
			object iOCMOCCFALN = CCGLOIJJMKC.DNHBLFMKDDH(array);
			return new OAJOIGPAFEJ(b, iOCMOCCFALN);
		}
		throw new DEIDBCPPCMB(50);
	}

	protected static bool OFAPJJLNFLP(byte OINILONPAGJ, object IOCMOCCFALN)
	{
		if (OINILONPAGJ == 0)
		{
			return IOCMOCCFALN is string;
		}
		throw new ArgumentException("unsupported value", "name");
	}
}
