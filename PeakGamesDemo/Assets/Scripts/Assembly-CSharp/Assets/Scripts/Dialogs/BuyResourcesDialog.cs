using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.MapScene;
using Assets.Scripts.SceneTransitions;
using Assets.Scripts.Utils;
using Dialogs.BuyCoins;
using TMPro;
using UnityEngine;
using Utils;

namespace Assets.Scripts.Dialogs
{
	public class BuyResourcesDialog : SimpleDialog
	{
		public SpriteRenderer InventoryItemImage;

		public SpriteRenderer HeartShadow;

		public SpriteMask JapanneseSunMask;

		public TextMeshPro MaxLifeText;

		public TextMeshPro BuyCountText;

		public TextMeshPro ContentText;

		public TextMeshPro CostText;

		public TextMeshPro TitleText;

		public TextMeshPro ButtonText;

		public SpriteRenderer[] BackgroundSprites;

		public SpriteRenderer[] PanelSprites;

		public Transform[] ButtonBackground;

		public Transform BuyButton;

		private bool CDHEJHFDGBM;

		private NAAHKHPBAPA KFLAELKHKKI;

		private Action<NAAHKHPBAPA> GAOABGCOGIL;

		private bool JGAPCKLPDEO;

		private IBGBAKAEEKI FDPAHFHJCAC;

		private string CHDHALMJOJH;

		public void SetResourceItem(NAAHKHPBAPA HBBIFNLDKPO, IBGBAKAEEKI ECCBKJNBHMH, Action<NAAHKHPBAPA> BCMADFBFGJA)
		{
			KFLAELKHKKI = HBBIFNLDKPO;
			GAOABGCOGIL = BCMADFBFGJA;
			FDPAHFHJCAC = ECCBKJNBHMH;
			CostText.FCJBBPHFNPJ = FDPAHFHJCAC.FDNCJEHPFFJ.ToString();
			Vector3 localPosition = new Vector3(0f, 0.8f, 0f);
			Vector3 localScale = new Vector3(1.35f, 1.35f, 1.35f);
			InventoryItemImage.sprite = SharedImageLibrary.Instance.GetSpriteByInventoryType(HBBIFNLDKPO);
			InventoryItemImage.transform.localPosition = localPosition;
			InventoryItemImage.transform.localScale = localScale;
			switch (HBBIFNLDKPO)
			{
			case NAAHKHPBAPA.Hammer:
				TitleText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Hammer");
				ContentText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("HammerBuy");
				localPosition.y = 0.864f;
				localScale = Vector3.one * 1.35f;
				break;
			case NAAHKHPBAPA.Anvil:
				TitleText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Anvil");
				ContentText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("AnvilBuy");
				localPosition.x = 0.14f;
				localScale = Vector3.one * 1.29f;
				break;
			case NAAHKHPBAPA.BoxingGlove:
				TitleText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("BoxingGlove");
				ContentText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("BoxingGloveBuy");
				localScale = Vector3.one * 1.79f;
				break;
			case NAAHKHPBAPA.Dice:
				TitleText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Shuffle");
				ContentText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("ShuffleBuy");
				localScale = Vector3.one * 1.26f;
				localPosition.x = 0f;
				localPosition.y = 0.8f;
				break;
			case NAAHKHPBAPA.Rocket:
				TitleText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Rocket");
				ContentText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("RocketBuy");
				localPosition.y = 0.855f;
				localScale = Vector3.one * 1.315f;
				break;
			case NAAHKHPBAPA.Bomb:
				TitleText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Bomb");
				ContentText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("BombBuy");
				localPosition.x = 0.019f;
				localPosition.y = 0.864f;
				localScale = Vector3.one * 1.35f;
				break;
			case NAAHKHPBAPA.DiscoBall:
				TitleText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("DiscoBall");
				ContentText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("DiscoBallBuy");
				localScale = Vector3.one * 1.315f;
				break;
			case NAAHKHPBAPA.Life:
				MaxLifeText.enabled = true;
				BuyCountText.enabled = false;
				HeartShadow.enabled = true;
				ContentText.enabled = false;
				MaxLifeText.FCJBBPHFNPJ = 5.ToString();
				ButtonText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Refill");
				TitleText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("RefillLives");
				localScale = Vector3.one * 1.415f;
				PKOGBFDLGIF();
				break;
			default:
				TitleText.FCJBBPHFNPJ = HBBIFNLDKPO.ToString();
				ContentText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Buy") + " " + HBBIFNLDKPO;
				break;
			}
			InventoryItemImage.transform.localPosition = localPosition;
			InventoryItemImage.transform.localScale = localScale;
		}

		private void PKOGBFDLGIF()
		{
			for (int i = 0; i < 2; i++)
			{
				Vector2 size = BackgroundSprites[i].size;
				Vector3 localPosition = BackgroundSprites[i].transform.localPosition;
				size.y = 6.109f;
				localPosition.y = 0.709f;
				BackgroundSprites[i].size = size;
				BackgroundSprites[i].transform.localPosition = localPosition;
				size = PanelSprites[i].size;
				localPosition = PanelSprites[i].transform.localPosition;
				size.y = 3.435f;
				localPosition.y = 0.493f;
				PanelSprites[i].size = size;
				PanelSprites[i].transform.localPosition = localPosition;
				localPosition = ButtonBackground[i].localPosition;
				localPosition.y = -2.765f;
				ButtonBackground[i].localPosition = localPosition;
			}
			Vector3 localPosition2 = BuyButton.localPosition;
			localPosition2.y = -2.2f;
			BuyButton.localPosition = localPosition2;
			Vector2 size2 = JapanneseSunMask.MOFHAKELNPN;
			Vector2 pivot = JapanneseSunMask.IIFBHCMJEKK;
			pivot.y = 0.24f;
			size2.y = 1.52f;
			JapanneseSunMask.IIFBHCMJEKK = pivot;
			JapanneseSunMask.MOFHAKELNPN = size2;
		}

