using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Touches;
using Assets.Scripts.Utils;
using DG.Tweening;
using GamePlayScene.UI;
using UnityEngine;
using Utils;

namespace Assets.Scripts.GamePlayScene.UI
{
	public class SettingsPanel : MonoBehaviour
	{
		public static SettingsPanel Instance;

		public LevelBuilder CurrentLevelBuilder;

		private bool LBKPPKEADMM;

		public GameObject BottomPanel;

		public BoosterManager CurrentBoosterManager;

		public GameObject DisabledImageMusic;

		public GameObject DisabledImageSound;

		private Sequence EMHBCIHHILK;

		public EventBasedSpriteButton SettingButton;

		public GameObject SettingsButton1;

		public GameObject SettingsButton2;

		public GameObject SettingsButton3;

		public GameObject SettingsButtonsHolder;

		private bool LLDHHJNHCEN;

		private bool GPCDKLIBIOI;

		private bool OPIPILEFLEP;

		public bool BLBFOGEDAPH { get; private set; }

		public SettingsPanel()
		{
			BLBFOGEDAPH = false;
		}

		public void Awake()
		{
			Instance = this;
		}

		public void OnDestroy()
		{
			Instance = null;
		}

		public void HideBottomPanel()
		{
			IAOFDBFPKPJ();
			CurrentBoosterManager.EBMPIHFCAMC(false);
		}

		public void DisableBottomPanel()
		{
			IAOFDBFPKPJ();
			CurrentBoosterManager.EBMPIHFCAMC(false);
		}

		public void EnableBottomPanel()
		{
			DLBLNHBHKHN();
			CurrentBoosterManager.OINIFNCLAGA();
		}

		public static void ResetSelf()
		{
			Instance = null;
		}

		internal void IAOFDBFPKPJ()
		{
			if (BLBFOGEDAPH)
			{
				SettingsClicked();
			}
			SettingButton.DisableButton(false);
			LBKPPKEADMM = true;
		}

		internal void DLBLNHBHKHN()
		{
			SettingButton.EnableButton();
			LBKPPKEADMM = false;
		}

		public void SettingsClicked()
		{
			if ((CurrentLevelBuilder != null && CurrentLevelBuilder.CurrentLevel != null && CurrentLevelBuilder.CurrentLevel.CELPAPAMMFK()) || (!BLBFOGEDAPH && LBKPPKEADMM))
			{
				return;
			}
			if (EMHBCIHHILK != null)
			{
				EMHBCIHHILK.Kill(true);
			}
			if (BLBFOGEDAPH)
			{
				BLBFOGEDAPH = false;
				if (OPIPILEFLEP)
				{
					BlackPanel.Instance.HidePanelFast();
				}
				else
				{
					BlackPanel.Instance.HidePanel();
				}
				OPIPILEFLEP = false;
				CIFBHPDFLEN();
				HintManager.Instance.EnableHints();
			}
			else
			{
				HintManager.Instance.DisableHints();
				DisabledImageSound.SetActive(!AudioManager.NAEBPOAPIFP);
				DisabledImageMusic.SetActive(!AudioManager.MMJKLIMKEHG);
				BLBFOGEDAPH = true;
				BlackPanel.Instance.ShowPanel();
				BoosterTapListener.Instance.IncreaseBlockRequests();
				CurrentBoosterManager.EBMPIHFCAMC(false);
				JEAIHKPCLEO();
			}
		}

		public void Hide()
		{
			BLBFOGEDAPH = false;
			BlackPanel.Instance.HidePanelFast();
			CIFBHPDFLEN();
		}

