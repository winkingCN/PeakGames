using System;
using System.Text.RegularExpressions;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.Dialogs;
using Assets.Scripts.MapScene;
using Assets.Scripts.Utils;
using TMPro;
using UnityEngine;

namespace ToonSocial.dialogs
{
	public class SocialCreateUserDialog : SimpleDialog
	{
		public bool IsInProgress = true;

		public TMP_InputField NickInputField;

		public EventBasedSpriteButton ContinueButton;

		public GameObject ActiveButton;

		public GameObject DeactiveButton;

		private static SocialCreateUserDialog LGNNAIDAMHJ;

		private bool INKPLNKKAEA;

		private bool BHCIFNKPGGN = true;

		private EIPCLBONPLC AMHKGOFOKGO;

		private bool PMFCIJBBCMA;

		public const int JOIN = 0;

		public const int CREATE = 1;

		public static int UserCreationType = -1;

		private IBKHFKAANJP EHLIIEELMGG;

		private int JODFKAPBJOE = 15;

		public void SetSession(EIPCLBONPLC JDFMMECNFKB)
		{
			AMHKGOFOKGO = JDFMMECNFKB;
		}

		public void Start()
		{
			CKCMOJEIKAG(false);
			EHLIIEELMGG = IBKHFKAANJP.DGGDDILJFBJ();
			NickInputField.NCGHJDIFGBJ = JODFKAPBJOE;
		}

		protected override void BLELAMHLLNN()
		{
			base.BLELAMHLLNN();
			AMHKGOFOKGO.IPCAELIMIBN.CurrentNotJoinedContainer.CurrentCreateTeamTab.UnLockFields();
			NickInputField.Select();
			PMFCIJBBCMA = true;
		}

		public void PostNick()
		{
			if (!JHOAHCHHBCH.CCAJIIFJPFF())
			{
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Connection"));
				Close();
				return;
			}
			EIIJIOKCNMG();
			string text = NickInputField.FCJBBPHFNPJ.Trim();
			if (text.Length >= 2)
			{
				string gLFMIMLJAPI = MDGKDGMGGCL.GABGKBAKHDP.PHOCMCOHANN();
				if (!EHLIIEELMGG.HBKMKHDLEBI(text, gLFMIMLJAPI))
				{
					MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_InvalidName"));
					return;
				}
				JBLHLNCOLHD();
				NickInputField.enabled = false;
				INKPLNKKAEA = true;
				MDMLFPDLFLE.JGCHLLMLCNI = true;
				AMHKGOFOKGO.NHHCGMIDPDK.MJIFKABFNAD(NickInputField.FCJBBPHFNPJ.Trim());
				Close();
			}
		}

		public bool IsPostSent()
		{
			return INKPLNKKAEA;
		}

		public void Update()
		{
			if (!SlowCheckTime.ShouldPass() && PMFCIJBBCMA && !NickInputField.MKAKFOEBMDF && NickInputField.enabled)
			{
				NickInputField.Select();
			}
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
			if (text.Length > JODFKAPBJOE)
			{
				text = text.Substring(0, JODFKAPBJOE);
			}
			NickInputField.FCJBBPHFNPJ = text;
		}

		private void IPHBJCMJONN()
		{
			string aELPGDIJOCN = NKILHODNBDE.GHBGCADFLFB("CharacterNotSupported");
			Vector3 fADJPCHMMBH = Vector3.down * 0.5f;
			MapManager.Instance.ShowErrorMessageAtPosition(aELPGDIJOCN, fADJPCHMMBH);
		}

		public override void OnDialogClosed()
		{
			base.OnDialogClosed();
			IsInProgress = false;
			LGNNAIDAMHJ = null;
		}

		public override void DialogCreated()
		{
			base.DialogCreated();
			LGNNAIDAMHJ = this;
		}

		public static void CloseActiveOne()
		{
			if (LGNNAIDAMHJ != null)
			{
				LGNNAIDAMHJ.Close();
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
	}
}
