using System.Collections.Generic;
using UnityEngine;

namespace GamePlayScene
{
	public class TubeBottlePathParticlePlayer : MonoBehaviour
	{
		private class AKJJNGPECFI
		{
			public GameObject IFLICJGCCNM;

			public SpriteRenderer PODNNFICNNO;

			public float LJLBPNDBOAI;

			public bool NDODOKFECKE;
		}

		public GameObject Reference;

		public SpriteRenderer FrontSprite;

		public ParticleSystem LeftBottleSmokeParticle;

		public ParticleSystem RightBottleSmokeParticle;

		public float StartScale = 0.4f;

		public float SpeedFactor = 8f;

		public float TraceFadeTime = 0.5f;

		private int GMFKFCNPDKF = 100;

		private float MCCLEGFCIMC = 0.005f;

		private Vector3[] LMFJDLDEIME;

		private static Vector3[] GCNMPOLBMCC = new Vector3[11]
		{
			new Vector3(0.871f, 1.315f, 0f),
			new Vector3(0.8709999f, 1.909f, 0f),
			new Vector3(0.8709999f, 1.97f, 0f),
			new Vector3(0.836f, 2.034f, 0f),
			new Vector3(0.784f, 2.077f, 0f),
			new Vector3(0.713f, 2.093f, 0f),
			new Vector3(0.147f, 2.093f, 0f),
			new Vector3(0.083f, 2.064f, 0f),
			new Vector3(0.028f, 1.997f, 0f),
			new Vector3(0.015f, 1.941f, 0f),
			new Vector3(0.01500002f, 0.492f, 0f)
		};

		private static float EAMKGMFJJNA = 0.5f;

		private AKJJNGPECFI[] NHILDGHKDKC;

		private float[] IDLAPIMMPIM;

		private float[] HPPFODCPEAM;

		private Color LDOMFINKBOB;

		private Color JKEFFADPLFM;

		private Color IFAGOEOHCDK;

		private float HFOEIPPEGLK;

		private float LGMNKIGIFEE;

		private bool GHBCLNBAIEP;

		private bool JBDHMJNHLEL;

		private bool OCGANFOIPOC;

		private bool PEGHFJOEIAE;

		private float PCABMABKPPF;

		private int MBMCEGPGCCF;

		private Vector3 LLILHFINJDO;

		private Vector3 NIGGHKAMOGJ;

		private int BNADBGHCPMC;

		private float PPDFCJKFMIL;

		private readonly List<AKJJNGPECFI> FGFOMPPPAJJ = new List<AKJJNGPECFI>();

		private static Color CKNCBJPKNLD(LEDBLDKJBAI JOCKKMJBJLL)
		{
			switch (JOCKKMJBJLL)
			{
			default:
				return new Color(1f, 0.85f, 0.1f, EAMKGMFJJNA);
			case LEDBLDKJBAI.Red:
				return new Color(1f, 0.18f, 0.18f, EAMKGMFJJNA);
			case LEDBLDKJBAI.Blue:
				return new Color(0f, 0.65f, 1f, EAMKGMFJJNA);
			case LEDBLDKJBAI.Green:
				return new Color(0.17f, 0.8f, 0.17f, EAMKGMFJJNA);
			case LEDBLDKJBAI.Purple:
				return new Color(0.76f, 0.2f, 1f, EAMKGMFJJNA);
			}
		}

