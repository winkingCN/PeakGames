using System;
using System.IO;

public class EKNLINDFMIM : EDOEBJJFOBM
{
	private KLKJHFKJLEM COAAMOJNOGG;

	private GLFDIPNOLKN AHCFBDOKFLP;

	private EDOEBJJFOBM CELLKDJDJEG;

	private int NJPMJNHGDNE;

	private EDOEBJJFOBM AOEKDEOCIID;

	public EDOEBJJFOBM HDADBHNCPBE
	{
		get
		{
			return CELLKDJDJEG;
		}
		set
		{
			CELLKDJDJEG = value;
		}
	}

	public KLKJHFKJLEM OCMOGHEOBBJ
	{
		get
		{
			return COAAMOJNOGG;
		}
		set
		{
			COAAMOJNOGG = value;
		}
	}

	public int HBAGPBEDGLH
	{
		get
		{
			return NJPMJNHGDNE;
		}
		set
		{
			if (NJPMJNHGDNE < 0 || NJPMJNHGDNE > 2)
			{
				throw new InvalidOperationException("invalid encoding value: " + NJPMJNHGDNE);
			}
			NJPMJNHGDNE = value;
		}
	}

	public EDOEBJJFOBM HBNJBGDAPAH
	{
		get
		{
			return AOEKDEOCIID;
		}
		set
		{
			AOEKDEOCIID = value;
		}
	}

	public GLFDIPNOLKN MDAENJIDOMD
	{
		get
		{
			return AHCFBDOKFLP;
		}
		set
		{
			AHCFBDOKFLP = value;
		}
	}

	public EKNLINDFMIM(DLDBGGDLOOO JPNDHPHJJGN)
	{
		int num = 0;
		EDOEBJJFOBM eDOEBJJFOBM = AAMHOGKKNMN(JPNDHPHJJGN, num);
		if (eDOEBJJFOBM is KLKJHFKJLEM)
		{
			COAAMOJNOGG = (KLKJHFKJLEM)eDOEBJJFOBM;
			num++;
			eDOEBJJFOBM = AAMHOGKKNMN(JPNDHPHJJGN, num);
		}
		if (eDOEBJJFOBM is GLFDIPNOLKN)
		{
			AHCFBDOKFLP = (GLFDIPNOLKN)eDOEBJJFOBM;
			num++;
			eDOEBJJFOBM = AAMHOGKKNMN(JPNDHPHJJGN, num);
		}
		if (!(eDOEBJJFOBM is PAANMJLACEF))
		{
			CELLKDJDJEG = eDOEBJJFOBM;
			num++;
			eDOEBJJFOBM = AAMHOGKKNMN(JPNDHPHJJGN, num);
		}
		if (JPNDHPHJJGN.GMCGMPEEHJP != num + 1)
		{
			throw new ArgumentException("input vector too large", "vector");
		}
		if (!(eDOEBJJFOBM is PAANMJLACEF))
		{
			throw new ArgumentException("No tagged object found in vector. Structure doesn't seem to be of type External", "vector");
		}
		PAANMJLACEF pAANMJLACEF = (PAANMJLACEF)eDOEBJJFOBM;
		HBAGPBEDGLH = pAANMJLACEF.JPBIKBDCEKC;
		if (NJPMJNHGDNE < 0 || NJPMJNHGDNE > 2)
		{
			throw new InvalidOperationException("invalid encoding value");
		}
		AOEKDEOCIID = pAANMJLACEF.NFMFKPLPLLH();
	}

	public EKNLINDFMIM(KLKJHFKJLEM COAAMOJNOGG, GLFDIPNOLKN AHCFBDOKFLP, EDOEBJJFOBM CELLKDJDJEG, JIHIOOKBBLB KAOKFBENADF)
		: this(COAAMOJNOGG, AHCFBDOKFLP, CELLKDJDJEG, KAOKFBENADF.JPBIKBDCEKC, KAOKFBENADF.IIHKEACDNID())
	{
	}

	public EKNLINDFMIM(KLKJHFKJLEM COAAMOJNOGG, GLFDIPNOLKN AHCFBDOKFLP, EDOEBJJFOBM CELLKDJDJEG, int NJPMJNHGDNE, EDOEBJJFOBM KAOKFBENADF)
	{
		OCMOGHEOBBJ = COAAMOJNOGG;
		MDAENJIDOMD = AHCFBDOKFLP;
		HDADBHNCPBE = CELLKDJDJEG;
		HBAGPBEDGLH = NJPMJNHGDNE;
		HBNJBGDAPAH = KAOKFBENADF.IIHKEACDNID();
	}

	internal override void LMDBBPLCJDM(JBLJHINPLMC NMHOOGAGLOA)
	{
		MemoryStream memoryStream = new MemoryStream();
		EKGFEKENLAG(memoryStream, COAAMOJNOGG);
		EKGFEKENLAG(memoryStream, AHCFBDOKFLP);
		EKGFEKENLAG(memoryStream, CELLKDJDJEG);
		EKGFEKENLAG(memoryStream, new JIHIOOKBBLB(8, AOEKDEOCIID));
		NMHOOGAGLOA.AGNEJPEMPAP(32, 8, memoryStream.ToArray());
	}

	protected override int BGFGDLGFEPI()
	{
		int num = AOEKDEOCIID.GetHashCode();
		if (COAAMOJNOGG != null)
		{
			num ^= COAAMOJNOGG.GetHashCode();
		}
		if (AHCFBDOKFLP != null)
		{
			num ^= AHCFBDOKFLP.GetHashCode();
		}
		if (CELLKDJDJEG != null)
		{
			num ^= CELLKDJDJEG.GetHashCode();
		}
		return num;
	}

	protected override bool IMHPDJGGAGJ(EDOEBJJFOBM LABMKGMAEGK)
	{
		if (this == LABMKGMAEGK)
		{
			return true;
		}
		EKNLINDFMIM eKNLINDFMIM = LABMKGMAEGK as EKNLINDFMIM;
		if (eKNLINDFMIM == null)
		{
			return false;
		}
		return object.Equals(COAAMOJNOGG, eKNLINDFMIM.COAAMOJNOGG) && object.Equals(AHCFBDOKFLP, eKNLINDFMIM.AHCFBDOKFLP) && object.Equals(CELLKDJDJEG, eKNLINDFMIM.CELLKDJDJEG) && AOEKDEOCIID.Equals(eKNLINDFMIM.AOEKDEOCIID);
	}

	private static EDOEBJJFOBM AAMHOGKKNMN(DLDBGGDLOOO AAIEJDNAODP, int EHJNMODJEAN)
	{
		if (AAIEJDNAODP.GMCGMPEEHJP <= EHJNMODJEAN)
		{
			throw new ArgumentException("too few objects in input vector", "v");
		}
		return AAIEJDNAODP.ECNCPJGHBIG(EHJNMODJEAN).IIHKEACDNID();
	}

	private static void EKGFEKENLAG(MemoryStream JAIHIINLIOP, LNKPCJLANAO EKFOKNPODBK)
	{
		if (EKFOKNPODBK != null)
		{
			byte[] array = EKFOKNPODBK.KMBJLPOKIAC();
			JAIHIINLIOP.Write(array, 0, array.Length);
		}
	}
}
