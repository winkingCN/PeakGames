using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.GamePlayScene.Tutorials;
using DG.Tweening;
using MapScene;
using UnityEngine;

public class KOFDCENHGIN : OOHGOOPDAEM
{
	[CompilerGenerated]
	private sealed class LHGHGHBCCPN
	{
		internal MapTutorial AADBMFOIKKM;

		internal KOFDCENHGIN PDAPIGLEPGC;

		internal void AGFNGEFDHLA()
		{
			SpriteButtonListener.Instance.EnableClicks = false;
			if (PDAPIGLEPGC.CECMINAKHFJ != null)
			{
				PDAPIGLEPGC.CECMINAKHFJ(true);
			}
			PDAPIGLEPGC.IOOJGJEKDMK(false);
		}

		internal void KDACLOKGNAM()
		{
			AADBMFOIKKM.FadeInBackground();
			Vector3 position = PDAPIGLEPGC.IAEAKIHMGDL.transform.position;
			position.y -= 2.1f;
			AADBMFOIKKM.ShowArrow(position);
			PDAPIGLEPGC.IAEAKIHMGDL.SetClickOnceCallback(delegate
			{
				AADBMFOIKKM.Remove();
			});
		}

		internal void DBLIJBPNCAN()
		{
			AADBMFOIKKM.Remove();
		}
	}

	private readonly GameObject JGAKMKLFFNK;

	private readonly StarChestDisplay IAEAKIHMGDL;

	public KOFDCENHGIN(StarChestDisplay BDLBICMIGIB, GameObject JFPFCMFNAEC, Action<bool> IMHLFAHONPP)
		: base(IMHLFAHONPP)
	{
		CENGNKJGOGP = "StarChestInitialOpenAnimation";
		JGAKMKLFFNK = JFPFCMFNAEC;
		IAEAKIHMGDL = BDLBICMIGIB;
	}

	private void IOOJGJEKDMK(bool HMLFIACPAAD)
	{
		int num = ((!HMLFIACPAAD) ? (-1) : (-11));
		int nNIDKMJGAJO = ((!HMLFIACPAAD) ? (-500) : 500);
		IAEAKIHMGDL.ChangeButtonDepth(num);
		IAEAKIHMGDL.IncreaseSortingOrder(nNIDKMJGAJO);
	}

	public override void GDGINCNCMDD(bool ODCADGABBHJ, bool DEIGFPCALOJ)
	{
		if (MapTutorial.ShouldDisplayStarChestOpenTutorial())
		{
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
				IOOJGJEKDMK(false);
			});
			IOOJGJEKDMK(true);
			Sequence s = DOTween.Sequence();
			s.InsertCallback(0.5f, delegate
			{
				AADBMFOIKKM.FadeInBackground();
				Vector3 position = IAEAKIHMGDL.transform.position;
				position.y -= 2.1f;
				AADBMFOIKKM.ShowArrow(position);
				IAEAKIHMGDL.SetClickOnceCallback(delegate
				{
					AADBMFOIKKM.Remove();
				});
			});
		}
		else if (CECMINAKHFJ != null)
		{
			CECMINAKHFJ(false);
		}
	}
}
