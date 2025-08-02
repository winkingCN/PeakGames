using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items.SpecialItems;
using GamePlayScene.Mechanics.Items.SpecialItems;

namespace GamePlayScene.Mechanics.Items.ComboItems
{
	public class DiscoBallAndRocketItem : DiscoBallComboItem
	{
		private int FBDJNHKGAEN;

		[CompilerGenerated]
		private static Comparison<Cell> EBCOMJBLIPP;

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.DiscoBallAndRocket;
		}

		protected override SpecialItem LNLPNAGCDGG(CFOIPDKEFMM EHEOIMKGPEP, Cell FMFABAKPMLB, int AJJFIEKFLNB)
		{
			HorizontalRocketItem horizontalRocketItem = ((AJJFIEKFLNB != 2) ? EHEOIMKGPEP.ELFBOKDHKGG.GIMBEKBFKMJ.CreateVerticallRocket(FMFABAKPMLB.GetFrozenPosition()) : EHEOIMKGPEP.ELFBOKDHKGG.GIMBEKBFKMJ.CreateHorizantalRocket(FMFABAKPMLB.GetFrozenPosition()));
			horizontalRocketItem.AllowBlockFalls();
			return horizontalRocketItem;
		}

		public override int GetScore()
		{
			return 1250 + DLDOMGCNDLN;
		}

		protected override IEnumerator MHMBGIJDDBC()
		{
			for (int i = 0; i < FGKEDOCEJFC.Count; i++)
			{
				SpecialItem specialItem = FGKEDOCEJFC[i];
				if (!(specialItem != null) || specialItem.ReCycled)
				{
					continue;
				}
				if (specialItem.ENCFFNKONOO != null && specialItem.ENCFFNKONOO.HasCellItem())
				{
					specialItem.ShouldRecycleInstantly = true;
					specialItem.CanNotJoinToCombo = false;
					FGKEDOCEJFC.RemoveAt(i);
					i--;
				}
				else
				{
					IEnumerator enumerator = specialItem.StartAutoExplode(MLENMAIAOHJ.BDAKKAIBMIM(14));
					while (enumerator.MoveNext())
					{
						yield return enumerator.Current;
					}
				}
			}
			new LLCJMMBBLEH(DGAAEKHAJOP(FGKEDOCEJFC));
		}

		private IEnumerator DGAAEKHAJOP(List<SpecialItem> FMMJCKEKJHO)
		{
			yield return MCJHHDACJBG.KNLADMIBAAD;
			FNMKFIHMDCN(FMMJCKEKJHO);
		}

		protected override void MLEENDCDNNB(List<Cell> FKIKBBHFHKN)
		{
			foreach (Cell item in CLCHKLJBIFH.IOFOFDLJDAA())
			{
				if (ECLAMDACKFJ(item))
				{
					FKIKBBHFHKN.Add(item);
				}
			}
			FKIKBBHFHKN.Sort(delegate(Cell MNIMEAMHNMI, Cell BCIHLCMFAEK)
			{
				if (MNIMEAMHNMI.Y > BCIHLCMFAEK.Y)
				{
					return -1;
				}
				return (MNIMEAMHNMI.Y != BCIHLCMFAEK.Y) ? 1 : ((MNIMEAMHNMI.X >= BCIHLCMFAEK.X) ? 1 : (-1));
			});
			for (int i = 0; i < FKIKBBHFHKN.Count; i++)
			{
				FKIKBBHFHKN[i].LBFCDKPCDPB.DiscoRayReservedType = OCLEDFFKDGI();
			}
		}

		protected override byte OCLEDFFKDGI()
		{
			if (FBDJNHKGAEN == 0)
			{
				FBDJNHKGAEN = BFGGHJGIHLJ.FDFDDKBDPEG(0, 2, 11);
			}
			return (byte)((FBDJNHKGAEN++ % 2 != 0) ? 3 : 2);
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 0;
		}

		[CompilerGenerated]
		private static int HKPHOHGBHPD(Cell MNIMEAMHNMI, Cell BCIHLCMFAEK)
		{
			if (MNIMEAMHNMI.Y > BCIHLCMFAEK.Y)
			{
				return -1;
			}
			if (MNIMEAMHNMI.Y == BCIHLCMFAEK.Y)
			{
				return (MNIMEAMHNMI.X >= BCIHLCMFAEK.X) ? 1 : (-1);
			}
			return 1;
		}
	}
}
