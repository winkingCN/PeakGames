using Assets.Scripts.Dialogs;
using TMPro;

namespace Dialogs
{
	public class ChestInfoDialog : SimpleDialog
	{
		public TextMeshPro MessageText;

		public void SetToonChestLevel(int GIJFOIEEBFE)
		{
			MessageText.FCJBBPHFNPJ = string.Format(NKILHODNBDE.GHBGCADFLFB("ReachLevelTopOpen"), GIJFOIEEBFE);
		}

		public void SetStarChestTargetCount(int ENMLICFLHAO)
		{
			MessageText.FCJBBPHFNPJ = string.Format(NKILHODNBDE.GHBGCADFLFB("StarChestInfoDialogContent"), ENMLICFLHAO);
		}
	}
}
