using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.Utils;
using DG.Tweening;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class TubeBottle : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class HHKAEGAPCJP
		{
			internal Color FJOJCEIMONG;

			internal TubeBottle PDAPIGLEPGC;

			internal void AGFNGEFDHLA()
			{
				PDAPIGLEPGC.ColorSpriteRenderer.sprite = PDAPIGLEPGC.ColorNextSpriteRenderer.sprite;
				PDAPIGLEPGC.ColorSpriteRenderer.color = PDAPIGLEPGC.CKKDNEBOMOG;
				PDAPIGLEPGC.ColorNextSpriteRenderer.color = PDAPIGLEPGC.BOKCDBLEPHF;
				PDAPIGLEPGC.SurfaceSpriteRenderer.color = FJOJCEIMONG;
				PDAPIGLEPGC.DFOKFEEAGPK = false;
			}
		}

		public bool ShouldPlaySmokeParticle;

		public SpriteRenderer ColorSpriteRenderer;

		public SpriteRenderer ColorTempSpriteRenderer;

		public SpriteRenderer ColorNextSpriteRenderer;

		public SpriteRenderer SurfaceSpriteRenderer;

		public TubeSmokeParticlePlayer TubeSmokeParticlePlayer;

		public TubeBubbleParticlePlayer TubeBubbleParticlePlayer;

		public TubeBottlePathParticlePlayer CurrentTubeBottlePathParticlePlayer;

		private ItemResources EDPGDJINIOJ;

		private LEDBLDKJBAI DPMFLCCMHLM;

		private int LAKFNLLJLOP;

		private readonly Color BOKCDBLEPHF = new Color(1f, 1f, 1f, 0f);

		private readonly Color CKKDNEBOMOG = new Color(1f, 1f, 1f, 1f);

		private static readonly Color[] PHNKMPAOMMO = new Color[6]
		{
			new Color(0.99607843f, 82f / 85f, 0.7647059f, 0.6f),
			new Color(84f / 85f, 0.6431373f, 0.6f, 40f / 51f),
			new Color(2f / 3f, 0.8980392f, 0.99215686f, 0.6f),
			new Color(44f / 51f, 0.99215686f, 62f / 85f, 0.6f),
			new Color(0.8980392f, 0.69803923f, 84f / 85f, 0.6f),
			new Color(0.99215686f, 0.8235294f, 0.6039216f, 0.6f)
		};

		private int LFJGHGGHEHP;

		private int LFCHJCKMMIH;

		private bool DFOKFEEAGPK;

		private int GGJMLGMKPCG = 4;

		private Sequence EFOLJPGECEG;

		public void Init(int ONLEJMMJMGK, int NNFOEMNONFK, ItemResources JEDAGPJEOAM)
		{
			EDPGDJINIOJ = JEDAGPJEOAM;
			LFJGHGGHEHP = ONLEJMMJMGK;
			if (MCJHHDACJBG.MCPELNPBPIF)
			{
				GGJMLGMKPCG--;
			}
			if (NNFOEMNONFK > 4)
			{
				GGJMLGMKPCG--;
			}
			if (TubeSmokeParticlePlayer != null)
			{
				TubeSmokeParticlePlayer.SetQuality(GGJMLGMKPCG);
			}
			if (TubeBubbleParticlePlayer != null)
			{
				LAKFNLLJLOP = TubeBubbleParticlePlayer.BubbleParticleRenderer.sortingOrder;
				TubeBubbleParticlePlayer.SetQuality(GGJMLGMKPCG);
			}
			if (CurrentTubeBottlePathParticlePlayer != null)
			{
				CurrentTubeBottlePathParticlePlayer.Init();
			}
		}

		public void Explode()
		{
			AudioManager.PlayAudioProps(EDPGDJINIOJ.AudioClips[LFJGHGGHEHP + 3]);
			PotionParticlePlayer component = ParticlePool.Instance.PlayParticle(EDPGDJINIOJ.Particles[LFJGHGGHEHP], base.transform.position).GetComponent<PotionParticlePlayer>();
			component.SetColor(DPMFLCCMHLM);
			base.gameObject.SetActive(false);
		}

		public void UpdateSorting(int GDDGFAKOCIL)
		{
			if (TubeBubbleParticlePlayer != null)
			{
				TubeBubbleParticlePlayer.BubbleParticleRenderer.sortingOrder = LAKFNLLJLOP + GDDGFAKOCIL;
			}
			if (TubeSmokeParticlePlayer != null)
			{
				TubeSmokeParticlePlayer.SmokeParticleRenderer.sortingOrder = LAKFNLLJLOP + GDDGFAKOCIL;
			}
			if (CurrentTubeBottlePathParticlePlayer != null)
			{
				CurrentTubeBottlePathParticlePlayer.UpdateSorting();
			}
		}

		public void PlayParticle()
		{
			if (TubeBubbleParticlePlayer != null)
			{
				TubeBubbleParticlePlayer.SetColor(DPMFLCCMHLM);
				TubeBubbleParticlePlayer.BubbleParticle.Play();
			}
			if (TubeSmokeParticlePlayer != null)
			{
				TubeSmokeParticlePlayer.SetColor(DPMFLCCMHLM);
				if (ShouldPlaySmokeParticle)
				{
					TubeSmokeParticlePlayer.SmokeParticle.Play();
				}
			}
			if (CurrentTubeBottlePathParticlePlayer != null)
			{
				CurrentTubeBottlePathParticlePlayer.PlayParticle(DPMFLCCMHLM);
			}
		}

		public int TransformToColorByMatchType(LEDBLDKJBAI JOCKKMJBJLL, bool KCJGMJPPBCE = true)
		{
			DPMFLCCMHLM = JOCKKMJBJLL;
			int num;
			switch (JOCKKMJBJLL)
			{
			case LEDBLDKJBAI.Yellow:
				num = 0;
				break;
			case LEDBLDKJBAI.Red:
				num = 1;
				break;
			case LEDBLDKJBAI.Blue:
				num = 2;
				break;
			case LEDBLDKJBAI.Green:
				num = 3;
				break;
			case LEDBLDKJBAI.Purple:
				num = 4;
				break;
			default:
				num = -1;
				break;
			}
			if (num == -1)
			{
				ColorSpriteRenderer.sprite = null;
				return num;
			}
			if (KCJGMJPPBCE)
			{
				ColorSpriteRenderer.sprite = EDPGDJINIOJ.Sprites[NGBEDOPANOI(num)];
				SurfaceSpriteRenderer.color = PHNKMPAOMMO[num];
				ColorNextSpriteRenderer.color = BOKCDBLEPHF;
				ColorTempSpriteRenderer.color = BOKCDBLEPHF;
			}
			else
			{
				if (EFOLJPGECEG != null && EFOLJPGECEG.IsActive() && EFOLJPGECEG.IsPlaying())
				{
					EFOLJPGECEG.Kill();
					ColorTempSpriteRenderer.color = ColorNextSpriteRenderer.color;
					ColorTempSpriteRenderer.sprite = ColorNextSpriteRenderer.sprite;
					DFOKFEEAGPK = true;
				}
				HHFELELNMMG(num);
			}
			return num;
		}

		private int NGBEDOPANOI(int EHJNMODJEAN)
		{
			return LFJGHGGHEHP * 5 + EHJNMODJEAN;
		}

		private void HHFELELNMMG(int NCMJEIEJAKF)
		{
			if (NCMJEIEJAKF != -1)
			{
				EFOLJPGECEG = DOTween.Sequence();
				ColorNextSpriteRenderer.sprite = EDPGDJINIOJ.Sprites[NGBEDOPANOI(NCMJEIEJAKF)];
				ColorNextSpriteRenderer.color = BOKCDBLEPHF;
				EFOLJPGECEG.Insert(0f, ColorSpriteRenderer.DOFade(0.8f, 0.5f));
				EFOLJPGECEG.Insert(0f, ColorNextSpriteRenderer.DOFade(1f, 0.5f));
				if (DFOKFEEAGPK)
				{
					EFOLJPGECEG.Insert(0f, ColorTempSpriteRenderer.DOFade(0f, 0.5f));
				}
				Color FJOJCEIMONG = PHNKMPAOMMO[NCMJEIEJAKF];
				EFOLJPGECEG.Insert(0f, SurfaceSpriteRenderer.DOColor(FJOJCEIMONG, 0.5f));
				Vector3 position = ColorSpriteRenderer.transform.position;
				position.y += 0.3f;
				PlayParticle();
				EFOLJPGECEG.OnComplete(delegate
				{
					ColorSpriteRenderer.sprite = ColorNextSpriteRenderer.sprite;
					ColorSpriteRenderer.color = CKKDNEBOMOG;
					ColorNextSpriteRenderer.color = BOKCDBLEPHF;
					SurfaceSpriteRenderer.color = FJOJCEIMONG;
					DFOKFEEAGPK = false;
				});
			}
		}
	}
}
