using NewMapScene;

namespace Dialogs
{
	public class FacebookConnectedDialog : DefaultDialog
	{
		public override void OnDialogClosed()
		{
			base.OnDialogClosed();
			if (ADEAGBKEGPG.CKOMGKGPEMO)
			{
				MapUIAnimationController instance = MapUIAnimationController.Instance;
				if (!(instance == null))
				{
					instance.StartCoinCollectAnimation(100);
				}
			}
		}
	}
}
