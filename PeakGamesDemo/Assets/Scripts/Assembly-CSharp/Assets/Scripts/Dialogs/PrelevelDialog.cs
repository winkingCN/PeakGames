using System;
using System.Collections;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Tutorials;
using Assets.Scripts.SceneTransitions;
using DG.Tweening;
using LevelLoaderScene;
using MapScene;
using TMPro;
using UnityEngine;
using Utils;

namespace Assets.Scripts.Dialogs
{
	public class PrelevelDialog : BoosterSelectDialog
	{
		public static int ChosenLevel = -1;

		public GameObject HighScoresPanelReference;

		public TextMeshPro TitleLabel;

		public GameObject TutorialPrefab;

		public Transform ScalerTransform;

		public bool ShowHighScores;

		public CrownDisplay CrownDisplay;

		private HighScoresPanel LPKKLPGGHMN;

		protected int EADEMDIHGHE;

		private bool GANINCKJBKG;

		protected Action JCOKJJGCPHI;

		public override void DialogCreated()
		{
			base.DialogCreated();
			BoosterSelectDialog.LatestSelectedItems = null;
			if (ShowHighScores)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(HighScoresPanelReference, Vector3.zero, Quaternion.identity);
				LPKKLPGGHMN = gameObject.GetComponent<HighScoresPanel>();
				LPKKLPGGHMN.CurrentDialog = this;
			}
			CrownDisplay.PrepareCrown(CrownDisplay.GetCrownStage());
		}

		public virtual void SetContent(int KIGOGMKCDKN, bool DLPNHOMMGGF = false, Action IMHLFAHONPP = null)
		{
			JCOKJJGCPHI = IMHLFAHONPP;
			EADEMDIHGHE = KIGOGMKCDKN;
			ChosenLevel = EADEMDIHGHE;
			int num = ((LevelLoaderController.FakeLevelNo < 0) ? EADEMDIHGHE : LevelLoaderController.FakeLevelNo);
			TitleLabel.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Level") + num;
			int num2 = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC();
			GANINCKJBKG = JGOKCHOGLJB();
			if (GANINCKJBKG)
			{
				MKINMKEMBPL.GABGKBAKHDP.KMPGGMKICLB("TutorialPrelevel");
			}
			for (int i = 0; i < FOHMHKLNLEG.Length && i < Boosters.Length; i++)
			{
				bool mHDCKCCCBAM = num2 < 6;
				Boosters[i].Init(FOHMHKLNLEG[i], mHDCKCCCBAM, this);
			}
			if (LPKKLPGGHMN != null)
			{
				LPKKLPGGHMN.DIOELAHNLKJ(KIGOGMKCDKN, 0);
			}
		}

		private bool JGOKCHOGLJB()
		{
			if (TutorialPrefab == null || !TutorialManager.ShouldDisplayPrelevelTutorial)
			{
				return false;
			}
			TutorialManager.ShouldDisplayPrelevelTutorial = false;
			return EADEMDIHGHE == 7 && !MKINMKEMBPL.GABGKBAKHDP.HEANMKDLPGF("TutorialPrelevel");
		}

		public override void OnDialogClosed()
		{
			if (LPKKLPGGHMN != null)
			{
				UnityEngine.Object.Destroy(LPKKLPGGHMN.gameObject);
			}
			ChosenLevel = -1;
			if (ELBMHNOBHPN.DJGMHLLAGLE)
			{
				FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.LifeHackDialog, false);
				return;
			}
			LevelBuilder.KDBDBMBAKEL = "Map";
			BoosterSelectDialog.LatestSelectedItems = null;
			if (JCOKJJGCPHI != null)
			{
				JCOKJJGCPHI();
			}
		}

		protected override void BLELAMHLLNN()
		{
			base.BLELAMHLLNN();
			if (GANINCKJBKG)
			{
				GANINCKJBKG = false;
				JBLHLNCOLHD();
				GameObject gameObject = UnityEngine.Object.Instantiate(TutorialPrefab);
				gameObject.transform.SetParent(ScalerTransform);
				gameObject.transform.localScale = Vector3.one;
				gameObject.transform.localPosition = Vector3.zero;
				PrelevelTutorial component = gameObject.GetComponent<PrelevelTutorial>();
				component.Init(this);
			}
		}

		public override void PlayDialogInAnimation()
		{
			base.PlayDialogInAnimation();
			if (!base.gameObject.activeSelf)
			{
				base.gameObject.SetActive(true);
			}
			StartCoroutine(MACGLLFCNIA());
		}

		public override Sequence PlayDialogOutAnimation()
		{
			if (LPKKLPGGHMN != null)
			{
				LPKKLPGGHMN.CPPHECFAEAD();
			}
			return base.PlayDialogOutAnimation();
		}

		private IEnumerator MACGLLFCNIA()
		{
			yield return MCJHHDACJBG.CNDGGNLKOOC;
			if (LPKKLPGGHMN != null)
			{
				LPKKLPGGHMN.ABOFKOHLOGC();
			}
		}

		public void OnPlayClick()
		{
			if (PJPPADHKGHN.GABGKBAKHDP.PMBGCACJIHD().DLDHNNCGIPI > 0)
			{
				BoosterSelectDialog.LatestSelectedItems = KACBDDJNKHC();
				LevelBuilder.CurrentLevelNo = EADEMDIHGHE;
				LevelBuilder.KDBDBMBAKEL = "Map";
				CaravanSceneManager.Load(GKBHIKONCKJ.GamePlay);
			}
			else
			{
				OutOfLivesDialog.RefillStatus = "play";
				OutOfLivesDialog.CreateAndShowOutOfLivesDialog(LCMJNHLHHMP);
			}
		}

		private void LCMJNHLHHMP()
		{
			OutOfLivesDialog.RefillStatus = null;
		}

		public void EnableButtons()
		{
			JNHCICHFNHL();
		}

		private void OnDestroy()
		{
			if (LPKKLPGGHMN != null)
			{
				UnityEngine.Object.Destroy(LPKKLPGGHMN.gameObject);
			}
		}
	}
}
