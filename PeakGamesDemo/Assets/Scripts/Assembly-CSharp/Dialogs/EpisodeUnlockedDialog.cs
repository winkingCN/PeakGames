using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Dialogs;
using Assets.Scripts.MapScene;
using Assets.Scripts.Utils;
using DG.Tweening;
using TMPro;
using UnityEngine;
using Utils.TextEffects;

namespace Dialogs
{
	public class EpisodeUnlockedDialog : FullscreenDialog
	{
		public SpriteRenderer BackgroundSpriteRenderer;

		public MeshRenderer MapRenderer;

		public Transform ContentTransform;

		public TextMeshPro EpisodeTitle;

		public TextMeshPro EpisodeUnlockedTitle;

		public Transform JapaneseSunController;

		public Animator CurrentAnimator;

		public TM_WaveScale WaveTextAnimation;

		public Transform ContinueButton;

		public Transform FrameTransform;

		public Transform EpisodeUnlockTextTransform;

		public Transform RibbonTransform;

		public ParticleSystem UnlockParticle;

		public ParticleSystem FrameParticle;

		public Transform ConfettiParticle;

		public Transform TitleBounceParticle;

		private Action JCOKJJGCPHI;

		private MapManager HDHCLKHLCEB;

		private readonly int HNHPBOOPHLK = Animator.StringToHash("Base Layer.EpisodeUnlockAnimation2");

		private bool HONKJFKBJAI;

		private NNKPJCPJPPA BMALPGBDINI;

