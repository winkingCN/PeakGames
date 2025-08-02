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
	public class PlayersLeaderboardEntry : VerticalScrollEntry
	{
		private const string HAPLBNAMNBN = "Blaster";

		public TextMeshPro FriendName;

		public TextMeshPro YourName;

		public TextMeshPro Level;

		public TextMeshPro LevelTitle;

		public TextMeshPro OrderNo;

		public SpriteRenderer Medal;

		public GameObject UserBackground;

		public GameObject FriendBackground;

		public Sprite UserFrameSprite;

		public Sprite FriendFrameSprite;

		public SpriteRenderer BadgeSpriteRenderer;

		public TextMeshPro TeamNameTextField;

		public GameObject CLContainer;

		public TextMeshPro CLScore;

		public KickButton ViewButton;

		private bool IOOMANKGHBF;

		private PlayersLeaderboardTabPage OHDPPBNFONP;

		private SocialHelper KCMNBMGCKKI;

		private int KKMIEDBFCOB;

		private string BLEJGEMEGAH;

		private GetTeamInfoResponseMessage IFLNPPEHMEE;

		public void ShowView()
		{
			IFLNPPEHMEE = null;
			if (!IOOMANKGHBF)
			{
				return;
			}
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
				component.ShowTeamInfoFromParent(KKMIEDBFCOB, KCMNBMGCKKI, IFLNPPEHMEE);
				component.SetReferral(4);
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
			IOOMANKGHBF = KKMIEDBFCOB != -1;
			if (GKNCJMICJEL == null || GKNCJMICJEL.Equals(string.Empty))
			{
				TeamNameTextField.enabled = false;
				YourName.ANLKLKAINEO.localPosition = new Vector3(YourName.ANLKLKAINEO.localPosition.x, -0.0877f, 0f);
				FriendName.ANLKLKAINEO.localPosition = new Vector3(FriendName.ANLKLKAINEO.localPosition.x, -0.087f, 0f);
				BadgeSpriteRenderer.sprite = KCMNBMGCKKI.BadgesDictionary.BlankSprite;
				BadgeSpriteRenderer.color = new Color(0.64705884f, 44f / 85f, 0.39607844f);
			}
			else
			{
				TeamNameTextField.enabled = true;
				TeamNameTextField.FCJBBPHFNPJ = GKNCJMICJEL;
				YourName.ANLKLKAINEO.localPosition = new Vector3(YourName.ANLKLKAINEO.localPosition.x, 0.1f, 0f);
				FriendName.ANLKLKAINEO.localPosition = new Vector3(FriendName.ANLKLKAINEO.localPosition.x, 0.1f, 0f);
				BadgeSpriteRenderer.sprite = KCMNBMGCKKI.BadgesDictionary.GetBadge(PMKHOPIMKNH);
				BadgeSpriteRenderer.color = Color.white;
			}
		}

		public void Prepare(OFGGFEJGABH GBKPDDDJOFO, int AIILDOGHINA, PlayersLeaderboardTabPage HJENCKLHFNB, SocialHelper JANPCBNIGFG)
		{
			OHDPPBNFONP = HJENCKLHFNB;
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
			bool flag = GBKPDDDJOFO.GDMECFECCOM == LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM;
			UserBackground.SetActive(flag);
			FriendBackground.SetActive(!flag);
			YourName.enabled = flag;
			FriendName.enabled = !flag;
			if (!string.IsNullOrEmpty(GBKPDDDJOFO.KJACEODCOHN))
			{
				FriendName.FCJBBPHFNPJ = GBKPDDDJOFO.KJACEODCOHN;
				YourName.FCJBBPHFNPJ = GBKPDDDJOFO.KJACEODCOHN;
			}
			else
			{
				FriendName.FCJBBPHFNPJ = "Blaster";
				YourName.FCJBBPHFNPJ = "Blaster";
			}
			Level.FCJBBPHFNPJ = GBKPDDDJOFO.DJADMBLKBKJ.ToString();
			UpdateTeam(GBKPDDDJOFO.OADDPGNIINO, GBKPDDDJOFO.EFHEIFMEJCN, GBKPDDDJOFO.FGPGOGEKDAM);
			if (flag)
			{
				LevelTitle.color = new Color(0.5137255f, 0.101960786f, 0.10980392f);
				TeamNameTextField.color = new Color(0.5137255f, 0.101960786f, 0.10980392f);
			}
			else
			{
				LevelTitle.color = new Color(0.4862745f, 31f / 85f, 21f / 85f);
				TeamNameTextField.color = new Color(26f / 51f, 31f / 85f, 0.23529412f);
			}
			CLContainer.SetActive(GBKPDDDJOFO.GGBEMNJNAEE > 0);
			CLScore.FCJBBPHFNPJ = GBKPDDDJOFO.GGBEMNJNAEE.ToString();
		}

		public override void SetContent<T>(T IFLICJGCCNM)
		{
			APEOGDOBFGH aPEOGDOBFGH = IFLICJGCCNM as APEOGDOBFGH;
			Prepare(aPEOGDOBFGH.HBHBDHOMGPE, aPEOGDOBFGH.KCAHGIBBHKJ, aPEOGDOBFGH.BCEEJPPBKIF, aPEOGDOBFGH.IPCAELIMIBN);
		}

		[CompilerGenerated]
		private void MNFBLHLCAIG(GetTeamInfoResponseMessage OMJOIIOONMO)
		{
			IFLNPPEHMEE = OMJOIIOONMO;
		}
	}
}
