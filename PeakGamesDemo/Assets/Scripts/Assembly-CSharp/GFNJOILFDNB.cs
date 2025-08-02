using Spine;

public class GFNJOILFDNB : FPOBLOBNHGG
{
	public const int JMPDFJHAGOA = 2;

	internal const int AMJGBMFEPLB = -2;

	internal const int MOBLILDKPIA = -1;

	internal const int NLNLJJOPLOE = 1;

	internal int DHJJGGGLNNH;

	internal float[] ENBKHCNKHCC;

	public int LLCDBBPCAND
	{
		get
		{
			return DHJJGGGLNNH;
		}
		set
		{
			DHJJGGGLNNH = value;
		}
	}

	public float[] IKOJIGLMFNG
	{
		get
		{
			return ENBKHCNKHCC;
		}
		set
		{
			ENBKHCNKHCC = value;
		}
	}

	public override int ODHLEJHEBGD
	{
		get
		{
			return DHJJGGGLNNH;
		}
	}

	public GFNJOILFDNB(int IJKENLLBMOJ)
		: base(IJKENLLBMOJ)
	{
		ENBKHCNKHCC = new float[IJKENLLBMOJ << 1];
	}

	public void BCEFHMIKFDC(int JHFDIBIBCPH, float HFLODNLEGFL, float GGELLLADCFC)
	{
		JHFDIBIBCPH <<= 1;
		ENBKHCNKHCC[JHFDIBIBCPH] = HFLODNLEGFL;
		ENBKHCNKHCC[JHFDIBIBCPH + 1] = GGELLLADCFC;
	}

	public override void FCHLOGCODOA(GCJKICAPOFL GDNININLMFD, float CGICCPOKJHB, float HFLODNLEGFL, ExposedList<DCBJAMHBAJB> ELMIMIMBNHP, float KBKMPEOMABI, BFCFMFBHBCH IFKBABBBDJM, ODPDBCNBOAK AJLDJAHHGOJ)
	{
		NBKCFDOMAPI nBKCFDOMAPI = GDNININLMFD.LIKIOBHLHHF.Items[DHJJGGGLNNH];
		float[] eNBKHCNKHCC = ENBKHCNKHCC;
		if (HFLODNLEGFL < eNBKHCNKHCC[0])
		{
			switch (IFKBABBBDJM)
			{
			case BFCFMFBHBCH.Setup:
				nBKCFDOMAPI.ODLHFMOPCHL = nBKCFDOMAPI.MBBPBGHKLJM.ODLHFMOPCHL;
				break;
			case BFCFMFBHBCH.Current:
			{
				float num = nBKCFDOMAPI.MBBPBGHKLJM.ODLHFMOPCHL - nBKCFDOMAPI.ODLHFMOPCHL;
				num -= (float)((16384 - (int)(16384.499999999996 - (double)(num / 360f))) * 360);
				nBKCFDOMAPI.ODLHFMOPCHL += num * KBKMPEOMABI;
				break;
			}
			}
			return;
		}
		if (HFLODNLEGFL >= eNBKHCNKHCC[eNBKHCNKHCC.Length - 2])
		{
			if (IFKBABBBDJM == BFCFMFBHBCH.Setup)
			{
				nBKCFDOMAPI.ODLHFMOPCHL = nBKCFDOMAPI.MBBPBGHKLJM.ODLHFMOPCHL + eNBKHCNKHCC[eNBKHCNKHCC.Length + -1] * KBKMPEOMABI;
				return;
			}
			float num2 = nBKCFDOMAPI.MBBPBGHKLJM.ODLHFMOPCHL + eNBKHCNKHCC[eNBKHCNKHCC.Length + -1] - nBKCFDOMAPI.ODLHFMOPCHL;
			num2 -= (float)((16384 - (int)(16384.499999999996 - (double)(num2 / 360f))) * 360);
			nBKCFDOMAPI.ODLHFMOPCHL += num2 * KBKMPEOMABI;
			return;
		}
		int num3 = GNGKKPOGGGM.EIAMMDBFDFO(eNBKHCNKHCC, HFLODNLEGFL, 2);
		float num4 = eNBKHCNKHCC[num3 + -1];
		float num5 = eNBKHCNKHCC[num3];
		float num6 = IFMKHGLKEMB((num3 >> 1) - 1, 1f - (HFLODNLEGFL - num5) / (eNBKHCNKHCC[num3 + -2] - num5));
		float num7 = eNBKHCNKHCC[num3 + 1] - num4;
		num7 -= (float)((16384 - (int)(16384.499999999996 - (double)(num7 / 360f))) * 360);
		num7 = num4 + num7 * num6;
		if (IFKBABBBDJM == BFCFMFBHBCH.Setup)
		{
			num7 -= (float)((16384 - (int)(16384.499999999996 - (double)(num7 / 360f))) * 360);
			nBKCFDOMAPI.ODLHFMOPCHL = nBKCFDOMAPI.MBBPBGHKLJM.ODLHFMOPCHL + num7 * KBKMPEOMABI;
		}
		else
		{
			num7 = nBKCFDOMAPI.MBBPBGHKLJM.ODLHFMOPCHL + num7 - nBKCFDOMAPI.ODLHFMOPCHL;
			num7 -= (float)((16384 - (int)(16384.499999999996 - (double)(num7 / 360f))) * 360);
			nBKCFDOMAPI.ODLHFMOPCHL += num7 * KBKMPEOMABI;
		}
	}
}
