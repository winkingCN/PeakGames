using UnityEngine;
using UnityEngine.Events;

internal struct DOKFANOLIBM : KPCMHKDGLFE
{
	public class HKJFMGABMKI : UnityEvent<float>
	{
	}

	private HKJFMGABMKI EOAELHJDLLC;

	private float NDKLAAOIMPG;

	private float CBEGBPKOGJJ;

	private float IOMHNFINCGA;

	private bool CIEGICCJEAJ;

	public float AHHFBLFACFD
	{
		get
		{
			return NDKLAAOIMPG;
		}
		set
		{
			NDKLAAOIMPG = value;
		}
	}

	public float PMLGEJPOIEM
	{
		get
		{
			return CBEGBPKOGJJ;
		}
		set
		{
			CBEGBPKOGJJ = value;
		}
	}

	public float FMPBJJMKCIG
	{
		get
		{
			return IOMHNFINCGA;
		}
		set
		{
			IOMHNFINCGA = value;
		}
	}

	public bool AFCNLNOBLKK
	{
		get
		{
			return CIEGICCJEAJ;
		}
		set
		{
			CIEGICCJEAJ = value;
		}
	}

	public void POCKOBFHALC(float DCKGCIEACAO)
	{
		if (KBDJIAJKPOG())
		{
			float arg = Mathf.Lerp(NDKLAAOIMPG, CBEGBPKOGJJ, DCKGCIEACAO);
			EOAELHJDLLC.Invoke(arg);
		}
	}

	public void MHKAGNEDHPH(UnityAction<float> HNJJMFOGAMG)
	{
		if (EOAELHJDLLC == null)
		{
			EOAELHJDLLC = new HKJFMGABMKI();
		}
		EOAELHJDLLC.AddListener(HNJJMFOGAMG);
	}

	public bool BPLICILHAGL()
	{
		return CIEGICCJEAJ;
	}

	public float HHECFPDJOBH()
	{
		return IOMHNFINCGA;
	}

	public bool KBDJIAJKPOG()
	{
		return EOAELHJDLLC != null;
	}
}
