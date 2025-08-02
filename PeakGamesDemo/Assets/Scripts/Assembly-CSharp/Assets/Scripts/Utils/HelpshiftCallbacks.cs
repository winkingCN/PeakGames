using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Assets.Scripts.Utils
{
	public class HelpshiftCallbacks : MonoBehaviour
	{
		[CompilerGenerated]
		private static NCHDGFIAHLI JANLDOMIIEF;

		[CompilerGenerated]
		private static NCHDGFIAHLI GEBGDBLHLKE;

		public void helpshiftSessionBegan()
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Support, "Helpshift session started.");
			if (MCJHHDACJBG.NDNBMGMPBLF)
			{
				ENJDLHOLKJA(0);
			}
		}

		public void helpshiftSessionEnded()
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Support, "Helpshift session ended.");
			if (MCJHHDACJBG.NDNBMGMPBLF)
			{
				KMBNIBGIHGH.GABGKBAKHDP.OMIKDFPHGBA();
			}
		}

		public void didReceiveUnreadMessagesCount(string FHBPCNHPINC)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Support, "Helpshift received unread message count = {0}", FHBPCNHPINC);
			int result;
			int.TryParse(FHBPCNHPINC, out result);
			ENJDLHOLKJA(result);
		}

		public void newConversationStarted(string AACBDIBOOME)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Support, "Helpshift new conversation started: {0}", AACBDIBOOME);
			GBFAPADEBEC.IIHHGNAACEG(IBDBPGIEAJE);
			AFJPGLHKOID.CPIGOAGGLBM("SupportSend", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString());
		}

		public void didCheckIfConversationActive(string AEDFIIPIPME)
		{
			if (AEDFIIPIPME.Equals("true") && !string.IsNullOrEmpty(KMBNIBGIHGH.CNLLFNKPIEG))
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Support, "Helpshift unsent log file will be retried.");
				GBFAPADEBEC.IIHHGNAACEG(IBDBPGIEAJE);
			}
		}

		private static void ENJDLHOLKJA(int ENMLICFLHAO)
		{
			KMBNIBGIHGH.GABGKBAKHDP.IOBIDNGDPIN = ENMLICFLHAO;
			KMBNIBGIHGH.GABGKBAKHDP.ENJDLHOLKJA();
		}

		private static void IBDBPGIEAJE(bool ODCADGABBHJ, string NOKFDFNMBMJ)
		{
			string text = KMBNIBGIHGH.CNLLFNKPIEG;
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Support, "Helpshift upload log file. Status: {0}, Name:{1}", ODCADGABBHJ, text);
			if (ODCADGABBHJ && !string.IsNullOrEmpty(text))
			{
				GJKNNDNIBMC item = new GJKNNDNIBMC(text, NOKFDFNMBMJ);
				KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH> { item });
			}
		}
	}
}
