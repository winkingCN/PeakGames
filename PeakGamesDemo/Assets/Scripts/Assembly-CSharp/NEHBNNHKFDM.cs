using System.IO;
using Org.BouncyCastle.Asn1;

public class NEHBNNHKFDM : FBDCBBCMCLK, HGIAHEKANFO
{
	private readonly MKNDIEHOMOI IGCEJBIEACI;

	internal NEHBNNHKFDM(MKNDIEHOMOI BKOBLIALKKC)
	{
		IGCEJBIEACI = BKOBLIALKKC;
	}

	public Stream PKLNGAOHLDC()
	{
		return new IPDDAGEBHMA(IGCEJBIEACI);
	}

	public EDOEBJJFOBM IIHKEACDNID()
	{
		try
		{
			return new OHNBHCLIOEI(NPBFDBCHIGL.FOJKFJEEFJN(PKLNGAOHLDC()));
		}
		catch (IOException ex)
		{
			throw new Asn1ParsingException("IOException converting stream to byte array: " + ex.Message, ex);
		}
	}
}