		public static readonly Dictionary<int, NNKPJCPJPPA> EpisodeCurveProps = new Dictionary<int, NNKPJCPJPPA>
		{
			{
				0,
				new NNKPJCPJPPA(0f, 0.19f, 3.45f, 0.13f, 0f)
			},
			{
				1,
				new NNKPJCPJPPA(0f, 0.2f, 3.53f, 0.03f, 0f)
			},
			{
				2,
				new NNKPJCPJPPA(0f, 0.2f, 3.45f, 0.15f, 0f)
			},
			{
				3,
				new NNKPJCPJPPA(0f, 0.2f, 3.5f, 0.12f, 0f)
			},
			{
				4,
				new NNKPJCPJPPA(0f, 0.19f, 3.45f, 0.12f, 0f)
			},
			{
				5,
				new NNKPJCPJPPA(0f, 0.19f, 3.53f, 0.07f, 0.02f)
			},
			{
				6,
				new NNKPJCPJPPA(0f, 0.2f, 3.51f, 0.1f, 0.04f)
			},
			{
				7,
				new NNKPJCPJPPA(0f, 0.16f, 3.47f, 0.12f, 0f)
			},
			{
				8,
				new NNKPJCPJPPA(0f, 0.2f, 3.53f, 0.08f, 0f)
			},
			{
				9,
				new NNKPJCPJPPA(0f, 0.21f, 3.5f, 0.06f, 0f)
			},
			{
				10,
				new NNKPJCPJPPA(0f, 0.2f, 3.45f, 0.14f, 0f)
			},
			{
				11,
				new NNKPJCPJPPA(0f, 0.2f, 3.5f, 0.06f, 0f)
			},
			{
				12,
				new NNKPJCPJPPA(0f, 0.2f, 3.48f, 0.1f, 0.04f)
			},
			{
				13,
				new NNKPJCPJPPA(0f, 0.18f, 3.54f, 0.02f, 0.04f)
			},
			{
				14,
				new NNKPJCPJPPA(0f, 0.2f, 3.48f, 0.08f, 0.03f)
			},
			{
				15,
				new NNKPJCPJPPA(0f, 0.2f, 3.48f, 0.08f, 0.03f)
			},
			{
				16,
				new NNKPJCPJPPA(0f, 0.2f, 3.49f, 0.09f, 0f)
			},
			{
				17,
				new NNKPJCPJPPA(0f, 0.2f, 3.44f, 0.14f, 0.03f)
			},
			{
				18,
				new NNKPJCPJPPA(0f, 0.2f, 3.51f, 0.04f, 0.03f)
			},
			{
				19,
				new NNKPJCPJPPA(0f, 0.2f, 3.53f, 0.04f, 0.03f)
			},
			{
				20,
				new NNKPJCPJPPA(0f, 0.19f, 3.52f, 0.08f, 0f)
			},
			{
				21,
				new NNKPJCPJPPA(0f, 0.22f, 3.52f, 0.09f, 0.04f)
			},
			{
				22,
				new NNKPJCPJPPA(0f, 0.2f, 3.47f, 0.08f, 0.05f)
			},
			{
				23,
				new NNKPJCPJPPA(0f, 0.2f, 3.52f, 0.06f, 0f)
			},
			{
				24,
				new NNKPJCPJPPA(0f, 0.2f, 3.5f, 0.1f, 0.04f)
			},
			{
				25,
				new NNKPJCPJPPA(0f, 0.2f, 3.48f, 0.1f, 0f)
			},
			{
				26,
				new NNKPJCPJPPA(0f, 0.22f, 3.46f, 0.1f, 0f)
			},
			{
				27,
				new NNKPJCPJPPA(0f, 0.2f, 3.46f, 0.12f, 0.06f)
			},
			{
				28,
				new NNKPJCPJPPA(0f, 0.22f, 3.5f, 0.06f, 0.03f)
			},
			{
				29,
				new NNKPJCPJPPA(0f, 0.2f, 3.5f, 0.06f, 0.03f)
			},
			{
				30,
				new NNKPJCPJPPA(0f, 0.24f, 3.52f, 0.06f, 0f)
			},
			{
				31,
				new NNKPJCPJPPA(0f, 0.22f, 3.47f, 0.1f, 0.02f)
			},
			{
				32,
				new NNKPJCPJPPA(0f, 0.16f, 3.51f, 0.08f, 0.03f)
			},
			{
				33,
				new NNKPJCPJPPA(0f, 0.16f, 3.48f, 0.12f, 0.02f)
			},
			{
				34,
				new NNKPJCPJPPA(0f, 0.16f, 3.48f, 0.12f, 0.04f)
			},
			{
				35,
				new NNKPJCPJPPA(0f, 0.19f, 3.45f, 0.13f, 0.04f)
			},
			{
				36,
				new NNKPJCPJPPA(0f, 0.22f, 3.5f, 0.06f, 0.03f)
			},
			{
				37,
				new NNKPJCPJPPA(0f, 0.19f, 3.48f, 0.1f, 0f)
			},
			{
				38,
				new NNKPJCPJPPA(0f, 0.19f, 3.58f, 0.02f, 0f)
			},
			{
				39,
				new NNKPJCPJPPA(0f, 0.09f, 3.53f, 0.06f, 0.02f)
			},
			{
				40,
				new NNKPJCPJPPA(0f, 0.19f, 3.48f, 0.08f, 0.06f)
			},
			{
				41,
				new NNKPJCPJPPA(0f, 0.19f, 3.5f, 0.09f, 0.02f)
			},
			{
				42,
				new NNKPJCPJPPA(0f, 0.21f, 3.5f, 0.05f, 0f)
			},
			{
				43,
				new NNKPJCPJPPA(0f, 0.21f, 3.48f, 0.1f, 0.04f)
			},
			{
				44,
				new NNKPJCPJPPA(0f, 0.21f, 3.48f, 0.12f, 0f)
			},
			{
				45,
				new NNKPJCPJPPA(0f, 0.13f, 3.51f, 0.08f, 0f)
			},
			{
				46,
				new NNKPJCPJPPA(0f, 0.11f, 3.48f, 0.1f, 0.03f)
			},
			{
				47,
				new NNKPJCPJPPA(0f, 0.15f, 3.51f, 0.06f, 0.04f)
			},
			{
				48,
				new NNKPJCPJPPA(0f, 0.17f, 3.47f, 0.1f, 0.02f)
			},
			{
				49,
				new NNKPJCPJPPA(0f, 0.2f, 3.48f, 0.1f, 0.04f)
			},
			{
				50,
				new NNKPJCPJPPA(0f, 0.16f, 3.5f, 0.06f, 0.02f)
			},
			{
				51,
				new NNKPJCPJPPA(0f, 0.19f, 3.46f, 0.13f, 0.01f)
			},
			{
				52,
				new NNKPJCPJPPA(0f, 0.21f, 3.52f, 0.08f, 0.04f)
			},
			{
				53,
				new NNKPJCPJPPA(0f, 0.2f, 3.48f, 0.12f, 0.06f)
			},
			{
				54,
				new NNKPJCPJPPA(0f, 0.21f, 3.5f, 0.08f, 0.04f)
			},
			{
				55,
				new NNKPJCPJPPA(0f, 0.21f, 3.48f, 0.09f, 0.04f)
			},
			{
				56,
				new NNKPJCPJPPA(0f, 0.2f, 3.46f, 0.1f, 0.04f)
			},
			{
				57,
				new NNKPJCPJPPA(0f, 0.205f, 3.5f, 0.08f, 0.02f)
			},
			{
				58,
				new NNKPJCPJPPA(0f, 0.12f, 3.48f, 0.12f, 0.03f)
			},
			{
				59,
				new NNKPJCPJPPA(0f, 0.19f, 3.48f, 0.12f, 0.06f)
			},
			{
				60,
				new NNKPJCPJPPA(-0.013f, 0.135f, 3.48f, 0.08f, 0.04f)
			},
			{
				61,
				new NNKPJCPJPPA(0f, 0.16f, 3.52f, 0.08f, 0.02f)
			},
			{
				62,
				new NNKPJCPJPPA(0f, 0.18f, 3.48f, 0.1f, 0.06f)
			},
			{
				63,
				new NNKPJCPJPPA(0f, 0.26f, 3.48f, 0.1f, 0f)
			},
			{
				64,
				new NNKPJCPJPPA(-0.01f, 0.13f, 3.52f, 0.09f, 0f)
			}
		};

