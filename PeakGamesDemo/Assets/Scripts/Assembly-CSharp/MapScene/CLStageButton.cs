using Assets.Scripts.Utils;
using Dialogs;
using UnityEngine;
using Utils;

namespace MapScene
{
	public class CLStageButton : LevelButton
	{
		protected override string AAGBDALMKEA(int GIOFHACJEGA)
		{
			return IDFPAFEJPPH.DALMNNKGINA(GIOFHACJEGA);
		}

		public override void OnLevelButtonClick()
		{
			if (!FHAAAFAAMDO.GABGKBAKHDP.COCNAAGPOMN)
			{
				AudioManager.Play(KOOGPFAPGGD.UiClick, GCEAKOOGDJK.Multiple);
				GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.CLPrelevelDialog, false, false, true);
				CLPrelevelDialog component = gameObject.GetComponent<CLPrelevelDialog>();
				if (component != null)
				{
					component.SetContent(IDFPAFEJPPH.GABGKBAKHDP.PDGLECFDLJJ);
				}
			}
		}
	}
}
