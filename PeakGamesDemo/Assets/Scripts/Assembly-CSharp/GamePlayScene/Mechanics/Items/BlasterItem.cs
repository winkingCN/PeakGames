using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.GamePlayScene.Touches;
using Assets.Scripts.Utils;
using DG.Tweening;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class BlasterItem : CollectorItem
	{
		[CompilerGenerated]
		private sealed class GNFMLOCJOLB
		{
			internal Cell FMFABAKPMLB;

			internal BlasterItem PDAPIGLEPGC;

			internal void AGFNGEFDHLA()
			{
				if (FMFABAKPMLB.HasCellItem())
				{
					FMFABAKPMLB.ExplodeCellItemWithBlaster(PDAPIGLEPGC.DOLOKFPJGEK);
				}
				if (FMFABAKPMLB.EAILOFHFNJO)
				{
					Item currentItem = FMFABAKPMLB.LBFCDKPCDPB;
					if (currentItem != null)
					{
						currentItem.PreventRaiseScore();
						PDAPIGLEPGC.DBFAMLNEIBM += currentItem.GetScore();
						CageItem cageItem = currentItem as CageItem;
						if (cageItem != null)
						{
							PDAPIGLEPGC.DBFAMLNEIBM += cageItem.AFAIKIMJLBP.GetScore();
						}
						currentItem.ExplodeByBlasterItem(PDAPIGLEPGC.CDIPLHPCHBL);
					}
				}
				if (FMFABAKPMLB.HasBubble)
				{
					FMFABAKPMLB.RemoveBubble();
				}
			}
		}

		public Transform BlasterTransform;

		public SpriteRenderer FillLayer;

		public ParticleSystem TrailParticles;

		public Animator CurrentAnimator;

		public SpriteRenderer ShadowSpriteRenderer;

		public SpriteRenderer FakeShadowSpriteRenderer;

		public ParticleSystem CollectParticle;

		public ParticleSystem CollectHitParticle;

		public Transform CollectTarget;

		public DefaultFakeItem FakeItem;

		public SpriteRenderer[] ColoredSpriteRenderers;

		public SpriteRenderer[] SpriteRenderers;

		private int JNKDBENJGFI;

		private int GMFKFCNPDKF;

		private int KEDBLADIMAH;

		private IEKBFJBLGFM GOOCMNFDKGH;

		private CKKKELDIOLD KKCPOOALFAD;

		private bool BPEPBOPHJJK;

		private float EDEONNLKCDF;

		private float IPHNJNJJONN = 0.07f;

		private List<Cell> JHHIAJBEMKN;

		private int EBAODFEGOEF;

		private int ABABLFMGHCC;

		private APBDPLNCDIJ DOLOKFPJGEK;

		private APBDPLNCDIJ CDIPLHPCHBL;

		private Vector3 CIMMHLNMGHG;

		private Sequence AKNFLCNFNDJ;

		private bool LNGMBIGHOJJ;

		private bool MKELAJLDJEF;

		private bool DPLFFKNCEPP;

		private const float HMEPDJFLOEC = 0.4f;

		private const float DLIHJDEGECE = 0.1f;

		private const float KACGOHDFNFN = 0.1f;

		private const float GIHOGCLJDKJ = 0.12f;

		private const float CECPDOKICKL = 0.4f;

		private int DBFAMLNEIBM;

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
					int num = ENCFFNKONOO.X;
					int num2 = ENCFFNKONOO.Y;
					switch (GOOCMNFDKGH)
					{
					case IEKBFJBLGFM.Up:
					case IEKBFJBLGFM.Down:
						num2++;
						break;
					case IEKBFJBLGFM.Left:
					case IEKBFJBLGFM.Right:
						num++;
						break;
					}
					FakeItem.ENCFFNKONOO = ENCFFNKONOO.CurrentGrid.ECNCPJGHBIG(num, num2);
				}
				else
				{
					FakeItem.ENCFFNKONOO = null;
				}
			}
		}

		private void Start()
		{
			EBAODFEGOEF = Animator.StringToHash("Base Layer.BlasterCollectAnimation");
			ABABLFMGHCC = Animator.StringToHash("Base Layer.BlasterLaunchAnimation");
		}

		public override void BringToFront()
		{
			CKKKELDIOLD sorting = GetSorting();
			sorting.BHIJCAOHDCM += 3000;
			ChangeSorting(sorting);
		}

		public void Prepare(IEKBFJBLGFM AJLDJAHHGOJ, int MDPEMCMPAMB, int CMAJLIAELDP, LEDBLDKJBAI JOCKKMJBJLL)
		{
			JNKDBENJGFI = MDPEMCMPAMB;
			base.BHIJCAOHDCM = CMAJLIAELDP;
			base.BPLHOCDDLCG = JOCKKMJBJLL;
			GOOCMNFDKGH = AJLDJAHHGOJ;
			Quaternion identity = Quaternion.identity;
			Vector3 vector = default(Vector3);
			float num = 1f;
			Vector3 localPosition = Vector3.zero;
			Vector3 localPosition2;
			switch (AJLDJAHHGOJ)
			{
			case IEKBFJBLGFM.Up:
				identity.eulerAngles = Vector3.zero;
				vector = new Vector3(0f, 0.5f);
				localPosition2 = new Vector3(0f, -0.463f);
				break;
			case IEKBFJBLGFM.Down:
				identity.eulerAngles = new Vector3(0f, 0f, 180f);
				vector = new Vector3(0f, 0.5f);
				localPosition2 = new Vector3(0f, -0.463f);
				break;
			case IEKBFJBLGFM.Left:
				identity.eulerAngles = new Vector3(0f, 0f, 90f);
				vector = new Vector3(0.5f, 0f);
				localPosition2 = new Vector3(0.135f, -0.425f);
				localPosition = new Vector3(0.8f, -0.5f);
				num = 1.2f;
				break;
			case IEKBFJBLGFM.Right:
				identity.eulerAngles = new Vector3(0f, 0f, 270f);
				vector = new Vector3(0.5f, 0f);
				localPosition2 = new Vector3(0f, -0.425f);
				localPosition = new Vector3(1f, -0.5f);
				num = 1.2f;
				break;
			default:
				throw new ArgumentOutOfRangeException("direction", AJLDJAHHGOJ, null);
			}
			ShadowSpriteRenderer.transform.localPosition = localPosition2;
			ShadowSpriteRenderer.transform.localScale = Vector3.one * num;
			FakeShadowSpriteRenderer.transform.localPosition = localPosition;
			FakeShadowSpriteRenderer.transform.localScale = Vector3.one * num;
			BlasterTransform.localRotation = identity;
			BlasterTransform.localPosition = vector;
			MMBPLACOIHK(base.BPLHOCDDLCG);
			FDLMOGCCLFJ();
			CollectorId = NLMLKADGECN.GABGKBAKHDP.BPHMPBKJJOO().HNCEPKJKAMC(this);
			if (JHHIAJBEMKN == null)
			{
				JHHIAJBEMKN = new List<Cell>();
			}
		}

		private void MMBPLACOIHK(LEDBLDKJBAI JOCKKMJBJLL)
		{
			Sprite[] array = null;
			switch (JOCKKMJBJLL)
			{
			case LEDBLDKJBAI.Yellow:
				FillLayer.color = new Color(0.8901961f, 0.77254903f, 0.18039216f);
				array = SharedImageLibrary.Instance.BlasterSpritesYellow;
				break;
			case LEDBLDKJBAI.Red:
				FillLayer.color = new Color(0.9843137f, 5f / 51f, 14f / 85f);
				array = SharedImageLibrary.Instance.BlasterSpritesRed;
				break;
			case LEDBLDKJBAI.Blue:
				FillLayer.color = new Color(0.18039216f, 47f / 85f, 0.8392157f);
				array = SharedImageLibrary.Instance.BlasterSpritesBlue;
				break;
			case LEDBLDKJBAI.Green:
				FillLayer.color = new Color(0.29411766f, 0.76862746f, 13f / 85f);
				array = SharedImageLibrary.Instance.BlasterSpritesGreen;
				break;
			case LEDBLDKJBAI.Purple:
				FillLayer.color = new Color(0.69803923f, 2f / 15f, 11f / 15f);
				array = SharedImageLibrary.Instance.BlasterSpritesPurple;
				break;
			default:
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.BlasterItem, "Error Changing color. Match type:{0} is not valid", JOCKKMJBJLL);
				break;
			}
			ColoredSpriteRenderers[0].sprite = array[0];
			ColoredSpriteRenderers[1].sprite = array[1];
			ColoredSpriteRenderers[2].sprite = array[2];
		}

		public override void StartCollectingItem()
		{
			KEDBLADIMAH++;
			if (KEDBLADIMAH == 1)
			{
				MKELAJLDJEF = true;
			}
			CurrentAnimator.SetBool("CollectCompleted", false);
			if (!LNGMBIGHOJJ && KEDBLADIMAH + GMFKFCNPDKF >= JNKDBENJGFI)
			{
				LNGMBIGHOJJ = true;
				TapListener.Instance.IncreaseBlockRequests();
				NLMLKADGECN.GABGKBAKHDP.BPHMPBKJJOO().JLJGBGFPKKC(CollectorId);
			}
		}

		public void PlayCollectParticle()
		{
			CollectParticle.Play();
		}

		public override void OnItemCollectCompleted()
		{
			if (this == null)
			{
				return;
			}
			GMFKFCNPDKF++;
			KEDBLADIMAH--;
			if (MKELAJLDJEF)
			{
				CollectHitParticle.Play();
				MKELAJLDJEF = false;
				if (ItemResourcesManager.GABGKBAKHDP != null)
				{
					AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[0]);
				}
			}
			int fullPathHash = CurrentAnimator.GetCurrentAnimatorStateInfo(0).fullPathHash;
			if (KEDBLADIMAH == 0)
			{
				CurrentAnimator.SetBool("CollectCompleted", true);
				if (EBAODFEGOEF != fullPathHash)
				{
					CurrentAnimator.Play(EBAODFEGOEF);
				}
				CAOAIAOGKOA();
			}
			else
			{
				CurrentAnimator.Play(EBAODFEGOEF);
			}
			if (KEDBLADIMAH == 0 && JNKDBENJGFI - GMFKFCNPDKF <= 0)
			{
				NLMLKADGECN.GABGKBAKHDP.BPHMPBKJJOO().HLFFHLAOIAJ(this);
			}
		}

		private void FDLMOGCCLFJ()
		{
			FillLayer.transform.localPosition = new Vector3(0f, -0.314f);
			FillLayer.transform.localScale = new Vector3(0.26f, 0f);
		}

		private void CAOAIAOGKOA()
		{
			if (AKNFLCNFNDJ != null)
			{
				AKNFLCNFNDJ.Kill();
			}
			float a = (float)GMFKFCNPDKF / (float)JNKDBENJGFI;
			float num = ((GMFKFCNPDKF < JNKDBENJGFI) ? 0.28f : 0.314f);
			float num2 = Mathf.Min(a, 1f);
			float atPosition = 0.2f;
			AKNFLCNFNDJ = DOTween.Sequence();
			Tweener tweener = FillLayer.transform.DOLocalMoveY(-0.314f + num * num2, 0.6f).SetEase(Ease.OutBounce);
			tweener.easeOvershootOrAmplitude = 2f;
			AKNFLCNFNDJ.Insert(atPosition, tweener);
			Tweener tweener2 = FillLayer.transform.DOScaleY(0.65f * num2, 0.6f).SetEase(Ease.OutBounce);
			tweener2.easeOvershootOrAmplitude = 2f;
			AKNFLCNFNDJ.Insert(atPosition, tweener2);
			AKNFLCNFNDJ.OnComplete(delegate
			{
				if (KEDBLADIMAH == 0 && JNKDBENJGFI - GMFKFCNPDKF <= 0 && !DPLFFKNCEPP)
				{
					DPLFFKNCEPP = true;
					StartCoroutine(NILNNEMMMLC());
				}
			});
		}

		public override bool IsAvailable()
		{
			return JNKDBENJGFI - (GMFKFCNPDKF + KEDBLADIMAH) > 0;
		}

		private IEnumerator NILNNEMMMLC()
		{
			while (FallManager.AreThereActiveAnimations() || FallManager.AreFallsBlocked() || NLMLKADGECN.GABGKBAKHDP.BPHMPBKJJOO().MAKEJBOJNOL != CollectorId)
			{
				yield return null;
			}
			CIMMHLNMGHG = base.transform.position;
			HintManager.Instance.IncreaseShuffleBlocker();
			TapListener.Instance.DecreaseBlockRequests();
			FallManager.IncreaseMechanicAnimation();
			FallManager.IncreaseWaitingFallBlocker();
			BringToFront();
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[1]);
			}
			if (ParticlePool.Instance != null)
			{
				if (GOOCMNFDKGH == IEKBFJBLGFM.Down || GOOCMNFDKGH == IEKBFJBLGFM.Up)
				{
					ParticlePlayer particlePlayer = ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[1], CIMMHLNMGHG);
					Vector3 cIMMHLNMGHG = CIMMHLNMGHG;
					if (GOOCMNFDKGH == IEKBFJBLGFM.Down)
					{
						cIMMHLNMGHG.y += 1.5f;
					}
					else
					{
						cIMMHLNMGHG.y -= 0.5f;
					}
					particlePlayer.transform.position = cIMMHLNMGHG;
				}
				else
				{
					ParticlePlayer particlePlayer2 = ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[0], CIMMHLNMGHG);
					Vector3 cIMMHLNMGHG2 = CIMMHLNMGHG;
					if (GOOCMNFDKGH == IEKBFJBLGFM.Left)
					{
						cIMMHLNMGHG2.x += 1.5f;
					}
					else
					{
						cIMMHLNMGHG2.x -= 0.5f;
					}
					particlePlayer2.transform.position = cIMMHLNMGHG2;
				}
			}
			CurrentAnimator.Play(ABABLFMGHCC, 0, 0f);
			TrailParticles.gameObject.SetActive(true);
			TrailParticles.Play();
			yield return new WaitForSeconds(0.12f);
			ShakeAnimation[] panelShakeAnimations = ELFBOKDHKGG.GIMBEKBFKMJ.PanelShakeAnimations;
			for (int i = 0; i < panelShakeAnimations.Length; i++)
			{
				panelShakeAnimations[i].Shake(0.4f, 0.1f, 0.1f);
			}
			yield return new WaitForSeconds(0.4f);
			DOLOKFPJGEK = MLENMAIAOHJ.BDAKKAIBMIM(17);
			CDIPLHPCHBL = MLENMAIAOHJ.BDAKKAIBMIM(17);
			GAKMAOKHMLF();
			while (!BPEPBOPHJJK)
			{
				yield return null;
			}
			DLCFAHAKNHA();
			FallManager.DecreaseMechanicAnimation();
			FallManager.DecreaseWaitingFallBlocker();
			HintManager.Instance.DecreaseShuffleBlocker();
			NLMLKADGECN.GABGKBAKHDP.BPHMPBKJJOO().GAHKKABDHGD();
			yield return new WaitForSeconds(2f);
			TrailParticles.Stop();
			RemoveSelf();
		}

		private void DLCFAHAKNHA()
		{
			ScoreManager.RaiseScore(DBFAMLNEIBM);
			for (int i = 0; i < JHHIAJBEMKN.Count; i++)
			{
				JHHIAJBEMKN[i].AcceptsFallInside();
			}
			JHHIAJBEMKN.Clear();
		}

		public override void RemoveSelf()
		{
			OnBeforeRemove();
			JHHIAJBEMKN.Clear();
			base.gameObject.MEJPNNFDEBD();
		}

		private void GAKMAOKHMLF()
		{
			JHHIAJBEMKN.Clear();
			switch (GOOCMNFDKGH)
			{
			case IEKBFJBLGFM.Down:
				EEDKNGMCKFD();
				break;
			case IEKBFJBLGFM.Up:
				BJDBMGAJCMC();
				break;
			case IEKBFJBLGFM.Left:
				KAKBOBKKMOK();
				break;
			case IEKBFJBLGFM.Right:
				JBNOLPBGPNP();
				break;
			case IEKBFJBLGFM.LeftUp:
			case IEKBFJBLGFM.LeftDown:
			case IEKBFJBLGFM.RightUp:
				break;
			}
		}

		private void CHIPOHEMKEG()
		{
			JHHIAJBEMKN.Add(ENCFFNKONOO);
			JHHIAJBEMKN.Add(FakeItem.ENCFFNKONOO);
			ENCFFNKONOO.RejectsFallInside();
			FakeItem.ENCFFNKONOO = null;
			ENCFFNKONOO = null;
		}

		private void JBNOLPBGPNP()
		{
			if (!(ENCFFNKONOO == null))
			{
				Sequence sequence = DOTween.Sequence();
				sequence.SetEase(Ease.Linear);
				int num = ENCFFNKONOO.X;
				CFOIPDKEFMM jHDMFHDHIFN = ELFBOKDHKGG.JHDMFHDHIFN;
				Cell cell = jHDMFHDHIFN.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Right);
				sequence.Append(base.transform.DOLocalMoveX((float)num + EDEONNLKCDF, IPHNJNJJONN * EDEONNLKCDF).SetEase(Ease.Linear));
				while (num < 9)
				{
					num++;
					cell = jHDMFHDHIFN.PHOOMEOBJCB(cell, IEKBFJBLGFM.Right);
					EJBPCMDJFEM(cell, sequence);
					sequence.Append(base.transform.DOLocalMoveX((float)num + EDEONNLKCDF, IPHNJNJJONN).SetEase(Ease.Linear));
				}
				sequence.AppendCallback(delegate
				{
					BPEPBOPHJJK = true;
				});
				float num2 = (float)(15 - num) - EDEONNLKCDF;
				sequence.Append(base.transform.DOLocalMoveX(15f, IPHNJNJJONN * num2).SetEase(Ease.Linear));
				CHIPOHEMKEG();
			}
		}

		private void KAKBOBKKMOK()
		{
			if (!(ENCFFNKONOO == null))
			{
				Sequence sequence = DOTween.Sequence();
				sequence.SetEase(Ease.Linear);
				int num = ENCFFNKONOO.X;
				CFOIPDKEFMM jHDMFHDHIFN = ELFBOKDHKGG.JHDMFHDHIFN;
				Cell cell = ENCFFNKONOO;
				sequence.Append(base.transform.DOLocalMoveX((float)num - EDEONNLKCDF, IPHNJNJJONN * EDEONNLKCDF).SetEase(Ease.Linear));
				while (num >= 0)
				{
					num--;
					cell = jHDMFHDHIFN.PHOOMEOBJCB(cell, IEKBFJBLGFM.Left);
					EJBPCMDJFEM(cell, sequence);
					sequence.Append(base.transform.DOLocalMoveX((float)num - EDEONNLKCDF, IPHNJNJJONN).SetEase(Ease.Linear));
				}
				sequence.AppendCallback(delegate
				{
					BPEPBOPHJJK = true;
				});
				float num2 = (float)(15 - num) - EDEONNLKCDF;
				sequence.Append(base.transform.DOLocalMoveX(-15f, IPHNJNJJONN * num2).SetEase(Ease.Linear));
				CHIPOHEMKEG();
			}
		}

		private void BJDBMGAJCMC()
		{
			if (!(ENCFFNKONOO == null))
			{
				Sequence sequence = DOTween.Sequence();
				sequence.SetEase(Ease.Linear);
				int num = ENCFFNKONOO.Y;
				CFOIPDKEFMM jHDMFHDHIFN = ELFBOKDHKGG.JHDMFHDHIFN;
				Cell cell = jHDMFHDHIFN.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Up);
				sequence.Append(base.transform.DOLocalMoveY((float)num + EDEONNLKCDF, IPHNJNJJONN * EDEONNLKCDF).SetEase(Ease.Linear));
				while (num < 9)
				{
					num++;
					cell = jHDMFHDHIFN.PHOOMEOBJCB(cell, IEKBFJBLGFM.Up);
					EJBPCMDJFEM(cell, sequence);
					sequence.Append(base.transform.DOLocalMoveY((float)num + EDEONNLKCDF, IPHNJNJJONN).SetEase(Ease.Linear));
				}
				sequence.AppendCallback(delegate
				{
					BPEPBOPHJJK = true;
				});
				float num2 = (float)(15 - num) - EDEONNLKCDF;
				sequence.Append(base.transform.DOLocalMoveY(15f, IPHNJNJJONN * num2).SetEase(Ease.Linear));
				CHIPOHEMKEG();
			}
		}

		private void EEDKNGMCKFD()
		{
			if (!(ENCFFNKONOO == null))
			{
				Sequence sequence = DOTween.Sequence();
				sequence.SetEase(Ease.Linear);
				int num = ENCFFNKONOO.Y;
				CFOIPDKEFMM jHDMFHDHIFN = ELFBOKDHKGG.JHDMFHDHIFN;
				Cell cell = ENCFFNKONOO;
				sequence.Append(base.transform.DOLocalMoveY((float)num - EDEONNLKCDF, IPHNJNJJONN * EDEONNLKCDF).SetEase(Ease.Linear));
				while (num >= 0)
				{
					num--;
					cell = jHDMFHDHIFN.PHOOMEOBJCB(cell, IEKBFJBLGFM.Down);
					EJBPCMDJFEM(cell, sequence);
					sequence.Append(base.transform.DOLocalMoveY((float)num - EDEONNLKCDF, IPHNJNJJONN).SetEase(Ease.Linear));
				}
				sequence.AppendCallback(delegate
				{
					BPEPBOPHJJK = true;
				});
				float num2 = (float)(15 - num) - EDEONNLKCDF;
				sequence.Append(base.transform.DOLocalMoveY(-15f, IPHNJNJJONN * num2).SetEase(Ease.Linear));
				CHIPOHEMKEG();
			}
		}

		private void EJBPCMDJFEM(Cell FMFABAKPMLB, Sequence MIABODPHOIP)
		{
			if (!(FMFABAKPMLB != null) || !FMFABAKPMLB.Exists)
			{
				return;
			}
			FMFABAKPMLB.RejectsFallInside();
			JHHIAJBEMKN.Add(FMFABAKPMLB);
			MIABODPHOIP.AppendCallback(delegate
			{
				if (FMFABAKPMLB.HasCellItem())
				{
					FMFABAKPMLB.ExplodeCellItemWithBlaster(DOLOKFPJGEK);
				}
				if (FMFABAKPMLB.EAILOFHFNJO)
				{
					Item currentItem = FMFABAKPMLB.LBFCDKPCDPB;
					if (currentItem != null)
					{
						currentItem.PreventRaiseScore();
						DBFAMLNEIBM += currentItem.GetScore();
						CageItem cageItem = currentItem as CageItem;
						if (cageItem != null)
						{
							DBFAMLNEIBM += cageItem.AFAIKIMJLBP.GetScore();
						}
						currentItem.ExplodeByBlasterItem(CDIPLHPCHBL);
					}
				}
				if (FMFABAKPMLB.HasBubble)
				{
					FMFABAKPMLB.RemoveBubble();
				}
			});
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Blaster;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			KKCPOOALFAD = IBBBMACIBGK;
			for (int i = 0; i < SpriteRenderers.Length; i++)
			{
				SpriteRenderer spriteRenderer = SpriteRenderers[i];
				if (!(spriteRenderer == null))
				{
					spriteRenderer.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
					spriteRenderer.sortingOrder = KKCPOOALFAD.BHIJCAOHDCM + 200 + i;
				}
			}
		}

		public override CKKKELDIOLD GetSorting()
		{
			return KKCPOOALFAD;
		}

		public override bool CanFall()
		{
			return false;
		}

		public override bool CanBeExplodedBySpecialItem()
		{
			return false;
		}

		public override bool CanBeExplodedByBooster()
		{
			return false;
		}

		public override bool BoosterAnvilCanBeUsed()
		{
			return true;
		}

		public override bool BoosterBoxingGloveCanBeUsed()
		{
			return true;
		}

		public override bool BoosterHammerCanBeUsed()
		{
			return false;
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
		}

		public override bool CanCastShadow()
		{
			return true;
		}

		public override int GetScore()
		{
			return 0;
		}

		public override bool CanBeInsideBubble()
		{
			return false;
		}

		public override bool CanBeInsideCellItem()
		{
			return false;
		}

		public override int GetFireworksPriority()
		{
			return -1;
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			int num = 0;
			switch (base.BPLHOCDDLCG)
			{
			case LEDBLDKJBAI.Yellow:
				num = 171;
				break;
			case LEDBLDKJBAI.Red:
				num = 175;
				break;
			case LEDBLDKJBAI.Blue:
				num = 201;
				break;
			case LEDBLDKJBAI.Green:
				num = 205;
				break;
			case LEDBLDKJBAI.Purple:
				num = 209;
				break;
			}
			switch (GOOCMNFDKGH)
			{
			case IEKBFJBLGFM.Down:
				num++;
				break;
			case IEKBFJBLGFM.Up:
				num = num;
				break;
			case IEKBFJBLGFM.Left:
				num += 2;
				break;
			case IEKBFJBLGFM.Right:
				num -= 18;
				break;
			}
			PNINCDLIDLL.EEFMIHDPJPG = (short)num;
			byte aINNOPBDDGL = (byte)(GMFKFCNPDKF + KEDBLADIMAH);
			PNINCDLIDLL.DKJDLMNKFGM(aINNOPBDDGL);
		}

		protected void BBHEILEOPCD(int ENMLICFLHAO)
		{
			GMFKFCNPDKF = ENMLICFLHAO;
		}

		protected int DGMKLFOOCIK()
		{
			return JNKDBENJGFI;
		}

		[CompilerGenerated]
		private void FCAAMNBFBIP()
		{
			if (KEDBLADIMAH == 0 && JNKDBENJGFI - GMFKFCNPDKF <= 0 && !DPLFFKNCEPP)
			{
				DPLFFKNCEPP = true;
				StartCoroutine(NILNNEMMMLC());
			}
		}

		[CompilerGenerated]
		private void OMDFPALPIKO()
		{
			BPEPBOPHJJK = true;
		}

		[CompilerGenerated]
		private void CDOAPHNBMDF()
		{
			BPEPBOPHJJK = true;
		}

		[CompilerGenerated]
		private void OFIKGIJCEKO()
		{
			BPEPBOPHJJK = true;
		}

		[CompilerGenerated]
		private void KMLCOFEJGCK()
		{
			BPEPBOPHJJK = true;
		}
	}
}
