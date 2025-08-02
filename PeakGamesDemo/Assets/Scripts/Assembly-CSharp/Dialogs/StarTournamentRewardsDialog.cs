using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.MapScene;
using Assets.Scripts.Utils.Analytics;
using EventsManagers;
using NewMapScene;
using TMPro;
using UnityEngine;

namespace Dialogs
{
	public class StarTournamentRewardsDialog : StarTournamentDialog
	{
		[CompilerGenerated]
		private sealed class CLKDHBAAJGP
		{
			internal NAAHKHPBAPA GEKKLIKPAPP;

			internal StarTournamentRewardsDialog PDAPIGLEPGC;

			internal void AGFNGEFDHLA(bool EEKJMDHEJCK)
			{
				PDAPIGLEPGC.Blocker.SetActive(false);
				PDAPIGLEPGC.LoadingIndicator.SetActive(false);
				if (EEKJMDHEJCK)
				{
					int aCFDIDGFPKJ = GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(GEKKLIKPAPP, PDAPIGLEPGC.MLHENHABGMO.amount);
					if (GEKKLIKPAPP == NAAHKHPBAPA.Coins)
					{
						PDAPIGLEPGC.JBJKNCHCDOK = PDAPIGLEPGC.JCOKJJGCPHI;
						GEBAAFFGKJG.GABGKBAKHDP.NPGEJMKGJON(aCFDIDGFPKJ);
						PDAPIGLEPGC.SetOnDialogClosedCallback(PDAPIGLEPGC.MBEBGNDIKCM);
					}
					else if (GEKKLIKPAPP.LGOKFILDDDD() || GEKKLIKPAPP.MCMDJCBFENO())
					{
						PDAPIGLEPGC.JBJKNCHCDOK = PDAPIGLEPGC.JCOKJJGCPHI;
						PDAPIGLEPGC.SetOnDialogClosedCallback(PDAPIGLEPGC.FICFHHEBEDO);
					}
					PDAPIGLEPGC.NANPEDFGNEP();
				}
				else
				{
					PEHKLPAIBDN();
				}
				PDAPIGLEPGC.Close();
			}
		}

		public static bool DialogActive;

		public static bool ShouldCallGetEventsCommand;

		public SpriteMask CurrentSpriteMask;

		public Transform BottomButtonTransform;

		public TextMeshPro ButtonText;

		public GameObject Blocker;

		private bool EKCINKDJPDI;

		private Action JBJKNCHCDOK;

		private bool INJLCJLDNKC
		{
			get
			{
				return MLHENHABGMO != null && GANLPJDONMH != null && GANLPJDONMH.AEPLIGFCGIF == 2 && GANLPJDONMH.AEBACBBGHKI <= 0;
			}
		}

		protected override void DIOELAHNLKJ()
		{
			EOBFKOKGDCP = -0.18f;
			ButtonText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Continue");
			if (ONCMBJKLKIL.KLEKJMEOPEH)
			{
				float num = 1.7787265f * ONCMBJKLKIL.EMFKAPJMDCC;
				float num2 = (ONCMBJKLKIL.FHAMOHDEGMK - num) * 0.3f;
				Vector2 size = new Vector2(BackgroundLeft.size.x, 14.05168f + num2);
				BottomScrollMask.transform.localPosition = new Vector3(0f, -7.92f - num2, 0f);
				BackgroundLeft.size = size;
				BackgroundRight.size = size;
				BackgroundLeft.transform.localPosition = new Vector3(BackgroundLeft.transform.localPosition.x, 0.9483f - num2 * 0.5f, 0f);
				BackgroundRight.transform.localPosition = new Vector3(BackgroundRight.transform.localPosition.x, 0.9483f - num2 * 0.5f, 0f);
				Vector2 size2 = StarTournamentScrollController.ScrollArea.size;
				size2.y += num2;
				StarTournamentScrollController.ScrollArea.size = size2;
				Vector2 offset = StarTournamentScrollController.ScrollArea.offset;
				offset.y -= num2 * 0.5f;
				StarTournamentScrollController.ScrollArea.offset = offset;
				JNFMOMPFIGG = num2 * 0.5f;
				if (JKANNLPGLPJ != null)
				{
					StarTournamentScrollController.SetOffsets(0f - JNFMOMPFIGG, 0f - JNFMOMPFIGG);
					StarTournamentScrollController.SetContentSize(ANJBHOECJME);
					StarTournamentScrollController.ScrollToTop();
				}
				BottomButtonTransform.transform.localPosition = new Vector3(0f, -6.28f - num2);
				CurrentSpriteMask.MOFHAKELNPN = new Vector2(CurrentSpriteMask.MOFHAKELNPN.x, CurrentSpriteMask.MOFHAKELNPN.y + num2);
			}
		}

