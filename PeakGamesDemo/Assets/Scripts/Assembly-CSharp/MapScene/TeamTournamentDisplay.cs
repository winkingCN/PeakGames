using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.MapScene;
using DG.Tweening;
using DataHelpers;
using Dialogs;
using UnityEngine;
using Utils;

namespace MapScene
{
	public class TeamTournamentDisplay : TimerMapDisplay, CCGJIPEFOEL
	{
		public SpriteRenderer[] SpriteRenderers;

		public ParticleSystemRenderer[] ParticleSystems;

		public Animator CurrentAnimator;

		private int HNHPBOOPHLK;

		private int EFOAFHLDPJA;

		private Sequence HJELEOFDIKN;

		private Action KFNJMBFFIFK;

		private Action NAFKELLKIKO;

		private bool LOJDMCMGJAI;

		public void SetClickOnceCallback(Action FFFINJKEBGO, Action ADBCFBIKKCP)
		{
			KFNJMBFFIFK = FFFINJKEBGO;
			NAFKELLKIKO = ADBCFBIKKCP;
		}

		public void ClearClickOnceCallback()
		{
			KFNJMBFFIFK = null;
			NAFKELLKIKO = null;
		}

		public void Prepare()
		{
			KCKDNJOMPJH kCKDNJOMPJH = DGOMNDMPMBG.GABGKBAKHDP.FABKMFCBELE;
			if (ELBMHNOBHPN.DJGMHLLAGLE || kCKDNJOMPJH == null || !kCKDNJOMPJH.NPHPMJFFPGB)
			{
				base.gameObject.SetActive(false);
				return;
			}
			base.gameObject.SetActive(true);
			HNHPBOOPHLK = Animator.StringToHash("Base Layer.TeamTournamentCollectAnimation2");
			MNGFOOGIKKO = kCKDNJOMPJH.AEBACBBGHKI;
			IOPCENJILNF();
			if (!LevelBuilder.LastLevel.HLFNDDEDJOI)
			{
				StartIconAnimation(false);
			}
		}

		public void OnClick()
		{
			if (!JHOAHCHHBCH.CCAJIIFJPFF())
			{
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("NoInternetConnection"));
				return;
			}
			KCKDNJOMPJH kCKDNJOMPJH = DGOMNDMPMBG.GABGKBAKHDP.FABKMFCBELE;
			if (kCKDNJOMPJH == null)
			{
				Prepare();
				return;
			}
			if (kCKDNJOMPJH.ADNCLLLLMEO)
			{
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Connection"));
				return;
			}
			switch (kCKDNJOMPJH.AEPLIGFCGIF)
			{
			case 0:
			case 1:
				BDOFFAGMHIB(DialogLibrary.GABGKBAKHDP.TeamTournamentAnnouncementDialog);
				break;
			case 2:
				BDOFFAGMHIB(DialogLibrary.GABGKBAKHDP.TeamTournamentInfoDialog);
				break;
			case 3:
				if (kCKDNJOMPJH.EEJGJPLADGB == 0)
				{
					BDOFFAGMHIB(DialogLibrary.GABGKBAKHDP.TeamTournamentRewardDialog);
				}
				else
				{
					BDOFFAGMHIB(DialogLibrary.GABGKBAKHDP.TeamTournamentInfoDialog);
				}
				break;
			}
		}

		private void BDOFFAGMHIB(GameObject HDCNHMFEFLB)
		{
			bool flag = NAFKELLKIKO != null;
			if (flag)
			{
				DialogLibrary.GABGKBAKHDP.ShowDialogBackgroundFast();
			}
			GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(HDCNHMFEFLB, false, false, false, null, !flag);
			OnCloseCallbackDialog component = gameObject.GetComponent<OnCloseCallbackDialog>();
			JAHBFEJMEBO(component);
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
			int num2 = ParticleSystems.Length;
			for (int j = 0; j < num2; j++)
			{
				ParticleSystemRenderer particleSystemRenderer = ParticleSystems[j];
				if (particleSystemRenderer != null)
				{
					particleSystemRenderer.sortingOrder += NNIDKMJGAJO;
				}
			}
			TimeLeft.GDDGFAKOCIL += NNIDKMJGAJO;
		}

		private void IOPCENJILNF()
		{
			if (MNGFOOGIKKO > 0)
			{
				TimerHelper.GABGKBAKHDP.RegisterTimer(this);
				PBGKHIOOMAG();
			}
			DPOOABPAMFO();
		}

