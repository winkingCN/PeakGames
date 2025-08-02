using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Tutorials
{
	public class MapTutorial : MonoBehaviour
	{
		public const string KeyStarChestStartTutorial = "TutorialStarChestStart";

		public const string KeyStarChestOpenTutorial = "TutorialStarChestOpen";

		public const string KeyDailyBonusTutorial = "TutorialDailyBonus";

		public const string KeyTeamChestTutorial = "TutorialTeamChest";

		public const string KeyTeamTournamentTutorial = "TutorialTeamTournament";

		public const string KeyTreasureHuntTutorial = "TutorialTreasureHunt";

		public SpriteRenderer[] SpriteRenderers;

		public Transform Content;

		public TextMeshPro MessageText;

		public SpriteRenderer BlackBackground;

		public GameObject UpArrow;

		public Transform ArrowContainer;

		public GameObject MessagePanel;

		public EventBasedButton BackgroundButton;

		public GameObject ContinueButton;

		private Action HOCGPCBBIEB;

		private Action AHLHPIKBEFB;

		private bool BIELEFAPPBF;

		private bool NIGGHHGOJDP;

		public static MapTutorial ActiveMapTutorial;

		public static bool DidShowMapTutorialInCurrentFlow;

		public static bool ShouldDisplayToonChestOpenTutorial()
		{
			return MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() == 9 && NDGOJGLPIJF.GABGKBAKHDP.BMKIICIJGEK();
		}

		public static bool ShouldDisplayStarChestOpenTutorial()
		{
			string text = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("TutorialStarChestOpen");
			if (text == null && MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() > 18)
			{
				CompleteStarChestOpenTutorial();
			}
			return text == null && NDGOJGLPIJF.GABGKBAKHDP.AEFOGGAOFEE() && GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Stars) >= NDGOJGLPIJF.DGIKLPPBGHJ && MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() <= 18;
		}

		public static bool ShouldDisplayStarChestStarTutorial()
		{
			string text = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("TutorialStarChestStart");
			if (text == null)
			{
				int aMKOJOKCELO = NDGOJGLPIJF.GABGKBAKHDP.AMKOJOKCELO;
				int num = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Stars);
				int num2 = num - aMKOJOKCELO;
				if (num2 > 0)
				{
					CompleteStarChestStartTutorial();
					return false;
				}
			}
			return text == null && MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() == 2;
		}

		public static bool ShouldDisplaySocialTutorial()
		{
			string text = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("TutorialSocialCompleted");
			bool flag = !MKINMKEMBPL.GABGKBAKHDP.HEANMKDLPGF("TutorialSocialCompleted") && MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() == 20 && !GFHPEDILAJG.GABGKBAKHDP.ODMCGBLJFKM && text == null;
			int num = CAGBGIHKHEJ.GABGKBAKHDP.IEIHCCBMPPG(0);
			if (flag && num > 0)
			{
				CompleteSocialTutorial();
				return false;
			}
			return flag && num == 0;
		}

		public static bool ShouldDisplayDailyBonusTutorial()
		{
			string text = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("TutorialDailyBonus");
			if (text == null && MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() > 25)
			{
				CompleteDailyBonusTutorial();
			}
			return text == null && MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() == 25 && DJFEHCGIDGC.GABGKBAKHDP.NPDHFFPKPLF();
		}

		public static bool ShouldDisplayTeamChestTutorial()
		{
			if (DidShowMapTutorialInCurrentFlow)
			{
				return false;
			}
			string text = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("TutorialTeamChest");
			return text == null && MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() >= 22;
		}

		public static bool ShouldDisplayTeamTournamentTutorial()
		{
			if (DidShowMapTutorialInCurrentFlow)
			{
				return false;
			}
			string text = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("TutorialTeamTournament");
			return text == null && MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() >= 21;
		}

		public static bool ShouldDisplayTreasureHuntTutorial()
		{
			if (DidShowMapTutorialInCurrentFlow)
			{
				return false;
			}
			string text = HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("TutorialTreasureHunt");
			return text == null && MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() >= 27;
		}

		public static void CompleteSocialTutorial()
		{
			MKINMKEMBPL.GABGKBAKHDP.KMPGGMKICLB("TutorialSocialCompleted");
			HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("TutorialSocialCompleted", "1");
		}

		public static void CompleteStarChestStartTutorial()
		{
			HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("TutorialStarChestStart", "1");
		}

		public static void CompleteStarChestOpenTutorial()
		{
			HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("TutorialStarChestOpen", "1");
		}

		public static void CompleteDailyBonusTutorial()
		{
			HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("TutorialDailyBonus", "1");
		}

		public static void CompleteTeamChestTutorial()
		{
			HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("TutorialTeamChest", "1");
		}

		public static void CompleteTeamTournamentTutorial()
		{
			HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("TutorialTeamTournament", "1");
		}

		public static void CompleteTreasureHuntTutorial()
		{
			HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("TutorialTreasureHunt", "1");
		}

		public void Init(string OEFCOJLNCKP, Vector3 LDMDBPLADGD, Action OMIODDBILMO, Action OCGNDHPLFAF = null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.MapTutorial, "Showing Map Tutorial with message: {0}", OEFCOJLNCKP);
			HOCGPCBBIEB = OMIODDBILMO;
			AHLHPIKBEFB = OCGNDHPLFAF;
			float num = ONCMBJKLKIL.EMFKAPJMDCC / 10.24f;
			Content.localScale = Vector3.one * num;
			BlackBackground.transform.localScale = new Vector3(ONCMBJKLKIL.EMFKAPJMDCC, ONCMBJKLKIL.FHAMOHDEGMK, 1f);
			MessageText.FCJBBPHFNPJ = OEFCOJLNCKP;
			Content.transform.position = LDMDBPLADGD;
			BlackBackground.color = new Color(0f, 0f, 0f, 0f);
			MessagePanel.gameObject.SetActive(false);
			UpArrow.gameObject.SetActive(false);
			ActiveMapTutorial = this;
		}

		public void EnableTutorialSkip()
		{
			NIGGHHGOJDP = true;
		}

		public void SkipTutorial()
		{
			if (NIGGHHGOJDP)
			{
				HideTutorial();
				Remove();
			}
		}

		public void ShowContinueButton(bool JIAPOBDACNL)
		{
			ContinueButton.SetActive(JIAPOBDACNL);
		}

		public void ShowArrow(Vector3 LDMDBPLADGD, float ODLHFMOPCHL = 0f, float NGIKINDMFIH = -0.46f)
		{
			if (!BIELEFAPPBF)
			{
				Quaternion identity = Quaternion.identity;
				identity.eulerAngles = new Vector3(0f, 0f, ODLHFMOPCHL);
				ArrowContainer.localRotation = identity;
				UpArrow.SetActive(true);
				ArrowContainer.transform.position = LDMDBPLADGD;
				UpArrow.transform.localPosition = Vector3.zero;
				UpArrow.transform.DOBlendableLocalMoveBy(new Vector3(0f, NGIKINDMFIH, 0f), 0.5f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
			}
		}

		public void FadeInBackground()
		{
			if (!BIELEFAPPBF)
			{
				BlackBackground.DOFade(0.8f, 0.3f);
			}
		}

		public void ShowDialog(bool CLHMCPLLLLM = true)
		{
			MessagePanel.gameObject.SetActive(true);
			MessagePanel.transform.localScale = Vector3.zero;
			MessagePanel.transform.DOScale(Vector3.one, 0.3f).SetEase(Ease.OutBack);
			ShowContinueButton(CLHMCPLLLLM);
		}

		public void Remove(bool ALKBJGIPKEE = false, float DKGFIMCDPKH = 0.3f)
		{
			if (BIELEFAPPBF)
			{
				return;
			}
			BIELEFAPPBF = true;
			ActiveMapTutorial = null;
			if (ALKBJGIPKEE)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			BlackBackground.DOFade(0f, DKGFIMCDPKH).OnComplete(delegate
			{
				UnityEngine.Object.Destroy(base.gameObject);
			});
			Content.transform.DOScale(Vector3.zero, DKGFIMCDPKH).SetEase(Ease.InBack);
			int num = SpriteRenderers.Length;
			for (int i = 0; i < num; i++)
			{
				SpriteRenderers[i].DOFade(0f, DKGFIMCDPKH);
			}
			if (HOCGPCBBIEB != null)
			{
				HOCGPCBBIEB();
			}
		}

		public void HideTutorial()
		{
			if (!BIELEFAPPBF)
			{
				base.gameObject.SetActive(false);
				if (AHLHPIKBEFB != null)
				{
					AHLHPIKBEFB();
				}
			}
		}

		public void OnClick()
		{
			if (!BIELEFAPPBF)
			{
				Remove();
			}
		}

		[CompilerGenerated]
		private void PHLBANHOJBP()
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
