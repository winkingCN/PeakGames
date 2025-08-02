using System.Collections.Generic;
using EventsManagers;
using UnityEngine;

namespace Dialogs
{
	public class StarTournamentResultDialog : StarTournamentDialog
	{
		protected override void DIOELAHNLKJ()
		{
			EOBFKOKGDCP = 1.57f;
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
			BKMPMIDDMDF();
			MJHJLEBLKGI();
		}

		public override void DialogCreated()
		{
			base.DialogCreated();
			GANLPJDONMH = DGOMNDMPMBG.GABGKBAKHDP.IIEALLANECJ;
			if (GANLPJDONMH == null)
			{
				return;
			}
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
		}

		protected override void AGEPABIDIJJ(string PDEKHNLNOLA, int JEAAHAFHDEG)
		{
			HINGKINONOC = JEAAHAFHDEG + 1;
			RankText.FCJBBPHFNPJ = "# " + HINGKINONOC;
		}

		protected override void GMIDPFIDMCL()
		{
			if (IAOPAOIEKKH != null)
			{
				float cAEMELGEOAE = (float)HINGKINONOC * 1.4f - 4.8149f - JNFMOMPFIGG * 2f;
				IAOPAOIEKKH.NNODBGKBMLK(cAEMELGEOAE);
			}
		}
	}
}
