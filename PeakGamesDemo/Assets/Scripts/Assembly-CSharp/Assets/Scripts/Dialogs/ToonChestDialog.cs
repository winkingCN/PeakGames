using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Assets.Scripts.Utils;
using DG.Tweening;
using NewMapScene;
using Spine.Unity;
using Spine.Unity.Modules;
using UnityEngine;
using Utils;

namespace Assets.Scripts.Dialogs
{
	public class ToonChestDialog : FullscreenDialog
	{
		[CompilerGenerated]
		private sealed class NAFIDGLBINE
		{
			internal bool KMJFJLCCKDF;

			internal int EHJNMODJEAN;

			internal ToonChestDialog PDAPIGLEPGC;
		}

		[CompilerGenerated]
		private sealed class PEDFHMNMLJF
		{
			internal ToonChestItem JOEKGGBMGJN;

			internal NAFIDGLBINE HJAOPEBPGKJ;

			internal void AGFNGEFDHLA()
			{
				AudioManager.Play(KOOGPFAPGGD.ChestCardTurn);
				HJAOPEBPGKJ.PDAPIGLEPGC.EAKFOPJODDP = DOTween.Sequence();
				HJAOPEBPGKJ.PDAPIGLEPGC.EAKFOPJODDP.timeScale = HJAOPEBPGKJ.PDAPIGLEPGC.EKPIJHFPGJB;
				JOEKGGBMGJN.BackFace.SetActive(false);
				JOEKGGBMGJN.FrontFace.SetActive(true);
				Quaternion identity = Quaternion.identity;
				identity.eulerAngles = new Vector3(-10f, -90f, 0f);
				JOEKGGBMGJN.FrontFace.transform.rotation = identity;
				HJAOPEBPGKJ.PDAPIGLEPGC.EAKFOPJODDP.Append(JOEKGGBMGJN.FrontFace.transform.DOLocalRotate(new Vector3(0f, 0f, 0f), 0.15f).SetEase(Ease.Linear));
				HJAOPEBPGKJ.PDAPIGLEPGC.EAKFOPJODDP.Join(JOEKGGBMGJN.transform.DOLocalRotate(new Vector3(0f, 0f, 0f), 0.15f).SetEase(Ease.Linear));
			}

			internal void KDACLOKGNAM()
			{
				AudioManager.Play(KOOGPFAPGGD.ChestCardLand);
				JOEKGGBMGJN.Explode();
			}

			internal void DBLIJBPNCAN()
			{
				if (HJAOPEBPGKJ.KMJFJLCCKDF)
				{
					HJAOPEBPGKJ.PDAPIGLEPGC.GMPPALFGNJD = JOEKGGBMGJN.PlayCountAnimation(HJAOPEBPGKJ.PDAPIGLEPGC.EKPIJHFPGJB, HJAOPEBPGKJ.EHJNMODJEAN, delegate(int JBKEOKPAFON)
					{
						if (JBKEOKPAFON == HJAOPEBPGKJ.EHJNMODJEAN)
						{
							JOEKGGBMGJN.BringToFront(false);
							HJAOPEBPGKJ.PDAPIGLEPGC.EENDAPOEEFK(++HJAOPEBPGKJ.EHJNMODJEAN, true);
						}
					});
				}
				else
				{
					JOEKGGBMGJN.BringToFront(false);
					HJAOPEBPGKJ.PDAPIGLEPGC.EENDAPOEEFK(++HJAOPEBPGKJ.EHJNMODJEAN, false);
				}
			}

			internal void EFLLCMEPAEM(int JBKEOKPAFON)
			{
				if (JBKEOKPAFON == HJAOPEBPGKJ.EHJNMODJEAN)
				{
					JOEKGGBMGJN.BringToFront(false);
					HJAOPEBPGKJ.PDAPIGLEPGC.EENDAPOEEFK(++HJAOPEBPGKJ.EHJNMODJEAN, true);
				}
			}
		}

		public SpriteRenderer BackgroundSpriteRenderer;

		public GameObject OpenButton;

		public GameObject ClaimButton;

		public GameObject ItemsContainer;

