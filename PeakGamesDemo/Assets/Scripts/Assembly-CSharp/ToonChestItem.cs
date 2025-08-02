using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.Utils;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class ToonChestItem : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class KECJBHOHNJH
	{
		internal Action<int> IMHLFAHONPP;

		internal int EHJNMODJEAN;

		internal ToonChestItem PDAPIGLEPGC;
	}

	[CompilerGenerated]
	private sealed class GKBNCMFFNLA
	{
		internal int AGKAAMJKIMN;

		internal int MKBKDKGIBDH;

		internal int ONHDLNFEHBB;

		internal KECJBHOHNJH OMKIMGJICPM;

		internal void AGFNGEFDHLA()
		{
			OMKIMGJICPM.PDAPIGLEPGC.AnimatedCountText.enabled = true;
			OMKIMGJICPM.PDAPIGLEPGC.AnimatedCountText.FCJBBPHFNPJ = "+" + 0;
			OMKIMGJICPM.PDAPIGLEPGC.CounterContinousParticle.Play();
		}

		internal int KDACLOKGNAM()
		{
			return AGKAAMJKIMN;
		}

		internal void DBLIJBPNCAN(int AMFCENFNAJJ)
		{
			AGKAAMJKIMN = AMFCENFNAJJ;
		}

		internal void EFLLCMEPAEM()
		{
			OMKIMGJICPM.PDAPIGLEPGC.AnimatedCountText.SetText("+" + AGKAAMJKIMN);
		}

		internal int NNINHCPIBHO()
		{
			return MKBKDKGIBDH;
		}

		internal void HFBABENGMDD(int AMFCENFNAJJ)
		{
			MKBKDKGIBDH = AMFCENFNAJJ;
		}

		internal void JJBKCOCNHNL()
		{
			if (ONHDLNFEHBB != MKBKDKGIBDH)
			{
				AudioManager.Play(KOOGPFAPGGD.UiCoinCollect, GCEAKOOGDJK.Multiple);
				ONHDLNFEHBB = MKBKDKGIBDH;
			}
		}

		internal void MJJBIDJBGLE()
		{
			OMKIMGJICPM.PDAPIGLEPGC.CounterContinousParticle.Stop();
			OMKIMGJICPM.PDAPIGLEPGC.CounterHitParticle.transform.localPosition = OMKIMGJICPM.PDAPIGLEPGC.CounterHitParticle.transform.localPosition + Vector3.left * 0.368f;
			OMKIMGJICPM.PDAPIGLEPGC.CounterHitParticle.Play();
			AudioManager.Play(KOOGPFAPGGD.UiGameplayStar3);
		}

		internal void DPADKEBGICE()
		{
			if (OMKIMGJICPM.IMHLFAHONPP != null)
			{
				OMKIMGJICPM.IMHLFAHONPP(OMKIMGJICPM.EHJNMODJEAN);
			}
		}
	}

	[CompilerGenerated]
	private sealed class MCAKJDDMNLA
	{
		internal int ACHJCNHNKGE;

		internal int ACAOJFKLKHN;

		internal KECJBHOHNJH OMKIMGJICPM;

		internal void AGFNGEFDHLA()
		{
			OMKIMGJICPM.PDAPIGLEPGC.AnimatedCountText.enabled = true;
			OMKIMGJICPM.PDAPIGLEPGC.AnimatedCountText.ANLKLKAINEO.localScale = Vector3.one;
			OMKIMGJICPM.PDAPIGLEPGC.AnimatedCountText.SetText("+" + 0);
		}

		internal int KDACLOKGNAM()
		{
			return ACHJCNHNKGE;
		}

		internal void DBLIJBPNCAN(int AMFCENFNAJJ)
		{
			ACHJCNHNKGE = AMFCENFNAJJ;
		}

		internal void EFLLCMEPAEM()
		{
			if (ACAOJFKLKHN != ACHJCNHNKGE)
			{
				OMKIMGJICPM.PDAPIGLEPGC.AnimatedCountText.SetText("+" + ACHJCNHNKGE);
				AudioManager.Play(KOOGPFAPGGD.ChestCardCountIncrease);
				ACAOJFKLKHN = ACHJCNHNKGE;
			}
		}

		internal void NNINHCPIBHO()
		{
			OMKIMGJICPM.PDAPIGLEPGC.CounterHitParticle.Play();
			AudioManager.Play(KOOGPFAPGGD.UiGameplayStar3);
		}

		internal void HFBABENGMDD()
		{
			if (OMKIMGJICPM.IMHLFAHONPP != null)
			{
				OMKIMGJICPM.IMHLFAHONPP(OMKIMGJICPM.EHJNMODJEAN);
			}
		}
	}

	public SortingGroup CurrentSortingGroup;

	public SpriteRenderer RewardSpriteRenderer;

	public TextMeshPro CountText;

	public TextMeshPro TitleText;

	public TextMeshPro AnimatedCountText;

	public GameObject BackFace;

	public GameObject FrontFace;

	public ParticleSystem PlaceParticle;

	public ParticleSystem CounterHitParticle;

	public ParticleSystem CounterContinousParticle;

	public int BaseSortingLayer;

	private NAAHKHPBAPA DCNEDLDLAMK;

	private int DHGLLBHDJNL;

	public void BringToFront(bool HMLFIACPAAD)
	{
		int num = ((!HMLFIACPAAD) ? (BaseSortingLayer - 50) : (BaseSortingLayer + 50));
		CurrentSortingGroup.sortingOrder += num;
	}

	public void SetContent(NAAHKHPBAPA IEGDGGBFLBJ, int MPCNGDPJABL)
	{
		BackFace.SetActive(true);
		FrontFace.SetActive(false);
		DCNEDLDLAMK = IEGDGGBFLBJ;
		DHGLLBHDJNL = MPCNGDPJABL;
		Sprite sprite = null;
		CountText.JOPPDFNGJBM = KNOECCJHIDP.MidlineRight;
		CountText.FCJBBPHFNPJ = "+" + MPCNGDPJABL;
		Vector3 localPosition = new Vector3(-0.099f, -1.921f);
		float num = 0.8f;
		float num2 = 0.9f;
		string oNHHAFBOPFG = "Hammer";
		switch (IEGDGGBFLBJ)
		{
		case NAAHKHPBAPA.Coins:
			sprite = SharedImageLibrary.Instance.Coins;
			num = 1.3f;
			localPosition.y = -1.96f;
			localPosition.x = -0.02f;
			num2 = 1f;
			oNHHAFBOPFG = "Coins2";
			break;
		case NAAHKHPBAPA.Hammer:
			oNHHAFBOPFG = "Hammer";
			num = 0.9f;
			break;
		case NAAHKHPBAPA.Anvil:
			oNHHAFBOPFG = "Anvil";
			num = 0.9f;
			localPosition.x = 0.05f;
			localPosition.y = -2.01f;
			break;
		case NAAHKHPBAPA.BoxingGlove:
			localPosition.x = -0.023f;
			localPosition.y = -2.02f;
			oNHHAFBOPFG = "BoxingShort";
			num = 1.2f;
			break;
		case NAAHKHPBAPA.Rocket:
			oNHHAFBOPFG = "Rocket";
			localPosition.y = -2.03f;
			break;
		case NAAHKHPBAPA.Bomb:
			oNHHAFBOPFG = "Bomb";
			localPosition.x = -0.06f;
			localPosition.y = -2f;
			break;
		case NAAHKHPBAPA.DiscoBall:
			num = 0.9f;
			localPosition.x = -0.01f;
			localPosition.y = -2.01f;
			oNHHAFBOPFG = "Disco";
			break;
		case NAAHKHPBAPA.Dice:
			num = 0.8f;
			localPosition.x = -0.06f;
			localPosition.y = -2.01f;
			oNHHAFBOPFG = "Shuffle";
			break;
		case NAAHKHPBAPA.Life:
			num = 0.84f;
			localPosition.x = -0.05f;
			localPosition.y = -2f;
			oNHHAFBOPFG = "Life";
			break;
		}
		if (sprite == null)
		{
			sprite = SharedImageLibrary.Instance.GetSpriteByInventoryType(IEGDGGBFLBJ);
		}
		RewardSpriteRenderer.sprite = sprite;
		RewardSpriteRenderer.transform.localScale = new Vector3(num, num, num);
		RewardSpriteRenderer.transform.localPosition = localPosition;
		CountText.ANLKLKAINEO.localScale = new Vector3(num2, num2, num2);
		TitleText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB(oNHHAFBOPFG);
		BringToFront(true);
	}

	public void PlayTurnAnimation()
	{
		BackFace.SetActive(false);
		FrontFace.SetActive(true);
		Explode();
	}

	public Sequence PlayCountAnimation(float BPGAMBFPMCO, int EHJNMODJEAN, Action<int> IMHLFAHONPP)
	{
		CountText.enabled = false;
		Sequence sequence = DOTween.Sequence();
		sequence.timeScale = BPGAMBFPMCO;
		if (DCNEDLDLAMK == NAAHKHPBAPA.Coins)
		{
			int AGKAAMJKIMN = 0;
			sequence.AppendCallback(delegate
			{
				AnimatedCountText.enabled = true;
				AnimatedCountText.FCJBBPHFNPJ = "+" + 0;
				CounterContinousParticle.Play();
			});
			sequence.Append(AnimatedCountText.ANLKLKAINEO.DOScale(1.8f, 1.3f).SetEase(Ease.Linear));
			sequence.Join(CounterContinousParticle.transform.DOScale(1.4f, 1.3f).SetEase(Ease.Linear));
			sequence.Join(DOTween.To(() => AGKAAMJKIMN, delegate(int AMFCENFNAJJ)
			{
				AGKAAMJKIMN = AMFCENFNAJJ;
			}, DHGLLBHDJNL, 1.3f).SetEase(Ease.Linear).OnUpdate(delegate
			{
				AnimatedCountText.SetText("+" + AGKAAMJKIMN);
			}));
			int MKBKDKGIBDH = 0;
			int ONHDLNFEHBB = 0;
			sequence.Join(DOTween.To(() => MKBKDKGIBDH, delegate(int AMFCENFNAJJ)
			{
				MKBKDKGIBDH = AMFCENFNAJJ;
			}, 15, 1.3f).SetEase(Ease.Linear).OnUpdate(delegate
			{
				if (ONHDLNFEHBB != MKBKDKGIBDH)
				{
					AudioManager.Play(KOOGPFAPGGD.UiCoinCollect, GCEAKOOGDJK.Multiple);
					ONHDLNFEHBB = MKBKDKGIBDH;
				}
			}));
			sequence.Insert(1.4f, AnimatedCountText.ANLKLKAINEO.DOScale(1f, 0.8f).SetEase(Ease.OutElastic));
			sequence.InsertCallback(1.5f, delegate
			{
				CounterContinousParticle.Stop();
				CounterHitParticle.transform.localPosition = CounterHitParticle.transform.localPosition + Vector3.left * 0.368f;
				CounterHitParticle.Play();
				AudioManager.Play(KOOGPFAPGGD.UiGameplayStar3);
			});
			sequence.InsertCallback(1.3f, delegate
			{
				if (IMHLFAHONPP != null)
				{
					IMHLFAHONPP(EHJNMODJEAN);
				}
			});
		}
		else
		{
			int ACHJCNHNKGE = 0;
			int ACAOJFKLKHN = 0;
			sequence.AppendCallback(delegate
			{
				AnimatedCountText.enabled = true;
				AnimatedCountText.ANLKLKAINEO.localScale = Vector3.one;
				AnimatedCountText.SetText("+" + 0);
			});
			sequence.Append(AnimatedCountText.ANLKLKAINEO.DOScale(2.2f, 0.1f * (float)DHGLLBHDJNL).SetEase(Ease.Linear));
			sequence.Join(DOTween.To(() => ACHJCNHNKGE, delegate(int AMFCENFNAJJ)
			{
				ACHJCNHNKGE = AMFCENFNAJJ;
			}, DHGLLBHDJNL, 0.1f * (float)DHGLLBHDJNL).SetEase(Ease.Linear).OnUpdate(delegate
			{
				if (ACAOJFKLKHN != ACHJCNHNKGE)
				{
					AnimatedCountText.SetText("+" + ACHJCNHNKGE);
					AudioManager.Play(KOOGPFAPGGD.ChestCardCountIncrease);
					ACAOJFKLKHN = ACHJCNHNKGE;
				}
			}));
			sequence.Insert(0.1f + 0.1f * (float)DHGLLBHDJNL, AnimatedCountText.ANLKLKAINEO.DOScale(1f, 0.8f).SetEase(Ease.OutElastic));
			sequence.InsertCallback(0.2f + 0.1f * (float)DHGLLBHDJNL, delegate
			{
				CounterHitParticle.Play();
				AudioManager.Play(KOOGPFAPGGD.UiGameplayStar3);
			});
			sequence.InsertCallback(0.1f * (float)DHGLLBHDJNL, delegate
			{
				if (IMHLFAHONPP != null)
				{
					IMHLFAHONPP(EHJNMODJEAN);
				}
			});
		}
		return sequence;
	}

	public void Explode()
	{
		PlaceParticle.Play();
	}
}
