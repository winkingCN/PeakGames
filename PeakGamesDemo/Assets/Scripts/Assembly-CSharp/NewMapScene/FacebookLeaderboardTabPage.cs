using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.MapScene;
using Assets.Scripts.SceneTransitions;
using Dialogs;
using TMPro;
using ToonSocial;
using ToonSocial.ui.joined;
using Ui.VerticalScroll;
using UnityEngine;

namespace NewMapScene
{
	public class FacebookLeaderboardTabPage : TabPage
	{
		public GameObject ConnectedContainer;

		public GameObject NotConnectedContainer;

		public GameObject FriendEntryReference;

		public VerticalScrollController ScrollController;

		public TextMeshPro NotConnectedLevelText;

		public TextMeshPro NotConnectedYouText;

		public TextMeshPro NotConnectedTeamText;

		public GameObject NotConnectedTeamBadge;

		public SpriteRenderer NotConnectedBadgeSpriteRenderer;

		public GameObject CLContainer;

		public TextMeshPro CLScore;

		[HideInInspector]
		public KickButton ActiveKickButton;

		[HideInInspector]
		public bool _leaderboardUpdated;

		[HideInInspector]
		public SocialHelper CurrentSocialHelper;

		private bool BIELEFAPPBF;

		private Dictionary<int, List<string>> MNJDGPMHAPH;

		private FFGIDMDAGOA IBIFOCEKDBF;

		private FacebookLeaderboardEntry IBKKGNDGOFK;

		public bool IsReady;

		private global::FHOJBJMMNOD<PDLBAPCKIBF, FacebookLeaderboardEntry> JKANNLPGLPJ;

		private List<PDLBAPCKIBF> LAKDGKIPIHI;

		private bool MOOEEOLJDDA
		{
			get
			{
				try
				{
					Vector2 size = ScrollController.ScrollArea.size;
					return true;
				}
				catch (Exception ex)
				{
					GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Leaderboard, "Error getting scroll area of leaderboard: {0} {1}", ex.Message, ex.StackTrace);
					return false;
				}
			}
		}

		public void OnDestroy()
		{
			BIELEFAPPBF = true;
		}

		public override void Activate()
		{
			base.Activate();
			ScrollController.ScrollToTop();
		}

		public override void Prepare()
		{
			IBIFOCEKDBF = FFGIDMDAGOA.GABGKBAKHDP;
			JBCMLGFAOBB();
			IsReady = true;
		}

		private void JBCMLGFAOBB()
		{
			if (JKANNLPGLPJ == null)
			{
				ScrollController.Init();
				JKANNLPGLPJ = new global::FHOJBJMMNOD<PDLBAPCKIBF, FacebookLeaderboardEntry>(ScrollController, FriendEntryReference.GetComponent<FacebookLeaderboardEntry>(), 15);
				JKANNLPGLPJ.FEHBHKPHBFC(10, 2f, 0.8f);
			}
		}

		public void SetScrollColliderSize(float HHHMOGOKFHF)
		{
			JBCMLGFAOBB();
			Vector2 size = ScrollController.ScrollArea.size;
			size.x = HHHMOGOKFHF;
			float centerPanelExtend = MapManager.Instance.CurrentMapPageSizer.CenterPanelExtend;
			if (centerPanelExtend > 0f)
			{
				size.y = 13f + centerPanelExtend;
				ScrollController.ScrollArea.offset = new Vector2(0f, (0f - centerPanelExtend) * 0.5f);
				ScrollController.SetOffsets((0f - centerPanelExtend) * 0.5f, (0f - centerPanelExtend) * 0.5f);
			}
			else
			{
				ScrollController.SetOffsets(0f, 0f);
			}
			ScrollController.ScrollArea.size = size;
		}

		public void Show()
		{
			if (CurrentSocialHelper != null && CurrentSocialHelper.CurrentSession != null)
			{
				UpdateNotConnectedContainer(CurrentSocialHelper.CurrentSession.COPDAKACHFM);
			}
			else
			{
				UpdateNotConnectedContainer(null);
			}
			ConnectedContainer.SetActive(LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA != null);
			if (ActiveKickButton != null && ActiveKickButton.IsActive())
			{
				ActiveKickButton.Hide();
			}
		}