		public GameObject Particles;

		public GameObject RewardItemPrefab;

		public SkeletonAnimation ChestAnimation;

		public Transform CardStartPosition;

		public Transform Circle;

		public Transform ChestContentTransform;

		public Transform Burst;

		public ParticleSystem ChestOpenBurstParticleSystem;

		public SpriteRenderer GradientSpriteRenderer;

		public Transform ChestParticleContainer;

		public ParticleSystem ChestParticle;

		protected NBKCFDOMAPI KLDPKHIHBCK;

		private Material FNDEBEFCKAD;

		private Sequence JIEEDECENPC;

		private Sequence EAKFOPJODDP;

		private Sequence GMPPALFGNJD;

		private int ONEHFGMKNBP;

		private bool PBJLJNHLLEM;

		private bool GKMKAMLMOPK;

		private bool NMGGNPJFMJC;

		private bool GLCODEFGOBK;

		private float EKPIJHFPGJB;

		private List<Transform> MEHHNEKJLAJ;

		protected string[] JFKGAJEFMNP;

		protected string AKNGCJLOOCA;

		protected string KEFDLMDHKBF;

		protected string ICPHLOGLEDE;

		protected string FKCKMLNPALG;

		protected Dictionary<NAAHKHPBAPA, int> MBODHMOEJEO;

		public Action OnChestClaimed;

		private Action JCOKJJGCPHI;

		private NBKCFDOMAPI KNGKFJEMNFB;

		protected int DIDFHGBGKFJ;

		protected float CPKEBLKCLCB = -1.62f;

		protected string CKLPLHKILDJ = string.Empty;

		protected string MHHELNHGHGM = string.Empty;

		protected string CENGNKJGOGP = string.Empty;

		[SerializeField]
		public AnimationCurve ScaleCurve = AnimationCurve.Linear(0f, 0f, 1f, 0f);

		[SerializeField]
		public AnimationCurve MoveCurve = AnimationCurve.Linear(0f, 0f, 1f, 0f);

		[CompilerGenerated]
		private static TweenCallback EBCOMJBLIPP;

		[CompilerGenerated]
		private static TweenCallback DNBOPLHGMHA;

		[CompilerGenerated]
		private static TweenCallback JFHCKLHBBDI;

		public virtual void UpdateAnimationIds()
		{
			JFKGAJEFMNP = new string[5] { "idle_mobile", "idle_mobile2", "idle_mobile3", "idle_mobile4", "idle_mobile5" };
			AKNGCJLOOCA = "open_last";
			KEFDLMDHKBF = "open";
			ICPHLOGLEDE = "open2";
			FKCKMLNPALG = "open_idle";
			CKLPLHKILDJ = "SpineAnimations/ToonChest/open_chest_SkeletonData";
			MHHELNHGHGM = "SpineAnimations/ToonChest/open_chest";
			CENGNKJGOGP = "fall";
		}

		public void Start()
		{
			float x = base.transform.lossyScale.x;
			Vector3 localScale = new Vector3(ONCMBJKLKIL.EMFKAPJMDCC / x, ONCMBJKLKIL.FHAMOHDEGMK / x, 1f);
			BackgroundSpriteRenderer.transform.localScale = localScale;
			GradientSpriteRenderer.transform.localScale = localScale;
		}

		private void Update()
		{
			if (KLDPKHIHBCK != null)
			{
				ChestParticleContainer.position = new Vector3(KLDPKHIHBCK.POFLEELFBPH, KLDPKHIHBCK.MLMBGGJGOBP);
			}
		}

