using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using DG.Tweening;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class PotionItem : Item, JFIEHOCCBNG
	{
		[CompilerGenerated]
		private sealed class PPNJGFICMFD
		{
			internal Color FJOJCEIMONG;

			internal PotionItem PDAPIGLEPGC;

			internal void AGFNGEFDHLA()
			{
				PDAPIGLEPGC.InnerSpriteRenderer.sprite = PDAPIGLEPGC.InnerNextSpriteRenderer.sprite;
				PDAPIGLEPGC.InnerSpriteRenderer.color = PDAPIGLEPGC.CKKDNEBOMOG;
				PDAPIGLEPGC.InnerNextSpriteRenderer.color = PDAPIGLEPGC.BOKCDBLEPHF;
				FJOJCEIMONG.a = 1f;
				PDAPIGLEPGC.SurfaceSpriteRenderer.color = FJOJCEIMONG;
				FJOJCEIMONG.a = 0f;
				PDAPIGLEPGC.SurfaceNextSpriteRenderer.color = FJOJCEIMONG;
				PDAPIGLEPGC.DFOKFEEAGPK = false;
			}
		}

		public Animator CurrentAnimator;

		public SpriteRenderer[] SortingSprites;

		public SpriteRenderer SurfaceSpriteRenderer;

		public SpriteRenderer SurfaceNextSpriteRenderer;

		public SpriteRenderer InnerSpriteRenderer;

		public SpriteRenderer InnerTempSpriteRenderer;

		public SpriteRenderer InnerNextSpriteRenderer;

		private static readonly Color[] PHNKMPAOMMO = new Color[5]
		{
			new Color(0.99607843f, 82f / 85f, 0.7647059f),
			new Color(84f / 85f, 0.6431373f, 0.6f),
			new Color(2f / 3f, 0.8980392f, 0.99215686f),
			new Color(44f / 51f, 0.99215686f, 62f / 85f),
			new Color(0.8980392f, 0.69803923f, 84f / 85f)
		};

		private readonly Color BOKCDBLEPHF = new Color(1f, 1f, 1f, 0f);

		private readonly Color CKKDNEBOMOG = new Color(1f, 1f, 1f, 1f);

		private LEDBLDKJBAI GIGJIOHBALP;

		private int LFCHJCKMMIH;

		private int OKJOGFBHOPE;

		private bool PIGCJDKPMFL;

		private bool DFOKFEEAGPK;

		private CKKKELDIOLD KKCPOOALFAD;

		private int[] IENHFDGGEAN;

		private Sequence EFOLJPGECEG;

		public override void OnItemCreated(KFCEILFGADG MGOFDOMDLCO)
		{
			base.OnItemCreated(MGOFDOMDLCO);
			ELFBOKDHKGG.OGIJEDJHMNG.Add(this);
			IENHFDGGEAN = new int[3];
			IENHFDGGEAN[0] = Animator.StringToHash("Base Layer.PotionDropAnimation1");
			IENHFDGGEAN[1] = Animator.StringToHash("Base Layer.PotionDropAnimation2");
			IENHFDGGEAN[2] = Animator.StringToHash("Base Layer.PotionDropAnimation3");
			OKJOGFBHOPE = MGOFDOMDLCO.EBMFPDNPIEM;
			UpdateView();
		}

		public void Init(LEDBLDKJBAI JOCKKMJBJLL)
		{
			GIGJIOHBALP = JOCKKMJBJLL;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			KKCPOOALFAD = IBBBMACIBGK;
			int i = 0;
			for (int num = SortingSprites.Length; i < num; i++)
			{
				SpriteRenderer spriteRenderer = SortingSprites[i];
				if (!(spriteRenderer == null))
				{
					spriteRenderer.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
					spriteRenderer.sortingOrder = KKCPOOALFAD.BHIJCAOHDCM + i;
				}
			}
		}

		public override CKKKELDIOLD GetSorting()
		{
			return KKCPOOALFAD;
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Potion;
		}

		public override int GetScore()
		{
			return 500;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return GIGJIOHBALP == KOINNGEBMJI;
		}

		public override bool CanBeInsideBubble()
		{
			return true;
		}

		public override bool CanCastShadow()
		{
			return true;
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			PIGCJDKPMFL = true;
			return true;
		}

		public override void PlayExplodeAudio()
		{
			AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[3]);
		}

		protected override void EJCFANPAMMK()
		{
			ItemResources resources = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType());
			if (ParticlePool.Instance != null && resources != null)
			{
				PotionParticlePlayer component = ParticlePool.Instance.PlayParticle(resources.Particles[1], base.transform.position).GetComponent<PotionParticlePlayer>();
				component.SetColor(GIGJIOHBALP);
			}
		}

		private int GOMFDFHCGOM(LEDBLDKJBAI JOCKKMJBJLL, bool KCJGMJPPBCE = true)
		{
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
				InnerSpriteRenderer.sprite = null;
				return num;
			}
			if (KCJGMJPPBCE)
			{
				ItemResources resources = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType());
				InnerSpriteRenderer.sprite = resources.Sprites[num];
				SurfaceSpriteRenderer.color = PHNKMPAOMMO[num];
			}
			return num;
		}

		private void HHFELELNMMG(int NCMJEIEJAKF)
		{
			if (NCMJEIEJAKF != -1)
			{
				EFOLJPGECEG = DOTween.Sequence();
				InnerNextSpriteRenderer.sprite = BBKCPPOFENL.Sprites[NCMJEIEJAKF];
				InnerNextSpriteRenderer.color = BOKCDBLEPHF;
				Color FJOJCEIMONG = PHNKMPAOMMO[NCMJEIEJAKF];
				FJOJCEIMONG.a = 0f;
				SurfaceNextSpriteRenderer.color = FJOJCEIMONG;
				EFOLJPGECEG.Insert(0f, InnerSpriteRenderer.DOFade(0.8f, 0.5f));
				EFOLJPGECEG.Insert(0f, InnerNextSpriteRenderer.DOFade(1f, 0.5f));
				if (DFOKFEEAGPK)
				{
					EFOLJPGECEG.Insert(0f, InnerTempSpriteRenderer.DOFade(0f, 0.5f));
				}
				EFOLJPGECEG.Insert(0f, SurfaceSpriteRenderer.DOFade(0.8f, 0.5f));
				EFOLJPGECEG.Insert(0f, SurfaceNextSpriteRenderer.DOFade(1f, 0.5f));
				if (ParticlePool.Instance != null && BBKCPPOFENL != null)
				{
					PotionParticlePlayer component = ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[0], this).GetComponent<PotionParticlePlayer>();
					component.SetColor(GIGJIOHBALP);
					ItemResources.AudioProps gFKKCPCHDGN = BBKCPPOFENL.AudioClips[Random.Range(0, 3)];
					AudioManager.PlayAudioProps(gFKKCPCHDGN);
				}
				EFOLJPGECEG.OnComplete(delegate
				{
					InnerSpriteRenderer.sprite = InnerNextSpriteRenderer.sprite;
					InnerSpriteRenderer.color = CKKDNEBOMOG;
					InnerNextSpriteRenderer.color = BOKCDBLEPHF;
					FJOJCEIMONG.a = 1f;
					SurfaceSpriteRenderer.color = FJOJCEIMONG;
					FJOJCEIMONG.a = 0f;
					SurfaceNextSpriteRenderer.color = FJOJCEIMONG;
					DFOKFEEAGPK = false;
				});
			}
		}

		public void ExplosionOccured(int CIDKKPKJJAE)
		{
			if (!PIGCJDKPMFL && (!(ENCFFNKONOO != null) || !ENCFFNKONOO.HasCellItem()) && OKJOGFBHOPE != CIDKKPKJJAE)
			{
				OKJOGFBHOPE = CIDKKPKJJAE;
				GIGJIOHBALP = ELFBOKDHKGG.FBKNLKDOAKD(NOALGNJECAD.Potion, ref LFCHJCKMMIH);
				if (EFOLJPGECEG != null && EFOLJPGECEG.IsPlaying())
				{
					EFOLJPGECEG.Kill();
					InnerTempSpriteRenderer.color = InnerNextSpriteRenderer.color;
					InnerTempSpriteRenderer.sprite = InnerNextSpriteRenderer.sprite;
					SurfaceSpriteRenderer.color = SurfaceNextSpriteRenderer.color;
					DFOKFEEAGPK = true;
				}
				HHFELELNMMG(GOMFDFHCGOM(GIGJIOHBALP, false));
			}
		}

		public override void OnFallEnded()
		{
			base.OnFallEnded();
			CurrentAnimator.Play(IENHFDGGEAN[Random.Range(0, 3)], 0, 0f);
		}

		public override void UpdateView()
		{
			LFCHJCKMMIH = ELFBOKDHKGG.APDPLIOJAHC(NOALGNJECAD.Potion, GIGJIOHBALP);
			if (LFCHJCKMMIH == -1)
			{
				GIGJIOHBALP = ELFBOKDHKGG.KIEPOCCJHIC(NOALGNJECAD.Potion, ref LFCHJCKMMIH);
			}
			GOMFDFHCGOM(GIGJIOHBALP);
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = (short)(55 + GIGJIOHBALP);
		}
	}
}
