using UnityEngine;

namespace Assets.Scripts.GamePlayScene
{
	public class SolidColorParticlePlayer : BurstModifierParticlePlayer
	{
		public ParticleSystem BigPieces;

		public ParticleSystem CubeFragments;

		public ParticleSystem SmokeParticle;

		private Color OKLBACJMMNL = new Color(1f, 0.1764706f, 5f / 51f, 1f);

		private Color EDFEHNDGOGB = new Color(4f / 85f, 0.5921569f, 0.99215686f, 1f);

		private Color BKMBNLDCGKF = new Color(8f / 51f, 78f / 85f, 19f / 85f, 1f);

		private Color EMFENIEOIGJ = new Color(1f, 0.81960785f, 0f, 1f);

		private Color LALJOECGCEB = new Color(0.8745098f, 0.19215687f, 0.81960785f, 1f);

		private Color IAPINEBPDKA = new Color(0.99215686f, 7f / 15f, 0.19215687f, 1f);

		public void EnableSmokeParticle(bool IEGIOBJMGKJ)
		{
			SmokeParticle.gameObject.SetActive(IEGIOBJMGKJ);
		}

		public void SetColor(NOALGNJECAD HBBIFNLDKPO)
		{
			Color color = OKLBACJMMNL;
			switch (HBBIFNLDKPO)
			{
			case NOALGNJECAD.SolidColor1:
				color = EMFENIEOIGJ;
				break;
			case NOALGNJECAD.SolidColor2:
				color = OKLBACJMMNL;
				break;
			case NOALGNJECAD.SolidColor3:
				color = EDFEHNDGOGB;
				break;
			case NOALGNJECAD.SolidColor4:
				color = BKMBNLDCGKF;
				break;
			case NOALGNJECAD.SolidColor5:
				color = LALJOECGCEB;
				break;
			case NOALGNJECAD.SolidColor6:
				color = IAPINEBPDKA;
				break;
			}
			ParticleSystem.MainModule main = MainParticle.main;
			main.startColor = color;
			ParticleSystem.MainModule main2 = CubeFragments.main;
			main2.startColor = color;
			ParticleSystem.MainModule main3 = BigPieces.main;
			main3.startColor = color;
		}
	}
}
