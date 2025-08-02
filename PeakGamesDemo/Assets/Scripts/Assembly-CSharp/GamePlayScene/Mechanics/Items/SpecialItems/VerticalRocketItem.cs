using System.Collections;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.Utils;
using DG.Tweening;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items.SpecialItems
{
	public class VerticalRocketItem : HorizontalRocketItem
	{
		protected override IEnumerator GIIEJHGNGJO()
		{
			AudioManager.Play(KOOGPFAPGGD.ItemSpecialRocket);
			AHPHKOBCJHP = ENCFFNKONOO.CurrentGrid;
			FHAMOHDEGMK = AHPHKOBCJHP.FHAMOHDEGMK;
			AJIFAKKFLBF = ENCFFNKONOO.X;
			NNOKOJMKNDK = ENCFFNKONOO.Y;
			AHFHDCLNMID = ONCMBJKLKIL.ECLBGPBLGMD.y + 2f;
			AGNHOHFCAFI = ONCMBJKLKIL.HINDAIPFFJL.y - 2f;
			PJGEFONMDBH = Head2.transform.localPosition.y * HorizontalRocketItem.ExplodeTime;
			for (int i = 0; i < FHAMOHDEGMK; i++)
			{
				AHPHKOBCJHP.ECNCPJGHBIG(AJIFAKKFLBF, i).RejectsFallInside();
			}
			SwitchToUseMode();
			KJFIPMDFECO = MLENMAIAOHJ.BDAKKAIBMIM(6);
			Sequence sequence = DOTween.Sequence();
			sequence.AppendCallback(FLLAFDDMGCN(AHPHKOBCJHP, AJIFAKKFLBF, NNOKOJMKNDK));
			int num = 1;
			bool flag = false;
			while (!flag)
			{
				int num2 = NNOKOJMKNDK + num;
				int num3 = NNOKOJMKNDK - num;
				flag = num2 > FHAMOHDEGMK && num3 < 0;
				if (num2 <= FHAMOHDEGMK)
				{
					LMDCGLGHGNC(Head2, num, 1, sequence);
				}
				if (num3 >= -1)
				{
					LMDCGLGHGNC(Head1, num, -1, sequence);
				}
				num++;
			}
			sequence.InsertCallback(CFLIBKJIMOP, OJOIKJMJDFF);
			while (CGJEMNNFFAF)
			{
				yield return null;
			}
		}

		private void LMDCGLGHGNC(Transform JACLFODHGCK, int CCHAAJBNJHL, int AJLDJAHHGOJ, Sequence MIABODPHOIP)
		{
			int num = NNOKOJMKNDK + CCHAAJBNJHL * AJLDJAHHGOJ;
			bool flag = num >= 0 && num < FHAMOHDEGMK;
			int num2 = num + AJLDJAHHGOJ;
			float num3 = ((CCHAAJBNJHL != 1) ? HorizontalRocketItem.ExplodeTime : PJGEFONMDBH);
			float num4 = ((CCHAAJBNJHL != 1) ? (HorizontalRocketItem.ExplodeTime * (float)(CCHAAJBNJHL - 2) + PJGEFONMDBH) : 0f);
			float num5 = JACLFODHGCK.position.y + ((float)CCHAAJBNJHL - HorizontalRocketItem.Offset) * (float)AJLDJAHHGOJ;
			MIABODPHOIP.Insert(num4, JACLFODHGCK.DOMoveY(num5, num3).SetEase(Ease.Linear));
			if (flag)
			{
				MIABODPHOIP.InsertCallback(num4 + num3, FLLAFDDMGCN(AHPHKOBCJHP, AJIFAKKFLBF, num));
			}
			if (num2 >= FHAMOHDEGMK)
			{
				float duration = (AHFHDCLNMID - num5) * HorizontalRocketItem.ExplodeTime;
				float num6 = num4 + num3;
				CFLIBKJIMOP = Mathf.Max(num6, CFLIBKJIMOP);
				MIABODPHOIP.Insert(num6, JACLFODHGCK.DOMoveY(AHFHDCLNMID, duration).SetEase(Ease.Linear));
			}
			else if (num2 < 0)
			{
				float duration2 = (0f - (AGNHOHFCAFI - num5)) * HorizontalRocketItem.ExplodeTime;
				float num7 = num4 + num3;
				CFLIBKJIMOP = Mathf.Max(num7, CFLIBKJIMOP);
				MIABODPHOIP.Insert(num7, JACLFODHGCK.DOMoveY(AGNHOHFCAFI, duration2).SetEase(Ease.Linear));
			}
		}

		private void OJOIKJMJDFF()
		{
			if (AHPHKOBCJHP != null)
			{
				ScoreManager.RaiseScore(DBFAMLNEIBM);
			}
			for (int i = 0; i < FHAMOHDEGMK; i++)
			{
				if (AHPHKOBCJHP != null)
				{
					AHPHKOBCJHP.ECNCPJGHBIG(AJIFAKKFLBF, i).AcceptsFallInside();
				}
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

		public override bool CanCastShadow()
		{
			return true;
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 82;
		}
	}
}
