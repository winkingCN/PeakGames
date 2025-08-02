using System;
using Spine;

public class JICANJGGKNH : MGHNLJBAHKB, PMGDFPKMKNH
{
	internal BMELPEKHKKJ MBBPBGHKLJM;

	internal ExposedList<NBKCFDOMAPI> LIKIOBHLHHF = new ExposedList<NBKCFDOMAPI>();

	internal NBKCFDOMAPI CAEMELGEOAE;

	internal float MIIHPKNIPAB;

	internal int IEFNLGDAINN;

	public BMELPEKHKKJ LJDLCPHOBHB
	{
		get
		{
			return MBBPBGHKLJM;
		}
	}

	public int BHIJCAOHDCM
	{
		get
		{
			return MBBPBGHKLJM.CMAJLIAELDP;
		}
	}

	public ExposedList<NBKCFDOMAPI> PGACGAFEFHD
	{
		get
		{
			return LIKIOBHLHHF;
		}
	}

	public NBKCFDOMAPI IPLKKJOIMPM
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

	public int AGEINJMHJAA
	{
		get
		{
			return IEFNLGDAINN;
		}
		set
		{
			IEFNLGDAINN = value;
		}
	}

	public float FABMAMDLDKF
	{
		get
		{
			return MIIHPKNIPAB;
		}
		set
		{
			MIIHPKNIPAB = value;
		}
	}

