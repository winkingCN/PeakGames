using UnityEngine;

namespace Assets.Scripts.GamePlayScene
{
	public class DiscoRayParticlePlayer : ParticlePlayer
	{
		public static readonly Color Purple = new Color(0.7647059f, 0.16078432f, 71f / 85f, 1f);

		public static readonly Color Red = new Color(1f, 0.23529412f, 0.23529412f, 1f);

		public static readonly Color Yellow = new Color(71f / 85f, 0.7490196f, 0.16078432f, 1f);

		public static readonly Color Green = new Color(16f / 85f, 0.7058824f, 11f / 85f, 1f);

		public static readonly Color Blue = new Color(0.16078432f, 0.3529412f, 71f / 85f, 1f);

		public static readonly Color Orange = new Color(71f / 85f, 22f / 51f, 0.16078432f, 1f);

		public ParticleSystem DiscoRayColorGlow;

		public Transform RotateTransform;

		public float RotationSpeed;

		public override void Update()
		{
			base.Update();
			RotateTransform.Rotate(0f, 0f, 5f * RotationSpeed * Time.deltaTime);
		}

		public static Color GetDiscoParticleColor(LEDBLDKJBAI CEKMAJAHNAG)
		{
			return new Color(1f, 1f, 1f, 0.6f);
		}

		public void SetColor(LEDBLDKJBAI CEKMAJAHNAG)
		{
			ParticleSystem.MainModule main = DiscoRayColorGlow.main;
			main.startColor = GetDiscoParticleColor(CEKMAJAHNAG);
		}

		public override void Play()
		{
			base.Play();
			DiscoRayColorGlow.Play();
		}

		public void PlayGlowOnly()
		{
			HPMFGJODCIK = true;
			DiscoRayColorGlow.Play();
		}

		protected override void FMHDGPAHPML()
		{
			if (!MainParticle.isPlaying && !DiscoRayColorGlow.isPlaying)
			{
				CGLBGMAHCDP();
			}
		}

		protected override void FCHJOLMHPLA()
		{
			MainParticle.Stop();
			DiscoRayColorGlow.Stop();
		}

		protected override void CGLBGMAHCDP()
		{
			MainParticle.Stop();
			DiscoRayColorGlow.Stop();
			base.CGLBGMAHCDP();
		}
	}
}
