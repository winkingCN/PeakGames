using UnityEngine;
using UnityEngine.Events;

internal struct BEDMFFDJAIN : KPCMHKDGLFE
{
	public enum JILFANNFHGA
	{
		All = 0,
		RGB = 1,
		Alpha = 2
	}

	public class PINECPHMFLK : UnityEvent<Color>
	{
	}

	private PINECPHMFLK EOAELHJDLLC;

	private Color KPLJBCLIHBE;

	private Color JDIKFFLFLCI;

	private JILFANNFHGA GNAEHPFDCJG;

	private float IOMHNFINCGA;

	private bool CIEGICCJEAJ;

	public Color NAKFMFEHEPL
	{
		get
		{
			return KPLJBCLIHBE;
		}
		set
		{
			KPLJBCLIHBE = value;
		}
	}

	public Color ICEFPJCHGBJ
	{
		get
		{
			return JDIKFFLFLCI;
		}
		set
		{
			JDIKFFLFLCI = value;
		}
	}

	public JILFANNFHGA GGPKBMLCBHA
	{
		get
		{
			return GNAEHPFDCJG;
		}
		set
		{
			GNAEHPFDCJG = value;
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
			Color arg = Color.Lerp(KPLJBCLIHBE, JDIKFFLFLCI, DCKGCIEACAO);
			if (GNAEHPFDCJG == JILFANNFHGA.Alpha)
			{
				arg.r = KPLJBCLIHBE.r;
				arg.g = KPLJBCLIHBE.g;
				arg.b = KPLJBCLIHBE.b;
			}
			else if (GNAEHPFDCJG == JILFANNFHGA.RGB)
			{
				arg.a = KPLJBCLIHBE.a;
			}
			EOAELHJDLLC.Invoke(arg);
		}
	}

	public void MHKAGNEDHPH(UnityAction<Color> HNJJMFOGAMG)
	{
		if (EOAELHJDLLC == null)
		{
			EOAELHJDLLC = new PINECPHMFLK();
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
