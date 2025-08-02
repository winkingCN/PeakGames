using System.Collections;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using DG.Tweening;
using UnityEngine;

public class AAIDOAKCCHF : PIHMIJMOBJB
{
	[CompilerGenerated]
	private sealed class JNHNGBGNCBD
	{
		internal CollectAnimation CAMFPAAGCIC;
	}

	[CompilerGenerated]
	private sealed class DJBCLDGGANO
	{
		internal Tweener IGNMMKDDGHJ;

		internal JNHNGBGNCBD NDMOGLDEJBE;

		internal void AGFNGEFDHLA()
		{
			IGNMMKDDGHJ.Kill();
			NDMOGLDEJBE.CAMFPAAGCIC.StartCoroutine(NDMOGLDEJBE.CAMFPAAGCIC.transform.EJBPPMACIKI(NDMOGLDEJBE.CAMFPAAGCIC.MiddlePoint, NDMOGLDEJBE.CAMFPAAGCIC.TargetPosition, NDMOGLDEJBE.CAMFPAAGCIC.CurveDuration, BJCJEPIOBMA.SineOut));
		}
	}

	private const float AGKHIEEIPKM = 0.055f;

	public void HCGFKKEMMLL(CollectAnimation CAMFPAAGCIC)
	{
		if (CAMFPAAGCIC.gameObject != null)
		{
			CAMFPAAGCIC.TopPanel.IncreaseActiveCollectAnimationtCount(CAMFPAAGCIC.TopPanelGoalId);
			CAMFPAAGCIC.UpdateSortingAfterDownAnimation();
			CAMFPAAGCIC.CollectSpriteRenderer.enabled = true;
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
			CAMFPAAGCIC.CurveDuration = 0.055f * (Vector3.Distance(position, CAMFPAAGCIC.MiddlePoint) + Vector3.Distance(CAMFPAAGCIC.TargetPosition, CAMFPAAGCIC.MiddlePoint));
			int num2 = Random.Range(0, 90);
			Vector3 position2 = position;
			position2.y += 0.7f;
			CAMFPAAGCIC.transform.position = position2;
			CAMFPAAGCIC.transform.localScale = Vector3.one * 0.48f;
			CAMFPAAGCIC.transform.localEulerAngles = new Vector3(0f, 0f, num2);
			bool flag = true;
			Tweener IGNMMKDDGHJ = CAMFPAAGCIC.transform.DOMoveY(position.y + 3f, 1.5f).SetEase(Ease.OutElastic);
			IGNMMKDDGHJ.easeOvershootOrAmplitude = 0.8f;
			Sequence sequence = DOTween.Sequence();
			sequence.Append(CAMFPAAGCIC.transform.DOScale(0.8f, 0.15f));
			sequence.InsertCallback(0.65f, delegate
			{
				IGNMMKDDGHJ.Kill();
				CAMFPAAGCIC.StartCoroutine(CAMFPAAGCIC.transform.EJBPPMACIKI(CAMFPAAGCIC.MiddlePoint, CAMFPAAGCIC.TargetPosition, CAMFPAAGCIC.CurveDuration, BJCJEPIOBMA.SineOut));
			});
			int num3 = ((Random.Range(0, 10) <= 5) ? 360 : (-360));
			if (flag)
			{
				CAMFPAAGCIC.transform.DOLocalRotate(new Vector3(0f, 0f, num3), 0.4f, RotateMode.LocalAxisAdd).SetEase(Ease.OutSine);
			}
			int num4 = -num2;
			sequence.Insert(0.6f, CAMFPAAGCIC.transform.DOLocalRotate(new Vector3(0f, 0f, num4), CAMFPAAGCIC.CurveDuration, RotateMode.LocalAxisAdd));
			sequence.OnComplete(CAMFPAAGCIC.MoveCompleted);
		}
		else
		{
			CAMFPAAGCIC.DoRecycle();
		}
	}

	public void PMPJJACINHL(CollectAnimation CAMFPAAGCIC)
	{
		CAMFPAAGCIC.CurrentLevel.ACJOALJFMHN(CAMFPAAGCIC.GoalType, true);
		CAMFPAAGCIC.CollectSpriteRenderer.enabled = false;
		CAMFPAAGCIC.StartCoroutine(EPEKANGEMBI(CAMFPAAGCIC));
	}

	private static IEnumerator EPEKANGEMBI(CollectAnimation CAMFPAAGCIC)
	{
		yield return new WaitForSeconds(0.5f);
		CAMFPAAGCIC.DoRecycle();
		CAMFPAAGCIC.CollectSpriteRenderer.enabled = true;
	}
}
