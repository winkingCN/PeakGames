using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.GamePlayScene.Mechanics.Items.SpecialItems;

public class PKOIDACHFJF
{
	private readonly LinkedList<Cell> BPDHLLAPOAF = new LinkedList<Cell>();

	private readonly CFOIPDKEFMM OELBDGFEGOI;

	private readonly int HGPPACPGBCG;

	private readonly bool[,] DGADANHPAMK;

	private readonly int JHMHKEEPEFH;

	private readonly bool[,] NMLBLGCBEDC = new bool[9, 9];

	public PKOIDACHFJF(CFOIPDKEFMM GOAELFDHDGD)
	{
		OELBDGFEGOI = GOAELFDHDGD;
		for (int i = 0; i < GOAELFDHDGD.EMFKAPJMDCC; i++)
		{
			for (int j = 0; j < GOAELFDHDGD.FHAMOHDEGMK; j++)
			{
				Cell cell = OELBDGFEGOI.ECNCPJGHBIG(i, j);
				if (cell.Exists)
				{
					BPDHLLAPOAF.AddLast(cell);
				}
			}
		}
		JHMHKEEPEFH = OELBDGFEGOI.EMFKAPJMDCC;
		HGPPACPGBCG = OELBDGFEGOI.FHAMOHDEGMK;
		DGADANHPAMK = new bool[OELBDGFEGOI.EMFKAPJMDCC, OELBDGFEGOI.FHAMOHDEGMK];
	}

	public PBLOIKDOPAJ KDGHAMBEFPF(Cell LBHDELJBONF)
	{
		PBLOIKDOPAJ pBLOIKDOPAJ = PBLOIKDOPAJ.GHBGCADFLFB(LBHDELJBONF);
		try
		{
			if (!LBHDELJBONF.Exists || !LBHDELJBONF.EAILOFHFNJO || !LBHDELJBONF.LBFCDKPCDPB.CanBeMatchable() || LBHDELJBONF.HasCellItem() || LBHDELJBONF.CGLFCDDLOKA || LBHDELJBONF.LBFCDKPCDPB.IsFalling)
			{
				return pBLOIKDOPAJ;
			}
			for (int i = 0; i < OELBDGFEGOI.EMFKAPJMDCC; i++)
			{
				for (int j = 0; j < OELBDGFEGOI.FHAMOHDEGMK; j++)
				{
					NMLBLGCBEDC[i, j] = false;
				}
			}
			pBLOIKDOPAJ.OABGDODKPKM.Add(LBHDELJBONF);
			NMLBLGCBEDC[LBHDELJBONF.X, LBHDELJBONF.Y] = true;
			KPOOOBAIOAM(NMLBLGCBEDC, LBHDELJBONF.LBFCDKPCDPB.GetMatchType(), LBHDELJBONF.GetCachedNeigbours(false), pBLOIKDOPAJ.OABGDODKPKM);
			return pBLOIKDOPAJ;
		}
		finally
		{
			pBLOIKDOPAJ.DAFKHFIMGDK();
		}
	}

	private static void KPOOOBAIOAM(bool[,] FOOAGHHONMO, LEDBLDKJBAI JOCKKMJBJLL, Cell[] GBJMFKGKPCN, List<Cell> FJKCLOMALBC)
	{
		if (GBJMFKGKPCN == null)
		{
			return;
		}
		int i = 0;
		for (int num = GBJMFKGKPCN.Length; i < num; i++)
		{
			Cell cell = GBJMFKGKPCN[i];
			if (FOOAGHHONMO[cell.X, cell.Y])
			{
				continue;
			}
			FOOAGHHONMO[cell.X, cell.Y] = true;
			if (cell.Exists && cell.EAILOFHFNJO && !cell.HasCellItem() && !cell.CGLFCDDLOKA)
			{
				Item currentItem = cell.LBFCDKPCDPB;
				if (currentItem.CanBeMatchable() && currentItem.GetMatchType() == JOCKKMJBJLL && !currentItem.IsFalling)
				{
					FJKCLOMALBC.Add(cell);
					KPOOOBAIOAM(FOOAGHHONMO, JOCKKMJBJLL, cell.GetCachedNeigbours(false), FJKCLOMALBC);
				}
			}
		}
	}

	public PBLOIKDOPAJ IBJBJENCOAB(Cell LBHDELJBONF)
	{
		PBLOIKDOPAJ pBLOIKDOPAJ = PBLOIKDOPAJ.GHBGCADFLFB(LBHDELJBONF);
		try
		{
			if (!LBHDELJBONF.Exists || !LBHDELJBONF.EAILOFHFNJO || !LBHDELJBONF.LBFCDKPCDPB.IsSpecialItem() || LBHDELJBONF.HasCellItem() || LBHDELJBONF.CGLFCDDLOKA)
			{
				return pBLOIKDOPAJ;
			}
			bool[,] array = new bool[OELBDGFEGOI.EMFKAPJMDCC, OELBDGFEGOI.FHAMOHDEGMK];
			pBLOIKDOPAJ.OABGDODKPKM.Add(LBHDELJBONF);
			array[LBHDELJBONF.X, LBHDELJBONF.Y] = true;
			NPECHCNAAFA(array, LBHDELJBONF.GetCachedNeigbours(false), pBLOIKDOPAJ.OABGDODKPKM);
			return pBLOIKDOPAJ;
		}
		finally
		{
			pBLOIKDOPAJ.DAFKHFIMGDK();
		}
	}

