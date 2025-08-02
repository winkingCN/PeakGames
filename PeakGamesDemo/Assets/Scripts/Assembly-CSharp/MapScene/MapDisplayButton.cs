using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.Utils;
using UnityEngine;
using UnityEngine.Events;

namespace MapScene
{
	public class MapDisplayButton : SpriteButton
	{
		public bool CanBeAnimated;

		public UnityEvent m_OnClick;

		private Vector3 FHKJNJKIDNE = Vector3.one;

		public void SetLocalScale(float HJLOCAEAFMJ)
		{
			FHKJNJKIDNE = Vector3.one * HJLOCAEAFMJ;
		}

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
				base.gameObject.transform.localScale = FHKJNJKIDNE - Vector3.one * 0.06f;
			}
		}

		public override void ButtonUp(bool AJICEJDODNC)
		{
			if (CanBeAnimated)
			{
				base.gameObject.transform.localScale = FHKJNJKIDNE;
			}
			if (CanBeClicked && AJICEJDODNC)
			{
				PerformAction();
			}
		}
	}
}
