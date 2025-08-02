using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ANOADDOEKMH
{
	private static ANOADDOEKMH JGODGGLOOGM;

	private readonly List<ICanvasElement> EIPHAIFEFHM = new List<ICanvasElement>();

	private Dictionary<int, int> PEFHMAFMGII = new Dictionary<int, int>();

	private readonly List<ICanvasElement> IEHDALJJNFO = new List<ICanvasElement>();

	private Dictionary<int, int> NLFLOHKEPPA = new Dictionary<int, int>();

	public static ANOADDOEKMH IACLMEKOOJO
	{
		get
		{
			if (JGODGGLOOGM == null)
			{
				JGODGGLOOGM = new ANOADDOEKMH();
			}
			return JGODGGLOOGM;
		}
	}

	protected ANOADDOEKMH()
	{
		Canvas.willRenderCanvases += MMGGGODDDEF;
	}

	public static void JKFPBGBHHBP(ICanvasElement KHLONKALNLL)
	{
		IACLMEKOOJO.JPIOJLDOFDF(KHLONKALNLL);
	}

	private bool JPIOJLDOFDF(ICanvasElement KHLONKALNLL)
	{
		int instanceID = (KHLONKALNLL as Object).GetInstanceID();
		if (PEFHMAFMGII.ContainsKey(instanceID))
		{
			return false;
		}
		PEFHMAFMGII[instanceID] = instanceID;
		EIPHAIFEFHM.Add(KHLONKALNLL);
		return true;
	}

	public static void ACJELPMHDFA(ICanvasElement KHLONKALNLL)
	{
		IACLMEKOOJO.PMBLDEELOGN(KHLONKALNLL);
	}

	private bool PMBLDEELOGN(ICanvasElement KHLONKALNLL)
	{
		int instanceID = (KHLONKALNLL as Object).GetInstanceID();
		if (NLFLOHKEPPA.ContainsKey(instanceID))
		{
			return false;
		}
		NLFLOHKEPPA[instanceID] = instanceID;
		IEHDALJJNFO.Add(KHLONKALNLL);
		return true;
	}

	private void MMGGGODDDEF()
	{
		for (int i = 0; i < EIPHAIFEFHM.Count; i++)
		{
			ICanvasElement canvasElement = IACLMEKOOJO.EIPHAIFEFHM[i];
			canvasElement.Rebuild(CanvasUpdate.Prelayout);
		}
		if (EIPHAIFEFHM.Count > 0)
		{
			EIPHAIFEFHM.Clear();
			PEFHMAFMGII.Clear();
		}
		for (int j = 0; j < IEHDALJJNFO.Count; j++)
		{
			ICanvasElement canvasElement2 = IACLMEKOOJO.IEHDALJJNFO[j];
			canvasElement2.Rebuild(CanvasUpdate.PreRender);
		}
		if (IEHDALJJNFO.Count > 0)
		{
			IEHDALJJNFO.Clear();
			NLFLOHKEPPA.Clear();
		}
	}

	private void IODHLAJJMAA()
	{
		Debug.Log("Perform update of MeshRenderer objects.");
	}

	public static void NJILFNJMDJF(ICanvasElement KHLONKALNLL)
	{
		IACLMEKOOJO.CIOEJJEHCJN(KHLONKALNLL);
		IACLMEKOOJO.NBHIMBODKKA(KHLONKALNLL);
	}

	private void CIOEJJEHCJN(ICanvasElement KHLONKALNLL)
	{
		int instanceID = (KHLONKALNLL as Object).GetInstanceID();
		IACLMEKOOJO.EIPHAIFEFHM.Remove(KHLONKALNLL);
		NLFLOHKEPPA.Remove(instanceID);
	}

	private void NBHIMBODKKA(ICanvasElement KHLONKALNLL)
	{
		int instanceID = (KHLONKALNLL as Object).GetInstanceID();
		IACLMEKOOJO.IEHDALJJNFO.Remove(KHLONKALNLL);
		PEFHMAFMGII.Remove(instanceID);
	}
}
