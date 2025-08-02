using System;
using Spine;

public class KNKKDGIBGLM : MGHNLJBAHKB, PMGDFPKMKNH
{
	private const int KPMOPBIENBP = -1;

	private const int HLEEAEFMICP = -2;

	private const int GGOIJLOBHGC = -3;

	private const float EIAGCAOPCGC = 1E-05f;

	internal GJNEKNOKICF MBBPBGHKLJM;

	internal ExposedList<NBKCFDOMAPI> LIKIOBHLHHF;

	internal LBBAMMPJKDA CAEMELGEOAE;

	internal float LDMDBPLADGD;

	internal float ILNOGLMCFMC;

	internal float OIBAIJIPGOM;

	internal float DHNKOEMONHP;

	internal ExposedList<float> KBALBAGNNFO = new ExposedList<float>();

	internal ExposedList<float> BPIMLJLPLJG = new ExposedList<float>();

	internal ExposedList<float> EGIALOFDBIE = new ExposedList<float>();

	internal ExposedList<float> BFCKICBPMJM = new ExposedList<float>();

	internal ExposedList<float> BFGGGEPJGOI = new ExposedList<float>();

	internal float[] ABBKELBADFF = new float[10];

	public int BHIJCAOHDCM
	{
		get
		{
			return MBBPBGHKLJM.CMAJLIAELDP;
		}
	}

	public float LJCIBEOLCHF
	{
		get
		{
			return LDMDBPLADGD;
		}
		set
		{
			LDMDBPLADGD = value;
		}
	}

	public float ODCLPEPDIJP
	{
		get
		{
			return ILNOGLMCFMC;
		}
		set
		{
			ILNOGLMCFMC = value;
		}
	}

	public float LAEMDLJOAAP
	{
		get
		{
			return OIBAIJIPGOM;
		}
		set
		{
			OIBAIJIPGOM = value;
		}
	}

	public float DDLNGEFIKCK
	{
		get
		{
			return DHNKOEMONHP;
		}
		set
		{
			DHNKOEMONHP = value;
		}
	}

	public ExposedList<NBKCFDOMAPI> PGACGAFEFHD
	{
		get
		{
			return LIKIOBHLHHF;
		}
	}

	public LBBAMMPJKDA IPLKKJOIMPM
	{
		get
		{
			return CAEMELGEOAE;
		}
		set
		{
			CAEMELGEOAE = value;
		}
	}

	public GJNEKNOKICF LJDLCPHOBHB
	{
		get
		{
			return MBBPBGHKLJM;
		}
	}

	public KNKKDGIBGLM(GJNEKNOKICF MBBPBGHKLJM, GCJKICAPOFL GDNININLMFD)
	{
		if (MBBPBGHKLJM == null)
		{
			throw new ArgumentNullException("data", "data cannot be null.");
		}
		if (GDNININLMFD == null)
		{
			throw new ArgumentNullException("skeleton", "skeleton cannot be null.");
		}
		this.MBBPBGHKLJM = MBBPBGHKLJM;
		LIKIOBHLHHF = new ExposedList<NBKCFDOMAPI>(MBBPBGHKLJM.PGACGAFEFHD.Count);
		using (ExposedList<GPJIPDIEIIL>.Enumerator enumerator = MBBPBGHKLJM.LIKIOBHLHHF.FIFMNBJLBFK())
		{
			while (enumerator.MoveNext())
			{
				GPJIPDIEIIL current = enumerator.Current;
				LIKIOBHLHHF.JEACJNAKLDJ(GDNININLMFD.NMLBCOPEEDC(current.IOCMOCCFALN));
			}
		}
		CAEMELGEOAE = GDNININLMFD.MEKLNNENPDK(MBBPBGHKLJM.CAEMELGEOAE.IOCMOCCFALN);
		LDMDBPLADGD = MBBPBGHKLJM.LDMDBPLADGD;
		ILNOGLMCFMC = MBBPBGHKLJM.ILNOGLMCFMC;
		OIBAIJIPGOM = MBBPBGHKLJM.OIBAIJIPGOM;
		DHNKOEMONHP = MBBPBGHKLJM.DHNKOEMONHP;
	}

	public void FCHLOGCODOA()
	{
		BPAJGOINFNL();
	}

