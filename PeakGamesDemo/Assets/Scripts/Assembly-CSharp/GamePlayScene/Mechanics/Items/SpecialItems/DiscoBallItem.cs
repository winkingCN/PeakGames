using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.GamePlayScene.Mechanics.Items.SpecialItems;
using Assets.Scripts.Utils;
using DG.Tweening;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items.SpecialItems
{
	public class DiscoBallItem : SpecialItem
	{
		public const byte ReserveTypeNone = 0;

		private const byte CJDEENFMPBL = 1;

		protected const byte GBBOCHKDMGF = 2;

		protected const byte BPNLLMMKBBP = 3;

		protected const byte AEPKFAIMIDC = 4;

		private static readonly NEEADKLBGMM NDJAFCDBIJN = new NEEADKLBGMM(302, 2f, 1.52f);

		private static readonly NEEADKLBGMM JGJEJFIOEBH = new NEEADKLBGMM(360, 1f, 1f);

		private static readonly NEEADKLBGMM FDMDIGGGFKF = new NEEADKLBGMM(149, 1.02f, 1.45f);

		private static readonly NEEADKLBGMM FMMHDFCHMLE = new NEEADKLBGMM(241, 1.02f, 1.03f);

		private static readonly NEEADKLBGMM MEKFBKDMNIO = new NEEADKLBGMM(40, 1f, 0.88f);

		private static readonly NEEADKLBGMM FANJACNHGIK = new NEEADKLBGMM(320, 1.26f, 1.6f);

		protected static readonly Vector3 ALMIMDEKONF = new Vector3(0.2f, -0.2f, 0f);

		private static readonly Vector3 OLJLCOEAMFM = new Vector3(0.15f, -0.2f, 0f);

		[HideInInspector]
		public LEDBLDKJBAI EffectiveItemType;

		public ParticleSystemRenderer[] ExplodeParticleRenderers;

		public GameObject UseParticle;

		public PeakFxColorChange AnimationSpriteColor;

		public PeakFxColorChange SpeedEffectColor;

		public Animator ExplodeAnimator;

		public SpriteRenderer ExplodeSpriteRenderer;

		public ParticleSystem StartAnimationParticle;

		public ParticleSystem StartExplodeParticle;

		protected bool FLFHGKKDIBJ;

		protected CFOIPDKEFMM CLCHKLJBIFH;

		protected int DJADMBLKBKJ;

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			base.ChangeSorting(IBBBMACIBGK);
			int sortingOrder = CurrentSpriteRenderer.sortingOrder;
			if (CurrentComboHintParticle != null)
			{
				CurrentComboHintParticle.Sort(sortingOrder - 1);
			}
		}

		public override void OnItemCreated(KFCEILFGADG MGOFDOMDLCO)
		{
			base.OnItemCreated(MGOFDOMDLCO);
			if (CanCastShadow() && GetShadowCaster() != null)
			{
				GetShadowCaster().HideShadow();
			}
		}

		public override void OnBeforeRemove()
		{
			base.OnBeforeRemove();
			if (StartAnimationParticle != null && StartAnimationParticle.isPlaying)
			{
				StartAnimationParticle.Stop();
			}
			if (StartExplodeParticle != null && StartExplodeParticle.isPlaying)
			{
				StartExplodeParticle.Stop();
			}
			CLCHKLJBIFH = null;
			if (ExplodeAnimator != null)
			{
				ExplodeAnimator.gameObject.SetActive(false);
			}
			if (UseParticle != null)
			{
				UseParticle.SetActive(false);
			}
		}

		public override void AfterPoolInit()
		{
			base.AfterPoolInit();
			FLFHGKKDIBJ = false;
			DJADMBLKBKJ = 0;
			CurrentSpriteRenderer.enabled = true;
			RelativeContainer.SetActive(true);
		}

		public override void RemoveSelf()
		{
			OnBeforeRemove();
			base.gameObject.MEJPNNFDEBD();
		}

		public override void SpecialItemExplodeSelf()
		{
			DiscoExplosionParticlePlayer discoExplosionParticlePlayer = ParticlePool.Instance.PlayParticle(ParticlePool.Instance.DiscoExplodeParticle, base.transform.position, false) as DiscoExplosionParticlePlayer;
			discoExplosionParticlePlayer.SetColor(EffectiveItemType);
			discoExplosionParticlePlayer.Play();
			base.SpecialItemExplodeSelf();
		}

		public void SetTintColor(LEDBLDKJBAI JOCKKMJBJLL)
		{
			NEEADKLBGMM nEEADKLBGMM;
			switch (JOCKKMJBJLL)
			{
			case LEDBLDKJBAI.Yellow:
				CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.DiscoBallSprites[0];
				nEEADKLBGMM = NDJAFCDBIJN;
				break;
			case LEDBLDKJBAI.Red:
				CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.DiscoBallSprites[1];
				nEEADKLBGMM = JGJEJFIOEBH;
				break;
			case LEDBLDKJBAI.Blue:
				CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.DiscoBallSprites[2];
				nEEADKLBGMM = FDMDIGGGFKF;
				break;
			case LEDBLDKJBAI.Green:
				CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.DiscoBallSprites[3];
				nEEADKLBGMM = FMMHDFCHMLE;
				break;
			case LEDBLDKJBAI.Purple:
				CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.DiscoBallSprites[4];
				nEEADKLBGMM = MEKFBKDMNIO;
				break;
			default:
				CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.DiscoBallSprites[5];
				nEEADKLBGMM = FANJACNHGIK;
				break;
			}
			if (AnimationSpriteColor != null)
			{
				AnimationSpriteColor.HueShift = nEEADKLBGMM.NKFABJFEJDC;
				AnimationSpriteColor.Saturation = nEEADKLBGMM.LODNPDJEBAM;
				AnimationSpriteColor.ValueBrightness = nEEADKLBGMM.OHCIOPOEIGE;
				AnimationSpriteColor.CallUpdate();
			}
			if (!(SpeedEffectColor == null))
			{
				SpeedEffectColor.HueShift = nEEADKLBGMM.NKFABJFEJDC;
				SpeedEffectColor.Saturation = 2f;
				SpeedEffectColor.ValueBrightness = 2f;
				SpeedEffectColor.CallUpdate();
			}
		}

		public override void PlaySpecialItemCreationAnimation()
		{
			Sequence s = DOTween.Sequence();
			s.AppendInterval(0.3f);
			s.AppendCallback(delegate
			{
				ParticlePool.Instance.PlayParticle(ParticlePool.Instance.SpecialItemCreationParticle, this);
			});
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.DiscoBall;
		}

		public override int GetScore()
		{
			return 1000;
		}

		public override bool CanCastShadow()
		{
			return true;
		}

		protected override IEnumerator GIIEJHGNGJO()
		{
			Vector3 frozenPosition = ENCFFNKONOO.GetFrozenPosition();
			List<ParticlePlayer> list = new List<ParticlePlayer>();
			List<Cell> list2 = new List<Cell>(20);
			CurrentSpriteRenderer.enabled = false;
			ExplodeAnimator.gameObject.SetActive(true);
			int num = CurrentSpriteRenderer.sortingOrder + 2000;
			ExplodeSpriteRenderer.sortingOrder = num;
			for (int i = 0; i < ExplodeParticleRenderers.Length; i++)
			{
				if (i == 1)
				{
					ExplodeParticleRenderers[i].sortingOrder = num + 1;
				}
				else
				{
					ExplodeParticleRenderers[i].sortingOrder = num - (i + 1);
				}
			}
			UseParticle.SetActive(true);
			StartAnimationParticle.Play();
			DJADMBLKBKJ = GetScore();
			ExplodeAnimator.SetBool("explode", true);
			CLCHKLJBIFH = ENCFFNKONOO.CurrentGrid;
			ChangeSorting(IPPOGIEPKEN.DiscoBallExplode.EFLCPKAFOBA());
			if (ShouldBlockFalls())
			{
				FallManager.IncreaseWaitingFallBlocker();
			}
			FallManager.IncreaseMechanicAnimation();
			MLEENDCDNNB(list2);
			list2.KFGEEKGAPDP(11);
			yield return MCJHHDACJBG.CNDGGNLKOOC;
			List<Cell> list3 = new List<Cell>();
			AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
			for (int j = 0; j < list2.Count; j++)
			{
				if (ParticlePool.Instance == null)
				{
					yield break;
				}
				Cell cell = list2[j];
				if (cell.EAILOFHFNJO && cell.LBFCDKPCDPB.transform.localPosition.y > (float)(CLCHKLJBIFH.FHAMOHDEGMK - 1))
				{
					list3.Add(cell);
				}
				else if (cell.HasCellItem() || cell.CGLFCDDLOKA)
				{
					if (cell.EAILOFHFNJO)
					{
						cell.LBFCDKPCDPB.DiscoRayReservedType = 0;
					}
					list2.Remove(cell);
					j--;
				}
				else
				{
					list.Add(JNDBJJNIGCC(cell, frozenPosition, audioSource));
					yield return new WaitForSeconds(0.05f);
				}
			}
			if (list3.Count > 0)
			{
				int k = 0;
				for (int count = list3.Count; k < count; k++)
				{
					Cell cell2 = list3[k];
					if (cell2.EAILOFHFNJO && cell2.LBFCDKPCDPB.transform.localPosition.y > (float)(CLCHKLJBIFH.FHAMOHDEGMK - 1))
					{
						cell2.LBFCDKPCDPB.DiscoRayReservedType = 0;
						list2.Remove(cell2);
					}
					else
					{
						list.Add(JNDBJJNIGCC(cell2, frozenPosition, audioSource));
						yield return new WaitForSeconds(0.05f);
					}
				}
			}
			yield return MCJHHDACJBG.CHFOIGLAMPN;
			StartExplodeParticle.Play();
			yield return new WaitForSeconds(0.65f);
			StartExplodeParticle.Stop();
			int l = 0;
			for (int count2 = list.Count; l < count2; l++)
			{
				ParticlePlayer particlePlayer = list[l];
				particlePlayer.HardStop();
			}
			FLFHGKKDIBJ = true;
			if (ParticlePool.Instance != null)
			{
				DiscoExplosionParticlePlayer discoExplosionParticlePlayer = ParticlePool.Instance.PlayParticle(ParticlePool.Instance.DiscoExplodeParticle, base.transform.position, false) as DiscoExplosionParticlePlayer;
				discoExplosionParticlePlayer.SetColor(EffectiveItemType);
				discoExplosionParticlePlayer.Play();
			}
			yield return null;
			audioSource.Stop();
			Object.Destroy(audioSource);
			AudioManager.Play(KOOGPFAPGGD.ItemSpecialDiscoExplode);
			RelativeContainer.SetActive(false);
			IEnumerator enumerator = MLPCLFEBGLB(list2);
			while (enumerator.MoveNext())
			{
				yield return enumerator.Current;
			}
			MEOAOAGINGP();
		}

		protected bool ECLAMDACKFJ(Cell LBHDELJBONF)
		{
			return !LBHDELJBONF.HasCellItem() && !LBHDELJBONF.CGLFCDDLOKA && LBHDELJBONF.EAILOFHFNJO && LBHDELJBONF.LBFCDKPCDPB.GetMatchType() == EffectiveItemType && !LBHDELJBONF.LMBJLCLEANK && LBHDELJBONF.LBFCDKPCDPB.JLHIKIHDEIE == 0;
		}

		protected virtual void MLEENDCDNNB(List<Cell> FKIKBBHFHKN)
		{
			foreach (Cell item in CLCHKLJBIFH.IOFOFDLJDAA())
			{
				if (ECLAMDACKFJ(item))
				{
					FKIKBBHFHKN.Add(item);
					item.LBFCDKPCDPB.DiscoRayReservedType = OCLEDFFKDGI();
				}
			}
		}

		private ParticlePlayer JNDBJJNIGCC(Cell LBHDELJBONF, Vector3 LDMDBPLADGD, AudioSource JNCFHKGILOI)
		{
			DiscoRayParticlePlayer discoRayParticlePlayer = ParticlePool.Instance.PlayParticle(ParticlePool.Instance.DiscoRayParticle, LDMDBPLADGD + ALMIMDEKONF, false) as DiscoRayParticlePlayer;
			discoRayParticlePlayer.SetColor(EffectiveItemType);
			LJEHKHFCPJO(discoRayParticlePlayer);
			AudioManager.Play(KOOGPFAPGGD.ItemSpecialDiscoRay, GCEAKOOGDJK.Multiple, JNCFHKGILOI);
			APKNIJBPIGG(LBHDELJBONF, discoRayParticlePlayer);
			return discoRayParticlePlayer;
		}

		protected virtual byte OCLEDFFKDGI()
		{
			return 1;
		}

		protected virtual void MEOAOAGINGP()
		{
			ScoreManager.RaiseScore(DJADMBLKBKJ);
			if (base.gameObject.activeSelf)
			{
				StartCoroutine(BGFBIJCNJIK());
			}
			else
			{
				RemoveSelf();
			}
		}

		protected virtual void LJEHKHFCPJO(DiscoRayParticlePlayer HPHBDNBJPHB)
		{
			HPHBDNBJPHB.Play();
		}

		private IEnumerator BGFBIJCNJIK()
		{
			yield return new WaitForSeconds(0.4f);
			if (ShouldBlockFalls())
			{
				FallManager.DecreaseWaitingFallBlocker();
			}
			FallManager.DecreaseMechanicAnimation();
			yield return new WaitForSeconds(2.6f);
			RemoveSelf();
		}

		protected virtual IEnumerator MLPCLFEBGLB(List<Cell> FKIKBBHFHKN)
		{
			APBDPLNCDIJ cCPAJBOJDMN = MLENMAIAOHJ.BDAKKAIBMIM(10);
			int num = ELFBOKDHKGG.ELEHIDCIDJN.GMCGMPEEHJP();
			foreach (Cell item in FKIKBBHFHKN)
			{
				Item currentItem = item.LBFCDKPCDPB;
				if (!item.HasCellItem() && !item.CGLFCDDLOKA)
				{
					if (ADCAOOPHFPK(item, cCPAJBOJDMN))
					{
						DJADMBLKBKJ += SpecialItem.LPKIMIHHJCK(currentItem, item);
					}
					else if (item.EAILOFHFNJO && item.LBFCDKPCDPB.CanGenerateScoreOnEachTryExplode() && item.LBFCDKPCDPB.CanGenerateScoreThisTurn())
					{
						DJADMBLKBKJ += currentItem.GetScore();
					}
				}
			}
			HDEDJKOHNIF = ELFBOKDHKGG.ELEHIDCIDJN.GMCGMPEEHJP() < num;
			yield return null;
		}

		private void APKNIJBPIGG(Cell LBHDELJBONF, ParticlePlayer HPHBDNBJPHB)
		{
			if (LBHDELJBONF.EAILOFHFNJO)
			{
				Item currentItem = LBHDELJBONF.LBFCDKPCDPB;
				new LLCJMMBBLEH(KCHOAGDIAHG(LBHDELJBONF, currentItem, HPHBDNBJPHB.transform.DOMove(LBHDELJBONF.LBFCDKPCDPB.transform.position + MCJHHDACJBG.EOOFFMFMDKL + OLJLCOEAMFM, 0.2f), HPHBDNBJPHB));
			}
		}

		protected virtual IEnumerator KCHOAGDIAHG(Cell FMFABAKPMLB, Item PLCFEOMGCFK, Tweener FHEMJANCDBM, ParticlePlayer HPHBDNBJPHB)
		{
			while (FHEMJANCDBM.IsActive() && FHEMJANCDBM.IsPlaying())
			{
				yield return null;
				if (LAEEFEJJGBC(FMFABAKPMLB, PLCFEOMGCFK, HPHBDNBJPHB))
				{
					yield break;
				}
			}
			if (!(ParticlePool.Instance == null))
			{
				ParticlePlayer particlePlayer = ParticlePool.Instance.PlayParticle(ParticlePool.Instance.DiscoRayReachedParticle, FMFABAKPMLB.GetFrozenPosition() + ALMIMDEKONF, false);
				particlePlayer.Play();
				Sequence sequence = DOTween.Sequence();
				sequence.Append(PLCFEOMGCFK.transform.DOLocalRotate(new Vector3(0f, 0f, 7f), 0.05f));
				sequence.Append(PLCFEOMGCFK.transform.DOLocalRotate(new Vector3(0f, 0f, -7f), 0.1f));
				sequence.Append(PLCFEOMGCFK.transform.DOLocalRotate(new Vector3(0f, 0f, 0f), 0.05f));
				sequence.SetLoops(-1);
				while (!FLFHGKKDIBJ && !LAEEFEJJGBC(FMFABAKPMLB, PLCFEOMGCFK, HPHBDNBJPHB))
				{
					yield return null;
				}
				if (PLCFEOMGCFK != null)
				{
					PLCFEOMGCFK.transform.rotation = Quaternion.identity;
				}
				sequence.Kill();
				particlePlayer.MEJPNNFDEBD();
			}
		}

		private static bool LAEEFEJJGBC(Cell LBHDELJBONF, Item EJCNAJOHBFI, ParticlePlayer ELLOILOPDJC)
		{
			bool flag = EJCNAJOHBFI == null;
			if (flag || EJCNAJOHBFI.ReCycled || LBHDELJBONF.HasCellItem() || LBHDELJBONF.CGLFCDDLOKA)
			{
				if (!flag)
				{
					EJCNAJOHBFI.DiscoRayReservedType = 0;
				}
				ELLOILOPDJC.HardStop();
				return true;
			}
			return false;
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = (short)(84 + EffectiveItemType);
		}

		[CompilerGenerated]
		private void DLEDMGEDNIK()
		{
			ParticlePool.Instance.PlayParticle(ParticlePool.Instance.SpecialItemCreationParticle, this);
		}
	}
}
