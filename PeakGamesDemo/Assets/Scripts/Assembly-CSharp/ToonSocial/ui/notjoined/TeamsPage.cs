using NewMapScene;
using ToonSocial.ui.joined;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ToonSocial.ui.notjoined
{
	public class TeamsPage : MonoBehaviour
	{
		public SpriteRenderer BackgroundImage;

		public ContainerManager CurrentContainerManager;

		public SocialHelper CurrentSocialHelper;

		public ChatTab CurrentChatTab;

		public TeamsTab CurrentTeamsTab;

		public SearchTeamTab CurrentSearchTeamTab;

		public MyTeamTab CurrentMyTeamTab;

		public CreateTeamTab CurrentCreateTeamTab;

		public AskLifeNotificationIcon CurrentAskLifeNotificationIcon;

		public ChatHelpNotificationIcon CurrentChatHelpNotificationIcon;

		public GameObject NoticeMark;

		public void Awake()
		{
			float num = 0.23f;
			BackgroundImage.transform.localScale = new Vector3(ONCMBJKLKIL.EMFKAPJMDCC + 2f * num, ONCMBJKLKIL.FHAMOHDEGMK, 1f);
			if (CurrentContainerManager != null)
			{
				CurrentContainerManager.HJOKHPIGEAM += AEKNDPOAMEB;
			}
			CurrentChatHelpNotificationIcon.Hide();
			CurrentChatTab.Prepare();
			CurrentMyTeamTab.Prepare();
		}

		private void AEKNDPOAMEB(EBMDNGEJJBO LDCFIGLFBOK)
		{
			if (LDCFIGLFBOK == EBMDNGEJJBO.Social)
			{
				CurrentAskLifeNotificationIcon.transform.localPosition = new Vector3(0.47f, 1.09f, 0f);
				CurrentChatHelpNotificationIcon.transform.localPosition = new Vector3(0.47f, 1.09f, 0f);
				NoticeMark.transform.localPosition = new Vector3(0.47f, 1.09f, 0f);
				if (!JHOAHCHHBCH.CCAJIIFJPFF() && CurrentSocialHelper.CurrentSession != null && !CurrentSocialHelper.CurrentSession.PLNDKBKHDHA)
				{
					CurrentSocialHelper.SwitchState(MGGEJMGBEBE.NoConnection);
				}
				return;
			}
			CurrentAskLifeNotificationIcon.transform.localPosition = new Vector3(0.47f, 0.47f, 0f);
			CurrentChatHelpNotificationIcon.transform.localPosition = new Vector3(0.47f, 0.47f, 0f);
			NoticeMark.transform.localPosition = new Vector3(0.47f, 0.47f, 0f);
			if (CurrentChatTab != null && CurrentChatTab.KeyBoard != null)
			{
				CurrentChatTab.KeyBoard.active = false;
			}
			if (CurrentCreateTeamTab.InputFields != null)
			{
				for (int i = 0; i < CurrentCreateTeamTab.InputFields.Length; i++)
				{
					if (!(CurrentCreateTeamTab.InputFields[i] == null))
					{
						CurrentCreateTeamTab.InputFields[i].OnDeselect(new BaseEventData(EventSystem.current));
						CurrentCreateTeamTab.InputFields[i].DeactivateInputField();
					}
				}
			}
			if (CurrentChatTab.gameObject.activeInHierarchy)
			{
				CurrentChatTab.CurrentScrollController.ScrollToBottom();
			}
			if (CurrentTeamsTab.gameObject.activeInHierarchy)
			{
				CurrentTeamsTab.TeamsScrollController.ScrollToTop();
			}
			if (CurrentSearchTeamTab.gameObject.activeInHierarchy)
			{
				CurrentSearchTeamTab.SearchResultsScrollController.ScrollToTop();
			}
			if (CurrentMyTeamTab.gameObject.activeInHierarchy)
			{
				CurrentMyTeamTab.MembersScrollController.ScrollToTop();
			}
			if (CurrentCreateTeamTab.gameObject.activeInHierarchy)
			{
				CurrentCreateTeamTab.ClearContent();
			}
			if (!JHOAHCHHBCH.CCAJIIFJPFF() && CurrentSocialHelper.CurrentSession != null && !CurrentSocialHelper.CurrentSession.PLNDKBKHDHA)
			{
				CurrentSocialHelper.SwitchState(MGGEJMGBEBE.NoConnection);
			}
		}
	}
}
