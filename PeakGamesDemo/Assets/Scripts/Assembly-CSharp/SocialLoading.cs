using System.Collections;
using UnityEngine;

public class SocialLoading : MonoBehaviour
{
	public float Degree = 30f;

	public float InTime = 1f;

	private bool CFIEOOAHHJK;

	private int HJDPMBLADMK;

	private LLCJMMBBLEH EBNNFLIJIFC;

	public void Start()
	{
		CFIEOOAHHJK = true;
		StartCoroutine(KAPOCJHFBJK());
	}

	private void OnEnable()
	{
		DisplayInstant();
	}

	private IEnumerator KAPOCJHFBJK()
	{
		while (true)
		{
			base.transform.Rotate(0f, 0f, Degree);
			yield return new WaitForSeconds(InTime);
		}
	}

	public void DisplayInstant()
	{
		if (CFIEOOAHHJK)
		{
			StopAllCoroutines();
			StartCoroutine(KAPOCJHFBJK());
		}
	}

	public void HideInstant()
	{
		StopAllCoroutines();
		base.gameObject.SetActive(false);
	}

	public void Display(bool LHEKNAFMFMG = false)
	{
		HJDPMBLADMK++;
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SocialLoading, "Showing loading:, {0}", HJDPMBLADMK);
		if (EBNNFLIJIFC == null)
		{
			EBNNFLIJIFC = new LLCJMMBBLEH(OIJCNHALBFG(LHEKNAFMFMG));
		}
	}

	private IEnumerator OIJCNHALBFG(bool LHEKNAFMFMG)
	{
		if (!LHEKNAFMFMG)
		{
			yield return MCJHHDACJBG.CNDGGNLKOOC;
		}
		if (HJDPMBLADMK == 0)
		{
			EBNNFLIJIFC = null;
			StopAllCoroutines();
			base.gameObject.SetActive(false);
		}
		else if (!base.gameObject.activeSelf)
		{
			base.gameObject.SetActive(true);
			StartCoroutine(KAPOCJHFBJK());
		}
	}

	public void Hide()
	{
		HJDPMBLADMK--;
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SocialLoading, "Hiding loading:, {0}", HJDPMBLADMK);
		if (HJDPMBLADMK < 0)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SocialLoading, "Minus loading:, {0}", HJDPMBLADMK);
			HJDPMBLADMK = 0;
		}
		if (HJDPMBLADMK <= 0)
		{
			if (EBNNFLIJIFC != null)
			{
				EBNNFLIJIFC.BPPFBMCJOAH();
				EBNNFLIJIFC = null;
			}
			StopAllCoroutines();
			base.gameObject.SetActive(false);
		}
	}
}
