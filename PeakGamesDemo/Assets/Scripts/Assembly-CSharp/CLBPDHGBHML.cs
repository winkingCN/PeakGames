using System;
using Org.BouncyCastle.Math;

public class CLBPDHGBHML : IGMAJHKIIPK
{
	private const int CKANHIOLMBM = 160;

	private readonly BigInteger HPHBDNBJPHB;

	private readonly BigInteger HJMBDGKAOBP;

	private readonly BigInteger OKDPJHOEPBJ;

	private readonly BigInteger JEMICOMMKMO;

	private readonly int CEKMAJAHNAG;

	private readonly int PHILIHLPDFD;

	private readonly IPCHHFKBJGE CANIMMGDFPJ;

	public BigInteger MBIJHANOCOC
	{
		get
		{
			return HPHBDNBJPHB;
		}
	}

	public BigInteger HBGOKILMBJG
	{
		get
		{
			return HJMBDGKAOBP;
		}
	}

	public BigInteger FNPELDEHJKL
	{
		get
		{
			return OKDPJHOEPBJ;
		}
	}

	public BigInteger GHGFJBIOAAC
	{
		get
		{
			return JEMICOMMKMO;
		}
	}

	public int IGBPKOOBCMA
	{
		get
		{
			return CEKMAJAHNAG;
		}
	}

	public int NBFDOJDLKOG
	{
		get
		{
			return PHILIHLPDFD;
		}
	}

	public IPCHHFKBJGE OAMDEKMPJIL
	{
		get
		{
			return CANIMMGDFPJ;
		}
	}

	public CLBPDHGBHML(BigInteger HPHBDNBJPHB, BigInteger HJMBDGKAOBP)
		: this(HPHBDNBJPHB, HJMBDGKAOBP, null, 0)
	{
	}

	public CLBPDHGBHML(BigInteger HPHBDNBJPHB, BigInteger HJMBDGKAOBP, BigInteger OKDPJHOEPBJ)
		: this(HPHBDNBJPHB, HJMBDGKAOBP, OKDPJHOEPBJ, 0)
	{
	}

	public CLBPDHGBHML(BigInteger HPHBDNBJPHB, BigInteger HJMBDGKAOBP, BigInteger OKDPJHOEPBJ, int PHILIHLPDFD)
		: this(HPHBDNBJPHB, HJMBDGKAOBP, OKDPJHOEPBJ, KBGJNPCEDJD(PHILIHLPDFD), PHILIHLPDFD, null, null)
	{
	}

	public CLBPDHGBHML(BigInteger HPHBDNBJPHB, BigInteger HJMBDGKAOBP, BigInteger OKDPJHOEPBJ, int CEKMAJAHNAG, int PHILIHLPDFD)
		: this(HPHBDNBJPHB, HJMBDGKAOBP, OKDPJHOEPBJ, CEKMAJAHNAG, PHILIHLPDFD, null, null)
	{
	}

	public CLBPDHGBHML(BigInteger HPHBDNBJPHB, BigInteger HJMBDGKAOBP, BigInteger OKDPJHOEPBJ, BigInteger JEMICOMMKMO, IPCHHFKBJGE CANIMMGDFPJ)
		: this(HPHBDNBJPHB, HJMBDGKAOBP, OKDPJHOEPBJ, 160, 0, JEMICOMMKMO, CANIMMGDFPJ)
	{
	}

	public CLBPDHGBHML(BigInteger HPHBDNBJPHB, BigInteger HJMBDGKAOBP, BigInteger OKDPJHOEPBJ, int CEKMAJAHNAG, int PHILIHLPDFD, BigInteger JEMICOMMKMO, IPCHHFKBJGE CANIMMGDFPJ)
	{
		if (HPHBDNBJPHB == null)
		{
			throw new ArgumentNullException("p");
		}
		if (HJMBDGKAOBP == null)
		{
			throw new ArgumentNullException("g");
		}
		if (!HPHBDNBJPHB.NJHNJHGDCIJ(0))
		{
			throw new ArgumentException("field must be an odd prime", "p");
		}
		if (HJMBDGKAOBP.JLPDKNFCNPO(BigInteger.Two) < 0 || HJMBDGKAOBP.JLPDKNFCNPO(HPHBDNBJPHB.FBGIHKPECCO(BigInteger.Two)) > 0)
		{
			throw new ArgumentException("generator must in the range [2, p - 2]", "g");
		}
		if (OKDPJHOEPBJ != null && OKDPJHOEPBJ.BitLength >= HPHBDNBJPHB.BitLength)
		{
			throw new ArgumentException("q too big to be a factor of (p-1)", "q");
		}
		if (CEKMAJAHNAG >= HPHBDNBJPHB.BitLength)
		{
			throw new ArgumentException("m value must be < bitlength of p", "m");
		}
		if (PHILIHLPDFD != 0)
		{
			if (PHILIHLPDFD >= HPHBDNBJPHB.BitLength)
			{
				throw new ArgumentException("when l value specified, it must be less than bitlength(p)", "l");
			}
			if (PHILIHLPDFD < CEKMAJAHNAG)
			{
				throw new ArgumentException("when l value specified, it may not be less than m value", "l");
			}
		}
		if (JEMICOMMKMO != null && JEMICOMMKMO.JLPDKNFCNPO(BigInteger.Two) < 0)
		{
			throw new ArgumentException("subgroup factor must be >= 2", "j");
		}
		this.HPHBDNBJPHB = HPHBDNBJPHB;
		this.HJMBDGKAOBP = HJMBDGKAOBP;
		this.OKDPJHOEPBJ = OKDPJHOEPBJ;
		this.CEKMAJAHNAG = CEKMAJAHNAG;
		this.PHILIHLPDFD = PHILIHLPDFD;
		this.JEMICOMMKMO = JEMICOMMKMO;
		this.CANIMMGDFPJ = CANIMMGDFPJ;
	}

	private static int KBGJNPCEDJD(int HKMEOJDOJPK)
	{
		if (HKMEOJDOJPK == 0)
		{
			return 160;
		}
		return Math.Min(HKMEOJDOJPK, 160);
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == this)
		{
			return true;
		}
		CLBPDHGBHML cLBPDHGBHML = NEMEKIOEOLC as CLBPDHGBHML;
		if (cLBPDHGBHML == null)
		{
			return false;
		}
		return KIFDKLPDKMD(cLBPDHGBHML);
	}

	protected virtual bool KIFDKLPDKMD(CLBPDHGBHML CJHEIBNHNNE)
	{
		return HPHBDNBJPHB.Equals(CJHEIBNHNNE.HPHBDNBJPHB) && HJMBDGKAOBP.Equals(CJHEIBNHNNE.HJMBDGKAOBP) && object.Equals(OKDPJHOEPBJ, CJHEIBNHNNE.OKDPJHOEPBJ);
	}

	public override int GetHashCode()
	{
		int num = HPHBDNBJPHB.GetHashCode() ^ HJMBDGKAOBP.GetHashCode();
		if (OKDPJHOEPBJ != null)
		{
			num ^= OKDPJHOEPBJ.GetHashCode();
		}
		return num;
	}
}
