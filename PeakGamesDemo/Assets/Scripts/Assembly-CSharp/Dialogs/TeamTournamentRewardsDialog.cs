using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.MapScene;
using Assets.Scripts.Utils;
using Assets.Scripts.Utils.Analytics;
using DG.Tweening;
using NewMapScene;
using TMPro;
using ToonSocial;
using Ui.VerticalScroll;
using UnityEngine;
using caravan.protobuf.messages;

namespace Dialogs
{
	public class TeamTournamentRewardsDialog : OnCloseCallbackDialog
	{
		public static bool DialogActive;

		public static bool ShouldCallGetEventsCommand;

		public SpriteMask CurrentSpriteMask;

		public SpriteRenderer BackgroundLeft;

		public SpriteRenderer BackgroundRight;

		public TextMeshPro ButtonText;

		public TextMeshPro NoRewardText;

		public TextMeshPro RankText;

		public Transform BottomButtonTransform;

		public Transform BottomScrollMask;

		public Transform[] DialogTabs;

		public GameObject Blocker;

		public GameObject LoadingIndicator;

		public GameObject TeamTournamentEntryPrefab;

		public GameObject TeamMemberEntryPrefab;

		public GameObject TeamMemberSeperatorEntryPrefab;

		public GameObject[] DialogTabSprites;

		public GameObject[] CoinRewards;

		public RewardText CoinRewardText;

		public VerticalScrollController TournamentScrollController;

		public VerticalScrollController MyTeamScrollController;

		private bool EKCINKDJPDI;

		private bool KPFIBDEMEPB;

		private long MNGFOOGIKKO;

		private int NJGAOPBHPIO;

		private int MCFEBJMJCHC;

		private float ANJBHOECJME;

		private float JNFMOMPFIGG;

		private Tween DPCJCKGNMND;

		private Action JBJKNCHCDOK;

		private KCKDNJOMPJH DBLLMGJJOOD;

		private List<int> INCCLAOPKJE;

		private global::FHOJBJMMNOD<CGKLKAOGGJB, TeamTournamentTeamEntry> ONLLECAAHOJ;

		private global::FJMEICJIFCD<KFHNJBEEPBL, TeamTournamentPlayerEntry> HIGKJHLLBNH;

		[CompilerGenerated]
		private static Func<TtTeamInfo, int> EBCOMJBLIPP;

		[CompilerGenerated]
		private static Func<TtTeamInfo, long> DNBOPLHGMHA;

		[CompilerGenerated]
		private static Func<TtMemberInfo, int> JFHCKLHBBDI;

		[CompilerGenerated]
		private static Func<TtMemberInfo, int> NOGHOEBDKAH;

		private bool INJLCJLDNKC
		{
			get
			{
				return MCFEBJMJCHC > 0 && DBLLMGJJOOD != null && DBLLMGJJOOD.LMIPACNFAAB;
			}
		}

		public override void DialogCreated()
		{
			DialogActive = true;
			base.DialogCreated();
			DIOELAHNLKJ();
			DBLLMGJJOOD = DGOMNDMPMBG.GABGKBAKHDP.FABKMFCBELE;
			if (DBLLMGJJOOD != null)
			{
				LoadingIndicator.SetActive(true);
				INCCLAOPKJE = DBLLMGJJOOD.GIEDINFFPNJ.rewards;
				if (DBLLMGJJOOD.GFEHMHDJKIF)
				{
					KJFJPKMBCGJ();
				}
				else
				{
					COCLEFIOIMB(true);
				}
			}
		}

		public void PrepareDialog(Action IMHLFAHONPP, bool OKAGICINMBN)
		{
			SetOnDialogClosedCallback(IMHLFAHONPP);
			EKCINKDJPDI = OKAGICINMBN;
		}