	public void BPAJGOINFNL()
	{
		GMLCOKFENFN gMLCOKFENFN = CAEMELGEOAE.AIKFOHCPLKG as GMLCOKFENFN;
		if (gMLCOKFENFN == null)
		{
			return;
		}
		float oIBAIJIPGOM = OIBAIJIPGOM;
		float dHNKOEMONHP = DHNKOEMONHP;
		bool flag = dHNKOEMONHP > 0f;
		bool flag2 = oIBAIJIPGOM > 0f;
		if (!flag && !flag2)
		{
			return;
		}
		GJNEKNOKICF mBBPBGHKLJM = MBBPBGHKLJM;
		OIGFPANDDIM eNMOCNJMBKD = mBBPBGHKLJM.ENMOCNJMBKD;
		bool flag3 = eNMOCNJMBKD == OIGFPANDDIM.Length;
		NOKBMFOFOMJ hCNEABGHJMH = mBBPBGHKLJM.HCNEABGHJMH;
		bool flag4 = hCNEABGHJMH == NOKBMFOFOMJ.Tangent;
		bool flag5 = hCNEABGHJMH == NOKBMFOFOMJ.ChainScale;
		int count = LIKIOBHLHHF.Count;
		int num = ((!flag4) ? (count + 1) : count);
		NBKCFDOMAPI[] items = LIKIOBHLHHF.Items;
		ExposedList<float> exposedList = KBALBAGNNFO.NKMKBLFBOFC(num);
		ExposedList<float> exposedList2 = null;
		float iLNOGLMCFMC = ILNOGLMCFMC;
		if (flag5 || flag3)
		{
			if (flag5)
			{
				exposedList2 = BFGGGEPJGOI.NKMKBLFBOFC(count);
			}
			int num2 = 0;
			int num3 = num - 1;
			while (num2 < num3)
			{
				NBKCFDOMAPI nBKCFDOMAPI = items[num2];
				float eOFAGACBNFP = nBKCFDOMAPI.MBBPBGHKLJM.EOFAGACBNFP;
				if (eOFAGACBNFP < 1E-05f)
				{
					if (flag5)
					{
						exposedList2.Items[num2] = 0f;
					}
					exposedList.Items[++num2] = 0f;
					continue;
				}
				float num4 = eOFAGACBNFP * nBKCFDOMAPI.MNIMEAMHNMI;
				float num5 = eOFAGACBNFP * nBKCFDOMAPI.FMFABAKPMLB;
				float num6 = (float)Math.Sqrt(num4 * num4 + num5 * num5);
				if (flag5)
				{
					exposedList2.Items[num2] = num6;
				}
				exposedList.Items[++num2] = ((!flag3) ? iLNOGLMCFMC : (eOFAGACBNFP + iLNOGLMCFMC)) * num6 / eOFAGACBNFP;
			}
		}
		else
		{
			for (int i = 1; i < num; i++)
			{
				exposedList.Items[i] = iLNOGLMCFMC;
			}
		}
		float[] array = GPOFBOHHGLJ(gMLCOKFENFN, num, flag4, mBBPBGHKLJM.FMJFEKINFLF == KMDGGFDOOPL.Percent, eNMOCNJMBKD == OIGFPANDDIM.Percent);
		float num7 = array[0];
		float num8 = array[1];
		float num9 = mBBPBGHKLJM.HCFAKEOFMPM;
		bool flag6;
		if (num9 == 0f)
		{
			flag6 = hCNEABGHJMH == NOKBMFOFOMJ.Chain;
		}
		else
		{
			flag6 = false;
			NBKCFDOMAPI jEBEPBEGCCF = CAEMELGEOAE.JEBEPBEGCCF;
			num9 *= ((!(jEBEPBEGCCF.MNIMEAMHNMI * jEBEPBEGCCF.ELNCCDELMMH - jEBEPBEGCCF.BCIHLCMFAEK * jEBEPBEGCCF.FMFABAKPMLB > 0f)) ? (-(float)Math.PI / 180f) : ((float)Math.PI / 180f));
		}
		int num10 = 0;
		int num11 = 3;
		while (num10 < count)
		{
			NBKCFDOMAPI nBKCFDOMAPI2 = items[num10];
			nBKCFDOMAPI2.POFLEELFBPH += (num7 - nBKCFDOMAPI2.POFLEELFBPH) * dHNKOEMONHP;
			nBKCFDOMAPI2.MLMBGGJGOBP += (num8 - nBKCFDOMAPI2.MLMBGGJGOBP) * dHNKOEMONHP;
			float num12 = array[num11];
			float num13 = array[num11 + 1];
			float num14 = num12 - num7;
			float num15 = num13 - num8;
			if (flag5)
			{
				float num16 = exposedList2.Items[num10];
				if (num16 >= 1E-05f)
				{
					float num17 = ((float)Math.Sqrt(num14 * num14 + num15 * num15) / num16 - 1f) * oIBAIJIPGOM + 1f;
					nBKCFDOMAPI2.MNIMEAMHNMI *= num17;
					nBKCFDOMAPI2.FMFABAKPMLB *= num17;
				}
			}
			num7 = num12;
			num8 = num13;
			if (flag2)
			{
				float mNIMEAMHNMI = nBKCFDOMAPI2.MNIMEAMHNMI;
				float bCIHLCMFAEK = nBKCFDOMAPI2.BCIHLCMFAEK;
				float fMFABAKPMLB = nBKCFDOMAPI2.FMFABAKPMLB;
				float eLNCCDELMMH = nBKCFDOMAPI2.ELNCCDELMMH;
				float num18 = (flag4 ? array[num11 - 1] : ((!(exposedList.Items[num10 + 1] < 1E-05f)) ? EDBPEAKKANM.FKGOMHJAJMK(num15, num14) : array[num11 + 2]));
				num18 -= EDBPEAKKANM.FKGOMHJAJMK(fMFABAKPMLB, mNIMEAMHNMI);
				float num19;
				float num20;
				if (flag6)
				{
					num19 = EDBPEAKKANM.KPMBBEFLOHE(num18);
					num20 = EDBPEAKKANM.OADPLHLHEEN(num18);
					float eOFAGACBNFP2 = nBKCFDOMAPI2.MBBPBGHKLJM.EOFAGACBNFP;
					num7 += (eOFAGACBNFP2 * (num19 * mNIMEAMHNMI - num20 * fMFABAKPMLB) - num14) * oIBAIJIPGOM;
					num8 += (eOFAGACBNFP2 * (num20 * mNIMEAMHNMI + num19 * fMFABAKPMLB) - num15) * oIBAIJIPGOM;
				}
				else
				{
					num18 += num9;
				}
				if (num18 > (float)Math.PI)
				{
					num18 -= (float)Math.PI * 2f;
				}
				else if (num18 < -(float)Math.PI)
				{
					num18 += (float)Math.PI * 2f;
				}
				num18 *= oIBAIJIPGOM;
				num19 = EDBPEAKKANM.KPMBBEFLOHE(num18);
				num20 = EDBPEAKKANM.OADPLHLHEEN(num18);
				nBKCFDOMAPI2.MNIMEAMHNMI = num19 * mNIMEAMHNMI - num20 * fMFABAKPMLB;
				nBKCFDOMAPI2.BCIHLCMFAEK = num19 * bCIHLCMFAEK - num20 * eLNCCDELMMH;
				nBKCFDOMAPI2.FMFABAKPMLB = num20 * mNIMEAMHNMI + num19 * fMFABAKPMLB;
				nBKCFDOMAPI2.ELNCCDELMMH = num20 * bCIHLCMFAEK + num19 * eLNCCDELMMH;
			}
			nBKCFDOMAPI2.LPDFKGBMKOH = false;
			num10++;
			num11 += 3;
		}
	}

