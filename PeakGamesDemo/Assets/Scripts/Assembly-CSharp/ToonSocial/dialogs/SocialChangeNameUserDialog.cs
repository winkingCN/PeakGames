using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.Dialogs;
using Assets.Scripts.MapScene;
using Assets.Scripts.Utils;
using DG.Tweening;
using Dialogs;
using TMPro;
using Ui.VerticalScroll;
using UnityEngine;

namespace ToonSocial.dialogs
{
	public class SocialChangeNameUserDialog : SimpleDialog
	{
		[CompilerGenerated]
		private sealed class PLGCFAJLJCH
		{
			internal string BAPHNHMONAC;

			internal SocialChangeNameUserDialog PDAPIGLEPGC;

			internal void AGFNGEFDHLA()
			{
				PDAPIGLEPGC.DescriptionText.FCJBBPHFNPJ = BAPHNHMONAC;
			}
		}

		public TMP_InputField NickInputField;

		public TextMeshPro DescriptionText;

		public TextMeshPro NewNickNameText;

		public TextMeshPro ChangeNameTitle;

		public TextMeshPro AreYouSureTitle;

		public ResultDialog FailedDialog;

		public ResultDialog SuccesDialog;

		public EventBasedSpriteButton ContinueButton;

		public GameObject EnabledContinueButton;

		public GameObject DisabledContinueButton;

		public GameObject EnabledYesButton;

		public GameObject DisabledYesButton;

		public GameObject EnterNameContainer;

		public GameObject AreYouSureContainer;

		public GameObject ContinueButtonContainer;

		public GameObject YesButtonContainer;

		public GameObject LoadingIndicator;

		private const int EHPELAKEAKJ = 0;

		private const int AKJNFKELGFA = 1;

		private int AJGPGBIEPJC = -1;

		private bool BHCIFNKPGGN = true;

		private bool PMFCIJBBCMA;

		private string LEDNMFLJPMJ;

		private IBKHFKAANJP EHLIIEELMGG;

		private SimpleDialog AELJLPJBIAH;

		private const int LPNEGBIJMAB = 15;

		public void Start()
		{
			CKCMOJEIKAG(false);
			EHLIIEELMGG = IBKHFKAANJP.DGGDDILJFBJ();
			NickInputField.NCGHJDIFGBJ = 15;
			FHAAAFAAMDO.ABPLPAEONPN(FailedDialog);
			FHAAAFAAMDO.ABPLPAEONPN(SuccesDialog);
			EnterNameContainer.SetActive(true);
			AreYouSureContainer.SetActive(false);
			LEDNMFLJPMJ = string.Empty;
			DescriptionText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("EnterNewName");
		}

		protected override void BLELAMHLLNN()
		{
			base.BLELAMHLLNN();
			NickInputField.Select();
			PMFCIJBBCMA = true;
			FailedDialog.DialogCreated();
			SuccesDialog.DialogCreated();
		}

		public void PostNick()
		{
			EIIJIOKCNMG();
			string text = NickInputField.FCJBBPHFNPJ.Trim();
			if (text.Length < 2)
			{
				return;
			}
			if (string.IsNullOrEmpty(LEDNMFLJPMJ))
			{
				string gLFMIMLJAPI = MDGKDGMGGCL.GABGKBAKHDP.PHOCMCOHANN();
				if (!EHLIIEELMGG.HBKMKHDLEBI(text, gLFMIMLJAPI))
				{
					MapManager.Instance.ShowErrorMessageAtPosition(NKILHODNBDE.GHBGCADFLFB("Error_InvalidName"), Vector3.down * 0.5f);
					return;
				}
				LEDNMFLJPMJ = text;
				KLBCJFMFNNE(1);
			}
			else if (LEDNMFLJPMJ != text)
			{
				MapManager.Instance.ShowErrorMessageAtPosition(NKILHODNBDE.GHBGCADFLFB("ChangeNameSame"), Vector3.down * 0.5f);
				KLBCJFMFNNE(0);
			}
			else
			{
				KLBCJFMFNNE(2);
			}
		}

		public void Update()
		{
			if (!SlowCheckTime.ShouldPass() && PMFCIJBBCMA && !NickInputField.MKAKFOEBMDF && NickInputField.enabled)
			{
				NickInputField.Select();
			}
		}

