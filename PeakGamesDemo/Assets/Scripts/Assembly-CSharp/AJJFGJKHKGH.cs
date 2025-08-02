using System;

public abstract class AJJFGJKHKGH : COEMJAGOFJJ
{
	private readonly ALFDDLOKJAC IJJHBEECMBP;

	private readonly KLKJHFKJLEM DHNJFHPNJLM;

	public ALFDDLOKJAC KPJHHAAOFOH
	{
		get
		{
			return IJJHBEECMBP;
		}
	}

	public KLKJHFKJLEM LMJPMDMLPNH
	{
		get
		{
			return DHNJFHPNJLM;
		}
	}

	protected AJJFGJKHKGH(bool OFKEGLBCAJF, ALFDDLOKJAC IJJHBEECMBP)
		: base(OFKEGLBCAJF)
	{
		this.IJJHBEECMBP = IJJHBEECMBP;
	}

	protected AJJFGJKHKGH(bool OFKEGLBCAJF, KLKJHFKJLEM DHNJFHPNJLM)
		: base(OFKEGLBCAJF)
	{
		IJJHBEECMBP = BMENKBLGJJK(DHNJFHPNJLM);
		this.DHNJFHPNJLM = DHNJFHPNJLM;
	}

	private static ALFDDLOKJAC BMENKBLGJJK(KLKJHFKJLEM DHNJFHPNJLM)
	{
		if (DHNJFHPNJLM == null)
		{
			throw new ArgumentNullException("publicKeyParamSet");
		}
		PHKAEJGHJOF pHKAEJGHJOF = DMLNGFPKDOB.BHLONOMMIGE(DHNJFHPNJLM);
		if (pHKAEJGHJOF == null)
		{
			throw new ArgumentException("OID is not a valid CryptoPro public key parameter set", "publicKeyParamSet");
		}
		return new ALFDDLOKJAC(pHKAEJGHJOF.MBIJHANOCOC, pHKAEJGHJOF.FNPELDEHJKL, pHKAEJGHJOF.JEHECJGFJEB);
	}
}
