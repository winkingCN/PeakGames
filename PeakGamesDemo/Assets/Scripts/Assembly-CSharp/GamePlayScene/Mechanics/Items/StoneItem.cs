using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class StoneItem : SpriteBasedItem
	{
		public ParticleSystem AnimationParticle;

		public Transform EffectsContainer;

		public SpriteRenderer[] Tiles;

		public SpriteRenderer[] Effects;

		public Animator CurrentAnimator;

		public SpriteRenderer GlowAnimationSprite;

		public Renderer ParticleRenderer;

		[HideInInspector]
		public StoneItem MasterItem;

		[HideInInspector]
		public bool IsMasterItem;

		[HideInInspector]
		public int StoneId;

		[HideInInspector]
		public int ExplosionOrder = 1000;

		private static int GOMMJNHNCJO;

		private List<StoneItem> OBOPNPKHJDE;

		private int BBAPOCIKLOM = 5;

		private CKKKELDIOLD KKCPOOALFAD;

		private readonly int[] BAJHMMMEJLN = new int[4];

		private ItemResources GIDBOAKLNCK;

		private const int CNFCNMOPCFN = 0;

		private const int NEHGODNLIMN = 1;

		private const int CIJACJKAJIE = 2;

		private const int BIPGDKMEJDI = 3;

		private const int NPKCLIGPBMG = 4;

		private const int MCBPMFBDEDJ = 5;

		private const int COPCMKCGDHJ = 6;

		private const int LBDNDIOMPOP = 7;

		private const int MIIAPEEKJCJ = 8;

		private const int FDEBOLNANNK = 9;

		private const int MNLMOHMHBHF = 10;

		private const int ONIGMJNBADO = 11;

		private const int KJJABFLDCOB = 18;

		private const int JMHMHBDLPHL = 12;

		private const int CHPHPPJIGCO = 13;

		private const int APBPPMGGNBI = 14;

		private const int ALFIOLDCFJE = 15;

		private const int PPCGHFPKFAC = 16;

		private const int EKOLHILCMEM = 17;

		private const int FFPAMADCIJM = 5;

		private const int JJJDFJFLCJP = 19;

		private const int BBKOPFLKCDJ = 24;

		private const int PFGLANMHJJJ = 29;

		private const int FHBAOHOJADB = 30;

		private const int NCGKBMLAKBI = 31;

		private const int PFMONFGNHHH = 32;

		private static readonly List<int> OFNHLJPMEIP = new List<int> { 11, 18 };

		private static readonly List<int> BIOCFMCBAAM = new List<int> { 3, 3, 3, 2, 1 };

		private static readonly List<int> GFAMBJEEHPF = new List<int> { 8, 9, 10 };

		private static readonly List<int> GBMCJFHJMHH = new List<int> { 15, 16, 17 };

		protected static readonly int[] DPLIJCAHCPF = new int[4] { 29, 30, 31, 32 };

		private readonly int OKLGMNAEHDF = Animator.StringToHash("StoneItemAnimation2_1");

		private bool BJGKOCABGAP;

		private bool DJIFKHIOMNO;

		[CompilerGenerated]
		private static Comparison<StoneItem> EBCOMJBLIPP;

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Stone;
		}

		public override int GetScore()
		{
			return 500;
		}

		public override bool CanRaiseScore()
		{
			return true;
		}

		public override bool CanFall()
		{
			return false;
		}

		public override bool CanShadowDrop()
		{
			return true;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return true;
		}

		public override bool CanBeTapped()
		{
			return false;
		}

		public override bool CanGenerateScoreWithoutExplode()
		{
			return true;
		}

		public override bool CanBeInsideBubble()
		{
			return false;
		}

		public override bool CanBeInsideCellItem()
		{
			return false;
		}

		public override void PlayWrongMove()
		{
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			KKCPOOALFAD = IBBBMACIBGK;
			for (int i = 0; i < 4; i++)
			{
				Tiles[i].sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
				Tiles[i].sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + BAJHMMMEJLN[i] + 1;
			}
			for (int j = 0; j < 2; j++)
			{
				Effects[j].sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
				Effects[j].sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + 21 + j;
			}
			CurrentSpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			CurrentSpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + 31;
			GlowAnimationSprite.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			GlowAnimationSprite.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + 32;
			ParticleRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			ParticleRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + 33;
		}

		public override int GetLayerCount()
		{
			return BBAPOCIKLOM;
		}

		private void PHNNOICOIAE()
		{
			CFOIPDKEFMM currentGrid = ENCFFNKONOO.CurrentGrid;
			bool cNLILOEEBOJ = MDMKFNKBCGH(currentGrid.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Up));
			bool cNLILOEEBOJ2 = MDMKFNKBCGH(currentGrid.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Down));
			bool aMFCENFNAJJ = MDMKFNKBCGH(currentGrid.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Left));
			bool aMFCENFNAJJ2 = MDMKFNKBCGH(currentGrid.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Right));
			BHFGLGPDLIC(Tiles[0], aMFCENFNAJJ, cNLILOEEBOJ, IEKBFJBLGFM.LeftUp, false, false);
			BHFGLGPDLIC(Tiles[1], aMFCENFNAJJ2, cNLILOEEBOJ, IEKBFJBLGFM.RightUp, true, false);
			BHFGLGPDLIC(Tiles[2], aMFCENFNAJJ2, cNLILOEEBOJ2, IEKBFJBLGFM.RightDown, true, true);
			BHFGLGPDLIC(Tiles[3], aMFCENFNAJJ, cNLILOEEBOJ2, IEKBFJBLGFM.LeftDown, false, true);
			LGLCEHBFCKE();
		}

		private void BHFGLGPDLIC(SpriteRenderer CGGMEBGANNC, bool AMFCENFNAJJ, bool CNLILOEEBOJ, IEKBFJBLGFM DGPLFNDFALP, bool MPOPLONGCDK, bool EDPLFAIMJLH)
		{
			if (GIDBOAKLNCK == null)
			{
				GIDBOAKLNCK = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType());
			}
			Sprite sprite;
			if (AMFCENFNAJJ && CNLILOEEBOJ)
			{
				if (MDMKFNKBCGH(ENCFFNKONOO.CurrentGrid.PHOOMEOBJCB(ENCFFNKONOO, DGPLFNDFALP)))
				{
					sprite = ((!EDPLFAIMJLH) ? GIDBOAKLNCK.Sprites[14] : GIDBOAKLNCK.Sprites[7]);
					if (EDPLFAIMJLH)
					{
						int num = UnityEngine.Random.Range(0, 4) * 90;
						CGGMEBGANNC.transform.localRotation = Quaternion.Euler(0f, 0f, num);
					}
				}
				else
				{
					sprite = ((!EDPLFAIMJLH) ? GIDBOAKLNCK.Sprites[5] : GIDBOAKLNCK.Sprites[6]);
					CGGMEBGANNC.transform.localPosition = new Vector3((!MPOPLONGCDK) ? (-0.5f) : 0.5f, (!EDPLFAIMJLH) ? 0.4f : (-0.6f), 0f);
					IEKBFJBLGFM aJLDJAHHGOJ = ((!EDPLFAIMJLH) ? IEKBFJBLGFM.Up : ((!MPOPLONGCDK) ? IEKBFJBLGFM.Left : IEKBFJBLGFM.Right));
					Cell cell = ENCFFNKONOO.CurrentGrid.PHOOMEOBJCB(ENCFFNKONOO, aJLDJAHHGOJ);
					if (cell != null && cell.EAILOFHFNJO)
					{
						StoneItem component = cell.LBFCDKPCDPB.GetComponent<StoneItem>();
						SpriteRenderer spriteRenderer = ((!MPOPLONGCDK) ? component.Tiles[(!EDPLFAIMJLH) ? 3 : 2] : component.Tiles[(!EDPLFAIMJLH) ? 2 : 3]);
						if (spriteRenderer.enabled)
						{
							spriteRenderer.enabled = false;
						}
					}
					if (EDPLFAIMJLH)
					{
						BAJHMMMEJLN[(!MPOPLONGCDK) ? 3 : 2] = -80;
					}
					else
					{
						BAJHMMMEJLN[MPOPLONGCDK ? 1 : 0] = 1;
					}
					ChangeSorting(KKCPOOALFAD);
				}
			}
			else if (AMFCENFNAJJ)
			{
				sprite = ((!EDPLFAIMJLH) ? HCPAFMILEBE(OFNHLJPMEIP) : HCPAFMILEBE(BIOCFMCBAAM));
				if (EDPLFAIMJLH)
				{
					Vector3 localPosition = CGGMEBGANNC.transform.localPosition;
					localPosition.y = -0.355f;
					CGGMEBGANNC.transform.localPosition = localPosition;
				}
			}
			else if (CNLILOEEBOJ)
			{
				sprite = ((!EDPLFAIMJLH) ? HCPAFMILEBE(GBMCJFHJMHH) : HCPAFMILEBE(GFAMBJEEHPF));
			}
			else if (EDPLFAIMJLH)
			{
				sprite = GIDBOAKLNCK.Sprites[4];
				Vector3 localPosition2 = CGGMEBGANNC.transform.localPosition;
				localPosition2.y = -0.355f;
				CGGMEBGANNC.transform.localPosition = localPosition2;
			}
			else if (MPOPLONGCDK)
			{
				sprite = GIDBOAKLNCK.Sprites[13];
				MPOPLONGCDK = false;
			}
			else
			{
				sprite = GIDBOAKLNCK.Sprites[12];
			}
			CGGMEBGANNC.sprite = sprite;
			CGGMEBGANNC.flipX = MPOPLONGCDK;
		}

		private Sprite HCPAFMILEBE(IList<int> ELNAPJBPKEE)
		{
			ELNAPJBPKEE.KFGEEKGAPDP();
			return GIDBOAKLNCK.Sprites[ELNAPJBPKEE[0]];
		}

		private void PFKLDJGJHMP()
		{
			CFOIPDKEFMM currentGrid = ENCFFNKONOO.CurrentGrid;
			Cell cell = currentGrid.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Left);
			StoneItem stoneItem = null;
			StoneItem stoneItem2 = null;
			StoneItem stoneItem3 = null;
			if (MDMKFNKBCGH(cell))
			{
				stoneItem = (StoneItem)cell.LBFCDKPCDPB;
			}
			cell = currentGrid.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Up);
			if (MDMKFNKBCGH(cell))
			{
				stoneItem2 = (StoneItem)cell.LBFCDKPCDPB;
			}
			cell = currentGrid.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.LeftUp);
			if (MDMKFNKBCGH(cell))
			{
				stoneItem3 = (StoneItem)cell.LBFCDKPCDPB;
			}
			if (stoneItem3 != null && stoneItem2 != null && stoneItem != null)
			{
				stoneItem.CCOBEOHLAID();
				stoneItem2.CCOBEOHLAID();
				stoneItem3.CCOBEOHLAID();
				CCOBEOHLAID();
			}
		}

		private void LGLCEHBFCKE()
		{
			PFKLDJGJHMP();
			int num = UnityEngine.Random.Range(0, 10);
			if (num < 6 && !BJGKOCABGAP)
			{
				int num2 = 19 + UnityEngine.Random.Range(0, 5);
				SpriteRenderer spriteRenderer = Effects[0];
				spriteRenderer.sprite = GIDBOAKLNCK.Sprites[num2];
				spriteRenderer.enabled = true;
				if (UnityEngine.Random.Range(0, 10) >= 5)
				{
					EffectsContainer.localScale = new Vector3(-1f, 1f, 1f);
				}
				spriteRenderer.color = new Color(1f, 1f, 1f, UnityEngine.Random.Range(0.6f, 0.8f));
				if (num2 < 4)
				{
					float x = UnityEngine.Random.Range(-0.1f, 0.1f);
					float y = UnityEngine.Random.Range(-0.1f, 0.1f);
					spriteRenderer.transform.localPosition = new Vector3(x, y, 1f);
				}
			}
			if (num >= 4 && num < 9)
			{
				int num3 = 24 + UnityEngine.Random.Range(0, 5);
				SpriteRenderer spriteRenderer2 = Effects[1];
				spriteRenderer2.sprite = GIDBOAKLNCK.Sprites[num3];
				spriteRenderer2.enabled = true;
				float x2 = UnityEngine.Random.Range(-0.3f, 0.3f);
				float y2 = UnityEngine.Random.Range(-0.3f, 0.3f);
				int num4 = UnityEngine.Random.Range(-30, 30);
				spriteRenderer2.transform.localPosition = new Vector3(x2, y2, 1f);
				spriteRenderer2.transform.localRotation = Quaternion.Euler(0f, 0f, num4);
				if (UnityEngine.Random.Range(0, 10) >= 5)
				{
					EffectsContainer.localScale = new Vector3(-1f, 1f, 1f);
				}
				spriteRenderer2.color = new Color(1f, 1f, 1f, UnityEngine.Random.Range(0.8f, 1f));
			}
		}

		private void CCOBEOHLAID()
		{
			BJGKOCABGAP = true;
			Effects[0].enabled = false;
		}

		private bool MDMKFNKBCGH(Cell LBHDELJBONF)
		{
			return LBHDELJBONF != null && LBHDELJBONF.Exists && LBHDELJBONF.EAILOFHFNJO && LBHDELJBONF.LBFCDKPCDPB is StoneItem && ((StoneItem)LBHDELJBONF.LBFCDKPCDPB).StoneId == StoneId;
		}

		public void LinkNeighbours(Cell LBHDELJBONF)
		{
			if (!LBHDELJBONF.Exists || !LBHDELJBONF.EAILOFHFNJO)
			{
				return;
			}
			if (GIDBOAKLNCK == null)
			{
				GIDBOAKLNCK = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType());
			}
			StoneItem stoneItem = LBHDELJBONF.LBFCDKPCDPB as StoneItem;
			if (stoneItem == null || stoneItem.MasterItem != null || stoneItem.IsMasterItem)
			{
				stoneItem = LBHDELJBONF.LBFCDKPCDPB.GetSubItem() as StoneItem;
				if (stoneItem == null || stoneItem.MasterItem != null || stoneItem.IsMasterItem)
				{
					return;
				}
			}
			if (stoneItem == this)
			{
				IsMasterItem = true;
				StoneId = GOMMJNHNCJO;
				GOMMJNHNCJO++;
				if (OBOPNPKHJDE == null)
				{
					OBOPNPKHJDE = new List<StoneItem>();
				}
			}
			else
			{
				stoneItem.StoneId = StoneId;
			}
			stoneItem.MasterItem = this;
			OBOPNPKHJDE.Add(stoneItem);
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
			stoneItem.PHNNOICOIAE();
		}

		public override void PlayExplodeAudio()
		{
		}

		protected override void EJCFANPAMMK()
		{
			MNFFFNFJCMG(4);
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			if (JOLBFHDFHAA())
			{
				return false;
			}
			IKNDHGOPKMD(ENCFFNKONOO, 0);
			MasterItem.OOLNOCMHDFA();
			if (CCPAJBOJDMN.JKJHJDLHCMD)
			{
				ScoreManager.RaiseScore(GetScore());
			}
			return false;
		}

		private void IKNDHGOPKMD(Cell LBHDELJBONF, int CMAJLIAELDP)
		{
			if (!LBHDELJBONF.Exists || !LBHDELJBONF.EAILOFHFNJO)
			{
				return;
			}
			StoneItem stoneItem = LBHDELJBONF.LBFCDKPCDPB as StoneItem;
			if (!(stoneItem == null) && stoneItem.ExplosionOrder > CMAJLIAELDP)
			{
				stoneItem.ExplosionOrder = CMAJLIAELDP;
				int cMAJLIAELDP = CMAJLIAELDP + 1;
				CFOIPDKEFMM currentGrid = LBHDELJBONF.CurrentGrid;
				Cell cell = currentGrid.PHOOMEOBJCB(LBHDELJBONF, IEKBFJBLGFM.Left);
				if (cell != null)
				{
					IKNDHGOPKMD(cell, cMAJLIAELDP);
				}
				Cell cell2 = currentGrid.PHOOMEOBJCB(LBHDELJBONF, IEKBFJBLGFM.Right);
				if (cell2 != null)
				{
					IKNDHGOPKMD(cell2, cMAJLIAELDP);
				}
				Cell cell3 = currentGrid.PHOOMEOBJCB(LBHDELJBONF, IEKBFJBLGFM.Up);
				if (cell3 != null)
				{
					IKNDHGOPKMD(cell3, cMAJLIAELDP);
				}
				Cell cell4 = currentGrid.PHOOMEOBJCB(LBHDELJBONF, IEKBFJBLGFM.Down);
				if (cell4 != null)
				{
					IKNDHGOPKMD(cell4, cMAJLIAELDP);
				}
			}
		}

		private bool JOLBFHDFHAA()
		{
			BBAPOCIKLOM--;
			if (BBAPOCIKLOM > 0)
			{
				CurrentSpriteRenderer.sprite = GIDBOAKLNCK.Sprites[DPLIJCAHCPF[BBAPOCIKLOM - 1]];
				CurrentSpriteRenderer.transform.localEulerAngles = Vector3.zero;
				switch (BBAPOCIKLOM)
				{
				case 4:
					AudioManager.PlayAudioProps(GIDBOAKLNCK.AudioClips[0]);
					MNFFFNFJCMG(0);
					CurrentSpriteRenderer.transform.localEulerAngles = Vector3.forward * UnityEngine.Random.Range(-70f, 71f);
					break;
				case 3:
					AudioManager.PlayAudioProps(GIDBOAKLNCK.AudioClips[1]);
					MNFFFNFJCMG(1);
					break;
				case 2:
					AudioManager.PlayAudioProps(GIDBOAKLNCK.AudioClips[1]);
					MNFFFNFJCMG(2);
					break;
				case 1:
					AudioManager.PlayAudioProps(GIDBOAKLNCK.AudioClips[1]);
					MNFFFNFJCMG(3);
					AnimationParticle.Play();
					CurrentAnimator.Play(OKLGMNAEHDF);
					break;
				}
				return true;
			}
			CurrentSpriteRenderer.enabled = false;
			return false;
		}

		private void MNFFFNFJCMG(int OLOEJNBENMK)
		{
			if (ParticlePool.Instance != null)
			{
				ParticlePool.Instance.PlayParticle(GIDBOAKLNCK.Particles[OLOEJNBENMK], base.transform.position);
			}
		}

		private void OOLNOCMHDFA()
		{
			OBOPNPKHJDE.Sort((StoneItem MNIMEAMHNMI, StoneItem BCIHLCMFAEK) => (MNIMEAMHNMI.ExplosionOrder != BCIHLCMFAEK.ExplosionOrder) ? ((MNIMEAMHNMI.ExplosionOrder > BCIHLCMFAEK.ExplosionOrder) ? 1 : (-1)) : 0);
			List<FJEEKMHKDOJ> list = new List<FJEEKMHKDOJ>();
			for (int i = 0; i < OBOPNPKHJDE.Count; i++)
			{
				list.Add(new FJEEKMHKDOJ
				{
					AHANCLBKKID = OBOPNPKHJDE[i],
					BHIJCAOHDCM = OBOPNPKHJDE[i].ExplosionOrder
				});
			}
			new LLCJMMBBLEH(KFDAAFAGJBE(list));
		}

		private IEnumerator KFDAAFAGJBE(List<FJEEKMHKDOJ> NLADMJEEGNJ)
		{
			FallManager.IncreaseStatAnimation();
			int num = 0;
			int count = NLADMJEEGNJ.Count;
			for (int i = 0; i < count; i++)
			{
				if (NLADMJEEGNJ[i].BHIJCAOHDCM != num)
				{
					num++;
					yield return MCJHHDACJBG.CNDGGNLKOOC;
				}
				if (NLADMJEEGNJ[i].AHANCLBKKID != null)
				{
					NLADMJEEGNJ[i].AHANCLBKKID.StartExplode();
				}
			}
			FallManager.DecreaseStatAnimation();
		}

		public override void StartExplode()
		{
			if (!DJIFKHIOMNO)
			{
				DJIFKHIOMNO = true;
				AudioManager.PlayAudioProps(GIDBOAKLNCK.AudioClips[2]);
				ELFBOKDHKGG.ACJOALJFMHN(NOALGNJECAD.Stone, false);
				ScoreManager.RaiseScore(GetScore());
				base.StartExplode();
			}
		}

		public override void RemoveSelf()
		{
			StartCoroutine(CJOHLENDJGO());
		}

		private IEnumerator CJOHLENDJGO()
		{
			yield return MCJHHDACJBG.CNDGGNLKOOC;
			EMPCLKHBOBO();
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 99;
			byte aINNOPBDDGL = (byte)GetLayerCount();
			PNINCDLIDLL.DKJDLMNKFGM(aINNOPBDDGL);
		}

		protected void DGCBHOBKOCH(int PKHFDMGGGJN)
		{
			BBAPOCIKLOM = PKHFDMGGGJN;
		}

		[CompilerGenerated]
		private static int DAKPCFHEBIH(StoneItem MNIMEAMHNMI, StoneItem BCIHLCMFAEK)
		{
			if (MNIMEAMHNMI.ExplosionOrder == BCIHLCMFAEK.ExplosionOrder)
			{
				return 0;
			}
			return (MNIMEAMHNMI.ExplosionOrder > BCIHLCMFAEK.ExplosionOrder) ? 1 : (-1);
		}

		[CompilerGenerated]
		[DebuggerHidden]
		private void EMPCLKHBOBO()
		{
			base.RemoveSelf();
		}
	}
}
