using System.Collections;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class VaseItem : SpriteBasedItem
	{
		public Animator CurrentAnimator;

		public SpriteRenderer[] PouchSprites;

		public GameObject VaseReference;

		public GameObject PouchReference;

		public Transform ShadowTransform;

		private LEDBLDKJBAI DPMFLCCMHLM;

		private LKDHEOPBAFN HCEHJCHHNFE;

		private int HBBBJLFIOCB = 2;

		private bool PIGCJDKPMFL;

		private Coroutine OJCIIJDFJIL;

		public void SetupItem(LKDHEOPBAFN NBFBPNNEKMN)
		{
			HCEHJCHHNFE = NBFBPNNEKMN;
			switch (HCEHJCHHNFE)
			{
			case LKDHEOPBAFN.VaseYellow:
				DPMFLCCMHLM = LEDBLDKJBAI.Yellow;
				break;
			case LKDHEOPBAFN.VaseRed:
				DPMFLCCMHLM = LEDBLDKJBAI.Red;
				break;
			case LKDHEOPBAFN.VaseBlue:
				DPMFLCCMHLM = LEDBLDKJBAI.Blue;
				break;
			case LKDHEOPBAFN.VaseGreen:
				DPMFLCCMHLM = LEDBLDKJBAI.Green;
				break;
			case LKDHEOPBAFN.VasePurple:
				DPMFLCCMHLM = LEDBLDKJBAI.Purple;
				break;
			case LKDHEOPBAFN.VaseOrange:
				DPMFLCCMHLM = LEDBLDKJBAI.Orange;
				break;
			default:
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.ColoredBalloonItem, "Cannot Initialize Vase item with type: " + NBFBPNNEKMN);
				break;
			}
			CurrentSpriteRenderer.sprite = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Sprites[(int)(HCEHJCHHNFE - 1)];
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Vase;
		}

		public override int GetScore()
		{
			return 500;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return HBBBJLFIOCB != 2 || KOINNGEBMJI == DPMFLCCMHLM;
		}

		public override bool CanBeTapped()
		{
			return false;
		}

		public override int GetLayerCount()
		{
			return HBBBJLFIOCB;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			CurrentSpriteRenderer.sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
			CurrentSpriteRenderer.sortingOrder = IBBBMACIBGK.BHIJCAOHDCM;
			int i = 0;
			for (int num = PouchSprites.Length; i < num; i++)
			{
				PouchSprites[i].sortingLayerID = IBBBMACIBGK.MMFFDANAEEI;
				PouchSprites[i].sortingOrder = IBBBMACIBGK.BHIJCAOHDCM + i;
			}
		}

		public override void BringToFront()
		{
			CKKKELDIOLD sorting = GetSorting();
			sorting.BHIJCAOHDCM += 249;
			ChangeSorting(sorting);
		}

		public override void SendToBack()
		{
			DEIFPMCEKCO();
		}

		public override bool CanCastShadow()
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
			if (HBBBJLFIOCB == 2)
			{
				OJCIIJDFJIL = StartCoroutine(KJNCPPMHLPE());
				return false;
			}
			PIGCJDKPMFL = true;
			return true;
		}

		private IEnumerator KJNCPPMHLPE()
		{
			HBBBJLFIOCB--;
			PouchReference.SetActive(true);
			VaseReference.SetActive(false);
			ShadowTransform.localPosition = Vector3.up * -0.514f;
			if (ParticlePool.Instance != null)
			{
				VaseTransformParticlePlayer vaseTransformParticlePlayer = ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[0], base.transform.position) as VaseTransformParticlePlayer;
				vaseTransformParticlePlayer.SetColor(DPMFLCCMHLM);
			}
			AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[0]);
			BringToFront();
			CurrentAnimator.Play(Animator.StringToHash("Base Layer.VaseItemTransformAnimation"), -1, 0f);
			yield return new WaitForSeconds(0.46f);
			SendToBack();
		}

		public override void PlayExplodeAudio()
		{
			if (!(ItemResourcesManager.GABGKBAKHDP == null))
			{
				AudioManager.PlayAudioProps(BBKCPPOFENL.AudioClips[1]);
			}
		}

		protected override void EJCFANPAMMK()
		{
			if (!(ParticlePool.Instance == null))
			{
				ParticlePool.Instance.PlayParticle(BBKCPPOFENL.Particles[1], base.transform.position);
			}
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			HBBBJLFIOCB = 0;
			base.ExplodeByBlasterItem(CCPAJBOJDMN);
		}

		private void OnDestroy()
		{
			if (OJCIIJDFJIL != null)
			{
				StopCoroutine(OJCIIJDFJIL);
			}
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = (short)(35 + DPMFLCCMHLM);
			byte aINNOPBDDGL = (byte)HBBBJLFIOCB;
			PNINCDLIDLL.DKJDLMNKFGM(aINNOPBDDGL);
		}

		protected void DGCBHOBKOCH(int PKHFDMGGGJN)
		{
			HBBBJLFIOCB = PKHFDMGGGJN;
		}
	}
}
