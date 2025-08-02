using Assets.Scripts.GamePlayScene.Mechanics.Items;
using UnityEngine;

public class EasterEggTransformationWaiter : MonoBehaviour
{
	public EasterEggItem MasterEgg;

	public void AnimationEnded()
	{
		MasterEgg.TransformationEnded();
	}
}
