using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Tutorials;
using Assets.Scripts.LevelLoaderScene;
using Assets.Scripts.MapScene;
using Assets.Scripts.SceneTransitions;
using Assets.Scripts.Utils;
using Assets.Scripts.Utils.Analytics;
using BestHTTP;
using BestHTTP.Authentication;
using ICSharpCode.SharpZipLib.Zip;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils.Game;

namespace LevelLoaderScene
{
	public class LevelLoaderController : MonoBehaviour
	{
		[Serializable]
		public class JsonDescriptionData
		{
			public string fileName;

			public string description;
		}

		[Serializable]
		private class DescList
		{
			public JsonDescriptionData[] list;
		}

		public TextMeshProUGUI ContentText;

		public TextMeshProUGUI TutorialsText;

		public TextMeshProUGUI FunABLevelsText;

		public RectTransform Container;

		public Camera LevelLoaderCamera;

		private bool CLIDFBIJBOM;

		private LLCJMMBBLEH BIAGOOJEIIA;

		public EventSystem TheEventSystem;

		private string IKFDCOHBGCL = "\n";

		private static Uri AKENFIJIECA;

		private static Uri CILMACBAMMC;

		private bool APFGDIJBGGC;

		public static bool IsMarketingLevel;

		public static bool IsOnlineLevel;

		public static bool IsOfflineLevel;

		public static int RandomSeed;

		public static GamePlayRecord Record;

		public InputField OfflineLevelInput;

		public TextMeshProUGUI LevelDescriptionText;

		public Button PlayOnlineLevelButton;

		public Button PlayOfflineLevelButton;

		public Button DownloadButton;

		public GameObject ReplayDataPanel;

		public InputField ReplayDataInput;

		public InputField RandomSeedInput;

		public TextMeshProUGUI ReplayErrorText;

		private string BPINMGLHACC;

		private string BKNJEFFEKAN = "onlinelevels/";

		private int FLDBJBBHCLA = 1;

		private int KGANJEIKFOM;

		private int FAHPMOKDBOL;

		private int AIMLJGJJBCD = 1;

		private bool MJICDGEOHAC;

		private bool CLJHKNLJAPM;

		private static bool NDEGDCFPKPN;

		private string[] IIFIICMOPCP;

		private DescList MEDAGEDKEGM;

		private JsonDescriptionData[] AIIABMGHEIG;

		private int PLDAJGBBDJI;

		public TextMeshProUGUI InboxLifeCount;

		public TextMeshProUGUI UnlimitedLifeSign;

		public TextMeshProUGUI LifeAmountText;

		public TextMeshProUGUI LifeTimeText;

		public TextMeshProUGUI HammerAmountText;

		public TextMeshProUGUI AnvilAmountText;

		public TextMeshProUGUI BoxingGloveAmountText;

		public TextMeshProUGUI CoinsAmountText;

		public TextMeshProUGUI ShuffleAmountText;

		public TextMeshProUGUI RocketAmountText;

		public TextMeshProUGUI BombAmountText;

		public TextMeshProUGUI DiscoAmountText;

		public TextMeshProUGUI StarAmountText;

		public TextMeshProUGUI KeyAmountText;

		private LLCJMMBBLEH ILNNDOBOHNE;

		private int JNMAOAIFJMJ;

		public static Action<string> OnAudioFilesDownloaded;

		public static bool IsMarketingBackgroundDownloaded;

		private static readonly Uri IMANMKDLHIG = new Uri("http://www.okanulas.com/peakgames/marketing/images/background.png");

		public const string MarketingBackgroundImagePath = "/marketingBackgroundImage.png";

		public Button MarketingImageButton;

		public InputField FakeLevelNoInput;

		public static int FakeLevelNo = -1;

		private bool BANMBDGBBGN;

		public TextMeshProUGUI LanguageText;

		public InputField WonUntilText;

		private bool PDPBLIBDMLN;

		private string EKCHGECKMHP;

		[CompilerGenerated]
		private static Comparison<JsonDescriptionData> EBCOMJBLIPP;

		[CompilerGenerated]
		private static Predicate<JsonDescriptionData> DNBOPLHGMHA;

		[CompilerGenerated]
		private static Predicate<JsonDescriptionData> JFHCKLHBBDI;

		[CompilerGenerated]
		private static Predicate<JsonDescriptionData> NOGHOEBDKAH;

		[CompilerGenerated]
		private static OnRequestFinishedDelegate JANLDOMIIEF;

		public static bool BLPJIDEKMMG
		{
			get
			{
				return IsMarketingLevel || IsOnlineLevel || IsOfflineLevel;
			}
		}

