using I2.Loc;
using UnityEngine;

public class NNBLEPHKOKA : global::BCFJOAHKHMI<SpriteRenderer>
{
	static NNBLEPHKOKA()
	{
		KFONLJMIOIB();
	}

	[KGHIPLIMGAG]
	private static void KFONLJMIOIB()
	{
		PNAJOCHGJFO.JNCGFCADPNN(new NNBLEPHKOKA());
	}

	public override string CILJKDELPFP()
	{
		return "SpriteRenderer";
	}

	public override LPNCMDLKPHE MHNAGNJBHNI(Localize HNKFIOBAHOB)
	{
		return LPNCMDLKPHE.Sprite;
	}

	public override LPNCMDLKPHE KPFEGOEPPND(Localize HNKFIOBAHOB)
	{
		return LPNCMDLKPHE.Text;
	}

	public override bool BPGIAEEGAHG()
	{
		return false;
	}

	public override bool EPEEEAJJCEM()
	{
		return false;
	}

	public override bool ILELPLPENPA()
	{
		return false;
	}

	public override void HKKDHLOJLGN(Localize HNKFIOBAHOB, string AMMAIADJFIM, string HDNBPGDPDAJ, out string FDNJMNMHGEG, out string ENOPBIOGPCL)
	{
		SpriteRenderer spriteRenderer = LDGBMPEMHEI(HNKFIOBAHOB);
		FDNJMNMHGEG = ((!(spriteRenderer.sprite != null)) ? string.Empty : spriteRenderer.sprite.name);
		ENOPBIOGPCL = null;
	}

	public override void FPJOJNKLJHL(Localize HNKFIOBAHOB, string JJMAEFKBEIL, string NAIBKJDAOHL)
	{
		SpriteRenderer spriteRenderer = LDGBMPEMHEI(HNKFIOBAHOB);
		Sprite sprite = spriteRenderer.sprite;
		if (sprite == null || sprite.name != JJMAEFKBEIL)
		{
			spriteRenderer.sprite = HNKFIOBAHOB.FindTranslatedObject<Sprite>(JJMAEFKBEIL);
		}
	}
}