		public void ChangeNickName()
		{
			if (!JHOAHCHHBCH.CCAJIIFJPFF())
			{
				MapManager.Instance.ShowErrorMessageAtPosition(NKILHODNBDE.GHBGCADFLFB("Error_Connection"), Vector3.down * 0.5f);
				return;
			}
			if (string.IsNullOrEmpty(LEDNMFLJPMJ))
			{
				ELLLEGJEDCH(1);
				return;
			}
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.NameChange, "Changing nickname: {0} -> {1}", LECPGNKOABP.GABGKBAKHDP.KJACEODCOHN, LEDNMFLJPMJ);
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
			{
				new NLEGJCEFIBD(LEDNMFLJPMJ, ELLLEGJEDCH)
			});
			JBLHLNCOLHD();
			EnabledYesButton.SetActive(false);
			DisabledYesButton.SetActive(true);
			LoadingIndicator.SetActive(true);
		}

		public override void OnDialogClosed()
		{
			base.OnDialogClosed();
			if (AJGPGBIEPJC == 0)
			{
				VerticalScrollController.UnlockAllScrolls();
				FHAAAFAAMDO.GABGKBAKHDP.FPGFIAKIIID();
			}
		}

		private void ELLLEGJEDCH(int DIDHNNMKJFE)
		{
			LoadingIndicator.SetActive(false);
			if (DIDHNNMKJFE == 0)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.NameChange, "Nickname changed successfully!");
				AJGPGBIEPJC = 0;
				SuccesDialog.PlayDialogInAnimation();
				MHBOHLJEBOE();
			}
			else
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.NameChange, "Nickname change failed!");
				FailedDialog.PlayDialogInAnimation();
			}
		}

		private void MHBOHLJEBOE()
		{
			AFJPGLHKOID.NMOKOLHHNIH(LECPGNKOABP.GABGKBAKHDP.KJACEODCOHN, LEDNMFLJPMJ);
			LECPGNKOABP.GABGKBAKHDP.MHBOHLJEBOE(LEDNMFLJPMJ);
		}

		private void CKCMOJEIKAG(bool IDEOALCKAEJ)
		{
			if (!(ContinueButton == null) && BHCIFNKPGGN != IDEOALCKAEJ)
			{
				BHCIFNKPGGN = IDEOALCKAEJ;
				ContinueButton.CanBeClicked = IDEOALCKAEJ;
				EnabledContinueButton.transform.localScale = Vector3.one;
				EnabledContinueButton.SetActive(IDEOALCKAEJ);
				DisabledContinueButton.transform.localScale = Vector3.one;
				DisabledContinueButton.SetActive(!IDEOALCKAEJ);
			}
		}

		private void CBHHFENKOAP()
		{
			string input = NickInputField.FCJBBPHFNPJ.Trim();
			input = Regex.Replace(input, "[^a-zA-Z0-9]", string.Empty);
			CKCMOJEIKAG(input.Length > 2);
		}

		public void OnTextChange()
		{
			try
			{
				EIIJIOKCNMG();
				CBHHFENKOAP();
			}
			catch (Exception ex)
			{
				Debug.Log("Nickname Change Exception:" + ex.Message);
			}
		}

		private void EIIJIOKCNMG()
		{
			string text = NickInputField.FCJBBPHFNPJ ?? string.Empty;
			int length = text.Length;
			text = HFFNPEPPBCC.OJHJEGCAPLF(text);
			if (length != text.Length)
			{
				IPHBJCMJONN();
			}
			text = text.TrimStart();
			if (text.Length > 15)
			{
				text = text.Substring(0, 15);
			}
			NickInputField.FCJBBPHFNPJ = text;
		}

		private void IPHBJCMJONN()
		{
			string aELPGDIJOCN = NKILHODNBDE.GHBGCADFLFB("CharacterNotSupported");
			Vector3 fADJPCHMMBH = Vector3.down * 0.5f;
			MapManager.Instance.ShowErrorMessageAtPosition(aELPGDIJOCN, fADJPCHMMBH);
		}

		private void LIGIJHDKDJN(string BAPHNHMONAC)
		{
			Sequence s = DOTween.Sequence();
			s.Append(DescriptionText.ANLKLKAINEO.DOScale(0f, 0.15f));
			s.AppendCallback(delegate
			{
				DescriptionText.FCJBBPHFNPJ = BAPHNHMONAC;
			});
			s.Append(DescriptionText.ANLKLKAINEO.DOScale(1f, 0.15f).SetEase(Ease.OutBack));
		}

		private void NKIABHJNDBA()
		{
			Sequence s = DOTween.Sequence();
			s.Append(EnterNameContainer.transform.DOScale(0f, 0.15f));
			s.AppendCallback(delegate
			{
				EnterNameContainer.SetActive(false);
				AreYouSureContainer.SetActive(true);
				ChangeNameTitle.enabled = false;
				AreYouSureTitle.enabled = true;
				ContinueButtonContainer.SetActive(false);
				YesButtonContainer.SetActive(true);
			});
			s.Append(AreYouSureContainer.transform.DOScale(1f, 0.3f).SetEase(Ease.OutBack));
		}

		private void KLBCJFMFNNE(int EGEPICBFDAE)
		{
			NickInputField.FCJBBPHFNPJ = string.Empty;
			switch (EGEPICBFDAE)
			{
			case 0:
				EnterNameContainer.SetActive(true);
				AreYouSureContainer.SetActive(false);
				LEDNMFLJPMJ = string.Empty;
				LIGIJHDKDJN(NKILHODNBDE.GHBGCADFLFB("EnterNewName"));
				break;
			case 1:
				LIGIJHDKDJN(NKILHODNBDE.GHBGCADFLFB("EnterNewNameAgain"));
				break;
			case 2:
				NickInputField.enabled = false;
				NewNickNameText.FCJBBPHFNPJ = LEDNMFLJPMJ;
				NKIABHJNDBA();
				break;
			}
		}

		[CompilerGenerated]
		private void PBDLEGDBBPE()
		{
			EnterNameContainer.SetActive(false);
			AreYouSureContainer.SetActive(true);
			ChangeNameTitle.enabled = false;
			AreYouSureTitle.enabled = true;
			ContinueButtonContainer.SetActive(false);
			YesButtonContainer.SetActive(true);
		}
	}
}
