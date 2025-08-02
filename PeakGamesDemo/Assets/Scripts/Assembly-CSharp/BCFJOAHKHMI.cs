using I2.Loc;
using UnityEngine;

public abstract class BCFJOAHKHMI<T> : ABOOAELLAEJ where T : Object
{
	public override bool MJDEENHLHMA(Localize HNKFIOBAHOB)
	{
		return HNKFIOBAHOB.GetComponent<T>() != null;
	}

	public override bool LDJDFHAKJLC(Localize HNKFIOBAHOB)
	{
		HNKFIOBAHOB.mTarget = (HNKFIOBAHOB.mTarget as T) ?? HNKFIOBAHOB.GetComponent<T>();
		return HNKFIOBAHOB.mTarget != null;
	}

	public T LDGBMPEMHEI(Localize HNKFIOBAHOB)
	{
		return HNKFIOBAHOB.mTarget as T;
	}

	public override bool OBBBEAMBJAG(Localize HNKFIOBAHOB)
	{
		return LDGBMPEMHEI(HNKFIOBAHOB) != null;
	}

	public override int ENPNBOFBDLJ()
	{
		return 100;
	}

	public override ABOOAELLAEJ IKBFGGABMKP(Localize HNKFIOBAHOB)
	{
		return MemberwiseClone() as ABOOAELLAEJ;
	}

	public static H EENMBICCIKK<H>(Transform PBMDKDICLJP) where H : Component
	{
		if (!PBMDKDICLJP)
		{
			return (H)null;
		}
		H component = PBMDKDICLJP.GetComponent<H>();
		while (!component && (bool)PBMDKDICLJP)
		{
			component = PBMDKDICLJP.GetComponent<H>();
			PBMDKDICLJP = PBMDKDICLJP.parent;
		}
		return component;
	}
}
