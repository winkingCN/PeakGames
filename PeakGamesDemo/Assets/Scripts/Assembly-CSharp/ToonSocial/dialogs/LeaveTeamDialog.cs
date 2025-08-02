using Assets.Scripts.Dialogs;
using TMPro;
using UnityEngine;

namespace ToonSocial.dialogs
{
	public class LeaveTeamDialog : SimpleDialog
	{
		public TextMeshPro LeaveText;

		public Transform ButtonContainer;

		public GameObject WarningContainer;

		public GameObject Content;

		private SocialHelper KCMNBMGCKKI;

		public static LeaveTeamDialog ActiveOne;

		private bool IMJACEMEIOJ;

		private bool IAAAOIMDGNE;

		public override void DialogCreated()
		{
			base.DialogCreated();
			ActiveOne = this;
			KCKDNJOMPJH kCKDNJOMPJH = DGOMNDMPMBG.GABGKBAKHDP.FABKMFCBELE;
			if (MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() >= 21 && kCKDNJOMPJH != null && kCKDNJOMPJH.AEPLIGFCGIF == 2)
			{
				OPJDNNLKKGH();
			}
		}

		public void LeaveTeam()
		{
			if (!IMJACEMEIOJ)
			{
				IMJACEMEIOJ = true;
				KCMNBMGCKKI.RequestLeaveTeam();
				if (!IAAAOIMDGNE)
				{
					KCMNBMGCKKI.LoadingIcon.Display();
					IAAAOIMDGNE = true;
				}
				Content.SetActive(false);
			}
		}

		private void OPJDNNLKKGH()
		{
			Vector3 localPosition = LeaveText.ANLKLKAINEO.localPosition;
			localPosition.y = 1.73f;
			LeaveText.ANLKLKAINEO.localPosition = localPosition;
			LeaveText.KMADLHHGAIH = 6.3f;
			localPosition = ButtonContainer.localPosition;
			localPosition.y = -0.22f;
			ButtonContainer.localPosition = localPosition;
			WarningContainer.SetActive(true);
		}

		public override void OnDialogClosed()
		{
			if (IAAAOIMDGNE)
			{
				KCMNBMGCKKI.LoadingIcon.Hide();
			}
			base.OnDialogClosed();
			ActiveOne = null;
		}

		public void Prepare(SocialHelper JANPCBNIGFG)
		{
			KCMNBMGCKKI = JANPCBNIGFG;
		}

		public void SoftClose()
		{
			Close();
		}
	}
}
