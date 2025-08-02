using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using GamePlayScene.Mechanics.Items;
using UnityEngine;

public class LLJLGKECBBE
{
	private static LLJLGKECBBE KNPOFJNFLJB;

	private readonly List<Cell> CEEAJDKHPKL = new List<Cell>();

	private readonly HashSet<FishItem> LBJHKLCGGHJ = new HashSet<FishItem>();

	private CFOIPDKEFMM OELBDGFEGOI;

	private int MPPFPBEBDPC;

	private int DHJFIPCFEGI;

	public static LLJLGKECBBE GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new LLJLGKECBBE();
			}
			return KNPOFJNFLJB;
		}
	}

	public int KOBIBAJNFCO
	{
		get
		{
			return DHJFIPCFEGI;
		}
		set
		{
			DHJFIPCFEGI = value;
		}
	}

	public static void INJHFIFHKOB()
	{
		KNPOFJNFLJB = null;
	}

	public void KNGDPCBKCJK()
	{
		DHJFIPCFEGI = 0;
	}

	public void GNCJEPLJLDJ()
	{
		DHJFIPCFEGI++;
	}

	public void KCDFMMEGJMB(CFOIPDKEFMM GOAELFDHDGD)
	{
		OELBDGFEGOI = GOAELFDHDGD;
	}

	public Cell MKLJIAFNDDH()
	{
		if (Time.frameCount != MPPFPBEBDPC)
		{
			MPPFPBEBDPC = Time.frameCount;
			CEEAJDKHPKL.Clear();
			foreach (Cell item in OELBDGFEGOI.IOFOFDLJDAA())
			{
				if (!item.HasCellItem() && !item.CGLFCDDLOKA && !item.HasBubble && !item.HFOKCLGLNOB && (!item.EAILOFHFNJO || item.LBFCDKPCDPB.CanBeInsideBubble()))
				{
					CEEAJDKHPKL.Add(item);
				}
			}
			CEEAJDKHPKL.KFGEEKGAPDP(13);
		}
		int num = CEEAJDKHPKL.Count - 1;
		if (num < 0)
		{
			return null;
		}
		Cell result = CEEAJDKHPKL[num];
		CEEAJDKHPKL.RemoveAt(num);
		return result;
	}

	public void MEBOIANIOCH(ref List<Cell> FFPHKNJCCIE)
	{
		if (FFPHKNJCCIE == null || FFPHKNJCCIE.Count == 0)
		{
			return;
		}
		int count = FFPHKNJCCIE.Count;
		for (int num = count - 1; num >= 0; num--)
		{
			Cell cell = FFPHKNJCCIE[num];
			if (cell == null || !cell.Exists || cell.HasBubble || cell.HFOKCLGLNOB || cell.HasCellItem() || cell.CGLFCDDLOKA)
			{
				FFPHKNJCCIE.RemoveAt(num);
			}
			else if (cell.EAILOFHFNJO && !cell.LBFCDKPCDPB.CanBeInsideBubble())
			{
				FFPHKNJCCIE.RemoveAt(num);
			}
		}
	}

	public void NEDGNENMFAE()
	{
		foreach (FishItem item in LBJHKLCGGHJ)
		{
			if (item != null)
			{
				item.Sleep();
			}
		}
	}

	public void LBOHGOAGAFJ(FishItem BCHAGIFNKDP)
	{
		LBJHKLCGGHJ.Add(BCHAGIFNKDP);
	}

	public void LENKLFIPLIH()
	{
		LBJHKLCGGHJ.Clear();
	}

	public void CDCGBANMJDF()
	{
		foreach (FishItem item in LBJHKLCGGHJ)
		{
			if (item != null)
			{
				item.ForceToSleep();
			}
		}
	}
}