		public void UpdateNotConnectedContainer(DKBEJLGEAOA IIIMBFFNNBN)
		{
			bool flag = LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA != null;
			NotConnectedContainer.SetActive(!flag);
			if (flag)
			{
				return;
			}
			IDFPAFEJPPH iDFPAFEJPPH = IDFPAFEJPPH.GABGKBAKHDP;
			CLContainer.SetActive(iDFPAFEJPPH.HGNJBHGBLIN);
			CLScore.FCJBBPHFNPJ = iDFPAFEJPPH.PDGLECFDLJJ.ToString();
			NotConnectedLevelText.FCJBBPHFNPJ = (MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1).ToString();
			try
			{
				string text = LECPGNKOABP.GABGKBAKHDP.KJACEODCOHN;
				NotConnectedYouText.FCJBBPHFNPJ = ((!string.IsNullOrEmpty(text)) ? text : NotConnectedYouText.FCJBBPHFNPJ);
				text = CurrentSocialHelper.CurrentSession.ADCMNJCINBO.EALJKKBHDHK;
				NotConnectedYouText.FCJBBPHFNPJ = ((!string.IsNullOrEmpty(text)) ? text : NotConnectedYouText.FCJBBPHFNPJ);
				NotConnectedTeamText.FCJBBPHFNPJ = IIIMBFFNNBN.PNGPLGHKFDI;
				NotConnectedBadgeSpriteRenderer.sprite = CurrentSocialHelper.BadgesDictionary.GetBadge(IIIMBFFNNBN.FGPGOGEKDAM);
				NotConnectedYouText.ANLKLKAINEO.localPosition = new Vector3(-0.07f, 3.5f, 0f);
				NotConnectedTeamText.enabled = true;
				NotConnectedTeamBadge.SetActive(true);
				int gGBEMNJNAEE = CurrentSocialHelper.CurrentSession.ADCMNJCINBO.GGBEMNJNAEE;
				if (gGBEMNJNAEE > 0)
				{
					if (gGBEMNJNAEE > iDFPAFEJPPH.PDGLECFDLJJ)
					{
						CLScore.FCJBBPHFNPJ = gGBEMNJNAEE.ToString();
					}
					CLContainer.SetActive(true);
				}
			}
			catch (Exception)
			{
				NotConnectedYouText.ANLKLKAINEO.localPosition = new Vector3(-0.87f, 3.377f, 0f);
				NotConnectedTeamText.enabled = false;
				NotConnectedTeamBadge.SetActive(false);
			}
		}

		public void UpdateLeaderboardData()
		{
			if (LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA != null && !_leaderboardUpdated)
			{
				_leaderboardUpdated = true;
				PGACJHKJAHA.JOAPFNGHHOP();
				IBIFOCEKDBF.ENGGNDDFFOI(CurrentSocialHelper);
				UpdateLeaderboardScroll();
				GetFacebookFriends();
				AFJPGLHKOID.NLDLHDAODGO();
			}
		}

		public void GetFacebookFriends()
		{
			if (!LECPGNKOABP.GABGKBAKHDP.BJLBIBDKADC())
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Leaderboard, "Not connected to FB; skip getting friends.");
				return;
			}
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Leaderboard, "Also refreshing cached latest levels.");
			JCGLFEMHECF.GABGKBAKHDP.LNFNDHKCKOP(delegate(KNAKIANHFJN[] LAJKEHONIPK)
			{
				if (!BIELEFAPPBF)
				{
					if (LAJKEHONIPK == null || LAJKEHONIPK.Length <= 0)
					{
						OnFriendListReceived(false);
					}
					else
					{
						GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Leaderboard, "Cache is refreshed. Re adding place friends.");
						List<string> list = new List<string>();
						for (int i = 0; i < LAJKEHONIPK.Length; i++)
						{
							list.Add(LAJKEHONIPK[i].EEFMIHDPJPG);
						}
						list.Add(LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA);
						if (list.Count > 0)
						{
							MDIOGGCOLLN item = new MDIOGGCOLLN(list, OnFriendListReceived);
							KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH> { item });
						}
						else
						{
							OnFriendListReceived(false);
						}
					}
				}
			});
		}

		public void OnFriendListReceived(bool DIDHNNMKJFE)
		{
			if (!BIELEFAPPBF)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Leaderboard, "Facebook friend leaderboard received");
				IBIFOCEKDBF.BAFBKBIKHKC();
				UpdateLeaderboardScroll();
			}
		}

		public void UpdateLeaderboardScroll()
		{
			if (CaravanSceneManager.CurrentScene != GKBHIKONCKJ.Map || BIELEFAPPBF || !IsReady || !MOOEEOLJDDA)
			{
				return;
			}
			List<IENHAKEMDPM> list = IBIFOCEKDBF.BBINNBKCDIH();
			if (list != null && list.Count != 0)
			{
				int count = list.Count;
				if (LAKDGKIPIHI == null)
				{
					LAKDGKIPIHI = new List<PDLBAPCKIBF>();
				}
				else
				{
					LAKDGKIPIHI.Clear();
				}
				for (int i = 0; i < count; i++)
				{
					IENHAKEMDPM iENHAKEMDPM = list[i];
					iENHAKEMDPM.KOPMPMIFHNF++;
					LAKDGKIPIHI.Add(new PDLBAPCKIBF(list[i], i, this, CurrentSocialHelper));
				}
				JKANNLPGLPJ.BBOMMEKKAEB(LAKDGKIPIHI);
				ScrollController.SetContentSize((float)count * 2f + 2f);
			}
		}

		public void OnConnectFBClick()
		{
			IIMOEAOONKA.GABGKBAKHDP.KCLJAABIMED("leaderboard");
		}

		[CompilerGenerated]
		private void GJPGKFDHAMO(KNAKIANHFJN[] LAJKEHONIPK)
		{
			if (BIELEFAPPBF)
			{
				return;
			}
			if (LAJKEHONIPK == null || LAJKEHONIPK.Length <= 0)
			{
				OnFriendListReceived(false);
				return;
			}
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Leaderboard, "Cache is refreshed. Re adding place friends.");
			List<string> list = new List<string>();
			for (int i = 0; i < LAJKEHONIPK.Length; i++)
			{
				list.Add(LAJKEHONIPK[i].EEFMIHDPJPG);
			}
			list.Add(LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA);
			if (list.Count > 0)
			{
				MDIOGGCOLLN item = new MDIOGGCOLLN(list, OnFriendListReceived);
				KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH> { item });
			}
			else
			{
				OnFriendListReceived(false);
			}
		}
	}
}
