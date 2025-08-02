using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Assets.Scripts.Dialogs;
using Assets.Scripts.MapScene;
using EventsManagers;
using TMPro;
using Ui.VerticalScroll;
using UnityEngine;
using caravan.protobuf.messages;

namespace Dialogs
{
	public class StarTournamentDialog : SimpleDialog
	{
		public SpriteRenderer RewardItemSpriteRenderer;

		public SpriteRenderer RewardItemShadowSpriteRenderer;

		public RewardText CoinRewardText;

		public GameObject MyEntryMask;

		public GameObject StarTournamentEntryPrefab;

		public GameObject LoadingIndicator;

		public GameObject BottomScrollMask;

		public GameObject RewardItemContainer;

		public GameObject[] CoinRewards;

		public TextMeshPro ItemAmount;

		public TextMeshPro NoRewardText;

		public TextMeshPro RankText;

		public SpriteRenderer BackgroundLeft;

		public SpriteRenderer BackgroundRight;

		public VerticalScrollController StarTournamentScrollController;

		protected int HINGKINONOC;

		protected string CFIOFKINCKD;

		protected float ANJBHOECJME;

		protected float JNFMOMPFIGG;

		protected float EOBFKOKGDCP;

		protected global::FHOJBJMMNOD<POGHNPKEOKP, StarTournamentEntry> JKANNLPGLPJ;

		protected KHDBHAOFFNG IAOPAOIEKKH;

		protected readonly Dictionary<int, List<StRewardItem>> INCCLAOPKJE = new Dictionary<int, List<StRewardItem>>();

		protected Action JCOKJJGCPHI;

		protected GPAFPAEDOHM GANLPJDONMH;

		protected StRewardItem MLHENHABGMO;

		protected bool KPFIBDEMEPB;

		[CompilerGenerated]
		private static Func<StMemberInfo, int> EBCOMJBLIPP;

		[CompilerGenerated]
		private static Func<StMemberInfo, long> DNBOPLHGMHA;

		private void Start()
		{
			DIOELAHNLKJ();
		}

		protected virtual void DIOELAHNLKJ()
		{
		}

		public void SetOnDialogClosedCallback(Action IMHLFAHONPP)
		{
			JCOKJJGCPHI = IMHLFAHONPP;
		}

		public override void PlayDialogInAnimation()
		{
			base.PlayDialogInAnimation();
			StarTournamentScrollController.JBOFOOHGDGC();
		}

		protected void COCLEFIOIMB(bool EEKJMDHEJCK)
		{
			bool flag = BKMPMIDDMDF();
			KPFIBDEMEPB = flag && EEKJMDHEJCK;
		}

		protected bool BKMPMIDDMDF()
		{
			List<StMemberInfo> list = GANLPJDONMH.NDABFDHPIBB;
			if (list == null)
			{
				Close();
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Connection"));
				return false;
			}
			LoadingIndicator.SetActive(false);
			IOrderedEnumerable<StMemberInfo> orderedEnumerable = from IBBBMACIBGK in list
				orderby IBBBMACIBGK.starCount descending, IBBBMACIBGK.userId
				select IBBBMACIBGK;
			List<POGHNPKEOKP> list2 = new List<POGHNPKEOKP>();
			int count = list.Count;
			int num = 0;
			bool flag = false;
			foreach (StMemberInfo item in orderedEnumerable)
			{
				bool flag2 = LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM == item.userId;
				if (flag2)
				{
					AGEPABIDIJJ(item.nickname, num);
					flag = true;
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "StarTournament Current user star count: {0}", item.starCount);
				}
				POGHNPKEOKP pOGHNPKEOKP = new POGHNPKEOKP();
				pOGHNPKEOKP.KJACEODCOHN = item.nickname;
				pOGHNPKEOKP.EFHEIFMEJCN = item.teamName;
				pOGHNPKEOKP.GCELBDIDEAI = item.teamBadge;
				pOGHNPKEOKP.MNPEKJAAFHD = flag2;
				pOGHNPKEOKP.GDMECFECCOM = item.userId;
				pOGHNPKEOKP.OADDPGNIINO = item.teamId;
				pOGHNPKEOKP.OHAPPDGAKNG = num + 1;
				pOGHNPKEOKP.OGEMDHPJHFO = item.starCount;
				POGHNPKEOKP pOGHNPKEOKP2 = pOGHNPKEOKP;
				List<StRewardItem> value = null;
				if (INCCLAOPKJE.TryGetValue(num + 1, out value))
				{
					pOGHNPKEOKP2.BIEIJGOBEIA = value[0].amount;
					pOGHNPKEOKP2.IHHMGILLMDB = value[0].id;
				}
				list2.Add(pOGHNPKEOKP2);
				num++;
			}
			if (JKANNLPGLPJ == null)
			{
				JKANNLPGLPJ = new global::FHOJBJMMNOD<POGHNPKEOKP, StarTournamentEntry>(StarTournamentScrollController, StarTournamentEntryPrefab.GetComponent<StarTournamentEntry>(), 10, 0.86f);
				JKANNLPGLPJ.FEHBHKPHBFC(13, 1.4f, 0.7f);
				if (flag)
				{
					float y = BottomScrollMask.transform.position.y;
					IAOPAOIEKKH = new KHDBHAOFFNG(JKANNLPGLPJ, MyEntryMask, StarTournamentEntryPrefab.GetComponent<StarTournamentEntry>(), y, JNFMOMPFIGG * 2f + EOBFKOKGDCP, HINGKINONOC - 1);
					JKANNLPGLPJ.EEGJMBDPKGP = IAOPAOIEKKH.IPPIJMJLGLM;
				}
				StarTournamentScrollController.Init();
				StarTournamentScrollController.SetOffsets(0f - JNFMOMPFIGG, 0f - JNFMOMPFIGG);
			}
			ANJBHOECJME = list.Count;
			JKANNLPGLPJ.BBOMMEKKAEB(list2);
			StarTournamentScrollController.SetContentSize((float)count * 1.4f + 0.2f);
			StarTournamentScrollController.ScrollToTop();
			StarTournamentScrollController.JBOFOOHGDGC();
			if (flag)
			{
				IAOPAOIEKKH.NCJIHMIBAPF();
			}
			else
			{
				MyEntryMask.SetActive(false);
			}
			GMIDPFIDMCL();
			return true;
		}

