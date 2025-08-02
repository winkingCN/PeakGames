using System.Collections.Generic;
using Assets.Scripts.MapScene;
using Dialogs;
using TMPro;
using ToonSocial;
using ToonSocial.ui.joined;
using Ui.VerticalScroll;
using UnityEngine;

namespace NewMapScene
{
	public class TeamLeaderboardTabPage : TabPage
	{
		public GameObject EntryPrefab;

		public GameObject NoInternetContainer;

		public TextMeshPro CountryTextActive;

		public TextMeshPro CountryTextPassive;

		public VerticalScrollController CurrentVerticalScrollController;

		public SocialLoading LoadingIcon;

		[HideInInspector]
		public SocialHelper CurrentSocialHelper;

		[HideInInspector]
		public KickButton ActiveKickButton;

		public TabButton[] TabButtons;

		public bool IsReady;

		protected int AFHMPOHBLLL;

		public int SharedTabIndex;

		private global::FHOJBJMMNOD<PMBADMGCMDA, TeamLeaderboardEntry> KBLCJMBCPNG;

		public bool KEKFPNAKACI { get; set; }

		public override void Activate()
		{
			base.Activate();
			INPMMFKFHNF(SharedTabIndex, false);
			UpdateLeaderboardScroll();
		}

		public override void Prepare()
		{
			if (KBLCJMBCPNG == null)
			{
				UpdateCountryText();
				JBCMLGFAOBB();
			}
			IsReady = true;
		}

		public void SelectLeaderboardTab(int OPLGNHEJBFJ, bool ODJGLICBNKH = true)
		{
			INPMMFKFHNF(OPLGNHEJBFJ, ODJGLICBNKH);
		}

		private void INPMMFKFHNF(int OPLGNHEJBFJ, bool ODJGLICBNKH = true)
		{
			SharedTabIndex = OPLGNHEJBFJ;
			if (AFHMPOHBLLL == OPLGNHEJBFJ)
			{
				TabButtons[AFHMPOHBLLL].Select(true, ODJGLICBNKH);
				return;
			}
			TabButtons[AFHMPOHBLLL].Select(false, ODJGLICBNKH);
			TabButtons[OPLGNHEJBFJ].Select(true, ODJGLICBNKH);
			AFHMPOHBLLL = OPLGNHEJBFJ;
			UpdateLeaderboardScroll();
		}

		protected virtual void JBCMLGFAOBB()
		{
			if (KBLCJMBCPNG == null)
			{
				CurrentVerticalScrollController.Init();
				KBLCJMBCPNG = new global::FHOJBJMMNOD<PMBADMGCMDA, TeamLeaderboardEntry>(CurrentVerticalScrollController, EntryPrefab.GetComponent<TeamLeaderboardEntry>(), 15);
				KBLCJMBCPNG.FEHBHKPHBFC(10, 2f, 3.2f);
			}
		}

		public void SetScrollColliderSize(float HHHMOGOKFHF)
		{
			JBCMLGFAOBB();
			Vector2 size = CurrentVerticalScrollController.ScrollArea.size;
			size.x = HHHMOGOKFHF;
			float centerPanelExtend = MapManager.Instance.CurrentMapPageSizer.CenterPanelExtend;
			if (centerPanelExtend > 0f)
			{
				size.y = 10.95f + centerPanelExtend;
				CurrentVerticalScrollController.ScrollArea.offset = new Vector2(0f, (0f - centerPanelExtend) * 0.5f);
				CurrentVerticalScrollController.SetOffsets((0f - centerPanelExtend) * 0.5f, (0f - centerPanelExtend) * 0.5f);
			}
			else
			{
				CurrentVerticalScrollController.SetOffsets(0f, 0f);
			}
			CurrentVerticalScrollController.ScrollArea.size = size;
		}

		public void UpdateLeaderboardData()
		{
			UpdateCountryText();
			UpdateLeaderboardScroll();
		}

		public void UpdateCountryText()
		{
			string localizedCountry = LeaderboardPageController.GetLocalizedCountry();
			CountryTextActive.FCJBBPHFNPJ = localizedCountry;
			CountryTextPassive.FCJBBPHFNPJ = localizedCountry;
		}

		public virtual void UpdateLeaderboardScroll(bool NDAILICIEEB = false)
		{
			if (!IsReady)
			{
				return;
			}
			float y = CurrentVerticalScrollController.Content.transform.localPosition.y;
			List<FMHKCJGDPEB> list = HLFNMNPLJCP.GABGKBAKHDP.BBINNBKCDIH(AFHMPOHBLLL + 1);
			if (list == null || list.Count == 0)
			{
				if (KBLCJMBCPNG != null)
				{
					KBLCJMBCPNG.FPGFIAKIIID();
				}
				if (!JHOAHCHHBCH.CCAJIIFJPFF())
				{
					LoadingIcon.HideInstant();
					if (!NoInternetContainer.activeSelf)
					{
						NoInternetContainer.SetActive(true);
					}
				}
				else if (KEKFPNAKACI)
				{
					if (!LoadingIcon.gameObject.activeSelf)
					{
						LoadingIcon.gameObject.SetActive(true);
					}
					LoadingIcon.DisplayInstant();
					if (NoInternetContainer.activeSelf)
					{
						NoInternetContainer.SetActive(false);
					}
				}
				else
				{
					if (NoInternetContainer.activeSelf)
					{
						NoInternetContainer.SetActive(false);
					}
					if (LoadingIcon.gameObject.activeSelf)
					{
						LoadingIcon.gameObject.SetActive(false);
					}
				}
			}
			else
			{
				if (NoInternetContainer.activeSelf)
				{
					NoInternetContainer.SetActive(false);
				}
				if (LoadingIcon.gameObject.activeSelf)
				{
					LoadingIcon.gameObject.SetActive(false);
				}
				List<PMBADMGCMDA> list2 = new List<PMBADMGCMDA>();
				int count = list.Count;
				for (int i = 0; i < count; i++)
				{
					list2.Add(new PMBADMGCMDA(list[i], i, this, CurrentSocialHelper));
				}
				CurrentVerticalScrollController.SetContentSize((float)count * 2f);
				KBLCJMBCPNG.BBOMMEKKAEB(list2);
				if (NDAILICIEEB)
				{
					CurrentVerticalScrollController.SetLocalPos(y);
				}
			}
		}

		public void UpdateLeaderboardScrollWithOrder(int KFAFMNLHGCF)
		{
			float y = CurrentVerticalScrollController.Content.transform.localPosition.y;
			UpdateLeaderboardScroll();
			y += (float)KFAFMNLHGCF * 2f;
			CurrentVerticalScrollController.SetLocalPos(y);
		}
	}
}
