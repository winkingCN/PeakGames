using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.Dialogs;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.GamePlayScene.Touches;
using Assets.Scripts.GamePlayScene.Tutorials;
using Assets.Scripts.GamePlayScene.UI;
using Assets.Scripts.Utils;
using DG.Tweening;
using TMPro;
using UnityEngine;
using Utils;

namespace Assets.Scripts.GamePlayScene.Mechanics
{
	public class BoosterManager : MonoBehaviour
	{
		private enum KBKGBLJCDFL
		{
			InHammer = 0,
			InAnvil = 1,
			InBoxingGlove = 2,
			InShuffle = 3,
			InPaintBrushState = 4,
			Busy = 5,
			InGamePlay = 6
		}

		[CompilerGenerated]
		private sealed class OJEDFOJHPEE
		{
			internal Cell HKAGGPPNKIF;

			internal IEKBFJBLGFM AJLDJAHHGOJ;

			internal APBDPLNCDIJ CCPAJBOJDMN;

			internal BoosterManager PDAPIGLEPGC;

			internal void AGFNGEFDHLA()
			{
				Item item = null;
				if (HKAGGPPNKIF.EAILOFHFNJO)
				{
					item = HKAGGPPNKIF.LBFCDKPCDPB;
					item.SetExplodeDirection(AJLDJAHHGOJ);
				}
				CFOIPDKEFMM jHDMFHDHIFN = PDAPIGLEPGC.CurrentLevelBuilder.CurrentLevel.JHDMFHDHIFN;
				jHDMFHDHIFN.EJBPCMDJFEM(HKAGGPPNKIF, CCPAJBOJDMN);
				jHDMFHDHIFN.ELFBOKDHKGG.ELEHIDCIDJN.JIELGDKBBJP();
			}
		}

		public const int PreLevelUnlockLevel = 6;

		public const int HammerUnlockLevel = 9;

		public const int BoxingGloveUnlockLevel = 12;

		public const int AnvilUnlockLevel = 16;

		public EventBasedSpriteButton[] AllButtons;

		public LevelBuilder CurrentLevelBuilder;

		public GameObject CurrentTapListener;

		public GameObject CurrentBoosterTapListener;

		public GameObject TimeScaleScroller;

		public SpriteRenderer[] BoosterImages;

		public SpriteRenderer[] BoosterButtons;

		public SpriteRenderer[] LockImages;

		public TextMeshPro[] BoosterAmounts;

		public BoxCollider2D[] BoosterButtonColliders;

		public HammerBooster2D Hammer2D;

		public AnvilBooster Anvil;

		public BoxingGloveBooster BoxingGlove;

		public GameObject PaintBrush;

		public Transform HammerStartPosition;

		public Transform PaintBrushStartPosition;

		public BoosterUseBackgroundPanel BoosterBackground;

		public ParticleSystem BoosterUseParticle;

		public ParticleSystemRenderer[] GlowParticles;

		private KBKGBLJCDFL AJGPGBIEPJC = KBKGBLJCDFL.InGamePlay;

		public Action<NAAHKHPBAPA> OnItemClicked;

		public int BaseSortingOrder;

		public bool ButtonsLocked;

		private Sequence AOEJADOLAPJ;

		[CompilerGenerated]
		private static TweenCallback JANLDOMIIEF;

		public static int EOEHGMKBEHF
		{
			get
			{
				return (!FNBPLBGNBNF.DMHOKIGLECN()) ? 19 : 18;
			}
		}

		public void ChangeParticleSorting(int JIIFFBLNNOH, int CMAJLIAELDP)
		{
			int num = GlowParticles.Length;
			for (int i = 0; i < num; i++)
			{
				ParticleSystemRenderer particleSystemRenderer = GlowParticles[i];
				particleSystemRenderer.sortingLayerID = JIIFFBLNNOH;
				particleSystemRenderer.sortingOrder = BaseSortingOrder + CMAJLIAELDP;
			}
		}

		public void ShowTimeScale()
		{
			TimeScaleScroller.SetActive(!TimeScaleScroller.activeSelf);
		}

		public void Start()
		{
			TimeScaleScroller.SetActive(false);
			LODCCPNBHDD();
			UpdateBoosterCounts();
		}

