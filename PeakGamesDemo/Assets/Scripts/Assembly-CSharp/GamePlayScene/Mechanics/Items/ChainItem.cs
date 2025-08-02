using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.Utils;
using DG.Tweening;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class ChainItem : CellItem
	{
		public Animator CurrentAnimator;

		public GameObject TopSpriteRenderer;

		public GameObject LeftSpriteRenderer;

		public GameObject BottomSpriteRenderer;

		public SpriteRenderer TopLeftSpriteRenderer;

		public SpriteRenderer TopRightSpriteRenderer;

		public SpriteRenderer ShadowFillSpriteRenderer;

		public SpriteRenderer ShadowBottomSpriteRenderer;

		public SpriteRenderer ShadowTopRightSpriteRenderer;

		public SpriteRenderer ShadowTopLeftSpriteRenderer;

		public SpriteRenderer[] SpriteRenderers;

		private bool BLOJKAMMLIH;

		private static int[] DAJLHJICGJN;

		private const float PFCPLLAHNJA = 0.05f;

		public int ChainOrder;

		public float BaseOrder;

		public float EmptyCellCount;

		private ChainItem DMOMCJGLCIC;

		private ChainItem ABHPFMMLIHD;

		private ChainItem FDIEPIELOHA;

		private ChainItem DEONHODDAHI;

		private CFOIPDKEFMM OELBDGFEGOI;

		private bool AKBEHHFCACM;

		private bool AHJGNKNAPHC;

		private bool JBLBEEBJPNJ;

		private Sequence LCPJGPGGAEK;

		public void Start()
		{
			if (DAJLHJICGJN == null)
			{
				DAJLHJICGJN = new int[3];
				DAJLHJICGJN[0] = Animator.StringToHash("Base Layer.ChainShakeAnimation1");
				DAJLHJICGJN[1] = Animator.StringToHash("Base Layer.ChainShakeAnimation2");
				DAJLHJICGJN[2] = Animator.StringToHash("Base Layer.ChainShakeAnimation3_wrongclick");
			}
		}

		public override void OnCellGridChange(CFOIPDKEFMM GOAELFDHDGD)
		{
			OELBDGFEGOI = GOAELFDHDGD;
			Cell cell = GOAELFDHDGD.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Up);
			Cell cell2 = GOAELFDHDGD.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Down);
			Cell cell3 = GOAELFDHDGD.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Left);
			Cell cell4 = GOAELFDHDGD.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Right);
			ABHPFMMLIHD = ((!(cell == null)) ? (cell.FEMFMBLMKHP as ChainItem) : null);
			DMOMCJGLCIC = ((!(cell2 == null)) ? (cell2.FEMFMBLMKHP as ChainItem) : null);
			FDIEPIELOHA = ((!(cell3 == null)) ? (cell3.FEMFMBLMKHP as ChainItem) : null);
			DEONHODDAHI = ((!(cell4 == null)) ? (cell4.FEMFMBLMKHP as ChainItem) : null);
			bool flag = ABHPFMMLIHD != null;
			bool flag2 = DMOMCJGLCIC != null;
			bool flag3 = FDIEPIELOHA != null;
			bool flag4 = DEONHODDAHI != null;
			if (!flag)
			{
				ADNEBLJACLO(GOAELFDHDGD);
				FLLEADJCLLO(BaseOrder);
			}
			ShadowFillSpriteRenderer.enabled = flag2;
			ShadowBottomSpriteRenderer.enabled = !flag2;
			JKDHLMCCPAP(BottomSpriteRenderer, flag2);
			JKDHLMCCPAP(LeftSpriteRenderer, flag3);
			if (!flag2)
			{
				CGIMKFAIAOL(IEKBFJBLGFM.Down);
			}
			if (!flag3)
			{
				CGIMKFAIAOL(IEKBFJBLGFM.Left);
			}
			if (!flag4)
			{
				CGIMKFAIAOL(IEKBFJBLGFM.Right);
			}
			BLOJKAMMLIH = ENCFFNKONOO.Y == GOAELFDHDGD.FHAMOHDEGMK - 1 || (cell != null && !cell.Exists);
			JKDHLMCCPAP(TopSpriteRenderer, BLOJKAMMLIH);
			bool flag5 = BLOJKAMMLIH && (!flag3 || !FDIEPIELOHA.BLOJKAMMLIH);
			TopLeftSpriteRenderer.sprite = ((!flag5) ? BBKCPPOFENL.Sprites[0] : BBKCPPOFENL.Sprites[1]);
			ShadowTopLeftSpriteRenderer.sprite = ((!flag5) ? BBKCPPOFENL.Sprites[5] : BBKCPPOFENL.Sprites[6]);
			bool flag6 = BLOJKAMMLIH && !flag4;
			TopRightSpriteRenderer.sprite = ((!flag6) ? BBKCPPOFENL.Sprites[0] : BBKCPPOFENL.Sprites[1]);
			ShadowTopRightSpriteRenderer.sprite = ((!flag6) ? BBKCPPOFENL.Sprites[5] : BBKCPPOFENL.Sprites[6]);
			if (ENCFFNKONOO.Y + 2 < GOAELFDHDGD.FHAMOHDEGMK && !flag)
			{
				ChainController.GABGKBAKHDP.RegisterChainItem(this);
			}
		}

		private void JKDHLMCCPAP(GameObject NIBJJGLKIEB, bool EDDNOJDPMCF)
		{
			if (NIBJJGLKIEB.activeInHierarchy != EDDNOJDPMCF)
			{
				NIBJJGLKIEB.SetActive(EDDNOJDPMCF);
			}
		}

		private void ADNEBLJACLO(CFOIPDKEFMM GOAELFDHDGD)
		{
			BaseOrder = 0f;
			for (int i = ENCFFNKONOO.Y + 1; i < GOAELFDHDGD.FHAMOHDEGMK; i++)
			{
				Cell cell = GOAELFDHDGD.ECNCPJGHBIG(ENCFFNKONOO.X, i);
				if (!cell.Exists)
				{
					BaseOrder += 1.5f;
					continue;
				}
				break;
			}
		}

		private void FLLEADJCLLO(float JFMBGIMCBGE)
		{
			ChainItem chainItem = this;
			int num = 0;
			while (chainItem != null)
			{
				chainItem.ChainOrder = num;
				chainItem.BaseOrder = JFMBGIMCBGE;
				num++;
				chainItem = chainItem.DMOMCJGLCIC;
			}
		}

		public void UpdateEmptyCellCount()
		{
			float num = 0f;
			for (int i = ENCFFNKONOO.Y + 1; i < OELBDGFEGOI.FHAMOHDEGMK; i++)
			{
				Cell cell = OELBDGFEGOI.ECNCPJGHBIG(ENCFFNKONOO.X, i);
				if (cell.Exists)
				{
					if (cell.EAILOFHFNJO)
					{
						break;
					}
					num += 1.5f;
				}
			}
			EmptyCellCount = num;
			if (!(num < 1f))
			{
				ChainItem dMOMCJGLCIC = DMOMCJGLCIC;
				while (dMOMCJGLCIC != null)
				{
					dMOMCJGLCIC.EmptyCellCount = num;
					dMOMCJGLCIC = dMOMCJGLCIC.DMOMCJGLCIC;
				}
			}
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Chain;
		}

		public override int GetScore()
		{
			return 500;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			int i = 0;
			for (int num = SpriteRenderers.Length; i < num; i++)
			{
				SpriteRenderer spriteRenderer = SpriteRenderers[i];
				if (spriteRenderer != null)
				{
					spriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
				}
			}
		}

		public override CKKKELDIOLD GetSorting()
		{
			return IPPOGIEPKEN.Items.EFLCPKAFOBA();
		}

		public override void PlayWrongMove()
		{
			CurrentAnimator.Play(DAJLHJICGJN[2], -1, 0f);
		}

		public void PlayShakeAnimation()
		{
			CurrentAnimator.Play(DAJLHJICGJN[Random.Range(0, 2)], -1, 0f);
		}

		private void COOIOJPGOLI(IEKBFJBLGFM AJLDJAHHGOJ)
		{
			CGIMKFAIAOL(AJLDJAHHGOJ);
			DCPCELKAPMO(AJLDJAHHGOJ);
		}

		private void CGIMKFAIAOL(IEKBFJBLGFM AJLDJAHHGOJ)
		{
			switch (AJLDJAHHGOJ)
			{
			case IEKBFJBLGFM.Down:
				SpriteRenderers[2].sprite = BBKCPPOFENL.Sprites[4];
				AKBEHHFCACM = true;
				break;
			case IEKBFJBLGFM.Left:
				IFKFIJNEGKC(JBLBEEBJPNJ);
				AHJGNKNAPHC = true;
				break;
			case IEKBFJBLGFM.Right:
				IFKFIJNEGKC(AHJGNKNAPHC);
				if (!AHJGNKNAPHC)
				{
					SpriteRenderers[0].flipX = true;
					SpriteRenderers[1].flipX = true;
					SpriteRenderers[2].flipX = true;
				}
				JBLBEEBJPNJ = true;
				break;
			}
		}

		private void IFKFIJNEGKC(bool KDLLEBEFHPG)
		{
			if (KDLLEBEFHPG)
			{
				SpriteRenderers[0].sprite = BBKCPPOFENL.Sprites[3];
				SpriteRenderers[1].sprite = BBKCPPOFENL.Sprites[3];
				if (!AKBEHHFCACM)
				{
					SpriteRenderers[2].sprite = BBKCPPOFENL.Sprites[3];
				}
			}
			else
			{
				SpriteRenderers[0].sprite = BBKCPPOFENL.Sprites[2];
				SpriteRenderers[1].sprite = BBKCPPOFENL.Sprites[2];
				if (!AKBEHHFCACM)
				{
					SpriteRenderers[2].sprite = BBKCPPOFENL.Sprites[2];
				}
			}
		}

		private void DCPCELKAPMO(IEKBFJBLGFM AJLDJAHHGOJ)
		{
			switch (AJLDJAHHGOJ)
			{
			case IEKBFJBLGFM.Down:
				JKDHLMCCPAP(BottomSpriteRenderer, false);
				ShadowBottomSpriteRenderer.enabled = true;
				ShadowFillSpriteRenderer.enabled = false;
				break;
			case IEKBFJBLGFM.Left:
				if (BLOJKAMMLIH)
				{
					TopLeftSpriteRenderer.sprite = BBKCPPOFENL.Sprites[1];
					ShadowTopLeftSpriteRenderer.sprite = BBKCPPOFENL.Sprites[6];
				}
				JKDHLMCCPAP(LeftSpriteRenderer, false);
				break;
			case IEKBFJBLGFM.Right:
				if (BLOJKAMMLIH)
				{
					TopRightSpriteRenderer.sprite = BBKCPPOFENL.Sprites[1];
					ShadowTopRightSpriteRenderer.sprite = BBKCPPOFENL.Sprites[6];
				}
				break;
			}
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (base.TryExplode(CCPAJBOJDMN))
			{
				return false;
			}
			if (ParticlePool.Instance != null)
			{
				ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[0], base.transform.position);
			}
			AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[0]);
			ELFBOKDHKGG.ACJOALJFMHN(NOALGNJECAD.Chain, true);
			if (CanRaiseScore())
			{
				ScoreManager.RaiseScore(GetScore());
			}
			if (ABHPFMMLIHD != null)
			{
				ABHPFMMLIHD.COOIOJPGOLI(IEKBFJBLGFM.Down);
			}
			if (DEONHODDAHI != null)
			{
				DEONHODDAHI.COOIOJPGOLI(IEKBFJBLGFM.Left);
			}
			if (FDIEPIELOHA != null)
			{
				FDIEPIELOHA.COOIOJPGOLI(IEKBFJBLGFM.Right);
			}
			if (DMOMCJGLCIC != null)
			{
				ChainController.GABGKBAKHDP.RegisterChainItem(DMOMCJGLCIC);
				DMOMCJGLCIC.FLLEADJCLLO(0f);
			}
			if (LCPJGPGGAEK != null)
			{
				LCPJGPGGAEK.Kill();
			}
			Object.Destroy(base.gameObject);
			return true;
		}

		public override void UpdateOnFallBehind()
		{
			if (LCPJGPGGAEK != null)
			{
				LCPJGPGGAEK.Kill();
			}
			LCPJGPGGAEK = DOTween.Sequence();
			LCPJGPGGAEK.InsertCallback(((float)ChainOrder + BaseOrder + EmptyCellCount) * 0.05f, PlayShakeAnimation);
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 34;
		}
	}
}
