using Assets.Scripts.CasualTools.Dialogs;
using UnityEngine;

namespace CasualTools.Dialogs
{
	public class TouchBoundsListener : MonoBehaviour
	{
		public static TouchBoundsListener Instance;

		private void Awake()
		{
			if (Instance == null || Instance != this)
			{
				Instance = this;
			}
		}

		private void OnDestroy()
		{
			if (Instance == this)
			{
				Instance = null;
			}
		}

		public void CloseCurrentDialogOnOuterClick(Vector3 ADMHOIGNGAK, Vector3 HMJECFEIOHF, GameObject DBAHBGDAFEP)
		{
			FHAAAFAAMDO fHAAAFAAMDO = FHAAAFAAMDO.GABGKBAKHDP;
			if (DBAHBGDAFEP != null || !fHAAAFAAMDO.COCNAAGPOMN)
			{
				return;
			}
			Dialog dialog = fHAAAFAAMDO.NGIEPDBBJBP();
			if (!(dialog == null) && dialog.CanCloseOnBlackPanelTouch())
			{
				Bounds dialogBounds = fHAAAFAAMDO.NGIEPDBBJBP().GetDialogBounds();
				ADMHOIGNGAK.z = 0f;
				HMJECFEIOHF.z = 0f;
				if (!dialogBounds.Contains(ADMHOIGNGAK) && !dialogBounds.Contains(HMJECFEIOHF))
				{
					fHAAAFAAMDO.MJJLMBOPJMA();
				}
			}
		}
	}
}
