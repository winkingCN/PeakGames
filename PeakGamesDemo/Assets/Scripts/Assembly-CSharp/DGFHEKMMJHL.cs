using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using GamePlayScene.Mechanics.Items;

public class DGFHEKMMJHL
{
	private readonly KFCEILFGADG LPONNGEPDON;

	private readonly List<JellyItem> FCNIAAHFJMI = new List<JellyItem>();

	private readonly List<GFAGJNMKAHG> AMCHLBECBIN = new List<GFAGJNMKAHG>(16);

	private readonly List<GFAGJNMKAHG> PKHGCGPIDLA = new List<GFAGJNMKAHG>(16);

	private int JPDGEKFBOKD;

	private int AAFDFLCEHCB;

	private bool JIENFGNIBHM;

	private bool LBKPPKEADMM;

	public DGFHEKMMJHL(KFCEILFGADG GIOFHACJEGA)
	{
		LPONNGEPDON = GIOFHACJEGA;
	}

	public void KJAOBJCEJPE()
	{
		if (!LBKPPKEADMM && AAFDFLCEHCB <= 0 && LPONNGEPDON.EBMFPDNPIEM != JPDGEKFBOKD)
		{
			MKLANNENCNG();
		}
	}

	public void JEACJNAKLDJ(JellyItem BGLEJAJPHLH)
	{
		FCNIAAHFJMI.Add(BGLEJAJPHLH);
		LPONNGEPDON.JPAFPKIDJDJ(NOALGNJECAD.Jelly);
	}

	public void CJOHLENDJGO(JellyItem BGLEJAJPHLH)
	{
		FCNIAAHFJMI.Remove(BGLEJAJPHLH);
	}

	public int GMCGMPEEHJP()
	{
		return FCNIAAHFJMI.Count;
	}

	public void EAOOHODGKJO()
	{
		if (AAFDFLCEHCB == 0)
		{
			JPDGEKFBOKD = LPONNGEPDON.EBMFPDNPIEM;
		}
	}

	public void PHCHCLEKBNA()
	{
		AAFDFLCEHCB++;
	}

	public bool IFNGGNOPIBG()
	{
		return AAFDFLCEHCB > 0;
	}

	public void PBOMHJMKHBM(bool BJNPKNEPJLK)
	{
		AAFDFLCEHCB--;
		if (!JIENFGNIBHM && BJNPKNEPJLK)
		{
			JIENFGNIBHM = true;
		}
		if (AAFDFLCEHCB <= 0)
		{
			if (!JIENFGNIBHM && !LBKPPKEADMM)
			{
				MKLANNENCNG();
				JPDGEKFBOKD = LPONNGEPDON.EBMFPDNPIEM;
			}
			AAFDFLCEHCB = 0;
			JIENFGNIBHM = false;
		}
	}

	private void MKLANNENCNG()
	{
		int count = FCNIAAHFJMI.Count;
		if (count <= 0)
		{
			return;
		}
		AMCHLBECBIN.Clear();
		PKHGCGPIDLA.Clear();
		for (int i = 0; i < count; i++)
		{
			JellyItem jellyItem = FCNIAAHFJMI[i];
			Cell currentCell = jellyItem.ENCFFNKONOO;
			if (currentCell == null || currentCell.HasCellItem())
			{
				continue;
			}
			for (int j = 0; j < currentCell.GetCachedNeigbours(false).Length; j++)
			{
				Cell cell = currentCell.GetCachedNeigbours(false)[j];
				if (cell.HasCellItem())
				{
					continue;
				}
				if (!cell.EAILOFHFNJO)
				{
					AMCHLBECBIN.Add(new GFAGJNMKAHG(currentCell, cell));
				}
				else
				{
					if (!cell.LBFCDKPCDPB.CanBeCapturedByJelly() || cell.LMBJLCLEANK)
					{
						continue;
					}
					SolidColorItem solidColorItem = cell.LBFCDKPCDPB as SolidColorItem;
					if (!(solidColorItem == null))
					{
						if (solidColorItem.DAPJNCFCBHD)
						{
							PKHGCGPIDLA.Add(new GFAGJNMKAHG(currentCell, cell));
						}
						else
						{
							AMCHLBECBIN.Add(new GFAGJNMKAHG(currentCell, cell));
						}
					}
				}
			}
		}
		GFAGJNMKAHG? gFAGJNMKAHG = null;
		if (AMCHLBECBIN.Count > 0)
		{
			gFAGJNMKAHG = AMCHLBECBIN[BFGGHJGIHLJ.FDFDDKBDPEG(0, AMCHLBECBIN.Count, 12)];
		}
		else if (PKHGCGPIDLA.Count > 0)
		{
			gFAGJNMKAHG = PKHGCGPIDLA[BFGGHJGIHLJ.FDFDDKBDPEG(0, PKHGCGPIDLA.Count, 12)];
		}
		if (gFAGJNMKAHG.HasValue)
		{
			GFAGJNMKAHG value = gFAGJNMKAHG.Value;
			JellyItem jellyItem2 = value.PMJDIPHGABO.LBFCDKPCDPB as JellyItem;
			if (jellyItem2 != null)
			{
				jellyItem2.PlayJellySpread(value.LPOKJNHPNEO);
			}
		}
	}

	public void JIELGDKBBJP()
	{
		JPDGEKFBOKD = -100000;
	}

	public void AELCCKHIMME()
	{
		LBKPPKEADMM = true;
	}
}
