using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.GamePlayScene.Touches;
using Assets.Scripts.Utils;
using UnityEngine;
using Utils;

namespace GamePlayScene.Mechanics.Items
{
	public class WallItem : CollectorItem
	{
		public SpriteRenderer WallSpriteRenderer;

		public SpriteRenderer JointSpriteRenderer;

		public SpriteRenderer JointCornerSpriteRenderer;

		public Animator CollectAnimator;

		public Transform CollectTarget;

		public SpriteRenderer DynamiteSpriteRenderer;

		public SpriteRenderer DynamiteRibbonSpriteRenderer;

		public SpriteRenderer DynamiteDialSpriteRenderer;

		public SpriteRenderer DynamiteDialGlowSpriteRenderer;

		public SpriteRenderer DynamiteShadowSpriteRenderer;

		public BitmapNumberDisplay CurrentBitmapNumberDisplay;

		public WallEffect[] WallEffects;

		public GameObject[] SparksBig;

		public GameObject[] SparksSmall;

		public SpriteRenderer[] FuseSpriteRenderers;

		public SpriteRenderer[] DialSprites;

		public ParticleSystem HitParticle;

		[HideInInspector]
		public WallItem MasterItem;

		[HideInInspector]
		public bool IsMasterItem;

		[HideInInspector]
		public string Group;

		private List<WallItem> OBOPNPKHJDE;

		private Item NHFMFLNPHCP;

		private CKKKELDIOLD KKCPOOALFAD;

		private int JNKDBENJGFI;

		private int GMFKFCNPDKF;

		private float GHKJECBFGFI;

		private Vector2 IHCDNKIHLOJ;

		private int KEDBLADIMAH;

		private bool LNGMBIGHOJJ;

		private Vector2 MOMLGKCLHLK = new Vector2(float.MaxValue, float.MaxValue);

		private Vector2 FGCCNAPIGCO = new Vector2(float.MinValue, float.MinValue);

		private ItemResources GIDBOAKLNCK;

		private Cell EGOJLIONFMD;

		private int JEGHOLAFOMD;

		private bool LFJKPAJNAKH;

		private const float NADEPGOKFEC = 0.4f;

		private static readonly int JPLHFICKKNO = Animator.StringToHash("WallItemExplode");

		public Item AFAIKIMJLBP
		{
			get
			{
				return NHFMFLNPHCP;
			}
			set
			{
				NHFMFLNPHCP = value;
				if (!(NHFMFLNPHCP == null))
				{
					NHFMFLNPHCP.gameObject.SetActive(false);
				}
			}
		}

		public void Prepare(DLKLKMDJOOJ GKCPHEMMHNA)
		{
			JNKDBENJGFI = GKCPHEMMHNA.LJNDDJECANK;
			IHCDNKIHLOJ = GKCPHEMMHNA.GOPMNHCIIMN;
			GHKJECBFGFI = GKCPHEMMHNA.GEBNMKAGJIG;
			GIDBOAKLNCK = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType());
			Group = GKCPHEMMHNA.AOMJLDBPDKP;
			base.BHIJCAOHDCM = GKCPHEMMHNA.BHIJCAOHDCM;
			base.BPLHOCDDLCG = GKCPHEMMHNA.BPLHOCDDLCG;
			CurrentBitmapNumberDisplay.Sprites = new Sprite[10]
			{
				GIDBOAKLNCK.Sprites[20],
				GIDBOAKLNCK.Sprites[21],
				GIDBOAKLNCK.Sprites[22],
				GIDBOAKLNCK.Sprites[23],
				GIDBOAKLNCK.Sprites[24],
				GIDBOAKLNCK.Sprites[25],
				GIDBOAKLNCK.Sprites[26],
				GIDBOAKLNCK.Sprites[27],
				GIDBOAKLNCK.Sprites[28],
				GIDBOAKLNCK.Sprites[29]
			};
			FEHOHJAAFDB();
			FDANHPNABBC();
		}

