using System;
using System.Collections;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class FishItem : Item
	{
		public Animator CurrentAnimator;

		public Transform Container;

		public SpriteRenderer[] SpriteRenderers;

		public ParticleSystem ThrowParticle;

		private int BMPFGMEMJJN = 1;

		private int MLKDGLDINED = 1;

		private int KBCCALFCDPL;

		private int OFGIBIKDOGB;

		private int CECIDKPINJC;

		private int GOOCMNFDKGH;

		private bool JNIGNLLDHKO;

		private bool HINNFILALIG;

		private static int BMLABDEBFII;

		public override int JLHIKIHDEIE
		{
			get
			{
				return BMLABDEBFII;
			}
			set
			{
				BMLABDEBFII = value;
			}
		}

		public void Start()
		{
			OFGIBIKDOGB = Animator.StringToHash("Base Layer.BubbleGeneratorThrow");
			CECIDKPINJC = Animator.StringToHash("Base Layer.BubbleGeneratorSleep");
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			int num = SpriteRenderers.Length;
			if (num != 0)
			{
				int num2 = ((!(ENCFFNKONOO == null)) ? ENCFFNKONOO.X : 0);
				for (int i = 0; i < num; i++)
				{
					SpriteRenderers[i].sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
					SpriteRenderers[i].sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + i + 50 + num2 * 10;
				}
			}
		}

		public override CKKKELDIOLD GetSorting()
		{
			return new CKKKELDIOLD(SpriteRenderers[0].sortingLayerID, SpriteRenderers[0].sortingOrder);
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Fish;
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

		public override void OnItemCreated(KFCEILFGADG MGOFDOMDLCO)
		{
			base.OnItemCreated(MGOFDOMDLCO);
			LLJLGKECBBE.GABGKBAKHDP.LBOHGOAGAFJ(this);
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			StartCoroutine(JCHHPGIFPIF());
			return false;
		}

		private IEnumerator JCHHPGIFPIF()
		{
			yield return null;
			bool flag = ELFBOKDHKGG.CICDFLLGAHA() < 2 && !JNIGNLLDHKO;
			if (ELFBOKDHKGG.CICDFLLGAHA() < 1)
			{
				yield break;
			}
			try
			{
				bool flag2 = false;
				KBCCALFCDPL++;
				if (KBCCALFCDPL % MLKDGLDINED == 0)
				{
					KBCCALFCDPL = 0;
					for (int i = 0; i < BMPFGMEMJJN; i++)
					{
						Cell cell = LLJLGKECBBE.GABGKBAKHDP.MKLJIAFNDDH();
						if (cell == null)
						{
							break;
						}
						flag2 = true;
						cell.AddBubble(true);
						GameObject gameObject = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Animators[0].JOBDHIPIMAG();
						BubbleAnimation component = gameObject.GetComponent<BubbleAnimation>();
						component.Prepare(ENCFFNKONOO, cell, GOOCMNFDKGH, ThrowParticle, LNGOKFALMCD);
						HINNFILALIG = true;
						if (flag)
						{
							LLJLGKECBBE.GABGKBAKHDP.NEDGNENMFAE();
						}
					}
				}
				if (flag2)
				{
					CurrentAnimator.Play(OFGIBIKDOGB, 0, 0f);
				}
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.FishItem, "Generate Bubbles Error:{0} Stack:{1} ", ex.Message, ex.StackTrace);
			}
		}

		public void Sleep()
		{
			if (!JNIGNLLDHKO)
			{
				JNIGNLLDHKO = true;
				if (!HINNFILALIG)
				{
					CurrentAnimator.Play(CECIDKPINJC, 0, 0f);
				}
			}
		}

		private void LNGOKFALMCD()
		{
			HINNFILALIG = false;
			if (JNIGNLLDHKO)
			{
				CurrentAnimator.Play(CECIDKPINJC, 0, 0f);
			}
		}

		public void SetDirection(int AJLDJAHHGOJ)
		{
			GOOCMNFDKGH = AJLDJAHHGOJ;
			if (GOOCMNFDKGH == 1)
			{
				Container.transform.localScale = new Vector3(-1f, 1f, 1f);
				Quaternion identity = Quaternion.identity;
				identity.eulerAngles = new Vector3(0f, 0f, 180f);
				ThrowParticle.transform.rotation = identity;
			}
		}

		public override bool CanBeInsideBubble()
		{
			return false;
		}

		public override void UpdateView()
		{
			if (JNIGNLLDHKO)
			{
				CurrentAnimator.Play(Animator.StringToHash("Base Layer.BubbleGeneratorSleep"), 0, 1f);
			}
		}

		public override int GetLayerCount()
		{
			return ELFBOKDHKGG.CICDFLLGAHA();
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = (short)(93 + GOOCMNFDKGH);
		}

		public void ForceToSleep()
		{
			JNIGNLLDHKO = true;
			UpdateView();
		}
	}
}
