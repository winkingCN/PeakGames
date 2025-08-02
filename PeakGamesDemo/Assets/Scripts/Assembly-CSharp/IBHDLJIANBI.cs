using System;

public class IBHDLJIANBI
{
	protected internal FBIJJFGLKMK GECCLOFELEC;

	protected internal int LOEMJLHDJAE;

	private bool MPGDDFMJMAA = true;

	private int AGELJEOCJCP;

	public int CLGCEPJECCO
	{
		get
		{
			return AGELJEOCJCP;
		}
	}

	public IBHDLJIANBI()
	{
	}

	internal IBHDLJIANBI(int AGELJEOCJCP)
	{
		if (AGELJEOCJCP < 1)
		{
			throw new ArgumentException("strength must be a positive value", "defaultStrength");
		}
		this.AGELJEOCJCP = AGELJEOCJCP;
	}

	public void DIOELAHNLKJ(HPBPDALECOG IJJHBEECMBP)
	{
		if (IJJHBEECMBP == null)
		{
			throw new ArgumentNullException("parameters");
		}
		MPGDDFMJMAA = false;
		HFLPGDBEKBE(IJJHBEECMBP);
	}

	protected virtual void HFLPGDBEKBE(HPBPDALECOG IJJHBEECMBP)
	{
		GECCLOFELEC = IJJHBEECMBP.IPFKDIJBGIM;
		LOEMJLHDJAE = (IJJHBEECMBP.IBANINMCJPP + 7) / 8;
	}

	public byte[] KLIMGLLPLAP()
	{
		if (MPGDDFMJMAA)
		{
			if (AGELJEOCJCP < 1)
			{
				throw new InvalidOperationException("Generator has not been initialised");
			}
			MPGDDFMJMAA = false;
			HFLPGDBEKBE(new HPBPDALECOG(new FBIJJFGLKMK(), AGELJEOCJCP));
		}
		return CBKCFJENBEG();
	}

	protected virtual byte[] CBKCFJENBEG()
	{
		return FBIJJFGLKMK.EABAFEKGFMC(GECCLOFELEC, LOEMJLHDJAE);
	}
}
