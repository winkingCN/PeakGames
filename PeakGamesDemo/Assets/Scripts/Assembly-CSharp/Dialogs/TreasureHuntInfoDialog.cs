using System;
using System.Collections;
using System.Text;
using Assets.Scripts.Dialogs;
using DG.Tweening;
using DataHelpers;
using TMPro;
using UnityEngine;
using Utils;

namespace Dialogs
{
	public class TreasureHuntInfoDialog : OnCloseCallbackDialog, CCGJIPEFOEL
	{
		public TextMeshPro TimeLeft;

		public TextMeshPro KeyBarCount;

		public TextMeshPro FailedKeyBarCount;

		public TextMeshPro InfoText;

		public Transform ClockHand;

		public GameObject CollectContainer;

		public GameObject UnlockedContainer;

		public SpriteRenderer TreasureKeyBar;

		public SpriteRenderer TreasureKeyBarShadow;

		public SpriteRenderer BackgroundLeft;

		public SpriteRenderer BackgroundRight;

		public SpriteRenderer DialogArtwork;

		public SpriteRenderer TreasureHuntKey;

		public Sprite TreasureKeyCont;

		public Sprite TreasureKeyContGrayScale;

		private static Sprite ELFAAELLNJN;

		private static bool NLIPJBBHBHC;

		private long MNGFOOGIKKO;

		private bool PFINMHBBIHG;

		private bool EKCINKDJPDI;

		private const float BDGGMIBGONL = -1.317f;

		private const float FFFHOJKAFBK = 0.803f;

		private const float CDBFEHCIAFD = 0.335f;

		private const float ENINHIFKEFN = 2.454f;

		private const float KHLLMHFEOMA = -0.267f;

		private const float PICIFFKDDGM = -0.011f;

		private const float MEBBAMOBCOG = 14.67f;

		private const float JPBAPCLEJKB = 14.156f;

		public override void DialogCreated()
		{
			base.DialogCreated();
			CFNKECEHDIC cFNKECEHDIC = DGOMNDMPMBG.GABGKBAKHDP.OEPCIADENMH;
			if (cFNKECEHDIC == null)
			{
				GMOMEPNHJGA();
			}
			else
			{
				GGKGNPEHDFK(cFNKECEHDIC);
			}
		}

		public override void PlayDialogInAnimation()
		{
			base.transform.position = Vector3.up * (ONCMBJKLKIL.ECLBGPBLGMD.y + ReferenceHeight * base.transform.localScale.x * 0.5f + 3f);
			if (ShouldLoadDialogArtwork())
			{
				StartCoroutine(LoadDialogArtwork(LKLJICDGMLH));
			}
			else if (ELFAAELLNJN == null)
			{
				StartCoroutine(HAKGHFEFFHM());
			}
			else
			{
				LKLJICDGMLH();
			}
		}

		private IEnumerator HAKGHFEFFHM()
		{
			while (ELFAAELLNJN == null)
			{
				yield return null;
			}
			LKLJICDGMLH();
		}

		private void LKLJICDGMLH()
		{
			DialogArtwork.sprite = ELFAAELLNJN;
			base.PlayDialogInAnimation();
			SetDialogBounds();
		}

		public void OnOpenClicked()
		{
			PFINMHBBIHG = true;
			Close();
		}

		public void PrepareDialog(bool OKAGICINMBN)
		{
			EKCINKDJPDI = OKAGICINMBN;
		}

		private void GGKGNPEHDFK(CFNKECEHDIC MNPBOAKDKDI)
		{
			switch (MNPBOAKDKDI.AEPLIGFCGIF)
			{
			case 1:
				MNGFOOGIKKO = MNPBOAKDKDI.AEBACBBGHKI;
				if (MNGFOOGIKKO <= 0)
				{
					GMOMEPNHJGA();
					MOGHDBCJHIC(false);
					DLLEGIHMJHH(MNPBOAKDKDI.HPHEOJFHKBG(), MNPBOAKDKDI.HMHBNDGADKG, false);
					InfoText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("TreasureHuntInfoFailed");
				}
				else
				{
					IOPCENJILNF();
					MOGHDBCJHIC(false);
					DLLEGIHMJHH(MNPBOAKDKDI.GFKLBMGGJMK, MNPBOAKDKDI.HMHBNDGADKG, true);
					InfoText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("TreasureHuntInfoCollect");
				}
				break;
			case 2:
				GMOMEPNHJGA();
				MOGHDBCJHIC(true);
				break;
			default:
				GMOMEPNHJGA();
				MOGHDBCJHIC(false);
				break;
			}
		}

		public static bool ShouldLoadDialogArtwork()
		{
			return !NLIPJBBHBHC && ELFAAELLNJN == null;
		}

		public static IEnumerator LoadDialogArtwork(Action IMHLFAHONPP = null)
		{
			NLIPJBBHBHC = true;
			ResourceRequest resourceRequest = Resources.LoadAsync<TextAsset>("EventAssets/TreasureHunt_Artwork");
			while (!resourceRequest.isDone)
			{
				yield return MCJHHDACJBG.CNDGGNLKOOC;
			}
			ELFAAELLNJN = LJDGBAMMEAM.FPAMEPBLDPL(resourceRequest.asset as TextAsset, 918, 1130);
			ELFAAELLNJN.name = "TreasureHuntArtwork";
			NLIPJBBHBHC = false;
			if (IMHLFAHONPP != null)
			{
				IMHLFAHONPP();
			}
		}

