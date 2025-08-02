using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using DG.Tweening;

public class EDOIFPONGPG
{
	public const float PHEJCMPEHIG = 0.3f;

	private bool CCNMKIHBCJH;

	public Item LGPEODBLFEA;

	private Cell MFENMHPPAHD;

	private void JIMBAPGACIJ(Item CAMFPAAGCIC)
	{
		if (!CCNMKIHBCJH)
		{
			CCNMKIHBCJH = true;
			LGPEODBLFEA = CAMFPAAGCIC;
			FallManager.IncreaseMechanicAnimation();
			FallManager.IncreaseWaitingFallBlocker();
		}
	}

	public void ELLCPFDBNDK()
	{
		if (CCNMKIHBCJH)
		{
			FallManager.DecreaseMechanicAnimation();
			FallManager.DecreaseWaitingFallBlocker();
			CCNMKIHBCJH = false;
		}
	}

	public Tweener LGJBBEFGCFE(Item CAMFPAAGCIC, Cell FIICENBDLDC)
	{
		JIMBAPGACIJ(CAMFPAAGCIC);
		if (CAMFPAAGCIC.ENCFFNKONOO != null)
		{
			MFENMHPPAHD = CAMFPAAGCIC.ENCFFNKONOO;
		}
		Tweener tweener = LGPEODBLFEA.transform.DOMove(FIICENBDLDC.GetFrozenPosition(), 0.3f).SetEase(Ease.InBack);
		tweener.easeOvershootOrAmplitude = 3.03f;
		return tweener.OnComplete(HIHPKEBIODD);
	}

	private void HIHPKEBIODD()
	{
		if (NLMLKADGECN.GABGKBAKHDP.NODDCJJNJEC(LGPEODBLFEA.GetMatchType()))
		{
			LGPEODBLFEA.StartCollectToItem(MFENMHPPAHD, true);
		}
		else
		{
			LGPEODBLFEA.RemoveSelf();
		}
	}
}
