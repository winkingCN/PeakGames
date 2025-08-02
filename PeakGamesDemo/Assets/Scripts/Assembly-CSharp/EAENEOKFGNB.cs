using caravan.protobuf.messages;

public class EAENEOKFGNB : NADPOFCHCON
{
	private readonly ConsentAddResponseMessage DJFBBNDIKED;

	public EAENEOKFGNB(ConsentAddResponseMessage OMJOIIOONMO, IKDMCJPBBIH KAGBOIDKAED, GBJNCLLOCJB KFNJHBPIHOI)
		: base(KAGBOIDKAED, KFNJHBPIHOI)
	{
		DJFBBNDIKED = OMJOIIOONMO;
	}

	public override void JLECFJEAFCD()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Command, "Consent Add Reply Success for user:{0}", DJFBBNDIKED.userId);
		FJPHLKFHDOG.GABGKBAKHDP.KOJKOMDHBBB(DJFBBNDIKED.userId);
	}

	public override void AIGOFKAJFBM()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Command, "Consent Add Reply Failure:");
	}
}
