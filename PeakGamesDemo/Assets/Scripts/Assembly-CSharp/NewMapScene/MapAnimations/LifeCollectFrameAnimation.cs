using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace NewMapScene.MapAnimations
{
	public class LifeCollectFrameAnimation : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class BCFHHMHBMCA
		{
			internal float INIGLDNBNJD;

			internal LifeCollectFrameAnimation PDAPIGLEPGC;

			internal float AGFNGEFDHLA()
			{
				return INIGLDNBNJD;
			}

			internal void KDACLOKGNAM(float AMFCENFNAJJ)
			{
				INIGLDNBNJD = AMFCENFNAJJ;
			}

			internal void DBLIJBPNCAN()
			{
				PDAPIGLEPGC.CurrentAnimator.speed = INIGLDNBNJD;
			}
		}

		public Animator CurrentAnimator;

		private void Start()
		{
			CurrentAnimator.speed = 1.5f;
			float INIGLDNBNJD = CurrentAnimator.speed;
			DOTween.To(() => INIGLDNBNJD, delegate(float AMFCENFNAJJ)
			{
				INIGLDNBNJD = AMFCENFNAJJ;
			}, 0.5f, 0.5f).OnUpdate(delegate
			{
				CurrentAnimator.speed = INIGLDNBNJD;
			}).SetDelay(0.7f);
		}
	}
}
