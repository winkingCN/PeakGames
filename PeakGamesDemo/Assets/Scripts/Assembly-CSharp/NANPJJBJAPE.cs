using I2.Loc;
using UnityEngine;
using UnityEngine.UI;

public class NANPJJBJAPE : global::BCFJOAHKHMI<Text>
{
	private TextAnchor IEBKDDMCMHE = TextAnchor.UpperRight;

	private TextAnchor MHFOJDIAONJ;

	private bool BLDHJCEJMJO;

	private bool ADFEFNHGHMJ = true;

	static NANPJJBJAPE()
	{
		KFONLJMIOIB();
	}

	[KGHIPLIMGAG]
	private static void KFONLJMIOIB()
	{
		PNAJOCHGJFO.JNCGFCADPNN(new NANPJJBJAPE());
	}

	public override string CILJKDELPFP()
	{
		return "Text";
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
		Text text = LDGBMPEMHEI(HNKFIOBAHOB);
		FDNJMNMHGEG = text.text;
		ENOPBIOGPCL = ((!(text.font != null)) ? string.Empty : text.font.name);
	}

	public override void FPJOJNKLJHL(Localize HNKFIOBAHOB, string JJMAEFKBEIL, string NAIBKJDAOHL)
	{
		Text text = LDGBMPEMHEI(HNKFIOBAHOB);
		Font font = HNKFIOBAHOB.FDCNEPAOCIA<Font>(ref JJMAEFKBEIL, ref NAIBKJDAOHL);
		if (font != null && font != text.font)
		{
			text.font = font;
		}
		if (ADFEFNHGHMJ)
		{
			ADFEFNHGHMJ = false;
			BLDHJCEJMJO = PNAJOCHGJFO.MNHBNGFDIPC;
			JICAKJMGIBM(BLDHJCEJMJO, text.alignment, out MHFOJDIAONJ, out IEBKDDMCMHE);
		}
		else
		{
			TextAnchor NDCOKDJFNDJ;
			TextAnchor KPOBNLIOGGH;
			JICAKJMGIBM(BLDHJCEJMJO, text.alignment, out NDCOKDJFNDJ, out KPOBNLIOGGH);
			if ((BLDHJCEJMJO && IEBKDDMCMHE != KPOBNLIOGGH) || (!BLDHJCEJMJO && MHFOJDIAONJ != NDCOKDJFNDJ))
			{
				MHFOJDIAONJ = NDCOKDJFNDJ;
				IEBKDDMCMHE = KPOBNLIOGGH;
			}
			BLDHJCEJMJO = PNAJOCHGJFO.MNHBNGFDIPC;
		}
		if (JJMAEFKBEIL != null && text.text != JJMAEFKBEIL)
		{
			if (HNKFIOBAHOB.CorrectAlignmentForRTL)
			{
				text.alignment = ((!PNAJOCHGJFO.MNHBNGFDIPC) ? MHFOJDIAONJ : IEBKDDMCMHE);
			}
			text.text = JJMAEFKBEIL;
			text.SetVerticesDirty();
		}
	}

	private void JICAKJMGIBM(bool DKOOKENNHDF, TextAnchor JOPPDFNGJBM, out TextAnchor NDCOKDJFNDJ, out TextAnchor KPOBNLIOGGH)
	{
		NDCOKDJFNDJ = (KPOBNLIOGGH = JOPPDFNGJBM);
		if (DKOOKENNHDF)
		{
			switch (JOPPDFNGJBM)
			{
			case TextAnchor.UpperRight:
				NDCOKDJFNDJ = TextAnchor.UpperLeft;
				break;
			case TextAnchor.MiddleRight:
				NDCOKDJFNDJ = TextAnchor.MiddleLeft;
				break;
			case TextAnchor.LowerRight:
				NDCOKDJFNDJ = TextAnchor.LowerLeft;
				break;
			case TextAnchor.UpperLeft:
				NDCOKDJFNDJ = TextAnchor.UpperRight;
				break;
			case TextAnchor.MiddleLeft:
				NDCOKDJFNDJ = TextAnchor.MiddleRight;
				break;
			case TextAnchor.LowerLeft:
				NDCOKDJFNDJ = TextAnchor.LowerRight;
				break;
			case TextAnchor.UpperCenter:
			case TextAnchor.MiddleCenter:
			case TextAnchor.LowerCenter:
				break;
			}
		}
		else
		{
			switch (JOPPDFNGJBM)
			{
			case TextAnchor.UpperRight:
				KPOBNLIOGGH = TextAnchor.UpperLeft;
				break;
			case TextAnchor.MiddleRight:
				KPOBNLIOGGH = TextAnchor.MiddleLeft;
				break;
			case TextAnchor.LowerRight:
				KPOBNLIOGGH = TextAnchor.LowerLeft;
				break;
			case TextAnchor.UpperLeft:
				KPOBNLIOGGH = TextAnchor.UpperRight;
				break;
			case TextAnchor.MiddleLeft:
				KPOBNLIOGGH = TextAnchor.MiddleRight;
				break;
			case TextAnchor.LowerLeft:
				KPOBNLIOGGH = TextAnchor.LowerRight;
				break;
			case TextAnchor.UpperCenter:
			case TextAnchor.MiddleCenter:
			case TextAnchor.LowerCenter:
				break;
			}
		}
	}
}
