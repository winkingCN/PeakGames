using I2.Loc;
using UnityEngine;
using UnityEngine.UI;

public class GCNGLNOCGHP : global::BCFJOAHKHMI<RawImage>
{
	static GCNGLNOCGHP()
	{
		KFONLJMIOIB();
	}

	[KGHIPLIMGAG]
	private static void KFONLJMIOIB()
	{
		PNAJOCHGJFO.JNCGFCADPNN(new GCNGLNOCGHP());
	}

	public override string CILJKDELPFP()
	{
		return "RawImage";
	}

	public override LPNCMDLKPHE MHNAGNJBHNI(Localize HNKFIOBAHOB)
	{
		return LPNCMDLKPHE.Texture;
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
		RawImage rawImage = LDGBMPEMHEI(HNKFIOBAHOB);
		FDNJMNMHGEG = ((!rawImage.mainTexture) ? string.Empty : rawImage.mainTexture.name);
		ENOPBIOGPCL = null;
	}

	public override void FPJOJNKLJHL(Localize HNKFIOBAHOB, string JJMAEFKBEIL, string NAIBKJDAOHL)
	{
		RawImage rawImage = LDGBMPEMHEI(HNKFIOBAHOB);
		Texture texture = rawImage.texture;
		if (texture == null || texture.name != JJMAEFKBEIL)
		{
			rawImage.texture = HNKFIOBAHOB.FindTranslatedObject<Texture>(JJMAEFKBEIL);
		}
	}
}
