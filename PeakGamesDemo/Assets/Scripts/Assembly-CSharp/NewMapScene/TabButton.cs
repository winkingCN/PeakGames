using Assets.Scripts.Utils;
using DG.Tweening;
using UnityEngine;

namespace NewMapScene
{
	public class TabButton : MonoBehaviour
	{
		public Transform SelectedContainer;

		public Transform NotSelectedContainer;

		public Transform Label;

		private bool OIMCHDPNJBL;

		private Tweener DPCJCKGNMND;

		public void Select(bool MOBADLDCMNC, bool ODJGLICBNKH = true)
		{
			OIMCHDPNJBL = MOBADLDCMNC;
			SelectedContainer.gameObject.SetActive(OIMCHDPNJBL);
			NotSelectedContainer.gameObject.SetActive(!OIMCHDPNJBL);
			if (Label == null)
			{
				return;
			}
			Label.transform.localScale = Vector3.one;
			if (OIMCHDPNJBL && ODJGLICBNKH)
			{
				if (DPCJCKGNMND != null)
				{
					DPCJCKGNMND.Kill();
				}
				base.transform.localScale = Vector3.one * 0.9f;
				DPCJCKGNMND = base.transform.DOScale(1f, 0.2f).SetEase(Ease.OutBack);
				DPCJCKGNMND.easeOvershootOrAmplitude = 3f;
				AudioManager.Play(KOOGPFAPGGD.UiClick, GCEAKOOGDJK.Multiple);
			}
		}
	}
}
