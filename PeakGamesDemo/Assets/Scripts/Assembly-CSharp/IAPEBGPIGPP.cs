using System;
using System.IO;

internal class IAPEBGPIGPP : Stream
{
	protected readonly OHPHNNNHCOO JFBOCCEMONP;

	public override bool OEIHDCMBCBA
	{
		get
		{
			return false;
		}
	}

	public override bool APIAGFPBBPE
	{
		get
		{
			return true;
		}
	}

	public override bool GEEJNFKINOG
	{
		get
		{
			return false;
		}
	}

	public override long EJIAJLPHOGC
	{
		get
		{
			return 0L;
		}
	}

	public override long LJCIBEOLCHF
	{
		get
		{
			throw new NotImplementedException();
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public IAPEBGPIGPP(OHPHNNNHCOO JFBOCCEMONP)
	{
		this.JFBOCCEMONP = JFBOCCEMONP;
	}

	public override int Read(byte[] DJDKLOJBJCO, int IBNDGNOIEEF, int ENMLICFLHAO)
	{
		throw new NotImplementedException();
	}

	public override int ReadByte()
	{
		throw new NotImplementedException();
	}

	public override void Write(byte[] DJDKLOJBJCO, int IBNDGNOIEEF, int ENMLICFLHAO)
	{
		if (ENMLICFLHAO > 0)
		{
			JFBOCCEMONP.GONEEEFEDGF(DJDKLOJBJCO, IBNDGNOIEEF, ENMLICFLHAO);
		}
	}

	public override void WriteByte(byte BCIHLCMFAEK)
	{
		JFBOCCEMONP.BPAJGOINFNL(BCIHLCMFAEK);
	}

	public override void Flush()
	{
	}

	public override long Seek(long IBNDGNOIEEF, SeekOrigin EBDCOMKHPBG)
	{
		throw new NotImplementedException();
	}

	public override void SetLength(long EOFAGACBNFP)
	{
		throw new NotImplementedException();
	}
}
