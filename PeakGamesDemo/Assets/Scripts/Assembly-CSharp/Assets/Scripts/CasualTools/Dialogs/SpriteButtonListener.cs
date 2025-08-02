using System;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Tutorials;
using Assets.Scripts.GamePlayScene.UI;
using Assets.Scripts.SceneTransitions;
using CasualTools.Dialogs;
using UnityEngine;
using Utils;

namespace Assets.Scripts.CasualTools.Dialogs
{
	public class SpriteButtonListener : MonoBehaviour
	{
		private const string MLAEDIALHKA = "SpriteButton";

		private const string KJAOIMNOGPL = "DialogSpriteButton";

		public static SpriteButtonListener Instance;

		private GameObject CAOFOGLOHDK;

		private Camera PJLJFCCLOJI;

		private bool EGEAMIHKICO;

		private bool GGGPNHMOBPE;

		private Vector3 KBCEKPCPLPE;

		public bool ScreenLockedByNative;

		public bool EnableClicks = true;

		public Vector3 LastTouchUpPosition;

		public void Awake()
		{
			if (Instance == null || Instance != this)
			{
				Instance = this;
			}
			PJLJFCCLOJI = GetComponent<Camera>();
		}

		public void OnDestroy()
		{
			if (Instance == this)
			{
				Instance = null;
			}
		}

		public void InvalidateTouch()
		{
			if (CAOFOGLOHDK != null)
			{
				EGEAMIHKICO = true;
			}
		}

		private void LateUpdate()
		{
			if (EnableClicks && !ScreenLockedByNative)
			{
				if (Input.GetKeyDown(KeyCode.Escape))
				{
					JHKBFMEMLAA();
				}
				else
				{
					GetUserActionMobile();
				}
			}
		}

		private static void JHKBFMEMLAA()
		{
			try
			{
				if (CaravanSceneManager.GDLJAINDFOJ || (LoadingScreenDisplayer.Instance != null && LoadingScreenDisplayer.Instance.CDIJIMCMCOE) || TutorialManager.TutorialActive || FHAAAFAAMDO.GABGKBAKHDP == null || (LevelBuilder.ActiveLevel != null && LevelBuilder.ActiveLevel.CELPAPAMMFK()))
				{
					return;
				}
				Dialog dialog = FHAAAFAAMDO.GABGKBAKHDP.NGIEPDBBJBP();
				if (dialog != null)
				{
					if (dialog.CanHandleBackButton())
					{
						dialog.Close();
					}
				}
				else
				{
					if (FHAAAFAAMDO.GABGKBAKHDP.COCNAAGPOMN)
					{
						return;
					}
					MapTutorial activeMapTutorial = MapTutorial.ActiveMapTutorial;
					if (activeMapTutorial != null)
					{
						activeMapTutorial.SkipTutorial();
					}
					else
					{
						if (LevelBuilder.ActiveLevel != null && (LevelBuilder.ActiveLevel.EBMFPDNPIEM <= 0 || LevelBuilder.ActiveLevel.NPMIKDPNBIA))
						{
							return;
						}
						SettingsPanel instance = SettingsPanel.Instance;
						if (instance != null)
						{
							if (instance.BLBFOGEDAPH)
							{
								instance.SettingsClicked();
							}
							if (instance.CurrentBoosterManager.ShouldCancellSelectedItem())
							{
								return;
							}
						}
						FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.QuitDialog, false);
					}
				}
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SpriteButtonListener, "BackButtonClicked Error:{0} Stack:{1}", ex.Message, ex.StackTrace);
			}
		}

		private void KPCKCDGGBMF(Vector2 NPGMHNONCGO)
		{
			GGGPNHMOBPE = FHAAAFAAMDO.GABGKBAKHDP.COCNAAGPOMN;
			KBCEKPCPLPE = PJLJFCCLOJI.ScreenToWorldPoint(NPGMHNONCGO);
			Collider2D collider2D = Physics2D.OverlapPoint(KBCEKPCPLPE);
			if (collider2D == null || !collider2D.CompareTag((!FHAAAFAAMDO.GABGKBAKHDP.COCNAAGPOMN && !TutorialManager.TutorialActive) ? "SpriteButton" : "DialogSpriteButton"))
			{
				return;
			}
			CAOFOGLOHDK = collider2D.gameObject;
			if (!(CAOFOGLOHDK == null))
			{
				BaseButton component = CAOFOGLOHDK.GetComponent<BaseButton>();
				if (component == null)
				{
					CAOFOGLOHDK = null;
				}
				else
				{
					component.ButtonDown();
				}
			}
		}

		private void NKPMGDHHBPB(Vector2 NPGMHNONCGO)
		{
			if (CAOFOGLOHDK == null)
			{
				return;
			}
			BaseButton component = CAOFOGLOHDK.GetComponent<BaseButton>();
			if (!(component == null))
			{
				Collider2D collider2D = Physics2D.OverlapPoint(PJLJFCCLOJI.ScreenToWorldPoint(NPGMHNONCGO));
				if (collider2D == null || collider2D.gameObject != CAOFOGLOHDK)
				{
					component.ButtonUp(false);
				}
			}
		}

		private void EFECEAIKDLA(Vector2 NPGMHNONCGO)
		{
			LastTouchUpPosition = PJLJFCCLOJI.ScreenToWorldPoint(NPGMHNONCGO);
			Collider2D collider2D = Physics2D.OverlapPoint(LastTouchUpPosition);
			if (GGGPNHMOBPE)
			{
				TouchBoundsListener.Instance.CloseCurrentDialogOnOuterClick(KBCEKPCPLPE, LastTouchUpPosition, CAOFOGLOHDK);
			}
			if (CAOFOGLOHDK != null)
			{
				BaseButton component = CAOFOGLOHDK.GetComponent<BaseButton>();
				if (component != null)
				{
					component.ButtonUp(collider2D != null && collider2D.gameObject == CAOFOGLOHDK && !EGEAMIHKICO);
				}
			}
			CAOFOGLOHDK = null;
			EGEAMIHKICO = false;
		}

		public void GetUserActionMobile()
		{
			if (Input.touchCount > 0)
			{
				Touch touch = Input.GetTouch(0);
				Vector2 position = touch.position;
				switch (touch.phase)
				{
				case TouchPhase.Began:
					KPCKCDGGBMF(position);
					break;
				case TouchPhase.Moved:
					NKPMGDHHBPB(position);
					break;
				case TouchPhase.Ended:
					EFECEAIKDLA(position);
					break;
				}
			}
		}
	}
}
