using UnityEngine.Events;

namespace Assets.Scripts.CasualTools.Dialogs
{
	public class EventBasedTouch : BaseButton
	{
		public UnityEvent m_OnClick;

		public override void ButtonUp(bool GKCFJEGLPNO)
		{
		}

		public override void ButtonDown()
		{
			if (CanBeClicked)
			{
				PerformAction();
			}
		}

		public override void PerformAction()
		{
			if (m_OnClick != null)
			{
				m_OnClick.Invoke();
			}
		}
	}
}
