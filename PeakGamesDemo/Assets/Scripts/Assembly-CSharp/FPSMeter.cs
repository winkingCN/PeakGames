using Assets.Scripts.CasualTools.Dialogs;
using TMPro;
using UnityEngine;

public class FPSMeter : MonoBehaviour
{
	public TextMeshPro FPSText;

	public EventBasedButton Button;

	private const float AGABIKJPKIK = 50f;

	private int GGPMAABCADK;

	private float HJKDEELOBAK;

	private int ENBKHCNKHCC;

	private float NHHFBKLMFIB;

	public float updateInterval = 1f;

	private float CIKLNLGMHEH = 60f;

	private float OINBEIOMLCP = 60f;

	private float EEBFBALPFJH;

	private int LDBDMELEBNE;

	private float JLMKKIJHLCC;

	public void Awake()
	{
		Button.CanBeClicked = false;
		FPSText.FCJBBPHFNPJ = string.Empty;
		FPSText.enabled = false;
	}

	public void Update()
	{
		if (Time.timeScale == 0f)
		{
			Reset();
		}
		else
		{
			DMLCMLLPMNG();
		}
	}

	private void DMLCMLLPMNG()
	{
		NHHFBKLMFIB -= Time.deltaTime;
		HJKDEELOBAK += Time.timeScale / Time.deltaTime;
		ENBKHCNKHCC++;
		if ((double)NHHFBKLMFIB <= 0.0)
		{
			CIKLNLGMHEH = HJKDEELOBAK / (float)ENBKHCNKHCC;
			LDBDMELEBNE++;
			JLMKKIJHLCC += CIKLNLGMHEH;
			OINBEIOMLCP = Mathf.Min(CIKLNLGMHEH, OINBEIOMLCP);
			EEBFBALPFJH = Mathf.Max(CIKLNLGMHEH, EEBFBALPFJH);
			if (CIKLNLGMHEH < 50f)
			{
				GGPMAABCADK++;
			}
			NHHFBKLMFIB = updateInterval;
			HJKDEELOBAK = 0f;
			ENBKHCNKHCC = 0;
			if (LDBDMELEBNE > 3600 || JLMKKIJHLCC > 9999999f)
			{
				Reset();
			}
		}
	}

	public void Reset()
	{
		OINBEIOMLCP = 99999f;
		CIKLNLGMHEH = 60f;
		GGPMAABCADK = 0;
		LDBDMELEBNE = 0;
		JLMKKIJHLCC = 0f;
	}

	public float MinimumFps()
	{
		if (OINBEIOMLCP < 0f || OINBEIOMLCP > 100f)
		{
			return 0f;
		}
		return OINBEIOMLCP;
	}

	public float MaximumFps()
	{
		if (EEBFBALPFJH < 0f || EEBFBALPFJH > 100f)
		{
			return 0f;
		}
		return EEBFBALPFJH;
	}

	public int SpikeCount()
	{
		if (GGPMAABCADK < 0 || GGPMAABCADK > 100)
		{
			return 0;
		}
		return GGPMAABCADK;
	}

	public float AverageFps()
	{
		if (LDBDMELEBNE == 0)
		{
			return 0f;
		}
		float num = JLMKKIJHLCC / (float)LDBDMELEBNE;
		if (num < 0f || num > 100f)
		{
			return 0f;
		}
		return num;
	}

	public void SwitchFPSMeter()
	{
		FPSText.enabled = !FPSText.enabled;
	}
}
