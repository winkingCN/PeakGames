using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.GamePlayScene.Mechanics.Items.Features;
using Assets.Scripts.GamePlayScene.Mechanics.Items.SpecialItems;
using DG.Tweening;
using GamePlayScene.Mechanics.Items.SpecialItems;
using UnityEngine;
using Utils;

namespace GamePlayScene.Mechanics.Items.ComboItems
{
	public abstract class DiscoBallComboItem : DiscoBallItem, PGCMDKBCMHI
	{
		protected int DLDOMGCNDLN;

		protected readonly List<SpecialItem> FGKEDOCEJFC = new List<SpecialItem>();

		private PBLOIKDOPAJ GBPKOHIHCJA;

		private bool BIELEFAPPBF;

		[CompilerGenerated]
		private static Comparison<SpecialItem> JANLDOMIIEF;

		protected abstract IEnumerator MHMBGIJDDBC();

		protected abstract SpecialItem LNLPNAGCDGG(CFOIPDKEFMM EHEOIMKGPEP, Cell FMFABAKPMLB, int AJJFIEKFLNB);

		public void SetComboGroup(PBLOIKDOPAJ FNEALCOPNND)
		{
			GBPKOHIHCJA = FNEALCOPNND;
		}

		public void AddScore(int AAIEJDNAODP)
		{
			DLDOMGCNDLN += AAIEJDNAODP;
		}

		public override bool CanRaiseScore()
		{
			return true;
		}

		public override bool CanFall()
		{
			return false;
		}

		protected override IEnumerator KCHOAGDIAHG(Cell FMFABAKPMLB, Item PLCFEOMGCFK, Tweener FHEMJANCDBM, ParticlePlayer HPHBDNBJPHB)
		{
			while (FHEMJANCDBM.IsActive() && FHEMJANCDBM.IsPlaying())
			{
				yield return null;
			}
			if (!FMFABAKPMLB.EAILOFHFNJO)
			{
				yield break;
			}
			Item currentItem = FMFABAKPMLB.LBFCDKPCDPB;
			SpecialItem specialItem = currentItem as SpecialItem;
			if (!(specialItem != null))
			{
				ELFBOKDHKGG.ACJOALJFMHN(currentItem.GetItemType(), false);
				ELFBOKDHKGG.DJNEAFJLFIH(currentItem.GetItemType());
				byte discoRayReservedType = currentItem.DiscoRayReservedType;
				if (NLMLKADGECN.GABGKBAKHDP.NODDCJJNJEC(currentItem.GetMatchType()))
				{
					currentItem.StartCollectToItem(FMFABAKPMLB);
				}
				SpecialItem specialItem2 = LNLPNAGCDGG(CLCHKLJBIFH, FMFABAKPMLB, discoRayReservedType);
				specialItem2.CurrentSpriteRenderer.enabled = false;
				specialItem2.CanNotJoinToCombo = true;
				specialItem2.ShouldRecycleInstantly = false;
				FMFABAKPMLB.LBFCDKPCDPB = specialItem2;
				FGKEDOCEJFC.Add(specialItem2);
				CanCastShadowComponent.CastShadowIfPossible(FMFABAKPMLB);
				currentItem.RemoveSelf();
				ParticlePool.Instance.PlayParticle(ParticlePool.Instance.RemainingMoveReplaceParticle, FMFABAKPMLB.GetFrozenPosition());
				specialItem2.CurrentSpriteRenderer.enabled = true;
				ParticlePlayer particlePlayer = ParticlePool.Instance.PlayParticle(ParticlePool.Instance.DiscoRayReachedParticle, FMFABAKPMLB.GetFrozenPosition() + DiscoBallItem.ALMIMDEKONF, false);
				particlePlayer.Play();
				while (!FLFHGKKDIBJ)
				{
					yield return null;
				}
				particlePlayer.MEJPNNFDEBD();
			}
		}

		private static int ACKCIIMOJLK(Item MNIMEAMHNMI, Item BCIHLCMFAEK)
		{
			if (MNIMEAMHNMI == null || BCIHLCMFAEK == null)
			{
				return 0;
			}
			Cell currentCell = MNIMEAMHNMI.ENCFFNKONOO;
			Cell currentCell2 = BCIHLCMFAEK.ENCFFNKONOO;
			if (currentCell == null || currentCell2 == null)
			{
				return 0;
			}
			return (currentCell2.Y - currentCell.Y) * 1000 - (currentCell2.X - currentCell.X);
		}

		protected override IEnumerator MLPCLFEBGLB(List<Cell> FKIKBBHFHKN)
		{
			PlayRandomSpineAnimations.ComboItemWillExplode = true;
			DLCFAHAKNHA();
			yield return new WaitForSeconds(0.7f);
			FGKEDOCEJFC.Sort(ACKCIIMOJLK);
			IEnumerator enumerator = MHMBGIJDDBC();
			while (enumerator.MoveNext())
			{
				yield return enumerator.Current;
			}
		}

		private void DLCFAHAKNHA()
		{
			foreach (Cell item in GBPKOHIHCJA.OABGDODKPKM)
			{
				item.AcceptsFallInside();
			}
		}

		protected void FNMKFIHMDCN(List<SpecialItem> FMMJCKEKJHO)
		{
			int i = 0;
			for (int count = FMMJCKEKJHO.Count; i < count; i++)
			{
				SpecialItem specialItem = FMMJCKEKJHO[i];
				if (specialItem != null)
				{
					specialItem.RecycleAutoExplodes();
				}
			}
		}

		protected override bool MAGCMMBBHEB()
		{
			return false;
		}

		public override bool ShouldBlockFalls()
		{
			return false;
		}

		public void OnDestroy()
		{
			BIELEFAPPBF = true;
		}

		public override void RemoveSelf()
		{
			OnBeforeRemove();
			if (!BIELEFAPPBF)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}

		protected override void MEOAOAGINGP()
		{
			if (ShouldBlockFalls())
			{
				FallManager.DecreaseWaitingFallBlocker();
			}
			if (!BIELEFAPPBF)
			{
				ScoreManager.RaiseScore(DJADMBLKBKJ + DLDOMGCNDLN);
				FallManager.DecreaseMechanicAnimation();
				RemoveSelf();
			}
		}
	}
}
