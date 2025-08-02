using System;
using caravan.protobuf.messages;

public class IHDDEELLFIA : NADPOFCHCON
{
	private readonly Action<bool, ClStatusResponseMessage> JCOKJJGCPHI;

	private readonly ClStatusResponseMessage DJFBBNDIKED;

	public IHDDEELLFIA(ClStatusResponseMessage OMJOIIOONMO, Action<bool, ClStatusResponseMessage> IMHLFAHONPP, IKDMCJPBBIH KAGBOIDKAED, GBJNCLLOCJB KFNJHBPIHOI)
		: base(KAGBOIDKAED, KFNJHBPIHOI)
	{
		JCOKJJGCPHI = IMHLFAHONPP;
		DJFBBNDIKED = OMJOIIOONMO;
	}

	public override void AIGOFKAJFBM()
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(false, null);
		}
	}

	public override void JLECFJEAFCD()
	{
		HBBNMLJMLII(DJFBBNDIKED);
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(true, DJFBBNDIKED);
		}
	}

	private static void HBBNMLJMLII(ClStatusResponseMessage OMJOIIOONMO)
	{
		try
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ChampionsLeague, "Champions League {0} - {1} - {2}", OMJOIIOONMO.ClId, OMJOIIOONMO.status, OMJOIIOONMO.duration);
			if (OMJOIIOONMO.leaderboard == null)
			{
				return;
			}
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ChampionsLeague, "Group: {0}", OMJOIIOONMO.leaderboard.groupId);
			foreach (ClMember member in OMJOIIOONMO.leaderboard.members)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ChampionsLeague, "Member: {0} - {1} - {2} - {3}", member.id, member.nickname, member.score, member.segment);
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ChampionsLeague, "Log Response Exception. Error:{0} Stack:{1}", ex.Message, ex.StackTrace);
		}
	}
}
