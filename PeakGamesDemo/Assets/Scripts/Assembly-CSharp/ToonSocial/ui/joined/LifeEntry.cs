using Assets.Scripts.MapScene;
using NewMapScene;
using TMPro;
using Ui.VerticalScroll;
using UnityEngine;

namespace ToonSocial.ui.joined
{
	public class LifeEntry : VerticalScrollEntry
	{
		public Transform HeartTransform;

		public TextMeshPro Name;

		public TextMeshPro Description;

		private int? DFEAHLCBEDI;

		private LivesInbox DHGJKGMAGHC;

		public void Prepare(string IOCMOCCFALN, int? BDKFNEDHAOJ, LivesInbox IKFGKFKACMN, int NBFBPNNEKMN)
		{
			DFEAHLCBEDI = BDKFNEDHAOJ;
			DHGJKGMAGHC = IKFGKFKACMN;
			switch (NBFBPNNEKMN)
			{
			case 0:
				Name.FCJBBPHFNPJ = IOCMOCCFALN;
				Description.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("SentYouALife");
				break;
			case 1:
				Name.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("DailyBonusTitle");
				Description.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("DailyBonusFreeLife");
				break;
			case 2:
				Name.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("TreasureHunt");
				Description.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("DailyBonusFreeLife");
				break;
			case 3:
				Name.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("StarChest");
				Description.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("DailyBonusFreeLife");
				break;
			default:
				Name.FCJBBPHFNPJ = IOCMOCCFALN;
				Description.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("SentYouALife");
				break;
			}
		}

		public void OnGetClick()
		{
			if (DHGJKGMAGHC.CanGetLife())
			{
				MapUIAnimationController instance = MapUIAnimationController.Instance;
				if (instance != null)
				{
					instance.StartLifeUseAnimation(HeartTransform.position, HeartTransform.lossyScale.x);
				}
				DHGJKGMAGHC.GetLife(DFEAHLCBEDI);
			}
			else
			{
				MapManager.Instance.ShowErrorMessageAtPosition(NKILHODNBDE.GHBGCADFLFB("LifesFull"), new Vector3(0f, -1.48f, 0f));
			}
		}

		public override void SetContent<T>(T IFLICJGCCNM)
		{
			HMBOJCADBKN hMBOJCADBKN = IFLICJGCCNM as HMBOJCADBKN;
			Prepare(hMBOJCADBKN.PNGPLGHKFDI, hMBOJCADBKN.EEFMIHDPJPG, hMBOJCADBKN.LGMFIJJIIDN, hMBOJCADBKN.ENBPGGCIADN);
		}
	}
}
