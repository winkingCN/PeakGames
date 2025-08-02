using TMPro;
using UnityEngine;

namespace MapScene
{
	public class TimerMapDisplay : MapDisplay
	{
		public TextMeshPro TimeLeft;

		protected long MNGFOOGIKKO;

		private const int AGPIGPBCAFE = 360000;

		private const int BDHFICDNBHB = 660;

		private LHDGDLKEFJG ABGDJDLNNDE;

		protected void CHIBCELAMDG()
		{
			KGLFJKJCIKP(AIIOBCFKGJG(MNGFOOGIKKO));
		}

		protected void KGLFJKJCIKP(LHDGDLKEFJG INONFJGFBGN)
		{
			if (ABGDJDLNNDE != INONFJGFBGN)
			{
				ABGDJDLNNDE = INONFJGFBGN;
				IPGADFOINIF();
			}
		}

		private void IPGADFOINIF()
		{
			Vector3 localPosition = TimeLeft.ANLKLKAINEO.localPosition;
			switch (ABGDJDLNNDE)
			{
			default:
				TimeLeft.DGLOHLPKABM = 3.6f;
				TimeLeft.JOPPDFNGJBM = KNOECCJHIDP.Left;
				localPosition.x = 0.046f;
				TimeLeft.ANLKLKAINEO.localPosition = localPosition;
				break;
			case LHDGDLKEFJG.Long:
				TimeLeft.DGLOHLPKABM = 3.35f;
				TimeLeft.JOPPDFNGJBM = KNOECCJHIDP.Left;
				localPosition.x = 0f;
				TimeLeft.ANLKLKAINEO.localPosition = localPosition;
				break;
			case LHDGDLKEFJG.Short:
				TimeLeft.DGLOHLPKABM = 3.6f;
				TimeLeft.JOPPDFNGJBM = KNOECCJHIDP.Left;
				localPosition.x = 0.012f;
				TimeLeft.ANLKLKAINEO.localPosition = localPosition;
				break;
			case LHDGDLKEFJG.Finished:
				TimeLeft.DGLOHLPKABM = 3.8f;
				TimeLeft.JOPPDFNGJBM = KNOECCJHIDP.Center;
				localPosition.x = 0f;
				TimeLeft.ANLKLKAINEO.localPosition = localPosition;
				TimeLeft.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("CL_Finished");
				break;
			}
		}

		private static LHDGDLKEFJG AIIOBCFKGJG(long KKLEHEHGDMJ)
		{
			if (KKLEHEHGDMJ >= 360000)
			{
				return LHDGDLKEFJG.Long;
			}
			if (KKLEHEHGDMJ < 660)
			{
				return (KKLEHEHGDMJ > 0) ? LHDGDLKEFJG.Short : LHDGDLKEFJG.Finished;
			}
			return LHDGDLKEFJG.Default;
		}
	}
}
