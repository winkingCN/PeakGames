using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace GamePlayScene.UI
{
	public class BlackPanel : MonoBehaviour
	{
		public static BlackPanel Instance;

		private Tween BCGMNJJAKDD;

		public SpriteRenderer CurrentBlackwindow;

		public BoxCollider2D CurrentCollider;

		private static readonly Color MAJCKCALFPK = new Color(0f, 0f, 0f, 0f);

		public void Awake()
		{
			Instance = this;
		}

		public void Start()
		{
			CurrentBlackwindow.transform.localScale = new Vector3(ONCMBJKLKIL.EMFKAPJMDCC, ONCMBJKLKIL.FHAMOHDEGMK, 1f);
		}

		public void OnDestroy()
		{
			Instance = null;
		}

		public static void ResetSelf()
		{
			Instance = null;
		}

		public void ShowPanel()
		{
			CurrentCollider.enabled = true;
			if (BCGMNJJAKDD != null && BCGMNJJAKDD.IsPlaying())
			{
				BCGMNJJAKDD.Kill();
			}
			else
			{
				CurrentBlackwindow.color = MAJCKCALFPK;
			}
			CurrentBlackwindow.enabled = true;
			BCGMNJJAKDD = CurrentBlackwindow.DOColor(new Color(0f, 0f, 0f, 0.8f), 0.35f).OnComplete(delegate
			{
				BCGMNJJAKDD = null;
			});
		}

		public void HidePanel()
		{
			CurrentCollider.enabled = false;
			if (BCGMNJJAKDD != null && BCGMNJJAKDD.IsPlaying())
			{
				BCGMNJJAKDD.Kill();
			}
			BCGMNJJAKDD = CurrentBlackwindow.DOColor(MAJCKCALFPK, 0.35f);
			BCGMNJJAKDD.OnComplete(delegate
			{
				CurrentBlackwindow.enabled = false;
				BCGMNJJAKDD = null;
			});
		}

		public void HidePanelFast()
		{
			CurrentCollider.enabled = false;
			if (BCGMNJJAKDD != null && BCGMNJJAKDD.IsPlaying())
			{
				BCGMNJJAKDD.Kill();
			}
			CurrentBlackwindow.color = MAJCKCALFPK;
		}

		[CompilerGenerated]
		private void LJLHPKGKFAK()
		{
			BCGMNJJAKDD = null;
		}

		[CompilerGenerated]
		private void MHLKECONMPK()
		{
			CurrentBlackwindow.enabled = false;
			BCGMNJJAKDD = null;
		}
	}
}