		private void KJFJPKMBCGJ()
		{
			List<IKDMCJPBBIH> list = new List<IKDMCJPBBIH>();
			if (ShouldCallGetEventsCommand)
			{
				list.Add(new KBBPGCKJHNJ());
			}
			list.Add(new FBNFMCGHLEE(DBLLMGJJOOD.IFOAAOCJODG, DBLLMGJJOOD.INFAGKCBEHL, LECPGNKOABP.GABGKBAKHDP.OADDPGNIINO, COCLEFIOIMB));
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(list);
			ShouldCallGetEventsCommand = false;
		}

		private void DIOELAHNLKJ()
		{
			ButtonText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Continue");
			if (ONCMBJKLKIL.KLEKJMEOPEH)
			{
				float num = 1.7787265f * ONCMBJKLKIL.EMFKAPJMDCC;
				float num2 = (ONCMBJKLKIL.FHAMOHDEGMK - num) * 0.3f;
				Vector2 size = new Vector2(BackgroundLeft.size.x, 7.105995f + num2);
				BottomScrollMask.transform.localPosition = new Vector3(0f, -7.92f - num2, 0f);
				BackgroundLeft.size = size;
				BackgroundRight.size = size;
				BackgroundLeft.transform.localPosition = new Vector3(BackgroundLeft.transform.localPosition.x, -2.3691f - num2 * 0.5f, 0f);
				BackgroundRight.transform.localPosition = new Vector3(BackgroundRight.transform.localPosition.x, -2.3691f - num2 * 0.5f, 0f);
				Vector2 size2 = TournamentScrollController.ScrollArea.size;
				size2.y += num2;
				TournamentScrollController.ScrollArea.size = size2;
				size2 = MyTeamScrollController.ScrollArea.size;
				size2.y += num2;
				MyTeamScrollController.ScrollArea.size = size2;
				Vector2 offset = TournamentScrollController.ScrollArea.offset;
				offset.y -= num2 * 0.5f;
				TournamentScrollController.ScrollArea.offset = offset;
				offset = MyTeamScrollController.ScrollArea.offset;
				offset.y -= num2 * 0.5f;
				MyTeamScrollController.ScrollArea.offset = offset;
				JNFMOMPFIGG = num2 * 0.5f;
				if (TournamentScrollController != null)
				{
					TournamentScrollController.SetOffsets(0f - JNFMOMPFIGG, 0f - JNFMOMPFIGG);
					TournamentScrollController.SetContentSize(ANJBHOECJME);
					TournamentScrollController.ScrollToTop();
				}
				if (MyTeamScrollController != null)
				{
					MyTeamScrollController.SetOffsets(0f - JNFMOMPFIGG, 0f - JNFMOMPFIGG);
					MyTeamScrollController.SetContentSize(ANJBHOECJME);
					MyTeamScrollController.ScrollToTop();
				}
				BottomButtonTransform.transform.localPosition = new Vector3(0f, -6.28f - num2);
				CurrentSpriteMask.MOFHAKELNPN = new Vector2(CurrentSpriteMask.MOFHAKELNPN.x, CurrentSpriteMask.MOFHAKELNPN.y + num2);
			}
		}

		private void COCLEFIOIMB(bool EEKJMDHEJCK)
		{
			bool flag = ONLFNAFHLHJ() && ABAAECDEMOB();
			KPFIBDEMEPB = flag && EEKJMDHEJCK;
		}

