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

public class LFCPHJHHOGP : OOHGOOPDAEM
{
	[CompilerGenerated]
	private sealed class NCLOBDHMEMB
	{
		internal MapTutorial AADBMFOIKKM;

		internal LFCPHJHHOGP PDAPIGLEPGC;

		internal void AGFNGEFDHLA()
		{
			SpriteButtonListener.Instance.EnableClicks = false;
			if (PDAPIGLEPGC.CECMINAKHFJ != null)
			{
				PDAPIGLEPGC.CECMINAKHFJ(true);
			}
		}

		internal void KDACLOKGNAM()
		{
			PDAPIGLEPGC.ONAJNGEBHNP(false);
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
			Vector3 position = PDAPIGLEPGC.GHIMIBPDEBL.transform.position;
			position.x += 0.072f;
			position.y -= 2.25f;
			AADBMFOIKKM.ShowArrow(position);
		}
	}

	private readonly GameObject JGAKMKLFFNK;

	private readonly TeamChestDisplay GHIMIBPDEBL;

	public LFCPHJHHOGP(TeamChestDisplay OCMKNJPNCHI, GameObject JFPFCMFNAEC, Action<bool> IMHLFAHONPP)
		: base(IMHLFAHONPP)
	{
		CENGNKJGOGP = "TeamChestAnimation";
		JGAKMKLFFNK = JFPFCMFNAEC;
		GHIMIBPDEBL = OCMKNJPNCHI;
	}

	public override void GDGINCNCMDD(bool ODCADGABBHJ, bool DEIGFPCALOJ)
	{
		AAPMDEEMEMM aAPMDEEMEMM = DGOMNDMPMBG.GABGKBAKHDP.BHGCBNAMEFK;
		if (aAPMDEEMEMM != null)
		{
			if (MapTutorial.ShouldDisplayTeamChestTutorial())
			{
				SpriteButtonListener.Instance.EnableClicks = true;
				VerticalScrollController.UnlockAllScrolls();
				FHAAAFAAMDO.GABGKBAKHDP.FPGFIAKIIID(true);
				CPANOHJMNIO(DEIGFPCALOJ);
				aAPMDEEMEMM.LGDBADICPEN();
			}
			else if (aAPMDEEMEMM.ICNIGMDCCLN)
			{
				SpriteButtonListener.Instance.EnableClicks = true;
				EOBDANKMCBK(aAPMDEEMEMM, DEIGFPCALOJ);
				aAPMDEEMEMM.LGDBADICPEN();
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

	private void EOBDANKMCBK(AAPMDEEMEMM HMOBAHHJOJE, bool DEIGFPCALOJ)
	{
		if (!GFHPEDILAJG.GABGKBAKHDP.ODMCGBLJFKM)
		{
			GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.TeamChestJoinTeamDialog, false);
			TeamChestJoinTeamDialog component = gameObject.GetComponent<TeamChestJoinTeamDialog>();
			component.SetOnDialogClosedCallback(EGFKMPGIFJB);
		}
		else if (HMOBAHHJOJE.OPBAEEEGPDE == null)
		{
			SpriteButtonListener.Instance.EnableClicks = false;
			if (CECMINAKHFJ != null)
			{
				CECMINAKHFJ(false);
			}
		}
		else
		{
			GameObject gameObject2 = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.TeamChestInfoDialog, false);
			TeamChestInfoDialog component2 = gameObject2.GetComponent<TeamChestInfoDialog>();
			component2.Prepare(HMOBAHHJOJE, DEIGFPCALOJ);
			component2.SetOnDialogClosedCallback(EGFKMPGIFJB);
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

	private void CPANOHJMNIO(bool DEIGFPCALOJ)
	{
		MapTutorial.CompleteTeamChestTutorial();
		MapTutorial.DidShowMapTutorialInCurrentFlow = true;
		GameObject gameObject = UnityEngine.Object.Instantiate(JGAKMKLFFNK);
		MapTutorial AADBMFOIKKM = gameObject.GetComponent<MapTutorial>();
		AADBMFOIKKM.Init(string.Empty, Vector3.zero, delegate
		{
			SpriteButtonListener.Instance.EnableClicks = false;
			if (CECMINAKHFJ != null)
			{
				CECMINAKHFJ(true);
			}
		}, delegate
		{
			ONAJNGEBHNP(false);
		});
		AADBMFOIKKM.EnableTutorialSkip();
		if (MapManager.Instance != null && MapManager.Instance.CurrentContainerManager.EELLFKJKKAN != 0)
		{
			MapManager.Instance.CurrentContainerManager.SlideToPosition(0);
		}
		ONAJNGEBHNP(true);
		GHIMIBPDEBL.SetClickOnceCallback(delegate
		{
			AADBMFOIKKM.HideTutorial();
		}, delegate
		{
			AADBMFOIKKM.Remove();
		}, DEIGFPCALOJ);
		Sequence s = DOTween.Sequence();
		s.InsertCallback(0.5f, delegate
		{
			AADBMFOIKKM.FadeInBackground();
			Vector3 position = GHIMIBPDEBL.transform.position;
			position.x += 0.072f;
			position.y -= 2.25f;
			AADBMFOIKKM.ShowArrow(position);
		});
		GHIMIBPDEBL.SetTutorialMembers(AADBMFOIKKM.ArrowContainer, 2.25f);
	}

	private void ONAJNGEBHNP(bool HMLFIACPAAD)
	{
		int num = ((!HMLFIACPAAD) ? (-2) : (-11));
		int nNIDKMJGAJO = ((!HMLFIACPAAD) ? (-500) : 500);
		GHIMIBPDEBL.ChangeButtonDepth(num);
		GHIMIBPDEBL.IncreaseSortingOrder(nNIDKMJGAJO);
	}

	public override bool PPOCOCCKKFF()
	{
		AAPMDEEMEMM aAPMDEEMEMM = DGOMNDMPMBG.GABGKBAKHDP.BHGCBNAMEFK;
		return aAPMDEEMEMM != null && aAPMDEEMEMM.ICNIGMDCCLN;
	}

	public override bool HDLHHPFDHIK()
	{
		return true;
	}
}
