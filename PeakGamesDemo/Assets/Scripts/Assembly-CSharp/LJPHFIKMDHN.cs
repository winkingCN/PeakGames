using Spine;

public class LJPHFIKMDHN : OAMNGFLKEFI
{
	private static int IMBEIFGCGOF = 0;

	private static readonly object EIKBBANMPEH = new object();

	internal readonly int BDKFNEDHAOJ;

	internal int[] LIKIOBHLHHF;

	internal float[] FHBFCAEGPOH;

	internal int MCCBDCEJDBC;

	public int EEFMIHDPJPG
	{
		get
		{
			return BDKFNEDHAOJ;
		}
	}

	public int[] PGACGAFEFHD
	{
		get
		{
			return LIKIOBHLHHF;
		}
		set
		{
			LIKIOBHLHHF = value;
		}
	}

	public float[] IAMHHPHNLHM
	{
		get
		{
			return FHBFCAEGPOH;
		}
		set
		{
			FHBFCAEGPOH = value;
		}
	}

	public int DBIIHGFAGJP
	{
		get
		{
			return MCCBDCEJDBC;
		}
		set
		{
			MCCBDCEJDBC = value;
		}
	}

	public LJPHFIKMDHN(string IOCMOCCFALN)
		: base(IOCMOCCFALN)
	{
		lock (EIKBBANMPEH)
		{
			BDKFNEDHAOJ = (IMBEIFGCGOF++ & 0xFFFF) << 11;
		}
	}

	public void EPLAHNOCDIB(LBBAMMPJKDA DFKJODFHCJB, float[] LBCIABCCMJB)
	{
		EPLAHNOCDIB(DFKJODFHCJB, 0, MCCBDCEJDBC, LBCIABCCMJB, 0);
	}

	public void EPLAHNOCDIB(LBBAMMPJKDA DFKJODFHCJB, int EHGOOEHDNMM, int ENMLICFLHAO, float[] LBCIABCCMJB, int IBNDGNOIEEF, int PPIOPCNCPNF = 2)
	{
		ENMLICFLHAO = IBNDGNOIEEF + (ENMLICFLHAO >> 1) * PPIOPCNCPNF;
		GCJKICAPOFL gDNININLMFD = DFKJODFHCJB.JEBEPBEGCCF.GDNININLMFD;
		ExposedList<float> aDAMNKAAPII = DFKJODFHCJB.ADAMNKAAPII;
		float[] array = FHBFCAEGPOH;
		int[] lIKIOBHLHHF = LIKIOBHLHHF;
		if (lIKIOBHLHHF == null)
		{
			if (aDAMNKAAPII.Count > 0)
			{
				array = aDAMNKAAPII.Items;
			}
			NBKCFDOMAPI jEBEPBEGCCF = DFKJODFHCJB.JEBEPBEGCCF;
			float pOFLEELFBPH = jEBEPBEGCCF.POFLEELFBPH;
			float mLMBGGJGOBP = jEBEPBEGCCF.MLMBGGJGOBP;
			float mNIMEAMHNMI = jEBEPBEGCCF.MNIMEAMHNMI;
			float bCIHLCMFAEK = jEBEPBEGCCF.BCIHLCMFAEK;
			float fMFABAKPMLB = jEBEPBEGCCF.FMFABAKPMLB;
			float eLNCCDELMMH = jEBEPBEGCCF.ELNCCDELMMH;
			int num = EHGOOEHDNMM;
			for (int i = IBNDGNOIEEF; i < ENMLICFLHAO; i += PPIOPCNCPNF)
			{
				float num2 = array[num];
				float num3 = array[num + 1];
				LBCIABCCMJB[i] = num2 * mNIMEAMHNMI + num3 * bCIHLCMFAEK + pOFLEELFBPH;
				LBCIABCCMJB[i + 1] = num2 * fMFABAKPMLB + num3 * eLNCCDELMMH + mLMBGGJGOBP;
				num += 2;
			}
			return;
		}
		int num4 = 0;
		int num5 = 0;
		for (int j = 0; j < EHGOOEHDNMM; j += 2)
		{
			int num6 = lIKIOBHLHHF[num4];
			num4 += num6 + 1;
			num5 += num6;
		}
		NBKCFDOMAPI[] items = gDNININLMFD.LIKIOBHLHHF.Items;
		if (aDAMNKAAPII.Count == 0)
		{
			int k = IBNDGNOIEEF;
			int num7 = num5 * 3;
			for (; k < ENMLICFLHAO; k += PPIOPCNCPNF)
			{
				float num8 = 0f;
				float num9 = 0f;
				int num10 = lIKIOBHLHHF[num4++];
				num10 += num4;
				while (num4 < num10)
				{
					NBKCFDOMAPI nBKCFDOMAPI = items[lIKIOBHLHHF[num4]];
					float num11 = array[num7];
					float num12 = array[num7 + 1];
					float num13 = array[num7 + 2];
					num8 += (num11 * nBKCFDOMAPI.MNIMEAMHNMI + num12 * nBKCFDOMAPI.BCIHLCMFAEK + nBKCFDOMAPI.POFLEELFBPH) * num13;
					num9 += (num11 * nBKCFDOMAPI.FMFABAKPMLB + num12 * nBKCFDOMAPI.ELNCCDELMMH + nBKCFDOMAPI.MLMBGGJGOBP) * num13;
					num4++;
					num7 += 3;
				}
				LBCIABCCMJB[k] = num8;
				LBCIABCCMJB[k + 1] = num9;
			}
			return;
		}
		float[] items2 = aDAMNKAAPII.Items;
		int l = IBNDGNOIEEF;
		int num14 = num5 * 3;
		int num15 = num5 << 1;
		for (; l < ENMLICFLHAO; l += PPIOPCNCPNF)
		{
			float num16 = 0f;
			float num17 = 0f;
			int num18 = lIKIOBHLHHF[num4++];
			num18 += num4;
			while (num4 < num18)
			{
				NBKCFDOMAPI nBKCFDOMAPI2 = items[lIKIOBHLHHF[num4]];
				float num19 = array[num14] + items2[num15];
				float num20 = array[num14 + 1] + items2[num15 + 1];
				float num21 = array[num14 + 2];
				num16 += (num19 * nBKCFDOMAPI2.MNIMEAMHNMI + num20 * nBKCFDOMAPI2.BCIHLCMFAEK + nBKCFDOMAPI2.POFLEELFBPH) * num21;
				num17 += (num19 * nBKCFDOMAPI2.FMFABAKPMLB + num20 * nBKCFDOMAPI2.ELNCCDELMMH + nBKCFDOMAPI2.MLMBGGJGOBP) * num21;
				num4++;
				num14 += 3;
				num15 += 2;
			}
			LBCIABCCMJB[l] = num16;
			LBCIABCCMJB[l + 1] = num17;
		}
	}

	public virtual bool OPPJKMMOONJ(LJPHFIKMDHN OLBMEPMFMPF)
	{
		return this == OLBMEPMFMPF;
	}
}
