using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

public static class DHOJBMHOLOI
{
	private sealed class GJIMKHELIHN : IDisposable
	{
		private enum DOPJPDOGHOC
		{
			NONE = 0,
			CURLY_OPEN = 1,
			CURLY_CLOSE = 2,
			SQUARED_OPEN = 3,
			SQUARED_CLOSE = 4,
			COLON = 5,
			COMMA = 6,
			STRING = 7,
			NUMBER = 8,
			TRUE = 9,
			FALSE = 10,
			NULL = 11
		}

		private const string PEONPPPLOON = "{}[],:\"";

		private StringReader BIPAJFCNEOB;

		private char NHECMPKBHBH
		{
			get
			{
				return Convert.ToChar(BIPAJFCNEOB.Peek());
			}
		}

		private char HJCKKKBJNFJ
		{
			get
			{
				return Convert.ToChar(BIPAJFCNEOB.Read());
			}
		}

		private string AHNHENDDFNC
		{
			get
			{
				StringBuilder stringBuilder = new StringBuilder();
				while (!LLJPJEHGDDB(NHECMPKBHBH))
				{
					stringBuilder.Append(HJCKKKBJNFJ);
					if (BIPAJFCNEOB.Peek() == -1)
					{
						break;
					}
				}
				return stringBuilder.ToString();
			}
		}

		private DOPJPDOGHOC NMLDMNBOJFN
		{
			get
			{
				HELNDNLFJGK();
				if (BIPAJFCNEOB.Peek() == -1)
				{
					return DOPJPDOGHOC.NONE;
				}
				switch (NHECMPKBHBH)
				{
				case '{':
					return DOPJPDOGHOC.CURLY_OPEN;
				case '}':
					BIPAJFCNEOB.Read();
					return DOPJPDOGHOC.CURLY_CLOSE;
				case '[':
					return DOPJPDOGHOC.SQUARED_OPEN;
				case ']':
					BIPAJFCNEOB.Read();
					return DOPJPDOGHOC.SQUARED_CLOSE;
				case ',':
					BIPAJFCNEOB.Read();
					return DOPJPDOGHOC.COMMA;
				case '"':
					return DOPJPDOGHOC.STRING;
				case ':':
					return DOPJPDOGHOC.COLON;
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
					return DOPJPDOGHOC.NUMBER;
				default:
					switch (AHNHENDDFNC)
					{
					case "false":
						return DOPJPDOGHOC.FALSE;
					case "true":
						return DOPJPDOGHOC.TRUE;
					case "null":
						return DOPJPDOGHOC.NULL;
					default:
						return DOPJPDOGHOC.NONE;
					}
				}
			}
		}

		private GJIMKHELIHN(string HDGFMHEHJBG)
		{
			BIPAJFCNEOB = new StringReader(HDGFMHEHJBG);
		}

		public static bool LLJPJEHGDDB(char FMFABAKPMLB)
		{
			return char.IsWhiteSpace(FMFABAKPMLB) || "{}[],:\"".IndexOf(FMFABAKPMLB) != -1;
		}

		public static object DHCLOMIANOE(string HDGFMHEHJBG)
		{
			using (GJIMKHELIHN gJIMKHELIHN = new GJIMKHELIHN(HDGFMHEHJBG))
			{
				return gJIMKHELIHN.FCPAAENDINA();
			}
		}

		public void Dispose()
		{
			BIPAJFCNEOB.Dispose();
			BIPAJFCNEOB = null;
		}

		private Dictionary<string, object> NDBCIEPMAKF()
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			BIPAJFCNEOB.Read();
			while (true)
			{
				switch (NMLDMNBOJFN)
				{
				case DOPJPDOGHOC.COMMA:
					continue;
				case DOPJPDOGHOC.NONE:
					return null;
				case DOPJPDOGHOC.CURLY_CLOSE:
					return dictionary;
				}
				string text = LGADJFBGGID();
				if (text == null)
				{
					return null;
				}
				if (NMLDMNBOJFN != DOPJPDOGHOC.COLON)
				{
					return null;
				}
				BIPAJFCNEOB.Read();
				dictionary[text] = FCPAAENDINA();
			}
		}