		private void PBGKHIOOMAG()
		{
			GPAFPAEDOHM gPAFPAEDOHM = DGOMNDMPMBG.GABGKBAKHDP.IIEALLANECJ;
			if (gPAFPAEDOHM == null)
			{
				LOJDMCMGJAI = true;
				return;
			}
			long num = gPAFPAEDOHM.AEBACBBGHKI - MNGFOOGIKKO;
			LOJDMCMGJAI = num > 5;
		}

		public void UpdateTimeLeft()
		{
			KCKDNJOMPJH kCKDNJOMPJH = DGOMNDMPMBG.GABGKBAKHDP.FABKMFCBELE;
			MNGFOOGIKKO = ((kCKDNJOMPJH != null) ? kCKDNJOMPJH.AEBACBBGHKI : 0);
			DPOOABPAMFO();
		}

		public void DecreaseTimeLeft()
		{
			MNGFOOGIKKO--;
			DPOOABPAMFO();
		}

		private void DPOOABPAMFO()
		{
			if (MNGFOOGIKKO <= 0)
			{
				GMOMEPNHJGA();
				return;
			}
			CHIBCELAMDG();
			TimeLeft.FCJBBPHFNPJ = GJEIMLMEHIN.FLANACEGNEO((int)MNGFOOGIKKO, true);
		}

		public void StartIconAnimation(bool HLFOLDAEPLE)
		{
			if (MNGFOOGIKKO <= 0)
			{
				return;
			}
			if (HLFOLDAEPLE)
			{
				if (HJELEOFDIKN != null)
				{
					HJELEOFDIKN.Kill();
				}
				HJELEOFDIKN = null;
				Sequence s = DOTween.Sequence();
				s.InsertCallback(0.5f, delegate
				{
					if (CurrentAnimator != null && MNGFOOGIKKO > 0 && !FHAAAFAAMDO.GABGKBAKHDP.COCNAAGPOMN)
					{
						CurrentAnimator.Play(HNHPBOOPHLK);
					}
					HECFDLBBJLG();
				});
			}
			else
			{
				HECFDLBBJLG();
			}
		}

		private void HECFDLBBJLG()
		{
			if (HJELEOFDIKN != null)
			{
				return;
			}
			HJELEOFDIKN = DOTween.Sequence();
			HJELEOFDIKN.SetDelay(3f).AppendCallback(delegate
			{
				if (CurrentAnimator != null && MNGFOOGIKKO > 0)
				{
					if (base.gameObject.activeSelf && !FHAAAFAAMDO.GABGKBAKHDP.COCNAAGPOMN)
					{
						CurrentAnimator.Play(HNHPBOOPHLK);
					}
				}
				else
				{
					HJELEOFDIKN.Kill(true);
				}
			}).SetLoops(-1);
		}

		private void GMOMEPNHJGA()
		{
			TimerHelper.GABGKBAKHDP.DeregisterTimer(this);
			KGLFJKJCIKP(LHDGDLKEFJG.Finished);
			if (LOJDMCMGJAI)
			{
				LOJDMCMGJAI = false;
				StartCoroutine(ACLBDBKGJIL());
			}
		}

		private IEnumerator ACLBDBKGJIL()
		{
			yield return MCJHHDACJBG.KNLADMIBAAD;
			KBEGNPKLMDE.IAEBCJLMJJO();
		}

		private void OnApplicationPause(bool MMMKENCKOAL)
		{
			if (MMMKENCKOAL)
			{
				LOJDMCMGJAI = false;
			}
		}

		[CompilerGenerated]
		private void MJNCCELJHOO()
		{
			if (CurrentAnimator != null && MNGFOOGIKKO > 0 && !FHAAAFAAMDO.GABGKBAKHDP.COCNAAGPOMN)
			{
				CurrentAnimator.Play(HNHPBOOPHLK);
			}
			HECFDLBBJLG();
		}

		[CompilerGenerated]
		private void KEGLJKHAGPO()
		{
			if (CurrentAnimator != null && MNGFOOGIKKO > 0)
			{
				if (base.gameObject.activeSelf && !FHAAAFAAMDO.GABGKBAKHDP.COCNAAGPOMN)
				{
					CurrentAnimator.Play(HNHPBOOPHLK);
				}
			}
			else
			{
				HJELEOFDIKN.Kill(true);
			}
		}
	}
}
