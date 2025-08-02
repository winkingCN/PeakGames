using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Ui.VerticalScroll;
using UnityEngine;

namespace Dialogs.BuyCoins
{
	public class BundleContent : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class CGFOFEKFAHM
		{
			internal int CMAJLIAELDP;

			internal bool AGFNGEFDHLA(PMCGNIAAMND BCIHLCMFAEK)
			{
				return BCIHLCMFAEK.BHIJCAOHDCM == CMAJLIAELDP;
			}
		}

		[CompilerGenerated]
		private sealed class KJHOEEFFJHP
		{
			internal int CMAJLIAELDP;

			internal bool AGFNGEFDHLA(KHMIKAEKHIG BCIHLCMFAEK)
			{
				return BCIHLCMFAEK.FDHJCJEBGMJ == CMAJLIAELDP;
			}
		}

		[CompilerGenerated]
		private sealed class GLPCOKLOCLB
		{
			internal string NIODHMGCCHH;

			internal bool AGFNGEFDHLA(PMCGNIAAMND BCIHLCMFAEK)
			{
				return BCIHLCMFAEK.FDIOHLPIGAI == NIODHMGCCHH;
			}
		}

		[CompilerGenerated]
		private sealed class CIEFHBOGINJ
		{
			internal string NIODHMGCCHH;

			internal bool AGFNGEFDHLA(KHMIKAEKHIG FMFABAKPMLB)
			{
				return FMFABAKPMLB.INMJKIDMBKB == NIODHMGCCHH;
			}
		}

		public GameObject CoinEntryPrefab;

		public GameObject BundleEntryBeginnerPrefab;

		public GameObject BundleEntryPrefab;

		public GameObject MoreOffersButton;

		public VerticalScrollController ScrollController;

		private int LLFNEKGDDCK;

		private HJBLKNBHMFJ GOEMHMEALGJ;

		private bool OONBCJCNGBM;

		private int IFMEAAAGHKK = 6;

		private int KMAPBIJHMMA = 6;

		private readonly List<CoinsEntry> CGMKIHEAGAG = new List<CoinsEntry>();

		private readonly List<BundleEntry> AAKMEGPAIJN = new List<BundleEntry>();

		private Action<string> JOMBEMFJCFD;

		private Action<string> KIBDGDIKEKD;

		private Action IFCENOEJGLI;

		private const float IMNOLKKKBBE = 5.05f;

		private const float CBDCADAMHAM = 1.35f;

		private const float PKKOIHIELFJ = -0.5f;

		private const float IMPLJBGOLML = 0.5f;

		private const float ADAPELJCCBM = 0.05f;

		public static BundleContent Instance;

		private int OMGDJGEIALD;

		public void Init(Action<string> MDONEELHENG, Action<string> NAPEFGFMCGC, Action CHGBAHPPPMO = null)
		{
			GOEMHMEALGJ = HJBLKNBHMFJ.GABGKBAKHDP;
			JOMBEMFJCFD = MDONEELHENG;
			KIBDGDIKEKD = NAPEFGFMCGC;
			IFCENOEJGLI = CHGBAHPPPMO;
			UpdateHighestBoughtPackageOrder();
		}

		public void Prepare()
		{
			MoreOffersButton.SetActive(false);
			PrepareScrollController();
			OCMIDALFLHD();
			AGEGJPHKEFG();
			if (IFCENOEJGLI != null)
			{
				IFCENOEJGLI();
				IFCENOEJGLI = null;
			}
		}

		private void OnDestroy()
		{
			OONBCJCNGBM = true;
		}

		public void DisableColliders()
		{
			int count = AAKMEGPAIJN.Count;
			for (int i = 0; i < count; i++)
			{
				AAKMEGPAIJN[i].DisableColliders();
			}
			count = CGMKIHEAGAG.Count;
			for (int j = 0; j < count; j++)
			{
				CGMKIHEAGAG[j].DisableColliders();
			}
			ScrollController.DAMJJFCIHBA();
		}

