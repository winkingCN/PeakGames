using Assets.Scripts.Utils;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene
{
	public class ParticlePlayer : MonoBehaviour
	{
		protected bool HPMFGJODCIK;

		public ParticleSystem MainParticle;

		public bool CreatedFromPool;

		public virtual void Play()
		{
			HPMFGJODCIK = true;
			MainParticle.Play();
		}

		public void SoftStop()
		{
			if (HPMFGJODCIK)
			{
				FCHJOLMHPLA();
			}
		}

		public void HardStop()
		{
			if (HPMFGJODCIK)
			{
				FCHJOLMHPLA();
				CGLBGMAHCDP();
			}
		}

		public virtual void Update()
		{
			if (!SlowCheckTime.ShouldPass() && HPMFGJODCIK)
			{
				FMHDGPAHPML();
			}
		}

		protected virtual void FMHDGPAHPML()
		{
			if (!MainParticle.isPlaying)
			{
				CGLBGMAHCDP();
			}
		}

		protected virtual void CGLBGMAHCDP()
		{
			if (!CreatedFromPool)
			{
				Object.Destroy(base.gameObject);
				return;
			}
			MainParticle.time = 0f;
			HPMFGJODCIK = false;
			base.transform.SetParent(null);
			base.gameObject.MEJPNNFDEBD();
		}

		protected virtual void FCHJOLMHPLA()
		{
			MainParticle.Stop();
		}

		public void PlayWithoutParent()
		{
			MainParticle.transform.SetParent(null);
			Play();
		}
	}
}
