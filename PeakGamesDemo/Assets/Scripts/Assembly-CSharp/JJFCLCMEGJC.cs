using System;
using System.IO;

public abstract class JJFCLCMEGJC : Stream
{
	private bool MBEOPLHLANP;

	public sealed override bool OEIHDCMBCBA
	{
		get
		{
			return false;
		}
	}

	public sealed override bool GEEJNFKINOG
	{
		get
		{
			return false;
		}
	}

	public sealed override bool APIAGFPBBPE
	{
		get
		{
			return !MBEOPLHLANP;
		}
	}

	public sealed override long EJIAJLPHOGC
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	public sealed override long LJCIBEOLCHF
	{
		get
		{
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public override void Close()
	{
		MBEOPLHLANP = true;
		base.Close();
	}

	public override void Flush()
	{
	}

	public sealed override int Read(byte[] DJDKLOJBJCO, int IBNDGNOIEEF, int ENMLICFLHAO)
	{
		throw new NotSupportedException();
	}

	public sealed override long Seek(long IBNDGNOIEEF, SeekOrigin EBDCOMKHPBG)
	{
		throw new NotSupportedException();
	}

	public sealed override void SetLength(long EDDNOJDPMCF)
	{
		throw new NotSupportedException();
	}

	public override void Write(byte[] DJDKLOJBJCO, int IBNDGNOIEEF, int ENMLICFLHAO)
	{
		int num = IBNDGNOIEEF + ENMLICFLHAO;
		for (int i = IBNDGNOIEEF; i < num; i++)
		{
			WriteByte(DJDKLOJBJCO[i]);
		}
	}

	public virtual void KBMOJGCCCEN(params byte[] DJDKLOJBJCO)
	{
		Write(DJDKLOJBJCO, 0, DJDKLOJBJCO.Length);
	}
}
