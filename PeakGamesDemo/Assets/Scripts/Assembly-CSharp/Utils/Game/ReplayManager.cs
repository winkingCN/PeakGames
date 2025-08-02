using System.Collections;
using System.Runtime.CompilerServices;
using Assets.Scripts.Dialogs;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Touches;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Utils.Game
{
	public class ReplayManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class HFPBAEOLDPD
		{
			internal bool GEPHINAOBOF;

			internal ReplayManager PDAPIGLEPGC;

			internal void AGFNGEFDHLA()
			{
				PDAPIGLEPGC.ReplayStatus.FCJBBPHFNPJ = ((!GEPHINAOBOF) ? "Replay is Running" : "Replay is Over");
			}
		}

		public ParticleSystem TouchParticle;

		public TextMeshPro ValidateStatus;

		public TextMeshPro ReplayStatus;

		public GameObject ReplayContainer;

		private int IIPLOGILLIA;

		private int LILCDDIFBLM;

		private GamePlayRecord EBHFCNDCJKE;

		private CFOIPDKEFMM OELBDGFEGOI;

		private Coroutine FACAMKMEGEO;

		private Sequence OIGIFINPOGE;

		private const float FHFKFCLBMMF = 2.1f;

		private const float HLCGAJHAHEI = 0.8f;

		public void PlayRecord(GamePlayRecord MBBPBGHKLJM)
		{
			EBHFCNDCJKE = MBBPBGHKLJM;
			OELBDGFEGOI = LevelBuilder.ActiveLevel.JHDMFHDHIFN;
			ReplayContainer.SetActive(true);
			OMLPGELEFBE(false);
			IIGHOCGOAID.GABGKBAKHDP.KNHLPBAIDLO(MBBPBGHKLJM.snapshots);
			OELBDGFEGOI.ELFBOKDHKGG.BIFLJLPOELJ();
			TapListener.Instance.IncreaseBlockRequests();
			FACAMKMEGEO = StartCoroutine(GPJODOCGLMP());
		}

		public void StopReplay()
		{
			if (FACAMKMEGEO != null)
			{
				StopCoroutine(FACAMKMEGEO);
				FACAMKMEGEO = null;
			}
		}

		private IEnumerator GPJODOCGLMP()
		{
			int num = 0;
			IIPLOGILLIA = 0;
			LILCDDIFBLM = 0;
			yield return new WaitForSeconds(1f);
			while (true)
			{
				float num2 = 0f;
				if (PNJCPJHBDEK(num))
				{
					yield return new WaitForSeconds(2.1f);
					while (!CHACINBPAEO())
					{
						yield return new WaitForSeconds(0.1f);
					}
					GJLMFIJAFLN();
					num2 += 2.1f;
				}
				while (GPFKOFMNCAO(num))
				{
					yield return new WaitForSeconds(0.8f);
					while (GPPMBCBGAAL())
					{
						yield return new WaitForSeconds(0.1f);
						num2 += 0.1f;
					}
					MKMJNKIGEGK mCOBEOPCNCG = BGLGMKGAADL();
					JFPJHFFHBDO(mCOBEOPCNCG);
					yield return new WaitForSeconds(mCOBEOPCNCG.JEMNECOACPF);
					num2 += 0.8f + mCOBEOPCNCG.JEMNECOACPF;
				}
				if (num * 2 >= EBHFCNDCJKE.m.Count)
				{
					break;
				}
				float num3 = DAFCCPMJJNF(num, num2);
				if (num3 == 0f)
				{
					while (GPPMBCBGAAL())
					{
						yield return new WaitForSeconds(0.1f);
					}
				}
				else
				{
					yield return new WaitForSeconds(num3);
				}
				int aMFCENFNAJJ = EBHFCNDCJKE.m[num * 2];
				int cNLILOEEBOJ = EBHFCNDCJKE.m[num * 2 + 1];
				Cell cell = OELBDGFEGOI.ECNCPJGHBIG(aMFCENFNAJJ, cNLILOEEBOJ);
				FEFHFGJPJML(num);
				OELBDGFEGOI.ELHPMMGOKMF(cell);
				OKCIHFHIPBH(cell);
				num++;
			}
			yield return MCJHHDACJBG.KNLADMIBAAD;
			while (GPPMBCBGAAL())
			{
				yield return MCJHHDACJBG.CNDGGNLKOOC;
			}
			yield return MCJHHDACJBG.KNLADMIBAAD;
			FEFHFGJPJML(num);
			OMLPGELEFBE(true);
			OKGNHCBGMDM();
		}

		private void OKGNHCBGMDM()
		{
			TapListener.Instance.DecreaseBlockRequests();
			OELBDGFEGOI.ELFBOKDHKGG.GIMHNADJNIK();
			OELBDGFEGOI.ELFBOKDHKGG.ELKFBOBDKMN();
			if (OELBDGFEGOI.ELFBOKDHKGG.NPMIKDPNBIA)
			{
				HintManager.Instance.EnableHints();
			}
			OELBDGFEGOI.ELFBOKDHKGG.NPMIKDPNBIA = false;
			OELBDGFEGOI.ELFBOKDHKGG.ACJOALJFMHN(NOALGNJECAD.None, false);
		}

		private void FEFHFGJPJML(int CCHAAJBNJHL)
		{
			if (!IIGHOCGOAID.GABGKBAKHDP.NPFEFGADBGN(CCHAAJBNJHL))
			{
				FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.QuitDialog, false);
			}
			else if (!IIGHOCGOAID.GABGKBAKHDP.IJIHJNDEEBK(CCHAAJBNJHL))
			{
				OELBDGFEGOI.ELFBOKDHKGG.ELKFBOBDKMN();
				FallManager.SnapshotRecoveredSetups();
				IIGHOCGOAID.GABGKBAKHDP.GIFOFCNGKAI(CCHAAJBNJHL);
				KMIIEPCPAHL();
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Level, "Replay is invalid.");
			}
		}

		private void KMIIEPCPAHL()
		{
			if (OIGIFINPOGE != null)
			{
				OIGIFINPOGE.Kill();
			}
			OIGIFINPOGE = DOTween.Sequence();
			ValidateStatus.color = new Color(1f, 1f, 1f, 0f);
			OIGIFINPOGE.Append(ValidateStatus.DOFade(1f, 0.4f));
			OIGIFINPOGE.Insert(1.5f, ValidateStatus.DOFade(0f, 0.2f));
		}

		private void OMLPGELEFBE(bool GEPHINAOBOF)
		{
			Sequence s = DOTween.Sequence();
			s.Append(ReplayStatus.DOFade(0f, 0.2f));
			s.AppendCallback(delegate
			{
				ReplayStatus.FCJBBPHFNPJ = ((!GEPHINAOBOF) ? "Replay is Running" : "Replay is Over");
			});
			s.Append(ReplayStatus.DOFade(1f, 0.4f));
		}

		private bool CHACINBPAEO()
		{
			EgoDialog egoDialog = Object.FindObjectOfType<EgoDialog>();
			return egoDialog != null && egoDialog.gameObject.activeSelf;
		}

		private bool GPPMBCBGAAL()
		{
			return FallManager.AreFallsBlocked() || FallManager.AreThereFallingItems() || FallManager.AreThereMechanicAnimations();
		}

		private float DAFCCPMJJNF(int CCHAAJBNJHL, float FNHHGGLFNHF)
		{
			if (CCHAAJBNJHL == 0)
			{
				return 0f;
			}
			return Mathf.Max(0f, (float)EBHFCNDCJKE.w[CCHAAJBNJHL - 1] / 100f - FNHHGGLFNHF);
		}

		private void OKCIHFHIPBH(Cell LBHDELJBONF)
		{
			TouchParticle.transform.position = LBHDELJBONF.GetFrozenPosition();
			TouchParticle.Play();
		}

		private bool PNJCPJHBDEK(int CCHAAJBNJHL)
		{
			if (LILCDDIFBLM < EBHFCNDCJKE.e.Count && CCHAAJBNJHL * 2 == EBHFCNDCJKE.e[LILCDDIFBLM])
			{
				LILCDDIFBLM++;
				return true;
			}
			return false;
		}

		private bool GPFKOFMNCAO(int CCHAAJBNJHL)
		{
			if (IIPLOGILLIA < EBHFCNDCJKE.b.Count)
			{
				return CCHAAJBNJHL * 2 == EBHFCNDCJKE.b[IIPLOGILLIA];
			}
			return false;
		}

		private MKMJNKIGEGK BGLGMKGAADL()
		{
			NAAHKHPBAPA mMHIFICGOHO = (NAAHKHPBAPA)EBHFCNDCJKE.b[IIPLOGILLIA + 3];
			Cell fIICENBDLDC = OELBDGFEGOI.ECNCPJGHBIG(EBHFCNDCJKE.b[IIPLOGILLIA + 1], EBHFCNDCJKE.b[IIPLOGILLIA + 2]);
			IIPLOGILLIA += 4;
			return new MKMJNKIGEGK(mMHIFICGOHO, fIICENBDLDC);
		}

		private void GJLMFIJAFLN()
		{
			int nNIDKMJGAJO = Mathf.Min(100 * LILCDDIFBLM, 500);
			GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Coins, nNIDKMJGAJO, false);
			Object.FindObjectOfType<EgoDialog>().OnBuyClicked();
		}

		private void JFPJHFFHBDO(MKMJNKIGEGK MCOBEOPCNCG)
		{
			GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(MCOBEOPCNCG.ACDEFIKEKHG, 1, false);
			switch (MCOBEOPCNCG.ACDEFIKEKHG)
			{
			case NAAHKHPBAPA.Hammer:
				BoosterTapListener.Instance.CurrentBoosterManager.HammerClicked();
				break;
			case NAAHKHPBAPA.Anvil:
				BoosterTapListener.Instance.CurrentBoosterManager.AnvilClicked();
				break;
			case NAAHKHPBAPA.BoxingGlove:
				BoosterTapListener.Instance.CurrentBoosterManager.BoxingGloveClicked();
				break;
			case NAAHKHPBAPA.Dice:
				BoosterTapListener.Instance.CurrentBoosterManager.ShuffleClicked();
				break;
			}
			BoosterTapListener.Instance.CurrentBoosterManager.CellTapped(MCOBEOPCNCG.PODEDNNPOAM);
			OKCIHFHIPBH(MCOBEOPCNCG.PODEDNNPOAM);
		}
	}
}
