using System.Text;

public class ANNNNPFPIBM
{
	private string EDDNOJDPMCF;

	private int EHJNMODJEAN;

	private char BJDILCNIABF;

	private StringBuilder DJDKLOJBJCO = new StringBuilder();

	public ANNNNPFPIBM(string GDFLIKNMBCL)
		: this(GDFLIKNMBCL, ',')
	{
	}

	public ANNNNPFPIBM(string GDFLIKNMBCL, char BJDILCNIABF)
	{
		EDDNOJDPMCF = GDFLIKNMBCL;
		EHJNMODJEAN = -1;
		this.BJDILCNIABF = BJDILCNIABF;
	}

	public bool OEGNOKFOOBH()
	{
		return EHJNMODJEAN != EDDNOJDPMCF.Length;
	}

	public string NMLDMNBOJFN()
	{
		if (EHJNMODJEAN == EDDNOJDPMCF.Length)
		{
			return null;
		}
		int i = EHJNMODJEAN + 1;
		bool flag = false;
		bool flag2 = false;
		DJDKLOJBJCO.Remove(0, DJDKLOJBJCO.Length);
		for (; i != EDDNOJDPMCF.Length; i++)
		{
			char c = EDDNOJDPMCF[i];
			if (c == '"')
			{
				if (!flag2)
				{
					flag = !flag;
					continue;
				}
				DJDKLOJBJCO.Append(c);
				flag2 = false;
			}
			else if (flag2 || flag)
			{
				if (c == '#' && DJDKLOJBJCO[DJDKLOJBJCO.Length - 1] == '=')
				{
					DJDKLOJBJCO.Append('\\');
				}
				else if (c == '+' && BJDILCNIABF != '+')
				{
					DJDKLOJBJCO.Append('\\');
				}
				DJDKLOJBJCO.Append(c);
				flag2 = false;
			}
			else if (c == '\\')
			{
				flag2 = true;
			}
			else
			{
				if (c == BJDILCNIABF)
				{
					break;
				}
				DJDKLOJBJCO.Append(c);
			}
		}
		EHJNMODJEAN = i;
		return DJDKLOJBJCO.ToString().Trim();
	}
}