		public void PlayInAnimation()
		{
			ONEHFGMKNBP = UnityEngine.Random.Range(0, JFKGAJEFMNP.Length);
			Sequence sequence = DOTween.Sequence();
			sequence.AppendCallback(delegate
			{
				AudioManager.Play(KOOGPFAPGGD.ChestFly);
			});
			sequence.Append(BackgroundSpriteRenderer.DOFade(1f, 0.5f));
			sequence.Join(Circle.transform.DOScale(Vector3.one * 1.366f, 0.3f).SetEase(Ease.OutBack));
			sequence.AppendCallback(base.JNHCICHFNHL);
			sequence.InsertCallback(0.1f, delegate
			{
				ChestAnimation.gameObject.SetActive(true);
				ChestAnimation.state.DHOFLMAIDKL += HCGFNGCAPKP;
			});
			sequence.InsertCallback(0.35f, delegate
			{
				OpenButton.transform.DOScale(Vector3.one, 0.35f).OnComplete(delegate
				{
					GKMKAMLMOPK = true;
				});
			});
			sequence.AppendInterval(0.2f);
			sequence.SetEase(Ease.Linear);
		}

		public void WaitForSpineToLoad()
		{
			ChestAnimation.skeletonDataAsset = LJDGBAMMEAM.OPKJBDGCGHC(CKLPLHKILDJ, MHHELNHGHGM);
			ChestAnimation.CENGNKJGOGP = CENGNKJGOGP;
			ChestAnimation.loop = false;
			ChestAnimation.Initialize(true);
			ChestAnimation.separatorSlots.Clear();
			ChestAnimation.separatorSlots.Add(ChestAnimation.skeleton.MEKLNNENPDK("base2"));
			ChestAnimation.separatorSlots.Add(ChestAnimation.skeleton.MEKLNNENPDK("base1"));
			SkeletonRenderSeparator.AddToSkeletonRenderer(ChestAnimation);
			int sortingLayerID = GradientSpriteRenderer.sortingLayerID;
			SkeletonRenderSeparator component = ChestAnimation.GetComponent<SkeletonRenderSeparator>();
			for (int i = 0; i < component.partsRenderers.Count; i++)
			{
				SkeletonPartsRenderer skeletonPartsRenderer = component.partsRenderers[i];
				skeletonPartsRenderer.GADGIJJDPOL.sortingOrder = 20 + 10 * i;
				skeletonPartsRenderer.GADGIJJDPOL.sortingLayerID = sortingLayerID;
			}
			SkeletonRenderSeparator component2 = ChestAnimation.GetComponent<SkeletonRenderSeparator>();
			component2.copyPropertyBlock = false;
			component2.copyMeshRendererFlags = false;
			KLDPKHIHBCK = ChestAnimation.skeleton.NMLBCOPEEDC("particle");
			float x = base.transform.localScale.x;
			ChestParticleContainer.localScale = Vector3.one * (1f / x);
			DoAfterSpineLoaded();
			PlayInAnimation();
		}

		public void DoAfterSpineLoaded()
		{
			if (ChestAnimation != null)
			{
				ChestAnimation.state.FAMOCPPGDPK += KKEHCHPNLHE;
				KNGKFJEMNFB = ChestAnimation.skeleton.NMLBCOPEEDC("burst");
				ChestAnimation.gameObject.SetActive(false);
			}
		}

		public override void PlayDialogInAnimation()
		{
			WaitForSpineToLoad();
		}

		private void HCGFNGCAPKP(JHFLAELBLPM JKFDBAEMGMJ)
		{
			GLCODEFGOBK = true;
			ChestAnimation.state.DHOFLMAIDKL -= HCGFNGCAPKP;
			ChestAnimation.state.DHOFLMAIDKL += HBHHNINCKJJ;
			HBHHNINCKJJ(null);
		}

		private void HBHHNINCKJJ(JHFLAELBLPM JKFDBAEMGMJ)
		{
			StartCoroutine(GGKLKHHODJA());
		}

		private IEnumerator GGKLKHHODJA()
		{
			yield return new WaitForSeconds(UnityEngine.Random.Range(0.2f, 1f));
			if (GLCODEFGOBK)
			{
				ONEHFGMKNBP++;
				if (ONEHFGMKNBP >= JFKGAJEFMNP.Length)
				{
					ONEHFGMKNBP = 0;
				}
				ChestAnimation.state.LMHOONAMFIJ(0, JFKGAJEFMNP[ONEHFGMKNBP], false);
			}
		}

