using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.MapScene;
using Assets.Scripts.SceneTransitions;
using Assets.Scripts.Utils;
using DG.Tweening;
using MapScene;
using NewMapScene.MapAnimations;
using TMPro;
using ToonSocial;
using ToonSocial.ui.joined;
using UnityEngine;

namespace NewMapScene
{
	public class MapUIAnimationController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class KDKCOHIEMBN
		{
			internal Action IMHLFAHONPP;

			internal void AGFNGEFDHLA()
			{
				IMHLFAHONPP();
			}
		}

		[CompilerGenerated]
		private sealed class MEPLPBHJKCH
		{
			internal Action<bool> IMHLFAHONPP;

			internal void AGFNGEFDHLA()
			{
				IMHLFAHONPP(true);
			}
		}

		[CompilerGenerated]
		private sealed class EGGHFLEIKCI
		{
			internal Action IMHLFAHONPP;

			internal void AGFNGEFDHLA()
			{
				IMHLFAHONPP();
			}
		}

		[CompilerGenerated]
		private sealed class NCFECICKOAE
		{
			internal Action<bool> BGCOOLBHJAP;

			internal void AGFNGEFDHLA()
			{
				BGCOOLBHJAP(true);
			}
		}

		[CompilerGenerated]
		private sealed class LPFEJAICEKG
		{
			internal TextMeshPro BJDLKMIEFOC;

			internal void AGFNGEFDHLA()
			{
				if (!(BJDLKMIEFOC == null))
				{
					BJDLKMIEFOC.enabled = false;
					BJDLKMIEFOC.MEJPNNFDEBD();
				}
			}
		}

		[CompilerGenerated]
		private sealed class COGCCJCBJHK
		{
			internal int GLCKKDDELKL;

			internal int BICBELADBDI;

			internal Action<int, bool> LNEOKLBLPPE;
		}

		[CompilerGenerated]
		private sealed class JKOFAGJHBME
		{
			internal GameObject KPFDIMBCJIN;
		}

		[CompilerGenerated]
		private sealed class MDDFAPAOLDB
		{
			internal bool AKHKBDKDKGF;

			internal COGCCJCBJHK CBLDHKBEKID;

			internal JKOFAGJHBME EDLEPJMMJBA;

			internal void AGFNGEFDHLA()
			{
				int num = CBLDHKBEKID.GLCKKDDELKL;
				if (CBLDHKBEKID.BICBELADBDI > 0)
				{
					CBLDHKBEKID.BICBELADBDI--;
					num++;
				}
				if (EDLEPJMMJBA.KPFDIMBCJIN != null)
				{
					EDLEPJMMJBA.KPFDIMBCJIN.MEJPNNFDEBD();
				}
				if (CBLDHKBEKID.LNEOKLBLPPE != null)
				{
					CBLDHKBEKID.LNEOKLBLPPE(num, AKHKBDKDKGF);
				}
			}
		}

		public static MapUIAnimationController Instance;

		public CameraSizer CurrentCameraSizer;

		public GameObject CollectCoinReferencePrefab;

		public GameObject CollectCoinTextReferencePrefab;

		public GameObject CollectLifeReferencePrefab;

		public GameObject CollectBoosterReferencePrefab;

		public LifeUseFrameAnimation UseLifeReferencePrefab;

		public SocialHelper CurrentSocialHelper;

		public Transform CoinCollectPosition;

		public Transform LifeCollectPosition;

		public Transform Container;

		public MapCoinsDisplay CoinBarDisplay;

		public MapLivesDisplay LivesDisplay;

		public InboxTab InboxTab;

		public Transform MapContainer;

		public Dictionary<string, GameObject> PositionDictionary;

		public float PageHeight = 14.52f;

		private float HPDLLEPFGPC;