	public JICANJGGKNH(BMELPEKHKKJ MBBPBGHKLJM, GCJKICAPOFL GDNININLMFD)
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
		MIIHPKNIPAB = MBBPBGHKLJM.MIIHPKNIPAB;
		IEFNLGDAINN = MBBPBGHKLJM.IEFNLGDAINN;
		LIKIOBHLHHF = new ExposedList<NBKCFDOMAPI>(MBBPBGHKLJM.LIKIOBHLHHF.Count);
		foreach (GPJIPDIEIIL item in MBBPBGHKLJM.LIKIOBHLHHF)
		{
			LIKIOBHLHHF.JEACJNAKLDJ(GDNININLMFD.NMLBCOPEEDC(item.IOCMOCCFALN));
		}
		CAEMELGEOAE = GDNININLMFD.NMLBCOPEEDC(MBBPBGHKLJM.CAEMELGEOAE.IOCMOCCFALN);
	}

	public void FCHLOGCODOA()
	{
		BPAJGOINFNL();
	}

	public void BPAJGOINFNL()
	{
		NBKCFDOMAPI cAEMELGEOAE = CAEMELGEOAE;
		ExposedList<NBKCFDOMAPI> lIKIOBHLHHF = LIKIOBHLHHF;
		switch (lIKIOBHLHHF.Count)
		{
		case 1:
			FCHLOGCODOA(lIKIOBHLHHF.Items[0], cAEMELGEOAE.POFLEELFBPH, cAEMELGEOAE.MLMBGGJGOBP, MIIHPKNIPAB);
			break;
		case 2:
			FCHLOGCODOA(lIKIOBHLHHF.Items[0], lIKIOBHLHHF.Items[1], cAEMELGEOAE.POFLEELFBPH, cAEMELGEOAE.MLMBGGJGOBP, IEFNLGDAINN, MIIHPKNIPAB);
			break;
		}
	}

	public override string ToString()
	{
		return MBBPBGHKLJM.IOCMOCCFALN;
	}

	public static void FCHLOGCODOA(NBKCFDOMAPI JEBEPBEGCCF, float JPGGJFPBDMF, float OKOGONJIBIM, float KBKMPEOMABI)
	{
		if (!JEBEPBEGCCF.LPDFKGBMKOH)
		{
			JEBEPBEGCCF.CKOPOJMGKOC();
		}
		NBKCFDOMAPI lIMMFGDCLAB = JEBEPBEGCCF.LIMMFGDCLAB;
		float num = 1f / (lIMMFGDCLAB.MNIMEAMHNMI * lIMMFGDCLAB.ELNCCDELMMH - lIMMFGDCLAB.BCIHLCMFAEK * lIMMFGDCLAB.FMFABAKPMLB);
		float num2 = JPGGJFPBDMF - lIMMFGDCLAB.POFLEELFBPH;
		float num3 = OKOGONJIBIM - lIMMFGDCLAB.MLMBGGJGOBP;
		float num4 = (num2 * lIMMFGDCLAB.ELNCCDELMMH - num3 * lIMMFGDCLAB.BCIHLCMFAEK) * num - JEBEPBEGCCF.LMEFHJAFJLG;
		float num5 = (num3 * lIMMFGDCLAB.MNIMEAMHNMI - num2 * lIMMFGDCLAB.FMFABAKPMLB) * num - JEBEPBEGCCF.PEAEDDOIAGN;
		float num6 = (float)Math.Atan2(num5, num4) * (180f / (float)Math.PI) - JEBEPBEGCCF.AIKGKNBOGCL - JEBEPBEGCCF.CLDDKKCPILB;
		if (JEBEPBEGCCF.IOLDFODFHAL < 0f)
		{
			num6 += 180f;
		}
		if (num6 > 180f)
		{
			num6 -= 360f;
		}
		else if (num6 < -180f)
		{
			num6 += 360f;
		}
		JEBEPBEGCCF.DGCKCELHAEG(JEBEPBEGCCF.LMEFHJAFJLG, JEBEPBEGCCF.PEAEDDOIAGN, JEBEPBEGCCF.CLDDKKCPILB + num6 * KBKMPEOMABI, JEBEPBEGCCF.IOLDFODFHAL, JEBEPBEGCCF.JBMAGEEAFKM, JEBEPBEGCCF.AIKGKNBOGCL, JEBEPBEGCCF.NIFFEDCOKDI);
	}

	public static void FCHLOGCODOA(NBKCFDOMAPI LIMMFGDCLAB, NBKCFDOMAPI MNCHGLKLBOD, float JPGGJFPBDMF, float OKOGONJIBIM, int NDHEHJIICPK, float KBKMPEOMABI)
	{
		if (KBKMPEOMABI == 0f)
		{
			MNCHGLKLBOD.DGCKCELHAEG();
			return;
		}
		if (!LIMMFGDCLAB.LPDFKGBMKOH)
		{
			LIMMFGDCLAB.CKOPOJMGKOC();
		}
		if (!MNCHGLKLBOD.LPDFKGBMKOH)
		{
			MNCHGLKLBOD.CKOPOJMGKOC();
		}
		float lMEFHJAFJLG = LIMMFGDCLAB.LMEFHJAFJLG;
		float pEAEDDOIAGN = LIMMFGDCLAB.PEAEDDOIAGN;
		float num = LIMMFGDCLAB.IOLDFODFHAL;
		float num2 = LIMMFGDCLAB.JBMAGEEAFKM;
		float num3 = MNCHGLKLBOD.IOLDFODFHAL;
		int num4;
		int num5;
		if (num < 0f)
		{
			num = 0f - num;
			num4 = 180;
			num5 = -1;
		}
		else
		{
			num4 = 0;
			num5 = 1;
		}
		if (num2 < 0f)
		{
			num2 = 0f - num2;
			num5 = -num5;
		}
		int num6;
		if (num3 < 0f)
		{
			num3 = 0f - num3;
			num6 = 180;
		}
		else
		{
			num6 = 0;
		}
		float lMEFHJAFJLG2 = MNCHGLKLBOD.LMEFHJAFJLG;
		float mNIMEAMHNMI = LIMMFGDCLAB.MNIMEAMHNMI;
		float bCIHLCMFAEK = LIMMFGDCLAB.BCIHLCMFAEK;
		float fMFABAKPMLB = LIMMFGDCLAB.FMFABAKPMLB;
		float eLNCCDELMMH = LIMMFGDCLAB.ELNCCDELMMH;
		bool flag = Math.Abs(num - num2) <= 0.0001f;
		float num7;
		float num8;
		float num9;
		if (!flag)
		{
			num7 = 0f;
			num8 = mNIMEAMHNMI * lMEFHJAFJLG2 + LIMMFGDCLAB.POFLEELFBPH;
			num9 = fMFABAKPMLB * lMEFHJAFJLG2 + LIMMFGDCLAB.MLMBGGJGOBP;
		}
		else
		{
			num7 = MNCHGLKLBOD.PEAEDDOIAGN;
			num8 = mNIMEAMHNMI * lMEFHJAFJLG2 + bCIHLCMFAEK * num7 + LIMMFGDCLAB.POFLEELFBPH;
			num9 = fMFABAKPMLB * lMEFHJAFJLG2 + eLNCCDELMMH * num7 + LIMMFGDCLAB.MLMBGGJGOBP;
		}
		NBKCFDOMAPI lIMMFGDCLAB = LIMMFGDCLAB.LIMMFGDCLAB;
		mNIMEAMHNMI = lIMMFGDCLAB.MNIMEAMHNMI;
		bCIHLCMFAEK = lIMMFGDCLAB.BCIHLCMFAEK;
		fMFABAKPMLB = lIMMFGDCLAB.FMFABAKPMLB;
		eLNCCDELMMH = lIMMFGDCLAB.ELNCCDELMMH;
		float num10 = 1f / (mNIMEAMHNMI * eLNCCDELMMH - bCIHLCMFAEK * fMFABAKPMLB);
		float num11 = JPGGJFPBDMF - lIMMFGDCLAB.POFLEELFBPH;
		float num12 = OKOGONJIBIM - lIMMFGDCLAB.MLMBGGJGOBP;
		float num13 = (num11 * eLNCCDELMMH - num12 * bCIHLCMFAEK) * num10 - lMEFHJAFJLG;
		float num14 = (num12 * mNIMEAMHNMI - num11 * fMFABAKPMLB) * num10 - pEAEDDOIAGN;
		num11 = num8 - lIMMFGDCLAB.POFLEELFBPH;
		num12 = num9 - lIMMFGDCLAB.MLMBGGJGOBP;
		float num15 = (num11 * eLNCCDELMMH - num12 * bCIHLCMFAEK) * num10 - lMEFHJAFJLG;
		float num16 = (num12 * mNIMEAMHNMI - num11 * fMFABAKPMLB) * num10 - pEAEDDOIAGN;
		float num17 = (float)Math.Sqrt(num15 * num15 + num16 * num16);
		float num18 = MNCHGLKLBOD.MBBPBGHKLJM.EOFAGACBNFP * num3;
		float num21;
		float num20;
		if (flag)
		{
			num18 *= num;
			float num19 = (num13 * num13 + num14 * num14 - num17 * num17 - num18 * num18) / (2f * num17 * num18);
			if (num19 < -1f)
			{
				num19 = -1f;
			}
			else if (num19 > 1f)
			{
				num19 = 1f;
			}
			num20 = (float)Math.Acos(num19) * (float)NDHEHJIICPK;
			mNIMEAMHNMI = num17 + num18 * num19;
			bCIHLCMFAEK = num18 * (float)Math.Sin(num20);
			num21 = (float)Math.Atan2(num14 * mNIMEAMHNMI - num13 * bCIHLCMFAEK, num13 * mNIMEAMHNMI + num14 * bCIHLCMFAEK);
		}
		else
		{
			mNIMEAMHNMI = num * num18;
			bCIHLCMFAEK = num2 * num18;
			float num22 = mNIMEAMHNMI * mNIMEAMHNMI;
			float num23 = bCIHLCMFAEK * bCIHLCMFAEK;
			float num24 = num13 * num13 + num14 * num14;
			float num25 = (float)Math.Atan2(num14, num13);
			fMFABAKPMLB = num23 * num17 * num17 + num22 * num24 - num22 * num23;
			float num26 = -2f * num23 * num17;
			float num27 = num23 - num22;
			eLNCCDELMMH = num26 * num26 - 4f * num27 * fMFABAKPMLB;
			if (eLNCCDELMMH >= 0f)
			{
				float num28 = (float)Math.Sqrt(eLNCCDELMMH);
				if (num26 < 0f)
				{
					num28 = 0f - num28;
				}
				num28 = (0f - (num26 + num28)) / 2f;
				float num29 = num28 / num27;
				float num30 = fMFABAKPMLB / num28;
				float num31 = ((!(Math.Abs(num29) < Math.Abs(num30))) ? num30 : num29);
				if (num31 * num31 <= num24)
				{
					num12 = (float)Math.Sqrt(num24 - num31 * num31) * (float)NDHEHJIICPK;
					num21 = num25 - (float)Math.Atan2(num12, num31);
					num20 = (float)Math.Atan2(num12 / num2, (num31 - num17) / num);
					goto IL_0504;
				}
			}
			float num32 = (float)Math.PI;
			float num33 = num17 - mNIMEAMHNMI;
			float num34 = num33 * num33;
			float num35 = 0f;
			float num36 = 0f;
			float num37 = num17 + mNIMEAMHNMI;
			float num38 = num37 * num37;
			float num39 = 0f;
			fMFABAKPMLB = (0f - mNIMEAMHNMI) * num17 / (num22 - num23);
			if (fMFABAKPMLB >= -1f && fMFABAKPMLB <= 1f)
			{
				fMFABAKPMLB = (float)Math.Acos(fMFABAKPMLB);
				num11 = mNIMEAMHNMI * (float)Math.Cos(fMFABAKPMLB) + num17;
				num12 = bCIHLCMFAEK * (float)Math.Sin(fMFABAKPMLB);
				eLNCCDELMMH = num11 * num11 + num12 * num12;
				if (eLNCCDELMMH < num34)
				{
					num32 = fMFABAKPMLB;
					num34 = eLNCCDELMMH;
					num33 = num11;
					num35 = num12;
				}
				if (eLNCCDELMMH > num38)
				{
					num36 = fMFABAKPMLB;
					num38 = eLNCCDELMMH;
					num37 = num11;
					num39 = num12;
				}
			}
			if (num24 <= (num34 + num38) / 2f)
			{
				num21 = num25 - (float)Math.Atan2(num35 * (float)NDHEHJIICPK, num33);
				num20 = num32 * (float)NDHEHJIICPK;
			}
			else
			{
				num21 = num25 - (float)Math.Atan2(num39 * (float)NDHEHJIICPK, num37);
				num20 = num36 * (float)NDHEHJIICPK;
			}
		}
		goto IL_0504;
		IL_0504:
		float num40 = (float)Math.Atan2(num7, lMEFHJAFJLG2) * (float)num5;
		float cLDDKKCPILB = LIMMFGDCLAB.CLDDKKCPILB;
		num21 = (num21 - num40) * (180f / (float)Math.PI) + (float)num4 - cLDDKKCPILB;
		if (num21 > 180f)
		{
			num21 -= 360f;
		}
		else if (num21 < -180f)
		{
			num21 += 360f;
		}
		LIMMFGDCLAB.DGCKCELHAEG(lMEFHJAFJLG, pEAEDDOIAGN, cLDDKKCPILB + num21 * KBKMPEOMABI, LIMMFGDCLAB.IAFNPOKEFMB, LIMMFGDCLAB.JBMAGEEAFKM, 0f, 0f);
		cLDDKKCPILB = MNCHGLKLBOD.CLDDKKCPILB;
		num20 = ((num20 + num40) * (180f / (float)Math.PI) - MNCHGLKLBOD.AIKGKNBOGCL) * (float)num5 + (float)num6 - cLDDKKCPILB;
		if (num20 > 180f)
		{
			num20 -= 360f;
		}
		else if (num20 < -180f)
		{
			num20 += 360f;
		}
		MNCHGLKLBOD.DGCKCELHAEG(lMEFHJAFJLG2, num7, cLDDKKCPILB + num20 * KBKMPEOMABI, MNCHGLKLBOD.IOLDFODFHAL, MNCHGLKLBOD.JBMAGEEAFKM, MNCHGLKLBOD.AIKGKNBOGCL, MNCHGLKLBOD.NIFFEDCOKDI);
	}
}
