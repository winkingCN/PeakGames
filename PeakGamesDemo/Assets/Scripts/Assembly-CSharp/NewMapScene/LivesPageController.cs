using System;
using Assets.Scripts.MapScene;
using TMPro;
using ToonSocial;
using UnityEngine;

namespace NewMapScene
{
	public class LivesPageController : MonoBehaviour
	{
		private enum COHGDDPCBBI
		{
			Connected = 0,
			NotConnected = 1,
			Inbox = 2
		}

		public const string JoinTeamOnceKey = "JoinTeam";

		public ContainerManager CurrentContainerManager;

		public InboxTab CurrentInboxTab;

		public SpriteRenderer BackgroundImage;

		public GameObject ConnectedLivesContainer;

		public GameObject NotConnectedLivesContainer;

		public LivesInbox LivesInboxContainer;

		public SocialHelper CurrentSocialHelper;

		public static LivesPageController Instance;

		public TextMeshPro PrizeCoinsText;

		public static void ResetSelf()
		{
			Instance = null;
		}

		private void NDLKJMCCOHC(COHGDDPCBBI BGEDKGLJIGM)
		{
			switch (BGEDKGLJIGM)
			{
			case COHGDDPCBBI.Connected:
				ConnectedLivesContainer.SetActive(true);
				NotConnectedLivesContainer.SetActive(false);
				LivesInboxContainer.gameObject.SetActive(false);
				break;
			case COHGDDPCBBI.NotConnected:
				ConnectedLivesContainer.SetActive(false);
				NotConnectedLivesContainer.SetActive(true);
				LivesInboxContainer.gameObject.SetActive(false);
				break;
			case COHGDDPCBBI.Inbox:
				ConnectedLivesContainer.SetActive(false);
				NotConnectedLivesContainer.SetActive(false);
				LivesInboxContainer.gameObject.SetActive(true);
				break;
			default:
				throw new ArgumentOutOfRangeException("state", BGEDKGLJIGM, null);
			}
		}

		private void Start()
		{
			if (CurrentContainerManager != null)
			{
				CurrentContainerManager.HJOKHPIGEAM += AEKNDPOAMEB;
				CurrentContainerManager.IKHJGHKNFJM += IJDFOHAKHOM;
			}
			PrizeCoinsText.FCJBBPHFNPJ = BOKGFGFPOHD.MFDPEOHIKKH.FDNCJEHPFFJ.ToString();
			float num = 0.23f;
			BackgroundImage.transform.localScale = new Vector3(ONCMBJKLKIL.EMFKAPJMDCC + 2f * num, ONCMBJKLKIL.FHAMOHDEGMK, 1f);
			Show();
		}

		public void Awake()
		{
			Instance = this;
			CurrentInboxTab.UpdateCount(CAGBGIHKHEJ.GABGKBAKHDP.ELEKFHDLKJJ());
		}

		public void OnDestroy()
		{
			CurrentContainerManager.HJOKHPIGEAM -= AEKNDPOAMEB;
			CurrentContainerManager.IKHJGHKNFJM -= IJDFOHAKHOM;
			ResetSelf();
		}

		public void Show()
		{
			int num = CAGBGIHKHEJ.GABGKBAKHDP.ELEKFHDLKJJ();
			COHGDDPCBBI bGEDKGLJIGM = COHGDDPCBBI.NotConnected;
			if (num > 0 || GFHPEDILAJG.GABGKBAKHDP.ODMCGBLJFKM)
			{
				bGEDKGLJIGM = COHGDDPCBBI.Inbox;
			}
			else if (MKINMKEMBPL.GABGKBAKHDP.HEANMKDLPGF("JoinTeam"))
			{
				bGEDKGLJIGM = COHGDDPCBBI.Connected;
			}
			else if (CurrentSocialHelper != null)
			{
				EIPCLBONPLC currentSession = CurrentSocialHelper.CurrentSession;
				if (currentSession != null && currentSession.NNEADDLACCA && currentSession.PLNDKBKHDHA && currentSession.ADCMNJCINBO != null && currentSession.COPDAKACHFM != null)
				{
					bGEDKGLJIGM = COHGDDPCBBI.Inbox;
				}
			}
			NDLKJMCCOHC(bGEDKGLJIGM);
		}

		private void CCBJLFEKKDE(EBMDNGEJJBO LDCFIGLFBOK)
		{
			if (LDCFIGLFBOK != EBMDNGEJJBO.Lives)
			{
				LivesInboxContainer.LivesScrollController.ScrollToTop();
				CurrentInboxTab.transform.localPosition = new Vector3(0.47f, 0.47f, 0f);
			}
			else
			{
				CurrentInboxTab.transform.localPosition = new Vector3(0.47f, 1.09f, 0f);
				Show();
			}
		}

		private void IJDFOHAKHOM(EBMDNGEJJBO LDCFIGLFBOK)
		{
			CCBJLFEKKDE(LDCFIGLFBOK);
		}

		private void AEKNDPOAMEB(EBMDNGEJJBO LDCFIGLFBOK)
		{
			if (LDCFIGLFBOK != EBMDNGEJJBO.Lives)
			{
				CurrentInboxTab.transform.localPosition = new Vector3(0.47f, 0.47f, 0f);
				return;
			}
			CurrentInboxTab.transform.localPosition = new Vector3(0.47f, 1.09f, 0f);
			Show();
		}

		public void OnJoinClick()
		{
			CurrentSocialHelper.CurrentNotJoinedContainer.SelectTab(0);
			CurrentContainerManager.SlideToPosition(1);
		}

		public void UpdateInboxCount()
		{
			CurrentInboxTab.UpdateCount(CAGBGIHKHEJ.GABGKBAKHDP.ELEKFHDLKJJ());
		}
	}
}
