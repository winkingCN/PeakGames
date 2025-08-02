using System;
using Org.BouncyCastle.Math;

public class ELKMCBFPHBP : PLGGNEJEIIP
{
	private readonly BigInteger EKFOKNPODBK;

	private readonly BigInteger HPHBDNBJPHB;

	private readonly BigInteger OKDPJHOEPBJ;

	private readonly BigInteger ILBNMEGNMAN;

	private readonly BigInteger FIKFHCHACNL;

	private readonly BigInteger NKADLNIOCAI;

	public BigInteger IHOPDFAGDAF
	{
		get
		{
			return EKFOKNPODBK;
		}
	}

	public BigInteger MBIJHANOCOC
	{
		get
		{
			return HPHBDNBJPHB;
		}
	}

	public BigInteger FNPELDEHJKL
	{
		get
		{
			return OKDPJHOEPBJ;
		}
	}

	public BigInteger OLMGFAMCEPN
	{
		get
		{
			return ILBNMEGNMAN;
		}
	}

	public BigInteger ECMGIOFKOBP
	{
		get
		{
			return FIKFHCHACNL;
		}
	}

	public BigInteger MLCIDFCJAPM
	{
		get
		{
			return NKADLNIOCAI;
		}
	}

	public ELKMCBFPHBP(BigInteger ACOFJAHAMHM, BigInteger PHAKMCGHMBA, BigInteger FNLHNKOPELG, BigInteger HPHBDNBJPHB, BigInteger OKDPJHOEPBJ, BigInteger ILBNMEGNMAN, BigInteger FIKFHCHACNL, BigInteger NKADLNIOCAI)
		: base(true, ACOFJAHAMHM, FNLHNKOPELG)
	{
		FLAAOLCONJC(PHAKMCGHMBA, "publicExponent", "exponent");
		FLAAOLCONJC(HPHBDNBJPHB, "p", "P value");
		FLAAOLCONJC(OKDPJHOEPBJ, "q", "Q value");
		FLAAOLCONJC(ILBNMEGNMAN, "dP", "DP value");
		FLAAOLCONJC(FIKFHCHACNL, "dQ", "DQ value");
		FLAAOLCONJC(NKADLNIOCAI, "qInv", "InverseQ value");
		EKFOKNPODBK = PHAKMCGHMBA;
		this.HPHBDNBJPHB = HPHBDNBJPHB;
		this.OKDPJHOEPBJ = OKDPJHOEPBJ;
		this.ILBNMEGNMAN = ILBNMEGNMAN;
		this.FIKFHCHACNL = FIKFHCHACNL;
		this.NKADLNIOCAI = NKADLNIOCAI;
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == this)
		{
			return true;
		}
		ELKMCBFPHBP eLKMCBFPHBP = NEMEKIOEOLC as ELKMCBFPHBP;
		if (eLKMCBFPHBP == null)
		{
			return false;
		}
		return eLKMCBFPHBP.OLMGFAMCEPN.Equals(ILBNMEGNMAN) && eLKMCBFPHBP.ECMGIOFKOBP.Equals(FIKFHCHACNL) && eLKMCBFPHBP.MFIHJHFAEFB.Equals(base.MFIHJHFAEFB) && eLKMCBFPHBP.FILOMPHGFKD.Equals(base.FILOMPHGFKD) && eLKMCBFPHBP.MBIJHANOCOC.Equals(HPHBDNBJPHB) && eLKMCBFPHBP.FNPELDEHJKL.Equals(OKDPJHOEPBJ) && eLKMCBFPHBP.IHOPDFAGDAF.Equals(EKFOKNPODBK) && eLKMCBFPHBP.MLCIDFCJAPM.Equals(NKADLNIOCAI);
	}

	public override int GetHashCode()
	{
		return OLMGFAMCEPN.GetHashCode() ^ ECMGIOFKOBP.GetHashCode() ^ base.MFIHJHFAEFB.GetHashCode() ^ base.FILOMPHGFKD.GetHashCode() ^ MBIJHANOCOC.GetHashCode() ^ FNPELDEHJKL.GetHashCode() ^ IHOPDFAGDAF.GetHashCode() ^ MLCIDFCJAPM.GetHashCode();
	}

	private static void FLAAOLCONJC(BigInteger AMFCENFNAJJ, string IOCMOCCFALN, string GFLHOMACBOE)
	{
		if (AMFCENFNAJJ == null)
		{
			throw new ArgumentNullException(IOCMOCCFALN);
		}
		if (AMFCENFNAJJ.SignValue <= 0)
		{
			throw new ArgumentException("Not a valid RSA " + GFLHOMACBOE, IOCMOCCFALN);
		}
	}
}
