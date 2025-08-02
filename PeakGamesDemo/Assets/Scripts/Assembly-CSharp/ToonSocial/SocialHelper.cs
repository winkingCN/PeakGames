using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Assets.Scripts.Utils;
using NewMapScene;
using TMPro;
using ToonSocial.dialogs;
using ToonSocial.ui.joined;
using ToonSocial.ui.notjoined;
using UnityEngine;

namespace ToonSocial
{
	public class SocialHelper : MonoBehaviour
	{
		private const string PPBFMIEPNOG = "SocialNoticeMarkAvailability";

		public MapUIAnimationController CurrentMapUIAnimationController;

		public EIPCLBONPLC CurrentSession;

		public Badges BadgesDictionary;

		public JoinedContainer CurrentJoinedContainer;

		public NotJoinedContainer CurrentNotJoinedContainer;

		public LivesInbox CurrentInbox;

		private NNDDOJGCENC MEFBGFFCPFF;

		private PHGCFPNJLEI LBLOAADLECH;

		private DAKLNDKNNII CGHBLJHPLBB;

		private MDFABKJBMNB NNPDHDKKFGB;

		private LMGLBNPMICI DDOPEOGPFMJ;

		private MDMLFPDLFLE[] BJKABDMNABO;

		public GameObject subTabNotJoinedToTeam;

		public GameObject subTabJoinedToTeam;

		public GameObject subTabNotAvilableYet;

		public SearchTeamTab subSearchTab;

		public GameObject subTabNoInternet;

		public GameObject NoInternetIcon;

		public GameObject MaintenanceIcon;

		public TextMeshPro NoInternetTitleText;

		public TextMeshPro NoInternetInfoText;

		private bool CFIEOOAHHJK;

		private LLCJMMBBLEH EOONDCDEFOL;

		private bool BKLPOHFMBLM;

		public SocialLoading LoadingIcon;

		private static SocialHelper KNPOFJNFLJB;

		private bool BIELEFAPPBF;

		public const float WaitFocusLoading = 4f;

		public IGKNEDGLOHA JBBCCIBAGJC { get; private set; }

		public static bool AKIJLCCOAPB
		{
			private get
			{
				string text = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("SocialNoticeMarkAvailability" + LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM);
				return text == null || text == "1";
			}
			set
			{
				HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("SocialNoticeMarkAvailability" + LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM, (!value) ? "0" : "1");
			}
		}

		public static bool CIAKNBCNMBM
		{
			get
			{
				return MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() > 20 && JHOAHCHHBCH.CCAJIIFJPFF() && !LECPGNKOABP.GABGKBAKHDP.LJEIKNAKAJD && AKIJLCCOAPB;
			}
		}

		public void Awake()
		{
			KNPOFJNFLJB = this;
		}

		public void Start()
		{
			int num = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC();
			if (num < 20)
			{
				SwitchState(MGGEJMGBEBE.TooEarly);
			}
			else
			{
				SwitchState(MGGEJMGBEBE.Loading);
			}
		}

		public void StartSocialHelper()
		{
			if (!CFIEOOAHHJK && MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() >= 20 && LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM > 0)
			{
				CFIEOOAHHJK = true;
				CurrentSession = new EIPCLBONPLC(this);
				MEFBGFFCPFF = new NNDDOJGCENC(CurrentSession);
				LBLOAADLECH = new PHGCFPNJLEI(CurrentSession);
				CGHBLJHPLBB = new DAKLNDKNNII(CurrentSession);
				NNPDHDKKFGB = new MDFABKJBMNB(CurrentSession);
				DDOPEOGPFMJ = new LMGLBNPMICI(CurrentSession);
				JBBCCIBAGJC = new IGKNEDGLOHA(CurrentSession);
				BJKABDMNABO = new MDMLFPDLFLE[6] { MEFBGFFCPFF, LBLOAADLECH, CGHBLJHPLBB, NNPDHDKKFGB, DDOPEOGPFMJ, JBBCCIBAGJC };
				SwitchState(MGGEJMGBEBE.Loading);
				StartCoroutine(FJCFBOGIKAH());
			}
		}

		private IEnumerator FJCFBOGIKAH()
		{
			int num = 0;
			while (true)
			{
				if (JHOAHCHHBCH.CCAJIIFJPFF())
				{
					num = 0;
					CurrentSession.LFGIBEDPLJG(true);
				}
				else
				{
					num++;
					if (num > 10)
					{
						CurrentSession.LFGIBEDPLJG(false);
					}
				}
				yield return MCJHHDACJBG.IONDKKIFPHN;
			}
		}

		public void OnDestroy()
		{
			BIELEFAPPBF = true;
			KNPOFJNFLJB = null;
			if (CurrentSession != null)
			{
				CurrentSession.NKKOEHGDNKD();
			}
		}

