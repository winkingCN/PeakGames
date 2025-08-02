using System;

namespace PeakGames.Amy.Core.Helpers.Managed
{
	[Serializable]
	public class BadWordLanguageNode
	{
		public string[] justWord;

		public string[] wholeSentence;

		public string[] regex;

		public string[] whitelist;
	}
}
