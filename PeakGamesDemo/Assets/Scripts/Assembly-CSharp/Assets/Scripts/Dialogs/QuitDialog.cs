using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.SceneTransitions;
using DG.Tweening;
using TMPro;
using UnityEngine;
using Utils;

namespace Assets.Scripts.Dialogs
{
	public class QuitDialog : SimpleDialog
	{
		public SpriteRenderer BrokenHearth;

		public SpriteRenderer BrokenHearthShadow;

		public TextMeshPro InfoText;

		public GameObject CrownRushEvent;

		public TextMeshPro CrownRushMessage;

		public SpriteRenderer[] CrownRushCrowns;

		private bool PEFKMNPDMPJ;

		[CompilerGenerated]
		private static TweenCallback JANLDOMIIEF;

		public override void DialogCreated()
		{
			base.DialogCreated();
			DIGGBGADIGJ dIGGBGADIGJ = DIGGBGADIGJ.GABGKBAKHDP;
			if (CaravanSceneManager.CurrentScene != GKBHIKONCKJ.GamePlay)
			{
				BrokenHearth.enabled = false;
				BrokenHearthShadow.enabled = false;
				InfoText.ANLKLKAINEO.localPosition += Vector3.up;
				InfoText.MHAGENKBNAN = true;
				InfoText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("QuitText");
			}
			else if (DIGGBGADIGJ.DFGKPMCBFNL && dIGGBGADIGJ.BGKIIAJNHLL > 0)
			{
				BrokenHearth.enabled = false;
				BrokenHearthShadow.enabled = false;
				InfoText.enabled = false;
				CrownRushEvent.SetActive(true);
				for (int i = 0; i < dIGGBGADIGJ.BGKIIAJNHLL - 1; i++)
				{
					CrownRushCrowns[i].enabled = true;
				}
				CrownRushMessage.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("CrownRushQuit");
			}
			else if (PJPPADHKGHN.GABGKBAKHDP.HNBIMJHPIPE() > 0)
			{
				BrokenHearth.transform.localPosition += 0.06f * Vector3.up;
				InfoText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("QuitText");
			}
			else
			{
				InfoText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Lose1Live");
			}
		}

		public void YesClicked()
		{
			if (LevelBuilder.ActiveLevel != null)
			{
				LevelBuilder.ActiveLevel.BKBFKFGBKDP = true;
			}
			switch (CaravanSceneManager.CurrentScene)
			{
			case GKBHIKONCKJ.Map:
			case GKBHIKONCKJ.Start:
			{
				KIIMLFPJHHD.LAEKPGADAHF();
				Sequence s = DOTween.Sequence();
				s.InsertCallback(0.1f, Application.Quit);
				break;
			}
			case GKBHIKONCKJ.GamePlay:
				if (LevelBuilder.ActiveLevel != null)
				{
					GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK((!LevelBuilder.LastLevel.EKGHEGKILLC) ? DialogLibrary.GABGKBAKHDP.LostDialog : DialogLibrary.GABGKBAKHDP.CLLostDialog, true);
					LostDialog component = gameObject.GetComponent<LostDialog>();
					component.SetContent(LevelBuilder.ActiveLevel, true);
				}
				break;
			default:
				PEFKMNPDMPJ = true;
				break;
			}
			Close();
		}

		public override void OnDialogClosed()
		{
			base.OnDialogClosed();
			if (PEFKMNPDMPJ)
			{
				CaravanSceneManager.Load(GKBHIKONCKJ.Map);
			}
		}
	}
}
