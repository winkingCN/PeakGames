using System;
using System.IO;

public abstract class HGJIPGDINJI : Stream
{
	private bool MBEOPLHLANP;

	public sealed override bool OEIHDCMBCBA
	{
		get
		{
			return !MBEOPLHLANP;
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
			return false;
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

	public sealed override void Flush()
	{
	}

	public override int Read(byte[] DJDKLOJBJCO, int IBNDGNOIEEF, int ENMLICFLHAO)
	{
		int num = IBNDGNOIEEF;
		try
		{
			int num2 = IBNDGNOIEEF + ENMLICFLHAO;
			while (num < num2)
			{
				int num3 = ReadByte();
				if (num3 == -1)
				{
					break;
				}
				DJDKLOJBJCO[num++] = (byte)num3;
			}
		}
		catch (IOException)
		{
			if (num == IBNDGNOIEEF)
			{
				throw;
			}
		}
		return num - IBNDGNOIEEF;
	}

	public sealed override long Seek(long IBNDGNOIEEF, SeekOrigin EBDCOMKHPBG)
	{
		throw new NotSupportedException();
	}

	public sealed override void SetLength(long EDDNOJDPMCF)
	{
		throw new NotSupportedException();
	}

	public sealed override void Write(byte[] DJDKLOJBJCO, int IBNDGNOIEEF, int ENMLICFLHAO)
	{
		throw new NotSupportedException();
	}
}
