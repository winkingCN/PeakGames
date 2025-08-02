using System;
using System.Text;
using Org.BouncyCastle.Math;

public class FJMKMKNJKOI : LHPKOCNBCPP
{
	private static readonly char[] AEPNIOFMGPL = new char[16]
	{
		'0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
		'A', 'B', 'C', 'D', 'E', 'F'
	};

	protected readonly byte[] PCECPIAMFEN;

	protected readonly int GNBLFGJPAJF;

	public virtual int KOHPFEHKIPK
	{
		get
		{
			return GNBLFGJPAJF;
		}
	}

	public virtual int CCEMPCIMBLB
	{
		get
		{
			int num = 0;
			int num2 = Math.Min(4, PCECPIAMFEN.Length);
			for (int i = 0; i < num2; i++)
			{
				num |= PCECPIAMFEN[i] << 8 * i;
			}
			if (GNBLFGJPAJF > 0 && num2 == PCECPIAMFEN.Length)
			{
				int num3 = (1 << GNBLFGJPAJF) - 1;
				num &= ~(num3 << 8 * (num2 - 1));
			}
			return num;
		}
	}

	public FJMKMKNJKOI(byte[] MBBPBGHKLJM, int FOIHIFLKIPF)
	{
		if (MBBPBGHKLJM == null)
		{
			throw new ArgumentNullException("data");
		}
		if (FOIHIFLKIPF < 0 || FOIHIFLKIPF > 7)
		{
			throw new ArgumentException("must be in the range 0 to 7", "padBits");
		}
		if (MBBPBGHKLJM.Length == 0 && FOIHIFLKIPF != 0)
		{
			throw new ArgumentException("if 'data' is empty, 'padBits' must be 0");
		}
		PCECPIAMFEN = NOGCEBKPPJE.IKBFGGABMKP(MBBPBGHKLJM);
		GNBLFGJPAJF = FOIHIFLKIPF;
	}

	public FJMKMKNJKOI(byte[] MBBPBGHKLJM)
		: this(MBBPBGHKLJM, 0)
	{
	}

	public FJMKMKNJKOI(int LBGGCEGLKBD)
	{
		if (LBGGCEGLKBD == 0)
		{
			PCECPIAMFEN = new byte[0];
			GNBLFGJPAJF = 0;
			return;
		}
		int num = BigInteger.DPLNBDLKNDE(LBGGCEGLKBD);
		int num2 = (num + 7) / 8;
		byte[] array = new byte[num2];
		num2--;
		for (int i = 0; i < num2; i++)
		{
			array[i] = (byte)LBGGCEGLKBD;
			LBGGCEGLKBD >>= 8;
		}
		array[num2] = (byte)LBGGCEGLKBD;
		int j;
		for (j = 0; (LBGGCEGLKBD & (1 << j)) == 0; j++)
		{
		}
		PCECPIAMFEN = array;
		GNBLFGJPAJF = j;
	}

	public FJMKMKNJKOI(LNKPCJLANAO NEMEKIOEOLC)
		: this(NEMEKIOEOLC.KMBJLPOKIAC())
	{
	}

	public static FJMKMKNJKOI BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is FJMKMKNJKOI)
		{
			return (FJMKMKNJKOI)NEMEKIOEOLC;
		}
		if (NEMEKIOEOLC is byte[])
		{
			try
			{
				return (FJMKMKNJKOI)EDOEBJJFOBM.HPDCKMOPEMM((byte[])NEMEKIOEOLC);
			}
			catch (Exception ex)
			{
				throw new ArgumentException("encoding error in GetInstance: " + ex.ToString());
			}
		}
		throw new ArgumentException("illegal object in GetInstance: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC));
	}

	public static FJMKMKNJKOI BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DNBCBHLACCP)
	{
		EDOEBJJFOBM eDOEBJJFOBM = NEMEKIOEOLC.NFMFKPLPLLH();
		if (DNBCBHLACCP || eDOEBJJFOBM is FJMKMKNJKOI)
		{
			return BJLJCGFMFOO(eDOEBJJFOBM);
		}
		return NKNAANNFPLL(((PJGIGKJFGFI)eDOEBJJFOBM).KLHNEKMCKKI());
	}

	public virtual byte[] KLHNEKMCKKI()
	{
		if (GNBLFGJPAJF != 0)
		{
			throw new InvalidOperationException("attempt to get non-octet aligned data from BIT STRING");
		}
		return NOGCEBKPPJE.IKBFGGABMKP(PCECPIAMFEN);
	}

	public virtual byte[] MIBPLNJNEGA()
	{
		byte[] array = NOGCEBKPPJE.IKBFGGABMKP(PCECPIAMFEN);
		if (GNBLFGJPAJF > 0)
		{
			array[array.Length - 1] &= (byte)(255 << GNBLFGJPAJF);
		}
		return array;
	}

	internal override void LMDBBPLCJDM(JBLJHINPLMC NMHOOGAGLOA)
	{
		if (GNBLFGJPAJF > 0)
		{
			int num = PCECPIAMFEN[PCECPIAMFEN.Length - 1];
			int num2 = (1 << GNBLFGJPAJF) - 1;
			int num3 = num & num2;
			if (num3 != 0)
			{
				byte[] array = NOGCEBKPPJE.JLIDOPNDFBO(PCECPIAMFEN, (byte)GNBLFGJPAJF);
				array[array.Length - 1] = (byte)(num ^ num3);
				NMHOOGAGLOA.AGNEJPEMPAP(3, array);
				return;
			}
		}
		NMHOOGAGLOA.AGNEJPEMPAP(3, (byte)GNBLFGJPAJF, PCECPIAMFEN);
	}

	protected override int BGFGDLGFEPI()
	{
		return GNBLFGJPAJF.GetHashCode() ^ NOGCEBKPPJE.ILMFICENEMK(PCECPIAMFEN);
	}

	protected override bool IMHPDJGGAGJ(EDOEBJJFOBM LABMKGMAEGK)
	{
		FJMKMKNJKOI fJMKMKNJKOI = LABMKGMAEGK as FJMKMKNJKOI;
		if (fJMKMKNJKOI == null)
		{
			return false;
		}
		return GNBLFGJPAJF == fJMKMKNJKOI.GNBLFGJPAJF && NOGCEBKPPJE.ICKLINNFHKK(PCECPIAMFEN, fJMKMKNJKOI.PCECPIAMFEN);
	}

	public override string JDANMONKNGD()
	{
		StringBuilder stringBuilder = new StringBuilder("#");
		byte[] array = KMBJLPOKIAC();
		for (int i = 0; i != array.Length; i++)
		{
			uint num = array[i];
			stringBuilder.Append(AEPNIOFMGPL[(num >> 4) & 0xF]);
			stringBuilder.Append(AEPNIOFMGPL[array[i] & 0xF]);
		}
		return stringBuilder.ToString();
	}

	internal static FJMKMKNJKOI NKNAANNFPLL(byte[] KBOOEAPJGEL)
	{
		if (KBOOEAPJGEL.Length < 1)
		{
			throw new ArgumentException("truncated BIT STRING detected", "octets");
		}
		int num = KBOOEAPJGEL[0];
		byte[] array = NOGCEBKPPJE.EHLHBAMJLNI(KBOOEAPJGEL, 1, KBOOEAPJGEL.Length);
		if (num > 0 && num < 8 && array.Length > 0)
		{
			int num2 = array[array.Length - 1];
			int num3 = (1 << num) - 1;
			if ((num2 & num3) != 0)
			{
				return new CIBIHNOLONH(array, num);
			}
		}
		return new FJMKMKNJKOI(array, num);
	}
}
