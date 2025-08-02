using System.IO;

public class DKLELFJMFAA : HGJIPGDINJI
{
	private readonly Stream MOPCLEEGDFB;

	private readonly Stream MEBHMFEMDBP;

	public DKLELFJMFAA(Stream MOPCLEEGDFB, Stream MEBHMFEMDBP)
	{
		this.MOPCLEEGDFB = MOPCLEEGDFB;
		this.MEBHMFEMDBP = MEBHMFEMDBP;
	}

	public override void Close()
	{
		LHFGHNFJIKM.PCHCAFHEJJM(MOPCLEEGDFB);
		LHFGHNFJIKM.PCHCAFHEJJM(MEBHMFEMDBP);
		base.Close();
	}

	public override int Read(byte[] GHPCHPOHELF, int JBAJPGIAPFF, int NBEDPKHALCN)
	{
		int num = MOPCLEEGDFB.Read(GHPCHPOHELF, JBAJPGIAPFF, NBEDPKHALCN);
		if (num > 0)
		{
			MEBHMFEMDBP.Write(GHPCHPOHELF, JBAJPGIAPFF, num);
		}
		return num;
	}

	public override int ReadByte()
	{
		int num = MOPCLEEGDFB.ReadByte();
		if (num >= 0)
		{
			MEBHMFEMDBP.WriteByte((byte)num);
		}
		return num;
	}
}
