using DG.Tweening;
using Dialogs;
using TMPro;
using ToonSocial.dialogs;
using Ui.VerticalScroll;
using UnityEngine;
using Utils;

namespace ToonSocial.ui.joined
{
	public class FriendEntry : VerticalScrollEntry
	{
		public TextMeshPro NameText;

		public TextMeshPro CurrentUserName;

		public TextMeshPro CurrentUserLeaderText;

		public TextMeshPro LeaderTitleText;

		public TextMeshPro LeaderNameText;

		public TextMeshPro OrderNoText;

		public TextMeshPro HelpsText;

		public TextMeshPro HelpsCountText;

		public TextMeshPro LevelText;

		public TextMeshPro MaxLevelText;

		public SpriteRenderer MedalImage;

		public KickButton KickButton;

		public GameObject BackgroundOther;

		public GameObject BackgroundMe;

		public Collider2D CurrentCollider;

		private SocialHelper KCMNBMGCKKI;

		private BMHDDEMBAEM KHNCGJNJAED;

		public GameObject CLContainer;

		public TextMeshPro CLScore;

		private static readonly Color NDKAPKKDLDO = new Color(0.5137255f, 0.101960786f, 0.10980392f);

		private static readonly Color OIMCPBFOLAD = new Color(32f / 51f, 38f / 85f, 24f / 85f);

		public void ShowKick()
		{
			if (KHNCGJNJAED.OGHDEOIFKFP)
			{
				bool active = !KickButton.IsActive();
				float num = base.transform.parent.localPosition.y + base.transform.localPosition.y;
				KickButton.Show(num < 4.5f);
				KickButton.gameObject.SetActive(active);
				KickButton.transform.DOKill();
				KickButton.transform.localScale = Vector3.zero;
				KickButton.transform.DOScale(1f, 0.3f).SetEase(Ease.OutBack);
			}
		}

		public void Kick()
		{
			if (KHNCGJNJAED.OGHDEOIFKFP)
			{
				KickButton.Hide();
				KickUserDialog component = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.SocialConfirmKickDialog, false).GetComponent<KickUserDialog>();
				component.Prepare(KHNCGJNJAED.GDMECFECCOM, KHNCGJNJAED.EALJKKBHDHK, KCMNBMGCKKI);
			}
		}

		private void JIMBAPGACIJ(BMHDDEMBAEM MBBPBGHKLJM)
		{
			KHNCGJNJAED = MBBPBGHKLJM;
			KCMNBMGCKKI = MBBPBGHKLJM.IPCAELIMIBN;
			KHDEEMPLHKA(MBBPBGHKLJM.KCAHGIBBHKJ, MBBPBGHKLJM.AILNPFFLELI, MBBPBGHKLJM.CALJBGILMOL, MBBPBGHKLJM.EALJKKBHDHK, MBBPBGHKLJM.KFBCFDALGBB, MBBPBGHKLJM.MNPEKJAAFHD, MBBPBGHKLJM.GGBEMNJNAEE);
		}

		private void KHDEEMPLHKA(int KCAHGIBBHKJ, bool LEPCJNMODGO, int BEKPLCHBMNJ, string FBKDKPCDMMK, long IAJHIKHNFNB, bool MFBIGBKJGJF, int OLFDKEDGHHF)
		{
			if (BackgroundMe != null)
			{
				BackgroundMe.SetActive(MFBIGBKJGJF);
			}
			BackgroundOther.SetActive(!MFBIGBKJGJF);
			if (MFBIGBKJGJF)
			{
				if (CurrentUserName != null)
				{
					CurrentUserName.enabled = true;
					CurrentUserName.FCJBBPHFNPJ = LECPGNKOABP.GABGKBAKHDP.KJACEODCOHN;
				}
				NameText.enabled = false;
				LevelText.color = NDKAPKKDLDO;
				if (HelpsText != null)
				{
					HelpsText.color = NDKAPKKDLDO;
				}
			}
			else
			{
				if (CurrentUserName != null)
				{
					CurrentUserName.enabled = false;
				}
				NameText.enabled = true;
				LevelText.color = OIMCPBFOLAD;
				if (HelpsText != null)
				{
					HelpsText.color = OIMCPBFOLAD;
				}
			}
			if (LEPCJNMODGO)
			{
				NameText.enabled = false;
				if (CurrentUserName != null)
				{
					CurrentUserName.enabled = false;
				}
				if (MFBIGBKJGJF)
				{
					LeaderNameText.gameObject.SetActive(false);
					if (CurrentUserLeaderText != null)
					{
						CurrentUserLeaderText.gameObject.SetActive(true);
						CurrentUserLeaderText.FCJBBPHFNPJ = FBKDKPCDMMK;
					}
				}
				else
				{
					if (CurrentUserLeaderText != null)
					{
						CurrentUserLeaderText.gameObject.SetActive(false);
					}
					LeaderNameText.gameObject.SetActive(true);
					LeaderNameText.FCJBBPHFNPJ = FBKDKPCDMMK;
				}
			}
			else
			{
				LeaderNameText.gameObject.SetActive(false);
				if (CurrentUserLeaderText != null)
				{
					CurrentUserLeaderText.gameObject.SetActive(false);
				}
			}
			OrderNoText.FCJBBPHFNPJ = KCAHGIBBHKJ.ToString();
			MaxLevelText.FCJBBPHFNPJ = BEKPLCHBMNJ.ToString();
			HKMOLHICFKD(KCAHGIBBHKJ);
			NameText.FCJBBPHFNPJ = FBKDKPCDMMK;
			if (HelpsCountText != null)
			{
				HelpsCountText.FCJBBPHFNPJ = IAJHIKHNFNB.ToString();
			}
			CLContainer.SetActive(OLFDKEDGHHF > 0);
			CLScore.FCJBBPHFNPJ = OLFDKEDGHHF.ToString();
		}

		private void HKMOLHICFKD(int KCAHGIBBHKJ)
		{
			if (KCAHGIBBHKJ <= 3)
			{
				Sprite medalSprite = SharedImageLibrary.Instance.GetMedalSprite(KCAHGIBBHKJ - 1);
				MedalImage.sprite = medalSprite;
				MedalImage.enabled = true;
				OrderNoText.enabled = false;
			}
			else
			{
				MedalImage.enabled = false;
				OrderNoText.enabled = true;
			}
		}

		public override void SetContent<T>(T IFLICJGCCNM)
		{
			BMHDDEMBAEM mBBPBGHKLJM = IFLICJGCCNM as BMHDDEMBAEM;
			JIMBAPGACIJ(mBBPBGHKLJM);
		}
	}
}
