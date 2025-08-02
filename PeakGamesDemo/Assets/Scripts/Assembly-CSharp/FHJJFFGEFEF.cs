using System;
using Spine;

public class FHJJFFGEFEF
{
	private ExposedList<BGNJIKECKDA> OGMKLHCFJFP = new ExposedList<BGNJIKECKDA>();

	private float BNBIHIPNELH;

	private float OPACLHFAHLP;

	private float DGCLNCKNIMA;

	private float JAAFIIJCDPN;

	public ExposedList<KBLNEHAAAJK> ADJBPAGNEKP { get; private set; }

	public ExposedList<BGNJIKECKDA> GPGICJBGECE { get; private set; }

	public float DGMLPAAGIJF
	{
		get
		{
			return BNBIHIPNELH;
		}
		set
		{
			BNBIHIPNELH = value;
		}
	}

	public float GIFMPDOHNCL
	{
		get
		{
			return OPACLHFAHLP;
		}
		set
		{
			OPACLHFAHLP = value;
		}
	}

	public float BFBEDEPAOLB
	{
		get
		{
			return DGCLNCKNIMA;
		}
		set
		{
			DGCLNCKNIMA = value;
		}
	}

	public float ADODLKFEBOH
	{
		get
		{
			return JAAFIIJCDPN;
		}
		set
		{
			JAAFIIJCDPN = value;
		}
	}

	public float EMFKAPJMDCC
	{
		get
		{
			return DGCLNCKNIMA - BNBIHIPNELH;
		}
	}

	public float FHAMOHDEGMK
	{
		get
		{
			return JAAFIIJCDPN - OPACLHFAHLP;
		}
	}

	public FHJJFFGEFEF()
	{
		ADJBPAGNEKP = new ExposedList<KBLNEHAAAJK>();
		GPGICJBGECE = new ExposedList<BGNJIKECKDA>();
	}

	public void BPAJGOINFNL(GCJKICAPOFL GDNININLMFD, bool EOLNGJIEFLK)
	{
		ExposedList<KBLNEHAAAJK> exposedList = ADJBPAGNEKP;
		ExposedList<BGNJIKECKDA> exposedList2 = GPGICJBGECE;
		ExposedList<LBBAMMPJKDA> mAKCMFCFDLP = GDNININLMFD.MAKCMFCFDLP;
		int count = mAKCMFCFDLP.Count;
		exposedList.BOPEPLONIFL();
		int i = 0;
		for (int count2 = exposedList2.Count; i < count2; i++)
		{
			OGMKLHCFJFP.JEACJNAKLDJ(exposedList2.Items[i]);
		}
		exposedList2.BOPEPLONIFL();
		for (int j = 0; j < count; j++)
		{
			LBBAMMPJKDA lBBAMMPJKDA = mAKCMFCFDLP.Items[j];
			KBLNEHAAAJK kBLNEHAAAJK = lBBAMMPJKDA.DFHHMKMLCFF as KBLNEHAAAJK;
			if (kBLNEHAAAJK != null)
			{
				exposedList.JEACJNAKLDJ(kBLNEHAAAJK);
				BGNJIKECKDA bGNJIKECKDA = null;
				int count3 = OGMKLHCFJFP.Count;
				if (count3 > 0)
				{
					bGNJIKECKDA = OGMKLHCFJFP.Items[count3 - 1];
					OGMKLHCFJFP.LIKBJGKHDOE(count3 - 1);
				}
				else
				{
					bGNJIKECKDA = new BGNJIKECKDA();
				}
				exposedList2.JEACJNAKLDJ(bGNJIKECKDA);
				int num = (bGNJIKECKDA.GMCGMPEEHJP = kBLNEHAAAJK.MCCBDCEJDBC);
				if (bGNJIKECKDA.IAMHHPHNLHM.Length < num)
				{
					bGNJIKECKDA.IAMHHPHNLHM = new float[num];
				}
				kBLNEHAAAJK.EPLAHNOCDIB(lBBAMMPJKDA, bGNJIKECKDA.IAMHHPHNLHM);
			}
		}
		if (EOLNGJIEFLK)
		{
			HMHKFOENCEO();
			return;
		}
		BNBIHIPNELH = -2.1474836E+09f;
		OPACLHFAHLP = -2.1474836E+09f;
		DGCLNCKNIMA = 2.1474836E+09f;
		JAAFIIJCDPN = 2.1474836E+09f;
	}

