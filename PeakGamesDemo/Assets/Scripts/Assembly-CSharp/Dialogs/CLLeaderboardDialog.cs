using System.Collections.Generic;
using Assets.Scripts.Dialogs;
using DG.Tweening;
using DataHelpers;
using TMPro;
using Ui.VerticalScroll;
using UnityEngine;
using caravan.protobuf.messages;

namespace Dialogs
{
	public class CLLeaderboardDialog : SimpleDialog, CCGJIPEFOEL
	{
		public TextMeshPro TimeLeftText;

		public GameObject LoadingIndicator;

		public Transform ClockHand;

		public SpriteRenderer BackgroundLeft;

		public SpriteRenderer BackgroundRight;

		public Transform MaskBottom;

		public GameObject LeaderboardEntryPrefab;

		public VerticalScrollController LeaderboardScrollController;

		private global::FHOJBJMMNOD<BDELNAHPDFB, CLLeaderboardEntry> JKANNLPGLPJ;

		private long MNGFOOGIKKO;

		private bool DCOKAEHHCJM;

		private ClLeaderboard HCJJHPGMEHK;

		private readonly Dictionary<int, List<CLRewardItem>> INCCLAOPKJE = new Dictionary<int, List<CLRewardItem>>();

		private float JNFMOMPFIGG;

		public void Start()
		{
			if (ONCMBJKLKIL.KLEKJMEOPEH)
			{
				float num = 1.7787265f * ONCMBJKLKIL.EMFKAPJMDCC;
				float num2 = (ONCMBJKLKIL.FHAMOHDEGMK - num) * 0.3f;
				Vector2 size = new Vector2(BackgroundLeft.size.x, 14.93349f + num2);
				Vector2 size2 = new Vector2(BackgroundRight.size.x, 14.93349f + num2);
				MaskBottom.localPosition = new Vector3(0f, -7.97f - num2, 0f);
				BackgroundLeft.size = size;
				BackgroundRight.size = size2;
				BackgroundLeft.transform.localPosition = new Vector3(BackgroundLeft.transform.localPosition.x, -0.165f - num2 * 0.5f, 0f);
				BackgroundRight.transform.localPosition = new Vector3(BackgroundRight.transform.localPosition.x, -0.165f - num2 * 0.5f, 0f);
				Vector2 size3 = LeaderboardScrollController.ScrollArea.size;
				size3.y = 8.45f + num2;
				LeaderboardScrollController.ScrollArea.size = size3;
				Vector2 offset = LeaderboardScrollController.ScrollArea.offset;
				offset.y -= num2 * 0.5f;
				LeaderboardScrollController.ScrollArea.offset = offset;
				JNFMOMPFIGG = num2 * 0.5f;
			}
		}

		public override void DialogCreated()
		{
			base.DialogCreated();
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
			{
				new IGBCNKNCJDI(COCLEFIOIMB)
			});
			LoadingIndicator.SetActive(true);
			MNGFOOGIKKO = IDFPAFEJPPH.GABGKBAKHDP.AEBACBBGHKI;
			IOPCENJILNF();
			AFJPGLHKOID.CPIGOAGGLBM("CLLeaderboardOpen", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString());
		}

		protected override void BLELAMHLLNN()
		{
			base.BLELAMHLLNN();
			DCOKAEHHCJM = false;
			if (HCJJHPGMEHK != null)
			{
				IDFPAFEJPPH.GABGKBAKHDP.NMOPBGEBEMN(HCJJHPGMEHK);
				FCPPFFMGFFE();
				HCJJHPGMEHK = null;
			}
		}

		public override void OnDialogClosed()
		{
			TimerHelper.GABGKBAKHDP.DeregisterTimer(this);
		}

		private void IOPCENJILNF()
		{
			if (MNGFOOGIKKO > 0)
			{
				TimerHelper.GABGKBAKHDP.RegisterTimer(this);
			}
			DPOOABPAMFO();
		}

		public void UpdateTimeLeft()
		{
			MNGFOOGIKKO = IDFPAFEJPPH.GABGKBAKHDP.AEBACBBGHKI;
			DPOOABPAMFO();
		}

		public void DecreaseTimeLeft()
		{
			MNGFOOGIKKO--;
			DPOOABPAMFO();
		}

		public override void PlayDialogInAnimation()
		{
			base.PlayDialogInAnimation();
			DCOKAEHHCJM = true;
		}

