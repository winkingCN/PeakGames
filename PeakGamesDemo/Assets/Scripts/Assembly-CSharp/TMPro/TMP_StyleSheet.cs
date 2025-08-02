using System;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	public class TMP_StyleSheet : ScriptableObject
	{
		private static TMP_StyleSheet s_Instance;

		[SerializeField]
		private List<TMP_Style> m_StyleList = new List<TMP_Style>(1);

		private Dictionary<int, TMP_Style> m_StyleDictionary = new Dictionary<int, TMP_Style>();

		public static TMP_StyleSheet instance
		{
			get
			{
				if (s_Instance == null)
				{
					s_Instance = TMP_Settings.defaultStyleSheet;
					if (s_Instance == null)
					{
						s_Instance = Resources.Load("Style Sheets/TMP Default Style Sheet") as TMP_StyleSheet;
					}
					if (s_Instance == null)
					{
						return null;
					}
					s_Instance.ONBFCHDKBFA();
				}
				return s_Instance;
			}
		}

		public static TMP_StyleSheet DBNNEDBOJAG()
		{
			return instance;
		}

		public static TMP_Style FGGDPFBGNFP(int CKFJKOFGBOL)
		{
			return instance.LPFBJJMDGOA(CKFJKOFGBOL);
		}

		private TMP_Style LPFBJJMDGOA(int CKFJKOFGBOL)
		{
			TMP_Style value;
			if (m_StyleDictionary.TryGetValue(CKFJKOFGBOL, out value))
			{
				return value;
			}
			return null;
		}

		public void JIBNPBOLEID(int BKFPPBIFLFI, int EIHFNBLFEED)
		{
			if (m_StyleDictionary.ContainsKey(BKFPPBIFLFI))
			{
				TMP_Style value = m_StyleDictionary[BKFPPBIFLFI];
				m_StyleDictionary.Add(EIHFNBLFEED, value);
				m_StyleDictionary.Remove(BKFPPBIFLFI);
			}
		}

		public static void DACHFDCNLAB()
		{
			instance.ONBFCHDKBFA();
		}

		private void ONBFCHDKBFA()
		{
			m_StyleDictionary.Clear();
			for (int i = 0; i < m_StyleList.Count; i++)
			{
				m_StyleList[i].MPIBAFLEIAC();
				if (!m_StyleDictionary.ContainsKey(m_StyleList[i].hashCode))
				{
					m_StyleDictionary.Add(m_StyleList[i].hashCode, m_StyleList[i]);
				}
			}
		}
	}
}
