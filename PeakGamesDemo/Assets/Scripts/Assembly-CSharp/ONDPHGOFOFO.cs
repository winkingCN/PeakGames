using System;
using System.IO;

internal class ONDPHGOFOFO : Stream
{
	private readonly HEMGBKNMOKB ACBFAFJINMJ;

	public override bool OEIHDCMBCBA
	{
		get
		{
			return !ACBFAFJINMJ.GGKOJOMPGEK;
		}
	}

	public override bool GEEJNFKINOG
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
			return !ACBFAFJINMJ.GGKOJOMPGEK;
		}
	}

	public override long EJIAJLPHOGC
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	public override long LJCIBEOLCHF
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

	internal ONDPHGOFOFO(HEMGBKNMOKB ACBFAFJINMJ)
	{
		this.ACBFAFJINMJ = ACBFAFJINMJ;
	}

	public override void Close()
	{
		ACBFAFJINMJ.NKKOEHGDNKD();
		base.Close();
	}

	public override void Flush()
	{
		ACBFAFJINMJ.COGIEDKOBPC();
	}

	public override int Read(byte[] GHPCHPOHELF, int JBAJPGIAPFF, int NBEDPKHALCN)
	{
		return ACBFAFJINMJ.MOANMMEHBDL(GHPCHPOHELF, JBAJPGIAPFF, NBEDPKHALCN);
	}

	public override int ReadByte()
	{
		byte[] array = new byte[1];
		if (Read(array, 0, 1) <= 0)
		{
			return -1;
		}
		return array[0];
	}

	public override long Seek(long IBNDGNOIEEF, SeekOrigin EBDCOMKHPBG)
	{
		throw new NotSupportedException();
	}

	public override void SetLength(long EDDNOJDPMCF)
	{
		throw new NotSupportedException();
	}

	public override void Write(byte[] GHPCHPOHELF, int JBAJPGIAPFF, int NBEDPKHALCN)
	{
		ACBFAFJINMJ.APDJGECJPIP(GHPCHPOHELF, JBAJPGIAPFF, NBEDPKHALCN);
	}

	public override void WriteByte(byte BCIHLCMFAEK)
	{
		ACBFAFJINMJ.APDJGECJPIP(new byte[1] { BCIHLCMFAEK }, 0, 1);
	}
}
