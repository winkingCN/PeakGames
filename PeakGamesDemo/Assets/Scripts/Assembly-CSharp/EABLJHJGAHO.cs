using System;
using System.Collections.Generic;
using UnityEngine;

public static class EABLJHJGAHO
{
	internal const TextureFormat AEBMBGOCELP = TextureFormat.RGBA32;

	internal const float GLLPCDDCBCJ = -0.5f;

	internal const bool PFHALCBFBAA = false;

	internal const float EIPJIHIALBN = 0.01f;

	private static Dictionary<FCPKAKFLFEG, Texture2D> EIIIOPEPMCC = new Dictionary<FCPKAKFLFEG, Texture2D>();

	private static List<Texture2D> HAMNDDKKIEH = new List<Texture2D>();

	public static FCPKAKFLFEG PKGKHHABACE(this Texture2D LLIEHCKNJEM, Material DMOJCHBFADP, float HJLOCAEAFMJ = 0.01f)
	{
		return LLIEHCKNJEM.PKGKHHABACE(DMOJCHBFADP.shader, HJLOCAEAFMJ, DMOJCHBFADP);
	}

	public static FCPKAKFLFEG PKGKHHABACE(this Texture2D LLIEHCKNJEM, Shader BLCFLFHNKFG, float HJLOCAEAFMJ = 0.01f, Material DMOJCHBFADP = null)
	{
		Material material = new Material(BLCFLFHNKFG);
		if (DMOJCHBFADP != null)
		{
			material.CopyPropertiesFromMaterial(DMOJCHBFADP);
			material.shaderKeywords = DMOJCHBFADP.shaderKeywords;
		}
		material.mainTexture = LLIEHCKNJEM;
		LLLHGJNHPML cPIKPMLODAK = material.PAOAGJDAHME();
		float num = LLIEHCKNJEM.width;
		float num2 = LLIEHCKNJEM.height;
		FCPKAKFLFEG fCPKAKFLFEG = new FCPKAKFLFEG();
		fCPKAKFLFEG.IOCMOCCFALN = LLIEHCKNJEM.name;
		fCPKAKFLFEG.EHJNMODJEAN = -1;
		fCPKAKFLFEG.BBMMCOJNJHE = false;
		Vector2 zero = Vector2.zero;
		Vector2 vector = new Vector2(num, num2) * HJLOCAEAFMJ;
		fCPKAKFLFEG.HHHMOGOKFHF = (int)num;
		fCPKAKFLFEG.OMHIBPLGBME = (int)num;
		fCPKAKFLFEG.JKNPBEOPMPK = (int)num2;
		fCPKAKFLFEG.JMEGIPJIGMK = (int)num2;
		fCPKAKFLFEG.MLKPDGNHNAE = num * (0.5f - HPPJAFEFFCO(zero.x, vector.x, 0f));
		fCPKAKFLFEG.INDIJOFPNGA = num2 * (0.5f - HPPJAFEFFCO(zero.y, vector.y, 0f));
		fCPKAKFLFEG.OJOAGEHFPNP = 0f;
		fCPKAKFLFEG.AAIEJDNAODP = 1f;
		fCPKAKFLFEG.ECKFKMJFOCI = 1f;
		fCPKAKFLFEG.OFFFLJCPAJE = 0f;
		fCPKAKFLFEG.AMFCENFNAJJ = 0;
		fCPKAKFLFEG.CNLILOEEBOJ = 0;
		fCPKAKFLFEG.CPIKPMLODAK = cPIKPMLODAK;
		return fCPKAKFLFEG;
	}

	public static FCPKAKFLFEG JOEMHKMEGJF(this Texture2D LLIEHCKNJEM, Material DMOJCHBFADP, TextureFormat MLLDGOCKHPL = TextureFormat.RGBA32, bool AOGOEMOPFKJ = false)
	{
		return LLIEHCKNJEM.JOEMHKMEGJF(DMOJCHBFADP.shader, MLLDGOCKHPL, AOGOEMOPFKJ, DMOJCHBFADP);
	}

