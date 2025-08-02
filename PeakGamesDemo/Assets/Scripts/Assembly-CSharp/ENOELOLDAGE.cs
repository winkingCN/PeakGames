using System.IO;

internal class ENOELOLDAGE : GLHKJAKEPFB
{
	private int MKBHIDDJBMJ;

	private bool FCMPHECONBF = true;

	internal ENOELOLDAGE(Stream EPKPLBOMHJL, int GJHEBCMICMA)
		: base(EPKPLBOMHJL, GJHEBCMICMA)
	{
		MKBHIDDJBMJ = LMMKGNBKJJP();
		DDKCBDCCECJ();
	}

	internal void PFJFBEFJIHC(bool EPFIMOOLHHL)
	{
		FCMPHECONBF = EPFIMOOLHHL;
		if (FCMPHECONBF)
		{
			DDKCBDCCECJ();
		}
	}

	private bool DDKCBDCCECJ()
	{
		if (MKBHIDDJBMJ == 0)
		{
			if (LMMKGNBKJJP() != 0)
			{
				throw new IOException("malformed end-of-contents marker");
			}
			MKBHIDDJBMJ = -1;
			KJOIBEMFMLC(true);
			return true;
		}
		return MKBHIDDJBMJ < 0;
	}

	public override int Read(byte[] DJDKLOJBJCO, int IBNDGNOIEEF, int ENMLICFLHAO)
	{
		if (FCMPHECONBF || ENMLICFLHAO <= 1)
		{
			return base.Read(DJDKLOJBJCO, IBNDGNOIEEF, ENMLICFLHAO);
		}
		if (MKBHIDDJBMJ < 0)
		{
			return 0;
		}
		int num = LDHCAPEAKHM.Read(DJDKLOJBJCO, IBNDGNOIEEF + 1, ENMLICFLHAO - 1);
		if (num <= 0)
		{
			throw new EndOfStreamException();
		}
		DJDKLOJBJCO[IBNDGNOIEEF] = (byte)MKBHIDDJBMJ;
		MKBHIDDJBMJ = LMMKGNBKJJP();
		return num + 1;
	}

	public override int ReadByte()
	{
		if (FCMPHECONBF && DDKCBDCCECJ())
		{
			return -1;
		}
		int mKBHIDDJBMJ = MKBHIDDJBMJ;
		MKBHIDDJBMJ = LMMKGNBKJJP();
		return mKBHIDDJBMJ;
	}

	private int LMMKGNBKJJP()
	{
		int num = LDHCAPEAKHM.ReadByte();
		if (num < 0)
		{
			throw new EndOfStreamException();
		}
		return num;
	}
}
