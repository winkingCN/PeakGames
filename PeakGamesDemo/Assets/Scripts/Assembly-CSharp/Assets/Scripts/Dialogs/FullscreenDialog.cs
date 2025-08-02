namespace Assets.Scripts.Dialogs
{
	public abstract class FullscreenDialog : SimpleDialog
	{
		public override bool CanHandleBackButton()
		{
			return false;
		}

		public override bool CanCloseOnBlackPanelTouch()
		{
			return false;
		}

		public override bool CanBlockFocusAnimations()
		{
			return true;
		}
	}
}
