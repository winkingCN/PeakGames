using System;
using System.Threading;

public class FBIJJFGLKMK : Random
{
	private static long CKKJMJHIJBN = ONALFDLIJGB.HJDDGNCAKFG();

	private static readonly FBIJJFGLKMK CAMFPAAGCIC = new FBIJJFGLKMK(new LOIACGHAJDD());

	protected readonly ENDHCNJKMOL DLGBFIFCPDM;

	private static readonly double HICJMGNBHCF = Math.Pow(2.0, 64.0);

	private static FBIJJFGLKMK BKKJLFCLIOF
	{
		get
		{
			return CAMFPAAGCIC;
		}
	}

	public FBIJJFGLKMK()
		: this(CDMANNOAMMI("SHA256", true))
	{
	}

	[Obsolete("Use GetInstance/SetSeed instead")]
	public FBIJJFGLKMK(byte[] HJBOEOOLOOE)
		: this(CDMANNOAMMI("SHA1", false))
	{
		LIDDJBHLFFD(HJBOEOOLOOE);
	}

	public FBIJJFGLKMK(ENDHCNJKMOL DLGBFIFCPDM)
		: base(0)
	{
		this.DLGBFIFCPDM = DLGBFIFCPDM;
	}

	private static long INCFLDPLLDF()
	{
		return Interlocked.Increment(ref CKKJMJHIJBN);
	}

	private static DABKMDDBDFE CDMANNOAMMI(string LGBIALICPLG, bool LPDGOOLIHBB)
	{
		BJLAMONNNDD bJLAMONNNDD = KDDIIEMIPKF.GANMELFOOMP(LGBIALICPLG);
		if (bJLAMONNNDD == null)
		{
			return null;
		}
		DABKMDDBDFE dABKMDDBDFE = new DABKMDDBDFE(bJLAMONNNDD);
		if (LPDGOOLIHBB)
		{
			dABKMDDBDFE.GMFBMHLENMN(INCFLDPLLDF());
			dABKMDDBDFE.GMFBMHLENMN(EABAFEKGFMC(BKKJLFCLIOF, bJLAMONNNDD.EEMLLAMENHO()));
		}
		return dABKMDDBDFE;
	}

	public static byte[] EABAFEKGFMC(FBIJJFGLKMK ENKGBJPFHAO, int EOFAGACBNFP)
	{
		byte[] array = new byte[EOFAGACBNFP];
		ENKGBJPFHAO.NextBytes(array);
		return array;
	}

	public static FBIJJFGLKMK BJLJCGFMFOO(string ADLMOHOLCGL)
	{
		return BJLJCGFMFOO(ADLMOHOLCGL, true);
	}

	public static FBIJJFGLKMK BJLJCGFMFOO(string ADLMOHOLCGL, bool LPDGOOLIHBB)
	{
		string text = LHFGHNFJIKM.OGLCLCODHJI(ADLMOHOLCGL);
		if (LHFGHNFJIKM.BGIBPBNIHDL(text, "PRNG"))
		{
			string lGBIALICPLG = text.Substring(0, text.Length - "PRNG".Length);
			DABKMDDBDFE dABKMDDBDFE = CDMANNOAMMI(lGBIALICPLG, LPDGOOLIHBB);
			if (dABKMDDBDFE != null)
			{
				return new FBIJJFGLKMK(dABKMDDBDFE);
			}
		}
		throw new ArgumentException("Unrecognised PRNG algorithm: " + ADLMOHOLCGL, "algorithm");
	}

	[Obsolete("Call GenerateSeed() on a SecureRandom instance instead")]
	public static byte[] GKBBKKNGJAK(int EOFAGACBNFP)
	{
		return EABAFEKGFMC(BKKJLFCLIOF, EOFAGACBNFP);
	}

	public virtual byte[] COGFPDAIFPN(int EOFAGACBNFP)
	{
		return EABAFEKGFMC(BKKJLFCLIOF, EOFAGACBNFP);
	}

	public virtual void LIDDJBHLFFD(byte[] HJBOEOOLOOE)
	{
		DLGBFIFCPDM.GMFBMHLENMN(HJBOEOOLOOE);
	}

	public virtual void LIDDJBHLFFD(long HJBOEOOLOOE)
	{
		DLGBFIFCPDM.GMFBMHLENMN(HJBOEOOLOOE);
	}

	public override int Next()
	{
		return LIFIMLDFLGI() & 0x7FFFFFFF;
	}

	public override int Next(int EPAMIJCEDKG)
	{
		if (EPAMIJCEDKG < 2)
		{
			if (EPAMIJCEDKG < 0)
			{
				throw new ArgumentOutOfRangeException("maxValue", "cannot be negative");
			}
			return 0;
		}
		int num;
		if ((EPAMIJCEDKG & (EPAMIJCEDKG - 1)) == 0)
		{
			num = LIFIMLDFLGI() & 0x7FFFFFFF;
			return (int)((long)num * (long)EPAMIJCEDKG >> 31);
		}
		int num2;
		do
		{
			num = LIFIMLDFLGI() & 0x7FFFFFFF;
			num2 = num % EPAMIJCEDKG;
		}
		while (num - num2 + (EPAMIJCEDKG - 1) < 0);
		return num2;
	}

	public override int Next(int PEGHFLCDCBD, int EPAMIJCEDKG)
	{
		if (EPAMIJCEDKG <= PEGHFLCDCBD)
		{
			if (EPAMIJCEDKG == PEGHFLCDCBD)
			{
				return PEGHFLCDCBD;
			}
			throw new ArgumentException("maxValue cannot be less than minValue");
		}
		int num = EPAMIJCEDKG - PEGHFLCDCBD;
		if (num > 0)
		{
			return PEGHFLCDCBD + Next(num);
		}
		int num2;
		do
		{
			num2 = LIFIMLDFLGI();
		}
		while (num2 < PEGHFLCDCBD || num2 >= EPAMIJCEDKG);
		return num2;
	}

	public override void NextBytes(byte[] GHPCHPOHELF)
	{
		DLGBFIFCPDM.GOADFPHGDJG(GHPCHPOHELF);
	}

	public virtual void GOADFPHGDJG(byte[] GHPCHPOHELF, int JBAJPGIAPFF, int NBEDPKHALCN)
	{
		DLGBFIFCPDM.GOADFPHGDJG(GHPCHPOHELF, JBAJPGIAPFF, NBEDPKHALCN);
	}

	public override double NextDouble()
	{
		return Convert.ToDouble((ulong)LKEDKILJLIH()) / HICJMGNBHCF;
	}

	public virtual int LIFIMLDFLGI()
	{
		byte[] array = new byte[4];
		NextBytes(array);
		uint num = array[0];
		num <<= 8;
		num |= array[1];
		num <<= 8;
		num |= array[2];
		num <<= 8;
		return (int)(num | array[3]);
	}

	public virtual long LKEDKILJLIH()
	{
		return (long)(((ulong)(uint)LIFIMLDFLGI() << 32) | (uint)LIFIMLDFLGI());
	}
}
