using Assets.Scripts.MapScene;
using CasualTools.Dialogs;
using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.CasualTools.Dialogs
{
	public abstract class Dialog : MonoBehaviour
	{
		public float IPadOffsetY;

		public float IPadReferenceWidth = 10f;

		public float OffsetY;

		public TouchBounds TouchBounds;

		protected Bounds OIFNJALJLMD;

		public float ReferenceHeight = 11f;

		public float ReferenceWidth = 8f;

		public Transform ScalableAnimationTransform;

		public bool FANPAGHELKE { protected get; set; }

		public bool DNADNGGDHKE { protected get; set; }

		public int NCJFEFMJKFA { get; protected set; }

		public virtual void OnDialogClosed()
		{
			if (FANPAGHELKE)
			{
				MapManager.Instance.CurrentNewMapAnimationController.StartAnimationFlowOnFocusIn();
			}
		}

		public virtual void Close()
		{
			FHAAAFAAMDO.GABGKBAKHDP.GANLPGBOANC(this);
		}

		public virtual bool CanBlockFocusAnimations()
		{
			return false;
		}

		public abstract void PlayDialogInAnimation();

		public abstract Sequence PlayDialogOutAnimation();

		public abstract void DialogCreated();

		public abstract void SetDialogBounds();

		public abstract Bounds GetDialogBounds();

		public virtual void HideSelf()
		{
			base.gameObject.SetActive(false);
		}

		public virtual void ShowSelf()
		{
			base.gameObject.SetActive(true);
		}

		public abstract void PlayDialogOutFast();

		public virtual bool CanHandleBackButton()
		{
			return true;
		}

		public virtual bool CanCloseOnBlackPanelTouch()
		{
			return true;
		}

		public virtual bool ShouldBeClosedOnSceneChange()
		{
			return true;
		}
	}
}
