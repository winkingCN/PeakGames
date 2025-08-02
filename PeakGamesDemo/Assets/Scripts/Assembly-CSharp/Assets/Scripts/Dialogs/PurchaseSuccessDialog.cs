using System;
using DG.Tweening;

namespace Assets.Scripts.Dialogs
{
	public class PurchaseSuccessDialog : SimpleDialog
	{
		private Action<NAAHKHPBAPA> JCOKJJGCPHI;

		private NAAHKHPBAPA OBPCNEIMCOF;

		public void Init(NAAHKHPBAPA HBBIFNLDKPO, Action<NAAHKHPBAPA> IMHLFAHONPP)
		{
			OBPCNEIMCOF = HBBIFNLDKPO;
			JCOKJJGCPHI = IMHLFAHONPP;
		}

		public override void OnDialogClosed()
		{
			base.OnDialogClosed();
			if (JCOKJJGCPHI != null)
			{
				JCOKJJGCPHI(OBPCNEIMCOF);
			}
		}

		public override void PlayDialogInAnimation()
		{
			base.PlayDialogInAnimation();
			Sequence s = DOTween.Sequence();
			s.AppendInterval(0.25f);
		}
	}
}
