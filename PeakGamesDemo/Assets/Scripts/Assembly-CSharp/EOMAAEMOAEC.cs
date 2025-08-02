using UnityEngine;
using caravan.protobuf.messages;

public class EOMAAEMOAEC : NADPOFCHCON
{
	private readonly string GHGDPCNDMIO;

	private readonly AutoLoginIdResponseMessage DJFBBNDIKED;

	public EOMAAEMOAEC(AutoLoginIdResponseMessage OMJOIIOONMO, string LIDFOJHAOLP, IKDMCJPBBIH KAGBOIDKAED, GBJNCLLOCJB KFNJHBPIHOI)
		: base(KAGBOIDKAED, KFNJHBPIHOI)
	{
		GHGDPCNDMIO = LIDFOJHAOLP;
		DJFBBNDIKED = OMJOIIOONMO;
	}

	public override void JLECFJEAFCD()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Command, "AutoLoginId response status = {0}", DJFBBNDIKED.status);
		if (DJFBBNDIKED.status > 0)
		{
			PlayerPrefs.SetString("LastDeviceId", GHGDPCNDMIO);
		}
	}
}
