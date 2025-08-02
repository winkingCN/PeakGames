using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.GamePlayScene.Mechanics.Items.SpecialItems;
using Assets.Scripts.Utils;
using DG.Tweening;
using GamePlayScene.Mechanics.Items.SpecialItems;
using UnityEngine;
using Utils;

namespace GamePlayScene.Mechanics.Items.ComboItems
{
	public class RocketAndBombItem : SpecialItem, PGCMDKBCMHI
	{
		public GameObject InUseObjects;

		private PBLOIKDOPAJ KPAKBHKNCNP;

		private int DLDOMGCNDLN;

		private int GAEPGFKDBAP;

		private const float HIMGADLAJPK = 0.07f;

		public ParticleSystem RocketAndBombParticle1;

		public ParticleSystem RocketAndBombParticle2;

		public GameObject InUseAnimation;

		public Animator TheAnimator;

		protected override void OOCKFIDFIPL()
		{
		}

		public void SetComboGroup(PBLOIKDOPAJ FNEALCOPNND)
		{
			KPAKBHKNCNP = FNEALCOPNND;
		}

		public void AddScore(int AAIEJDNAODP)
		{
			DLDOMGCNDLN += AAIEJDNAODP;
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.RocketAndBomb;
		}

		public override int GetScore()
		{
			return 750 + DLDOMGCNDLN;
		}

		private int EJBPCMDJFEM(CFOIPDKEFMM CLCHKLJBIFH, int AMFCENFNAJJ, int CNLILOEEBOJ, APBDPLNCDIJ CCPAJBOJDMN)
		{
			PlayRandomSpineAnimations.ComboItemWillExplode = true;
			if (AMFCENFNAJJ < 0 || AMFCENFNAJJ >= CLCHKLJBIFH.EMFKAPJMDCC || CNLILOEEBOJ < 0 || CNLILOEEBOJ >= CLCHKLJBIFH.FHAMOHDEGMK)
			{
				return 0;
			}
			Cell cell = CLCHKLJBIFH.ECNCPJGHBIG(AMFCENFNAJJ, CNLILOEEBOJ);
			if (cell.HasCellItem())
			{
				int score = cell.FEMFMBLMKHP.GetScore();
				if (ADCAOOPHFPK(cell, CCPAJBOJDMN))
				{
					return score;
				}
			}
			Item currentItem = cell.LBFCDKPCDPB;
			int num = 0;
			bool flag = false;
			if (currentItem != null)
			{
				num = currentItem.GetScore();
				flag = currentItem.CanGenerateScoreWithoutExplode();
			}
			if (ADCAOOPHFPK(cell, CCPAJBOJDMN))
			{
				return SpecialItem.LPKIMIHHJCK(currentItem, cell);
			}
			int num2 = 0;
			if (cell.EAILOFHFNJO && cell.LBFCDKPCDPB.CanGenerateScoreOnEachTryExplode() && cell.LBFCDKPCDPB.CanGenerateScoreThisTurn())
			{
				num2 += num;
			}
			else if (!cell.EAILOFHFNJO && flag && num > 0)
			{
				num2 += num;
			}
			if (cell.EAILOFHFNJO && cell.LBFCDKPCDPB.IsSpecialItem())
			{
				((SpecialItem)currentItem).SpecialItemCanOnlyExplodeSelf = false;
			}
			return num2;
		}

		private IEnumerator DDEPNBNGBPL(CFOIPDKEFMM CLCHKLJBIFH, int AMFCENFNAJJ, int CNLILOEEBOJ, APBDPLNCDIJ CCPAJBOJDMN)
		{
			yield return null;
			GAEPGFKDBAP += EJBPCMDJFEM(CLCHKLJBIFH, AMFCENFNAJJ + 1, CNLILOEEBOJ, CCPAJBOJDMN);
			GAEPGFKDBAP += EJBPCMDJFEM(CLCHKLJBIFH, AMFCENFNAJJ - 1, CNLILOEEBOJ, CCPAJBOJDMN);
			GAEPGFKDBAP += EJBPCMDJFEM(CLCHKLJBIFH, AMFCENFNAJJ, CNLILOEEBOJ + 1, CCPAJBOJDMN);
			GAEPGFKDBAP += EJBPCMDJFEM(CLCHKLJBIFH, AMFCENFNAJJ, CNLILOEEBOJ - 1, CCPAJBOJDMN);
			yield return new WaitForSeconds(0.07f);
			GAEPGFKDBAP += EJBPCMDJFEM(CLCHKLJBIFH, AMFCENFNAJJ + 1, CNLILOEEBOJ + 1, CCPAJBOJDMN);
			GAEPGFKDBAP += EJBPCMDJFEM(CLCHKLJBIFH, AMFCENFNAJJ - 1, CNLILOEEBOJ - 1, CCPAJBOJDMN);
			GAEPGFKDBAP += EJBPCMDJFEM(CLCHKLJBIFH, AMFCENFNAJJ - 1, CNLILOEEBOJ + 1, CCPAJBOJDMN);
			GAEPGFKDBAP += EJBPCMDJFEM(CLCHKLJBIFH, AMFCENFNAJJ + 1, CNLILOEEBOJ - 1, CCPAJBOJDMN);
		}

