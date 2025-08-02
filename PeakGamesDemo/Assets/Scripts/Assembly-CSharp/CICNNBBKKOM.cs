using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.GamePlayScene.Tutorials;
using Assets.Scripts.MapScene;
using DG.Tweening;
using Dialogs;
using MapScene;
using Ui.VerticalScroll;
using UnityEngine;
using Utils;

public class CICNNBBKKOM : OOHGOOPDAEM
{
	[CompilerGenerated]
	private sealed class CCAKOIEJCHE
	{
		internal MapTutorial AADBMFOIKKM;

		internal CICNNBBKKOM PDAPIGLEPGC;

		internal void AGFNGEFDHLA()
		{
			PDAPIGLEPGC.IPDAGPBIHDD.ClearClickOnceCallback();
			SpriteButtonListener.Instance.EnableClicks = false;
			if (PDAPIGLEPGC.CECMINAKHFJ != null)
			{
				PDAPIGLEPGC.CECMINAKHFJ(true);
			}
		}

		internal void KDACLOKGNAM()
		{
			PDAPIGLEPGC.DDOHJJCKLGK(false);
		}

		internal void DBLIJBPNCAN()
		{
			AADBMFOIKKM.HideTutorial();
		}

		internal void EFLLCMEPAEM()
		{
			AADBMFOIKKM.Remove();
		}

		internal void NNINHCPIBHO()
		{
			AADBMFOIKKM.FadeInBackground();
			Vector3 position = PDAPIGLEPGC.IPDAGPBIHDD.transform.position;
			position.x += 0.072f;
			position.y -= 2.25f;
			AADBMFOIKKM.ShowArrow(position);
		}
	}

	private readonly GameObject JGAKMKLFFNK;

	private readonly TeamTournamentDisplay IPDAGPBIHDD;

	public CICNNBBKKOM(TeamTournamentDisplay MMOPMIKOKAP, GameObject JFPFCMFNAEC, Action<bool> IMHLFAHONPP)
		: base(IMHLFAHONPP)
	{
		CENGNKJGOGP = "TeamTournamentAnimation";
		JGAKMKLFFNK = JFPFCMFNAEC;
		IPDAGPBIHDD = MMOPMIKOKAP;
	}

