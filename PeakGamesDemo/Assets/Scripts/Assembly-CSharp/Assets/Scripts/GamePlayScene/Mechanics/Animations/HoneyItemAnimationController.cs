using GamePlayScene.Mechanics.Items;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Animations
{
	public class HoneyItemAnimationController : MonoBehaviour
	{
		public HoneyItem CurrentItem;

		public void BurstAnimationStarted()
		{
			CurrentItem.BringToFront();
		}

		public void BurstAnimationEnded()
		{
			CurrentItem.SendToBack();
		}
	}
}
