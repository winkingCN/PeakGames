using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Dialogs;
using Assets.Scripts.MapScene;
using Assets.Scripts.SceneTransitions;
using UnityEngine;
using Utils;

namespace ToonSocial.dialogs
{
	public class ReportChatConfirmationDialog : SimpleDialog
	{
		[CompilerGenerated]
		private sealed class LHMAFIKBFEB
		{
			internal bool EEKJMDHEJCK;

			internal int CHBAGODEDPP;

			internal ReportChatConfirmationDialog PDAPIGLEPGC;

			internal void AGFNGEFDHLA()
			{
				PDAPIGLEPGC.ActivateDialog(PDAPIGLEPGC);
				if (EEKJMDHEJCK)
				{
					if (MapManager.Instance != null)
					{
						MapManager.Instance.CurrentSocialHelper.CurrentJoinedContainer.ChatTab.ClearAll();
						MapManager.Instance.CurrentSocialHelper.JoinToTeam(LECPGNKOABP.GABGKBAKHDP.OADDPGNIINO, null);
					}
				}
				else
				{
					MapManager.Instance.ShowErrorMessageAtPosition(NKILHODNBDE.GHBGCADFLFB((CHBAGODEDPP > 0) ? "ReportChatError" : "ReportChatLimitReached"), new Vector3(0f, 0f, 0f));
				}
				PDAPIGLEPGC.Close();
			}
		}

		private EKPAJFBBAJC MOJHEMIODFL;

		private bool JDPIKGGHOAO = true;

		public void Prepare(EKPAJFBBAJC NOBNPDKGOLD)
		{
			MOJHEMIODFL = NOBNPDKGOLD;
		}

		public void OnYesClick()
		{
			JDPIKGGHOAO = false;
			JBLHLNCOLHD();
			StartCoroutine(IINKCBOCHBG());
		}

		private IEnumerator IINKCBOCHBG()
		{
			yield return null;
			ActivateDialog(false);
			LoadingScreenDisplayer.Instance.ShowLoading(KLKAGJKCKBE.Loading);
			DialogLibrary.GABGKBAKHDP.HideDialogBackground();
			NGKCKOCMLPE();
		}

		private void NGKCKOCMLPE()
		{
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
			{
				new DHEOPGNOBAH((int)LECPGNKOABP.GABGKBAKHDP.OADDPGNIINO, MapManager.Instance.CurrentSocialHelper.CurrentJoinedContainer.ChatTab.GetSameMessages(MOJHEMIODFL), delegate(bool EEKJMDHEJCK, int CHBAGODEDPP)
				{
					LoadingScreenDisplayer.Instance.StartFadeOut(delegate
					{
						ActivateDialog(this);
						if (EEKJMDHEJCK)
						{
							if (MapManager.Instance != null)
							{
								MapManager.Instance.CurrentSocialHelper.CurrentJoinedContainer.ChatTab.ClearAll();
								MapManager.Instance.CurrentSocialHelper.JoinToTeam(LECPGNKOABP.GABGKBAKHDP.OADDPGNIINO, null);
							}
						}
						else
						{
							MapManager.Instance.ShowErrorMessageAtPosition(NKILHODNBDE.GHBGCADFLFB((CHBAGODEDPP > 0) ? "ReportChatError" : "ReportChatLimitReached"), new Vector3(0f, 0f, 0f));
						}
						Close();
					});
				})
			});
		}

		public override bool CanCloseOnBlackPanelTouch()
		{
			return JDPIKGGHOAO;
		}

		[CompilerGenerated]
		private void KNCBIEOLFBC(bool EEKJMDHEJCK, int CHBAGODEDPP)
		{
			LoadingScreenDisplayer.Instance.StartFadeOut(delegate
			{
				ActivateDialog(this);
				if (EEKJMDHEJCK)
				{
					if (MapManager.Instance != null)
					{
						MapManager.Instance.CurrentSocialHelper.CurrentJoinedContainer.ChatTab.ClearAll();
						MapManager.Instance.CurrentSocialHelper.JoinToTeam(LECPGNKOABP.GABGKBAKHDP.OADDPGNIINO, null);
					}
				}
				else
				{
					MapManager.Instance.ShowErrorMessageAtPosition(NKILHODNBDE.GHBGCADFLFB((CHBAGODEDPP > 0) ? "ReportChatError" : "ReportChatLimitReached"), new Vector3(0f, 0f, 0f));
				}
				Close();
			});
		}
	}
}
