using System;
using System.IO;
using System.Text;
using Org.BouncyCastle.Math;

public class KLKJHFKJLEM : EDOEBJJFOBM
{
	private readonly string GMBNJCKNOBD;

	private byte[] KCIJNHPGJKF;

	private const long NMJFALOEBEK = 72057594037927808L;

	private static readonly KLKJHFKJLEM[] EMGEPAJHHLN = new KLKJHFKJLEM[1024];

	public string EEFMIHDPJPG
	{
		get
		{
			return GMBNJCKNOBD;
		}
	}

	public KLKJHFKJLEM(string GMBNJCKNOBD)
	{
		if (GMBNJCKNOBD == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (!AIJIDIACNHD(GMBNJCKNOBD))
		{
			throw new FormatException("string " + GMBNJCKNOBD + " not an OID");
		}
		this.GMBNJCKNOBD = GMBNJCKNOBD;
	}

	internal KLKJHFKJLEM(KLKJHFKJLEM GDFLIKNMBCL, string PDALFDFLDBH)
	{
		if (!CDEDGAJABNE(PDALFDFLDBH, 0))
		{
			throw new ArgumentException("string " + PDALFDFLDBH + " not a valid OID branch", "branchID");
		}
		GMBNJCKNOBD = GDFLIKNMBCL.EEFMIHDPJPG + "." + PDALFDFLDBH;
	}

	internal KLKJHFKJLEM(byte[] DIPNEDDIHBK)
	{
		GMBNJCKNOBD = KAAJLPIOKNF(DIPNEDDIHBK);
		KCIJNHPGJKF = NOGCEBKPPJE.IKBFGGABMKP(DIPNEDDIHBK);
	}

	public static KLKJHFKJLEM BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is KLKJHFKJLEM)
		{
			return (KLKJHFKJLEM)NEMEKIOEOLC;
		}
		if (NEMEKIOEOLC is byte[])
		{
			return DADPGGIAGHN((byte[])NEMEKIOEOLC);
		}
		throw new ArgumentException("illegal object in GetInstance: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC), "obj");
	}

