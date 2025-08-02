namespace GamePlayScene.Mechanics.Items
{
	public class GiantPinataFakeItem : FakeItem<GiantPinataItem>
	{
		public IEKBFJBLGFM PositionRelativeToMaster;

		public override bool CanCastShadow()
		{
			return false;
		}

		public override bool CanShadowDrop()
		{
			return PositionRelativeToMaster == IEKBFJBLGFM.Up || PositionRelativeToMaster == IEKBFJBLGFM.RightUp;
		}

		public override void SetExplodeDirection(IEKBFJBLGFM AJLDJAHHGOJ)
		{
			if (AJLDJAHHGOJ == IEKBFJBLGFM.None && ENCFFNKONOO != null)
			{
				AJLDJAHHGOJ = ENCFFNKONOO.GetDirectionTo(MasterItem.ENCFFNKONOO);
			}
			MasterItem.SetExplodeDirection(AJLDJAHHGOJ);
		}
	}
}
