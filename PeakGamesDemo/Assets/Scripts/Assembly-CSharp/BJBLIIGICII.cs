using System;
using Spine;

public class BJBLIIGICII : FPOBLOBNHGG
{
	internal int PBPEMFGPGFC;

	internal float[] ENBKHCNKHCC;

	internal float[][] NIDOOEHBMOG;

	internal LJPHFIKMDHN DFHHMKMLCFF;

	public int ONPPEPBHGCK
	{
		get
		{
			return PBPEMFGPGFC;
		}
		set
		{
			PBPEMFGPGFC = value;
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

	public float[][] IAMHHPHNLHM
	{
		get
		{
			return NIDOOEHBMOG;
		}
		set
		{
			NIDOOEHBMOG = value;
		}
	}

	public LJPHFIKMDHN AIKFOHCPLKG
	{
		get
		{
			return DFHHMKMLCFF;
		}
		set
		{
			DFHHMKMLCFF = value;
		}
	}

	public override int ODHLEJHEBGD
	{
		get
		{
			return 100663296 + DFHHMKMLCFF.BDKFNEDHAOJ + PBPEMFGPGFC;
		}
	}

	public BJBLIIGICII(int IJKENLLBMOJ)
		: base(IJKENLLBMOJ)
	{
		ENBKHCNKHCC = new float[IJKENLLBMOJ];
		NIDOOEHBMOG = new float[IJKENLLBMOJ][];
	}

	public void BCEFHMIKFDC(int JHFDIBIBCPH, float HFLODNLEGFL, float[] FHBFCAEGPOH)
	{
		ENBKHCNKHCC[JHFDIBIBCPH] = HFLODNLEGFL;
		NIDOOEHBMOG[JHFDIBIBCPH] = FHBFCAEGPOH;
	}

	public override void FCHLOGCODOA(GCJKICAPOFL GDNININLMFD, float CGICCPOKJHB, float HFLODNLEGFL, ExposedList<DCBJAMHBAJB> ELMIMIMBNHP, float KBKMPEOMABI, BFCFMFBHBCH IFKBABBBDJM, ODPDBCNBOAK AJLDJAHHGOJ)
	{
		LBBAMMPJKDA lBBAMMPJKDA = GDNININLMFD.MAKCMFCFDLP.Items[PBPEMFGPGFC];
		LJPHFIKMDHN lJPHFIKMDHN = lBBAMMPJKDA.DFHHMKMLCFF as LJPHFIKMDHN;
		if (lJPHFIKMDHN == null || !lJPHFIKMDHN.OPPJKMMOONJ(DFHHMKMLCFF))
		{
			return;
		}
		ExposedList<float> aDAMNKAAPII = lBBAMMPJKDA.ADAMNKAAPII;
		if (aDAMNKAAPII.Count == 0)
		{
			KBKMPEOMABI = 1f;
		}
		float[][] nIDOOEHBMOG = NIDOOEHBMOG;
		int num = nIDOOEHBMOG[0].Length;
		float[] eNBKHCNKHCC = ENBKHCNKHCC;
		float[] items;
		if (HFLODNLEGFL < eNBKHCNKHCC[0])
		{
			switch (IFKBABBBDJM)
			{
			case BFCFMFBHBCH.Setup:
				aDAMNKAAPII.BOPEPLONIFL();
				break;
			case BFCFMFBHBCH.Current:
				if (KBKMPEOMABI == 1f)
				{
					aDAMNKAAPII.BOPEPLONIFL();
					break;
				}
				if (aDAMNKAAPII.Capacity < num)
				{
					aDAMNKAAPII.Capacity = num;
				}
				aDAMNKAAPII.Count = num;
				items = aDAMNKAAPII.Items;
				if (lJPHFIKMDHN.LIKIOBHLHHF == null)
				{
					float[] fHBFCAEGPOH = lJPHFIKMDHN.FHBFCAEGPOH;
					for (int i = 0; i < num; i++)
					{
						items[i] += (fHBFCAEGPOH[i] - items[i]) * KBKMPEOMABI;
					}
				}
				else
				{
					KBKMPEOMABI = 1f - KBKMPEOMABI;
					for (int j = 0; j < num; j++)
					{
						items[j] *= KBKMPEOMABI;
					}
				}
				break;
			}
			return;
		}
		if (aDAMNKAAPII.Capacity < num)
		{
			aDAMNKAAPII.Capacity = num;
		}
		aDAMNKAAPII.Count = num;
		items = aDAMNKAAPII.Items;
		if (HFLODNLEGFL >= eNBKHCNKHCC[eNBKHCNKHCC.Length - 1])
		{
			float[] array = nIDOOEHBMOG[eNBKHCNKHCC.Length - 1];
			if (KBKMPEOMABI == 1f)
			{
				Array.Copy(array, 0, items, 0, num);
			}
			else if (IFKBABBBDJM == BFCFMFBHBCH.Setup)
			{
				if (lJPHFIKMDHN.LIKIOBHLHHF == null)
				{
					float[] fHBFCAEGPOH2 = lJPHFIKMDHN.FHBFCAEGPOH;
					for (int k = 0; k < num; k++)
					{
						float num2 = fHBFCAEGPOH2[k];
						items[k] = num2 + (array[k] - num2) * KBKMPEOMABI;
					}
				}
				else
				{
					for (int l = 0; l < num; l++)
					{
						items[l] = array[l] * KBKMPEOMABI;
					}
				}
			}
			else
			{
				for (int m = 0; m < num; m++)
				{
					items[m] += (array[m] - items[m]) * KBKMPEOMABI;
				}
			}
			return;
		}
		int num3 = GNGKKPOGGGM.EIAMMDBFDFO(eNBKHCNKHCC, HFLODNLEGFL);
		float[] array2 = nIDOOEHBMOG[num3 - 1];
		float[] array3 = nIDOOEHBMOG[num3];
		float num4 = eNBKHCNKHCC[num3];
		float num5 = IFMKHGLKEMB(num3 - 1, 1f - (HFLODNLEGFL - num4) / (eNBKHCNKHCC[num3 - 1] - num4));
		if (KBKMPEOMABI == 1f)
		{
			for (int n = 0; n < num; n++)
			{
				float num6 = array2[n];
				items[n] = num6 + (array3[n] - num6) * num5;
			}
		}
		else if (IFKBABBBDJM == BFCFMFBHBCH.Setup)
		{
			if (lJPHFIKMDHN.LIKIOBHLHHF == null)
			{
				float[] fHBFCAEGPOH3 = lJPHFIKMDHN.FHBFCAEGPOH;
				for (int num7 = 0; num7 < num; num7++)
				{
					float num8 = array2[num7];
					float num9 = fHBFCAEGPOH3[num7];
					items[num7] = num9 + (num8 + (array3[num7] - num8) * num5 - num9) * KBKMPEOMABI;
				}
			}
			else
			{
				for (int num10 = 0; num10 < num; num10++)
				{
					float num11 = array2[num10];
					items[num10] = (num11 + (array3[num10] - num11) * num5) * KBKMPEOMABI;
				}
			}
		}
		else
		{
			for (int num12 = 0; num12 < num; num12++)
			{
				float num13 = array2[num12];
				items[num12] += (num13 + (array3[num12] - num13) * num5 - items[num12]) * KBKMPEOMABI;
			}
		}
	}
}
