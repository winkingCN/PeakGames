using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.Utils;
using GamePlayScene.Mechanics.Items;
using UnityEngine;

namespace GamePlayScene.Mechanics
{
	public class ChainController : MonoBehaviour
	{
		private static ChainController KNPOFJNFLJB;

		private readonly List<ChainItem> PHPBHBDAICK = new List<ChainItem>();

		public static ChainController GABGKBAKHDP
		{
			get
			{
				if (KNPOFJNFLJB == null)
				{
					GameObject gameObject = new GameObject();
					ChainController kNPOFJNFLJB = gameObject.AddComponent<ChainController>();
					KNPOFJNFLJB = kNPOFJNFLJB;
				}
				return KNPOFJNFLJB;
			}
		}

		public void RegisterChainItem(ChainItem CAIGKMCOGFM)
		{
			PHPBHBDAICK.Add(CAIGKMCOGFM);
		}

		private void Update()
		{
			if (SlowCheckTime.ShouldPass() || FallManager.AreThereFallingItems())
			{
				return;
			}
			int i = 0;
			for (int count = PHPBHBDAICK.Count; i < count; i++)
			{
				ChainItem chainItem = PHPBHBDAICK[i];
				if (chainItem != null)
				{
					chainItem.UpdateEmptyCellCount();
				}
			}
		}

		public static void ResetSelf()
		{
			if (KNPOFJNFLJB != null)
			{
				KNPOFJNFLJB.PHPBHBDAICK.Clear();
				Object.Destroy(KNPOFJNFLJB.gameObject);
				KNPOFJNFLJB = null;
			}
		}
	}
}
