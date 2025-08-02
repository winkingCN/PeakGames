namespace Assets.Scripts.Dialogs
{
	public class FacebookLogoutConfirmation : SimpleDialog
	{
		private bool HKMAKLENKEK;

		public void LogoutFromFacebook()
		{
			HKMAKLENKEK = true;
			Close();
		}

		public override void OnDialogClosed()
		{
			base.OnDialogClosed();
			if (HKMAKLENKEK)
			{
				IIMOEAOONKA.GABGKBAKHDP.DNNNNBBFNDG();
			}
		}
	}
}
