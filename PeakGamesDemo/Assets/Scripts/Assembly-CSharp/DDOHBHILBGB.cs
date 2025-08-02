using I2.Loc;
using UnityEngine;

public class DDOHBHILBGB : global::BCFJOAHKHMI<GameObject>
{
	static DDOHBHILBGB()
	{
		KFONLJMIOIB();
	}

	[KGHIPLIMGAG]
	private static void KFONLJMIOIB()
	{
		PNAJOCHGJFO.JNCGFCADPNN(new DDOHBHILBGB());
	}

	public override string CILJKDELPFP()
	{
		return "Child";
	}

	public override LPNCMDLKPHE MHNAGNJBHNI(Localize HNKFIOBAHOB)
	{
		return LPNCMDLKPHE.GameObject;
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

	public override int ENPNBOFBDLJ()
	{
		return 200;
	}

	public override bool LDJDFHAKJLC(Localize HNKFIOBAHOB)
	{
		if (string.IsNullOrEmpty(HNKFIOBAHOB.ONHHAFBOPFG) || HNKFIOBAHOB.ONHHAFBOPFG == "-")
		{
			return true;
		}
		TermData termData = PNAJOCHGJFO.MJFCJBJIFHC(HNKFIOBAHOB.ONHHAFBOPFG);
		if (termData == null || termData.TermType != LPNCMDLKPHE.Child)
		{
			return false;
		}
		return true;
	}

	public override bool OBBBEAMBJAG(Localize HNKFIOBAHOB)
	{
		return LDJDFHAKJLC(HNKFIOBAHOB);
	}

	public override void HKKDHLOJLGN(Localize HNKFIOBAHOB, string AMMAIADJFIM, string HDNBPGDPDAJ, out string FDNJMNMHGEG, out string ENOPBIOGPCL)
	{
		GameObject gameObject = LDGBMPEMHEI(HNKFIOBAHOB);
		FDNJMNMHGEG = gameObject.name;
		ENOPBIOGPCL = null;
	}

	public override void FPJOJNKLJHL(Localize HNKFIOBAHOB, string JJMAEFKBEIL, string NAIBKJDAOHL)
	{
		Transform transform = HNKFIOBAHOB.transform;
		string text = JJMAEFKBEIL;
		int num = JJMAEFKBEIL.LastIndexOfAny(LanguageSource.CategorySeparators);
		if (num >= 0)
		{
			text = text.Substring(num + 1);
		}
		for (int i = 0; i < transform.childCount; i++)
		{
			Transform child = transform.GetChild(i);
			child.gameObject.SetActive(child.name == text);
		}
	}

	public override bool MJDEENHLHMA(Localize HNKFIOBAHOB)
	{
		return HNKFIOBAHOB.transform.childCount > 0;
	}
}