		public void Awake()
		{
			if (Instance != null)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.MapUIAnimationController, "THERE IS ALREADY A INSTANCE OF MAP ANIMATION CONTROLLER");
			}
			Instance = this;
		}

		public void ResetSelf()
		{
			CollectCoinReferencePrefab.EILCDHMOOGO();
			CollectCoinTextReferencePrefab.EILCDHMOOGO();
			Instance = null;
		}

		public void OnDestroy()
		{
			Instance = null;
		}

		public void Start()
		{
			if (!(CurrentCameraSizer == null))
			{
				float num = ONCMBJKLKIL.EMFKAPJMDCC / CurrentCameraSizer.DesiredWidth;
				float num2 = ONCMBJKLKIL.FHAMOHDEGMK - (CurrentCameraSizer.HeightOfTopPanel + CurrentCameraSizer.HeightOfTopPanel) * num;
				HPDLLEPFGPC = num2 / PageHeight;
				PositionDictionary = new Dictionary<string, GameObject>();
				CollectCoinReferencePrefab.FLFDKMOOIFL(5);
				CollectCoinTextReferencePrefab.FLFDKMOOIFL(2);
			}
		}

		public void StartCoinCollectAnimationWithKey(int NNIDKMJGAJO, string IKNCPEPOKGJ)
		{
			GameObject gameObject = PositionDictionary[IKNCPEPOKGJ];
			if (!(gameObject == null))
			{
				PositionDictionary.Remove(IKNCPEPOKGJ);
				Vector3 kKAHENNAJJD = gameObject.transform.position * gameObject.transform.lossyScale.y;
				float y = Mathf.Clamp(kKAHENNAJJD.y / HPDLLEPFGPC, -6f, 3.6f);
				kKAHENNAJJD.y = y;
				StartCoinCollectAnimation(NNIDKMJGAJO, NNIDKMJGAJO, kKAHENNAJJD);
			}
		}

		public void StartCoinCollectAnimation(int NNIDKMJGAJO, Action IMHLFAHONPP, int ENMLICFLHAO = 10, Vector3 KKAHENNAJJD = default(Vector3))
		{
			if (IMHLFAHONPP != null)
			{
				Sequence sequence = DOTween.Sequence();
				sequence.AppendInterval(1.7f + 0.1f * (float)ENMLICFLHAO);
				sequence.OnComplete(delegate
				{
					IMHLFAHONPP();
				});
			}
			StartCoinCollectAnimation(NNIDKMJGAJO, ENMLICFLHAO, KKAHENNAJJD);
		}

		public void StartCoinCollectAnimation(int NNIDKMJGAJO, Action<bool> IMHLFAHONPP, int ENMLICFLHAO = 10, Vector3 KKAHENNAJJD = default(Vector3))
		{
			if (IMHLFAHONPP != null)
			{
				Sequence sequence = DOTween.Sequence();
				sequence.AppendInterval(1f + 0.1f * (float)ENMLICFLHAO);
				sequence.OnComplete(delegate
				{
					IMHLFAHONPP(true);
				});
			}
			StartCoinCollectAnimation(NNIDKMJGAJO, ENMLICFLHAO, KKAHENNAJJD);
		}

		public void StartCoinCollectAnimation(int NNIDKMJGAJO, int ENMLICFLHAO = 10, Vector3 KKAHENNAJJD = default(Vector3))
		{
			EOEBCAEKFKP(NNIDKMJGAJO, KKAHENNAJJD);
			MEPPKHHMMII(NNIDKMJGAJO, ENMLICFLHAO, KKAHENNAJJD, CoinCollectPosition.position, CollectCoinReferencePrefab, CFMJKLBAAKB);
			if (NNIDKMJGAJO > 1)
			{
				AudioManager.Play(KOOGPFAPGGD.LevelWinCoinReward, GCEAKOOGDJK.Single);
			}
		}

		private void CFMJKLBAAKB(int EDDNOJDPMCF, bool AKHKBDKDKGF)
		{
			if (CoinBarDisplay != null)
			{
				CoinBarDisplay.PlayHitAnimation(EDDNOJDPMCF, AKHKBDKDKGF);
			}
			AudioManager.Play(KOOGPFAPGGD.UiCoinCollect, GCEAKOOGDJK.Multiple);
		}

		public void StartLifeCollectAnimation(int NNIDKMJGAJO, Action IMHLFAHONPP, int ENMLICFLHAO, Vector3 KKAHENNAJJD, bool EMHEDOEHEFH)
		{
			if (IMHLFAHONPP != null)
			{
				Sequence sequence = DOTween.Sequence();
				sequence.AppendInterval(1.7f + 0.1f * (float)ENMLICFLHAO);
				sequence.OnComplete(delegate
				{
					IMHLFAHONPP();
				});
			}
			StartLifeCollectAnimation(NNIDKMJGAJO, ENMLICFLHAO, KKAHENNAJJD, EMHEDOEHEFH);
		}

		public void StartLifeCollectAnimation(int NNIDKMJGAJO, int ENMLICFLHAO, Vector3 KKAHENNAJJD, bool EMHEDOEHEFH)
		{
			EOEBCAEKFKP(NNIDKMJGAJO, KKAHENNAJJD);
			MEPPKHHMMII(NNIDKMJGAJO, ENMLICFLHAO, KKAHENNAJJD, LifeCollectPosition.position, CollectLifeReferencePrefab, JALKNPMPAIE, 1.1f, 0.12f, 1.5f);
			if (!(InboxTab == null))
			{
				Sequence sequence = DOTween.Sequence();
				sequence.AppendInterval(1.7f + 0.1f * (float)ENMLICFLHAO);
				sequence.OnComplete(delegate
				{
					InboxTab.UpdateToCurrentCount();
				});
				if (EMHEDOEHEFH)
				{
					AudioManager.Play(KOOGPFAPGGD.LifeReveal, GCEAKOOGDJK.Single);
				}
			}
		}

		private void JALKNPMPAIE(int EDDNOJDPMCF, bool AKHKBDKDKGF)
		{
			if (!(InboxTab == null))
			{
				InboxTab.PlayHitAnimation();
				AudioManager.Play(KOOGPFAPGGD.UiLifeCollect, GCEAKOOGDJK.Multiple);
			}
		}

		public void StartLifeUseAnimation(Vector3 KKAHENNAJJD, float HJLOCAEAFMJ)
		{
			UnityEngine.Object.Instantiate(UseLifeReferencePrefab).StartAnimation(KKAHENNAJJD, LivesDisplay.LivesCount.ANLKLKAINEO.position, HJLOCAEAFMJ, KAMJLJNKFOE);
		}

		private void KAMJLJNKFOE()
		{
			if (!(LivesDisplay == null))
			{
				LivesDisplay.UpdateLives();
				LivesDisplay.PlayHitAnimation();
				AudioManager.Play(KOOGPFAPGGD.UiLifeCollect, GCEAKOOGDJK.Multiple);
			}
		}

		public void StartPrefabCollectAnimation(int ENMLICFLHAO, int NNIDKMJGAJO, Vector3 KKAHENNAJJD, Vector3 HBKDNOHDOFG, GameObject DDBADIOCKGF, Action<int, bool> NAGCPNLKLPD, Action<bool> BGCOOLBHJAP)
		{
			Sequence sequence = DOTween.Sequence();
			sequence.AppendInterval(0.8f);
			sequence.OnComplete(delegate
			{
				BGCOOLBHJAP(true);
			});
			MEPPKHHMMII(ENMLICFLHAO, NNIDKMJGAJO, KKAHENNAJJD, HBKDNOHDOFG, DDBADIOCKGF, NAGCPNLKLPD, 0f, 0f);
		}

		private void EOEBCAEKFKP(int NNIDKMJGAJO, Vector3 KKAHENNAJJD)
		{
			TextMeshPro BJDLKMIEFOC = CollectCoinTextReferencePrefab.JOBDHIPIMAG().GetComponent<TextMeshPro>();
			if (!(BJDLKMIEFOC != null))
			{
				return;
			}
			Sequence sequence = DOTween.Sequence().SetEase(Ease.Linear);
			sequence.SetRecyclable(false);
			BJDLKMIEFOC.enabled = true;
			BJDLKMIEFOC.color = new Color(1f, 1f, 1f, 0f);
			BJDLKMIEFOC.ANLKLKAINEO.position = KKAHENNAJJD;
			BJDLKMIEFOC.ANLKLKAINEO.localScale = Vector3.zero;
			BJDLKMIEFOC.FCJBBPHFNPJ = "+" + NNIDKMJGAJO;
			Tweener tweener = BJDLKMIEFOC.ANLKLKAINEO.DOMoveY(KKAHENNAJJD.y + 2f, 2f).SetEase(Ease.InQuad);
			tweener.easeOvershootOrAmplitude = 2f;
			sequence.Insert(0f, BJDLKMIEFOC.DOFade(1f, 1f));
			sequence.Insert(0f, BJDLKMIEFOC.ANLKLKAINEO.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutSine));
			sequence.Insert(0f, tweener);
			sequence.Insert(1.5f, BJDLKMIEFOC.DOFade(0f, 0.5f));
			sequence.OnComplete(delegate
			{
				if (!(BJDLKMIEFOC == null))
				{
					BJDLKMIEFOC.enabled = false;
					BJDLKMIEFOC.MEJPNNFDEBD();
				}
			});
		}

		private void MEPPKHHMMII(int NNIDKMJGAJO, int ENMLICFLHAO, Vector3 KKAHENNAJJD, Vector3 GLJBHFOEPAO, GameObject JCFCDEJKFMH, Action<int, bool> LNEOKLBLPPE, float DFLCPDGAHGM = 1.3f, float POKHCMMAGGH = 0.1f, float NPLDBAAFJOL = 1.2f)
		{
			int GLCKKDDELKL = NNIDKMJGAJO / ENMLICFLHAO;
			int BICBELADBDI = NNIDKMJGAJO % ENMLICFLHAO;
			for (int i = 0; i < ENMLICFLHAO; i++)
			{
				GameObject KPFDIMBCJIN = JCFCDEJKFMH.JOBDHIPIMAG();
				if (!(KPFDIMBCJIN != null))
				{
					continue;
				}
				CollectPrefab component = KPFDIMBCJIN.GetComponent<CollectPrefab>();
				if (component != null)
				{
					component.IncreaseSortingOrder(i);
				}
				Sequence s = DOTween.Sequence();
				Vector3 position = KKAHENNAJJD;
				position.x += UnityEngine.Random.Range(-0.75f, 0.75f);
				position.y += UnityEngine.Random.Range(-0.4f, 0.4f);
				KPFDIMBCJIN.transform.position = position;
				KPFDIMBCJIN.transform.localScale = Vector3.zero;
				s.AppendInterval((float)i * POKHCMMAGGH);
				s.Append(KPFDIMBCJIN.transform.DOScale(Vector3.one, 0.3f).SetEase(Ease.OutSine));
				s.AppendInterval(0.1f);
				bool AKHKBDKDKGF = i == ENMLICFLHAO - 1;
				Tweener tweener = KPFDIMBCJIN.transform.DOMove(GLJBHFOEPAO, DFLCPDGAHGM).SetEase(Ease.InBack).OnComplete(delegate
				{
					int num = GLCKKDDELKL;
					if (BICBELADBDI > 0)
					{
						BICBELADBDI--;
						num++;
					}
					if (KPFDIMBCJIN != null)
					{
						KPFDIMBCJIN.MEJPNNFDEBD();
					}
					if (LNEOKLBLPPE != null)
					{
						LNEOKLBLPPE(num, AKHKBDKDKGF);
					}
				});
				tweener.easeOvershootOrAmplitude = NPLDBAAFJOL;
				s.Append(tweener);
			}
		}

		public void InformTeamLeaveAndRequestLimit(double KKLEHEHGDMJ, int BPKJLGJDFKG)
		{
			string empty = string.Empty;
			empty = ((!(KKLEHEHGDMJ > 60.0)) ? NKILHODNBDE.GHBGCADFLFB("WaitForHelpSingular") : string.Format(NKILHODNBDE.GHBGCADFLFB("WaitForHelpPlural"), (int)(KKLEHEHGDMJ / 60.0) + 1));
			MapManager.Instance.ShowErrorMessage(empty);
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.MapUIAnimationController, "InformTeamLeaveAndRequestLimit seconds left:" + KKLEHEHGDMJ);
			GameObject value;
			if (PositionDictionary.TryGetValue("LifeReq" + BPKJLGJDFKG, out value))
			{
				HelpButtonScript component = value.GetComponent<HelpButtonScript>();
				if (component != null)
				{
					component.HelpEntry.EnableHelpButton();
				}
			}
		}

		public void StartRewardCollectAnimation(NAAHKHPBAPA MMHIFICGOHO, int ENMLICFLHAO, Action IMHLFAHONPP)
		{
			if (!MMHIFICGOHO.LGOKFILDDDD() && !MMHIFICGOHO.MCMDJCBFENO())
			{
				if (IMHLFAHONPP != null)
				{
					IMHLFAHONPP();
				}
				return;
			}
			for (int i = 0; i < ENMLICFLHAO; i++)
			{
				CollectBooster component = UnityEngine.Object.Instantiate(CollectBoosterReferencePrefab).GetComponent<CollectBooster>();
				if (!(component == null))
				{
					component.Prepare(MMHIFICGOHO, i, true, MapContainer, (i != ENMLICFLHAO - 1) ? null : IMHLFAHONPP);
				}
			}
		}

		public void StartMultipleRewardCollectAnimation(Dictionary<NAAHKHPBAPA, int> JEAHDBDNJOA, Action IMHLFAHONPP)
		{
			int num = 0;
			foreach (KeyValuePair<NAAHKHPBAPA, int> item in JEAHDBDNJOA)
			{
				CollectBooster component = UnityEngine.Object.Instantiate(CollectBoosterReferencePrefab).GetComponent<CollectBooster>();
				if (!(component == null))
				{
					component.Prepare(item.Key, num, false, MapContainer, (num != JEAHDBDNJOA.Count - 1) ? null : IMHLFAHONPP);
					num++;
				}
			}
		}

		[CompilerGenerated]
		private void HFLMMIGLNHD()
		{
			InboxTab.UpdateToCurrentCount();
		}
	}
}