		public static readonly NNKPJCPJPPA DefaultCurveProps = new NNKPJCPJPPA(0f, 0.2f, 3.5f, 0.1f, 0f);

		public void Start()
		{
			float x = base.transform.localScale.x;
			BackgroundSpriteRenderer.transform.localScale = new Vector3(ONCMBJKLKIL.EMFKAPJMDCC / x, ONCMBJKLKIL.FHAMOHDEGMK / x, 1f);
			ConfettiParticle.transform.position = new Vector3(0f, ONCMBJKLKIL.ECLBGPBLGMD.y + 1f, 0f);
			WaveTextAnimation.VertexCurve2 = new AnimationCurve(new Keyframe(0f, BMALPGBDINI.LJFPAJMHLKJ), new Keyframe(0.5f, BMALPGBDINI.ELNEKNHAKJN), new Keyframe(1f, 0f));
			WaveTextAnimation.VertexCurve2.SmoothTangents(0, 0f);
			WaveTextAnimation.VertexCurve2.SmoothTangents(2, 0f);
			Vector3 localPosition = EpisodeTitle.ANLKLKAINEO.localPosition;
			localPosition.y = BMALPGBDINI.KEDHKAPOGDE;
			EpisodeTitle.ANLKLKAINEO.localPosition = localPosition;
		}

		public void PrepareDialog(Action IMHLFAHONPP)
		{
			JCOKJJGCPHI = IMHLFAHONPP;
		}

		public override void DialogCreated()
		{
			if (MDGKDGMGGCL.GABGKBAKHDP.AGGMHHLFFDA())
			{
				AudioManager.StopSong();
				HONKJFKBJAI = true;
			}
			BDMACLHLONH();
			HDHCLKHLCEB = MapManager.Instance;
			BMALPGBDINI = ((!PNAJOCHGJFO.LOEHJECLFHL.Equals("English")) ? DefaultCurveProps : EpisodeCurveProps[HDHCLKHLCEB.AGBOBACEIEP]);
			base.NCJFEFMJKFA = Time.frameCount;
			if (ONCMBJKLKIL.PEFHCKMBHOM)
			{
				ContentTransform.transform.localScale = Vector3.one * 0.8f;
			}
			EpisodeTitle.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("EpisodeTitle_" + MapManager.GetMapIdForLevel(HDHCLKHLCEB.NNDCJLBBGAB));
			HDHCLKHLCEB.NewMapContent.LoadMapAsset(HDHCLKHLCEB.AGBOBACEIEP, LKAEBIGNLLG);
			EpisodeTitle.gameObject.SetActive(false);
			ContinueButton.gameObject.SetActive(false);
			FrameTransform.gameObject.SetActive(false);
			EpisodeUnlockTextTransform.gameObject.SetActive(false);
			RibbonTransform.gameObject.SetActive(false);
			JapaneseSunController.gameObject.SetActive(false);
		}

