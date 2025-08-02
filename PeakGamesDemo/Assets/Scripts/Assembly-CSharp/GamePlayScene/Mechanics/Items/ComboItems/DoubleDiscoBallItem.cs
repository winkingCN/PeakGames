using System.Collections;
using System.Collections.Generic;
using System.Text;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.GamePlayScene.Mechanics.Items.SpecialItems;
using Assets.Scripts.Utils;
using DG.Tweening;
using UnityEngine;
using Utils;

namespace GamePlayScene.Mechanics.Items.ComboItems
{
	public class DoubleDiscoBallItem : SpecialItem, PGCMDKBCMHI
	{
		private struct ELOLELDOCEB
		{
			public Cell MOPENJLLGCM;

			public int EJIFMCCGABG;

			public ELOLELDOCEB(Cell LBHDELJBONF, int ELNCCDELMMH)
			{
				MOPENJLLGCM = LBHDELJBONF;
				EJIFMCCGABG = ELNCCDELMMH;
			}
		}

		public ParticleSystem ExplodeParticle;

		public GameObject ExplodeContainer;

		public SpriteRenderer BackgroundSprite;

		public SpriteRenderer RingSprite;

		public Gradient RingGradient;

		private Material FNDEBEFCKAD;

		private Material LLAPJAPGFDB;

		private PBLOIKDOPAJ KPAKBHKNCNP;

		private const float AAOEHGHNPAM = 1.34f;

		private const float HBEPGAKHGPH = 0.2f;

		private const float KEILJILPHGE = 0.8f;

		private const float PEHCEEPPEDG = 0.9f;

		public static float RingDuration = 1.75f;

		public static float ExplodeRingSpeed = 11.5f;

		public static float RadiusOffset = 0.1f;

		private int DLDOMGCNDLN;

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
			return NOALGNJECAD.DoubleDiscoBall;
		}

		public override int GetScore()
		{
			return 8000 + DLDOMGCNDLN;
		}

