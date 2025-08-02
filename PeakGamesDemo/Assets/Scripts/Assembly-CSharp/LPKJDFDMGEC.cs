using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using Assets.Scripts.Utils;
using DG.Tweening;
using GamePlayScene.Mechanics;
using UnityEngine;

public class LPKJDFDMGEC : PIHMIJMOBJB
{
	[CompilerGenerated]
	private sealed class PMBHLIFDJON
	{
		internal Tweener IGNMMKDDGHJ;

		internal CollectAnimation CAMFPAAGCIC;

		internal void AGFNGEFDHLA()
		{
			IGNMMKDDGHJ.Kill();
			CAMFPAAGCIC.StartCoroutine(CAMFPAAGCIC.transform.EJBPPMACIKI(CAMFPAAGCIC.MiddlePoint, CAMFPAAGCIC.TargetPosition, CAMFPAAGCIC.CurveDuration, BJCJEPIOBMA.SineIn));
		}
	}

	private float EJEGAEDFPPM = 1.3f;

	private float OIDODOHKEGA = 0.2f;

	public void HCGFKKEMMLL(CollectAnimation CAMFPAAGCIC)
	{
		if (CAMFPAAGCIC.gameObject != null)
		{
			CAMFPAAGCIC.TopPanel.IncreaseActiveCollectAnimationtCount(CAMFPAAGCIC.TopPanelGoalId);
			CAMFPAAGCIC.UpdateSortingAfterDownAnimation();
			CAMFPAAGCIC.CollectSpriteRenderer.enabled = true;
			if (CAMFPAAGCIC.ShadowSortingGroup != null)
			{
				CAMFPAAGCIC.ShadowSortingGroup.sortingOrder = 1;
			}
			if (CAMFPAAGCIC.SortingGroup != null)
			{
				int num = (int)(CAMFPAAGCIC.transform.position.y * 10f);
				CAMFPAAGCIC.SortingGroup.sortingOrder = 50 - num;
			}
			IFMJJMNMIIG(CAMFPAAGCIC);
		}
		else
		{
			CAMFPAAGCIC.DoRecycle();
		}
	}

	private void IFMJJMNMIIG(CollectAnimation CAMFPAAGCIC)
	{
		Vector3 position = CAMFPAAGCIC.transform.position;
		CAMFPAAGCIC.MiddlePoint = position;
		ItemResources resources = ItemResourcesManager.GABGKBAKHDP.GetResources(NOALGNJECAD.Penguin);
		if (resources != null)
		{
			AudioManager.PlayAudioProps(resources.AudioClips[3]);
		}
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
		CAMFPAAGCIC.MiddlePoint.y -= 2f - CAMFPAAGCIC.YDelay * 0.5f;
		CAMFPAAGCIC.transform.localScale = Vector3.one * 0.8f;
		CAMFPAAGCIC.transform.DOScale(Vector3.one, 0.05f);
		CAMFPAAGCIC.CurveDuration = 0.055f * (Vector3.Distance(position, CAMFPAAGCIC.MiddlePoint) + Vector3.Distance(CAMFPAAGCIC.TargetPosition, CAMFPAAGCIC.MiddlePoint));
		Tweener IGNMMKDDGHJ = CAMFPAAGCIC.transform.DOMoveY(position.y + 1f, 1.5f).SetEase(Ease.OutElastic);
		IGNMMKDDGHJ.easeOvershootOrAmplitude = 0.8f;
		Vector3 vector = CAMFPAAGCIC.TargetPosition - position;
		float num2 = 57.29578f * Mathf.Atan2(vector.y, vector.x);
		int num3 = ((!(num2 > 90f)) ? (-8) : 8);
		Sequence sequence = DOTween.Sequence();
		sequence.Append(CAMFPAAGCIC.transform.DOScale(EJEGAEDFPPM, OIDODOHKEGA));
		sequence.AppendInterval(0.5f);
		sequence.Append(CAMFPAAGCIC.transform.DOScale(1f, CAMFPAAGCIC.CurveDuration * 0.85f).SetEase(Ease.InQuad));
		sequence.Append(CAMFPAAGCIC.transform.DOScale(0.8f, CAMFPAAGCIC.CurveDuration * 0.05f).SetEase(Ease.OutQuad));
		sequence.Insert(0f, CAMFPAAGCIC.transform.DOLocalRotate(new Vector3(0f, 0f, -num3), OIDODOHKEGA).SetEase(Ease.OutBack));
		sequence.Insert(0.65f, CAMFPAAGCIC.transform.DOLocalRotate(new Vector3(0f, 0f, 1f), CAMFPAAGCIC.CurveDuration).SetEase(Ease.InQuad));
		sequence.InsertCallback(0.65f, delegate
		{
			IGNMMKDDGHJ.Kill();
			CAMFPAAGCIC.StartCoroutine(CAMFPAAGCIC.transform.EJBPPMACIKI(CAMFPAAGCIC.MiddlePoint, CAMFPAAGCIC.TargetPosition, CAMFPAAGCIC.CurveDuration, BJCJEPIOBMA.SineIn));
		});
		sequence.OnComplete(CAMFPAAGCIC.MoveCompleted);
	}

	public void PMPJJACINHL(CollectAnimation CAMFPAAGCIC)
	{
		CAMFPAAGCIC.CurrentLevel.ACJOALJFMHN(CAMFPAAGCIC.GoalType, true);
		CAMFPAAGCIC.DoRecycle();
	}
}