		private void JEAIHKPCLEO()
		{
			LLDHHJNHCEN = AudioManager.MMJKLIMKEHG;
			GPCDKLIBIOI = AudioManager.NAEBPOAPIFP;
			EMHBCIHHILK = DOTween.Sequence();
			SettingsButtonsHolder.SetActive(true);
			Vector3 jDBOMLADPFF = ONCMBJKLKIL.JDBOMLADPFF;
			jDBOMLADPFF.x -= 1.7f;
			Vector3 position = SettingsButtonsHolder.transform.position;
			position.x = jDBOMLADPFF.x;
			SettingsButtonsHolder.transform.position = position;
			SettingsButtonsHolder.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 60f));
			EMHBCIHHILK.Append(SettingsButtonsHolder.transform.DOLocalMoveX(0f, 0.3f));
			EMHBCIHHILK.Join(SettingsButtonsHolder.transform.DORotateQuaternion(Quaternion.identity, 0.3f));
			HLFBCPMMIKF(EMHBCIHHILK, SettingsButton1, 1.5f);
			HLFBCPMMIKF(EMHBCIHHILK, SettingsButton2, 1f);
			HLFBCPMMIKF(EMHBCIHHILK, SettingsButton3, 0f);
			EMHBCIHHILK.OnComplete(delegate
			{
				EMHBCIHHILK = null;
			});
		}

		private void HLFBCPMMIKF(Sequence HFIBKKLENJH, GameObject AACCPLMFDIE, float ELNCCDELMMH)
		{
			Vector3 localPosition = AACCPLMFDIE.transform.localPosition;
			localPosition.x -= ELNCCDELMMH;
			AACCPLMFDIE.transform.localPosition = localPosition;
			HFIBKKLENJH.Join(AACCPLMFDIE.transform.DOLocalMoveX(0f, 0.3f + 0.15f * ELNCCDELMMH));
		}

		private void CIFBHPDFLEN()
		{
			EMHBCIHHILK = DOTween.Sequence();
			Vector3 jDBOMLADPFF = ONCMBJKLKIL.JDBOMLADPFF;
			jDBOMLADPFF.x -= 1.9f;
			EMHBCIHHILK.Append(SettingsButtonsHolder.transform.DOMoveX(jDBOMLADPFF.x, 0.5f));
			EMHBCIHHILK.Join(SettingsButtonsHolder.transform.DORotateQuaternion(Quaternion.Euler(new Vector3(0f, 0f, 60f)), 0.4f));
			EMHBCIHHILK.InsertCallback(0.3f, delegate
			{
				SettingsButtonsHolder.SetActive(false);
			});
			EMHBCIHHILK.OnComplete(delegate
			{
				EMHBCIHHILK = null;
			});
			CurrentBoosterManager.OINIFNCLAGA();
			LAIEILHELFH();
			if (LLDHHJNHCEN != AudioManager.MMJKLIMKEHG)
			{
				BFGODHFHMBD(AudioManager.MMJKLIMKEHG ? 1 : 0);
			}
			if (GPCDKLIBIOI != AudioManager.NAEBPOAPIFP)
			{
				BLEHAPDPEDH(AudioManager.NAEBPOAPIFP ? 1 : 0);
				AudioManager.ExecuteFXChange();
			}
		}

		private void BLEHAPDPEDH(int ODCADGABBHJ)
		{
			AFJPGLHKOID.CPIGOAGGLBM("SoundStatusChanged", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), ODCADGABBHJ.ToString());
		}

		private void BFGODHFHMBD(int ODCADGABBHJ)
		{
			AFJPGLHKOID.CPIGOAGGLBM("MusicStatusChanged", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), ODCADGABBHJ.ToString());
		}

		private void LAIEILHELFH()
		{
			BoosterTapListener.Instance.DecreaseBlockRequests();
			TapListener.Instance.WaitFirstUntap = true;
			BoosterTapListener.Instance.WaitFirstUntap = true;
		}

		public void SoundButtonClicked()
		{
			bool flag = !AudioManager.NAEBPOAPIFP;
			MDGKDGMGGCL.GABGKBAKHDP.JFEDLJOAJEM(flag);
			DisabledImageSound.SetActive(!flag);
		}

		public void MusicButtonClicked()
		{
			bool flag = !AudioManager.MMJKLIMKEHG;
			MDGKDGMGGCL.GABGKBAKHDP.OJKFPLOOKLA(flag);
			DisabledImageMusic.SetActive(!flag);
		}

		public void QuitButtonClicked()
		{
			OPIPILEFLEP = true;
			SettingsClicked();
			DialogLibrary.GABGKBAKHDP.ShowDialogBackgroundFast();
			FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.QuitDialog, false, false, false, null, false);
		}

		[CompilerGenerated]
		private void DDOCCHLMDMP()
		{
			EMHBCIHHILK = null;
		}

		[CompilerGenerated]
		private void CCHODEKECIJ()
		{
			SettingsButtonsHolder.SetActive(false);
		}

		[CompilerGenerated]
		private void IJJGPOMJIFI()
		{
			EMHBCIHHILK = null;
		}
	}
}
