using System;

public class MBHFAHIPABH
{
	public static readonly DateTime DHCOAKFLBGC = new DateTime(1970, 1, 1);

	private MBHFAHIPABH()
	{
	}

	public static long BFKGMCIHPDI(DateTime DBJHPBHNAAL)
	{
		if (DBJHPBHNAAL.CompareTo(DHCOAKFLBGC) < 0)
		{
			throw new ArgumentException("DateTime value may not be before the epoch", "dateTime");
		}
		return (DBJHPBHNAAL.Ticks - DHCOAKFLBGC.Ticks) / 10000;
	}

	public static DateTime HJNEGGFABJO(long NGKIDBGHKFI)
	{
		return new DateTime(NGKIDBGHKFI * 10000 + DHCOAKFLBGC.Ticks);
	}

	public static long NGABLLHKHJJ()
	{
		return BFKGMCIHPDI(DateTime.UtcNow);
	}
}
