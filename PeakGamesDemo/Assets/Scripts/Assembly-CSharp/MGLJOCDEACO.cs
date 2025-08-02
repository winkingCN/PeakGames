using System.Collections.Generic;

public class MGLJOCDEACO
{
	private ANDHJPJNLNI JBNPKCNEJGG;

	public string AELPGDIJOCN { get; private set; }

	public bool AGHFOCILFDH { get; set; }

	public MGLJOCDEACO()
	{
		AELPGDIJOCN = null;
		AGHFOCILFDH = false;
	}

	public object ILOALOLANOL(string FCJBBPHFNPJ)
	{
		AELPGDIJOCN = null;
		JBNPKCNEJGG = new ANDHJPJNLNI(FCJBBPHFNPJ);
		JBNPKCNEJGG.AGHFOCILFDH = AGHFOCILFDH;
		return FCPAAENDINA();
	}

	public static object LMMFKDKLKNL(string FCJBBPHFNPJ)
	{
		MGLJOCDEACO mGLJOCDEACO = new MGLJOCDEACO();
		return mGLJOCDEACO.ILOALOLANOL(FCJBBPHFNPJ);
	}

	private IDictionary<string, object> NDBCIEPMAKF()
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		JBNPKCNEJGG.NMLDMNBOJFN();
		while (true)
		{
			switch (JBNPKCNEJGG.PLDOBBHPPKK())
			{
			case ANDHJPJNLNI.KELIKHGNJPC.None:
				EHGAMNIBLEE("Invalid token");
				return null;
			case ANDHJPJNLNI.KELIKHGNJPC.Comma:
				JBNPKCNEJGG.NMLDMNBOJFN();
				continue;
			case ANDHJPJNLNI.KELIKHGNJPC.CurlyClose:
				JBNPKCNEJGG.NMLDMNBOJFN();
				return dictionary;
			}
			string key = GIBIMMPAJPJ(JBNPKCNEJGG.LGADJFBGGID());
			if (AELPGDIJOCN != null)
			{
				return null;
			}
			ANDHJPJNLNI.KELIKHGNJPC kELIKHGNJPC = JBNPKCNEJGG.NMLDMNBOJFN();
			if (kELIKHGNJPC != ANDHJPJNLNI.KELIKHGNJPC.Colon)
			{
				EHGAMNIBLEE("Invalid token; expected ':'");
				return null;
			}
			object value = FCPAAENDINA();
			if (AELPGDIJOCN != null)
			{
				return null;
			}
			dictionary[key] = value;
		}
	}

	private IList<object> HDLINDDEOBC()
	{
		List<object> list = new List<object>();
		JBNPKCNEJGG.NMLDMNBOJFN();
		while (true)
		{
			switch (JBNPKCNEJGG.PLDOBBHPPKK())
			{
			case ANDHJPJNLNI.KELIKHGNJPC.None:
				EHGAMNIBLEE("Invalid token");
				return null;
			case ANDHJPJNLNI.KELIKHGNJPC.Comma:
				JBNPKCNEJGG.NMLDMNBOJFN();
				continue;
			case ANDHJPJNLNI.KELIKHGNJPC.SquaredClose:
				JBNPKCNEJGG.NMLDMNBOJFN();
				return list;
			}
			object item = FCPAAENDINA();
			if (AELPGDIJOCN != null)
			{
				return null;
			}
			list.Add(item);
		}
	}

	private object FCPAAENDINA()
	{
		switch (JBNPKCNEJGG.PLDOBBHPPKK())
		{
		case ANDHJPJNLNI.KELIKHGNJPC.String:
			return GIBIMMPAJPJ(JBNPKCNEJGG.LGADJFBGGID());
		case ANDHJPJNLNI.KELIKHGNJPC.Number:
			if (AGHFOCILFDH)
			{
				return GIBIMMPAJPJ(JBNPKCNEJGG.CGGAOFELHOA());
			}
			return GIBIMMPAJPJ(JBNPKCNEJGG.GOBJFJNKNCC());
		case ANDHJPJNLNI.KELIKHGNJPC.CurlyOpen:
			return NDBCIEPMAKF();
		case ANDHJPJNLNI.KELIKHGNJPC.SquaredOpen:
			return HDLINDDEOBC();
		case ANDHJPJNLNI.KELIKHGNJPC.True:
			JBNPKCNEJGG.NMLDMNBOJFN();
			return true;
		case ANDHJPJNLNI.KELIKHGNJPC.False:
			JBNPKCNEJGG.NMLDMNBOJFN();
			return false;
		case ANDHJPJNLNI.KELIKHGNJPC.Null:
			JBNPKCNEJGG.NMLDMNBOJFN();
			return null;
		default:
			EHGAMNIBLEE("Unable to parse value");
			return null;
		}
	}

	private void EHGAMNIBLEE(string OEFCOJLNCKP)
	{
		AELPGDIJOCN = string.Format("Error: '{0}' at line {1}", OEFCOJLNCKP, JBNPKCNEJGG.HGCMIDFMKHD);
	}

	private T GIBIMMPAJPJ<T>(T EDDNOJDPMCF)
	{
		if (JBNPKCNEJGG.CDMLGKLOJIO)
		{
			EHGAMNIBLEE("Lexical error ocurred");
		}
		return EDDNOJDPMCF;
	}
}
