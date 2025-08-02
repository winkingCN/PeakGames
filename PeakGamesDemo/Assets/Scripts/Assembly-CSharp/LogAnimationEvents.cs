using GamePlayScene.Mechanics.Items;
using UnityEngine;

public class LogAnimationEvents : MonoBehaviour
{
	public LogItem CurrentLogItem;

	public void OnLoopeEnd()
	{
		CurrentLogItem.OnLoopEnd();
	}

	public void OnExplodeStart()
	{
		CurrentLogItem.OnExplodeStart();
	}
}