		protected override IEnumerator GIIEJHGNGJO()
		{
			RingSprite.enabled = false;
			AudioManager.Play(KOOGPFAPGGD.ComboDiscoDisco);
			CFOIPDKEFMM currentGrid = ENCFFNKONOO.CurrentGrid;
			Vector3 frozenPosition = ENCFFNKONOO.GetFrozenPosition();
			int num = GetScore();
			StringBuilder stringBuilder = new StringBuilder();
			List<ELOLELDOCEB> list = new List<ELOLELDOCEB>();
			foreach (Cell item in currentGrid.IOFOFDLJDAA())
			{
				int num2 = item.X - ENCFFNKONOO.X;
				int num3 = item.Y - ENCFFNKONOO.Y;
				int eLNCCDELMMH = num2 * num2 + num3 * num3;
				list.Add(new ELOLELDOCEB(item, eLNCCDELMMH));
			}
			stringBuilder.Append("Double Disco > Total Explode Count:" + list.Count);
			list.Sort((ELOLELDOCEB MNIMEAMHNMI, ELOLELDOCEB BCIHLCMFAEK) => (MNIMEAMHNMI.EJIFMCCGABG > BCIHLCMFAEK.EJIFMCCGABG) ? 1 : ((MNIMEAMHNMI.EJIFMCCGABG < BCIHLCMFAEK.EJIFMCCGABG) ? (-1) : 0));
			yield return null;
			float eMFKAPJMDCC = ONCMBJKLKIL.EMFKAPJMDCC;
			float fHAMOHDEGMK = ONCMBJKLKIL.FHAMOHDEGMK;
			float value = (frozenPosition.x + eMFKAPJMDCC * 0.5f) / eMFKAPJMDCC;
			float value2 = (frozenPosition.y + fHAMOHDEGMK * 0.5f) / fHAMOHDEGMK;
			Vector3 localScale = new Vector3(eMFKAPJMDCC, fHAMOHDEGMK, 1f);
			BackgroundSprite.transform.position = Vector3.zero;
			BackgroundSprite.transform.localScale = localScale;
			RingSprite.transform.position = Vector3.zero;
			RingSprite.transform.localScale = localScale;
			FNDEBEFCKAD = BackgroundSprite.material;
			FNDEBEFCKAD.SetFloat("_scaleX", eMFKAPJMDCC);
			FNDEBEFCKAD.SetFloat("_scaleY", fHAMOHDEGMK);
			FNDEBEFCKAD.SetFloat("_x", value);
			FNDEBEFCKAD.SetFloat("_y", value2);
			FNDEBEFCKAD.SetFloat("_slide", 0.2f);
			FNDEBEFCKAD.SetFloat("_alpha", 0f);
			LLAPJAPGFDB = RingSprite.material;
			LLAPJAPGFDB.SetFloat("_scaleX", eMFKAPJMDCC);
			LLAPJAPGFDB.SetFloat("_scaleY", fHAMOHDEGMK);
			LLAPJAPGFDB.SetFloat("_x", value);
			LLAPJAPGFDB.SetFloat("_y", value2);
			LLAPJAPGFDB.SetFloat("_ratio", 0f);
			LLAPJAPGFDB.SetFloat("_thickness", 0.2f);
			LLAPJAPGFDB.SetFloat("_alpha", 1f);
			ExplodeContainer.SetActive(true);
			BackgroundSprite.gameObject.SetActive(true);
			DOVirtual.Float(0f, 0.6f, 0.35f, delegate(float AMFCENFNAJJ)
			{
				FNDEBEFCKAD.SetFloat("_alpha", AMFCENFNAJJ);
			}).SetEase(Ease.Linear);
			FallManager.IncreaseWaitingFallBlocker();
			PlayRandomSpineAnimations.ComboItemWillExplode = true;
			yield return new WaitForSeconds(2.3f);
			ExplodeParticle.Play();
			RingSprite.enabled = true;
			DOVirtual.Float(0.2f, -10f, 1.34f, delegate(float AMFCENFNAJJ)
			{
				FNDEBEFCKAD.SetFloat("_slide", AMFCENFNAJJ);
			}).SetEase(Ease.Linear);
			DOVirtual.Float(0f, 2f, RingDuration, delegate(float AMFCENFNAJJ)
			{
				LLAPJAPGFDB.SetFloat("_ratio", AMFCENFNAJJ);
			}).SetEase(Ease.Linear);
			DOVirtual.Float(1f, 0f, 0.8f, delegate(float AMFCENFNAJJ)
			{
				LLAPJAPGFDB.SetFloat("_alpha", AMFCENFNAJJ);
				FNDEBEFCKAD.SetFloat("_alpha", AMFCENFNAJJ);
			}).SetDelay(0.9f);
			RingSprite.DOGradientColor(RingGradient, RingDuration);
			CurrentSpriteRenderer.enabled = false;
			APBDPLNCDIJ cCPAJBOJDMN = MLENMAIAOHJ.BDAKKAIBMIM(11);
			float num4 = 0f;
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				float deltaTime = Time.deltaTime;
				num4 += deltaTime * ExplodeRingSpeed;
				float num5 = num4 + RadiusOffset;
				for (float num6 = num5 * num5; i < count && num6 >= (float)list[i].EJIFMCCGABG; i++)
				{
					num += BDFOOLOAFKO(list[i].MOPENJLLGCM, cCPAJBOJDMN);
				}
				yield return null;
			}
			stringBuilder.Append(" Final CellIndex:" + i);
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Level, stringBuilder.ToString());
			ScoreManager.RaiseScore(num);
			for (int j = 0; j < KPAKBHKNCNP.OABGDODKPKM.Count; j++)
			{
				Cell cell = KPAKBHKNCNP.OABGDODKPKM[j];
				cell.AcceptsFallInside();
			}
			FallManager.DecreaseWaitingFallBlocker();
			if (base.gameObject.activeSelf)
			{
				StartCoroutine(GHAMJIOKLLM());
			}
			else
			{
				RemoveSelf();
			}
		}

		private IEnumerator GHAMJIOKLLM()
		{
			yield return MCJHHDACJBG.CHFOIGLAMPN;
			RemoveSelf();
		}

		private int BDFOOLOAFKO(Cell FMFABAKPMLB, APBDPLNCDIJ CCPAJBOJDMN)
		{
			int num = 0;
			if (FMFABAKPMLB.HasCellItem())
			{
				int score = FMFABAKPMLB.FEMFMBLMKHP.GetScore();
				if (ADCAOOPHFPK(FMFABAKPMLB, CCPAJBOJDMN))
				{
					num += score;
				}
			}
			else
			{
				Item currentItem = FMFABAKPMLB.LBFCDKPCDPB;
				int num2 = 0;
				bool flag = false;
				if (FMFABAKPMLB.EAILOFHFNJO)
				{
					if (currentItem.GetItemType() == NOALGNJECAD.Rocket || currentItem.GetItemType() == NOALGNJECAD.Bomb)
					{
						num -= currentItem.GetScore();
					}
					else
					{
						if (currentItem.GetItemType() == NOALGNJECAD.DiscoBall)
						{
							((SpecialItem)currentItem).SpecialItemCanOnlyExplodeSelf = true;
						}
						num2 = currentItem.GetScore();
						flag = currentItem.CanGenerateScoreWithoutExplode();
					}
				}
				if (ADCAOOPHFPK(FMFABAKPMLB, CCPAJBOJDMN))
				{
					num += SpecialItem.LPKIMIHHJCK(currentItem, FMFABAKPMLB);
				}
				else if (FMFABAKPMLB.EAILOFHFNJO && FMFABAKPMLB.LBFCDKPCDPB.CanGenerateScoreOnEachTryExplode() && FMFABAKPMLB.LBFCDKPCDPB.CanGenerateScoreThisTurn())
				{
					num += num2;
				}
				else if (!FMFABAKPMLB.EAILOFHFNJO && flag && num > 0)
				{
					num += num2;
				}
				if (currentItem != null && currentItem.IsSpecialItem())
				{
					((SpecialItem)currentItem).SpecialItemCanOnlyExplodeSelf = false;
				}
			}
			return num;
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 0;
		}
	}
}
