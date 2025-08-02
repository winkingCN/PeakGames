using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace NewMapScene.MapAnimations
{
	public class LifeUseFrameAnimation : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class FOLBADHFCLM
		{
			internal float INIGLDNBNJD;

			internal Action IMHLFAHONPP;

			internal LifeUseFrameAnimation PDAPIGLEPGC;

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

			internal void EFLLCMEPAEM()
			{
				PJPPADHKGHN.GABGKBAKHDP.EFFMBBAJLCF--;
				IMHLFAHONPP();
				UnityEngine.Object.Destroy(PDAPIGLEPGC.gameObject);
			}
		}

		public SpriteRenderer HeartSpriteRenderer;

		public Animator CurrentAnimator;

		private readonly Vector3 GCADBCDLANJ = new Vector3(2f, -2.5f, 0f);

		private readonly Vector3 HLLILKBLIFE = new Vector3(3f, -2f, 0f);

		private readonly Vector3 NNDAHHFMAPP = new Vector3(-1f, -2.5f, 0f);

		private readonly Vector3 PPFOCFFIMIF = new Vector3(-0.7f, -2f, 0f);

		public void StartAnimation(Vector3 KKAHENNAJJD, Vector3 HBKDNOHDOFG, float HJLOCAEAFMJ, Action IMHLFAHONPP)
		{
			base.transform.position = KKAHENNAJJD;
			base.transform.localScale = Vector3.one * 1.46f * HJLOCAEAFMJ;
			CurrentAnimator.speed = 1.5f;
			MKDNOGFMJIJ(KKAHENNAJJD, HBKDNOHDOFG, IMHLFAHONPP);
		}

		private void MKDNOGFMJIJ(Vector3 KKAHENNAJJD, Vector3 HBKDNOHDOFG, Action IMHLFAHONPP)
		{
			bool pEFHCKMBHOM = ONCMBJKLKIL.PEFHCKMBHOM;
			float num = HBKDNOHDOFG.y - KKAHENNAJJD.y;
			Vector3 vector = ((!pEFHCKMBHOM) ? GCADBCDLANJ : NNDAHHFMAPP);
			Vector3 jEJLEJBPJIJ = KKAHENNAJJD + vector;
			Vector3 vector2 = ((!pEFHCKMBHOM) ? HLLILKBLIFE : PPFOCFFIMIF);
			vector2.x += ((!pEFHCKMBHOM) ? UnityEngine.Random.Range(0f, 1f) : UnityEngine.Random.Range(0f, -0.5f));
			Vector3 mPNMKDOJKOM = HBKDNOHDOFG + vector2;
			float kCNCHPJAALL = 5f + num;
			LNEKBHIDOIG lNEKBHIDOIG = AMPCNLBLOIL.MBNNJGMFFAF(base.transform, KKAHENNAJJD, jEJLEJBPJIJ, mPNMKDOJKOM, HBKDNOHDOFG, 20, kCNCHPJAALL, Ease.InSine);
			Sequence iOBPBFOPFCH = lNEKBHIDOIG.IOBPBFOPFCH;
			float INIGLDNBNJD = CurrentAnimator.speed;
			DOTween.To(() => INIGLDNBNJD, delegate(float AMFCENFNAJJ)
			{
				INIGLDNBNJD = AMFCENFNAJJ;
			}, 0.5f, lNEKBHIDOIG.AEBACBBGHKI).OnUpdate(delegate
			{
				CurrentAnimator.speed = INIGLDNBNJD;
			});
			iOBPBFOPFCH.OnComplete(delegate
			{
				PJPPADHKGHN.GABGKBAKHDP.EFFMBBAJLCF--;
				IMHLFAHONPP();
				UnityEngine.Object.Destroy(base.gameObject);
			});
		}
	}
}