		private bool ONLFNAFHLHJ()
		{
			List<TtTeamInfo> list = DBLLMGJJOOD.NDABFDHPIBB;
			if (list == null || list.Count == 0)
			{
				Close();
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Connection"));
				return false;
			}
			LoadingIndicator.SetActive(false);
			IOrderedEnumerable<TtTeamInfo> orderedEnumerable = from IBBBMACIBGK in list
				orderby IBBBMACIBGK.starCount descending, IBBBMACIBGK.teamId
				select IBBBMACIBGK;
			List<CGKLKAOGGJB> list2 = new List<CGKLKAOGGJB>();
			int count = list.Count;
			int num = 0;
			foreach (TtTeamInfo item2 in orderedEnumerable)
			{
				bool flag = LECPGNKOABP.GABGKBAKHDP.OADDPGNIINO == item2.teamId;
				int num2 = 0;
				if (num < INCCLAOPKJE.Count)
				{
					num2 = INCCLAOPKJE[num];
				}
				if (flag)
				{
					NJGAOPBHPIO = num + 1;
					if (num2 > 0)
					{
						MCFEBJMJCHC = num2 / DBLLMGJJOOD.MIIHHONLDOI;
						int num3 = MCFEBJMJCHC % 10;
						if (num3 != 0)
						{
							MCFEBJMJCHC += 10 - num3;
						}
					}
					NHABCJMFNPG();
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TeamTournament Team total star count: {0} - Team rank: {1}", item2.starCount, NJGAOPBHPIO);
				}
				CGKLKAOGGJB cGKLKAOGGJB = new CGKLKAOGGJB();
				cGKLKAOGGJB.OBMLPJHJOCL = flag;
				cGKLKAOGGJB.OHAPPDGAKNG = num + 1;
				cGKLKAOGGJB.OGEMDHPJHFO = item2.starCount;
				cGKLKAOGGJB.OADDPGNIINO = item2.teamId;
				cGKLKAOGGJB.EFHEIFMEJCN = item2.teamName;
				cGKLKAOGGJB.GCELBDIDEAI = item2.teamBadge;
				cGKLKAOGGJB.BIEIJGOBEIA = num2;
				CGKLKAOGGJB item = cGKLKAOGGJB;
				list2.Add(item);
				num++;
			}
			if (ONLLECAAHOJ == null)
			{
				ONLLECAAHOJ = new global::FHOJBJMMNOD<CGKLKAOGGJB, TeamTournamentTeamEntry>(TournamentScrollController, TeamTournamentEntryPrefab.GetComponent<TeamTournamentTeamEntry>(), 10, 0.86f);
				ONLLECAAHOJ.FEHBHKPHBFC(13, 1.4f, 0.7f);
				ONLLECAAHOJ.GEKBMINLCLJ(MNFNBKJNHKB);
				TournamentScrollController.Init();
				TournamentScrollController.SetOffsets(0f - JNFMOMPFIGG, 0f - JNFMOMPFIGG);
			}
			ANJBHOECJME = count;
			ONLLECAAHOJ.BBOMMEKKAEB(list2);
			TournamentScrollController.SetContentSize((float)count * 1.4f + 0.2f);
			TournamentScrollController.ScrollToTop();
			TournamentScrollController.JBOFOOHGDGC();
			return true;
		}

