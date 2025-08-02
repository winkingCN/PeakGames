using System;
using Assets.Scripts.Dialogs;

namespace Dialogs
{
	public class CLPrelevelDialog : PrelevelDialog
	{
		public override void SetContent(int KIGOGMKCDKN, bool DLPNHOMMGGF = false, Action IMHLFAHONPP = null)
		{
			JCOKJJGCPHI = IMHLFAHONPP;
			EADEMDIHGHE = IDFPAFEJPPH.GABGKBAKHDP.KOPMPMIFHNF;
			PrelevelDialog.ChosenLevel = EADEMDIHGHE;
			TitleLabel.FCJBBPHFNPJ = IDFPAFEJPPH.GABGKBAKHDP.EGLOCAFPJCJ;
			for (int i = 0; i < FOHMHKLNLEG.Length && i < Boosters.Length; i++)
			{
				Boosters[i].Init(FOHMHKLNLEG[i], false, this);
			}
		}
	}
}
