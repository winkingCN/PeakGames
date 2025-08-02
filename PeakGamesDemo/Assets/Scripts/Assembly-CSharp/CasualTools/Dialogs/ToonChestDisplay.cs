using Assets.Scripts.Dialogs;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.Utils;
using Dialogs;
using MapScene;
using TMPro;
using UnityEngine;
using Utils;

namespace CasualTools.Dialogs
{
	public class ToonChestDisplay : MapChestDisplay
	{
		private int HMIHKJBCNAF;

		[SerializeField]
		private TextMeshPro _level;

		public void Start()
		{
			UpdateDisplay();
		}

		public override void UpdateDisplay()
		{
			UpdateDisplayWithGlowAnimation(false);
		}

		public void UpdateDisplayWithGlowAnimation(bool MDIKOCLCJKL)
		{
			HMIHKJBCNAF = NDGOJGLPIJF.GABGKBAKHDP.DLDNDGEEIAB();
			_level.FCJBBPHFNPJ = string.Format(NKILHODNBDE.GHBGCADFLFB("ToonChestLevel"), HMIHKJBCNAF);
			if (NDGOJGLPIJF.GABGKBAKHDP.BMKIICIJGEK())
			{
				bool flag = DLNJHGOJKPN();
				if (!MDIKOCLCJKL && !flag)
				{
					ChangeState(KMEIGFENLNO.Open);
				}
				else if (MDIKOCLCJKL && flag)
				{
					ChangeState(KMEIGFENLNO.Open);
					OpenParticle.Play();
					AudioManager.Play(KOOGPFAPGGD.UiEpisodeUnlockLand);
				}
			}
			else
			{
				ChangeState(KMEIGFENLNO.Collect);
			}
		}

		private bool DLNJHGOJKPN()
		{
			return LevelBuilder.LastLevel.HLFNDDEDJOI && MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1 == NDGOJGLPIJF.GABGKBAKHDP.DLDNDGEEIAB();
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
					OpenContent.SetActive(false);
					CollectContainer.SetActive(true);
					base.gameObject.transform.localScale = Vector3.one;
					break;
				case KMEIGFENLNO.Open:
					OpenButton.CanBeAnimated = false;
					OpenContent.SetActive(true);
					CollectContainer.SetActive(false);
					LDOFPOJOALI(true);
					break;
				}
			}
		}

		public void OnClick()
		{
			CFPKNHKNFOH();
			if (OpenContent.activeSelf)
			{
				GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.ToonChestDialog, false);
				ToonChestDialog component = gameObject.GetComponent<ToonChestDialog>();
				component.SetContent(UpdateDisplay);
			}
			else
			{
				GameObject gameObject2 = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.ChestInfoDialog, false);
				ChestInfoDialog component2 = gameObject2.GetComponent<ChestInfoDialog>();
				component2.SetToonChestLevel(HMIHKJBCNAF);
			}
		}
	}
}
