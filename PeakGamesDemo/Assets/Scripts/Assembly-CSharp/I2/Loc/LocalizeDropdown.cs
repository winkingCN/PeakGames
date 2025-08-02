using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace I2.Loc
{
	[AddComponentMenu("I2/Localization/Localize Dropdown")]
	public class LocalizeDropdown : MonoBehaviour
	{
		public List<string> _Terms = new List<string>();

		public void Start()
		{
			PNAJOCHGJFO.BEBEKBLNBDB += OnLocalize;
			OnLocalize();
		}

		public void OnDestroy()
		{
			PNAJOCHGJFO.BEBEKBLNBDB -= OnLocalize;
		}

		private void OnEnable()
		{
			if (_Terms.Count == 0)
			{
				KKPEEGLHOHJ();
			}
			OnLocalize();
		}

		public void OnLocalize()
		{
			if (base.enabled && !(base.gameObject == null) && base.gameObject.activeInHierarchy && !string.IsNullOrEmpty(PNAJOCHGJFO.LOEHJECLFHL))
			{
				UpdateLocalization();
			}
		}

		private void KKPEEGLHOHJ()
		{
			Dropdown component = GetComponent<Dropdown>();
			if (component == null && ODIHEPBMAPE.MIGINPHAHND())
			{
				OFLFFOBIIMK();
				return;
			}
			foreach (Dropdown.OptionData option in component.options)
			{
				_Terms.Add(option.text);
			}
		}

		public void UpdateLocalization()
		{
			Dropdown component = GetComponent<Dropdown>();
			if (component == null)
			{
				UpdateLocalizationTMPro();
				return;
			}
			component.options.Clear();
			foreach (string term in _Terms)
			{
				string text = PNAJOCHGJFO.NOGNJJIFAIN(term);
				component.options.Add(new Dropdown.OptionData(text));
			}
			component.RefreshShownValue();
		}

		public void UpdateLocalizationTMPro()
		{
			TMP_Dropdown component = GetComponent<TMP_Dropdown>();
			if (component == null)
			{
				return;
			}
			component.ONFGHNCDFKO.Clear();
			foreach (string term in _Terms)
			{
				string fCJBBPHFNPJ = PNAJOCHGJFO.NOGNJJIFAIN(term);
				component.ONFGHNCDFKO.Add(new TMP_Dropdown.OptionData(fCJBBPHFNPJ));
			}
			component.RefreshShownValue();
		}

		private void OFLFFOBIIMK()
		{
			TMP_Dropdown component = GetComponent<TMP_Dropdown>();
			if (component == null)
			{
				return;
			}
			foreach (TMP_Dropdown.OptionData option in component.ONFGHNCDFKO)
			{
				_Terms.Add(option.text);
			}
		}
	}
}
