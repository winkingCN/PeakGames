using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using GamePlayScene.Mechanics.Items;
using UnityEngine;

public class MJPAKGMNFAC
{
	private static MJPAKGMNFAC KNPOFJNFLJB;

	private readonly List<Cell> CEEAJDKHPKL = new List<Cell>();

	private readonly List<Cell> MLBDAKKBJKP = new List<Cell>();

	private readonly List<Cell> HLAHDELJKJJ = new List<Cell>();

	private readonly Dictionary<NOALGNJECAD, HashSet<GeneratorBasedItem>> OLODMFAJEEM = new Dictionary<NOALGNJECAD, HashSet<GeneratorBasedItem>>();

	private CFOIPDKEFMM OELBDGFEGOI;

	private int MPPFPBEBDPC;

	public static MJPAKGMNFAC GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new MJPAKGMNFAC();
			}
			return KNPOFJNFLJB;
		}
	}

	public void KCDFMMEGJMB(CFOIPDKEFMM GOAELFDHDGD)
	{
		OELBDGFEGOI = GOAELFDHDGD;
	}

	public static void INJHFIFHKOB()
	{
		KNPOFJNFLJB = null;
	}

	public Cell MKLJIAFNDDH()
	{
		if (Time.frameCount > MPPFPBEBDPC + 10)
		{
			MPPFPBEBDPC = Time.frameCount;
			CEEAJDKHPKL.Clear();
			MLBDAKKBJKP.Clear();
			HLAHDELJKJJ.Clear();
			foreach (Cell item in OELBDGFEGOI.IOFOFDLJDAA())
			{
				if (item.LMBJLCLEANK || item.HasCellItem() || item.CGLFCDDLOKA)
				{
					continue;
				}
				if (item.EAILOFHFNJO)
				{
					if (item.LBFCDKPCDPB.DiscoRayReservedType != 0)
					{
						continue;
					}
					switch (item.LBFCDKPCDPB.GetItemType())
					{
					case NOALGNJECAD.SolidColor1:
					case NOALGNJECAD.SolidColor2:
					case NOALGNJECAD.SolidColor3:
					case NOALGNJECAD.SolidColor4:
					case NOALGNJECAD.SolidColor5:
						if (item.LBFCDKPCDPB.IsFalling || item.LBFCDKPCDPB.FilledNewly || item.IsFilling)
						{
							HLAHDELJKJJ.Add(item);
						}
						else
						{
							CEEAJDKHPKL.Add(item);
						}
						break;
					}
				}
				else
				{
					MLBDAKKBJKP.Add(item);
				}
			}
			CEEAJDKHPKL.KFGEEKGAPDP(13);
			MLBDAKKBJKP.KFGEEKGAPDP(13);
			HLAHDELJKJJ.KFGEEKGAPDP(13);
		}
		int num = CEEAJDKHPKL.Count - 1;
		if (num < 0)
		{
			int num2 = HLAHDELJKJJ.Count - 1;
			if (num2 < 0)
			{
				int num3 = MLBDAKKBJKP.Count - 1;
				if (num3 < 0)
				{
					return null;
				}
				Cell result = MLBDAKKBJKP[num3];
				MLBDAKKBJKP.RemoveAt(num3);
				return result;
			}
			Cell result2 = HLAHDELJKJJ[num2];
			HLAHDELJKJJ.RemoveAt(num2);
			return result2;
		}
		Cell result3 = CEEAJDKHPKL[num];
		CEEAJDKHPKL.RemoveAt(num);
		return result3;
	}

	public void AFLOKCLDFNE(NOALGNJECAD HBBIFNLDKPO, GeneratorBasedItem EJCNAJOHBFI)
	{
		if (!OLODMFAJEEM.ContainsKey(HBBIFNLDKPO))
		{
			OLODMFAJEEM.Add(HBBIFNLDKPO, new HashSet<GeneratorBasedItem>());
		}
		OLODMFAJEEM[HBBIFNLDKPO].Add(EJCNAJOHBFI);
	}

	public void FJLHDCOCLEH()
	{
		OLODMFAJEEM.Clear();
	}

	public HashSet<GeneratorBasedItem> DPNNOCFDIGJ(NOALGNJECAD HBBIFNLDKPO)
	{
		return (!OLODMFAJEEM.ContainsKey(HBBIFNLDKPO)) ? null : OLODMFAJEEM[HBBIFNLDKPO];
	}

	public void EPOFJEDKNPF(NOALGNJECAD HBBIFNLDKPO)
	{
		if (!OLODMFAJEEM.ContainsKey(HBBIFNLDKPO))
		{
			return;
		}
		foreach (GeneratorBasedItem item in OLODMFAJEEM[HBBIFNLDKPO])
		{
			item.Sleep();
		}
		OLODMFAJEEM.Remove(HBBIFNLDKPO);
	}

	public void CDCGBANMJDF(NOALGNJECAD HBBIFNLDKPO)
	{
		if (!OLODMFAJEEM.ContainsKey(HBBIFNLDKPO))
		{
			return;
		}
		foreach (GeneratorBasedItem item in OLODMFAJEEM[HBBIFNLDKPO])
		{
			item.ForceSleep();
		}
		OLODMFAJEEM.Remove(HBBIFNLDKPO);
	}
}
