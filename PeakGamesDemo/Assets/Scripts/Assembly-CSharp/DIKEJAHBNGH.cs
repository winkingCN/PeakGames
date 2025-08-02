using System;
using System.IO;

internal class DIKEJAHBNGH : GLHKJAKEPFB
{
	private static readonly byte[] JBCONIFELBM = new byte[0];

	private readonly int HGNCLOHNHLN;

	private int CBJBAHIPFKC;

	internal int DFJPIBBCOHB
	{
		get
		{
			return CBJBAHIPFKC;
		}
	}

	internal DIKEJAHBNGH(Stream EPKPLBOMHJL, int EOFAGACBNFP)
		: base(EPKPLBOMHJL, EOFAGACBNFP)
	{
		if (EOFAGACBNFP < 0)
		{
			throw new ArgumentException("negative lengths not allowed", "length");
		}
		HGNCLOHNHLN = EOFAGACBNFP;
		CBJBAHIPFKC = EOFAGACBNFP;
		if (EOFAGACBNFP == 0)
		{
			KJOIBEMFMLC(true);
		}
	}

	public override int ReadByte()
	{
		if (CBJBAHIPFKC == 0)
		{
			return -1;
		}
		int num = LDHCAPEAKHM.ReadByte();
		if (num < 0)
		{
			throw new EndOfStreamException("DEF length " + HGNCLOHNHLN + " object truncated by " + CBJBAHIPFKC);
		}
		if (--CBJBAHIPFKC == 0)
		{
			KJOIBEMFMLC(true);
		}
		return num;
	}

	public override int Read(byte[] GHPCHPOHELF, int JBAJPGIAPFF, int NBEDPKHALCN)
	{
		if (CBJBAHIPFKC == 0)
		{
			return 0;
		}
		int count = Math.Min(NBEDPKHALCN, CBJBAHIPFKC);
		int num = LDHCAPEAKHM.Read(GHPCHPOHELF, JBAJPGIAPFF, count);
		if (num < 1)
		{
			throw new EndOfStreamException("DEF length " + HGNCLOHNHLN + " object truncated by " + CBJBAHIPFKC);
		}
		if ((CBJBAHIPFKC -= num) == 0)
		{
			KJOIBEMFMLC(true);
		}
		return num;
	}

	internal void LHKGEPBLMFH(byte[] GHPCHPOHELF)
	{
		if (CBJBAHIPFKC != GHPCHPOHELF.Length)
		{
			throw new ArgumentException("buffer length not right for data");
		}
		if ((CBJBAHIPFKC -= NPBFDBCHIGL.PCNDKGFHPJN(LDHCAPEAKHM, GHPCHPOHELF)) != 0)
		{
			throw new EndOfStreamException("DEF length " + HGNCLOHNHLN + " object truncated by " + CBJBAHIPFKC);
		}
		KJOIBEMFMLC(true);
	}

	internal byte[] GDPLKNIEGDB()
	{
		if (CBJBAHIPFKC == 0)
		{
			return JBCONIFELBM;
		}
		byte[] array = new byte[CBJBAHIPFKC];
		if ((CBJBAHIPFKC -= NPBFDBCHIGL.PCNDKGFHPJN(LDHCAPEAKHM, array)) != 0)
		{
			throw new EndOfStreamException("DEF length " + HGNCLOHNHLN + " object truncated by " + CBJBAHIPFKC);
		}
		KJOIBEMFMLC(true);
		return array;
	}
}