		public void Awake()
		{
			if (!MCJHHDACJBG.DGDIEBKEMOL)
			{
				CLIDFBIJBOM = true;
				if (LevelLoaderCamera != null)
				{
					LevelLoaderCamera.enabled = false;
				}
				CaravanSceneManager.Load(GKBHIKONCKJ.Map);
			}
			if (ONCMBJKLKIL.HGJOLCBALEI.ECLBGPBLGMD > 0f)
			{
				float num = 960f * ONCMBJKLKIL.HGJOLCBALEI.ECLBGPBLGMD / (ONCMBJKLKIL.FHAMOHDEGMK * 100f);
				Container.offsetMax = new Vector2(Container.offsetMax.x, 0f - num);
			}
		}

		public void Start()
		{
			if (CLIDFBIJBOM)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			PlayOnlineLevelButton.interactable = false;
			PlayOfflineLevelButton.interactable = true;
			BPINMGLHACC = Path.Combine(Application.persistentDataPath, BKNJEFFEKAN);
			MNHBKDDGIGO();
			StartCoroutine(HKOOEFJGLMC());
			KFNKCGDGHCO();
			if (FakeLevelNo != -1)
			{
				FakeLevelNoInput.text = FakeLevelNo.ToString();
			}
			JNMAOAIFJMJ = CAGBGIHKHEJ.GABGKBAKHDP.ELEKFHDLKJJ();
			InboxLifeCount.FCJBBPHFNPJ = "Add Inbox Life " + JNMAOAIFJMJ;
			AIMLJGJJBCD = Mathf.Max(1, LevelBuilder.CurrentLevelNo);
			OfflineLevelInput.text = AIMLJGJJBCD.ToString();
			TutorialsText.FCJBBPHFNPJ = "Tutorials:\n" + ((!TutorialManager.ForceShowTutorials) ? "Off" : "On");
			LanguageText.FCJBBPHFNPJ = "Lang: " + MDGKDGMGGCL.GABGKBAKHDP.PHOCMCOHANN();
			FunABLevelsText.FCJBBPHFNPJ = "Fun AB Levels:\n" + ((!NDEGDCFPKPN) ? "Off" : "On");
			DDKCMGHBDAC();
			CEIEODBDILE();
			NAAGDFCLOPE.GABGKBAKHDP.LMGDDIIJMHF("CloudUser", PANBGLOOMOC);
			RandomSeed = 0;
			Record = null;
		}

		private void CEIEODBDILE()
		{
			string text = "TapToSkip Count:" + HJBLKNBHMFJ.GABGKBAKHDP.LIANKDMAHFM("TapToSkipCount") + IKFDCOHBGCL;
			string text2 = text;
			text = text2 + "Sync Id:" + GFHPEDILAJG.GABGKBAKHDP.OMBKMIINHMF + IKFDCOHBGCL;
			text = text + "Auto Login Id:" + PeakAnalytics.GetDeviceId() + IKFDCOHBGCL;
			string text3 = LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA ?? string.Empty;
			if (EKCHGECKMHP == null)
			{
				EKCHGECKMHP = string.Empty;
			}
			text = text + "FB Id: " + text3 + IKFDCOHBGCL;
			text = text + "Cloud: " + EKCHGECKMHP + IKFDCOHBGCL;
			ContentText.FCJBBPHFNPJ = text;
		}

		public void Update()
		{
			if (OfflineLevelInput.isFocused && !APFGDIJBGGC)
			{
				APFGDIJBGGC = true;
				OfflineLevelInput.text = string.Empty;
			}
			else if (!OfflineLevelInput.isFocused && APFGDIJBGGC)
			{
				APFGDIJBGGC = false;
				if (OfflineLevelInput.text == string.Empty)
				{
					OfflineLevelInput.text = AIMLJGJJBCD.ToString();
				}
			}
		}

		public void PlaySelectedLevel()
		{
			if (!MJICDGEOHAC)
			{
				MJICDGEOHAC = true;
				KJPPADKJGGN();
				DPFCGMDNHFG();
			}
		}

		public void PlaySelectedOfflineLevel()
		{
			if (AIMLJGJJBCD <= 2850 && !MJICDGEOHAC)
			{
				MJICDGEOHAC = true;
				IsOfflineLevel = true;
				IsOnlineLevel = false;
				KJPPADKJGGN();
				DPFCGMDNHFG(true);
			}
		}

		private void KJPPADKJGGN()
		{
			string text = FakeLevelNoInput.text;
			int result = -1;
			if (!string.IsNullOrEmpty(text) && int.TryParse(text, out result))
			{
				FakeLevelNo = result;
			}
		}

		public void StepLevelNo(int CCHAAJBNJHL)
		{
			if ((AIMLJGJJBCD == 1 && CCHAAJBNJHL < 0) || PLDAJGBBDJI > 0)
			{
				PLDAJGBBDJI = Mathf.Clamp(PLDAJGBBDJI - CCHAAJBNJHL, 0, KGANJEIKFOM);
				PlayOfflineLevelButton.interactable = PLDAJGBBDJI == 0;
			}
			else
			{
				AIMLJGJJBCD += CCHAAJBNJHL;
				PlayOfflineLevelButton.interactable = AIMLJGJJBCD <= 2850;
			}
			NLAMOOEEAHI();
			DDKCMGHBDAC();
		}

