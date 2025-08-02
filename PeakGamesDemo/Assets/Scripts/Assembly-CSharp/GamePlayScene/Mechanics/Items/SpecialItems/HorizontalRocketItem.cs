using System.Collections;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.GamePlayScene.Mechanics.Items.SpecialItems;
using Assets.Scripts.Utils;
using DG.Tweening;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items.SpecialItems
{
	public class HorizontalRocketItem : SpecialItem
	{
		[CompilerGenerated]
		private sealed class NHBFFDLJMAO
		{
			internal int AMFCENFNAJJ;

			internal CFOIPDKEFMM CLCHKLJBIFH;

			internal int CNLILOEEBOJ;

			internal HorizontalRocketItem PDAPIGLEPGC;

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
					if (PDAPIGLEPGC.ADCAOOPHFPK(cell, PDAPIGLEPGC.KJFIPMDFECO))
					{
						PDAPIGLEPGC.DBFAMLNEIBM += score;
					}
					return;
				}
				Item currentItem = cell.LBFCDKPCDPB;
				int num = 0;
				bool flag = false;
				if (cell.EAILOFHFNJO)
				{
					num = currentItem.GetScore();
					flag = currentItem.CanGenerateScoreWithoutExplode();
				}
				if (PDAPIGLEPGC.ADCAOOPHFPK(cell, PDAPIGLEPGC.KJFIPMDFECO))
				{
					PDAPIGLEPGC.DBFAMLNEIBM += SpecialItem.LPKIMIHHJCK(currentItem, cell);
				}
				else if (cell.EAILOFHFNJO && cell.LBFCDKPCDPB.CanGenerateScoreOnEachTryExplode() && cell.LBFCDKPCDPB.CanGenerateScoreThisTurn())
				{
					PDAPIGLEPGC.DBFAMLNEIBM += currentItem.GetScore();
				}
				else if (!cell.EAILOFHFNJO && flag && num > 0)
				{
					PDAPIGLEPGC.DBFAMLNEIBM += num;
				}
			}
		}

		public static float ExplodeTime = 0.07f;

		public static float Offset = 0.8f;

		protected CFOIPDKEFMM AHPHKOBCJHP;

		protected int FHAMOHDEGMK;

		protected int DBFAMLNEIBM;

		protected float AGNHOHFCAFI;

		protected float IAIAMOCMCMK;

		protected float MODKKEKFIBP;

		protected float AHFHDCLNMID;

		protected float PJGEFONMDBH;

		protected int AJIFAKKFLBF;

		protected int NNOKOJMKNDK;

		protected int EMFKAPJMDCC;

		protected APBDPLNCDIJ KJFIPMDFECO;

		public GameObject ExplodeAnimation;

		public Transform Head1;

		public ParticleSystem Head1TrailParticle;

		public Transform Head2;

		public ParticleSystem Head2TrailParticle;

		protected bool CGJEMNNFFAF = true;

		protected bool CIFMDKFIDNM = true;

		private bool GOEPNHCJBFK;

		protected float CFLIBKJIMOP;

		private Vector3 BDELGGKJOFK;

		private Vector3 BJPIOPEGAFN;

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Rocket;
		}

		protected override bool MAGCMMBBHEB()
		{
			return false;
		}

		public void AllowBlockFalls()
		{
			CIFMDKFIDNM = false;
		}

		public override void OnBeforeRemove()
		{
			base.OnBeforeRemove();
			Head1TrailParticle.Stop();
			Head2TrailParticle.Stop();
			RelativeContainer.SetActive(true);
			ExplodeAnimation.SetActive(false);
			Head1.gameObject.SetActive(false);
			Head2.gameObject.SetActive(false);
		}

		public override void AfterPoolInit()
		{
			if (!GOEPNHCJBFK)
			{
				GOEPNHCJBFK = true;
				BDELGGKJOFK = Head1.transform.localPosition;
				BJPIOPEGAFN = Head2.transform.localPosition;
			}
			base.AfterPoolInit();
			AHPHKOBCJHP = null;
			FHAMOHDEGMK = 0;
			DBFAMLNEIBM = GetScore();
			AGNHOHFCAFI = 0f;
			IAIAMOCMCMK = 0f;
			MODKKEKFIBP = 0f;
			AHFHDCLNMID = 0f;
			PJGEFONMDBH = 0f;
			AJIFAKKFLBF = 0;
			NNOKOJMKNDK = 0;
			EMFKAPJMDCC = 0;
			CGJEMNNFFAF = true;
			CIFMDKFIDNM = true;
			CFLIBKJIMOP = 0f;
			Head1.transform.localPosition = BDELGGKJOFK;
			Head2.transform.localPosition = BJPIOPEGAFN;
		}

		public override void RemoveSelf()
		{
			if (ShouldRecycleInstantly)
			{
				OnBeforeRemove();
				base.gameObject.MEJPNNFDEBD();
			}
			else
			{
				base.gameObject.SetActive(false);
			}
		}

		public override bool ShouldBlockFalls()
		{
			return CIFMDKFIDNM;
		}

		public void SwitchToUseMode(bool IDEJILLCHNG = true, bool NAPICOPADNI = true, bool HPKCJJPGMNK = true, bool BELACJAGNNI = true, bool IFADGMNDEII = true)
		{
			RelativeContainer.SetActive(false);
			ExplodeAnimation.SetActive(true);
			Head1.gameObject.SetActive(IDEJILLCHNG);
			Head2.gameObject.SetActive(NAPICOPADNI);
			if (BELACJAGNNI)
			{
				Head1TrailParticle.Play();
			}
			if (IFADGMNDEII)
			{
				Head2TrailParticle.Play();
			}
		}

		protected override IEnumerator GIIEJHGNGJO()
		{
			AudioManager.Play(KOOGPFAPGGD.ItemSpecialRocket);
			AHPHKOBCJHP = ENCFFNKONOO.CurrentGrid;
			EMFKAPJMDCC = AHPHKOBCJHP.EMFKAPJMDCC;
			NNOKOJMKNDK = ENCFFNKONOO.Y;
			AJIFAKKFLBF = ENCFFNKONOO.X;
			IAIAMOCMCMK = ONCMBJKLKIL.JDBOMLADPFF.x - 2f;
			MODKKEKFIBP = ONCMBJKLKIL.ABDNNJLJKJD.x + 2f;
			PJGEFONMDBH = Head2.transform.localPosition.x * ExplodeTime;
			SwitchToUseMode();
			KJFIPMDFECO = MLENMAIAOHJ.BDAKKAIBMIM(6);
			for (int i = 0; i < EMFKAPJMDCC; i++)
			{
				AHPHKOBCJHP.ECNCPJGHBIG(i, NNOKOJMKNDK).RejectsFallInside();
			}
			Sequence sequence = DOTween.Sequence();
			sequence.AppendCallback(FLLAFDDMGCN(AHPHKOBCJHP, AJIFAKKFLBF, NNOKOJMKNDK));
			int num = 1;
			bool flag = false;
			while (!flag)
			{
				int num2 = AJIFAKKFLBF + num;
				int num3 = AJIFAKKFLBF - num;
				flag = num3 < 0 && num2 >= EMFKAPJMDCC;
				if (num3 >= -1)
				{
					LMDCGLGHGNC(Head1, num, -1, sequence);
				}
				if (num2 <= EMFKAPJMDCC)
				{
					LMDCGLGHGNC(Head2, num, 1, sequence);
				}
				num++;
			}
			sequence.InsertCallback(CFLIBKJIMOP, DLFCAMLJDPA);
			while (CGJEMNNFFAF)
			{
				yield return null;
			}
		}

		public IEnumerator Die()
		{
			yield return MCJHHDACJBG.KNLADMIBAAD;
			RemoveSelf();
		}

		private void LMDCGLGHGNC(Transform JACLFODHGCK, int CCHAAJBNJHL, int AJLDJAHHGOJ, Sequence MIABODPHOIP)
		{
			int num = AJIFAKKFLBF + CCHAAJBNJHL * AJLDJAHHGOJ;
			bool flag = num >= 0 && num < EMFKAPJMDCC;
			int num2 = num + AJLDJAHHGOJ;
			float num3 = ((CCHAAJBNJHL != 1) ? ExplodeTime : PJGEFONMDBH);
			float num4 = ((CCHAAJBNJHL != 1) ? (ExplodeTime * (float)(CCHAAJBNJHL - 2) + PJGEFONMDBH) : 0f);
			float num5 = JACLFODHGCK.position.x + ((float)CCHAAJBNJHL - Offset) * (float)AJLDJAHHGOJ;
			MIABODPHOIP.Insert(num4, JACLFODHGCK.DOMoveX(num5, num3).SetEase(Ease.Linear));
			if (flag)
			{
				MIABODPHOIP.InsertCallback(num4 + num3, FLLAFDDMGCN(AHPHKOBCJHP, num, NNOKOJMKNDK));
			}
			if (num2 >= EMFKAPJMDCC)
			{
				float duration = (MODKKEKFIBP - num5) * ExplodeTime;
				float num6 = num4 + num3;
				CFLIBKJIMOP = Mathf.Max(num6, CFLIBKJIMOP);
				MIABODPHOIP.Insert(num6, JACLFODHGCK.DOMoveX(MODKKEKFIBP, duration).SetEase(Ease.Linear));
			}
			else if (num2 < 0)
			{
				float duration2 = (0f - (IAIAMOCMCMK - num5)) * ExplodeTime;
				float num7 = num4 + num3;
				CFLIBKJIMOP = Mathf.Max(num7, CFLIBKJIMOP);
				MIABODPHOIP.Insert(num7, JACLFODHGCK.DOMoveX(IAIAMOCMCMK, duration2).SetEase(Ease.Linear));
			}
		}

		public override int GetScore()
		{
			return 250;
		}

		private void DLFCAMLJDPA()
		{
			ScoreManager.RaiseScore(DBFAMLNEIBM);
			for (int i = 0; i < EMFKAPJMDCC; i++)
			{
				AHPHKOBCJHP.ECNCPJGHBIG(i, NNOKOJMKNDK).AcceptsFallInside();
			}
			CGJEMNNFFAF = false;
			if (base.gameObject.activeSelf)
			{
				StartCoroutine(Die());
			}
			else
			{
				RemoveSelf();
			}
		}

		protected TweenCallback FLLAFDDMGCN(CFOIPDKEFMM CLCHKLJBIFH, int AMFCENFNAJJ, int CNLILOEEBOJ)
		{
			return delegate
			{
				if (AMFCENFNAJJ >= 0 && AMFCENFNAJJ < CLCHKLJBIFH.EMFKAPJMDCC && CNLILOEEBOJ >= 0 && CNLILOEEBOJ < CLCHKLJBIFH.FHAMOHDEGMK)
				{
					Cell cell = CLCHKLJBIFH.ECNCPJGHBIG(AMFCENFNAJJ, CNLILOEEBOJ);
					if (cell.HasCellItem())
					{
						int score = cell.FEMFMBLMKHP.GetScore();
						if (ADCAOOPHFPK(cell, KJFIPMDFECO))
						{
							DBFAMLNEIBM += score;
						}
					}
					else
					{
						Item currentItem = cell.LBFCDKPCDPB;
						int num = 0;
						bool flag = false;
						if (cell.EAILOFHFNJO)
						{
							num = currentItem.GetScore();
							flag = currentItem.CanGenerateScoreWithoutExplode();
						}
						if (ADCAOOPHFPK(cell, KJFIPMDFECO))
						{
							DBFAMLNEIBM += SpecialItem.LPKIMIHHJCK(currentItem, cell);
						}
						else if (cell.EAILOFHFNJO && cell.LBFCDKPCDPB.CanGenerateScoreOnEachTryExplode() && cell.LBFCDKPCDPB.CanGenerateScoreThisTurn())
						{
							DBFAMLNEIBM += currentItem.GetScore();
						}
						else if (!cell.EAILOFHFNJO && flag && num > 0)
						{
							DBFAMLNEIBM += num;
						}
					}
				}
			};
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 81;
		}
	}
}
