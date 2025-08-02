using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Dialogs.BuyCoins
{
	public class BundleEntry : MonoBehaviour
	{
		public TextMeshPro TitleText;

		public TextMeshPro CoinsText;

		public TextMeshPro PriceText;

		public BundleBoosterItem[] BoosterItems;

		public Collider2D ButtonCollider;

		public Transform CoinCollectPosition;

		public SpriteRenderer CoinsSpriteRenderer;

		public GameObject Badge;

		public TextMeshPro BadgeText;

		[HideInInspector]
		public string BundleId;

		[HideInInspector]
		public int CoinAmount;

		[HideInInspector]
		public int Order;

		private Action<string> LHJILGMJGPI;

		private static readonly Vector3[] JCDGLFEAEIE = new Vector3[6]
		{
			new Vector3(1.83f, -2.259f),
			new Vector3(1.758f, -2.433f),
			new Vector3(1.91f, -2.573f),
			new Vector3(1.916f, -2.609f),
			new Vector3(1.54f, -2.639f),
			new Vector3(1.528f, -2.633f)
		};

		public void SetContent(PMCGNIAAMND ECCBKJNBHMH, string LJFDPILBBFM, Action<string> DJFNMHFCLLI)
		{
			BundleId = ECCBKJNBHMH.FDIOHLPIGAI;
			CoinAmount = ECCBKJNBHMH.CIOENCFNLKH;
			Order = ECCBKJNBHMH.BHIJCAOHDCM;
			LHJILGMJGPI = DJFNMHFCLLI;
			TitleText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Bundle_" + ECCBKJNBHMH.BHIJCAOHDCM);
			CoinsText.FCJBBPHFNPJ = ECCBKJNBHMH.CIOENCFNLKH.ToString("# ##0").Replace(" ", "<size=-2> </size>");
			PriceText.FCJBBPHFNPJ = LJFDPILBBFM;
			Sprite sprite = Resources.Load<Sprite>("Bundles/BundleImage_0" + ECCBKJNBHMH.BHIJCAOHDCM);
			CoinsSpriteRenderer.sprite = sprite;
			CoinsSpriteRenderer.transform.localPosition = JCDGLFEAEIE[ECCBKJNBHMH.BHIJCAOHDCM - 1];
			CoinsSpriteRenderer.transform.localScale = Vector3.one * 1.428f;
			if (ECCBKJNBHMH.JEHNEDLEEHG != 0)
			{
				Badge.SetActive(true);
				switch (ECCBKJNBHMH.JEHNEDLEEHG)
				{
				case PMCGNIAAMND.CJMEIJFAHLA.Sale:
					BadgeText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Badge_Sale");
					BadgeText.DGLOHLPKABM = 5.8f;
					break;
				case PMCGNIAAMND.CJMEIJFAHLA.MostPopular:
					BadgeText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Badge_MostPopular");
					BadgeText.DGLOHLPKABM = 3.7f;
					break;
				case PMCGNIAAMND.CJMEIJFAHLA.Best:
					BadgeText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Badge_Best");
					BadgeText.DGLOHLPKABM = 4f;
					break;
				}
			}
			List<NAAHKHPBAPA> list = ((ECCBKJNBHMH.DDILBILNNFN <= 0) ? PMCGNIAAMND.OHDNIPPLMJO : PMCGNIAAMND.KCEHEMOIGHB);
			int count = list.Count;
			for (int i = 0; i < 8; i++)
			{
				BundleBoosterItem bundleBoosterItem = BoosterItems[i];
				if (i < count)
				{
					bundleBoosterItem.SetContent(list[i], ECCBKJNBHMH.AMKGEHCMHIA, ECCBKJNBHMH.DDILBILNNFN);
				}
				else
				{
					bundleBoosterItem.Hide();
				}
			}
		}

		public void DisableColliders()
		{
			ButtonCollider.enabled = false;
		}

		public void EnableColliders()
		{
			ButtonCollider.enabled = true;
		}

		public void ChangeColliderTag(string HIEPEOCIAFG)
		{
			ButtonCollider.tag = HIEPEOCIAFG;
		}

		public void OnClick()
		{
			if (LHJILGMJGPI != null)
			{
				LHJILGMJGPI(BundleId);
			}
		}

		private void OnDestroy()
		{
			LHJILGMJGPI = null;
		}
	}
}
