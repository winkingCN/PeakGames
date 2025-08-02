using Assets.Scripts.GamePlayScene.Mechanics.Items;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Animations
{
	public class OysterItemAnimationController : MonoBehaviour
	{
		public OysterItem CurrentItem;

		public void AnimationStarted()
		{
			CurrentItem.BringToFront();
		}

		public void AnimationEnded()
		{
			CurrentItem.SendToBack();
		}
	}
}
