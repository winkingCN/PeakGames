using System;
using caravan.protobuf.messages;

public class JMFKIFOGOIM : NADPOFCHCON
{
	private readonly StClaimResponseMessage DJFBBNDIKED;

	private readonly Action<bool> JCOKJJGCPHI;

	public JMFKIFOGOIM(StClaimResponseMessage OMJOIIOONMO, Action<bool> IMHLFAHONPP, IKDMCJPBBIH KAGBOIDKAED, GBJNCLLOCJB KFNJHBPIHOI)
		: base(KAGBOIDKAED, KFNJHBPIHOI)
	{
		DJFBBNDIKED = OMJOIIOONMO;
		JCOKJJGCPHI = IMHLFAHONPP;
	}

	public override void JLECFJEAFCD()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "StClaimCommand success = {0}.", DJFBBNDIKED.success);
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(DJFBBNDIKED.success != 0);
		}
	}

	public override void AIGOFKAJFBM()
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(false);
		}
	}
}