	public static FCPKAKFLFEG JOEMHKMEGJF(this Texture2D LLIEHCKNJEM, Shader BLCFLFHNKFG, TextureFormat MLLDGOCKHPL = TextureFormat.RGBA32, bool AOGOEMOPFKJ = false, Material DMOJCHBFADP = null)
	{
		Material material = new Material(BLCFLFHNKFG);
		if (DMOJCHBFADP != null)
		{
			material.CopyPropertiesFromMaterial(DMOJCHBFADP);
			material.shaderKeywords = DMOJCHBFADP.shaderKeywords;
		}
		Texture2D texture2D = LLIEHCKNJEM.BNKOCCCOFMO(false, MLLDGOCKHPL, AOGOEMOPFKJ);
		texture2D.LLGDNHGILCK();
		texture2D.name = LLIEHCKNJEM.name + "-pma-";
		material.name = LLIEHCKNJEM.name + BLCFLFHNKFG.name;
		material.mainTexture = texture2D;
		LLLHGJNHPML cPIKPMLODAK = material.PAOAGJDAHME();
		FCPKAKFLFEG fCPKAKFLFEG = texture2D.PKGKHHABACE(BLCFLFHNKFG);
		fCPKAKFLFEG.CPIKPMLODAK = cPIKPMLODAK;
		return fCPKAKFLFEG;
	}

	public static LLLHGJNHPML PAOAGJDAHME(this Material CEKMAJAHNAG)
	{
		LLLHGJNHPML lLLHGJNHPML = new LLLHGJNHPML();
		lLLHGJNHPML.FDCGLBIAFPB = CEKMAJAHNAG;
		lLLHGJNHPML.IOCMOCCFALN = CEKMAJAHNAG.name;
		LLLHGJNHPML lLLHGJNHPML2 = lLLHGJNHPML;
		Texture mainTexture = CEKMAJAHNAG.mainTexture;
		if (mainTexture != null)
		{
			lLLHGJNHPML2.HHHMOGOKFHF = mainTexture.width;
			lLLHGJNHPML2.JKNPBEOPMPK = mainTexture.height;
		}
		return lLLHGJNHPML2;
	}

	public static FCPKAKFLFEG PKGKHHABACE(this Sprite IBBBMACIBGK, LLLHGJNHPML CPIKPMLODAK)
	{
		if (CPIKPMLODAK == null)
		{
			throw new ArgumentNullException("page", "page cannot be null. AtlasPage determines which texture region belongs and how it should be rendered. You can use material.ToSpineAtlasPage() to get a shareable AtlasPage from a Material, or use the sprite.ToAtlasRegion(material) overload.");
		}
		FCPKAKFLFEG fCPKAKFLFEG = IBBBMACIBGK.PKGKHHABACE();
		fCPKAKFLFEG.CPIKPMLODAK = CPIKPMLODAK;
		return fCPKAKFLFEG;
	}

	public static FCPKAKFLFEG PKGKHHABACE(this Sprite IBBBMACIBGK, Material GHPFOPNNJOB)
	{
		FCPKAKFLFEG fCPKAKFLFEG = IBBBMACIBGK.PKGKHHABACE();
		fCPKAKFLFEG.CPIKPMLODAK = GHPFOPNNJOB.PAOAGJDAHME();
		return fCPKAKFLFEG;
	}

	public static FCPKAKFLFEG JOEMHKMEGJF(this Sprite IBBBMACIBGK, Shader BLCFLFHNKFG, TextureFormat MLLDGOCKHPL = TextureFormat.RGBA32, bool AOGOEMOPFKJ = false, Material DMOJCHBFADP = null)
	{
		Material material = new Material(BLCFLFHNKFG);
		if (DMOJCHBFADP != null)
		{
			material.CopyPropertiesFromMaterial(DMOJCHBFADP);
			material.shaderKeywords = DMOJCHBFADP.shaderKeywords;
		}
		Texture2D texture2D = IBBBMACIBGK.ICNBBEIMJDP(false, MLLDGOCKHPL, AOGOEMOPFKJ);
		texture2D.LLGDNHGILCK();
		texture2D.name = IBBBMACIBGK.name + "-pma-";
		material.name = texture2D.name + BLCFLFHNKFG.name;
		material.mainTexture = texture2D;
		LLLHGJNHPML cPIKPMLODAK = material.PAOAGJDAHME();
		FCPKAKFLFEG fCPKAKFLFEG = IBBBMACIBGK.PKGKHHABACE(true);
		fCPKAKFLFEG.CPIKPMLODAK = cPIKPMLODAK;
		return fCPKAKFLFEG;
	}

