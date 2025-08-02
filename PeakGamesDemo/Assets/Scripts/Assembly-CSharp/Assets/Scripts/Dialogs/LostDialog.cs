using System.Collections;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.SceneTransitions;
using Assets.Scripts.Utils;
using Assets.Scripts.Utils.Analytics;
using DG.Tweening;
using LevelLoaderScene;
using TMPro;
using UnityEngine;
using Utils;

namespace Assets.Scripts.Dialogs
{
	public class LostDialog : BoosterSelectDialog
	{
		public GameObject HighScoresPanelReference;

		public TextMeshPro TitleLabel;

		public bool ShowHighScores;

		private HighScoresPanel LPKKLPGGHMN;

		private KFCEILFGADG NLKHKDBCLMB;

		private bool CCPBPONCJAD;

		public override void DialogCreated()
		{
			base.DialogCreated();
			LevelBuilder.LastLevel.GBHOKPGEGEN();
			if (ShowHighScores)
			{
				GameObject gameObject = Object.Instantiate(HighScoresPanelReference, Vector3.zero, Quaternion.identity);
				LPKKLPGGHMN = gameObject.GetComponent<HighScoresPanel>();
				LPKKLPGGHMN.CurrentDialog = this;
			}
			FocusListener.ResetGamePlayCrash();
			if (DIGGBGADIGJ.DFGKPMCBFNL)
			{
				DIGGBGADIGJ.GABGKBAKHDP.JDHNHIKEOMA();
			}
			EAJKFHMFMMD();
		}

		private static void EAJKFHMFMMD()
		{
			DGOMNDMPMBG.GABGKBAKHDP.JDHNHIKEOMA();
		}

		public override Sequence PlayDialogOutAnimation()
		{
			if (LPKKLPGGHMN != null)
			{
				LPKKLPGGHMN.CPPHECFAEAD();
			}
			return base.PlayDialogOutAnimation();
		}

		public override void PlayDialogInAnimation()
		{
			base.PlayDialogInAnimation();
			if (!base.gameObject.activeSelf)
			{
				base.gameObject.SetActive(true);
			}
			if (LPKKLPGGHMN != null)
			{
				StartCoroutine(MACGLLFCNIA());
			}
		}

		private IEnumerator MACGLLFCNIA()
		{
			LPKKLPGGHMN.RefreshHighscorePanel();
			yield return MCJHHDACJBG.CNDGGNLKOOC;
			LPKKLPGGHMN.ABOFKOHLOGC();
		}

		public override void OnDialogClosed()
		{
			if (LPKKLPGGHMN != null)
			{
				Object.Destroy(LPKKLPGGHMN.gameObject);
			}
			if (CCPBPONCJAD)
			{
				BoosterSelectDialog.LatestSelectedItems = KACBDDJNKHC();
				if (PJPPADHKGHN.GABGKBAKHDP.PMBGCACJIHD().DLDHNNCGIPI > 0)
				{
					NLKHKDBCLMB.GIMBEKBFKMJ.RetryLevel();
					return;
				}
				OutOfLivesDialog.RefillStatus = "tryagain";
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LostDialog, "User don't have any lives left to retry the level.");
				OutOfLivesDialog.CreateAndShowOutOfLivesDialog(GLFAFHOAFPF);
			}
		}

		public void OnRetryClicked()
		{
			CCPBPONCJAD = true;
			Close();
		}

		public override void Close()
		{
			if (!CCPBPONCJAD)
			{
				CaravanSceneManager.Load((LevelLoaderController.IsOnlineLevel || LevelLoaderController.IsOfflineLevel) ? GKBHIKONCKJ.LevelLoader : GKBHIKONCKJ.Map);
			}
			else
			{
				base.Close();
			}
		}

		private void GLFAFHOAFPF()
		{
			OutOfLivesDialog.RefillStatus = null;
			GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK((!LevelBuilder.LastLevel.EKGHEGKILLC) ? DialogLibrary.GABGKBAKHDP.LostDialog : DialogLibrary.GABGKBAKHDP.CLLostDialog, false);
			LostDialog component = gameObject.GetComponent<LostDialog>();
			if (component != null)
			{
				component.SetContent(NLKHKDBCLMB, false, true);
			}
		}