		public void PrepareDialog(Action IMHLFAHONPP, bool OKAGICINMBN)
		{
			SetOnDialogClosedCallback(IMHLFAHONPP);
			EKCINKDJPDI = OKAGICINMBN;
		}

		public override void DialogCreated()
		{
			DialogActive = true;
			base.DialogCreated();
			GANLPJDONMH = DGOMNDMPMBG.GABGKBAKHDP.IIEALLANECJ;
			if (GANLPJDONMH == null)
			{
				return;
			}
			KJFJPKMBCGJ();
			LoadingIndicator.SetActive(true);
			StRewardsJson stRewardsJson = GANLPJDONMH.COGMBHJAPNO();
			foreach (StRewardItem reward in stRewardsJson.rewards)
			{
				if (!INCCLAOPKJE.ContainsKey(reward.rank))
				{
					INCCLAOPKJE.Add(reward.rank, new List<StRewardItem>());
				}
				INCCLAOPKJE[reward.rank].Add(reward);
			}
		}

		private void KJFJPKMBCGJ()
		{
			List<IKDMCJPBBIH> list = new List<IKDMCJPBBIH>();
			if (ShouldCallGetEventsCommand)
			{
				list.Add(new KBBPGCKJHNJ());
			}
			list.Add(new ILCNNFKJEFG(GANLPJDONMH.INFAGKCBEHL, true, base.COCLEFIOIMB));
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(list);
			ShouldCallGetEventsCommand = false;
		}

		public override void OnDialogClosed()
		{
			DialogActive = false;
			if (JCOKJJGCPHI != null)
			{
				JCOKJJGCPHI();
			}
			base.OnDialogClosed();
		}

		protected override void AGEPABIDIJJ(string PDEKHNLNOLA, int JEAAHAFHDEG)
		{
			HINGKINONOC = JEAAHAFHDEG + 1;
			RankText.FCJBBPHFNPJ = "# " + HINGKINONOC;
		}

		protected override void GMIDPFIDMCL()
		{
			CurrentSpriteMask.update();
			MJHJLEBLKGI();
			if (INJLCJLDNKC)
			{
				ButtonText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Claim");
			}
			if (IAOPAOIEKKH != null)
			{
				float cAEMELGEOAE = (float)HINGKINONOC * 1.4f - 3.6881f - JNFMOMPFIGG * 2f;
				IAOPAOIEKKH.CDHEHPKLMFC(new Vector3(0f, -2.99f - JNFMOMPFIGG * 2f, 0f));
				IAOPAOIEKKH.NNODBGKBMLK(cAEMELGEOAE);
			}
		}

		public void OnClaimClick()
		{
			if (!KPFIBDEMEPB)
			{
				KFMJHIOKEBG();
			}
			else if (INJLCJLDNKC)
			{
				FACOFGIMPIM();
			}
			else
			{
				PNNHELCPGMM();
			}
		}

