using System;

public class GFKPCPPOEMJ : IGMAJHKIIPK
{
	private readonly EGEBOHHBFLK FPLJDPKAFPG;

	private readonly EGEBOHHBFLK LKPJLBCDIIP;

	public virtual EGEBOHHBFLK CBCPEGHBHAO
	{
		get
		{
			return FPLJDPKAFPG;
		}
	}

	public virtual EGEBOHHBFLK AJPOLAKEBPF
	{
		get
		{
			return LKPJLBCDIIP;
		}
	}

	public GFKPCPPOEMJ(EGEBOHHBFLK FPLJDPKAFPG, EGEBOHHBFLK LKPJLBCDIIP)
	{
		if (FPLJDPKAFPG == null)
		{
			throw new ArgumentNullException("staticPublicKey");
		}
		if (LKPJLBCDIIP == null)
		{
			throw new ArgumentNullException("ephemeralPublicKey");
		}
		if (!FPLJDPKAFPG.KPJHHAAOFOH.Equals(LKPJLBCDIIP.KPJHHAAOFOH))
		{
			throw new ArgumentException("Static and ephemeral public keys have different domain parameters");
		}
		this.FPLJDPKAFPG = FPLJDPKAFPG;
		this.LKPJLBCDIIP = LKPJLBCDIIP;
	}
}
