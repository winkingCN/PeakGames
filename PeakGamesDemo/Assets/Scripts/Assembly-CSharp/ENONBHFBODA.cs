using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.GamePlayScene.Tutorials;
using CasualTools.Dialogs;
using DG.Tweening;
using UnityEngine;

public class ENONBHFBODA : OOHGOOPDAEM
{
	[CompilerGenerated]
	private sealed class JGBJJHLNLPI
	{
		internal MapTutorial AADBMFOIKKM;

		internal ENONBHFBODA PDAPIGLEPGC;

		internal void AGFNGEFDHLA()
		{
			PDAPIGLEPGC.NBMJJHAHDKA(false);
			new LLCJMMBBLEH(PDAPIGLEPGC.OBDOODGMBMK(), true);
		}

		internal void KDACLOKGNAM()
		{
			AADBMFOIKKM.FadeInBackground();
			Vector3 position = PDAPIGLEPGC.BNAKNGLNKBC.transform.position;
			position.y -= 2.1f;
			AADBMFOIKKM.ShowArrow(position);
			PDAPIGLEPGC.BNAKNGLNKBC.SetClickOnceCallback(delegate
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

	private readonly ToonChestDisplay BNAKNGLNKBC;

	public ENONBHFBODA(ToonChestDisplay MGDOFFEHLFM, GameObject JFPFCMFNAEC, Action<bool> IMHLFAHONPP)
		: base(IMHLFAHONPP)
	{
		CENGNKJGOGP = "ToonChestAnimation";
		JGAKMKLFFNK = JFPFCMFNAEC;
		BNAKNGLNKBC = MGDOFFEHLFM;
	}

	public override void GDGINCNCMDD(bool ODCADGABBHJ, bool DEIGFPCALOJ)
	{
		if (MapTutorial.ShouldDisplayToonChestOpenTutorial())
		{
			SpriteButtonListener.Instance.EnableClicks = true;
			BNAKNGLNKBC.UpdateDisplayWithGlowAnimation(true);
			GameObject gameObject = UnityEngine.Object.Instantiate(JGAKMKLFFNK);
			MapTutorial AADBMFOIKKM = gameObject.GetComponent<MapTutorial>();
			AADBMFOIKKM.Init(string.Empty, Vector3.zero, delegate
			{
				NBMJJHAHDKA(false);
				new LLCJMMBBLEH(OBDOODGMBMK(), true);
			});
			NBMJJHAHDKA(true);
			Sequence s = DOTween.Sequence();
			s.InsertCallback(0.5f, delegate
			{
				AADBMFOIKKM.FadeInBackground();
				Vector3 position = BNAKNGLNKBC.transform.position;
				position.y -= 2.1f;
				AADBMFOIKKM.ShowArrow(position);
				BNAKNGLNKBC.SetClickOnceCallback(delegate
				{
					AADBMFOIKKM.Remove();
				});
			});
		}
		else
		{
			BNAKNGLNKBC.UpdateDisplayWithGlowAnimation(true);
			if (CECMINAKHFJ != null)
			{
				CECMINAKHFJ(false);
			}
		}
	}

	private void NBMJJHAHDKA(bool HMLFIACPAAD)
	{
		int num = ((!HMLFIACPAAD) ? (-1) : (-11));
		int nNIDKMJGAJO = ((!HMLFIACPAAD) ? (-500) : 500);
		BNAKNGLNKBC.ChangeButtonDepth(num);
		BNAKNGLNKBC.IncreaseSortingOrder(nNIDKMJGAJO);
	}

	private IEnumerator OBDOODGMBMK()
	{
		yield return MCJHHDACJBG.CNDGGNLKOOC;
		while (FHAAAFAAMDO.GABGKBAKHDP.COCNAAGPOMN)
		{
			yield return null;
		}
		SpriteButtonListener.Instance.EnableClicks = false;
		if (CECMINAKHFJ != null)
		{
			CECMINAKHFJ(true);
		}
	}
}