	private void HMHKFOENCEO()
	{
		float num = 2.1474836E+09f;
		float num2 = 2.1474836E+09f;
		float num3 = -2.1474836E+09f;
		float num4 = -2.1474836E+09f;
		ExposedList<BGNJIKECKDA> exposedList = GPGICJBGECE;
		int i = 0;
		for (int count = exposedList.Count; i < count; i++)
		{
			BGNJIKECKDA bGNJIKECKDA = exposedList.Items[i];
			float[] array = bGNJIKECKDA.IAMHHPHNLHM;
			int j = 0;
			for (int num5 = bGNJIKECKDA.GMCGMPEEHJP; j < num5; j += 2)
			{
				float val = array[j];
				float val2 = array[j + 1];
				num = Math.Min(num, val);
				num2 = Math.Min(num2, val2);
				num3 = Math.Max(num3, val);
				num4 = Math.Max(num4, val2);
			}
		}
		BNBIHIPNELH = num;
		OPACLHFAHLP = num2;
		DGCLNCKNIMA = num3;
		JAAFIIJCDPN = num4;
	}

	public bool KKEEAAKBNLJ(float AMFCENFNAJJ, float CNLILOEEBOJ)
	{
		return AMFCENFNAJJ >= BNBIHIPNELH && AMFCENFNAJJ <= DGCLNCKNIMA && CNLILOEEBOJ >= OPACLHFAHLP && CNLILOEEBOJ <= JAAFIIJCDPN;
	}

	public bool BAFMHEAGCII(float CMJGCHCINDK, float KLMIJJJNIIL, float DPGEOPKDNPM, float GPINCOHCNEI)
	{
		float bNBIHIPNELH = BNBIHIPNELH;
		float oPACLHFAHLP = OPACLHFAHLP;
		float dGCLNCKNIMA = DGCLNCKNIMA;
		float jAAFIIJCDPN = JAAFIIJCDPN;
		if ((CMJGCHCINDK <= bNBIHIPNELH && DPGEOPKDNPM <= bNBIHIPNELH) || (KLMIJJJNIIL <= oPACLHFAHLP && GPINCOHCNEI <= oPACLHFAHLP) || (CMJGCHCINDK >= dGCLNCKNIMA && DPGEOPKDNPM >= dGCLNCKNIMA) || (KLMIJJJNIIL >= jAAFIIJCDPN && GPINCOHCNEI >= jAAFIIJCDPN))
		{
			return false;
		}
		float num = (GPINCOHCNEI - KLMIJJJNIIL) / (DPGEOPKDNPM - CMJGCHCINDK);
		float num2 = num * (bNBIHIPNELH - CMJGCHCINDK) + KLMIJJJNIIL;
		if (num2 > oPACLHFAHLP && num2 < jAAFIIJCDPN)
		{
			return true;
		}
		num2 = num * (dGCLNCKNIMA - CMJGCHCINDK) + KLMIJJJNIIL;
		if (num2 > oPACLHFAHLP && num2 < jAAFIIJCDPN)
		{
			return true;
		}
		float num3 = (oPACLHFAHLP - KLMIJJJNIIL) / num + CMJGCHCINDK;
		if (num3 > bNBIHIPNELH && num3 < dGCLNCKNIMA)
		{
			return true;
		}
		num3 = (jAAFIIJCDPN - KLMIJJJNIIL) / num + CMJGCHCINDK;
		if (num3 > bNBIHIPNELH && num3 < dGCLNCKNIMA)
		{
			return true;
		}
		return false;
	}

	public bool MOEGJCCKHJD(FHJJFFGEFEF DJKHEGCCHFI)
	{
		return BNBIHIPNELH < DJKHEGCCHFI.DGCLNCKNIMA && DGCLNCKNIMA > DJKHEGCCHFI.BNBIHIPNELH && OPACLHFAHLP < DJKHEGCCHFI.JAAFIIJCDPN && JAAFIIJCDPN > DJKHEGCCHFI.OPACLHFAHLP;
	}