		private void COCLEFIOIMB(bool EEKJMDHEJCK, ClGetLeaderboardResponseMessage OMJOIIOONMO)
		{
			if (EEKJMDHEJCK)
			{
				if (DCOKAEHHCJM)
				{
					HCJJHPGMEHK = OMJOIIOONMO.leaderboard;
					return;
				}
				IDFPAFEJPPH.GABGKBAKHDP.NMOPBGEBEMN(OMJOIIOONMO.leaderboard);
				FCPPFFMGFFE();
			}
		}

		private void DPOOABPAMFO()
		{
			if (!(TimeLeftText == null))
			{
				if (MNGFOOGIKKO > 0)
				{
					TimeLeftText.FCJBBPHFNPJ = GJEIMLMEHIN.JDIMBPFKOBB((int)MNGFOOGIKKO, true);
					ClockHand.DORotate(new Vector3(0f, 0f, (float)(MNGFOOGIKKO % 4) * 90f), 0.2f).SetEase(Ease.OutBack);
				}
				else
				{
					TimerHelper.GABGKBAKHDP.DeregisterTimer(this);
					TimeLeftText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("CL_Finished");
				}
				if (TimeLeftText.FCJBBPHFNPJ.Length < 4)
				{
					TimeLeftText.ANLKLKAINEO.localPosition = new Vector3(0f, 1.413f, 0f);
				}
				else if (TimeLeftText.FCJBBPHFNPJ.Length < 8)
				{
					TimeLeftText.ANLKLKAINEO.localPosition = new Vector3(0.15f, 1.413f, 0f);
				}
				else
				{
					TimeLeftText.ANLKLKAINEO.localPosition = new Vector3(0.3f, 1.413f, 0f);
				}
			}
		}

		private void FCPPFFMGFFE()
		{
			LoadingIndicator.SetActive(false);
			IList<ClMember> list = IDFPAFEJPPH.GABGKBAKHDP.NDABFDHPIBB;
			if (list == null)
			{
				return;
			}
			OGKNOBGBDEO();
			int count = list.Count;
			List<BDELNAHPDFB> list2 = new List<BDELNAHPDFB>();
			int num = 0;
			foreach (ClMember item in list)
			{
				BDELNAHPDFB bDELNAHPDFB = new BDELNAHPDFB();
				bDELNAHPDFB.KKMJBOCCMCF = long.Parse(item.id);
				bDELNAHPDFB.DJADMBLKBKJ = item.score;
				bDELNAHPDFB.OHAPPDGAKNG = num + 1;
				bDELNAHPDFB.KJACEODCOHN = item.nickname;
				BDELNAHPDFB bDELNAHPDFB2 = bDELNAHPDFB;
				List<CLRewardItem> value = null;
				if (INCCLAOPKJE.TryGetValue(num + 1, out value))
				{
					bDELNAHPDFB2.BIEIJGOBEIA = value[0].amount;
					bDELNAHPDFB2.IHHMGILLMDB = value[0].id;
				}
				list2.Add(bDELNAHPDFB2);
				num++;
			}
			if (JKANNLPGLPJ == null)
			{
				JKANNLPGLPJ = new global::FHOJBJMMNOD<BDELNAHPDFB, CLLeaderboardEntry>(LeaderboardScrollController, LeaderboardEntryPrefab.GetComponent<CLLeaderboardEntry>(), 15, 0.86f);
				JKANNLPGLPJ.FEHBHKPHBFC(15, 1.35f, 0.7f);
				LeaderboardScrollController.Init();
				LeaderboardScrollController.SetOffsets(0f - JNFMOMPFIGG, 0f - JNFMOMPFIGG);
			}
			JKANNLPGLPJ.BBOMMEKKAEB(list2);
			LeaderboardScrollController.SetContentSize((float)count * 1.35f + 0.2f);
			LeaderboardScrollController.ScrollToTop();
			LeaderboardScrollController.JBOFOOHGDGC();
		}

		private void OGKNOBGBDEO()
		{
			CLRewardsJson cLRewardsJson = IDFPAFEJPPH.GABGKBAKHDP.COGMBHJAPNO();
			if (cLRewardsJson == null)
			{
				return;
			}
			foreach (CLRewardItem reward in cLRewardsJson.rewards)
			{
				if (!INCCLAOPKJE.ContainsKey(reward.rank))
				{
					INCCLAOPKJE.Add(reward.rank, new List<CLRewardItem>());
				}
				INCCLAOPKJE[reward.rank].Add(reward);
			}
		}
	}
}
