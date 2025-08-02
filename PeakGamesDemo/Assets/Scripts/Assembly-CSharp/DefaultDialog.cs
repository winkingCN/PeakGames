using System;
using Assets.Scripts.Dialogs;

public class DefaultDialog : SimpleDialog
{
	public Action OnDialogClosedAction;

	public override void OnDialogClosed()
	{
		base.OnDialogClosed();
		try
		{
			if (OnDialogClosedAction != null)
			{
				OnDialogClosedAction();
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.DialogManager, "Error in closing default dialog: {0}", ex.Message);
		}
	}
}