	private float[] GPOFBOHHGLJ(GMLCOKFENFN LCCKDPIBKPJ, int JJGNLJCBMBL, bool ADGCBACGHGI, bool IBICDAEIBJM, bool HAIMEJDOEIM)
	{
		LBBAMMPJKDA cAEMELGEOAE = CAEMELGEOAE;
		float num = LDMDBPLADGD;
		float[] items = KBALBAGNNFO.Items;
		float[] items2 = BPIMLJLPLJG.NKMKBLFBOFC(JJGNLJCBMBL * 3 + 2).Items;
		bool flag = LCCKDPIBKPJ.IHLIGFJLDLJ;
		int num2 = LCCKDPIBKPJ.DBIIHGFAGJP;
		int num3 = num2 / 6;
		int num4 = -1;
		float[] items3;
		float num5;
		if (!LCCKDPIBKPJ.LNCKGABJBIJ)
		{
			float[] array = LCCKDPIBKPJ.GHEILOANJBM;
			num3 -= (flag ? 1 : 2);
			num5 = array[num3];
			if (IBICDAEIBJM)
			{
				num *= num5;
			}
			if (HAIMEJDOEIM)
			{
				for (int i = 0; i < JJGNLJCBMBL; i++)
				{
					items[i] *= num5;
				}
			}
			items3 = EGIALOFDBIE.NKMKBLFBOFC(8).Items;
			int j = 0;
			int k = 0;
			int num6 = 0;
			for (; j < JJGNLJCBMBL; j++, k += 3)
			{
				float num7 = items[j];
				num += num7;
				float num8 = num;
				if (flag)
				{
					num8 %= num5;
					if (num8 < 0f)
					{
						num8 += num5;
					}
					num6 = 0;
				}
				else
				{
					if (num8 < 0f)
					{
						if (num4 != -2)
						{
							num4 = -2;
							LCCKDPIBKPJ.EPLAHNOCDIB(cAEMELGEOAE, 2, 4, items3, 0);
						}
						CBJPJHOIBGN(num8, items3, 0, items2, k);
						continue;
					}
					if (num8 > num5)
					{
						if (num4 != -3)
						{
							num4 = -3;
							LCCKDPIBKPJ.EPLAHNOCDIB(cAEMELGEOAE, num2 - 6, 4, items3, 0);
						}
						DECCDADLGOJ(num8 - num5, items3, 0, items2, k);
						continue;
					}
				}
				float num9;
				while (true)
				{
					num9 = array[num6];
					if (!(num8 > num9))
					{
						break;
					}
					num6++;
				}
				if (num6 == 0)
				{
					num8 /= num9;
				}
				else
				{
					float num10 = array[num6 - 1];
					num8 = (num8 - num10) / (num9 - num10);
				}
				if (num6 != num4)
				{
					num4 = num6;
					if (flag && num6 == num3)
					{
						LCCKDPIBKPJ.EPLAHNOCDIB(cAEMELGEOAE, num2 - 4, 4, items3, 0);
						LCCKDPIBKPJ.EPLAHNOCDIB(cAEMELGEOAE, 0, 4, items3, 4);
					}
					else
					{
						LCCKDPIBKPJ.EPLAHNOCDIB(cAEMELGEOAE, num6 * 6 + 2, 8, items3, 0);
					}
				}
				GEBFFDFOEFJ(num8, items3[0], items3[1], items3[2], items3[3], items3[4], items3[5], items3[6], items3[7], items2, k, ADGCBACGHGI || (j > 0 && num7 < 1E-05f));
			}
			return items2;
		}
		if (flag)
		{
			num2 += 2;
			items3 = EGIALOFDBIE.NKMKBLFBOFC(num2).Items;
			LCCKDPIBKPJ.EPLAHNOCDIB(cAEMELGEOAE, 2, num2 - 4, items3, 0);
			LCCKDPIBKPJ.EPLAHNOCDIB(cAEMELGEOAE, 0, 2, items3, num2 - 4);
			items3[num2 - 2] = items3[0];
			items3[num2 - 1] = items3[1];
		}
		else
		{
			num3--;
			num2 -= 4;
			items3 = EGIALOFDBIE.NKMKBLFBOFC(num2).Items;
			LCCKDPIBKPJ.EPLAHNOCDIB(cAEMELGEOAE, 2, num2, items3, 0);
		}
		float[] items4 = BFCKICBPMJM.NKMKBLFBOFC(num3).Items;
		num5 = 0f;
		float num11 = items3[0];
		float num12 = items3[1];
		float num13 = 0f;
		float num14 = 0f;
		float num15 = 0f;
		float num16 = 0f;
		float num17 = 0f;
		float num18 = 0f;
		int num19 = 0;
		int num20 = 2;
		while (num19 < num3)
		{
			num13 = items3[num20];
			num14 = items3[num20 + 1];
			num15 = items3[num20 + 2];
			num16 = items3[num20 + 3];
			num17 = items3[num20 + 4];
			num18 = items3[num20 + 5];
			float num21 = (num11 - num13 * 2f + num15) * 0.1875f;
			float num22 = (num12 - num14 * 2f + num16) * 0.1875f;
			float num23 = ((num13 - num15) * 3f - num11 + num17) * (3f / 32f);
			float num24 = ((num14 - num16) * 3f - num12 + num18) * (3f / 32f);
			float num25 = num21 * 2f + num23;
			float num26 = num22 * 2f + num24;
			float num27 = (num13 - num11) * 0.75f + num21 + num23 * (1f / 6f);
			float num28 = (num14 - num12) * 0.75f + num22 + num24 * (1f / 6f);
			num5 += (float)Math.Sqrt(num27 * num27 + num28 * num28);
			num27 += num25;
			num28 += num26;
			num25 += num23;
			num26 += num24;
			num5 += (float)Math.Sqrt(num27 * num27 + num28 * num28);
			num27 += num25;
			num28 += num26;
			num5 += (float)Math.Sqrt(num27 * num27 + num28 * num28);
			num27 += num25 + num23;
			num28 += num26 + num24;
			num5 = (items4[num19] = num5 + (float)Math.Sqrt(num27 * num27 + num28 * num28));
			num11 = num17;
			num12 = num18;
			num19++;
			num20 += 6;
		}
		if (IBICDAEIBJM)
		{
			num *= num5;
		}
		if (HAIMEJDOEIM)
		{
			for (int l = 0; l < JJGNLJCBMBL; l++)
			{
				items[l] *= num5;
			}
		}
		float[] aBBKELBADFF = ABBKELBADFF;
		float num29 = 0f;
		int m = 0;
		int n = 0;
		int num30 = 0;
		int num31 = 0;
		for (; m < JJGNLJCBMBL; m++, n += 3)
		{
			float num32 = items[m];
			num += num32;
			float num33 = num;
			if (flag)
			{
				num33 %= num5;
				if (num33 < 0f)
				{
					num33 += num5;
				}
				num30 = 0;
			}
			else
			{
				if (num33 < 0f)
				{
					CBJPJHOIBGN(num33, items3, 0, items2, n);
					continue;
				}
				if (num33 > num5)
				{
					DECCDADLGOJ(num33 - num5, items3, num2 - 4, items2, n);
					continue;
				}
			}
			float num34;
			while (true)
			{
				num34 = items4[num30];
				if (!(num33 > num34))
				{
					break;
				}
				num30++;
			}
			if (num30 == 0)
			{
				num33 /= num34;
			}
			else
			{
				float num35 = items4[num30 - 1];
				num33 = (num33 - num35) / (num34 - num35);
			}
			if (num30 != num4)
			{
				num4 = num30;
				int num36 = num30 * 6;
				num11 = items3[num36];
				num12 = items3[num36 + 1];
				num13 = items3[num36 + 2];
				num14 = items3[num36 + 3];
				num15 = items3[num36 + 4];
				num16 = items3[num36 + 5];
				num17 = items3[num36 + 6];
				num18 = items3[num36 + 7];
				float num21 = (num11 - num13 * 2f + num15) * 0.03f;
				float num22 = (num12 - num14 * 2f + num16) * 0.03f;
				float num23 = ((num13 - num15) * 3f - num11 + num17) * 0.006f;
				float num24 = ((num14 - num16) * 3f - num12 + num18) * 0.006f;
				float num25 = num21 * 2f + num23;
				float num26 = num22 * 2f + num24;
				float num27 = (num13 - num11) * 0.3f + num21 + num23 * (1f / 6f);
				float num28 = (num14 - num12) * 0.3f + num22 + num24 * (1f / 6f);
				num29 = (aBBKELBADFF[0] = (float)Math.Sqrt(num27 * num27 + num28 * num28));
				for (num36 = 1; num36 < 8; num36++)
				{
					num27 += num25;
					num28 += num26;
					num25 += num23;
					num26 += num24;
					num29 = (aBBKELBADFF[num36] = num29 + (float)Math.Sqrt(num27 * num27 + num28 * num28));
				}
				num27 += num25;
				num28 += num26;
				num29 = (aBBKELBADFF[8] = num29 + (float)Math.Sqrt(num27 * num27 + num28 * num28));
				num27 += num25 + num23;
				num28 += num26 + num24;
				num29 = (aBBKELBADFF[9] = num29 + (float)Math.Sqrt(num27 * num27 + num28 * num28));
				num31 = 0;
			}
			num33 *= num29;
			float num37;
			while (true)
			{
				num37 = aBBKELBADFF[num31];
				if (!(num33 > num37))
				{
					break;
				}
				num31++;
			}
			if (num31 == 0)
			{
				num33 /= num37;
			}
			else
			{
				float num38 = aBBKELBADFF[num31 - 1];
				num33 = (float)num31 + (num33 - num38) / (num37 - num38);
			}
			GEBFFDFOEFJ(num33 * 0.1f, num11, num12, num13, num14, num15, num16, num17, num18, items2, n, ADGCBACGHGI || (m > 0 && num32 < 1E-05f));
		}
		return items2;
	}

