using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class JellyAnimatorWaiter : MonoBehaviour
	{
		[HideInInspector]
		public JellyItem MasterJelly;

		public Animator SpreadAnimator;

		public Renderer SpreadingSprite;

		public int DisplaySortNo;

		public void InformAnimationEnded()
		{
			SpreadAnimator.SetInteger("DIRECTION", 5);
			if (MasterJelly != null)
			{
				MasterJelly.AnimationEnded();
			}
		}

		public void DisplayAtFront()
		{
			SpreadingSprite.sortingLayerName = "Mechanics";
			SpreadingSprite.sortingOrder = DisplaySortNo;
		}

		public void HideIt()
		{
			SpreadingSprite.sortingLayerName = "Default";
			SpreadingSprite.sortingOrder = -10;
		}
	}
}