	public static FCPKAKFLFEG JOEMHKMEGJF(this Sprite IBBBMACIBGK, Material DMOJCHBFADP, TextureFormat MLLDGOCKHPL = TextureFormat.RGBA32, bool AOGOEMOPFKJ = false)
	{
		return IBBBMACIBGK.JOEMHKMEGJF(DMOJCHBFADP.shader, MLLDGOCKHPL, AOGOEMOPFKJ, DMOJCHBFADP);
	}

	internal static FCPKAKFLFEG PKGKHHABACE(this Sprite IBBBMACIBGK, bool KGNLHJDDEBF = false)
	{
		FCPKAKFLFEG fCPKAKFLFEG = new FCPKAKFLFEG();
		fCPKAKFLFEG.IOCMOCCFALN = IBBBMACIBGK.name;
		fCPKAKFLFEG.EHJNMODJEAN = -1;
		fCPKAKFLFEG.BBMMCOJNJHE = IBBBMACIBGK.packed && IBBBMACIBGK.packingRotation != SpritePackingRotation.None;
		Bounds bounds = IBBBMACIBGK.bounds;
		Vector2 vector = bounds.min;
		Vector2 vector2 = bounds.max;
		Rect rect = IBBBMACIBGK.rect.MCOBKLLDCOL(IBBBMACIBGK.texture.height);
		fCPKAKFLFEG.HHHMOGOKFHF = (int)rect.width;
		fCPKAKFLFEG.OMHIBPLGBME = (int)rect.width;
		fCPKAKFLFEG.JKNPBEOPMPK = (int)rect.height;
		fCPKAKFLFEG.JMEGIPJIGMK = (int)rect.height;
		fCPKAKFLFEG.MLKPDGNHNAE = rect.width * (0.5f - HPPJAFEFFCO(vector.x, vector2.x, 0f));
		fCPKAKFLFEG.INDIJOFPNGA = rect.height * (0.5f - HPPJAFEFFCO(vector.y, vector2.y, 0f));
		if (KGNLHJDDEBF)
		{
			fCPKAKFLFEG.OJOAGEHFPNP = 0f;
			fCPKAKFLFEG.AAIEJDNAODP = 1f;
			fCPKAKFLFEG.ECKFKMJFOCI = 1f;
			fCPKAKFLFEG.OFFFLJCPAJE = 0f;
			fCPKAKFLFEG.AMFCENFNAJJ = 0;
			fCPKAKFLFEG.CNLILOEEBOJ = 0;
		}
		else
		{
			Texture2D texture = IBBBMACIBGK.texture;
			Rect rect2 = BPEKKGBFHJO(IBBBMACIBGK.textureRect, texture.width, texture.height);
			fCPKAKFLFEG.OJOAGEHFPNP = rect2.xMin;
			fCPKAKFLFEG.AAIEJDNAODP = rect2.yMax;
			fCPKAKFLFEG.ECKFKMJFOCI = rect2.xMax;
			fCPKAKFLFEG.OFFFLJCPAJE = rect2.yMin;
			fCPKAKFLFEG.AMFCENFNAJJ = (int)rect.x;
			fCPKAKFLFEG.CNLILOEEBOJ = (int)rect.y;
		}
		return fCPKAKFLFEG;
	}

