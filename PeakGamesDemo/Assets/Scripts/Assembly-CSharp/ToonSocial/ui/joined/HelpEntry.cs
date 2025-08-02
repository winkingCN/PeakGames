using System.Collections;
using Assets.Scripts.MapScene;
using TMPro;
using UnityEngine;

namespace ToonSocial.ui.joined
{
	public class HelpEntry : ChatEntry
	{
		public GameObject HelpButton;

		public TextMeshPro HelpCountsText;

		public TextMeshPro HelpButtonText;

		private NBBAAJENFFN JJALFAMEALG;

		public GameObject[] Seperators;

		public GameObject[] BarSegments;

		public Transform LifeBar;

		public NBBAAJENFFN LifeRequest;

		public GameObject HelpButtonActive;

		public GameObject HelpButtonDisabled;

		private bool IFHJFFANGDF = true;

		public bool PCPIBNDIHMA
		{
			get
			{
				return IFHJFFANGDF;
			}
		}

		public override void Prepare(EKPAJFBBAJC KINKOCNMOMJ, SocialHelper JANPCBNIGFG)
		{
			IPCAELIMIBN = JANPCBNIGFG;
			CurrentChatMessage = KINKOCNMOMJ;
			LifeBar.transform.localPosition = new Vector3(0f, 1.478f, 0f);
			HelpButton.SetActive(true);
			EnableHelpButton();
			if (Sender != null)
			{
				string eALJKKBHDHK = KINKOCNMOMJ.DLDMKKEICMA.EALJKKBHDHK;
				AKGIJAMHMNA value;
				if (string.IsNullOrEmpty(eALJKKBHDHK) && IPCAELIMIBN.CurrentSession.COPDAKACHFM.HOINIMJNGFK.TryGetValue(KINKOCNMOMJ.DLDMKKEICMA.OCHADBCJEDP, out value))
				{
					eALJKKBHDHK = value.EALJKKBHDHK;
				}
				if (!string.IsNullOrEmpty(eALJKKBHDHK))
				{
					Sender.FCJBBPHFNPJ = eALJKKBHDHK;
				}
			}
			JJALFAMEALG = KINKOCNMOMJ.DLDMKKEICMA;
			if (JJALFAMEALG.HEANMKDLPGF())
			{
				IFHJFFANGDF = false;
			}
			int num = Mathf.Clamp(JJALFAMEALG.AKNLLPAHFOK, 0, 5);
			HelpCountsText.FCJBBPHFNPJ = num + "/5";
			for (int i = 0; i < 5; i++)
			{
				BarSegments[i].SetActive(i < num);
			}
			long num2 = LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM;
			if (JJALFAMEALG.OCHADBCJEDP == num2)
			{
				HelpButton.SetActive(false);
				LifeBar.transform.localPosition = new Vector3(1.21f, 1.56f, 0f);
				IFHJFFANGDF = false;
			}
			else if (num2 == JJALFAMEALG.EKEHIONIGNO || num2 == JJALFAMEALG.KPDACHNHNHG || num2 == JJALFAMEALG.CJMDFOCHDGB || num2 == JJALFAMEALG.JPKNMKEAHDM || num2 == JJALFAMEALG.LCLLDKHKLKP)
			{
				IFHJFFANGDF = false;
				OKFGCFFLFIJ();
			}
		}

		public void EnableHelpButton()
		{
			if (!HelpButtonActive.activeSelf)
			{
				HelpButtonActive.SetActive(true);
			}
			if (HelpButtonDisabled.activeSelf)
			{
				HelpButtonDisabled.SetActive(false);
			}
		}

		private void OKFGCFFLFIJ()
		{
			if (HelpButtonActive.activeSelf)
			{
				HelpButtonActive.SetActive(false);
			}
			if (!HelpButtonDisabled.activeSelf)
			{
				HelpButtonDisabled.SetActive(true);
			}
		}

		public void DisabledHelpClick()
		{
			MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_AlreadyHelped"));
		}

		public void HelpClicked()
		{
			OKFGCFFLFIJ();
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.HelpEntry, "User tried to help to {0}", JJALFAMEALG.OCHADBCJEDP);
			IPCAELIMIBN.CurrentSession.NMGBGAGMOGI.EIABEOOGKNK(JJALFAMEALG.OCHADBCJEDP);
			IPCAELIMIBN.CurrentMapUIAnimationController.PositionDictionary["LifeReq" + JJALFAMEALG.OCHADBCJEDP] = HelpButton.gameObject;
		}

		public void UpdateHelp(EKPAJFBBAJC NOBNPDKGOLD, SocialHelper JANPCBNIGFG)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.HelpEntry, "{0} help to {1}", NOBNPDKGOLD.KNMOIMNECKE, NOBNPDKGOLD.DLDMKKEICMA.EALJKKBHDHK);
			Prepare(NOBNPDKGOLD, JANPCBNIGFG);
			if (NOBNPDKGOLD.DLDMKKEICMA.HEANMKDLPGF())
			{
				new LLCJMMBBLEH(RemoveSelf());
			}
		}

		public IEnumerator RemoveSelf()
		{
			yield return MCJHHDACJBG.KNLADMIBAAD;
			IPCAELIMIBN.CurrentJoinedContainer.ChatTab.RemoveEntry(this, CurrentChatMessage);
		}
	}
}