	private static void CBJPJHOIBGN(float HPHBDNBJPHB, float[] HPDOHKKPDBF, int PLCFEOMGCFK, float[] BILGCJNPJGJ, int AACCPLMFDIE)
	{
		float num = HPDOHKKPDBF[PLCFEOMGCFK];
		float num2 = HPDOHKKPDBF[PLCFEOMGCFK + 1];
		float aMFCENFNAJJ = HPDOHKKPDBF[PLCFEOMGCFK + 2] - num;
		float cNLILOEEBOJ = HPDOHKKPDBF[PLCFEOMGCFK + 3] - num2;
		float num3 = EDBPEAKKANM.FKGOMHJAJMK(cNLILOEEBOJ, aMFCENFNAJJ);
		BILGCJNPJGJ[AACCPLMFDIE] = num + HPHBDNBJPHB * EDBPEAKKANM.KPMBBEFLOHE(num3);
		BILGCJNPJGJ[AACCPLMFDIE + 1] = num2 + HPHBDNBJPHB * EDBPEAKKANM.OADPLHLHEEN(num3);
		BILGCJNPJGJ[AACCPLMFDIE + 2] = num3;
	}

	private static void DECCDADLGOJ(float HPHBDNBJPHB, float[] HPDOHKKPDBF, int PLCFEOMGCFK, float[] BILGCJNPJGJ, int AACCPLMFDIE)
	{
		float num = HPDOHKKPDBF[PLCFEOMGCFK + 2];
		float num2 = HPDOHKKPDBF[PLCFEOMGCFK + 3];
		float aMFCENFNAJJ = num - HPDOHKKPDBF[PLCFEOMGCFK];
		float cNLILOEEBOJ = num2 - HPDOHKKPDBF[PLCFEOMGCFK + 1];
		float num3 = EDBPEAKKANM.FKGOMHJAJMK(cNLILOEEBOJ, aMFCENFNAJJ);
		BILGCJNPJGJ[AACCPLMFDIE] = num + HPHBDNBJPHB * EDBPEAKKANM.KPMBBEFLOHE(num3);
		BILGCJNPJGJ[AACCPLMFDIE + 1] = num2 + HPHBDNBJPHB * EDBPEAKKANM.OADPLHLHEEN(num3);
		BILGCJNPJGJ[AACCPLMFDIE + 2] = num3;
	}

