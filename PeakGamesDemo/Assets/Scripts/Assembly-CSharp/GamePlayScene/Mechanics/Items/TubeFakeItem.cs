namespace GamePlayScene.Mechanics.Items
{
	public class TubeFakeItem : FakeItem<TubeItem>
	{
		public IEKBFJBLGFM PositionRelativeToMaster;

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			return MasterItem.ExplodeBy(PositionRelativeToMaster, CCPAJBOJDMN);
		}
	}
}