		public void EnableColliders()
		{
			int count = AAKMEGPAIJN.Count;
			for (int i = 0; i < count; i++)
			{
				AAKMEGPAIJN[i].EnableColliders();
			}
			count = CGMKIHEAGAG.Count;
			for (int j = 0; j < count; j++)
			{
				CGMKIHEAGAG[j].EnableColliders();
			}
			ScrollController.JBOFOOHGDGC();
		}

		public void PrepareScrollController()
		{
			ScrollController.Init();
			ScrollController.SetContentSize(1f);
		}

		private void OCMIDALFLHD()
		{
			for (int i = 0; i < KMAPBIJHMMA; i++)
			{
				if (LLFNEKGDDCK > 0 && i == 0)
				{
					continue;
				}
				PMCGNIAAMND pMCGNIAAMND = BOKGFGFPOHD.NIAJFDLMNJH[i];
				if (pMCGNIAAMND.CIOENCFNLKH >= OMGDJGEIALD)
				{
					GameObject original = ((i != 0) ? BundleEntryPrefab : BundleEntryBeginnerPrefab);
					BundleEntry component = UnityEngine.Object.Instantiate(original, ScrollController.Content.transform).GetComponent<BundleEntry>();
					component.gameObject.SetActive(false);
					string text = ANGCNEFIIHE.GABGKBAKHDP.JBGJMFHPBDM(pMCGNIAAMND.FDIOHLPIGAI);
					if (text == null)
					{
						text = BOKGFGFPOHD.FAEIHDFPLFI[pMCGNIAAMND.FDIOHLPIGAI];
					}
					component.SetContent(pMCGNIAAMND, text, JOMBEMFJCFD);
					AAKMEGPAIJN.Add(component);
				}
			}
			for (int j = 0; j < IFMEAAAGHKK; j++)
			{
				KHMIKAEKHIG kHMIKAEKHIG = BOKGFGFPOHD.FNEABNFILKK[j];
				if (kHMIKAEKHIG.LGCFDCILJFO >= OMGDJGEIALD)
				{
					CoinsEntry component2 = UnityEngine.Object.Instantiate(CoinEntryPrefab, ScrollController.Content.transform).GetComponent<CoinsEntry>();
					component2.gameObject.SetActive(false);
					string text2 = ANGCNEFIIHE.GABGKBAKHDP.JBGJMFHPBDM(kHMIKAEKHIG.INMJKIDMBKB);
					if (text2 == null)
					{
						text2 = BOKGFGFPOHD.FAEIHDFPLFI[kHMIKAEKHIG.INMJKIDMBKB];
					}
					component2.SetContent(kHMIKAEKHIG.INMJKIDMBKB, kHMIKAEKHIG.LGCFDCILJFO, text2, kHMIKAEKHIG.FDHJCJEBGMJ, KIBDGDIKEKD);
					CGMKIHEAGAG.Add(component2);
				}
			}
		}

		private void AGEGJPHKEFG()
		{
			ANGCNEFIIHE.GABGKBAKHDP.FEEMCKCKAAL(delegate(bool DIDHNNMKJFE)
			{
				if (DIDHNNMKJFE && !OONBCJCNGBM)
				{
					int count = AAKMEGPAIJN.Count;
					for (int i = 0; i < count; i++)
					{
						BundleEntry bundleEntry = AAKMEGPAIJN[i];
						string NIODHMGCCHH2 = bundleEntry.BundleId;
						PMCGNIAAMND pMCGNIAAMND = BOKGFGFPOHD.NIAJFDLMNJH.FirstOrDefault((PMCGNIAAMND BCIHLCMFAEK) => BCIHLCMFAEK.FDIOHLPIGAI == NIODHMGCCHH2);
						if (pMCGNIAAMND != null)
						{
							string text = ANGCNEFIIHE.GABGKBAKHDP.ENHPFINGJEA(NIODHMGCCHH2);
							if (text != null)
							{
								bundleEntry.SetContent(pMCGNIAAMND, text, JOMBEMFJCFD);
							}
						}
					}
					count = CGMKIHEAGAG.Count;
					for (int j = 0; j < count; j++)
					{
						CoinsEntry coinsEntry = CGMKIHEAGAG[j];
						string NIODHMGCCHH = coinsEntry.BundleId;
						KHMIKAEKHIG kHMIKAEKHIG = BOKGFGFPOHD.FNEABNFILKK.FirstOrDefault((KHMIKAEKHIG FMFABAKPMLB) => FMFABAKPMLB.INMJKIDMBKB == NIODHMGCCHH);
						if (kHMIKAEKHIG.INMJKIDMBKB != null)
						{
							string text2 = ANGCNEFIIHE.GABGKBAKHDP.ENHPFINGJEA(kHMIKAEKHIG.INMJKIDMBKB);
							if (text2 != null)
							{
								coinsEntry.SetContent(kHMIKAEKHIG.INMJKIDMBKB, kHMIKAEKHIG.LGCFDCILJFO, text2, kHMIKAEKHIG.FDHJCJEBGMJ, KIBDGDIKEKD);
							}
						}
					}
				}
			});
		}

