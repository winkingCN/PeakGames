using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Dialogs;
using Assets.Scripts.MapScene;
using DG.Tweening;
using DataHelpers;
using TMPro;
using ToonSocial;
using ToonSocial.ui.joined;
using Ui.VerticalScroll;
using UnityEngine;
using Utils;

namespace Dialogs
{
	public class TeamChestInfoDialog : OnCloseCallbackDialog, CCGJIPEFOEL
	{
		[CompilerGenerated]
		private sealed class FFKFFKEPGKJ
		{
			internal int MFFLPDALICD;

			internal int LBIODAFMFAM;

			internal TeamChestInfoDialog PDAPIGLEPGC;

			internal int AGFNGEFDHLA()
			{
				return MFFLPDALICD;
			}

			internal void KDACLOKGNAM(int AMFCENFNAJJ)
			{
				MFFLPDALICD = AMFCENFNAJJ;
			}

			internal void DBLIJBPNCAN()
			{
				PDAPIGLEPGC.DLLEGIHMJHH(MFFLPDALICD, LBIODAFMFAM);
			}
		}

		public TextMeshPro StateInfo;

		public TextMeshPro StarBarCount;

		public TextMeshPro TeamName;

		public TextMeshPro TimeLeft;

		public Transform ClockHand;

		public SpriteRenderer StarBar;

		public SpriteRenderer BadgeIcon;

		public GameObject TeamInfoContainer;

		public GameObject UnlockedContainer;

		public PeakGrayScale[] GrayScaleSprites;

		public GameObject TeamChestEntryPrefab;

		public VerticalScrollController TeamChestScrollController;

		public SpriteRenderer BackgroundLeft;

		public SpriteRenderer BackgroundRight;

		public Transform MaskBottom;

		private bool NFIGBNGALAA;

		private bool CNICJCOANPI;

		private bool PFINMHBBIHG;

		private bool EKCINKDJPDI;

		private long MNGFOOGIKKO;

		private string PENHJPBKABF;

		private AAPMDEEMEMM CLKKEINMEOK;

		private JJHJHJFNCGC IOJBDDLIAOB;

		private Tweener BOJDNHEGPEC;

		private const float OGNHCIDPBII = -1.554f;

		private const float CBBNALBKMFD = 0.777f;

		private const float CDBFEHCIAFD = 0.411f;

		private const float ENINHIFKEFN = 5.087f;

		private static readonly Color KMHIKPJMAIO = new Color(25f / 51f, 19f / 51f, 4f / 15f, 1f);

		private global::FHOJBJMMNOD<MOGIFCAGGKE, TeamChestEntry> JKANNLPGLPJ;

		private float ANJBHOECJME;

		private float JNFMOMPFIGG;

		public void Start()
		{
			if (ONCMBJKLKIL.KLEKJMEOPEH)
			{
				float num = 1.7787265f * ONCMBJKLKIL.EMFKAPJMDCC;
				float num2 = (ONCMBJKLKIL.FHAMOHDEGMK - num) * 0.3f;
				Vector2 size = new Vector2(BackgroundLeft.size.x, 14.92428f + num2);
				Vector2 size2 = new Vector2(BackgroundLeft.size.x, 14.92428f + num2);
				MaskBottom.localPosition = new Vector3(0f, -7.92f - num2, 0f);
				BackgroundLeft.size = size;
				BackgroundRight.size = size2;
				BackgroundLeft.transform.localPosition = new Vector3(BackgroundLeft.transform.localPosition.x, 0.5178f - num2 * 0.5f, 0f);
				BackgroundRight.transform.localPosition = new Vector3(BackgroundRight.transform.localPosition.x, 0.5178f - num2 * 0.5f, 0f);
				Vector2 size3 = TeamChestScrollController.ScrollArea.size;
				size3.y = 9f + num2;
				TeamChestScrollController.ScrollArea.size = size3;
				Vector2 offset = TeamChestScrollController.ScrollArea.offset;
				offset.y -= num2 * 0.5f;
				TeamChestScrollController.ScrollArea.offset = offset;
				JNFMOMPFIGG = num2 * 0.5f;
				if (JKANNLPGLPJ != null)
				{
					TeamChestScrollController.SetOffsets(0f - JNFMOMPFIGG, 0f - JNFMOMPFIGG);
					TeamChestScrollController.SetContentSize(ANJBHOECJME);
					TeamChestScrollController.ScrollToTop();
				}
			}
		}

