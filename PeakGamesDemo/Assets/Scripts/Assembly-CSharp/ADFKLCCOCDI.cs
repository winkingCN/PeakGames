using System;
using System.IO;

public class ADFKLCCOCDI : FBDCBBCMCLK, HGIAHEKANFO
{
	private readonly DIKEJAHBNGH JKKFADEOBOG;

	internal ADFKLCCOCDI(DIKEJAHBNGH JKKFADEOBOG)
	{
		this.JKKFADEOBOG = JKKFADEOBOG;
	}

	public Stream PKLNGAOHLDC()
	{
		return JKKFADEOBOG;
	}

	public EDOEBJJFOBM IIHKEACDNID()
	{
		try
		{
			return new CFMJBFILJCB(JKKFADEOBOG.GDPLKNIEGDB());
		}
		catch (IOException ex)
		{
			throw new InvalidOperationException("IOException converting stream to byte array: " + ex.Message, ex);
		}
	}
}