		private List<object> HDLINDDEOBC()
		{
			List<object> list = new List<object>();
			BIPAJFCNEOB.Read();
			bool flag = true;
			while (flag)
			{
				DOPJPDOGHOC dOPJPDOGHOC = NMLDMNBOJFN;
				switch (dOPJPDOGHOC)
				{
				case DOPJPDOGHOC.NONE:
					return null;
				case DOPJPDOGHOC.SQUARED_CLOSE:
					flag = false;
					break;
				default:
				{
					object item = DHENBJDIPFJ(dOPJPDOGHOC);
					list.Add(item);
					break;
				}
				case DOPJPDOGHOC.COMMA:
					break;
				}
			}
			return list;
		}

		private object FCPAAENDINA()
		{
			DOPJPDOGHOC dJJGDFFDGFN = NMLDMNBOJFN;
			return DHENBJDIPFJ(dJJGDFFDGFN);
		}

		private object DHENBJDIPFJ(DOPJPDOGHOC DJJGDFFDGFN)
		{
			switch (DJJGDFFDGFN)
			{
			case DOPJPDOGHOC.STRING:
				return LGADJFBGGID();
			case DOPJPDOGHOC.NUMBER:
				return PDEHNOJODNI();
			case DOPJPDOGHOC.CURLY_OPEN:
				return NDBCIEPMAKF();
			case DOPJPDOGHOC.SQUARED_OPEN:
				return HDLINDDEOBC();
			case DOPJPDOGHOC.TRUE:
				return true;
			case DOPJPDOGHOC.FALSE:
				return false;
			case DOPJPDOGHOC.NULL:
				return null;
			default:
				return null;
			}
		}

		private string LGADJFBGGID()
		{
			StringBuilder stringBuilder = new StringBuilder();
			BIPAJFCNEOB.Read();
			bool flag = true;
			while (flag)
			{
				if (BIPAJFCNEOB.Peek() == -1)
				{
					flag = false;
					break;
				}
				char c = HJCKKKBJNFJ;
				switch (c)
				{
				case '"':
					flag = false;
					break;
				case '\\':
					if (BIPAJFCNEOB.Peek() == -1)
					{
						flag = false;
						break;
					}
					c = HJCKKKBJNFJ;
					switch (c)
					{
					case '"':
					case '/':
					case '\\':
						stringBuilder.Append(c);
						break;
					case 'b':
						stringBuilder.Append('\b');
						break;
					case 'f':
						stringBuilder.Append('\f');
						break;
					case 'n':
						stringBuilder.Append('\n');
						break;
					case 'r':
						stringBuilder.Append('\r');
						break;
					case 't':
						stringBuilder.Append('\t');
						break;
					case 'u':
					{
						char[] array = new char[4];
						for (int i = 0; i < 4; i++)
						{
							array[i] = HJCKKKBJNFJ;
						}
						stringBuilder.Append((char)Convert.ToInt32(new string(array), 16));
						break;
					}
					}
					break;
				default:
					stringBuilder.Append(c);
					break;
				}
			}
			return stringBuilder.ToString();
		}

		private object PDEHNOJODNI()
		{
			string text = AHNHENDDFNC;
			if (text.IndexOf('.') == -1)
			{
				long result;
				long.TryParse(text, out result);
				return result;
			}
			double result2;
			double.TryParse(text, out result2);
			return result2;
		}