		private void FDANHPNABBC()
		{
			Sprite[] sprites = GIDBOAKLNCK.Sprites;
			switch (base.BPLHOCDDLCG)
			{
			case LEDBLDKJBAI.Yellow:
				DynamiteRibbonSpriteRenderer.sprite = sprites[8];
				DynamiteDialSpriteRenderer.sprite = sprites[14];
				break;
			case LEDBLDKJBAI.Red:
				DynamiteRibbonSpriteRenderer.sprite = sprites[9];
				DynamiteDialSpriteRenderer.sprite = sprites[15];
				break;
			case LEDBLDKJBAI.Blue:
				DynamiteRibbonSpriteRenderer.sprite = sprites[10];
				DynamiteDialSpriteRenderer.sprite = sprites[16];
				break;
			case LEDBLDKJBAI.Green:
				DynamiteRibbonSpriteRenderer.sprite = sprites[11];
				DynamiteDialSpriteRenderer.sprite = sprites[17];
				break;
			case LEDBLDKJBAI.Purple:
				DynamiteRibbonSpriteRenderer.sprite = sprites[12];
				DynamiteDialSpriteRenderer.sprite = sprites[18];
				break;
			case LEDBLDKJBAI.Orange:
				DynamiteRibbonSpriteRenderer.sprite = sprites[13];
				DynamiteDialSpriteRenderer.sprite = sprites[19];
				break;
			}
		}

		public virtual void LinkNeighbours(Cell LBHDELJBONF)
		{
			if (!LBHDELJBONF.Exists || !LBHDELJBONF.EAILOFHFNJO)
			{
				return;
			}
			WallItem wallItem = LBHDELJBONF.LBFCDKPCDPB as WallItem;
			if (wallItem == null || wallItem.MasterItem != null || wallItem.IsMasterItem || wallItem.Group != Group)
			{
				return;
			}
			LBHDELJBONF.HideBubble();
			if (wallItem == this)
			{
				IsMasterItem = true;
				if (OBOPNPKHJDE == null)
				{
					OBOPNPKHJDE = new List<WallItem>();
				}
				CollectorId = NLMLKADGECN.GABGKBAKHDP.OAPMNDFNNHB().HNCEPKJKAMC(this);
				CollectTarget.gameObject.SetActive(true);
			}
			else
			{
				wallItem.MasterItem = this;
				wallItem.CollectorId = CollectorId;
				OBOPNPKHJDE.Add(wallItem);
			}
			Vector3 position = wallItem.transform.position;
			if (position.x < MOMLGKCLHLK.x)
			{
				MOMLGKCLHLK.x = position.x;
			}
			if (position.x > FGCCNAPIGCO.x)
			{
				FGCCNAPIGCO.x = position.x;
			}
			if (position.y < MOMLGKCLHLK.y)
			{
				MOMLGKCLHLK.y = position.y;
			}
			if (position.y > FGCCNAPIGCO.y)
			{
				FGCCNAPIGCO.y = position.y;
			}
			if (LBHDELJBONF.Y > JEGHOLAFOMD)
			{
				JEGHOLAFOMD = LBHDELJBONF.Y;
			}
			CFOIPDKEFMM currentGrid = LBHDELJBONF.CurrentGrid;
			Cell cell = currentGrid.PHOOMEOBJCB(LBHDELJBONF, IEKBFJBLGFM.Left);
			if (cell != null)
			{
				LinkNeighbours(cell);
			}
			Cell cell2 = currentGrid.PHOOMEOBJCB(LBHDELJBONF, IEKBFJBLGFM.Right);
			if (cell2 != null)
			{
				LinkNeighbours(cell2);
			}
			Cell cell3 = currentGrid.PHOOMEOBJCB(LBHDELJBONF, IEKBFJBLGFM.Up);
			if (cell3 != null)
			{
				LinkNeighbours(cell3);
			}
			Cell cell4 = currentGrid.PHOOMEOBJCB(LBHDELJBONF, IEKBFJBLGFM.Down);
			if (cell4 != null)
			{
				LinkNeighbours(cell4);
			}
			wallItem.PHNNOICOIAE();
			if (IsMasterItem)
			{
				CollectTarget.localScale = Vector3.one * GHKJECBFGFI;
				CollectTarget.position = new Vector3((MOMLGKCLHLK.x + FGCCNAPIGCO.x) / 2f + IHCDNKIHLOJ.x, (MOMLGKCLHLK.y + FGCCNAPIGCO.y) / 2f + IHCDNKIHLOJ.y, CollectTarget.position.z);
				Vector3 localPosition = CollectTarget.localPosition;
				localPosition.x += -0.02f;
				localPosition.y += -0.123f;
				CollectTarget.localPosition = localPosition;
				ChangeSorting(KKCPOOALFAD);
			}
		}

