using System.IO;
using Spine.Unity;
using UnityEngine;

public class ENLNOBFMDHF : LLFEBPNBNPD
{
	private AtlasAsset NAKEECODHKO;

	public ENLNOBFMDHF(AtlasAsset NAKEECODHKO)
	{
		this.NAKEECODHKO = NAKEECODHKO;
	}

	public void JIKNLJNFPFG(LLLHGJNHPML CPIKPMLODAK, string LCCKDPIBKPJ)
	{
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(LCCKDPIBKPJ);
		Material material = null;
		Material[] materials = NAKEECODHKO.materials;
		foreach (Material material2 in materials)
		{
			if (material2.mainTexture == null)
			{
				Debug.LogError("Material is missing texture: " + material2.name, material2);
				return;
			}
			if (material2.mainTexture.name == fileNameWithoutExtension)
			{
				material = material2;
				break;
			}
		}
		if (material == null)
		{
			Debug.LogError("Material with texture name \"" + fileNameWithoutExtension + "\" not found for atlas asset: " + NAKEECODHKO.name, NAKEECODHKO);
			return;
		}
		CPIKPMLODAK.FDCGLBIAFPB = material;
		if (CPIKPMLODAK.HHHMOGOKFHF == 0 || CPIKPMLODAK.JKNPBEOPMPK == 0)
		{
			CPIKPMLODAK.HHHMOGOKFHF = material.mainTexture.width;
			CPIKPMLODAK.JKNPBEOPMPK = material.mainTexture.height;
		}
	}

	public void ILKDHGENJLB(object CGIOFLEGCHD)
	{
	}
}
