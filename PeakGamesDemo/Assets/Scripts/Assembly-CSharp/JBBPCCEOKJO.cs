using I2.Loc;
using UnityEngine;

public class JBBPCCEOKJO : global::BCFJOAHKHMI<GameObject>
{
	static JBBPCCEOKJO()
	{
		KFONLJMIOIB();
	}

	[KGHIPLIMGAG]
	private static void KFONLJMIOIB()
	{
		PNAJOCHGJFO.JNCGFCADPNN(new JBBPCCEOKJO());
	}

	public override string CILJKDELPFP()
	{
		return "Prefab";
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

	public override bool LDJDFHAKJLC(Localize HNKFIOBAHOB)
	{
		if (HNKFIOBAHOB.mTarget as GameObject != null)
		{
			return true;
		}
		TermData termData = PNAJOCHGJFO.MJFCJBJIFHC(HNKFIOBAHOB.ONHHAFBOPFG);
		return termData != null && termData.TermType == LPNCMDLKPHE.GameObject;
	}

	public override int ENPNBOFBDLJ()
	{
		return 150;
	}

	public override bool OBBBEAMBJAG(Localize HNKFIOBAHOB)
	{
		return true;
	}

	public override void HKKDHLOJLGN(Localize HNKFIOBAHOB, string AMMAIADJFIM, string HDNBPGDPDAJ, out string FDNJMNMHGEG, out string ENOPBIOGPCL)
	{
		GameObject gameObject = LDGBMPEMHEI(HNKFIOBAHOB);
		FDNJMNMHGEG = gameObject.name;
		ENOPBIOGPCL = null;
	}

	public override void FPJOJNKLJHL(Localize HNKFIOBAHOB, string JJMAEFKBEIL, string NAIBKJDAOHL)
	{
		GameObject gameObject = LDGBMPEMHEI(HNKFIOBAHOB);
		if ((bool)gameObject && gameObject.name == JJMAEFKBEIL)
		{
			return;
		}
		Transform transform = HNKFIOBAHOB.transform;
		string text = JJMAEFKBEIL;
		int num = JJMAEFKBEIL.LastIndexOfAny(LanguageSource.CategorySeparators);
		if (num >= 0)
		{
			text = text.Substring(num + 1);
		}
		Transform transform2 = HMFJOBMDJDJ(HNKFIOBAHOB, JJMAEFKBEIL);
		if (transform2 == null)
		{
			return;
		}
		transform2.name = text;
		for (int num2 = transform.childCount - 1; num2 >= 0; num2--)
		{
			Transform child = transform.GetChild(num2);
			if (child != transform2)
			{
				Object.Destroy(child.gameObject);
			}
		}
	}

	private Transform HMFJOBMDJDJ(Localize HNKFIOBAHOB, string JJMAEFKBEIL)
	{
		GameObject gameObject = HNKFIOBAHOB.FindTranslatedObject<GameObject>(JJMAEFKBEIL);
		if (gameObject == null)
		{
			return null;
		}
		GameObject gameObject2 = HNKFIOBAHOB.mTarget as GameObject;
		HNKFIOBAHOB.mTarget = Object.Instantiate(gameObject);
		if (HNKFIOBAHOB.mTarget == null)
		{
			return null;
		}
		Transform transform = HNKFIOBAHOB.transform;
		Transform transform2 = (HNKFIOBAHOB.mTarget as GameObject).transform;
		transform2.SetParent(transform);
		Transform transform3 = ((!gameObject2) ? transform : gameObject2.transform);
		transform2.rotation = transform3.rotation;
		transform2.position = transform3.position;
		return transform2;
	}

	public override bool MJDEENHLHMA(Localize HNKFIOBAHOB)
	{
		return HNKFIOBAHOB.transform.childCount > 0;
	}
}
