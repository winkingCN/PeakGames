using I2.Loc;
using UnityEngine;

public class FEOJIOIAIMA : global::BCFJOAHKHMI<GUITexture>
{
	static FEOJIOIAIMA()
	{
		KFONLJMIOIB();
	}

	[KGHIPLIMGAG]
	private static void KFONLJMIOIB()
	{
		PNAJOCHGJFO.JNCGFCADPNN(new FEOJIOIAIMA());
	}

	public override string CILJKDELPFP()
	{
		return "GUITexture";
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
		GUITexture gUITexture = LDGBMPEMHEI(HNKFIOBAHOB);
		FDNJMNMHGEG = ((!gUITexture.texture) ? string.Empty : gUITexture.texture.name);
		ENOPBIOGPCL = null;
	}

	public override void FPJOJNKLJHL(Localize HNKFIOBAHOB, string JJMAEFKBEIL, string NAIBKJDAOHL)
	{
		GUITexture gUITexture = LDGBMPEMHEI(HNKFIOBAHOB);
		Texture texture = gUITexture.texture;
		if (texture == null || texture.name != JJMAEFKBEIL)
		{
			gUITexture.texture = HNKFIOBAHOB.FindTranslatedObject<Texture>(JJMAEFKBEIL);
		}
	}
}
