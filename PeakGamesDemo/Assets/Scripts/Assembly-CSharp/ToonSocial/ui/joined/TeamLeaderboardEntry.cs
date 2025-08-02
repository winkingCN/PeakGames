using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.MapScene;
using DG.Tweening;
using Dialogs;
using NewMapScene;
using TMPro;
using Ui.VerticalScroll;
using UnityEngine;
using Utils;
using caravan.protobuf.messages;

namespace ToonSocial.ui.joined
{
	public class TeamLeaderboardEntry : VerticalScrollEntry
	{
		public TextMeshPro TeamName;

		public TextMeshPro YourTeamName;

		public TextMeshPro Score;

		public TextMeshPro ScoreTitle;

		public TextMeshPro OrderNo;

		public GameObject UserBackground;

		public GameObject FriendBackground;

		public SpriteRenderer Medal;

		public SpriteRenderer BadgeSpriteRenderer;

		public KickButton ViewButton;

		private TeamLeaderboardTabPage OHDPPBNFONP;

		private SocialHelper KCMNBMGCKKI;

		private int KKMIEDBFCOB;

		private GetTeamInfoResponseMessage IFLNPPEHMEE;

		public void ShowView()
		{
			IFLNPPEHMEE = null;
			bool flag = !ViewButton.IsActive();
			if (OHDPPBNFONP != null)
			{
				if (flag)
				{
					if (OHDPPBNFONP.ActiveKickButton != null && OHDPPBNFONP.ActiveKickButton != ViewButton)
					{
						OHDPPBNFONP.ActiveKickButton.Hide();
					}
					OHDPPBNFONP.ActiveKickButton = ViewButton;
				}
				else
				{
					OHDPPBNFONP.ActiveKickButton = null;
				}
			}
			float num = base.transform.parent.localPosition.y + base.transform.localPosition.y;
			ViewButton.Show(num < 1.3f);
			ViewButton.gameObject.SetActive(flag);
			ViewButton.transform.DOKill();
			ViewButton.transform.localScale = Vector3.zero;
			ViewButton.transform.DOScale(1f, 0.3f).SetEase(Ease.OutBack);
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
			{
				new AKHDMHCPFPJ(KKMIEDBFCOB, delegate(GetTeamInfoResponseMessage OMJOIIOONMO)
				{
					IFLNPPEHMEE = OMJOIIOONMO;
				})
			});
		}

		public void OnViewClick()
		{
			if (!JHOAHCHHBCH.CCAJIIFJPFF())
			{
				Vector3 vector = ((!ViewButton.Up.gameObject.activeSelf) ? ViewButton.Down.transform.position : ViewButton.Up.transform.position);
				MapManager.Instance.ShowErrorMessageAtPosition(NKILHODNBDE.GHBGCADFLFB("Error_Connection"), new Vector3(0f, vector.y + 1f, 0f));
				ViewButton.Hide();
				OHDPPBNFONP.ActiveKickButton = null;
			}
			else
			{
				GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.SocialTeamInfoJoinDialog, false);
				TeamInfoJoinDialog component = gameObject.GetComponent<TeamInfoJoinDialog>();
				component.SetSelectedTeamTab(OHDPPBNFONP.SharedTabIndex);
				component.SetReferral(3);
				component.ShowTeamInfoFromParent(KKMIEDBFCOB, KCMNBMGCKKI, IFLNPPEHMEE);
				ViewButton.Hide();
			}
		}

		public void OnEntryClick()
		{
			ShowView();
		}

		public void UpdateTeam(int EMNOJOHFMEH, string GKNCJMICJEL, string PMKHOPIMKNH)
		{
			KKMIEDBFCOB = EMNOJOHFMEH;
			BadgeSpriteRenderer.sprite = KCMNBMGCKKI.BadgesDictionary.GetBadge(PMKHOPIMKNH);
			BadgeSpriteRenderer.color = Color.white;
		}

		public void Prepare(FMHKCJGDPEB GBKPDDDJOFO, int AIILDOGHINA, TeamLeaderboardTabPage HJENCKLHFNB, SocialHelper JANPCBNIGFG)
		{
			OHDPPBNFONP = HJENCKLHFNB;
			KKMIEDBFCOB = GBKPDDDJOFO.OADDPGNIINO;
			KCMNBMGCKKI = JANPCBNIGFG;
			if (AIILDOGHINA < 3)
			{
				Medal.gameObject.SetActive(true);
				OrderNo.gameObject.SetActive(false);
				Medal.sprite = SharedImageLibrary.Instance.GetMedalSprite(AIILDOGHINA);
			}
			else
			{
				Medal.gameObject.SetActive(false);
				OrderNo.gameObject.SetActive(true);
				OrderNo.FCJBBPHFNPJ = (AIILDOGHINA + 1).ToString();
			}
			bool flag = (int)LECPGNKOABP.GABGKBAKHDP.OADDPGNIINO == GBKPDDDJOFO.OADDPGNIINO;
			UserBackground.SetActive(flag);
			FriendBackground.SetActive(!flag);
			YourTeamName.enabled = flag;
			TeamName.enabled = !flag;
			TeamName.FCJBBPHFNPJ = GBKPDDDJOFO.PNGPLGHKFDI;
			YourTeamName.FCJBBPHFNPJ = GBKPDDDJOFO.PNGPLGHKFDI;
			Score.FCJBBPHFNPJ = GBKPDDDJOFO.DJADMBLKBKJ.ToString();
			BadgeSpriteRenderer.sprite = KCMNBMGCKKI.BadgesDictionary.GetBadge(GBKPDDDJOFO.FGPGOGEKDAM);
			if (flag)
			{
				ScoreTitle.color = new Color(0.5137255f, 0.101960786f, 0.10980392f);
			}
			else
			{
				ScoreTitle.color = new Color(0.4862745f, 31f / 85f, 21f / 85f);
			}
		}

		public override void SetContent<T>(T IFLICJGCCNM)
		{
			PMBADMGCMDA pMBADMGCMDA = IFLICJGCCNM as PMBADMGCMDA;
			Prepare(pMBADMGCMDA.HBHBDHOMGPE, pMBADMGCMDA.KCAHGIBBHKJ, pMBADMGCMDA.BCEEJPPBKIF, pMBADMGCMDA.IPCAELIMIBN);
		}

		[CompilerGenerated]
		private void MNFBLHLCAIG(GetTeamInfoResponseMessage OMJOIIOONMO)
		{
			IFLNPPEHMEE = OMJOIIOONMO;
		}
	}
}
