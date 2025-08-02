using System.Collections.Generic;
using DG.Tweening;
using DataHelpers;
using EventsManagers;
using TMPro;
using ToonSocial.dialogs;
using UnityEngine;
using Utils;

namespace Dialogs
{
	public class StarTournamentInfoDialog : StarTournamentDialog, CCGJIPEFOEL
	{
		public Transform ClockHand;

		public TextMeshPro TimeLeftText;

		public Transform JapaneseSunContainer;

		private long MNGFOOGIKKO;

		protected override void DIOELAHNLKJ()
		{
			EOBFKOKGDCP = -0.18f;
			if (JapaneseSunContainer != null)
			{
				JapaneseSunContainer.transform.DORotate(new Vector3(0f, 0f, -179.99f), 30f, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);
			}
			if (ONCMBJKLKIL.KLEKJMEOPEH)
			{
				float num = 1.7787265f * ONCMBJKLKIL.EMFKAPJMDCC;
				float num2 = (ONCMBJKLKIL.FHAMOHDEGMK - num) * 0.3f;
				Vector2 size = new Vector2(BackgroundLeft.size.x, 14.92428f + num2);
				Vector2 size2 = new Vector2(BackgroundLeft.size.x, 14.92428f + num2);
				BottomScrollMask.transform.localPosition = new Vector3(0f, -7.92f - num2, 0f);
				BackgroundLeft.size = size;
				BackgroundRight.size = size2;
				BackgroundLeft.transform.localPosition = new Vector3(BackgroundLeft.transform.localPosition.x, 0.5178f - num2 * 0.5f, 0f);
				BackgroundRight.transform.localPosition = new Vector3(BackgroundRight.transform.localPosition.x, 0.5178f - num2 * 0.5f, 0f);
				Vector2 size3 = StarTournamentScrollController.ScrollArea.size;
				size3.y += num2;
				StarTournamentScrollController.ScrollArea.size = size3;
				Vector2 offset = StarTournamentScrollController.ScrollArea.offset;
				offset.y -= num2 * 0.5f;
				StarTournamentScrollController.ScrollArea.offset = offset;
				JNFMOMPFIGG = num2 * 0.5f;
				if (JKANNLPGLPJ != null)
				{
					StarTournamentScrollController.SetOffsets(0f - JNFMOMPFIGG, 0f - JNFMOMPFIGG);
					StarTournamentScrollController.SetContentSize(ANJBHOECJME);
					StarTournamentScrollController.ScrollToTop();
				}
			}
		}

		public override void DialogCreated()
		{
			base.DialogCreated();
			GANLPJDONMH = DGOMNDMPMBG.GABGKBAKHDP.IIEALLANECJ;
			if (GANLPJDONMH == null)
			{
				return;
			}
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
			{
				new ILCNNFKJEFG(GANLPJDONMH.INFAGKCBEHL, true, base.COCLEFIOIMB)
			});
			LoadingIndicator.SetActive(true);
			StRewardsJson stRewardsJson = GANLPJDONMH.COGMBHJAPNO();
			foreach (StRewardItem reward in stRewardsJson.rewards)
			{
				if (!INCCLAOPKJE.ContainsKey(reward.rank))
				{
					INCCLAOPKJE.Add(reward.rank, new List<StRewardItem>());
				}
				INCCLAOPKJE[reward.rank].Add(reward);
			}
			MNGFOOGIKKO = GANLPJDONMH.AEBACBBGHKI;
			IOPCENJILNF();
		}

		public override void OnDialogClosed()
		{
			if (KPFIBDEMEPB && GANLPJDONMH != null && GANLPJDONMH.NDABFDHPIBB != null && string.IsNullOrEmpty(CFIOFKINCKD) && string.IsNullOrEmpty(LECPGNKOABP.GABGKBAKHDP.KJACEODCOHN))
			{
				GCDCDBFMKIA();
			}
			else if (JCOKJJGCPHI != null)
			{
				JCOKJJGCPHI();
			}
			TimerHelper.GABGKBAKHDP.DeregisterTimer(this);
			base.OnDialogClosed();
		}

		private void GCDCDBFMKIA()
		{
			GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.StarTournamentCreateUserDialog, false);
			StarTournamentCreateUserDialog component = gameObject.GetComponent<StarTournamentCreateUserDialog>();
			component.SetOnDialogClosedCallback(JCOKJJGCPHI);
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
			GPAFPAEDOHM gPAFPAEDOHM = DGOMNDMPMBG.GABGKBAKHDP.IIEALLANECJ;
			MNGFOOGIKKO = ((gPAFPAEDOHM != null) ? gPAFPAEDOHM.AEBACBBGHKI : 0);
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
	}
}