		public void Init()
		{
			if (!GHBCLNBAIEP)
			{
				GMFKFCNPDKF = 100;
				EAMKGMFJJNA = 0.5f;
				MCCLEGFCIMC = 0.005f;
				GHBCLNBAIEP = true;
				NHILDGHKDKC = new AKJJNGPECFI[GMFKFCNPDKF];
				for (int i = 0; i < GMFKFCNPDKF; i++)
				{
					GameObject gameObject = Object.Instantiate(Reference, base.transform);
					gameObject.transform.SetParent(base.transform);
					NHILDGHKDKC[i] = new AKJJNGPECFI
					{
						IFLICJGCCNM = gameObject,
						PODNNFICNNO = gameObject.GetComponent<SpriteRenderer>()
					};
					NHILDGHKDKC[i].PODNNFICNNO.enabled = false;
				}
				IDLAPIMMPIM = new float[GCNMPOLBMCC.Length - 1];
				HPPFODCPEAM = new float[GCNMPOLBMCC.Length - 1];
				for (int j = 0; j < IDLAPIMMPIM.Length; j++)
				{
					Vector3 vector = GCNMPOLBMCC[j + 1];
					Vector3 vector2 = GCNMPOLBMCC[j];
					IDLAPIMMPIM[j] = (HPPFODCPEAM[IDLAPIMMPIM.Length - 1 - j] = Vector3.Magnitude(vector - vector2));
				}
				LMFJDLDEIME = new Vector3[GCNMPOLBMCC.Length];
				for (int k = 0; k < GCNMPOLBMCC.Length; k++)
				{
					LMFJDLDEIME[k] = GCNMPOLBMCC[GCNMPOLBMCC.Length - 1 - k];
				}
			}
		}

		public void PlayParticle(LEDBLDKJBAI JOCKKMJBJLL)
		{
			if (OCGANFOIPOC || FGFOMPPPAJJ.Count > 0)
			{
				JBDHMJNHLEL = true;
				HFOEIPPEGLK = 0f;
				LDOMFINKBOB = IFAGOEOHCDK;
				JKEFFADPLFM = CKNCBJPKNLD(JOCKKMJBJLL);
				return;
			}
			PEGHFJOEIAE = !PEGHFJOEIAE;
			PCABMABKPPF = 0f;
			IFAGOEOHCDK = (LDOMFINKBOB = (JKEFFADPLFM = CKNCBJPKNLD(JOCKKMJBJLL)));
			BNADBGHCPMC = -1;
			OCGANFOIPOC = true;
			LGMNKIGIFEE = 0f;
			JBDHMJNHLEL = false;
			PFFOMNCFLKF();
			FKBJACPAFOA();
		}

		public void Update()
		{
			if (!GHBCLNBAIEP)
			{
				return;
			}
			if (PCABMABKPPF > 0f)
			{
				PCABMABKPPF -= Time.deltaTime;
				return;
			}
			if (OCGANFOIPOC)
			{
				float num;
				for (num = LGMNKIGIFEE; num < Time.deltaTime; num += MCCLEGFCIMC)
				{
					if (!GHGAHPOLKME(MCCLEGFCIMC, Time.deltaTime - num))
					{
						CCFJHMFOKNA();
						break;
					}
				}
				LGMNKIGIFEE = num - Time.deltaTime;
			}
			bool eGNCPICKKNP = false;
			if (JBDHMJNHLEL)
			{
				APFNMNGAGGL(Time.deltaTime);
				eGNCPICKKNP = true;
			}
			if (FGFOMPPPAJJ.Count > 0)
			{
				FJKHOINKBPO(Time.deltaTime, eGNCPICKKNP);
			}
		}

		private void APFNMNGAGGL(float CFENOBBDOHG)
		{
			HFOEIPPEGLK += CFENOBBDOHG;
			float num = HFOEIPPEGLK / 0.5f;
			if (num >= 1f)
			{
				JBDHMJNHLEL = false;
				IFAGOEOHCDK = JKEFFADPLFM;
			}
			else
			{
				IFAGOEOHCDK = Color.Lerp(LDOMFINKBOB, JKEFFADPLFM, num);
			}
		}

		private void FJKHOINKBPO(float CFENOBBDOHG, bool EGNCPICKKNP)
		{
			for (int num = FGFOMPPPAJJ.Count - 1; num >= 0; num--)
			{
				AKJJNGPECFI aKJJNGPECFI = FGFOMPPPAJJ[num];
				aKJJNGPECFI.LJLBPNDBOAI += CFENOBBDOHG;
				float num2 = aKJJNGPECFI.LJLBPNDBOAI / TraceFadeTime;
				if (num2 > 1f)
				{
					aKJJNGPECFI.PODNNFICNNO.enabled = false;
					aKJJNGPECFI.NDODOKFECKE = false;
					FGFOMPPPAJJ.RemoveAt(num);
				}
				else if (EGNCPICKKNP)
				{
					aKJJNGPECFI.PODNNFICNNO.color = IFAGOEOHCDK;
				}
			}
		}

