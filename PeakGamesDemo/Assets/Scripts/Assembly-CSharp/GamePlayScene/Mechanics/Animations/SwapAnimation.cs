using System;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using DG.Tweening;
using GamePlayScene.Mechanics.Items;
using UnityEngine;

namespace GamePlayScene.Mechanics.Animations
{
	public class SwapAnimation : MonoBehaviour
	{
		public UfoItem CurrentUfoItem;

		public Action OnComplete;

		private const float LLKPMAMIAEM = 0.25f;

		private const float MMELGPDODCB = 0.15f;

		private Cell MCNJLNOBFBL;

		private Cell GIKPDAJONLB;

		public void Swap(Item CKCOPGFCKCN)
		{
			MCNJLNOBFBL = CurrentUfoItem.ENCFFNKONOO;
			GIKPDAJONLB = CKCOPGFCKCN.ENCFFNKONOO;
			MCNJLNOBFBL.RejectsFallInside();
			GIKPDAJONLB.RejectsFallInside();
			CurrentUfoItem.transform.DOMove(GIKPDAJONLB.GetFrozenPosition(), 0.25f).SetDelay(0.15f).OnComplete(GMMOLILNJJA);
			CKCOPGFCKCN.transform.DOMove(MCNJLNOBFBL.GetFrozenPosition(), 0.25f).SetDelay(0.15f);
			CurrentUfoItem.ENCFFNKONOO = GIKPDAJONLB;
			CKCOPGFCKCN.ENCFFNKONOO = MCNJLNOBFBL;
			CurrentUfoItem.PlaySwapAnimation();
		}

		private void GMMOLILNJJA()
		{
			MCNJLNOBFBL.AcceptsFallInside();
			GIKPDAJONLB.AcceptsFallInside();
			if (OnComplete != null)
			{
				OnComplete();
			}
		}
	}
}
