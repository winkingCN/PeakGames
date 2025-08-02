using System.IO;

public abstract class MFEBIMBMJMH : HHFIFCOHIFL
{
	private bool KIIDLMIJMGH;

	private bool OJGMJIAIBBI;

	private int OFJNLGKHCMB;

	protected MFEBIMBMJMH(Stream OMCALCLJPOD)
		: base(OMCALCLJPOD)
	{
	}

	protected MFEBIMBMJMH(Stream OMCALCLJPOD, int LGPKPEMILHA, bool DNBCBHLACCP)
		: base(OMCALCLJPOD)
	{
		KIIDLMIJMGH = true;
		OJGMJIAIBBI = DNBCBHLACCP;
		OFJNLGKHCMB = LGPKPEMILHA;
	}

	private static void CFNBLFIGKEK(Stream OBDBEMFLBID, int EOFAGACBNFP)
	{
		if (EOFAGACBNFP > 127)
		{
			int num = 1;
			int num2 = EOFAGACBNFP;
			while ((num2 >>= 8) != 0)
			{
				num++;
			}
			OBDBEMFLBID.WriteByte((byte)((uint)num | 0x80u));
			for (int num3 = (num - 1) * 8; num3 >= 0; num3 -= 8)
			{
				OBDBEMFLBID.WriteByte((byte)(EOFAGACBNFP >> num3));
			}
		}
		else
		{
			OBDBEMFLBID.WriteByte((byte)EOFAGACBNFP);
		}
	}

	internal static void GPDBOIKCNDD(Stream OMCALCLJPOD, int MOKLDCMGFFB, byte[] DIPNEDDIHBK)
	{
		OMCALCLJPOD.WriteByte((byte)MOKLDCMGFFB);
		CFNBLFIGKEK(OMCALCLJPOD, DIPNEDDIHBK.Length);
		OMCALCLJPOD.Write(DIPNEDDIHBK, 0, DIPNEDDIHBK.Length);
	}

	internal void GPDBOIKCNDD(int MOKLDCMGFFB, byte[] DIPNEDDIHBK)
	{
		if (KIIDLMIJMGH)
		{
			int num = OFJNLGKHCMB | 0x80;
			if (OJGMJIAIBBI)
			{
				int mOKLDCMGFFB = OFJNLGKHCMB | 0x20 | 0x80;
				MemoryStream memoryStream = new MemoryStream();
				GPDBOIKCNDD(memoryStream, MOKLDCMGFFB, DIPNEDDIHBK);
				GPDBOIKCNDD(base.CLDOFILJLHP, mOKLDCMGFFB, memoryStream.ToArray());
			}
			else
			{
				if (((uint)MOKLDCMGFFB & 0x20u) != 0)
				{
					num |= 0x20;
				}
				GPDBOIKCNDD(base.CLDOFILJLHP, num, DIPNEDDIHBK);
			}
		}
		else
		{
			GPDBOIKCNDD(base.CLDOFILJLHP, MOKLDCMGFFB, DIPNEDDIHBK);
		}
	}

	internal static void GPDBOIKCNDD(Stream OBDBEMFLBID, int MOKLDCMGFFB, Stream FILBOAMBNOP)
	{
		GPDBOIKCNDD(OBDBEMFLBID, MOKLDCMGFFB, NPBFDBCHIGL.FOJKFJEEFJN(FILBOAMBNOP));
	}
}
