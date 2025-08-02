using System;

public static class FIBJIOBINHL
{
	public static long GMEBBNOHJFJ(this DateTime DBJHPBHNAAL)
	{
		return (long)(DBJHPBHNAAL - new DateTime(1970, 1, 1)).TotalSeconds;
	}

	public static long CFBJBKEPGAN()
	{
		return DateTime.UtcNow.GMEBBNOHJFJ();
	}

	public static DateTime IIDMAMGMAAA(long CBPMOEJPGPK)
	{
		return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).Add(TimeSpan.FromMilliseconds(CBPMOEJPGPK));
	}

	public static string LNJPHFHNGCO(this int OBMCICDNJBA, string DFEEIJGLPIH = ":")
	{
		int num = (int)((float)OBMCICDNJBA / 60f);
		string text = ((num >= 10) ? num.ToString() : ("0" + num));
		int num2 = OBMCICDNJBA % 60;
		string text2 = ((num2 >= 10) ? num2.ToString() : ("0" + num2));
		return text + DFEEIJGLPIH + text2;
	}
}
