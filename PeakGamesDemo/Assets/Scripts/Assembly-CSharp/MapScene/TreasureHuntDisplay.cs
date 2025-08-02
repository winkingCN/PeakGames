using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.Utils;
using DG.Tweening;
using DataHelpers;
using Dialogs;
using NewMapScene;
using TMPro;
using UnityEngine;
using Utils;

namespace MapScene
{
	public class TreasureHuntDisplay : TimerMapDisplay, CCGJIPEFOEL
	{
		[CompilerGenerated]
		private sealed class DMLHJMMOJDD
		{
			internal ParticleSystem FLLHHHDFCKA;

			internal void AGFNGEFDHLA()
			{
				if (!(FLLHHHDFCKA == null))
				{
					FLLHHHDFCKA.Stop();
					FLLHHHDFCKA.gameObject.MEJPNNFDEBD();
				}
			}
		}

		public SpriteRenderer[] SpriteRenderers;

		public TextMeshPro OpenText;

		public GameObject TreasureKeyCollectParticle;

		public CollectTreasureKey CollectTreasureKeyPrefab;

		public Sprite TreasureKeyBackgroundOnCounting;

		public Sprite TreasureKeyBackgroundOnOpen;

		public TreasureHuntDisplayAnimation TreasureHuntDisplayAnimation;

		private int KIHPFKLBAHH;

		private bool EKCINKDJPDI;

		private Action NAFKELLKIKO;

		private Action KFNJMBFFIFK;

		public void PlayHitAnimation()
		{
			Prepare();
			Vector3 localScale = base.transform.localScale;
			Sequence s = DOTween.Sequence();
			s.Insert(0f, base.transform.DOScale(localScale * 0.9f, 0.1f));
			s.Insert(0.1f, base.transform.DOScale(localScale, 0.1f));
			ParticleSystem FLLHHHDFCKA = TreasureKeyCollectParticle.JOBDHIPIMAG().GetComponent<ParticleSystem>();
			if (FLLHHHDFCKA == null)
			{
				return;
			}
			FLLHHHDFCKA.transform.position = base.transform.position;
			FLLHHHDFCKA.Play();
			CFNKECEHDIC cFNKECEHDIC = DGOMNDMPMBG.GABGKBAKHDP.OEPCIADENMH;
			TreasureHuntDisplayAnimation.PlayHitAnimation(cFNKECEHDIC.AEPLIGFCGIF == 2);
			AudioManager.Play(KOOGPFAPGGD.TreasureKeyHit);
			Sequence sequence = DOTween.Sequence();
			sequence.AppendInterval(1f);
			sequence.OnComplete(delegate
			{
				if (!(FLLHHHDFCKA == null))
				{
					FLLHHHDFCKA.Stop();
					FLLHHHDFCKA.gameObject.MEJPNNFDEBD();
				}
			});
		}

		public void Prepare()
		{
			CFNKECEHDIC cFNKECEHDIC = DGOMNDMPMBG.GABGKBAKHDP.OEPCIADENMH;
			if (cFNKECEHDIC == null || !cFNKECEHDIC.NPHPMJFFPGB)
			{
				base.gameObject.SetActive(false);
				return;
			}
			base.gameObject.SetActive(true);
			if (TreasureHuntInfoDialog.ShouldLoadDialogArtwork())
			{
				StartCoroutine(TreasureHuntInfoDialog.LoadDialogArtwork());
			}
			MNGFOOGIKKO = cFNKECEHDIC.AEBACBBGHKI;
			KNOPPLNGLIN(cFNKECEHDIC);
		}

		private void KNOPPLNGLIN(CFNKECEHDIC MNPBOAKDKDI)
		{
			switch (MNPBOAKDKDI.AEPLIGFCGIF)
			{
			case 1:
				IOPCENJILNF();
				MOGHDBCJHIC(false);
				break;
			case 2:
				GMOMEPNHJGA();
				MOGHDBCJHIC(true);
				break;
			default:
				GMOMEPNHJGA();
				break;
			}
		}

