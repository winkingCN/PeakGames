using NewMapScene;
using TMPro;
using UnityEngine;

namespace ToonSocial.ui.joined
{
	public class JoinedContainer : MonoBehaviour
	{
		public TabButton[] TabButtons;

		public TabPage[] TabPages;

		public TextMeshPro[] TeamNames;

		public TextMeshPro[] OnlineCounts;

		public TextMeshPro[] OfflineCounts;

		public SocialHelper CurrentSocialHelper;

		private int PMCEPNAMKHC;

		public ChatTab ChatTab;

		public MyTeamTab MyTeamTab;

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
		}

		public void SelectTab(int OPLGNHEJBFJ)
		{
			if (PMCEPNAMKHC == OPLGNHEJBFJ)
			{
				TabButtons[PMCEPNAMKHC].Select(true);
				return;
			}
			TabButtons[PMCEPNAMKHC].Select(false);
			TabPages[PMCEPNAMKHC].Deactivate();
			PMCEPNAMKHC = OPLGNHEJBFJ;
			TabButtons[PMCEPNAMKHC].Select(true);
			TabPages[PMCEPNAMKHC].Activate();
		}

		public void Start()
		{
			InitTabs(0);
		}

		private void OnEnable()
		{
			InitTabs(0);
		}

		public void UpdateTeamNames()
		{
			DKBEJLGEAOA dKBEJLGEAOA = CurrentSocialHelper.CurrentSession.COPDAKACHFM;
			if (dKBEJLGEAOA != null)
			{
				TextMeshPro[] teamNames = TeamNames;
				foreach (TextMeshPro textMeshPro in teamNames)
				{
					textMeshPro.FCJBBPHFNPJ = dKBEJLGEAOA.PNGPLGHKFDI;
				}
			}
		}

		public void UpdateOnlineUserCounts()
		{
			DKBEJLGEAOA dKBEJLGEAOA = CurrentSocialHelper.CurrentSession.COPDAKACHFM;
			if (dKBEJLGEAOA != null)
			{
				string text = NKILHODNBDE.GHBGCADFLFB("Online") + ": " + CurrentSocialHelper.CurrentSession.FPILBAGGALI.Count + "/" + dKBEJLGEAOA.GMCGMPEEHJP;
				TextMeshPro[] onlineCounts = OnlineCounts;
				foreach (TextMeshPro textMeshPro in onlineCounts)
				{
					textMeshPro.FCJBBPHFNPJ = text;
				}
			}
		}

		public void UpdateOfflineUserCounts()
		{
			DKBEJLGEAOA dKBEJLGEAOA = CurrentSocialHelper.CurrentSession.COPDAKACHFM;
			if (dKBEJLGEAOA != null)
			{
				long gMCGMPEEHJP = dKBEJLGEAOA.GMCGMPEEHJP;
				string text = gMCGMPEEHJP + "/50";
				TextMeshPro[] offlineCounts = OfflineCounts;
				foreach (TextMeshPro textMeshPro in offlineCounts)
				{
					textMeshPro.FCJBBPHFNPJ = text;
				}
			}
		}
	}
}