		protected virtual void AGEPABIDIJJ(string PDEKHNLNOLA, int JEAAHAFHDEG)
		{
			HINGKINONOC = JEAAHAFHDEG + 1;
			CFIOFKINCKD = PDEKHNLNOLA;
			RankText.FCJBBPHFNPJ = HINGKINONOC.ToString();
		}

		protected virtual void GMIDPFIDMCL()
		{
		}

		protected void MJHJLEBLKGI()
		{
			List<StRewardItem> value = null;
			INCCLAOPKJE.TryGetValue(HINGKINONOC, out value);
			if (value == null)
			{
				return;
			}
			NoRewardText.enabled = false;
			MLHENHABGMO = value[0];
			NAAHKHPBAPA id = (NAAHKHPBAPA)MLHENHABGMO.id;
			if ((id.LGOKFILDDDD() || id.MCMDJCBFENO()) && MapManager.Instance != null)
			{
				MapManager.Instance.CurrentContainerManager.SlideToPosition(0);
			}
			if (HINGKINONOC < 4)
			{
				ENIHNAEFMNK(RewardItemContainer, false);
				int num = HINGKINONOC - 1;
				ENIHNAEFMNK(CoinRewards[0], num == 0);
				ENIHNAEFMNK(CoinRewards[1], num == 1);
				ENIHNAEFMNK(CoinRewards[2], num == 2);
				CoinRewardText.SetRewardAmount(MLHENHABGMO.amount);
				return;
			}
			ENIHNAEFMNK(CoinRewards[0], false);
			ENIHNAEFMNK(CoinRewards[1], false);
			ENIHNAEFMNK(CoinRewards[2], false);
			CoinRewardText.Activate(false);
			ENIHNAEFMNK(RewardItemContainer, MLHENHABGMO.id != 0);
			if (MLHENHABGMO.id > 0)
			{
				NAAHKHPBAPA id2 = (NAAHKHPBAPA)MLHENHABGMO.id;
				Sprite spriteByInventoryType = SharedImageLibrary.Instance.GetSpriteByInventoryType(id2);
				RewardItemSpriteRenderer.sprite = spriteByInventoryType;
				RewardItemShadowSpriteRenderer.sprite = spriteByInventoryType;
				PDHNGJPKLPB(id2);
				if (MLHENHABGMO.id != 1 && MLHENHABGMO.amount > 0)
				{
					ItemAmount.enabled = true;
					ItemAmount.SetText("x" + MLHENHABGMO.amount);
				}
			}
		}

		private void PDHNGJPKLPB(NAAHKHPBAPA GEKKLIKPAPP)
		{
			switch (GEKKLIKPAPP)
			{
			case NAAHKHPBAPA.BoxingGlove:
				RewardItemSpriteRenderer.transform.localScale = RewardItemSpriteRenderer.transform.localScale * 1.26f;
				break;
			case NAAHKHPBAPA.Rocket:
				RewardItemSpriteRenderer.transform.localScale = RewardItemSpriteRenderer.transform.localScale * 0.9f;
				break;
			case NAAHKHPBAPA.DiscoBall:
				RewardItemSpriteRenderer.transform.localScale = RewardItemSpriteRenderer.transform.localScale * 0.96f;
				break;
			case NAAHKHPBAPA.Dice:
				RewardItemSpriteRenderer.transform.localScale = RewardItemSpriteRenderer.transform.localScale * 0.9f;
				RewardItemSpriteRenderer.transform.localPosition = RewardItemSpriteRenderer.transform.localPosition + Vector3.right * 0.06f;
				break;
			case NAAHKHPBAPA.Bomb:
			case NAAHKHPBAPA.Extra5Moves:
				break;
			}
		}

		private void ENIHNAEFMNK(GameObject LGDFKAMHKFM, bool ODCADGABBHJ)
		{
			if (LGDFKAMHKFM.activeSelf != ODCADGABBHJ)
			{
				LGDFKAMHKFM.SetActive(ODCADGABBHJ);
			}
		}

		[CompilerGenerated]
		private static int GPKBGKIGGBA(StMemberInfo IBBBMACIBGK)
		{
			return IBBBMACIBGK.starCount;
		}

		[CompilerGenerated]
		private static long MIMEBFPLHNK(StMemberInfo IBBBMACIBGK)
		{
			return IBBBMACIBGK.userId;
		}
	}
}
