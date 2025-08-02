using System;

public class ENIDFCPLGCJ : BOMNEDGBAIA
{
	public const int DHNIGMIAPPE = 24;

	public ENIDFCPLGCJ(byte[] IKNCPEPOKGJ)
		: base(CKNDACLKMHJ(IKNCPEPOKGJ, 0, IKNCPEPOKGJ.Length))
	{
	}

	public ENIDFCPLGCJ(byte[] IKNCPEPOKGJ, int EDKGBLMGFOO, int JJBNFEJMIPJ)
		: base(CKNDACLKMHJ(IKNCPEPOKGJ, EDKGBLMGFOO, JJBNFEJMIPJ))
	{
	}

	private static byte[] CKNDACLKMHJ(byte[] IKNCPEPOKGJ, int EDKGBLMGFOO, int JJBNFEJMIPJ)
	{
		byte[] array = new byte[24];
		switch (JJBNFEJMIPJ)
		{
		case 16:
			Array.Copy(IKNCPEPOKGJ, EDKGBLMGFOO, array, 0, 16);
			Array.Copy(IKNCPEPOKGJ, EDKGBLMGFOO, array, 16, 8);
			break;
		case 24:
			Array.Copy(IKNCPEPOKGJ, EDKGBLMGFOO, array, 0, 24);
			break;
		default:
			throw new ArgumentException("Bad length for DESede key: " + JJBNFEJMIPJ, "keyLen");
		}
		if (DDGIJIBNJBG(array))
		{
			throw new ArgumentException("attempt to create weak DESede key");
		}
		return array;
	}

	public static bool DDGIJIBNJBG(byte[] IKNCPEPOKGJ, int IBNDGNOIEEF, int EOFAGACBNFP)
	{
		for (int i = IBNDGNOIEEF; i < EOFAGACBNFP; i += 8)
		{
			if (BOMNEDGBAIA.DDGIJIBNJBG(IKNCPEPOKGJ, i))
			{
				return true;
			}
		}
		return false;
	}

	public new static bool DDGIJIBNJBG(byte[] IKNCPEPOKGJ, int IBNDGNOIEEF)
	{
		return DDGIJIBNJBG(IKNCPEPOKGJ, IBNDGNOIEEF, IKNCPEPOKGJ.Length - IBNDGNOIEEF);
	}

	public new static bool DDGIJIBNJBG(byte[] IKNCPEPOKGJ)
	{
		return DDGIJIBNJBG(IKNCPEPOKGJ, 0, IKNCPEPOKGJ.Length);
	}

	public static bool ENHFBAMJJCM(byte[] IKNCPEPOKGJ, int IBNDGNOIEEF)
	{
		return (IKNCPEPOKGJ.Length != 16) ? JPBHPANECBH(IKNCPEPOKGJ, IBNDGNOIEEF) : MLENLIFODAF(IKNCPEPOKGJ, IBNDGNOIEEF);
	}

	public static bool MLENLIFODAF(byte[] IKNCPEPOKGJ, int IBNDGNOIEEF)
	{
		bool flag = false;
		for (int i = IBNDGNOIEEF; i != IBNDGNOIEEF + 8; i++)
		{
			flag |= IKNCPEPOKGJ[i] != IKNCPEPOKGJ[i + 8];
		}
		return flag;
	}

	public static bool JPBHPANECBH(byte[] IKNCPEPOKGJ, int IBNDGNOIEEF)
	{
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		for (int i = IBNDGNOIEEF; i != IBNDGNOIEEF + 8; i++)
		{
			flag |= IKNCPEPOKGJ[i] != IKNCPEPOKGJ[i + 8];
			flag2 |= IKNCPEPOKGJ[i] != IKNCPEPOKGJ[i + 16];
			flag3 |= IKNCPEPOKGJ[i + 8] != IKNCPEPOKGJ[i + 16];
		}
		return flag && flag2 && flag3;
	}
}
