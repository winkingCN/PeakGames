using Spine;

public class CFHAEHPHFEI : CPCLJAHCDGN
{
	public override int ODHLEJHEBGD
	{
		get
		{
			return 33554432 + DHJJGGGLNNH;
		}
	}

	public CFHAEHPHFEI(int IJKENLLBMOJ)
		: base(IJKENLLBMOJ)
	{
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
				nBKCFDOMAPI.IAFNPOKEFMB = nBKCFDOMAPI.MBBPBGHKLJM.IAFNPOKEFMB;
				nBKCFDOMAPI.GFMCPIJHIGD = nBKCFDOMAPI.MBBPBGHKLJM.GFMCPIJHIGD;
				break;
			case BFCFMFBHBCH.Current:
				nBKCFDOMAPI.IAFNPOKEFMB += (nBKCFDOMAPI.MBBPBGHKLJM.IAFNPOKEFMB - nBKCFDOMAPI.IAFNPOKEFMB) * KBKMPEOMABI;
				nBKCFDOMAPI.GFMCPIJHIGD += (nBKCFDOMAPI.MBBPBGHKLJM.GFMCPIJHIGD - nBKCFDOMAPI.GFMCPIJHIGD) * KBKMPEOMABI;
				break;
			}
			return;
		}
		float num;
		float num2;
		if (HFLODNLEGFL >= eNBKHCNKHCC[eNBKHCNKHCC.Length - 3])
		{
			num = eNBKHCNKHCC[eNBKHCNKHCC.Length + -2] * nBKCFDOMAPI.MBBPBGHKLJM.IAFNPOKEFMB;
			num2 = eNBKHCNKHCC[eNBKHCNKHCC.Length + -1] * nBKCFDOMAPI.MBBPBGHKLJM.GFMCPIJHIGD;
		}
		else
		{
			int num3 = GNGKKPOGGGM.EIAMMDBFDFO(eNBKHCNKHCC, HFLODNLEGFL, 3);
			num = eNBKHCNKHCC[num3 + -2];
			num2 = eNBKHCNKHCC[num3 + -1];
			float num4 = eNBKHCNKHCC[num3];
			float num5 = IFMKHGLKEMB(num3 / 3 - 1, 1f - (HFLODNLEGFL - num4) / (eNBKHCNKHCC[num3 + -3] - num4));
			num = (num + (eNBKHCNKHCC[num3 + 1] - num) * num5) * nBKCFDOMAPI.MBBPBGHKLJM.IAFNPOKEFMB;
			num2 = (num2 + (eNBKHCNKHCC[num3 + 2] - num2) * num5) * nBKCFDOMAPI.MBBPBGHKLJM.GFMCPIJHIGD;
		}
		if (KBKMPEOMABI == 1f)
		{
			nBKCFDOMAPI.IAFNPOKEFMB = num;
			nBKCFDOMAPI.GFMCPIJHIGD = num2;
			return;
		}
		float num6;
		float num7;
		if (IFKBABBBDJM == BFCFMFBHBCH.Setup)
		{
			num6 = nBKCFDOMAPI.MBBPBGHKLJM.IAFNPOKEFMB;
			num7 = nBKCFDOMAPI.MBBPBGHKLJM.GFMCPIJHIGD;
		}
		else
		{
			num6 = nBKCFDOMAPI.IAFNPOKEFMB;
			num7 = nBKCFDOMAPI.GFMCPIJHIGD;
		}
		if (AJLDJAHHGOJ == ODPDBCNBOAK.Out)
		{
			num = ((!(num >= 0f)) ? (0f - num) : num) * (float)((num6 >= 0f) ? 1 : (-1));
			num2 = ((!(num2 >= 0f)) ? (0f - num2) : num2) * (float)((num7 >= 0f) ? 1 : (-1));
		}
		else
		{
			num6 = ((!(num6 >= 0f)) ? (0f - num6) : num6) * (float)((num >= 0f) ? 1 : (-1));
			num7 = ((!(num7 >= 0f)) ? (0f - num7) : num7) * (float)((num2 >= 0f) ? 1 : (-1));
		}
		nBKCFDOMAPI.IAFNPOKEFMB = num6 + (num - num6) * KBKMPEOMABI;
		nBKCFDOMAPI.GFMCPIJHIGD = num7 + (num2 - num7) * KBKMPEOMABI;
	}
}
