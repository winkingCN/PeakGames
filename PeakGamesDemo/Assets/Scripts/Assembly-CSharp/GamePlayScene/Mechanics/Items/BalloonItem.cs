using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class BalloonItem : SpriteBasedItem
	{
		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Balloon;
		}

		public override int GetScore()
		{
			return 500;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return true;
		}

		public override bool CanCastShadow()
		{
			return true;
		}

		public override void BringToFront()
		{
			CKKKELDIOLD sorting = GetSorting();
			sorting.BHIJCAOHDCM += 120;
			ChangeSorting(sorting);
		}

		public override void SendToBack()
		{
			DEIFPMCEKCO();
		}

		public override void ReactToUpperFall()
		{
			FallListener fallListener = MHILDHNALNO();
			fallListener.EndFall(-1f);
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
				BalloonParticlePlayer balloonParticlePlayer = ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[0], base.transform.position) as BalloonParticlePlayer;
				balloonParticlePlayer.SetColor();
			}
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 63;
		}
	}
}