		private void KFMJHIOKEBG()
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "StarTournamentRewardsDialog closed wtihout any action because leaderboard data is not up to date.");
			PEHKLPAIBDN();
			Close();
		}

		private void FACOFGIMPIM()
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "StarTournamentRewardsDialog Claim clicked.");
			NAAHKHPBAPA GEKKLIKPAPP = (NAAHKHPBAPA)MLHENHABGMO.id;
			Blocker.SetActive(true);
			LoadingIndicator.SetActive(true);
			JBLHLNCOLHD();
			GANLPJDONMH.LCEPBBLJGCG(delegate(bool EEKJMDHEJCK)
			{
				Blocker.SetActive(false);
				LoadingIndicator.SetActive(false);
				if (EEKJMDHEJCK)
				{
					int aCFDIDGFPKJ = GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(GEKKLIKPAPP, MLHENHABGMO.amount);
					if (GEKKLIKPAPP == NAAHKHPBAPA.Coins)
					{
						JBJKNCHCDOK = JCOKJJGCPHI;
						GEBAAFFGKJG.GABGKBAKHDP.NPGEJMKGJON(aCFDIDGFPKJ);
						SetOnDialogClosedCallback(MBEBGNDIKCM);
					}
					else if (GEKKLIKPAPP.LGOKFILDDDD() || GEKKLIKPAPP.MCMDJCBFENO())
					{
						JBJKNCHCDOK = JCOKJJGCPHI;
						SetOnDialogClosedCallback(FICFHHEBEDO);
					}
					NANPEDFGNEP();
				}
				else
				{
					PEHKLPAIBDN();
				}
				Close();
			});
		}

		private void PNNHELCPGMM()
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "StarTournamentRewardsDialog Continue clicked.");
			if (GANLPJDONMH != null && GANLPJDONMH.AEBACBBGHKI <= 0)
			{
				GANLPJDONMH.KALEIGDLEAM();
				NANPEDFGNEP();
			}
			Close();
		}

		private static void PEHKLPAIBDN()
		{
			if (MapManager.Instance != null)
			{
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Connection"));
			}
		}

		private void MBEBGNDIKCM()
		{
			if (EKCINKDJPDI)
			{
				SpriteButtonListener.Instance.EnableClicks = false;
			}
			IJIMKNBDAKJ(MLHENHABGMO.amount, JBJKNCHCDOK);
		}

		private void FICFHHEBEDO()
		{
			if (EKCINKDJPDI)
			{
				SpriteButtonListener.Instance.EnableClicks = false;
			}
			FOLKKFOJFAG((NAAHKHPBAPA)MLHENHABGMO.id, MLHENHABGMO.amount, JBJKNCHCDOK);
		}

		private void FOLKKFOJFAG(NAAHKHPBAPA HBBIFNLDKPO, int NNIDKMJGAJO, Action IMHLFAHONPP)
		{
			MapUIAnimationController instance = MapUIAnimationController.Instance;
			if (instance == null)
			{
				if (IMHLFAHONPP != null)
				{
					IMHLFAHONPP();
				}
			}
			else
			{
				instance.StartRewardCollectAnimation(HBBIFNLDKPO, NNIDKMJGAJO, IMHLFAHONPP);
			}
		}

		private static void IJIMKNBDAKJ(int NNIDKMJGAJO, Action IMHLFAHONPP)
		{
			MapUIAnimationController instance = MapUIAnimationController.Instance;
			if (instance == null)
			{
				if (IMHLFAHONPP != null)
				{
					IMHLFAHONPP();
				}
			}
			else
			{
				instance.StartCoinCollectAnimation(NNIDKMJGAJO, IMHLFAHONPP, 20, NewMapPage.CoinAnimationStartPosition);
			}
		}

		private void NANPEDFGNEP()
		{
			JsonStarChestGifts jsonStarChestGifts = new JsonStarChestGifts();
			if (MLHENHABGMO != null)
			{
				switch ((NAAHKHPBAPA)MLHENHABGMO.id)
				{
				case NAAHKHPBAPA.Coins:
					jsonStarChestGifts.coin = MLHENHABGMO.amount;
					break;
				case NAAHKHPBAPA.Hammer:
					jsonStarChestGifts.hammer = MLHENHABGMO.amount;
					break;
				case NAAHKHPBAPA.Anvil:
					jsonStarChestGifts.anvil = MLHENHABGMO.amount;
					break;
				case NAAHKHPBAPA.BoxingGlove:
					jsonStarChestGifts.boxingglove = MLHENHABGMO.amount;
					break;
				case NAAHKHPBAPA.Rocket:
					jsonStarChestGifts.rocket = MLHENHABGMO.amount;
					break;
				case NAAHKHPBAPA.Bomb:
					jsonStarChestGifts.bomb = MLHENHABGMO.amount;
					break;
				case NAAHKHPBAPA.DiscoBall:
					jsonStarChestGifts.discoball = MLHENHABGMO.amount;
					break;
				case NAAHKHPBAPA.Dice:
					jsonStarChestGifts.dice = MLHENHABGMO.amount;
					break;
				case NAAHKHPBAPA.Life:
					jsonStarChestGifts.life_refill = 1;
					break;
				}
			}
			JsonInventory jsonInventory = new JsonInventory();
			jsonInventory.LDOCFEGBGNK();
			JsonLevelStarChest jsonLevelStarChest = new JsonLevelStarChest();
			jsonLevelStarChest.gifts = jsonStarChestGifts;
			jsonLevelStarChest.inventory = jsonInventory;
			JsonLevelStarChest jsonLevelStarChest2 = jsonLevelStarChest;
			jsonLevelStarChest2.LLGLAHKBJJG();
			AFJPGLHKOID.FIBBNCGGJFN(GANLPJDONMH.IFOAAOCJODG, GANLPJDONMH.OHAPPDGAKNG, jsonLevelStarChest2);
		}

		public override bool CanHandleBackButton()
		{
			return false;
		}

		public override bool CanCloseOnBlackPanelTouch()
		{
			return false;
		}
	}
}
