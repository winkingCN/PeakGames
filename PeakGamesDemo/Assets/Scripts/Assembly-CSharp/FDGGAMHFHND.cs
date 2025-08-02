using System;
using System.IO;

public class FDGGAMHFHND
{
	protected readonly byte CPAAPFDOOMG;

	public virtual byte JLDDAAEEHPE
	{
		get
		{
			return CPAAPFDOOMG;
		}
	}

	public FDGGAMHFHND(byte LJCPOAOKFOE)
	{
		if (!OCCBGJFJPAD.NAFCDEECGEF(LJCPOAOKFOE))
		{
			throw new ArgumentException("not a valid HeartbeatMode value", "mode");
		}
		CPAAPFDOOMG = LJCPOAOKFOE;
	}

	public virtual void LMDBBPLCJDM(Stream BILGCJNPJGJ)
	{
		KINEBFNENMB.JBOHOOBEPAM(CPAAPFDOOMG, BILGCJNPJGJ);
	}

	public static FDGGAMHFHND DHCLOMIANOE(Stream MOPCLEEGDFB)
	{
		byte b = KINEBFNENMB.HEEOKPLLJMG(MOPCLEEGDFB);
		if (!OCCBGJFJPAD.NAFCDEECGEF(b))
		{
			throw new DEIDBCPPCMB(47);
		}
		return new FDGGAMHFHND(b);
	}
}
