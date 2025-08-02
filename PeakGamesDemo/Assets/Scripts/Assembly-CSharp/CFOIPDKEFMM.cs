using System.Collections.Generic;
using System.Reflection;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.GamePlayScene.Mechanics.Items.Features;
using Assets.Scripts.GamePlayScene.Mechanics.Items.SpecialItems;
using Assets.Scripts.Utils;
using DG.Tweening;
using GamePlayScene.Mechanics.Items;
using UnityEngine;

[DefaultMember("Item")]
public class CFOIPDKEFMM
{
	private readonly Cell[,] EFAHCCBOHLM;

	private readonly PKOIDACHFJF MCDODPFEBOL;

	private readonly LinkedList<Cell> BPDHLLAPOAF;

	public readonly int FHAMOHDEGMK;

	public readonly int EMFKAPJMDCC;

	public KFCEILFGADG ELFBOKDHKGG;

	public bool NCHIPIJGIKB;

	public readonly Dictionary<BoxCollider2D, Cell> GFIEMDDJAOB;

	public Cell AHANCLBKKID
	{
		get
		{
			return EFAHCCBOHLM[AMFCENFNAJJ, CNLILOEEBOJ];
		}
		set
		{
			EFAHCCBOHLM[AMFCENFNAJJ, CNLILOEEBOJ] = value;
		}
	}

	public int MGOOMLBDCPJ { get; private set; }

