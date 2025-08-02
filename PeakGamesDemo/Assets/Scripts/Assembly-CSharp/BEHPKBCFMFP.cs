using System;
using caravan.protobuf.messages;

public class BEHPKBCFMFP : NADPOFCHCON
{
	private readonly int EADEMDIHGHE;

	private readonly Action<bool> JCOKJJGCPHI;

	private readonly GetFriendsScoresResponseMessage DJFBBNDIKED;

	public BEHPKBCFMFP(KNNEHLJJIJN KAGBOIDKAED, int KIGOGMKCDKN, Action<bool> IMHLFAHONPP, GetFriendsScoresResponseMessage OMJOIIOONMO, GBJNCLLOCJB OJCKIOENBEL)
		: base(KAGBOIDKAED, OJCKIOENBEL)
	{
		EADEMDIHGHE = KIGOGMKCDKN;
		JCOKJJGCPHI = IMHLFAHONPP;
		if (OJCKIOENBEL == GBJNCLLOCJB.ResultSuccess)
		{
			DJFBBNDIKED = OMJOIIOONMO;
		}
	}

	public override void AIGOFKAJFBM()
	{
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(false);
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.GetFriendsScoresReply, "PerformFailureOperation levelNo:{0}", EADEMDIHGHE);
	}

	public override void JLECFJEAFCD()
	{
		if (DJFBBNDIKED.scores != null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.GetFriendsScoresCommand, "Score of {0} friend retrieved for level {1}", DJFBBNDIKED.scores.Count, EADEMDIHGHE);
		}
		else
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.GetFriendsScoresReply, "No friend score for levelNo:{0}", EADEMDIHGHE);
		}
		AGLOLLABINO.GABGKBAKHDP.DIHCNJLKMGP(EADEMDIHGHE, DJFBBNDIKED.scores);
		if (JCOKJJGCPHI != null)
		{
			JCOKJJGCPHI(true);
		}
	}
}
