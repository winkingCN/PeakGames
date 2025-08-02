using GamePlayScene.Mechanics.Items;
using UnityEngine;

public class BlasterAnimationScript : MonoBehaviour
{
	public BlasterItem Master;

	public void OnAnimationEvent()
	{
		if (Master != null)
		{
			Master.PlayCollectParticle();
		}
	}
}
