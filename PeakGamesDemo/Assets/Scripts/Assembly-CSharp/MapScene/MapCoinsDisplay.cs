using System.Runtime.CompilerServices;
using Assets.Scripts.Utils;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace MapScene
{
	public class MapCoinsDisplay : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class EEDKHNKMDBA
		{
			internal ParticleSystem FLLHHHDFCKA;

			internal void AGFNGEFDHLA()
			{
				if (!(FLLHHHDFCKA == null))
				{
					FLLHHHDFCKA.Stop();
					FLLHHHDFCKA.gameObject.MEJPNNFDEBD();
				}
			}
		}

		public SpriteRenderer Glow;

		public GameObject CoinCollectParticle;

		public Transform CoinTransform;

		private bool MCPHPIPBFJO;

		private bool NECJPADHPID;

		private float GDDLNCLDOBL;

		private Sequence KKMDOBOKABL;

		private int KIHPFKLBAHH;

		public TextMeshPro CoinText;

		private int OILKIKEJFGB = -1;

		public void PlayHitAnimation(int LGKKCNCBOLL, bool OFGLDGCLDDG)
		{
			NECJPADHPID = !OFGLDGCLDDG;
			if (!GEBAAFFGKJG.GABGKBAKHDP.IBFMAELGBGP(LGKKCNCBOLL * -1))
			{
				if (GDDLNCLDOBL <= 0f)
				{
					GDDLNCLDOBL = Time.time + 0.5f;
				}
				MCPHPIPBFJO = true;
			}
			int frameCount = Time.frameCount;
			if (frameCount - KIHPFKLBAHH < 2)
			{
				return;
			}
			KIHPFKLBAHH = frameCount;
			Glow.enabled = true;
			Glow.color = new Color(1f, 1f, 1f, 0f);
			base.gameObject.transform.localScale = Vector3.one;
			KKMDOBOKABL.Kill();
			KKMDOBOKABL = DOTween.Sequence();
			KKMDOBOKABL.SetRecyclable(false);
			KKMDOBOKABL.Insert(0f, base.gameObject.transform.DOScale(Vector3.one * 0.9f, 0.1f));
			KKMDOBOKABL.Insert(0.1f, base.gameObject.transform.DOScale(Vector3.one, 0.1f));
			KKMDOBOKABL.Insert(0f, Glow.DOColor(new Color(1f, 1f, 1f, 0.3f), 0.1f));
			KKMDOBOKABL.Insert(0.1f, Glow.DOColor(new Color(1f, 1f, 1f, 0f), 0.2f));
			ParticleSystem FLLHHHDFCKA = CoinCollectParticle.JOBDHIPIMAG().GetComponent<ParticleSystem>();
			if (!(FLLHHHDFCKA != null))
			{
				return;
			}
			FLLHHHDFCKA.transform.position = CoinTransform.position;
			FLLHHHDFCKA.Play();
			Sequence sequence = DOTween.Sequence();
			sequence.SetRecyclable(false);
			sequence.AppendInterval(1f);
			sequence.OnComplete(delegate
			{
				if (!(FLLHHHDFCKA == null))
				{
					FLLHHHDFCKA.Stop();
					FLLHHHDFCKA.gameObject.MEJPNNFDEBD();
				}
			});
		}

		public void Update()
		{
			if (!SlowCheckTime.ShouldPass())
			{
				if (MCPHPIPBFJO && !NECJPADHPID && GDDLNCLDOBL < Time.time)
				{
					MCPHPIPBFJO = false;
					GDDLNCLDOBL = 0f;
				}
				Refresh();
			}
		}

		public void Start()
		{
			CoinCollectParticle.FLFDKMOOIFL(5);
			CoinText.DGLOHLPKABM = 6f;
			Refresh();
		}

		public void Refresh()
		{
			int num = GEBAAFFGKJG.GABGKBAKHDP.JBGLJOJEBNM - GEBAAFFGKJG.GABGKBAKHDP.AGIIAKOKGDB;
			if (MCPHPIPBFJO)
			{
				CoinText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Full");
			}
			else if (num != OILKIKEJFGB)
			{
				CoinText.FCJBBPHFNPJ = num.ToString();
			}
		}
	}
}
