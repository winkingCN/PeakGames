using System.Collections.Generic;
using ToonSocial.ui.joined;

namespace NewMapScene
{
	public class PlayersLeaderboardTabPage : TeamLeaderboardTabPage
	{
		private global::FHOJBJMMNOD<APEOGDOBFGH, PlayersLeaderboardEntry> KBLCJMBCPNG;

		protected override void JBCMLGFAOBB()
		{
			if (KBLCJMBCPNG == null)
			{
				CurrentVerticalScrollController.Init();
				KBLCJMBCPNG = new global::FHOJBJMMNOD<APEOGDOBFGH, PlayersLeaderboardEntry>(CurrentVerticalScrollController, EntryPrefab.GetComponent<PlayersLeaderboardEntry>(), 15);
				KBLCJMBCPNG.FEHBHKPHBFC(10, 2f, 3.2f);
			}
		}

		public override void UpdateLeaderboardScroll(bool NDAILICIEEB = false)
		{
			if (!IsReady)
			{
				return;
			}
			float y = CurrentVerticalScrollController.Content.transform.localPosition.y;
			List<OFGGFEJGABH> list = FIFPLICICKP.GABGKBAKHDP.BBINNBKCDIH(AFHMPOHBLLL + 1);
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
				else if (base.KEKFPNAKACI)
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
				List<APEOGDOBFGH> list2 = new List<APEOGDOBFGH>();
				int count = list.Count;
				for (int i = 0; i < count; i++)
				{
					list2.Add(new APEOGDOBFGH(list[i], i, this, CurrentSocialHelper));
				}
				CurrentVerticalScrollController.SetContentSize((float)count * 2f);
				KBLCJMBCPNG.BBOMMEKKAEB(list2);
				if (NDAILICIEEB)
				{
					CurrentVerticalScrollController.SetLocalPos(y);
				}
			}
		}
	}
}