		public void UpdateDataAfterAB()
		{
			for (int i = 0; i < AAKMEGPAIJN.Count; i++)
			{
				BundleEntry bundleEntry = AAKMEGPAIJN[i];
				int CMAJLIAELDP2 = bundleEntry.Order;
				PMCGNIAAMND pMCGNIAAMND = BOKGFGFPOHD.NIAJFDLMNJH.FirstOrDefault((PMCGNIAAMND BCIHLCMFAEK) => BCIHLCMFAEK.BHIJCAOHDCM == CMAJLIAELDP2);
				string lJFDPILBBFM = ANGCNEFIIHE.GABGKBAKHDP.JBGJMFHPBDM(pMCGNIAAMND.FDIOHLPIGAI) ?? BOKGFGFPOHD.FAEIHDFPLFI[pMCGNIAAMND.FDIOHLPIGAI];
				bundleEntry.SetContent(pMCGNIAAMND, lJFDPILBBFM, JOMBEMFJCFD);
			}
			for (int j = 0; j < CGMKIHEAGAG.Count; j++)
			{
				CoinsEntry coinsEntry = CGMKIHEAGAG[j];
				int CMAJLIAELDP = coinsEntry.Order;
				KHMIKAEKHIG kHMIKAEKHIG = BOKGFGFPOHD.FNEABNFILKK.FirstOrDefault((KHMIKAEKHIG BCIHLCMFAEK) => BCIHLCMFAEK.FDHJCJEBGMJ == CMAJLIAELDP);
				string nJBGJKFBHGJ = ANGCNEFIIHE.GABGKBAKHDP.JBGJMFHPBDM(kHMIKAEKHIG.INMJKIDMBKB) ?? BOKGFGFPOHD.FAEIHDFPLFI[kHMIKAEKHIG.INMJKIDMBKB];
				coinsEntry.SetContent(kHMIKAEKHIG.INMJKIDMBKB, kHMIKAEKHIG.LGCFDCILJFO, nJBGJKFBHGJ, kHMIKAEKHIG.FDHJCJEBGMJ, KIBDGDIKEKD);
			}
		}

