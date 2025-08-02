namespace GamePlayScene.Mechanics.Items
{
	public class CanTossFakeItem : FakeItem<CanTossItem>
	{
		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			return MasterItem.TryExplode(CCPAJBOJDMN);
		}
	}
}