		private IEnumerator KFNEKPJILCJ(HorizontalRocketItem BDNJLOFKIME, Vector3 LDMDBPLADGD, int JKNPBEOPMPK, int NNBCLKAEIJL, CFOIPDKEFMM CLCHKLJBIFH, int CNLILOEEBOJ, int HHHMOGOKFHF, int AJLDJAHHGOJ, APBDPLNCDIJ CCPAJBOJDMN)
		{
			bool flag = AJLDJAHHGOJ > 0;
			BDNJLOFKIME.SwitchToUseMode(!flag, flag, false, false, false);
			Sequence sequence = DOTween.Sequence();
			for (int i = 0; i < HHHMOGOKFHF; i++)
			{
				int PLCFEOMGCFK = AJLDJAHHGOJ * i;
				sequence.Append(BDNJLOFKIME.transform.DOMoveX(LDMDBPLADGD.x - ((i != 0) ? ((float)AJLDJAHHGOJ * 0.8f) : 0f) + (float)PLCFEOMGCFK, (i != 0) ? 0.07f : 0.001f).SetEase(Ease.Linear));
				if (CNLILOEEBOJ >= 0 && CNLILOEEBOJ < JKNPBEOPMPK)
				{
					sequence.AppendCallback(delegate
					{
						int aMFCENFNAJJ = NNBCLKAEIJL + PLCFEOMGCFK;
						int num = EJBPCMDJFEM(CLCHKLJBIFH, aMFCENFNAJJ, CNLILOEEBOJ, CCPAJBOJDMN);
						GAEPGFKDBAP += num;
					});
				}
			}
			yield return sequence.WaitForCompletion();
			if (AJLDJAHHGOJ < 0)
			{
				Vector3 jDBOMLADPFF = ONCMBJKLKIL.JDBOMLADPFF;
				jDBOMLADPFF.x -= 1f;
				float duration = 0.07f * (BDNJLOFKIME.transform.position.x - jDBOMLADPFF.x);
				BDNJLOFKIME.transform.DOMoveX(jDBOMLADPFF.x, duration).SetEase(Ease.Linear);
			}
			else
			{
				Vector3 aBDNNJLJKJD = ONCMBJKLKIL.ABDNNJLJKJD;
				aBDNNJLJKJD.x += 1f;
				float duration2 = 0.07f * (aBDNNJLJKJD.x - BDNJLOFKIME.transform.position.x);
				BDNJLOFKIME.transform.DOMoveX(aBDNNJLJKJD.x, duration2).SetEase(Ease.Linear);
			}
		}

		private IEnumerator MFOOEHGIAJB(VerticalRocketItem DGPJIILJHMD, Vector3 LDMDBPLADGD, int JKNPBEOPMPK, int MLOGDFDJEBK, CFOIPDKEFMM CLCHKLJBIFH, int AMFCENFNAJJ, int HHHMOGOKFHF, int AJLDJAHHGOJ, APBDPLNCDIJ CCPAJBOJDMN)
		{
			bool flag = AJLDJAHHGOJ > 0;
			DGPJIILJHMD.SwitchToUseMode(!flag, flag, false, false, false);
			Sequence sequence = DOTween.Sequence();
			for (int i = 0; i < JKNPBEOPMPK; i++)
			{
				int PLCFEOMGCFK = AJLDJAHHGOJ * i;
				sequence.Append(DGPJIILJHMD.transform.DOMoveY(LDMDBPLADGD.y - ((i != 0) ? ((float)AJLDJAHHGOJ * 0.8f) : 0f) + (float)PLCFEOMGCFK, (i != 0) ? 0.07f : 0.001f).SetEase(Ease.Linear));
				if (AMFCENFNAJJ >= 0 && AMFCENFNAJJ < HHHMOGOKFHF)
				{
					sequence.AppendCallback(delegate
					{
						int cNLILOEEBOJ = MLOGDFDJEBK + PLCFEOMGCFK;
						int num = EJBPCMDJFEM(CLCHKLJBIFH, AMFCENFNAJJ, cNLILOEEBOJ, CCPAJBOJDMN);
						GAEPGFKDBAP += num;
					});
				}
			}
			sequence.SetEase(Ease.Linear);
			yield return sequence.WaitForCompletion();
			if (AJLDJAHHGOJ < 0)
			{
				Vector3 hINDAIPFFJL = ONCMBJKLKIL.HINDAIPFFJL;
				hINDAIPFFJL.y -= 1f;
				float duration = 0.07f * (DGPJIILJHMD.transform.position.y - hINDAIPFFJL.y);
				DGPJIILJHMD.transform.DOMoveY(hINDAIPFFJL.y, duration).SetEase(Ease.Linear);
			}
			else
			{
				Vector3 eCLBGPBLGMD = ONCMBJKLKIL.ECLBGPBLGMD;
				eCLBGPBLGMD.y += 1f;
				float duration2 = 0.07f * (eCLBGPBLGMD.y - DGPJIILJHMD.transform.position.y);
				DGPJIILJHMD.transform.DOMoveY(eCLBGPBLGMD.y, duration2).SetEase(Ease.Linear);
			}
		}

