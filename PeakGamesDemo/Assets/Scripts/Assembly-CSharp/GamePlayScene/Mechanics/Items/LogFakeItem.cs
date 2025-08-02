using Assets.Scripts.GamePlayScene.Mechanics;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class LogFakeItem : FakeItem<LogItem>
	{
		public SpriteRenderer CurrentSpriteRenderer;

		public IEKBFJBLGFM AKDMMEEHGHB { get; private set; }

		public void Prepare(IEKBFJBLGFM AJLDJAHHGOJ)
		{
			AKDMMEEHGHB = AJLDJAHHGOJ;
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.LogFake;
		}

		public override bool CanCastShadow()
		{
			return false;
		}

		public override bool CanShadowDrop()
		{
			return false;
		}

		public override Vector3 GetCenterPositionOffset(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (CCPAJBOJDMN.ENBPGGCIADN == 3)
			{
				Cell currentCell = MasterItem.ENCFFNKONOO;
				if (currentCell != null)
				{
					return IDIOLIHBJBE.transform.position - currentCell.transform.position;
				}
			}
			return base.GetCenterPositionOffset(CCPAJBOJDMN);
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			switch (AKDMMEEHGHB)
			{
			case IEKBFJBLGFM.Right:
				PNINCDLIDLL.EEFMIHDPJPG = 194;
				break;
			case IEKBFJBLGFM.Left:
				PNINCDLIDLL.EEFMIHDPJPG = 195;
				break;
			case IEKBFJBLGFM.Down:
				PNINCDLIDLL.EEFMIHDPJPG = 196;
				break;
			case IEKBFJBLGFM.Up:
				PNINCDLIDLL.EEFMIHDPJPG = 197;
				break;
			case IEKBFJBLGFM.LeftUp:
			case IEKBFJBLGFM.LeftDown:
			case IEKBFJBLGFM.RightUp:
				break;
			}
		}
	}
}
