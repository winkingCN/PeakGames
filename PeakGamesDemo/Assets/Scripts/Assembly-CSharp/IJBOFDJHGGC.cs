using I2.Loc;
using UnityEngine;

public class IJBOFDJHGGC : global::BCFJOAHKHMI<GUIText>
{
	public TextAlignment IEBKDDMCMHE = TextAlignment.Right;

	public TextAlignment MHFOJDIAONJ;

	public bool BLDHJCEJMJO;

	public bool ADFEFNHGHMJ = true;

	static IJBOFDJHGGC()
	{
		KFONLJMIOIB();
	}

	[KGHIPLIMGAG]
	private static void KFONLJMIOIB()
	{
		PNAJOCHGJFO.JNCGFCADPNN(new IJBOFDJHGGC());
	}

	public override string CILJKDELPFP()
	{
		return "GUIText";
	}

	public override LPNCMDLKPHE MHNAGNJBHNI(Localize HNKFIOBAHOB)
	{
		return LPNCMDLKPHE.Text;
	}

	public override LPNCMDLKPHE KPFEGOEPPND(Localize HNKFIOBAHOB)
	{
		return LPNCMDLKPHE.Font;
	}

	public override bool BPGIAEEGAHG()
	{
		return true;
	}

	public override bool EPEEEAJJCEM()
	{
		return true;
	}

	public override bool ILELPLPENPA()
	{
		return false;
	}

	public override void HKKDHLOJLGN(Localize HNKFIOBAHOB, string AMMAIADJFIM, string HDNBPGDPDAJ, out string FDNJMNMHGEG, out string ENOPBIOGPCL)
	{
		GUIText gUIText = LDGBMPEMHEI(HNKFIOBAHOB);
		FDNJMNMHGEG = gUIText.text;
		ENOPBIOGPCL = ((!string.IsNullOrEmpty(HDNBPGDPDAJ) || !(gUIText.font != null)) ? null : gUIText.font.name);
	}

	public override void FPJOJNKLJHL(Localize HNKFIOBAHOB, string JJMAEFKBEIL, string NAIBKJDAOHL)
	{
		GUIText gUIText = LDGBMPEMHEI(HNKFIOBAHOB);
		Font font = HNKFIOBAHOB.FDCNEPAOCIA<Font>(ref JJMAEFKBEIL, ref NAIBKJDAOHL);
		if (font != null && gUIText.font != font)
		{
			gUIText.font = font;
		}
		if (ADFEFNHGHMJ)
		{
			ADFEFNHGHMJ = false;
			MHFOJDIAONJ = (IEBKDDMCMHE = gUIText.alignment);
			if (PNAJOCHGJFO.MNHBNGFDIPC && IEBKDDMCMHE == TextAlignment.Right)
			{
				MHFOJDIAONJ = TextAlignment.Left;
			}
			if (!PNAJOCHGJFO.MNHBNGFDIPC && MHFOJDIAONJ == TextAlignment.Left)
			{
				IEBKDDMCMHE = TextAlignment.Right;
			}
		}
		if (JJMAEFKBEIL != null && gUIText.text != JJMAEFKBEIL)
		{
			if (HNKFIOBAHOB.CorrectAlignmentForRTL && gUIText.alignment != TextAlignment.Center)
			{
				gUIText.alignment = ((!PNAJOCHGJFO.MNHBNGFDIPC) ? MHFOJDIAONJ : IEBKDDMCMHE);
			}
			gUIText.text = JJMAEFKBEIL;
		}
	}
}
