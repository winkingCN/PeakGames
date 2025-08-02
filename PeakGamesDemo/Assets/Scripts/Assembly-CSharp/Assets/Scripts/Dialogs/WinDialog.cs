using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Touches;
using Assets.Scripts.GamePlayScene.Tutorials;
using Assets.Scripts.SceneTransitions;
using Assets.Scripts.Utils;
using Assets.Scripts.Utils.Analytics;
using DG.Tweening;
using Dialogs;
using LevelLoaderScene;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.Dialogs
{
	public class WinDialog : SimpleDialog
	{
		[CompilerGenerated]
		private sealed class HKEMIHOGLNC
		{
			internal GameObject MMGNLANNNJI;

			internal int AMFCENFNAJJ;

			internal void AGFNGEFDHLA()
			{
				MMGNLANNNJI.SetActive(true);
			}

			internal void KDACLOKGNAM()
			{
				if (AMFCENFNAJJ != 1)
				{
					if (AMFCENFNAJJ == 2)
					{
						AudioManager.Play(KOOGPFAPGGD.UiPopupStar3);
					}
					else
					{
						AudioManager.Play(KOOGPFAPGGD.UiPopupStar1);
					}
				}
				else
				{
					AudioManager.Play(KOOGPFAPGGD.UiPopupStar2);
				}
			}
		}

		public GameObject HighScoresPanelReference;

		public TextMeshPro Score;

		public GameObject Seperator1;

		public Sprite CheckSprite;

		public Sprite CrossSprite;

		public GameObject[] Goals;

		public SpriteRenderer[] GoalIcons;

		public SpriteRenderer[] StatusIcons;

		public ParticleSystem[] StarParticles;

		public bool ShowHigscoresPanel;

		public GameObject[] Stars;

		public TextMeshPro TitleLabel;

		public KFCEILFGADG CurrentLevel;

		private HighScoresPanel LPKKLPGGHMN;

		private Sequence EHCNBCAIOOK;

		private List<Sequence> EHLILJNBEKN;

		public override void DialogCreated()
		{
			base.DialogCreated();
			BoosterTapListener.Instance.IncreaseBlockRequests();
			for (int i = 0; i < Stars.Length; i++)
			{
				Stars[i].SetActive(false);
			}
			if (ShowHigscoresPanel)
			{
				GameObject gameObject = Object.Instantiate(HighScoresPanelReference, Vector3.zero, Quaternion.identity);
				LPKKLPGGHMN = gameObject.GetComponent<HighScoresPanel>();
				LPKKLPGGHMN.CurrentDialog = this;
			}
		}

		public void PrepareGoals(List<OGIFMLFEAEM> CDAEMCDOHPC, int KIGOGMKCDKN)
		{
			int count = CDAEMCDOHPC.Count;
			float num = (float)(count - 1) * 0.6f;
			for (int i = 0; i < Goals.Length; i++)
			{
				if (i < count)
				{
					OGIFMLFEAEM oGIFMLFEAEM = CDAEMCDOHPC[i];
					Sprite goalSpriteByItemType = SharedImageLibrary.Instance.GetGoalSpriteByItemType(oGIFMLFEAEM.ENBPGGCIADN);
					GoalIcons[i].sprite = goalSpriteByItemType;
					GoalIcons[i].transform.localScale = GoalIcons[i].transform.localScale * SharedImageLibrary.Instance.GoalImageScale(oGIFMLFEAEM.ENBPGGCIADN);
					StatusIcons[i].sprite = CheckSprite;
					Vector3 localPosition = Goals[i].transform.localPosition;
					localPosition.x = 0f - num + (float)i * 1.2f;
					Goals[i].transform.localPosition = localPosition;
				}
				else
				{
					Goals[i].SetActive(false);
				}
			}
		}

		public void Win(KFCEILFGADG GIOFHACJEGA)
		{
			AudioManager.ResetExternalAudioSources();
			CurrentLevel = GIOFHACJEGA;
			PrepareGoals(CurrentLevel.JKKJLDLMIOG, CurrentLevel.PDGLECFDLJJ);
			EHLILJNBEKN = new List<Sequence>();
			int num = 0;
			int score = ScoreManager.DJADMBLKBKJ;
			for (int i = 0; i < GIOFHACJEGA.EMNDJNDGANP.Length; i++)
			{
				if (score >= GIOFHACJEGA.EMNDJNDGANP[i])
				{
					num = i + 1;
				}
			}
			int pDGLECFDLJJ = GIOFHACJEGA.PDGLECFDLJJ;
			int num2 = IDFPAFEJPPH.GABGKBAKHDP.PDGLECFDLJJ;
			int num3 = 0;
			if (LevelBuilder.LastLevel.EKGHEGKILLC)
			{
				num3 = IDFPAFEJPPH.GABGKBAKHDP.BFBNJLMHPFA;
				TitleLabel.FCJBBPHFNPJ = IDFPAFEJPPH.GABGKBAKHDP.EGLOCAFPJCJ;
			}
			else
			{
				int num4 = ((LevelLoaderController.FakeLevelNo < 0) ? pDGLECFDLJJ : LevelLoaderController.FakeLevelNo);
				TitleLabel.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Level") + num4;
			}
			if (!LevelLoaderController.IsOnlineLevel && !LevelLoaderController.IsOfflineLevel)
			{
				LevelBuilder.LastLevel.ANGCDCAAFKP(num);
				if (LevelBuilder.LastLevel.EKGHEGKILLC)
				{
					IDFPAFEJPPH.GABGKBAKHDP.JBHEPDBAEBP(num);
				}
				else
				{
					MADFPPJCOIM.GABGKBAKHDP.CGINNGBOKAP(pDGLECFDLJJ, score, num);
					DJFPMCMLPJJ.CIBKGNFLBDE(pDGLECFDLJJ);
				}
				if (NDGOJGLPIJF.GABGKBAKHDP.AEFOGGAOFEE())
				{
					int num5 = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Stars);
					if (num5 < NDGOJGLPIJF.DGIKLPPBGHJ)
					{
						GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Stars, num, false);
						NDGOJGLPIJF.GABGKBAKHDP.AMKOJOKCELO = num;
					}
				}
			}
			if (LPKKLPGGHMN != null)
			{
				LPKKLPGGHMN.DIOELAHNLKJ(pDGLECFDLJJ, 1);
			}
			Score.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Score") + string.Format(": <color=#CA2A39>{0}</color>", score);
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.WinDialog, "Won Level:{0} Score:{1} Stars:{2} Name:{3}", pDGLECFDLJJ, score, num, GIOFHACJEGA.PNGPLGHKFDI);
			EHCNBCAIOOK = DOTween.Sequence();
			EHCNBCAIOOK.AppendInterval(0.2f);
			Vector3[] array = new Vector3[3]
			{
				new Vector3(-1.76f, 8.55f, 0f),
				new Vector3(0f, 8.69f, 0f),
				new Vector3(2.37f, 8.4f, 0f)
			};
			Vector3[] array2 = new Vector3[3]
			{
				new Vector3(0.014f, -0.154f, 0f),
				new Vector3(0f, -0.089f, 0f),
				new Vector3(-0.056f, -0.121f, 0f)
			};
			Vector3[] array3 = new Vector3[3]
			{
				new Vector3(0f, -0.015f, 0f),
				new Vector3(0f, 0f, 0f),
				new Vector3(0.009f, -0.023f, 0f)
			};
			Vector3 localScale = Vector3.one * 5f;
			Vector3 endValue = Vector3.one * 0.9f;
			Vector3 endValue2 = Vector3.one * 1.05f;
			Vector3 one = Vector3.one;
			for (int j = 0; j < num; j++)
			{
				GameObject MMGNLANNNJI = Stars[j];
				ParticleSystem @object = StarParticles[j];
				Sequence sequence = DOTween.Sequence();
				MMGNLANNNJI.transform.localScale = localScale;
				MMGNLANNNJI.transform.localPosition = array[j];
				int AMFCENFNAJJ = j;
				sequence.AppendCallback(delegate
				{
					MMGNLANNNJI.SetActive(true);
				});
				sequence.Append(MMGNLANNNJI.transform.DOScale(endValue, 0.3f).SetEase(Ease.InCubic));
				sequence.Join(MMGNLANNNJI.transform.DOLocalMove(array2[j], 0.3f).SetEase(Ease.InCubic));
				sequence.AppendCallback(delegate
				{
					if (AMFCENFNAJJ != 1)
					{
						if (AMFCENFNAJJ == 2)
						{
							AudioManager.Play(KOOGPFAPGGD.UiPopupStar3);
						}
						else
						{
							AudioManager.Play(KOOGPFAPGGD.UiPopupStar1);
						}
					}
					else
					{
						AudioManager.Play(KOOGPFAPGGD.UiPopupStar2);
					}
				});
				sequence.Append(MMGNLANNNJI.transform.DOScale(endValue2, 0.08f).SetEase(Ease.Linear));
				sequence.Join(MMGNLANNNJI.transform.DOLocalMove(array3[j], 0.08f).SetEase(Ease.Linear));
				sequence.Append(MMGNLANNNJI.transform.DOScale(one, 0.06f).SetEase(Ease.Linear));
				sequence.InsertCallback(0.3f, @object.Play);
				EHLILJNBEKN.Add(sequence);
				EHCNBCAIOOK.Insert(0.6f + 0.3f * (float)j, sequence);
			}
			EHCNBCAIOOK.AppendInterval(0.2f);
			EHCNBCAIOOK.AppendCallback(FOMMHJGKGGN);
			EHCNBCAIOOK.OnComplete(delegate
			{
				EHCNBCAIOOK = null;
			});
			if (DIGGBGADIGJ.DFGKPMCBFNL)
			{
				DIGGBGADIGJ.GABGKBAKHDP.NKEOIKOJMMD();
			}
			EAJKFHMFMMD(num);
			JsonLevelEndInventory jsonLevelEndInventory = new JsonLevelEndInventory();
			jsonLevelEndInventory.inventory = new JsonInventory();
			jsonLevelEndInventory.inventory.LDOCFEGBGNK();
			jsonLevelEndInventory.NMCGKNPBGKC();
			bool eKGHEGKILLC = LevelBuilder.LastLevel.EKGHEGKILLC;
			JsonLevelEndData jsonLevelEndData = new JsonLevelEndData();
			jsonLevelEndData.user_id = LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString();
			jsonLevelEndData.level = ((!eKGHEGKILLC) ? CurrentLevel.PDGLECFDLJJ : (-1 * CurrentLevel.PDGLECFDLJJ));
			jsonLevelEndData.level_name = CurrentLevel.PNGPLGHKFDI;
			jsonLevelEndData.level_max = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC();
			jsonLevelEndData.number_of_ego_shown = CurrentLevel.KFHIMNCFLFD;
			jsonLevelEndData.result = num;
			jsonLevelEndData.user_score = score;
			jsonLevelEndData.moves_given = CurrentLevel.HJCPDOGONIG + num3;
			jsonLevelEndData.moves_made = CurrentLevel.PPHBPKCJGMC;
			jsonLevelEndData.duration = (int)((CurrentLevel.NAFLKPJGHHD != 0f) ? (Time.realtimeSinceStartup - CurrentLevel.NAFLKPJGHHD) : 0f);
			jsonLevelEndData.min_fps = CurrentLevel.GIMBEKBFKMJ.FPSMeter.MinimumFps().ToString();
			jsonLevelEndData.max_fps = CurrentLevel.GIMBEKBFKMJ.FPSMeter.MaximumFps().ToString();
			jsonLevelEndData.avg_fps = CurrentLevel.GIMBEKBFKMJ.FPSMeter.AverageFps().ToString();
			jsonLevelEndData.under_50_fps = CurrentLevel.GIMBEKBFKMJ.FPSMeter.SpikeCount();
			jsonLevelEndData.data = jsonLevelEndInventory;
			jsonLevelEndData.cl_stage = (eKGHEGKILLC ? num2 : 0);
			jsonLevelEndData.cl_id = (eKGHEGKILLC ? IDFPAFEJPPH.GABGKBAKHDP.NBJMMBIGCOB : 0);
			JsonLevelEndData aKGPMBFANJB = jsonLevelEndData;
			if (!LevelBuilder.LastLevel.EKGHEGKILLC)
			{
				switch (pDGLECFDLJJ)
				{
				case 6:
					GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Rocket, 3, false);
					GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Bomb, 3, false);
					GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.DiscoBall, 3, false);
					TutorialManager.ShouldDisplayPrelevelTutorial = true;
					break;
				case 9:
					GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Hammer, 4, false);
					TutorialManager.ShouldDisplayBoosterTutorial = true;
					break;
				case 12:
					GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.BoxingGlove, 4, false);
					TutorialManager.ShouldDisplayBoosterTutorial = true;
					break;
				case 16:
					GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Anvil, 4, false);
					TutorialManager.ShouldDisplayBoosterTutorial = true;
					break;
				default:
					if (pDGLECFDLJJ == BoosterManager.EOEHGMKBEHF)
					{
						GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Dice, 4, false);
						TutorialManager.ShouldDisplayBoosterTutorial = true;
					}
					break;
				}
			}
			KBEGNPKLMDE.BFMGMOGNPLJ();
			FIFPLICICKP.GABGKBAKHDP.BAFBKBIKHKC();
			AFJPGLHKOID.CIBKGNFLBDE(aKGPMBFANJB);
			HBOLODOHKKE();
		}

		public void OnDestroy()
		{
			if (EHCNBCAIOOK != null)
			{
				EHCNBCAIOOK.Kill();
			}
			for (int i = 0; i < EHLILJNBEKN.Count; i++)
			{
				Sequence t = EHLILJNBEKN[i];
				if (t.IsActive())
				{
					t.Kill();
				}
			}
		}

		private static void EAJKFHMFMMD(int HCCBDFMKLHN)
		{
			DGOMNDMPMBG.GABGKBAKHDP.NKEOIKOJMMD(HCCBDFMKLHN);
		}

		private static void HBOLODOHKKE()
		{
			if (MCJHHDACJBG.NDNBMGMPBLF && RateUsDialog.ShouldDisplayRateUsForLevel(MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1))
			{
				JHOAHCHHBCH.NCOFPCABEMF();
			}
		}

		private void FOMMHJGKGGN()
		{
			if (Stars == null)
			{
				return;
			}
			for (int i = 0; i < Stars.Length; i++)
			{
				if (Stars[i].activeSelf)
				{
					StarSlider starSlider = Stars[i].AddComponent<StarSlider>();
					starSlider.SetOrder(i);
					starSlider.CanPlay = true;
				}
			}
		}

		public void ContinueButton()
		{
			if (EHCNBCAIOOK != null)
			{
				EHCNBCAIOOK.timeScale = 50f;
			}
			Close();
		}

		public override void Close()
		{
			if (LevelLoaderController.IsOnlineLevel || LevelLoaderController.IsOfflineLevel)
			{
				CaravanSceneManager.Load(GKBHIKONCKJ.LevelLoader);
				return;
			}
			if (CurrentLevel.PDGLECFDLJJ == 1 && MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() == 1)
			{
				LevelBuilder.ShouldRemoveBackgroundImagesOnDestroy = false;
				LevelBuilder.CurrentLevelNo = 2;
				LevelBuilder.KDBDBMBAKEL = "Automatic";
				CaravanSceneManager.Load(GKBHIKONCKJ.GamePlay);
			}
			else
			{
				CaravanSceneManager.Load(GKBHIKONCKJ.Map);
			}
			OneSignal.SendTag("LevelTag", (CurrentLevel.PDGLECFDLJJ + 1).ToString());
		}

		public override Sequence PlayDialogOutAnimation()
		{
			if (LPKKLPGGHMN != null)
			{
				LPKKLPGGHMN.CPPHECFAEAD();
			}
			return base.PlayDialogOutAnimation();
		}

		public override void PlayDialogInAnimation()
		{
			base.PlayDialogInAnimation();
			if (!base.gameObject.activeSelf)
			{
				base.gameObject.SetActive(true);
			}
			if (LPKKLPGGHMN != null)
			{
				StartCoroutine(MACGLLFCNIA());
			}
		}

		private IEnumerator MACGLLFCNIA()
		{
			LPKKLPGGHMN.RefreshHighscorePanel();
			yield return new WaitForSeconds(0.35f);
			LPKKLPGGHMN.ABOFKOHLOGC();
		}

		public override bool CanCloseOnBlackPanelTouch()
		{
			return false;
		}

		public override bool ShouldBeClosedOnSceneChange()
		{
			return false;
		}

		[CompilerGenerated]
		private void NIPGPCLLEPL()
		{
			EHCNBCAIOOK = null;
		}
	}
}
