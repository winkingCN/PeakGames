using System;

public class MHDGEFBACLA : Exception
{
	private readonly int PBFAFOKINHF;

	public int LCDGFMNDKIN
	{
		get
		{
			return PBFAFOKINHF;
		}
	}

	public MHDGEFBACLA(int FEIFILLPLPM, string OEFCOJLNCKP)
		: base(OEFCOJLNCKP + "(ErrorCode:" + FEIFILLPLPM + ")")
	{
		PBFAFOKINHF = FEIFILLPLPM;
	}
}
