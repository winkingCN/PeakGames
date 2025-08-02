using UnityEngine;

namespace Assets.Scripts.CasualTools.Dialogs
{
	public abstract class BaseButton : MonoBehaviour
	{
		public bool CanBeClicked = true;

		public virtual void ButtonUp(bool GKCFJEGLPNO)
		{
			if (CanBeClicked && GKCFJEGLPNO)
			{
				PerformAction();
			}
		}

		public virtual void ButtonDown()
		{
		}

		public abstract void PerformAction();
	}
}
