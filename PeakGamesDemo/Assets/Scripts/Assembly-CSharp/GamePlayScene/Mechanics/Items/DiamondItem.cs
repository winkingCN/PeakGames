using System.Collections;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class DiamondItem : SpriteBasedItem, JFIEHOCCBNG
	{
		public Animator CurrentAnimator;

		public SpriteRenderer OpenSpriteRenderer;

		public SpriteRenderer DiamondSpriteRenderer;

		public SpriteRenderer DoorSpriteRenderer;

		public SpriteRenderer DoorSpriteRenderer1;

		public SpriteRenderer DoorSpriteRenderer2;

		private bool JIFDJLDKMBO;

		private bool PIGCJDKPMFL;

		private int JAOLDOFHIDL;

		private int OIEJJCNBEFN;

		private void Awake()
		{
			JAOLDOFHIDL = Animator.StringToHash("Base Layer.DiamondOpenAnimation");
			OIEJJCNBEFN = Animator.StringToHash("Base Layer.DiamondCloseAnimation");
		}

		public void SwitchState()
		{
			if (!(ENCFFNKONOO == null) && !ENCFFNKONOO.HasCellItem())
			{
				if (OMDOBBEDBAO)
				{
					OMDOBBEDBAO = false;
					return;
				}
				JIFDJLDKMBO = !JIFDJLDKMBO;
				ChangeState(JIFDJLDKMBO);
			}
		}

		public void ChangeState(bool CKBJPHHOBIN, bool KEGFABEOAON = true)
		{
			JIFDJLDKMBO = CKBJPHHOBIN;
			ItemResources itemResources = null;
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				itemResources = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType());
			}
			if (itemResources != null && KEGFABEOAON)
			{
				AudioManager.PlayAudioProps(itemResources.AudioClips[0]);
			}
			StopAllCoroutines();
			StartCoroutine(HEBINMBOKBO(JIFDJLDKMBO, KEGFABEOAON));
		}

		private IEnumerator HEBINMBOKBO(bool FDBEJCCGEIK, bool HLFOLDAEPLE)
		{
			CurrentAnimator.Play((!FDBEJCCGEIK) ? OIEJJCNBEFN : JAOLDOFHIDL, 0, (!HLFOLDAEPLE) ? 1 : 0);
			yield return null;
		}

		public override bool CanShadowDrop()
		{
			return true;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			int num = 0;
			if (ENCFFNKONOO != null)
			{
				num = 10 - ENCFFNKONOO.X;
			}
			OpenSpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			OpenSpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + 1 + num;
			DiamondSpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			DiamondSpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + 2 + num;
			DoorSpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			DoorSpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + 4 + num;
			DoorSpriteRenderer1.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			DoorSpriteRenderer1.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + 4 + num;
			DoorSpriteRenderer2.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			DoorSpriteRenderer2.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + 3 + num;
			CurrentSpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			CurrentSpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + num;
		}

		protected override void EJCFANPAMMK()
		{
			if (ParticlePool.Instance != null && ItemResourcesManager.GABGKBAKHDP != null)
			{
				ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[0], base.transform.position);
			}
		}

		public override void OnItemCreated(KFCEILFGADG MGOFDOMDLCO)
		{
			base.OnItemCreated(MGOFDOMDLCO);
			ELFBOKDHKGG.OGIJEDJHMNG.Add(this);
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Diamond;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return true;
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (PIGCJDKPMFL)
			{
				return false;
			}
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			if (CCPAJBOJDMN.JKJHJDLHCMD)
			{
				PIGCJDKPMFL = true;
				return true;
			}
			if (JIFDJLDKMBO)
			{
				PIGCJDKPMFL = true;
				return true;
			}
			return false;
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			JIFDJLDKMBO = true;
			base.ExplodeByBlasterItem(CCPAJBOJDMN);
		}

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

		public void ExplosionOccured(int CIDKKPKJJAE)
		{
			if (!PIGCJDKPMFL)
			{
				SwitchState();
			}
		}

		public override bool CanBeCollectedWithAnimation()
		{
			return true;
		}

		public override void UpdateView()
		{
			ChangeState(JIFDJLDKMBO, false);
		}

		public override int GetLayerCount()
		{
			return JIFDJLDKMBO ? 1 : (-1);
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 97;
			if (JIFDJLDKMBO)
			{
				PNINCDLIDLL.EEFMIHDPJPG = 96;
			}
		}
	}
}
