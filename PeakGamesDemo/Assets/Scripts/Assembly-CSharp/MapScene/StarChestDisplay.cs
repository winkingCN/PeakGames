using System;
using Assets.Scripts.Dialogs;
using DG.Tweening;
using Dialogs;
using TMPro;
using UnityEngine;
using Utils;

namespace MapScene
{
	public class StarChestDisplay : MapChestDisplay
	{
		public GameObject CollectContent;

		public TextMeshPro CollectedStarCount;

		public SpriteRenderer StarBar;

		public ParticleSystem StarHitParticle;

		private const float OGNHCIDPBII = -1.623f;

		private const float CBBNALBKMFD = -0.686f;

		private const float CDBFEHCIAFD = 0.42f;

		private const float ENINHIFKEFN = 2.293675f;

		private int BMBLEDJKGFG;

		private bool CGEIKECPHMH;

		private bool HBEABECLMAM;

		private int PEHBMFDNLBB;

		public void Start()
		{
			if (!NDGOJGLPIJF.GABGKBAKHDP.AEFOGGAOFEE())
			{
				base.gameObject.SetActive(false);
				return;
			}
			OuterGlow.gameObject.SetActive(false);
			BMBLEDJKGFG = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Stars);
			UpdateDisplay();
		}

		public void ChangeState(KMEIGFENLNO BGEDKGLJIGM)
		{
			if (AJGPGBIEPJC != BGEDKGLJIGM)
			{
				AJGPGBIEPJC = BGEDKGLJIGM;
				IBKKMOCAGFF();
				switch (AJGPGBIEPJC)
				{
				case KMEIGFENLNO.Collect:
					OpenButton.CanBeAnimated = true;
					CollectContainer.SetActive(true);
					CollectContent.SetActive(true);
					OpenContent.SetActive(false);
					BMBLEDJKGFG = Math.Min(GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Stars), NDGOJGLPIJF.DGIKLPPBGHJ);
					CollectedStarCount.FCJBBPHFNPJ = BMBLEDJKGFG - PEHBMFDNLBB + "/" + NDGOJGLPIJF.DGIKLPPBGHJ;
					DBBPLBJFOIK(BMBLEDJKGFG);
					base.gameObject.transform.localScale = Vector3.one;
					break;
				case KMEIGFENLNO.Open:
					OpenButton.CanBeAnimated = false;
					CollectContainer.SetActive(false);
					CollectContent.SetActive(false);
					OpenContent.SetActive(true);
					LDOFPOJOALI(true);
					PEHBMFDNLBB = 0;
					break;
				}
			}
		}

		public override void UpdateDisplay()
		{
			int dGIKLPPBGHJ = NDGOJGLPIJF.DGIKLPPBGHJ;
			BMBLEDJKGFG = Math.Min(GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Stars), dGIKLPPBGHJ);
			if (NDGOJGLPIJF.GABGKBAKHDP.AEFOGGAOFEE())
			{
				if (BMBLEDJKGFG == dGIKLPPBGHJ && NDGOJGLPIJF.GABGKBAKHDP.AMKOJOKCELO == 0)
				{
					ChangeState(KMEIGFENLNO.Open);
				}
				else
				{
					ChangeState(KMEIGFENLNO.Collect);
				}
			}
		}

		public void OnClick()
		{
			CFPKNHKNFOH();
			BMBLEDJKGFG = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Stars);
			if (BMBLEDJKGFG < NDGOJGLPIJF.DGIKLPPBGHJ)
			{
				ChestInfoDialog component = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.StarChestInfoDialog, false).GetComponent<ChestInfoDialog>();
				component.SetStarChestTargetCount(NDGOJGLPIJF.DGIKLPPBGHJ);
				UpdateDisplay();
			}
			else
			{
				GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.StarChestDialog, false);
				StarChestDialog component2 = gameObject.GetComponent<StarChestDialog>();
				component2.OnChestClaimed = UpdateDisplay;
				PEHBMFDNLBB = 0;
			}
		}

		public void DecreaseStarCount(int OBAOKEIDEBE)
		{
			PEHBMFDNLBB = OBAOKEIDEBE;
			int num = BMBLEDJKGFG - PEHBMFDNLBB;
			CollectedStarCount.FCJBBPHFNPJ = num + "/" + NDGOJGLPIJF.DGIKLPPBGHJ;
			DBBPLBJFOIK(num);
		}

		public void IncreaseStarCount(bool LFOMNBIBABO = false)
		{
			PEHBMFDNLBB--;
			int dGIKLPPBGHJ = NDGOJGLPIJF.DGIKLPPBGHJ;
			int val = BMBLEDJKGFG - PEHBMFDNLBB;
			val = Math.Min(val, dGIKLPPBGHJ);
			CollectedStarCount.FCJBBPHFNPJ = val + "/" + dGIKLPPBGHJ;
			DBBPLBJFOIK(val);
			StarHitParticle.Stop();
			StarHitParticle.Play();
			FlashSprite.DOKill();
			FlashSprite.color = new Color(1f, 1f, 1f, 0.4f);
			FlashSprite.DOFade(0f, 0.3f);
			LDOFPOJOALI();
			base.transform.DOPunchScale(Vector3.one * -0.03f, 0.15f, 2);
			if (LFOMNBIBABO && val == dGIKLPPBGHJ)
			{
				ChangeState(KMEIGFENLNO.Open);
				OpenParticle.Play();
			}
		}

		private void DBBPLBJFOIK(int ENMLICFLHAO)
		{
			int dGIKLPPBGHJ = NDGOJGLPIJF.DGIKLPPBGHJ;
			float x = -1.623f - -0.93700004f / (float)dGIKLPPBGHJ * (float)ENMLICFLHAO;
			Vector3 localPosition = StarBar.transform.localPosition;
			localPosition.x = x;
			StarBar.transform.localPosition = localPosition;
			float x2 = 0.42f - -1.873675f / (float)dGIKLPPBGHJ * (float)ENMLICFLHAO;
			Vector2 size = StarBar.size;
			size.x = x2;
			StarBar.size = size;
		}

		public void IncreaseUpdateStarCount()
		{
			int dGIKLPPBGHJ = NDGOJGLPIJF.DGIKLPPBGHJ;
			int num = Math.Min(BMBLEDJKGFG = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Stars), dGIKLPPBGHJ);
			CollectedStarCount.FCJBBPHFNPJ = num + "/" + dGIKLPPBGHJ;
			DBBPLBJFOIK(num);
			UpdateDisplay();
		}
	}
}
