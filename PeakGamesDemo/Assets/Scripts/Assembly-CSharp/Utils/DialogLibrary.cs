using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Utils
{
	public class DialogLibrary : MonoBehaviour
	{
		private const float DHLFHNJNFJF = 0.12f;

		private Tween BCGMNJJAKDD;

		private bool BIPIHACBDKN;

		public SpriteRenderer DialogBackground;

		public GameObject BuyCoinsBundleDialog;

		public GameObject PurchaseSuccessDialog;

		public GameObject PurchaseFailedDialog;

		public GameObject PurchaseRetryCompletedDialog;

		public GameObject[] EgoDialogs;

		public GameObject FacebookConnectedDialog;

		public GameObject FacebookConnectFailedDialog;

		public GameObject FacebookLogoutFailedDialog;

		public GameObject FacebookLogoutSuccededDialog;

		public GameObject FacebookLogoutConfirmationDialog;

		public GameObject GoalsBannerDialog;

		public GameObject QuitDialog;

		public GameObject LostDialog;

		public GameObject WinDialog;

		public GameObject BuyResourcesDialog;

		public GameObject PaintBrushDialog;

		public GameObject PrelevelDialog;

		public GameObject NoLivesLeftGamePlayDialog;

		public GameObject NoLivesLeftMapDialog;

		public GameObject NoConnectionDialog;

		public GameObject NoPossibleMovesDialog;

		public GameObject SupportTicketDialog;

		public GameObject SupportFailedDialog;

		public GameObject SupportSuccessDialog;

		public GameObject BoosterUnlockedDialog;

		public GameObject ToonChestDialog;

		public GameObject StarChestDialog;

		public GameObject MoreLevelsDialog;

		public GameObject ChestInfoDialog;

		public GameObject StarChestInfoDialog;

		public GameObject RateUsDialog;

		public GameObject SocialCreateUserDialog;

		public GameObject SocialLeaveTeamDialog;

		public GameObject SocialChangeTeamDialog;

		public GameObject SocialTeamInfoJoinDialog;

		public GameObject SocialSelectBadgeDialog;

		public GameObject SocialConfirmKickDialog;

		public GameObject SocialTeamInfoDialog;

		public GameObject SettingsDialog;

		public GameObject TeamEditDialog;

		public GameObject NewLevelsDialog;

		public GameObject EpisodeNavigationDialog;

		public GameObject EpisodeUnlockedDialog;

		public GameObject ChatReportConfirmationDialog;

		public GameObject CLPrelevelDialog;

		public GameObject CLEnterenceDialog;

		public GameObject CLLeaderboardDialog;

		public GameObject CLRewardsDialog;

		public GameObject CLWinDialog;

		public GameObject CLLostDialog;

		public GameObject CLNoPossibleMovesDialog;

		public GameObject DeviceBanDialog;

		public GameObject LifeHackDialog;

		public GameObject CrownRushInfoDialog;

		public GameObject DailyBonusDialog;

		public GameObject TeamChestInfoDialog;

		public GameObject TeamChestJoinTeamDialog;

		public GameObject TeamChestDialog;

		public GameObject TreasureHuntInfoDialog;

		public GameObject TreasureHuntDialog;

		public GameObject ChangeNameUserDialog;

		public GameObject StarTournamentInfoDialog;

		public GameObject StarTournamentResultDialog;

		public GameObject StarTournamentRewardsDialog;

		public GameObject StarTournamentCreateUserDialog;

		public GameObject StarTournamentAnnouncementDialog;

		public GameObject TeamTournamentAnnouncementDialog;

		public GameObject TeamTournamentInfoDialog;

		public GameObject TeamTournamentRewardDialog;

		public GameObject CalendarOpenDialog;

		public GameObject CalendarGiftDialog;

		public static DialogLibrary GABGKBAKHDP { get; private set; }

		public void Awake()
		{
			GABGKBAKHDP = this;
		}

		public void Start()
		{
			DialogBackground.transform.localScale = new Vector3(ONCMBJKLKIL.EMFKAPJMDCC, ONCMBJKLKIL.FHAMOHDEGMK, 1f);
		}

		private void OnDestroy()
		{
			GABGKBAKHDP = null;
		}

		public void ShowDialogBackgroundFast()
		{
			if (!BIPIHACBDKN)
			{
				BIPIHACBDKN = true;
				if (BCGMNJJAKDD != null && BCGMNJJAKDD.IsPlaying())
				{
					BCGMNJJAKDD.Kill();
				}
				DialogBackground.enabled = true;
				DialogBackground.color = new Color(0f, 0f, 0f, 0.8f);
			}
		}

		public void ShowDialogBackground(bool MPBOICALAMG = false, float FMPBJJMKCIG = 0.12f, float DKIPEJPGACG = 0f)
		{
			if (!BIPIHACBDKN)
			{
				BIPIHACBDKN = true;
				if (BCGMNJJAKDD != null && BCGMNJJAKDD.IsPlaying())
				{
					BCGMNJJAKDD.Kill();
				}
				else
				{
					DialogBackground.color = new Color(0f, 0f, 0f, 0f);
				}
				DialogBackground.enabled = true;
				BCGMNJJAKDD = DialogBackground.DOColor(new Color(0f, 0f, 0f, (!MPBOICALAMG) ? 0.8f : 0.2f), FMPBJJMKCIG).SetDelay(DKIPEJPGACG).OnComplete(delegate
				{
					BCGMNJJAKDD = null;
				});
			}
		}

		public void DarkenBackground()
		{
			DialogBackground.DOColor(new Color(0f, 0f, 0f, 0.89f), 0.12f);
		}

		public void SetBackgroundColor(float HIMINGHNIKN, float FMPBJJMKCIG)
		{
			DialogBackground.DOKill();
			DialogBackground.DOColor(new Color(0f, 0f, 0f, HIMINGHNIKN), FMPBJJMKCIG);
		}

		public void HideDialogBackground()
		{
			if (BIPIHACBDKN)
			{
				BIPIHACBDKN = false;
				if (BCGMNJJAKDD != null && BCGMNJJAKDD.IsPlaying())
				{
					BCGMNJJAKDD.Kill();
				}
				BCGMNJJAKDD = DialogBackground.DOColor(new Color(0f, 0f, 0f, 0f), 0.12f);
				BCGMNJJAKDD.OnComplete(delegate
				{
					DialogBackground.enabled = false;
					BCGMNJJAKDD = null;
				});
			}
		}

		[CompilerGenerated]
		private void NIMLOLFEOGM()
		{
			BCGMNJJAKDD = null;
		}

		[CompilerGenerated]
		private void DMCPGIKCDHL()
		{
			DialogBackground.enabled = false;
			BCGMNJJAKDD = null;
		}
	}
}
