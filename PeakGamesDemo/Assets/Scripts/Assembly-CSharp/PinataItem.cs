using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using GamePlayScene.Mechanics;

public class PinataItem : SpriteBasedItem
{
	public override NOALGNJECAD GetItemType()
	{
		return NOALGNJECAD.Pinata;
	}

	public override int GetScore()
	{
		return 1000;
	}

	public override bool CanCastShadow()
	{
		return true;
	}

	public override void PlayExplodeAudio()
	{
		if (ItemResourcesManager.GABGKBAKHDP != null)
		{
			AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[0]);
		}
	}

	protected override void EJCFANPAMMK()
	{
		if (ParticlePool.Instance != null && ItemResourcesManager.GABGKBAKHDP != null)
		{
			ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[0], base.transform.position);
		}
	}

	public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
	{
		PNINCDLIDLL.EEFMIHDPJPG = 62;
	}
}
