using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public static class HPENNIOPLFI
{
	private class JHAHOCCBDBN
	{
		public int LHLKMONNIKI;

		public Material NGHPJNNBAHP;

		public long JLCMHJJOJDF;

		public Material PDKNCECBLAJ;

		public int ENMLICFLHAO;
	}

	private class HMOCDOANDMK
	{
		public Material NGHPJNNBAHP;

		public Material OOPABMMCFKM;

		public int ENMLICFLHAO;

		public int LKPCAONFPPB;
	}

	[CompilerGenerated]
	private sealed class ONJLLPFGPFK
	{
		internal Material OOPABMMCFKM;

		internal bool AGFNGEFDHLA(HMOCDOANDMK EJCNAJOHBFI)
		{
			return EJCNAJOHBFI.OOPABMMCFKM == OOPABMMCFKM;
		}
	}

	[CompilerGenerated]
	private sealed class CFCJFDCNOML
	{
		internal Material OOPABMMCFKM;

		internal bool AGFNGEFDHLA(HMOCDOANDMK EJCNAJOHBFI)
		{
			return EJCNAJOHBFI.OOPABMMCFKM == OOPABMMCFKM;
		}
	}

	[CompilerGenerated]
	private sealed class MAPIGEKBGID
	{
		internal Material OOPABMMCFKM;

		internal bool AGFNGEFDHLA(HMOCDOANDMK EJCNAJOHBFI)
		{
			return EJCNAJOHBFI.OOPABMMCFKM == OOPABMMCFKM;
		}
	}

	[CompilerGenerated]
	private sealed class KDOEGEFDIJE
	{
		internal Material NGHPJNNBAHP;

		internal bool AGFNGEFDHLA(HMOCDOANDMK EJCNAJOHBFI)
		{
			return EJCNAJOHBFI.NGHPJNNBAHP == NGHPJNNBAHP;
		}
	}

	private static List<HMOCDOANDMK> HIMNOABEJHC;

	private static Dictionary<long, JHAHOCCBDBN> FHMGHHINOFH;

	private static Dictionary<int, long> PCCDJDGKFBJ;

	private static List<JHAHOCCBDBN> NPBGAPCACLI;

	private static bool EJMEFGHFFFG;

	static HPENNIOPLFI()
	{
		HIMNOABEJHC = new List<HMOCDOANDMK>();
		FHMGHHINOFH = new Dictionary<long, JHAHOCCBDBN>();
		PCCDJDGKFBJ = new Dictionary<int, long>();
		NPBGAPCACLI = new List<JHAHOCCBDBN>();
		Camera.onPreRender = (Camera.CameraCallback)Delegate.Combine(Camera.onPreRender, new Camera.CameraCallback(OLNNEOOOOOE));
		Canvas.willRenderCanvases += LHMMLLDIHMN;
	}

	private static void OLNNEOOOOOE(Camera GAPLNBLGDPC)
	{
		if (EJMEFGHFFFG)
		{
			CDKIDPGKAPE();
			EJMEFGHFFFG = false;
		}
	}

	private static void LHMMLLDIHMN()
	{
		if (EJMEFGHFFFG)
		{
			CDKIDPGKAPE();
			EJMEFGHFFFG = false;
		}
	}

	public static Material HJNELAFHOND(Material NGHPJNNBAHP, int LKPCAONFPPB)
	{
		if (!NGHPJNNBAHP.HasProperty(MOHPNOBPBBL.FGLCEENBMMC))
		{
			Debug.LogWarning("Selected Shader does not support Stencil Masking. Please select the Distance Field or Mobile Distance Field Shader.");
			return NGHPJNNBAHP;
		}
		int instanceID = NGHPJNNBAHP.GetInstanceID();
		for (int i = 0; i < HIMNOABEJHC.Count; i++)
		{
			if (HIMNOABEJHC[i].NGHPJNNBAHP.GetInstanceID() == instanceID && HIMNOABEJHC[i].LKPCAONFPPB == LKPCAONFPPB)
			{
				HIMNOABEJHC[i].ENMLICFLHAO++;
				return HIMNOABEJHC[i].OOPABMMCFKM;
			}
		}
		Material material = new Material(NGHPJNNBAHP);
		material.hideFlags = HideFlags.HideAndDontSave;
		material.shaderKeywords = NGHPJNNBAHP.shaderKeywords;
		MOHPNOBPBBL.LNNKOOPFJON();
		material.SetFloat(MOHPNOBPBBL.FGLCEENBMMC, LKPCAONFPPB);
		material.SetFloat(MOHPNOBPBBL.EBKPBDBFNHL, 4f);
		HMOCDOANDMK hMOCDOANDMK = new HMOCDOANDMK();
		hMOCDOANDMK.NGHPJNNBAHP = NGHPJNNBAHP;
		hMOCDOANDMK.OOPABMMCFKM = material;
		hMOCDOANDMK.LKPCAONFPPB = LKPCAONFPPB;
		hMOCDOANDMK.ENMLICFLHAO = 1;
		HIMNOABEJHC.Add(hMOCDOANDMK);
		return material;
	}

	public static void PEENDKMJMPN(Material OOPABMMCFKM)
	{
		int instanceID = OOPABMMCFKM.GetInstanceID();
		for (int i = 0; i < HIMNOABEJHC.Count; i++)
		{
			if (HIMNOABEJHC[i].OOPABMMCFKM.GetInstanceID() == instanceID)
			{
				if (HIMNOABEJHC[i].ENMLICFLHAO > 1)
				{
					HIMNOABEJHC[i].ENMLICFLHAO--;
					break;
				}
				UnityEngine.Object.DestroyImmediate(HIMNOABEJHC[i].OOPABMMCFKM);
				HIMNOABEJHC.RemoveAt(i);
				OOPABMMCFKM = null;
				break;
			}
		}
	}

	public static Material MBDDFFFLBFL(Material OOPABMMCFKM)
	{
		int num = HIMNOABEJHC.FindIndex((HMOCDOANDMK EJCNAJOHBFI) => EJCNAJOHBFI.OOPABMMCFKM == OOPABMMCFKM);
		if (num == -1)
		{
			return null;
		}
		return HIMNOABEJHC[num].NGHPJNNBAHP;
	}

	public static Material NNALFICEMPH(Material GHPFOPNNJOB, int LKPCAONFPPB)
	{
		GHPFOPNNJOB.SetFloat(MOHPNOBPBBL.FGLCEENBMMC, LKPCAONFPPB);
		if (LKPCAONFPPB == 0)
		{
			GHPFOPNNJOB.SetFloat(MOHPNOBPBBL.EBKPBDBFNHL, 8f);
		}
		else
		{
			GHPFOPNNJOB.SetFloat(MOHPNOBPBBL.EBKPBDBFNHL, 4f);
		}
		return GHPFOPNNJOB;
	}

	public static void ENCIFEDPNPI(Material NGHPJNNBAHP, Material OOPABMMCFKM, int LKPCAONFPPB)
	{
		int num = HIMNOABEJHC.FindIndex((HMOCDOANDMK EJCNAJOHBFI) => EJCNAJOHBFI.OOPABMMCFKM == OOPABMMCFKM);
		if (num == -1)
		{
			HMOCDOANDMK hMOCDOANDMK = new HMOCDOANDMK();
			hMOCDOANDMK.NGHPJNNBAHP = NGHPJNNBAHP;
			hMOCDOANDMK.OOPABMMCFKM = OOPABMMCFKM;
			hMOCDOANDMK.LKPCAONFPPB = LKPCAONFPPB;
			hMOCDOANDMK.ENMLICFLHAO = 1;
			HIMNOABEJHC.Add(hMOCDOANDMK);
		}
		else
		{
			OOPABMMCFKM = HIMNOABEJHC[num].OOPABMMCFKM;
			HIMNOABEJHC[num].ENMLICFLHAO++;
		}
	}

	public static void FNGDJDBDIEJ(Material OOPABMMCFKM)
	{
		int num = HIMNOABEJHC.FindIndex((HMOCDOANDMK EJCNAJOHBFI) => EJCNAJOHBFI.OOPABMMCFKM == OOPABMMCFKM);
		if (num != -1)
		{
			HIMNOABEJHC.RemoveAt(num);
		}
	}

	public static void ENCODPENFIF(Material NGHPJNNBAHP)
	{
		int num = HIMNOABEJHC.FindIndex((HMOCDOANDMK EJCNAJOHBFI) => EJCNAJOHBFI.NGHPJNNBAHP == NGHPJNNBAHP);
		if (num == -1)
		{
			Debug.Log("No Masking Material exists for " + NGHPJNNBAHP.name);
		}
		else if (HIMNOABEJHC[num].ENMLICFLHAO > 1)
		{
			HIMNOABEJHC[num].ENMLICFLHAO--;
			Debug.Log("Removed (1) reference to " + HIMNOABEJHC[num].OOPABMMCFKM.name + ". There are " + HIMNOABEJHC[num].ENMLICFLHAO + " references left.");
		}
		else
		{
			Debug.Log("Removed last reference to " + HIMNOABEJHC[num].OOPABMMCFKM.name + " with ID " + HIMNOABEJHC[num].OOPABMMCFKM.GetInstanceID());
			UnityEngine.Object.DestroyImmediate(HIMNOABEJHC[num].OOPABMMCFKM);
			HIMNOABEJHC.RemoveAt(num);
		}
	}

	public static void EOBNIKHKPDO()
	{
		if (HIMNOABEJHC.Count == 0)
		{
			Debug.Log("Material List has already been cleared.");
			return;
		}
		for (int i = 0; i < HIMNOABEJHC.Count; i++)
		{
			Material oOPABMMCFKM = HIMNOABEJHC[i].OOPABMMCFKM;
			UnityEngine.Object.DestroyImmediate(oOPABMMCFKM);
			HIMNOABEJHC.RemoveAt(i);
		}
	}

	public static int IOMBBOBLCMK(GameObject NEMEKIOEOLC)
	{
		int num = 0;
		List<Mask> list = global::MNGOLNKCDBE<Mask>.GHBGCADFLFB();
		NEMEKIOEOLC.GetComponentsInParent(false, list);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].IsActive())
			{
				num++;
			}
		}
		global::MNGOLNKCDBE<Mask>.PNCNHFLJCIG(list);
		return Mathf.Min((1 << num) - 1, 255);
	}

	public static Material MFPJJEMDCGJ(Material NJIFHGPKPFH, Material DHODAMEHKFD)
	{
		int instanceID = NJIFHGPKPFH.GetInstanceID();
		Texture texture = DHODAMEHKFD.GetTexture(MOHPNOBPBBL.GKMMOOGJLHP);
		int instanceID2 = texture.GetInstanceID();
		long num = ((long)instanceID << 32) | (uint)instanceID2;
		JHAHOCCBDBN value;
		if (FHMGHHINOFH.TryGetValue(num, out value))
		{
			return value.PDKNCECBLAJ;
		}
		Material material = null;
		if (NJIFHGPKPFH.HasProperty(MOHPNOBPBBL.APPGFNEOBOF) && DHODAMEHKFD.HasProperty(MOHPNOBPBBL.APPGFNEOBOF))
		{
			material = new Material(NJIFHGPKPFH);
			material.hideFlags = HideFlags.HideAndDontSave;
			material.SetTexture(MOHPNOBPBBL.GKMMOOGJLHP, texture);
			material.SetFloat(MOHPNOBPBBL.APPGFNEOBOF, DHODAMEHKFD.GetFloat(MOHPNOBPBBL.APPGFNEOBOF));
			material.SetFloat(MOHPNOBPBBL.EBBPDFAEDND, DHODAMEHKFD.GetFloat(MOHPNOBPBBL.EBBPDFAEDND));
			material.SetFloat(MOHPNOBPBBL.BJKLDMNLFAO, DHODAMEHKFD.GetFloat(MOHPNOBPBBL.BJKLDMNLFAO));
			material.SetFloat(MOHPNOBPBBL.NJPHJKMLDDE, DHODAMEHKFD.GetFloat(MOHPNOBPBBL.NJPHJKMLDDE));
			material.SetFloat(MOHPNOBPBBL.MHJAEHJBPFN, DHODAMEHKFD.GetFloat(MOHPNOBPBBL.MHJAEHJBPFN));
		}
		else
		{
			material = new Material(DHODAMEHKFD);
		}
		value = new JHAHOCCBDBN();
		value.LHLKMONNIKI = instanceID;
		value.NGHPJNNBAHP = NJIFHGPKPFH;
		value.JLCMHJJOJDF = num;
		value.PDKNCECBLAJ = material;
		value.ENMLICFLHAO = 0;
		FHMGHHINOFH.Add(num, value);
		PCCDJDGKFBJ.Add(material.GetInstanceID(), num);
		return material;
	}

	public static void FOCNKHFDMIM(Material DHODAMEHKFD)
	{
		if (!(DHODAMEHKFD == null))
		{
			int instanceID = DHODAMEHKFD.GetInstanceID();
			long value;
			JHAHOCCBDBN value2;
			if (PCCDJDGKFBJ.TryGetValue(instanceID, out value) && FHMGHHINOFH.TryGetValue(value, out value2))
			{
				value2.ENMLICFLHAO++;
			}
		}
	}

	public static void KHBMEKLNJDD(Material DHODAMEHKFD)
	{
		if (DHODAMEHKFD == null)
		{
			return;
		}
		int instanceID = DHODAMEHKFD.GetInstanceID();
		long value;
		JHAHOCCBDBN value2;
		if (PCCDJDGKFBJ.TryGetValue(instanceID, out value) && FHMGHHINOFH.TryGetValue(value, out value2))
		{
			value2.ENMLICFLHAO--;
			if (value2.ENMLICFLHAO < 1)
			{
				NPBGAPCACLI.Add(value2);
			}
		}
	}

	public static void CDKIDPGKAPE()
	{
		if (NPBGAPCACLI.Count == 0)
		{
			return;
		}
		for (int i = 0; i < NPBGAPCACLI.Count; i++)
		{
			JHAHOCCBDBN jHAHOCCBDBN = NPBGAPCACLI[i];
			if (jHAHOCCBDBN.ENMLICFLHAO < 1)
			{
				Material pDKNCECBLAJ = jHAHOCCBDBN.PDKNCECBLAJ;
				FHMGHHINOFH.Remove(jHAHOCCBDBN.JLCMHJJOJDF);
				PCCDJDGKFBJ.Remove(pDKNCECBLAJ.GetInstanceID());
				UnityEngine.Object.DestroyImmediate(pDKNCECBLAJ);
				pDKNCECBLAJ = null;
			}
		}
		NPBGAPCACLI.Clear();
	}

	public static void KLMFHLDMKJF(Material KBEKHGJJNPK)
	{
		if (KBEKHGJJNPK == null)
		{
			return;
		}
		int instanceID = KBEKHGJJNPK.GetInstanceID();
		long value;
		JHAHOCCBDBN value2;
		if (PCCDJDGKFBJ.TryGetValue(instanceID, out value) && FHMGHHINOFH.TryGetValue(value, out value2))
		{
			value2.ENMLICFLHAO--;
			if (value2.ENMLICFLHAO < 1)
			{
				NPBGAPCACLI.Add(value2);
			}
		}
		EJMEFGHFFFG = true;
	}

	public static void FGMMJFLGOBC(Material JKHLMLIANAI, Material IPPHCKILFOA)
	{
		if (JKHLMLIANAI.HasProperty(MOHPNOBPBBL.APPGFNEOBOF) && IPPHCKILFOA.HasProperty(MOHPNOBPBBL.APPGFNEOBOF))
		{
			Texture texture = IPPHCKILFOA.GetTexture(MOHPNOBPBBL.GKMMOOGJLHP);
			float @float = IPPHCKILFOA.GetFloat(MOHPNOBPBBL.APPGFNEOBOF);
			float float2 = IPPHCKILFOA.GetFloat(MOHPNOBPBBL.EBBPDFAEDND);
			float float3 = IPPHCKILFOA.GetFloat(MOHPNOBPBBL.BJKLDMNLFAO);
			float float4 = IPPHCKILFOA.GetFloat(MOHPNOBPBBL.NJPHJKMLDDE);
			float float5 = IPPHCKILFOA.GetFloat(MOHPNOBPBBL.MHJAEHJBPFN);
			IPPHCKILFOA.CopyPropertiesFromMaterial(JKHLMLIANAI);
			IPPHCKILFOA.shaderKeywords = JKHLMLIANAI.shaderKeywords;
			IPPHCKILFOA.SetTexture(MOHPNOBPBBL.GKMMOOGJLHP, texture);
			IPPHCKILFOA.SetFloat(MOHPNOBPBBL.APPGFNEOBOF, @float);
			IPPHCKILFOA.SetFloat(MOHPNOBPBBL.EBBPDFAEDND, float2);
			IPPHCKILFOA.SetFloat(MOHPNOBPBBL.BJKLDMNLFAO, float3);
			IPPHCKILFOA.SetFloat(MOHPNOBPBBL.NJPHJKMLDDE, float4);
			IPPHCKILFOA.SetFloat(MOHPNOBPBBL.MHJAEHJBPFN, float5);
		}
	}
}
