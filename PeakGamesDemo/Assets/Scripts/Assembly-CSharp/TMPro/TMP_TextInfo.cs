using System;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	public class TMP_TextInfo
	{
		private static Vector2 k_InfinityVectorPositive = new Vector2(32767f, 32767f);

		private static Vector2 k_InfinityVectorNegative = new Vector2(-32767f, -32767f);

		public TMP_Text textComponent;

		public int characterCount;

		public int spriteCount;

		public int spaceCount;

		public int wordCount;

		public int linkCount;

		public int lineCount;

		public int pageCount;

		public int materialCount;

		public MGLLLPMKGDA[] characterInfo;

		public GLDAENBEFBI[] wordInfo;

		public IDPGGIAHIGC[] linkInfo;

		public CFLMKMOJIJI[] lineInfo;

		public FIJGPKLCJGE[] pageInfo;

		public IDAPNGDHHBD[] meshInfo;

		private IDAPNGDHHBD[] m_CachedMeshInfo;

		public TMP_TextInfo()
		{
			characterInfo = new MGLLLPMKGDA[8];
			wordInfo = new GLDAENBEFBI[16];
			linkInfo = new IDPGGIAHIGC[0];
			lineInfo = new CFLMKMOJIJI[2];
			pageInfo = new FIJGPKLCJGE[4];
			meshInfo = new IDAPNGDHHBD[1];
		}

		public TMP_TextInfo(TMP_Text MHFABDJOCMG)
		{
			textComponent = MHFABDJOCMG;
			characterInfo = new MGLLLPMKGDA[8];
			wordInfo = new GLDAENBEFBI[4];
			linkInfo = new IDPGGIAHIGC[0];
			lineInfo = new CFLMKMOJIJI[2];
			pageInfo = new FIJGPKLCJGE[4];
			meshInfo = new IDAPNGDHHBD[1];
			meshInfo[0].IJKCGGPJDIG = MHFABDJOCMG.IJKCGGPJDIG;
			materialCount = 1;
		}

		public void BOPEPLONIFL()
		{
			characterCount = 0;
			spaceCount = 0;
			wordCount = 0;
			linkCount = 0;
			lineCount = 0;
			pageCount = 0;
			spriteCount = 0;
			for (int i = 0; i < meshInfo.Length; i++)
			{
				meshInfo[i].BKJOIFFAGKE = 0;
			}
		}

		public void OOPEFLFPKFO(bool AHJKJHGIJIA)
		{
			for (int i = 0; i < meshInfo.Length; i++)
			{
				meshInfo[i].BOPEPLONIFL(AHJKJHGIJIA);
			}
		}

		public void JOBBMAHDMDP()
		{
			for (int i = 0; i < meshInfo.Length; i++)
			{
				meshInfo[i].BOPEPLONIFL(true);
			}
		}

		public void PGMGIJGFCNP(bool JKKNBMKFKAI)
		{
			for (int i = 0; i < meshInfo.Length; i++)
			{
				meshInfo[i].CMGCBJCIJNB(0, JKKNBMKFKAI);
			}
		}

		public void NGOKLPFCFAO(FMOBJPAGLEE[] IDBMABBJCNC)
		{
			for (int i = 0; i < meshInfo.Length; i++)
			{
				int kKMNKJJENIL = 0;
				meshInfo[i].NGOKLPFCFAO(kKMNKJJENIL);
			}
		}

		public void KNPNNLMNFIL()
		{
			if (lineInfo == null)
			{
				lineInfo = new CFLMKMOJIJI[2];
			}
			for (int i = 0; i < lineInfo.Length; i++)
			{
				lineInfo[i].NGNCDLJAEFL = 0;
				lineInfo[i].EAMAFAMPCGE = 0;
				lineInfo[i].HHHMOGOKFHF = 0f;
				lineInfo[i].MNKFKKODLLM = k_InfinityVectorNegative.x;
				lineInfo[i].CALDBEMMLEA = k_InfinityVectorPositive.x;
				lineInfo[i].DIPEKGFBHMP.IJHGDODBFCD = k_InfinityVectorPositive;
				lineInfo[i].DIPEKGFBHMP.NHLJFKPLKLI = k_InfinityVectorNegative;
				lineInfo[i].HDDCEFKKDHE = 0f;
			}
		}

		public IDAPNGDHHBD[] NELIGDABDAE()
		{
			if (m_CachedMeshInfo == null || m_CachedMeshInfo.Length != meshInfo.Length)
			{
				m_CachedMeshInfo = new IDAPNGDHHBD[meshInfo.Length];
				for (int i = 0; i < m_CachedMeshInfo.Length; i++)
				{
					int num = meshInfo[i].FHBFCAEGPOH.Length;
					m_CachedMeshInfo[i].FHBFCAEGPOH = new Vector3[num];
					m_CachedMeshInfo[i].LFAFOAOKPKA = new Vector2[num];
					m_CachedMeshInfo[i].FJPNPHPFBFJ = new Vector2[num];
					m_CachedMeshInfo[i].PMBHKFBDDND = new Color32[num];
				}
			}
			for (int j = 0; j < m_CachedMeshInfo.Length; j++)
			{
				int num2 = meshInfo[j].FHBFCAEGPOH.Length;
				if (m_CachedMeshInfo[j].FHBFCAEGPOH.Length != num2)
				{
					m_CachedMeshInfo[j].FHBFCAEGPOH = new Vector3[num2];
					m_CachedMeshInfo[j].LFAFOAOKPKA = new Vector2[num2];
					m_CachedMeshInfo[j].FJPNPHPFBFJ = new Vector2[num2];
					m_CachedMeshInfo[j].PMBHKFBDDND = new Color32[num2];
				}
				Array.Copy(meshInfo[j].FHBFCAEGPOH, m_CachedMeshInfo[j].FHBFCAEGPOH, num2);
				Array.Copy(meshInfo[j].LFAFOAOKPKA, m_CachedMeshInfo[j].LFAFOAOKPKA, num2);
				Array.Copy(meshInfo[j].FJPNPHPFBFJ, m_CachedMeshInfo[j].FJPNPHPFBFJ, num2);
				Array.Copy(meshInfo[j].PMBHKFBDDND, m_CachedMeshInfo[j].PMBHKFBDDND, num2);
			}
			return m_CachedMeshInfo;
		}

		public static void NKMKBLFBOFC<T>(ref T[] KDOGMDCDCEN, int MOFHAKELNPN)
		{
			int newSize = ((MOFHAKELNPN <= 1024) ? Mathf.NextPowerOfTwo(MOFHAKELNPN) : (MOFHAKELNPN + 256));
			Array.Resize(ref KDOGMDCDCEN, newSize);
		}

		public static void NKMKBLFBOFC<T>(ref T[] KDOGMDCDCEN, int MOFHAKELNPN, bool FGCCAEAPJOK)
		{
			if (FGCCAEAPJOK)
			{
				MOFHAKELNPN = ((MOFHAKELNPN <= 1024) ? Mathf.NextPowerOfTwo(MOFHAKELNPN) : (MOFHAKELNPN + 256));
			}
			if (MOFHAKELNPN != KDOGMDCDCEN.Length)
			{
				Array.Resize(ref KDOGMDCDCEN, MOFHAKELNPN);
			}
		}
	}
}
