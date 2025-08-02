using System;
using System.Collections;
using Assets.Scripts.MapScene;
using DG.Tweening;
using DataHelpers;
using Dialogs;
using TMPro;
using UnityEngine;
using Utils;

namespace MapScene
{
	public class TeamChestDisplay : TimerMapDisplay, CCGJIPEFOEL
	{
		public SpriteRenderer[] SpriteRenderers;

		public TextMeshPro OpenText;

		public GameObject CollectContainer;

		public GameObject ChestAnimation;

		public Transform AnimatorTransform;

		public Sprite ChestBackgroundOnCounting;

		public Sprite ChestBackgroundOnOpen;

		private long MEDKNCCJPKL;

		private bool EKCINKDJPDI;

		private Action NAFKELLKIKO;

		private Action KFNJMBFFIFK;

		private Coroutine JOJOIIBODBK;

		public void SetClickOnceCallback(Action FFFINJKEBGO, Action ADBCFBIKKCP, bool OKAGICINMBN)
		{
			KFNJMBFFIFK = FFFINJKEBGO;
			NAFKELLKIKO = ADBCFBIKKCP;
			EKCINKDJPDI = OKAGICINMBN;
		}

		public void Prepare()
		{
			AAPMDEEMEMM aAPMDEEMEMM = DGOMNDMPMBG.GABGKBAKHDP.BHGCBNAMEFK;
			if (aAPMDEEMEMM == null)
			{
				GHKHLKGIEAA();
				return;
			}
			base.gameObject.SetActive(true);
			KNOPPLNGLIN(aAPMDEEMEMM);
		}

		private void KNOPPLNGLIN(AAPMDEEMEMM HMOBAHHJOJE)
		{
			int num = HMOBAHHJOJE.KKGHMHHILNF;
			PHNNOICOIAE(num == 2);
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "Setup TC Display for: " + num);
			switch (num)
			{
			case 1:
				AAEANMFOAGB();
				ChestAnimation.SetActive(false);
				CollectContainer.SetActive(true);
				OpenText.enabled = false;
				TimeLeft.enabled = true;
				TimeLeft.JOPPDFNGJBM = KNOECCJHIDP.Left;
				MNGFOOGIKKO = HMOBAHHJOJE.AEBACBBGHKI;
				ELBACPMLLKH();
				IOPCENJILNF();
				break;
			case 2:
				JOMBBBHMCGI();
				ChestAnimation.SetActive(true);
				CollectContainer.SetActive(false);
				OpenText.enabled = true;
				TimeLeft.enabled = false;
				MEDKNCCJPKL = HMOBAHHJOJE.PGMKKMIEBGB;
				GMOMEPNHJGA();
				NNGODEHBCPI(true);
				break;
			case 3:
				AAEANMFOAGB();
				ChestAnimation.SetActive(false);
				CollectContainer.SetActive(true);
				OpenText.enabled = false;
				TimeLeft.enabled = true;
				MEDKNCCJPKL = HMOBAHHJOJE.PGMKKMIEBGB;
				GMOMEPNHJGA();
				NNGODEHBCPI(HMOBAHHJOJE.EBEALFFCHFB);
				break;
			default:
				GHKHLKGIEAA();
				break;
			}
		}

		private void PHNNOICOIAE(bool MKHNIMJIFMB)
		{
			if (MKHNIMJIFMB)
			{
				SpriteRenderers[0].sprite = ChestBackgroundOnOpen;
				SpriteRenderers[1].sprite = ChestBackgroundOnOpen;
				SpriteRenderers[16].enabled = true;
				SpriteRenderers[17].enabled = true;
			}
			else
			{
				SpriteRenderers[0].sprite = ChestBackgroundOnCounting;
				SpriteRenderers[1].sprite = ChestBackgroundOnCounting;
				SpriteRenderers[16].enabled = false;
				SpriteRenderers[17].enabled = false;
			}
		}

