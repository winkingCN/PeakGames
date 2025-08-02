using System;
using System.IO;

public class FBMKOGABPFL
{
	protected readonly byte JFPMADKMGKI;

	protected readonly byte HDKIPBJPFEP;

	public virtual byte GHMJJKMGKKB
	{
		get
		{
			return JFPMADKMGKI;
		}
	}

	public virtual byte ACMDKLDPDLB
	{
		get
		{
			return HDKIPBJPFEP;
		}
	}

	public FBMKOGABPFL(byte AIELCDIFLFB, byte PINNJBGMGOA)
	{
		if (!KINEBFNENMB.EIEEEIONBCO(AIELCDIFLFB))
		{
			throw new ArgumentException("should be a uint8", "hash");
		}
		if (!KINEBFNENMB.EIEEEIONBCO(PINNJBGMGOA))
		{
			throw new ArgumentException("should be a uint8", "signature");
		}
		if (PINNJBGMGOA == 0)
		{
			throw new ArgumentException("MUST NOT be \"anonymous\"", "signature");
		}
		JFPMADKMGKI = AIELCDIFLFB;
		HDKIPBJPFEP = PINNJBGMGOA;
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (!(NEMEKIOEOLC is FBMKOGABPFL))
		{
			return false;
		}
		FBMKOGABPFL fBMKOGABPFL = (FBMKOGABPFL)NEMEKIOEOLC;
		return fBMKOGABPFL.GHMJJKMGKKB == GHMJJKMGKKB && fBMKOGABPFL.ACMDKLDPDLB == ACMDKLDPDLB;
	}

	public override int GetHashCode()
	{
		return (GHMJJKMGKKB << 16) | ACMDKLDPDLB;
	}

	public virtual void LMDBBPLCJDM(Stream BILGCJNPJGJ)
	{
		KINEBFNENMB.JBOHOOBEPAM(GHMJJKMGKKB, BILGCJNPJGJ);
		KINEBFNENMB.JBOHOOBEPAM(ACMDKLDPDLB, BILGCJNPJGJ);
	}

	public static FBMKOGABPFL DHCLOMIANOE(Stream MOPCLEEGDFB)
	{
		byte aIELCDIFLFB = KINEBFNENMB.HEEOKPLLJMG(MOPCLEEGDFB);
		byte pINNJBGMGOA = KINEBFNENMB.HEEOKPLLJMG(MOPCLEEGDFB);
		return new FBMKOGABPFL(aIELCDIFLFB, pINNJBGMGOA);
	}
}