		protected override IEnumerator GIIEJHGNGJO()
		{
			AudioManager.Play(KOOGPFAPGGD.ComboRocketBombSpin);
			InUseObjects.SetActive(true);
			CurrentSpriteRenderer.enabled = false;
			CFOIPDKEFMM currentGrid = ENCFFNKONOO.CurrentGrid;
			int eMFKAPJMDCC = currentGrid.EMFKAPJMDCC;
			int fHAMOHDEGMK = currentGrid.FHAMOHDEGMK;
			int y = ENCFFNKONOO.Y;
			int x = ENCFFNKONOO.X;
			Vector3 frozenPosition = ENCFFNKONOO.GetFrozenPosition();
			GAEPGFKDBAP = GetScore();
			for (int i = x - 1; i <= x + 1; i++)
			{
				if (i >= 0 && i < eMFKAPJMDCC)
				{
					for (int j = 0; j < fHAMOHDEGMK; j++)
					{
						currentGrid.ECNCPJGHBIG(i, j).RejectsFallInside();
					}
				}
			}
			TheAnimator.speed = 0.25f;
			DOTween.To(() => TheAnimator.speed, delegate(float AMFCENFNAJJ)
			{
				TheAnimator.speed = AMFCENFNAJJ;
			}, 1f, 0.6f).SetEase(Ease.Linear);
			yield return new WaitForSeconds(1.07f);
			ParticlePool.Instance.PlayParticle(ParticlePool.Instance.RocketAndBombParticle, frozenPosition);
			AudioManager.Play(KOOGPFAPGGD.ComboRocketBombExplode);
			yield return new WaitForSeconds(0.05f);
			HorizontalRocketItem[] array = new HorizontalRocketItem[6];
			for (int k = 0; k < 6; k++)
			{
				Vector3 lDMDBPLADGD = frozenPosition;
				int num = k / 2 - 1;
				lDMDBPLADGD.y += num;
				HorizontalRocketItem horizontalRocketItem = ELFBOKDHKGG.GIMBEKBFKMJ.CreateHorizantalRocket(lDMDBPLADGD);
				array[k] = horizontalRocketItem;
				array[k].RelativeContainer.SetActive(false);
			}
			VerticalRocketItem[] array2 = new VerticalRocketItem[6];
			for (int l = 0; l < 6; l++)
			{
				Vector3 lDMDBPLADGD2 = frozenPosition;
				int num2 = l / 2 - 1;
				lDMDBPLADGD2.x += num2;
				VerticalRocketItem verticalRocketItem = ELFBOKDHKGG.GIMBEKBFKMJ.CreateVerticallRocket(lDMDBPLADGD2);
				array2[l] = verticalRocketItem;
				array2[l].RelativeContainer.SetActive(false);
			}
			APBDPLNCDIJ cCPAJBOJDMN = MLENMAIAOHJ.BDAKKAIBMIM(12);
			APBDPLNCDIJ cCPAJBOJDMN2 = MLENMAIAOHJ.BDAKKAIBMIM(13);
			new LLCJMMBBLEH(DDEPNBNGBPL(currentGrid, x, y, cCPAJBOJDMN2));
			LLCJMMBBLEH lLCJMMBBLEH = new LLCJMMBBLEH(MFOOEHGIAJB(array2[0], frozenPosition, fHAMOHDEGMK, y, currentGrid, x - 1, eMFKAPJMDCC, 1, cCPAJBOJDMN));
			new LLCJMMBBLEH(MFOOEHGIAJB(array2[2], frozenPosition, fHAMOHDEGMK, y, currentGrid, x, eMFKAPJMDCC, 1, cCPAJBOJDMN));
			new LLCJMMBBLEH(MFOOEHGIAJB(array2[4], frozenPosition, fHAMOHDEGMK, y, currentGrid, x + 1, eMFKAPJMDCC, 1, cCPAJBOJDMN));
			LLCJMMBBLEH lLCJMMBBLEH2 = new LLCJMMBBLEH(KFNEKPJILCJ(array[4], frozenPosition, fHAMOHDEGMK, x, currentGrid, y + 1, eMFKAPJMDCC, 1, cCPAJBOJDMN));
			new LLCJMMBBLEH(KFNEKPJILCJ(array[2], frozenPosition, fHAMOHDEGMK, x, currentGrid, y, eMFKAPJMDCC, 1, cCPAJBOJDMN));
			new LLCJMMBBLEH(KFNEKPJILCJ(array[0], frozenPosition, fHAMOHDEGMK, x, currentGrid, y - 1, eMFKAPJMDCC, 1, cCPAJBOJDMN));
			LLCJMMBBLEH lLCJMMBBLEH3 = new LLCJMMBBLEH(MFOOEHGIAJB(array2[5], frozenPosition, fHAMOHDEGMK, y, currentGrid, x + 1, eMFKAPJMDCC, -1, cCPAJBOJDMN));
			new LLCJMMBBLEH(MFOOEHGIAJB(array2[3], frozenPosition, fHAMOHDEGMK, y, currentGrid, x, eMFKAPJMDCC, -1, cCPAJBOJDMN));
			new LLCJMMBBLEH(MFOOEHGIAJB(array2[1], frozenPosition, fHAMOHDEGMK, y, currentGrid, x - 1, eMFKAPJMDCC, -1, cCPAJBOJDMN));
			LLCJMMBBLEH lLCJMMBBLEH4 = new LLCJMMBBLEH(KFNEKPJILCJ(array[1], frozenPosition, fHAMOHDEGMK, x, currentGrid, y - 1, eMFKAPJMDCC, -1, cCPAJBOJDMN));
			new LLCJMMBBLEH(KFNEKPJILCJ(array[3], frozenPosition, fHAMOHDEGMK, x, currentGrid, y, eMFKAPJMDCC, -1, cCPAJBOJDMN));
			new LLCJMMBBLEH(KFNEKPJILCJ(array[5], frozenPosition, fHAMOHDEGMK, x, currentGrid, y + 1, eMFKAPJMDCC, -1, cCPAJBOJDMN));
			RocketAndBombParticle1.Stop();
			RocketAndBombParticle2.Stop();
			yield return new WaitForSeconds(0.01f);
			UnityEngine.Object.Destroy(InUseAnimation);
			yield return new WaitForSeconds(0.2f);
			for (int m = 0; m < 6; m++)
			{
				if (m % 2 == 0)
				{
					array[m].Head2TrailParticle.Play();
					array2[m].Head2TrailParticle.Play();
				}
				else
				{
					array[m].Head1TrailParticle.Play();
					array2[m].Head1TrailParticle.Play();
				}
			}
			int num3 = Math.Max(fHAMOHDEGMK - 1 - y, y);
			int num4 = Math.Max(eMFKAPJMDCC - 1 - x, x);
			LLCJMMBBLEH lLCJMMBBLEH5 = ((num3 > num4) ? ((y <= fHAMOHDEGMK - 1 - y) ? lLCJMMBBLEH : lLCJMMBBLEH3) : ((x <= eMFKAPJMDCC - 1 - x) ? lLCJMMBBLEH2 : lLCJMMBBLEH4));
			while (lLCJMMBBLEH5.BPLCLABMIMM)
			{
				yield return null;
			}
			RelativeContainer.SetActive(false);
			for (int n = 0; n < 6; n++)
			{
				new LLCJMMBBLEH(array[n].Die());
			}
			yield return null;
			ScoreManager.RaiseScore(GAEPGFKDBAP);
			for (int num5 = 0; num5 < 6; num5++)
			{
				new LLCJMMBBLEH(array2[num5].Die());
			}
			for (int num6 = x - 1; num6 <= x + 1; num6++)
			{
				if (num6 >= 0 && num6 < eMFKAPJMDCC)
				{
					for (int num7 = 0; num7 < fHAMOHDEGMK; num7++)
					{
						currentGrid.ECNCPJGHBIG(num6, num7).AcceptsFallInside();
					}
				}
			}
			List<Cell> oABGDODKPKM = KPAKBHKNCNP.OABGDODKPKM;
			for (int num8 = 0; num8 < oABGDODKPKM.Count; num8++)
			{
				Cell cell = oABGDODKPKM[num8];
				cell.AcceptsFallInside();
			}
			RemoveSelf();
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 0;
		}
	}
}