	public static void KILLBLCKBND(List<OAMNGFLKEFI> EEPJHLKPCAP, List<OAMNGFLKEFI> GMHABJHBOBP, Material DMOJCHBFADP, out Material FEDGBIODGPI, out Texture2D JCIPEOPNCJL, int MHDHOLLELFA = 1024, int HFHKPBBFDFD = 2, TextureFormat MLLDGOCKHPL = TextureFormat.RGBA32, bool AOGOEMOPFKJ = false, string LNNKFCDONFP = "Repacked Attachments", bool OIFBDFFEFKJ = false)
	{
		if (EEPJHLKPCAP == null)
		{
			throw new ArgumentNullException("sourceAttachments");
		}
		if (GMHABJHBOBP == null)
		{
			throw new ArgumentNullException("outputAttachments");
		}
		Dictionary<FCPKAKFLFEG, int> dictionary = new Dictionary<FCPKAKFLFEG, int>();
		List<int> list = new List<int>();
		List<Texture2D> list2 = new List<Texture2D>();
		List<FCPKAKFLFEG> list3 = new List<FCPKAKFLFEG>();
		GMHABJHBOBP.Clear();
		GMHABJHBOBP.AddRange(EEPJHLKPCAP);
		int num = 0;
		int i = 0;
		for (int count = EEPJHLKPCAP.Count; i < count; i++)
		{
			OAMNGFLKEFI aACCPLMFDIE = EEPJHLKPCAP[i];
			OAMNGFLKEFI oAMNGFLKEFI = aACCPLMFDIE.BNKOCCCOFMO(true);
			if (CJMIFJDBPFB(oAMNGFLKEFI))
			{
				FCPKAKFLFEG fCPKAKFLFEG = oAMNGFLKEFI.NHFGAPCPPJP();
				int value;
				if (dictionary.TryGetValue(fCPKAKFLFEG, out value))
				{
					list.Add(value);
				}
				else
				{
					list3.Add(fCPKAKFLFEG);
					list2.Add(fCPKAKFLFEG.ICNBBEIMJDP());
					dictionary.Add(fCPKAKFLFEG, num);
					list.Add(num);
					num++;
				}
				GMHABJHBOBP[i] = oAMNGFLKEFI;
			}
		}
		Texture2D texture2D = new Texture2D(MHDHOLLELFA, MHDHOLLELFA, MLLDGOCKHPL, AOGOEMOPFKJ);
		texture2D.mipMapBias = -0.5f;
		texture2D.anisoLevel = list2[0].anisoLevel;
		texture2D.name = LNNKFCDONFP;
		Rect[] array = texture2D.PackTextures(list2.ToArray(), HFHKPBBFDFD, MHDHOLLELFA);
		Shader shader = ((!(DMOJCHBFADP == null)) ? DMOJCHBFADP.shader : Shader.Find("Spine/Skeleton"));
		Material material = new Material(shader);
		if (DMOJCHBFADP != null)
		{
			material.CopyPropertiesFromMaterial(DMOJCHBFADP);
			material.shaderKeywords = DMOJCHBFADP.shaderKeywords;
		}
		material.name = LNNKFCDONFP;
		material.mainTexture = texture2D;
		LLLHGJNHPML lLLHGJNHPML = material.PAOAGJDAHME();
		lLLHGJNHPML.IOCMOCCFALN = LNNKFCDONFP;
		List<FCPKAKFLFEG> list4 = new List<FCPKAKFLFEG>();
		int j = 0;
		for (int count2 = list3.Count; j < count2; j++)
		{
			FCPKAKFLFEG fCPKAKFLFEG2 = list3[j];
			FCPKAKFLFEG item = KFBDBGLOENK(array[j], fCPKAKFLFEG2.IOCMOCCFALN, lLLHGJNHPML, fCPKAKFLFEG2.MLKPDGNHNAE, fCPKAKFLFEG2.INDIJOFPNGA, fCPKAKFLFEG2.BBMMCOJNJHE);
			list4.Add(item);
		}
		int k = 0;
		for (int count3 = GMHABJHBOBP.Count; k < count3; k++)
		{
			OAMNGFLKEFI dFHHMKMLCFF = GMHABJHBOBP[k];
			dFHHMKMLCFF.HJJKKGEMFOM(list4[list[k]]);
		}
		if (OIFBDFFEFKJ)
		{
			OIOPIEFFMFM();
		}
		JCIPEOPNCJL = texture2D;
		FEDGBIODGPI = material;
	}