	public static KLKJHFKJLEM BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DHGLJHFEJFL)
	{
		return BJLJCGFMFOO(NEMEKIOEOLC.NFMFKPLPLLH());
	}

	public virtual KLKJHFKJLEM BCDAGLPENOK(string PDALFDFLDBH)
	{
		return new KLKJHFKJLEM(this, PDALFDFLDBH);
	}

	public virtual bool JDAFDFOMLHG(KLKJHFKJLEM DLGMIJMPIGD)
	{
		string text = EEFMIHDPJPG;
		string text2 = DLGMIJMPIGD.EEFMIHDPJPG;
		return text.Length > text2.Length && text[text2.Length] == '.' && LHFGHNFJIKM.GNEPOHDBAEJ(text, text2);
	}

	private void BPDCDKJFNDI(Stream CPNFIBMCOCG, long KNNCJHPOKKB)
	{
		byte[] array = new byte[9];
		int num = 8;
		array[num] = (byte)(KNNCJHPOKKB & 0x7F);
		while (KNNCJHPOKKB >= 128)
		{
			KNNCJHPOKKB >>= 7;
			array[--num] = (byte)((KNNCJHPOKKB & 0x7F) | 0x80);
		}
		CPNFIBMCOCG.Write(array, num, 9 - num);
	}

	private void BPDCDKJFNDI(Stream CPNFIBMCOCG, BigInteger KNNCJHPOKKB)
	{
		int num = (KNNCJHPOKKB.BitLength + 6) / 7;
		if (num == 0)
		{
			CPNFIBMCOCG.WriteByte(0);
			return;
		}
		BigInteger bigInteger = KNNCJHPOKKB;
		byte[] array = new byte[num];
		for (int num2 = num - 1; num2 >= 0; num2--)
		{
			array[num2] = (byte)(((uint)bigInteger.IntValue & 0x7Fu) | 0x80u);
			bigInteger = bigInteger.ABOIOKBIANB(7);
		}
		array[num - 1] &= 127;
		CPNFIBMCOCG.Write(array, 0, array.Length);
	}

	private void JPNHGEDFOOC(MemoryStream JBKJDDDPONA)
	{
		HCMCCCCKCMG hCMCCCCKCMG = new HCMCCCCKCMG(GMBNJCKNOBD);
		string s = hCMCCCCKCMG.NMLDMNBOJFN();
		int num = int.Parse(s) * 40;
		s = hCMCCCCKCMG.NMLDMNBOJFN();
		if (s.Length <= 18)
		{
			BPDCDKJFNDI(JBKJDDDPONA, num + long.Parse(s));
		}
		else
		{
			BPDCDKJFNDI(JBKJDDDPONA, new BigInteger(s).JEACJNAKLDJ(BigInteger.AGLOJCOAJIK(num)));
		}
		while (hCMCCCCKCMG.OEGNOKFOOBH)
		{
			s = hCMCCCCKCMG.NMLDMNBOJFN();
			if (s.Length <= 18)
			{
				BPDCDKJFNDI(JBKJDDDPONA, long.Parse(s));
			}
			else
			{
				BPDCDKJFNDI(JBKJDDDPONA, new BigInteger(s));
			}
		}
	}

	internal byte[] PLPEAPFFJOH()
	{
		lock (this)
		{
			if (KCIJNHPGJKF == null)
			{
				MemoryStream memoryStream = new MemoryStream();
				JPNHGEDFOOC(memoryStream);
				KCIJNHPGJKF = memoryStream.ToArray();
			}
		}
		return KCIJNHPGJKF;
	}

	internal override void LMDBBPLCJDM(JBLJHINPLMC NMHOOGAGLOA)
	{
		NMHOOGAGLOA.AGNEJPEMPAP(6, PLPEAPFFJOH());
	}

	protected override int BGFGDLGFEPI()
	{
		return GMBNJCKNOBD.GetHashCode();
	}

	protected override bool IMHPDJGGAGJ(EDOEBJJFOBM LABMKGMAEGK)
	{
		KLKJHFKJLEM kLKJHFKJLEM = LABMKGMAEGK as KLKJHFKJLEM;
		if (kLKJHFKJLEM == null)
		{
			return false;
		}
		return GMBNJCKNOBD.Equals(kLKJHFKJLEM.GMBNJCKNOBD);
	}

	public override string ToString()
	{
		return GMBNJCKNOBD;
	}

	private static bool CDEDGAJABNE(string PDALFDFLDBH, int EHGOOEHDNMM)
	{
		bool flag = false;
		int num = PDALFDFLDBH.Length;
		while (--num >= EHGOOEHDNMM)
		{
			char c = PDALFDFLDBH[num];
			if ('0' <= c && c <= '9')
			{
				flag = true;
				continue;
			}
			if (c == '.')
			{
				if (!flag)
				{
					return false;
				}
				flag = false;
				continue;
			}
			return false;
		}
		return flag;
	}

	private static bool AIJIDIACNHD(string GMBNJCKNOBD)
	{
		if (GMBNJCKNOBD.Length < 3 || GMBNJCKNOBD[1] != '.')
		{
			return false;
		}
		char c = GMBNJCKNOBD[0];
		if (c < '0' || c > '2')
		{
			return false;
		}
		return CDEDGAJABNE(GMBNJCKNOBD, 2);
	}

	private static string KAAJLPIOKNF(byte[] DIPNEDDIHBK)
	{
		StringBuilder stringBuilder = new StringBuilder();
		long num = 0L;
		BigInteger bigInteger = null;
		bool flag = true;
		for (int i = 0; i != DIPNEDDIHBK.Length; i++)
		{
			int num2 = DIPNEDDIHBK[i];
			if (num <= 72057594037927808L)
			{
				num += num2 & 0x7F;
				if ((num2 & 0x80) == 0)
				{
					if (flag)
					{
						if (num < 40)
						{
							stringBuilder.Append('0');
						}
						else if (num < 80)
						{
							stringBuilder.Append('1');
							num -= 40;
						}
						else
						{
							stringBuilder.Append('2');
							num -= 80;
						}
						flag = false;
					}
					stringBuilder.Append('.');
					stringBuilder.Append(num);
					num = 0L;
				}
				else
				{
					num <<= 7;
				}
				continue;
			}
			if (bigInteger == null)
			{
				bigInteger = BigInteger.AGLOJCOAJIK(num);
			}
			bigInteger = bigInteger.CIAIADPNAON(BigInteger.AGLOJCOAJIK(num2 & 0x7F));
			if ((num2 & 0x80) == 0)
			{
				if (flag)
				{
					stringBuilder.Append('2');
					bigInteger = bigInteger.FBGIHKPECCO(BigInteger.AGLOJCOAJIK(80L));
					flag = false;
				}
				stringBuilder.Append('.');
				stringBuilder.Append(bigInteger);
				bigInteger = null;
				num = 0L;
			}
			else
			{
				bigInteger = bigInteger.DOKHFLENGLF(7);
			}
		}
		return stringBuilder.ToString();
	}

	internal static KLKJHFKJLEM DADPGGIAGHN(byte[] LALAKHICDBP)
	{
		int num = NOGCEBKPPJE.ILMFICENEMK(LALAKHICDBP);
		int num2 = num & 0x3FF;
		lock (EMGEPAJHHLN)
		{
			KLKJHFKJLEM kLKJHFKJLEM = EMGEPAJHHLN[num2];
			if (kLKJHFKJLEM != null && NOGCEBKPPJE.ICKLINNFHKK(LALAKHICDBP, kLKJHFKJLEM.PLPEAPFFJOH()))
			{
				return kLKJHFKJLEM;
			}
			return EMGEPAJHHLN[num2] = new KLKJHFKJLEM(LALAKHICDBP);
		}
	}
}
