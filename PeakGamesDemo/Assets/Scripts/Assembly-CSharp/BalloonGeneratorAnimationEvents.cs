using GamePlayScene.Mechanics.Items;
using UnityEngine;

public class BalloonGeneratorAnimationEvents : MonoBehaviour
{
	public BalloonGeneratorItem Master;

	public void OnAnimationCompleted()
	{
		Master.ThrowAnimationCompleteEventTriggered();
	}
}
