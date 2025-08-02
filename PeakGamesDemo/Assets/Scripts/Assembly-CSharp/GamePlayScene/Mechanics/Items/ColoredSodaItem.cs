using System.Collections.Generic;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class ColoredSodaItem : Item
	{
		public ColoredSodaFakeItem BottomRight;

		public ColoredSodaFakeItem TopLeft;

		public ColoredSodaFakeItem TopRight;

		public Animator CurrentAnimator;

		public SpriteRenderer BackSpriteRenderer;

		public Transform ExplodePosition;

		public SodaBottle[] SodaBottles;

		private List<SodaBottle> PKOLNILPHBO;

		private LEDBLDKJBAI GIGJIOHBALP;

		private CKKKELDIOLD KKCPOOALFAD;

		private int[] DAJLHJICGJN;

		private bool DJIFKHIOMNO;

		private float OBBFCPIOIBH;

		private bool NFBGMNBEOJK = true;

		public override Cell ENCFFNKONOO
		{
			get
			{
				return base.ENCFFNKONOO;
			}
			set
			{
				base.ENCFFNKONOO = value;
				if (ENCFFNKONOO != null)
				{
					TopLeft.ENCFFNKONOO = ENCFFNKONOO.CurrentGrid.ECNCPJGHBIG(ENCFFNKONOO.X, ENCFFNKONOO.Y + 1);
					TopRight.ENCFFNKONOO = ENCFFNKONOO.CurrentGrid.ECNCPJGHBIG(ENCFFNKONOO.X + 1, ENCFFNKONOO.Y + 1);
					BottomRight.ENCFFNKONOO = ENCFFNKONOO.CurrentGrid.ECNCPJGHBIG(ENCFFNKONOO.X + 1, ENCFFNKONOO.Y);
				}
				else
				{
					TopLeft.ENCFFNKONOO = null;
					TopRight.ENCFFNKONOO = null;
					BottomRight.ENCFFNKONOO = null;
				}
			}
		}

		private void PJBGPLNFKKF(LEDBLDKJBAI JOCKKMJBJLL)
		{
			int num = 0;
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
			}
			SharedImageLibrary instance = SharedImageLibrary.Instance;
			int num2 = SodaBottles.Length;
			for (int i = 0; i < num2; i++)
			{
				SodaBottles[i].BottleSpriteRenderer.sprite = instance.SodaItemBottles[num];
				SodaBottles[i].CapSpriteRenderer.sprite = instance.SodaItemCaps[num];
				SodaBottles[i].TopSpriteRenderer.sprite = instance.SodaItemTops[num];
			}
		}

		public void Start()
		{
			JKPEPNEOJML();
			PJBGPLNFKKF(GIGJIOHBALP);
		}

		protected void JKPEPNEOJML()
		{
			DAJLHJICGJN = new int[1] { Animator.StringToHash("Base Layer.SodaItemShakeAnimation1") };
		}

		public void Init(LEDBLDKJBAI JOCKKMJBJLL)
		{
			GIGJIOHBALP = JOCKKMJBJLL;
			PKOLNILPHBO = new List<SodaBottle>
			{
				SodaBottles[0],
				SodaBottles[1],
				SodaBottles[2],
				SodaBottles[3]
			};
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			if (GIGJIOHBALP != KOINNGEBMJI)
			{
				return false;
			}
			return true;
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			return ExplodeBy(this, CCPAJBOJDMN);
		}

		public override bool CanGenerateScoreThisTurn()
		{
			return NFBGMNBEOJK;
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (DJIFKHIOMNO)
			{
				return;
			}
			DJIFKHIOMNO = true;
			int count = PKOLNILPHBO.Count;
			for (int i = 0; i < count; i++)
			{
				SodaBottle sodaBottle = PKOLNILPHBO[i];
				if (sodaBottle != null)
				{
					Vector3 position = sodaBottle.transform.position;
					Object.Destroy(sodaBottle.gameObject);
					if (ParticlePool.Instance != null && ItemResourcesManager.GABGKBAKHDP != null)
					{
						SodaBottleParticlePlayer component = ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[0], position).GetComponent<SodaBottleParticlePlayer>();
						component.SetColor(GIGJIOHBALP);
					}
					if (i > 0)
					{
						ScoreManager.RaiseScore(GetScore());
					}
					ELFBOKDHKGG.ACJOALJFMHN(NOALGNJECAD.Soda, false);
				}
			}
			PlayExplodeAudio();
			EJCFANPAMMK();
			RemoveSelf();
		}

		public bool ExplodeBy(Item EJCNAJOHBFI, APBDPLNCDIJ CCPAJBOJDMN)
		{
			NFBGMNBEOJK = false;
			if (DJIFKHIOMNO)
			{
				return false;
			}
			if (CCPAJBOJDMN.ENBPGGCIADN == 13)
			{
				return false;
			}
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			NFBGMNBEOJK = true;
			KKHHCDOPGND();
			if (CCPAJBOJDMN.JKJHJDLHCMD)
			{
				ScoreManager.RaiseScore(EJCNAJOHBFI.GetScore());
			}
			if (PKOLNILPHBO.Count != 0)
			{
				ELFBOKDHKGG.ACJOALJFMHN(NOALGNJECAD.Soda, false);
				return false;
			}
			DJIFKHIOMNO = true;
			return true;
		}

		private void KKHHCDOPGND()
		{
			if (!DJIFKHIOMNO)
			{
				int index = PKOLNILPHBO.Count - 1;
				SodaBottle sodaBottle = PKOLNILPHBO[index];
				PKOLNILPHBO.RemoveAt(index);
				for (int i = 0; i < PKOLNILPHBO.Count; i++)
				{
					PKOLNILPHBO[i].PlayShakeAnimation(GIGJIOHBALP);
				}
				Vector3 position = sodaBottle.transform.position;
				Object.Destroy(sodaBottle.gameObject);
				int stateNameHash = DAJLHJICGJN[Random.Range(0, DAJLHJICGJN.Length)];
				CurrentAnimator.Play(stateNameHash, 0, 0f);
				ItemResources resources = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType());
				if (resources != null)
				{
					AudioManager.PlayAudioProps(resources.AudioClips[0]);
				}
				if (ParticlePool.Instance != null && resources != null)
				{
					SodaBottleParticlePlayer component = ParticlePool.Instance.PlayParticle(resources.Particles[0], position).GetComponent<SodaBottleParticlePlayer>();
					component.SetColor(GIGJIOHBALP);
				}
			}
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Soda;
		}

		public override CKKKELDIOLD GetSorting()
		{
			return KKCPOOALFAD;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			KKCPOOALFAD = IBBBMACIBGK;
			BackSpriteRenderer.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
			BackSpriteRenderer.sortingOrder = KKCPOOALFAD.BHIJCAOHDCM;
			SodaBottles[0].ChangeSorting(KKCPOOALFAD, 20);
			SodaBottles[1].ChangeSorting(KKCPOOALFAD, 30);
			SodaBottles[2].ChangeSorting(KKCPOOALFAD, 10);
			SodaBottles[3].ChangeSorting(KKCPOOALFAD, 20);
		}

		public override void PlayExplodeAudio()
		{
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[1]);
			}
		}

		public override bool CanFall()
		{
			return false;
		}

		public override int GetScore()
		{
			return 1000;
		}

		protected override void EJCFANPAMMK()
		{
			if (ParticlePool.Instance != null && ItemResourcesManager.GABGKBAKHDP != null)
			{
				ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[1], ExplodePosition.position);
			}
		}

		public override void RemoveSelf()
		{
			base.RemoveSelf();
			BottomRight.RemoveSelf();
			TopLeft.RemoveSelf();
			TopRight.RemoveSelf();
		}

		public override bool CanGenerateScoreOnEachTryExplode()
		{
			return true;
		}

		public override bool CanBeInsideBubble()
		{
			return false;
		}

		public override bool CanBeInsideCellItem()
		{
			return false;
		}

		public override int GetLayerCount()
		{
			return PKOLNILPHBO.Count;
		}

		public override Vector3 GetCenterPositionOffset(APBDPLNCDIJ CCPAJBOJDMN)
		{
			return new Vector3(0.5f, 0.5f, 0f);
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			ALIFCLNJKPH aLIFCLNJKPH = ALIFCLNJKPH.Soda4;
			switch (GIGJIOHBALP)
			{
			case LEDBLDKJBAI.Yellow:
				aLIFCLNJKPH = ALIFCLNJKPH.ColoredSodaYellow;
				break;
			case LEDBLDKJBAI.Red:
				aLIFCLNJKPH = ALIFCLNJKPH.ColoredSodaRed;
				break;
			case LEDBLDKJBAI.Blue:
				aLIFCLNJKPH = ALIFCLNJKPH.ColoredSodaBlue;
				break;
			case LEDBLDKJBAI.Green:
				aLIFCLNJKPH = ALIFCLNJKPH.ColoredSodaGreen;
				break;
			case LEDBLDKJBAI.Purple:
				aLIFCLNJKPH = ALIFCLNJKPH.ColoredSodaPurple;
				break;
			}
			PNINCDLIDLL.EEFMIHDPJPG = (short)aLIFCLNJKPH;
			byte aINNOPBDDGL = (byte)GetLayerCount();
			PNINCDLIDLL.DKJDLMNKFGM(aINNOPBDDGL);
		}

		protected List<SodaBottle> KBOIIEODFLE()
		{
			return PKOLNILPHBO;
		}
	}
}
