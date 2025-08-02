namespace GamePlayScene.Mechanics.Items
{
	public class ColoredSodaFakeItem : FakeItem<ColoredSodaItem>
	{
		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			return MasterItem.ExplodeBy(this, CCPAJBOJDMN);
		}
	}
}
