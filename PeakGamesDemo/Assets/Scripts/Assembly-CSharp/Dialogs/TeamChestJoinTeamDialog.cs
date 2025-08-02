using Assets.Scripts.MapScene;

namespace Dialogs
{
	public class TeamChestJoinTeamDialog : OnCloseCallbackDialog
	{
		public void OnClick()
		{
			Close();
			MapManager.Instance.CurrentContainerManager.SlideToPosition(1);
			MapManager.Instance.CurrentSocialHelper.CurrentNotJoinedContainer.SelectTab(0);
		}
	}
}