		private bool ABAAECDEMOB()
		{
			List<TtMemberInfo> list = DBLLMGJJOOD.ABBDIDFPMON;
			if (list == null)
			{
				Close();
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Connection"));
				return false;
			}
			LoadingIndicator.SetActive(false);
			IOrderedEnumerable<TtMemberInfo> orderedEnumerable = from IBBBMACIBGK in list
				orderby IBBBMACIBGK.progress descending, IBBBMACIBGK.disabled
				select IBBBMACIBGK;
			List<KFHNJBEEPBL> list2 = new List<KFHNJBEEPBL>();
			int count = list.Count;
			int num = 0;
			long num2 = 0L;
			SocialHelper currentSocialHelper = MapManager.Instance.CurrentSocialHelper;
			if (currentSocialHelper != null && currentSocialHelper.CurrentSession != null && currentSocialHelper.CurrentSession.COPDAKACHFM != null)
			{
				num2 = currentSocialHelper.CurrentSession.COPDAKACHFM.AFPDGDAEENM;
			}
			bool flag = false;
			float num3 = 0.86f;
			float num4 = 0f;
			foreach (TtMemberInfo item in orderedEnumerable)
			{
				KFHNJBEEPBL kFHNJBEEPBL;
				if (!flag && item.disabled == 1)
				{
					float num5 = 0.93f * num3;
					num4 += num5;
					kFHNJBEEPBL = new KFHNJBEEPBL();
					kFHNJBEEPBL.ENBPGGCIADN = 0;
					KFHNJBEEPBL kFHNJBEEPBL2 = kFHNJBEEPBL;
					kFHNJBEEPBL2.LMGJAGFBDMN(1, num5);
					list2.Add(kFHNJBEEPBL2);
					flag = true;
				}
				bool flag2 = LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM == item.id;
				bool gHADDDMNNIL = num2 == item.id;
				if (flag2)
				{
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TeamTournament Current user star count: {0}", item.progress);
				}
				kFHNJBEEPBL = new KFHNJBEEPBL();
				kFHNJBEEPBL.ENBPGGCIADN = 1;
				kFHNJBEEPBL.ABHNFOBGFCO = item.nick;
				kFHNJBEEPBL.MNPEKJAAFHD = flag2;
				kFHNJBEEPBL.GHADDDMNNIL = gHADDDMNNIL;
				kFHNJBEEPBL.OHAPPDGAKNG = num + 1;
				kFHNJBEEPBL.OGEMDHPJHFO = item.progress;
				kFHNJBEEPBL.GDMECFECCOM = item.id;
				KFHNJBEEPBL kFHNJBEEPBL3 = kFHNJBEEPBL;
				float num6 = 1.627f * num3;
				num4 += num6;
				kFHNJBEEPBL3.LMGJAGFBDMN(0, num6);
				list2.Add(kFHNJBEEPBL3);
				num++;
			}
			if (HIGKJHLLBNH == null)
			{
				TeamTournamentPlayerEntry[] pHEFFKBMAIA = new TeamTournamentPlayerEntry[2]
				{
					TeamMemberEntryPrefab.GetComponent<TeamTournamentPlayerEntry>(),
					TeamMemberSeperatorEntryPrefab.GetComponent<TeamTournamentPlayerEntry>()
				};
				int[] pECIDFMIPIN = new int[2] { 10, 1 };
				HIGKJHLLBNH = new global::FJMEICJIFCD<KFHNJBEEPBL, TeamTournamentPlayerEntry>(MyTeamScrollController, pHEFFKBMAIA, pECIDFMIPIN, num3, MNFNBKJNHKB);
				HIGKJHLLBNH.FEHBHKPHBFC(10);
				MyTeamScrollController.Init();
				MyTeamScrollController.SetOffsets(0f - JNFMOMPFIGG, 0f - JNFMOMPFIGG);
			}
			ANJBHOECJME = count;
			HIGKJHLLBNH.BBOMMEKKAEB(list2);
			MyTeamScrollController.SetContentSize(num4 + 0.2f);
			MyTeamScrollController.ScrollToTop();
			MyTeamScrollController.JBOFOOHGDGC();
			if (INJLCJLDNKC)
			{
				ButtonText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Claim");
			}
			return true;
		}

		private void MNFNBKJNHKB(int EHJNMODJEAN)
		{
			CurrentSpriteMask.gameObject.SetActive(false);
			CurrentSpriteMask.gameObject.SetActive(true);
		}

		private void NHABCJMFNPG()
		{
			RankText.FCJBBPHFNPJ = "# " + NJGAOPBHPIO;
			AGDBBOAKAFP(false);
			if (NJGAOPBHPIO <= 5)
			{
				ENIHNAEFMNK(CoinRewards[NJGAOPBHPIO - 1], true);
				CoinRewardText.SetRewardAmount(MCFEBJMJCHC);
				NoRewardText.enabled = false;
			}
			else
			{
				CoinRewardText.Activate(false);
				NoRewardText.enabled = true;
			}
		}

		private void AGDBBOAKAFP(bool ODCADGABBHJ)
		{
			int i = 0;
			for (int num = CoinRewards.Length; i < num; i++)
			{
				ENIHNAEFMNK(CoinRewards[i], ODCADGABBHJ);
			}
		}

