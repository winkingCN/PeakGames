using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using Assets.Scripts.Utils;
using DG.Tweening;
using GamePlayScene.Mechanics;
using UnityEngine;

public class FJFLOLGAOKD : PIHMIJMOBJB
{
	[CompilerGenerated]
	private sealed class BBKEOCMCMAN
	{
		internal CollectAnimation CAMFPAAGCIC;

		internal void AGFNGEFDHLA()
		{
			CAMFPAAGCIC.StartCoroutine(CAMFPAAGCIC.transform.EJBPPMACIKI(CAMFPAAGCIC.MiddlePoint, CAMFPAAGCIC.TargetPosition, CAMFPAAGCIC.CurveDuration, BJCJEPIOBMA.SineOut));
		}
	}

	public void HCGFKKEMMLL(CollectAnimation CAMFPAAGCIC)
	{
		if (!(CAMFPAAGCIC.gameObject == null))
		{
			CAMFPAAGCIC.TopPanel.IncreaseActiveCollectAnimationtCount(CAMFPAAGCIC.TopPanelGoalId);
			CAMFPAAGCIC.SpriteRenderers[0].enabled = true;
			CAMFPAAGCIC.SpriteRenderers[1].enabled = true;
			CAMFPAAGCIC.SpriteRenderers[1].color = new Color(1f, 1f, 1f, 0f);
			CAMFPAAGCIC.SpriteRenderers[1].DOColor(new Color(1f, 1f, 1f, 0.5f), 0.5f);
			Vector3 position = CAMFPAAGCIC.transform.position;
			position.y -= 1.8f;
			CAMFPAAGCIC.MiddlePoint = position;
			CAMFPAAGCIC.MiddlePoint.x -= JGOBAMHIFAN(position.x, CAMFPAAGCIC.TargetPosition.x);
			CAMFPAAGCIC.MiddlePoint.y -= 0.5f;
			CAMFPAAGCIC.CurveDuration = 0.05f * (Vector3.Distance(position, CAMFPAAGCIC.MiddlePoint) + Vector3.Distance(CAMFPAAGCIC.TargetPosition, CAMFPAAGCIC.MiddlePoint));
			float num = 0.135f;
			Tweener t = CAMFPAAGCIC.transform.DOMove(position, num).SetEase(Ease.Linear);
			t.OnComplete(delegate
			{
				CAMFPAAGCIC.StartCoroutine(CAMFPAAGCIC.transform.EJBPPMACIKI(CAMFPAAGCIC.MiddlePoint, CAMFPAAGCIC.TargetPosition, CAMFPAAGCIC.CurveDuration, BJCJEPIOBMA.SineOut));
			});
			Sequence sequence = DOTween.Sequence();
			sequence.Append(t);
			sequence.Join(CAMFPAAGCIC.transform.DOScale(1.2f, CAMFPAAGCIC.CurveDuration * 0.6f));
			sequence.InsertCallback(num + CAMFPAAGCIC.CurveDuration, CAMFPAAGCIC.MoveCompleted);
			sequence.SetEase(Ease.Linear);
		}
	}

	private float JGOBAMHIFAN(float LLAEDBFNCCP, float BMIOECELGCA)
	{
		float num = (LLAEDBFNCCP - BMIOECELGCA) / 4f;
		if (num > -0.6f && num < 0f)
		{
			num = -0.6f;
		}
		else if (num >= 0f && num < 0.6f)
		{
			num = 0.6f;
		}
		return num;
	}

	public void PMPJJACINHL(CollectAnimation CAMFPAAGCIC)
	{
		ItemResources resources = ItemResourcesManager.GABGKBAKHDP.GetResources(NOALGNJECAD.Safe);
		if (resources != null)
		{
			AudioManager.PlayAudioProps(resources.AudioClips[3]);
		}
		CAMFPAAGCIC.CurrentLevel.ACJOALJFMHN(CAMFPAAGCIC.GoalType, true);
		CAMFPAAGCIC.SpriteRenderers[0].enabled = false;
		CAMFPAAGCIC.SpriteRenderers[1].enabled = false;
		DOTween.Sequence().InsertCallback(0.5f, CAMFPAAGCIC.DoRecycle);
	}
}
