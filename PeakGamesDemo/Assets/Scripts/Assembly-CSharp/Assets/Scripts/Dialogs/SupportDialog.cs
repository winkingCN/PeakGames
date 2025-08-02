using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.SceneTransitions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Assets.Scripts.Dialogs
{
	public class SupportDialog : SimpleDialog
	{
		public GameObject SendButtonContainer;

		public GameObject SendButtonContainerDisabled;

		public InputField EmailInput;

		public InputField MessageInput;

		public EventBasedSpriteButton SendButton;

		public TextMeshPro SendButtonText;

		public TextMeshPro TitleText;

		public SpriteRenderer SendButtonBack;

		private string FLEPELKJBGN;

		public Text EmailPlaceHolder;

		public Text MessagePlaceHolder;

		private bool HLJMJBDIKKK;

		private bool LBADBOLDJFH;

		private bool GICKCMPLNNK;

		private const int EIGHJIEJDNH = 1;

		private const int IDGEHJHLGIO = 2;

		private int AHEAGFKDBHP = 1;

		private EKPAJFBBAJC MOJHEMIODFL;

		public void Start()
		{
			TitleText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB((AHEAGFKDBHP != 2) ? "Support" : "Report");
			EmailPlaceHolder.text = NKILHODNBDE.GHBGCADFLFB("SupportEmail");
			MessagePlaceHolder.text = NKILHODNBDE.GHBGCADFLFB("SupportMessage");
			CKCMOJEIKAG(false);
			CBHHFENKOAP();
		}

		private void Update()
		{
			PEJEHGMLKCC(EmailInput, EmailPlaceHolder);
			PEJEHGMLKCC(MessageInput, MessagePlaceHolder);
		}

		private void PEJEHGMLKCC(InputField FEJFOKCKKAL, Text KNNMGOHIFIG)
		{
			if (FEJFOKCKKAL.isFocused && KNNMGOHIFIG.enabled)
			{
				KNNMGOHIFIG.enabled = false;
			}
			else if (!FEJFOKCKKAL.isFocused && FEJFOKCKKAL.text == string.Empty && !KNNMGOHIFIG.enabled)
			{
				KNNMGOHIFIG.enabled = true;
			}
		}

		private void IBDBPGIEAJE(bool ODCADGABBHJ, string NOKFDFNMBMJ)
		{
			if (!ODCADGABBHJ)
			{
				FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.SupportFailedDialog, false);
				FLEPELKJBGN = "abort";
			}
			else
			{
				FLEPELKJBGN = NOKFDFNMBMJ;
			}
		}

		public void SendSupportTicket()
		{
			if (!JHOAHCHHBCH.CCAJIIFJPFF())
			{
				FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.NoConnectionDialog, false);
			}
			else if (AHEAGFKDBHP == 1)
			{
				JBLHLNCOLHD();
				EmailInput.enabled = false;
				MessageInput.enabled = false;
				LoadingScreenDisplayer.Instance.ShowLoading(KLKAGJKCKBE.Loading);
				StartCoroutine(WaitCompress(delegate(bool DIDHNNMKJFE)
				{
					if (DIDHNNMKJFE)
					{
						string text3 = EmailInput.text;
						string text4 = MessageInput.text;
						MFODECOOJLA item = new MFODECOOJLA(text3, text4, FLEPELKJBGN, OnSupportTicketUploadComplete);
						KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH> { item });
					}
					else
					{
						OnSupportTicketUploadComplete(false);
					}
				}));
			}
			else
			{
				if (AHEAGFKDBHP != 2)
				{
					return;
				}
				JBLHLNCOLHD();
				EmailInput.enabled = false;
				MessageInput.enabled = false;
				string text = EmailInput.text;
				string text2 = MessageInput.text;
				LoadingScreenDisplayer.Instance.ShowLoading(KLKAGJKCKBE.Loading);
				KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
				{
					new MFODECOOJLA(MOJHEMIODFL, text, text2, delegate(bool EEKJMDHEJCK)
					{
						LoadingScreenDisplayer.Instance.StartFadeOut();
						if (EEKJMDHEJCK)
						{
							GICKCMPLNNK = true;
							Close();
						}
						else
						{
							JNHCICHFNHL();
							CKCMOJEIKAG(true);
							EmailInput.enabled = true;
							MessageInput.enabled = true;
							HLJMJBDIKKK = false;
							FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.SupportFailedDialog, false);
						}
					})
				});
			}
		}

		protected override void BLELAMHLLNN()
		{
			base.BLELAMHLLNN();
			if (AHEAGFKDBHP == 1 && !HLJMJBDIKKK && !LBADBOLDJFH)
			{
				StartCoroutine(WaitCompress(null));
			}
		}

		public IEnumerator WaitCompress(Action<bool> NMKJKNDDOAG)
		{
			if (!HLJMJBDIKKK && !LBADBOLDJFH)
			{
				HLJMJBDIKKK = true;
				if (FLEPELKJBGN == null)
				{
					GBFAPADEBEC.IIHHGNAACEG(IBDBPGIEAJE);
				}
				while (FLEPELKJBGN == null)
				{
					yield return null;
				}
				if ("abort".Equals(FLEPELKJBGN))
				{
					HLJMJBDIKKK = false;
					LBADBOLDJFH = false;
					if (NMKJKNDDOAG != null)
					{
						NMKJKNDDOAG(false);
					}
					yield break;
				}
				LBADBOLDJFH = true;
				HLJMJBDIKKK = false;
			}
			if (NMKJKNDDOAG != null)
			{
				NMKJKNDDOAG(true);
			}
		}

		public void OnSupportTicketUploadComplete(bool EEKJMDHEJCK)
		{
			LoadingScreenDisplayer.Instance.StartFadeOut();
			if (EEKJMDHEJCK)
			{
				GICKCMPLNNK = true;
				Close();
				return;
			}
			JNHCICHFNHL();
			CKCMOJEIKAG(true);
			EmailInput.enabled = true;
			MessageInput.enabled = true;
			HLJMJBDIKKK = false;
			FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.SupportFailedDialog, false);
		}

		public bool IsValidEmailAddress(string IBBBMACIBGK)
		{
			if (IBBBMACIBGK == null || IBBBMACIBGK.Length == 0)
			{
				return false;
			}
			Regex regex = new Regex("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
			return regex.IsMatch(IBBBMACIBGK);
		}

		private void CKCMOJEIKAG(bool IDEOALCKAEJ)
		{
			if (SendButtonContainer.activeSelf != IDEOALCKAEJ)
			{
				SendButtonContainer.SetActive(IDEOALCKAEJ);
			}
			if (SendButtonContainerDisabled.activeSelf == IDEOALCKAEJ)
			{
				SendButtonContainerDisabled.SetActive(!IDEOALCKAEJ);
			}
		}

		private void CBHHFENKOAP()
		{
			bool flag = IsValidEmailAddress(EmailInput.text);
			bool flag2 = !string.IsNullOrEmpty(MessageInput.text.Trim()) && !MessagePlaceHolder.enabled;
			bool iDEOALCKAEJ = flag && flag2;
			CKCMOJEIKAG(iDEOALCKAEJ);
		}

		public void OnMessageFieldValueChange()
		{
			IFMAKLJLCMF(MessageInput, MessagePlaceHolder);
			CBHHFENKOAP();
		}

		public void OnMessageFieldEndEdit()
		{
			IFMAKLJLCMF(MessageInput, MessagePlaceHolder);
			CBHHFENKOAP();
		}

		public void OnEmailFieldValueChanged()
		{
			IFMAKLJLCMF(EmailInput, EmailPlaceHolder);
			CBHHFENKOAP();
		}

		public void OnEmailFieldEndEdit()
		{
			IFMAKLJLCMF(EmailInput, EmailPlaceHolder);
			CBHHFENKOAP();
		}

		private void IFMAKLJLCMF(InputField MOPCLEEGDFB, Text KNNMGOHIFIG)
		{
			bool flag = MOPCLEEGDFB.text.Trim() == string.Empty;
			if (flag && !KNNMGOHIFIG.enabled)
			{
				KNNMGOHIFIG.enabled = true;
			}
			else if (!flag && KNNMGOHIFIG.enabled)
			{
				KNNMGOHIFIG.enabled = false;
			}
		}

		public override void OnDialogClosed()
		{
			base.OnDialogClosed();
			if (GICKCMPLNNK)
			{
				FHAAAFAAMDO.GABGKBAKHDP.GLHIMFPOKHD();
				FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.SupportSuccessDialog, false);
				AFJPGLHKOID.CPIGOAGGLBM("SupportSend", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString());
			}
		}

		public void SetChatMessage(EKPAJFBBAJC NOBNPDKGOLD)
		{
			AHEAGFKDBHP = 2;
			MOJHEMIODFL = NOBNPDKGOLD;
		}

		[CompilerGenerated]
		private void DPJAHKGLNMG(bool DIDHNNMKJFE)
		{
			if (DIDHNNMKJFE)
			{
				string text = EmailInput.text;
				string text2 = MessageInput.text;
				MFODECOOJLA item = new MFODECOOJLA(text, text2, FLEPELKJBGN, OnSupportTicketUploadComplete);
				KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH> { item });
			}
			else
			{
				OnSupportTicketUploadComplete(false);
			}
		}

		[CompilerGenerated]
		private void JAPCCBKGIFE(bool EEKJMDHEJCK)
		{
			LoadingScreenDisplayer.Instance.StartFadeOut();
			if (EEKJMDHEJCK)
			{
				GICKCMPLNNK = true;
				Close();
				return;
			}
			JNHCICHFNHL();
			CKCMOJEIKAG(true);
			EmailInput.enabled = true;
			MessageInput.enabled = true;
			HLJMJBDIKKK = false;
			FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.SupportFailedDialog, false);
		}
	}
}
