using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.GamePlayScene.Tutorials;
using DG.Tweening;
using MapScene;
using UnityEngine;

public class FKLBKNGILLM : OOHGOOPDAEM
{
	[CompilerGenerated]
	private sealed class EGFOKOONKFA
	{
		internal MapTutorial AADBMFOIKKM;

		internal FKLBKNGILLM PDAPIGLEPGC;

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
			PDAPIGLEPGC.OGEHEPFPNII(false);
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
			Vector3 position = PDAPIGLEPGC.PMNGIHOEGMC.transform.position;
			position.x += 0.072f;
			position.y -= 2.1f;
			AADBMFOIKKM.ShowArrow(position);
		}
	}

	private readonly GameObject JGAKMKLFFNK;

	private readonly DailyBonusDisplay PMNGIHOEGMC;

	public FKLBKNGILLM(DailyBonusDisplay JBBJEFOAKFA, GameObject JFPFCMFNAEC, Action<bool> IMHLFAHONPP)
		: base(IMHLFAHONPP)
	{
		CENGNKJGOGP = "DailyBonusTutorialAnimation";
		JGAKMKLFFNK = JFPFCMFNAEC;
		PMNGIHOEGMC = JBBJEFOAKFA;
	}

	private void OGEHEPFPNII(bool HMLFIACPAAD)
	{
		int num = ((!HMLFIACPAAD) ? (-2) : (-11));
		int nNIDKMJGAJO = ((!HMLFIACPAAD) ? (-500) : 500);
		PMNGIHOEGMC.ChangeButtonDepth(num);
		PMNGIHOEGMC.IncreaseSortingOrder(nNIDKMJGAJO);
	}

	public override void GDGINCNCMDD(bool ODCADGABBHJ, bool DEIGFPCALOJ)
	{
		if (MapTutorial.ShouldDisplayDailyBonusTutorial())
		{
			MapTutorial.CompleteDailyBonusTutorial();
			MapTutorial.DidShowMapTutorialInCurrentFlow = true;
			SpriteButtonListener.Instance.EnableClicks = true;
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
				OGEHEPFPNII(false);
			});
			AADBMFOIKKM.EnableTutorialSkip();
			OGEHEPFPNII(true);
			PMNGIHOEGMC.SetClickOnceCallback(delegate
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
				Vector3 position = PMNGIHOEGMC.transform.position;
				position.x += 0.072f;
				position.y -= 2.1f;
				AADBMFOIKKM.ShowArrow(position);
			});
			PMNGIHOEGMC.SetTutorialMembers(AADBMFOIKKM.ArrowContainer, 2.1f);
		}
		else if (CECMINAKHFJ != null)
		{
			CECMINAKHFJ(false);
		}
	}
}
