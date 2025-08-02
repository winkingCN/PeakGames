using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.MapScene;
using ToonSocial;
using UnityEngine;

namespace NewMapScene
{
	public class LeaderboardPageController : MonoBehaviour
	{
		public ContainerManager CurrentContainerManager;

		public SocialHelper CurrentSocialHelper;

		public SpriteRenderer BackgroundImage;

		public SpriteRenderer TabBackground;

		public FacebookLeaderboardTabPage CurrentFacebookLeaderboardTabPage;

		public TeamLeaderboardTabPage CurrentTeamLeaderboardTabPage;

		public PlayersLeaderboardTabPage CurrentPlayersLeaderboardTabPage;

		public GameObject LeaderboardButtons;

		public TabButton[] TabButtons;

		public TabPage[] TabPages;

		private bool PDPNCAJGGOD = true;

		private int PMCEPNAMKHC;

		private int KLIADEEDNAE;

		private bool EMIBENONFGP;

		private bool BIELEFAPPBF;

		public void SelectSharedLeaderboardTab(int OPLGNHEJBFJ)
		{
			BNEHCENOALD(OPLGNHEJBFJ, true);
		}

		public static string GetLocalizedCountry()
		{
			HJBLKNBHMFJ hJBLKNBHMFJ = HJBLKNBHMFJ.GABGKBAKHDP;
			string text = hJBLKNBHMFJ.LIANKDMAHFM("Country");
			if (text != null && text.Equals("Local"))
			{
				text = null;
			}
			return text ?? NKILHODNBDE.GHBGCADFLFB("LeaderboardLocal");
		}

		public static void UpdateLocalizedCountry(string KNFEMKNJIDI)
		{
			HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("Country", KNFEMKNJIDI);
		}

		private void Awake()
		{
			CurrentFacebookLeaderboardTabPage.Prepare();
			CurrentTeamLeaderboardTabPage.Prepare();
			CurrentPlayersLeaderboardTabPage.Prepare();
			CurrentFacebookLeaderboardTabPage.CurrentSocialHelper = CurrentSocialHelper;
			CurrentTeamLeaderboardTabPage.CurrentSocialHelper = CurrentSocialHelper;
			CurrentPlayersLeaderboardTabPage.CurrentSocialHelper = CurrentSocialHelper;
		}

		private void Start()
		{
			MapPageSizer currentMapPageSizer = MapManager.Instance.CurrentMapPageSizer;
			if (currentMapPageSizer.CurrentWidth > 0f)
			{
				HBEMDFJHICG(currentMapPageSizer.CurrentWidth);
			}
			else
			{
				currentMapPageSizer.PBNPBHCHODE += HBEMDFJHICG;
			}
			if (CurrentContainerManager != null)
			{
				CurrentContainerManager.IKHJGHKNFJM += IJDFOHAKHOM;
				CurrentContainerManager.HJOKHPIGEAM += AEKNDPOAMEB;
			}
		}

		public void OnDestroy()
		{
			BIELEFAPPBF = true;
			if (CurrentContainerManager != null)
			{
				CurrentContainerManager.IKHJGHKNFJM -= IJDFOHAKHOM;
			}
		}

		private void HBEMDFJHICG(float HHHMOGOKFHF)
		{
			float num = 0.23f;
			BackgroundImage.transform.localScale = new Vector3(ONCMBJKLKIL.EMFKAPJMDCC + 2f * num, ONCMBJKLKIL.FHAMOHDEGMK, 1f);
			CurrentFacebookLeaderboardTabPage.SetScrollColliderSize(HHHMOGOKFHF);
			CurrentTeamLeaderboardTabPage.SetScrollColliderSize(HHHMOGOKFHF);
			CurrentPlayersLeaderboardTabPage.SetScrollColliderSize(HHHMOGOKFHF);
			TabBackground.size = new Vector3(HHHMOGOKFHF, 1.8f);
		}

		private void IJDFOHAKHOM(EBMDNGEJJBO LDCFIGLFBOK)
		{
			if (LDCFIGLFBOK != EBMDNGEJJBO.Leaderboard)
			{
				CurrentFacebookLeaderboardTabPage.ScrollController.ScrollToTop();
				CurrentFacebookLeaderboardTabPage.Show();
				SelectTabIndex(0, false);
				BNEHCENOALD(0, false);
				TabPages[PMCEPNAMKHC].Activate();
			}
		}

