using System.Text.RegularExpressions;
using Assets.Scripts.Dialogs;
using Assets.Scripts.MapScene;
using Assets.Scripts.Utils.Analytics;
using TMPro;
using ToonSocial;
using UnityEngine;
using Utils;

namespace Dialogs
{
	public class TeamEditDialog : SimpleDialog
	{
		public GameObject LoadingIndicator;

		public SpriteRenderer BadgeSpriteRenderer;

		public TextMeshPro TeamName;

		public TMP_InputField DescriptionInput;

		public TextMeshProUGUI DescriptionInputPlaceholder;

		public CreateTeamLevelSlider LevelSlider;

		public CreateTeamTypeSlider TypeSlider;

		private SocialHelper PFFCACADPKB;

		private bool HKFICKBKNBI;

		private string BDCEBCLLNNG;

		private string LGLNFMEFLCF;

		public void Start()
		{
			BDCEBCLLNNG = MDGKDGMGGCL.GABGKBAKHDP.PHOCMCOHANN();
			DescriptionInputPlaceholder.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Description") + "...";
			LGLNFMEFLCF = NKILHODNBDE.GHBGCADFLFB("Error_InvalidDescription");
		}

		public void Prepare(SocialHelper BHCIBOMDAIE)
		{
			PFFCACADPKB = BHCIBOMDAIE;
			GHANFPGCAJN();
		}

		private void GHANFPGCAJN()
		{
			DKBEJLGEAOA dKBEJLGEAOA = PFFCACADPKB.CurrentSession.COPDAKACHFM;
			TeamName.FCJBBPHFNPJ = dKBEJLGEAOA.PNGPLGHKFDI;
			BadgeSpriteRenderer.sprite = PFFCACADPKB.BadgesDictionary.GetBadge(dKBEJLGEAOA.FGPGOGEKDAM);
			DescriptionInput.FCJBBPHFNPJ = dKBEJLGEAOA.MMONLGJNACB;
			DescriptionInputPlaceholder.FCJBBPHFNPJ = dKBEJLGEAOA.MMONLGJNACB;
			TypeSlider.Force(dKBEJLGEAOA.IHLIGFJLDLJ);
			LevelSlider.Force((int)dKBEJLGEAOA.KOPMPMIFHNF);
			LevelSlider.CurrentSocialHelper = PFFCACADPKB;
			LoadingIndicator.SetActive(false);
		}

		public void Update()
		{
			PEJEHGMLKCC(DescriptionInput, DescriptionInputPlaceholder);
		}

		public void OnDescriptionChanged()
		{
			string text = DescriptionInput.FCJBBPHFNPJ;
			text = ILAMPCAFGIF.PJIBGAKHHFI(text);
			text = Regex.Replace(text, "\\s{2,}", " ");
			text = Regex.Replace(text, "<\\/?[a-z][a-z0-9]*[^<>]*>|<!--.*?-->", string.Empty);
			text = text.TrimStart();
			if (text.Length > 79)
			{
				text = text.Substring(0, 79);
			}
			text = ILAMPCAFGIF.PJIBGAKHHFI(text);
			if (DescriptionInput.FCJBBPHFNPJ != null)
			{
				DescriptionInput.FCJBBPHFNPJ = text;
			}
		}

		private static void PEJEHGMLKCC(TMP_InputField FEJFOKCKKAL, TextMeshProUGUI KNNMGOHIFIG)
		{
			bool flag = FEJFOKCKKAL.FCJBBPHFNPJ.Trim().Length == 0;
			if (FEJFOKCKKAL.MKAKFOEBMDF)
			{
				if (KNNMGOHIFIG.enabled)
				{
					KNNMGOHIFIG.enabled = false;
				}
				return;
			}
			if (flag && !KNNMGOHIFIG.enabled)
			{
				KNNMGOHIFIG.enabled = true;
			}
			if (!flag && KNNMGOHIFIG.enabled)
			{
				KNNMGOHIFIG.enabled = false;
			}
		}

