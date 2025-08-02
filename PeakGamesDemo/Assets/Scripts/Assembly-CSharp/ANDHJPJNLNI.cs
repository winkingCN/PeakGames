using System;
using System.Globalization;
using System.Text;

internal class ANDHJPJNLNI
{
	public enum KELIKHGNJPC
	{
		None = 0,
		Null = 1,
		True = 2,
		False = 3,
		Colon = 4,
		Comma = 5,
		String = 6,
		Number = 7,
		CurlyOpen = 8,
		CurlyClose = 9,
		SquaredOpen = 10,
		SquaredClose = 11
	}

	private char[] BIPAJFCNEOB;

	private int EHJNMODJEAN;

	private bool EEKJMDHEJCK = true;

	private char[] BNCGGGFKADO = new char[4096];

	public bool CDMLGKLOJIO
	{
		get
		{
			return !EEKJMDHEJCK;
		}
	}

	public int HGCMIDFMKHD { get; private set; }

	public bool AGHFOCILFDH { get; set; }

	public ANDHJPJNLNI(string FCJBBPHFNPJ)
	{
		OMOKOKFNBKI();
		BIPAJFCNEOB = FCJBBPHFNPJ.ToCharArray();
		AGHFOCILFDH = false;
	}

	public void OMOKOKFNBKI()
	{
		EHJNMODJEAN = 0;
		HGCMIDFMKHD = 1;
		EEKJMDHEJCK = true;
	}

	public string LGADJFBGGID()
	{
		int num = 0;
		StringBuilder stringBuilder = null;
		MAFEHLLPMOD();
		char c = BIPAJFCNEOB[EHJNMODJEAN++];
		bool flag = false;
		bool flag2 = false;
		while (!flag2 && !flag && EHJNMODJEAN != BIPAJFCNEOB.Length)
		{
			c = BIPAJFCNEOB[EHJNMODJEAN++];
			if (c == '"')
			{
				flag2 = true;
				break;
			}
			if (c == '\\')
			{
				if (EHJNMODJEAN == BIPAJFCNEOB.Length)
				{
					break;
				}
				switch (BIPAJFCNEOB[EHJNMODJEAN++])
				{
				case '"':
					BNCGGGFKADO[num++] = '"';
					break;
				case '\\':
					BNCGGGFKADO[num++] = '\\';
					break;
				case '/':
					BNCGGGFKADO[num++] = '/';
					break;
				case 'b':
					BNCGGGFKADO[num++] = '\b';
					break;
				case 'f':
					BNCGGGFKADO[num++] = '\f';
					break;
				case 'n':
					BNCGGGFKADO[num++] = '\n';
					break;
				case 'r':
					BNCGGGFKADO[num++] = '\r';
					break;
				case 't':
					BNCGGGFKADO[num++] = '\t';
					break;
				case 'u':
				{
					int num2 = BIPAJFCNEOB.Length - EHJNMODJEAN;
					if (num2 >= 4)
					{
						string value = new string(BIPAJFCNEOB, EHJNMODJEAN, 4);
						BNCGGGFKADO[num++] = (char)Convert.ToInt32(value, 16);
						EHJNMODJEAN += 4;
					}
					else
					{
						flag = true;
					}
					break;
				}
				}
			}
			else
			{
				BNCGGGFKADO[num++] = c;
			}
			if (num >= BNCGGGFKADO.Length)
			{
				if (stringBuilder == null)
				{
					stringBuilder = new StringBuilder();
				}
				stringBuilder.Append(BNCGGGFKADO, 0, num);
				num = 0;
			}
		}
		if (!flag2)
		{
			EEKJMDHEJCK = false;
			return null;
		}
		if (stringBuilder != null)
		{
			return stringBuilder.ToString();
		}
		return new string(BNCGGGFKADO, 0, num);
	}

	private string OLICNFCCEAG()
	{
		MAFEHLLPMOD();
		int num = FNPAOELFEIC(EHJNMODJEAN);
		int length = num - EHJNMODJEAN + 1;
		string result = new string(BIPAJFCNEOB, EHJNMODJEAN, length);
		EHJNMODJEAN = num + 1;
		return result;
	}

