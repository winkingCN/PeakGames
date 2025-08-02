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
	public class FacebookLeaderboardEntry : VerticalScrollEntry
	{
		public TextMeshPro FriendName;

		public TextMeshPro YourName;

		public TextMeshPro Level;

		public TextMeshPro LevelTitle;

		public TextMeshPro OrderNo;

		public SpriteRenderer Avatar;

		public SpriteRenderer AvatarFrame;

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

		private bool BIELEFAPPBF;

		private bool IOOMANKGHBF;

		private FacebookLeaderboardTabPage OHDPPBNFONP;

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
			ViewButton.Show(num < 4.5f);
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
				component.SetReferral(2);
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
				YourName.ANLKLKAINEO.localPosition = new Vector3(YourName.ANLKLKAINEO.localPosition.x, -0.167f, 0f);
				FriendName.ANLKLKAINEO.localPosition = new Vector3(FriendName.ANLKLKAINEO.localPosition.x, -0.19f, 0f);
				BadgeSpriteRenderer.sprite = KCMNBMGCKKI.BadgesDictionary.BlankSprite;
				BadgeSpriteRenderer.color = new Color(0.64705884f, 44f / 85f, 0.39607844f);
			}
			else
			{
				TeamNameTextField.enabled = true;
				TeamNameTextField.FCJBBPHFNPJ = GKNCJMICJEL;
				YourName.ANLKLKAINEO.localPosition = new Vector3(YourName.ANLKLKAINEO.localPosition.x, 0.044f, 0f);
				FriendName.ANLKLKAINEO.localPosition = new Vector3(FriendName.ANLKLKAINEO.localPosition.x, 0.025f, 0f);
				BadgeSpriteRenderer.sprite = KCMNBMGCKKI.BadgesDictionary.GetBadge(PMKHOPIMKNH);
				BadgeSpriteRenderer.color = Color.white;
			}
		}

		public void Prepare(IENHAKEMDPM GBKPDDDJOFO, int AIILDOGHINA, FacebookLeaderboardTabPage HJENCKLHFNB, SocialHelper JANPCBNIGFG)
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
			BLEJGEMEGAH = GBKPDDDJOFO.EHNKLBBAKCA;
			bool flag = LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA.Equals(BLEJGEMEGAH);
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
				string text = JCGLFEMHECF.KLAFFBMDCLM(GBKPDDDJOFO.PNGPLGHKFDI);
				FriendName.FCJBBPHFNPJ = text;
				YourName.FCJBBPHFNPJ = text;
			}
			Level.FCJBBPHFNPJ = GBKPDDDJOFO.KOPMPMIFHNF.ToString();
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
			AvatarFrame.sprite = ((!flag) ? FriendFrameSprite : UserFrameSprite);
			Avatar.sprite = null;
			LFJJCHNGDLJ lFJJCHNGDLJ = new LFJJCHNGDLJ();
			lFJJCHNGDLJ.IPAKPIGIJHK = delegate(Sprite DODBJCHDBFF, string LHOFEHMNEIG)
			{
				if (!BIELEFAPPBF && !(BLEJGEMEGAH != LHOFEHMNEIG))
				{
					Avatar.sprite = DODBJCHDBFF;
					Avatar.enabled = true;
					Avatar.transform.localScale = Vector3.one;
				}
			};
			lFJJCHNGDLJ.MAMDEOJCFEI = delegate
			{
				if (!BIELEFAPPBF)
				{
					Avatar.enabled = false;
				}
			};
			LFJJCHNGDLJ @object = lFJJCHNGDLJ;
			PAFJEIOKMIK.GABGKBAKHDP.NNMEBAOIJAM(BLEJGEMEGAH, null, @object.KEJEHBBLDPO);
			CLContainer.SetActive(GBKPDDDJOFO.GGBEMNJNAEE > 0);
			CLScore.FCJBBPHFNPJ = GBKPDDDJOFO.GGBEMNJNAEE.ToString();
		}

		private void OnDestroy()
		{
			BIELEFAPPBF = true;
		}

		public override void SetContent<T>(T IFLICJGCCNM)
		{
			PDLBAPCKIBF pDLBAPCKIBF = IFLICJGCCNM as PDLBAPCKIBF;
			Prepare(pDLBAPCKIBF.HBHBDHOMGPE, pDLBAPCKIBF.KCAHGIBBHKJ, pDLBAPCKIBF.BCEEJPPBKIF, pDLBAPCKIBF.IPCAELIMIBN);
		}

		[CompilerGenerated]
		private void MNFBLHLCAIG(GetTeamInfoResponseMessage OMJOIIOONMO)
		{
			IFLNPPEHMEE = OMJOIIOONMO;
		}

		[CompilerGenerated]
		private void IDOIMEBFDJH(Sprite DODBJCHDBFF, string LHOFEHMNEIG)
		{
			if (!BIELEFAPPBF && !(BLEJGEMEGAH != LHOFEHMNEIG))
			{
				Avatar.sprite = DODBJCHDBFF;
				Avatar.enabled = true;
				Avatar.transform.localScale = Vector3.one;
			}
		}

		[CompilerGenerated]
		private void OLKAILFKAIM()
		{
			if (!BIELEFAPPBF)
			{
				Avatar.enabled = false;
			}
		}
	}
}
