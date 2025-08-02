using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.Utils;
using DG.Tweening;
using GamePlayScene.Mechanics;
using UnityEngine;

public class BubbleAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class DHHBCEDDGJM
	{
		internal ParticleSystem DOECBNGBDHA;

		internal BubbleAnimation PDAPIGLEPGC;
	}

	[CompilerGenerated]
	private sealed class HANOCANNCEA
	{
		internal ItemResources JEDAGPJEOAM;

		internal Vector3 NBLHKHMMCKB;

		internal DHHBCEDDGJM FIABJICDDMO;

		internal void AGFNGEFDHLA()
		{
			FIABJICDDMO.DOECBNGBDHA.Play();
			if (FIABJICDDMO.PDAPIGLEPGC.GJCEOOLAJLF != null)
			{
				FIABJICDDMO.PDAPIGLEPGC.GJCEOOLAJLF();
			}
		}

		internal void KDACLOKGNAM()
		{
			FIABJICDDMO.PDAPIGLEPGC.BubbleContainer.gameObject.SetActive(true);
			FIABJICDDMO.PDAPIGLEPGC.Bubble.transform.DOKill();
			FIABJICDDMO.PDAPIGLEPGC.Bubble.transform.localScale = Vector3.one;
			FIABJICDDMO.PDAPIGLEPGC.Bubble.transform.DOScaleX(1.2f, 0.1f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
			FIABJICDDMO.PDAPIGLEPGC.Bubble.transform.DOScaleY(1.2f, 0.1f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear)
				.SetDelay(0.1f);
		}

		internal void DBLIJBPNCAN()
		{
			if (ParticlePool.Instance != null && JEDAGPJEOAM != null)
			{
				ParticlePool.Instance.PlayParticle(JEDAGPJEOAM.Particles[0], NBLHKHMMCKB);
			}
			if (FIABJICDDMO.PDAPIGLEPGC.HEIFFGLOPKI != null)
			{
				FIABJICDDMO.PDAPIGLEPGC.HEIFFGLOPKI.ApplyReservedBubble(FIABJICDDMO.PDAPIGLEPGC);
			}
			FIABJICDDMO.PDAPIGLEPGC.BADHDINHKND = null;
			FIABJICDDMO.PDAPIGLEPGC.gameObject.MEJPNNFDEBD();
		}
	}

	[CompilerGenerated]
	private sealed class CLLJJOGCCOA
	{
		internal SpriteRenderer IPOOHPFIBIB;

		internal Sequence JIEEDECENPC;

		internal void AGFNGEFDHLA()
		{
			IPOOHPFIBIB.sortingOrder -= LLJLGKECBBE.GABGKBAKHDP.KOBIBAJNFCO;
			JIEEDECENPC = null;
		}
	}

	private const float MMELGPDODCB = 0.15f;

	private const float BIEPEIFMLBA = 0.6f;

	private const float BJBMPCMKKOO = 0.4f;

	private const float HIIJALBIMBJ = 0.3f;

	private const float LAEEMKIEJIC = 0.8f;

	private const float MABLMDOFELC = 0.05f;

	public Transform Bubble;

	public Transform BubbleContainer;

	private Cell HEIFFGLOPKI;

	private int GOOCMNFDKGH;

	private Sequence BADHDINHKND;

	private Action GJCEOOLAJLF;

	public void Awake()
	{
		DIOELAHNLKJ();
	}

	protected virtual void DIOELAHNLKJ()
	{
		BubbleContainer.gameObject.SetActive(false);
	}

	public void Prepare(Cell LLAEDBFNCCP, Cell BMIOECELGCA, int AJLDJAHHGOJ, ParticleSystem DOECBNGBDHA, Action LBHGIIEDMOB)
	{
		try
		{
			HEIFFGLOPKI = BMIOECELGCA;
			GOOCMNFDKGH = AJLDJAHHGOJ;
			GJCEOOLAJLF = LBHGIIEDMOB;
			Vector3 frozenPosition = LLAEDBFNCCP.GetFrozenPosition();
			Vector3 NBLHKHMMCKB = BMIOECELGCA.GetFrozenPosition();
			if (GOOCMNFDKGH == 0)
			{
				frozenPosition.x += 0.6f;
			}
			else
			{
				frozenPosition.x -= 0.6f;
			}
			BubbleContainer.transform.position = frozenPosition;
			BubbleContainer.transform.localScale = new Vector3(0.1f, 0.1f, 1f);
			Quaternion identity = Quaternion.identity;
			identity.eulerAngles = new Vector3(-66.7f, 0f, 0f);
			BubbleContainer.transform.rotation = identity;
			int num = 10;
			Vector3 vector = (NBLHKHMMCKB - frozenPosition) * 0.5f;
			int num2 = ((!(vector.y > 0f)) ? 1 : (-1));
			if (GOOCMNFDKGH == 1)
			{
				num2 *= -1;
			}
			float num3 = vector.magnitude * 0.5f;
			float val = vector.magnitude * 0.25f;
			val = Math.Min(0.8f, Math.Max(0.3f, val));
			float num4 = val / (float)num;
			Vector3 normalized = new Vector3(0f - vector.y, vector.x).normalized;
			Vector3 zero = Vector3.zero;
			zero.x = frozenPosition.x + vector.x;
			zero.y = frozenPosition.y + vector.y;
			zero += normalized * num3 * num2;
			if (BADHDINHKND != null)
			{
				BADHDINHKND.Kill();
			}
			ItemResources JEDAGPJEOAM = null;
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				JEDAGPJEOAM = ItemResourcesManager.GABGKBAKHDP.GetResources(NOALGNJECAD.Fish);
			}
			if (JEDAGPJEOAM != null)
			{
				AudioManager.PlayAudioProps(JEDAGPJEOAM.AudioClips[0]);
			}
			BADHDINHKND = DOTween.Sequence();
			BADHDINHKND.AppendInterval(0.15f);
			BADHDINHKND.AppendCallback(delegate
			{
				DOECBNGBDHA.Play();
				if (GJCEOOLAJLF != null)
				{
					GJCEOOLAJLF();
				}
			});
			BADHDINHKND.InsertCallback(0.2f, delegate
			{
				BubbleContainer.gameObject.SetActive(true);
				Bubble.transform.DOKill();
				Bubble.transform.localScale = Vector3.one;
				Bubble.transform.DOScaleX(1.2f, 0.1f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
				Bubble.transform.DOScaleY(1.2f, 0.1f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear)
					.SetDelay(0.1f);
			});
			for (int i = 1; i <= num; i++)
			{
				float lLIEHCKNJEM = (float)i / (float)num;
				Vector3 endValue = HODNPLBHEKB(frozenPosition, zero, NBLHKHMMCKB, lLIEHCKNJEM);
				BADHDINHKND.Insert(0.2f + num4 * (float)i, BubbleContainer.transform.DOMove(endValue, num4).SetEase(Ease.Linear));
			}
			BADHDINHKND.Insert(0.2f + num4, BubbleContainer.transform.DORotate(Vector3.zero, 0.3f));
			BADHDINHKND.Insert(0.2f + num4, BubbleContainer.transform.DOScale(0.4f, 0.1f));
			BADHDINHKND.Insert(0.2f + num4, BubbleContainer.transform.DOScale(1f, val - 0.1f));
			BADHDINHKND.OnComplete(delegate
			{
				if (ParticlePool.Instance != null && JEDAGPJEOAM != null)
				{
					ParticlePool.Instance.PlayParticle(JEDAGPJEOAM.Particles[0], NBLHKHMMCKB);
				}
				if (HEIFFGLOPKI != null)
				{
					HEIFFGLOPKI.ApplyReservedBubble(this);
				}
				BADHDINHKND = null;
				base.gameObject.MEJPNNFDEBD();
			});
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.GamePlay, "There is an error trying to play bubble animation. Error:{0} Stack:{1}", ex.Message, ex.StackTrace);
		}
	}

	private Vector3 HODNPLBHEKB(Vector3 LLAEDBFNCCP, Vector3 ELEIAMCGPIM, Vector3 BMIOECELGCA, float LLIEHCKNJEM)
	{
		Vector3 zero = Vector3.zero;
		zero.x = LLAEDBFNCCP.x * (1f - LLIEHCKNJEM) * (1f - LLIEHCKNJEM) + ELEIAMCGPIM.x * 2f * (1f - LLIEHCKNJEM) * LLIEHCKNJEM + BMIOECELGCA.x * LLIEHCKNJEM * LLIEHCKNJEM;
		zero.y = LLAEDBFNCCP.y * (1f - LLIEHCKNJEM) * (1f - LLIEHCKNJEM) + ELEIAMCGPIM.y * 2f * (1f - LLIEHCKNJEM) * LLIEHCKNJEM + BMIOECELGCA.y * LLIEHCKNJEM * LLIEHCKNJEM;
		return zero;
	}

	public virtual void ShowBubble(Sequence JIEEDECENPC, SpriteRenderer IPOOHPFIBIB)
	{
		if (JIEEDECENPC != null)
		{
			JIEEDECENPC.Kill();
		}
		JIEEDECENPC = DOTween.Sequence();
		IPOOHPFIBIB.sortingOrder += LLJLGKECBBE.GABGKBAKHDP.KOBIBAJNFCO;
		if (ItemResourcesManager.GABGKBAKHDP != null)
		{
			AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(NOALGNJECAD.Bubble).AudioClips[3]);
		}
		IPOOHPFIBIB.transform.localScale = new Vector3(0.9f, 0.9f, 1f);
		JIEEDECENPC.Append(IPOOHPFIBIB.transform.DOScale(new Vector3(1.2f, 0.9f, 1f), 0.1f)).SetEase(Ease.Linear);
		JIEEDECENPC.Append(IPOOHPFIBIB.transform.DOScale(new Vector3(1f, 1.2f, 1f), 0.1f)).SetEase(Ease.Linear);
		JIEEDECENPC.Append(IPOOHPFIBIB.transform.DOScale(Vector3.one, 0.1f)).SetEase(Ease.Linear);
		JIEEDECENPC.OnComplete(delegate
		{
			IPOOHPFIBIB.sortingOrder -= LLJLGKECBBE.GABGKBAKHDP.KOBIBAJNFCO;
			JIEEDECENPC = null;
		});
	}
}
