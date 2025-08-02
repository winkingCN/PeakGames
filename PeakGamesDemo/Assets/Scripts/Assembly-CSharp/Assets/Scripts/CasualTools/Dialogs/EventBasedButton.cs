using UnityEngine.Events;

namespace Assets.Scripts.CasualTools.Dialogs
{
	public class EventBasedButton : BaseButton
	{
		public UnityEvent m_OnClick;

		public override void PerformAction()
		{
			if (m_OnClick != null)
			{
				m_OnClick.Invoke();
			}
		}
	}
}
