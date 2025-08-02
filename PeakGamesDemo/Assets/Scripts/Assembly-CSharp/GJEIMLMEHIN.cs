public class GJEIMLMEHIN
{
	private static readonly string BICBELADBDI = " " + NKILHODNBDE.GHBGCADFLFB("timeLeft");

	private static readonly string IFABBNKJNHJ = NKILHODNBDE.GHBGCADFLFB("daysStr");

	private static readonly string JMPCIGGDGJB = NKILHODNBDE.GHBGCADFLFB("hoursStr");

	private static readonly string KGMJPAEFAKI = NKILHODNBDE.GHBGCADFLFB("minutesStr");

	private static readonly string KKJDMHOMOBO = NKILHODNBDE.GHBGCADFLFB("secondsStr");

	public static string FLANACEGNEO(int HFLODNLEGFL, bool OLLIPMMDMEB = false)
	{
		if (HFLODNLEGFL == 0)
		{
			return "00:00";
		}
		int num = HFLODNLEGFL / 3600;
		HFLODNLEGFL -= num * 3600;
		int num2 = HFLODNLEGFL / 60;
		int num3 = HFLODNLEGFL % 60;
		if (OLLIPMMDMEB)
		{
			return string.Format("{0:00}:{1:00}:{2:00}", num, num2, num3);
		}
		return (num != 0) ? string.Format("{0:00}:{1:00}:{2:00}", num, num2, num3) : string.Format("{0:00}:{1:00}", num2, num3);
	}

	public static string JDIMBPFKOBB(int CPLOIFFOMOD, bool CCKBJJHGBML = false)
	{
		if (CPLOIFFOMOD == 0)
		{
			return string.Format("0{0}", NKILHODNBDE.GHBGCADFLFB("secondsStr"));
		}
		int num = CPLOIFFOMOD / 86400;
		int num2 = CPLOIFFOMOD / 3600 % 24;
		int num3 = CPLOIFFOMOD / 60 % 60;
		int num4 = CPLOIFFOMOD % 60;
		string empty = string.Empty;
		if (num > 0)
		{
			empty = ((num2 <= 0) ? string.Format("{0}{1}{2}", num, IFABBNKJNHJ, (!CCKBJJHGBML) ? string.Empty : BICBELADBDI) : string.Format("{0}{1} {2}{3}", num, IFABBNKJNHJ, num2, JMPCIGGDGJB));
			if (CCKBJJHGBML && empty.Length < 6)
			{
				empty += BICBELADBDI;
			}
		}
		else if (num2 <= 0)
		{
			empty = ((num3 <= 0) ? string.Format("{0}{1}", num4, KKJDMHOMOBO) : string.Format("{0}{1} {2}{3}", num3, KGMJPAEFAKI, num4, KKJDMHOMOBO));
		}
		else
		{
			empty = ((num3 <= 0) ? string.Format("{0}{1}{2}", num2, JMPCIGGDGJB, (!CCKBJJHGBML) ? string.Empty : BICBELADBDI) : string.Format("{0}{1} {2}{3}", num2, JMPCIGGDGJB, num3, KGMJPAEFAKI));
			if (CCKBJJHGBML && empty.Length < 6)
			{
				empty += BICBELADBDI;
			}
		}
		return empty;
	}
}
