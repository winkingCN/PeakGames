using System;
using ToonSocial;
using caravan.protobuf.messages;

public class GNFDHEDGOKN : NADPOFCHCON
{
	private readonly ChangeNicknameResponseMessage DJFBBNDIKED;

	private readonly Action<int> JCOKJJGCPHI;

	public GNFDHEDGOKN(Action<int> IMHLFAHONPP, ChangeNicknameResponseMessage OMJOIIOONMO, IKDMCJPBBIH KAGBOIDKAED, GBJNCLLOCJB KFNJHBPIHOI)
		: base(KAGBOIDKAED, KFNJHBPIHOI)
	{
		DJFBBNDIKED = OMJOIIOONMO;
		JCOKJJGCPHI = IMHLFAHONPP;
	}

	public override void JLECFJEAFCD()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Command, "ChangeNickname error = {0}", DJFBBNDIKED.error);
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(DJFBBNDIKED.error);
		}
		if (DJFBBNDIKED.error != 2)
		{
			GEBAAFFGKJG.GABGKBAKHDP.LDHHPHHKNHL(NJGLIIMEMBI.USER_TYPE_NAME_CHANGED, false);
		}
		if (DJFBBNDIKED.error == 0)
		{
			SocialHelper.RefreshUser();
		}
	}

	public override void AIGOFKAJFBM()
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(2);
		}
	}
}
