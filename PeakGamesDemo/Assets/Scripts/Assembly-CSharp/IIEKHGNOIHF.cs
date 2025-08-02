using Assets.Scripts.PeakAB.Pocos;
using BestHTTP;

public class IIEKHGNOIHF : BLBEENOGLAK
{
	public IIEKHGNOIHF(Variant HOHDPCLDPEP)
		: base(HOHDPCLDPEP)
	{
	}

	protected override void GDGINCNCMDD(HTTPResponse OMJOIIOONMO)
	{
		string dataAsText = OMJOIIOONMO.DataAsText;
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AbTesting, "Process SocialProcessor Data:{0}", dataAsText);
		string[] array = dataAsText.Split(':');
		if (dataAsText.Length > 1)
		{
			string text = array[0].ToLowerInvariant();
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AbTesting, "SocialProcessor Type:{0}", text);
			if (text != null && text == "social_tutorial")
			{
				EKGLBJJKNBG.GABGKBAKHDP.FIMIAMGJADB("KeyAB_SocialTutorial", array[1]);
			}
		}
	}
}
