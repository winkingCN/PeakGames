using caravan.protobuf.messages;

public class ECGJJNMJBDE : NADPOFCHCON
{
	private readonly CalendarClaimResponseMessage DJFBBNDIKED;

	public ECGJJNMJBDE(CalendarClaimResponseMessage OMJOIIOONMO, IKDMCJPBBIH KAGBOIDKAED, GBJNCLLOCJB KFNJHBPIHOI)
		: base(KAGBOIDKAED, KFNJHBPIHOI)
	{
		DJFBBNDIKED = OMJOIIOONMO;
	}

	public override void JLECFJEAFCD()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Bonus, "Calendar: Duration: {0}, NextDuration: {1}, Step: {2}", DJFBBNDIKED.duration, DJFBBNDIKED.nextDuration, DJFBBNDIKED.step);
		if (DJFBBNDIKED.step > 0)
		{
			BPPNANHCLJI.GABGKBAKHDP.DNBHGBMPIDO(DJFBBNDIKED.duration >= 0, DJFBBNDIKED.step, DJFBBNDIKED.duration);
		}
	}

	public override void AIGOFKAJFBM()
	{
	}
}
