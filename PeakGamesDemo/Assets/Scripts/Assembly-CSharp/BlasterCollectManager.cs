using System.Collections.Generic;
using UnityEngine;

public class BlasterCollectManager : MonoBehaviour
{
	public static BlasterCollectManager Instance;

	private bool FIEAKGKJJBP;

	public List<BlasterCollectAnimation>[] _collects = new List<BlasterCollectAnimation>[10];

	public void Awake()
	{
		Instance = this;
		for (int i = 0; i < 10; i++)
		{
			_collects[i] = new List<BlasterCollectAnimation>(90);
		}
	}

	public void OnDestroy()
	{
		ResetSelf();
	}

	public static void ResetSelf()
	{
		Instance = null;
	}

	public void LateUpdate()
	{
		if (!FIEAKGKJJBP)
		{
			return;
		}
		for (int i = 0; i < _collects.Length; i++)
		{
			List<BlasterCollectAnimation> list = _collects[i];
			if (list.Count != 0)
			{
				MCLFAHIMDIF fMFABAKPMLB = new MCLFAHIMDIF(list, list[0].NPBPGCMMLNE);
				int count = list.Count;
				for (int j = 0; j < count; j++)
				{
					BlasterCollectAnimation blasterCollectAnimation = list[j];
					blasterCollectAnimation.InsertDelays(fMFABAKPMLB, blasterCollectAnimation.HLOBGGHBOIM, j, count);
				}
				list.Clear();
			}
		}
		FIEAKGKJJBP = false;
	}

	public void Register(BlasterCollectAnimation FBGDKDAGGFL, int KAGMCIGFJBL)
	{
		FIEAKGKJJBP = true;
		_collects[KAGMCIGFJBL].Add(FBGDKDAGGFL);
	}
}
