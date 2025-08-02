using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using GamePlayScene.Mechanics.Items.SpecialItems;

public class PBLOIKDOPAJ
{
	public const int LJNDDJECANK = 100;

	public static Stack<PBLOIKDOPAJ> HJKDPHHLKCA = new Stack<PBLOIKDOPAJ>(100);

	public List<Cell> OABGDODKPKM = new List<Cell>(10);

	public Cell BFCMNIPBDIE;

	public LEDBLDKJBAI BPLHOCDDLCG = LEDBLDKJBAI.None;

	public int PNBDAGKFOBN;

	public bool FGOGPEOCNCK;

	public bool IJILFJHCFKM;

	public int DJADMBLKBKJ;

	public bool CPDGPBNOADK;

	public NOALGNJECAD CDAJIPHMCDN;

	public NOALGNJECAD PNAMGKGHNCG;

	public bool GAPCCIILKLL;

	private PBLOIKDOPAJ()
	{
	}

	public static PBLOIKDOPAJ GHBGCADFLFB(Cell LBHDELJBONF)
	{
		PBLOIKDOPAJ pBLOIKDOPAJ = ((HJKDPHHLKCA.Count <= 0) ? new PBLOIKDOPAJ() : HJKDPHHLKCA.Pop());
		pBLOIKDOPAJ.DIOELAHNLKJ(LBHDELJBONF);
		return pBLOIKDOPAJ;
	}

	public static void HMKJAFHJMGN(PBLOIKDOPAJ JELDNNIGLFC)
	{
		if (HJKDPHHLKCA.Count <= 100)
		{
			JELDNNIGLFC.BOPEPLONIFL();
			HJKDPHHLKCA.Push(JELDNNIGLFC);
		}
	}

	public void BOPEPLONIFL()
	{
		OABGDODKPKM.Clear();
		CPDGPBNOADK = false;
		FGOGPEOCNCK = false;
		IJILFJHCFKM = false;
		BFCMNIPBDIE = null;
		CDAJIPHMCDN = NOALGNJECAD.None;
		BPLHOCDDLCG = LEDBLDKJBAI.None;
		DJADMBLKBKJ = 0;
		PNBDAGKFOBN = 0;
		PNAMGKGHNCG = NOALGNJECAD.None;
		GAPCCIILKLL = false;
	}

	public void DAFKHFIMGDK()
	{
		short num = 0;
		short num2 = 0;
		short num3 = 0;
		int i = 0;
		for (int count = OABGDODKPKM.Count; i < count; i++)
		{
			Cell cell = OABGDODKPKM[i];
			if (cell.EAILOFHFNJO)
			{
				Item currentItem = cell.LBFCDKPCDPB;
				if (!GAPCCIILKLL && (currentItem.IsFalling || currentItem.FilledNewly))
				{
					GAPCCIILKLL = true;
				}
				DJADMBLKBKJ += currentItem.GetScore();
				switch (currentItem.GetItemType())
				{
				case NOALGNJECAD.Rocket:
					num++;
					break;
				case NOALGNJECAD.Bomb:
					num2++;
					break;
				case NOALGNJECAD.DiscoBall:
					num3++;
					break;
				}
			}
		}
		PNBDAGKFOBN = OABGDODKPKM.Count;
		FGOGPEOCNCK = OABGDODKPKM.Count >= 5;
		IJILFJHCFKM = OABGDODKPKM.Count >= 2;
		if (PNBDAGKFOBN > 3 && PNBDAGKFOBN < 7)
		{
			PNAMGKGHNCG = NOALGNJECAD.Rocket;
		}
		if (PNBDAGKFOBN >= 7 && PNBDAGKFOBN < 9)
		{
			PNAMGKGHNCG = NOALGNJECAD.Bomb;
		}
		if (PNBDAGKFOBN >= 9)
		{
			PNAMGKGHNCG = NOALGNJECAD.DiscoBall;
		}
		CPDGPBNOADK = num + num2 + num3 > 1;
		if (num3 > 1)
		{
			CDAJIPHMCDN = NOALGNJECAD.DoubleDiscoBall;
		}
		else if (num3 == 1)
		{
			if (num2 > 0)
			{
				CDAJIPHMCDN = NOALGNJECAD.DiscoBallAndBomb;
			}
			else if (num > 0)
			{
				CDAJIPHMCDN = NOALGNJECAD.DiscoBallAndRocket;
			}
		}
		else if (num2 > 1)
		{
			CDAJIPHMCDN = NOALGNJECAD.DoubleBomb;
		}
		else if (num2 == 1 && num > 0)
		{
			CDAJIPHMCDN = NOALGNJECAD.RocketAndBomb;
		}
		else if (num > 1)
		{
			CDAJIPHMCDN = NOALGNJECAD.DoubleRocket;
		}
	}

	public DiscoBallItem PEMKDIIEPPJ()
	{
		int i = 0;
		for (int count = OABGDODKPKM.Count; i < count; i++)
		{
			Cell cell = OABGDODKPKM[i];
			if (cell.EAILOFHFNJO && cell.LBFCDKPCDPB.GetItemType() == NOALGNJECAD.DiscoBall)
			{
				return (DiscoBallItem)cell.LBFCDKPCDPB;
			}
		}
		return null;
	}

	public override string ToString()
	{
		return string.Format("[MatchGroup: ClickedCell={0}, Size={1}, MatchType={2}, CanExplode={3}]", BFCMNIPBDIE, PNBDAGKFOBN, BPLHOCDDLCG, IJILFJHCFKM);
	}

	public void DIOELAHNLKJ(Cell LBHDELJBONF)
	{
		BOPEPLONIFL();
		BFCMNIPBDIE = LBHDELJBONF;
		if (BFCMNIPBDIE.EAILOFHFNJO)
		{
			BPLHOCDDLCG = BFCMNIPBDIE.LBFCDKPCDPB.GetMatchType();
		}
	}
}
