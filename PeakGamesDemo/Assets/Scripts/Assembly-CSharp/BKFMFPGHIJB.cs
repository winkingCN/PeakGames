using System;

public abstract class BKFMFPGHIJB : COEMJAGOFJJ
{
	private static readonly string[] NCLCMMGJEBI = new string[6] { "EC", "ECDSA", "ECDH", "ECDHC", "ECGOST3410", "ECMQV" };

	private readonly string ADLMOHOLCGL;

	private readonly MJDENGGDLMJ IJJHBEECMBP;

	private readonly KLKJHFKJLEM DHNJFHPNJLM;

	public string KFKMEPMEBND
	{
		get
		{
			return ADLMOHOLCGL;
		}
	}

	public MJDENGGDLMJ KPJHHAAOFOH
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

	protected BKFMFPGHIJB(string ADLMOHOLCGL, bool OFKEGLBCAJF, MJDENGGDLMJ IJJHBEECMBP)
		: base(OFKEGLBCAJF)
	{
		if (ADLMOHOLCGL == null)
		{
			throw new ArgumentNullException("algorithm");
		}
		if (IJJHBEECMBP == null)
		{
			throw new ArgumentNullException("parameters");
		}
		this.ADLMOHOLCGL = HFPDJDIJMPC(ADLMOHOLCGL);
		this.IJJHBEECMBP = IJJHBEECMBP;
	}

	protected BKFMFPGHIJB(string ADLMOHOLCGL, bool OFKEGLBCAJF, KLKJHFKJLEM DHNJFHPNJLM)
		: base(OFKEGLBCAJF)
	{
		if (ADLMOHOLCGL == null)
		{
			throw new ArgumentNullException("algorithm");
		}
		if (DHNJFHPNJLM == null)
		{
			throw new ArgumentNullException("publicKeyParamSet");
		}
		this.ADLMOHOLCGL = HFPDJDIJMPC(ADLMOHOLCGL);
		IJJHBEECMBP = BMENKBLGJJK(DHNJFHPNJLM);
		this.DHNJFHPNJLM = DHNJFHPNJLM;
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == this)
		{
			return true;
		}
		MJDENGGDLMJ mJDENGGDLMJ = NEMEKIOEOLC as MJDENGGDLMJ;
		if (mJDENGGDLMJ == null)
		{
			return false;
		}
		return Equals(mJDENGGDLMJ);
	}

	protected bool KIFDKLPDKMD(BKFMFPGHIJB CJHEIBNHNNE)
	{
		return IJJHBEECMBP.Equals(CJHEIBNHNNE.IJJHBEECMBP) && KIFDKLPDKMD((COEMJAGOFJJ)CJHEIBNHNNE);
	}

	public override int GetHashCode()
	{
		return IJJHBEECMBP.GetHashCode() ^ base.GetHashCode();
	}

	internal JDKCFKJJIHN NICFFCEDGPG(FBIJJFGLKMK GECCLOFELEC)
	{
		if (DHNJFHPNJLM != null)
		{
			return new JDKCFKJJIHN(DHNJFHPNJLM, GECCLOFELEC);
		}
		return new JDKCFKJJIHN(IJJHBEECMBP, GECCLOFELEC);
	}

	internal static string HFPDJDIJMPC(string ADLMOHOLCGL)
	{
		string result = LHFGHNFJIKM.OGLCLCODHJI(ADLMOHOLCGL);
		if (Array.IndexOf(NCLCMMGJEBI, ADLMOHOLCGL, 0, NCLCMMGJEBI.Length) < 0)
		{
			throw new ArgumentException("unrecognised algorithm: " + ADLMOHOLCGL, "algorithm");
		}
		return result;
	}

	internal static MJDENGGDLMJ BMENKBLGJJK(KLKJHFKJLEM DHNJFHPNJLM)
	{
		if (DHNJFHPNJLM == null)
		{
			throw new ArgumentNullException("publicKeyParamSet");
		}
		MJDENGGDLMJ mJDENGGDLMJ = PBFONLGGGIN.BHLONOMMIGE(DHNJFHPNJLM);
		if (mJDENGGDLMJ == null)
		{
			JMLDNPGFBDA jMLDNPGFBDA = JMLCKFLAGEF.GJFLBAIJAEM(DHNJFHPNJLM);
			if (jMLDNPGFBDA == null)
			{
				throw new ArgumentException("OID is not a valid public key parameter set", "publicKeyParamSet");
			}
			mJDENGGDLMJ = new MJDENGGDLMJ(jMLDNPGFBDA.ECFGFKNLLGH, jMLDNPGFBDA.HBGOKILMBJG, jMLDNPGFBDA.HNLMGJGNBDD, jMLDNPGFBDA.JGOHMOHEFMJ, jMLDNPGFBDA.GKBBKKNGJAK());
		}
		return mJDENGGDLMJ;
	}
}
