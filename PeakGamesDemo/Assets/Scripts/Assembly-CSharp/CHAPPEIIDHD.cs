public abstract class CHAPPEIIDHD
{
	public const byte KIDAAJNKKGA = 0;

	public const byte LLGEPBMMGEB = 1;

	public const byte MLBEIDJMHFI = 2;

	public const byte CKICLBJMDFH = 3;

	public const byte JKOJEIPLAGN = 4;

	public const byte GJKOEJHPCCI = 5;

	public const byte PAPBDBAKPNK = 6;

	public static string CILJKDELPFP(byte JMCLOFPGGNN)
	{
		switch (JMCLOFPGGNN)
		{
		case 0:
			return "none";
		case 1:
			return "md5";
		case 2:
			return "sha1";
		case 3:
			return "sha224";
		case 4:
			return "sha256";
		case 5:
			return "sha384";
		case 6:
			return "sha512";
		default:
			return "UNKNOWN";
		}
	}

	public static string GMPMIOJECLI(byte JMCLOFPGGNN)
	{
		return CILJKDELPFP(JMCLOFPGGNN) + "(" + JMCLOFPGGNN + ")";
	}

	public static bool CCLHEKOIIKM(byte JMCLOFPGGNN)
	{
		return 224 <= JMCLOFPGGNN && JMCLOFPGGNN <= byte.MaxValue;
	}
}
