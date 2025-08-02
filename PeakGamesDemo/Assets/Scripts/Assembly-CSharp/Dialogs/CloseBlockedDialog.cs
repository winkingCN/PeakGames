namespace Dialogs
{
	public class CloseBlockedDialog : DefaultDialog
	{
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
