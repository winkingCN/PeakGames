using UnityEngine;

namespace GamePlayScene
{
	public class SnowParticlePlayer : MonoBehaviour
	{
		private class DKOKDCPDLJI
		{
			public SpriteRenderer IFLICJGCCNM;

			public Vector3 OKBKGLCLGKL;

			public float OKHNNKPLHAL;

			public float PFNNFPIDHFN;

			public float DHNPLAMABAA;

			public bool AJEGGLPFLEO;
		}

		private const float PENHGMMIMKI = -0.12f;

		private const float BGPEFDMHCCI = 1.5f;

		private const float KOBOAJEBMJB = 0.001f;

		private const float FBOLDOEBCMB = 0.015f;

		public GameObject Reference;

		public int Count;

		public float Radius;

		public float InnerRadius;

		private DKOKDCPDLJI[] LGFBGMDFPGE;

		private bool GHBCLNBAIEP;

		private float HGLGKBHACMK;

		public void Init()
		{
			if (!GHBCLNBAIEP)
			{
				GHBCLNBAIEP = true;
				HGLGKBHACMK = Radius * Radius;
				LGFBGMDFPGE = new DKOKDCPDLJI[Count];
				for (int i = 0; i < Count; i++)
				{
					GameObject gameObject = Object.Instantiate(Reference);
					LGFBGMDFPGE[i] = new DKOKDCPDLJI
					{
						IFLICJGCCNM = gameObject.GetComponent<SpriteRenderer>(),
						OKBKGLCLGKL = Vector3.zero,
						OKHNNKPLHAL = 1f,
						PFNNFPIDHFN = Random.Range(1, 100),
						DHNPLAMABAA = 1f,
						AJEGGLPFLEO = false
					};
				}
				Reset();
			}
		}

		public void Shake()
		{
			Reset();
			GHGAHPOLKME();
		}

		public void UpdateSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			if (!GHBCLNBAIEP)
			{
				return;
			}
			for (int i = 0; i < Count; i++)
			{
				DKOKDCPDLJI dKOKDCPDLJI = LGFBGMDFPGE[i];
				if (dKOKDCPDLJI != null)
				{
					dKOKDCPDLJI.IFLICJGCCNM.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
					dKOKDCPDLJI.IFLICJGCCNM.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM;
				}
			}
		}

		private void Reset()
		{
			if (!GHBCLNBAIEP)
			{
				return;
			}
			for (int i = 0; i < Count; i++)
			{
				DKOKDCPDLJI dKOKDCPDLJI = LGFBGMDFPGE[i];
				if (dKOKDCPDLJI != null)
				{
					if (!dKOKDCPDLJI.IFLICJGCCNM.gameObject.activeSelf)
					{
						dKOKDCPDLJI.IFLICJGCCNM.gameObject.SetActive(true);
					}
					dKOKDCPDLJI.OKBKGLCLGKL = new Vector3(0f, Random.Range(0.1f, 2.5f), 0f);
					dKOKDCPDLJI.OKHNNKPLHAL = Random.Range(0.001f, 0.015f);
					dKOKDCPDLJI.IFLICJGCCNM.transform.SetParent(base.transform);
					dKOKDCPDLJI.IFLICJGCCNM.transform.localPosition = new Vector3(Random.Range(0f - Radius, Radius), Random.Range(-0.4f, 0.2f), 0f);
					dKOKDCPDLJI.IFLICJGCCNM.color = new Color(1f, 1f, 1f, 1f);
					dKOKDCPDLJI.DHNPLAMABAA = (float)Random.Range(1, 100) * 0.001f;
					dKOKDCPDLJI.AJEGGLPFLEO = true;
					dKOKDCPDLJI.IFLICJGCCNM.transform.localScale = Vector3.one * Random.Range(0.1f, 0.4f);
				}
			}
		}

		private void GHGAHPOLKME()
		{
			for (int i = 0; i < Count; i++)
			{
				DKOKDCPDLJI dKOKDCPDLJI = LGFBGMDFPGE[i];
				if (dKOKDCPDLJI == null || !dKOKDCPDLJI.AJEGGLPFLEO)
				{
					continue;
				}
				dKOKDCPDLJI.OKBKGLCLGKL.y += -0.12f;
				dKOKDCPDLJI.PFNNFPIDHFN += dKOKDCPDLJI.DHNPLAMABAA;
				Vector3 localPosition = dKOKDCPDLJI.IFLICJGCCNM.transform.localPosition + dKOKDCPDLJI.OKBKGLCLGKL * 0.001f * 1.5f;
				localPosition.x += Mathf.Sin(dKOKDCPDLJI.PFNNFPIDHFN) * dKOKDCPDLJI.OKHNNKPLHAL;
				dKOKDCPDLJI.IFLICJGCCNM.transform.localPosition = localPosition;
				float x = localPosition.x;
				float y = localPosition.y;
				float num = x * x + y * y;
				bool activeSelf = dKOKDCPDLJI.IFLICJGCCNM.gameObject.activeSelf;
				if (num > HGLGKBHACMK - InnerRadius)
				{
					if (activeSelf)
					{
						dKOKDCPDLJI.IFLICJGCCNM.gameObject.SetActive(false);
					}
					if (y < -0.4f)
					{
						dKOKDCPDLJI.AJEGGLPFLEO = false;
					}
				}
				else if (!activeSelf)
				{
					dKOKDCPDLJI.IFLICJGCCNM.gameObject.SetActive(true);
				}
			}
		}

		public void Update()
		{
			if (GHBCLNBAIEP)
			{
				GHGAHPOLKME();
			}
		}
	}
}