	public override void GDGINCNCMDD(bool ODCADGABBHJ, bool DEIGFPCALOJ)
	{
		KCKDNJOMPJH kCKDNJOMPJH = DGOMNDMPMBG.GABGKBAKHDP.FABKMFCBELE;
		if (kCKDNJOMPJH != null)
		{
			if (kCKDNJOMPJH.NPHPMJFFPGB && MapTutorial.ShouldDisplayTeamTournamentTutorial())
			{
				if (kCKDNJOMPJH.NPHGOHLHFKD)
				{
					MapTutorial.CompleteTeamTournamentTutorial();
					if (CECMINAKHFJ != null)
					{
						CECMINAKHFJ(false);
					}
				}
				else
				{
					SpriteButtonListener.Instance.EnableClicks = true;
					VerticalScrollController.UnlockAllScrolls();
					FHAAAFAAMDO.GABGKBAKHDP.FPGFIAKIIID(true);
					CPANOHJMNIO();
					kCKDNJOMPJH.BCBDPNPEKFI();
					kCKDNJOMPJH.JDBFNCMJMCH();
				}
			}
			else if (kCKDNJOMPJH.LMIPACNFAAB && !TeamTournamentRewardsDialog.DialogActive)
			{
				SpriteButtonListener.Instance.EnableClicks = true;
				VerticalScrollController.UnlockAllScrolls();
				FHAAAFAAMDO.GABGKBAKHDP.FPGFIAKIIID(true);
				GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.TeamTournamentRewardDialog, false);
				TeamTournamentRewardsDialog component = gameObject.GetComponent<TeamTournamentRewardsDialog>();
				component.PrepareDialog(EGFKMPGIFJB, DEIGFPCALOJ);
			}
			else if (kCKDNJOMPJH.BPDNGDOGLIO)
			{
				SpriteButtonListener.Instance.EnableClicks = true;
				GameObject gameObject2 = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.TeamTournamentInfoDialog, false);
				TeamTournamentInfoDialog component2 = gameObject2.GetComponent<TeamTournamentInfoDialog>();
				component2.SetOnDialogClosedCallback(EGFKMPGIFJB);
				kCKDNJOMPJH.BCBDPNPEKFI();
				kCKDNJOMPJH.JDBFNCMJMCH();
			}
			else if (kCKDNJOMPJH.LJGNJNOIAPH)
			{
				SpriteButtonListener.Instance.EnableClicks = true;
				GameObject gameObject3 = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.TeamTournamentAnnouncementDialog, false);
				TeamTournamentAnnouncementDialog component3 = gameObject3.GetComponent<TeamTournamentAnnouncementDialog>();
				component3.SetOnDialogClosedCallback(EGFKMPGIFJB);
				kCKDNJOMPJH.JDBFNCMJMCH();
			}
			else if (CECMINAKHFJ != null)
			{
				CECMINAKHFJ(false);
			}
		}
		else if (CECMINAKHFJ != null)
		{
			CECMINAKHFJ(false);
		}
	}

	private void EGFKMPGIFJB()
	{
		SpriteButtonListener.Instance.EnableClicks = false;
		if (CECMINAKHFJ != null)
		{
			CECMINAKHFJ(true);
		}
	}

	private void CPANOHJMNIO()
	{
		MapTutorial.CompleteTeamTournamentTutorial();
		MapTutorial.DidShowMapTutorialInCurrentFlow = true;
		GameObject gameObject = UnityEngine.Object.Instantiate(JGAKMKLFFNK);
		MapTutorial AADBMFOIKKM = gameObject.GetComponent<MapTutorial>();
		AADBMFOIKKM.Init(string.Empty, Vector3.zero, delegate
		{
			IPDAGPBIHDD.ClearClickOnceCallback();
			SpriteButtonListener.Instance.EnableClicks = false;
			if (CECMINAKHFJ != null)
			{
				CECMINAKHFJ(true);
			}
		}, delegate
		{
			DDOHJJCKLGK(false);
		});
		AADBMFOIKKM.EnableTutorialSkip();
		if (MapManager.Instance != null && MapManager.Instance.CurrentContainerManager.EELLFKJKKAN != 0)
		{
			MapManager.Instance.CurrentContainerManager.SlideToPosition(0);
		}
		DDOHJJCKLGK(true);
		IPDAGPBIHDD.SetClickOnceCallback(delegate
		{
			AADBMFOIKKM.HideTutorial();
		}, delegate
		{
			AADBMFOIKKM.Remove();
		});
		Sequence s = DOTween.Sequence();
		s.InsertCallback(0.5f, delegate
		{
			AADBMFOIKKM.FadeInBackground();
			Vector3 position = IPDAGPBIHDD.transform.position;
			position.x += 0.072f;
			position.y -= 2.25f;
			AADBMFOIKKM.ShowArrow(position);
		});
		IPDAGPBIHDD.SetTutorialMembers(AADBMFOIKKM.ArrowContainer, 2.25f);
	}

	private void DDOHJJCKLGK(bool HMLFIACPAAD)
	{
		int num = ((!HMLFIACPAAD) ? (-2) : (-11));
		int nNIDKMJGAJO = ((!HMLFIACPAAD) ? (-500) : 500);
		IPDAGPBIHDD.ChangeButtonDepth(num);
		IPDAGPBIHDD.IncreaseSortingOrder(nNIDKMJGAJO);
	}

	public override bool PPOCOCCKKFF()
	{
		KCKDNJOMPJH kCKDNJOMPJH = DGOMNDMPMBG.GABGKBAKHDP.FABKMFCBELE;
		return kCKDNJOMPJH != null && ((kCKDNJOMPJH.NPHPMJFFPGB && MapTutorial.ShouldDisplayTeamTournamentTutorial()) || (kCKDNJOMPJH.LMIPACNFAAB && !TeamTournamentRewardsDialog.DialogActive) || kCKDNJOMPJH.BPDNGDOGLIO || kCKDNJOMPJH.LJGNJNOIAPH);
	}

	public override bool HDLHHPFDHIK()
	{
		return true;
	}
}
