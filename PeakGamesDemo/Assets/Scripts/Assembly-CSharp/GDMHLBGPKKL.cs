public class GDMHLBGPKKL
{
	private int OKHNDECGJEO;

	private int FMFABAKPMLB;

	private long OANOOFPPKDL;

	private long BEDGOLMEFIL;

	public int ANGINAGELKI
	{
		get
		{
			return FMFABAKPMLB;
		}
	}

	public int PHJLFAEPHKF
	{
		get
		{
			return OKHNDECGJEO;
		}
	}

	public long GAFDHCMEECK
	{
		get
		{
			return BEDGOLMEFIL;
		}
	}

	public long MKCHBFGHNPD
	{
		get
		{
			return OANOOFPPKDL;
		}
	}

	public GDMHLBGPKKL(int OKHNDECGJEO, int FMFABAKPMLB)
	{
		this.OKHNDECGJEO = OKHNDECGJEO;
		this.FMFABAKPMLB = FMFABAKPMLB;
	}

	public GDMHLBGPKKL(long OANOOFPPKDL, long BEDGOLMEFIL)
	{
		this.OANOOFPPKDL = OANOOFPPKDL;
		this.BEDGOLMEFIL = BEDGOLMEFIL;
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		GDMHLBGPKKL gDMHLBGPKKL = NEMEKIOEOLC as GDMHLBGPKKL;
		return gDMHLBGPKKL != null && gDMHLBGPKKL.FMFABAKPMLB == FMFABAKPMLB && gDMHLBGPKKL.OKHNDECGJEO == OKHNDECGJEO && gDMHLBGPKKL.BEDGOLMEFIL == BEDGOLMEFIL && gDMHLBGPKKL.OANOOFPPKDL == OANOOFPPKDL;
	}

	public override int GetHashCode()
	{
		return FMFABAKPMLB.GetHashCode() ^ OKHNDECGJEO.GetHashCode() ^ BEDGOLMEFIL.GetHashCode() ^ OANOOFPPKDL.GetHashCode();
	}
}