		public void EditTeamRequest(string GFLHOMACBOE, int GIOFHACJEGA, int MBEOPLHLANP)
		{
			JBBCCIBAGJC.FDNNLJLFMKI(GFLHOMACBOE, GIOFHACJEGA, MBEOPLHLANP);
		}

		public void EditTeamResponse(bool DIDHNNMKJFE, int EMNOJOHFMEH, NKILAONHNNE LENFKJMEBFP = null)
		{
			JBBCCIBAGJC.GPGKHODHINM(DIDHNNMKJFE, EMNOJOHFMEH, LENFKJMEBFP);
		}

		public void FetchSuggestedTeams()
		{
			if (MEFBGFFCPFF != null)
			{
				MEFBGFFCPFF.FDNNLJLFMKI();
			}
		}

		public void SuggestedTeamsFetched(bool DIDHNNMKJFE, List<BGMENKMNLCH> FOBMKHBPFMG)
		{
			MEFBGFFCPFF.GPGKHODHINM(DIDHNNMKJFE, FOBMKHBPFMG);
		}

		public void JoinToTeam(long EMNOJOHFMEH, TeamEntry KAGBOIDKAED)
		{
			LBLOAADLECH.FDNNLJLFMKI(EMNOJOHFMEH, KAGBOIDKAED);
		}

		public void JoinToTeamEnded(bool DIDHNNMKJFE, JPLIGBJJCOE ECBDGMPPBKF, NKILAONHNNE EEBJBOHPDDH)
		{
			LBLOAADLECH.GPGKHODHINM(DIDHNNMKJFE, ECBDGMPPBKF, EEBJBOHPDDH);
			if (ChangeTeamDialog.ActiveOne != null)
			{
				ChangeTeamDialog.ActiveOne.OnJoinEnd(DIDHNNMKJFE, EEBJBOHPDDH);
			}
		}

		public void RequestLeaveTeam()
		{
			CGHBLJHPLBB.FDNNLJLFMKI();
		}

		public void LeaveTeamEnded(bool DIDHNNMKJFE, AKGIJAMHMNA FMEJGLGPIBJ, NKILAONHNNE EEBJBOHPDDH)
		{
			CGHBLJHPLBB.GPGKHODHINM(DIDHNNMKJFE, FMEJGLGPIBJ, EEBJBOHPDDH);
			if (ChangeTeamDialog.ActiveOne != null)
			{
				ChangeTeamDialog.ActiveOne.OnLeaveEnd();
			}
		}

		public void SwitchState(MGGEJMGBEBE BGEDKGLJIGM)
		{
			if (EOONDCDEFOL != null)
			{
				EOONDCDEFOL.BPPFBMCJOAH();
				if (BKLPOHFMBLM)
				{
					BKLPOHFMBLM = false;
					LoadingIcon.Hide();
				}
			}
			if (BIELEFAPPBF)
			{
				return;
			}
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SocialHelper, "Switching to state: " + BGEDKGLJIGM);
			switch (BGEDKGLJIGM)
			{
			case MGGEJMGBEBE.ChangingHost:
				return;
			case MGGEJMGBEBE.NoConnection:
				if (Time.time - FocusListener.LastTimeFocused < 4f)
				{
					if (!BKLPOHFMBLM)
					{
						BKLPOHFMBLM = true;
						LoadingIcon.Display(true);
					}
					EOONDCDEFOL = new LLCJMMBBLEH(FACAMECOLGI());
					return;
				}
				break;
			}
			if (BGEDKGLJIGM == MGGEJMGBEBE.Loading)
			{
				BKLPOHFMBLM = true;
				if (!LoadingIcon.gameObject.activeSelf)
				{
					LoadingIcon.gameObject.SetActive(true);
				}
				LoadingIcon.DisplayInstant();
			}
			else
			{
				BKLPOHFMBLM = false;
				if (LoadingIcon.gameObject.activeSelf)
				{
					LoadingIcon.HideInstant();
				}
			}
			BJINPLHPCLD(BGEDKGLJIGM);
			subTabNotJoinedToTeam.SetActive(BGEDKGLJIGM == MGGEJMGBEBE.NotJoinedToAnyTeam);
			subTabJoinedToTeam.SetActive(BGEDKGLJIGM == MGGEJMGBEBE.JoinedToTeam);
			subTabNotAvilableYet.SetActive(BGEDKGLJIGM == MGGEJMGBEBE.TooEarly);
			subSearchTab.gameObject.SetActive((BGEDKGLJIGM == MGGEJMGBEBE.JoinedToTeam || BGEDKGLJIGM == MGGEJMGBEBE.NotJoinedToAnyTeam) && subSearchTab.AJEGGLPFLEO);
		}