		public static void UnloadDialogArtwork()
		{
			ELFAAELLNJN = null;
			NLIPJBBHBHC = false;
		}

		private void MOGHDBCJHIC(bool DOKMPEOLBGO)
		{
			UnlockedContainer.SetActive(DOKMPEOLBGO);
			CollectContainer.SetActive(!DOKMPEOLBGO);
			float y = ((!DOKMPEOLBGO) ? (-0.011f) : (-0.267f));
			Vector3 position = BackgroundLeft.transform.position;
			position.y = y;
			BackgroundLeft.transform.position = position;
			position = BackgroundRight.transform.position;
			position.y = y;
			BackgroundRight.transform.position = position;
			float y2 = ((!DOKMPEOLBGO) ? 14.156f : 14.67f);
			Vector2 size = BackgroundLeft.size;
			size.y = y2;
			BackgroundLeft.size = size;
			size = BackgroundRight.size;
			size.y = y2;
			BackgroundRight.size = size;
			TouchBounds.Offset.y = ((!DOKMPEOLBGO) ? 0f : (-0.28f));
			TouchBounds.Size.y = ((!DOKMPEOLBGO) ? 16.25f : 16.8f);
			SetDialogBounds();
		}

		private void DLLEGIHMJHH(int AEOLICFHBFL, int LACMJAAJGND, bool DOKMPEOLBGO)
		{
			AEOLICFHBFL = Mathf.Clamp(AEOLICFHBFL, 0, LACMJAAJGND);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(AEOLICFHBFL);
			stringBuilder.Append("/ ");
			stringBuilder.Append(LACMJAAJGND);
			KeyBarCount.enabled = DOKMPEOLBGO;
			FailedKeyBarCount.enabled = !DOKMPEOLBGO;
			TreasureHuntKey.sprite = ((!DOKMPEOLBGO) ? TreasureKeyContGrayScale : TreasureKeyCont);
			if (DOKMPEOLBGO)
			{
				if (AEOLICFHBFL > 0)
				{
					TreasureKeyBar.enabled = true;
					TreasureKeyBarShadow.enabled = true;
					EACFLEGEFLE(DBNJFOIAABC(AEOLICFHBFL, LACMJAAJGND), AKGHNJMJDON(AEOLICFHBFL, LACMJAAJGND));
				}
				else
				{
					TreasureKeyBar.enabled = false;
					TreasureKeyBarShadow.enabled = false;
				}
				KeyBarCount.FCJBBPHFNPJ = stringBuilder.ToString();
			}
			else
			{
				TreasureKeyBar.enabled = false;
				TreasureKeyBarShadow.enabled = false;
				FailedKeyBarCount.FCJBBPHFNPJ = stringBuilder.ToString();
			}
		}

		private void EACFLEGEFLE(float JIANJOALKIM, float MNOOIBAFFIN)
		{
			Vector3 localPosition = TreasureKeyBar.transform.localPosition;
			localPosition.x = JIANJOALKIM;
			TreasureKeyBar.transform.localPosition = localPosition;
			Vector2 size = TreasureKeyBar.size;
			size.x = MNOOIBAFFIN;
			TreasureKeyBar.size = size;
			Vector3 localPosition2 = TreasureKeyBarShadow.transform.localPosition;
			localPosition2.x = JIANJOALKIM + MNOOIBAFFIN;
			TreasureKeyBarShadow.transform.localPosition = localPosition2;
		}

		private float DBNJFOIAABC(int ENMLICFLHAO, int CAEMELGEOAE)
		{
			return -1.317f - -2.12f / (float)CAEMELGEOAE * (float)ENMLICFLHAO;
		}

		private float AKGHNJMJDON(int ENMLICFLHAO, int CAEMELGEOAE)
		{
			return 0.335f - -2.119f / (float)CAEMELGEOAE * (float)ENMLICFLHAO;
		}

		public override void OnDialogClosed()
		{
			TimerHelper.GABGKBAKHDP.DeregisterTimer(this);
			if (PFINMHBBIHG)
			{
				GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.TreasureHuntDialog, false);
				TreasureHuntDialog component = gameObject.GetComponent<TreasureHuntDialog>();
				component.PrepareDialog(AMFCLGFBDJI, EKCINKDJPDI);
				AMFCLGFBDJI = null;
			}
			else
			{
				base.OnDialogClosed();
			}
		}

		private void IOPCENJILNF()
		{
			if (MNGFOOGIKKO > 0)
			{
				TimerHelper.GABGKBAKHDP.RegisterTimer(this);
			}
			DPOOABPAMFO();
		}

		public void UpdateTimeLeft()
		{
			CFNKECEHDIC cFNKECEHDIC = DGOMNDMPMBG.GABGKBAKHDP.OEPCIADENMH;
			MNGFOOGIKKO = ((cFNKECEHDIC != null) ? cFNKECEHDIC.AEBACBBGHKI : 0);
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
				TimerHelper.GABGKBAKHDP.DeregisterTimer(this);
				GMOMEPNHJGA();
			}
			else
			{
				TimeLeft.FCJBBPHFNPJ = GJEIMLMEHIN.FLANACEGNEO((int)MNGFOOGIKKO, true);
				ClockHand.DORotate(new Vector3(0f, 0f, (float)(MNGFOOGIKKO % 4) * 90f), 0.2f).SetEase(Ease.OutBack);
			}
		}

		private void GMOMEPNHJGA()
		{
			TimeLeft.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("CL_Finished");
		}
	}
}
