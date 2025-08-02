using System;
using Spine;

public abstract class FPOBLOBNHGG : DABFMEODJHE
{
	protected const float DMOHIMDLOEM = 0f;

	protected const float NOGGFLJENKJ = 1f;

	protected const float OKNFGENALGD = 2f;

	protected const int DEHFOHHOLCG = 19;

	private float[] BFCKICBPMJM;

	public int DABCDPAEDEE
	{
		get
		{
			return BFCKICBPMJM.Length / 19 + 1;
		}
	}

	public abstract int ODHLEJHEBGD { get; }

	public FPOBLOBNHGG(int IJKENLLBMOJ)
	{
		if (IJKENLLBMOJ <= 0)
		{
			throw new ArgumentException("frameCount must be > 0: " + IJKENLLBMOJ, "frameCount");
		}
		BFCKICBPMJM = new float[(IJKENLLBMOJ - 1) * 19];
	}

	public abstract void FCHLOGCODOA(GCJKICAPOFL GDNININLMFD, float CGICCPOKJHB, float HFLODNLEGFL, ExposedList<DCBJAMHBAJB> ELMIMIMBNHP, float KBKMPEOMABI, BFCFMFBHBCH IFKBABBBDJM, ODPDBCNBOAK AJLDJAHHGOJ);

	public void PEAPBMCFLJN(int JHFDIBIBCPH)
	{
		BFCKICBPMJM[JHFDIBIBCPH * 19] = 0f;
	}

	public void FGGBGOFPDAD(int JHFDIBIBCPH)
	{
		BFCKICBPMJM[JHFDIBIBCPH * 19] = 1f;
	}

	public void MHALBIPKNGP(int JHFDIBIBCPH, float NCPCIBAPGLC, float JBALMLHCLFB, float BHGLMKKHPKI, float BPBDDGPNHLL)
	{
		float num = ((0f - NCPCIBAPGLC) * 2f + BHGLMKKHPKI) * 0.03f;
		float num2 = ((0f - JBALMLHCLFB) * 2f + BPBDDGPNHLL) * 0.03f;
		float num3 = ((NCPCIBAPGLC - BHGLMKKHPKI) * 3f + 1f) * 0.006f;
		float num4 = ((JBALMLHCLFB - BPBDDGPNHLL) * 3f + 1f) * 0.006f;
		float num5 = num * 2f + num3;
		float num6 = num2 * 2f + num4;
		float num7 = NCPCIBAPGLC * 0.3f + num + num3 * (1f / 6f);
		float num8 = JBALMLHCLFB * 0.3f + num2 + num4 * (1f / 6f);
		int i = JHFDIBIBCPH * 19;
		float[] bFCKICBPMJM = BFCKICBPMJM;
		bFCKICBPMJM[i++] = 2f;
		float num9 = num7;
		float num10 = num8;
		for (int num11 = i + 19 - 1; i < num11; i += 2)
		{
			bFCKICBPMJM[i] = num9;
			bFCKICBPMJM[i + 1] = num10;
			num7 += num5;
			num8 += num6;
			num5 += num3;
			num6 += num4;
			num9 += num7;
			num10 += num8;
		}
	}

	public float IFMKHGLKEMB(int JHFDIBIBCPH, float IFNDDLGGDHH)
	{
		IFNDDLGGDHH = EDBPEAKKANM.KHNPKKEKJDC(IFNDDLGGDHH, 0f, 1f);
		float[] bFCKICBPMJM = BFCKICBPMJM;
		int num = JHFDIBIBCPH * 19;
		float num2 = bFCKICBPMJM[num];
		if (num2 == 0f)
		{
			return IFNDDLGGDHH;
		}
		if (num2 == 1f)
		{
			return 0f;
		}
		num++;
		float num3 = 0f;
		int num4 = num;
		for (int num5 = num + 19 - 1; num < num5; num += 2)
		{
			num3 = bFCKICBPMJM[num];
			if (num3 >= IFNDDLGGDHH)
			{
				float num6;
				float num7;
				if (num == num4)
				{
					num6 = 0f;
					num7 = 0f;
				}
				else
				{
					num6 = bFCKICBPMJM[num - 2];
					num7 = bFCKICBPMJM[num - 1];
				}
				return num7 + (bFCKICBPMJM[num + 1] - num7) * (IFNDDLGGDHH - num6) / (num3 - num6);
			}
		}
		float num8 = bFCKICBPMJM[num - 1];
		return num8 + (1f - num8) * (IFNDDLGGDHH - num3) / (1f - num3);
	}

	public float AGEBHBNBPOK(int JHFDIBIBCPH)
	{
		return BFCKICBPMJM[JHFDIBIBCPH * 19];
	}
}
