using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AKPCCCAJCLD
{
	private static AKPCCCAJCLD JGODGGLOOGM;

	private readonly List<TMP_Text> EIPHAIFEFHM = new List<TMP_Text>();

	private Dictionary<int, int> PEFHMAFMGII = new Dictionary<int, int>();

	private readonly List<TMP_Text> IEHDALJJNFO = new List<TMP_Text>();

	private Dictionary<int, int> NLFLOHKEPPA = new Dictionary<int, int>();

	public static AKPCCCAJCLD IACLMEKOOJO
	{
		get
		{
			if (JGODGGLOOGM == null)
			{
				JGODGGLOOGM = new AKPCCCAJCLD();
			}
			return JGODGGLOOGM;
		}
	}

	protected AKPCCCAJCLD()
	{
		Camera.onPreCull = (Camera.CameraCallback)Delegate.Combine(Camera.onPreCull, new Camera.CameraCallback(OCEJLCEJONL));
	}

	public static void LBDAPAMHFIM(TMP_Text KHLONKALNLL)
	{
		IACLMEKOOJO.ONPDPHAHPAA(KHLONKALNLL);
	}

	private bool ONPDPHAHPAA(TMP_Text KHLONKALNLL)
	{
		int instanceID = KHLONKALNLL.GetInstanceID();
		if (PEFHMAFMGII.ContainsKey(instanceID))
		{
			return false;
		}
		PEFHMAFMGII[instanceID] = instanceID;
		EIPHAIFEFHM.Add(KHLONKALNLL);
		return true;
	}

	public static void EHNJMDLGJIP(TMP_Text KHLONKALNLL)
	{
		IACLMEKOOJO.AKDIHEMDGCL(KHLONKALNLL);
	}

	private bool AKDIHEMDGCL(TMP_Text KHLONKALNLL)
	{
		int instanceID = KHLONKALNLL.GetInstanceID();
		if (NLFLOHKEPPA.ContainsKey(instanceID))
		{
			return false;
		}
		NLFLOHKEPPA[instanceID] = instanceID;
		IEHDALJJNFO.Add(KHLONKALNLL);
		return true;
	}

	private void OCEJLCEJONL(Camera GAPLNBLGDPC)
	{
		for (int i = 0; i < EIPHAIFEFHM.Count; i++)
		{
			EIPHAIFEFHM[i].Rebuild(CanvasUpdate.Prelayout);
		}
		if (EIPHAIFEFHM.Count > 0)
		{
			EIPHAIFEFHM.Clear();
			PEFHMAFMGII.Clear();
		}
		for (int j = 0; j < IEHDALJJNFO.Count; j++)
		{
			IEHDALJJNFO[j].Rebuild(CanvasUpdate.PreRender);
		}
		if (IEHDALJJNFO.Count > 0)
		{
			IEHDALJJNFO.Clear();
			NLFLOHKEPPA.Clear();
		}
	}

	public static void CHHGMIDGPKI(TMP_Text KHLONKALNLL)
	{
		IACLMEKOOJO.MAFEKOBLMFJ(KHLONKALNLL);
		IACLMEKOOJO.MCCGFILEDHO(KHLONKALNLL);
	}

	private void MAFEKOBLMFJ(TMP_Text KHLONKALNLL)
	{
		int instanceID = KHLONKALNLL.GetInstanceID();
		IACLMEKOOJO.IEHDALJJNFO.Remove(KHLONKALNLL);
		NLFLOHKEPPA.Remove(instanceID);
	}

	private void MCCGFILEDHO(TMP_Text KHLONKALNLL)
	{
		int instanceID = KHLONKALNLL.GetInstanceID();
		IACLMEKOOJO.EIPHAIFEFHM.Remove(KHLONKALNLL);
		PEFHMAFMGII.Remove(instanceID);
	}
}
