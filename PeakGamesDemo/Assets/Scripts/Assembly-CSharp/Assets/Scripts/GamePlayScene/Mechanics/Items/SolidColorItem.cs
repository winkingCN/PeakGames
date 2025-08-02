using DG.Tweening;
using GamePlayScene.Mechanics;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Items
{
	public class SolidColorItem : SpriteBasedItem, CAAODJJHLLJ
	{
		private LEDBLDKJBAI DPMFLCCMHLM;

		private NOALGNJECAD KFLAELKHKKI;

		public SpriteRenderer GlowSpriteRenderer;

		private bool BPPMDKAIKND;

		private readonly EDOIFPONGPG LEIBJOHIMHM = new EDOIFPONGPG();

		private bool PMHNLBHFMBL;

		private bool IMJOKABAEHL;

		public bool DAPJNCFCBHD
		{
			get
			{
				return BPPMDKAIKND;
			}
		}

		public override int GetScore()
		{
			return 10;
		}

		public void ChangeMatchType(LEDBLDKJBAI JOCKKMJBJLL)
		{
			Paint(JOCKKMJBJLL);
		}

		public override bool CanBeReplacedByPreLevelBooster()
		{
			return true;
		}

		public override bool CanBeCapturedByJelly()
		{
			return true;
		}

		public override bool CanBeCollectedToBlasters()
		{
			return true;
		}

		public void SetupItem(NOALGNJECAD NBFBPNNEKMN)
		{
			NIPKCAEANKM();
			KFLAELKHKKI = NBFBPNNEKMN;
			switch (NBFBPNNEKMN)
			{
			case NOALGNJECAD.SolidColor1:
				DPMFLCCMHLM = LEDBLDKJBAI.Yellow;
				break;
			case NOALGNJECAD.SolidColor2:
				DPMFLCCMHLM = LEDBLDKJBAI.Red;
				break;
			case NOALGNJECAD.SolidColor3:
				DPMFLCCMHLM = LEDBLDKJBAI.Blue;
				break;
			case NOALGNJECAD.SolidColor4:
				DPMFLCCMHLM = LEDBLDKJBAI.Green;
				break;
			case NOALGNJECAD.SolidColor5:
				DPMFLCCMHLM = LEDBLDKJBAI.Purple;
				break;
			case NOALGNJECAD.SolidColor6:
				DPMFLCCMHLM = LEDBLDKJBAI.Orange;
				break;
			default:
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.SolidColorItem, "Cannot Initialize normal item with type: " + NBFBPNNEKMN);
				break;
			}
			CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.SolidColorSprites[(int)DPMFLCCMHLM];
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			PMHNLBHFMBL = CCPAJBOJDMN.ENBPGGCIADN == 5;
			return base.TryExplode(CCPAJBOJDMN);
		}

		public override void OnBeforeRemove()
		{
			base.OnBeforeRemove();
			LEIBJOHIMHM.ELLCPFDBNDK();
		}

		public override void RemoveSelf()
		{
			OnBeforeRemove();
			base.gameObject.MEJPNNFDEBD();
		}

		public override void AfterPoolInit()
		{
			base.AfterPoolInit();
			RelativeContainer.transform.localScale = Vector3.one;
		}

		private void NIPKCAEANKM()
		{
			BAIKFFOGMCB();
			DiscoRayReservedType = 0;
			GlowSpriteRenderer.enabled = false;
			DPMFLCCMHLM = LEDBLDKJBAI.None;
		}

		public Tweener MoveToSpecialItem(Cell FIICENBDLDC)
		{
			BAIKFFOGMCB();
			CurrentSpriteRenderer.sortingOrder += 1600;
			GlowSpriteRenderer.enabled = true;
			GlowSpriteRenderer.sortingOrder = 1600;
			return LEIBJOHIMHM.LGJBBEFGCFE(this, FIICENBDLDC);
		}

		protected override void EJCFANPAMMK()
		{
			if (!(ParticlePool.Instance == null))
			{
				SolidColorParticlePlayer solidColorParticlePlayer = ParticlePool.Instance.PlayParticle(ParticlePool.Instance.SolidColorExplosion, base.transform.position + MCJHHDACJBG.EOOFFMFMDKL, false) as SolidColorParticlePlayer;
				solidColorParticlePlayer.SetColor(GetItemType());
				solidColorParticlePlayer.EnableSmokeParticle(!PMHNLBHFMBL);
				if (PMHNLBHFMBL)
				{
					solidColorParticlePlayer.SetParticleCount(2f);
				}
				solidColorParticlePlayer.Play();
			}
		}

		public override bool CanShowMatchHint()
		{
			return false;
		}

		public void UpdateSprites(NOALGNJECAD NBFBPNNEKMN)
		{
			BPPMDKAIKND = true;
			switch (NBFBPNNEKMN)
			{
			case NOALGNJECAD.Rocket:
				CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.SolidColorHintRocketSprites[(int)GetMatchType()];
				break;
			case NOALGNJECAD.Bomb:
				CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.SolidColorHintBombSprites[(int)GetMatchType()];
				break;
			case NOALGNJECAD.DiscoBall:
				CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.SolidColorHintDiscoSprites[(int)GetMatchType()];
				break;
			default:
				BPPMDKAIKND = false;
				CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.SolidColorSprites[(int)GetMatchType()];
				break;
			}
		}

		public override bool CanShuffle()
		{
			return true;
		}

		public override bool CanBeMatchable()
		{
			return true;
		}

		public override LEDBLDKJBAI GetMatchType()
		{
			return DPMFLCCMHLM;
		}

		public override NOALGNJECAD GetItemType()
		{
			return KFLAELKHKKI;
		}

		public override bool CanBePaint()
		{
			return true;
		}

		public override bool CanShadowDrop()
		{
			return true;
		}

		public override bool CanBeCollectedWithAnimation()
		{
			return true;
		}

		public void Paint(LEDBLDKJBAI BACMHDFIMIC)
		{
			switch (BACMHDFIMIC)
			{
			case LEDBLDKJBAI.Yellow:
				KFLAELKHKKI = NOALGNJECAD.SolidColor1;
				break;
			case LEDBLDKJBAI.Red:
				KFLAELKHKKI = NOALGNJECAD.SolidColor2;
				break;
			case LEDBLDKJBAI.Blue:
				KFLAELKHKKI = NOALGNJECAD.SolidColor3;
				break;
			case LEDBLDKJBAI.Green:
				KFLAELKHKKI = NOALGNJECAD.SolidColor4;
				break;
			case LEDBLDKJBAI.Purple:
				KFLAELKHKKI = NOALGNJECAD.SolidColor5;
				break;
			case LEDBLDKJBAI.Orange:
				KFLAELKHKKI = NOALGNJECAD.SolidColor6;
				break;
			}
			DPMFLCCMHLM = BACMHDFIMIC;
			CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.SolidColorSprites[(int)BACMHDFIMIC];
		}

		public override int GetFireworksPriority()
		{
			int num = -1;
			if (ENCFFNKONOO != null && ENCFFNKONOO.HasBubble)
			{
				num = (BPPMDKAIKND ? 1 : 0);
			}
			else if (ENCFFNKONOO != null && FireworksController.GABGKBAKHDP.IsUnderToy(ENCFFNKONOO))
			{
				num = ((!BPPMDKAIKND) ? 2 : 3);
			}
			else if (!FilledNewly)
			{
				num = ((!BPPMDKAIKND) ? 4 : 5);
			}
			return (JLHIKIHDEIE < GetLayerCount()) ? num : (-1);
		}

		public override Item GetMasterTarget()
		{
			IMJOKABAEHL = ENCFFNKONOO.HasBubble;
			return (!IMJOKABAEHL) ? this : null;
		}

		public override void OnFallUpdated()
		{
			if (IMJOKABAEHL)
			{
				JLHIKIHDEIE = 0;
				IMJOKABAEHL = false;
			}
		}

		public override void OnReservedForCellItem(bool MJEJCGOLOPH)
		{
			base.OnReservedForCellItem(MJEJCGOLOPH);
			if (MJEJCGOLOPH)
			{
				UpdateSprites(NOALGNJECAD.None);
			}
		}

		public override void OnWrongTouch()
		{
			LevelBuilder.LastLevel.KMBHLPKMOEC.OEGMOBGBFJH++;
			PlayWrongMove();
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = (short)(DPMFLCCMHLM + 1);
		}
	}
}
