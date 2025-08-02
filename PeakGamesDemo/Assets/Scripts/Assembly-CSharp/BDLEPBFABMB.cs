using System;

public class BDLEPBFABMB : IBHDLJIANBI
{
	private const byte HCFGFLGHJJO = 252;

	private const byte MBDGOJLMODM = 15;

	protected override void HFLPGDBEKBE(HPBPDALECOG BOFHHECPKNF)
	{
		GECCLOFELEC = BOFHHECPKNF.IPFKDIJBGIM;
		LOEMJLHDJAE = 32;
	}

	protected override byte[] CBKCFJENBEG()
	{
		byte[] array = base.CBKCFJENBEG();
		KHNPKKEKJDC(array);
		return array;
	}

	public static void KHNPKKEKJDC(byte[] IKNCPEPOKGJ)
	{
		if (IKNCPEPOKGJ.Length != 32)
		{
			throw new ArgumentException("Poly1305 key must be 256 bits.");
		}
		IKNCPEPOKGJ[3] &= 15;
		IKNCPEPOKGJ[7] &= 15;
		IKNCPEPOKGJ[11] &= 15;
		IKNCPEPOKGJ[15] &= 15;
		IKNCPEPOKGJ[4] &= 252;
		IKNCPEPOKGJ[8] &= 252;
		IKNCPEPOKGJ[12] &= 252;
	}

	public static void JGNNNDOHHED(byte[] IKNCPEPOKGJ)
	{
		if (IKNCPEPOKGJ.Length != 32)
		{
			throw new ArgumentException("Poly1305 key must be 256 bits.");
		}
		BJCLHJCBJED(IKNCPEPOKGJ[3], 15);
		BJCLHJCBJED(IKNCPEPOKGJ[7], 15);
		BJCLHJCBJED(IKNCPEPOKGJ[11], 15);
		BJCLHJCBJED(IKNCPEPOKGJ[15], 15);
		BJCLHJCBJED(IKNCPEPOKGJ[4], 252);
		BJCLHJCBJED(IKNCPEPOKGJ[8], 252);
		BJCLHJCBJED(IKNCPEPOKGJ[12], 252);
	}

	private static void BJCLHJCBJED(byte BCIHLCMFAEK, byte DHJODBJPGBJ)
	{
		if ((BCIHLCMFAEK & ~DHJODBJPGBJ) != 0)
		{
			throw new ArgumentException("Invalid format for r portion of Poly1305 key.");
		}
	}
}
