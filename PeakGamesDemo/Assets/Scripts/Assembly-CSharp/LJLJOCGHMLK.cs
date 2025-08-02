using System;

public class LJLJOCGHMLK : IGMAJHKIIPK
{
	private readonly EKGPBAENHIF DGCDMPIDDLI;

	private readonly EKGPBAENHIF JNLJJFHGAGK;

	private readonly EGEBOHHBFLK LKPJLBCDIIP;

	public virtual EKGPBAENHIF OFPHGNLODAG
	{
		get
		{
			return DGCDMPIDDLI;
		}
	}

	public virtual EKGPBAENHIF GEGOCHOEEJK
	{
		get
		{
			return JNLJJFHGAGK;
		}
	}

	public virtual EGEBOHHBFLK AJPOLAKEBPF
	{
		get
		{
			return LKPJLBCDIIP;
		}
	}

	public LJLJOCGHMLK(EKGPBAENHIF DGCDMPIDDLI, EKGPBAENHIF JNLJJFHGAGK)
		: this(DGCDMPIDDLI, JNLJJFHGAGK, null)
	{
	}

	public LJLJOCGHMLK(EKGPBAENHIF DGCDMPIDDLI, EKGPBAENHIF JNLJJFHGAGK, EGEBOHHBFLK LKPJLBCDIIP)
	{
		if (DGCDMPIDDLI == null)
		{
			throw new ArgumentNullException("staticPrivateKey");
		}
		if (JNLJJFHGAGK == null)
		{
			throw new ArgumentNullException("ephemeralPrivateKey");
		}
		MJDENGGDLMJ mJDENGGDLMJ = DGCDMPIDDLI.KPJHHAAOFOH;
		if (!mJDENGGDLMJ.Equals(JNLJJFHGAGK.KPJHHAAOFOH))
		{
			throw new ArgumentException("Static and ephemeral private keys have different domain parameters");
		}
		if (LKPJLBCDIIP == null)
		{
			LKPJLBCDIIP = new EGEBOHHBFLK(mJDENGGDLMJ.HBGOKILMBJG.IBJBIGNPNEM(JNLJJFHGAGK.INCIODEICNM), mJDENGGDLMJ);
		}
		else if (!mJDENGGDLMJ.Equals(LKPJLBCDIIP.KPJHHAAOFOH))
		{
			throw new ArgumentException("Ephemeral public key has different domain parameters");
		}
		this.DGCDMPIDDLI = DGCDMPIDDLI;
		this.JNLJJFHGAGK = JNLJJFHGAGK;
		this.LKPJLBCDIIP = LKPJLBCDIIP;
	}
}