		private void DPFCGMDNHFG(bool JCEKOLNILCC = false)
		{
			if (Record == null)
			{
				int.TryParse(RandomSeedInput.text, out RandomSeed);
			}
			if (!JCEKOLNILCC)
			{
				IsOnlineLevel = true;
				LevelBuilder.CurrentLevelNo = Math.Max(0, FLDBJBBHCLA - KGANJEIKFOM);
				if (NDEGDCFPKPN && LevelBuilder.CurrentLevelNo <= AIIABMGHEIG.Length)
				{
					LevelBuilder.CurrentLevelPath = AIIABMGHEIG[LevelBuilder.CurrentLevelNo - 1].fileName + "|FunAB";
				}
				else
				{
					LevelBuilder.CurrentLevelPath = MEDAGEDKEGM.list[FLDBJBBHCLA - 1].fileName;
				}
				IsMarketingLevel = MEDAGEDKEGM.list[FLDBJBBHCLA - 1].fileName.Contains("MMM");
			}
			else
			{
				IsOfflineLevel = true;
				int.TryParse(OfflineLevelInput.text, out AIMLJGJJBCD);
				AIMLJGJJBCD = Mathf.Clamp(AIMLJGJJBCD, 1, 2850);
				LevelBuilder.CurrentLevelNo = AIMLJGJJBCD;
				string empty = string.Empty;
				if (NDEGDCFPKPN)
				{
					empty = MJJHFBBMHAO.CJENHJMDHFN("ToonRocksFun" + AIMLJGJJBCD);
					string text = Path.Combine(Application.streamingAssetsPath, "peak/" + empty + ".bin");
					if (!File.Exists(text))
					{
						GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LevelLoader, "There is no Fun AB Level in local levelNo:{0} path:{1}", AIMLJGJJBCD, text);
						MJICDGEOHAC = false;
						return;
					}
					empty += "|FunAB";
				}
				else
				{
					empty = MJJHFBBMHAO.CJENHJMDHFN("ToonRocks" + AIMLJGJJBCD);
				}
				LevelBuilder.CurrentLevelPath = empty;
			}
			MapManager.CurrentMapId = MapManager.GetMapIdForLevel(LevelBuilder.CurrentLevelNo).ToString();
			CaravanSceneManager.Load(GKBHIKONCKJ.GamePlay);
		}

		private void DDKCMGHBDAC()
		{
			FLDBJBBHCLA = AIMLJGJJBCD + KGANJEIKFOM - PLDAJGBBDJI;
			OnLevelChange();
		}

		private void NLAMOOEEAHI()
		{
			AIMLJGJJBCD = Mathf.Clamp(AIMLJGJJBCD, 1, Mathf.Max(FAHPMOKDBOL - KGANJEIKFOM, 2850));
			OfflineLevelInput.text = AIMLJGJJBCD.ToString();
		}

		public void OnOfflineLevelInputEnded()
		{
			if (OfflineLevelInput.text.Length > 0)
			{
				int.TryParse(OfflineLevelInput.text, out AIMLJGJJBCD);
				PLDAJGBBDJI = 0;
			}
			PlayOfflineLevelButton.enabled = true;
			NLAMOOEEAHI();
			DDKCMGHBDAC();
			PlayOfflineLevelButton.interactable = AIMLJGJJBCD <= 2850;
		}

		public void OnLevelChange()
		{
			NLAMOOEEAHI();
			HJCFLLEECHH();
		}

		private void HJCFLLEECHH()
		{
			if (MEDAGEDKEGM != null)
			{
				FLDBJBBHCLA = ((FLDBJBBHCLA < MEDAGEDKEGM.list.Length) ? FLDBJBBHCLA : MEDAGEDKEGM.list.Length);
				LevelDescriptionText.FCJBBPHFNPJ = MEDAGEDKEGM.list[FLDBJBBHCLA - 1].description;
			}
		}

		public void DownloadNewLevels()
		{
			if (!CLJHKNLJAPM)
			{
				CLJHKNLJAPM = true;
				LevelDescriptionText.FCJBBPHFNPJ = "Downloading...";
				DownloadButton.interactable = false;
				HTTPRequest hTTPRequest = new HTTPRequest(CILMACBAMMC, HTTPMethods.Get, AEIFIBBLDAD);
				hTTPRequest.Send();
			}
		}

