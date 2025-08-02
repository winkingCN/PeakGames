using System;

public class ENIPPOEKJPA : OAMNGFLKEFI
{
	internal float AMFCENFNAJJ;

	internal float CNLILOEEBOJ;

	internal float ODLHFMOPCHL;

	public float CBPFFIBINEH
	{
		get
		{
			return AMFCENFNAJJ;
		}
		set
		{
			AMFCENFNAJJ = value;
		}
	}

	public float MOAGLBJDKKL
	{
		get
		{
			return CNLILOEEBOJ;
		}
		set
		{
			CNLILOEEBOJ = value;
		}
	}

	public float PMNEAMANOCD
	{
		get
		{
			return ODLHFMOPCHL;
		}
		set
		{
			ODLHFMOPCHL = value;
		}
	}

	public ENIPPOEKJPA(string IOCMOCCFALN)
		: base(IOCMOCCFALN)
	{
	}

	public void MPNHFIOIEAK(NBKCFDOMAPI JEBEPBEGCCF, out float KHDNMGAKGPE, out float HNNAMHLGJHI)
	{
		JEBEPBEGCCF.EMLJIFGGEJI(AMFCENFNAJJ, CNLILOEEBOJ, out KHDNMGAKGPE, out HNNAMHLGJHI);
	}

	public float PAFJJHOLPKF(NBKCFDOMAPI JEBEPBEGCCF)
	{
		float num = EDBPEAKKANM.OCGBMDHACPF(ODLHFMOPCHL);
		float num2 = EDBPEAKKANM.HLLKFBLOPOE(ODLHFMOPCHL);
		float aMFCENFNAJJ = num * JEBEPBEGCCF.MNIMEAMHNMI + num2 * JEBEPBEGCCF.BCIHLCMFAEK;
		float cNLILOEEBOJ = num * JEBEPBEGCCF.FMFABAKPMLB + num2 * JEBEPBEGCCF.ELNCCDELMMH;
		return EDBPEAKKANM.FKGOMHJAJMK(cNLILOEEBOJ, aMFCENFNAJJ) * (180f / (float)Math.PI);
	}
}