	public float CGGAOFELHOA()
	{
		string s = OLICNFCCEAG();
		float result;
		if (!float.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out result))
		{
			return 0f;
		}
		return result;
	}

	public double GOBJFJNKNCC()
	{
		string s = OLICNFCCEAG();
		double result;
		if (!double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out result))
		{
			return 0.0;
		}
		return result;
	}

	private int FNPAOELFEIC(int EHJNMODJEAN)
	{
		int i;
		for (i = EHJNMODJEAN; i < BIPAJFCNEOB.Length; i++)
		{
			char c = BIPAJFCNEOB[i];
			if ((c < '0' || c > '9') && c != '+' && c != '-' && c != '.' && c != 'e' && c != 'E')
			{
				break;
			}
		}
		return i - 1;
	}

	private void MAFEHLLPMOD()
	{
		while (EHJNMODJEAN < BIPAJFCNEOB.Length)
		{
			char c = BIPAJFCNEOB[EHJNMODJEAN];
			if (c == '\n')
			{
				HGCMIDFMKHD++;
			}
			if (!char.IsWhiteSpace(BIPAJFCNEOB[EHJNMODJEAN]))
			{
				break;
			}
			EHJNMODJEAN++;
		}
	}

	public KELIKHGNJPC PLDOBBHPPKK()
	{
		MAFEHLLPMOD();
		int EHJNMODJEAN = this.EHJNMODJEAN;
		return NMLDMNBOJFN(BIPAJFCNEOB, ref EHJNMODJEAN);
	}

	public KELIKHGNJPC NMLDMNBOJFN()
	{
		MAFEHLLPMOD();
		return NMLDMNBOJFN(BIPAJFCNEOB, ref EHJNMODJEAN);
	}

	private static KELIKHGNJPC NMLDMNBOJFN(char[] BIPAJFCNEOB, ref int EHJNMODJEAN)
	{
		if (EHJNMODJEAN == BIPAJFCNEOB.Length)
		{
			return KELIKHGNJPC.None;
		}
		switch (BIPAJFCNEOB[EHJNMODJEAN++])
		{
		case '{':
			return KELIKHGNJPC.CurlyOpen;
		case '}':
			return KELIKHGNJPC.CurlyClose;
		case '[':
			return KELIKHGNJPC.SquaredOpen;
		case ']':
			return KELIKHGNJPC.SquaredClose;
		case ',':
			return KELIKHGNJPC.Comma;
		case '"':
			return KELIKHGNJPC.String;
		case '-':
		case '0':
		case '1':
		case '2':
		case '3':
		case '4':
		case '5':
		case '6':
		case '7':
		case '8':
		case '9':
			return KELIKHGNJPC.Number;
		case ':':
			return KELIKHGNJPC.Colon;
		default:
		{
			EHJNMODJEAN--;
			int num = BIPAJFCNEOB.Length - EHJNMODJEAN;
			if (num >= 5 && BIPAJFCNEOB[EHJNMODJEAN] == 'f' && BIPAJFCNEOB[EHJNMODJEAN + 1] == 'a' && BIPAJFCNEOB[EHJNMODJEAN + 2] == 'l' && BIPAJFCNEOB[EHJNMODJEAN + 3] == 's' && BIPAJFCNEOB[EHJNMODJEAN + 4] == 'e')
			{
				EHJNMODJEAN += 5;
				return KELIKHGNJPC.False;
			}
			if (num >= 4 && BIPAJFCNEOB[EHJNMODJEAN] == 't' && BIPAJFCNEOB[EHJNMODJEAN + 1] == 'r' && BIPAJFCNEOB[EHJNMODJEAN + 2] == 'u' && BIPAJFCNEOB[EHJNMODJEAN + 3] == 'e')
			{
				EHJNMODJEAN += 4;
				return KELIKHGNJPC.True;
			}
			if (num >= 4 && BIPAJFCNEOB[EHJNMODJEAN] == 'n' && BIPAJFCNEOB[EHJNMODJEAN + 1] == 'u' && BIPAJFCNEOB[EHJNMODJEAN + 2] == 'l' && BIPAJFCNEOB[EHJNMODJEAN + 3] == 'l')
			{
				EHJNMODJEAN += 4;
				return KELIKHGNJPC.Null;
			}
			return KELIKHGNJPC.None;
		}
		}
	}
}
