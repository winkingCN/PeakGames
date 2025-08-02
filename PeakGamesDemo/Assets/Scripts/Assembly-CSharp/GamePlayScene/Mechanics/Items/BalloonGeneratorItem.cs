using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.Utils;
using GamePlayScene.Mechanics.Animations;
using UnityEngine;
using UnityEngine.Rendering;

namespace GamePlayScene.Mechanics.Items
{
	public class BalloonGeneratorItem : GeneratorBasedItem
	{
		public Animator CurrentAnimator;

		public SortingGroup CurrentSortingGroup;

		public Transform Container;

		private int OFGIBIKDOGB;

		private int CECIDKPINJC;

		private int GOOCMNFDKGH;

		private CKKKELDIOLD KKCPOOALFAD;

		private bool JNIGNLLDHKO;

		private bool JOGBPBFNBCI;

		private bool CFHBFFNEJPO;

		public void Start()
		{
			DNEBHKPJOJJ = 1;
			BOCFHAEPEIA = 1;
			OFGIBIKDOGB = Animator.StringToHash("Base Layer.BalloonGeneratorThrow");
			CECIDKPINJC = Animator.StringToHash("Base Layer.BalloonGeneratorSleep");
			ChangeSorting(GetSorting());
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			int num = (int)base.transform.localPosition.x;
			int num2 = (int)(8f - base.transform.localPosition.y);
			CurrentSortingGroup.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			CurrentSortingGroup.sortingOrder = 1200 + num2 * 20 + ((GOOCMNFDKGH != 0) ? num : (10 - num));
			KKCPOOALFAD = new CKKKELDIOLD(IBBBMACIBGK.MMFFDANAEEI, CurrentSortingGroup.sortingOrder);
		}

		public override CKKKELDIOLD GetSorting()
		{
			return KKCPOOALFAD;
		}

		public override void OnItemCreated(KFCEILFGADG MGOFDOMDLCO)
		{
			base.OnItemCreated(MGOFDOMDLCO);
			GenerateItemType = NOALGNJECAD.Balloon;
			MJPAKGMNFAC.GABGKBAKHDP.AFLOKCLDFNE(GenerateItemType, this);
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.BalloonGenerator;
		}

		public override bool CanFall()
		{
			return false;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return true;
		}

		public override int GetScore()
		{
			return 0;
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			PACACNHKKHA();
			return false;
		}

		public override void Sleep()
		{
			JNIGNLLDHKO = true;
			if (!CFHBFFNEJPO && base.gameObject.activeSelf)
			{
				StartCoroutine(EDJKPKGOHHH());
			}
		}

		public override void ForceSleep()
		{
			JNIGNLLDHKO = true;
			UpdateView();
		}

		public override Cell GetRandomCell()
		{
			return MJPAKGMNFAC.GABGKBAKHDP.MKLJIAFNDDH();
		}

		public override void PlayThrowAnimation(List<Cell> FNHOIPIKEMJ)
		{
			if (FNHOIPIKEMJ == null || FNHOIPIKEMJ.Count == 0)
			{
				ELFBOKDHKGG.DJNEAFJLFIH(GenerateItemType);
				return;
			}
			int count = FNHOIPIKEMJ.Count;
			ItemResources resources = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType());
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[0]);
			}
			for (int i = 0; i < count; i++)
			{
				if (resources != null)
				{
					JOGBPBFNBCI = true;
					GameObject gameObject = resources.Animators[0].JOBDHIPIMAG();
					BalloonGeneratorThrowAnimation component = gameObject.GetComponent<BalloonGeneratorThrowAnimation>();
					component.Prepare(ENCFFNKONOO, FNHOIPIKEMJ[i], GOOCMNFDKGH, LNGOKFALMCD);
					CurrentAnimator.Play(OFGIBIKDOGB, 0, 0f);
					AudioManager.PlayAudioProps(resources.AudioClips[1]);
				}
			}
			if (!CFHBFFNEJPO)
			{
				StartCoroutine(EDJKPKGOHHH());
			}
		}

		private IEnumerator EDJKPKGOHHH()
		{
			CFHBFFNEJPO = true;
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			while (Time.realtimeSinceStartup - realtimeSinceStartup < 1f && JOGBPBFNBCI)
			{
				yield return null;
			}
			if (JNIGNLLDHKO)
			{
				if (ItemResourcesManager.GABGKBAKHDP != null)
				{
					AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[1]);
				}
				CurrentAnimator.Play(CECIDKPINJC, 0, 0f);
			}
			CFHBFFNEJPO = false;
		}

		public void SetDirection(int AJLDJAHHGOJ)
		{
			GOOCMNFDKGH = AJLDJAHHGOJ;
			if (GOOCMNFDKGH == 1)
			{
				Container.transform.localScale = new Vector3(-1f, 1f, 1f);
				Quaternion identity = Quaternion.identity;
				identity.eulerAngles = new Vector3(0f, 0f, 180f);
			}
		}

		public override bool CanBeInsideBubble()
		{
			return false;
		}

		public void ThrowAnimationCompleteEventTriggered()
		{
			JOGBPBFNBCI = false;
		}

		public override void UpdateView()
		{
			if (JNIGNLLDHKO)
			{
				CurrentAnimator.Play(Animator.StringToHash("Base Layer.BalloonGeneratorSleep"), 0, 1f);
			}
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = (short)(74 + GOOCMNFDKGH);
		}
	}
}
