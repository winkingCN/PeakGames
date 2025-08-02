using Assets.Scripts.Dialogs;
using UnityEngine;

namespace Dialogs
{
	public class ResultDialog : SimpleDialog
	{
		public GameObject MainDialog;

		public override void PlayDialogInAnimation()
		{
			MainDialog.SetActive(false);
			base.gameObject.SetActive(true);
			base.PlayDialogInAnimation();
		}
	}
}
