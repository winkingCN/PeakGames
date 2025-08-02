using System.IO;

public class OHAOIPKCMFC : BJLAMONNNDD
{
	private readonly MemoryStream JBKJDDDPONA = new MemoryStream();

	public string KFKMEPMEBND
	{
		get
		{
			return "NULL";
		}
	}

	public int MNAIJEEKPCP()
	{
		return 0;
	}

	public int EEMLLAMENHO()
	{
		return (int)JBKJDDDPONA.Length;
	}

	public void BPAJGOINFNL(byte BCIHLCMFAEK)
	{
		JBKJDDDPONA.WriteByte(BCIHLCMFAEK);
	}

	public void GONEEEFEDGF(byte[] AIFKJBMJOMK, int ELICNEDIBGB, int NBEDPKHALCN)
	{
		JBKJDDDPONA.Write(AIFKJBMJOMK, ELICNEDIBGB, NBEDPKHALCN);
	}

	public int LCNOFBMOHHM(byte[] NGAGMIIBGKA, int EMAKNGBIFDC)
	{
		byte[] array = JBKJDDDPONA.ToArray();
		array.CopyTo(NGAGMIIBGKA, EMAKNGBIFDC);
		OMOKOKFNBKI();
		return array.Length;
	}

	public void OMOKOKFNBKI()
	{
		JBKJDDDPONA.SetLength(0L);
	}
}
