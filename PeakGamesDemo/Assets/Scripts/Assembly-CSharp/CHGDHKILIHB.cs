using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Security.Certificates;

public class CHGDHKILIHB
{
	private static readonly JJGIGNBOBJG IIGCJOAFAFB = new JJGIGNBOBJG("CRL");

	private readonly bool OIBFIEPOHFC;

	private FAGODOKGMEH IFANEPLIAAL;

	private int NDIGIPNKOMN;

	private Stream IKACMFHBDDO;

	public CHGDHKILIHB()
		: this(false)
	{
	}

	public CHGDHKILIHB(bool OIBFIEPOHFC)
	{
		this.OIBFIEPOHFC = OIBFIEPOHFC;
	}

	private OFBPGIKBNGF KDPOEFIFKGO(Stream EPKPLBOMHJL)
	{
		ALLINHNNNJN aLLINHNNNJN = IIGCJOAFAFB.LIMPKFOBIED(EPKPLBOMHJL);
		return (aLLINHNNNJN != null) ? ELLLEDPMDJA(MEJFHBGOPAE.BJLJCGFMFOO(aLLINHNNNJN)) : null;
	}

	private OFBPGIKBNGF DEDEGHILDPP(AOKAOIHEKIH IJFDHDOHBEF)
	{
		ALLINHNNNJN aLLINHNNNJN = (ALLINHNNNJN)IJFDHDOHBEF.DMHLIGLGJGI();
		if (aLLINHNNNJN.GMCGMPEEHJP > 1 && aLLINHNNNJN.ECNCPJGHBIG(0) is KLKJHFKJLEM && aLLINHNNNJN.ECNCPJGHBIG(0).Equals(NLPPJKFFBON.HIGAMNPBLBO))
		{
			IFANEPLIAAL = DEPIBGIJJNK.BJLJCGFMFOO(ALLINHNNNJN.BJLJCGFMFOO((PAANMJLACEF)aLLINHNNNJN.ECNCPJGHBIG(1), true)).KEPHMMEGPCJ;
			return IONPMGAIAGF();
		}
		return ELLLEDPMDJA(MEJFHBGOPAE.BJLJCGFMFOO(aLLINHNNNJN));
	}

	private OFBPGIKBNGF IONPMGAIAGF()
	{
		if (IFANEPLIAAL == null || NDIGIPNKOMN >= IFANEPLIAAL.GMCGMPEEHJP)
		{
			return null;
		}
		return ELLLEDPMDJA(MEJFHBGOPAE.BJLJCGFMFOO(IFANEPLIAAL.ECNCPJGHBIG(NDIGIPNKOMN++)));
	}

	protected virtual OFBPGIKBNGF ELLLEDPMDJA(MEJFHBGOPAE FMFABAKPMLB)
	{
		return new OFBPGIKBNGF(FMFABAKPMLB);
	}

	public OFBPGIKBNGF LLPLKOFDLPF(byte[] MOPCLEEGDFB)
	{
		return LLPLKOFDLPF(new MemoryStream(MOPCLEEGDFB, false));
	}

	public ICollection NFKHCMADJHC(byte[] MOPCLEEGDFB)
	{
		return NFKHCMADJHC(new MemoryStream(MOPCLEEGDFB, false));
	}

	public OFBPGIKBNGF LLPLKOFDLPF(Stream EPKPLBOMHJL)
	{
		if (EPKPLBOMHJL == null)
		{
			throw new ArgumentNullException("inStream");
		}
		if (!EPKPLBOMHJL.CanRead)
		{
			throw new ArgumentException("inStream must be read-able", "inStream");
		}
		if (IKACMFHBDDO == null)
		{
			IKACMFHBDDO = EPKPLBOMHJL;
			IFANEPLIAAL = null;
			NDIGIPNKOMN = 0;
		}
		else if (IKACMFHBDDO != EPKPLBOMHJL)
		{
			IKACMFHBDDO = EPKPLBOMHJL;
			IFANEPLIAAL = null;
			NDIGIPNKOMN = 0;
		}
		try
		{
			if (IFANEPLIAAL != null)
			{
				if (NDIGIPNKOMN != IFANEPLIAAL.GMCGMPEEHJP)
				{
					return IONPMGAIAGF();
				}
				IFANEPLIAAL = null;
				NDIGIPNKOMN = 0;
				return null;
			}
			PFGADOAKFGI pFGADOAKFGI = new PFGADOAKFGI(EPKPLBOMHJL);
			int num = pFGADOAKFGI.ReadByte();
			if (num < 0)
			{
				return null;
			}
			pFGADOAKFGI.CNHKNKAFPKE(num);
			if (num != 48)
			{
				return KDPOEFIFKGO(pFGADOAKFGI);
			}
			AOKAOIHEKIH iJFDHDOHBEF = ((!OIBFIEPOHFC) ? new AOKAOIHEKIH(pFGADOAKFGI) : new AAHBFGFDINE(pFGADOAKFGI));
			return DEDEGHILDPP(iJFDHDOHBEF);
		}
		catch (CrlException ex)
		{
			throw ex;
		}
		catch (Exception ex2)
		{
			throw new CrlException(ex2.ToString());
		}
	}

	public ICollection NFKHCMADJHC(Stream EPKPLBOMHJL)
	{
		IList list = LHFGHNFJIKM.PPPFFFBMGML();
		OFBPGIKBNGF value;
		while ((value = LLPLKOFDLPF(EPKPLBOMHJL)) != null)
		{
			list.Add(value);
		}
		return list;
	}
}
