using Assets.Scripts.MapScene;
using DG.Tweening;
using TMPro;
using ToonSocial;
using Ui.VerticalScroll;
using UnityEngine;
using Utils;

namespace Dialogs
{
	public class StarTournamentEntry : VerticalScrollEntry
	{
		private static KickButton LFJBMNDECHL;

		public GameObject BackgroundSelf;

		public GameObject BackgroundOther;

		public GameObject InventoryItemContainer;

		public GameObject[] CoinsRewards;

		public SpriteRenderer MedalSpriteRenderer;

		public SpriteRenderer InventoryItem;

		public SpriteRenderer InventoryItemShadow;

		public SpriteRenderer TeamBadge;

		public TextMeshPro NicknameOtherText;

		public TextMeshPro NicknameSelfText;

		public TextMeshPro TeamNameText;

		public TextMeshPro ItemAmount;

		public TextMeshPro RankText;

		public TextMeshPro StarScoreText;

		public RewardText CoinRewardText;

		public KickButton ViewButton;

		private SocialHelper KCMNBMGCKKI;

		private int KKMIEDBFCOB;

		private long HNDDIFIANKG;

		private void DAJGABKGNHI()
		{
			if (KKMIEDBFCOB <= 0)
			{
				return;
			}
			bool flag = !ViewButton.IsActive();
			if (flag)
			{
				if (LFJBMNDECHL != null && LFJBMNDECHL != ViewButton)
				{
					LFJBMNDECHL.Hide();
				}
				LFJBMNDECHL = ViewButton;
			}
			else
			{
				LFJBMNDECHL = null;
			}
			float num = base.transform.parent.localPosition.y + base.transform.localPosition.y;
			ViewButton.Show(num < 1.3f);
			ViewButton.gameObject.SetActive(flag);
			ViewButton.transform.DOKill();
			ViewButton.transform.localScale = Vector3.zero;
			ViewButton.transform.DOScale(1f, 0.3f).SetEase(Ease.OutBack);
		}

		public void OnViewClick()
		{
			MapManager.Instance.CurrentSocialHelper.StartSocialHelper();
			GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.SocialTeamInfoJoinDialog, false);
			TeamInfoJoinDialog component = gameObject.GetComponent<TeamInfoJoinDialog>();
			component.ShowTeamInfoFromParent(KKMIEDBFCOB, KCMNBMGCKKI);
			component.SetReferral(5);
			ViewButton.Hide();
		}

		public void OnEntryClick()
		{
			DAJGABKGNHI();
		}