		private void AEKNDPOAMEB(EBMDNGEJJBO LDCFIGLFBOK)
		{
			if (LDCFIGLFBOK == EBMDNGEJJBO.Leaderboard && PDPNCAJGGOD)
			{
				PDPNCAJGGOD = false;
				CurrentTeamLeaderboardTabPage.KEKFPNAKACI = true;
				CurrentPlayersLeaderboardTabPage.KEKFPNAKACI = true;
				CurrentFacebookLeaderboardTabPage.UpdateLeaderboardData();
				CurrentTeamLeaderboardTabPage.UpdateLeaderboardData();
				CurrentPlayersLeaderboardTabPage.UpdateLeaderboardData();
				BPKAOEDCPKE item = new BPKAOEDCPKE(IAEABDPGGGJ);
				KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH> { item });
			}
		}

		private void IAEABDPGGGJ(bool EEKJMDHEJCK)
		{
			if (!BIELEFAPPBF)
			{
				EMIBENONFGP = EEKJMDHEJCK;
				if (!EMIBENONFGP && KLIADEEDNAE < 5)
				{
					KLIADEEDNAE++;
					StopAllCoroutines();
					StartCoroutine(PCACFMDDDKE());
				}
				else
				{
					CurrentTeamLeaderboardTabPage.KEKFPNAKACI = false;
					CurrentPlayersLeaderboardTabPage.KEKFPNAKACI = false;
					CurrentTeamLeaderboardTabPage.UpdateLeaderboardData();
					CurrentPlayersLeaderboardTabPage.UpdateLeaderboardData();
				}
			}
		}

		private IEnumerator PCACFMDDDKE()
		{
			yield return new WaitForSeconds(5f);
			if (!BIELEFAPPBF)
			{
				BPKAOEDCPKE item = new BPKAOEDCPKE(IAEABDPGGGJ);
				KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH> { item });
			}
		}

		private void OnEnable()
		{
			InitTabs(0);
		}

		public void SelectTab(int OPLGNHEJBFJ)
		{
			SelectTabIndex(OPLGNHEJBFJ);
		}

		public void SelectTabIndex(int OPLGNHEJBFJ, bool ODJGLICBNKH = true)
		{
			if (PMCEPNAMKHC == OPLGNHEJBFJ)
			{
				TabButtons[PMCEPNAMKHC].Select(true, ODJGLICBNKH);
			}
			else
			{
				TabButtons[PMCEPNAMKHC].Select(false, ODJGLICBNKH);
				TabPages[PMCEPNAMKHC].Deactivate();
				PMCEPNAMKHC = OPLGNHEJBFJ;
				TabButtons[PMCEPNAMKHC].Select(true, ODJGLICBNKH);
				TabPages[PMCEPNAMKHC].Activate();
			}
			LeaderboardButtons.SetActive(PMCEPNAMKHC <= 1);
		}

		public void InitTabs(int OPLGNHEJBFJ)
		{
			PMCEPNAMKHC = OPLGNHEJBFJ;
			for (int i = 0; i < TabButtons.Length; i++)
			{
				if (i == PMCEPNAMKHC)
				{
					TabButtons[i].Select(true, false);
					TabPages[i].Activate();
				}
				else
				{
					TabButtons[i].Select(false, false);
					TabPages[i].Deactivate();
				}
			}
			TabPages[PMCEPNAMKHC].Activate();
			BNEHCENOALD(OPLGNHEJBFJ, false);
		}

		private void BNEHCENOALD(int OPLGNHEJBFJ, bool ODJGLICBNKH)
		{
			if (PMCEPNAMKHC == 0)
			{
				CurrentPlayersLeaderboardTabPage.SelectLeaderboardTab(OPLGNHEJBFJ, ODJGLICBNKH);
				CurrentTeamLeaderboardTabPage.SharedTabIndex = OPLGNHEJBFJ;
			}
			else if (PMCEPNAMKHC == 1)
			{
				CurrentTeamLeaderboardTabPage.SelectLeaderboardTab(OPLGNHEJBFJ, ODJGLICBNKH);
				CurrentPlayersLeaderboardTabPage.SharedTabIndex = OPLGNHEJBFJ;
			}
		}

		private void OnApplicationPause(bool MMMKENCKOAL)
		{
			if (!MMMKENCKOAL)
			{
				PDPNCAJGGOD = true;
				AEKNDPOAMEB(CurrentContainerManager.GetCurrentMapPage());
			}
		}

		public void UpdateLeaderboardScrolls()
		{
			try
			{
				CurrentFacebookLeaderboardTabPage.UpdateLeaderboardScroll();
				CurrentTeamLeaderboardTabPage.UpdateLeaderboardScroll();
				CurrentPlayersLeaderboardTabPage.UpdateLeaderboardScroll();
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Leaderboard, "Exception on updating leader board scrolls: " + ex.Message);
			}
		}
	}
}
