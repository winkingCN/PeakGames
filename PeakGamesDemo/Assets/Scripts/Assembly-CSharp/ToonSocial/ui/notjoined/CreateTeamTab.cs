using System;
using System.Text.RegularExpressions;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.MapScene;
using Dialogs.BuyCoins;
using NewMapScene;
using TMPro;
using ToonSocial.dialogs;
using UnityEngine;
using Utils;

namespace ToonSocial.ui.notjoined
{
	public class CreateTeamTab : TabPage
	{
		public TMP_InputField TeamNameInput;

		public TextMeshProUGUI TeamNameInputPlaceholder;

		public TMP_InputField DescriptionInput;

		public TextMeshProUGUI DescriptionInputPlaceholder;

		public CreateTeamLevelSlider LevelSlider;

		public CreateTeamTypeSlider TypeSlider;

		public Camera MainCamera;

		public EventBasedSpriteButton[] Buttons;

		public SpriteRenderer[] CreateTeamBacks;

		public SpriteRenderer BadgeIcon;

		public TextMeshPro[] CreateTeamButtonTexts;

		public SpriteRenderer CreateTeamButtonGold;

		public SocialHelper CurrentSocialHelper;

		public Badges CurrentBadges;

		public GameObject ActiveCreateButton;

		public GameObject PassiveCreateButton;

		public TextMeshPro CoinsTextPasive;

		public TextMeshPro CoinsText;

		public TMP_InputField[] InputFields;

		public ContainerManager CurrentContainerManager;

		private string MGLIGFFIGHM;

		public const int DescriptionTextCount = 79;

		private const int CIOCNMCMINB = 15;

		private IBKHFKAANJP EHLIIEELMGG;

		private string EGJCCINLPCO;

		public void Awake()
		{
			CKCMOJEIKAG(false);
			CoinsText.SetText(BOKGFGFPOHD.JNIADGLOLMP.FDNCJEHPFFJ.ToString());
			CoinsTextPasive.SetText(BOKGFGFPOHD.JNIADGLOLMP.FDNCJEHPFFJ.ToString());
			EHLIIEELMGG = IBKHFKAANJP.DGGDDILJFBJ();
			DescriptionInput.NCGHJDIFGBJ = 79;
		}

		private void OnEnable()
		{
			ClearContent();
		}

		public void ClearContent()
		{
			TeamNameInput.FCJBBPHFNPJ = string.Empty;
			DescriptionInput.FCJBBPHFNPJ = string.Empty;
			CKCMOJEIKAG(false);
			LevelSlider.Force(0);
			TypeSlider.Force(false);
			Update();
		}

		public override void Activate()
		{
			base.Activate();
			TeamNameInput.enabled = true;
			DescriptionInput.enabled = true;
			Sprite randomBadge = CurrentBadges.GetRandomBadge();
			BadgeIcon.sprite = randomBadge;
			MGLIGFFIGHM = randomBadge.name;
			InputFields = new TMP_InputField[2] { TeamNameInput, DescriptionInput };
			TeamNameInputPlaceholder.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("TeamName") + "...";
			DescriptionInputPlaceholder.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Description") + "...";
		}

		public override void Deactivate()
		{
			base.Deactivate();
			TeamNameInput.enabled = false;
			DescriptionInput.enabled = false;
			InputFields = null;
		}

		public void Update()
		{
			PEJEHGMLKCC(TeamNameInput, TeamNameInputPlaceholder);
			PEJEHGMLKCC(DescriptionInput, DescriptionInputPlaceholder);
			if (FHAAAFAAMDO.GABGKBAKHDP.COCNAAGPOMN && TeamNameInput.enabled)
			{
				TeamNameInput.enabled = false;
				DescriptionInput.enabled = false;
			}
			else if (!FHAAAFAAMDO.GABGKBAKHDP.COCNAAGPOMN && !TeamNameInput.enabled)
			{
				TeamNameInput.enabled = true;
				DescriptionInput.enabled = true;
			}
		}

		public void BrowseBadge()
		{
			SocialSelectBadgeDialog component = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.SocialSelectBadgeDialog, false).GetComponent<SocialSelectBadgeDialog>();
			component.Prepare(MainCamera, CurrentSocialHelper);
			component.OnBadgeSelected = FOCABFJBIDJ;
		}