		public override Sequence PlayDialogOutAnimation()
		{
			KLDPKHIHBCK = null;
			float x = base.transform.localScale.x;
			ChestParticleContainer.transform.localPosition = new Vector3(0.007f, 1.333f / x);
			Sequence sequence = DOTween.Sequence();
			sequence.Append(ClaimButton.transform.DOScale(Vector3.zero, 0.2f));
			int count = MEHHNEKJLAJ.Count;
			for (int i = 0; i < count; i++)
			{
				float atPosition = 0.076f * (float)i;
				sequence.Insert(atPosition, MEHHNEKJLAJ[i].DOScale(Vector3.zero, 0.153f).SetEase(Ease.InBack));
				sequence.Insert(atPosition, MEHHNEKJLAJ[i].DOLocalMoveY(-1f, 0.153f).SetEase(Ease.InBack));
			}
			float num = 0.076f * (float)count;
			sequence.Insert(num, Circle.transform.DOScale(Vector3.zero, 0.153f).SetEase(Ease.InBack));
			sequence.Insert(num, ChestAnimation.transform.DOScale(Vector3.zero, 0.153f).SetEase(Ease.InBack));
			sequence.Insert(num, ChestParticleContainer.DOScale(Vector3.zero, 0.153f).SetEase(Ease.InBack));
			sequence.Insert(num, ChestParticleContainer.DOLocalMoveY(CPKEBLKCLCB / x, 0.153f).SetEase(Ease.InBack));
			sequence.Insert(num + 0.2f, BackgroundSpriteRenderer.DOColor(new Color(0.5882353f, 0.1764706f, 0.21960784f, 0f), 0.23f));
			sequence.InsertCallback(num + 0.2f, delegate
			{
				DialogLibrary.GABGKBAKHDP.HideDialogBackground();
			}).SetEase(Ease.Linear);
			DOVirtual.Float(0.468f, 0f, 0.23f, delegate(float AMFCENFNAJJ)
			{
				FNDEBEFCKAD.SetFloat("_alpha", AMFCENFNAJJ);
			}).SetEase(Ease.Linear).SetDelay(num + 0.2f);
			return sequence;
		}

		public virtual void OpenChest()
		{
			if (!PBJLJNHLLEM)
			{
				if (!GLCODEFGOBK)
				{
					HCGFNGCAPKP(null);
				}
				GKMKAMLMOPK = false;
				PBJLJNHLLEM = true;
				OpenButton.SetActive(false);
				GLCODEFGOBK = false;
				ChestAnimation.state.DHOFLMAIDKL -= HBHHNINCKJJ;
				PrepareRewards();
				float num = FFIIJJPJABD(MBODHMOEJEO.Count);
				Vector3 localPosition = ItemsContainer.transform.localPosition;
				localPosition.x = (0f - num) * 0.5f;
				ItemsContainer.transform.localPosition = localPosition;
				EENDAPOEEFK(0, false);
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ChestDialog, "Chest Opened");
			}
		}

		public virtual void PrepareRewards()
		{
			MBODHMOEJEO = NDGOJGLPIJF.GABGKBAKHDP.NCJMDKEBLMP();
		}

