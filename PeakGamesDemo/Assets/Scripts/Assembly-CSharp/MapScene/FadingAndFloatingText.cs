using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace MapScene
{
	public class FadingAndFloatingText : MonoBehaviour
	{
		public TextMeshPro TextItSelf;

		public TextMeshPro Shadow;

		private Vector3 CGGPOBAJLKJ;

		private Vector3 CIHADLEFHGE;

		private Sequence BADHDINHKND;

		public void SetPosition(Vector3 FADJPCHMMBH)
		{
			CGGPOBAJLKJ = FADJPCHMMBH;
		}

		public void DoAnimation()
		{
			DoAnimation(1f, 2f, true);
		}

		public void DoAnimation(float JCCOPGOBLLG, float CBPBPILHPCL, bool LLKOGDGBEBE)
		{
			base.gameObject.SetActive(true);
			base.transform.position = CGGPOBAJLKJ;
			Color color = TextItSelf.color;
			color.a = 1f;
			TextItSelf.color = color;
			base.transform.localScale = Vector3.one * 0.1f;
			float endValue = CGGPOBAJLKJ.y + JCCOPGOBLLG;
			if (BADHDINHKND != null)
			{
				BADHDINHKND.Kill();
			}
			BADHDINHKND = DOTween.Sequence();
			BADHDINHKND.SetEase(Ease.Linear);
			BADHDINHKND.Insert(0f, base.transform.DOScale(1f, 0.1f).SetEase(Ease.OutSine));
			BADHDINHKND.Insert(0f, base.transform.DOMoveY(endValue, CBPBPILHPCL));
			if (LLKOGDGBEBE)
			{
				CBPBPILHPCL += 0.5f;
			}
			BADHDINHKND.Insert(CBPBPILHPCL, TextItSelf.OCHJNKODKNO(0f, 0.5f));
			BADHDINHKND.OnComplete(delegate
			{
				base.gameObject.SetActive(false);
			});
			if (!(Shadow == null))
			{
				Shadow.color = new Color(0f, 0f, 0f, 0.5882353f);
				BADHDINHKND.Insert(CBPBPILHPCL, Shadow.OCHJNKODKNO(0f, 0.5f));
			}
		}

		public void KillAnimation()
		{
			if (BADHDINHKND != null)
			{
				BADHDINHKND.Kill(true);
			}
		}

		public void OnEnable()
		{
			DoAnimation();
		}

		[CompilerGenerated]
		private void KJAJJJPEMFA()
		{
			base.gameObject.SetActive(false);
		}
	}
}
