using System.Collections.Generic;
using Assets.Scripts.MapScene;
using TMPro;
using UnityEngine;

namespace Dialogs
{
	public class TeamTournamentAnnouncementDialog : OnCloseCallbackDialog
	{
		public TextMeshPro AnnouncementInfo;

		public TextMeshPro ButtonText;

		public Animator CurrentAnimator;

		private bool HCHJEBHINBG;

		public override void DialogCreated()
		{
			base.DialogCreated();
			if (CurrentAnimator != null)
			{
				CurrentAnimator.Play(Animator.StringToHash("Base Layer.TeamTournamentDialogCollectAnimation"));
			}
			KCKDNJOMPJH kCKDNJOMPJH = DGOMNDMPMBG.GABGKBAKHDP.FABKMFCBELE;
			if (kCKDNJOMPJH == null)
			{
				return;
			}
			if (kCKDNJOMPJH.GFEHMHDJKIF)
			{
				KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
				{
					new FBNFMCGHLEE(kCKDNJOMPJH.IFOAAOCJODG, kCKDNJOMPJH.INFAGKCBEHL, LECPGNKOABP.GABGKBAKHDP.OADDPGNIINO)
				});
			}
			if (!GFHPEDILAJG.GABGKBAKHDP.ODMCGBLJFKM)
			{
				AnnouncementInfo.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("TeamTournamentJoin");
				ButtonText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Join");
				HCHJEBHINBG = true;
				return;
			}
			KCKDNJOMPJH kCKDNJOMPJH2 = DGOMNDMPMBG.GABGKBAKHDP.FABKMFCBELE;
			if (LECPGNKOABP.GABGKBAKHDP.CPIKDFFHGCI < kCKDNJOMPJH2.GIEDINFFPNJ.userRewardLimit)
			{
				AnnouncementInfo.FCJBBPHFNPJ = string.Format(NKILHODNBDE.GHBGCADFLFB("TeamTournamentPlayerLimit"), kCKDNJOMPJH.GIEDINFFPNJ.userRewardLimit);
				ButtonText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Continue");
			}
			else
			{
				AnnouncementInfo.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("TeamTournamentWinLevel");
				ButtonText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Continue");
			}
		}

		public void ShowSocialTabIfNeeded()
		{
			Close();
			if (HCHJEBHINBG)
			{
				MapManager.Instance.CurrentContainerManager.SlideToPosition(1);
				MapManager.Instance.CurrentSocialHelper.CurrentNotJoinedContainer.SelectTab(0);
			}
		}
	}
}
