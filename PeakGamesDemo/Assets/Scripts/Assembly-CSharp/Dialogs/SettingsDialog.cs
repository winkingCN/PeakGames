using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Dialogs;
using Assets.Scripts.MapScene;
using Assets.Scripts.Utils;
using DG.Tweening;
using TMPro;
using UnityEngine;
using Utils;

namespace Dialogs
{
	public class SettingsDialog : SimpleDialog
	{
		[CompilerGenerated]
		private sealed class FHKKDNAEECO
		{
			internal bool NKOCDFAPMEH;

			internal GameObject HDCNHMFEFLB;

			internal void AGFNGEFDHLA()
			{
				if (NKOCDFAPMEH)
				{
					JHOAHCHHBCH.KBKMIGBDDOC(HDCNHMFEFLB, false);
				}
				else
				{
					FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(HDCNHMFEFLB, false);
				}
			}
		}

		public SpriteRenderer AudioDisabled;

		public SpriteRenderer FxDisabled;

		public GameObject ChatOnButton;

		public GameObject ChatOffButton;

		public GameObject ChangeNameEnabled;

		public GameObject ChangeNameDisabled;

		public GameObject FBConnectButton;

		public GameObject FBLogoutButton;

		public GameObject SupportNotificationIndicator;

		public TextMeshPro InfoText;

		private bool MGNFHOBHIBF;

		private bool MHACOOEFAOG;

		private float OBNJIFMECHO;

		private bool MJBDIJMPEIL;

		private bool ODBFJBMPHCC;

		private bool IDIOGABOMPH;

		private int OMLBIBANKID;

		private float ALFBFCDMLBI;

		private bool NLMCDLJIPMD;

		[CompilerGenerated]
		private static Action<bool> EBCOMJBLIPP;

		[CompilerGenerated]
		private static TweenCallback DNBOPLHGMHA;

		public override void DialogCreated()
		{
			base.DialogCreated();
			IDIOGABOMPH = MDGKDGMGGCL.GABGKBAKHDP.NBJEKKIECGE();
			FxDisabled.enabled = !MDGKDGMGGCL.GABGKBAKHDP.NBJEKKIECGE();
			AudioDisabled.enabled = !MDGKDGMGGCL.GABGKBAKHDP.AGGMHHLFFDA();
			ODBFJBMPHCC = MDGKDGMGGCL.GABGKBAKHDP.APAAJANEIOD();
			NFBKCMNCJOG();
			HODMFAKLGKM(PKMNMDCLIJP());
			MJBDIJMPEIL = false;
			SupportNotificationIndicator.SetActive(KMBNIBGIHGH.GABGKBAKHDP.IOBIDNGDPIN > 0);
			UpdateButtons();
		}

		public override void OnDialogClosed()
		{
			base.OnDialogClosed();
			if (IDIOGABOMPH != AudioManager.NAEBPOAPIFP)
			{
				AudioManager.ExecuteFXChange();
			}
			if (ODBFJBMPHCC != MDGKDGMGGCL.GABGKBAKHDP.APAAJANEIOD())
			{
				MapManager.Instance.CurrentSocialHelper.CurrentJoinedContainer.ChatTab.RefreshChatMessages();
			}
			if (!MJBDIJMPEIL)
			{
				return;
			}
			MJBDIJMPEIL = false;
			if (LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM == 0)
			{
				KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
				{
					new CBLGCPEEKDM(delegate
					{
						KMBNIBGIHGH.GABGKBAKHDP.MJGCHNMPAKJ();
					})
				});
			}
			else
			{
				KMBNIBGIHGH.GABGKBAKHDP.MJGCHNMPAKJ();
			}
		}

		public override void PlayDialogInAnimation()
		{
			base.PlayDialogInAnimation();
			JNHCICHFNHL();
		}

		public void UpdateButtons()
		{
			bool flag = LECPGNKOABP.GABGKBAKHDP.BJLBIBDKADC();
			InfoText.FCJBBPHFNPJ = "4161 / " + LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM;
			FBConnectButton.SetActive(!flag);
			FBLogoutButton.SetActive(flag);
		}