	private static void GEBFFDFOEFJ(float HPHBDNBJPHB, float CMJGCHCINDK, float KLMIJJJNIIL, float NCPCIBAPGLC, float JBALMLHCLFB, float BHGLMKKHPKI, float BPBDDGPNHLL, float DPGEOPKDNPM, float GPINCOHCNEI, float[] BILGCJNPJGJ, int AACCPLMFDIE, bool ADGCBACGHGI)
	{
		if (HPHBDNBJPHB < 1E-05f || float.IsNaN(HPHBDNBJPHB))
		{
			HPHBDNBJPHB = 1E-05f;
		}
		float num = HPHBDNBJPHB * HPHBDNBJPHB;
		float num2 = num * HPHBDNBJPHB;
		float num3 = 1f - HPHBDNBJPHB;
		float num4 = num3 * num3;
		float num5 = num4 * num3;
		float num6 = num3 * HPHBDNBJPHB;
		float num7 = num6 * 3f;
		float num8 = num3 * num7;
		float num9 = num7 * HPHBDNBJPHB;
		float num10 = CMJGCHCINDK * num5 + NCPCIBAPGLC * num8 + BHGLMKKHPKI * num9 + DPGEOPKDNPM * num2;
		float num11 = KLMIJJJNIIL * num5 + JBALMLHCLFB * num8 + BPBDDGPNHLL * num9 + GPINCOHCNEI * num2;
		BILGCJNPJGJ[AACCPLMFDIE] = num10;
		BILGCJNPJGJ[AACCPLMFDIE + 1] = num11;
		if (ADGCBACGHGI)
		{
			BILGCJNPJGJ[AACCPLMFDIE + 2] = (float)Math.Atan2(num11 - (KLMIJJJNIIL * num4 + JBALMLHCLFB * num6 * 2f + BPBDDGPNHLL * num), num10 - (CMJGCHCINDK * num4 + NCPCIBAPGLC * num6 * 2f + BHGLMKKHPKI * num));
		}
	}
}
