using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Dialogs.BuyCoins
{
	public class BundleBoosterItem : MonoBehaviour
	{
		private struct DHGOPMAODAG
		{
			public readonly Vector3 HOKKEHNMPDD;

			public readonly Vector3 DFJKLHOBKKF;

			public DHGOPMAODAG(Vector3 IPMLMBIHKCK, Vector3 ECICCLCFNJA)
			{
				HOKKEHNMPDD = IPMLMBIHKCK;
				DFJKLHOBKKF = ECICCLCFNJA;
			}
		}

		public TextMeshPro CountText;

		public TextMeshPro ExtraText;

		public SpriteRenderer CurrentSpriteRenderer;

		public SpriteRenderer BackgroundSpriteRenderer;

		private const string JEPFOGOLKGO = "<size=-0.6>x</size>";

		private static string ABMFBOJBOIA = null;

		private static readonly Dictionary<NAAHKHPBAPA, DHGOPMAODAG> BOBKLHHPGNB = new Dictionary<NAAHKHPBAPA, DHGOPMAODAG>(default(KMICDMJOMKP))
		{
			{
				NAAHKHPBAPA.UnlimitedLife,
				new DHGOPMAODAG(new Vector3(-0.63f, 0.057f), new Vector3(0.374f, 0.374f))
			},
			{
				NAAHKHPBAPA.Rocket,
				new DHGOPMAODAG(new Vector3(-0.63f, -0.025f), new Vector3(0.31f, 0.31f))
			},
			{
				NAAHKHPBAPA.DiscoBall,
				new DHGOPMAODAG(new Vector3(-0.64f, 0.012f), new Vector3(0.32f, 0.32f))
			},
			{
				NAAHKHPBAPA.Bomb,
				new DHGOPMAODAG(new Vector3(-0.58f, -0.003f), new Vector3(0.33f, 0.33f))
			},
			{
				NAAHKHPBAPA.BoxingGlove,
				new DHGOPMAODAG(new Vector3(-0.63f, 0f), new Vector3(0.41f, 0.41f))
			},
			{
				NAAHKHPBAPA.Hammer,
				new DHGOPMAODAG(new Vector3(-0.63f, -0.021f), new Vector3(0.34f, 0.34f))
			},
			{
				NAAHKHPBAPA.Anvil,
				new DHGOPMAODAG(new Vector3(-0.56f, -0.022f), new Vector3(0.31f, 0.31f))
			},
			{
				NAAHKHPBAPA.Dice,
				new DHGOPMAODAG(new Vector3(-0.6f, -0.01f), new Vector3(0.3f, 0.3f))
			}
		};

		private void HJDPDBHCFIJ()
		{
			CountText.enabled = true;
			CurrentSpriteRenderer.enabled = true;
			BackgroundSpriteRenderer.enabled = true;
		}

		public void Hide()
		{
			CountText.enabled = false;
			CurrentSpriteRenderer.enabled = false;
			BackgroundSpriteRenderer.enabled = false;
		}

		public void SetContent(NAAHKHPBAPA GEKKLIKPAPP, int FBIAFMHGCMM, int MEICMGGAGEG)
		{
			DHGOPMAODAG value;
			if (BOBKLHHPGNB.TryGetValue(GEKKLIKPAPP, out value))
			{
				CurrentSpriteRenderer.transform.localPosition = value.HOKKEHNMPDD;
				CurrentSpriteRenderer.transform.localScale = value.DFJKLHOBKKF;
			}
			bool flag = GEKKLIKPAPP == NAAHKHPBAPA.UnlimitedLife;
			if (ExtraText != null)
			{
				ExtraText.enabled = flag;
			}
			if (flag)
			{
				ABMFBOJBOIA = "<size=-0.6>" + NKILHODNBDE.GHBGCADFLFB("hoursStr") + "</size>";
				CountText.FCJBBPHFNPJ = MEICMGGAGEG + ABMFBOJBOIA;
			}
			else
			{
				CountText.FCJBBPHFNPJ = "<size=-0.6>x</size>" + FBIAFMHGCMM;
			}
			CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.GetSpriteByInventoryType(GEKKLIKPAPP);
			HJDPDBHCFIJ();
		}
	}
}
