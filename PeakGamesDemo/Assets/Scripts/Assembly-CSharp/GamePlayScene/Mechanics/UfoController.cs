using System.Collections.Generic;
using Assets.Scripts.Utils;
using GamePlayScene.Mechanics.Items;
using UnityEngine;

namespace GamePlayScene.Mechanics
{
	public class UfoController : MonoBehaviour
	{
		private static UfoController KNPOFJNFLJB;

		private readonly List<UfoItem> FDDOPONELBK = new List<UfoItem>();

		public static UfoController GABGKBAKHDP
		{
			get
			{
				if (KNPOFJNFLJB == null)
				{
					GameObject gameObject = new GameObject();
					gameObject.AddComponent<UfoController>();
					KNPOFJNFLJB = gameObject.GetComponent<UfoController>();
				}
				return KNPOFJNFLJB;
			}
		}

		public void RegisterUfoItem(UfoItem AHGPFBFAIPN)
		{
			FDDOPONELBK.Add(AHGPFBFAIPN);
		}

		private void Update()
		{
			if (SlowCheckTime.ShouldPass())
			{
				return;
			}
			int i = 0;
			for (int count = FDDOPONELBK.Count; i < count; i++)
			{
				UfoItem ufoItem = FDDOPONELBK[i];
				if (!(ufoItem == null) && !ufoItem.TrySwap())
				{
					ufoItem.TryFall();
				}
			}
		}

		public static void ResetSelf()
		{
			if (KNPOFJNFLJB != null)
			{
				KNPOFJNFLJB.FDDOPONELBK.Clear();
				Object.Destroy(KNPOFJNFLJB.gameObject);
				KNPOFJNFLJB = null;
			}
		}
	}
}
