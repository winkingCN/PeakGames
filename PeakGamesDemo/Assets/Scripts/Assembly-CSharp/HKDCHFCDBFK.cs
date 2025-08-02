using Assets.Scripts.PeakAB.Pocos;
using BestHTTP;

public class HKDCHFCDBFK : BLBEENOGLAK
{
	public HKDCHFCDBFK(Variant HOHDPCLDPEP)
		: base(HOHDPCLDPEP)
	{
	}

	protected override void GDGINCNCMDD(HTTPResponse OMJOIIOONMO)
	{
		string text = OMJOIIOONMO.DataAsText.ToLowerInvariant();
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AbTesting, "Process Events Data: {0}", text);
		if (text.StartsWith("calendar"))
		{
			string[] array = text.Split(':');
			if (array.Length == 2 && array[0].Equals("calendar"))
			{
				EKGLBJJKNBG.GABGKBAKHDP.FIMIAMGJADB("KeyAB_Calendar", array[1]);
			}
		}
	}
}
