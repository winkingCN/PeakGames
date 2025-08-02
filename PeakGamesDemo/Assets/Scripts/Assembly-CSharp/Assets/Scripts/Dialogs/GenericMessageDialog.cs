using System;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.Dialogs
{
	public class GenericMessageDialog : SimpleDialog
	{
		public TextMeshPro Title;

		public TextMeshPro Message;

		[HideInInspector]
		public Action ActionToPerformOnClose;

		public override void OnDialogClosed()
		{
			if (ActionToPerformOnClose != null)
			{
				ActionToPerformOnClose();
			}
		}
	}
}
