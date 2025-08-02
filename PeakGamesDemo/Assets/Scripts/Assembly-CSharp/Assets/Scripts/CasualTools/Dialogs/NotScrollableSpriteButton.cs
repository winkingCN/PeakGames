using Assets.Scripts.Utils;
using Ui.VerticalScroll;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.CasualTools.Dialogs
{
	public class NotScrollableSpriteButton : SpriteButton
	{
		public UnityEvent m_OnClick;

		public override void ButtonDown()
		{
			base.ButtonDown();
			if (CanBeClicked)
			{
				LMILIEDFIFF();
				base.gameObject.transform.localScale = new Vector3(0.94f, 0.94f, 0.94f);
				VerticalScrollController.InvalidateScrolls();
			}
		}

		public override void ButtonUp(bool AJICEJDODNC)
		{
			base.ButtonUp(AJICEJDODNC);
			VerticalScrollController.InvalidateScrolls();
		}

		public override void PerformAction()
		{
			if (m_OnClick != null)
			{
				AudioManager.Play(KOOGPFAPGGD.UiClick, GCEAKOOGDJK.Multiple);
				m_OnClick.Invoke();
			}
		}
	}
}