		public void OnClick()
		{
			bool flag = NAFKELLKIKO != null;
			if (!GFHPEDILAJG.GABGKBAKHDP.ODMCGBLJFKM)
			{
				if (flag)
				{
					DialogLibrary.GABGKBAKHDP.ShowDialogBackgroundFast();
				}
				GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.TeamChestJoinTeamDialog, false, false, false, null, !flag);
				TeamChestJoinTeamDialog component = gameObject.GetComponent<TeamChestJoinTeamDialog>();
				JAHBFEJMEBO(component);
				return;
			}
			AAPMDEEMEMM aAPMDEEMEMM = DGOMNDMPMBG.GABGKBAKHDP.BHGCBNAMEFK;
			if (aAPMDEEMEMM == null)
			{
				return;
			}
			JJHJHJFNCGC jJHJHJFNCGC = aAPMDEEMEMM.OPBAEEEGPDE;
			if (jJHJHJFNCGC == null)
			{
				MapManager.Instance.ShowErrorMessageAtPosition(NKILHODNBDE.GHBGCADFLFB("TeamChestNoInternet"), Vector3.down * 1.12f);
				return;
			}
			if (flag)
			{
				DialogLibrary.GABGKBAKHDP.ShowDialogBackgroundFast();
			}
			GameObject gameObject2 = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.TeamChestInfoDialog, false, false, false, null, !flag);
			TeamChestInfoDialog component2 = gameObject2.GetComponent<TeamChestInfoDialog>();
			component2.Prepare(aAPMDEEMEMM, EKCINKDJPDI);
			JAHBFEJMEBO(component2);
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

		private void NNGODEHBCPI(bool JLIKBGMLCHP)
		{
			if (JOJOIIBODBK != null && MEDKNCCJPKL > 0)
			{
				return;
			}
			if (MEDKNCCJPKL <= 0)
			{
				if (!JLIKBGMLCHP)
				{
					GHKHLKGIEAA();
				}
			}
			else
			{
				JOJOIIBODBK = StartCoroutine(KKEHJGBKHHA(JLIKBGMLCHP));
			}
		}

		private void IOPCENJILNF()
		{
			if (MNGFOOGIKKO <= 0)
			{
				GMOMEPNHJGA();
				return;
			}
			TimerHelper.GABGKBAKHDP.RegisterTimer(this);
			DPOOABPAMFO();
		}

		private IEnumerator KKEHJGBKHHA(bool JLIKBGMLCHP)
		{
			do
			{
				yield return MCJHHDACJBG.KNLADMIBAAD;
				MEDKNCCJPKL--;
			}
			while (MEDKNCCJPKL > 0);
			if (!JLIKBGMLCHP)
			{
				GHKHLKGIEAA();
			}
		}

		public void UpdateTimeLeft()
		{
			AAPMDEEMEMM aAPMDEEMEMM = DGOMNDMPMBG.GABGKBAKHDP.BHGCBNAMEFK;
			MNGFOOGIKKO = ((aAPMDEEMEMM != null) ? aAPMDEEMEMM.AEBACBBGHKI : 0);
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

		private void GMOMEPNHJGA()
		{
			TimerHelper.GABGKBAKHDP.DeregisterTimer(this);
			KGLFJKJCIKP(LHDGDLKEFJG.Finished);
		}

		private void ELBACPMLLKH()
		{
			if (JOJOIIBODBK != null)
			{
				StopCoroutine(JOJOIIBODBK);
				JOJOIIBODBK = null;
			}
		}

		private void AAEANMFOAGB()
		{
			AnimatorTransform.DOKill();
			AnimatorTransform.localScale = Vector3.one;
		}

		private void JOMBBBHMCGI()
		{
			AAEANMFOAGB();
			AnimatorTransform.DOScaleX(0.9f, 0.6f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.OutSine);
			AnimatorTransform.DOScaleY(0.9f, 0.6f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.OutSine);
		}

		private void GHKHLKGIEAA()
		{
			base.gameObject.SetActive(false);
			TimerHelper.GABGKBAKHDP.DeregisterTimer(this);
			if (JOJOIIBODBK != null)
			{
				StopCoroutine(JOJOIIBODBK);
			}
			JOJOIIBODBK = null;
		}
	}
}