	public bool GKMPJGIJPPO(BGNJIKECKDA BGCDJHJPCLE, float AMFCENFNAJJ, float CNLILOEEBOJ)
	{
		float[] array = BGCDJHJPCLE.IAMHHPHNLHM;
		int num = BGCDJHJPCLE.GMCGMPEEHJP;
		int num2 = num - 2;
		bool flag = false;
		for (int i = 0; i < num; i += 2)
		{
			float num3 = array[i + 1];
			float num4 = array[num2 + 1];
			if ((num3 < CNLILOEEBOJ && num4 >= CNLILOEEBOJ) || (num4 < CNLILOEEBOJ && num3 >= CNLILOEEBOJ))
			{
				float num5 = array[i];
				if (num5 + (CNLILOEEBOJ - num3) / (num4 - num3) * (array[num2] - num5) < AMFCENFNAJJ)
				{
					flag = !flag;
				}
			}
			num2 = i;
		}
		return flag;
	}

	public KBLNEHAAAJK GKMPJGIJPPO(float AMFCENFNAJJ, float CNLILOEEBOJ)
	{
		ExposedList<BGNJIKECKDA> exposedList = GPGICJBGECE;
		int i = 0;
		for (int count = exposedList.Count; i < count; i++)
		{
			if (GKMPJGIJPPO(exposedList.Items[i], AMFCENFNAJJ, CNLILOEEBOJ))
			{
				return ADJBPAGNEKP.Items[i];
			}
		}
		return null;
	}

	public KBLNEHAAAJK IJAHJEEBOOD(float CMJGCHCINDK, float KLMIJJJNIIL, float DPGEOPKDNPM, float GPINCOHCNEI)
	{
		ExposedList<BGNJIKECKDA> exposedList = GPGICJBGECE;
		int i = 0;
		for (int count = exposedList.Count; i < count; i++)
		{
			if (IJAHJEEBOOD(exposedList.Items[i], CMJGCHCINDK, KLMIJJJNIIL, DPGEOPKDNPM, GPINCOHCNEI))
			{
				return ADJBPAGNEKP.Items[i];
			}
		}
		return null;
	}

	public bool IJAHJEEBOOD(BGNJIKECKDA BGCDJHJPCLE, float CMJGCHCINDK, float KLMIJJJNIIL, float DPGEOPKDNPM, float GPINCOHCNEI)
	{
		float[] array = BGCDJHJPCLE.IAMHHPHNLHM;
		int num = BGCDJHJPCLE.GMCGMPEEHJP;
		float num2 = CMJGCHCINDK - DPGEOPKDNPM;
		float num3 = KLMIJJJNIIL - GPINCOHCNEI;
		float num4 = CMJGCHCINDK * GPINCOHCNEI - KLMIJJJNIIL * DPGEOPKDNPM;
		float num5 = array[num - 2];
		float num6 = array[num - 1];
		for (int i = 0; i < num; i += 2)
		{
			float num7 = array[i];
			float num8 = array[i + 1];
			float num9 = num5 * num8 - num6 * num7;
			float num10 = num5 - num7;
			float num11 = num6 - num8;
			float num12 = num2 * num11 - num3 * num10;
			float num13 = (num4 * num10 - num2 * num9) / num12;
			if (((num13 >= num5 && num13 <= num7) || (num13 >= num7 && num13 <= num5)) && ((num13 >= CMJGCHCINDK && num13 <= DPGEOPKDNPM) || (num13 >= DPGEOPKDNPM && num13 <= CMJGCHCINDK)))
			{
				float num14 = (num4 * num11 - num3 * num9) / num12;
				if (((num14 >= num6 && num14 <= num8) || (num14 >= num8 && num14 <= num6)) && ((num14 >= KLMIJJJNIIL && num14 <= GPINCOHCNEI) || (num14 >= GPINCOHCNEI && num14 <= KLMIJJJNIIL)))
				{
					return true;
				}
			}
			num5 = num7;
			num6 = num8;
		}
		return false;
	}

	public BGNJIKECKDA JFIFLBFBBGD(KBLNEHAAAJK DFHHMKMLCFF)
	{
		int num = ADJBPAGNEKP.NFLFPHCMIOK(DFHHMKMLCFF);
		return (num != -1) ? GPGICJBGECE.Items[num] : null;
	}
}
