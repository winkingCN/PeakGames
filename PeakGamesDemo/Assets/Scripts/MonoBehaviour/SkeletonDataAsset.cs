using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Spine.Unity
{
	public class SkeletonDataAsset : ScriptableObject
	{
		public AtlasAsset[] atlasAssets = new AtlasAsset[0];

		public float scale = 0.01f;

		public TextAsset skeletonJSON;

		[HPODBBIKPLB("", "", false, false)]
		public string[] fromAnimation = new string[0];

		[HPODBBIKPLB("", "", false, false)]
		public string[] toAnimation = new string[0];

		public float[] duration = new float[0];

		public float defaultMix;

		public RuntimeAnimatorController controller;

		private KGMHJGFNPFC skeletonData;

		private IIIIDJKKPLL stateData;

		public bool IsLoaded
		{
			get
			{
				return skeletonData != null;
			}
		}

		private void OMOKOKFNBKI()
		{
			BOPEPLONIFL();
		}

		public static SkeletonDataAsset ICOCODPFNNJ(TextAsset KPPCBNAHEAI, AtlasAsset NAKEECODHKO, bool AEMBPKJOPDB, float HJLOCAEAFMJ = 0.01f)
		{
			return ICOCODPFNNJ(KPPCBNAHEAI, new AtlasAsset[1] { NAKEECODHKO }, AEMBPKJOPDB, HJLOCAEAFMJ);
		}

		public static SkeletonDataAsset ICOCODPFNNJ(TextAsset KPPCBNAHEAI, AtlasAsset[] LANGBGEBLIJ, bool AEMBPKJOPDB, float HJLOCAEAFMJ = 0.01f)
		{
			SkeletonDataAsset skeletonDataAsset = ScriptableObject.CreateInstance<SkeletonDataAsset>();
			skeletonDataAsset.BOPEPLONIFL();
			skeletonDataAsset.skeletonJSON = KPPCBNAHEAI;
			skeletonDataAsset.atlasAssets = LANGBGEBLIJ;
			skeletonDataAsset.scale = HJLOCAEAFMJ;
			if (AEMBPKJOPDB)
			{
				skeletonDataAsset.CPILINNBJLL(true);
			}
			return skeletonDataAsset;
		}

		public void BOPEPLONIFL()
		{
			skeletonData = null;
			stateData = null;
		}

		public KGMHJGFNPFC CPILINNBJLL(bool MDAEOJFOBIC)
		{
			if (skeletonJSON == null)
			{
				if (!MDAEOJFOBIC)
				{
					Debug.LogError("Skeleton JSON file not set for SkeletonData asset: " + base.name, this);
				}
				BOPEPLONIFL();
				return null;
			}
			if (skeletonData != null)
			{
				return skeletonData;
			}
			GFNFFCGAGEH[] aNMHLKGBNIP = GCMLAJAELNB();
			EDENIAPLFEN jHLKFNEOEBO = new JKAOAAMMPPH(aNMHLKGBNIP);
			float hJLOCAEAFMJ = scale;
			bool flag = skeletonJSON.name.ToLower().Contains(".skel");
			KGMHJGFNPFC fDLKCJNOPHK;
			try
			{
				fDLKCJNOPHK = ((!flag) ? FDOJFCCGLKM(skeletonJSON.text, jHLKFNEOEBO, hJLOCAEAFMJ) : FDOJFCCGLKM(skeletonJSON.bytes, jHLKFNEOEBO, hJLOCAEAFMJ));
			}
			catch (Exception ex)
			{
				if (!MDAEOJFOBIC)
				{
					Debug.LogError("Error reading skeleton JSON file for SkeletonData asset: " + base.name + "\n" + ex.Message + "\n" + ex.StackTrace, this);
				}
				return null;
			}
			JNPPLJHCLHP(fDLKCJNOPHK);
			return skeletonData;
		}

		internal void JNPPLJHCLHP(KGMHJGFNPFC FDLKCJNOPHK)
		{
			skeletonData = FDLKCJNOPHK;
			stateData = new IIIIDJKKPLL(skeletonData);
			KDKOMPFIEIH();
		}

		internal GFNFFCGAGEH[] GCMLAJAELNB()
		{
			List<GFNFFCGAGEH> list = new List<GFNFFCGAGEH>(atlasAssets.Length);
			for (int i = 0; i < atlasAssets.Length; i++)
			{
				AtlasAsset atlasAsset = atlasAssets[i];
				if (!(atlasAsset == null))
				{
					GFNFFCGAGEH gFNFFCGAGEH = atlasAsset.HBLFJLAAIBA();
					if (gFNFFCGAGEH != null)
					{
						list.Add(gFNFFCGAGEH);
					}
				}
			}
			return list.ToArray();
		}

		internal static KGMHJGFNPFC FDOJFCCGLKM(byte[] DIPNEDDIHBK, EDENIAPLFEN JHLKFNEOEBO, float HJLOCAEAFMJ)
		{
			MemoryStream mOPCLEEGDFB = new MemoryStream(DIPNEDDIHBK);
			KFDBBILPOJN kFDBBILPOJN = new KFDBBILPOJN(JHLKFNEOEBO);
			kFDBBILPOJN.GEBNMKAGJIG = HJLOCAEAFMJ;
			KFDBBILPOJN kFDBBILPOJN2 = kFDBBILPOJN;
			return kFDBBILPOJN2.FDOJFCCGLKM(mOPCLEEGDFB);
		}

		internal static KGMHJGFNPFC FDOJFCCGLKM(string FCJBBPHFNPJ, EDENIAPLFEN JHLKFNEOEBO, float HJLOCAEAFMJ)
		{
			StringReader jIGJDAHIIBA = new StringReader(FCJBBPHFNPJ);
			JCHLDDECFJF jCHLDDECFJF = new JCHLDDECFJF(JHLKFNEOEBO);
			jCHLDDECFJF.GEBNMKAGJIG = HJLOCAEAFMJ;
			JCHLDDECFJF jCHLDDECFJF2 = jCHLDDECFJF;
			return jCHLDDECFJF2.FDOJFCCGLKM(jIGJDAHIIBA);
		}

		public void KDKOMPFIEIH()
		{
			if (stateData == null)
			{
				return;
			}
			stateData.FOMAIIHKNPM = defaultMix;
			int i = 0;
			for (int num = fromAnimation.Length; i < num; i++)
			{
				if (fromAnimation[i].Length != 0 && toAnimation[i].Length != 0)
				{
					stateData.BCGMMBBFMPJ(fromAnimation[i], toAnimation[i], duration[i]);
				}
			}
		}

		public IIIIDJKKPLL AFBPPBHHKFB()
		{
			if (stateData != null)
			{
				return stateData;
			}
			CPILINNBJLL(false);
			return stateData;
		}
	}
}
