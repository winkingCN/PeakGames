using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class ColoredBalloonItem : SpriteBasedItem
	{
		private LEDBLDKJBAI DPMFLCCMHLM;

		private IIKJJFHPHOL HCEHJCHHNFE;

		public void SetupItem(IIKJJFHPHOL NBFBPNNEKMN)
		{
			HCEHJCHHNFE = NBFBPNNEKMN;
			switch (HCEHJCHHNFE)
			{
			case IIKJJFHPHOL.Balloon1:
				DPMFLCCMHLM = LEDBLDKJBAI.Yellow;
				break;
			case IIKJJFHPHOL.Balloon2:
				DPMFLCCMHLM = LEDBLDKJBAI.Red;
				break;
			case IIKJJFHPHOL.Balloon3:
				DPMFLCCMHLM = LEDBLDKJBAI.Blue;
				break;
			case IIKJJFHPHOL.Balloon4:
				DPMFLCCMHLM = LEDBLDKJBAI.Green;
				break;
			case IIKJJFHPHOL.Balloon5:
				DPMFLCCMHLM = LEDBLDKJBAI.Purple;
				break;
			default:
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.ColoredBalloonItem, "Cannot Initialize Colored Balloon item with type: " + NBFBPNNEKMN);
				break;
			}
			CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.ColoredBalloonSprites[(int)(HCEHJCHHNFE - 1)];
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.ColoredBalloon;
		}

		public override int GetScore()
		{
			return 500;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return KOINNGEBMJI == DPMFLCCMHLM;
		}

		public override void ReactToUpperFall()
		{
			FallListener fallListener = MHILDHNALNO();
			fallListener.EndFall(-1f);
		}

		public override bool CanBeTapped()
		{
			return false;
		}

		public override bool CanCastShadow()
		{
			return true;
		}

		public override void PlayExplodeAudio()
		{
			if (!(ItemResourcesManager.GABGKBAKHDP == null))
			{
				ItemResources.AudioProps[] audioClips = BBKCPPOFENL.AudioClips;
				AudioManager.PlayAudioProps(audioClips[Random.Range(0, audioClips.Length)]);
			}
		}

		protected override void EJCFANPAMMK()
		{
			if (!(ParticlePool.Instance == null))
			{
				ColoredBalloonParticlePlayer coloredBalloonParticlePlayer = ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[0], base.transform.position) as ColoredBalloonParticlePlayer;
				coloredBalloonParticlePlayer.SetColor(DPMFLCCMHLM);
			}
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = (short)(104 + DPMFLCCMHLM);
		}
	}
}
