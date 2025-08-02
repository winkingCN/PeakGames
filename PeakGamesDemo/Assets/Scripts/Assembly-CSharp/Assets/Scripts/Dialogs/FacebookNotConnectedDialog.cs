using Assets.Scripts.CasualTools.Dialogs;

namespace Assets.Scripts.Dialogs
{
	public class FacebookNotConnectedDialog : SimpleDialog
	{
		private bool HKMAKLENKEK;

		private Dialog EBAMFFGOJAG;

		public override void DialogCreated()
		{
			base.DialogCreated();
			if (FHAAAFAAMDO.GABGKBAKHDP.COCNAAGPOMN)
			{
				EBAMFFGOJAG = FHAAAFAAMDO.GABGKBAKHDP.NGIEPDBBJBP();
			}
		}

		public void ConnectToFacebook()
		{
			HKMAKLENKEK = true;
			Close();
		}

		public override void OnDialogClosed()
		{
			base.OnDialogClosed();
			if (HKMAKLENKEK)
			{
				IIMOEAOONKA.GABGKBAKHDP.KCLJAABIMED("fail", KAKOONJCENE.LoginInOk, CECMINAKHFJ);
			}
			else if (EBAMFFGOJAG != null)
			{
				EBAMFFGOJAG.ShowSelf();
			}
		}

		private void CECMINAKHFJ(bool EEKJMDHEJCK)
		{
			if (!EEKJMDHEJCK)
			{
				Dialog dialog = FHAAAFAAMDO.GABGKBAKHDP.NGIEPDBBJBP();
				if (dialog != null)
				{
					dialog.HideSelf();
				}
			}
		}
	}
}