		public void Prepare(AAPMDEEMEMM HMOBAHHJOJE, bool OKAGICINMBN)
		{
			CLKKEINMEOK = HMOBAHHJOJE;
			MNGFOOGIKKO = CLKKEINMEOK.AEBACBBGHKI;
			IOJBDDLIAOB = CLKKEINMEOK.OPBAEEEGPDE;
			EKCINKDJPDI = OKAGICINMBN;
			int oPEOKMOANBM = OGLIBCLBEDG();
			GGKGNPEHDFK(IOJBDDLIAOB.AEPLIGFCGIF, oPEOKMOANBM);
		}

		protected override void BLELAMHLLNN()
		{
			if (IOJBDDLIAOB.INOKNDGFNLK > IOJBDDLIAOB.LMJPNCDFAPH)
			{
				GBKBGJGBDJO(IOJBDDLIAOB.LMJPNCDFAPH, IOJBDDLIAOB.INOKNDGFNLK, CLKKEINMEOK.FLFDJCHPGAJ);
			}
			base.BLELAMHLLNN();
		}

		public void ClaimTeamChest()
		{
			PFINMHBBIHG = true;
			Close();
		}

		public void OnTeamChestProgress()
		{
			if (!string.IsNullOrEmpty(PENHJPBKABF))
			{
				MapManager.Instance.ShowErrorMessageAtPosition(PENHJPBKABF, Vector3.up * 5.65f);
			}
		}

		public override void OnDialogClosed()
		{
			TimerHelper.GABGKBAKHDP.DeregisterTimer(this);
			if (PFINMHBBIHG)
			{
				GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.TeamChestDialog, false);
				TeamChestDialog component = gameObject.GetComponent<TeamChestDialog>();
				component.PrepareDialog(AMFCLGFBDJI, EKCINKDJPDI);
				AMFCLGFBDJI = null;
			}
			else if (AMFCLGFBDJI != null)
			{
				AMFCLGFBDJI();
			}
		}

		public override Sequence PlayDialogOutAnimation()
		{
			if (BOJDNHEGPEC != null)
			{
				BOJDNHEGPEC.Complete();
			}
			if (PFINMHBBIHG)
			{
				return DOTween.Sequence();
			}
			return base.PlayDialogOutAnimation();
		}

		private void GBKBGJGBDJO(int HCGGHECHHBO, int KHJENCJIGBI, int LBIODAFMFAM)
		{
			HCGGHECHHBO = ((HCGGHECHHBO >= 0) ? HCGGHECHHBO : 0);
			KHJENCJIGBI = ((KHJENCJIGBI <= LBIODAFMFAM) ? KHJENCJIGBI : LBIODAFMFAM);
			int MFFLPDALICD = HCGGHECHHBO;
			BOJDNHEGPEC = DOTween.To(() => MFFLPDALICD, delegate(int AMFCENFNAJJ)
			{
				MFFLPDALICD = AMFCENFNAJJ;
			}, KHJENCJIGBI, 2f).SetEase(Ease.OutQuart).OnUpdate(delegate
			{
				DLLEGIHMJHH(MFFLPDALICD, LBIODAFMFAM);
			})
				.OnComplete(CLKKEINMEOK.MMHLOMIACEK);
		}

