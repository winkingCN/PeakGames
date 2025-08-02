using UnityEngine;

public class GFFMFGMCOBP
{
	public static void KMHPJHNHCLG(Transform AHPHIMJPOEO, string JEEAGJJJFBN, int NCDKEAJONMF, int DPAKEPKLHJF)
	{
		Vector3 localPosition = AHPHIMJPOEO.localPosition;
		localPosition.z = DPAKEPKLHJF;
		AHPHIMJPOEO.localPosition = localPosition;
		ONNLDEDPJBC(AHPHIMJPOEO, new CKKKELDIOLD(SortingLayer.NameToID(JEEAGJJJFBN), NCDKEAJONMF));
	}

	public static void ONNLDEDPJBC(Transform CAEMELGEOAE, CKKKELDIOLD KHFBHDLBLJH)
	{
		Renderer[] componentsInChildren = CAEMELGEOAE.GetComponentsInChildren<Renderer>(true);
		int num = componentsInChildren.Length;
		for (int i = 0; i < num; i++)
		{
			componentsInChildren[i].sortingLayerID = KHFBHDLBLJH.MMFFDANAEEI;
			componentsInChildren[i].sortingOrder += KHFBHDLBLJH.BHIJCAOHDCM;
		}
	}
}
