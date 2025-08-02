using System;

public class CPBMGNAHLKB : IPMKHEFLFNC
{
	private ulong PHPFNJLODEE;

	private ulong HNEFBNELLMO;

	private const double BEOONBOBING = 4.656612873077393E-10;

	public CPBMGNAHLKB()
	{
		PHPFNJLODEE = (ulong)Guid.NewGuid().GetHashCode();
		HNEFBNELLMO = (ulong)Guid.NewGuid().GetHashCode();
	}

	public CPBMGNAHLKB(int HJBOEOOLOOE)
	{
		PHPFNJLODEE = (ulong)((long)HJBOEOOLOOE << 3);
		HNEFBNELLMO = (ulong)HJBOEOOLOOE >> 3;
	}

	public int BDAKKAIBMIM()
	{
		ulong hNEFBNELLMO = HNEFBNELLMO;
		PHPFNJLODEE ^= PHPFNJLODEE << 23;
		ulong num = PHPFNJLODEE ^ HNEFBNELLMO ^ (PHPFNJLODEE >> 17) ^ (HNEFBNELLMO >> 26);
		int result = (int)(num + HNEFBNELLMO);
		PHPFNJLODEE = hNEFBNELLMO;
		HNEFBNELLMO = num;
		return result;
	}

	public int BDAKKAIBMIM(int IJHGDODBFCD, int NHLJFKPLKLI)
	{
		ulong hNEFBNELLMO = HNEFBNELLMO;
		PHPFNJLODEE ^= PHPFNJLODEE << 23;
		ulong num = PHPFNJLODEE ^ HNEFBNELLMO ^ (PHPFNJLODEE >> 17) ^ (HNEFBNELLMO >> 26);
		int num2 = (int)(num + HNEFBNELLMO);
		PHPFNJLODEE = hNEFBNELLMO;
		HNEFBNELLMO = num;
		num2 &= 0x7FFFFFFF;
		return (NHLJFKPLKLI <= IJHGDODBFCD) ? (num2 % (IJHGDODBFCD - NHLJFKPLKLI) + NHLJFKPLKLI) : (num2 % (NHLJFKPLKLI - IJHGDODBFCD) + IJHGDODBFCD);
	}

	public double IJMGAMPJIAL()
	{
		ulong hNEFBNELLMO = HNEFBNELLMO;
		PHPFNJLODEE ^= PHPFNJLODEE << 23;
		ulong num = PHPFNJLODEE ^ HNEFBNELLMO ^ (PHPFNJLODEE >> 17) ^ (HNEFBNELLMO >> 26);
		ulong num2 = num + HNEFBNELLMO;
		double result = 4.656612873077393E-10 * (double)(0x7FFFFFFF & num2);
		PHPFNJLODEE = hNEFBNELLMO;
		HNEFBNELLMO = num;
		return result;
	}

	public IPMKHEFLFNC[] DOEJJMHNNNI(int AFKEAHDLGOC)
	{
		IPMKHEFLFNC[] array = new IPMKHEFLFNC[AFKEAHDLGOC];
		for (int i = 0; i < AFKEAHDLGOC; i++)
		{
			array[i] = new CPBMGNAHLKB(BDAKKAIBMIM());
		}
		return array;
	}
}
