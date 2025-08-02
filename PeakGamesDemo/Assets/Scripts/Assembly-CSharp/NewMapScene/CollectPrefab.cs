using UnityEngine;

namespace NewMapScene
{
	public class CollectPrefab : MonoBehaviour
	{
		public SpriteRenderer CollectSpriteRenderer;

		public int BaseSortingOrder;

		public void ChangeSortingLayer(CKKKELDIOLD IBBBMACIBGK)
		{
			CollectSpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			CollectSpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM;
		}

		public void IncreaseSortingOrder(int EAANFOPONAJ)
		{
			CollectSpriteRenderer.sortingOrder = BaseSortingOrder + EAANFOPONAJ;
		}
	}
}