	public static JPAALKCPGNB LHDKBMLCILA(this JPAALKCPGNB AACCPLMFDIE, string GNLHNMLIEFN, Material DMOJCHBFADP, out Material FEDGBIODGPI, out Texture2D JCIPEOPNCJL, int MHDHOLLELFA = 1024, int HFHKPBBFDFD = 2, TextureFormat MLLDGOCKHPL = TextureFormat.RGBA32, bool AOGOEMOPFKJ = false)
	{
		return AACCPLMFDIE.LHDKBMLCILA(GNLHNMLIEFN, DMOJCHBFADP.shader, out FEDGBIODGPI, out JCIPEOPNCJL, MHDHOLLELFA, HFHKPBBFDFD, MLLDGOCKHPL, AOGOEMOPFKJ, DMOJCHBFADP);
	}

	public static JPAALKCPGNB LHDKBMLCILA(this JPAALKCPGNB AACCPLMFDIE, string GNLHNMLIEFN, Shader BLCFLFHNKFG, out Material FEDGBIODGPI, out Texture2D JCIPEOPNCJL, int MHDHOLLELFA = 1024, int HFHKPBBFDFD = 2, TextureFormat MLLDGOCKHPL = TextureFormat.RGBA32, bool AOGOEMOPFKJ = false, Material DMOJCHBFADP = null, bool OIFBDFFEFKJ = false)
	{
		Dictionary<JPAALKCPGNB.CNCHOJOHBLN, OAMNGFLKEFI> dictionary = AACCPLMFDIE.NLADLMOLKLK;
		JPAALKCPGNB jPAALKCPGNB = new JPAALKCPGNB(GNLHNMLIEFN);
		Dictionary<FCPKAKFLFEG, int> dictionary2 = new Dictionary<FCPKAKFLFEG, int>();
		List<int> list = new List<int>();
		List<OAMNGFLKEFI> list2 = new List<OAMNGFLKEFI>();
		List<Texture2D> list3 = new List<Texture2D>();
		List<FCPKAKFLFEG> list4 = new List<FCPKAKFLFEG>();
		int num = 0;
		foreach (KeyValuePair<JPAALKCPGNB.CNCHOJOHBLN, OAMNGFLKEFI> item2 in dictionary)
		{
			OAMNGFLKEFI oAMNGFLKEFI = item2.Value.BNKOCCCOFMO(true);
			if (CJMIFJDBPFB(oAMNGFLKEFI))
			{
				FCPKAKFLFEG fCPKAKFLFEG = oAMNGFLKEFI.NHFGAPCPPJP();
				int value;
				if (dictionary2.TryGetValue(fCPKAKFLFEG, out value))
				{
					list.Add(value);
				}
				else
				{
					list4.Add(fCPKAKFLFEG);
					list3.Add(fCPKAKFLFEG.ICNBBEIMJDP());
					dictionary2.Add(fCPKAKFLFEG, num);
					list.Add(num);
					num++;
				}
				list2.Add(oAMNGFLKEFI);
			}
			JPAALKCPGNB.CNCHOJOHBLN key = item2.Key;
			jPAALKCPGNB.DJJIHPJOEBF(key.PBPEMFGPGFC, key.IOCMOCCFALN, oAMNGFLKEFI);
		}
		Texture2D texture2D = new Texture2D(MHDHOLLELFA, MHDHOLLELFA, MLLDGOCKHPL, AOGOEMOPFKJ);
		texture2D.mipMapBias = -0.5f;
		texture2D.anisoLevel = list3[0].anisoLevel;
		texture2D.name = GNLHNMLIEFN;
		Rect[] array = texture2D.PackTextures(list3.ToArray(), HFHKPBBFDFD, MHDHOLLELFA);
		Material material = new Material(BLCFLFHNKFG);
		if (DMOJCHBFADP != null)
		{
			material.CopyPropertiesFromMaterial(DMOJCHBFADP);
			material.shaderKeywords = DMOJCHBFADP.shaderKeywords;
		}
		material.name = GNLHNMLIEFN;
		material.mainTexture = texture2D;
		LLLHGJNHPML lLLHGJNHPML = material.PAOAGJDAHME();
		lLLHGJNHPML.IOCMOCCFALN = GNLHNMLIEFN;
		List<FCPKAKFLFEG> list5 = new List<FCPKAKFLFEG>();
		int i = 0;
		for (int count = list4.Count; i < count; i++)
		{
			FCPKAKFLFEG fCPKAKFLFEG2 = list4[i];
			FCPKAKFLFEG item = KFBDBGLOENK(array[i], fCPKAKFLFEG2.IOCMOCCFALN, lLLHGJNHPML, fCPKAKFLFEG2.MLKPDGNHNAE, fCPKAKFLFEG2.INDIJOFPNGA, fCPKAKFLFEG2.BBMMCOJNJHE);
			list5.Add(item);
		}
		int j = 0;
		for (int count2 = list2.Count; j < count2; j++)
		{
			OAMNGFLKEFI dFHHMKMLCFF = list2[j];
			dFHHMKMLCFF.HJJKKGEMFOM(list5[list[j]]);
		}
		if (OIFBDFFEFKJ)
		{
			OIOPIEFFMFM();
		}
		JCIPEOPNCJL = texture2D;
		FEDGBIODGPI = material;
		return jPAALKCPGNB;
	}