		private void PHNNOICOIAE()
		{
			Sprite[] sprites = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Sprites;
			CFOIPDKEFMM currentGrid = ENCFFNKONOO.CurrentGrid;
			int i = 0;
			for (int num = WallEffects.Length; i < num; i++)
			{
				WallEffect wallEffect = WallEffects[i];
				if (wallEffect != null)
				{
					wallEffect.Init();
				}
			}
			bool flag = NIOOGKKDHMN(currentGrid.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Down));
			bool flag2 = NIOOGKKDHMN(currentGrid.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Left));
			bool flag3 = NIOOGKKDHMN(currentGrid.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Right));
			int num2 = (flag2 ? (flag3 ? 1 : 2) : 0);
			WallSpriteRenderer.sprite = sprites[num2];
			JointSpriteRenderer.sprite = null;
			JointCornerSpriteRenderer.sprite = null;
			if (flag)
			{
				if (!flag2)
				{
					JointSpriteRenderer.sprite = sprites[3];
				}
				else if (!flag3)
				{
					JointSpriteRenderer.sprite = sprites[5];
				}
				else
				{
					bool flag4 = NIOOGKKDHMN(currentGrid.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.LeftDown));
					bool flag5 = NIOOGKKDHMN(currentGrid.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.RightDown));
					if (!flag4)
					{
						JointCornerSpriteRenderer.sprite = sprites[6];
					}
					else if (!flag5)
					{
						JointCornerSpriteRenderer.sprite = sprites[7];
					}
					else
					{
						JointSpriteRenderer.sprite = sprites[4];
					}
				}
			}
			JointCornerSpriteRenderer.enabled = JointCornerSpriteRenderer.sprite != null;
			JointSpriteRenderer.enabled = JointSpriteRenderer.sprite != null;
			if (UnityEngine.Random.Range(0, 10) < 5)
			{
				WallEffects[num2].ShowOverlays(6);
			}
		}

		private bool NIOOGKKDHMN(Cell LBHDELJBONF)
		{
			return LBHDELJBONF != null && LBHDELJBONF.Exists && LBHDELJBONF.EAILOFHFNJO && LBHDELJBONF.LBFCDKPCDPB is WallItem && ((WallItem)LBHDELJBONF.LBFCDKPCDPB).Group == Group;
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
		}

		public override bool CanFall()
		{
			return false;
		}

		public override bool CanBeTapped()
		{
			return false;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			KKCPOOALFAD = IBBBMACIBGK;
			WallSpriteRenderer.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
			WallSpriteRenderer.sortingOrder = KKCPOOALFAD.BHIJCAOHDCM;
			JointSpriteRenderer.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
			JointSpriteRenderer.sortingOrder = KKCPOOALFAD.BHIJCAOHDCM + 10;
			JointCornerSpriteRenderer.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
			JointCornerSpriteRenderer.sortingOrder = KKCPOOALFAD.BHIJCAOHDCM + 10;
			int i = 0;
			for (int num = WallEffects.Length; i < num; i++)
			{
				WallEffect wallEffect = WallEffects[i];
				if (wallEffect != null)
				{
					wallEffect.UpdateSorting(KKCPOOALFAD);
				}
			}
			int a = KKCPOOALFAD.BHIJCAOHDCM + JEGHOLAFOMD * 100;
			a = Mathf.Min(a, 1450);
			DynamiteShadowSpriteRenderer.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
			DynamiteShadowSpriteRenderer.sortingOrder = a + 10;
			DynamiteSpriteRenderer.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
			DynamiteSpriteRenderer.sortingOrder = a + 11;
			DynamiteRibbonSpriteRenderer.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
			DynamiteRibbonSpriteRenderer.sortingOrder = a + 12;
			for (int j = 0; j < 3; j++)
			{
				FuseSpriteRenderers[j].sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
				FuseSpriteRenderers[j].sortingOrder = a + 13;
			}
			for (int k = 0; k < 3; k++)
			{
				DialSprites[k].sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
				DialSprites[k].sortingOrder = a + k + 14;
			}
			DynamiteDialGlowSpriteRenderer.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
			DynamiteDialGlowSpriteRenderer.sortingOrder = a + 17;
		}

		public override int GetFireworksPriority()
		{
			return -1;
		}

		public override CKKKELDIOLD GetSorting()
		{
			return KKCPOOALFAD;
		}

		public override Item ExtractSubItem()
		{
			if (NHFMFLNPHCP == null)
			{
				return AFAIKIMJLBP;
			}
			NHFMFLNPHCP.gameObject.SetActive(true);
			return AFAIKIMJLBP;
		}

		public override bool CanShadowDrop()
		{
			return true;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return false;
		}

		public override int GetScore()
		{
			return 0;
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Wall;
		}

		public override bool CanBeInsideBubble()
		{
			return false;
		}

		public override bool CanBeInsideCellItem()
		{
			return false;
		}

		public override Item GetSubItem()
		{
			return AFAIKIMJLBP;
		}

		public override bool CanBeExplodedBySpecialItem()
		{
			return false;
		}

		public override bool CanBeExplodedByBooster()
		{
			return false;
		}

		public override void PlayWrongMove()
		{
		}

		public override bool BoosterHammerCanBeUsed()
		{
			return false;
		}

		public override bool BoosterAnvilCanBeUsed()
		{
			return false;
		}

		public override bool BoosterBoxingGloveCanBeUsed()
		{
			return false;
		}

		public override void PlayExplodeAudio()
		{
			AudioManager.PlayAudioProps(GIDBOAKLNCK.AudioClips[2]);
		}

		protected override void EJCFANPAMMK()
		{
			if (ParticlePool.Instance != null && ItemResourcesManager.GABGKBAKHDP != null)
			{
				ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[0], base.transform.position);
			}
		}

		protected void FEHOHJAAFDB()
		{
			int num = JNKDBENJGFI - GMFKFCNPDKF;
			if (num < 0)
			{
				return;
			}
			if (num < 6 && !SparksSmall[0].activeSelf)
			{
				for (int i = 0; i < 3; i++)
				{
					SparksSmall[i].SetActive(true);
				}
			}
			if (num < 10 && !LFJKPAJNAKH)
			{
				LFJKPAJNAKH = true;
				CurrentBitmapNumberDisplay.transform.localScale = Vector3.one * 0.8f;
				CurrentBitmapNumberDisplay.transform.localPosition = new Vector3(0.076f, 0.004f, 0f);
			}
			CurrentBitmapNumberDisplay.Show(num);
		}

		public override bool IsAvailable()
		{
			return JNKDBENJGFI - (GMFKFCNPDKF + KEDBLADIMAH) > 0;
		}

		public override void StartCollectingItem()
		{
			KEDBLADIMAH++;
			if (!LNGMBIGHOJJ && KEDBLADIMAH + GMFKFCNPDKF >= JNKDBENJGFI)
			{
				LNGMBIGHOJJ = true;
				TapListener.Instance.IncreaseBlockRequests();
			}
		}

		public override void OnItemCollectCompleted()
		{
			GMFKFCNPDKF++;
			KEDBLADIMAH--;
			AudioManager.PlayAudioProps(GIDBOAKLNCK.AudioClips[0]);
			HitParticle.Play();
			FEHOHJAAFDB();
			if (KEDBLADIMAH == 0)
			{
				CollectAnimator.SetBool("single_collect", true);
				CollectAnimator.SetBool("collect", false);
				StartCoroutine(LKDEIMGCIHI());
			}
			else
			{
				CollectAnimator.SetBool("collect", true);
			}
			if (KEDBLADIMAH == 0 && JNKDBENJGFI - GMFKFCNPDKF <= 0)
			{
				NLMLKADGECN.GABGKBAKHDP.OAPMNDFNNHB().HLFFHLAOIAJ(this);
				new LLCJMMBBLEH(DDIFCKMAOJB(), true);
			}
		}

		private IEnumerator LKDEIMGCIHI()
		{
			yield return MCJHHDACJBG.CNDGGNLKOOC;
			CollectAnimator.SetBool("collect", false);
			CollectAnimator.SetBool("single_collect", false);
		}

		private IEnumerator DDIFCKMAOJB()
		{
			while (FallManager.AreThereActiveAnimations() || FallManager.AreFallsBlocked())
			{
				yield return null;
			}
			FallManager.IncreaseMechanicAnimation();
			FallManager.IncreaseWaitingFallBlocker();
			AudioManager.PlayAudioProps(GIDBOAKLNCK.AudioClips[1]);
			for (int i = 0; i < 3; i++)
			{
				SparksSmall[i].SetActive(false);
				SparksBig[i].SetActive(true);
			}
			CollectAnimator.SetBool("explode", true);
			while (!CollectAnimator.GetCurrentAnimatorStateInfo(0).shortNameHash.Equals(JPLHFICKKNO))
			{
				yield return null;
			}
			yield return new WaitForSeconds(1.4f);
			CollectTarget.gameObject.SetActive(false);
			if (ParticlePool.Instance != null && ItemResourcesManager.GABGKBAKHDP != null)
			{
				ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[1], CollectTarget.position);
			}
			ShakeAnimation[] panelShakeAnimations = ELFBOKDHKGG.GIMBEKBFKMJ.PanelShakeAnimations;
			foreach (ShakeAnimation shakeAnimation in panelShakeAnimations)
			{
				if (!shakeAnimation.IsShaking)
				{
					shakeAnimation.Shake(0.4f, 0.2f, 0.2f);
				}
			}
			List<Cell> list = new List<Cell>();
			if (OBOPNPKHJDE != null && OBOPNPKHJDE.Count > 0)
			{
				int count = OBOPNPKHJDE.Count;
				for (int k = 0; k < count; k++)
				{
					Cell currentCell = OBOPNPKHJDE[k].ENCFFNKONOO;
					ENCFFNKONOO.CurrentGrid.EJBPCMDJFEM(currentCell, MLENMAIAOHJ.BDAKKAIBMIM(1));
					OBOPNPKHJDE[k].StartExplode();
					if (currentCell != null)
					{
						list.Add(currentCell);
					}
				}
				OBOPNPKHJDE = null;
			}
			list.Add(ENCFFNKONOO);
			ENCFFNKONOO.CurrentGrid.EJBPCMDJFEM(ENCFFNKONOO, MLENMAIAOHJ.BDAKKAIBMIM(1));
			StartExplode();
			for (int l = 0; l < list.Count; l++)
			{
				Cell cell = list[l];
				cell.ShowBubble();
				Item currentItem = cell.LBFCDKPCDPB;
				if (currentItem != null)
				{
					currentItem.UpdateView();
				}
				BillboardItem billboardItem = currentItem as BillboardItem;
				if (billboardItem != null && billboardItem.MasterItem == null)
				{
					billboardItem.LinkNeighbours(cell);
				}
				StoneItem stoneItem = currentItem as StoneItem;
				if (stoneItem != null && stoneItem.MasterItem == null)
				{
					stoneItem.LinkNeighbours(cell);
				}
				LogItem logItem = currentItem as LogItem;
				if (logItem != null)
				{
					logItem.LinkNeighbours();
				}
			}
			yield return new WaitForSeconds(0.5f);
			int m = 0;
			for (int count2 = list.Count; m < count2; m++)
			{
				if (list[m] != null && list[m].EAILOFHFNJO)
				{
					list[m].LBFCDKPCDPB.transform.localPosition = list[m].GetFrozenLocalPosition();
				}
			}
			TapListener.Instance.DecreaseBlockRequests();
			FallManager.DecreaseMechanicAnimation();
			FallManager.DecreaseWaitingFallBlocker();
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			if (AFAIKIMJLBP != null)
			{
				AFAIKIMJLBP.GetItemSnapshotData(PNINCDLIDLL);
			}
			byte[] bytes = BitConverter.GetBytes(PNINCDLIDLL.EEFMIHDPJPG);
			PNINCDLIDLL.BOPEPLONIFL();
			PNINCDLIDLL.EEFMIHDPJPG = (short)(221 + base.BPLHOCDDLCG);
			PNINCDLIDLL.DKJDLMNKFGM(bytes[BitConverter.IsLittleEndian ? 1 : 0]);
			PNINCDLIDLL.DKJDLMNKFGM(bytes[(!BitConverter.IsLittleEndian) ? 1u : 0u]);
			byte aINNOPBDDGL = (byte)(GMFKFCNPDKF + KEDBLADIMAH);
			PNINCDLIDLL.DKJDLMNKFGM(aINNOPBDDGL);
		}

		protected void JCPHCGCOOEB(int ENMLICFLHAO)
		{
			GMFKFCNPDKF = ENMLICFLHAO;
		}
	}
}