		private void AEIFIBBLDAD(HTTPRequest MONIIALMCBH, HTTPResponse OMJOIIOONMO)
		{
			string text = "Download Completed: \n";
			bool flag = false;
			switch (MONIIALMCBH.State)
			{
			case HTTPRequestStates.Finished:
				flag = true;
				break;
			case HTTPRequestStates.Error:
			{
				string text2 = ((MONIIALMCBH.Exception == null) ? "No Exception" : (MONIIALMCBH.Exception.Message + "\n" + MONIIALMCBH.Exception.StackTrace));
				text = text + "Download failed for request with error " + text2;
				break;
			}
			case HTTPRequestStates.Aborted:
				text += "Download Aborted";
				break;
			case HTTPRequestStates.ConnectionTimedOut:
				text += "Download Connection TimedOut";
				break;
			case HTTPRequestStates.TimedOut:
				text += "Download TimedOut";
				break;
			default:
				text += "Download Unknown Error";
				break;
			}
			if (flag)
			{
				byte[] data = OMJOIIOONMO.Data;
				string text3 = Application.persistentDataPath + "/onlinelevels.zip";
				if (File.Exists(text3))
				{
					File.Delete(text3);
				}
				using (FileStream fileStream = new FileStream(text3, FileMode.OpenOrCreate))
				{
					byte[] array = data;
					foreach (byte value in array)
					{
						fileStream.WriteByte(value);
					}
				}
				if (Directory.Exists(BPINMGLHACC))
				{
					Directory.Delete(BPINMGLHACC, true);
				}
				Directory.CreateDirectory(BPINMGLHACC);
				using (ZipInputStream zipInputStream = new ZipInputStream(File.OpenRead(text3)))
				{
					ZipEntry nextEntry;
					while ((nextEntry = zipInputStream.GetNextEntry()) != null)
					{
						string fileName = Path.GetFileName(nextEntry.Name);
						if (fileName == string.Empty)
						{
							continue;
						}
						using (FileStream fileStream2 = File.Create(Path.Combine(Application.persistentDataPath, BKNJEFFEKAN) + nextEntry.Name))
						{
							byte[] array2 = new byte[2048];
							while (true)
							{
								int num = zipInputStream.Read(array2, 0, array2.Length);
								if (num > 0)
								{
									fileStream2.Write(array2, 0, num);
									continue;
								}
								break;
							}
						}
					}
				}
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LevelLoader, "Unzipping resulted with : From {0} to {1}", text3, BPINMGLHACC);
			}
			LevelDescriptionText.FCJBBPHFNPJ = text;
			CLJHKNLJAPM = false;
			DownloadButton.interactable = true;
			MNHBKDDGIGO();
		}

		private void MNHBKDDGIGO()
		{
			FLDBJBBHCLA = 1;
			if (Directory.Exists(BPINMGLHACC))
			{
				bool isOnlineLevel = IsOnlineLevel;
				string path = Path.Combine(BPINMGLHACC, "desc.json");
				if (File.Exists(path))
				{
					string json = File.ReadAllText(path);
					MEDAGEDKEGM = JsonUtility.FromJson<DescList>(json);
					Array.Sort(MEDAGEDKEGM.list, (JsonDescriptionData LIIFHNKIAKD, JsonDescriptionData NBCBJMAGFCH) => LIIFHNKIAKD.description.CompareTo(NBCBJMAGFCH.description));
					JsonDescriptionData[] array = Array.FindAll(MEDAGEDKEGM.list, (JsonDescriptionData AMFCENFNAJJ) => AMFCENFNAJJ.fileName.Contains("MMM") || AMFCENFNAJJ.fileName.Contains("COM"));
					if (array != null)
					{
						KGANJEIKFOM = array.Length;
					}
					AIIABMGHEIG = Array.FindAll(MEDAGEDKEGM.list, (JsonDescriptionData AMFCENFNAJJ) => AMFCENFNAJJ.fileName.Contains("FUN"));
					MEDAGEDKEGM.list = Array.FindAll(MEDAGEDKEGM.list, (JsonDescriptionData AMFCENFNAJJ) => !AMFCENFNAJJ.fileName.Contains("FUN"));
				}
				FAHPMOKDBOL = MEDAGEDKEGM.list.Length;
				if (isOnlineLevel && LevelBuilder.CurrentLevelNo != 0)
				{
					FLDBJBBHCLA = Math.Min(LevelBuilder.CurrentLevelNo + KGANJEIKFOM, FAHPMOKDBOL);
					OnLevelChange();
				}
				PlayOnlineLevelButton.interactable = true;
				HJCFLLEECHH();
			}
			else
			{
				LevelDescriptionText.FCJBBPHFNPJ = "No Downloaded Levels!";
			}
		}

		private void KFNKCGDGHCO()
		{
			ShuffleAmountText.FCJBBPHFNPJ = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Dice).ToString();
			CoinsAmountText.FCJBBPHFNPJ = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Coins).ToString();
			HammerAmountText.FCJBBPHFNPJ = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Hammer).ToString();
			AnvilAmountText.FCJBBPHFNPJ = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Anvil).ToString();
			BoxingGloveAmountText.FCJBBPHFNPJ = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.BoxingGlove).ToString();
			RocketAmountText.FCJBBPHFNPJ = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Rocket).ToString();
			BombAmountText.FCJBBPHFNPJ = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Bomb).ToString();
			DiscoAmountText.FCJBBPHFNPJ = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.DiscoBall).ToString();
			StarAmountText.FCJBBPHFNPJ = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Stars).ToString();
			KeyAmountText.FCJBBPHFNPJ = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Key).ToString();
		}

		private IEnumerator HKOOEFJGLMC()
		{
			while (true)
			{
				KIKHFGDINBD();
				yield return MCJHHDACJBG.KNLADMIBAAD;
			}
		}

		private void KIKHFGDINBD()
		{
			PJPPADHKGHN pJPPADHKGHN = PJPPADHKGHN.GABGKBAKHDP;
			int num = pJPPADHKGHN.HNBIMJHPIPE();
			if (num > 0)
			{
				UnlimitedLifeSign.enabled = true;
				LifeAmountText.enabled = false;
			}
			else
			{
				UnlimitedLifeSign.enabled = false;
				LifeAmountText.enabled = true;
				LifeAmountText.FCJBBPHFNPJ = pJPPADHKGHN.PMBGCACJIHD().DLDHNNCGIPI.ToString();
				num = pJPPADHKGHN.PMBGCACJIHD().APLNHKHHMEL;
			}
			LifeTimeText.FCJBBPHFNPJ = GJEIMLMEHIN.FLANACEGNEO(num, true);
		}

		public void AddCoinsButtonOnDown()
		{
			if (ILNNDOBOHNE == null)
			{
				ILNNDOBOHNE = new LLCJMMBBLEH(FJDJIJLAOLH());
			}
		}

		private IEnumerator FJDJIJLAOLH()
		{
			yield return new WaitForSeconds(0.6f);
			AddCoins();
			for (int i = 0; i < 4; i++)
			{
				yield return new WaitForSeconds(0.125f);
				AddCoins();
			}
			while (true)
			{
				yield return new WaitForSeconds(0.04f);
				AddCoins();
			}
		}

		public void AddCoinsButtonOnUp()
		{
			ILNNDOBOHNE.BPPFBMCJOAH();
			ILNNDOBOHNE = null;
		}

		public void UseLife(int ENMLICFLHAO)
		{
			for (int i = 0; i < ENMLICFLHAO; i++)
			{
				PJPPADHKGHN.GABGKBAKHDP.MFDIAGADLNJ();
			}
			KIKHFGDINBD();
		}

		public void IncreaseUnlimitedLife(int GBBOCDMGFFH)
		{
			int num = GBBOCDMGFFH * 60;
			PJPPADHKGHN pJPPADHKGHN = PJPPADHKGHN.GABGKBAKHDP;
			int num2 = pJPPADHKGHN.HNBIMJHPIPE();
			pJPPADHKGHN.BOLHHAJPKMH(num2 + num, true);
			KIKHFGDINBD();
		}

		public void AddCoins()
		{
			GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Coins, 100);
			KFNKCGDGHCO();
		}

		public void AddKeys()
		{
			int num = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Key);
			int num2 = num % 100;
			if (num2 < 98)
			{
				GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Key, 1);
				KFNKCGDGHCO();
			}
		}

		public void FullLife()
		{
			PJPPADHKGHN.GABGKBAKHDP.MMECFKDOBDC();
			KIKHFGDINBD();
		}

		public void AddResources()
		{
			GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Anvil, 10);
			GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.BoxingGlove, 10);
			GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Hammer, 10);
			GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Dice, 10);
			GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Rocket, 10);
			GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Bomb, 10);
			GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.DiscoBall, 10);
			KFNKCGDGHCO();
		}

		public void RemoveResources()
		{
			RemoveAllResources();
		}

		public void RemoveAllResources()
		{
			GEBAAFFGKJG.GABGKBAKHDP.MDCKDPBIIEN(NAAHKHPBAPA.Coins, 0);
			GEBAAFFGKJG.GABGKBAKHDP.MDCKDPBIIEN(NAAHKHPBAPA.Hammer, 0);
			GEBAAFFGKJG.GABGKBAKHDP.MDCKDPBIIEN(NAAHKHPBAPA.Anvil, 0);
			GEBAAFFGKJG.GABGKBAKHDP.MDCKDPBIIEN(NAAHKHPBAPA.BoxingGlove, 0);
			GEBAAFFGKJG.GABGKBAKHDP.MDCKDPBIIEN(NAAHKHPBAPA.Dice, 0);
			GEBAAFFGKJG.GABGKBAKHDP.MDCKDPBIIEN(NAAHKHPBAPA.Rocket, 0);
			GEBAAFFGKJG.GABGKBAKHDP.MDCKDPBIIEN(NAAHKHPBAPA.Bomb, 0);
			GEBAAFFGKJG.GABGKBAKHDP.MDCKDPBIIEN(NAAHKHPBAPA.DiscoBall, 0);
			KFNKCGDGHCO();
		}

		public void AddStarsButtonClick()
		{
			GEBAAFFGKJG.GABGKBAKHDP.GOHFAPAOAJI(NAAHKHPBAPA.Stars, 1);
			KFNKCGDGHCO();
		}

		public void AddInboxLife()
		{
			CAGBGIHKHEJ.GABGKBAKHDP.CPDDAPIICDO("Bruno Bear", DateTime.UtcNow.GMEBBNOHJFJ().ToString(), JNMAOAIFJMJ);
			JNMAOAIFJMJ++;
			InboxLifeCount.FCJBBPHFNPJ = "Add Inbox Life " + JNMAOAIFJMJ;
		}

		public void DownloadAudioFiles()
		{
			OnAudioFilesDownloaded = delegate(string DIDHNNMKJFE)
			{
				LevelDescriptionText.FCJBBPHFNPJ = DIDHNNMKJFE;
				HJCFLLEECHH();
			};
			LevelDescriptionText.FCJBBPHFNPJ = "Downloading Audio";
			DownloadOnlineAudioFiles();
		}

		public static void DownloadOnlineAudioFiles()
		{
			HTTPRequest hTTPRequest = new HTTPRequest(AKENFIJIECA, HTTPMethods.Get, OnAudioFileDownloadCompleted);
			hTTPRequest.DisableCache = true;
			HTTPRequest hTTPRequest2 = hTTPRequest;
			hTTPRequest2.Send();
		}

		public static void OnAudioFileDownloadCompleted(HTTPRequest MONIIALMCBH, HTTPResponse OMJOIIOONMO)
		{
			string text = "Download Completed: \n";
			try
			{
				bool flag = false;
				switch (MONIIALMCBH.State)
				{
				case HTTPRequestStates.Finished:
					flag = true;
					break;
				case HTTPRequestStates.Error:
				{
					string text2 = ((MONIIALMCBH.Exception == null) ? "No Exception" : (MONIIALMCBH.Exception.Message + "\n" + MONIIALMCBH.Exception.StackTrace));
					text = text + "Download failed for request with error " + text2;
					break;
				}
				case HTTPRequestStates.Aborted:
					text += "Download Aborted";
					break;
				case HTTPRequestStates.ConnectionTimedOut:
					text += "Download Connection TimedOut";
					break;
				case HTTPRequestStates.TimedOut:
					text += "Download TimedOut";
					break;
				default:
					text += "Download Unknown Error";
					break;
				}
				if (flag)
				{
					byte[] data = OMJOIIOONMO.Data;
					string path = Path.Combine(Application.persistentDataPath, "audio.zip");
					if (File.Exists(path))
					{
						File.Delete(path);
					}
					using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
					{
						byte[] array = data;
						foreach (byte value in array)
						{
							fileStream.WriteByte(value);
						}
					}
					string path2 = Path.Combine(Application.persistentDataPath, "temp_audio");
					if (Directory.Exists(path2))
					{
						Directory.Delete(path2, true);
					}
					using (ZipInputStream zipInputStream = new ZipInputStream(File.OpenRead(path)))
					{
						ZipEntry nextEntry;
						while ((nextEntry = zipInputStream.GetNextEntry()) != null)
						{
							string directoryName = Path.GetDirectoryName(nextEntry.Name);
							string fileName = Path.GetFileName(nextEntry.Name);
							if (directoryName.Length > 0)
							{
								Directory.CreateDirectory(Application.persistentDataPath + "/" + directoryName);
							}
							if (fileName == string.Empty)
							{
								continue;
							}
							using (FileStream fileStream2 = File.Create(Application.persistentDataPath + "/" + nextEntry.Name))
							{
								byte[] array2 = new byte[2048];
								while (true)
								{
									int num = zipInputStream.Read(array2, 0, array2.Length);
									if (num > 0)
									{
										fileStream2.Write(array2, 0, num);
										continue;
									}
									break;
								}
							}
						}
					}
					File.Delete(path);
				}
				AudioManager.ProcessDownloadedAudioFiles();
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.LevelLoader, "Error Downloading audio files:{0} Stack:{1}", ex.Message, ex.StackTrace);
			}
			finally
			{
				if (OnAudioFilesDownloaded != null)
				{
					OnAudioFilesDownloaded(text);
				}
				OnAudioFilesDownloaded = null;
			}
		}

		public void DownloadMarketingBackgroundImage()
		{
			if (!CLJHKNLJAPM)
			{
				CLJHKNLJAPM = true;
				LevelDescriptionText.FCJBBPHFNPJ = "Downloading...";
				DownloadButton.interactable = false;
				MarketingImageButton.interactable = false;
				HTTPRequest hTTPRequest = new HTTPRequest(IMANMKDLHIG, HTTPMethods.Get, OnMarketingBackgroundImageDownloadCompleted);
				hTTPRequest.Credentials = new Credentials("toon", "hello2017");
				hTTPRequest.Send();
			}
		}

		public void OnMarketingBackgroundImageDownloadCompleted(HTTPRequest MONIIALMCBH, HTTPResponse OMJOIIOONMO)
		{
			string text = "Download Completed: \n";
			bool flag = false;
			switch (MONIIALMCBH.State)
			{
			case HTTPRequestStates.Finished:
				flag = true;
				break;
			case HTTPRequestStates.Error:
			{
				string text2 = ((MONIIALMCBH.Exception == null) ? "No Exception" : (MONIIALMCBH.Exception.Message + "\n" + MONIIALMCBH.Exception.StackTrace));
				text = text + "Download failed for request with error " + text2;
				break;
			}
			case HTTPRequestStates.Aborted:
				text += "Download Aborted";
				break;
			case HTTPRequestStates.ConnectionTimedOut:
				text += "Download Connection TimedOut";
				break;
			case HTTPRequestStates.TimedOut:
				text += "Download TimedOut";
				break;
			default:
				text += "Download Unknown Error";
				break;
			}
			if (flag)
			{
				byte[] data = OMJOIIOONMO.Data;
				string text3 = Application.persistentDataPath + "/marketingBackgroundImage.png";
				if (File.Exists(text3))
				{
					File.Delete(text3);
				}
				using (FileStream fileStream = new FileStream(text3, FileMode.OpenOrCreate))
				{
					byte[] array = data;
					foreach (byte value in array)
					{
						fileStream.WriteByte(value);
					}
				}
				if (Directory.Exists(BPINMGLHACC))
				{
					Directory.Delete(BPINMGLHACC, true);
				}
				Directory.CreateDirectory(BPINMGLHACC);
				int num = ABMHGHAMFDH.MMHJJNIGKFD(text3, BPINMGLHACC);
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LevelLoader, "Unzipping resulted with {0}: From {1} to {2}", num, text3, BPINMGLHACC);
			}
			LevelDescriptionText.FCJBBPHFNPJ = text;
			CLJHKNLJAPM = false;
			DownloadButton.interactable = true;
			MarketingImageButton.interactable = true;
			MNHBKDDGIGO();
		}

		public void TakeScreenShots()
		{
			if (!BANMBDGBBGN)
			{
				GameObject gameObject = new GameObject();
				UnityEngine.Object.DontDestroyOnLoad(gameObject);
				gameObject.AddComponent<LevelScreenShotTaker>();
			}
		}

		public void ChangeLanguage()
		{
			string[] array = new string[9] { "en", "tr", "fr", "de", "it", "pt-BR", "es", "ru", "ja" };
			string text = MDGKDGMGGCL.GABGKBAKHDP.PHOCMCOHANN();
			int num = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (text.Equals(array[i]))
				{
					num = i;
					break;
				}
			}
			num++;
			if (num >= array.Length)
			{
				num = 0;
			}
			string fCAKCGLLGCL = array[num];
			MDGKDGMGGCL.GABGKBAKHDP.DNNOFBIEFCF(fCAKCGLLGCL);
			string text2 = MDGKDGMGGCL.GABGKBAKHDP.PHOCMCOHANN();
			PNAJOCHGJFO.LMJKBCFGAIN(PNAJOCHGJFO.HNJPEIBFHJI(text2), text2, true, true);
			LanguageText.FCJBBPHFNPJ = "Lang: " + text2;
		}

		public void WonUntil()
		{
			if (!PDPBLIBDMLN)
			{
				PDPBLIBDMLN = true;
				string text = WonUntilText.text;
				int result;
				int.TryParse(text, out result);
				if (result <= 0)
				{
					result = 50;
				}
				int num = 2850;
				if (result > num)
				{
					result = num;
				}
				for (int i = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1; i <= result; i++)
				{
					MADFPPJCOIM.GABGKBAKHDP.CGINNGBOKAP(Math.Max(0, i - 1), 714, 2);
				}
				CaravanSceneManager.Load(GKBHIKONCKJ.Map);
			}
		}

		public void SwitchTutorials()
		{
			TutorialManager.ForceShowTutorials = !TutorialManager.ForceShowTutorials;
			TutorialsText.FCJBBPHFNPJ = "Tutorials:\n" + ((!TutorialManager.ForceShowTutorials) ? "Off" : "On");
		}

		public void SwitchFunABLevels()
		{
			NDEGDCFPKPN = !NDEGDCFPKPN;
			FunABLevelsText.FCJBBPHFNPJ = "Fun AB Levels:\n" + ((!NDEGDCFPKPN) ? "Off" : "On");
		}

		public void SendNotification()
		{
		}

		public void DisplayNotification()
		{
		}

		public void CrashNative()
		{
			NHNBFBDHKGN.LEKBJGOMHNP();
		}

		public void CrashMono()
		{
			NHNBFBDHKGN.GCJPFNFPIIB();
		}

		public void OpenMapScene()
		{
			if (!MJICDGEOHAC)
			{
				MJICDGEOHAC = true;
				CaravanSceneManager.Load(GKBHIKONCKJ.Map);
			}
		}

		public void ResetTapToSkipCount()
		{
			HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("TapToSkipCount", "0");
			CEIEODBDILE();
		}

		public void HideTapToSkip()
		{
			HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("TapToSkipCount", "100");
			CEIEODBDILE();
		}

		public void ClearCloud()
		{
			PHHKFLHAFHG.PEDBOELHCPG();
			new LLCJMMBBLEH(IEHKIMPCKCJ());
		}

		public void PlayLastRecord()
		{
			if (MLPHFMDIMLB.LLPBJPNDKIA != null)
			{
				Record = MLPHFMDIMLB.LLPBJPNDKIA;
				RandomSeed = Record.s;
				AIMLJGJJBCD = Record.l;
				MHLCCLLIDIN();
			}
		}

		public void ShowReplayPanel()
		{
			ReplayErrorText.FCJBBPHFNPJ = string.Empty;
			ReplayDataPanel.SetActive(true);
		}

		public void CheckAllLevels()
		{
			GameObject gameObject = new GameObject();
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			gameObject.AddComponent<LevelChecker>();
		}

		public void HideReplayPanel()
		{
			ReplayDataPanel.SetActive(false);
		}

		public void PlayLogDataReplay()
		{
			ReplayErrorText.FCJBBPHFNPJ = string.Empty;
			string text = ReplayDataInput.text;
			if (!string.IsNullOrEmpty(text))
			{
				GamePlayRecord gamePlayRecord = null;
				try
				{
					gamePlayRecord = GamePlayRecord.NBPMNECNBHJ(text);
				}
				catch (Exception ex)
				{
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.LevelLoader, "There is an error while trying to parse game play record json data. Error:{0}", ex.Message);
				}
				if (gamePlayRecord == null)
				{
					ReplayErrorText.FCJBBPHFNPJ = "Json parse error. Please check your replay data and try again.";
					return;
				}
				if (gamePlayRecord.v != 4)
				{
					ReplayErrorText.FCJBBPHFNPJ = string.Format("Recorded data version is v{0}, but it should be version v{1}.", gamePlayRecord.v, 4);
					return;
				}
				Record = gamePlayRecord;
				RandomSeed = Record.s;
				OfflineLevelInput.text = gamePlayRecord.l.ToString();
				OnOfflineLevelInputEnded();
				MHLCCLLIDIN();
			}
		}

		private void MHLCCLLIDIN()
		{
			if (AIMLJGJJBCD > 2850)
			{
				PlaySelectedLevel();
			}
			else
			{
				PlaySelectedOfflineLevel();
			}
		}

		private IEnumerator IEHKIMPCKCJ()
		{
			yield return MCJHHDACJBG.KNLADMIBAAD;
			NAAGDFCLOPE.GABGKBAKHDP.LMGDDIIJMHF("CloudUser", PANBGLOOMOC);
		}

		private void PANBGLOOMOC(string MBBPBGHKLJM)
		{
			try
			{
				string[] array = MBBPBGHKLJM.Split(':');
				string text = "fb";
				if (text != array[0])
				{
					text = "guest";
				}
				string text2 = array[1];
				string text3 = array[3];
				EKCHGECKMHP = "G:" + text2 + " FB:" + text3 + " (Active:" + text + ")";
			}
			catch (Exception)
			{
				EKCHGECKMHP = string.Empty;
			}
			CEIEODBDILE();
		}

		[CompilerGenerated]
		private static int NOGBIKFDCAJ(JsonDescriptionData LIIFHNKIAKD, JsonDescriptionData NBCBJMAGFCH)
		{
			return LIIFHNKIAKD.description.CompareTo(NBCBJMAGFCH.description);
		}

		[CompilerGenerated]
		private static bool HPILCEIPPDL(JsonDescriptionData AMFCENFNAJJ)
		{
			return AMFCENFNAJJ.fileName.Contains("MMM") || AMFCENFNAJJ.fileName.Contains("COM");
		}

		[CompilerGenerated]
		private static bool HNPKFKKBNCB(JsonDescriptionData AMFCENFNAJJ)
		{
			return AMFCENFNAJJ.fileName.Contains("FUN");
		}

		[CompilerGenerated]
		private static bool BHMHLKPHIAP(JsonDescriptionData AMFCENFNAJJ)
		{
			return !AMFCENFNAJJ.fileName.Contains("FUN");
		}

		[CompilerGenerated]
		private void COIHJLKLMOF(string DIDHNNMKJFE)
		{
			LevelDescriptionText.FCJBBPHFNPJ = DIDHNNMKJFE;
			HJCFLLEECHH();
		}
	}
}
