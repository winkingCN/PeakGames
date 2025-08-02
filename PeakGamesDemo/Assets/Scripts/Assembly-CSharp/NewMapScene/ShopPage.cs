using Assets.Scripts.MapScene;
using Dialogs.BuyCoins;
using Ui.VerticalScroll;
using UnityEngine;

namespace NewMapScene
{
	public class ShopPage : MonoBehaviour
	{
		public SpriteRenderer BackgroundImage;

		public BundleShopPage BundleContainer;

		public void Awake()
		{
			BackgroundImage.transform.localScale = new Vector3(ONCMBJKLKIL.EMFKAPJMDCC, ONCMBJKLKIL.FHAMOHDEGMK, 1f);
		}

		public void Start()
		{
			MapPageSizer currentMapPageSizer = MapManager.Instance.CurrentMapPageSizer;
			if (currentMapPageSizer.CurrentWidth > 0f)
			{
				AOJNCIHALBD(currentMapPageSizer.CurrentWidth);
			}
			else
			{
				currentMapPageSizer.PBNPBHCHODE += AOJNCIHALBD;
			}
		}

		private void AOJNCIHALBD(float HHHMOGOKFHF)
		{
			if (BundleContainer.gameObject.activeSelf)
			{
				BundleContainer.CurrentBundleContent.Prepare();
				VerticalScrollController scrollController = BundleContainer.CurrentBundleContent.ScrollController;
				float centerPanelExtend = MapManager.Instance.CurrentMapPageSizer.CenterPanelExtend;
				if (centerPanelExtend > 0f)
				{
					scrollController.ScrollArea.size = new Vector2(HHHMOGOKFHF, 13.34955f + centerPanelExtend);
					scrollController.SetOffsets((0f - centerPanelExtend) * 0.5f, (0f - centerPanelExtend) * 0.5f);
				}
				else
				{
					scrollController.ScrollArea.size = new Vector2(HHHMOGOKFHF, 13.34955f);
				}
				scrollController.ScrollArea.transform.localPosition = new Vector3(0f, (0f - centerPanelExtend) * 0.5f, 0f);
				BundleContainer.CurrentBundleContent.transform.localPosition = new Vector3(0f, -1.97f, 0f);
				BundleContainer.CurrentBundleContent.ShowAllOffers();
			}
		}
	}
}
