using System.Collections;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.GamePlayScene.Mechanics.Items.Features;
using Assets.Scripts.Utils;
using Medvedya.SpriteDeformerTools;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class GiantPinataItem : Item
	{
		private IEKBFJBLGFM PEAGKCJGHKE;

		public Animator GiantPinataAnimator;

		public GiantPinataFakeItem BottomRight;

		public GiantPinataFakeItem TopLeft;

		public GiantPinataFakeItem TopRight;

		public SpriteRenderer BaseImage;

		public MeshRenderer DonkeyMesh;

		public MeshRenderer RopeMesh;

		public ParticleSystem ToDownParticle;

		public ParticleSystem ToLeftParticle;

		public ParticleSystem ToRightParticle;

		public ParticleSystem ToUpParticle;

		public ParticlePlayer FinalParticle;

		public SpriteDeformerAnimation DonkeyImage;

		public Transform DonkeyImagePosition;

		public SpriteDeformerAnimation RopeImage;

		private float MFGJPEAADEO;

		private int IKNIJCEHCHO;

		private bool KKJKEMCNFGD;

		private bool CFOJPHNGMHA;

		private CKKKELDIOLD KKCPOOALFAD;

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
					TopLeft.ENCFFNKONOO = ENCFFNKONOO.CurrentGrid.ECNCPJGHBIG(ENCFFNKONOO.X, ENCFFNKONOO.Y + 1);
					TopRight.ENCFFNKONOO = ENCFFNKONOO.CurrentGrid.ECNCPJGHBIG(ENCFFNKONOO.X + 1, ENCFFNKONOO.Y + 1);
					BottomRight.ENCFFNKONOO = ENCFFNKONOO.CurrentGrid.ECNCPJGHBIG(ENCFFNKONOO.X + 1, ENCFFNKONOO.Y);
				}
				else
				{
					TopLeft.ENCFFNKONOO = null;
					TopRight.ENCFFNKONOO = null;
					BottomRight.ENCFFNKONOO = null;
				}
			}
		}

		public void SetLastDirection(IEKBFJBLGFM AJLDJAHHGOJ)
		{
			PEAGKCJGHKE = AJLDJAHHGOJ;
		}

		public override CKKKELDIOLD GetSorting()
		{
			return KKCPOOALFAD;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			KKCPOOALFAD = IBBBMACIBGK;
			DonkeyMesh.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			DonkeyMesh.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + 270;
			RopeMesh.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			RopeMesh.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM;
			BaseImage.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			BaseImage.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + 1;
		}

		public override int GetScore()
		{
			return 5000;
		}

		public override void OnFallEnded()
		{
			base.OnFallEnded();
			Cell currentCell = BottomRight.ENCFFNKONOO;
			if (currentCell != null)
			{
				CanCastShadowComponent.CastShadowIfPossible(currentCell);
			}
		}

		public override bool CanFall()
		{
			return false;
		}

		public override bool CanBeInsideCellItem()
		{
			return false;
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.GiantPinata;
		}

		public override void SetExplodeDirection(IEKBFJBLGFM AJLDJAHHGOJ)
		{
			PEAGKCJGHKE = AJLDJAHHGOJ;
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (!KKJKEMCNFGD)
			{
				IKNIJCEHCHO = 2;
				MFGJPEAADEO = Time.time;
				base.ExplodeByBlasterItem(CCPAJBOJDMN);
			}
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (KKJKEMCNFGD)
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
			IKNIJCEHCHO++;
			if (GiantPinataAnimator.GetInteger("DIRECTION") == 0 || (GiantPinataAnimator.GetInteger("STATE") == 1 && IKNIJCEHCHO == 2))
			{
				int value;
				switch (PEAGKCJGHKE)
				{
				case IEKBFJBLGFM.Up:
					NHNDBKAAMML(ToDownParticle);
					value = 3;
					break;
				case IEKBFJBLGFM.Down:
					NHNDBKAAMML(ToUpParticle);
					value = 1;
					break;
				case IEKBFJBLGFM.Left:
					NHNDBKAAMML(ToRightParticle);
					value = 2;
					break;
				default:
					NHNDBKAAMML(ToLeftParticle);
					value = 4;
					break;
				}
				if (MFGJPEAADEO + 0.2f < Time.time)
				{
					GiantPinataAnimator.SetInteger("STATE", IKNIJCEHCHO);
					GiantPinataAnimator.SetInteger("DIRECTION", value);
					MFGJPEAADEO = Time.time;
				}
			}
			if (IKNIJCEHCHO < 3 && ItemResourcesManager.GABGKBAKHDP != null && ItemResourcesManager.GABGKBAKHDP != null)
			{
				AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[0]);
			}
			StartCoroutine(LIDBCGIOBGN());
			if (IKNIJCEHCHO != 3)
			{
				return false;
			}
			KKJKEMCNFGD = true;
			FinalParticle.gameObject.SetActive(true);
			FinalParticle.PlayWithoutParent();
			return true;
		}

		private void NHNDBKAAMML(ParticleSystem CAEMELGEOAE)
		{
			HCLOHDAMJIC(CAEMELGEOAE, ToUpParticle);
			HCLOHDAMJIC(CAEMELGEOAE, ToDownParticle);
			HCLOHDAMJIC(CAEMELGEOAE, ToLeftParticle);
			HCLOHDAMJIC(CAEMELGEOAE, ToRightParticle);
		}

		private void HCLOHDAMJIC(Component CAEMELGEOAE, ParticleSystem JBMOGPKJDBO)
		{
			GameObject gameObject = JBMOGPKJDBO.gameObject;
			if (CAEMELGEOAE == JBMOGPKJDBO)
			{
				gameObject.SetActive(true);
				JBMOGPKJDBO.Play();
			}
			else if (gameObject.activeSelf)
			{
				gameObject.SetActive(false);
			}
		}

		public override void PlayExplodeAudio()
		{
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[1]);
			}
		}

		private IEnumerator LIDBCGIOBGN()
		{
			yield return MCJHHDACJBG.CNDGGNLKOOC;
			int num = IKNIJCEHCHO;
			if (num > 2)
			{
				num = 2;
			}
			if (!(ItemResourcesManager.GABGKBAKHDP == null))
			{
				ItemResources resources = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType());
				DonkeyImage.MJOJAOIHCIO = resources.Sprites[num];
			}
		}

		public override void StartExplode()
		{
			if (!CFOJPHNGMHA)
			{
				CFOJPHNGMHA = true;
				base.StartExplode();
			}
		}

		protected override void EJCFANPAMMK()
		{
		}

		public override bool CanBeInsideBubble()
		{
			return false;
		}

		public override int GetLayerCount()
		{
			return 3 - IKNIJCEHCHO;
		}

		public override Vector3 GetCenterPositionOffset(APBDPLNCDIJ CCPAJBOJDMN)
		{
			return new Vector3(0.5f, 0.5f, 0f);
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 72;
			byte aINNOPBDDGL = (byte)GetLayerCount();
			PNINCDLIDLL.DKJDLMNKFGM(aINNOPBDDGL);
		}

		protected void BJIFNMPHEEE(int ELBFJPCPAKF)
		{
			IKNIJCEHCHO = ELBFJPCPAKF;
		}
	}
}
