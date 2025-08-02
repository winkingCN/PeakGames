using Assets.Scripts.MapScene;
using Assets.Scripts.PeakAB.Pocos;
using BestHTTP;
using Dialogs.BuyCoins;

public class CBILMNJENGL : BLBEENOGLAK
{
	public CBILMNJENGL(Variant HOHDPCLDPEP)
		: base(HOHDPCLDPEP)
	{
	}

	protected override void GDGINCNCMDD(HTTPResponse OMJOIIOONMO)
	{
		string text = OMJOIIOONMO.DataAsText.ToLowerInvariant();
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.AbTesting, "Process BuyCoins Data: {0}", text);
		if (!text.StartsWith("bundle"))
		{
			return;
		}
		string[] array = text.Split(':');
		if (array.Length == 2)
		{
			EKGLBJJKNBG.GABGKBAKHDP.FIMIAMGJADB("KeyAB_Bundle", array[1]);
			BOKGFGFPOHD.EAGHHEMOFLE();
			if (!(MapManager.Instance == null) && !(BundleContent.Instance == null) && !ANGCNEFIIHE.GABGKBAKHDP.JPOJKMBOLIJ && MapManager.Instance.CurrentContainerManager.GetCurrentMapPage() != 0)
			{
				BundleContent.Instance.UpdateDataAfterAB();
			}
		}
	}
}
