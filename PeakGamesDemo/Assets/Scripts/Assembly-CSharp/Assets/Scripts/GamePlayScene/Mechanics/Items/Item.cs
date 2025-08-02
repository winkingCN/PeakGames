using System;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using Assets.Scripts.GamePlayScene.Mechanics.Items.Features;
using Assets.Scripts.Utils;
using DG.Tweening;
using GamePlayScene.Mechanics;
using GamePlayScene.Mechanics.Items;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Items
{
	public abstract class Item : MonoBehaviour
	{
		[HideInInspector]
		public bool IsActive = true;

		private bool BADFAOOIHND;

		protected KFCEILFGADG ELFBOKDHKGG;

		protected ItemResources BBKCPPOFENL;

		protected Cell IDIOLIHBJBE;

		public Cell ParentCell;

		[HideInInspector]
		public byte DiscoRayReservedType;

		[HideInInspector]
		public bool ReCycled;

		[HideInInspector]
		public bool FilledNewly;

		protected readonly HashSet<int> NGKLFNCDIJM = new HashSet<int>();

		[HideInInspector]
		public bool IsFalling;

		private CanCastShadowComponent KIBHBMLKEBK;

		private bool CPPHOGCJINF = true;

		public FallListener FallListener;

		public GameObject RelativeContainer;

		private Sequence KEELJCBPPED;

		public FallAnimation CurrentFallAnimation;

		protected bool OMDOBBEDBAO;

		public virtual Cell ENCFFNKONOO
		{
			get
			{
				return IDIOLIHBJBE;
			}
			set
			{
				if (!(IDIOLIHBJBE == value))
				{
					Cell iDIOLIHBJBE = IDIOLIHBJBE;
					IDIOLIHBJBE = value;
					if (iDIOLIHBJBE != null && iDIOLIHBJBE.LBFCDKPCDPB == this)
					{
						iDIOLIHBJBE.LBFCDKPCDPB = null;
					}
					if (value != null)
					{
						value.LBFCDKPCDPB = this;
					}
					DEIFPMCEKCO();
				}
			}
		}

		public virtual int JLHIKIHDEIE { get; set; }

		public event Action DFKAIGLKIIH;

		public virtual void OnBeforeRemove()
		{
			if (this.DFKAIGLKIIH != null)
			{
				this.DFKAIGLKIIH();
				this.DFKAIGLKIIH = null;
			}
			NGKLFNCDIJM.Clear();
			FallManager.StartRunning();
			if (BADFAOOIHND)
			{
				BADFAOOIHND = false;
				ReCycled = true;
			}
		}

		public virtual void AfterPoolInit()
		{
			ReCycled = false;
			FilledNewly = false;
			IsFalling = false;
			JLHIKIHDEIE = 0;
			CPPHOGCJINF = true;
			ParentCell = null;
		}

		public virtual void OnItemCreated(KFCEILFGADG MGOFDOMDLCO)
		{
			BBKCPPOFENL = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType());
			ELFBOKDHKGG = MGOFDOMDLCO;
			ELFBOKDHKGG.GKKIFODLNDE(GetItemType());
			ELFBOKDHKGG.MLAGNJGFOND(GetItemType());
			BADFAOOIHND = true;
		}

		protected virtual void DEIFPMCEKCO()
		{
			if (!(ENCFFNKONOO == null))
			{
				IsActive = !ENCFFNKONOO.HasCellItem();
				CKKKELDIOLD iBBBMACIBGK = PAFJGJOPLKB.LOPMMJANOFP(ENCFFNKONOO.Y);
				ChangeSorting(iBBBMACIBGK);
				CanCastShadowComponent shadowCaster = GetShadowCaster();
				if (!(shadowCaster == null))
				{
					SpriteRenderer shadowSpriteRenderer = shadowCaster.ShadowSpriteRenderer;
					shadowSpriteRenderer.sortingOrder = iBBBMACIBGK.BHIJCAOHDCM - 1;
					shadowSpriteRenderer.sortingLayerID = iBBBMACIBGK.MMFFDANAEEI;
				}
			}
		}

		public virtual Item ExtractSubItem()
		{
			return null;
		}

		public virtual void OnFallEnded()
		{
		}

		public virtual void OnFallUpdated()
		{
		}

		public virtual bool CanFall()
		{
			return true;
		}

		public virtual bool IsSpecialItem()
		{
			return false;
		}

		public virtual bool CanBeCapturedByJelly()
		{
			return false;
		}

		public virtual bool CanBeTapped()
		{
			return true;
		}

		public virtual bool CanBeMatchable()
		{
			return false;
		}

		public virtual bool CanGenerateScoreOnEachTryExplode()
		{
			return false;
		}

		public virtual bool CanGenerateScoreWithoutExplode()
		{
			return false;
		}

		public virtual bool CanGenerateScoreThisTurn()
		{
			return true;
		}

		public virtual bool CanBeExplodedBySpecialItem()
		{
			return true;
		}

		public virtual bool CanBeExplodedByBooster()
		{
			return true;
		}

		public virtual bool BoosterAnvilCanBeUsed()
		{
			return true;
		}

		public virtual bool BoosterBoxingGloveCanBeUsed()
		{
			return true;
		}

		public virtual bool BoosterHammerCanBeUsed()
		{
			return true;
		}

		public virtual LEDBLDKJBAI GetMatchType()
		{
			return LEDBLDKJBAI.None;
		}

		public abstract NOALGNJECAD GetItemType();

		public virtual bool CanShuffle()
		{
			return false;
		}

		public virtual bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return false;
		}

		public virtual bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			return LAGEBFBEINC(CCPAJBOJDMN);
		}

		protected bool LAGEBFBEINC(APBDPLNCDIJ CCPAJBOJDMN)
		{
			return NGKLFNCDIJM.Add(CCPAJBOJDMN.EEFMIHDPJPG);
		}

		public virtual void RemoveAllLayers()
		{
		}

		public virtual bool CanBeReplacedByPreLevelBooster()
		{
			return false;
		}

		public virtual bool CanBePaint()
		{
			return false;
		}

		public virtual bool CanCastShadow()
		{
			return false;
		}

		public CanCastShadowComponent GetShadowCaster()
		{
			if (!CanCastShadow())
			{
				return null;
			}
			if (KIBHBMLKEBK == null)
			{
				KIBHBMLKEBK = GetComponent<CanCastShadowComponent>();
			}
			return KIBHBMLKEBK;
		}

		public virtual bool CanShadowDrop()
		{
			return false;
		}

		public virtual int GetFireworksPriority()
		{
			int num = GetLayerCount();
			if (ENCFFNKONOO != null && ENCFFNKONOO.HasBubble)
			{
				num++;
			}
			return (JLHIKIHDEIE >= num) ? (-1) : 0;
		}

		public virtual int SelectedByFireworks()
		{
			JLHIKIHDEIE++;
			return GetFireworksPriority();
		}

		public virtual void HitByFireworks()
		{
			JLHIKIHDEIE--;
			if (JLHIKIHDEIE < 0)
			{
				JLHIKIHDEIE = 0;
			}
		}

		public virtual Item GetMasterTarget()
		{
			return this;
		}

		public virtual Vector3 GetCenterPositionOffset(APBDPLNCDIJ CCPAJBOJDMN)
		{
			return Vector3.zero;
		}

		public virtual int GetLayerCount()
		{
			return 1;
		}

		public virtual int GetScore()
		{
			return 10;
		}

		public virtual bool CanRaiseScore()
		{
			return CPPHOGCJINF;
		}

		public void PreventRaiseScore()
		{
			CPPHOGCJINF = false;
		}

		internal void IOFDFFBKCBF()
		{
			CPPHOGCJINF = true;
		}

		public void DoShuffleAnimation(Cell FIICENBDLDC, Cell JGPDDHNMPOH, LEDBLDKJBAI IINIKGMHFFM)
		{
			CKKKELDIOLD kHFBHDLBLJH = PAFJGJOPLKB.LOPMMJANOFP(FIICENBDLDC.Y);
			int bHIJCAOHDCM = kHFBHDLBLJH.BHIJCAOHDCM;
			kHFBHDLBLJH.BHIJCAOHDCM += ((IINIKGMHFFM != LEDBLDKJBAI.None) ? (-50) : 0);
			CKKKELDIOLD iBBBMACIBGK = PAFJGJOPLKB.LOPMMJANOFP(JGPDDHNMPOH.Y);
			ENCFFNKONOO = FIICENBDLDC;
			ChangeSorting(iBBBMACIBGK);
			ShuffleAnimation shuffleAnimation = base.gameObject.NKNNFLHDJHK<ShuffleAnimation>();
			shuffleAnimation.CJJAIFCFLCF(this, kHFBHDLBLJH);
			shuffleAnimation.ShuffleWith(JGPDDHNMPOH, FIICENBDLDC, bHIJCAOHDCM, IINIKGMHFFM);
		}

		public abstract void ChangeSorting(CKKKELDIOLD IBBBMACIBGK);

		public abstract CKKKELDIOLD GetSorting();

		public virtual void StartExplode()
		{
			BAIKFFOGMCB();
			PlayExplodeAudio();
			EJCFANPAMMK();
			RemoveSelf();
		}

		public virtual void RemoveSelf()
		{
			OnBeforeRemove();
			UnityEngine.Object.Destroy(base.gameObject);
		}

		public virtual void OnBeforeNewLevel()
		{
			ELFBOKDHKGG = null;
		}

		public virtual CollectAnimation GetCollectItem()
		{
			CollectAnimation component = ELFBOKDHKGG.GIMBEKBFKMJ.GenericCollectItem.JOBDHIPIMAG(base.transform.position).GetComponent<CollectAnimation>();
			component.Prepare(ELFBOKDHKGG, GetItemType(), GetSorting(), null, ENCFFNKONOO);
			return component;
		}

		public virtual void StartCollect()
		{
			BAIKFFOGMCB();
			CollectAnimation collectItem = GetCollectItem();
			collectItem.StartAnimation();
			PlayExplodeAudio();
			EJCFANPAMMK();
			RemoveSelf();
		}

		public void StartCollectToItem(Cell MFENMHPPAHD, bool LIBMFHBHMFK = false)
		{
			BAIKFFOGMCB();
			BlasterItem blasterItem = NLMLKADGECN.GABGKBAKHDP.BPHMPBKJJOO().DLGLMDDEOEG(GetMatchType());
			WallItem wallItem = NLMLKADGECN.GABGKBAKHDP.OAPMNDFNNHB().DLGLMDDEOEG(GetMatchType());
			if (blasterItem != null || wallItem != null)
			{
				Vector3 nBLHKHMMCKB = ((!(blasterItem != null)) ? wallItem.CollectTarget.position : blasterItem.CollectTarget.position);
				CollectorItem cAMFPAAGCIC = ((!(blasterItem != null)) ? ((CollectorItem)wallItem) : ((CollectorItem)blasterItem));
				GameObject gameObject = ELFBOKDHKGG.GIMBEKBFKMJ.BlasterItemCollectAnimation.JOBDHIPIMAG();
				BlasterCollectAnimation component = gameObject.GetComponent<BlasterCollectAnimation>();
				component.StartAnimation(GetItemType(), base.transform.position, nBLHKHMMCKB, cAMFPAAGCIC, MFENMHPPAHD, LIBMFHBHMFK, GetSorting());
			}
			else
			{
				CollectAnimation collectItem = GetCollectItem();
				collectItem.StartAnimation();
			}
			PlayExplodeAudio();
			EJCFANPAMMK();
			RemoveSelf();
		}

		public virtual void PlayExplodeAudio()
		{
			AudioManager.Play(KOOGPFAPGGD.ClassicExplode);
		}

		public virtual void OnWrongTouch()
		{
			LevelBuilder.LastLevel.KMBHLPKMOEC.JMAHDCMOIGC++;
			PlayWrongMove();
		}

		public virtual void PlayWrongMove()
		{
			if (KEELJCBPPED != null)
			{
				KEELJCBPPED.Kill(true);
			}
			AudioManager.Play(KOOGPFAPGGD.InvalidTap);
			KEELJCBPPED = DOTween.Sequence();
			KEELJCBPPED.Append(RelativeContainer.transform.DOLocalRotate(new Vector3(0f, 0f, 15f), 0.035f));
			KEELJCBPPED.Join(RelativeContainer.transform.DOScale(0.93f, 0.035f));
			KEELJCBPPED.Append(RelativeContainer.transform.DOLocalRotate(new Vector3(0f, 0f, -15f), 0.07f));
			KEELJCBPPED.Append(RelativeContainer.transform.DOLocalRotate(new Vector3(0f, 0f, 0f), 0.035f));
			KEELJCBPPED.Append(RelativeContainer.transform.DOLocalRotate(new Vector3(0f, 0f, 15f), 0.035f));
			KEELJCBPPED.Append(RelativeContainer.transform.DOLocalRotate(new Vector3(0f, 0f, -15f), 0.07f));
			KEELJCBPPED.Append(RelativeContainer.transform.DOLocalRotate(new Vector3(0f, 0f, 0f), 0.035f));
			KEELJCBPPED.Join(RelativeContainer.transform.DOScale(1f, 0.035f));
			KEELJCBPPED.OnComplete(HCKMPDJJCLG);
		}

		private void HCKMPDJJCLG()
		{
			KEELJCBPPED = null;
		}

		public void AppendFallAnimation(Cell FIICENBDLDC)
		{
			if (KEELJCBPPED != null)
			{
				KEELJCBPPED.Kill(true);
				KEELJCBPPED = null;
			}
			if (CurrentFallAnimation == null)
			{
				CurrentFallAnimation = base.gameObject.AddComponent<FallAnimation>();
			}
			CurrentFallAnimation.AppendFallTo(FIICENBDLDC, MHILDHNALNO());
		}

		protected void BAIKFFOGMCB()
		{
			if (KEELJCBPPED != null)
			{
				KEELJCBPPED.Kill(true);
				KEELJCBPPED = null;
			}
			if (CurrentFallAnimation != null)
			{
				CurrentFallAnimation.Cancel();
			}
		}

		public virtual void ReactToUpperFall()
		{
		}

		protected virtual void EJCFANPAMMK()
		{
			if (ParticlePool.Instance != null)
			{
				ParticlePool.Instance.PlayParticle(ParticlePool.Instance.DefaultExplosion, base.transform.position);
			}
		}

		public virtual bool CanShowMatchHint()
		{
			return false;
		}

		public virtual bool CanShowCurrentlyUnderTap()
		{
			return false;
		}

		protected FallListener MHILDHNALNO()
		{
			return FallListener;
		}

		public virtual void SetExplodeDirection(IEKBFJBLGFM AJLDJAHHGOJ)
		{
		}

		public virtual void BringToFront()
		{
		}

		public virtual void SendToBack()
		{
		}

		public virtual bool CanBeInsideBubble()
		{
			return true;
		}

		public virtual bool CanBeInsideCellItem()
		{
			return true;
		}

		public virtual bool CanBeCollectedToBlasters()
		{
			return false;
		}

		public virtual void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (ELFBOKDHKGG != null && !(ENCFFNKONOO == null) && ENCFFNKONOO.CurrentGrid != null)
			{
				ELFBOKDHKGG.JHDMFHDHIFN.EJBPCMDJFEM(ENCFFNKONOO, CCPAJBOJDMN);
			}
		}

		public virtual bool CanBeCollectedWithAnimation()
		{
			return false;
		}

		public virtual void OnSubItemCreated()
		{
		}

		public virtual Item GetSubItem()
		{
			return null;
		}

		public virtual void UpdateView()
		{
		}

		public virtual void UpdateOnFallBehind()
		{
		}

		public virtual void OnCellGridChange(CFOIPDKEFMM GOAELFDHDGD)
		{
		}

		public virtual void OnCellItemExploded()
		{
		}

		public void SetWaitTurnEndToChangeState()
		{
			OMDOBBEDBAO = true;
		}

		public virtual void AddToExploders(HashSet<int> IAMPDPOIEOC)
		{
			NGKLFNCDIJM.UnionWith(IAMPDPOIEOC);
		}

		public virtual void OnCellItemCreated()
		{
			IsActive = false;
		}

		public virtual void OnReservedForCellItem(bool MJEJCGOLOPH)
		{
		}

		public abstract void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL);
	}
}
