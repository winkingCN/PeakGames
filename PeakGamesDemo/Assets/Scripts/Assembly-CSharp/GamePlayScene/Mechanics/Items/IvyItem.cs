using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.Utils;
using DG.Tweening;
using GamePlayScene.Mechanics.Animations;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class IvyItem : CellItem
	{
		public Transform PositionFixer;

		private float DOAKDOGFPPL = -1f;

		private int JHIABECKOLP;

		private int FGKHPEONDLM;

		private CKKKELDIOLD KKCPOOALFAD;

		private IvyAnimator NGNKCKHKJNI;

		private IvySpreadAnimation OFGKKPBEDGP;

		private static List<int> NCHIBLJBPOJ;

		private Sequence LCPJGPGGAEK;

		public IvySpreadAnimation GMFMOBCBDAE
		{
			set
			{
				OFGKKPBEDGP = value;
			}
		}

		public static void InitSortingOrders()
		{
			NCHIBLJBPOJ = new List<int>(81);
			for (int i = 0; i < 81; i++)
			{
				NCHIBLJBPOJ.Add(i);
			}
			NCHIBLJBPOJ.KFGEEKGAPDP();
		}

		public static int GetIvyCellSortingOrder(int AMFCENFNAJJ, int CNLILOEEBOJ)
		{
			int index = CNLILOEEBOJ * 9 + AMFCENFNAJJ;
			return 1350 + NCHIBLJBPOJ[index];
		}

		public override void OnCellGridChange(CFOIPDKEFMM GOAELFDHDGD)
		{
			FGKHPEONDLM = GOAELFDHDGD.FHAMOHDEGMK;
			DOAKDOGFPPL = FGKHPEONDLM - ENCFFNKONOO.Y - 1;
			JHIABECKOLP = (ENCFFNKONOO.X + ENCFFNKONOO.Y) % 2;
			NGNKCKHKJNI = ((!IsRecyclable) ? Object.Instantiate(BBKCPPOFENL.Animators[JHIABECKOLP]).GetComponent<IvyAnimator>() : BBKCPPOFENL.Animators[JHIABECKOLP].JOBDHIPIMAG().GetComponent<IvyAnimator>());
			NGNKCKHKJNI.transform.SetParent(PositionFixer);
			Cell cell = GOAELFDHDGD.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Up);
			bool mGHJIHIPMKC = ENCFFNKONOO.Y == FGKHPEONDLM - 1 || (cell != null && !cell.Exists);
			NGNKCKHKJNI.Prepare(JHIABECKOLP, mGHJIHIPMKC);
			KKCPOOALFAD = IPPOGIEPKEN.Items.EFLCPKAFOBA();
			KKCPOOALFAD.BHIJCAOHDCM = GetIvyCellSortingOrder(ENCFFNKONOO.X, ENCFFNKONOO.Y);
			ChangeSorting(KKCPOOALFAD);
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Ivy;
		}

		public override int GetScore()
		{
			return 500;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			NGNKCKHKJNI.ChangeSorting(IBBBMACIBGK);
		}

		public override CKKKELDIOLD GetSorting()
		{
			return default(CKKKELDIOLD);
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return true;
		}

		public override void PlayWrongMove()
		{
			if (NGNKCKHKJNI != null)
			{
				NGNKCKHKJNI.PlayShakeAnimation();
			}
		}

		public override void BringToFront()
		{
			CKKKELDIOLD kKCPOOALFAD = KKCPOOALFAD;
			kKCPOOALFAD.MMFFDANAEEI = SortingLayer.NameToID("Dialogs");
			ChangeSorting(kKCPOOALFAD);
		}

		public override void SendToBack()
		{
			ChangeSorting(KKCPOOALFAD);
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
			ELFBOKDHKGG.ACJOALJFMHN(NOALGNJECAD.Ivy, true);
			if (CanRaiseScore())
			{
				ScoreManager.RaiseScore(GetScore());
			}
			DoRecycle();
			return true;
		}

		protected override void PFMCDDPFKGO()
		{
			base.PFMCDDPFKGO();
			if (OFGKKPBEDGP != null)
			{
				OFGKKPBEDGP.TryRecycle();
			}
			if (NGNKCKHKJNI != null)
			{
				NGNKCKHKJNI.Recycle();
			}
			OFGKKPBEDGP = null;
			NGNKCKHKJNI = null;
			DOAKDOGFPPL = -1f;
			FGKHPEONDLM = 0;
			JHIABECKOLP = 0;
			if (LCPJGPGGAEK != null)
			{
				LCPJGPGGAEK.Kill();
				LCPJGPGGAEK = null;
			}
		}

		public override void UpdateOnFallBehind()
		{
			base.UpdateOnFallBehind();
			if (LCPJGPGGAEK != null)
			{
				LCPJGPGGAEK.Kill();
			}
			LCPJGPGGAEK = DOTween.Sequence();
			LCPJGPGGAEK.InsertCallback(DOAKDOGFPPL * 0.05f, delegate
			{
				NGNKCKHKJNI.PlayShakeAnimation();
			});
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 68;
		}

		[CompilerGenerated]
		private void KLOJHJJILBL()
		{
			NGNKCKHKJNI.PlayShakeAnimation();
		}
	}
}
