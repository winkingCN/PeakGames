using NewMapScene;
using UnityEngine;

namespace ToonSocial.ui.notjoined
{
	public class NotJoinedContainer : MonoBehaviour
	{
		public TeamsTab CurrentTeamsTab;

		public CreateTeamTab CurrentCreateTeamTab;

		public SearchTeamTab CurrentSearchTab;

		public TabButton[] TabButtons;

		public TabPage[] TabPages;

		private int PMCEPNAMKHC;

		private void OnEnable()
		{
			InitTabs(0);
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
	}
}
