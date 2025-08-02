using System;
using caravan.protobuf.messages;

public class PIEGFDGCIGA : NADPOFCHCON
{
	private readonly int MDHMNDJKOKP;

	private readonly Action<int> JCOKJJGCPHI;

	public PIEGFDGCIGA(CreateSocialUserResponseMessage OMJOIIOONMO, Action<int> IMHLFAHONPP, IKDMCJPBBIH KAGBOIDKAED, GBJNCLLOCJB KFNJHBPIHOI)
		: base(KAGBOIDKAED, KFNJHBPIHOI)
	{
		MDHMNDJKOKP = OMJOIIOONMO.error;
		JCOKJJGCPHI = IMHLFAHONPP;
	}

	public override void JLECFJEAFCD()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Command, "Create Social User error = {0}", MDHMNDJKOKP);
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(MDHMNDJKOKP);
		}
	}

	public override void AIGOFKAJFBM()
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(1);
		}
	}
}
