using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Touches;
using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Items.SpecialItems
{
	public abstract class SpecialItem : SpriteBasedItem
	{
		[CompilerGenerated]
		private sealed class GLDDPDAGKBA
		{
			internal DGFHEKMMJHL GNDCEFPIMOP;

			internal Cell FCJLDGANJMG;

			internal SpecialItem PDAPIGLEPGC;

			internal void AGFNGEFDHLA(bool P_0, LLCJMMBBLEH P_1)
			{
				PDAPIGLEPGC.LBLDJHHJBBC = true;
				GNDCEFPIMOP.PBOMHJMKHBM(PDAPIGLEPGC.HDEDJKOHNIF);
				if (PDAPIGLEPGC.ELFBOKDHKGG != null)
				{
					PDAPIGLEPGC.ELFBOKDHKGG.KMEOMFGKMJC();
				}
				FallManager.DecreaseMechanicAnimation();
				if (PDAPIGLEPGC.MAGCMMBBHEB())
				{
					FCJLDGANJMG.AcceptsFallInside();
				}
			}
		}

		[HideInInspector]
		public bool CanNotJoinToCombo;

		private readonly EDOIFPONGPG LEIBJOHIMHM = new EDOIFPONGPG();

		[HideInInspector]
		public bool SpecialItemCanOnlyExplodeSelf;

		private Cell PHMFGGKPCCE;

		[HideInInspector]
		public bool ShouldRecycleInstantly = true;

		[HideInInspector]
		public SortingParticlePlayer CurrentComboHintParticle;

		private bool LBLDJHHJBBC;

		protected bool HDEDJKOHNIF;

		private CKKKELDIOLD KKCPOOALFAD;

		public override Cell ENCFFNKONOO
		{
			get
			{
				return base.ENCFFNKONOO;
			}
			set
			{
				base.ENCFFNKONOO = value;
				if (value != null)
				{
					PHMFGGKPCCE = value;
				}
			}
		}

		public virtual bool ShouldBlockFalls()
		{
			return true;
		}

		public override void OnSubItemCreated()
		{
			base.transform.localPosition = ENCFFNKONOO.GetFrozenLocalPosition();
		}

		protected virtual void OOCKFIDFIPL()
		{
		}

		protected virtual bool MAGCMMBBHEB()
		{
			return true;
		}

		public Tweener MoveToComboItem(Cell FIICENBDLDC)
		{
			BAIKFFOGMCB();
			return LEIBJOHIMHM.LGJBBEFGCFE(this, FIICENBDLDC);
		}

		public override void OnBeforeRemove()
		{
			if (CurrentComboHintParticle != null)
			{
				DisplayComboHint(false);
			}
			PHMFGGKPCCE = null;
			base.OnBeforeRemove();
			LEIBJOHIMHM.ELLCPFDBNDK();
		}

		public override void AfterPoolInit()
		{
			base.AfterPoolInit();
			RelativeContainer.transform.localScale = Vector3.one;
			PHMFGGKPCCE = null;
			CanNotJoinToCombo = false;
			SpecialItemCanOnlyExplodeSelf = false;
			LBLDJHHJBBC = false;
			HDEDJKOHNIF = false;
			CurrentSpriteRenderer.gameObject.SetActive(true);
			if (CanCastShadow())
			{
				GetShadowCaster().HideShadow();
			}
		}

		public void RecycleAutoExplodes()
		{
			ShouldRecycleInstantly = true;
			RemoveSelf();
		}

		protected bool ADCAOOPHFPK(Cell LBHDELJBONF, APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (LBHDELJBONF.Exists && ((LBHDELJBONF.EAILOFHFNJO && LBHDELJBONF.LBFCDKPCDPB.CanBeExplodedBySpecialItem()) || LBHDELJBONF.HasCellItem()))
			{
				IEKBFJBLGFM explodeDirection = ((!(PHMFGGKPCCE == null)) ? PHMFGGKPCCE.GetDirectionTo(LBHDELJBONF) : IEKBFJBLGFM.None);
				if (LBHDELJBONF.EAILOFHFNJO)
				{
					if (LBHDELJBONF.LBFCDKPCDPB.GetItemType() == NOALGNJECAD.Jelly)
					{
						HDEDJKOHNIF = true;
					}
					Item currentItem = LBHDELJBONF.LBFCDKPCDPB;
					currentItem.PreventRaiseScore();
					currentItem.SetExplodeDirection(explodeDirection);
				}
				if (LBHDELJBONF.HasCellItem())
				{
					LBHDELJBONF.FEMFMBLMKHP.PreventRaiseScore();
				}
				bool flag;
				if (CCPAJBOJDMN.ENBPGGCIADN == 10)
				{
					PBLOIKDOPAJ pBLOIKDOPAJ = PBLOIKDOPAJ.GHBGCADFLFB(LBHDELJBONF);
					flag = LBHDELJBONF.CurrentGrid.EJBPCMDJFEM(LBHDELJBONF, CCPAJBOJDMN, pBLOIKDOPAJ, new List<Cell>());
					ScoreManager.RaiseScore(pBLOIKDOPAJ.DJADMBLKBKJ);
				}
				else
				{
					flag = LBHDELJBONF.CurrentGrid.EJBPCMDJFEM(LBHDELJBONF, CCPAJBOJDMN);
				}
				if (!flag)
				{
					if (LBHDELJBONF.LBFCDKPCDPB != null)
					{
						LBHDELJBONF.LBFCDKPCDPB.IOFDFFBKCBF();
					}
					if (LBHDELJBONF.HasCellItem())
					{
						LBHDELJBONF.FEMFMBLMKHP.IOFDFFBKCBF();
					}
				}
				return flag;
			}
			LBHDELJBONF.ShakeBubble();
			return false;
		}

		protected abstract IEnumerator GIIEJHGNGJO();

		public virtual void PlaySpecialItemCreationAnimation()
		{
			CurrentSpriteRenderer.gameObject.SetActive(false);
			Sequence s = DOTween.Sequence();
			s.AppendInterval(0.3f);
			s.AppendCallback(delegate
			{
				CurrentSpriteRenderer.gameObject.SetActive(true);
				ParticlePool.Instance.PlayParticle(ParticlePool.Instance.SpecialItemCreationParticle, this);
			});
		}

		public IEnumerator StartAutoExplode(APBDPLNCDIJ CCPAJBOJDMN, Tweener HADMGKDPBGP = null)
		{
			ELFBOKDHKGG.ELEHIDCIDJN.PHCHCLEKBNA();
			TapListener.Instance.IncreaseBlockRequests();
			if (ShouldBlockFalls())
			{
				FallManager.IncreaseWaitingFallBlocker();
			}
			FallManager.IncreaseMechanicAnimation();
			if (HADMGKDPBGP != null)
			{
				yield return HADMGKDPBGP.WaitForCompletion();
			}
			OOCKFIDFIPL();
			if (base.gameObject != null && ENCFFNKONOO != null)
			{
				ADCAOOPHFPK(ENCFFNKONOO, CCPAJBOJDMN);
			}
			while (!LBLDJHHJBBC)
			{
				yield return null;
			}
			if (ELFBOKDHKGG != null)
			{
				ELFBOKDHKGG.ELEHIDCIDJN.PBOMHJMKHBM(HDEDJKOHNIF);
				ELFBOKDHKGG.KMEOMFGKMJC();
				TapListener.Instance.DecreaseBlockRequests();
				if (ShouldBlockFalls())
				{
					FallManager.DecreaseWaitingFallBlocker();
				}
				FallManager.DecreaseMechanicAnimation();
			}
		}

		public void DisplayComboHint(bool FPEAONMEHDC)
		{
			if (FPEAONMEHDC)
			{
				if (!(CurrentComboHintParticle != null) && !(ParticlePool.Instance == null))
				{
					CurrentComboHintParticle = ParticlePool.Instance.PlayParticle(ParticlePool.Instance.ComboHintParticle, this) as SortingParticlePlayer;
					CurrentComboHintParticle.transform.localScale = Vector3.one;
					if (ENCFFNKONOO != null)
					{
						ChangeSorting(PAFJGJOPLKB.LOPMMJANOFP(ENCFFNKONOO.Y));
					}
				}
			}
			else if (!(CurrentComboHintParticle == null))
			{
				CurrentComboHintParticle.SoftStop();
				CurrentComboHintParticle = null;
			}
		}

		public virtual void StartAnimations()
		{
		}

		public override void BringToFront()
		{
			KKCPOOALFAD = IPPOGIEPKEN.Collecting.EFLCPKAFOBA();
			CurrentSpriteRenderer.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
			CurrentSpriteRenderer.sortingOrder = 15000;
		}

		protected override void DEIFPMCEKCO()
		{
			base.DEIFPMCEKCO();
			if (!IsActive)
			{
				DisplayComboHint(false);
			}
		}

		public override void SendToBack()
		{
			DEIFPMCEKCO();
		}

		public override bool CanRaiseScore()
		{
			return false;
		}

		public override void StartExplode()
		{
			BAIKFFOGMCB();
			if (SpecialItemCanOnlyExplodeSelf)
			{
				SpecialItemExplodeSelf();
			}
		}

		public virtual void SpecialItemExplodeSelf()
		{
			Object.Destroy(base.gameObject);
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			if (CurrentComboHintParticle == null)
			{
				CurrentSpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
				CurrentSpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM;
			}
			else
			{
				CurrentComboHintParticle.Sort(IBBBMACIBGK.BHIJCAOHDCM + 150);
				CurrentSpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
				CurrentSpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + 152;
			}
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			if (!SpecialItemCanOnlyExplodeSelf)
			{
				Cell FCJLDGANJMG = ENCFFNKONOO;
				DGFHEKMMJHL GNDCEFPIMOP = ELFBOKDHKGG.ELEHIDCIDJN;
				GNDCEFPIMOP.PHCHCLEKBNA();
				if (MAGCMMBBHEB())
				{
					FCJLDGANJMG.RejectsFallInside();
				}
				FallManager.IncreaseMechanicAnimation();
				LLCJMMBBLEH lLCJMMBBLEH = new LLCJMMBBLEH(GIIEJHGNGJO());
				lLCJMMBBLEH.LDFKMBBIDMP += delegate
				{
					LBLDJHHJBBC = true;
					GNDCEFPIMOP.PBOMHJMKHBM(HDEDJKOHNIF);
					if (ELFBOKDHKGG != null)
					{
						ELFBOKDHKGG.KMEOMFGKMJC();
					}
					FallManager.DecreaseMechanicAnimation();
					if (MAGCMMBBHEB())
					{
						FCJLDGANJMG.AcceptsFallInside();
					}
				};
			}
			else
			{
				LBLDJHHJBBC = true;
			}
			DisplayComboHint(false);
			return true;
		}

		public override bool IsSpecialItem()
		{
			return true;
		}

		protected static int LPKIMIHHJCK(Item IPEHMGAILFA, Cell FMFABAKPMLB)
		{
			if (IPEHMGAILFA == null)
			{
				return 0;
			}
			return (!IPEHMGAILFA.IsSpecialItem()) ? (IPEHMGAILFA.GetScore() + FMFABAKPMLB.GetBubbleScoreIfPossible()) : 0;
		}

		public override int GetFireworksPriority()
		{
			return -1;
		}

		public override void OnCellItemCreated()
		{
			base.OnCellItemCreated();
			DisplayComboHint(false);
		}

		[CompilerGenerated]
		private void DLEDMGEDNIK()
		{
			CurrentSpriteRenderer.gameObject.SetActive(true);
			ParticlePool.Instance.PlayParticle(ParticlePool.Instance.SpecialItemCreationParticle, this);
		}
	}
}
