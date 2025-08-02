using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.Utils;
using UnityEngine;
using UnityEngine.Events;

namespace CasualTools.Dialogs
{
	public class MapChestButton : SpriteButton
	{
		public bool CanBeAnimated;

		public UnityEvent m_OnClick;

		public override void PerformAction()
		{
			if (m_OnClick != null)
			{
				AudioManager.Play(KOOGPFAPGGD.UiClick, GCEAKOOGDJK.Multiple);
				m_OnClick.Invoke();
			}
		}

		public override void ButtonDown()
		{
			if (CanBeClicked && CanBeAnimated)
			{
				base.gameObject.transform.localScale = new Vector3(0.94f, 0.94f, 0.94f);
			}
		}

		public override void ButtonUp(bool AJICEJDODNC)
		{
			if (CanBeAnimated)
			{
				base.gameObject.transform.localScale = Vector3.one;
			}
			if (CanBeClicked && AJICEJDODNC)
			{
				PerformAction();
			}
		}
	}
}