		public void ShowInitialEntries()
		{
			float num = -0.5f;
			int count = AAKMEGPAIJN.Count;
			int num2 = 0;
			switch (LLFNEKGDDCK)
			{
			case 0:
				num2 = 1;
				break;
			case 1:
				num2 = 2;
				break;
			default:
				num2 = LLFNEKGDDCK;
				break;
			}
			int order = AAKMEGPAIJN[0].Order;
			if (num2 < order)
			{
				num2 = order;
			}
			int num3 = Math.Min(num2 + 1, 6);
			num2 = num3 - 1;
			bool flag = LLFNEKGDDCK > 0;
			int num4 = 0;
			int num5 = 0;
			for (int i = 0; i < count; i++)
			{
				BundleEntry bundleEntry = AAKMEGPAIJN[i];
				if (bundleEntry.Order >= num2 && bundleEntry.Order <= num3)
				{
					num4++;
					BundleEntry bundleEntry2 = AAKMEGPAIJN[i];
					Vector3 vector = new Vector3(0f, (!flag) ? num : ((float)(-(2 - num4)) * 5.05f + -0.5f));
					bundleEntry2.transform.localPosition = new Vector3(10f, vector.y);
					bundleEntry2.transform.DOLocalMoveX(0f, 0.5f).SetEase(Ease.OutBack).SetDelay((float)((!flag) ? num5 : (1 - num5)) * 0.05f);
					bundleEntry2.gameObject.SetActive(true);
					num -= 5.05f;
					num5++;
				}
			}
			bool flag2 = CGMKIHEAGAG[0].BundleId == BOKGFGFPOHD.FNEABNFILKK[0].INMJKIDMBKB && flag;
			count = CGMKIHEAGAG.Count;
			for (int j = 0; j < count; j++)
			{
				CoinsEntry coinsEntry = CGMKIHEAGAG[j];
				int order2 = coinsEntry.Order;
				if ((flag2 && j == 0) || (order2 >= num2 && order2 <= num3))
				{
					coinsEntry.gameObject.SetActive(true);
					Vector3 vector2 = new Vector3(0f, num);
					coinsEntry.transform.localPosition = new Vector3(10f, vector2.y);
					coinsEntry.transform.DOLocalMoveX(0f, 0.5f).SetEase(Ease.OutBack).SetDelay((float)num5 * 0.05f);
					num -= 1.35f;
					num5++;
				}
			}
			num -= 1f;
			MoreOffersButton.SetActive(true);
			MoreOffersButton.transform.localPosition = new Vector3(0f, num, -5f);
			num -= 1f;
			ScrollController.SetContentSize(0f - num);
			ScrollController.ScrollToTop();
		}

		public void ShowAllOffers(bool ODJGLICBNKH = false)
		{
			bool flag = LLFNEKGDDCK > 0;
			float num = -0.5f;
			int count = AAKMEGPAIJN.Count;
			for (int i = 0; i < count; i++)
			{
				BundleEntry bundleEntry = AAKMEGPAIJN[i];
				Vector3 localPosition = new Vector3(0f, (!flag) ? num : ((float)(-(count - i - 1)) * 5.05f + -0.5f));
				if (ODJGLICBNKH && !bundleEntry.gameObject.activeSelf)
				{
					bundleEntry.transform.localPosition = new Vector3(10f, localPosition.y);
					bundleEntry.transform.DOLocalMoveX(0f, 0.5f).SetEase(Ease.OutBack).SetDelay((float)((!flag) ? i : (count - 1 - i)) * 0.05f);
				}
				else
				{
					bundleEntry.transform.localPosition = localPosition;
				}
				bundleEntry.gameObject.SetActive(true);
				num -= 5.05f;
			}
			count = CGMKIHEAGAG.Count;
			for (int j = 0; j < count; j++)
			{
				CoinsEntry coinsEntry = CGMKIHEAGAG[j];
				Vector3 localPosition2 = new Vector3(0f, num);
				if (ODJGLICBNKH && !coinsEntry.gameObject.activeSelf)
				{
					coinsEntry.transform.localPosition = new Vector3(10f, localPosition2.y);
					coinsEntry.transform.DOLocalMoveX(0f, 0.5f).SetEase(Ease.OutBack);
				}
				else
				{
					coinsEntry.transform.localPosition = localPosition2;
				}
				coinsEntry.gameObject.SetActive(true);
				num -= 1.35f;
			}
			num -= 0.675f;
			ScrollController.SetContentSize(0f - num);
		}

		public void MakePayerAndUpdateOffers()
		{
			BundleEntry bundleEntry = AAKMEGPAIJN[0];
			if (bundleEntry.BundleId == BOKGFGFPOHD.NIAJFDLMNJH[0].FDIOHLPIGAI)
			{
				UnityEngine.Object.Destroy(bundleEntry.gameObject);
				AAKMEGPAIJN.RemoveAt(0);
				ShowAllOffers();
			}
		}

		public Vector3 GetBundleButtonPosition(int EHJNMODJEAN)
		{
			return AAKMEGPAIJN[EHJNMODJEAN].CoinCollectPosition.position;
		}

		public Vector3 GetCoinButtonPosition(int EHJNMODJEAN)
		{
			return CGMKIHEAGAG[EHJNMODJEAN].CoinCollectPosition.position;
		}

		public void UpdateHighestBoughtPackageOrder()
		{
			int.TryParse(GOEMHMEALGJ.LIANKDMAHFM("KeyHighestBoughtBundleNo"), out LLFNEKGDDCK);
		}

