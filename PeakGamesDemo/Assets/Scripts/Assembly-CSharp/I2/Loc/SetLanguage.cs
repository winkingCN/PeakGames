using UnityEngine;

namespace I2.Loc
{
	[AddComponentMenu("I2/Localization/SetLanguage Button")]
	public class SetLanguage : MonoBehaviour
	{
		public string _Language;

		private void OnClick()
		{
			ApplyLanguage();
		}

		public void ApplyLanguage()
		{
			if (PNAJOCHGJFO.ILPMCAOOFIO(_Language))
			{
				PNAJOCHGJFO.LOEHJECLFHL = _Language;
			}
		}
	}
}
