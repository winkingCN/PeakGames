using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.Dialogs;
using Assets.Scripts.MapScene;
using Assets.Scripts.Utils;
using Dialogs;
using TMPro;
using UnityEngine;
using Utils;

namespace ToonSocial.dialogs
{
	public class StarTournamentCreateUserDialog : SimpleDialog
	{
		public TMP_InputField NickInputField;

		public EventBasedSpriteButton ContinueButton;

		public GameObject ActiveButton;

		public GameObject DeactiveButton;

		public GameObject CloseButton;

		private bool PMFCIJBBCMA;

		private bool OBKNFCOAJLN;

		private bool BHCIFNKPGGN = true;

		private IBKHFKAANJP EHLIIEELMGG;

		private Action JCOKJJGCPHI;

		private const int LPNEGBIJMAB = 15;

		private void Start()
		{
			CKCMOJEIKAG(false);
			EHLIIEELMGG = IBKHFKAANJP.DGGDDILJFBJ();
			NickInputField.NCGHJDIFGBJ = ((!MCJHHDACJBG.NDNBMGMPBLF) ? 15 : 0);
		}

		protected override void BLELAMHLLNN()
		{
			base.BLELAMHLLNN();
			NickInputField.Select();
			PMFCIJBBCMA = true;
		}

		private void Update()
		{
			if (!SlowCheckTime.ShouldPass() && PMFCIJBBCMA && !NickInputField.MKAKFOEBMDF && NickInputField.enabled)
			{
				if (MCJHHDACJBG.MCPELNPBPIF)
				{
					NickInputField.Select();
				}
				else
				{
					NickInputField.ActivateInputField();
				}
			}
		}

		private void OKLGFPOCFJK()
		{
			CloseButton.SetActive(true);
		}

		public void PostNick()
		{
			if (!CKFMBPHBAJE())
			{
				return;
			}
			JBLHLNCOLHD();
			NickInputField.enabled = false;
			CKCMOJEIKAG(false);
			MAFNKMLNNMF item = new MAFNKMLNNMF(NickInputField.FCJBBPHFNPJ, delegate(int LENFKJMEBFP)
			{
				if (LENFKJMEBFP == 0)
				{
					AFJPGLHKOID.JIPLLFBJBIL(NickInputField.FCJBBPHFNPJ, 3);
					LECPGNKOABP.GABGKBAKHDP.MHBOHLJEBOE(NickInputField.FCJBBPHFNPJ);
					SocialHelper.RefreshUser();
					OBKNFCOAJLN = true;
					Close();
				}
				else
				{
					JNHCICHFNHL();
					OKLGFPOCFJK();
					CKCMOJEIKAG(true);
					NickInputField.enabled = true;
					MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Connection"));
				}
			});
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH> { item });
		}

		public void SetOnDialogClosedCallback(Action IMHLFAHONPP)
		{
			JCOKJJGCPHI = IMHLFAHONPP;
		}

		public override void OnDialogClosed()
		{
			if (OBKNFCOAJLN)
			{
				GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.StarTournamentInfoDialog, false);
				StarTournamentInfoDialog component = gameObject.GetComponent<StarTournamentInfoDialog>();
				component.SetOnDialogClosedCallback(JCOKJJGCPHI);
			}
			else if (JCOKJJGCPHI != null)
			{
				JCOKJJGCPHI();
			}
			base.OnDialogClosed();
		}

		private bool CKFMBPHBAJE()
		{
			if (!JHOAHCHHBCH.CCAJIIFJPFF())
			{
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Connection"));
				Close();
				return false;
			}
			EIIJIOKCNMG();
			string text = NickInputField.FCJBBPHFNPJ.Trim();
			if (text.Length < 2)
			{
				return false;
			}
			string gLFMIMLJAPI = MDGKDGMGGCL.GABGKBAKHDP.PHOCMCOHANN();
			if (!EHLIIEELMGG.HBKMKHDLEBI(text, gLFMIMLJAPI))
			{
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_InvalidName"));
				return false;
			}
			return true;
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

		private void CKCMOJEIKAG(bool IDEOALCKAEJ)
		{
			if (!(ContinueButton == null) && BHCIFNKPGGN != IDEOALCKAEJ)
			{
				BHCIFNKPGGN = IDEOALCKAEJ;
				ContinueButton.CanBeClicked = IDEOALCKAEJ;
				ActiveButton.SetActive(IDEOALCKAEJ);
				DeactiveButton.SetActive(!IDEOALCKAEJ);
			}
		}

		public override bool CanHandleBackButton()
		{
			return false;
		}

		public override bool CanCloseOnBlackPanelTouch()
		{
			return false;
		}

		[CompilerGenerated]
		private void KBKHPOAMEHJ(int LENFKJMEBFP)
		{
			if (LENFKJMEBFP == 0)
			{
				AFJPGLHKOID.JIPLLFBJBIL(NickInputField.FCJBBPHFNPJ, 3);
				LECPGNKOABP.GABGKBAKHDP.MHBOHLJEBOE(NickInputField.FCJBBPHFNPJ);
				SocialHelper.RefreshUser();
				OBKNFCOAJLN = true;
				Close();
			}
			else
			{
				JNHCICHFNHL();
				OKLGFPOCFJK();
				CKCMOJEIKAG(true);
				NickInputField.enabled = true;
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Connection"));
			}
		}
	}
}