		public void SendTicket()
		{
			MJBDIJMPEIL = KMBNIBGIHGH.GABGKBAKHDP.EGKCMNLKGHG;
			if (MJBDIJMPEIL)
			{
				Close();
				return;
			}
			JBLHLNCOLHD();
			EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.SupportTicketDialog);
		}

		private void EOBDANKMCBK(GameObject HDCNHMFEFLB, bool NKOCDFAPMEH = false)
		{
			Sequence s = DOTween.Sequence();
			s.InsertCallback(0.2f, delegate
			{
				if (NKOCDFAPMEH)
				{
					JHOAHCHHBCH.KBKMIGBDDOC(HDCNHMFEFLB, false);
				}
				else
				{
					FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(HDCNHMFEFLB, false);
				}
			});
		}

		public void AudioToggled()
		{
			bool flag = MDGKDGMGGCL.GABGKBAKHDP.AGGMHHLFFDA();
			MDGKDGMGGCL.GABGKBAKHDP.OJKFPLOOKLA(!flag);
			AudioDisabled.enabled = flag;
			AFJPGLHKOID.CPIGOAGGLBM("MusicStatusChanged", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), (!MDGKDGMGGCL.GABGKBAKHDP.AGGMHHLFFDA()) ? "0" : "1");
		}

		public void FxToggled()
		{
			bool flag = MDGKDGMGGCL.GABGKBAKHDP.NBJEKKIECGE();
			MDGKDGMGGCL.GABGKBAKHDP.JFEDLJOAJEM(!flag);
			FxDisabled.enabled = flag;
			AFJPGLHKOID.CPIGOAGGLBM("SoundStatusChanged", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), (!MDGKDGMGGCL.GABGKBAKHDP.NBJEKKIECGE()) ? "0" : "1");
		}

		public void ConnectFB()
		{
			JBLHLNCOLHD();
			Sequence s = DOTween.Sequence();
			s.InsertCallback(0.2f, delegate
			{
				IIMOEAOONKA.GABGKBAKHDP.KCLJAABIMED("settings");
			});
		}

		public void LogoutFB()
		{
			JBLHLNCOLHD();
			if (JHOAHCHHBCH.CCAJIIFJPFF())
			{
				EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.FacebookLogoutConfirmationDialog);
			}
			else
			{
				EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.NoConnectionDialog);
			}
		}

		public void SwitchChatEnabled()
		{
			MDGKDGMGGCL.GABGKBAKHDP.FPGCGKIJOEI(!MDGKDGMGGCL.GABGKBAKHDP.APAAJANEIOD());
			NFBKCMNCJOG();
		}

		private void NFBKCMNCJOG()
		{
			bool flag = MDGKDGMGGCL.GABGKBAKHDP.APAAJANEIOD();
			ChatOnButton.SetActive(flag);
			ChatOffButton.SetActive(!flag);
		}

		public void ChangeName()
		{
			string value = LECPGNKOABP.GABGKBAKHDP.KJACEODCOHN;
			if (string.IsNullOrEmpty(value))
			{
				MapManager.Instance.ShowErrorMessageAtPosition(NKILHODNBDE.GHBGCADFLFB("ChangeNameNoName"), Vector3.up * 1.5f);
				HODMFAKLGKM(false);
			}
			else if (GEBAAFFGKJG.GABGKBAKHDP.ACBHOCGJHHF(NJGLIIMEMBI.USER_TYPE_NAME_CHANGED))
			{
				MapManager.Instance.ShowErrorMessageAtPosition(NKILHODNBDE.GHBGCADFLFB("ChangeNameUsed"), Vector3.up * 1.5f);
				HODMFAKLGKM(false);
			}
			else if (!JHOAHCHHBCH.CCAJIIFJPFF())
			{
				MapManager.Instance.ShowErrorMessageAtPosition(NKILHODNBDE.GHBGCADFLFB("Error_Connection"), Vector3.up * 1.5f);
				HODMFAKLGKM(false);
			}
			else
			{
				FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.ChangeNameUserDialog, false);
				HODMFAKLGKM(true);
			}
		}

		private bool PKMNMDCLIJP()
		{
			string value = LECPGNKOABP.GABGKBAKHDP.KJACEODCOHN;
			return JHOAHCHHBCH.CCAJIIFJPFF() && !string.IsNullOrEmpty(value) && !GEBAAFFGKJG.GABGKBAKHDP.ACBHOCGJHHF(NJGLIIMEMBI.USER_TYPE_NAME_CHANGED);
		}

		private void HODMFAKLGKM(bool EDDNOJDPMCF)
		{
			ChangeNameEnabled.SetActive(EDDNOJDPMCF);
			ChangeNameDisabled.SetActive(!EDDNOJDPMCF);
		}

		private void Update()
		{
			GOAILBAFNKN();
		}

		private void GOAILBAFNKN()
		{
			if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
			{
				NDOHJJMKMEO();
			}
		}

		private void NDOHJJMKMEO()
		{
			if (Time.realtimeSinceStartup - ALFBFCDMLBI < 0.3f)
			{
				OMLBIBANKID++;
				if (OMLBIBANKID >= 2)
				{
					OMLBIBANKID = 0;
					NLMCDLJIPMD = !NLMCDLJIPMD;
					InfoText.enabled = NLMCDLJIPMD;
				}
			}
			else
			{
				OMLBIBANKID = 0;
			}
			ALFBFCDMLBI = Time.realtimeSinceStartup;
		}

		[CompilerGenerated]
		private static void OAGBODOPKFK(bool BCIHLCMFAEK)
		{
			KMBNIBGIHGH.GABGKBAKHDP.MJGCHNMPAKJ();
		}

		[CompilerGenerated]
		private static void DBOKFIEFANB()
		{
			IIMOEAOONKA.GABGKBAKHDP.KCLJAABIMED("settings");
		}
	}
}
