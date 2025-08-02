using System;
using caravan.protobuf.messages;

public class FLJKGGKGGJL : NADPOFCHCON
{
	private readonly TtClaimResponseMessage DJFBBNDIKED;

	private readonly Action<bool> JCOKJJGCPHI;

	public FLJKGGKGGJL(TtClaimResponseMessage OMJOIIOONMO, Action<bool> IMHLFAHONPP, IKDMCJPBBIH KAGBOIDKAED, GBJNCLLOCJB KFNJHBPIHOI)
		: base(KAGBOIDKAED, KFNJHBPIHOI)
	{
		DJFBBNDIKED = OMJOIIOONMO;
		JCOKJJGCPHI = IMHLFAHONPP;
	}

	public override void JLECFJEAFCD()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TtClaimCommand success = {0}.", DJFBBNDIKED.success);
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
