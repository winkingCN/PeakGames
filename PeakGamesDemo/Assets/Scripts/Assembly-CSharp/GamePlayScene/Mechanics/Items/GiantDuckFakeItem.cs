namespace GamePlayScene.Mechanics.Items
{
	public class GiantDuckFakeItem : FakeItem<GiantDuckItem>, JFIEHOCCBNG
	{
		public bool IsBottomRight;

		public override int GetScore()
		{
			return 0;
		}

		public override bool CanFall()
		{
			return false;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return IsBottomRight;
		}

		public override bool CanCastShadow()
		{
			return IsBottomRight;
		}

		public void ExplosionOccured(int CIDKKPKJJAE)
		{
			MasterItem.ExplosionOccured(CIDKKPKJJAE);
		}
	}
}
