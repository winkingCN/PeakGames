using UnityEngine;

namespace GamePlayScene
{
	public class SodaParticlePlayer : MonoBehaviour
	{
		private class NDCLAPDDPHG
		{
			public GameObject IFLICJGCCNM;

			public SpriteRenderer PODNNFICNNO;

			public Vector3 OKBKGLCLGKL;

			public float PCJLEBBNEKL;

			public float NAFLKPJGHHD;

			public float GEBNMKAGJIG;

			public bool AJEGGLPFLEO;
		}

		public GameObject Reference;

		public int Count;

		private const float MJPBNCOHBAE = -0.1f;

		private const float FIGHPMHNEOF = 0.1f;

		private const float KELNODHFIEP = 0.1f;

		private const float MCNAAAIMLPE = 0.6f;

		private const float MCBKFLOBBGN = -0.001f;

		private const float JPCPMHHNLOH = 0.001f;

		private const float OPABPIBHOIF = -0.002f;

		private const float PNDPLGGPFGF = 0.0015f;

		private const float JGOHOEDGAHJ = 0.02f;

		private const float OALFEINHOBD = 0.7f;

		private const float IJPPAOCOBFF = 1f;

		private const float MABJJHCLOBA = 0.01f;

		private const float MDNFJJEMING = 0.2f;

		private const float CKINALAMADA = 0.01f;

		private const float CPBNKPMLONG = 0.0001f;

		private static GameObject ALLIKALCHGA;

		private NDCLAPDDPHG[] LGFBGMDFPGE;

		private Color LNDCLLACBPO;

		private bool GHBCLNBAIEP;

		private bool OCGANFOIPOC;

		private int LHBHJJJHNOF;

		private float HGLGKBHACMK;

		private CKKKELDIOLD KKCPOOALFAD;

		public void Init()
		{
			if (!GHBCLNBAIEP)
			{
				GHBCLNBAIEP = true;
				LGFBGMDFPGE = new NDCLAPDDPHG[Count];
				Reference.FLFDKMOOIFL(100);
				for (int i = 0; i < Count; i++)
				{
					LGFBGMDFPGE[i] = new NDCLAPDDPHG
					{
						OKBKGLCLGKL = Vector3.zero,
						AJEGGLPFLEO = false
					};
				}
			}
		}

		private static Color CKNCBJPKNLD(LEDBLDKJBAI JOCKKMJBJLL)
		{
			switch (JOCKKMJBJLL)
			{
			default:
				return new Color(1f, 1f, 40f / 51f, 1f);
			case LEDBLDKJBAI.Red:
				return new Color(1f, 40f / 51f, 40f / 51f, 1f);
			case LEDBLDKJBAI.Blue:
				return new Color(0.6627451f, 0.827451f, 0.9411765f, 1f);
			case LEDBLDKJBAI.Green:
				return new Color(0.79607844f, 1f, 0.79607844f, 1f);
			case LEDBLDKJBAI.Purple:
				return new Color(1.0705882f, 57f / 85f, 0.8f, 1f);
			}
		}

		public void Shake(LEDBLDKJBAI JOCKKMJBJLL)
		{
			OCGANFOIPOC = true;
			LNDCLLACBPO = CKNCBJPKNLD(JOCKKMJBJLL);
			JIMBAPGACIJ();
		}

		public void UpdateSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			KKCPOOALFAD = IBBBMACIBGK;
		}