		public void AddResources()
		{
			bool eEKJMDHEJCK = false;
			int jFLJEAAONLI = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins);
			if (GEBAAFFGKJG.GABGKBAKHDP.DCAKPPKFOEP(NAAHKHPBAPA.Coins, FDPAHFHJCAC.FDNCJEHPFFJ))
			{
				CDHEJHFDGBM = true;
				eEKJMDHEJCK = true;
				HPKKDINNMHB();
				Close();
			}
			else if (CaravanSceneManager.CurrentScene != GKBHIKONCKJ.GamePlay && "shop" == OutOfLivesDialog.RefillStatus)
			{
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("NotEnoughCoins"));
			}
			else
			{
				CHDHALMJOJH = KFLAELKHKKI.ToString();
				JGAPCKLPDEO = true;
				Close();
			}
			AFJPGLHKOID.GEEIAHDELAO(CHDHALMJOJH, jFLJEAAONLI, FDPAHFHJCAC.FDNCJEHPFFJ, eEKJMDHEJCK, OutOfLivesDialog.RefillStatus);
		}

		public override void OnDialogClosed()
		{
			base.OnDialogClosed();
			if (JGAPCKLPDEO)
			{
				int eJICKCGPFAH = FDPAHFHJCAC.FDNCJEHPFFJ - GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins);
				HLJHIJOGIBN.LKHOELJMLID = HLJHIJOGIBN.PMHLLJMKMBK(KFLAELKHKKI);
				GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.BuyCoinsBundleDialog, false);
				BundleShopDialog component = gameObject.GetComponent<BundleShopDialog>();
				component.DoNotDisplayUnder(eJICKCGPFAH);
				component.AfterCloseDo(delegate(NAAHKHPBAPA NBFBPNNEKMN, bool GKHLKDONJEF)
				{
					if (NBFBPNNEKMN == NAAHKHPBAPA.None)
					{
						BuyResourcesDialog component2 = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.BuyResourcesDialog, false).GetComponent<BuyResourcesDialog>();
						component2.SetResourceItem(KFLAELKHKKI, FDPAHFHJCAC, GAOABGCOGIL);
					}
					else
					{
						CDHEJHFDGBM = GKHLKDONJEF;
						if (!CDHEJHFDGBM)
						{
							KKBJIJBJCED(NBFBPNNEKMN);
						}
						if (GAOABGCOGIL != null)
						{
							GAOABGCOGIL(NAAHKHPBAPA.None);
						}
					}
				});
			}
			else if (GAOABGCOGIL != null)
			{
				GAOABGCOGIL(CDHEJHFDGBM ? KFLAELKHKKI : NAAHKHPBAPA.None);
			}
		}

		private void KKBJIJBJCED(NAAHKHPBAPA NEMEKIOEOLC)
		{
			if (NEMEKIOEOLC == NAAHKHPBAPA.Coins)
			{
				int num = FDPAHFHJCAC.FDNCJEHPFFJ;
				int jFLJEAAONLI = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins);
				if (GEBAAFFGKJG.GABGKBAKHDP.DCAKPPKFOEP(NAAHKHPBAPA.Coins, num))
				{
					HPKKDINNMHB();
					AFJPGLHKOID.GEEIAHDELAO(CHDHALMJOJH, jFLJEAAONLI, num, true, OutOfLivesDialog.RefillStatus);
				}
			}
		}

		private void HPKKDINNMHB()
		{
			CDHEJHFDGBM = true;
			CHDHALMJOJH = KFLAELKHKKI.ToString();
			NAAHKHPBAPA kFLAELKHKKI = KFLAELKHKKI;
			if (kFLAELKHKKI == NAAHKHPBAPA.Life)
			{
				AudioManager.Play(KOOGPFAPGGD.UiLifeFill);
				PJPPADHKGHN.GABGKBAKHDP.MMECFKDOBDC();
			}
			else
			{
				AudioManager.Play(KOOGPFAPGGD.UiBuyBooster);
				GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(KFLAELKHKKI, FDPAHFHJCAC.GMCGMPEEHJP);
			}
		}

		[CompilerGenerated]
		private void OAGBODOPKFK(NAAHKHPBAPA NBFBPNNEKMN, bool GKHLKDONJEF)
		{
			if (NBFBPNNEKMN == NAAHKHPBAPA.None)
			{
				BuyResourcesDialog component = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.BuyResourcesDialog, false).GetComponent<BuyResourcesDialog>();
				component.SetResourceItem(KFLAELKHKKI, FDPAHFHJCAC, GAOABGCOGIL);
				return;
			}
			CDHEJHFDGBM = GKHLKDONJEF;
			if (!CDHEJHFDGBM)
			{
				KKBJIJBJCED(NBFBPNNEKMN);
			}
			if (GAOABGCOGIL != null)
			{
				GAOABGCOGIL(NAAHKHPBAPA.None);
			}
		}
	}
}