		private void ENIHNAEFMNK(GameObject LGDFKAMHKFM, bool ODCADGABBHJ)
		{
			if (LGDFKAMHKFM.activeSelf != ODCADGABBHJ)
			{
				LGDFKAMHKFM.SetActive(ODCADGABBHJ);
			}
		}

		private List<TtMemberInfo> HJDGDJGLIBH()
		{
			List<TtMemberInfo> list = new List<TtMemberInfo>();
			int num = 0;
			for (int i = 0; i < 50; i++)
			{
				TtMemberInfo ttMemberInfo = new TtMemberInfo();
				if (i == 2)
				{
					ttMemberInfo.disabled = 0;
					ttMemberInfo.id = UnityEngine.Random.Range(1000, 100000);
					ttMemberInfo.nick = "Nick:" + ttMemberInfo.id;
					ttMemberInfo.progress = 100 * (50 - i + 1);
				}
				else
				{
					ttMemberInfo.disabled = ((i >= 40) ? 1 : 0);
					ttMemberInfo.id = UnityEngine.Random.Range(1000, 100000);
					ttMemberInfo.nick = "Nick:" + ttMemberInfo.id;
					ttMemberInfo.progress = 100 * (50 - i + 1);
				}
				list.Add(ttMemberInfo);
				num++;
			}
			return list;
		}

		public void OnTabClicked(int EHJNMODJEAN)
		{
			KDPMPAABMAK(EHJNMODJEAN);
			bool flag = EHJNMODJEAN == 0;
			DialogTabSprites[0].SetActive(flag);
			DialogTabSprites[1].SetActive(!flag);
			DialogTabSprites[2].SetActive(!flag);
			DialogTabSprites[3].SetActive(flag);
			TournamentScrollController.gameObject.SetActive(flag);
			MyTeamScrollController.gameObject.SetActive(!flag);
		}

		private void KDPMPAABMAK(int EHJNMODJEAN)
		{
			if (DPCJCKGNMND != null)
			{
				DPCJCKGNMND.Kill();
			}
			DialogTabs[EHJNMODJEAN].localScale = Vector3.one * 0.9f;
			DPCJCKGNMND = DialogTabs[EHJNMODJEAN].DOScale(1f, 0.2f).SetEase(Ease.OutBack);
			DPCJCKGNMND.easeOvershootOrAmplitude = 3f;
			AudioManager.Play(KOOGPFAPGGD.UiClick, GCEAKOOGDJK.Multiple);
		}

		public override void OnDialogClosed()
		{
			if (MapManager.Instance != null)
			{
				MapManager.Instance.StopErrorMessage();
			}
			DialogActive = false;
			base.OnDialogClosed();
		}

		public void OnClaimClick()
		{
			if (!KPFIBDEMEPB)
			{
				KFMJHIOKEBG();
			}
			else if (INJLCJLDNKC)
			{
				FACOFGIMPIM();
			}
			else
			{
				PNNHELCPGMM();
			}
		}

		private void KFMJHIOKEBG()
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TeamTournamentRewardsDialog closed wtihout any action because leaderboard data is not up to date.");
			PEHKLPAIBDN();
			Close();
		}

