using System;
using System.IO;

public class PFGADOAKFGI : JJOLEANMIHG
{
	private int GHPCHPOHELF = -1;

	public PFGADOAKFGI(Stream IBBBMACIBGK)
		: base(IBBBMACIBGK)
	{
	}

	public override int ReadByte()
	{
		if (GHPCHPOHELF != -1)
		{
			int gHPCHPOHELF = GHPCHPOHELF;
			GHPCHPOHELF = -1;
			return gHPCHPOHELF;
		}
		return base.ReadByte();
	}

	public override int Read(byte[] DJDKLOJBJCO, int IBNDGNOIEEF, int ENMLICFLHAO)
	{
		if (GHPCHPOHELF != -1 && ENMLICFLHAO > 0)
		{
			DJDKLOJBJCO[IBNDGNOIEEF] = (byte)GHPCHPOHELF;
			GHPCHPOHELF = -1;
			return 1;
		}
		return base.Read(DJDKLOJBJCO, IBNDGNOIEEF, ENMLICFLHAO);
	}

	public virtual void CNHKNKAFPKE(int BCIHLCMFAEK)
	{
		if (GHPCHPOHELF != -1)
		{
			throw new InvalidOperationException("Can only push back one byte");
		}
		GHPCHPOHELF = BCIHLCMFAEK & 0xFF;
	}
}