		private void LKAEBIGNLLG(bool PAEFDANMKNM)
		{
			MapRenderer.material.mainTexture = HDHCLKHLCEB.NewMapContent.EINEBDMKFPJ.texture;
			MapRenderer.material.mainTextureScale = new Vector2(1.0160493f, 0.62719345f);
			MapRenderer.material.mainTextureOffset = new Vector2(BMALPGBDINI.EKKDMBPODHB, BMALPGBDINI.GAEGHOBIDHO);
		}

		public override void PlayDialogInAnimation()
		{
			JapaneseSunController.DORotate(new Vector3(0f, 0f, -180f), 8f, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);
			StartCoroutine(JPOBLDGOFLO());
		}

		private IEnumerator JPOBLDGOFLO()
		{
			while (MapRenderer.material.mainTexture == null)
			{
				yield return null;
			}
			JNHCICHFNHL();
			CurrentAnimator.Play(HNHPBOOPHLK, 0, 0f);
			yield return new WaitForSeconds(0.2f);
			AudioManager.Play(KOOGPFAPGGD.UiEpisodeUnlockCelebration);
			yield return new WaitForSeconds(0.2f);
			UnlockParticle.Play();
			AudioManager.Play(KOOGPFAPGGD.UiEpisodeUnlockLand);
			yield return MCJHHDACJBG.CHFOIGLAMPN;
			JapaneseSunController.gameObject.SetActive(true);
			FrameParticle.Play();
			yield return new WaitForSeconds(0.13f);
			AudioManager.Play(KOOGPFAPGGD.UiEpisodeUnlockLand);
			yield return new WaitForSeconds(0.23f);
			HDHCLKHLCEB.CurrentNewMapAnimationController.LevelButton.UpdateLevelButton(true);
			HDHCLKHLCEB.NewMapContent.BackgroundImage.sprite = HDHCLKHLCEB.NewMapContent.EINEBDMKFPJ;
			BLELAMHLLNN();
			yield return new WaitForSeconds(0.45f);
			EpisodeTitle.gameObject.SetActive(true);
			WaveTextAnimation.Animate();
			yield return new WaitForSeconds(0.9f);
			ContinueButton.gameObject.SetActive(true);
			FBMHAIMJIEG(ContinueButton);
		}

		public override Sequence PlayDialogOutAnimation()
		{
			return DOTween.Sequence();
		}

		public override void OnDialogClosed()
		{
			if (JCOKJJGCPHI != null)
			{
				JCOKJJGCPHI();
			}
			base.OnDialogClosed();
			MapRenderer.material.mainTexture = null;
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.EpisodeUnlockedDialog, "Episode Unlocked Dialog Closed");
			if (HONKJFKBJAI)
			{
				AudioManager.PlaySong();
			}
		}

		private void BDMACLHLONH()
		{
			float x = EpisodeUnlockedTitle.GetPreferredValues().x;
			if (x < 8.45f)
			{
				float num = 1f - (8.45f - x) * 0.083f;
				TitleBounceParticle.localScale = Vector3.one * num;
			}
		}

		private void FBMHAIMJIEG(Transform LLIEHCKNJEM)
		{
			LLIEHCKNJEM.localScale = Vector3.zero;
			Vector3 endValue = new Vector3(0.85f, 0.85f, 0.85f);
			LLIEHCKNJEM.DOScale(endValue, 0.35f).SetEase(Ease.OutBack).easeOvershootOrAmplitude = 1.2f;
		}

		public override bool CanHandleBackButton()
		{
			return true;
		}
	}
}
