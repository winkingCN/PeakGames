using System.Collections;
using System.Runtime.CompilerServices;
using Assets.Scripts.MapScene;
using DG.Tweening;
using DataHelpers;
using Dialogs;
using TMPro;
using UnityEngine;
using Utils;

namespace MapScene
{
	public class StarTournamentDisplay : TimerMapDisplay, CCGJIPEFOEL
	{
		public TextMeshPro RankText;

		public Animator CurrentAnimator;

		public Transform ShineTransform;

		public SpriteRenderer ShineSpriteRenderer;

		private bool LOJDMCMGJAI;

		private static readonly Color IICBFCINFAO = new Color(1f, 1f, 1f, 0.3f);

		private static readonly Color NDLGMBOCGNP = new Color(1f, 1f, 1f, 0.8f);

		private Sequence NAJAGILAIFF;

		public void Prepare()
		{
			GPAFPAEDOHM gPAFPAEDOHM = DGOMNDMPMBG.GABGKBAKHDP.IIEALLANECJ;
			if (ELBMHNOBHPN.DJGMHLLAGLE || gPAFPAEDOHM == null || MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1 < gPAFPAEDOHM.FHIIFBJOKND || (gPAFPAEDOHM.AEPLIGFCGIF < 2 && gPAFPAEDOHM.AEBACBBGHKI < 10800))
			{
				base.gameObject.SetActive(false);
				return;
			}
			base.gameObject.SetActive(true);
			if (gPAFPAEDOHM.AEPLIGFCGIF <= 1)
			{
				RankText.FCJBBPHFNPJ = string.Empty;
			}
			else
			{
				RankText.FCJBBPHFNPJ = gPAFPAEDOHM.OHAPPDGAKNG.ToString();
			}
			MNGFOOGIKKO = gPAFPAEDOHM.AEBACBBGHKI;
			IOPCENJILNF();
			NOADDEBHPJK();
		}

		private void NOADDEBHPJK()
		{
			if (NAJAGILAIFF != null)
			{
				if (NAJAGILAIFF.IsPlaying())
				{
					return;
				}
				NAJAGILAIFF.Kill();
			}
			ShineSpriteRenderer.color = IICBFCINFAO;
			ShineTransform.localPosition = new Vector3(-1.592f, 0.0813f, 0f);
			float num = Random.Range(0f, 1f);
			NAJAGILAIFF = DOTween.Sequence();
			NAJAGILAIFF.Insert(num, ShineTransform.DOLocalMoveX(1.89f, 1.5f));
			NAJAGILAIFF.Insert(num, ShineSpriteRenderer.DOColor(NDLGMBOCGNP, 0.7f));
			NAJAGILAIFF.Insert(num + 0.7f, ShineSpriteRenderer.DOColor(IICBFCINFAO, 0.7f));
			NAJAGILAIFF.OnComplete(NOADDEBHPJK);
		}

		public void OnClick()
		{
			if (!JHOAHCHHBCH.CCAJIIFJPFF())
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.DialogManager, "Do not open dialog from StarTournamentDisplay because there is no internet connection.");
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("NoInternetConnection"));
				return;
			}
			GPAFPAEDOHM gPAFPAEDOHM = DGOMNDMPMBG.GABGKBAKHDP.IIEALLANECJ;
			if (gPAFPAEDOHM == null)
			{
				return;
			}
			if (gPAFPAEDOHM.AEBACBBGHKI > 0 && gPAFPAEDOHM.AEPLIGFCGIF <= 1)
			{
				if (gPAFPAEDOHM.ADNCLLLLMEO)
				{
					MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Connection"));
				}
				else
				{
					FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.StarTournamentAnnouncementDialog, false);
				}
			}
			else if (gPAFPAEDOHM.AEBACBBGHKI > 0)
			{
				FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.StarTournamentInfoDialog, false);
			}
			else if (gPAFPAEDOHM.AEPLIGFCGIF == 2)
			{
				StarTournamentRewardsDialog.ShouldCallGetEventsCommand = true;
				FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.StarTournamentRewardsDialog, false);
			}
			else
			{
				FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.StarTournamentResultDialog, false);
			}
		}

		private void IOPCENJILNF()
		{
			if (MNGFOOGIKKO > 0)
			{
				TimerHelper.GABGKBAKHDP.RegisterTimer(this);
				LOJDMCMGJAI = true;
			}
			DPOOABPAMFO();
		}

		public void UpdateTimeLeft()
		{
			GPAFPAEDOHM gPAFPAEDOHM = DGOMNDMPMBG.GABGKBAKHDP.IIEALLANECJ;
			MNGFOOGIKKO = ((gPAFPAEDOHM != null) ? gPAFPAEDOHM.AEBACBBGHKI : 0);
			DPOOABPAMFO();
		}

		public void DecreaseTimeLeft()
		{
			MNGFOOGIKKO--;
			DPOOABPAMFO();
		}

		private void DPOOABPAMFO()
		{
			if (MNGFOOGIKKO <= 0 || DGOMNDMPMBG.GABGKBAKHDP.IIEALLANECJ == null)
			{
				GMOMEPNHJGA();
				return;
			}
			CHIBCELAMDG();
			TimeLeft.FCJBBPHFNPJ = GJEIMLMEHIN.FLANACEGNEO((int)MNGFOOGIKKO, true);
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

		public void PlayStarCollectAnimation()
		{
			if (MNGFOOGIKKO <= 0 || !base.gameObject.activeSelf)
			{
				return;
			}
			Sequence s = DOTween.Sequence();
			s.InsertCallback(0.5f, delegate
			{
				if (CurrentAnimator != null)
				{
					CurrentAnimator.Play(Animator.StringToHash("Base Layer.StarTournamentMapIconStarCollectAnimation"), -1, 0f);
				}
			});
		}

		private void OnApplicationPause(bool MMMKENCKOAL)
		{
			if (MMMKENCKOAL)
			{
				LOJDMCMGJAI = false;
			}
		}

		[CompilerGenerated]
		private void NGADNIPCKCK()
		{
			if (CurrentAnimator != null)
			{
				CurrentAnimator.Play(Animator.StringToHash("Base Layer.StarTournamentMapIconStarCollectAnimation"), -1, 0f);
			}
		}
	}
}
