using System;
using UnityEngine;

public class Last5MovesAnimation : MonoBehaviour
{
	public Action OnPlayInSound;

	public Action OnPlayOutSound;

	public void PlayInSound()
	{
		if (OnPlayInSound != null)
		{
			OnPlayInSound();
		}
	}

	public void PlayOutSound()
	{
		if (OnPlayOutSound != null)
		{
			OnPlayOutSound();
		}
	}
}
