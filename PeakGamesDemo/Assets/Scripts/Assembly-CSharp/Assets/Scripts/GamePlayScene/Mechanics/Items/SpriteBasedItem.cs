using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Items
{
	public abstract class SpriteBasedItem : Item
	{
		public SpriteRenderer CurrentSpriteRenderer;

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			CurrentSpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			CurrentSpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM;
		}

		public override CKKKELDIOLD GetSorting()
		{
			return new CKKKELDIOLD(CurrentSpriteRenderer.sortingLayerID, CurrentSpriteRenderer.sortingOrder);
		}
	}
}