	public static Sprite HDFANJBMLOF(this FCPKAKFLFEG IJFNOIFFPOH, float IGMBAPEBFBJ = 100f)
	{
		return Sprite.Create(IJFNOIFFPOH.JKIEDOJMPCP(), IJFNOIFFPOH.EDJGMKJPDIA(), new Vector2(0.5f, 0.5f), IGMBAPEBFBJ);
	}

	public static void OIOPIEFFMFM()
	{
		foreach (Texture2D item in HAMNDDKKIEH)
		{
			UnityEngine.Object.Destroy(item);
		}
		EIIIOPEPMCC.Clear();
		HAMNDDKKIEH.Clear();
	}

	public static Texture2D ICNBBEIMJDP(this FCPKAKFLFEG IJFNOIFFPOH, bool DDAEBEPJFFP = true, TextureFormat MLLDGOCKHPL = TextureFormat.RGBA32, bool AOGOEMOPFKJ = false)
	{
		Texture2D value;
		EIIIOPEPMCC.TryGetValue(IJFNOIFFPOH, out value);
		if (value == null)
		{
			Texture2D texture2D = IJFNOIFFPOH.JKIEDOJMPCP();
			Rect rect = IJFNOIFFPOH.EDJGMKJPDIA(texture2D.height);
			int num = (int)rect.width;
			int num2 = (int)rect.height;
			value = new Texture2D(num, num2, MLLDGOCKHPL, AOGOEMOPFKJ);
			value.name = IJFNOIFFPOH.IOCMOCCFALN;
			Color[] pixels = texture2D.GetPixels((int)rect.x, (int)rect.y, num, num2);
			value.SetPixels(pixels);
			EIIIOPEPMCC.Add(IJFNOIFFPOH, value);
			HAMNDDKKIEH.Add(value);
			if (DDAEBEPJFFP)
			{
				value.Apply();
			}
		}
		return value;
	}

	private static Texture2D ICNBBEIMJDP(this Sprite IBBBMACIBGK, bool DDAEBEPJFFP = true, TextureFormat MLLDGOCKHPL = TextureFormat.RGBA32, bool AOGOEMOPFKJ = false)
	{
		Texture2D texture = IBBBMACIBGK.texture;
		Rect textureRect = IBBBMACIBGK.textureRect;
		Color[] pixels = texture.GetPixels((int)textureRect.x, (int)textureRect.y, (int)textureRect.width, (int)textureRect.height);
		Texture2D texture2D = new Texture2D((int)textureRect.width, (int)textureRect.height, MLLDGOCKHPL, AOGOEMOPFKJ);
		texture2D.SetPixels(pixels);
		if (DDAEBEPJFFP)
		{
			texture2D.Apply();
		}
		return texture2D;
	}

