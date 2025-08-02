using System;
using Assets.Scripts.Dialogs;

namespace Dialogs
{
	public class OnCloseCallbackDialog : SimpleDialog
	{
		protected Action AMFCLGFBDJI;

		public void SetOnDialogClosedCallback(Action BHFCKIMLCMM)
		{
			AMFCLGFBDJI = BHFCKIMLCMM;
		}

		public override void OnDialogClosed()
		{
			if (AMFCLGFBDJI != null)
			{
				AMFCLGFBDJI();
			}
			base.OnDialogClosed();
		}
	}
}
