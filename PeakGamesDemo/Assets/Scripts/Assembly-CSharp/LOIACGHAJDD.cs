using System;
using System.Security.Cryptography;

public class LOIACGHAJDD : ENDHCNJKMOL
{
	private readonly RandomNumberGenerator FCGNJFNPFFK;

	public LOIACGHAJDD()
		: this(new RNGCryptoServiceProvider())
	{
	}

	public LOIACGHAJDD(RandomNumberGenerator MEEOMNFCCPB)
	{
		FCGNJFNPFFK = MEEOMNFCCPB;
	}

	public virtual void GMFBMHLENMN(byte[] HJBOEOOLOOE)
	{
	}

	public virtual void GMFBMHLENMN(long HJBOEOOLOOE)
	{
	}

	public virtual void GOADFPHGDJG(byte[] DIPNEDDIHBK)
	{
		FCGNJFNPFFK.GetBytes(DIPNEDDIHBK);
	}

	public virtual void GOADFPHGDJG(byte[] DIPNEDDIHBK, int EHGOOEHDNMM, int NBEDPKHALCN)
	{
		if (EHGOOEHDNMM < 0)
		{
			throw new ArgumentException("Start offset cannot be negative", "start");
		}
		if (DIPNEDDIHBK.Length < EHGOOEHDNMM + NBEDPKHALCN)
		{
			throw new ArgumentException("Byte array too small for requested offset and length");
		}
		if (DIPNEDDIHBK.Length == NBEDPKHALCN && EHGOOEHDNMM == 0)
		{
			GOADFPHGDJG(DIPNEDDIHBK);
			return;
		}
		byte[] array = new byte[NBEDPKHALCN];
		GOADFPHGDJG(array);
		Array.Copy(array, 0, DIPNEDDIHBK, EHGOOEHDNMM, NBEDPKHALCN);
	}
}
