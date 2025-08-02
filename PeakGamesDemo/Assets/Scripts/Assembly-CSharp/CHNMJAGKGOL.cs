using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using Assets.Scripts.Utils;
using DG.Tweening;
using GamePlayScene.Mechanics;
using UnityEngine;

public class CHNMJAGKGOL : PIHMIJMOBJB
{
	[CompilerGenerated]
	private sealed class CMOMOPGHJHM
	{
		internal ItemResources JEDAGPJEOAM;

		internal CollectAnimation CAMFPAAGCIC;

		internal void AGFNGEFDHLA()
		{
			if (JEDAGPJEOAM != null)
			{
				AudioManager.PlayAudioProps(JEDAGPJEOAM.AudioClips[2]);
			}
		}

		internal void KDACLOKGNAM()
		{
			CAMFPAAGCIC.MoveCompleted();
			if (JEDAGPJEOAM != null)
			{
				AudioManager.PlayAudioProps(JEDAGPJEOAM.AudioClips[1]);
			}
		}
	}

	public void HCGFKKEMMLL(CollectAnimation CAMFPAAGCIC)
	{
		if (CAMFPAAGCIC.gameObject == null)
		{
			return;
		}
		bool flag = CAMFPAAGCIC.GoalType == NOALGNJECAD.GiantDuck;
		CAMFPAAGCIC.TopPanel.IncreaseActiveCollectAnimationtCount(CAMFPAAGCIC.TopPanelGoalId);
		Vector3 position = CAMFPAAGCIC.transform.position;
		CAMFPAAGCIC.MiddlePoint = position;
		float num = (position.x - CAMFPAAGCIC.TargetPosition.x) / 4f;
		if (num < 0f)
		{
			if (num > -0.6f)
			{
				num = -0.6f;
			}
		}
		else if (num < 0.6f)
		{
			num = 0.6f;
		}
		CAMFPAAGCIC.MiddlePoint.x -= num;
		CAMFPAAGCIC.MiddlePoint.y -= 0.5f + CAMFPAAGCIC.YDelay * 1f;
		CAMFPAAGCIC.CurveDuration = 0.045f * (Vector3.Distance(position, CAMFPAAGCIC.MiddlePoint) + Vector3.Distance(CAMFPAAGCIC.TargetPosition, CAMFPAAGCIC.MiddlePoint));
		ItemResources JEDAGPJEOAM = ItemResourcesManager.GABGKBAKHDP.GetResources(CAMFPAAGCIC.GoalType);
		CAMFPAAGCIC.DownAnimationEnded();
		float num2 = 3.3334f * CAMFPAAGCIC.GoalImageScale;
		float num3 = CAMFPAAGCIC.GoalImageScale;
		if (flag)
		{
			num2 *= 0.66f;
			num3 *= 0.66f;
		}
		Sequence sequence = DOTween.Sequence();
		sequence.Append(CAMFPAAGCIC.transform.DOScale(num2, CAMFPAAGCIC.CurveDuration * 0.4f).SetEase(Ease.OutQuad));
		sequence.Append(CAMFPAAGCIC.transform.DOScale(num2, CAMFPAAGCIC.CurveDuration * 0.2f).SetEase(Ease.Linear));
		sequence.Append(CAMFPAAGCIC.transform.DOScale(num3, CAMFPAAGCIC.CurveDuration * 0.4f).SetEase(Ease.InQuad));
		if (!flag)
		{
			sequence.InsertCallback(CAMFPAAGCIC.CurveDuration * 0.2f, delegate
			{
				if (JEDAGPJEOAM != null)
				{
					AudioManager.PlayAudioProps(JEDAGPJEOAM.AudioClips[2]);
				}
			});
		}
		sequence.OnComplete(delegate
		{
			CAMFPAAGCIC.MoveCompleted();
			if (JEDAGPJEOAM != null)
			{
				AudioManager.PlayAudioProps(JEDAGPJEOAM.AudioClips[1]);
			}
		});
		sequence.SetEase(Ease.Linear);
	}

	public void PMPJJACINHL(CollectAnimation CAMFPAAGCIC)
	{
		CAMFPAAGCIC.CurrentLevel.ACJOALJFMHN(CAMFPAAGCIC.GoalType, true);
		CAMFPAAGCIC.DoRecycle();
	}
}
