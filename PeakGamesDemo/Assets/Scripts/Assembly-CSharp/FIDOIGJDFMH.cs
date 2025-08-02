using I2.Loc;
using UnityEngine;

public class FIDOIGJDFMH : global::BCFJOAHKHMI<TextMesh>
{
	public TextAlignment IEBKDDMCMHE = TextAlignment.Right;

	public TextAlignment MHFOJDIAONJ;

	public bool BLDHJCEJMJO;

	public bool ADFEFNHGHMJ = true;

	static FIDOIGJDFMH()
	{
		KFONLJMIOIB();
	}

	[KGHIPLIMGAG]
	private static void KFONLJMIOIB()
	{
		PNAJOCHGJFO.JNCGFCADPNN(new FIDOIGJDFMH());
	}

	public override string CILJKDELPFP()
	{
		return "TextMesh";
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
		TextMesh textMesh = LDGBMPEMHEI(HNKFIOBAHOB);
		FDNJMNMHGEG = textMesh.text;
		ENOPBIOGPCL = ((!string.IsNullOrEmpty(HDNBPGDPDAJ) || !(textMesh.font != null)) ? null : textMesh.font.name);
	}

	public override void FPJOJNKLJHL(Localize HNKFIOBAHOB, string JJMAEFKBEIL, string NAIBKJDAOHL)
	{
		TextMesh textMesh = LDGBMPEMHEI(HNKFIOBAHOB);
		Font font = HNKFIOBAHOB.FDCNEPAOCIA<Font>(ref JJMAEFKBEIL, ref NAIBKJDAOHL);
		if (font != null && textMesh.font != font)
		{
			textMesh.font = font;
		}
		if (ADFEFNHGHMJ)
		{
			ADFEFNHGHMJ = false;
			MHFOJDIAONJ = (IEBKDDMCMHE = textMesh.alignment);
			if (PNAJOCHGJFO.MNHBNGFDIPC && IEBKDDMCMHE == TextAlignment.Right)
			{
				MHFOJDIAONJ = TextAlignment.Left;
			}
			if (!PNAJOCHGJFO.MNHBNGFDIPC && MHFOJDIAONJ == TextAlignment.Left)
			{
				IEBKDDMCMHE = TextAlignment.Right;
			}
		}
		if (JJMAEFKBEIL != null && textMesh.text != JJMAEFKBEIL)
		{
			if (HNKFIOBAHOB.CorrectAlignmentForRTL && textMesh.alignment != TextAlignment.Center)
			{
				textMesh.alignment = ((!PNAJOCHGJFO.MNHBNGFDIPC) ? MHFOJDIAONJ : IEBKDDMCMHE);
			}
			textMesh.font.RequestCharactersInTexture(JJMAEFKBEIL);
			textMesh.text = JJMAEFKBEIL;
		}
	}
}