		private void GGKGNPEHDFK(int DMDECCKGBKD, int OPEOKMOANBM)
		{
			OIKEPIIPBKG(false);
			IOPCENJILNF();
			int iNOKNDGFNLK = IOJBDDLIAOB.INOKNDGFNLK;
			int num = CLKKEINMEOK.FLFDJCHPGAJ;
			long num2 = CLKKEINMEOK.AEBACBBGHKI;
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TeamChestInfoDialog chest:{0} user:{1} progress:{2}/{3} duration:{4}", DMDECCKGBKD, OPEOKMOANBM, iNOKNDGFNLK, num, num2);
			if (DMDECCKGBKD == 4)
			{
				DMDECCKGBKD = ((iNOKNDGFNLK >= num) ? 2 : ((num2 > 0) ? 1 : 3));
			}
			switch (DMDECCKGBKD)
			{
			case 1:
				if (OPEOKMOANBM == 1)
				{
					DPFNJKGAGMP();
					StateInfo.SetText(NKILHODNBDE.GHBGCADFLFB("TeamChestInfoClaimed2"));
					PENHJPBKABF = NKILHODNBDE.GHBGCADFLFB("TeamChestInfoClaimed2");
				}
				else
				{
					StateInfo.SetText(NKILHODNBDE.GHBGCADFLFB("TeamChestInfoCollect"), CLKKEINMEOK.FLFDJCHPGAJ);
					PENHJPBKABF = NKILHODNBDE.GHBGCADFLFB("TeamChestButtonCollect");
				}
				break;
			case 2:
				switch (OPEOKMOANBM)
				{
				case 0:
					OIKEPIIPBKG(true);
					StateInfo.SetText(NKILHODNBDE.GHBGCADFLFB("TeamChestInfoSucceed"));
					break;
				case 1:
					StateInfo.SetText(NKILHODNBDE.GHBGCADFLFB("TeamChestInfoSucceed"));
					PENHJPBKABF = NKILHODNBDE.GHBGCADFLFB("TeamChestInfoClaimed1");
					break;
				default:
					StateInfo.SetText(NKILHODNBDE.GHBGCADFLFB("TeamChestInfoCompleted"));
					PENHJPBKABF = NKILHODNBDE.GHBGCADFLFB("TeamChestInfoCompleted");
					break;
				}
				GMOMEPNHJGA();
				break;
			case 3:
				StateInfo.SetText(NKILHODNBDE.GHBGCADFLFB("TeamChestInfoFailed"));
				if (OPEOKMOANBM == 1)
				{
					PENHJPBKABF = NKILHODNBDE.GHBGCADFLFB("TeamChestInfoClaimed2");
				}
				else
				{
					PENHJPBKABF = NKILHODNBDE.GHBGCADFLFB("TeamChestInfoFailed");
				}
				CLKKEINMEOK.HPHEOJFHKBG();
				GMOMEPNHJGA();
				break;
			default:
				StateInfo.SetText(NKILHODNBDE.GHBGCADFLFB("TeamChestInfoCollect"), CLKKEINMEOK.FLFDJCHPGAJ);
				break;
			}
		}

		private void OIKEPIIPBKG(bool EDDNOJDPMCF)
		{
			TeamInfoContainer.SetActive(!EDDNOJDPMCF);
			UnlockedContainer.SetActive(EDDNOJDPMCF);
			if (EDDNOJDPMCF)
			{
				StateInfo.ANLKLKAINEO.localPosition = StateInfo.ANLKLKAINEO.localPosition + Vector3.up * 0.15f;
				StateInfo.KMADLHHGAIH = 5.3f;
			}
		}

		private void DPFNJKGAGMP()
		{
			PeakGrayScale[] grayScaleSprites = GrayScaleSprites;
			foreach (PeakGrayScale peakGrayScale in grayScaleSprites)
			{
				peakGrayScale.UpdateGrayScale(0.19f, 0.09f, 0f);
			}
			TeamName.color = KMHIKPJMAIO;
		}

