using TMPro;
using ToonSocial;
using Ui.VerticalScroll;
using UnityEngine;

namespace Dialogs
{
	public class TeamTournamentPlayerEntry : VerticalScrollEntry
	{
		public GameObject BackgroundSelf;

		public GameObject BackgroundOther;

		public TextMeshPro LeaderOther;

		public TextMeshPro LeaderSelf;

		public TextMeshPro NicknameOtherText;

		public TextMeshPro NicknameSelfText;

		public TextMeshPro RankSelfText;

		public TextMeshPro RankOtherText;

		public TextMeshPro StarScoreText;

		private SocialHelper KCMNBMGCKKI;

		public override void SetContent<T>(T HOMONAAFMFH)
		{
			if (BackgroundSelf == null)
			{
				return;
			}
			KFHNJBEEPBL kFHNJBEEPBL = HOMONAAFMFH as KFHNJBEEPBL;
			if (kFHNJBEEPBL != null)
			{
				ENIHNAEFMNK(BackgroundOther, !kFHNJBEEPBL.MNPEKJAAFHD);
				ENIHNAEFMNK(BackgroundSelf, kFHNJBEEPBL.MNPEKJAAFHD);
				RankSelfText.enabled = kFHNJBEEPBL.MNPEKJAAFHD;
				RankOtherText.enabled = !kFHNJBEEPBL.MNPEKJAAFHD;
				RankSelfText.FCJBBPHFNPJ = kFHNJBEEPBL.OHAPPDGAKNG.ToString();
				RankOtherText.FCJBBPHFNPJ = kFHNJBEEPBL.OHAPPDGAKNG.ToString();
				StarScoreText.FCJBBPHFNPJ = kFHNJBEEPBL.OGEMDHPJHFO.ToString();
				if (kFHNJBEEPBL.GHADDDMNNIL)
				{
					LeaderSelf.gameObject.SetActive(kFHNJBEEPBL.MNPEKJAAFHD);
					LeaderOther.gameObject.SetActive(!kFHNJBEEPBL.MNPEKJAAFHD);
					NicknameSelfText.enabled = false;
					NicknameOtherText.enabled = false;
					LeaderSelf.FCJBBPHFNPJ = kFHNJBEEPBL.ABHNFOBGFCO;
					LeaderOther.FCJBBPHFNPJ = kFHNJBEEPBL.ABHNFOBGFCO;
				}
				else
				{
					LeaderSelf.gameObject.SetActive(false);
					LeaderOther.gameObject.SetActive(false);
					NicknameSelfText.enabled = kFHNJBEEPBL.MNPEKJAAFHD;
					NicknameOtherText.enabled = !kFHNJBEEPBL.MNPEKJAAFHD;
					NicknameSelfText.FCJBBPHFNPJ = kFHNJBEEPBL.ABHNFOBGFCO;
					NicknameOtherText.FCJBBPHFNPJ = kFHNJBEEPBL.ABHNFOBGFCO;
				}
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