		public void OnClick()
		{
			bool flag = NAFKELLKIKO != null;
			CFNKECEHDIC cFNKECEHDIC = DGOMNDMPMBG.GABGKBAKHDP.OEPCIADENMH;
			if (cFNKECEHDIC == null)
			{
				Prepare();
				return;
			}
			if (flag)
			{
				DialogLibrary.GABGKBAKHDP.ShowDialogBackgroundFast();
			}
			GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.TreasureHuntInfoDialog, false, false, false, null, !flag);
			TreasureHuntInfoDialog component = gameObject.GetComponent<TreasureHuntInfoDialog>();
			component.PrepareDialog(EKCINKDJPDI);
			JAHBFEJMEBO(component);
		}

		public void SetClickOnceCallback(Action FFFINJKEBGO, Action ADBCFBIKKCP, bool OKAGICINMBN)
		{
			KFNJMBFFIFK = FFFINJKEBGO;
			NAFKELLKIKO = ADBCFBIKKCP;
			EKCINKDJPDI = OKAGICINMBN;
		}

		private void JAHBFEJMEBO(OnCloseCallbackDialog HDCNHMFEFLB)
		{
			if (KFNJMBFFIFK != null)
			{
				KFNJMBFFIFK();
				KFNJMBFFIFK = null;
				if (NAFKELLKIKO != null)
				{
					HDCNHMFEFLB.SetOnDialogClosedCallback(NAFKELLKIKO);
					NAFKELLKIKO = null;
				}
			}
		}

		public void ChangeButtonDepth(float IGNEOOOFEMO)
		{
			Vector3 localPosition = base.transform.localPosition;
			localPosition.z = IGNEOOOFEMO;
			base.transform.localPosition = localPosition;
		}

		public void IncreaseSortingOrder(int NNIDKMJGAJO)
		{
			int num = SpriteRenderers.Length;
			for (int i = 0; i < num; i++)
			{
				SpriteRenderer spriteRenderer = SpriteRenderers[i];
				if (spriteRenderer != null)
				{
					spriteRenderer.sortingOrder += NNIDKMJGAJO;
				}
			}
			TimeLeft.GDDGFAKOCIL += NNIDKMJGAJO;
			OpenText.GDDGFAKOCIL += NNIDKMJGAJO;
		}

		private void MOGHDBCJHIC(bool DOKMPEOLBGO)
		{
			SpriteRenderers[10].enabled = DOKMPEOLBGO;
			SpriteRenderers[11].enabled = DOKMPEOLBGO;
			OpenText.enabled = DOKMPEOLBGO;
			TimeLeft.enabled = !DOKMPEOLBGO;
			if (DOKMPEOLBGO)
			{
				SpriteRenderers[0].sprite = TreasureKeyBackgroundOnOpen;
				SpriteRenderers[1].sprite = TreasureKeyBackgroundOnOpen;
			}
			else
			{
				SpriteRenderers[0].sprite = TreasureKeyBackgroundOnCounting;
				SpriteRenderers[1].sprite = TreasureKeyBackgroundOnCounting;
			}
		}

		private void IOPCENJILNF()
		{
			if (MNGFOOGIKKO > 0)
			{
				TimerHelper.GABGKBAKHDP.RegisterTimer(this);
			}
			DPOOABPAMFO();
		}

		public void UpdateTimeLeft()
		{
			CFNKECEHDIC cFNKECEHDIC = DGOMNDMPMBG.GABGKBAKHDP.OEPCIADENMH;
			MNGFOOGIKKO = ((cFNKECEHDIC != null) ? cFNKECEHDIC.AEBACBBGHKI : 0);
			DPOOABPAMFO();
		}

		public void DecreaseTimeLeft()
		{
			MNGFOOGIKKO--;
			DPOOABPAMFO();
		}

		private void DPOOABPAMFO()
		{
			if (MNGFOOGIKKO <= 0 || DGOMNDMPMBG.GABGKBAKHDP.OEPCIADENMH == null)
			{
				TreasureHuntDisplayAnimation.StopAllAnimations();
				GMOMEPNHJGA();
			}
			else
			{
				CHIBCELAMDG();
				TimeLeft.FCJBBPHFNPJ = GJEIMLMEHIN.FLANACEGNEO((int)MNGFOOGIKKO, true);
			}
		}

		private void GMOMEPNHJGA()
		{
			TimerHelper.GABGKBAKHDP.DeregisterTimer(this);
			KGLFJKJCIKP(LHDGDLKEFJG.Finished);
		}

		private void OnDestroy()
		{
			TreasureHuntInfoDialog.UnloadDialogArtwork();
		}
	}
}
