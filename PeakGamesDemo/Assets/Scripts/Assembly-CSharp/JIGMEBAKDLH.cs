using System;
using caravan.protobuf.messages;

public class JIGMEBAKDLH : NADPOFCHCON
{
	private readonly Action<bool, ClJoinResponseMessage> JCOKJJGCPHI;

	private ClJoinResponseMessage DJFBBNDIKED;

	public JIGMEBAKDLH(ClJoinResponseMessage OMJOIIOONMO, Action<bool, ClJoinResponseMessage> IMHLFAHONPP, IKDMCJPBBIH KAGBOIDKAED, GBJNCLLOCJB KFNJHBPIHOI)
		: base(KAGBOIDKAED, KFNJHBPIHOI)
	{
		DJFBBNDIKED = OMJOIIOONMO;
		JCOKJJGCPHI = IMHLFAHONPP;
	}

	public override void JLECFJEAFCD()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ChampionsLeague, "Join result: {0}", DJFBBNDIKED.status);
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(true, DJFBBNDIKED);
		}
	}

	public override void AIGOFKAJFBM()
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(false, null);
		}
	}
}