	private static Texture2D BNKOCCCOFMO(this Texture2D LLIEHCKNJEM, bool DDAEBEPJFFP = true, TextureFormat MLLDGOCKHPL = TextureFormat.RGBA32, bool AOGOEMOPFKJ = false)
	{
		Color[] pixels = LLIEHCKNJEM.GetPixels(0, 0, LLIEHCKNJEM.width, LLIEHCKNJEM.height);
		Texture2D texture2D = new Texture2D(LLIEHCKNJEM.width, LLIEHCKNJEM.height, MLLDGOCKHPL, AOGOEMOPFKJ);
		texture2D.SetPixels(pixels);
		if (DDAEBEPJFFP)
		{
			texture2D.Apply();
		}
		return texture2D;
	}

	private static bool CJMIFJDBPFB(OAMNGFLKEFI MNIMEAMHNMI)
	{
		return MNIMEAMHNMI is MKEALIMJCFJ || MNIMEAMHNMI is MGCLDKAFCIB;
	}

	private static Rect MCOBKLLDCOL(this Rect JIBDHLJBMPG, int ONAFEMGJMNO)
	{
		JIBDHLJBMPG.y = (float)ONAFEMGJMNO - JIBDHLJBMPG.y - JIBDHLJBMPG.height;
		return JIBDHLJBMPG;
	}

	private static Rect EDJGMKJPDIA(this FCPKAKFLFEG PMKKIEFBKAK)
	{
		return PMKKIEFBKAK.FICOFEOALPD().MCOBKLLDCOL(PMKKIEFBKAK.CPIKPMLODAK.JKNPBEOPMPK);
	}

	private static Rect EDJGMKJPDIA(this FCPKAKFLFEG PMKKIEFBKAK, int ONAFEMGJMNO)
	{
		return PMKKIEFBKAK.FICOFEOALPD().MCOBKLLDCOL(ONAFEMGJMNO);
	}

	private static Rect FICOFEOALPD(this FCPKAKFLFEG PMKKIEFBKAK, bool CDFGCICINEO = true)
	{
		if (CDFGCICINEO && PMKKIEFBKAK.BBMMCOJNJHE)
		{
			return new Rect(PMKKIEFBKAK.AMFCENFNAJJ, PMKKIEFBKAK.CNLILOEEBOJ, PMKKIEFBKAK.JKNPBEOPMPK, PMKKIEFBKAK.HHHMOGOKFHF);
		}
		return new Rect(PMKKIEFBKAK.AMFCENFNAJJ, PMKKIEFBKAK.CNLILOEEBOJ, PMKKIEFBKAK.HHHMOGOKFHF, PMKKIEFBKAK.JKNPBEOPMPK);
	}

	private static Rect MHKPJHCCNPD(Rect NCNNIOCHFNC, int HLFOAMBJMDA, int MLFGKIENFJC)
	{
		NCNNIOCHFNC.x *= HLFOAMBJMDA;
		NCNNIOCHFNC.width *= HLFOAMBJMDA;
		NCNNIOCHFNC.y *= MLFGKIENFJC;
		NCNNIOCHFNC.height *= MLFGKIENFJC;
		return NCNNIOCHFNC;
	}

	private static Rect BPEKKGBFHJO(Rect OHCCELEGJMF, int HLFOAMBJMDA, int MLFGKIENFJC)
	{
		OHCCELEGJMF.x = Mathf.InverseLerp(0f, HLFOAMBJMDA, OHCCELEGJMF.x);
		OHCCELEGJMF.y = Mathf.InverseLerp(0f, MLFGKIENFJC, OHCCELEGJMF.y);
		OHCCELEGJMF.width = Mathf.InverseLerp(0f, HLFOAMBJMDA, OHCCELEGJMF.width);
		OHCCELEGJMF.height = Mathf.InverseLerp(0f, MLFGKIENFJC, OHCCELEGJMF.height);
		return OHCCELEGJMF;
	}