		private AKJJNGPECFI MDGFPAAOGOB()
		{
			AKJJNGPECFI aKJJNGPECFI = CCIJDKPNPCE();
			if (aKJJNGPECFI.NDODOKFECKE)
			{
				FGFOMPPPAJJ.Remove(aKJJNGPECFI);
				aKJJNGPECFI.NDODOKFECKE = false;
			}
			aKJJNGPECFI.LJLBPNDBOAI = 0f;
			aKJJNGPECFI.PODNNFICNNO.enabled = true;
			aKJJNGPECFI.PODNNFICNNO.color = LDOMFINKBOB;
			aKJJNGPECFI.IFLICJGCCNM.transform.localPosition = new Vector3(0f, 0f);
			aKJJNGPECFI.IFLICJGCCNM.transform.localScale = Vector3.one * StartScale;
			return aKJJNGPECFI;
		}

		private bool PFFOMNCFLKF(float AFCOFDANFAG = 0f)
		{
			Vector3[] array = ((!PEGHFJOEIAE) ? GCNMPOLBMCC : LMFJDLDEIME);
			BNADBGHCPMC++;
			LLILHFINJDO = array[BNADBGHCPMC];
			if (BNADBGHCPMC == array.Length - 1)
			{
				return false;
			}
			NIGGHKAMOGJ = array[BNADBGHCPMC + 1];
			PPDFCJKFMIL = AFCOFDANFAG;
			return true;
		}

		private AKJJNGPECFI CCIJDKPNPCE()
		{
			AKJJNGPECFI result = NHILDGHKDKC[MBMCEGPGCCF];
			MBMCEGPGCCF = (MBMCEGPGCCF + 1) % NHILDGHKDKC.Length;
			return result;
		}

		private bool GHGAHPOLKME(float HFLODNLEGFL, float KIKFIGOALHM)
		{
			float[] array = ((!PEGHFJOEIAE) ? IDLAPIMMPIM : HPPFODCPEAM);
			PPDFCJKFMIL += SpeedFactor * HFLODNLEGFL;
			if (PPDFCJKFMIL > array[BNADBGHCPMC])
			{
				float aFCOFDANFAG = PPDFCJKFMIL - array[BNADBGHCPMC];
				OCGANFOIPOC = PFFOMNCFLKF(aFCOFDANFAG);
				if (!OCGANFOIPOC)
				{
					return false;
				}
			}
			float t = PPDFCJKFMIL / array[BNADBGHCPMC];
			Vector3 localPosition = Vector3.Lerp(LLILHFINJDO, NIGGHKAMOGJ, t);
			AKJJNGPECFI aKJJNGPECFI = MDGFPAAOGOB();
			aKJJNGPECFI.IFLICJGCCNM.transform.localPosition = localPosition;
			aKJJNGPECFI.LJLBPNDBOAI = KIKFIGOALHM;
			aKJJNGPECFI.NDODOKFECKE = true;
			FGFOMPPPAJJ.Add(aKJJNGPECFI);
			return true;
		}

		public void UpdateSorting()
		{
			CKKKELDIOLD cKKKELDIOLD = new CKKKELDIOLD(FrontSprite.sortingLayerID, FrontSprite.sortingOrder + 1);
			for (int i = 0; i < GMFKFCNPDKF; i++)
			{
				NHILDGHKDKC[i].PODNNFICNNO.sortingLayerID = cKKKELDIOLD.MMFFDANAEEI;
				NHILDGHKDKC[i].PODNNFICNNO.sortingOrder = cKKKELDIOLD.BHIJCAOHDCM;
			}
		}

		private void FKBJACPAFOA()
		{
			if (PEGHFJOEIAE)
			{
				if (LeftBottleSmokeParticle != null)
				{
					LeftBottleSmokeParticle.Play();
				}
			}
			else if (RightBottleSmokeParticle != null)
			{
				RightBottleSmokeParticle.Play();
			}
		}

		private void CCFJHMFOKNA()
		{
			if (PEGHFJOEIAE)
			{
				if (RightBottleSmokeParticle != null)
				{
					RightBottleSmokeParticle.Play();
				}
			}
			else if (LeftBottleSmokeParticle != null)
			{
				LeftBottleSmokeParticle.Play();
			}
		}
	}
}
