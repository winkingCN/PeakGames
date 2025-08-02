using System;
using caravan.protobuf.messages;

public class CCGPGGNMJFC : NADPOFCHCON
{
	private readonly Action<bool, int> JCOKJJGCPHI;

	private readonly ReportChatResponseMessage DJFBBNDIKED;

	public CCGPGGNMJFC(Action<bool, int> IMHLFAHONPP, ReportChatResponseMessage OMJOIIOONMO, DHEOPGNOBAH DDCPOLCADHH, GBJNCLLOCJB KFNJHBPIHOI)
		: base(DDCPOLCADHH, KFNJHBPIHOI)
	{
		JCOKJJGCPHI = IMHLFAHONPP;
		DJFBBNDIKED = OMJOIIOONMO;
	}

	public override void JLECFJEAFCD()
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(DJFBBNDIKED.success == 1, DJFBBNDIKED.reportCount);
		}
	}

	public override void AIGOFKAJFBM()
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(false, 1);
		}
	}
}
