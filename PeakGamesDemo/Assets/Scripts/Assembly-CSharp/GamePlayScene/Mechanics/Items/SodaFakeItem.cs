namespace GamePlayScene.Mechanics.Items
{
	public class SodaFakeItem : FakeItem<SodaItem>
	{
		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			return MasterItem.ExplodeBy(this, CCPAJBOJDMN);
		}
	}
}
