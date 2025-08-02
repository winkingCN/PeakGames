using System;
using Org.BouncyCastle.Math;

public abstract class AEHODCJKLBP
{
	public static int MNAIJEEKPCP(KBINBLGGLNE NHDMDAHCFAA)
	{
		return (NHDMDAHCFAA.PJNLBAHOKGC + 7) / 8;
	}

	public static int MNAIJEEKPCP(BHPIABAGAPB FMFABAKPMLB)
	{
		return (FMFABAKPMLB.PJNLBAHOKGC + 7) / 8;
	}

	public static byte[] OIDMLPILCDK(BigInteger IBBBMACIBGK, int LHLOCJDFJHB)
	{
		byte[] array = IBBBMACIBGK.MEOCDOOKOLH();
		if (LHLOCJDFJHB < array.Length)
		{
			byte[] array2 = new byte[LHLOCJDFJHB];
			Array.Copy(array, array.Length - array2.Length, array2, 0, array2.Length);
			return array2;
		}
		if (LHLOCJDFJHB > array.Length)
		{
			byte[] array3 = new byte[LHLOCJDFJHB];
			Array.Copy(array, 0, array3, array3.Length - array.Length, array.Length);
			return array3;
		}
		return array;
	}
}