	private static void NPECHCNAAFA(bool[,] FOOAGHHONMO, Cell[] GBJMFKGKPCN, List<Cell> FJKCLOMALBC)
	{
		if (GBJMFKGKPCN == null)
		{
			return;
		}
		int i = 0;
		for (int num = GBJMFKGKPCN.Length; i < num; i++)
		{
			Cell cell = GBJMFKGKPCN[i];
			if (!FOOAGHHONMO[cell.X, cell.Y])
			{
				FOOAGHHONMO[cell.X, cell.Y] = true;
				if (cell.Exists && cell.EAILOFHFNJO && cell.LBFCDKPCDPB.IsSpecialItem() && !cell.HasCellItem() && !cell.CGLFCDDLOKA)
				{
					FJKCLOMALBC.Add(cell);
					NPECHCNAAFA(FOOAGHHONMO, cell.GetCachedNeigbours(false), FJKCLOMALBC);
				}
			}
		}
	}

	public void JMOKDEFDBLF(List<PBLOIKDOPAJ> AHPHIMJPOEO)
	{
		LinkedListNode<Cell> linkedListNode = BPDHLLAPOAF.First;
		for (int i = 0; i < JHMHKEEPEFH; i++)
		{
			for (int j = 0; j < HGPPACPGBCG; j++)
			{
				DGADANHPAMK[i, j] = false;
			}
		}
		while (linkedListNode != null)
		{
			Cell value = linkedListNode.Value;
			if (!DGADANHPAMK[value.X, value.Y])
			{
				AHPHIMJPOEO.Add(ELPGGJBDALH(value));
			}
			linkedListNode = linkedListNode.Next;
		}
	}

	private PBLOIKDOPAJ ELPGGJBDALH(Cell LBHDELJBONF)
	{
		DGADANHPAMK[LBHDELJBONF.X, LBHDELJBONF.Y] = true;
		PBLOIKDOPAJ pBLOIKDOPAJ = PBLOIKDOPAJ.GHBGCADFLFB(LBHDELJBONF);
		try
		{
			pBLOIKDOPAJ.OABGDODKPKM.Add(LBHDELJBONF);
			if (!LBHDELJBONF.Exists || !LBHDELJBONF.EAILOFHFNJO || LBHDELJBONF.HasCellItem() || LBHDELJBONF.CGLFCDDLOKA || (!LBHDELJBONF.LBFCDKPCDPB.CanBeMatchable() && (!LBHDELJBONF.LBFCDKPCDPB.IsSpecialItem() || ((SpecialItem)LBHDELJBONF.LBFCDKPCDPB).CanNotJoinToCombo)))
			{
				return pBLOIKDOPAJ;
			}
			PIAPMPKFEHN(LBHDELJBONF.LBFCDKPCDPB.GetMatchType(), LBHDELJBONF.GetCachedNeigbours(false), pBLOIKDOPAJ.OABGDODKPKM);
			return pBLOIKDOPAJ;
		}
		finally
		{
			pBLOIKDOPAJ.DAFKHFIMGDK();
		}
	}

	private void PIAPMPKFEHN(LEDBLDKJBAI JOCKKMJBJLL, Cell[] GBJMFKGKPCN, List<Cell> FJKCLOMALBC)
	{
		if (GBJMFKGKPCN == null)
		{
			return;
		}
		int i = 0;
		for (int num = GBJMFKGKPCN.Length; i < num; i++)
		{
			Cell cell = GBJMFKGKPCN[i];
			if (!DGADANHPAMK[cell.X, cell.Y])
			{
				if (!cell.Exists || !cell.EAILOFHFNJO || cell.HasCellItem() || cell.CGLFCDDLOKA || (!cell.LBFCDKPCDPB.CanBeMatchable() && (!cell.LBFCDKPCDPB.IsSpecialItem() || ((SpecialItem)cell.LBFCDKPCDPB).CanNotJoinToCombo)))
				{
					DGADANHPAMK[cell.X, cell.Y] = true;
				}
				else if (cell.LBFCDKPCDPB.GetMatchType() == JOCKKMJBJLL)
				{
					DGADANHPAMK[cell.X, cell.Y] = true;
					FJKCLOMALBC.Add(cell);
					PIAPMPKFEHN(JOCKKMJBJLL, cell.GetCachedNeigbours(false), FJKCLOMALBC);
				}
			}
		}
	}
}