		public virtual void ExecuteOpenChest(Dictionary<NAAHKHPBAPA, int> GKNKMDIPAIK)
		{
			foreach (KeyValuePair<NAAHKHPBAPA, int> item in GKNKMDIPAIK)
			{
				int aCFDIDGFPKJ = GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(item.Key, item.Value);
				if (item.Key == NAAHKHPBAPA.Coins)
				{
					DIDFHGBGKFJ = item.Value;
					GEBAAFFGKJG.GABGKBAKHDP.IBFMAELGBGP(aCFDIDGFPKJ);
				}
			}
			AFJPGLHKOID.DJDGHLNEAHB(GKNKMDIPAIK);
			NDGOJGLPIJF.GABGKBAKHDP.EAMANKNAANK();
			if (!ELBMHNOBHPN.EDAFBCMCHDH)
			{
				KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
				{
					new NKPDMAEDFHC()
				});
			}
			if (JCOKJJGCPHI != null)
			{
				JCOKJJGCPHI();
			}
			if (OnChestClaimed != null)
			{
				OnChestClaimed();
			}
		}

		private static float FFIIJJPJABD(int EHJNMODJEAN)
		{
			return 2f * (float)EHJNMODJEAN + 1f * (float)(EHJNMODJEAN - 1) - 2f;
		}

		public void ClaimRewards()
		{
			JBLHLNCOLHD();
			Close();
		}

		public virtual void SkipAnimation()
		{
			if (MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() <= 24)
			{
				return;
			}
			if (GKMKAMLMOPK)
			{
				OpenChest();
				GKMKAMLMOPK = false;
				return;
			}
			if (NMGGNPJFMJC)
			{
				Close();
				NMGGNPJFMJC = false;
				return;
			}
			EKPIJHFPGJB = 2f;
			if (JIEEDECENPC != null)
			{
				JIEEDECENPC.timeScale = EKPIJHFPGJB;
			}
			if (EAKFOPJODDP != null)
			{
				EAKFOPJODDP.timeScale = EKPIJHFPGJB;
			}
			if (GMPPALFGNJD != null)
			{
				GMPPALFGNJD.timeScale = EKPIJHFPGJB;
			}
		}

		protected virtual void EENDAPOEEFK(int EHJNMODJEAN, bool KMJFJLCCKDF, float BBDDGAOPJBG = 0f)
		{
			int count = MBODHMOEJEO.Count;
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ChestDialog, "Show reward: {0}/{1}", EHJNMODJEAN, count);
			if (EHJNMODJEAN < count)
			{
				ChestAnimation.state.JKEHGHMHCKJ(0);
				if (EHJNMODJEAN == count - 1)
				{
					ChestAnimation.state.LMHOONAMFIJ(0, AKNGCJLOOCA, false);
				}
				else
				{
					string pEKKCDPEBGL = ((EHJNMODJEAN != 0) ? ICPHLOGLEDE : KEFDLMDHKBF);
					ChestAnimation.state.LMHOONAMFIJ(0, pEKKCDPEBGL, false);
					ChestAnimation.state.CCKPJPKJLJI(0, FKCKMLNPALG, true, 0f);
				}
				KeyValuePair<NAAHKHPBAPA, int> jHPAEIHECAI = MBODHMOEJEO.ElementAt(EHJNMODJEAN);
				GameObject gameObject = UnityEngine.Object.Instantiate(RewardItemPrefab);
				gameObject.transform.SetParent(ItemsContainer.transform);
				gameObject.transform.position = CardStartPosition.position;
				gameObject.transform.localScale = Vector3.zero;
				ToonChestItem JOEKGGBMGJN = gameObject.GetComponent<ToonChestItem>();
				JKCHCBBALOB(JOEKGGBMGJN, jHPAEIHECAI);
				JOEKGGBMGJN.BaseSortingLayer = (10 - (count - EHJNMODJEAN)) * 2;
				if (KMJFJLCCKDF)
				{
					JOEKGGBMGJN.CountText.enabled = false;
				}
				MEHHNEKJLAJ.Add(JOEKGGBMGJN.transform);
				Vector3 endValue = new Vector3(FFIIJJPJABD(EHJNMODJEAN + 1), 0f, 0f);
				EKPIJHFPGJB = 1f;
				if (JIEEDECENPC != null && JIEEDECENPC.IsPlaying())
				{
					return;
				}
				JIEEDECENPC = DOTween.Sequence();
				JIEEDECENPC.timeScale = EKPIJHFPGJB;
				JIEEDECENPC.SetDelay(0.3f + BBDDGAOPJBG);
				JIEEDECENPC.AppendCallback(delegate
				{
					AudioManager.Play(KOOGPFAPGGD.ChestCardFly);
				});
				JIEEDECENPC.Append(JOEKGGBMGJN.transform.DOScale(Vector3.one * 1.2f, 0.3f).SetEase(Ease.OutSine));
				Tweener t = gameObject.transform.DOLocalMoveY(0.57f, 0.3f).SetEase(Ease.OutSine);
				JIEEDECENPC.Join(t);
				JIEEDECENPC.Append(JOEKGGBMGJN.BackFace.transform.DOLocalRotate(new Vector3(10f, 90f, 0f), 0.15f).SetEase(Ease.Linear));
				JIEEDECENPC.Join(JOEKGGBMGJN.transform.DOLocalRotate(new Vector3(10f, 10f, 0f), 0.15f).SetEase(Ease.Linear));
				JIEEDECENPC.AppendCallback(delegate
				{
					AudioManager.Play(KOOGPFAPGGD.ChestCardTurn);
					EAKFOPJODDP = DOTween.Sequence();
					EAKFOPJODDP.timeScale = EKPIJHFPGJB;
					JOEKGGBMGJN.BackFace.SetActive(false);
					JOEKGGBMGJN.FrontFace.SetActive(true);
					Quaternion identity = Quaternion.identity;
					identity.eulerAngles = new Vector3(-10f, -90f, 0f);
					JOEKGGBMGJN.FrontFace.transform.rotation = identity;
					EAKFOPJODDP.Append(JOEKGGBMGJN.FrontFace.transform.DOLocalRotate(new Vector3(0f, 0f, 0f), 0.15f).SetEase(Ease.Linear));
					EAKFOPJODDP.Join(JOEKGGBMGJN.transform.DOLocalRotate(new Vector3(0f, 0f, 0f), 0.15f).SetEase(Ease.Linear));
				});
				JIEEDECENPC.Append(JOEKGGBMGJN.transform.DOScale(Vector3.one, 0.3f).SetEase(ScaleCurve));
				JIEEDECENPC.Join(JOEKGGBMGJN.transform.DOLocalMove(endValue, 0.3f).SetEase(MoveCurve));
				JIEEDECENPC.AppendCallback(delegate
				{
					AudioManager.Play(KOOGPFAPGGD.ChestCardLand);
					JOEKGGBMGJN.Explode();
				});
				JIEEDECENPC.SetEase(Ease.Linear);
				JIEEDECENPC.OnComplete(delegate
				{
					if (KMJFJLCCKDF)
					{
						GMPPALFGNJD = JOEKGGBMGJN.PlayCountAnimation(EKPIJHFPGJB, EHJNMODJEAN, delegate(int JBKEOKPAFON)
						{
							if (JBKEOKPAFON == EHJNMODJEAN)
							{
								JOEKGGBMGJN.BringToFront(false);
								EENDAPOEEFK(++EHJNMODJEAN, true);
							}
						});
					}
					else
					{
						JOEKGGBMGJN.BringToFront(false);
						EENDAPOEEFK(++EHJNMODJEAN, false);
					}
				});
			}
			else
			{
				ClaimButton.SetActive(true);
				NMGGNPJFMJC = true;
				new LLCJMMBBLEH(DHBMLJPMEKM(MBODHMOEJEO));
			}
		}

		private void JKCHCBBALOB(ToonChestItem JOEKGGBMGJN, KeyValuePair<NAAHKHPBAPA, int> JHPAEIHECAI)
		{
			JOEKGGBMGJN.SetContent(JHPAEIHECAI.Key, JHPAEIHECAI.Value);
		}

		private IEnumerator DHBMLJPMEKM(Dictionary<NAAHKHPBAPA, int> JEAHDBDNJOA)
		{
			yield return MCJHHDACJBG.CHFOIGLAMPN;
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ChestDialog, "Give rewards.");
			ExecuteOpenChest(JEAHDBDNJOA);
		}

		public override void DialogCreated()
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ChestDialog, "Chest Dialog Created");
			base.DialogCreated();
			MEHHNEKJLAJ = new List<Transform>();
			base.transform.position = Vector3.zero;
			BackgroundSpriteRenderer.color = new Color(0.5882353f, 0.1764706f, 0.21960784f, 1f);
			OpenButton.transform.localScale = Vector3.zero;
			ClaimButton.SetActive(false);
			Circle.transform.localScale = Vector3.zero;
			FNDEBEFCKAD = GradientSpriteRenderer.material;
			FNDEBEFCKAD.SetColor("_colorA", new Color(43f / 85f, 0.11372549f, 0.11372549f, 0f));
			FNDEBEFCKAD.SetColor("_colorB", new Color(0.4117647f, 0f, 0f, 4f / 51f));
			FNDEBEFCKAD.SetFloat("_slide", -1f);
			FNDEBEFCKAD.SetFloat("_alpha", 0.468f);
			FNDEBEFCKAD.SetFloat("_x", 0.5f);
			FNDEBEFCKAD.SetFloat("_y", 0.46f);
			FNDEBEFCKAD.SetFloat("_scaleX", 10.2156f);
			FNDEBEFCKAD.SetFloat("_scaleY", 20.26675f);
			FNDEBEFCKAD.SetFloat("_ratio", 0.79f);
			UpdateAnimationIds();
			if (ONCMBJKLKIL.PEFHCKMBHOM)
			{
				ChestContentTransform.transform.localScale = Vector3.one * 0.8f;
			}
		}

		private void KKEHCHPNLHE(JHFLAELBLPM JKFDBAEMGMJ, DCBJAMHBAJB EKFOKNPODBK)
		{
			if (KNGKFJEMNFB != null)
			{
				Burst.localPosition = new Vector3(KNGKFJEMNFB.POFLEELFBPH, KNGKFJEMNFB.MLMBGGJGOBP);
			}
			if (!Particles.activeSelf)
			{
				Particles.SetActive(true);
			}
			string text = EKFOKNPODBK.LJDLCPHOBHB.PNGPLGHKFDI;
			if (text != null && text == "ShowParticle")
			{
				switch (EKFOKNPODBK.FGEEHHBILMN)
				{
				case "ChestBurst":
					ChestParticle.Play(true);
					ChestOpenBurstParticleSystem.Play();
					break;
				case "ChestOpen2":
				case "ChestBurst2":
				case "ChestBurst3":
					ChestOpenBurstParticleSystem.Play();
					break;
				}
			}
		}

		public void SetContent(Action IMHLFAHONPP)
		{
			JCOKJJGCPHI = IMHLFAHONPP;
		}

		public override void OnDialogClosed()
		{
			base.OnDialogClosed();
			MeshRenderer component = ChestAnimation.GetComponent<MeshRenderer>();
			if (component != null && component.materials.Length > 0)
			{
				Resources.UnloadAsset(component.materials[0].mainTexture);
			}
			POIKGNFHGHM();
		}

		protected virtual void POIKGNFHGHM()
		{
			if (DIDFHGBGKFJ > 0)
			{
				MapUIAnimationController instance = MapUIAnimationController.Instance;
				if (!(instance == null))
				{
					int eNMLICFLHAO = Math.Min(DIDFHGBGKFJ / 2, 15);
					instance.StartCoinCollectAnimation(DIDFHGBGKFJ, eNMLICFLHAO, NewMapPage.CoinAnimationStartPosition);
				}
			}
		}

		[CompilerGenerated]
		private static void ICMLNMBGHKD()
		{
			AudioManager.Play(KOOGPFAPGGD.ChestFly);
		}

		[CompilerGenerated]
		private void OLJACDCOPCG()
		{
			ChestAnimation.gameObject.SetActive(true);
			ChestAnimation.state.DHOFLMAIDKL += HCGFNGCAPKP;
		}

		[CompilerGenerated]
		private void IKFMGFLBJNM()
		{
			OpenButton.transform.DOScale(Vector3.one, 0.35f).OnComplete(delegate
			{
				GKMKAMLMOPK = true;
			});
		}

		[CompilerGenerated]
		private static void HKMFDDJABDH()
		{
			DialogLibrary.GABGKBAKHDP.HideDialogBackground();
		}

		[CompilerGenerated]
		private void OANAIAJBAOC(float AMFCENFNAJJ)
		{
			FNDEBEFCKAD.SetFloat("_alpha", AMFCENFNAJJ);
		}

		[CompilerGenerated]
		private static void ADAOPCLOBFF()
		{
			AudioManager.Play(KOOGPFAPGGD.ChestCardFly);
		}

		[CompilerGenerated]
		private void JIGIIDFOKBM()
		{
			GKMKAMLMOPK = true;
		}
	}
}
