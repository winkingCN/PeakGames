using System;
using System.Collections.Generic;
using System.Linq;
using Ui.VerticalScroll;
using UnityEngine;

public class FHOJBJMMNOD<T, U> where U : VerticalScrollEntry
{
	private readonly VerticalScrollController KBLCJMBCPNG;

	private List<T> LAKDGKIPIHI;

	private readonly U OBIKNMJJJCA;

	private int LFCHJCKMMIH;

	private readonly Dictionary<int, U> LEINIAGANND;

	private int AJJACKLINAK = 10;

	private float CNNDHPKLOJG = 2f;

	private float POGJIHELLLI;

	private float KDDCFLIKEOM = 3f;

	private readonly float HPDLLEPFGPC;

	private Action<int> NJGKLJGNGMO;

	public Action<float> EEGJMBDPKGP;

	public float GEBNMKAGJIG
	{
		get
		{
			return HPDLLEPFGPC;
		}
	}

	public FHOJBJMMNOD(VerticalScrollController OEGMKCLNAME, U DFHCBBOOIJG, int PECIDFMIPIN, float HJLOCAEAFMJ = 1f)
	{
		KBLCJMBCPNG = OEGMKCLNAME;
		OBIKNMJJJCA = DFHCBBOOIJG;
		LEINIAGANND = new Dictionary<int, U>();
		KBLCJMBCPNG.OnScroll = OnScroll;
		HPDLLEPFGPC = HJLOCAEAFMJ;
		OBIKNMJJJCA.FLFDKMOOIFL(PECIDFMIPIN);
	}

	public void GEKBMINLCLJ(Action<int> DBOMHAEHCKM)
	{
		NJGKLJGNGMO = DBOMHAEHCKM;
	}

	public void ICDJLHGBPKP()
	{
		OBIKNMJJJCA.EILCDHMOOGO();
	}

	public void NEPJMKPKPKM(int EHJNMODJEAN, T MBBPBGHKLJM)
	{
		if (EHJNMODJEAN >= 0 && EHJNMODJEAN < LAKDGKIPIHI.Count)
		{
			LAKDGKIPIHI[EHJNMODJEAN] = MBBPBGHKLJM;
			FPGFIAKIIID();
			PDJJHNKKACK();
		}
	}

	public void BBOMMEKKAEB(List<T> COGHCHMKJGF)
	{
		LAKDGKIPIHI = COGHCHMKJGF;
		FPGFIAKIIID();
		PDJJHNKKACK();
	}

	public T JHBKJBFAGCB(int EHJNMODJEAN)
	{
		return LAKDGKIPIHI[EHJNMODJEAN];
	}

	public float FMAFOFCEPCE(int EHJNMODJEAN)
	{
		return (float)EHJNMODJEAN * CNNDHPKLOJG + POGJIHELLLI + KBLCJMBCPNG.transform.localPosition.y;
	}

	public Transform MAPMKCKNGKE()
	{
		return KBLCJMBCPNG.transform;
	}

	public void CABDGJJMBLD()
	{
		int count = LEINIAGANND.Count;
		for (int num = count - 1; num >= 0; num--)
		{
			KeyValuePair<int, U> keyValuePair = LEINIAGANND.ElementAt(num);
			U value = keyValuePair.Value;
			value.SetContent(LAKDGKIPIHI[keyValuePair.Key]);
		}
	}

	public void FPGFIAKIIID()
	{
		foreach (KeyValuePair<int, U> item in LEINIAGANND)
		{
			if (item.Value != null)
			{
				item.Value.MEJPNNFDEBD();
			}
		}
		LEINIAGANND.Clear();
	}

	public void FEHBHKPHBFC(int MKEPNJBFDHH, float BBHOEGKLIFG, float INHFJECCIPI = 0f, float NPLDMEDJNLB = 3f)
	{
		AJJACKLINAK = MKEPNJBFDHH;
		CNNDHPKLOJG = BBHOEGKLIFG;
		POGJIHELLLI = INHFJECCIPI;
		KDDCFLIKEOM = NPLDMEDJNLB;
	}

	private void OnScroll()
	{
		int num = Math.Max(0, KBLCJMBCPNG.GetScrollTopIndex(CNNDHPKLOJG, KDDCFLIKEOM));
		if (EEGJMBDPKGP != null)
		{
			EEGJMBDPKGP(KBLCJMBCPNG.Content.localPosition.y);
		}
		if (LFCHJCKMMIH != num)
		{
			LFCHJCKMMIH = num;
			PDJJHNKKACK();
			if (NJGKLJGNGMO != null)
			{
				NJGKLJGNGMO(LFCHJCKMMIH);
			}
		}
	}

	private void PDJJHNKKACK()
	{
		int count = LEINIAGANND.Count;
		int num = LFCHJCKMMIH + AJJACKLINAK;
		for (int num2 = count - 1; num2 >= 0; num2--)
		{
			KeyValuePair<int, U> keyValuePair = LEINIAGANND.ElementAt(num2);
			if (keyValuePair.Key < LFCHJCKMMIH || keyValuePair.Key >= num)
			{
				keyValuePair.Value.MEJPNNFDEBD();
				LEINIAGANND.Remove(keyValuePair.Key);
			}
		}
		for (int i = LFCHJCKMMIH; i < num && i < LAKDGKIPIHI.Count; i++)
		{
			if (!LEINIAGANND.ContainsKey(i))
			{
				U value = OBIKNMJJJCA.JOBDHIPIMAG();
				if (value.transform.parent == null)
				{
					value.transform.SetParent(KBLCJMBCPNG.Content);
					value.transform.localScale = Vector3.one * HPDLLEPFGPC;
				}
				value.transform.localPosition = new Vector3(0f, (float)(-i) * CNNDHPKLOJG - POGJIHELLLI, 0f);
				value.SetContent(LAKDGKIPIHI[i]);
				LEINIAGANND.Add(i, value);
			}
		}
	}
}
