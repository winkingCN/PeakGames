using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Assets.Scripts.Dialogs;
using DG.Tweening;
using MapScene;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.MapScene
{
	public class MapLivesDisplay : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class PCFOPCDJMHP
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

		public SpriteRenderer Glow;

		public TextMeshPro LivesTimer;

		public TextMeshPro LivesCount;

		private int HJJGOHBNJBB;

		public GameObject UnlimitedLifeImage;

		public GameObject NoButtonDisplay;

		public GameObject AddLivesButton;

		public GameObject LifeCollectParticle;

		public MapCoinsDisplay CurrentMapCoinsDisplay;

		private bool BPNLKIIOIJD;

		private byte NIPLOEEHIPL;

		private Sequence KKMDOBOKABL;

		public void Start()
		{
			StartCoroutine(OGBIMOCGFEG());
		}

		public void OnApplicationPause(bool APMMLLCMAKI)
		{
			if (!APMMLLCMAKI)
			{
				UpdateLives();
			}
		}

		private IEnumerator OGBIMOCGFEG()
		{
			UpdateLives();
			yield return MCJHHDACJBG.KNLADMIBAAD;
			StartCoroutine(OGBIMOCGFEG());
		}

		public void AddLifes()
		{
			if (!BPNLKIIOIJD)
			{
				BPNLKIIOIJD = true;
				int dLDHNNCGIPI = PJPPADHKGHN.GABGKBAKHDP.PMBGCACJIHD().DLDHNNCGIPI;
				if (dLDHNNCGIPI >= 5)
				{
					Vector3 zero = Vector3.zero;
					zero.y = AddLivesButton.transform.position.y - 2f;
					MapManager.Instance.ShowErrorMessageAtPosition(NKILHODNBDE.GHBGCADFLFB("LifesFull"), zero);
					BPNLKIIOIJD = false;
				}
				else
				{
					OutOfLivesDialog.RefillStatus = "map";
					OutOfLivesDialog.CreateAndShowOutOfLivesDialog(KPDJHLMMHNI);
				}
			}
		}

		private void KPDJHLMMHNI()
		{
			OutOfLivesDialog.RefillStatus = null;
			CurrentMapCoinsDisplay.Refresh();
			BPNLKIIOIJD = false;
		}

		public void UpdateLives()
		{
			int num = PJPPADHKGHN.GABGKBAKHDP.HNBIMJHPIPE();
			if (num > 0)
			{
				NNLPOFBCEKM();
				LivesTimer.FCJBBPHFNPJ = GJEIMLMEHIN.FLANACEGNEO(num, true);
				return;
			}
			MOLCIIAPCMN mOLCIIAPCMN = PJPPADHKGHN.GABGKBAKHDP.PMBGCACJIHD();
			HJJGOHBNJBB = mOLCIIAPCMN.APLNHKHHMEL;
			int val = mOLCIIAPCMN.DLDHNNCGIPI - PJPPADHKGHN.GABGKBAKHDP.EFFMBBAJLCF;
			int num2 = Math.Min(5, Math.Max(0, val));
			if (num2 == 5)
			{
				FAMGAMMLPNO();
				return;
			}
			HGMHJLDEEML();
			LivesTimer.FCJBBPHFNPJ = GJEIMLMEHIN.FLANACEGNEO(HJJGOHBNJBB);
			LivesCount.FCJBBPHFNPJ = num2.ToString();
		}

		private void NNLPOFBCEKM()
		{
			if (NIPLOEEHIPL != 3)
			{
				NIPLOEEHIPL = 3;
				if (AddLivesButton.activeSelf)
				{
					AddLivesButton.SetActive(false);
				}
				if (!NoButtonDisplay.activeSelf)
				{
					NoButtonDisplay.SetActive(true);
				}
				LivesTimer.JOPPDFNGJBM = KNOECCJHIDP.Left;
				LivesTimer.GPPKOGCLKPL.sizeDelta = new Vector2(1.896f, 0.615f);
				LivesTimer.LPMDHKHNOGE = false;
				LivesTimer.DGLOHLPKABM = 5f;
				Vector3 localPosition = LivesTimer.ANLKLKAINEO.localPosition;
				localPosition.x = 0.4f;
				localPosition.y = -0.049f;
				LivesTimer.ANLKLKAINEO.localPosition = localPosition;
				UnlimitedLifeImage.SetActive(true);
				LivesCount.gameObject.SetActive(false);
			}
		}

		private void HGMHJLDEEML()
		{
			if (NIPLOEEHIPL != 2)
			{
				NIPLOEEHIPL = 2;
				if (!AddLivesButton.activeSelf)
				{
					AddLivesButton.SetActive(true);
				}
				if (NoButtonDisplay.activeSelf)
				{
					NoButtonDisplay.SetActive(false);
				}
				LivesTimer.LPMDHKHNOGE = false;
				LivesTimer.DGLOHLPKABM = 6f;
				LivesTimer.JOPPDFNGJBM = KNOECCJHIDP.Left;
				Vector3 localPosition = LivesTimer.ANLKLKAINEO.localPosition;
				localPosition.x = -0.104f;
				localPosition.y = -0.034f;
				LivesTimer.GPPKOGCLKPL.sizeDelta = new Vector2(1.143f, 0.615f);
				LivesTimer.ANLKLKAINEO.localPosition = localPosition;
				UnlimitedLifeImage.SetActive(false);
				LivesCount.gameObject.SetActive(true);
			}
		}

		private void FAMGAMMLPNO()
		{
			if (NIPLOEEHIPL != 1)
			{
				NIPLOEEHIPL = 1;
				if (!AddLivesButton.activeSelf)
				{
					AddLivesButton.SetActive(true);
				}
				if (NoButtonDisplay.activeSelf)
				{
					NoButtonDisplay.SetActive(false);
				}
				LivesTimer.LPMDHKHNOGE = true;
				LivesTimer.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Full");
				LivesTimer.JOPPDFNGJBM = KNOECCJHIDP.Center;
				Vector3 localPosition = LivesTimer.ANLKLKAINEO.localPosition;
				localPosition.x = 0.03f;
				localPosition.y = -0.034f;
				LivesTimer.GPPKOGCLKPL.sizeDelta = new Vector2(1.64f, 0.615f);
				LivesTimer.ANLKLKAINEO.localPosition = localPosition;
				UnlimitedLifeImage.SetActive(false);
				LivesCount.gameObject.SetActive(true);
				LivesCount.FCJBBPHFNPJ = "5";
			}
		}

		public void PlayHitAnimation()
		{
			Glow.enabled = true;
			Glow.color = new Color(1f, 1f, 1f, 0f);
			base.gameObject.transform.localScale = Vector3.one;
			KKMDOBOKABL.Kill();
			KKMDOBOKABL = DOTween.Sequence();
			KKMDOBOKABL.SetRecyclable(false);
			KKMDOBOKABL.Insert(0f, base.gameObject.transform.DOScale(Vector3.one * 0.9f, 0.1f));
			KKMDOBOKABL.Insert(0.1f, base.gameObject.transform.DOScale(Vector3.one, 0.1f));
			KKMDOBOKABL.Insert(0f, Glow.DOColor(new Color(1f, 1f, 1f, 0.3f), 0.1f));
			KKMDOBOKABL.Insert(0.1f, Glow.DOColor(new Color(1f, 1f, 1f, 0f), 0.2f));
			ParticleSystem FLLHHHDFCKA = LifeCollectParticle.JOBDHIPIMAG().GetComponent<ParticleSystem>();
			if (FLLHHHDFCKA == null)
			{
				return;
			}
			FLLHHHDFCKA.transform.position = LivesCount.ANLKLKAINEO.position;
			FLLHHHDFCKA.Play();
			Sequence sequence = DOTween.Sequence();
			sequence.SetRecyclable(false);
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
	}
}