	private static FCPKAKFLFEG KFBDBGLOENK(Rect NCNNIOCHFNC, string IOCMOCCFALN, LLLHGJNHPML CPIKPMLODAK, float MLKPDGNHNAE, float INDIJOFPNGA, bool BBMMCOJNJHE)
	{
		Rect jIBDHLJBMPG = MHKPJHCCNPD(NCNNIOCHFNC, CPIKPMLODAK.HHHMOGOKFHF, CPIKPMLODAK.JKNPBEOPMPK);
		Rect rect = jIBDHLJBMPG.MCOBKLLDCOL(CPIKPMLODAK.JKNPBEOPMPK);
		int aMFCENFNAJJ = (int)rect.x;
		int cNLILOEEBOJ = (int)rect.y;
		int num;
		int num2;
		if (BBMMCOJNJHE)
		{
			num = (int)rect.height;
			num2 = (int)rect.width;
		}
		else
		{
			num = (int)rect.width;
			num2 = (int)rect.height;
		}
		FCPKAKFLFEG fCPKAKFLFEG = new FCPKAKFLFEG();
		fCPKAKFLFEG.CPIKPMLODAK = CPIKPMLODAK;
		fCPKAKFLFEG.IOCMOCCFALN = IOCMOCCFALN;
		fCPKAKFLFEG.OJOAGEHFPNP = NCNNIOCHFNC.xMin;
		fCPKAKFLFEG.ECKFKMJFOCI = NCNNIOCHFNC.xMax;
		fCPKAKFLFEG.AAIEJDNAODP = NCNNIOCHFNC.yMax;
		fCPKAKFLFEG.OFFFLJCPAJE = NCNNIOCHFNC.yMin;
		fCPKAKFLFEG.EHJNMODJEAN = -1;
		fCPKAKFLFEG.HHHMOGOKFHF = num;
		fCPKAKFLFEG.OMHIBPLGBME = num;
		fCPKAKFLFEG.JKNPBEOPMPK = num2;
		fCPKAKFLFEG.JMEGIPJIGMK = num2;
		fCPKAKFLFEG.MLKPDGNHNAE = MLKPDGNHNAE;
		fCPKAKFLFEG.INDIJOFPNGA = INDIJOFPNGA;
		fCPKAKFLFEG.AMFCENFNAJJ = aMFCENFNAJJ;
		fCPKAKFLFEG.CNLILOEEBOJ = cNLILOEEBOJ;
		fCPKAKFLFEG.BBMMCOJNJHE = BBMMCOJNJHE;
		return fCPKAKFLFEG;
	}

	private static FCPKAKFLFEG NHFGAPCPPJP(this OAMNGFLKEFI MNIMEAMHNMI)
	{
		MKEALIMJCFJ mKEALIMJCFJ = MNIMEAMHNMI as MKEALIMJCFJ;
		if (mKEALIMJCFJ != null)
		{
			return mKEALIMJCFJ.HIPOEPNPBPO as FCPKAKFLFEG;
		}
		MGCLDKAFCIB mGCLDKAFCIB = MNIMEAMHNMI as MGCLDKAFCIB;
		if (mGCLDKAFCIB != null)
		{
			return mGCLDKAFCIB.HIPOEPNPBPO as FCPKAKFLFEG;
		}
		return null;
	}

	private static Texture2D JKIEDOJMPCP(this FCPKAKFLFEG PMKKIEFBKAK)
	{
		Material material = PMKKIEFBKAK.CPIKPMLODAK.FDCGLBIAFPB as Material;
		return material.mainTexture as Texture2D;
	}

	private static void LLGDNHGILCK(this Texture2D CGIOFLEGCHD, bool DDAEBEPJFFP = true)
	{
		Color[] pixels = CGIOFLEGCHD.GetPixels();
		int i = 0;
		for (int num = pixels.Length; i < num; i++)
		{
			Color color = pixels[i];
			float a = color.a;
			color.r *= a;
			color.g *= a;
			color.b *= a;
			pixels[i] = color;
		}
		CGIOFLEGCHD.SetPixels(pixels);
		if (DDAEBEPJFFP)
		{
			CGIOFLEGCHD.Apply();
		}
	}

	private static float HPPJAFEFFCO(float MNIMEAMHNMI, float BCIHLCMFAEK, float EDDNOJDPMCF)
	{
		return (EDDNOJDPMCF - MNIMEAMHNMI) / (BCIHLCMFAEK - MNIMEAMHNMI);
	}
}
