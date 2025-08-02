using System;
using Assets.Scripts.Utils;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.Dialogs
{
	public class BoosterUnlockedDialog : SimpleDialog
	{
		public SpriteRenderer InventoryItemImage;

		public TextMeshPro DescriptionText;

		public TextMeshPro TitleText;

		private Action LKENIEGGFJG;

		public override void PlayDialogInAnimation()
		{
			base.PlayDialogInAnimation();
			AudioManager.PlayStingerWithoutStopingSong(KOOGPFAPGGD.StingerBoosterUnlocked);
		}

		public void SetResourceItem(NAAHKHPBAPA HBBIFNLDKPO, Action OMIODDBILMO = null)
		{
			LKENIEGGFJG = OMIODDBILMO;
			Vector3 localPosition = new Vector3(0f, 0.8f, 0f);
			Vector3 localScale = new Vector3(2f, 2f, 2f);
			switch (HBBIFNLDKPO)
			{
			case NAAHKHPBAPA.Hammer:
				TitleText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Hammer");
				DescriptionText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("HammerBuy");
				localPosition.y = 0.086f;
				localScale = Vector3.one * 1.352f;
				break;
			case NAAHKHPBAPA.Anvil:
				TitleText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Anvil");
				DescriptionText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("AnvilBuy");
				localPosition.x = 0.225f;
				localPosition.y = 0.012f;
				localScale = Vector3.one * 1.26f;
				break;
			case NAAHKHPBAPA.BoxingGlove:
				TitleText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("BoxingGlove");
				DescriptionText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("BoxingGloveBuy");
				localPosition.x = 0.037f;
				localPosition.y = 0.104f;
				localScale = Vector3.one * 1.6f;
				break;
			case NAAHKHPBAPA.Dice:
				TitleText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Shuffle");
				DescriptionText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("ShuffleBuy");
				localScale = Vector3.one * 1.11f;
				localPosition.x = 0f;
				localPosition.y = 0.095f;
				break;
			default:
				TitleText.FCJBBPHFNPJ = HBBIFNLDKPO.ToString();
				DescriptionText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Buy") + " " + HBBIFNLDKPO;
				break;
			}
			InventoryItemImage.sprite = SharedImageLibrary.Instance.GetSpriteByInventoryType(HBBIFNLDKPO);
			InventoryItemImage.transform.localPosition = localPosition;
			InventoryItemImage.transform.localScale = localScale;
		}

		public override void OnDialogClosed()
		{
			base.OnDialogClosed();
			if (LKENIEGGFJG != null)
			{
				LKENIEGGFJG();
			}
		}
	}
}
