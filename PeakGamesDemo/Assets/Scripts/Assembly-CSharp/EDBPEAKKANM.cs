using System;

public static class EDBPEAKKANM
{
	public const float LEBLKGNBFKH = (float)Math.PI;

	public const float MDGKIKLEPPG = (float)Math.PI * 2f;

	public const float MBNLFBPBPAG = 180f / (float)Math.PI;

	public const float IMMLJMEKIFG = (float)Math.PI / 180f;

	private const int HEMELNNCPHE = 14;

	private const int GCDLHGLOFDN = 16383;

	private const int HEJBDMLAIDH = 16384;

	private const float JEDCADDOEDK = (float)Math.PI * 2f;

	private const float MGFNGHDJFCL = 360f;

	private const float OGDPFEINBBE = 8192f / (float)Math.PI;

	private const float GBKCFFLGPCM = 45.511112f;

	private static float[] IGLOMNIDEAJ;

	static EDBPEAKKANM()
	{
		IGLOMNIDEAJ = new float[16384];
		for (int i = 0; i < 16384; i++)
		{
			IGLOMNIDEAJ[i] = (float)Math.Sin(((float)i + 0.5f) / 16384f * ((float)Math.PI * 2f));
		}
		for (int j = 0; j < 360; j += 90)
		{
			IGLOMNIDEAJ[(int)((float)j * 45.511112f) & 0x3FFF] = (float)Math.Sin((float)j * ((float)Math.PI / 180f));
		}
	}

	public static float OADPLHLHEEN(float FJLEFILAEPC)
	{
		return IGLOMNIDEAJ[(int)(FJLEFILAEPC * (8192f / (float)Math.PI)) & 0x3FFF];
	}

	public static float KPMBBEFLOHE(float FJLEFILAEPC)
	{
		return IGLOMNIDEAJ[(int)((FJLEFILAEPC + (float)Math.PI / 2f) * (8192f / (float)Math.PI)) & 0x3FFF];
	}

	public static float HLLKFBLOPOE(float GGELLLADCFC)
	{
		return IGLOMNIDEAJ[(int)(GGELLLADCFC * 45.511112f) & 0x3FFF];
	}

	public static float OCGBMDHACPF(float GGELLLADCFC)
	{
		return IGLOMNIDEAJ[(int)((GGELLLADCFC + 90f) * 45.511112f) & 0x3FFF];
	}

	public static float FKGOMHJAJMK(float CNLILOEEBOJ, float AMFCENFNAJJ)
	{
		if (AMFCENFNAJJ == 0f)
		{
			if (CNLILOEEBOJ > 0f)
			{
				return (float)Math.PI / 2f;
			}
			if (CNLILOEEBOJ == 0f)
			{
				return 0f;
			}
			return -(float)Math.PI / 2f;
		}
		float num = CNLILOEEBOJ / AMFCENFNAJJ;
		float num2;
		if (Math.Abs(num) < 1f)
		{
			num2 = num / (1f + 0.28f * num * num);
			if (AMFCENFNAJJ < 0f)
			{
				return num2 + ((!(CNLILOEEBOJ < 0f)) ? ((float)Math.PI) : (-(float)Math.PI));
			}
			return num2;
		}
		num2 = (float)Math.PI / 2f - num / (num * num + 0.28f);
		return (!(CNLILOEEBOJ < 0f)) ? num2 : (num2 - (float)Math.PI);
	}

	public static float KHNPKKEKJDC(float EDDNOJDPMCF, float IJHGDODBFCD, float NHLJFKPLKLI)
	{
		if (EDDNOJDPMCF < IJHGDODBFCD)
		{
			return IJHGDODBFCD;
		}
		if (EDDNOJDPMCF > NHLJFKPLKLI)
		{
			return NHLJFKPLKLI;
		}
		return EDDNOJDPMCF;
	}
}