		private int OGLIBCLBEDG()
		{
			int result = 2;
			Badges badgesDictionary = MapManager.Instance.CurrentSocialHelper.BadgesDictionary;
			BadgeIcon.sprite = badgesDictionary.GetBadge(CLKKEINMEOK.GCELBDIDEAI);
			TeamName.SetText(IOJBDDLIAOB.KJACEODCOHN);
			if (IOJBDDLIAOB.INOKNDGFNLK < IOJBDDLIAOB.LMJPNCDFAPH)
			{
				DLLEGIHMJHH(IOJBDDLIAOB.INOKNDGFNLK, CLKKEINMEOK.FLFDJCHPGAJ);
				CLKKEINMEOK.MMHLOMIACEK();
			}
			else
			{
				DLLEGIHMJHH(IOJBDDLIAOB.LMJPNCDFAPH, CLKKEINMEOK.FLFDJCHPGAJ);
			}
			List<JJHJHJFNCGC> list = CLKKEINMEOK.IPHCMAJGCIG;
			long num = CLKKEINMEOK.IGFDHCGLKBN;
			List<MOGIFCAGGKE> list2 = new List<MOGIFCAGGKE>();
			int i = 0;
			for (int count = list.Count; i < count; i++)
			{
				bool flag = list[i].GDMECFECCOM == LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM;
				MOGIFCAGGKE mOGIFCAGGKE = new MOGIFCAGGKE();
				mOGIFCAGGKE.EALJKKBHDHK = list[i].KJACEODCOHN;
				mOGIFCAGGKE.GDMECFECCOM = list[i].GDMECFECCOM;
				mOGIFCAGGKE.KCAHGIBBHKJ = i + 1;
				mOGIFCAGGKE.FDEODFEHEFB = list[i].INOKNDGFNLK;
				mOGIFCAGGKE.AILNPFFLELI = list[i].GDMECFECCOM == num;
				mOGIFCAGGKE.MNPEKJAAFHD = flag;
				MOGIFCAGGKE item = mOGIFCAGGKE;
				if (flag)
				{
					result = list[i].AEPLIGFCGIF;
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Events, "TeamChest Current user star count: {0}", list[i].INOKNDGFNLK);
				}
				list2.Add(item);
			}
			if (JKANNLPGLPJ == null)
			{
				JKANNLPGLPJ = new global::FHOJBJMMNOD<MOGIFCAGGKE, TeamChestEntry>(TeamChestScrollController, TeamChestEntryPrefab.GetComponent<TeamChestEntry>(), 15, 0.85f);
				JKANNLPGLPJ.FEHBHKPHBFC(15, 1.4f, 0.8f);
				TeamChestScrollController.Init();
				TeamChestScrollController.SetOffsets(0f - JNFMOMPFIGG, 0f - JNFMOMPFIGG);
			}
			ANJBHOECJME = (float)list.Count * 1.4f + 0.2f;
			JKANNLPGLPJ.BBOMMEKKAEB(list2);
			TeamChestScrollController.SetContentSize(ANJBHOECJME);
			TeamChestScrollController.ScrollToTop();
			TeamChestScrollController.JBOFOOHGDGC();
			return result;
		}

		private void DLLEGIHMJHH(int MGCMMJPNJPH, int CAEMELGEOAE)
		{
			MGCMMJPNJPH = ((MGCMMJPNJPH <= CAEMELGEOAE) ? MGCMMJPNJPH : CAEMELGEOAE);
			MGCMMJPNJPH = ((MGCMMJPNJPH >= 0) ? MGCMMJPNJPH : 0);
			IHPEPELMOAO(EJMMHMPAAPH(MGCMMJPNJPH, CAEMELGEOAE), NENLPOLPOAE(MGCMMJPNJPH, CAEMELGEOAE));
			NMOMJGIHIJG(MGCMMJPNJPH, CAEMELGEOAE);
		}

		private void NMOMJGIHIJG(int MFFLPDALICD, int CAEMELGEOAE)
		{
			StarBarCount.SetText(MFFLPDALICD + " / " + CAEMELGEOAE);
		}

		private void IHPEPELMOAO(float JIANJOALKIM, float MNOOIBAFFIN)
		{
			Vector3 localPosition = StarBar.transform.localPosition;
			localPosition.x = JIANJOALKIM;
			StarBar.transform.localPosition = localPosition;
			Vector2 size = StarBar.size;
			size.x = MNOOIBAFFIN;
			StarBar.size = size;
		}

		private float EJMMHMPAAPH(int MGCMMJPNJPH, int CAEMELGEOAE)
		{
			return -1.554f - -2.331f / (float)CAEMELGEOAE * (float)MGCMMJPNJPH;
		}

		private float NENLPOLPOAE(int MGCMMJPNJPH, int CAEMELGEOAE)
		{
			return 0.411f - -4.6759996f / (float)CAEMELGEOAE * (float)MGCMMJPNJPH;
		}

		private void IOPCENJILNF()
		{
			if (MNGFOOGIKKO <= 0)
			{
				GMOMEPNHJGA();
				return;
			}
			if (MNGFOOGIKKO >= 360000)
			{
				LALEHBICDII(-0.086f);
				NFIGBNGALAA = true;
			}
			TimerHelper.GABGKBAKHDP.RegisterTimer(this);
			DPOOABPAMFO();
		}

		private void LALEHBICDII(float EDDNOJDPMCF)
		{
			Vector3 localPosition = TimeLeft.ANLKLKAINEO.localPosition;
			localPosition.x += EDDNOJDPMCF;
			TimeLeft.ANLKLKAINEO.localPosition = localPosition;
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
			if (NFIGBNGALAA && MNGFOOGIKKO < 360000)
			{
				LALEHBICDII(0.086f);
				NFIGBNGALAA = false;
			}
			if (MNGFOOGIKKO <= 0)
			{
				GMOMEPNHJGA();
				return;
			}
			TimeLeft.FCJBBPHFNPJ = GJEIMLMEHIN.FLANACEGNEO((int)MNGFOOGIKKO, true);
			ClockHand.DORotate(new Vector3(0f, 0f, (float)(MNGFOOGIKKO % 4) * 90f), 0.2f).SetEase(Ease.OutBack);
		}

		private void GMOMEPNHJGA()
		{
			TimerHelper.GABGKBAKHDP.DeregisterTimer(this);
			Vector3 localPosition = TimeLeft.ANLKLKAINEO.localPosition;
			localPosition.x = 0.267f;
			TimeLeft.ANLKLKAINEO.localPosition = localPosition;
			TimeLeft.JOPPDFNGJBM = KNOECCJHIDP.Center;
			TimeLeft.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("CL_Finished");
		}
	}
}
