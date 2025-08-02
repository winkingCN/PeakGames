using System;
using TMPro;
using UnityEngine;

namespace Dialogs.BuyCoins
{
	public class CoinsEntry : MonoBehaviour
	{
		public TextMeshPro CoinsText;

		public TextMeshPro PriceText;

		public BoxCollider2D Collider;

		public Transform CoinCollectPosition;

		private Action<string> AICBENPFEIH;

		public string BundleId;

		public int Order;

		public void OnClick()
		{
			if (AICBENPFEIH != null)
			{
				AICBENPFEIH(BundleId);
			}
		}

		public void DisableColliders()
		{
			Collider.enabled = false;
		}

		public void EnableColliders()
		{
			Collider.enabled = true;
		}

		public void ChangeColliderTag(string MELLKFCHLCG)
		{
			Collider.tag = MELLKFCHLCG;
		}

		public void SetContent(string NIODHMGCCHH, int ACFDIDGFPKJ, string NJBGJKFBHGJ, int CMAJLIAELDP, Action<string> DJFNMHFCLLI)
		{
			AICBENPFEIH = DJFNMHFCLLI;
			BundleId = NIODHMGCCHH;
			Order = CMAJLIAELDP;
			PriceText.FCJBBPHFNPJ = NJBGJKFBHGJ;
			CoinsText.FCJBBPHFNPJ = ACFDIDGFPKJ.ToString("# ##0").Replace(" ", "<size=-2> </size>");
		}

		private void OnDestroy()
		{
			AICBENPFEIH = null;
		}
	}
}
