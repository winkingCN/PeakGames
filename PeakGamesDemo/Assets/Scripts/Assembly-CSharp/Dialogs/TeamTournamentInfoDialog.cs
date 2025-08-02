using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Assets.Scripts.MapScene;
using Assets.Scripts.Utils;
using DG.Tweening;
using DataHelpers;
using EventsManagers;
using TMPro;
using ToonSocial;
using Ui.VerticalScroll;
using UnityEngine;
using caravan.protobuf.messages;

namespace Dialogs
{
	public class TeamTournamentInfoDialog : OnCloseCallbackDialog, CCGJIPEFOEL
	{
		public SpriteRenderer BackgroundLeft;

		public SpriteRenderer BackgroundRight;

		public Transform BottomScrollMask;

		public Transform ClockHand;

		public Transform[] DialogTabs;

		public TextMeshPro NoRewardText;

		public TextMeshPro RankText;

		public TextMeshPro TimeLeftText;

		public GameObject LoadingIndicator;

		public GameObject TopInfoContainer;

		public GameObject TopResultContainer;

		public GameObject TeamTournamentEntryPrefab;

		public GameObject TeamMemberEntryPrefab;

		public GameObject TeamMemberSeperatorEntryPrefab;

		public GameObject[] DialogTabSprites;

		public GameObject[] CoinRewards;

		public Animator CurrentAnimator;

		public RewardText CoinRewardText;

		public VerticalScrollController TournamentScrollController;

		public VerticalScrollController MyTeamScrollController;

		private bool OKDMIHIFGKL;

		private int NJGAOPBHPIO;

		private int MCFEBJMJCHC;

		private long MNGFOOGIKKO;

		private float JNFMOMPFIGG;

		private Tween DPCJCKGNMND;

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

		public override void DialogCreated()
		{
			base.DialogCreated();
			DIOELAHNLKJ();
			DBLLMGJJOOD = DGOMNDMPMBG.GABGKBAKHDP.FABKMFCBELE;
			if (DBLLMGJJOOD != null)
			{
				LoadingIndicator.SetActive(true);
				OKDMIHIFGKL = DBLLMGJJOOD.AEPLIGFCGIF == 3;
				TopResultContainer.SetActive(OKDMIHIFGKL);
				TopInfoContainer.SetActive(!OKDMIHIFGKL);
				if (CurrentAnimator != null && !OKDMIHIFGKL)
				{
					CurrentAnimator.Play(Animator.StringToHash("Base Layer.TeamTournamentDialogCollectAnimation"));
				}
				TtConfigJson ttConfigJson = DBLLMGJJOOD.GIEDINFFPNJ;
				INCCLAOPKJE = ttConfigJson.rewards;
				MNGFOOGIKKO = DBLLMGJJOOD.AEBACBBGHKI;
				IOPCENJILNF();
				if (DBLLMGJJOOD.GFEHMHDJKIF)
				{
					KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
					{
						new FBNFMCGHLEE(DBLLMGJJOOD.IFOAAOCJODG, DBLLMGJJOOD.INFAGKCBEHL, LECPGNKOABP.GABGKBAKHDP.OADDPGNIINO, COCLEFIOIMB)
					});
				}
				else
				{
					COCLEFIOIMB(true);
				}
			}
		}

		public override void PlayDialogInAnimation()
		{
			base.PlayDialogInAnimation();
			TournamentScrollController.JBOFOOHGDGC();
			MyTeamScrollController.JBOFOOHGDGC();
		}

