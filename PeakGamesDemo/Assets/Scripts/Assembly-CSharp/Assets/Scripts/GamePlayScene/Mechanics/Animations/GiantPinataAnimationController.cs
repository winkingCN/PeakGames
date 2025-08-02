using GamePlayScene.Mechanics.Items;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Animations
{
	public class GiantPinataAnimationController : MonoBehaviour
	{
		public Animator GiantPinataAnimator;

		public GiantPinataItem MasterItem;

		public void AnimationPlayed()
		{
			GiantPinataAnimator.SetInteger("DIRECTION", 0);
		}
	}
}