		public override void SetContent<T>(T HOMONAAFMFH)
		{
			if (HNDDIFIANKG == 0)
			{
				HNDDIFIANKG = LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM;
			}
			POGHNPKEOKP pOGHNPKEOKP = HOMONAAFMFH as POGHNPKEOKP;
			if (pOGHNPKEOKP == null)
			{
				return;
			}
			ENIHNAEFMNK(BackgroundOther, !pOGHNPKEOKP.MNPEKJAAFHD);
			ENIHNAEFMNK(BackgroundSelf, pOGHNPKEOKP.MNPEKJAAFHD);
			if (pOGHNPKEOKP.OHAPPDGAKNG < 4)
			{
				ENIHNAEFMNK(InventoryItemContainer, false);
				int num = pOGHNPKEOKP.OHAPPDGAKNG - 1;
				ENIHNAEFMNK(CoinsRewards[0], num == 0);
				ENIHNAEFMNK(CoinsRewards[1], num == 1);
				ENIHNAEFMNK(CoinsRewards[2], num == 2);
				CoinRewardText.SetRewardAmount(pOGHNPKEOKP.BIEIJGOBEIA);
				RankText.enabled = false;
				MedalSpriteRenderer.enabled = true;
				MedalSpriteRenderer.sprite = SharedImageLibrary.Instance.GetMedalSprite(pOGHNPKEOKP.OHAPPDGAKNG - 1);
			}
			else
			{
				ENIHNAEFMNK(CoinsRewards[0], false);
				ENIHNAEFMNK(CoinsRewards[1], false);
				ENIHNAEFMNK(CoinsRewards[2], false);
				CoinRewardText.Activate(false);
				ENIHNAEFMNK(InventoryItemContainer, pOGHNPKEOKP.IHHMGILLMDB != 0);
				IELCJKCPPPN(pOGHNPKEOKP.IHHMGILLMDB, pOGHNPKEOKP.BIEIJGOBEIA);
				RankText.enabled = true;
				RankText.FCJBBPHFNPJ = pOGHNPKEOKP.OHAPPDGAKNG.ToString();
				MedalSpriteRenderer.enabled = false;
				MedalSpriteRenderer.sprite = null;
			}
			NicknameSelfText.enabled = pOGHNPKEOKP.MNPEKJAAFHD;
			NicknameOtherText.enabled = !pOGHNPKEOKP.MNPEKJAAFHD;
			KCMNBMGCKKI = MapManager.Instance.CurrentSocialHelper;
			Badges badgesDictionary = KCMNBMGCKKI.BadgesDictionary;
			if (string.IsNullOrEmpty(pOGHNPKEOKP.EFHEIFMEJCN))
			{
				TeamNameText.enabled = false;
				TeamBadge.sprite = badgesDictionary.BlankSprite;
				TeamBadge.color = new Color(0.827451f, 0.6509804f, 0.4745098f);
				NicknameOtherText.ANLKLKAINEO.localPosition = new Vector3(NicknameOtherText.ANLKLKAINEO.localPosition.x, 0.039f);
				NicknameSelfText.ANLKLKAINEO.localPosition = new Vector3(NicknameOtherText.ANLKLKAINEO.localPosition.x, 0.044f);
			}
			else
			{
				TeamNameText.enabled = true;
				TeamNameText.FCJBBPHFNPJ = pOGHNPKEOKP.EFHEIFMEJCN;
				Sprite badge = badgesDictionary.GetBadge(pOGHNPKEOKP.GCELBDIDEAI);
				if (badge != null)
				{
					TeamBadge.sprite = badge;
				}
				TeamBadge.color = Color.white;
				NicknameOtherText.ANLKLKAINEO.localPosition = new Vector3(NicknameOtherText.ANLKLKAINEO.localPosition.x, 0.226f);
				NicknameSelfText.ANLKLKAINEO.localPosition = new Vector3(NicknameOtherText.ANLKLKAINEO.localPosition.x, 0.231f);
			}
			if (string.IsNullOrEmpty(pOGHNPKEOKP.KJACEODCOHN))
			{
				NicknameSelfText.FCJBBPHFNPJ = "Player";
				NicknameOtherText.FCJBBPHFNPJ = "Player";
			}
			else
			{
				NicknameSelfText.FCJBBPHFNPJ = pOGHNPKEOKP.KJACEODCOHN;
				NicknameOtherText.FCJBBPHFNPJ = pOGHNPKEOKP.KJACEODCOHN;
			}
			StarScoreText.FCJBBPHFNPJ = pOGHNPKEOKP.OGEMDHPJHFO.ToString();
			RankText.FCJBBPHFNPJ = pOGHNPKEOKP.OHAPPDGAKNG.ToString();
			KKMIEDBFCOB = pOGHNPKEOKP.OADDPGNIINO;
		}

		private void IELCJKCPPPN(int MLMPDNGDCFI, int NNIDKMJGAJO)
		{
			if (MLMPDNGDCFI != 0)
			{
				Sprite spriteByInventoryType = SharedImageLibrary.Instance.GetSpriteByInventoryType((NAAHKHPBAPA)MLMPDNGDCFI);
				InventoryItem.sprite = spriteByInventoryType;
				InventoryItemShadow.sprite = spriteByInventoryType;
				PDHNGJPKLPB((NAAHKHPBAPA)MLMPDNGDCFI);
				if (MLMPDNGDCFI != 1 && NNIDKMJGAJO > 0)
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
