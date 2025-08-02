using Assets.Scripts.MapScene;
using DG.Tweening;
using TMPro;
using ToonSocial;
using Ui.VerticalScroll;
using UnityEngine;
using Utils;

namespace Dialogs
{
	public class TeamTournamentTeamEntry : VerticalScrollEntry
	{
		public GameObject BackgroundSelf;

		public GameObject BackgroundOther;

		public GameObject[] CoinsRewards;

		public SpriteRenderer TeamBadge;

		public TextMeshPro TeamnameOtherText;

		public TextMeshPro TeamnameSelfText;

		public TextMeshPro RankSelfText;

		public TextMeshPro RankOtherText;

		public TextMeshPro StarScoreText;

		public RewardText CoinRewardText;

		public BoxCollider2D ViewCollider;

		public KickButton ViewButton;

		private static KickButton LFJBMNDECHL;

		private SocialHelper KCMNBMGCKKI;

		private long KKMIEDBFCOB;

		private void DAJGABKGNHI()
		{
			if (ViewButton == null || KKMIEDBFCOB <= 0)
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
			component.ShowTeamInfoFromParent((int)KKMIEDBFCOB, KCMNBMGCKKI);
			component.SetReferral(7);
			ViewButton.Hide();
		}

		public void OnEntryClick()
		{
			DAJGABKGNHI();
		}

		public override void SetContent<T>(T HOMONAAFMFH)
		{
			CGKLKAOGGJB cGKLKAOGGJB = HOMONAAFMFH as CGKLKAOGGJB;
			if (cGKLKAOGGJB != null)
			{
				ENIHNAEFMNK(BackgroundOther, !cGKLKAOGGJB.OBMLPJHJOCL);
				ENIHNAEFMNK(BackgroundSelf, cGKLKAOGGJB.OBMLPJHJOCL);
				if (cGKLKAOGGJB.OHAPPDGAKNG < 6)
				{
					int num = cGKLKAOGGJB.OHAPPDGAKNG - 1;
					AGDBBOAKAFP(false);
					ENIHNAEFMNK(CoinsRewards[num], true);
					CoinRewardText.SetRewardAmount(cGKLKAOGGJB.BIEIJGOBEIA, true);
					DJMJNAKOJGM(false);
				}
				else
				{
					AGDBBOAKAFP(false);
					CoinRewardText.Activate(false);
					DJMJNAKOJGM(true);
				}
				KKMIEDBFCOB = cGKLKAOGGJB.OADDPGNIINO;
				RankSelfText.enabled = cGKLKAOGGJB.OBMLPJHJOCL;
				RankOtherText.enabled = !cGKLKAOGGJB.OBMLPJHJOCL;
				RankSelfText.FCJBBPHFNPJ = cGKLKAOGGJB.OHAPPDGAKNG.ToString();
				RankOtherText.FCJBBPHFNPJ = cGKLKAOGGJB.OHAPPDGAKNG.ToString();
				StarScoreText.FCJBBPHFNPJ = cGKLKAOGGJB.OGEMDHPJHFO.ToString();
				TeamnameSelfText.enabled = cGKLKAOGGJB.OBMLPJHJOCL;
				TeamnameOtherText.enabled = !cGKLKAOGGJB.OBMLPJHJOCL;
				TeamnameSelfText.FCJBBPHFNPJ = cGKLKAOGGJB.EFHEIFMEJCN;
				TeamnameOtherText.FCJBBPHFNPJ = cGKLKAOGGJB.EFHEIFMEJCN;
				KCMNBMGCKKI = MapManager.Instance.CurrentSocialHelper;
				Badges badgesDictionary = KCMNBMGCKKI.BadgesDictionary;
				Sprite badge = badgesDictionary.GetBadge(cGKLKAOGGJB.GCELBDIDEAI);
				if (badge != null)
				{
					TeamBadge.sprite = badge;
				}
				TeamBadge.color = Color.white;
			}
		}

		private void AGDBBOAKAFP(bool ODCADGABBHJ)
		{
			int i = 0;
			for (int num = CoinsRewards.Length; i < num; i++)
			{
				ENIHNAEFMNK(CoinsRewards[i], ODCADGABBHJ);
			}
		}

		private void ENIHNAEFMNK(GameObject LGDFKAMHKFM, bool ODCADGABBHJ)
		{
			if (LGDFKAMHKFM.activeSelf != ODCADGABBHJ)
			{
				LGDFKAMHKFM.SetActive(ODCADGABBHJ);
			}
		}

		private void DJMJNAKOJGM(bool ODCADGABBHJ)
		{
			if (!(ViewCollider == null))
			{
				ViewCollider.offset = ((!ODCADGABBHJ) ? new Vector2(-2.17f, 0.05f) : new Vector2(-0.86f, 0.05f));
				ViewCollider.size = ((!ODCADGABBHJ) ? new Vector2(5.16f, 1.41f) : new Vector2(7.78f, 1.41f));
			}
		}

		public void ShowRewardInfo()
		{
			MapManager.Instance.ShowErrorMessageAtPosition(NKILHODNBDE.GHBGCADFLFB("TeamTournamentRewardInfo"), base.transform.position, 0.5f, 1f, 0.5f);
		}
	}
}