		private void HELNDNLFJGK()
		{
			while (char.IsWhiteSpace(NHECMPKBHBH))
			{
				BIPAJFCNEOB.Read();
				if (BIPAJFCNEOB.Peek() == -1)
				{
					break;
				}
			}
		}
	}

	private sealed class CNKHNPAJPDM
	{
		private StringBuilder OFIAADJFEDJ;

		private CNKHNPAJPDM()
		{
			OFIAADJFEDJ = new StringBuilder();
		}

		public static string LFIJNCAPDMO(object NEMEKIOEOLC)
		{
			CNKHNPAJPDM cNKHNPAJPDM = new CNKHNPAJPDM();
			cNKHNPAJPDM.PEMHKGCBFOP(NEMEKIOEOLC);
			return cNKHNPAJPDM.OFIAADJFEDJ.ToString();
		}

		private void PEMHKGCBFOP(object EDDNOJDPMCF)
		{
			string gFPBBLPMOOL;
			IList pGCENHPBBFF;
			IDictionary nEMEKIOEOLC;
			if (EDDNOJDPMCF == null)
			{
				OFIAADJFEDJ.Append("null");
			}
			else if ((gFPBBLPMOOL = EDDNOJDPMCF as string) != null)
			{
				HILJNLOFBMF(gFPBBLPMOOL);
			}
			else if (EDDNOJDPMCF is bool)
			{
				OFIAADJFEDJ.Append((!(bool)EDDNOJDPMCF) ? "false" : "true");
			}
			else if ((pGCENHPBBFF = EDDNOJDPMCF as IList) != null)
			{
				AOHGKBKLJNP(pGCENHPBBFF);
			}
			else if ((nEMEKIOEOLC = EDDNOJDPMCF as IDictionary) != null)
			{
				KJMNPEJCJJN(nEMEKIOEOLC);
			}
			else if (EDDNOJDPMCF is char)
			{
				HILJNLOFBMF(new string((char)EDDNOJDPMCF, 1));
			}
			else
			{
				IDACNJFJGNN(EDDNOJDPMCF);
			}
		}

		private void KJMNPEJCJJN(IDictionary NEMEKIOEOLC)
		{
			bool flag = true;
			OFIAADJFEDJ.Append('{');
			foreach (object key in NEMEKIOEOLC.Keys)
			{
				if (!flag)
				{
					OFIAADJFEDJ.Append(',');
				}
				HILJNLOFBMF(key.ToString());
				OFIAADJFEDJ.Append(':');
				PEMHKGCBFOP(NEMEKIOEOLC[key]);
				flag = false;
			}
			OFIAADJFEDJ.Append('}');
		}

		private void AOHGKBKLJNP(IList PGCENHPBBFF)
		{
			OFIAADJFEDJ.Append('[');
			bool flag = true;
			foreach (object item in PGCENHPBBFF)
			{
				if (!flag)
				{
					OFIAADJFEDJ.Append(',');
				}
				PEMHKGCBFOP(item);
				flag = false;
			}
			OFIAADJFEDJ.Append(']');
		}

		private void HILJNLOFBMF(string GFPBBLPMOOL)
		{
			OFIAADJFEDJ.Append('"');
			char[] array = GFPBBLPMOOL.ToCharArray();
			char[] array2 = array;
			foreach (char c in array2)
			{
				switch (c)
				{
				case '"':
					OFIAADJFEDJ.Append("\\\"");
					continue;
				case '\\':
					OFIAADJFEDJ.Append("\\\\");
					continue;
				case '\b':
					OFIAADJFEDJ.Append("\\b");
					continue;
				case '\f':
					OFIAADJFEDJ.Append("\\f");
					continue;
				case '\n':
					OFIAADJFEDJ.Append("\\n");
					continue;
				case '\r':
					OFIAADJFEDJ.Append("\\r");
					continue;
				case '\t':
					OFIAADJFEDJ.Append("\\t");
					continue;
				}
				int num = Convert.ToInt32(c);
				if (num >= 32 && num <= 126)
				{
					OFIAADJFEDJ.Append(c);
					continue;
				}
				OFIAADJFEDJ.Append("\\u");
				OFIAADJFEDJ.Append(num.ToString("x4"));
			}
			OFIAADJFEDJ.Append('"');
		}

		private void IDACNJFJGNN(object EDDNOJDPMCF)
		{
			if (EDDNOJDPMCF is float)
			{
				OFIAADJFEDJ.Append(((float)EDDNOJDPMCF).ToString("R"));
			}
			else if (EDDNOJDPMCF is int || EDDNOJDPMCF is uint || EDDNOJDPMCF is long || EDDNOJDPMCF is sbyte || EDDNOJDPMCF is byte || EDDNOJDPMCF is short || EDDNOJDPMCF is ushort || EDDNOJDPMCF is ulong)
			{
				OFIAADJFEDJ.Append(EDDNOJDPMCF);
			}
			else if (EDDNOJDPMCF is double || EDDNOJDPMCF is decimal)
			{
				OFIAADJFEDJ.Append(Convert.ToDouble(EDDNOJDPMCF).ToString("R"));
			}
			else
			{
				HILJNLOFBMF(EDDNOJDPMCF.ToString());
			}
		}
	}

	public static object NBPMNECNBHJ(string BIPAJFCNEOB)
	{
		if (BIPAJFCNEOB == null)
		{
			return null;
		}
		return GJIMKHELIHN.DHCLOMIANOE(BIPAJFCNEOB);
	}

	public static string LFIJNCAPDMO(object NEMEKIOEOLC)
	{
		return CNKHNPAJPDM.LFIJNCAPDMO(NEMEKIOEOLC);
	}
}
