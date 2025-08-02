using System.Text.RegularExpressions;

public abstract class HOOPJEOBGPN : JIDJCBGKJPF
{
	public int EDDNOJDPMCF;

	public char KMIAHBEBMAH;

	protected HOOPJEOBGPN(string EJBMABJCEDN)
	{
		if (EJBMABJCEDN != null)
		{
			EJBMABJCEDN = Regex.Replace(EJBMABJCEDN, "\\s+", string.Empty);
			char c = EJBMABJCEDN.ToCharArray()[0];
			switch (c)
			{
			case '<':
			case '=':
			case '>':
				KMIAHBEBMAH = c;
				EDDNOJDPMCF = int.Parse(EJBMABJCEDN.Substring(1));
				break;
			default:
				EDDNOJDPMCF = int.Parse(EJBMABJCEDN);
				KMIAHBEBMAH = '=';
				break;
			}
		}
	}

	public abstract bool IONCPAHMPIL();

	public bool DKECENMIJCJ(int DFGEOCLKDFD)
	{
		switch (KMIAHBEBMAH)
		{
		case '>':
			return DFGEOCLKDFD > EDDNOJDPMCF;
		case '<':
			return DFGEOCLKDFD < EDDNOJDPMCF;
		case '=':
			return DFGEOCLKDFD == EDDNOJDPMCF;
		default:
			return false;
		}
	}
}
