public abstract class CCGJJBHGFMC
{
	public const byte NOEKDDHBFNA = 1;

	public const byte LLJIECBDCCN = 2;

	public static string CILJKDELPFP(byte LHIDNPKMPPJ)
	{
		switch (LHIDNPKMPPJ)
		{
		case 1:
			return "warning";
		case 2:
			return "fatal";
		default:
			return "UNKNOWN";
		}
	}

	public static string GMPMIOJECLI(byte LHIDNPKMPPJ)
	{
		return CILJKDELPFP(LHIDNPKMPPJ) + "(" + LHIDNPKMPPJ + ")";
	}
}
