using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Spine.Unity
{
	public class AtlasAsset : ScriptableObject
	{
		public TextAsset atlasFile;

		public Material[] materials;

		protected GFNFFCGAGEH atlas;

		public bool IsLoaded
		{
			get
			{
				return atlas != null;
			}
		}

		public static AtlasAsset ICOCODPFNNJ(TextAsset JDDGCOLIDDM, Material[] IDBMABBJCNC, bool AEMBPKJOPDB)
		{
			AtlasAsset atlasAsset = ScriptableObject.CreateInstance<AtlasAsset>();
			atlasAsset.OMOKOKFNBKI();
			atlasAsset.atlasFile = JDDGCOLIDDM;
			atlasAsset.materials = IDBMABBJCNC;
			if (AEMBPKJOPDB)
			{
				atlasAsset.HBLFJLAAIBA();
			}
			return atlasAsset;
		}

		public static AtlasAsset ICOCODPFNNJ(TextAsset JDDGCOLIDDM, Texture2D[] MCOOAPOLEIA, Material DMOJCHBFADP, bool AEMBPKJOPDB)
		{
			string text = JDDGCOLIDDM.text;
			text = text.Replace("\r", string.Empty);
			string[] array = text.Split('\n');
			List<string> list = new List<string>();
			for (int i = 0; i < array.Length - 1; i++)
			{
				if (array[i].Trim().Length == 0)
				{
					list.Add(array[i + 1].Trim().Replace(".png", string.Empty));
				}
			}
			Material[] array2 = new Material[list.Count];
			int j = 0;
			for (int count = list.Count; j < count; j++)
			{
				Material material = null;
				string a = list[j];
				int k = 0;
				for (int num = MCOOAPOLEIA.Length; k < num; k++)
				{
					if (string.Equals(a, MCOOAPOLEIA[k].name, StringComparison.OrdinalIgnoreCase))
					{
						material = new Material(DMOJCHBFADP);
						material.mainTexture = MCOOAPOLEIA[k];
						break;
					}
				}
				if (material != null)
				{
					array2[j] = material;
					continue;
				}
				throw new ArgumentException("Could not find matching atlas page in the texture array.");
			}
			return ICOCODPFNNJ(JDDGCOLIDDM, array2, AEMBPKJOPDB);
		}

		public static AtlasAsset ICOCODPFNNJ(TextAsset JDDGCOLIDDM, Texture2D[] MCOOAPOLEIA, Shader BLCFLFHNKFG, bool AEMBPKJOPDB)
		{
			if (BLCFLFHNKFG == null)
			{
				BLCFLFHNKFG = Shader.Find("Spine/Skeleton");
			}
			Material dMOJCHBFADP = new Material(BLCFLFHNKFG);
			return ICOCODPFNNJ(JDDGCOLIDDM, MCOOAPOLEIA, dMOJCHBFADP, AEMBPKJOPDB);
		}

		private void OMOKOKFNBKI()
		{
			BOPEPLONIFL();
		}

		public virtual void BOPEPLONIFL()
		{
			atlas = null;
		}

		public virtual GFNFFCGAGEH HBLFJLAAIBA()
		{
			if (atlasFile == null)
			{
				Debug.LogError("Atlas file not set for atlas asset: " + base.name, this);
				BOPEPLONIFL();
				return null;
			}
			if (materials == null || materials.Length == 0)
			{
				Debug.LogError("Materials not set for atlas asset: " + base.name, this);
				BOPEPLONIFL();
				return null;
			}
			if (atlas != null)
			{
				return atlas;
			}
			try
			{
				atlas = new GFNFFCGAGEH(new StringReader(atlasFile.text), string.Empty, new ENLNOBFMDHF(this));
				atlas.OACJKGINKAK();
				return atlas;
			}
			catch (Exception ex)
			{
				Debug.LogError("Error reading atlas file for atlas asset: " + base.name + "\n" + ex.Message + "\n" + ex.StackTrace, this);
				return null;
			}
		}

		public Mesh DEEKGBCCMJC(string IOCMOCCFALN, Mesh IJKCGGPJDIG, out Material GHPFOPNNJOB, float HJLOCAEAFMJ = 0.01f)
		{
			FCPKAKFLFEG fCPKAKFLFEG = atlas.GIGKGEPPBCG(IOCMOCCFALN);
			GHPFOPNNJOB = null;
			if (fCPKAKFLFEG != null)
			{
				if (IJKCGGPJDIG == null)
				{
					IJKCGGPJDIG = new Mesh();
					IJKCGGPJDIG.name = IOCMOCCFALN;
				}
				Vector3[] array = new Vector3[4];
				Vector2[] array2 = new Vector2[4];
				Color[] colors = new Color[4]
				{
					Color.white,
					Color.white,
					Color.white,
					Color.white
				};
				int[] triangles = new int[6] { 0, 1, 2, 2, 3, 0 };
				float num = (float)fCPKAKFLFEG.HHHMOGOKFHF / -2f;
				float x = num * -1f;
				float num2 = (float)fCPKAKFLFEG.JKNPBEOPMPK / 2f;
				float y = num2 * -1f;
				array[0] = new Vector3(num, y, 0f) * HJLOCAEAFMJ;
				array[1] = new Vector3(num, num2, 0f) * HJLOCAEAFMJ;
				array[2] = new Vector3(x, num2, 0f) * HJLOCAEAFMJ;
				array[3] = new Vector3(x, y, 0f) * HJLOCAEAFMJ;
				float oJOAGEHFPNP = fCPKAKFLFEG.OJOAGEHFPNP;
				float aAIEJDNAODP = fCPKAKFLFEG.AAIEJDNAODP;
				float eCKFKMJFOCI = fCPKAKFLFEG.ECKFKMJFOCI;
				float oFFFLJCPAJE = fCPKAKFLFEG.OFFFLJCPAJE;
				if (!fCPKAKFLFEG.BBMMCOJNJHE)
				{
					array2[0] = new Vector2(oJOAGEHFPNP, oFFFLJCPAJE);
					array2[1] = new Vector2(oJOAGEHFPNP, aAIEJDNAODP);
					array2[2] = new Vector2(eCKFKMJFOCI, aAIEJDNAODP);
					array2[3] = new Vector2(eCKFKMJFOCI, oFFFLJCPAJE);
				}
				else
				{
					array2[0] = new Vector2(eCKFKMJFOCI, oFFFLJCPAJE);
					array2[1] = new Vector2(oJOAGEHFPNP, oFFFLJCPAJE);
					array2[2] = new Vector2(oJOAGEHFPNP, aAIEJDNAODP);
					array2[3] = new Vector2(eCKFKMJFOCI, aAIEJDNAODP);
				}
				IJKCGGPJDIG.triangles = new int[0];
				IJKCGGPJDIG.vertices = array;
				IJKCGGPJDIG.uv = array2;
				IJKCGGPJDIG.colors = colors;
				IJKCGGPJDIG.triangles = triangles;
				IJKCGGPJDIG.RecalculateNormals();
				IJKCGGPJDIG.RecalculateBounds();
				GHPFOPNNJOB = (Material)fCPKAKFLFEG.CPIKPMLODAK.FDCGLBIAFPB;
			}
			else
			{
				IJKCGGPJDIG = null;
			}
			return IJKCGGPJDIG;
		}
	}
}
