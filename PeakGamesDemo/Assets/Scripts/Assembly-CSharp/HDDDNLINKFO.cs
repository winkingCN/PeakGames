using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using Assets.Scripts.Utils;
using DG.Tweening;
using GamePlayScene.Mechanics;
using GamePlayScene.Mechanics.Items;
using UnityEngine;

public class HDDDNLINKFO : PIHMIJMOBJB
{
	[CompilerGenerated]
	private sealed class OOCPPIGKPKL
	{
		internal Tweener IGNMMKDDGHJ;

		internal CollectAnimation CAMFPAAGCIC;

		internal ItemResources GPGDCCMECGF;

		internal Vector3 DJJLMOKPPPC;

		internal void AGFNGEFDHLA()
		{
			IGNMMKDDGHJ.Kill();
			CAMFPAAGCIC.StartCoroutine(CAMFPAAGCIC.transform.EJBPPMACIKI(CAMFPAAGCIC.MiddlePoint, CAMFPAAGCIC.TargetPosition, CAMFPAAGCIC.CurveDuration, BJCJEPIOBMA.Linear));
		}

		internal void KDACLOKGNAM()
		{
			if (ParticlePool.Instance != null && GPGDCCMECGF != null)
			{
				ParticlePool.Instance.PlayParticle(GPGDCCMECGF.Particles[0], DJJLMOKPPPC);
			}
		}
	}

	private const float FDODMAAMMFF = -0.5f;

	private const float FDBKMJJMMML = 1.1f;

	private const float MFMNGDDPPME = 0.8f;

	private const float JCOEJADNDJK = 0.7f;

	private const float GENBLIBDFLG = 0.9f;

	private const float IOKPJEJFIFG = 0.45f;

	private const float GMNNCELGAMF = 0.8f;

	private const float JDIEHJOAHBC = -0.35f;

	private const float LJJJNDGBDHK = 0.03f;

	private const float AJIIINLNBOK = 0.2f;

	public void HCGFKKEMMLL(CollectAnimation CAMFPAAGCIC)
	{
		if (CAMFPAAGCIC.gameObject != null)
		{
			CAMFPAAGCIC.TopPanel.IncreaseActiveCollectAnimationtCount(CAMFPAAGCIC.TopPanelGoalId);
			if (CAMFPAAGCIC.CurrentLevel.BDIFIPAIELJ(NOALGNJECAD.Bird))
			{
				BirdHouseItem.ClearAllBirdHouses();
			}
			CAMFPAAGCIC.UpdateSortingAfterDownAnimation();
			CAMFPAAGCIC.CollectSpriteRenderer.enabled = true;
			IFMJJMNMIIG(CAMFPAAGCIC);
		}
		else
		{
			CAMFPAAGCIC.DoRecycle();
		}
	}

	private void IFMJJMNMIIG(CollectAnimation CAMFPAAGCIC)
	{
		Vector3 DJJLMOKPPPC = CAMFPAAGCIC.transform.position;
		CAMFPAAGCIC.MiddlePoint = DJJLMOKPPPC;
		ItemResources GPGDCCMECGF = ItemResourcesManager.GABGKBAKHDP.GetResources(NOALGNJECAD.BirdHouse);
		if (GPGDCCMECGF != null)
		{
			AudioManager.PlayAudioProps(GPGDCCMECGF.AudioClips[0]);
		}
		float num = (DJJLMOKPPPC.x - CAMFPAAGCIC.TargetPosition.x) / 4f;
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
		Vector3 position = DJJLMOKPPPC;
		position.y += -0.35f;
		CAMFPAAGCIC.transform.position = position;
		CAMFPAAGCIC.CurveDuration = 0.055f * (Vector3.Distance(DJJLMOKPPPC, CAMFPAAGCIC.MiddlePoint) + Vector3.Distance(CAMFPAAGCIC.TargetPosition, CAMFPAAGCIC.MiddlePoint)) * 0.7f;
		float num2 = Random.Range(-1.3f, -0.5f);
		Tweener IGNMMKDDGHJ = CAMFPAAGCIC.transform.DOMoveY(position.y + num2, 1.3499999f).SetEase(Ease.OutElastic).SetDelay(0.03f);
		IGNMMKDDGHJ.easeOvershootOrAmplitude = 0.8f;
		int num3 = ((Random.Range(0, 10) <= 5) ? (-8) : 8);
		Sequence sequence = DOTween.Sequence();
		sequence.Append(CAMFPAAGCIC.transform.DOScale(1.1f, 0.2f));
		sequence.Join(CAMFPAAGCIC.transform.DOLocalRotate(new Vector3(0f, 0f, -num3), 0.2f).SetEase(Ease.OutBack));
		sequence.AppendInterval(0.45f);
		sequence.AppendCallback(delegate
		{
			IGNMMKDDGHJ.Kill();
			CAMFPAAGCIC.StartCoroutine(CAMFPAAGCIC.transform.EJBPPMACIKI(CAMFPAAGCIC.MiddlePoint, CAMFPAAGCIC.TargetPosition, CAMFPAAGCIC.CurveDuration, BJCJEPIOBMA.Linear));
		});
		sequence.Append(CAMFPAAGCIC.transform.DOLocalRotate(new Vector3(0f, 0f, 1f), CAMFPAAGCIC.CurveDuration * 0.8f).SetEase(Ease.InQuad));
		sequence.Append(CAMFPAAGCIC.transform.DOScale(0.8f, CAMFPAAGCIC.CurveDuration * 0.2f).SetEase(Ease.Linear));
		sequence.InsertCallback(0.1f, delegate
		{
			if (ParticlePool.Instance != null && GPGDCCMECGF != null)
			{
				ParticlePool.Instance.PlayParticle(GPGDCCMECGF.Particles[0], DJJLMOKPPPC);
			}
		});
		sequence.OnComplete(CAMFPAAGCIC.MoveCompleted);
	}

	public void PMPJJACINHL(CollectAnimation CAMFPAAGCIC)
	{
		CAMFPAAGCIC.CurrentLevel.ACJOALJFMHN(CAMFPAAGCIC.GoalType, true);
		CAMFPAAGCIC.CollectSpriteRenderer.enabled = true;
		CAMFPAAGCIC.DoRecycle();
	}
}