		public void SetContent(KFCEILFGADG GIOFHACJEGA, bool LLOLEDGKNFN = false, bool MLJLDIHFEOB = false)
		{
			AudioManager.ResetExternalAudioSources();
			NLKHKDBCLMB = GIOFHACJEGA;
			if (LPKKLPGGHMN != null)
			{
				LPKKLPGGHMN.DIOELAHNLKJ(NLKHKDBCLMB.PDGLECFDLJJ, -1);
			}
			if (!MLJLDIHFEOB)
			{
				AudioManager.PlayStinger(KOOGPFAPGGD.StingerLevelFailed);
				LevelBuilder.Recorder.GAMDCIKLKJC(!LLOLEDGKNFN);
				string text = "Goal Progress: ";
				foreach (OGIFMLFEAEM item in GIOFHACJEGA.JKKJLDLMIOG)
				{
					text += item;
				}
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LostDialog, text);
			}
			if (LevelBuilder.LastLevel.EKGHEGKILLC)
			{
				TitleLabel.FCJBBPHFNPJ = IDFPAFEJPPH.GABGKBAKHDP.EGLOCAFPJCJ;
			}
			else
			{
				int num = ((LevelLoaderController.FakeLevelNo < 0) ? NLKHKDBCLMB.PDGLECFDLJJ : LevelLoaderController.FakeLevelNo);
				TitleLabel.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Level") + num;
			}
			int num2 = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC();
			for (int i = 0; i < FOHMHKLNLEG.Length && i < Boosters.Length; i++)
			{
				bool mHDCKCCCBAM = num2 < 6;
				PrelevelDialogBooster prelevelDialogBooster = Boosters[i];
				prelevelDialogBooster.Init(FOHMHKLNLEG[i], mHDCKCCCBAM, this);
				if (MLJLDIHFEOB && BoosterSelectDialog.LatestSelectedItems != null)
				{
					prelevelDialogBooster.SwitchBoosterStatusByItemType(BoosterSelectDialog.LatestSelectedItems);
				}
			}
			BoosterSelectDialog.LatestSelectedItems = null;
			if (!MLJLDIHFEOB)
			{
				CIBKGNFLBDE(NLKHKDBCLMB, LLOLEDGKNFN);
			}
		}

		private static void CIBKGNFLBDE(KFCEILFGADG GIOFHACJEGA, bool LLOLEDGKNFN)
		{
			JsonLevelEndInventory jsonLevelEndInventory = new JsonLevelEndInventory();
			jsonLevelEndInventory.inventory = new JsonInventory();
			JsonLevelEndInventory jsonLevelEndInventory2 = jsonLevelEndInventory;
			jsonLevelEndInventory2.inventory.LDOCFEGBGNK();
			jsonLevelEndInventory2.NMCGKNPBGKC();
			int moves_given = GIOFHACJEGA.HJCPDOGONIG + (LevelBuilder.LastLevel.EKGHEGKILLC ? IDFPAFEJPPH.GABGKBAKHDP.BFBNJLMHPFA : 0);
			JsonLevelEndData jsonLevelEndData = new JsonLevelEndData();
			jsonLevelEndData.user_id = LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString();
			jsonLevelEndData.level = ((!LevelBuilder.LastLevel.EKGHEGKILLC) ? GIOFHACJEGA.PDGLECFDLJJ : (-1 * GIOFHACJEGA.PDGLECFDLJJ));
			jsonLevelEndData.level_name = GIOFHACJEGA.PNGPLGHKFDI;
			jsonLevelEndData.level_max = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1;
			jsonLevelEndData.number_of_ego_shown = GIOFHACJEGA.KFHIMNCFLFD;
			jsonLevelEndData.result = (LLOLEDGKNFN ? (-1) : 0);
			jsonLevelEndData.user_score = ScoreManager.DJADMBLKBKJ;
			jsonLevelEndData.moves_given = moves_given;
			jsonLevelEndData.moves_made = GIOFHACJEGA.EPLKIIOCNPE;
			jsonLevelEndData.duration = (int)((GIOFHACJEGA.NAFLKPJGHHD != 0f) ? (Time.realtimeSinceStartup - GIOFHACJEGA.NAFLKPJGHHD) : 0f);
			jsonLevelEndData.min_fps = GIOFHACJEGA.GIMBEKBFKMJ.FPSMeter.MinimumFps().ToString();
			jsonLevelEndData.max_fps = GIOFHACJEGA.GIMBEKBFKMJ.FPSMeter.MaximumFps().ToString();
			jsonLevelEndData.avg_fps = GIOFHACJEGA.GIMBEKBFKMJ.FPSMeter.AverageFps().ToString();
			jsonLevelEndData.under_50_fps = GIOFHACJEGA.GIMBEKBFKMJ.FPSMeter.SpikeCount();
			jsonLevelEndData.data = jsonLevelEndInventory2;
			JsonLevelEndData jsonLevelEndData2 = jsonLevelEndData;
			jsonLevelEndData2.LLGLAHKBJJG();
			AFJPGLHKOID.CIBKGNFLBDE(jsonLevelEndData2);
		}

		public override bool CanCloseOnBlackPanelTouch()
		{
			return false;
		}
	}
}