		private void LODCCPNBHDD()
		{
			int num = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC();
			if (TutorialManager.ForceShowTutorials)
			{
				num = LevelBuilder.CurrentLevelNo;
			}
			JGNHLDBPFGA(0, num < 9);
			JGNHLDBPFGA(1, num < 16);
			JGNHLDBPFGA(2, num < 12);
			JGNHLDBPFGA(3, num < EOEHGMKBEHF);
		}

		private void JGNHLDBPFGA(int EHJNMODJEAN, bool MHDCKCCCBAM)
		{
			EHJNMODJEAN = Mathf.Clamp(EHJNMODJEAN, 0, 3);
			BoosterImages[EHJNMODJEAN].enabled = !MHDCKCCCBAM;
			BoosterButtonColliders[EHJNMODJEAN].enabled = !MHDCKCCCBAM;
			BoosterButtons[EHJNMODJEAN].gameObject.SetActive(!MHDCKCCCBAM);
			LockImages[EHJNMODJEAN].enabled = MHDCKCCCBAM;
			BoosterAmounts[EHJNMODJEAN].enabled = !MHDCKCCCBAM;
		}

		public void UpdateBoosterCounts()
		{
			BoosterAmounts[0].FCJBBPHFNPJ = ODIBKJLMJEJ(GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Hammer));
			BoosterAmounts[1].FCJBBPHFNPJ = ODIBKJLMJEJ(GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Anvil));
			BoosterAmounts[2].FCJBBPHFNPJ = ODIBKJLMJEJ(GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.BoxingGlove));
			BoosterAmounts[3].FCJBBPHFNPJ = ODIBKJLMJEJ(GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Dice));
		}

		private static string ODIBKJLMJEJ(int AAIEJDNAODP)
		{
			return (AAIEJDNAODP > 0) ? AAIEJDNAODP.ToString() : "+";
		}

		private void KNIGGOPNGHD(NAAHKHPBAPA HBBIFNLDKPO)
		{
			BoosterTapListener.Instance.DecreaseBlockRequests();
			UpdateBoosterCounts();
			switch (HBBIFNLDKPO)
			{
			case NAAHKHPBAPA.Anvil:
				OOALGGLKKNM(NAAHKHPBAPA.Anvil, KBKGBLJCDFL.InAnvil);
				break;
			case NAAHKHPBAPA.BoxingGlove:
				OOALGGLKKNM(NAAHKHPBAPA.BoxingGlove, KBKGBLJCDFL.InBoxingGlove);
				break;
			case NAAHKHPBAPA.Hammer:
				OOALGGLKKNM(NAAHKHPBAPA.Hammer, KBKGBLJCDFL.InHammer);
				break;
			case NAAHKHPBAPA.Dice:
				OOALGGLKKNM(NAAHKHPBAPA.Dice, KBKGBLJCDFL.InShuffle);
				break;
			case NAAHKHPBAPA.PaintBrush:
				OOALGGLKKNM(NAAHKHPBAPA.PaintBrush, KBKGBLJCDFL.InPaintBrushState);
				break;
			}
		}

		private void LOMGPDPGFHD(NAAHKHPBAPA HBBIFNLDKPO)
		{
			GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.BuyResourcesDialog, false);
			BuyResourcesDialog component = gameObject.GetComponent<BuyResourcesDialog>();
			if (!(component == null))
			{
				BoosterTapListener.Instance.IncreaseBlockRequests();
				component.SetResourceItem(HBBIFNLDKPO, BOKGFGFPOHD.DNCLFKKHEPL(HBBIFNLDKPO), KNIGGOPNGHD);
			}
		}

		internal void OINIFNCLAGA()
		{
			int i = 0;
			for (int num = AllButtons.Length; i < num; i++)
			{
				EventBasedSpriteButton eventBasedSpriteButton = AllButtons[i];
				eventBasedSpriteButton.EnableButton();
			}
		}

		internal void EBMPIHFCAMC(bool BKHMHGHGHIP)
		{
			int i = 0;
			for (int num = AllButtons.Length; i < num; i++)
			{
				EventBasedSpriteButton eventBasedSpriteButton = AllButtons[i];
				eventBasedSpriteButton.DisableButton(BKHMHGHGHIP);
			}
		}

		private void OOALGGLKKNM(NAAHKHPBAPA HBBIFNLDKPO, KBKGBLJCDFL BGEDKGLJIGM)
		{
			if (ButtonsLocked || FallManager.AreFallsBlocked() || FallManager.AreThereFallingItems() || FallManager.AreThereMechanicAnimations())
			{
				return;
			}
			if (OnItemClicked != null)
			{
				OnItemClicked(HBBIFNLDKPO);
			}
			if (CurrentLevelBuilder.CurrentLevel.EBMFPDNPIEM <= 0 || CurrentLevelBuilder.CurrentLevel.NPMIKDPNBIA || CurrentLevelBuilder.CurrentLevel.CELPAPAMMFK() || NLMLKADGECN.GABGKBAKHDP.BPHMPBKJJOO().LBGEOEHBJNF() > 0)
			{
				return;
			}
			if (GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(HBBIFNLDKPO) > 0)
			{
				if (AJGPGBIEPJC != KBKGBLJCDFL.Busy)
				{
					if (AJGPGBIEPJC == BGEDKGLJIGM)
					{
						BOPLAAOMFMA();
						JKMIEGCIHIJ();
					}
					else
					{
						HGKBCEGKHJD(HBBIFNLDKPO, BGEDKGLJIGM);
					}
				}
			}
			else
			{
				LOMGPDPGFHD(HBBIFNLDKPO);
			}
		}

		public bool ShouldCancellSelectedItem()
		{
			if (AJGPGBIEPJC == KBKGBLJCDFL.InGamePlay || AJGPGBIEPJC == KBKGBLJCDFL.Busy)
			{
				return false;
			}
			BOPLAAOMFMA();
			JKMIEGCIHIJ();
			return true;
		}

		public void HammerClicked()
		{
			OOALGGLKKNM(NAAHKHPBAPA.Hammer, KBKGBLJCDFL.InHammer);
		}

		public void AnvilClicked()
		{
			OOALGGLKKNM(NAAHKHPBAPA.Anvil, KBKGBLJCDFL.InAnvil);
		}

		public void BoxingGloveClicked()
		{
			OOALGGLKKNM(NAAHKHPBAPA.BoxingGlove, KBKGBLJCDFL.InBoxingGlove);
		}

		public void PaintBrushClicked()
		{
		}

		public void ShuffleClicked()
		{
			OOALGGLKKNM(NAAHKHPBAPA.Dice, KBKGBLJCDFL.InShuffle);
		}

		public void CellTapped(Cell LBHDELJBONF)
		{
			if (LBHDELJBONF.Exists && (LBHDELJBONF.HasCellItem() || (LBHDELJBONF.EAILOFHFNJO && !LBHDELJBONF.LBFCDKPCDPB.IsSpecialItem() && (AJGPGBIEPJC != KBKGBLJCDFL.InShuffle || LBHDELJBONF.LBFCDKPCDPB.CanShuffle()))))
			{
				JFPJHFFHBDO(LBHDELJBONF);
			}
		}

		private void JFPJHFFHBDO(Cell LBHDELJBONF)
		{
			if (LBHDELJBONF.HasCellItem() || (LBHDELJBONF.EAILOFHFNJO && (AJGPGBIEPJC != 0 || LBHDELJBONF.LBFCDKPCDPB.BoosterHammerCanBeUsed()) && (AJGPGBIEPJC != KBKGBLJCDFL.InAnvil || LBHDELJBONF.LBFCDKPCDPB.BoosterAnvilCanBeUsed()) && (AJGPGBIEPJC != KBKGBLJCDFL.InBoxingGlove || LBHDELJBONF.LBFCDKPCDPB.BoosterBoxingGloveCanBeUsed())))
			{
				BoosterBackground.Hide();
				BoosterUseParticle.Stop();
				BoosterUseParticle.gameObject.SetActive(false);
				JKMIEGCIHIJ();
				string jOMMFPHFDIG = string.Empty;
				switch (AJGPGBIEPJC)
				{
				case KBKGBLJCDFL.InHammer:
					StartCoroutine(IHHFDFJFGOF(LBHDELJBONF));
					jOMMFPHFDIG = "Hammer";
					break;
				case KBKGBLJCDFL.InAnvil:
					StartCoroutine(GOBGKLDHOPE(LBHDELJBONF));
					jOMMFPHFDIG = "Anvil";
					break;
				case KBKGBLJCDFL.InBoxingGlove:
					StartCoroutine(LCLNFJNMLPN(LBHDELJBONF));
					jOMMFPHFDIG = "BoxingGlove";
					break;
				case KBKGBLJCDFL.InShuffle:
					StartCoroutine(BONBBNAAGAM(LBHDELJBONF));
					jOMMFPHFDIG = "Dice";
					break;
				case KBKGBLJCDFL.InPaintBrushState:
					jOMMFPHFDIG = "PaintBrush";
					StartCoroutine(OAIJOOKIDDJ(LBHDELJBONF));
					break;
				default:
					BOPLAAOMFMA();
					break;
				}
				AFJPGLHKOID.IJPMIOFMCPJ(jOMMFPHFDIG);
				FallManager.StartRunning();
			}
		}

		private void BOPLAAOMFMA()
		{
			try
			{
				SettingsPanel.Instance.DLBLNHBHKHN();
				AJGPGBIEPJC = KBKGBLJCDFL.InGamePlay;
				CurrentBoosterTapListener.SetActive(false);
				CurrentTapListener.SetActive(true);
				HintManager.Instance.EnableHints();
				BoosterBackground.Hide();
				BoosterUseParticle.Stop();
				BoosterUseParticle.gameObject.SetActive(false);
				for (int i = 0; i < BoosterButtonColliders.Length; i++)
				{
					BoosterButtonColliders[i].enabled = true;
				}
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.BoosterManager, "There is an error while switching to game play. Reason is most likely returning to map scene while the booster animation is playing. Error:{0} Stack:{1}", ex.Message, ex.StackTrace);
			}
		}

		private void JKMIEGCIHIJ()
		{
			for (int i = 0; i < BoosterButtons.Length; i++)
			{
				BoosterButtons[i].sortingOrder = BaseSortingOrder + 5;
			}
			for (int j = 0; j < BoosterImages.Length; j++)
			{
				BoosterImages[j].sortingOrder = BaseSortingOrder + 6;
			}
		}

		private void HGKBCEGKHJD(NAAHKHPBAPA HBBIFNLDKPO, KBKGBLJCDFL BGEDKGLJIGM)
		{
			SettingsPanel.Instance.IAOFDBFPKPJ();
			AJGPGBIEPJC = BGEDKGLJIGM;
			CurrentBoosterTapListener.SetActive(true);
			CurrentTapListener.SetActive(false);
			HintManager.Instance.DisableHints();
			BoosterBackground.Show(HBBIFNLDKPO);
			int num = 0;
			switch (HBBIFNLDKPO)
			{
			case NAAHKHPBAPA.Hammer:
				num = 0;
				break;
			case NAAHKHPBAPA.Anvil:
				num = 1;
				break;
			case NAAHKHPBAPA.BoxingGlove:
				num = 2;
				break;
			case NAAHKHPBAPA.Dice:
				num = 3;
				break;
			case NAAHKHPBAPA.PaintBrush:
				num = 4;
				break;
			}
			if (num >= BoosterImages.Length || BoosterImages[num] == null)
			{
				return;
			}
			BoosterButtons[num].sortingOrder = BaseSortingOrder + 301;
			BoosterImages[num].sortingOrder = BaseSortingOrder + 302;
			Vector3 localPosition = BoosterButtons[num].transform.parent.localPosition;
			localPosition.x -= 0.025f;
			localPosition.y = 0.43f;
			BoosterUseParticle.gameObject.SetActive(true);
			BoosterUseParticle.transform.localPosition = localPosition;
			BoosterUseParticle.Play();
			for (int i = 0; i < BoosterButtonColliders.Length; i++)
			{
				if (i != num)
				{
					BoosterButtonColliders[i].enabled = false;
				}
			}
		}

		private IEnumerator BONBBNAAGAM(Cell LBHDELJBONF)
		{
			if (!LBHDELJBONF.EAILOFHFNJO || !LBHDELJBONF.LBFCDKPCDPB.CanShuffle())
			{
				BOPLAAOMFMA();
				yield break;
			}
			if (!ShuffleManager.TryShuffle(CurrentLevelBuilder.CurrentLevel.JHDMFHDHIFN) || !GEBAAFFGKJG.GABGKBAKHDP.DCAKPPKFOEP(NAAHKHPBAPA.Dice, 1, false))
			{
				BOPLAAOMFMA();
				yield break;
			}
			LevelBuilder.Recorder.FJOBHOMJDBH(LBHDELJBONF.X, LBHDELJBONF.Y, NAAHKHPBAPA.Dice);
			UpdateBoosterCounts();
			CurrentLevelBuilder.CurrentLevel.CFDBAMKOABO[NAAHKHPBAPA.Dice]++;
			CurrentLevelBuilder.CurrentLevel.KEAEBEGPDKP();
			CurrentBoosterTapListener.SetActive(false);
			AJGPGBIEPJC = KBKGBLJCDFL.Busy;
			FallManager.IncreaseWaitingFallBlocker();
			yield return new WaitForSeconds(0.9f);
			BOPLAAOMFMA();
			FallManager.DecreaseWaitingFallBlocker();
			yield return null;
		}

		private IEnumerator IHHFDFJFGOF(Cell LBHDELJBONF)
		{
			if ((LBHDELJBONF.EAILOFHFNJO && LBHDELJBONF.LBFCDKPCDPB.BoosterHammerCanBeUsed()) || LBHDELJBONF.HasCellItem())
			{
				if (!GEBAAFFGKJG.GABGKBAKHDP.DCAKPPKFOEP(NAAHKHPBAPA.Hammer, 1, false))
				{
					BOPLAAOMFMA();
					yield break;
				}
				LevelBuilder.Recorder.FJOBHOMJDBH(LBHDELJBONF.X, LBHDELJBONF.Y, NAAHKHPBAPA.Hammer);
				UpdateBoosterCounts();
				CurrentLevelBuilder.CurrentLevel.CFDBAMKOABO[NAAHKHPBAPA.Hammer]++;
				CurrentLevelBuilder.CurrentLevel.KEAEBEGPDKP();
				CurrentBoosterTapListener.SetActive(false);
				AJGPGBIEPJC = KBKGBLJCDFL.Busy;
				FallManager.IncreaseWaitingFallBlocker();
				yield return null;
				Hammer2D.transform.position = HammerStartPosition.position;
				if (AOEJADOLAPJ != null)
				{
					AOEJADOLAPJ.Kill();
				}
				Hammer2D.gameObject.SetActive(true);
				Hammer2D.HitAnimator.gameObject.SetActive(true);
				CFOIPDKEFMM CLCHKLJBIFH = CurrentLevelBuilder.CurrentLevel.JHDMFHDHIFN;
				Vector3 lDMDBPLADGD = LBHDELJBONF.GetFrozenPosition();
				APBDPLNCDIJ CCPAJBOJDMN = MLENMAIAOHJ.BDAKKAIBMIM(3);
				if (!LBHDELJBONF.HasCellItem() && LBHDELJBONF.EAILOFHFNJO && LBHDELJBONF.LBFCDKPCDPB.GetMasterTarget() != null)
				{
					lDMDBPLADGD = LBHDELJBONF.LBFCDKPCDPB.GetMasterTarget().transform.position + LBHDELJBONF.LBFCDKPCDPB.GetCenterPositionOffset(CCPAJBOJDMN);
				}
				IEnumerator enumerator = Hammer2D.PlayIn(lDMDBPLADGD, delegate
				{
					if (LBHDELJBONF.EAILOFHFNJO)
					{
						LBHDELJBONF.LBFCDKPCDPB.SetExplodeDirection(IEKBFJBLGFM.None);
					}
					CLCHKLJBIFH.EJBPCMDJFEM(LBHDELJBONF, CCPAJBOJDMN);
				});
				while (enumerator.MoveNext())
				{
					yield return enumerator.Current;
				}
				CLCHKLJBIFH.ELFBOKDHKGG.ELEHIDCIDJN.JIELGDKBBJP();
				yield return new WaitForSeconds(0.400333f);
				AudioManager.Play(KOOGPFAPGGD.BoosterHammerExit);
				AOEJADOLAPJ = DOTween.Sequence();
				AOEJADOLAPJ.AppendCallback(delegate
				{
					AudioManager.Play(KOOGPFAPGGD.BoosterHammerExit);
				});
				Vector3 position = HammerStartPosition.position;
				position.x -= 1.23f;
				position.y -= 0.7401493f;
				AOEJADOLAPJ.Append(Hammer2D.transform.DOMove(position, 0.5f).SetEase(Ease.InBack));
				AOEJADOLAPJ.AppendCallback(delegate
				{
					Hammer2D.HitAnimator.SetTrigger("Idle");
					Hammer2D.HitAnimator.gameObject.SetActive(false);
					BOPLAAOMFMA();
				});
				AOEJADOLAPJ.AppendInterval(1f);
				AOEJADOLAPJ.AppendCallback(delegate
				{
					Hammer2D.gameObject.SetActive(false);
					AOEJADOLAPJ = null;
				});
				yield return null;
				FallManager.DecreaseWaitingFallBlocker();
			}
			yield return null;
		}

		private IEnumerator GOBGKLDHOPE(Cell LBHDELJBONF)
		{
			if (LBHDELJBONF.HasCellItem() || (LBHDELJBONF.EAILOFHFNJO && LBHDELJBONF.LBFCDKPCDPB.BoosterAnvilCanBeUsed()))
			{
				if (!GEBAAFFGKJG.GABGKBAKHDP.DCAKPPKFOEP(NAAHKHPBAPA.Anvil, 1, false))
				{
					BOPLAAOMFMA();
					yield break;
				}
				LevelBuilder.Recorder.FJOBHOMJDBH(LBHDELJBONF.X, LBHDELJBONF.Y, NAAHKHPBAPA.Anvil);
				UpdateBoosterCounts();
				CurrentLevelBuilder.CurrentLevel.CFDBAMKOABO[NAAHKHPBAPA.Anvil]++;
				CurrentLevelBuilder.CurrentLevel.KEAEBEGPDKP();
				CurrentBoosterTapListener.SetActive(false);
				AJGPGBIEPJC = KBKGBLJCDFL.Busy;
				FallManager.IncreaseWaitingFallBlocker();
				yield return null;
				Vector3 frozenPosition = LBHDELJBONF.GetFrozenPosition();
				frozenPosition.y = 7f;
				Vector3 endValue = frozenPosition;
				endValue.y = ONCMBJKLKIL.HINDAIPFFJL.y;
				CFOIPDKEFMM jHDMFHDHIFN = CurrentLevelBuilder.CurrentLevel.JHDMFHDHIFN;
				Vector3 frozenPosition2 = jHDMFHDHIFN.ECNCPJGHBIG(LBHDELJBONF.X, jHDMFHDHIFN.FHAMOHDEGMK - 1).GetFrozenPosition();
				frozenPosition2.y += 1.6f;
				float num = frozenPosition.y - frozenPosition2.y;
				Anvil.transform.position = frozenPosition;
				Anvil.gameObject.SetActive(true);
				AudioManager.Play(KOOGPFAPGGD.BoosterAnvil);
				Anvil.TrailSmokeParticle.Play();
				Anvil.AnvilSpriteRenderer.enabled = true;
				Sequence sequence = DOTween.Sequence();
				sequence.SetEase(Ease.InCubic);
				sequence.Append(Anvil.transform.DOMoveY(frozenPosition2.y, num * 0.1f).SetEase(Ease.Linear));
				APBDPLNCDIJ cCPAJBOJDMN = MLENMAIAOHJ.BDAKKAIBMIM(5);
				for (int num2 = jHDMFHDHIFN.FHAMOHDEGMK - 1; num2 >= 0; num2--)
				{
					Cell cell = jHDMFHDHIFN.ECNCPJGHBIG(LBHDELJBONF.X, num2);
					sequence.Append(Anvil.transform.DOMoveY(cell.GetFrozenPosition().y + 0.6f, 0.1f).SetEase(Ease.Linear));
					if (cell.HasCellItem() || (cell.EAILOFHFNJO && cell.LBFCDKPCDPB.CanBeExplodedByBooster()))
					{
						sequence.AppendCallback(FLLAFDDMGCN(cell, IEKBFJBLGFM.Up, cCPAJBOJDMN));
					}
				}
				sequence.Append(ShortcutExtensions.DOMove(duration: (jHDMFHDHIFN.ECNCPJGHBIG(LBHDELJBONF.X, 0).GetFrozenPosition().y - endValue.y) * 0.1f, target: Anvil.transform, endValue: endValue).SetEase(Ease.Linear));
				sequence.Goto(0.5f, true);
				yield return sequence.WaitForCompletion();
				Anvil.PlayHit();
				Anvil.gameObject.SetActive(false);
				IEnumerator waiter = Anvil.GetWaiter();
				while (waiter.MoveNext())
				{
					yield return waiter.Current;
				}
				yield return MCJHHDACJBG.CNDGGNLKOOC;
				FallManager.DecreaseWaitingFallBlocker();
				yield return null;
				while (FallManager.AreThereFallingItems())
				{
					yield return null;
				}
				BOPLAAOMFMA();
				yield return null;
			}
			yield return null;
		}

		private IEnumerator OAIJOOKIDDJ(Cell LBHDELJBONF)
		{
			if (LBHDELJBONF.EAILOFHFNJO && LBHDELJBONF.LBFCDKPCDPB.CanBeExplodedByBooster() && LBHDELJBONF.LBFCDKPCDPB.CanBePaint())
			{
				GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.PaintBrushDialog, false);
				PaintBrushDialog component = gameObject.GetComponent<PaintBrushDialog>();
				CurrentBoosterTapListener.SetActive(false);
				while (!component.IsCloseHappened())
				{
					yield return null;
				}
				if (component.NODFACBNKIF())
				{
					if (!GEBAAFFGKJG.GABGKBAKHDP.DCAKPPKFOEP(NAAHKHPBAPA.PaintBrush, 1, false))
					{
						BOPLAAOMFMA();
						yield break;
					}
					UpdateBoosterCounts();
					CurrentLevelBuilder.CurrentLevel.KEAEBEGPDKP();
					AJGPGBIEPJC = KBKGBLJCDFL.Busy;
					FallManager.IncreaseWaitingFallBlocker();
					yield return null;
					PaintBrush.transform.position = PaintBrushStartPosition.position;
					PaintBrush.SetActive(true);
					Sequence sequence = DOTween.Sequence();
					sequence.Append(PaintBrush.transform.DOMove(LBHDELJBONF.GetFrozenPosition(), 0.2f));
					sequence.SetEase(Ease.OutSine);
					yield return sequence.WaitForCompletion();
					PaintBrush.SetActive(false);
					if (LBHDELJBONF.LBFCDKPCDPB.CanBePaint())
					{
						((CAAODJJHLLJ)LBHDELJBONF.LBFCDKPCDPB).Paint(component.NEPCLOBAFEG());
					}
					yield return null;
					FallManager.DecreaseWaitingFallBlocker();
				}
				BOPLAAOMFMA();
			}
			yield return null;
		}

		private IEnumerator LCLNFJNMLPN(Cell LBHDELJBONF)
		{
			if (LBHDELJBONF.HasCellItem() || (LBHDELJBONF.EAILOFHFNJO && LBHDELJBONF.LBFCDKPCDPB.BoosterBoxingGloveCanBeUsed()))
			{
				if (!GEBAAFFGKJG.GABGKBAKHDP.DCAKPPKFOEP(NAAHKHPBAPA.BoxingGlove, 1, false))
				{
					BOPLAAOMFMA();
					yield break;
				}
				LevelBuilder.Recorder.FJOBHOMJDBH(LBHDELJBONF.X, LBHDELJBONF.Y, NAAHKHPBAPA.BoxingGlove);
				UpdateBoosterCounts();
				CurrentLevelBuilder.CurrentLevel.CFDBAMKOABO[NAAHKHPBAPA.BoxingGlove]++;
				CurrentLevelBuilder.CurrentLevel.KEAEBEGPDKP();
				CurrentBoosterTapListener.SetActive(false);
				AJGPGBIEPJC = KBKGBLJCDFL.Busy;
				FallManager.IncreaseWaitingFallBlocker();
				yield return null;
				Vector3 frozenPosition = LBHDELJBONF.GetFrozenPosition();
				Vector3 position = frozenPosition;
				position.x = -7f;
				CFOIPDKEFMM jHDMFHDHIFN = CurrentLevelBuilder.CurrentLevel.JHDMFHDHIFN;
				Vector3 frozenPosition2 = jHDMFHDHIFN.ECNCPJGHBIG(0, LBHDELJBONF.Y).GetFrozenPosition();
				frozenPosition2.x -= 2.2f;
				float num = frozenPosition2.x - position.x;
				BoxingGlove.transform.position = position;
				BoxingGlove.gameObject.SetActive(true);
				float num2 = 0.04f;
				Sequence sequence = DOTween.Sequence();
				sequence.SetEase(Ease.Linear);
				sequence.Append(BoxingGlove.transform.DOMove(frozenPosition2, num * num2).SetEase(Ease.Linear));
				APBDPLNCDIJ cCPAJBOJDMN = MLENMAIAOHJ.BDAKKAIBMIM(4);
				for (int i = 0; i < jHDMFHDHIFN.EMFKAPJMDCC; i++)
				{
					Cell cell = jHDMFHDHIFN.ECNCPJGHBIG(i, LBHDELJBONF.Y);
					Vector3 frozenPosition3 = cell.GetFrozenPosition();
					frozenPosition3.x -= 1.2f;
					sequence.Append(BoxingGlove.transform.DOMove(frozenPosition3, num2).SetEase(Ease.Linear));
					if (cell.HasCellItem() || (cell.EAILOFHFNJO && cell.LBFCDKPCDPB.CanBeExplodedByBooster()))
					{
						sequence.AppendCallback(FLLAFDDMGCN(cell, IEKBFJBLGFM.Left, cCPAJBOJDMN));
					}
				}
				Tweener tweener = BoxingGlove.transform.DOMoveX(ONCMBJKLKIL.ABDNNJLJKJD.x - 1f, 0.4f);
				tweener.SetEase(Ease.OutElastic);
				tweener.easeOvershootOrAmplitude = 1f;
				sequence.Append(tweener);
				sequence.InsertCallback(sequence.Duration(false) - 0.35f, BoxingGlove.ShakeScreen);
				sequence.AppendInterval(0.1f);
				sequence.AppendCallback(BoxingGlove.PlayAnimationOut);
				sequence.Append(BoxingGlove.transform.DOMove(new Vector3(ONCMBJKLKIL.JDBOMLADPFF.x - 1f, frozenPosition.y, frozenPosition.z), 0.7f).SetEase(Ease.InQuart));
				sequence.AppendCallback(FallManager.DecreaseWaitingFallBlocker);
				BoxingGlove.PlayAnimationIn(num2 * (float)jHDMFHDHIFN.EMFKAPJMDCC + 0.2f);
				yield return sequence.WaitForCompletion();
				BoxingGlove.gameObject.SetActive(false);
				BOPLAAOMFMA();
				yield return null;
			}
			yield return null;
		}

		private TweenCallback FLLAFDDMGCN(Cell HKAGGPPNKIF, IEKBFJBLGFM AJLDJAHHGOJ, APBDPLNCDIJ CCPAJBOJDMN)
		{
			return delegate
			{
				Item item = null;
				if (HKAGGPPNKIF.EAILOFHFNJO)
				{
					item = HKAGGPPNKIF.LBFCDKPCDPB;
					item.SetExplodeDirection(AJLDJAHHGOJ);
				}
				CFOIPDKEFMM jHDMFHDHIFN = CurrentLevelBuilder.CurrentLevel.JHDMFHDHIFN;
				jHDMFHDHIFN.EJBPCMDJFEM(HKAGGPPNKIF, CCPAJBOJDMN);
				jHDMFHDHIFN.ELFBOKDHKGG.ELEHIDCIDJN.JIELGDKBBJP();
			};
		}
	}
}
