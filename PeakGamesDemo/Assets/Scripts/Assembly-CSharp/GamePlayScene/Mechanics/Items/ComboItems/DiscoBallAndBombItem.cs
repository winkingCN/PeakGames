using System.Collections;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items.SpecialItems;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items.ComboItems
{
	public class DiscoBallAndBombItem : DiscoBallComboItem
	{
		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.DiscoBallAndBomb;
		}

		protected override SpecialItem LNLPNAGCDGG(CFOIPDKEFMM EHEOIMKGPEP, Cell FMFABAKPMLB, int AJJFIEKFLNB)
		{
			SpecialItem specialItem = EHEOIMKGPEP.ELFBOKDHKGG.GIMBEKBFKMJ.CreateItem(new DNJKLNPHPOF(NOALGNJECAD.Bomb)) as SpecialItem;
			specialItem.transform.position = FMFABAKPMLB.GetFrozenPosition();
			return specialItem;
		}

		public override void RemoveSelf()
		{
			OnBeforeRemove();
			Object.Destroy(base.gameObject);
		}

		public override int GetScore()
		{
			return 1500 + DLDOMGCNDLN;
		}

		protected override IEnumerator MHMBGIJDDBC()
		{
			for (int i = 0; i < FGKEDOCEJFC.Count; i++)
			{
				SpecialItem specialItem = FGKEDOCEJFC[i];
				if (specialItem == null || specialItem.ReCycled)
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
					IEnumerator enumerator = specialItem.StartAutoExplode(MLENMAIAOHJ.BDAKKAIBMIM(15));
					while (enumerator.MoveNext())
					{
						yield return enumerator.Current;
					}
					yield return MCJHHDACJBG.CNDGGNLKOOC;
				}
			}
			FNMKFIHMDCN(FGKEDOCEJFC);
		}

		protected override byte OCLEDFFKDGI()
		{
			return 4;
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 0;
		}
	}
}
