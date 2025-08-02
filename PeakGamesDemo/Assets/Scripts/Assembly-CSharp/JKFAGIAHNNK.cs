using Spine;

public class JKFAGIAHNNK : DABFMEODJHE
{
	internal float[] ENBKHCNKHCC;

	private DCBJAMHBAJB[] NJOHMGMPGBE;

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

	public DCBJAMHBAJB[] GHMLPLDGGIJ
	{
		get
		{
			return NJOHMGMPGBE;
		}
		set
		{
			NJOHMGMPGBE = value;
		}
	}

	public int DABCDPAEDEE
	{
		get
		{
			return ENBKHCNKHCC.Length;
		}
	}

	public int ODHLEJHEBGD
	{
		get
		{
			return 117440512;
		}
	}

	public JKFAGIAHNNK(int IJKENLLBMOJ)
	{
		ENBKHCNKHCC = new float[IJKENLLBMOJ];
		NJOHMGMPGBE = new DCBJAMHBAJB[IJKENLLBMOJ];
	}

	public void BCEFHMIKFDC(int JHFDIBIBCPH, DCBJAMHBAJB EKFOKNPODBK)
	{
		ENBKHCNKHCC[JHFDIBIBCPH] = EKFOKNPODBK.PFNNFPIDHFN;
		NJOHMGMPGBE[JHFDIBIBCPH] = EKFOKNPODBK;
	}

	public void FCHLOGCODOA(GCJKICAPOFL GDNININLMFD, float CGICCPOKJHB, float HFLODNLEGFL, ExposedList<DCBJAMHBAJB> ELMIMIMBNHP, float KBKMPEOMABI, BFCFMFBHBCH IFKBABBBDJM, ODPDBCNBOAK AJLDJAHHGOJ)
	{
		if (ELMIMIMBNHP == null)
		{
			return;
		}
		float[] eNBKHCNKHCC = ENBKHCNKHCC;
		int num = eNBKHCNKHCC.Length;
		if (CGICCPOKJHB > HFLODNLEGFL)
		{
			FCHLOGCODOA(GDNININLMFD, CGICCPOKJHB, 2.1474836E+09f, ELMIMIMBNHP, KBKMPEOMABI, IFKBABBBDJM, AJLDJAHHGOJ);
			CGICCPOKJHB = -1f;
		}
		else if (CGICCPOKJHB >= eNBKHCNKHCC[num - 1])
		{
			return;
		}
		if (HFLODNLEGFL < eNBKHCNKHCC[0])
		{
			return;
		}
		int i;
		if (CGICCPOKJHB < eNBKHCNKHCC[0])
		{
			i = 0;
		}
		else
		{
			i = GNGKKPOGGGM.EIAMMDBFDFO(eNBKHCNKHCC, CGICCPOKJHB);
			float num2 = eNBKHCNKHCC[i];
			while (i > 0 && eNBKHCNKHCC[i - 1] == num2)
			{
				i--;
			}
		}
		for (; i < num && HFLODNLEGFL >= eNBKHCNKHCC[i]; i++)
		{
			ELMIMIMBNHP.JEACJNAKLDJ(NJOHMGMPGBE[i]);
		}
	}
}
