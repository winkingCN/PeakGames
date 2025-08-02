using TMPro;
using Ui.VerticalScroll;
using UnityEngine;

namespace ToonSocial.ui.joined
{
	public class TeamChestEntry : VerticalScrollEntry
	{
		public TextMeshPro NameText;

		public TextMeshPro CurrentUserName;

		public TextMeshPro CurrentUserLeaderText;

		public TextMeshPro LeaderNameText;

		public TextMeshPro OrderNoText;

		public TextMeshPro StarCountText;

		public SpriteRenderer MedalImage;

		public GameObject BackgroundOther;

		public GameObject BackgroundMe;

		private void JIMBAPGACIJ(MOGIFCAGGKE MBBPBGHKLJM)
		{
			KHDEEMPLHKA(MBBPBGHKLJM.KCAHGIBBHKJ, MBBPBGHKLJM.AILNPFFLELI, MBBPBGHKLJM.FDEODFEHEFB, MBBPBGHKLJM.EALJKKBHDHK, MBBPBGHKLJM.MNPEKJAAFHD);
		}

		private void KHDEEMPLHKA(int KCAHGIBBHKJ, bool LEPCJNMODGO, int MFFLPDALICD, string FBKDKPCDMMK, bool MFBIGBKJGJF)
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
					CurrentUserName.FCJBBPHFNPJ = FBKDKPCDMMK;
				}
				NameText.enabled = false;
			}
			else
			{
				if (CurrentUserName != null)
				{
					CurrentUserName.enabled = false;
				}
				NameText.enabled = true;
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
			StarCountText.FCJBBPHFNPJ = MFFLPDALICD.ToString();
			HKMOLHICFKD(KCAHGIBBHKJ);
			NameText.FCJBBPHFNPJ = FBKDKPCDMMK;
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
			MOGIFCAGGKE mBBPBGHKLJM = IFLICJGCCNM as MOGIFCAGGKE;
			JIMBAPGACIJ(mBBPBGHKLJM);
		}
	}
}
