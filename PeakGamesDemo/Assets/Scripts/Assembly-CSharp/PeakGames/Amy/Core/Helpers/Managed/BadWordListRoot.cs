using System;

namespace PeakGames.Amy.Core.Helpers.Managed
{
	[Serializable]
	public class BadWordListRoot
	{
		public bool freeChat;

		public BadWordLanguageNode en;

		public BadWordLanguageNode tr;

		public BadWordLanguageNode it;

		public BadWordLanguageNode fr;

		public BadWordLanguageNode pt;

		public BadWordLanguageNode de;

		public BadWordLanguageNode es;

		public BadWordLanguageNode dflt;
	}
}
