using System;
using Spine;

public class HHDOJIEJCGJ : DABFMEODJHE
{
	internal float[] ENBKHCNKHCC;

	private int[][] EADLAIGNBHF;

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

	public int[][] LAFMFLIDGHA
	{
		get
		{
			return EADLAIGNBHF;
		}
		set
		{
			EADLAIGNBHF = value;
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
			return 134217728;
		}
	}

	public HHDOJIEJCGJ(int IJKENLLBMOJ)
	{
		ENBKHCNKHCC = new float[IJKENLLBMOJ];
		EADLAIGNBHF = new int[IJKENLLBMOJ][];
	}

	public void BCEFHMIKFDC(int JHFDIBIBCPH, float HFLODNLEGFL, int[] COACJAFIPEI)
	{
		ENBKHCNKHCC[JHFDIBIBCPH] = HFLODNLEGFL;
		EADLAIGNBHF[JHFDIBIBCPH] = COACJAFIPEI;
	}

	public void FCHLOGCODOA(GCJKICAPOFL GDNININLMFD, float CGICCPOKJHB, float HFLODNLEGFL, ExposedList<DCBJAMHBAJB> ELMIMIMBNHP, float KBKMPEOMABI, BFCFMFBHBCH IFKBABBBDJM, ODPDBCNBOAK AJLDJAHHGOJ)
	{
		ExposedList<LBBAMMPJKDA> cOACJAFIPEI = GDNININLMFD.COACJAFIPEI;
		ExposedList<LBBAMMPJKDA> mAKCMFCFDLP = GDNININLMFD.MAKCMFCFDLP;
		if (AJLDJAHHGOJ == ODPDBCNBOAK.Out && IFKBABBBDJM == BFCFMFBHBCH.Setup)
		{
			Array.Copy(mAKCMFCFDLP.Items, 0, cOACJAFIPEI.Items, 0, mAKCMFCFDLP.Count);
			return;
		}
		float[] eNBKHCNKHCC = ENBKHCNKHCC;
		if (HFLODNLEGFL < eNBKHCNKHCC[0])
		{
			if (IFKBABBBDJM == BFCFMFBHBCH.Setup)
			{
				Array.Copy(mAKCMFCFDLP.Items, 0, cOACJAFIPEI.Items, 0, mAKCMFCFDLP.Count);
			}
			return;
		}
		int num = ((!(HFLODNLEGFL >= eNBKHCNKHCC[eNBKHCNKHCC.Length - 1])) ? (GNGKKPOGGGM.EIAMMDBFDFO(eNBKHCNKHCC, HFLODNLEGFL) - 1) : (eNBKHCNKHCC.Length - 1));
		int[] array = EADLAIGNBHF[num];
		if (array == null)
		{
			cOACJAFIPEI.BOPEPLONIFL();
			int i = 0;
			for (int count = mAKCMFCFDLP.Count; i < count; i++)
			{
				cOACJAFIPEI.JEACJNAKLDJ(mAKCMFCFDLP.Items[i]);
			}
			return;
		}
		LBBAMMPJKDA[] items = cOACJAFIPEI.Items;
		LBBAMMPJKDA[] items2 = mAKCMFCFDLP.Items;
		int j = 0;
		for (int num2 = array.Length; j < num2; j++)
		{
			items[j] = items2[array[j]];
		}
	}
}
