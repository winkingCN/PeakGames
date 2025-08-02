using Assets.Scripts.Utils;
using UnityEngine.Events;

namespace Assets.Scripts.CasualTools.Dialogs
{
	public class EventBasedSpriteButton : SpriteButton
	{
		public UnityEvent m_OnClick;

		public bool IsCloseButton;

		public override void PerformAction()
		{
			if (m_OnClick != null)
			{
				AudioManager.Play((!IsCloseButton) ? KOOGPFAPGGD.UiClick : KOOGPFAPGGD.UiClose, GCEAKOOGDJK.Multiple);
				m_OnClick.Invoke();
			}
		}
	}
}
