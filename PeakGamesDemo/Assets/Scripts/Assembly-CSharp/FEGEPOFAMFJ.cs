using caravan.protobuf.messages;

public class FEGEPOFAMFJ : NADPOFCHCON
{
	private readonly TeamChangeResponseMessage DJFBBNDIKED;

	public FEGEPOFAMFJ(TeamChangeResponseMessage OMJOIIOONMO, IKDMCJPBBIH KAGBOIDKAED, GBJNCLLOCJB KFNJHBPIHOI)
		: base(KAGBOIDKAED, KFNJHBPIHOI)
	{
		DJFBBNDIKED = OMJOIIOONMO;
	}

	public override void JLECFJEAFCD()
	{
		if (DJFBBNDIKED.success == 1)
		{
			HJBLKNBHMFJ.GABGKBAKHDP.MFKBEDNLCJA("TeamChangeList");
		}
	}
}