		private void DIOELAHNLKJ()
		{
			if (ONCMBJKLKIL.KLEKJMEOPEH)
			{
				float num = 1.7787265f * ONCMBJKLKIL.EMFKAPJMDCC;
				float num2 = (ONCMBJKLKIL.FHAMOHDEGMK - num) * 0.4f;
				Vector2 size = new Vector2(BackgroundLeft.size.x, 8.168766f + num2);
				Vector2 size2 = new Vector2(BackgroundLeft.size.x, 8.168766f + num2);
				BottomScrollMask.localPosition = new Vector3(0f, -7.92f - num2, 0f);
				BackgroundLeft.size = size;
				BackgroundRight.size = size2;
				BackgroundLeft.transform.localPosition = new Vector3(BackgroundLeft.transform.localPosition.x, -2.858f - num2 * 0.5f, 0f);
				BackgroundRight.transform.localPosition = new Vector3(BackgroundRight.transform.localPosition.x, -2.858f - num2 * 0.5f, 0f);
				Vector2 size3 = TournamentScrollController.ScrollArea.size;
				size3.y += num2;
				TournamentScrollController.ScrollArea.size = size3;
				Vector2 offset = TournamentScrollController.ScrollArea.offset;
				offset.y -= num2 * 0.5f;
				TournamentScrollController.ScrollArea.offset = offset;
				size3 = MyTeamScrollController.ScrollArea.size;
				size3.y += num2;
				MyTeamScrollController.ScrollArea.size = size3;
				offset = MyTeamScrollController.ScrollArea.offset;
				offset.y -= num2 * 0.5f;
				MyTeamScrollController.ScrollArea.offset = offset;
				JNFMOMPFIGG = num2 * 0.5f;
			}
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
					int num3 = DBLLMGJJOOD.MIIHHONLDOI;
					if (OKDMIHIFGKL && num2 > 0 && num3 > 0)
					{
						MCFEBJMJCHC = num2 / num3;
						int num4 = MCFEBJMJCHC % 10;
						if (num4 != 0)
						{
							MCFEBJMJCHC += 10 - num4;
						}
					}
					if (OKDMIHIFGKL)
					{
						NHABCJMFNPG();
					}
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
				TournamentScrollController.Init();
				TournamentScrollController.SetOffsets(0f - JNFMOMPFIGG, 0f - JNFMOMPFIGG);
			}
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
					if (item.disabled == 1)
					{
						NHABCJMFNPG(true);
					}
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
				HIGKJHLLBNH = new global::FJMEICJIFCD<KFHNJBEEPBL, TeamTournamentPlayerEntry>(MyTeamScrollController, pHEFFKBMAIA, pECIDFMIPIN, num3);
				HIGKJHLLBNH.FEHBHKPHBFC(10, JNFMOMPFIGG);
				MyTeamScrollController.Init();
				MyTeamScrollController.SetOffsets(0f - JNFMOMPFIGG, 0f - JNFMOMPFIGG);
			}
			HIGKJHLLBNH.BBOMMEKKAEB(list2);
			MyTeamScrollController.SetContentSize(num4 + 0.2f);
			MyTeamScrollController.ScrollToTop();
			MyTeamScrollController.JBOFOOHGDGC();
			return true;
		}

		private void NHABCJMFNPG(bool MOOFCMOFDMA = false)
		{
			RankText.FCJBBPHFNPJ = "# " + NJGAOPBHPIO;
			AGDBBOAKAFP(false);
			if (NJGAOPBHPIO <= 5 && !MOOFCMOFDMA)
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

		private void COCLEFIOIMB(bool EEKJMDHEJCK)
		{
			ONLFNAFHLHJ();
			ABAAECDEMOB();
		}

		public override void OnDialogClosed()
		{
			if (MapManager.Instance != null)
			{
				MapManager.Instance.StopErrorMessage();
			}
			TimerHelper.GABGKBAKHDP.DeregisterTimer(this);
			base.OnDialogClosed();
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

		private void IOPCENJILNF()
		{
			if (MNGFOOGIKKO <= 0)
			{
				GMOMEPNHJGA();
				return;
			}
			TimerHelper.GABGKBAKHDP.RegisterTimer(this);
			DPOOABPAMFO();
		}

		public void UpdateTimeLeft()
		{
			KCKDNJOMPJH kCKDNJOMPJH = DGOMNDMPMBG.GABGKBAKHDP.FABKMFCBELE;
			MNGFOOGIKKO = ((kCKDNJOMPJH != null) ? kCKDNJOMPJH.AEBACBBGHKI : 0);
			DPOOABPAMFO();
		}

		public void DecreaseTimeLeft()
		{
			MNGFOOGIKKO--;
			DPOOABPAMFO();
		}

		private void DPOOABPAMFO()
		{
			if (MNGFOOGIKKO > 0)
			{
				TimeLeftText.FCJBBPHFNPJ = GJEIMLMEHIN.FLANACEGNEO((int)MNGFOOGIKKO, true);
				ClockHand.DORotate(new Vector3(0f, 0f, (float)(MNGFOOGIKKO % 4) * 90f), 0.2f).SetEase(Ease.OutBack);
			}
			else
			{
				GMOMEPNHJGA();
			}
		}

		private void GMOMEPNHJGA()
		{
			TimerHelper.GABGKBAKHDP.DeregisterTimer(this);
			Vector3 localPosition = TimeLeftText.ANLKLKAINEO.localPosition;
			localPosition.x = 0.267f;
			TimeLeftText.ANLKLKAINEO.localPosition = localPosition;
			TimeLeftText.JOPPDFNGJBM = KNOECCJHIDP.Center;
			TimeLeftText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("CL_Finished");
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
	}
}
