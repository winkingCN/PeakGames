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

public class EIOJBFNGJMN : OOHGOOPDAEM
{
	[CompilerGenerated]
	private sealed class NFFNALJHCKF
	{
		internal MapTutorial AADBMFOIKKM;

		internal EIOJBFNGJMN PDAPIGLEPGC;

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
			PDAPIGLEPGC.JHHIPMHEAFG(false);
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
			Vector3 position = PDAPIGLEPGC.IKLGCFCPGIJ.transform.position;
			position.x += 0.072f;
			position.y -= 2.25f;
			AADBMFOIKKM.ShowArrow(position);
		}
	}

	private readonly GameObject JGAKMKLFFNK;

	private readonly TreasureHuntDisplay IKLGCFCPGIJ;

	public EIOJBFNGJMN(TreasureHuntDisplay GACEHBKCPNN, GameObject JFPFCMFNAEC, Action<bool> IMHLFAHONPP)
		: base(IMHLFAHONPP)
	{
		CENGNKJGOGP = "TreasureHuntAnimation";
		JGAKMKLFFNK = JFPFCMFNAEC;
		IKLGCFCPGIJ = GACEHBKCPNN;
	}

	public override void GDGINCNCMDD(bool ODCADGABBHJ, bool DEIGFPCALOJ)
	{
		CFNKECEHDIC cFNKECEHDIC = DGOMNDMPMBG.GABGKBAKHDP.OEPCIADENMH;
		if (cFNKECEHDIC != null && cFNKECEHDIC.NPHPMJFFPGB)
		{
			IKLGCFCPGIJ.TreasureHuntDisplayAnimation.PlayRotateAnimationIfNeeded(cFNKECEHDIC.AEPLIGFCGIF);
			if (MapTutorial.ShouldDisplayTreasureHuntTutorial())
			{
				SpriteButtonListener.Instance.EnableClicks = true;
				VerticalScrollController.UnlockAllScrolls();
				FHAAAFAAMDO.GABGKBAKHDP.FPGFIAKIIID(true);
				CPANOHJMNIO(DEIGFPCALOJ);
				cFNKECEHDIC.BCBDPNPEKFI();
			}
			else if (cFNKECEHDIC.BPDNGDOGLIO)
			{
				SpriteButtonListener.Instance.EnableClicks = true;
				EOBDANKMCBK();
				cFNKECEHDIC.BCBDPNPEKFI();
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

	private void CPANOHJMNIO(bool DEIGFPCALOJ)
	{
		MapTutorial.CompleteTreasureHuntTutorial();
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
			JHHIPMHEAFG(false);
		});
		AADBMFOIKKM.EnableTutorialSkip();
		if (MapManager.Instance != null && MapManager.Instance.CurrentContainerManager.EELLFKJKKAN != 0)
		{
			MapManager.Instance.CurrentContainerManager.SlideToPosition(0);
		}
		JHHIPMHEAFG(true);
		IKLGCFCPGIJ.SetClickOnceCallback(delegate
		{
			AADBMFOIKKM.HideTutorial();
		}, delegate
		{
			AADBMFOIKKM.Remove();
		}, DEIGFPCALOJ);
		Sequence s = DOTween.Sequence();
		s.InsertCallback(0.25f, delegate
		{
			AADBMFOIKKM.FadeInBackground();
			Vector3 position = IKLGCFCPGIJ.transform.position;
			position.x += 0.072f;
			position.y -= 2.25f;
			AADBMFOIKKM.ShowArrow(position);
		});
		IKLGCFCPGIJ.SetTutorialMembers(AADBMFOIKKM.ArrowContainer, 2.25f);
	}

	private void EOBDANKMCBK()
	{
		GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.TreasureHuntInfoDialog, false);
		TreasureHuntInfoDialog component = gameObject.GetComponent<TreasureHuntInfoDialog>();
		component.SetOnDialogClosedCallback(EGFKMPGIFJB);
	}

	private void JHHIPMHEAFG(bool HMLFIACPAAD)
	{
		int num = ((!HMLFIACPAAD) ? (-2) : (-11));
		int nNIDKMJGAJO = ((!HMLFIACPAAD) ? (-500) : 500);
		IKLGCFCPGIJ.ChangeButtonDepth(num);
		IKLGCFCPGIJ.IncreaseSortingOrder(nNIDKMJGAJO);
	}

	public override bool PPOCOCCKKFF()
	{
		CFNKECEHDIC cFNKECEHDIC = DGOMNDMPMBG.GABGKBAKHDP.OEPCIADENMH;
		return cFNKECEHDIC != null && cFNKECEHDIC.BPDNGDOGLIO;
	}

	public override bool HDLHHPFDHIK()
	{
		return true;
	}
}
