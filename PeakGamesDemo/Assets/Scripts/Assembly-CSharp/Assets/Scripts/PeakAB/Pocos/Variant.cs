using System;

namespace Assets.Scripts.PeakAB.Pocos
{
	[Serializable]
	public class Variant
	{
		public string variant_id;

		public string file_url;

		public object file_content;

		public int ts;

		public object hash;
	}
}