		public void OnMoreOffersClick()
		{
			MoreOffersButton.gameObject.SetActive(false);
			ShowAllOffers(true);
		}

		public void ChangeSortingLayer(int MLEJMHGEOKE, string MELLKFCHLCG)
		{
			AEEAAMFGAGC(MoreOffersButton.transform, MLEJMHGEOKE);
			MoreOffersButton.tag = MELLKFCHLCG;
			int count = AAKMEGPAIJN.Count;
			for (int i = 0; i < count; i++)
			{
				AEEAAMFGAGC(AAKMEGPAIJN[i].transform, MLEJMHGEOKE);
				AAKMEGPAIJN[i].ChangeColliderTag(MELLKFCHLCG);
			}
			count = CGMKIHEAGAG.Count;
			for (int j = 0; j < count; j++)
			{
				AEEAAMFGAGC(CGMKIHEAGAG[j].transform, MLEJMHGEOKE);
				CGMKIHEAGAG[j].ChangeColliderTag(MELLKFCHLCG);
			}
		}

		private void AEEAAMFGAGC(Transform ANLKLKAINEO, int MLEJMHGEOKE)
		{
			SpriteRenderer[] componentsInChildren = ANLKLKAINEO.GetComponentsInChildren<SpriteRenderer>();
			foreach (SpriteRenderer spriteRenderer in componentsInChildren)
			{
				if (spriteRenderer != null)
				{
					spriteRenderer.sortingLayerID = MLEJMHGEOKE;
				}
			}
			MeshRenderer[] componentsInChildren2 = ANLKLKAINEO.GetComponentsInChildren<MeshRenderer>();
			foreach (MeshRenderer meshRenderer in componentsInChildren2)
			{
				if (meshRenderer != null)
				{
					meshRenderer.sortingLayerID = MLEJMHGEOKE;
				}
			}
		}

		public void DontDisplayUnder(int EJICKCGPFAH)
		{
			OMGDJGEIALD = EJICKCGPFAH;
		}

		[CompilerGenerated]
		private void ADNHPBHCMHH(bool DIDHNNMKJFE)
		{
			if (!DIDHNNMKJFE || OONBCJCNGBM)
			{
				return;
			}
			int count = AAKMEGPAIJN.Count;
			for (int i = 0; i < count; i++)
			{
				BundleEntry bundleEntry = AAKMEGPAIJN[i];
				string NIODHMGCCHH = bundleEntry.BundleId;
				PMCGNIAAMND pMCGNIAAMND = BOKGFGFPOHD.NIAJFDLMNJH.FirstOrDefault((PMCGNIAAMND BCIHLCMFAEK) => BCIHLCMFAEK.FDIOHLPIGAI == NIODHMGCCHH);
				if (pMCGNIAAMND != null)
				{
					string text = ANGCNEFIIHE.GABGKBAKHDP.ENHPFINGJEA(NIODHMGCCHH);
					if (text != null)
					{
						bundleEntry.SetContent(pMCGNIAAMND, text, JOMBEMFJCFD);
					}
				}
			}
			count = CGMKIHEAGAG.Count;
			for (int j = 0; j < count; j++)
			{
				CoinsEntry coinsEntry = CGMKIHEAGAG[j];
				string NIODHMGCCHH2 = coinsEntry.BundleId;
				KHMIKAEKHIG kHMIKAEKHIG = BOKGFGFPOHD.FNEABNFILKK.FirstOrDefault((KHMIKAEKHIG FMFABAKPMLB) => FMFABAKPMLB.INMJKIDMBKB == NIODHMGCCHH2);
				if (kHMIKAEKHIG.INMJKIDMBKB != null)
				{
					string text2 = ANGCNEFIIHE.GABGKBAKHDP.ENHPFINGJEA(kHMIKAEKHIG.INMJKIDMBKB);
					if (text2 != null)
					{
						coinsEntry.SetContent(kHMIKAEKHIG.INMJKIDMBKB, kHMIKAEKHIG.LGCFDCILJFO, text2, kHMIKAEKHIG.FDHJCJEBGMJ, KIBDGDIKEKD);
					}
				}
			}
		}
	}
}
