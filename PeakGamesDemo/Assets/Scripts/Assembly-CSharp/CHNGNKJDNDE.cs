using System;

public class CHNGNKJDNDE : LNKPCJLANAO
{
	private readonly KLKJHFKJLEM DHAEIJFFKKI;

	private readonly PJGIGKJFGFI OMJOIIOONMO;

	public KLKJHFKJLEM KKCABDOOKDA
	{
		get
		{
			return DHAEIJFFKKI;
		}
	}

	public PJGIGKJFGFI KFKIHMPOABC
	{
		get
		{
			return OMJOIIOONMO;
		}
	}

	public CHNGNKJDNDE(KLKJHFKJLEM DHAEIJFFKKI, PJGIGKJFGFI OMJOIIOONMO)
	{
		if (DHAEIJFFKKI == null)
		{
			throw new ArgumentNullException("responseType");
		}
		if (OMJOIIOONMO == null)
		{
			throw new ArgumentNullException("response");
		}
		this.DHAEIJFFKKI = DHAEIJFFKKI;
		this.OMJOIIOONMO = OMJOIIOONMO;
	}

	private CHNGNKJDNDE(ALLINHNNNJN MIABODPHOIP)
	{
		if (MIABODPHOIP.GMCGMPEEHJP != 2)
		{
			throw new ArgumentException("Wrong number of elements in sequence", "seq");
		}
		DHAEIJFFKKI = KLKJHFKJLEM.BJLJCGFMFOO(MIABODPHOIP.ECNCPJGHBIG(0));
		OMJOIIOONMO = PJGIGKJFGFI.BJLJCGFMFOO(MIABODPHOIP.ECNCPJGHBIG(1));
	}

	public static CHNGNKJDNDE BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DHGLJHFEJFL)
	{
		return BJLJCGFMFOO(ALLINHNNNJN.BJLJCGFMFOO(NEMEKIOEOLC, DHGLJHFEJFL));
	}

	public static CHNGNKJDNDE BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is CHNGNKJDNDE)
		{
			return (CHNGNKJDNDE)NEMEKIOEOLC;
		}
		if (NEMEKIOEOLC is ALLINHNNNJN)
		{
			return new CHNGNKJDNDE((ALLINHNNNJN)NEMEKIOEOLC);
		}
		throw new ArgumentException("unknown object in factory: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC), "obj");
	}

	public override EDOEBJJFOBM IIHKEACDNID()
	{
		return new KOGPLMALOEH(DHAEIJFFKKI, OMJOIIOONMO);
	}
}
