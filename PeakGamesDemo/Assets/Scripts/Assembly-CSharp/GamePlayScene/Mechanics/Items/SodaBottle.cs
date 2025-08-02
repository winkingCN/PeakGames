using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class SodaBottle : MonoBehaviour
	{
		public Animator CurrentAnimator;

		public SpriteRenderer[] BottleSpriteRenderers;

		public SpriteRenderer BottleSpriteRenderer;

		public SpriteRenderer ShadowSpriteRenderer;

		public SpriteRenderer CapSpriteRenderer;

		public SpriteRenderer TopSpriteRenderer;

		public SodaParticlePlayer CurrentSodaParticlePlayer;

		private bool AKANCHEKDCG;

		private int[] DAJLHJICGJN;

		public void Start()
		{
			PrepareSodaBottleVisuals();
		}

		public void PrepareSodaBottleVisuals()
		{
			DAJLHJICGJN = new int[5]
			{
				Animator.StringToHash("Base Layer.SodaBottleShakeAnimation1"),
				Animator.StringToHash("Base Layer.SodaBottleShakeAnimation2"),
				Animator.StringToHash("Base Layer.SodaBottleShakeAnimation3"),
				Animator.StringToHash("Base Layer.SodaBottleShakeAnimation4"),
				Animator.StringToHash("Base Layer.SodaBottleShakeAnimation5")
			};
			CurrentSodaParticlePlayer.Init();
		}

		public void PlayShakeAnimation(LEDBLDKJBAI JOCKKMJBJLL)
		{
			if (!AKANCHEKDCG)
			{
				int stateNameHash = DAJLHJICGJN[Random.Range(0, DAJLHJICGJN.Length)];
				CurrentAnimator.Play(stateNameHash, 0, 0f);
				CurrentSodaParticlePlayer.Shake(JOCKKMJBJLL);
			}
		}

		public void ChangeSorting(CKKKELDIOLD KHFBHDLBLJH, int CMAJLIAELDP)
		{
			ShadowSpriteRenderer.sortingLayerID = KHFBHDLBLJH.MMFFDANAEEI;
			ShadowSpriteRenderer.sortingOrder = KHFBHDLBLJH.BHIJCAOHDCM + 1;
			int num = KHFBHDLBLJH.BHIJCAOHDCM + CMAJLIAELDP + 1;
			int num2 = BottleSpriteRenderers.Length;
			for (int i = 0; i < num2; i++)
			{
				SpriteRenderer spriteRenderer = BottleSpriteRenderers[i];
				if (!(spriteRenderer == null))
				{
					spriteRenderer.sortingLayerID = KHFBHDLBLJH.MMFFDANAEEI;
					spriteRenderer.sortingOrder = num + i;
				}
			}
			CurrentSodaParticlePlayer.UpdateSorting(new CKKKELDIOLD(KHFBHDLBLJH.MMFFDANAEEI, num + num2));
		}

		public void Remove()
		{
			AKANCHEKDCG = true;
			CurrentAnimator.StopPlayback();
			CurrentSodaParticlePlayer.RecycleParticles();
			Object.Destroy(base.gameObject);
		}
	}
}
