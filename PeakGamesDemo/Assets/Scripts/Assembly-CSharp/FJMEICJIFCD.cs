using System;
using System.Collections.Generic;
using System.Linq;
using Ui.VerticalScroll;
using UnityEngine;

public class FJMEICJIFCD<T, U> where T : JCPNPHKBDPK where U : VerticalScrollEntry
{
	private struct MNJDPNMDLFC
	{
		public float AEHGCPINKIG;

		public float LLBCGILBOIJ;

		public float KGBLOJBKCJB;
	}

	private readonly VerticalScrollController KBLCJMBCPNG;

	private List<T> LAKDGKIPIHI;

	private readonly U[] BONONFBDNNI;

	private int LFCHJCKMMIH;

	private readonly Dictionary<int, U> LEINIAGANND;

	private float KDDCFLIKEOM;

	private float CKJENCLCJMO;

	private float HPDLLEPFGPC;

	private int AJJACKLINAK = 10;

	private Action<int> NJGKLJGNGMO;

	private List<MNJDPNMDLFC> EGIPHLNBPIC;

	private float KEEIBEEEFBD;

	public FJMEICJIFCD(VerticalScrollController OEGMKCLNAME, U[] PHEFFKBMAIA, int[] PECIDFMIPIN, float HJLOCAEAFMJ = 1f, Action<int> DBOMHAEHCKM = null)
	{
		LEINIAGANND = new Dictionary<int, U>();
		KBLCJMBCPNG = OEGMKCLNAME;
		KBLCJMBCPNG.OnScroll = OnScroll;
		BONONFBDNNI = PHEFFKBMAIA;
		HPDLLEPFGPC = HJLOCAEAFMJ;
		NJGKLJGNGMO = DBOMHAEHCKM;
		for (int i = 0; i < BONONFBDNNI.Length; i++)
		{
			U val = BONONFBDNNI[i];
			if (!(val == null) && i < PECIDFMIPIN.Length)
			{
				val.FLFDKMOOIFL(PECIDFMIPIN[i]);
			}
		}
	}

	public void FEHBHKPHBFC(int MKEPNJBFDHH, float NPLDMEDJNLB = 0f, float GBONDLEMOCJ = 1f)
	{
		AJJACKLINAK = MKEPNJBFDHH;
		KDDCFLIKEOM = NPLDMEDJNLB;
		CKJENCLCJMO = GBONDLEMOCJ;
	}

	public void ICDJLHGBPKP()
	{
		for (int i = 0; i < BONONFBDNNI.Length; i++)
		{
			U val = BONONFBDNNI[i];
			if (!(val == null))
			{
				val.EILCDHMOOGO();
			}
		}
	}

	public void BBOMMEKKAEB(List<T> COGHCHMKJGF)
	{
		LAKDGKIPIHI = COGHCHMKJGF;
		EGIPHLNBPIC = new List<MNJDPNMDLFC>(LAKDGKIPIHI.Count);
		float num = KDDCFLIKEOM;
		for (int i = 0; i < LAKDGKIPIHI.Count; i++)
		{
			T val = LAKDGKIPIHI[i];
			if (val != null)
			{
				MNJDPNMDLFC item = default(MNJDPNMDLFC);
				float num2 = val.MDPHMDLJIME();
				if (i > 0)
				{
					T val2 = LAKDGKIPIHI[i - 1];
					num += (val2.MDPHMDLJIME() + num2) * 0.5f + KEEIBEEEFBD;
				}
				else
				{
					num = num2 * 0.5f;
				}
				item.LLBCGILBOIJ = num - num2 * 0.5f;
				item.KGBLOJBKCJB = num + num2 * 0.5f;
				item.AEHGCPINKIG = num;
				EGIPHLNBPIC.Add(item);
			}
		}
		FPGFIAKIIID();
		PDJJHNKKACK();
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

	private void OnScroll()
	{
		int num = INMNCHAAENB(KBLCJMBCPNG.GetScrollPosition(CKJENCLCJMO));
		if (LFCHJCKMMIH != num)
		{
			LFCHJCKMMIH = num;
			PDJJHNKKACK();
		}
	}

	private int INMNCHAAENB(float LDMDBPLADGD)
	{
		if (EGIPHLNBPIC == null || EGIPHLNBPIC.Count == 0)
		{
			return 0;
		}
		for (int i = 0; i < EGIPHLNBPIC.Count; i++)
		{
			MNJDPNMDLFC mNJDPNMDLFC = EGIPHLNBPIC[i];
			if (LDMDBPLADGD > mNJDPNMDLFC.LLBCGILBOIJ && LDMDBPLADGD < mNJDPNMDLFC.KGBLOJBKCJB)
			{
				return i;
			}
		}
		return 0;
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
				T val = LAKDGKIPIHI[i];
				U value = BONONFBDNNI[val.AJCJDONDHMH()].JOBDHIPIMAG();
				MNJDPNMDLFC mNJDPNMDLFC = EGIPHLNBPIC[i];
				if (value.transform.parent == null)
				{
					value.transform.SetParent(KBLCJMBCPNG.Content);
					value.transform.localScale = Vector3.one * HPDLLEPFGPC;
				}
				value.transform.localPosition = new Vector3(0f, 0f - mNJDPNMDLFC.AEHGCPINKIG, 0f);
				value.SetContent(LAKDGKIPIHI[i]);
				LEINIAGANND.Add(i, value);
			}
		}
		if (NJGKLJGNGMO != null)
		{
			NJGKLJGNGMO(LFCHJCKMMIH);
		}
	}
}
