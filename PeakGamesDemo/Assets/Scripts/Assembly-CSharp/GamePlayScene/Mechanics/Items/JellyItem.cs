using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class JellyItem : SpriteBasedItem
	{
		private GameObject PLNMIDBADLI;

		private JellyItem JALLALCMJLG;

		public Transform JellyAnimationOwner;

		private JellyAnimatorWaiter FPCAGAELAPJ;

		private bool KHBBECMIOHG;

		private bool BIELEFAPPBF;

		private JellyItem LFPAHBGNIBO;

		public JellyItem SpreadedBy;

		public override int GetScore()
		{
			return 500;
		}

		public override void PlayExplodeAudio()
		{
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[1]);
			}
		}

		public void PlayJellySpread(Cell HNLGJMONNCM)
		{
			if (KHBBECMIOHG || BIELEFAPPBF || HNLGJMONNCM == null)
			{
				return;
			}
			ItemResources itemResources = null;
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				itemResources = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType());
			}
			if (itemResources != null)
			{
				AudioManager.PlayAudioProps(itemResources.AudioClips[0]);
			}
			FPCAGAELAPJ = itemResources.Animators[0].JOBDHIPIMAG(JellyAnimationOwner.position).GetComponent<JellyAnimatorWaiter>();
			FPCAGAELAPJ.MasterJelly = this;
			int num = 0;
			ParticlePlayer hFGBGLIHEOL = itemResources.Particles[2];
			if (HNLGJMONNCM.Y == ENCFFNKONOO.Y)
			{
				num = ((HNLGJMONNCM.X < ENCFFNKONOO.X) ? 1 : 3);
				FPCAGAELAPJ.DisplaySortNo = CurrentSpriteRenderer.sortingOrder + 5;
			}
			else if (HNLGJMONNCM.X == ENCFFNKONOO.X)
			{
				if (HNLGJMONNCM.Y < ENCFFNKONOO.Y)
				{
					num = 4;
					hFGBGLIHEOL = itemResources.Particles[1];
					FPCAGAELAPJ.DisplaySortNo = CurrentSpriteRenderer.sortingOrder - 1;
				}
				else
				{
					num = 2;
					hFGBGLIHEOL = itemResources.Particles[0];
					FPCAGAELAPJ.DisplaySortNo = CurrentSpriteRenderer.sortingOrder + 105;
				}
			}
			FPCAGAELAPJ.HideIt();
			if (num == 0)
			{
				FPCAGAELAPJ.MasterJelly = null;
				FPCAGAELAPJ.gameObject.MEJPNNFDEBD();
				return;
			}
			KHBBECMIOHG = true;
			FPCAGAELAPJ.SpreadAnimator.SetInteger("DIRECTION", num);
			if (HNLGJMONNCM.EAILOFHFNJO)
			{
				Item currentItem = HNLGJMONNCM.LBFCDKPCDPB;
				currentItem.ENCFFNKONOO = null;
				PLNMIDBADLI = currentItem.gameObject;
			}
			LFPAHBGNIBO = ELFBOKDHKGG.GIMBEKBFKMJ.CreateItem(new DNJKLNPHPOF(NOALGNJECAD.Jelly, ALIFCLNJKPH.Jelly)) as JellyItem;
			LFPAHBGNIBO.transform.position = HNLGJMONNCM.transform.position;
			LFPAHBGNIBO.ENCFFNKONOO = HNLGJMONNCM;
			LFPAHBGNIBO.RelativeContainer.SetActive(false);
			LFPAHBGNIBO.SpreadedBy = this;
			ParticlePlayer particlePlayer = ParticlePool.Instance.PlayParticle(hFGBGLIHEOL, LFPAHBGNIBO.transform.position, false);
			particlePlayer.transform.localScale = ((num != 3) ? Vector3.one : new Vector3(-1f, 1f, 1f));
			particlePlayer.Play();
			JALLALCMJLG = LFPAHBGNIBO;
		}

		public override bool CanShadowDrop()
		{
			return true;
		}

		public void AnimationEnded()
		{
			if (LFPAHBGNIBO != null)
			{
				LFPAHBGNIBO.SpreadedBy = null;
				if (LFPAHBGNIBO.ENCFFNKONOO != null)
				{
					LFPAHBGNIBO.transform.position = LFPAHBGNIBO.ENCFFNKONOO.transform.position;
				}
			}
			if (FPCAGAELAPJ != null)
			{
				FPCAGAELAPJ.SpreadAnimator.SetInteger("DIRECTION", 5);
				FPCAGAELAPJ.MasterJelly = null;
				FPCAGAELAPJ.HideIt();
				FPCAGAELAPJ.gameObject.MEJPNNFDEBD();
			}
			if (PLNMIDBADLI != null)
			{
				PLNMIDBADLI.GetComponent<Item>().RemoveSelf();
			}
			if (JALLALCMJLG != null)
			{
				JALLALCMJLG.RelativeContainer.SetActive(true);
			}
			JALLALCMJLG = null;
			PLNMIDBADLI = null;
			FPCAGAELAPJ = null;
			KHBBECMIOHG = false;
		}

		public override void OnItemCreated(KFCEILFGADG MGOFDOMDLCO)
		{
			base.OnItemCreated(MGOFDOMDLCO);
			ELFBOKDHKGG.ELEHIDCIDJN.JEACJNAKLDJ(this);
		}

		public override void OnBeforeRemove()
		{
			if (SpreadedBy != null)
			{
				SpreadedBy.AnimationEnded();
			}
			AnimationEnded();
			base.OnBeforeRemove();
			ELFBOKDHKGG.ELEHIDCIDJN.CJOHLENDJGO(this);
			BIELEFAPPBF = true;
		}

		public override void AfterPoolInit()
		{
			base.AfterPoolInit();
			BIELEFAPPBF = false;
		}

		public override void ReactToUpperFall()
		{
			FallListener fallListener = MHILDHNALNO();
			fallListener.EndFall(-1f);
		}

		protected override void EJCFANPAMMK()
		{
			if (ParticlePool.Instance != null)
			{
				ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[3], base.transform.position);
			}
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return true;
		}

		public override bool CanFall()
		{
			return false;
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			bool flag = base.TryExplode(CCPAJBOJDMN);
			if (flag)
			{
				ELFBOKDHKGG.ELEHIDCIDJN.EAOOHODGKJO();
			}
			return flag;
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Jelly;
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 123;
		}
	}
}
