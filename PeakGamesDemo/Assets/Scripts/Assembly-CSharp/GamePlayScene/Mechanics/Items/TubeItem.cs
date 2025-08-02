using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class TubeItem : Item, JFIEHOCCBNG
	{
		private static int NIPJFEFGFDH;

		private static int[] NCHIBLJBPOJ;

		public TubeFakeItem[] FakeItems;

		public SpriteRenderer[] SpriteRenderers;

		public Animator[] Animators;

		public TubeBottle[] TubeBottles;

		private const int FKNAKBPMAAO = 3;

		private int LFCHJCKMMIH;

		private int OKJOGFBHOPE;

		private LEDBLDKJBAI GIGJIOHBALP;

		private CKKKELDIOLD KKCPOOALFAD;

		private List<TubeBottle> AMHGLBAGDJF;

		private int[] DFEMACNFENA;

		private int[] AGFDFAFACGK;

		private bool PIGCJDKPMFL;

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
					for (int i = 0; i < FakeItems.Length; i++)
					{
						TubeFakeItem tubeFakeItem = FakeItems[i];
						if (!(tubeFakeItem == null))
						{
							int aMFCENFNAJJ = ENCFFNKONOO.X + i % 3;
							int cNLILOEEBOJ = ENCFFNKONOO.Y + i / 3;
							tubeFakeItem.ENCFFNKONOO = ENCFFNKONOO.CurrentGrid.ECNCPJGHBIG(aMFCENFNAJJ, cNLILOEEBOJ);
						}
					}
					return;
				}
				for (int j = 0; j < FakeItems.Length; j++)
				{
					TubeFakeItem tubeFakeItem2 = FakeItems[j];
					if (!(tubeFakeItem2 == null))
					{
						tubeFakeItem2.ENCFFNKONOO = null;
					}
				}
			}
		}

		public void Init(LEDBLDKJBAI PFDINDHJOCC)
		{
			GIGJIOHBALP = PFDINDHJOCC;
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Tube;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			SpriteRenderers[0].sortingOrder = NCHIBLJBPOJ[0] + IBBBMACIBGK.BHIJCAOHDCM;
			SpriteRenderers[1].sortingOrder = NCHIBLJBPOJ[1] + IBBBMACIBGK.BHIJCAOHDCM;
			KKCPOOALFAD = IBBBMACIBGK;
			for (int i = 2; i < SpriteRenderers.Length; i++)
			{
				SpriteRenderers[i].sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
				SpriteRenderers[i].sortingOrder = 1100 + NCHIBLJBPOJ[i];
			}
			for (int j = 0; j < TubeBottles.Length; j++)
			{
				TubeBottle tubeBottle = TubeBottles[j];
				if (tubeBottle != null)
				{
					tubeBottle.UpdateSorting(1100);
				}
			}
		}

		public override CKKKELDIOLD GetSorting()
		{
			return KKCPOOALFAD;
		}

		public override bool CanShadowDrop()
		{
			return true;
		}

		public override void OnItemCreated(KFCEILFGADG MGOFDOMDLCO)
		{
			base.OnItemCreated(MGOFDOMDLCO);
			MJJDEMKDIEM();
			ELFBOKDHKGG.OGIJEDJHMNG.Add(this);
			int value = 4;
			HintManager.Instance.CurrentLevelBuilder.GoalCountDict.TryGetValue(GetItemType(), out value);
			value /= 8;
			AMHGLBAGDJF = new List<TubeBottle>();
			for (int i = 0; i < TubeBottles.Length; i++)
			{
				AMHGLBAGDJF.Add(TubeBottles[i]);
				TubeBottles[i].Init(7 - i, value, BBKCPPOFENL);
			}
			OKJOGFBHOPE = MGOFDOMDLCO.EBMFPDNPIEM;
			if (NCHIBLJBPOJ == null)
			{
				int num = SpriteRenderers.Length;
				NCHIBLJBPOJ = new int[num];
				for (int j = 0; j < num; j++)
				{
					if (!(SpriteRenderers[j] == null))
					{
						NCHIBLJBPOJ[j] = SpriteRenderers[j].sortingOrder;
					}
				}
			}
			UpdateView();
		}

		public override void PlayExplodeAudio()
		{
		}

		public override void PlayWrongMove()
		{
			OEJMJEKLFKE(AMHGLBAGDJF.Count > 3);
			JLACLGOFALJ();
			JPFPENMHKFE(CHAMLKBCMIF(IEKBFJBLGFM.None));
		}

		public void ExplosionOccured(int CIDKKPKJJAE)
		{
			if (!PIGCJDKPMFL && OKJOGFBHOPE != CIDKKPKJJAE)
			{
				OKJOGFBHOPE = CIDKKPKJJAE;
				GIGJIOHBALP = ELFBOKDHKGG.FBKNLKDOAKD(NOALGNJECAD.Tube, ref LFCHJCKMMIH);
				IIGEMHJHOAL();
				FOIPFLGGPFP();
			}
		}

		private void IIGEMHJHOAL()
		{
			if (AMHGLBAGDJF.Count > 3)
			{
				NIPJFEFGFDH = Time.frameCount;
			}
			StartCoroutine(FPAMPFKENOG());
		}

		private IEnumerator FPAMPFKENOG()
		{
			yield return null;
			OEJMJEKLFKE(Time.frameCount > NIPJFEFGFDH && Time.frameCount < NIPJFEFGFDH + 5);
		}

		private void OEJMJEKLFKE(bool CHEODPJOHCJ)
		{
			if (CHEODPJOHCJ)
			{
				AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[Random.Range(0, 2)]);
			}
		}

		private void FOIPFLGGPFP()
		{
			for (int num = AMHGLBAGDJF.Count - 1; num >= 0; num--)
			{
				AMHGLBAGDJF[num].TransformToColorByMatchType(GIGJIOHBALP, false);
			}
		}

		public override void RemoveAllLayers()
		{
			while (AMHGLBAGDJF.Count > 0)
			{
				KBBGLHOFLJK();
			}
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (!PIGCJDKPMFL)
			{
				RemoveAllLayers();
				base.ExplodeByBlasterItem(CCPAJBOJDMN);
			}
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return KOINNGEBMJI == GIGJIOHBALP;
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			return ExplodeBy(IEKBFJBLGFM.LeftDown, CCPAJBOJDMN);
		}

		private void GCJHFEOBKKL()
		{
			AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[11]);
			base.gameObject.SetActive(false);
		}

		private void KBBGLHOFLJK()
		{
			if (AMHGLBAGDJF.Count != 0)
			{
				int num = AMHGLBAGDJF.Count - 1;
				if (num > 0)
				{
					ELFBOKDHKGG.ACJOALJFMHN(NOALGNJECAD.Tube, false);
				}
				TubeBottle tubeBottle = AMHGLBAGDJF[num];
				tubeBottle.Explode();
				ScoreManager.RaiseScore(500);
				AMHGLBAGDJF.RemoveAt(num);
			}
		}

		public override bool CanFall()
		{
			return false;
		}

		public override int GetLayerCount()
		{
			return AMHGLBAGDJF.Count;
		}

		public override int GetScore()
		{
			return 0;
		}

		public override bool CanGenerateScoreOnEachTryExplode()
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

		public override Vector3 GetCenterPositionOffset(APBDPLNCDIJ CCPAJBOJDMN)
		{
			return new Vector3(1f, 1f, 0f);
		}

		protected override void EJCFANPAMMK()
		{
		}

		private void JLACLGOFALJ()
		{
			Animators[9].Play(DFEMACNFENA[8], 0, 0f);
			for (int i = 0; i < 8; i++)
			{
				if (!(Animators[i] == null) && Animators[i].isActiveAndEnabled)
				{
					Animators[i].Play(DFEMACNFENA[i], 0, 0f);
					TubeBottle tubeBottle = TubeBottles[7 - i];
					if (tubeBottle != null)
					{
						tubeBottle.PlayParticle();
					}
				}
			}
		}

		private void JPFPENMHKFE(int EHJNMODJEAN)
		{
			Animators[8].Play(AGFDFAFACGK[EHJNMODJEAN], 0, 0f);
		}

		private void MJJDEMKDIEM()
		{
			DFEMACNFENA = new int[9];
			for (int i = 0; i < 8; i++)
			{
				DFEMACNFENA[i] = Animator.StringToHash("Base Layer.TubeBottleAnimation" + (i + 1) + "_shake1");
			}
			DFEMACNFENA[8] = Animator.StringToHash("Base Layer.TubeBurnerAnimation_shake");
			AGFDFAFACGK = new int[4]
			{
				Animator.StringToHash("Base Layer.TubeBackgroundAnimation_shake1"),
				Animator.StringToHash("Base Layer.TubeBackgroundAnimation_shake2"),
				Animator.StringToHash("Base Layer.TubeBackgroundAnimation_shake3"),
				Animator.StringToHash("Base Layer.TubeBackgroundAnimation_shake4")
			};
		}

		public override void UpdateView()
		{
			LFCHJCKMMIH = ELFBOKDHKGG.APDPLIOJAHC(NOALGNJECAD.Tube, GIGJIOHBALP);
			if (LFCHJCKMMIH == -1)
			{
				GIGJIOHBALP = ELFBOKDHKGG.KIEPOCCJHIC(NOALGNJECAD.Tube, ref LFCHJCKMMIH);
			}
			for (int num = AMHGLBAGDJF.Count - 1; num >= 0; num--)
			{
				TubeBottle tubeBottle = AMHGLBAGDJF[num];
				tubeBottle.TransformToColorByMatchType(GIGJIOHBALP);
			}
		}

		public bool ExplodeBy(IEKBFJBLGFM HNACJFKHCND, APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (PIGCJDKPMFL)
			{
				return false;
			}
			if (CCPAJBOJDMN.ENBPGGCIADN == 13)
			{
				return false;
			}
			if (!LAGEBFBEINC(CCPAJBOJDMN))
			{
				return false;
			}
			KBBGLHOFLJK();
			JLACLGOFALJ();
			JPFPENMHKFE(CHAMLKBCMIF(HNACJFKHCND));
			if (AMHGLBAGDJF.Count > 0)
			{
				return false;
			}
			GCJHFEOBKKL();
			PIGCJDKPMFL = true;
			ELFBOKDHKGG.OGIJEDJHMNG.Remove(this);
			return true;
		}

		private int CHAMLKBCMIF(IEKBFJBLGFM AJLDJAHHGOJ)
		{
			switch (AJLDJAHHGOJ)
			{
			case IEKBFJBLGFM.LeftDown:
				return 0;
			case IEKBFJBLGFM.RightDown:
				return 1;
			case IEKBFJBLGFM.RightUp:
				return 2;
			case IEKBFJBLGFM.LeftUp:
				return 3;
			case IEKBFJBLGFM.Down:
				return (Random.Range(0, 2) != 0) ? 1 : 0;
			case IEKBFJBLGFM.Right:
				return (Random.Range(0, 2) == 0) ? 1 : 2;
			case IEKBFJBLGFM.Up:
				return (Random.Range(0, 2) != 0) ? 3 : 2;
			case IEKBFJBLGFM.Left:
				return (Random.Range(0, 2) != 0) ? 3 : 0;
			default:
				return Random.Range(0, 4);
			}
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = (short)(281 + (int)GIGJIOHBALP * 3);
			byte aINNOPBDDGL = (byte)GetLayerCount();
			PNINCDLIDLL.DKJDLMNKFGM(aINNOPBDDGL);
		}

		protected void DGCBHOBKOCH(int PKHFDMGGGJN)
		{
			for (int num = AMHGLBAGDJF.Count - 1; num >= PKHFDMGGGJN; num--)
			{
				AMHGLBAGDJF[num].gameObject.SetActive(false);
				AMHGLBAGDJF.RemoveAt(num);
			}
		}
	}
}
