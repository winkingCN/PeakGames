using UnityEngine;

namespace Assets.Scripts.Dialogs
{
	public class StarSlider : MonoBehaviour
	{
		private float GDKCKLHCLMH = 1f;

		private SpriteRenderer JBHDAGLEPGM;

		private float ADGOEBJPKCO;

		private float PCABMABKPPF;

		public bool CanPlay;

		public int Order;

		public void Awake()
		{
			JBHDAGLEPGM = GetComponent<SpriteRenderer>();
		}

		public void SetOrder(int PLCFEOMGCFK)
		{
			Order = PLCFEOMGCFK;
		}

		public void Update()
		{
			if (!CanPlay)
			{
				return;
			}
			if (ADGOEBJPKCO < 1f)
			{
				ADGOEBJPKCO = Time.time;
			}
			if (!(ADGOEBJPKCO + (float)Order / 2f > Time.time) && !(Time.time - PCABMABKPPF < 1f))
			{
				GDKCKLHCLMH -= Time.deltaTime * 3f;
				if (GDKCKLHCLMH < -5f)
				{
					GDKCKLHCLMH = 1f;
					PCABMABKPPF = Time.time;
				}
				if (GDKCKLHCLMH >= -0.1f && GDKCKLHCLMH <= 1f)
				{
					JBHDAGLEPGM.material.SetFloat("_ShineLocation", GDKCKLHCLMH);
				}
			}
		}
	}
}
