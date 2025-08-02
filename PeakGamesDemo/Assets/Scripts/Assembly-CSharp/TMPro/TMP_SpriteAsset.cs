using System.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	public class TMP_SpriteAsset : TMP_Asset
	{
		private Dictionary<int, int> m_UnicodeLookup;

		private Dictionary<int, int> m_NameLookup;

		public static TMP_SpriteAsset m_defaultSpriteAsset;

		public Texture spriteSheet;

		public List<TMP_Sprite> spriteInfoList;

		private Dictionary<int, int> m_SpriteUnicodeLookup;

		[SerializeField]
		public List<TMP_SpriteAsset> fallbackSpriteAssets;

		public static TMP_SpriteAsset defaultSpriteAsset
		{
			get
			{
				if (m_defaultSpriteAsset == null)
				{
					m_defaultSpriteAsset = Resources.Load<TMP_SpriteAsset>("Sprite Assets/Default Sprite Asset");
				}
				return m_defaultSpriteAsset;
			}
		}

		private void OnEnable()
		{
		}

		private Material GKIAEPGOELA()
		{
			MOHPNOBPBBL.LNNKOOPFJON();
			Shader shader = Shader.Find("TextMeshPro/Sprite");
			Material material = new Material(shader);
			material.SetTexture(MOHPNOBPBBL.GKMMOOGJLHP, spriteSheet);
			material.hideFlags = HideFlags.HideInHierarchy;
			return material;
		}

		public void IDIAKBJCKGL()
		{
			if (m_NameLookup == null)
			{
				m_NameLookup = new Dictionary<int, int>();
			}
			if (m_UnicodeLookup == null)
			{
				m_UnicodeLookup = new Dictionary<int, int>();
			}
			for (int i = 0; i < spriteInfoList.Count; i++)
			{
				int key = spriteInfoList[i].hashCode;
				if (!m_NameLookup.ContainsKey(key))
				{
					m_NameLookup.Add(key, i);
				}
				int unicode = spriteInfoList[i].unicode;
				if (!m_UnicodeLookup.ContainsKey(unicode))
				{
					m_UnicodeLookup.Add(unicode, i);
				}
			}
		}

		public int GKLFEMKCFNH(int CKFJKOFGBOL)
		{
			if (m_NameLookup == null)
			{
				IDIAKBJCKGL();
			}
			int value = 0;
			if (m_NameLookup.TryGetValue(CKFJKOFGBOL, out value))
			{
				return value;
			}
			return -1;
		}

		public int CKGEAHJCDNP(int NPCBJGBAJCK)
		{
			if (m_UnicodeLookup == null)
			{
				IDIAKBJCKGL();
			}
			int value = 0;
			if (m_UnicodeLookup.TryGetValue(NPCBJGBAJCK, out value))
			{
				return value;
			}
			return -1;
		}

		public int MOOECNDPDEF(string IOCMOCCFALN)
		{
			if (m_NameLookup == null)
			{
				IDIAKBJCKGL();
			}
			int cKFJKOFGBOL = LBOEJMDHOEP.OLDMALBCAKF(IOCMOCCFALN);
			return GKLFEMKCFNH(cKFJKOFGBOL);
		}

		public static TMP_SpriteAsset GOGLJPJDMMP(TMP_SpriteAsset GKDEMJDOOLB, int NPCBJGBAJCK, out int JDMPHFEHPCI)
		{
			JDMPHFEHPCI = -1;
			if (GKDEMJDOOLB == null)
			{
				return null;
			}
			JDMPHFEHPCI = GKDEMJDOOLB.CKGEAHJCDNP(NPCBJGBAJCK);
			if (JDMPHFEHPCI != -1)
			{
				return GKDEMJDOOLB;
			}
			if (GKDEMJDOOLB.fallbackSpriteAssets != null && GKDEMJDOOLB.fallbackSpriteAssets.Count > 0)
			{
				for (int i = 0; i < GKDEMJDOOLB.fallbackSpriteAssets.Count; i++)
				{
					if (JDMPHFEHPCI != -1)
					{
						break;
					}
					TMP_SpriteAsset tMP_SpriteAsset = GOGLJPJDMMP(GKDEMJDOOLB.fallbackSpriteAssets[i], NPCBJGBAJCK, out JDMPHFEHPCI);
					if (tMP_SpriteAsset != null)
					{
						return tMP_SpriteAsset;
					}
				}
			}
			return null;
		}

		public static TMP_SpriteAsset GOGLJPJDMMP(List<TMP_SpriteAsset> BEFIOPLCCGI, int NPCBJGBAJCK, out int JDMPHFEHPCI)
		{
			JDMPHFEHPCI = -1;
			if (BEFIOPLCCGI != null && BEFIOPLCCGI.Count > 0)
			{
				for (int i = 0; i < BEFIOPLCCGI.Count; i++)
				{
					TMP_SpriteAsset tMP_SpriteAsset = GOGLJPJDMMP(BEFIOPLCCGI[i], NPCBJGBAJCK, out JDMPHFEHPCI);
					if (tMP_SpriteAsset != null)
					{
						return tMP_SpriteAsset;
					}
				}
			}
			return null;
		}
	}
}