		private void FACOFGIMPIM()
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TeamTournamentRewardsDialog Claim clicked.");
			Blocker.SetActive(true);
			LoadingIndicator.SetActive(true);
			JBLHLNCOLHD();
			DBLLMGJJOOD.LCEPBBLJGCG(NJGAOPBHPIO, delegate(bool EEKJMDHEJCK)
			{
				Blocker.SetActive(false);
				LoadingIndicator.SetActive(false);
				if (EEKJMDHEJCK)
				{
					int aCFDIDGFPKJ = GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Coins, MCFEBJMJCHC);
					JBJKNCHCDOK = AMFCLGFBDJI;
					GEBAAFFGKJG.GABGKBAKHDP.NPGEJMKGJON(aCFDIDGFPKJ);
					SetOnDialogClosedCallback(MBEBGNDIKCM);
					NANPEDFGNEP();
				}
				else
				{
					PEHKLPAIBDN();
				}
				Close();
			});
		}

		private void PNNHELCPGMM()
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TeamTournamentRewardsDialog Continue clicked.");
			if (DBLLMGJJOOD != null && DBLLMGJJOOD.AEBACBBGHKI <= 0)
			{
				DBLLMGJJOOD.KALEIGDLEAM(NJGAOPBHPIO);
				NANPEDFGNEP();
			}
			Close();
		}

		private static void PEHKLPAIBDN()
		{
			if (MapManager.Instance != null)
			{
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Connection"));
			}
		}

		private void MBEBGNDIKCM()
		{
			if (EKCINKDJPDI)
			{
				SpriteButtonListener.Instance.EnableClicks = false;
			}
			IJIMKNBDAKJ(MCFEBJMJCHC, JBJKNCHCDOK);
		}

		private static void IJIMKNBDAKJ(int NNIDKMJGAJO, Action IMHLFAHONPP)
		{
			MapUIAnimationController instance = MapUIAnimationController.Instance;
			if (instance == null)
			{
				if (IMHLFAHONPP != null)
				{
					IMHLFAHONPP();
				}
			}
			else
			{
				instance.StartCoinCollectAnimation(NNIDKMJGAJO, IMHLFAHONPP, 20, NewMapPage.CoinAnimationStartPosition);
			}
		}

		private void NANPEDFGNEP()
		{
			JsonInventory jsonInventory = new JsonInventory();
			jsonInventory.LDOCFEGBGNK();
			JsonTeamChestGifts jsonTeamChestGifts = new JsonTeamChestGifts();
			jsonTeamChestGifts.coin = MCFEBJMJCHC;
			JsonTeamChestGifts gifts = jsonTeamChestGifts;
			JsonTeamTournament jsonTeamTournament = new JsonTeamTournament();
			jsonTeamTournament.member_count = DBLLMGJJOOD.MIIHHONLDOI;
			jsonTeamTournament.gifts = gifts;
			jsonTeamTournament.inventory = jsonInventory;
			JsonTeamTournament jsonTeamTournament2 = jsonTeamTournament;
			jsonTeamTournament2.LLGLAHKBJJG();
			AFJPGLHKOID.NPHHNNEIBOA(DBLLMGJJOOD.IFOAAOCJODG, NJGAOPBHPIO, jsonTeamTournament2);
		}

		public override bool CanHandleBackButton()
		{
			return false;
		}

		public override bool CanCloseOnBlackPanelTouch()
		{
			return false;
		}

		[CompilerGenerated]
		private static int POPPGFFJAHA(TtTeamInfo IBBBMACIBGK)
		{
			return IBBBMACIBGK.starCount;
		}

		[CompilerGenerated]
		private static long GFKHBAJAGFG(TtTeamInfo IBBBMACIBGK)
		{
			return IBBBMACIBGK.teamId;
		}

		[CompilerGenerated]
		private static int ABKPGABNGOL(TtMemberInfo IBBBMACIBGK)
		{
			return IBBBMACIBGK.progress;
		}

		[CompilerGenerated]
		private static int APGEBFDEJDK(TtMemberInfo IBBBMACIBGK)
		{
			return IBBBMACIBGK.disabled;
		}

		[CompilerGenerated]
		private void AIGEPGOOFGD(bool EEKJMDHEJCK)
		{
			Blocker.SetActive(false);
			LoadingIndicator.SetActive(false);
			if (EEKJMDHEJCK)
			{
				int aCFDIDGFPKJ = GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Coins, MCFEBJMJCHC);
				JBJKNCHCDOK = AMFCLGFBDJI;
				GEBAAFFGKJG.GABGKBAKHDP.NPGEJMKGJON(aCFDIDGFPKJ);
				SetOnDialogClosedCallback(MBEBGNDIKCM);
				NANPEDFGNEP();
			}
			else
			{
				PEHKLPAIBDN();
			}
			Close();
		}
	}
}
