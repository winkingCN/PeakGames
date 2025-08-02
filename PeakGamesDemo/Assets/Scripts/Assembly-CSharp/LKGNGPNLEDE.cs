using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using Assets.Scripts.Utils;
using DG.Tweening;
using GamePlayScene.Mechanics;
using UnityEngine;

public class LKGNGPNLEDE : PIHMIJMOBJB
{
	[CompilerGenerated]
	private sealed class FOINMCALFHD
	{
		internal CollectAnimation CAMFPAAGCIC;

		internal ItemResources JEDAGPJEOAM;

		internal void AGFNGEFDHLA()
		{
			CAMFPAAGCIC.ReferencedCell.AcceptsFallInside();
			CAMFPAAGCIC.StartCoroutine(CAMFPAAGCIC.transform.EJBPPMACIKI(CAMFPAAGCIC.MiddlePoint, CAMFPAAGCIC.TargetPosition, CAMFPAAGCIC.CurveDuration, MBGMDHKLALO));
		}

		internal void KDACLOKGNAM()
		{
			if (JEDAGPJEOAM != null)
			{
				AudioManager.PlayAudioProps(JEDAGPJEOAM.AudioClips[1]);
			}
		}

		internal void DBLIJBPNCAN()
		{
			CAMFPAAGCIC.MoveCompleted();
			for (int i = 0; i < CAMFPAAGCIC.SpriteRenderers.Length; i++)
			{
				CAMFPAAGCIC.SpriteRenderers[i].enabled = false;
			}
			if (JEDAGPJEOAM != null)
			{
				AudioManager.PlayAudioProps(JEDAGPJEOAM.AudioClips[3]);
			}
		}
	}

	private static float ODKABBOJEFG = 0.7f;

	private static float KOGGGAPJDBO = 0.35f;

	private static float BOGAKAKMCJK = 2f;

	private static float FFMKJOLINJN = 2f;

	private static BJCJEPIOBMA MBGMDHKLALO = BJCJEPIOBMA.QuadIn;

	public void HCGFKKEMMLL(CollectAnimation CAMFPAAGCIC)
	{
		if (!(CAMFPAAGCIC.gameObject == null))
		{
			CAMFPAAGCIC.TopPanel.IncreaseActiveCollectAnimationtCount(CAMFPAAGCIC.TopPanelGoalId);
			CEINFKDBNAH(CAMFPAAGCIC);
		}
	}

	private void CEINFKDBNAH(CollectAnimation CAMFPAAGCIC)
	{
		Vector3 position = CAMFPAAGCIC.transform.position;
		CAMFPAAGCIC.CollectAnimator.speed = FFMKJOLINJN;
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
		CAMFPAAGCIC.MiddlePoint.y -= 6f - CAMFPAAGCIC.YDelay * 0.5f;
		float num2 = 0.055f * (Vector3.Distance(position, CAMFPAAGCIC.MiddlePoint) + Vector3.Distance(CAMFPAAGCIC.TargetPosition, CAMFPAAGCIC.MiddlePoint)) * ODKABBOJEFG;
		CAMFPAAGCIC.CurveDuration = num2;
		ItemResources JEDAGPJEOAM = ItemResourcesManager.GABGKBAKHDP.GetResources(NOALGNJECAD.Ufo);
		if (JEDAGPJEOAM != null)
		{
			AudioManager.PlayAudioProps(JEDAGPJEOAM.AudioClips[2]);
		}
		Sequence s = DOTween.Sequence();
		float num3 = (CAMFPAAGCIC.XDelay + CAMFPAAGCIC.YDelay) * 0.1f;
		s.AppendInterval(KOGGGAPJDBO + num3);
		s.AppendCallback(delegate
		{
			CAMFPAAGCIC.ReferencedCell.AcceptsFallInside();
			CAMFPAAGCIC.StartCoroutine(CAMFPAAGCIC.transform.EJBPPMACIKI(CAMFPAAGCIC.MiddlePoint, CAMFPAAGCIC.TargetPosition, CAMFPAAGCIC.CurveDuration, MBGMDHKLALO));
		});
		s.Append(CAMFPAAGCIC.transform.DOScale(BOGAKAKMCJK, num2 * 0.6f));
		s.Append(CAMFPAAGCIC.transform.DOScale(1f, num2 * 0.5f));
		s.Insert(KOGGGAPJDBO, CAMFPAAGCIC.AnimationTransform.DORotate(Vector3.forward * 45f, num2, RotateMode.WorldAxisAdd).SetEase(Ease.Linear));
		s.InsertCallback(KOGGGAPJDBO, delegate
		{
			if (JEDAGPJEOAM != null)
			{
				AudioManager.PlayAudioProps(JEDAGPJEOAM.AudioClips[1]);
			}
		});
		float num4 = KOGGGAPJDBO + num3;
		s.InsertCallback(num2 + num4, delegate
		{
			CAMFPAAGCIC.MoveCompleted();
			for (int i = 0; i < CAMFPAAGCIC.SpriteRenderers.Length; i++)
			{
				CAMFPAAGCIC.SpriteRenderers[i].enabled = false;
			}
			if (JEDAGPJEOAM != null)
			{
				AudioManager.PlayAudioProps(JEDAGPJEOAM.AudioClips[3]);
			}
		});
		s.InsertCallback(num2 + 0.7f + num4, CAMFPAAGCIC.DoRecycle);
	}

	public void PMPJJACINHL(CollectAnimation CAMFPAAGCIC)
	{
		CAMFPAAGCIC.CurrentLevel.ACJOALJFMHN(CAMFPAAGCIC.GoalType, true);
	}
}
