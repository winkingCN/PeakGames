using System.Collections;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.GamePlayScene.Mechanics.Items.SpecialItems;
using Assets.Scripts.Utils;
using DG.Tweening;
using GamePlayScene.Mechanics.Items.SpecialItems;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items.ComboItems
{
	public class DoubleRocketItem : SpecialItem, PGCMDKBCMHI
	{
		[CompilerGenerated]
		private sealed class NMHLFBGICBL
		{
			internal int AMFCENFNAJJ;

			internal CFOIPDKEFMM CLCHKLJBIFH;

			internal int CNLILOEEBOJ;

			internal APBDPLNCDIJ CCPAJBOJDMN;

			internal DoubleRocketItem PDAPIGLEPGC;

			internal void AGFNGEFDHLA()
			{
				if (AMFCENFNAJJ < 0 || AMFCENFNAJJ >= CLCHKLJBIFH.EMFKAPJMDCC || CNLILOEEBOJ < 0 || CNLILOEEBOJ >= CLCHKLJBIFH.FHAMOHDEGMK)
				{
					return;
				}
				Cell cell = CLCHKLJBIFH.ECNCPJGHBIG(AMFCENFNAJJ, CNLILOEEBOJ);
				if (cell.HasCellItem())
				{
					int score = cell.FEMFMBLMKHP.GetScore();
					if (PDAPIGLEPGC.ADCAOOPHFPK(cell, CCPAJBOJDMN))
					{
						PDAPIGLEPGC.GAEPGFKDBAP += score;
					}
					return;
				}
				Item currentItem = cell.LBFCDKPCDPB;
				int num = 0;
				bool flag = false;
				if (currentItem != null)
				{
					num = currentItem.GetScore();
					flag = currentItem.CanGenerateScoreWithoutExplode();
				}
				if (PDAPIGLEPGC.ADCAOOPHFPK(cell, CCPAJBOJDMN))
				{
					PDAPIGLEPGC.GAEPGFKDBAP += SpecialItem.LPKIMIHHJCK(currentItem, cell);
				}
				else if (cell.EAILOFHFNJO && cell.LBFCDKPCDPB.CanGenerateScoreOnEachTryExplode() && cell.LBFCDKPCDPB.CanGenerateScoreThisTurn())
				{
					PDAPIGLEPGC.GAEPGFKDBAP += currentItem.GetScore();
				}
				else if (!cell.EAILOFHFNJO && flag && num > 0)
				{
					PDAPIGLEPGC.GAEPGFKDBAP += num;
				}
			}
		}

		private CFOIPDKEFMM OELBDGFEGOI;

		private int HGPPACPGBCG;

		private float NEJEKFGKJLA;

		private float IPFAFJHLFPM;

		private float EDHACMMPDLG;

		private float ACHJJKPHCDN;

		private float ILDBNJJNINM;

		private float BCIDNKDIAAK;

		private int INBNPKFLLGI;

		private int FBAAABNLPLK;

		private int JHMHKEEPEFH;

		public Transform HeadDown;

		public Transform HeadLeft;

		public Transform HeadRight;

		public Transform HeadUp;

		public GameObject HorizontalAnimation;

		public ParticleSystem TrailParticleDown;

		public ParticleSystem TrailParticleLeft;

		public ParticleSystem TrailParticleRight;

		public ParticleSystem TrailParticleUp;

		public GameObject VerticalAnimation;

		private PBLOIKDOPAJ KPAKBHKNCNP;

		private int DLDOMGCNDLN;

		private int GAEPGFKDBAP;

		private float CGHGCLMEJNH;

		private bool DIMNHLIPBIH = true;

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
			return NOALGNJECAD.DoubleRocket;
		}

		protected override bool MAGCMMBBHEB()
		{
			return false;
		}

		protected override void OOCKFIDFIPL()
		{
			ParticlePool.Instance.PlayParticle(ParticlePool.Instance.ComboCreationParticle, ENCFFNKONOO.GetFrozenPosition());
		}

		protected override IEnumerator GIIEJHGNGJO()
		{
			GAEPGFKDBAP = GetScore();
			OELBDGFEGOI = ENCFFNKONOO.CurrentGrid;
			HGPPACPGBCG = OELBDGFEGOI.FHAMOHDEGMK;
			JHMHKEEPEFH = OELBDGFEGOI.EMFKAPJMDCC;
			INBNPKFLLGI = ENCFFNKONOO.X;
			FBAAABNLPLK = ENCFFNKONOO.Y;
			IPFAFJHLFPM = ONCMBJKLKIL.JDBOMLADPFF.x - 2f;
			EDHACMMPDLG = ONCMBJKLKIL.ABDNNJLJKJD.x + 2f;
			ACHJJKPHCDN = ONCMBJKLKIL.ECLBGPBLGMD.y + 2f;
			NEJEKFGKJLA = ONCMBJKLKIL.HINDAIPFFJL.y - 2f;
			ILDBNJJNINM = HeadRight.transform.localPosition.x * HorizontalRocketItem.ExplodeTime;
			BCIDNKDIAAK = HeadUp.transform.localPosition.y * HorizontalRocketItem.ExplodeTime;
			FallManager.IncreaseWaitingFallBlocker();
			yield return new WaitForSeconds(0.4f);
			RelativeContainer.SetActive(false);
			HorizontalAnimation.SetActive(true);
			VerticalAnimation.SetActive(true);
			TrailParticleLeft.Play();
			TrailParticleRight.Play();
			TrailParticleUp.Play();
			TrailParticleDown.Play();
			AudioManager.Play(KOOGPFAPGGD.ComboRocketRocket);
			Sequence sequence = DOTween.Sequence();
			APBDPLNCDIJ cCPAJBOJDMN = MLENMAIAOHJ.BDAKKAIBMIM(7);
			sequence.AppendCallback(FLLAFDDMGCN(OELBDGFEGOI, cCPAJBOJDMN, INBNPKFLLGI, FBAAABNLPLK));
			int num = 1;
			bool flag = false;
			bool flag2 = false;
			while (!flag || !flag2)
			{
				int num2 = FBAAABNLPLK + num;
				int num3 = FBAAABNLPLK - num;
				int num4 = INBNPKFLLGI + num;
				int num5 = INBNPKFLLGI - num;
				flag = num2 >= HGPPACPGBCG && num3 < 0;
				if (num2 <= HGPPACPGBCG)
				{
					EHKOMDGIBOL(HeadUp, cCPAJBOJDMN, num, 1, sequence);
				}
				if (num3 >= -1)
				{
					EHKOMDGIBOL(HeadDown, cCPAJBOJDMN, num, -1, sequence);
				}
				flag2 = num5 < 0 && num4 >= JHMHKEEPEFH;
				if (num5 >= -1)
				{
					POLCLOJPINH(HeadLeft, cCPAJBOJDMN, num, -1, sequence);
				}
				if (num4 <= JHMHKEEPEFH)
				{
					POLCLOJPINH(HeadRight, cCPAJBOJDMN, num, 1, sequence);
				}
				num++;
			}
			sequence.InsertCallback(CGHGCLMEJNH, NEAHACDCGDA);
			while (DIMNHLIPBIH)
			{
				yield return null;
			}
		}

		private IEnumerator BGFBIJCNJIK()
		{
			yield return MCJHHDACJBG.KNLADMIBAAD;
			RemoveSelf();
		}

		public override int GetScore()
		{
			return 500 + DLDOMGCNDLN;
		}

		private void POLCLOJPINH(Transform JACLFODHGCK, APBDPLNCDIJ CCPAJBOJDMN, int CCHAAJBNJHL, int AJLDJAHHGOJ, Sequence MIABODPHOIP)
		{
			int num = INBNPKFLLGI + CCHAAJBNJHL * AJLDJAHHGOJ;
			bool flag = num >= 0 && num < JHMHKEEPEFH;
			int num2 = num + AJLDJAHHGOJ;
			float num3 = ((CCHAAJBNJHL != 1) ? HorizontalRocketItem.ExplodeTime : ILDBNJJNINM);
			float num4 = ((CCHAAJBNJHL != 1) ? (HorizontalRocketItem.ExplodeTime * (float)(CCHAAJBNJHL - 2) + ILDBNJJNINM) : 0f);
			float num5 = JACLFODHGCK.position.x + ((float)CCHAAJBNJHL - HorizontalRocketItem.Offset) * (float)AJLDJAHHGOJ;
			MIABODPHOIP.Insert(num4, JACLFODHGCK.DOMoveX(num5, num3).SetEase(Ease.Linear));
			if (flag)
			{
				MIABODPHOIP.InsertCallback(num4 + num3, FLLAFDDMGCN(OELBDGFEGOI, CCPAJBOJDMN, num, FBAAABNLPLK));
			}
			if (num2 >= JHMHKEEPEFH)
			{
				float duration = (EDHACMMPDLG - num5) * HorizontalRocketItem.ExplodeTime;
				float num6 = num4 + num3;
				CGHGCLMEJNH = Mathf.Max(num6, CGHGCLMEJNH);
				MIABODPHOIP.Insert(num6, JACLFODHGCK.DOMoveX(EDHACMMPDLG, duration).SetEase(Ease.Linear));
			}
			else if (num2 < 0)
			{
				float duration2 = (0f - (IPFAFJHLFPM - num5)) * HorizontalRocketItem.ExplodeTime;
				float num7 = num4 + num3;
				CGHGCLMEJNH = Mathf.Max(num7, CGHGCLMEJNH);
				MIABODPHOIP.Insert(num7, JACLFODHGCK.DOMoveX(IPFAFJHLFPM, duration2).SetEase(Ease.Linear));
			}
		}

		private void EHKOMDGIBOL(Transform JACLFODHGCK, APBDPLNCDIJ CCPAJBOJDMN, int CCHAAJBNJHL, int AJLDJAHHGOJ, Sequence MIABODPHOIP)
		{
			int num = FBAAABNLPLK + CCHAAJBNJHL * AJLDJAHHGOJ;
			bool flag = num >= 0 && num < HGPPACPGBCG;
			int num2 = num + AJLDJAHHGOJ;
			float num3 = ((CCHAAJBNJHL != 1) ? HorizontalRocketItem.ExplodeTime : BCIDNKDIAAK);
			float num4 = ((CCHAAJBNJHL != 1) ? (HorizontalRocketItem.ExplodeTime * (float)(CCHAAJBNJHL - 2) + BCIDNKDIAAK) : 0f);
			float num5 = JACLFODHGCK.position.y + ((float)CCHAAJBNJHL - HorizontalRocketItem.Offset) * (float)AJLDJAHHGOJ;
			MIABODPHOIP.Insert(num4, JACLFODHGCK.DOMoveY(num5, num3).SetEase(Ease.Linear));
			if (flag)
			{
				MIABODPHOIP.InsertCallback(num4 + num3, FLLAFDDMGCN(OELBDGFEGOI, CCPAJBOJDMN, INBNPKFLLGI, num));
			}
			if (num2 >= HGPPACPGBCG)
			{
				float duration = (ACHJJKPHCDN - num5) * HorizontalRocketItem.ExplodeTime;
				float num6 = num4 + num3;
				CGHGCLMEJNH = Mathf.Max(num6, CGHGCLMEJNH);
				MIABODPHOIP.Insert(num6, JACLFODHGCK.DOMoveY(ACHJJKPHCDN, duration).SetEase(Ease.Linear));
			}
			else if (num2 < 0)
			{
				float duration2 = (0f - (NEJEKFGKJLA - num5)) * HorizontalRocketItem.ExplodeTime;
				float num7 = num4 + num3;
				CGHGCLMEJNH = Mathf.Max(num7, CGHGCLMEJNH);
				MIABODPHOIP.Insert(num7, JACLFODHGCK.DOMoveY(NEJEKFGKJLA, duration2).SetEase(Ease.Linear));
			}
		}

		private void NEAHACDCGDA()
		{
			foreach (Cell item in KPAKBHKNCNP.OABGDODKPKM)
			{
				item.AcceptsFallInside();
			}
			ScoreManager.RaiseScore(GAEPGFKDBAP);
			FallManager.DecreaseWaitingFallBlocker();
			DIMNHLIPBIH = false;
			if (base.gameObject.activeSelf)
			{
				StartCoroutine(BGFBIJCNJIK());
			}
			else
			{
				RemoveSelf();
			}
		}

		private TweenCallback FLLAFDDMGCN(CFOIPDKEFMM CLCHKLJBIFH, APBDPLNCDIJ CCPAJBOJDMN, int AMFCENFNAJJ, int CNLILOEEBOJ)
		{
			return delegate
			{
				if (AMFCENFNAJJ >= 0 && AMFCENFNAJJ < CLCHKLJBIFH.EMFKAPJMDCC && CNLILOEEBOJ >= 0 && CNLILOEEBOJ < CLCHKLJBIFH.FHAMOHDEGMK)
				{
					Cell cell = CLCHKLJBIFH.ECNCPJGHBIG(AMFCENFNAJJ, CNLILOEEBOJ);
					if (cell.HasCellItem())
					{
						int score = cell.FEMFMBLMKHP.GetScore();
						if (ADCAOOPHFPK(cell, CCPAJBOJDMN))
						{
							GAEPGFKDBAP += score;
						}
					}
					else
					{
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
							GAEPGFKDBAP += SpecialItem.LPKIMIHHJCK(currentItem, cell);
						}
						else if (cell.EAILOFHFNJO && cell.LBFCDKPCDPB.CanGenerateScoreOnEachTryExplode() && cell.LBFCDKPCDPB.CanGenerateScoreThisTurn())
						{
							GAEPGFKDBAP += currentItem.GetScore();
						}
						else if (!cell.EAILOFHFNJO && flag && num > 0)
						{
							GAEPGFKDBAP += num;
						}
					}
				}
			};
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 0;
		}
	}
}
