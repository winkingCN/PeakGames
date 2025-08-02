using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using DG.Tweening;
using UnityEngine;

public class GPDHNEPBDFP : PIHMIJMOBJB
{
	private const float AGKHIEEIPKM = 0.045f;

	public void HCGFKKEMMLL(CollectAnimation CAMFPAAGCIC)
	{
		if (CAMFPAAGCIC.gameObject != null)
		{
			CAMFPAAGCIC.TopPanel.IncreaseActiveCollectAnimationtCount(CAMFPAAGCIC.TopPanelGoalId);
			Vector3 position = CAMFPAAGCIC.transform.position;
			Sequence sequence = DOTween.Sequence();
			if (CAMFPAAGCIC.XDelay > 0f)
			{
				sequence.SetDelay(CAMFPAAGCIC.XDelay * 0.035f);
			}
			Vector3 vector = position;
			vector.y -= 1.8f + CAMFPAAGCIC.YDelay;
			float num = 0.075f * (1.8f + CAMFPAAGCIC.YDelay);
			CAMFPAAGCIC.MiddlePoint = vector;
			float num2 = (vector.x - CAMFPAAGCIC.TargetPosition.x) / 4f;
			if (num2 < 0f)
			{
				if (num2 > -0.6f)
				{
					num2 = -0.6f;
				}
			}
			else if (num2 < 0.6f)
			{
				num2 = 0.6f;
			}
			CAMFPAAGCIC.MiddlePoint.x -= num2;
			CAMFPAAGCIC.MiddlePoint.y -= 0.5f + CAMFPAAGCIC.YDelay * 1f;
			CAMFPAAGCIC.CurveDuration = 0.045f * (Vector3.Distance(vector, CAMFPAAGCIC.MiddlePoint) + Vector3.Distance(CAMFPAAGCIC.TargetPosition, CAMFPAAGCIC.MiddlePoint));
			Tweener t = CAMFPAAGCIC.transform.DOMove(vector, num).SetEase(Ease.Linear);
			t.OnComplete(CAMFPAAGCIC.DownAnimationEnded);
			sequence.Append(t);
			sequence.Join(CAMFPAAGCIC.transform.DOScale(CAMFPAAGCIC.GoalImageScale, num + CAMFPAAGCIC.CurveDuration).SetEase(Ease.Linear));
			sequence.OnComplete(CAMFPAAGCIC.MoveCompleted);
			sequence.SetEase(Ease.Linear);
		}
		else
		{
			CAMFPAAGCIC.DoRecycle();
		}
	}

	public void PMPJJACINHL(CollectAnimation CAMFPAAGCIC)
	{
		CAMFPAAGCIC.CurrentLevel.ACJOALJFMHN(CAMFPAAGCIC.GoalType, true);
		CAMFPAAGCIC.DoRecycle();
	}
}
