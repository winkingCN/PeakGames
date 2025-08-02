using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using DG.Tweening;
using GamePlayScene.Mechanics;
using GamePlayScene.Mechanics.Items;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics
{
	public class Cell : MonoBehaviour
	{
		private Cell[] MHAFEBDLOLO;

		private Cell[] HHJFGNKFACJ;

		private int BPEKAEAPJDP;

		private Item LNMHNJEIGBH;

		private List<FCPPDOMBLHL> BGOEFJHGAGF;

		private List<FCPPDOMBLHL> CFKHOFDIENF;

		private List<int> IFMIFKBAKOP;

		[HideInInspector]
		public bool HasBubble;

		[HideInInspector]
		public CFOIPDKEFMM CurrentGrid;

		[HideInInspector]
		public bool Exists;

		[HideInInspector]
		public Cell FirstExistingBottomCell;

		[HideInInspector]
		public Cell JustAboveCell;

		[HideInInspector]
		public Cell JustBelowCell;

		public int LastBubbleRemoved;

		private Sequence JIEEDECENPC;

		[HideInInspector]
		public int X;

		[HideInInspector]
		public int Y;

		private bool IPPPLLCGGOP;

		private NOALGNJECAD JOMBKNIELCE;

		public SpriteRenderer[] Borders;

		public SpriteRenderer BubbleSpriteRenderer;

		[HideInInspector]
		public bool IsFloor;

		[HideInInspector]
		public bool IsFilling;

		public BoxCollider2D Collider;

		private Vector3 DJJCBEHDBAJ;

		private Vector3 OKMMIAOKGJC;

		public Item LBFCDKPCDPB
		{
			get
			{
				return LNMHNJEIGBH;
			}
			set
			{
				if (!(LNMHNJEIGBH == value))
				{
					Item lNMHNJEIGBH = LNMHNJEIGBH;
					LNMHNJEIGBH = value;
					if (lNMHNJEIGBH != null && object.Equals(lNMHNJEIGBH.ENCFFNKONOO, this))
					{
						lNMHNJEIGBH.ENCFFNKONOO = null;
					}
					if (value != null)
					{
						value.ENCFFNKONOO = this;
					}
				}
			}
		}

		public bool EAILOFHFNJO
		{
			get
			{
				return LNMHNJEIGBH != null && !LNMHNJEIGBH.ReCycled;
			}
		}

		public bool HFOKCLGLNOB { get; set; }

		public bool LMBJLCLEANK { get; set; }

		public bool CGLFCDDLOKA
		{
			get
			{
				return IPPPLLCGGOP;
			}
			set
			{
				IPPPLLCGGOP = value;
				if (EAILOFHFNJO)
				{
					LBFCDKPCDPB.OnReservedForCellItem(IPPPLLCGGOP);
				}
			}
		}

		public CellItem FEMFMBLMKHP { get; private set; }

		public int GetBubbleScoreIfPossible()
		{
			return (LastBubbleRemoved == Time.frameCount) ? 500 : 0;
		}

		public void ShowHighlight()
		{
			if (!Exists || !EAILOFHFNJO)
			{
				return;
			}
			PBLOIKDOPAJ pBLOIKDOPAJ = CurrentGrid.ELPGGJBDALH(this);
			if (pBLOIKDOPAJ == null || !pBLOIKDOPAJ.IJILFJHCFKM)
			{
				return;
			}
			foreach (Cell item in pBLOIKDOPAJ.OABGDODKPKM)
			{
				if (item.LBFCDKPCDPB.CanShowCurrentlyUnderTap())
				{
					((KBCDCGOIIIF)item.LBFCDKPCDPB).PNCDAIPCCDH();
				}
			}
		}

		public bool CanItemFallFromThisCell()
		{
			return LBFCDKPCDPB == null || LBFCDKPCDPB.CanFall();
		}

		public override string ToString()
		{
			return string.Format("[Cell: X={0}, Y={1}]", X, Y);
		}

		public void RejectsFallInside()
		{
			BPEKAEAPJDP++;
		}

		public void AcceptsFallInside()
		{
			BPEKAEAPJDP--;
			if (BPEKAEAPJDP < 0)
			{
				BPEKAEAPJDP = 0;
			}
		}

		public bool CanItemsFallInside()
		{
			return BPEKAEAPJDP == 0;
		}

		public void AddIntervalGroupId(FCPPDOMBLHL BDKFNEDHAOJ)
		{
			if (BGOEFJHGAGF == null)
			{
				BGOEFJHGAGF = new List<FCPPDOMBLHL>();
			}
			BGOEFJHGAGF.Add(BDKFNEDHAOJ);
		}

		public void AddFillGroupId(FCPPDOMBLHL BDKFNEDHAOJ, int HEPJDGACJLJ = 1)
		{
			if (CFKHOFDIENF == null)
			{
				CFKHOFDIENF = new List<FCPPDOMBLHL>();
			}
			if (IFMIFKBAKOP == null)
			{
				IFMIFKBAKOP = new List<int>();
			}
			HEPJDGACJLJ = Math.Max(0, Math.Min(100, HEPJDGACJLJ));
			int num = 0;
			if (IFMIFKBAKOP.Count > 0)
			{
				num = IFMIFKBAKOP[IFMIFKBAKOP.Count - 1];
			}
			num += HEPJDGACJLJ;
			IFMIFKBAKOP.Add(num);
			CFKHOFDIENF.Add(BDKFNEDHAOJ);
		}

		public Item CreateRefillItem()
		{
			if (CFKHOFDIENF == null || CFKHOFDIENF.Count <= 0)
			{
				return null;
			}
			if (CurrentGrid.ELFBOKDHKGG.AOFJJGNOLDM && CurrentGrid.ELFBOKDHKGG.HCPDKCHKNKA.ContainsKey(X) && CurrentGrid.ELFBOKDHKGG.HCPDKCHKNKA[X].Count != 0)
			{
				DNJKLNPHPOF nBHMBPFKCMI = CurrentGrid.ELFBOKDHKGG.HCPDKCHKNKA[X].Dequeue();
				return CurrentGrid.ELFBOKDHKGG.GIMBEKBFKMJ.CreateItem(nBHMBPFKCMI);
			}
			FCPPDOMBLHL fCPPDOMBLHL = FCPPDOMBLHL.None;
			if (BGOEFJHGAGF != null)
			{
				fCPPDOMBLHL = CurrentGrid.ELFBOKDHKGG.IPFAJHMMGPF(BGOEFJHGAGF);
				if (fCPPDOMBLHL != 0)
				{
					return CurrentGrid.ELFBOKDHKGG.OJDPAPIBONC(fCPPDOMBLHL, X);
				}
			}
			int count = CFKHOFDIENF.Count;
			int num = 0;
			int num2 = IFMIFKBAKOP.LLJKKEKFPFG();
			while (num < count)
			{
				fCPPDOMBLHL = CFKHOFDIENF[num2];
				Item item = CurrentGrid.ELFBOKDHKGG.OJDPAPIBONC(fCPPDOMBLHL, X);
				if (item != null)
				{
					return item;
				}
				num++;
				num2 = (num2 + 1) % count;
			}
			return null;
		}

		public void Squash(Sequence MIABODPHOIP, Transform DHHMKEJENIE, float FNLMFCLDCOD, float HFLODNLEGFL, Ease EKFOKNPODBK = Ease.Linear)
		{
			MIABODPHOIP.Append(DHHMKEJENIE.DOScale(new Vector3(1f / FNLMFCLDCOD, FNLMFCLDCOD), HFLODNLEGFL).SetEase(EKFOKNPODBK));
		}

		public void ShakeBubble()
		{
			if (HasBubble)
			{
				if (JIEEDECENPC != null)
				{
					JIEEDECENPC.Kill();
				}
				JIEEDECENPC = DOTween.Sequence();
				Transform dHHMKEJENIE = BubbleSpriteRenderer.transform;
				Squash(JIEEDECENPC, dHHMKEJENIE, 0.9f, 0.05f, Ease.OutQuad);
				Squash(JIEEDECENPC, dHHMKEJENIE, 1.06f, 0.08f, Ease.OutQuad);
				Squash(JIEEDECENPC, dHHMKEJENIE, 0.95f, 0.05f, Ease.OutQuad);
				Squash(JIEEDECENPC, dHHMKEJENIE, 1.03f, 0.04f, Ease.OutQuad);
				Squash(JIEEDECENPC, dHHMKEJENIE, 1f, 0.05f, Ease.InQuad);
				JIEEDECENPC.OnComplete(delegate
				{
					JIEEDECENPC = null;
				});
			}
		}

		public void AddCellItem(int DOGMNEKGKBP, KFCEILFGADG GIOFHACJEGA)
		{
			if (!(FEMFMBLMKHP != null))
			{
				HODEBPNBAGL(((ALIFCLNJKPH)DOGMNEKGKBP).AMLEHGPGGIC(), GIOFHACJEGA, false);
			}
		}

		public void AddCellItemToCurrentLevel(NOALGNJECAD OKBIEHADFIK)
		{
			if (!(FEMFMBLMKHP != null))
			{
				HODEBPNBAGL(OKBIEHADFIK, CurrentGrid.ELFBOKDHKGG, true);
			}
		}

		private void HODEBPNBAGL(NOALGNJECAD OKBIEHADFIK, KFCEILFGADG MGOFDOMDLCO, bool BOBCMAOIJGM)
		{
			FEMFMBLMKHP = MGOFDOMDLCO.GIMBEKBFKMJ.CreateCellItem(OKBIEHADFIK, BOBCMAOIJGM);
			FEMFMBLMKHP.transform.SetParent(base.transform);
			FEMFMBLMKHP.transform.localPosition = Vector3.zero;
			FEMFMBLMKHP.ENCFFNKONOO = this;
			CGLFCDDLOKA = false;
			FEMFMBLMKHP.OnItemCreated(MGOFDOMDLCO);
		}

		public bool HasCellItem()
		{
			return FEMFMBLMKHP != null && !FEMFMBLMKHP.NCFJOBEMANH;
		}

		public void RemoveCellItem()
		{
			FEMFMBLMKHP = null;
		}

		public void OnCellGridChange(CFOIPDKEFMM GOAELFDHDGD)
		{
			if (FEMFMBLMKHP != null)
			{
				FEMFMBLMKHP.OnCellGridChange(GOAELFDHDGD);
			}
		}

		public bool ExplodeCellItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (FEMFMBLMKHP != null && !FEMFMBLMKHP.NCFJOBEMANH && FEMFMBLMKHP.TryExplode(CCPAJBOJDMN))
			{
				if (EAILOFHFNJO)
				{
					LBFCDKPCDPB.OnCellItemExploded();
				}
				return true;
			}
			return false;
		}

		public void ExplodeCellItemWithBlaster(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (FEMFMBLMKHP != null)
			{
				FEMFMBLMKHP.TryExplode(CCPAJBOJDMN);
			}
			FEMFMBLMKHP = null;
		}

		public void UpdateFall(Cell FIICENBDLDC)
		{
			if (FEMFMBLMKHP != null)
			{
				FEMFMBLMKHP.UpdateOnFallBehind();
			}
			if (!(FIICENBDLDC == null))
			{
				Cell firstExistingBottomCell = FIICENBDLDC.FirstExistingBottomCell;
				if (firstExistingBottomCell == null || !firstExistingBottomCell.Exists || (firstExistingBottomCell != null && firstExistingBottomCell.Exists && firstExistingBottomCell.EAILOFHFNJO && !firstExistingBottomCell.LBFCDKPCDPB.IsFalling))
				{
					FIICENBDLDC.UpdateFall(null);
				}
			}
		}

		public void AddBubble(bool MJEJCGOLOPH = false)
		{
			LLJLGKECBBE.GABGKBAKHDP.GNCJEPLJLDJ();
			HFOKCLGLNOB = MJEJCGOLOPH;
			if (!MJEJCGOLOPH)
			{
				HasBubble = true;
				ShowBubble();
			}
		}

		public void ReserveForItem(NOALGNJECAD HBBIFNLDKPO)
		{
			if (!LMBJLCLEANK)
			{
				RejectsFallInside();
				JOMBKNIELCE = HBBIFNLDKPO;
				LMBJLCLEANK = true;
			}
		}

		public void ApplyReservedItem()
		{
			if (!LMBJLCLEANK)
			{
				return;
			}
			LMBJLCLEANK = false;
			try
			{
				if (JOMBKNIELCE == NOALGNJECAD.None)
				{
					return;
				}
				if (LBFCDKPCDPB != null)
				{
					if (LBFCDKPCDPB.GetItemType() == NOALGNJECAD.GiantDuck)
					{
						KFCEILFGADG eLFBOKDHKGG = CurrentGrid.ELFBOKDHKGG;
						if (eLFBOKDHKGG.HEHOGLHPCGH(JOMBKNIELCE) != null)
						{
							eLFBOKDHKGG.ACJOALJFMHN(JOMBKNIELCE, false);
						}
						int num = eLFBOKDHKGG.GEHOAFJDMPE(JOMBKNIELCE);
						if (num <= 0)
						{
							MJPAKGMNFAC.GABGKBAKHDP.EPOFJEDKNPF(JOMBKNIELCE);
						}
						JOMBKNIELCE = NOALGNJECAD.None;
						AcceptsFallInside();
						return;
					}
					LBFCDKPCDPB.RemoveSelf();
					NOALGNJECAD itemType = LBFCDKPCDPB.GetItemType();
					if (CurrentGrid.ELFBOKDHKGG.HEHOGLHPCGH(itemType) != null)
					{
						CurrentGrid.ELFBOKDHKGG.ACJOALJFMHN(itemType, true);
					}
				}
				CurrentGrid.ELFBOKDHKGG.GIMBEKBFKMJ.CreateItemAtCell(JOMBKNIELCE, this);
				JOMBKNIELCE = NOALGNJECAD.None;
				AcceptsFallInside();
				ApplyShadowIfPossible();
				if (JIEEDECENPC != null)
				{
					JIEEDECENPC.Kill();
				}
				JIEEDECENPC = DOTween.Sequence();
				if (LBFCDKPCDPB == null)
				{
					return;
				}
				LBFCDKPCDPB.BringToFront();
				LBFCDKPCDPB.transform.localScale = new Vector3(1f, 1f, 1f);
				JIEEDECENPC.Append(LBFCDKPCDPB.transform.DOScale(new Vector3(0.85f, 0.85f, 1f), 0.1f)).SetEase(Ease.Linear);
				JIEEDECENPC.Append(LBFCDKPCDPB.transform.DOScale(new Vector3(1.1f, 1.1f, 1f), 0.1f)).SetEase(Ease.Linear);
				JIEEDECENPC.Append(LBFCDKPCDPB.transform.DOScale(new Vector3(0.95f, 0.95f, 1f), 0.1f)).SetEase(Ease.Linear);
				JIEEDECENPC.Append(LBFCDKPCDPB.transform.DOScale(new Vector3(1.05f, 1.05f, 1f), 0.1f)).SetEase(Ease.Linear);
				JIEEDECENPC.Append(LBFCDKPCDPB.transform.DOScale(Vector3.one, 0.1f)).SetEase(Ease.Linear);
				JIEEDECENPC.OnComplete(delegate
				{
					JIEEDECENPC = null;
					if (LBFCDKPCDPB != null)
					{
						LBFCDKPCDPB.SendToBack();
					}
				});
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Cell, "Apply Reserved Item Error:{0} | {1}", ex.Message, ex.StackTrace);
			}
		}

		public void ApplyShadowIfPossible()
		{
			if (LBFCDKPCDPB.CanCastShadow() && JustBelowCell != null && JustBelowCell.Exists && JustBelowCell.EAILOFHFNJO && JustBelowCell.LBFCDKPCDPB.CanShadowDrop() && LBFCDKPCDPB.GetShadowCaster() != null)
			{
				LBFCDKPCDPB.GetShadowCaster().CastShadow();
			}
		}

		public void ApplyReservedBubble(BubbleAnimation MGGNDAKIKII = null)
		{
			if (HFOKCLGLNOB)
			{
				HFOKCLGLNOB = false;
				HasBubble = true;
				ShowBubble(MGGNDAKIKII);
			}
		}

		public void RemoveBubble()
		{
			if (HasBubble)
			{
				HasBubble = false;
				LastBubbleRemoved = Time.frameCount;
				KFCEILFGADG eLFBOKDHKGG = CurrentGrid.ELFBOKDHKGG;
				BubbleSpriteRenderer.enabled = false;
				ItemResources resources = ItemResourcesManager.GABGKBAKHDP.GetResources(NOALGNJECAD.Bubble);
				if (resources != null)
				{
					ParticlePool.Instance.PlayParticle(resources.Particles[0], GetFrozenPosition());
					AudioManager.PlayAudioProps(resources.AudioClips[UnityEngine.Random.Range(0, 3)]);
				}
				eLFBOKDHKGG.ACJOALJFMHN(NOALGNJECAD.Bubble, false);
			}
		}

		public void ShowBubble(BubbleAnimation MGGNDAKIKII = null)
		{
			try
			{
				if (HasBubble)
				{
					BubbleSpriteRenderer.sprite = SharedImageLibrary.Instance.Bubble;
					BubbleSpriteRenderer.enabled = true;
					BubbleSpriteRenderer.sortingOrder = BubbleSpriteRenderer.sortingOrder;
					if (MGGNDAKIKII != null)
					{
						MGGNDAKIKII.ShowBubble(JIEEDECENPC, BubbleSpriteRenderer);
					}
				}
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Cell, "ShowBubble Error:{0} | {1}", ex.Message, ex.StackTrace);
			}
		}

		public void HideBubble()
		{
			if (HasBubble)
			{
				BubbleSpriteRenderer.enabled = false;
			}
		}

		public Cell[] GetCachedNeigbours(bool LCBPJDAOFFM)
		{
			if (LCBPJDAOFFM)
			{
				return MHAFEBDLOLO ?? (MHAFEBDLOLO = LMNOBFEDENL(true));
			}
			return HHJFGNKFACJ ?? (HHJFGNKFACJ = LMNOBFEDENL(false));
		}

		private Cell[] LMNOBFEDENL(bool LCBPJDAOFFM)
		{
			int fHAMOHDEGMK = CurrentGrid.FHAMOHDEGMK;
			int eMFKAPJMDCC = CurrentGrid.EMFKAPJMDCC;
			List<Cell> list = new List<Cell>((!LCBPJDAOFFM) ? 4 : 8);
			if (X - 1 >= 0)
			{
				KIIJKEELECC(list, CurrentGrid.ECNCPJGHBIG(X - 1, Y));
			}
			if (LCBPJDAOFFM && X - 1 >= 0 && Y + 1 < fHAMOHDEGMK)
			{
				KIIJKEELECC(list, CurrentGrid.ECNCPJGHBIG(X - 1, Y + 1));
			}
			if (Y + 1 < fHAMOHDEGMK)
			{
				KIIJKEELECC(list, CurrentGrid.ECNCPJGHBIG(X, Y + 1));
			}
			if (LCBPJDAOFFM && X + 1 < eMFKAPJMDCC && Y + 1 < fHAMOHDEGMK)
			{
				KIIJKEELECC(list, CurrentGrid.ECNCPJGHBIG(X + 1, Y + 1));
			}
			if (X + 1 < eMFKAPJMDCC)
			{
				KIIJKEELECC(list, CurrentGrid.ECNCPJGHBIG(X + 1, Y));
			}
			if (LCBPJDAOFFM && X + 1 < eMFKAPJMDCC && Y - 1 >= 0)
			{
				KIIJKEELECC(list, CurrentGrid.ECNCPJGHBIG(X + 1, Y - 1));
			}
			if (Y - 1 >= 0)
			{
				KIIJKEELECC(list, CurrentGrid.ECNCPJGHBIG(X, Y - 1));
			}
			if (LCBPJDAOFFM && X - 1 >= 0 && Y - 1 >= 0)
			{
				KIIJKEELECC(list, CurrentGrid.ECNCPJGHBIG(X - 1, Y - 1));
			}
			return list.ToArray();
		}

		private static void KIIJKEELECC(List<Cell> FFPHKNJCCIE, Cell LBHDELJBONF)
		{
			if (LBHDELJBONF.Exists)
			{
				FFPHKNJCCIE.Add(LBHDELJBONF);
			}
		}

		public void FreezePosition()
		{
			DJJCBEHDBAJ = base.transform.position;
			OKMMIAOKGJC = base.transform.localPosition;
		}

		public Vector3 GetFrozenPosition()
		{
			return DJJCBEHDBAJ;
		}

		public Vector3 GetFrozenLocalPosition()
		{
			return OKMMIAOKGJC;
		}

		public IEKBFJBLGFM GetDirectionTo(Cell LBHDELJBONF)
		{
			if (LBHDELJBONF == null)
			{
				return IEKBFJBLGFM.None;
			}
			int num = X - LBHDELJBONF.X;
			int num2 = Y - LBHDELJBONF.Y;
			if (num == 0 && num2 == 0)
			{
				return IEKBFJBLGFM.None;
			}
			if (num == 0)
			{
				return (num2 > 0) ? IEKBFJBLGFM.Up : IEKBFJBLGFM.Down;
			}
			if (num2 == 0)
			{
				return (num <= 0) ? IEKBFJBLGFM.Left : IEKBFJBLGFM.Right;
			}
			if (num > 0)
			{
				return (num2 <= 0) ? IEKBFJBLGFM.RightDown : IEKBFJBLGFM.RightUp;
			}
			return (num2 <= 0) ? IEKBFJBLGFM.LeftDown : IEKBFJBLGFM.LeftUp;
		}

		public void ResetStateForSnapshot()
		{
			BGOEFJHGAGF = null;
			IFMIFKBAKOP = null;
			CFKHOFDIENF = null;
			HasBubble = false;
			BubbleSpriteRenderer.enabled = false;
			LastBubbleRemoved = 0;
			HFOKCLGLNOB = false;
			LMBJLCLEANK = false;
			CGLFCDDLOKA = false;
			JOMBKNIELCE = NOALGNJECAD.None;
			AcceptsFallInside();
			if (EAILOFHFNJO)
			{
				LBFCDKPCDPB.RemoveSelf();
				LBFCDKPCDPB = null;
			}
			if (HasCellItem())
			{
				FEMFMBLMKHP.RemoveSelf();
				FEMFMBLMKHP = null;
			}
		}

		[CompilerGenerated]
		private void JHJNOKGBCBN()
		{
			JIEEDECENPC = null;
		}

		[CompilerGenerated]
		private void IPGOOIFGDFG()
		{
			JIEEDECENPC = null;
			if (LBFCDKPCDPB != null)
			{
				LBFCDKPCDPB.SendToBack();
			}
		}
	}
}