	public CFOIPDKEFMM(Cell[,] AKIPKPNNPNJ)
	{
		EMFKAPJMDCC = AKIPKPNNPNJ.GetLength(0);
		FHAMOHDEGMK = AKIPKPNNPNJ.GetLength(1);
		MGOOMLBDCPJ = Mathf.Max(EMFKAPJMDCC, FHAMOHDEGMK);
		EFAHCCBOHLM = AKIPKPNNPNJ;
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Grid, "Grid is ready w{0}xh{1}", EMFKAPJMDCC, FHAMOHDEGMK);
		MCDODPFEBOL = new PKOIDACHFJF(this);
		GFIEMDDJAOB = new Dictionary<BoxCollider2D, Cell>();
		BPDHLLAPOAF = new LinkedList<Cell>();
		for (int i = 0; i < EMFKAPJMDCC; i++)
		{
			for (int j = 0; j < FHAMOHDEGMK; j++)
			{
				Cell cell = EFAHCCBOHLM[i, j];
				if (cell.Exists)
				{
					BPDHLLAPOAF.AddLast(cell);
					BoxCollider2D component = cell.GetComponent<BoxCollider2D>();
					if (component != null)
					{
						GFIEMDDJAOB.Add(component, cell);
					}
				}
			}
		}
	}

	public IEnumerable<Cell> IOFOFDLJDAA()
	{
		for (LinkedListNode<Cell> linkedListNode = BPDHLLAPOAF.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
		{
			yield return linkedListNode.Value;
		}
	}

	public IEnumerable<Cell> ECNKPIEGILI()
	{
		for (int i = 0; i < EMFKAPJMDCC; i++)
		{
			for (int j = 0; j < FHAMOHDEGMK; j++)
			{
				yield return EFAHCCBOHLM[i, j];
			}
		}
	}

	public void JCNFICLCFOB()
	{
		foreach (Cell item in IOFOFDLJDAA())
		{
			if (item.EAILOFHFNJO && item.LBFCDKPCDPB.CanShowCurrentlyUnderTap())
			{
				((KBCDCGOIIIF)item.LBFCDKPCDPB).HPNBCBIDLJO();
			}
		}
	}

	public PBLOIKDOPAJ ELPGGJBDALH(Cell LBHDELJBONF)
	{
		if (LBHDELJBONF == null || !LBHDELJBONF.EAILOFHFNJO)
		{
			return null;
		}
		return (!LBHDELJBONF.LBFCDKPCDPB.IsSpecialItem()) ? MCDODPFEBOL.KDGHAMBEFPF(LBHDELJBONF) : MCDODPFEBOL.IBJBJENCOAB(LBHDELJBONF);
	}

	public void DGINICFFFFP(List<PBLOIKDOPAJ> AHPHIMJPOEO)
	{
		MCDODPFEBOL.JMOKDEFDBLF(AHPHIMJPOEO);
	}

	public Cell PHOOMEOBJCB(Cell JKHLMLIANAI, IEKBFJBLGFM AJLDJAHHGOJ)
	{
		if (JKHLMLIANAI == null)
		{
			return null;
		}
		int x = JKHLMLIANAI.X;
		int y = JKHLMLIANAI.Y;
		if (AJLDJAHHGOJ == IEKBFJBLGFM.Left && x - 1 >= 0)
		{
			return this.ECNCPJGHBIG(x - 1, y);
		}
		if (AJLDJAHHGOJ == IEKBFJBLGFM.LeftUp && x - 1 >= 0 && y + 1 < FHAMOHDEGMK)
		{
			return this.ECNCPJGHBIG(x - 1, y + 1);
		}
		if (AJLDJAHHGOJ == IEKBFJBLGFM.Up && y + 1 < FHAMOHDEGMK)
		{
			return this.ECNCPJGHBIG(x, y + 1);
		}
		if (AJLDJAHHGOJ == IEKBFJBLGFM.RightUp && x + 1 < EMFKAPJMDCC && y + 1 < FHAMOHDEGMK)
		{
			return this.ECNCPJGHBIG(x + 1, y + 1);
		}
		if (AJLDJAHHGOJ == IEKBFJBLGFM.Right && x + 1 < EMFKAPJMDCC)
		{
			return this.ECNCPJGHBIG(x + 1, y);
		}
		if (AJLDJAHHGOJ == IEKBFJBLGFM.RightDown && x + 1 < EMFKAPJMDCC && y - 1 >= 0)
		{
			return this.ECNCPJGHBIG(x + 1, y - 1);
		}
		if (AJLDJAHHGOJ == IEKBFJBLGFM.Down && y - 1 >= 0)
		{
			return this.ECNCPJGHBIG(x, y - 1);
		}
		if (AJLDJAHHGOJ == IEKBFJBLGFM.LeftDown && x - 1 >= 0 && y - 1 >= 0)
		{
			return this.ECNCPJGHBIG(x - 1, y - 1);
		}
		return null;
	}

	public void NLOHEBDFPCP()
	{
		LevelBuilder.LastLevel.KMBHLPKMOEC.HHICALABBJL++;
	}

	public void ELHPMMGOKMF(Cell EAPKIIBJENG)
	{
		if (EAPKIIBJENG == null)
		{
			return;
		}
		LevelBuilder.Recorder.JBEKBJHJBKD(EAPKIIBJENG.X, EAPKIIBJENG.Y);
		Item currentItem = EAPKIIBJENG.LBFCDKPCDPB;
		if (EAPKIIBJENG.CGLFCDDLOKA)
		{
			if (currentItem != null)
			{
				currentItem.OnWrongTouch();
			}
		}
		else if (EAPKIIBJENG.HasCellItem())
		{
			EAPKIIBJENG.FEMFMBLMKHP.OnWrongTouch();
		}
		else
		{
			if (currentItem == null)
			{
				return;
			}
			if (!currentItem.CanBeTapped())
			{
				currentItem.OnWrongTouch();
				return;
			}
			PBLOIKDOPAJ pBLOIKDOPAJ = ELPGGJBDALH(EAPKIIBJENG);
			if (pBLOIKDOPAJ == null)
			{
				currentItem.OnWrongTouch();
			}
			else if (currentItem.IsSpecialItem())
			{
				ELFBOKDHKGG.AMFPKLEIMBO();
				if (((SpecialItem)currentItem).CanRaiseScore())
				{
					ScoreManager.RaiseScore(pBLOIKDOPAJ.DJADMBLKBKJ);
				}
				if (pBLOIKDOPAJ.CPDGPBNOADK)
				{
					SpecialItem specialItem = ELFBOKDHKGG.GIMBEKBFKMJ.CreateComboItem(pBLOIKDOPAJ, EAPKIIBJENG.GetFrozenPosition());
					AudioManager.Play(KOOGPFAPGGD.ComboMerge);
					Tweener hADMGKDPBGP = null;
					int i = 0;
					for (int count = pBLOIKDOPAJ.OABGDODKPKM.Count; i < count; i++)
					{
						Cell cell = pBLOIKDOPAJ.OABGDODKPKM[i];
						Item currentItem2 = cell.LBFCDKPCDPB;
						if (cell.EAILOFHFNJO)
						{
							((PGCMDKBCMHI)specialItem).AddScore(cell.LBFCDKPCDPB.GetScore());
						}
						cell.RemoveBubble();
						specialItem.DisplayComboHint(false);
						cell.LBFCDKPCDPB = null;
						cell.RejectsFallInside();
						hADMGKDPBGP = ((SpecialItem)currentItem2).MoveToComboItem(pBLOIKDOPAJ.BFCMNIPBDIE);
					}
					EAPKIIBJENG.LBFCDKPCDPB = specialItem;
					new LLCJMMBBLEH(specialItem.StartAutoExplode(MLENMAIAOHJ.BDAKKAIBMIM(1), hADMGKDPBGP));
				}
				else
				{
					EJBPCMDJFEM(EAPKIIBJENG, MLENMAIAOHJ.BDAKKAIBMIM(1));
				}
				ELFBOKDHKGG.ELEHIDCIDJN.KJAOBJCEJPE();
				ELFBOKDHKGG.KMEOMFGKMJC();
				ELFBOKDHKGG.PPOFGAFEACD();
			}
			else if (pBLOIKDOPAJ.IJILFJHCFKM)
			{
				ELFBOKDHKGG.AMFPKLEIMBO();
				List<Cell> mGKLAHNKKOM = new List<Cell>();
				APBDPLNCDIJ cCPAJBOJDMN = MLENMAIAOHJ.BDAKKAIBMIM(2);
				foreach (Cell item in pBLOIKDOPAJ.OABGDODKPKM)
				{
					EJBPCMDJFEM(item, cCPAJBOJDMN, pBLOIKDOPAJ, mGKLAHNKKOM);
				}
				ScoreManager.RaiseScore(pBLOIKDOPAJ.DJADMBLKBKJ);
				ELFBOKDHKGG.ELEHIDCIDJN.KJAOBJCEJPE();
				ELFBOKDHKGG.KMEOMFGKMJC();
				ELFBOKDHKGG.PPOFGAFEACD();
			}
			else
			{
				currentItem.OnWrongTouch();
			}
		}
	}

	private void JCDMMAIBIMO(Item EJCNAJOHBFI, Cell LBHDELJBONF)
	{
		if (EJCNAJOHBFI != null)
		{
			EJCNAJOHBFI.SetExplodeDirection(IEKBFJBLGFM.None);
		}
		EJBPCMDJFEM(LBHDELJBONF, MLENMAIAOHJ.BDAKKAIBMIM(3));
	}

	public bool EJBPCMDJFEM(Cell EEABGAIFMCP, APBDPLNCDIJ CCPAJBOJDMN, PBLOIKDOPAJ FNEALCOPNND = null, List<Cell> MGKLAHNKKOM = null)
	{
		if (EEABGAIFMCP == null)
		{
			return false;
		}
		if (EEABGAIFMCP.HasCellItem())
		{
			return EEABGAIFMCP.ExplodeCellItem(CCPAJBOJDMN);
		}
		if (!EEABGAIFMCP.EAILOFHFNJO)
		{
			EEABGAIFMCP.ShakeBubble();
			return false;
		}
		Item currentItem = EEABGAIFMCP.LBFCDKPCDPB;
		LEDBLDKJBAI matchType = currentItem.GetMatchType();
		if (currentItem.TryExplode(CCPAJBOJDMN))
		{
			Item item = currentItem.ExtractSubItem();
			if (item != null)
			{
				item.transform.SetParent(currentItem.transform.parent);
			}
			CanCastShadowComponent.HideShadowIfPossible(EEABGAIFMCP);
			ELFBOKDHKGG.MAEILEPNBAE++;
			if (EEABGAIFMCP.HasBubble && (currentItem is SolidColorItem || currentItem.IsSpecialItem()))
			{
				EEABGAIFMCP.RemoveBubble();
			}
			else
			{
				EEABGAIFMCP.ShakeBubble();
			}
			bool flag = Time.frameCount == EEABGAIFMCP.LastBubbleRemoved;
			if (FNEALCOPNND == null && currentItem.CanRaiseScore())
			{
				int num = currentItem.GetScore();
				if (flag)
				{
					num += 500;
				}
				ScoreManager.RaiseScore(num);
			}
			NOALGNJECAD itemType = currentItem.GetItemType();
			if (FNEALCOPNND != null && FNEALCOPNND.FGOGPEOCNCK)
			{
				ELFBOKDHKGG.ACJOALJFMHN(itemType, false);
				((SolidColorItem)currentItem).MoveToSpecialItem(FNEALCOPNND.BFCMNIPBDIE);
			}
			else if (ELFBOKDHKGG.NODDCJJNJEC(currentItem.GetItemType()) && currentItem.CanBeCollectedWithAnimation())
			{
				currentItem.StartCollect();
			}
			else if (currentItem is SolidColorItem && NLMLKADGECN.GABGKBAKHDP.NODDCJJNJEC(currentItem.GetMatchType()))
			{
				currentItem.StartCollectToItem(EEABGAIFMCP);
			}
			else
			{
				if (ELFBOKDHKGG.NODDCJJNJEC(currentItem.GetItemType()))
				{
					ELFBOKDHKGG.DJNEAFJLFIH(itemType);
					ELFBOKDHKGG.ACJOALJFMHN(currentItem.GetItemType(), false);
				}
				currentItem.StartExplode();
			}
			EEABGAIFMCP.LBFCDKPCDPB = null;
			if (FNEALCOPNND == null)
			{
				PBGJCPJIECH(item, EEABGAIFMCP);
				CanCastShadowComponent.CastShadowIfPossible(EEABGAIFMCP);
				return true;
			}
			if (flag)
			{
				FNEALCOPNND.DJADMBLKBKJ += 500;
			}
			if (FNEALCOPNND.FGOGPEOCNCK && FNEALCOPNND.BFCMNIPBDIE == EEABGAIFMCP)
			{
				SpecialItem specialItem = ELFBOKDHKGG.GIMBEKBFKMJ.CreateSpecialItem(FNEALCOPNND.PNAMGKGHNCG, FNEALCOPNND.BPLHOCDDLCG, EEABGAIFMCP.GetFrozenPosition(), EEABGAIFMCP);
				specialItem.StartAnimations();
				EEABGAIFMCP.LBFCDKPCDPB = specialItem;
				CanCastShadowComponent.CastShadowIfPossible(EEABGAIFMCP);
				specialItem.PlaySpecialItemCreationAnimation();
				AudioManager.Play(KOOGPFAPGGD.ItemSpecialCreate);
				if (NCHIPIJGIKB)
				{
					NCHIPIJGIKB = false;
					ELFBOKDHKGG.GIMBEKBFKMJ.TryPlaySpecialItemTutorial(specialItem);
				}
			}
			Cell[] cachedNeigbours = EEABGAIFMCP.GetCachedNeigbours(false);
			int i = 0;
			for (int num2 = cachedNeigbours.Length; i < num2; i++)
			{
				Cell cell = cachedNeigbours[i];
				if (cell == null || FNEALCOPNND.OABGDODKPKM.Contains(cell))
				{
					continue;
				}
				if (cell.HasCellItem())
				{
					if (cell.FEMFMBLMKHP.CanExplodeDueToExplodeInNeigbour(matchType))
					{
						CellItem cellItem = cell.FEMFMBLMKHP;
						if (!MGKLAHNKKOM.Contains(cellItem.ENCFFNKONOO))
						{
							MGKLAHNKKOM.Add(cellItem.ENCFFNKONOO);
							cellItem.PreventRaiseScore();
							EJBPCMDJFEM(cell, CCPAJBOJDMN);
							FNEALCOPNND.DJADMBLKBKJ += cellItem.GetScore();
							cellItem.IOFDFFBKCBF();
						}
					}
				}
				else if (cell.EAILOFHFNJO && cell.LBFCDKPCDPB.CanExplodeDueToExplodeInNeigbour(matchType))
				{
					Item currentItem2 = cell.LBFCDKPCDPB;
					currentItem2.PreventRaiseScore();
					EJBPCMDJFEM(cell, CCPAJBOJDMN);
					if (currentItem2.ENCFFNKONOO == null || (currentItem2.CanGenerateScoreOnEachTryExplode() && currentItem2.CanGenerateScoreThisTurn()))
					{
						FNEALCOPNND.DJADMBLKBKJ += currentItem2.GetScore();
					}
					currentItem2.IOFDFFBKCBF();
				}
			}
			PBGJCPJIECH(item, EEABGAIFMCP);
			return true;
		}
		EEABGAIFMCP.ShakeBubble();
		return false;
	}

	private static void PBGJCPJIECH(Item NBENOCONCML, Cell EEABGAIFMCP)
	{
		if (!(NBENOCONCML == null))
		{
			NBENOCONCML.ENCFFNKONOO = EEABGAIFMCP;
			NBENOCONCML.OnSubItemCreated();
		}
	}
}
