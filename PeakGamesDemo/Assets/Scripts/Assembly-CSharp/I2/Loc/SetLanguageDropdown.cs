using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace I2.Loc
{
	[AddComponentMenu("I2/Localization/SetLanguage Dropdown")]
	public class SetLanguageDropdown : MonoBehaviour
	{
		private void OnEnable()
		{
			Dropdown component = GetComponent<Dropdown>();
			if (!(component == null))
			{
				string item = PNAJOCHGJFO.LOEHJECLFHL;
				if (PNAJOCHGJFO.ODEOFDCJHNK.Count == 0)
				{
					PNAJOCHGJFO.JHMHBFIFFFK();
				}
				List<string> list = PNAJOCHGJFO.JKANFJOGPBF();
				component.ClearOptions();
				component.AddOptions(list);
				component.value = list.IndexOf(item);
				component.onValueChanged.RemoveListener(CNLHHMJHGEM);
				component.onValueChanged.AddListener(CNLHHMJHGEM);
			}
		}

		private void CNLHHMJHGEM(int EHJNMODJEAN)
		{
			Dropdown component = GetComponent<Dropdown>();
			if (EHJNMODJEAN < 0)
			{
				EHJNMODJEAN = 0;
				component.value = EHJNMODJEAN;
			}
			PNAJOCHGJFO.LOEHJECLFHL = component.options[EHJNMODJEAN].text;
		}
	}
}