		private void JIMBAPGACIJ()
		{
			if (!GHBCLNBAIEP)
			{
				return;
			}
			LHBHJJJHNOF = Count;
			for (int i = 0; i < Count; i++)
			{
				NDCLAPDDPHG nDCLAPDDPHG = LGFBGMDFPGE[i];
				if (nDCLAPDDPHG != null)
				{
					if (nDCLAPDDPHG.IFLICJGCCNM == null)
					{
						nDCLAPDDPHG.IFLICJGCCNM = Reference.JOBDHIPIMAG();
					}
					if (!nDCLAPDDPHG.IFLICJGCCNM.activeSelf)
					{
						nDCLAPDDPHG.IFLICJGCCNM.SetActive(true);
					}
					nDCLAPDDPHG.IFLICJGCCNM.transform.SetParent(base.transform);
					nDCLAPDDPHG.IFLICJGCCNM.transform.localPosition = new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(0.1f, 0.6f), 0f);
					nDCLAPDDPHG.IFLICJGCCNM.transform.localScale = Vector3.one * nDCLAPDDPHG.GEBNMKAGJIG;
					nDCLAPDDPHG.PODNNFICNNO = nDCLAPDDPHG.IFLICJGCCNM.GetComponent<SpriteRenderer>();
					nDCLAPDDPHG.PODNNFICNNO.color = LNDCLLACBPO;
					nDCLAPDDPHG.PODNNFICNNO.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
					nDCLAPDDPHG.PODNNFICNNO.sortingOrder = KKCPOOALFAD.BHIJCAOHDCM;
					nDCLAPDDPHG.OKBKGLCLGKL = new Vector3(Random.Range(-0.001f, 0.001f), Random.Range(-0.002f, 0.0015f), 0f);
					nDCLAPDDPHG.GEBNMKAGJIG = Random.Range(0.01f, 0.2f);
					nDCLAPDDPHG.PCJLEBBNEKL = 0.7f - nDCLAPDDPHG.IFLICJGCCNM.transform.localPosition.y * 1f;
					nDCLAPDDPHG.AJEGGLPFLEO = true;
					nDCLAPDDPHG.NAFLKPJGHHD = Time.realtimeSinceStartup;
				}
			}
		}

		private void GHGAHPOLKME()
		{
			for (int i = 0; i < Count; i++)
			{
				NDCLAPDDPHG nDCLAPDDPHG = LGFBGMDFPGE[i];
				if (nDCLAPDDPHG == null || !nDCLAPDDPHG.AJEGGLPFLEO || nDCLAPDDPHG.IFLICJGCCNM == null)
				{
					continue;
				}
				Vector3 localScale = nDCLAPDDPHG.IFLICJGCCNM.transform.localScale;
				if (localScale.x < nDCLAPDDPHG.GEBNMKAGJIG)
				{
					localScale.x += 0.01f;
					localScale.y += 0.01f;
					nDCLAPDDPHG.IFLICJGCCNM.transform.localScale = localScale;
				}
				float num = Time.realtimeSinceStartup - nDCLAPDDPHG.NAFLKPJGHHD;
				if (num > nDCLAPDDPHG.PCJLEBBNEKL)
				{
					Color color = nDCLAPDDPHG.PODNNFICNNO.color;
					if (color.a > 0f)
					{
						color.a -= 0.02f;
					}
					else
					{
						nDCLAPDDPHG.AJEGGLPFLEO = false;
						JALACGKBBKF(nDCLAPDDPHG);
						LHBHJJJHNOF--;
					}
					if (nDCLAPDDPHG.AJEGGLPFLEO)
					{
						nDCLAPDDPHG.PODNNFICNNO.color = color;
					}
				}
				if (nDCLAPDDPHG.AJEGGLPFLEO)
				{
					nDCLAPDDPHG.OKBKGLCLGKL.y += 0.0001f;
					Vector3 localPosition = nDCLAPDDPHG.IFLICJGCCNM.transform.localPosition + nDCLAPDDPHG.OKBKGLCLGKL;
					nDCLAPDDPHG.IFLICJGCCNM.transform.localPosition = localPosition;
				}
				if (LHBHJJJHNOF == 0)
				{
					OCGANFOIPOC = false;
				}
			}
		}

		public void Update()
		{
			if (GHBCLNBAIEP && OCGANFOIPOC)
			{
				GHGAHPOLKME();
			}
		}

		public void RecycleParticles()
		{
			if (LGFBGMDFPGE == null || LGFBGMDFPGE.Length == 0)
			{
				return;
			}
			for (int i = 0; i < Count; i++)
			{
				NDCLAPDDPHG nDCLAPDDPHG = LGFBGMDFPGE[i];
				if (nDCLAPDDPHG != null && !(nDCLAPDDPHG.IFLICJGCCNM == null))
				{
					JALACGKBBKF(nDCLAPDDPHG);
				}
			}
		}

		private void JALACGKBBKF(NDCLAPDDPHG ELLOILOPDJC)
		{
			ELLOILOPDJC.IFLICJGCCNM.transform.SetParent(base.transform.root);
			ELLOILOPDJC.IFLICJGCCNM.MEJPNNFDEBD();
			ELLOILOPDJC.IFLICJGCCNM = null;
			ELLOILOPDJC.PODNNFICNNO = null;
		}
	}
}