		public void LockFields()
		{
			DescriptionInput.enabled = false;
			DescriptionInputPlaceholder.enabled = false;
			JBLHLNCOLHD();
		}

		public void UnlockFields()
		{
			DescriptionInput.enabled = true;
			DescriptionInputPlaceholder.enabled = true;
			JNHCICHFNHL();
		}

		public void OnCancelClick()
		{
			HKFICKBKNBI = true;
			Close();
		}

		public void OnSaveClick()
		{
			string text = DescriptionInput.FCJBBPHFNPJ;
			if (!string.IsNullOrEmpty(text) && !IBKHFKAANJP.DGGDDILJFBJ().OJEHDCCGHNC(text, BDCEBCLLNNG))
			{
				MapManager.Instance.ShowErrorMessage(LGLNFMEFLCF);
				return;
			}
			FHAAAFAAMDO.GABGKBAKHDP.MKLDLJHOHNA = true;
			LoadingIndicator.SetActive(true);
			LockFields();
			FMCDBPMDHGH();
		}

		private void FMCDBPMDHGH()
		{
			OnDescriptionChanged();
			PFFCACADPKB.JBBCCIBAGJC.BHAHMPONDOL += BOGMABFPOOD;
			PFFCACADPKB.CurrentSession.NMGBGAGMOGI.EGHCONCIBKE(DescriptionInput.FCJBBPHFNPJ, LevelSlider.Level, TypeSlider.IsClosed ? 1 : 0);
		}

		private void BOGMABFPOOD(bool EEKJMDHEJCK, long EMNOJOHFMEH)
		{
			JsonTeamEdit jsonTeamEdit = new JsonTeamEdit();
			jsonTeamEdit.badge_id = PFFCACADPKB.CurrentSession.COPDAKACHFM.FGPGOGEKDAM;
			jsonTeamEdit.country = PFFCACADPKB.CurrentSession.COPDAKACHFM.NKOHDLBCJBK;
			jsonTeamEdit.required_level_before = (int)PFFCACADPKB.CurrentSession.COPDAKACHFM.KOPMPMIFHNF;
			jsonTeamEdit.team_type_before = (PFFCACADPKB.CurrentSession.COPDAKACHFM.IHLIGFJLDLJ ? 1 : 0);
			jsonTeamEdit.team_description_before = HFFNPEPPBCC.OJHJEGCAPLF(PFFCACADPKB.CurrentSession.COPDAKACHFM.MMONLGJNACB);
			jsonTeamEdit.required_level = LevelSlider.Level;
			jsonTeamEdit.team_description = HFFNPEPPBCC.OJHJEGCAPLF(DescriptionInput.FCJBBPHFNPJ);
			jsonTeamEdit.LLGLAHKBJJG();
			PFFCACADPKB.JBBCCIBAGJC.BHAHMPONDOL -= BOGMABFPOOD;
			PFFCACADPKB.CurrentSession.COPDAKACHFM.MMONLGJNACB = DescriptionInput.FCJBBPHFNPJ;
			PFFCACADPKB.CurrentSession.COPDAKACHFM.IHLIGFJLDLJ = TypeSlider.IsClosed;
			PFFCACADPKB.CurrentSession.COPDAKACHFM.KOPMPMIFHNF = LevelSlider.Level;
			FHAAAFAAMDO.GABGKBAKHDP.MKLDLJHOHNA = false;
			AFJPGLHKOID.DBMNKIFNEHH(jsonTeamEdit, TypeSlider.IsClosed, PFFCACADPKB.CurrentSession.COPDAKACHFM.EEFMIHDPJPG.ToString());
			Close();
		}

		public override void OnDialogClosed()
		{
			base.OnDialogClosed();
			if (HKFICKBKNBI)
			{
				TeamInfoDialog component = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.SocialTeamInfoDialog, false).GetComponent<TeamInfoDialog>();
				component.Prepare(PFFCACADPKB.CurrentSession.COPDAKACHFM, PFFCACADPKB);
			}
		}
	}
}
