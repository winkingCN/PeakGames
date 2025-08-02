using System;
using System.IO;

public class IONBDAJAGNJ : Stream
{
	private readonly AOIEPNLGJDJ DJDKLOJBJCO;

	public virtual int AJFPKOAKJOD
	{
		get
		{
			return DJDKLOJBJCO.AJFPKOAKJOD;
		}
	}

	public override bool OEIHDCMBCBA
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

	public override bool APIAGFPBBPE
	{
		get
		{
			return true;
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

	public IONBDAJAGNJ()
	{
		DJDKLOJBJCO = new AOIEPNLGJDJ();
	}

	public override void Flush()
	{
	}

	public virtual int DNMHOJNDABI(byte[] GHPCHPOHELF)
	{
		int num = Math.Min(DJDKLOJBJCO.AJFPKOAKJOD, GHPCHPOHELF.Length);
		DJDKLOJBJCO.CELOEBEMCKP(GHPCHPOHELF, 0, num, 0);
		return num;
	}

	public virtual int CELOEBEMCKP(byte[] GHPCHPOHELF)
	{
		return Read(GHPCHPOHELF, 0, GHPCHPOHELF.Length);
	}

	public override int Read(byte[] GHPCHPOHELF, int JBAJPGIAPFF, int NBEDPKHALCN)
	{
		int num = Math.Min(DJDKLOJBJCO.AJFPKOAKJOD, NBEDPKHALCN);
		DJDKLOJBJCO.LNFLLAIGBIO(GHPCHPOHELF, JBAJPGIAPFF, num, 0);
		return num;
	}

	public override int ReadByte()
	{
		if (DJDKLOJBJCO.AJFPKOAKJOD == 0)
		{
			return -1;
		}
		return DJDKLOJBJCO.LNFLLAIGBIO(1, 0)[0] & 0xFF;
	}

	public override long Seek(long IBNDGNOIEEF, SeekOrigin EBDCOMKHPBG)
	{
		throw new NotSupportedException();
	}

	public override void SetLength(long EDDNOJDPMCF)
	{
		throw new NotSupportedException();
	}

	public virtual int EKLILGBGLGD(int IDHLPOFDLKJ)
	{
		int num = Math.Min(DJDKLOJBJCO.AJFPKOAKJOD, IDHLPOFDLKJ);
		DJDKLOJBJCO.LNFLLAIGBIO(num);
		return num;
	}

	public virtual void KBMOJGCCCEN(byte[] GHPCHPOHELF)
	{
		DJDKLOJBJCO.ECGMPBCCBLB(GHPCHPOHELF, 0, GHPCHPOHELF.Length);
	}

	public override void Write(byte[] GHPCHPOHELF, int JBAJPGIAPFF, int NBEDPKHALCN)
	{
		DJDKLOJBJCO.ECGMPBCCBLB(GHPCHPOHELF, JBAJPGIAPFF, NBEDPKHALCN);
	}

	public override void WriteByte(byte BCIHLCMFAEK)
	{
		DJDKLOJBJCO.ECGMPBCCBLB(new byte[1] { BCIHLCMFAEK }, 0, 1);
	}
}
