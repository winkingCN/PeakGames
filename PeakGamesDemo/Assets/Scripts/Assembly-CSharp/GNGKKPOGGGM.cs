using System;
using Spine;

public class GNGKKPOGGGM
{
	internal ExposedList<DABFMEODJHE> OHPHLIGNIMA;

	internal float FMPBJJMKCIG;

	internal string IOCMOCCFALN;

	public string PNGPLGHKFDI
	{
		get
		{
			return IOCMOCCFALN;
		}
	}

	public ExposedList<DABFMEODJHE> MHCPMFHCODO
	{
		get
		{
			return OHPHLIGNIMA;
		}
		set
		{
			OHPHLIGNIMA = value;
		}
	}

	public float AEBACBBGHKI
	{
		get
		{
			return FMPBJJMKCIG;
		}
		set
		{
			FMPBJJMKCIG = value;
		}
	}

	public GNGKKPOGGGM(string IOCMOCCFALN, ExposedList<DABFMEODJHE> OHPHLIGNIMA, float FMPBJJMKCIG)
	{
		if (IOCMOCCFALN == null)
		{
			throw new ArgumentNullException("name", "name cannot be null.");
		}
		if (OHPHLIGNIMA == null)
		{
			throw new ArgumentNullException("timelines", "timelines cannot be null.");
		}
		this.IOCMOCCFALN = IOCMOCCFALN;
		this.OHPHLIGNIMA = OHPHLIGNIMA;
		this.FMPBJJMKCIG = FMPBJJMKCIG;
	}

	public void FCHLOGCODOA(GCJKICAPOFL GDNININLMFD, float CGICCPOKJHB, float HFLODNLEGFL, bool IKGIEEMCFDK, ExposedList<DCBJAMHBAJB> NJOHMGMPGBE, float KBKMPEOMABI, BFCFMFBHBCH IFKBABBBDJM, ODPDBCNBOAK AJLDJAHHGOJ)
	{
		if (GDNININLMFD == null)
		{
			throw new ArgumentNullException("skeleton", "skeleton cannot be null.");
		}
		if (IKGIEEMCFDK && FMPBJJMKCIG != 0f)
		{
			HFLODNLEGFL %= FMPBJJMKCIG;
			if (CGICCPOKJHB > 0f)
			{
				CGICCPOKJHB %= FMPBJJMKCIG;
			}
		}
		ExposedList<DABFMEODJHE> oHPHLIGNIMA = OHPHLIGNIMA;
		int i = 0;
		for (int count = oHPHLIGNIMA.Count; i < count; i++)
		{
			oHPHLIGNIMA.Items[i].FCHLOGCODOA(GDNININLMFD, CGICCPOKJHB, HFLODNLEGFL, NJOHMGMPGBE, KBKMPEOMABI, IFKBABBBDJM, AJLDJAHHGOJ);
		}
	}

	internal static int EIAMMDBFDFO(float[] OLNMBMEIBPL, float CAEMELGEOAE, int CCHAAJBNJHL)
	{
		int num = 0;
		int num2 = OLNMBMEIBPL.Length / CCHAAJBNJHL - 2;
		if (num2 == 0)
		{
			return CCHAAJBNJHL;
		}
		int num3 = (int)((uint)num2 >> 1);
		while (true)
		{
			if (OLNMBMEIBPL[(num3 + 1) * CCHAAJBNJHL] <= CAEMELGEOAE)
			{
				num = num3 + 1;
			}
			else
			{
				num2 = num3;
			}
			if (num == num2)
			{
				break;
			}
			num3 = (int)((uint)(num + num2) >> 1);
		}
		return (num + 1) * CCHAAJBNJHL;
	}

	internal static int EIAMMDBFDFO(float[] OLNMBMEIBPL, float CAEMELGEOAE)
	{
		int num = 0;
		int num2 = OLNMBMEIBPL.Length - 2;
		if (num2 == 0)
		{
			return 1;
		}
		int num3 = (int)((uint)num2 >> 1);
		while (true)
		{
			if (OLNMBMEIBPL[num3 + 1] <= CAEMELGEOAE)
			{
				num = num3 + 1;
			}
			else
			{
				num2 = num3;
			}
			if (num == num2)
			{
				break;
			}
			num3 = (int)((uint)(num + num2) >> 1);
		}
		return num + 1;
	}

	internal static int DANPKALKKJL(float[] OLNMBMEIBPL, float CAEMELGEOAE, int CCHAAJBNJHL)
	{
		int i = 0;
		for (int num = OLNMBMEIBPL.Length - CCHAAJBNJHL; i <= num; i += CCHAAJBNJHL)
		{
			if (OLNMBMEIBPL[i] > CAEMELGEOAE)
			{
				return i;
			}
		}
		return -1;
	}
}
