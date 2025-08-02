using I2.Loc;
using UnityEngine;
using UnityEngine.UI;

public class IAEGENOHDFA : global::BCFJOAHKHMI<Image>
{
	static IAEGENOHDFA()
	{
		KFONLJMIOIB();
	}

	[KGHIPLIMGAG]
	private static void KFONLJMIOIB()
	{
		PNAJOCHGJFO.JNCGFCADPNN(new IAEGENOHDFA());
	}

	public override string CILJKDELPFP()
	{
		return "Image";
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

	public override LPNCMDLKPHE MHNAGNJBHNI(Localize HNKFIOBAHOB)
	{
		Image image = LDGBMPEMHEI(HNKFIOBAHOB);
		return (!(image.sprite == null)) ? LPNCMDLKPHE.Sprite : LPNCMDLKPHE.Texture;
	}

	public override LPNCMDLKPHE KPFEGOEPPND(Localize HNKFIOBAHOB)
	{
		return LPNCMDLKPHE.Text;
	}

	public override void HKKDHLOJLGN(Localize HNKFIOBAHOB, string AMMAIADJFIM, string HDNBPGDPDAJ, out string FDNJMNMHGEG, out string ENOPBIOGPCL)
	{
		Image image = LDGBMPEMHEI(HNKFIOBAHOB);
		FDNJMNMHGEG = ((!image.mainTexture) ? string.Empty : image.mainTexture.name);
		if (image.sprite != null && image.sprite.name != FDNJMNMHGEG)
		{
			FDNJMNMHGEG = FDNJMNMHGEG + "." + image.sprite.name;
		}
		ENOPBIOGPCL = null;
	}

	public override void FPJOJNKLJHL(Localize HNKFIOBAHOB, string JJMAEFKBEIL, string NAIBKJDAOHL)
	{
		Image image = LDGBMPEMHEI(HNKFIOBAHOB);
		Sprite sprite = image.sprite;
		if (sprite == null || sprite.name != JJMAEFKBEIL)
		{
			image.sprite = HNKFIOBAHOB.FindTranslatedObject<Sprite>(JJMAEFKBEIL);
		}
	}
}
