using System.Collections;
using Assets.Scripts.Utils;
using DG.Tweening;
using GamePlayScene.Mechanics;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Items
{
	public class EasterEggItem : SpriteBasedItem
	{
		[HideInInspector]
		public LEDBLDKJBAI EffectiveType = LEDBLDKJBAI.None;

		public SpriteRenderer BlurSpriteRenderer;

		public SpriteRenderer EggLinesRenderer;

		public SpriteRenderer EggLinesRenderer2;

		public Animator TransformationAnimator;

		public Color GreenMain = new Color(0.07450981f, 14f / 15f, 28f / 85f, 1f);

		public Color RedMain = new Color(1f, 18f / 85f, 18f / 85f, 1f);

		public Color BlueMain = new Color(0.6431373f, 1f, 1f, 1f);

		public Color YellowMain = new Color(1f, 0.9098039f, 2f / 85f, 1f);

		public Color PurpleMain = new Color(73f / 85f, 28f / 85f, 1f, 1f);

		public Color GreenParticle = new Color(8f / 51f, 0.9254902f, 0.19215687f, 1f);

		public Color RedParticle = new Color(1f, 18f / 85f, 18f / 85f, 1f);

		public Color BlueParticle = new Color(12f / 85f, 0.6039216f, 1f, 1f);

		public Color YellowParticle = new Color(1f, 1f, 0.38431373f, 1f);

		public Color PurpleParticle = new Color(0.7372549f, 0.20784314f, 0.78039217f, 1f);

		private LEDBLDKJBAI AJOFNCOOPLN = LEDBLDKJBAI.None;

		private bool OJLKEJCPCEK;

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			AJOFNCOOPLN = KOINNGEBMJI;
			return true;
		}

		public void TransformationEnded()
		{
			CurrentSpriteRenderer.color = Color.white;
			BlurSpriteRenderer.gameObject.SetActive(false);
			EggLinesRenderer.gameObject.SetActive(false);
			EggLinesRenderer2.gameObject.SetActive(false);
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			base.ChangeSorting(IBBBMACIBGK);
			BlurSpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			BlurSpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + 1;
			EggLinesRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			EggLinesRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + 2;
			EggLinesRenderer2.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			EggLinesRenderer2.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + 2;
		}

		private void BABJBOBMLCL()
		{
			if (!OJLKEJCPCEK)
			{
				OJLKEJCPCEK = true;
				Color endValue = Color.yellow;
				Color eLLOILOPDJC = Color.yellow;
				Sprite sprite;
				switch (EffectiveType)
				{
				case LEDBLDKJBAI.Yellow:
					sprite = SharedImageLibrary.Instance.EasterEggSprites[1];
					endValue = YellowMain;
					eLLOILOPDJC = YellowParticle;
					break;
				case LEDBLDKJBAI.Red:
					sprite = SharedImageLibrary.Instance.EasterEggSprites[2];
					endValue = RedMain;
					eLLOILOPDJC = RedParticle;
					break;
				case LEDBLDKJBAI.Blue:
					sprite = SharedImageLibrary.Instance.EasterEggSprites[3];
					endValue = BlueMain;
					eLLOILOPDJC = BlueParticle;
					break;
				case LEDBLDKJBAI.Green:
					sprite = SharedImageLibrary.Instance.EasterEggSprites[4];
					endValue = GreenMain;
					eLLOILOPDJC = GreenParticle;
					break;
				case LEDBLDKJBAI.Purple:
					sprite = SharedImageLibrary.Instance.EasterEggSprites[5];
					endValue = PurpleMain;
					eLLOILOPDJC = PurpleParticle;
					break;
				default:
					sprite = SharedImageLibrary.Instance.EasterEggSprites[1];
					break;
				}
				CurrentSpriteRenderer.sprite = sprite;
				Vector3 position = base.gameObject.transform.position;
				position.y -= 0.1f;
				if (ItemResourcesManager.GABGKBAKHDP != null)
				{
					ItemResources resources = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType());
					AudioManager.PlayAudioProps(resources.AudioClips[0]);
					ParticlePlayer particlePlayer = ParticlePool.Instance.PlayParticle(resources.Particles[0], this, false);
					particlePlayer.gameObject.transform.position = position;
					particlePlayer.GetComponent<EasterEggTransformationParticle>().SetStartColors(eLLOILOPDJC, CurrentSpriteRenderer.sortingOrder + 110);
					StartCoroutine(DNIMJGBIGCK(particlePlayer, 0.15f));
				}
				TransformationAnimator.enabled = true;
				CurrentSpriteRenderer.color = new Color(1f, 1f, 1f, 0f);
				BlurSpriteRenderer.gameObject.SetActive(true);
				EggLinesRenderer.gameObject.SetActive(true);
				EggLinesRenderer2.gameObject.SetActive(true);
				BlurSpriteRenderer.DOColor(endValue, 0.27f);
			}
		}

		private static IEnumerator DNIMJGBIGCK(ParticlePlayer MBOBDDKIFAH, float DKIPEJPGACG)
		{
			yield return new WaitForSeconds(DKIPEJPGACG);
			MBOBDDKIFAH.Play();
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (EffectiveType == LEDBLDKJBAI.None)
			{
				EffectiveType = ELFBOKDHKGG.DCJNBADOLGD[FCPPDOMBLHL.Group1].HPBAMJALPMB().OFBMGJCGHFE();
			}
			base.ExplodeByBlasterItem(CCPAJBOJDMN);
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			if (EffectiveType == LEDBLDKJBAI.None)
			{
				if (CCPAJBOJDMN.AFAAILGMEBN)
				{
					EffectiveType = AJOFNCOOPLN;
				}
				else
				{
					try
					{
						NOALGNJECAD pLCFEOMGCFK = ELFBOKDHKGG.DCJNBADOLGD[FCPPDOMBLHL.Group1].HPBAMJALPMB();
						EffectiveType = pLCFEOMGCFK.OFBMGJCGHFE();
					}
					catch
					{
						GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.EasterEgg, "Can not find a match from Group!");
						EffectiveType = LEDBLDKJBAI.Blue;
					}
				}
				BABJBOBMLCL();
				return false;
			}
			return !CCPAJBOJDMN.AFAAILGMEBN || EffectiveType == AJOFNCOOPLN;
		}

		public override int GetScore()
		{
			return 500;
		}

		public override bool CanCastShadow()
		{
			return true;
		}

		public override int GetLayerCount()
		{
			return (EffectiveType != LEDBLDKJBAI.None) ? 1 : 2;
		}

		public override void PlayExplodeAudio()
		{
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[1]);
			}
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.EasterEgg;
		}

		protected override void EJCFANPAMMK()
		{
			if (ParticlePool.Instance != null && ItemResourcesManager.GABGKBAKHDP != null)
			{
				ParticlePlayer particlePlayer = ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[1], base.transform.position);
				EasterEggExplosionParticle component = particlePlayer.GetComponent<EasterEggExplosionParticle>();
				component.SetColor(EffectiveType);
			}
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 71;
			byte aINNOPBDDGL = (byte)EffectiveType;
			PNINCDLIDLL.DKJDLMNKFGM(aINNOPBDDGL);
		}
	}
}