		private void BJINPLHPCLD(MGGEJMGBEBE BGEDKGLJIGM)
		{
			switch (BGEDKGLJIGM)
			{
			case MGGEJMGBEBE.Maintenance:
				subTabNoInternet.SetActive(true);
				NoInternetIcon.SetActive(false);
				MaintenanceIcon.SetActive(true);
				NoInternetTitleText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("MaintenanceBreak");
				NoInternetInfoText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("MaintenanceBreakDesc");
				break;
			case MGGEJMGBEBE.NoConnection:
				subTabNoInternet.SetActive(true);
				NoInternetIcon.SetActive(true);
				MaintenanceIcon.SetActive(false);
				NoInternetTitleText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("NoInternetConnection");
				NoInternetInfoText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("YouNeedInternetWithReason");
				break;
			default:
				subTabNoInternet.SetActive(false);
				break;
			}
		}

		private IEnumerator FACAMECOLGI()
		{
			yield return new WaitForSeconds(5f);
			EOONDCDEFOL = null;
			if (BKLPOHFMBLM)
			{
				BKLPOHFMBLM = false;
				LoadingIcon.Hide();
			}
			SwitchState(MGGEJMGBEBE.NoConnection);
		}

		public void SendChatMessage(string OEFCOJLNCKP)
		{
			OEFCOJLNCKP = Regex.Replace(OEFCOJLNCKP, "<\\/?[a-z][a-z0-9]*[^<>]*>|<!--.*?-->", string.Empty);
			string value = OEFCOJLNCKP.Trim();
			if (!string.IsNullOrEmpty(OEFCOJLNCKP) && !string.IsNullOrEmpty(value))
			{
				CurrentSession.NMGBGAGMOGI.IEJDIMGBMCN(OEFCOJLNCKP);
			}
		}

		public void RequestCreateTeam(string GKNCJMICJEL, string DGDILOMFNFA, string JLODDGBIINF, int KIGOGMKCDKN, bool DCFMMIPAOCK)
		{
			NNPDHDKKFGB.FDNNLJLFMKI(GKNCJMICJEL, DGDILOMFNFA, JLODDGBIINF, KIGOGMKCDKN, DCFMMIPAOCK);
		}

		public void CreateTeamEnded(bool DIDHNNMKJFE, int? NHCLNANFHKJ, NKILAONHNNE LENFKJMEBFP)
		{
			NNPDHDKKFGB.GPGKHODHINM(DIDHNNMKJFE, NHCLNANFHKJ, LENFKJMEBFP);
		}

		public void RequestSearchTeams(string FCJBBPHFNPJ)
		{
			DDOPEOGPFMJ.FDNNLJLFMKI(FCJBBPHFNPJ);
		}

		public void RequestLevelUpdate()
		{
			CurrentSession.NHHCGMIDPDK.NHNHFBFJMNF();
		}

		public void SearchTeamEnded(bool DIDHNNMKJFE, List<BGMENKMNLCH> IMCILJFAPPB, NKILAONHNNE LENFKJMEBFP)
		{
			DDOPEOGPFMJ.GPGKHODHINM(DIDHNNMKJFE, IMCILJFAPPB, LENFKJMEBFP);
		}

		public void Disconnectted()
		{
			MDMLFPDLFLE[] bJKABDMNABO = BJKABDMNABO;
			foreach (MDMLFPDLFLE mDMLFPDLFLE in bJKABDMNABO)
			{
				mDMLFPDLFLE.AHDHEMJOMGB();
			}
		}

		public static void RefreshUser()
		{
			if (KNPOFJNFLJB != null && KNPOFJNFLJB.CurrentSession != null)
			{
				KNPOFJNFLJB.CurrentSession.FFBLPBHGFOD();
			}
		}

		public void RequestInbox()
		{
			CurrentSession.NMGBGAGMOGI.OLAHHONIHDA();
		}

		public void RequestInboxEnded(bool DIDHNNMKJFE, string LKCCLDFFEPD, string DLALMJPFFMK, long DIKEGACKFFH)
		{
			if (!DIDHNNMKJFE || LKCCLDFFEPD == null)
			{
				return;
			}
			if (DLALMJPFFMK == null)
			{
				if (!string.IsNullOrEmpty(LKCCLDFFEPD) && !PlayerPrefs.HasKey("Inbox_Error_" + LKCCLDFFEPD))
				{
					PlayerPrefs.SetInt("Inbox_Error_" + LKCCLDFFEPD, 1);
					PlayerPrefs.Save();
					AFJPGLHKOID.IIEPJFFOJPF(CurrentSession);
				}
			}
			else
			{
				CurrentInbox.AddSocialLife(LKCCLDFFEPD, DLALMJPFFMK, DIKEGACKFFH);
				CurrentSession.NMGBGAGMOGI.HOLOADDJPPB(DLALMJPFFMK, DIKEGACKFFH);
				RequestInbox();
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Inbox, "Adding life from {0}-{1}. {2}", LKCCLDFFEPD, DLALMJPFFMK, CAGBGIHKHEJ.GABGKBAKHDP);
			}
		}

		public void OnApplicationPause(bool APMMLLCMAKI)
		{
			if (!APMMLLCMAKI && CurrentSession != null)
			{
				CurrentSession.BDPBBCELEBN();
			}
		}
	}
}
