using TMPro;
using Ui.VerticalScroll;
using UnityEngine;

namespace Dialogs
{
	public class CLRewardsEntry : VerticalScrollEntry
	{
		public GameObject BackgroundSelf;

		public GameObject BackgroundOther;

		public TextMeshPro NicknameSelfText;

		public TextMeshPro NicknameOtherText;

		public SpriteRenderer MedalSpriteRenderer;

		public GameObject[] CoinsRewards;

		public GameObject InventoryItemContainer;

		public SpriteRenderer InventoryItem;

		public SpriteRenderer InventoryItemShadow;

		public TextMeshPro ItemAmount;

		public TextMeshPro RankText;

		public TextMeshPro ScoreText;

		public RewardText CoinRewardText;

		private long HNDDIFIANKG;

		public override void SetContent<T>(T IFLICJGCCNM)
		{
			if (HNDDIFIANKG == 0)
			{
				HNDDIFIANKG = LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM;
			}
			BDELNAHPDFB bDELNAHPDFB = IFLICJGCCNM as BDELNAHPDFB;
			if (bDELNAHPDFB != null)
			{
				bool flag = HNDDIFIANKG == bDELNAHPDFB.KKMJBOCCMCF;
				ENIHNAEFMNK(BackgroundOther, !flag);
				ENIHNAEFMNK(BackgroundSelf, flag);
				if (bDELNAHPDFB.OHAPPDGAKNG < 4)
				{
					ENIHNAEFMNK(InventoryItemContainer, false);
					int num = bDELNAHPDFB.OHAPPDGAKNG - 1;
					ENIHNAEFMNK(CoinsRewards[0], num == 0);
					ENIHNAEFMNK(CoinsRewards[1], num == 1);
					ENIHNAEFMNK(CoinsRewards[2], num == 2);
					CoinRewardText.SetRewardAmount(bDELNAHPDFB.BIEIJGOBEIA);
					RankText.enabled = false;
					MedalSpriteRenderer.enabled = true;
					MedalSpriteRenderer.sprite = SharedImageLibrary.Instance.GetMedalSprite(bDELNAHPDFB.OHAPPDGAKNG - 1);
				}
				else
				{
					ENIHNAEFMNK(CoinsRewards[0], false);
					ENIHNAEFMNK(CoinsRewards[1], false);
					ENIHNAEFMNK(CoinsRewards[2], false);
					CoinRewardText.Activate(false);
					ENIHNAEFMNK(InventoryItemContainer, bDELNAHPDFB.IHHMGILLMDB != 0);
					IELCJKCPPPN(bDELNAHPDFB.IHHMGILLMDB, bDELNAHPDFB.BIEIJGOBEIA);
					RankText.enabled = true;
					RankText.FCJBBPHFNPJ = bDELNAHPDFB.OHAPPDGAKNG.ToString();
					MedalSpriteRenderer.enabled = false;
					MedalSpriteRenderer.sprite = null;
				}
				NicknameSelfText.enabled = flag;
				NicknameOtherText.enabled = !flag;
				NicknameSelfText.FCJBBPHFNPJ = bDELNAHPDFB.KJACEODCOHN;
				NicknameOtherText.FCJBBPHFNPJ = bDELNAHPDFB.KJACEODCOHN;
				ScoreText.FCJBBPHFNPJ = bDELNAHPDFB.DJADMBLKBKJ.ToString();
				RankText.FCJBBPHFNPJ = bDELNAHPDFB.OHAPPDGAKNG.ToString();
			}
		}

		private void IELCJKCPPPN(int DHAMHHHNKEA, int NNIDKMJGAJO)
		{
			if (DHAMHHHNKEA != 0)
			{
				Sprite spriteByInventoryType = SharedImageLibrary.Instance.GetSpriteByInventoryType((NAAHKHPBAPA)DHAMHHHNKEA);
				InventoryItem.sprite = spriteByInventoryType;
				InventoryItemShadow.sprite = spriteByInventoryType;
				PDHNGJPKLPB((NAAHKHPBAPA)DHAMHHHNKEA);
				if (DHAMHHHNKEA != 1 && NNIDKMJGAJO > 1)
				{
					ItemAmount.enabled = true;
					ItemAmount.FCJBBPHFNPJ = "x" + NNIDKMJGAJO;
				}
			}
		}

		private void PDHNGJPKLPB(NAAHKHPBAPA GEKKLIKPAPP)
		{
			switch (GEKKLIKPAPP)
			{
			case NAAHKHPBAPA.BoxingGlove:
				InventoryItem.transform.localScale = InventoryItem.transform.localScale * 1.26f;
				break;
			case NAAHKHPBAPA.Rocket:
				InventoryItem.transform.localScale = InventoryItem.transform.localScale * 0.9f;
				break;
			case NAAHKHPBAPA.DiscoBall:
				InventoryItem.transform.localScale = InventoryItem.transform.localScale * 0.96f;
				break;
			case NAAHKHPBAPA.Dice:
				InventoryItem.transform.localScale = InventoryItem.transform.localScale * 0.9f;
				InventoryItem.transform.localPosition = InventoryItem.transform.localPosition + Vector3.right * 0.06f;
				break;
			case NAAHKHPBAPA.Bomb:
			case NAAHKHPBAPA.Extra5Moves:
				break;
			}
		}

		private void ENIHNAEFMNK(GameObject LGDFKAMHKFM, bool ODCADGABBHJ)
		{
			if (LGDFKAMHKFM.activeSelf != ODCADGABBHJ)
			{
				LGDFKAMHKFM.SetActive(ODCADGABBHJ);
			}
		}
	}
}