		private void FOCABFJBIDJ(string FDMAHKFBNMI)
		{
			Sprite badge = CurrentSocialHelper.BadgesDictionary.GetBadge(FDMAHKFBNMI);
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.CreateTeam, "Selected badge is: {0}, and setting {1}", FDMAHKFBNMI, badge.name);
			MGLIGFFIGHM = FDMAHKFBNMI;
			BadgeIcon.sprite = badge;
		}

		public void CheckFields()
		{
			Update();
			string input = TeamNameInput.FCJBBPHFNPJ.Trim();
			input = Regex.Replace(input, "[^a-zA-Z0-9]", string.Empty);
			CKCMOJEIKAG(input.Length > 2);
		}

		public void OnTeamNameChanged()
		{
			try
			{
				TeamNameInput.FCJBBPHFNPJ = NFBBGJONNED(TeamNameInput.FCJBBPHFNPJ);
				CheckFields();
			}
			catch (Exception ex)
			{
				Debug.Log("Team Name Change Exception:" + ex.Message);
			}
		}

		public void OnDescriptionChanged()
		{
			string text = DescriptionInput.FCJBBPHFNPJ;
			text = Regex.Replace(text, "\\s{2,}", " ");
			text = Regex.Replace(text, "<\\/?[a-z][a-z0-9]*[^<>]*>|<!--.*?-->", string.Empty);
			text = text.TrimStart();
			text = ILAMPCAFGIF.PJIBGAKHHFI(text);
			if (text.Length > 79)
			{
				text = text.Substring(0, 79);
			}
			if (DescriptionInput.FCJBBPHFNPJ != null)
			{
				DescriptionInput.FCJBBPHFNPJ = text;
			}
			CheckFields();
		}

		private string NFBBGJONNED(string IBBBMACIBGK)
		{
			int length = IBBBMACIBGK.Length;
			IBBBMACIBGK = HFFNPEPPBCC.OJHJEGCAPLF(IBBBMACIBGK);
			if (length != IBBBMACIBGK.Length)
			{
				IPHBJCMJONN(NKILHODNBDE.GHBGCADFLFB("CharacterNotSupported"), Vector3.up * 1.12f);
			}
			IBBBMACIBGK = IBBBMACIBGK.TrimStart();
			if (IBBBMACIBGK.Length > 15)
			{
				IBBBMACIBGK = IBBBMACIBGK.Substring(0, 15);
			}
			return IBBBMACIBGK;
		}

		public void CreateTeamDisabled()
		{
			IPHBJCMJONN(NKILHODNBDE.GHBGCADFLFB("CreateTeamError"), Vector3.down * 1.12f);
		}

		private void IPHBJCMJONN(string NLOEBAMANDF, Vector3 HJBBHKNANMP)
		{
			MapManager.Instance.ShowErrorMessageAtPosition(NLOEBAMANDF, HJBBHKNANMP);
		}

		public void CreateTeam()
		{
			int num = BOKGFGFPOHD.JNIADGLOLMP.FDNCJEHPFFJ;
			int num2 = num - GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins);
			if (num2 > 0)
			{
				HLJHIJOGIBN.LKHOELJMLID = "TeamCreate";
				GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.BuyCoinsBundleDialog, false);
				BundleShopDialog component = gameObject.GetComponent<BundleShopDialog>();
				component.DoNotDisplayUnder(num2);
				return;
			}
			string gLFMIMLJAPI = MDGKDGMGGCL.GABGKBAKHDP.PHOCMCOHANN();
			string text = string.Empty;
			if (!EHLIIEELMGG.HBKMKHDLEBI(TeamNameInput.FCJBBPHFNPJ, gLFMIMLJAPI))
			{
				text = NKILHODNBDE.GHBGCADFLFB("Error_InvalidName");
			}
			else if (!EHLIIEELMGG.HBKMKHDLEBI(DescriptionInput.FCJBBPHFNPJ, gLFMIMLJAPI))
			{
				text = NKILHODNBDE.GHBGCADFLFB("Error_InvalidDescription");
			}
			if (!text.Equals(string.Empty))
			{
				MapManager.Instance.ShowErrorMessage(text);
				return;
			}
			OnTeamNameChanged();
			OnDescriptionChanged();
			CKCMOJEIKAG(false);
			PHGCFPNJLEI.DEIDLKIBDOB = null;
			SocialCreateUserDialog.UserCreationType = 1;
			PHGCFPNJLEI.DCPADMOLNML = "Create";
			CurrentSocialHelper.RequestCreateTeam(TeamNameInput.FCJBBPHFNPJ, DescriptionInput.FCJBBPHFNPJ, MGLIGFFIGHM, LevelSlider.Level, TypeSlider.IsClosed);
		}

		private void CKCMOJEIKAG(bool IDEOALCKAEJ)
		{
			if (ActiveCreateButton.activeSelf != IDEOALCKAEJ)
			{
				ActiveCreateButton.SetActive(IDEOALCKAEJ);
				PassiveCreateButton.SetActive(!IDEOALCKAEJ);
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
			TeamNameInput.enabled = false;
			TeamNameInputPlaceholder.enabled = false;
			DescriptionInput.enabled = false;
			DescriptionInputPlaceholder.enabled = false;
			CKCMOJEIKAG(false);
			EventBasedSpriteButton[] buttons = Buttons;
			foreach (EventBasedSpriteButton eventBasedSpriteButton in buttons)
			{
				if (eventBasedSpriteButton != null)
				{
					eventBasedSpriteButton.DisableButton();
				}
			}
		}

		public void UnLockFields()
		{
			OnTeamNameChanged();
			OnDescriptionChanged();
			TeamNameInput.enabled = true;
			TeamNameInputPlaceholder.enabled = false;
			DescriptionInput.enabled = true;
			DescriptionInputPlaceholder.enabled = false;
			CKCMOJEIKAG(true);
			EventBasedSpriteButton[] buttons = Buttons;
			foreach (EventBasedSpriteButton eventBasedSpriteButton in buttons)
			{
				if (eventBasedSpriteButton != null)
				{
					eventBasedSpriteButton.EnableButton();
				}
			}
		}
	}
}
