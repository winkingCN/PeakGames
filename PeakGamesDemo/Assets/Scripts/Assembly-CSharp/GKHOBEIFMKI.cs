using System.IO;

public class GKHOBEIFMKI : Stream
{
	protected readonly Stream IBBBMACIBGK;

	public override bool OEIHDCMBCBA
	{
		get
		{
			return IBBBMACIBGK.CanRead;
		}
	}

	public override bool GEEJNFKINOG
	{
		get
		{
			return IBBBMACIBGK.CanSeek;
		}
	}

	public override bool APIAGFPBBPE
	{
		get
		{
			return IBBBMACIBGK.CanWrite;
		}
	}

	public override long EJIAJLPHOGC
	{
		get
		{
			return IBBBMACIBGK.Length;
		}
	}

	public override long LJCIBEOLCHF
	{
		get
		{
			return IBBBMACIBGK.Position;
		}
		set
		{
			IBBBMACIBGK.Position = value;
		}
	}

	public GKHOBEIFMKI(Stream IBBBMACIBGK)
	{
		this.IBBBMACIBGK = IBBBMACIBGK;
	}

	public override void Close()
	{
		LHFGHNFJIKM.PCHCAFHEJJM(IBBBMACIBGK);
		base.Close();
	}

	public override void Flush()
	{
		IBBBMACIBGK.Flush();
	}

	public override long Seek(long IBNDGNOIEEF, SeekOrigin EBDCOMKHPBG)
	{
		return IBBBMACIBGK.Seek(IBNDGNOIEEF, EBDCOMKHPBG);
	}

	public override void SetLength(long EDDNOJDPMCF)
	{
		IBBBMACIBGK.SetLength(EDDNOJDPMCF);
	}

	public override int Read(byte[] DJDKLOJBJCO, int IBNDGNOIEEF, int ENMLICFLHAO)
	{
		return IBBBMACIBGK.Read(DJDKLOJBJCO, IBNDGNOIEEF, ENMLICFLHAO);
	}

	public override int ReadByte()
	{
		return IBBBMACIBGK.ReadByte();
	}

	public override void Write(byte[] DJDKLOJBJCO, int IBNDGNOIEEF, int ENMLICFLHAO)
	{
		IBBBMACIBGK.Write(DJDKLOJBJCO, IBNDGNOIEEF, ENMLICFLHAO);
	}

	public override void WriteByte(byte EDDNOJDPMCF)
	{
		IBBBMACIBGK.WriteByte(EDDNOJDPMCF);
	}
}
