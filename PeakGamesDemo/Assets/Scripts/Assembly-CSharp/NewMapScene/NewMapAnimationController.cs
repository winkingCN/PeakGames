using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Tutorials;
using Assets.Scripts.MapScene;
using Assets.Scripts.SceneTransitions;
using Assets.Scripts.Utils;
using CasualTools.Dialogs;
using MapScene;
using UnityEngine;

namespace NewMapScene
{
	public class NewMapAnimationController : MonoBehaviour
	{
		public Transform StarCollectStartPosition;

		public NewMapPage CurrentMapPage;

		public GameObject MapTutorialReference;

		public MapManager CurrentMapManager;

		public StarChestDisplay StarChestDisplay;

		public ToonChestDisplay ToonChestDisplay;

		public DailyBonusDisplay DailyBonusDisplay;

		public TeamChestDisplay TeamChestDisplay;

		public StarTournamentDisplay StarTournamentDisplay;

		public TeamTournamentDisplay TeamTournamentDisplay;

		public TreasureHuntDisplay TreasureHuntDisplay;

		public LevelButton LevelButton;

		public LevelButton StageButton;

		public LevelStar[] LevelStars;

		public Transform LevelStarTarget;

		public Action OnAnimationCompleted;

		[HideInInspector]
		public bool BlockFacebookPopup;

		private OOHGOOPDAEM JMDDFDJGNNL;

		private int LKEMPLLFFBJ;

		private int IILDKKHLACP;

		private List<OOHGOOPDAEM> ABFNGEHFCIN;

		private readonly HashSet<string> ENCOCEGJNNE = new HashSet<string>();

		private Coroutine OFLKAPCHKDI;

		private float PEEAJDGKMFI = -1f;

		public bool LPIEKIDOGNI { get; private set; }

		public OOHGOOPDAEM FLJGANLMLJD
		{
			get
			{
				return JMDDFDJGNNL;
			}
		}

		public bool LNGHOBJLPGL { get; set; }

		private void NFOEGPCDJKB(string IKNCPEPOKGJ)
		{
			ENCOCEGJNNE.Add(IKNCPEPOKGJ);
			DNLIMJIDCED();
		}

		private void KODMFPGMPNK(string IKNCPEPOKGJ)
		{
			ENCOCEGJNNE.Remove(IKNCPEPOKGJ);
		}

		public static void AddToFocusAnimations(string IKNCPEPOKGJ)
		{
			if (MapManager.Instance != null)
			{
				MapManager.Instance.CurrentNewMapAnimationController.NFOEGPCDJKB(IKNCPEPOKGJ);
			}
		}

		private void DNLIMJIDCED()
		{
			if (OFLKAPCHKDI == null)
			{
				OFLKAPCHKDI = StartCoroutine(LAIOABDCCIC());
			}
			else
			{
				PEEAJDGKMFI = Time.time + 60f;
			}
		}

		public void StopFocusAnimationCoroutine()
		{
			if (OFLKAPCHKDI != null)
			{
				StopCoroutine(OFLKAPCHKDI);
				OFLKAPCHKDI = null;
			}
		}

		private void DJFKFOLJBBJ()
		{
			if (ENCOCEGJNNE.Count > 0 && StartAnimationFlowOnFocusIn())
			{
				ENCOCEGJNNE.Clear();
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.MapAnimationController, "Focus Animations flow started from coroutine.");
			}
		}

		private IEnumerator LAIOABDCCIC()
		{
			while (LPIEKIDOGNI)
			{
				yield return null;
			}
			PEEAJDGKMFI = Time.time + 60f;
			while (Time.time < PEEAJDGKMFI)
			{
				DJFKFOLJBBJ();
				yield return MCJHHDACJBG.KNLADMIBAAD;
			}
			DJFKFOLJBBJ();
			OFLKAPCHKDI = null;
		}

		public void Awake()
		{
			int num = LevelStars.Length;
			for (int i = 0; i < num; i++)
			{
				if (LevelStars[i].gameObject.activeSelf)
				{
					LevelStars[i].gameObject.SetActive(false);
				}
			}
		}

		private void OnDestroy()
		{
			OnAnimationCompleted = null;
		}

		private List<OOHGOOPDAEM> GEIBELODNON(bool AMMJOBIJHFN)
		{
			int aMKOJOKCELO = NDGOJGLPIJF.GABGKBAKHDP.AMKOJOKCELO;
			int focusCounter = FocusListener.MOGJKPIEGGL;
			float dKIPEJPGACG = ((aMKOJOKCELO <= 0) ? 0f : 0.5f);
			int val = 2850;
			int aBJDELCBHCM = Math.Min(val, 1 + MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC());
			MapTutorial.DidShowMapTutorialInCurrentFlow = false;
			List<OOHGOOPDAEM> list;
			if (ELBMHNOBHPN.DJGMHLLAGLE)
			{
				list = new List<OOHGOOPDAEM>();
				list.Add(new AGHCCCFOBFA(ACCNCCEPFFE));
				list.Add(new GADNIEHOENP(0f, ACCNCCEPFFE));
				list.Add(new KOFDCENHGIN(StarChestDisplay, MapTutorialReference, ACCNCCEPFFE));
				list.Add(new ENONBHFBODA(ToonChestDisplay, MapTutorialReference, ACCNCCEPFFE));
				list.Add(new FOJIFKGIDJN(ACCNCCEPFFE));
				list.Add(new FKLBKNGILLM(DailyBonusDisplay, MapTutorialReference, ACCNCCEPFFE));
				list.Add(new LCBBCGAOLMK(ACCNCCEPFFE));
				list.Add(new JNBLANLHOMI(ACCNCCEPFFE));
				list.Add(new EIOJBFNGJMN(TreasureHuntDisplay, MapTutorialReference, ACCNCCEPFFE));
				list.Add(new LFCPHJHHOGP(TeamChestDisplay, MapTutorialReference, ACCNCCEPFFE));
				list.Add(new CICNNBBKKOM(TeamTournamentDisplay, MapTutorialReference, ACCNCCEPFFE));
				list.Add(new LNFMMHADOMD(false, ACCNCCEPFFE));
				return list;
			}
			if (AMMJOBIJHFN)
			{
				list = new List<OOHGOOPDAEM>();
				list.Add(new KJONDCLCMHK(ACCNCCEPFFE));
				list.Add(new FOJIFKGIDJN(ACCNCCEPFFE));
				list.Add(new DOKDGDIJFGA(ACCNCCEPFFE));
				list.Add(new JNBLANLHOMI(ACCNCCEPFFE));
				list.Add(new EIOJBFNGJMN(TreasureHuntDisplay, MapTutorialReference, ACCNCCEPFFE));
				list.Add(new LFCPHJHHOGP(TeamChestDisplay, MapTutorialReference, ACCNCCEPFFE));
				list.Add(new CICNNBBKKOM(TeamTournamentDisplay, MapTutorialReference, ACCNCCEPFFE));
				list.Add(new LNFMMHADOMD(true, ACCNCCEPFFE));
				return list;
			}
			if (MapManager.IsFirstTime && !LevelBuilder.EEPCGJDBPAE)
			{
				MapManager.IsFirstTime = false;
				list = new List<OOHGOOPDAEM>();
				list.Add(new KJONDCLCMHK(ACCNCCEPFFE));
				list.Add(new KOFDCENHGIN(StarChestDisplay, MapTutorialReference, ACCNCCEPFFE));
				list.Add(new ENONBHFBODA(ToonChestDisplay, MapTutorialReference, ACCNCCEPFFE));
				list.Add(new FOJIFKGIDJN(ACCNCCEPFFE));
				list.Add(new FKLBKNGILLM(DailyBonusDisplay, MapTutorialReference, ACCNCCEPFFE));
				list.Add(new GFIEJLKCDDD(CurrentMapManager, ACCNCCEPFFE));
				list.Add(new HKBGHJCLNBB(ACCNCCEPFFE));
				list.Add(new DOKDGDIJFGA(ACCNCCEPFFE));
				list.Add(new LCBBCGAOLMK(ACCNCCEPFFE));
				list.Add(new JNBLANLHOMI(ACCNCCEPFFE));
				list.Add(new EIOJBFNGJMN(TreasureHuntDisplay, MapTutorialReference, ACCNCCEPFFE));
				list.Add(new LFCPHJHHOGP(TeamChestDisplay, MapTutorialReference, ACCNCCEPFFE));
				list.Add(new CICNNBBKKOM(TeamTournamentDisplay, MapTutorialReference, ACCNCCEPFFE));
				list.Add(new LNFMMHADOMD(false, ACCNCCEPFFE));
				return list;
			}
			list = new List<OOHGOOPDAEM>();
			list.Add(new KJONDCLCMHK(ACCNCCEPFFE));
			list.Add(new FKELDDNIIDI(this, StarCollectStartPosition.position, ACCNCCEPFFE));
			list.Add(new KHDAAMDEMBI(TreasureHuntDisplay, StarCollectStartPosition.position, ACCNCCEPFFE));
			list.Add(new GADNIEHOENP(dKIPEJPGACG, ACCNCCEPFFE));
			list.Add(new GCOPIPGDCBP(CurrentMapManager, StageButton, LevelButton, ACCNCCEPFFE));
			list.Add(new LOILCCLCILL(dKIPEJPGACG, aBJDELCBHCM, focusCounter, ACCNCCEPFFE));
			list.Add(new ENONBHFBODA(ToonChestDisplay, MapTutorialReference, ACCNCCEPFFE));
			list.Add(new FOJIFKGIDJN(ACCNCCEPFFE));
			list.Add(new FKLBKNGILLM(DailyBonusDisplay, MapTutorialReference, ACCNCCEPFFE));
			list.Add(new GEOHHDNOOEM(MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC(), ACCNCCEPFFE));
			list.Add(new DOKDGDIJFGA(ACCNCCEPFFE));
			list.Add(new LCBBCGAOLMK(ACCNCCEPFFE));
			list.Add(new JNBLANLHOMI(ACCNCCEPFFE));
			list.Add(new EIOJBFNGJMN(TreasureHuntDisplay, MapTutorialReference, ACCNCCEPFFE));
			list.Add(new LFCPHJHHOGP(TeamChestDisplay, MapTutorialReference, ACCNCCEPFFE));
			list.Add(new CICNNBBKKOM(TeamTournamentDisplay, MapTutorialReference, ACCNCCEPFFE));
			list.Add(new LNFMMHADOMD(false, ACCNCCEPFFE));
			list.Add(new MPJFFCOPDHO(ACCNCCEPFFE));
			list.Add(new GFIEJLKCDDD(CurrentMapManager, ACCNCCEPFFE));
			list.Add(new AFBFCOONECN(this, ACCNCCEPFFE));
			return list;
		}

		protected void CJGDCIOEJKB()
		{
			if (PEEAJDGKMFI < 0f)
			{
				DNLIMJIDCED();
			}
			Reset();
			if (OnAnimationCompleted != null)
			{
				OnAnimationCompleted();
			}
		}

		public void Reset()
		{
			LPIEKIDOGNI = false;
			LevelBuilder.LastLevel.OMOKOKFNBKI();
			CurrentMapManager.EnableTaps(true);
			MapTutorial.DidShowMapTutorialInCurrentFlow = false;
		}

		public void StartAnimationFlow()
		{
			if (!LPIEKIDOGNI && !LNGHOBJLPGL)
			{
				LPIEKIDOGNI = true;
				CurrentMapManager.EnableTaps(false);
				StartCoroutine(JDEHGPKCHCM());
			}
		}

		public bool StartAnimationFlowOnFocusIn()
		{
			if (LPIEKIDOGNI || LNGHOBJLPGL)
			{
				return false;
			}
			ABFNGEHFCIN = GEIBELODNON(true);
			PPGKDFKCIBG();
			if (FHAAAFAAMDO.GABGKBAKHDP.COCNAAGPOMN)
			{
				Dialog dialog = FHAAAFAAMDO.GABGKBAKHDP.NGIEPDBBJBP();
				if (dialog != null && dialog.CanBlockFocusAnimations())
				{
					if (IILDKKHLACP > 0)
					{
						dialog.DNADNGGDHKE = true;
					}
					dialog.FANPAGHELKE = true;
					return true;
				}
				return false;
			}
			LPIEKIDOGNI = true;
			CurrentMapManager.EnableTaps(false);
			APCJIGIMELI();
			return true;
		}

		private IEnumerator JDEHGPKCHCM()
		{
			int aMKOJOKCELO = NDGOJGLPIJF.GABGKBAKHDP.AMKOJOKCELO;
			int num = aMKOJOKCELO;
			int num2 = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(NAAHKHPBAPA.Stars);
			if (num2 > NDGOJGLPIJF.DGIKLPPBGHJ)
			{
				num = NDGOJGLPIJF.DGIKLPPBGHJ - (num2 - num);
			}
			StarChestDisplay.DecreaseStarCount(num);
			yield return MCJHHDACJBG.CHFOIGLAMPN;
			ABFNGEHFCIN = GEIBELODNON(false);
			PPGKDFKCIBG();
			APCJIGIMELI();
		}

		protected void ACCNCCEPFFE(bool ODCADGABBHJ)
		{
			if (CaravanSceneManager.CurrentScene != GKBHIKONCKJ.Map)
			{
				SpriteButtonListener.Instance.EnableClicks = true;
				return;
			}
			if (ODCADGABBHJ && ABFNGEHFCIN[LKEMPLLFFBJ].HDLHHPFDHIK())
			{
				BlockFacebookPopup = true;
			}
			LKEMPLLFFBJ++;
			if (LKEMPLLFFBJ < ABFNGEHFCIN.Count)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.MapAnimationController, "CURRENT: {0} NEXT:{1}", JMDDFDJGNNL.CENGNKJGOGP, ABFNGEHFCIN[LKEMPLLFFBJ].CENGNKJGOGP);
				if (JMDDFDJGNNL != null)
				{
					JMDDFDJGNNL.CECMINAKHFJ = null;
				}
				JMDDFDJGNNL = ABFNGEHFCIN[LKEMPLLFFBJ];
				try
				{
					KODMFPGMPNK(JMDDFDJGNNL.CENGNKJGOGP);
					JMDDFDJGNNL.GDGINCNCMDD(ODCADGABBHJ, MIKJJLEJACL());
					return;
				}
				catch (Exception ex)
				{
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.MapAnimationController, "Map Animation Exception : {0} {1}", ex.Message, ex.StackTrace);
					ACCNCCEPFFE(ODCADGABBHJ);
					return;
				}
			}
			CJGDCIOEJKB();
		}

		private void APCJIGIMELI()
		{
			LKEMPLLFFBJ = 0;
			JMDDFDJGNNL = ABFNGEHFCIN[LKEMPLLFFBJ];
			KODMFPGMPNK(JMDDFDJGNNL.CENGNKJGOGP);
			JMDDFDJGNNL.GDGINCNCMDD(true, MIKJJLEJACL());
		}

		private void PPGKDFKCIBG()
		{
			IILDKKHLACP = 0;
			BlockFacebookPopup = false;
			int count = ABFNGEHFCIN.Count;
			for (int num = count - 1; num >= 0; num--)
			{
				if (ABFNGEHFCIN[num].PPOCOCCKKFF())
				{
					IILDKKHLACP = num;
					break;
				}
			}
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.MapAnimationController, "Last Will Process index is: {0}", IILDKKHLACP);
		}

		private bool MIKJJLEJACL()
		{
			return IILDKKHLACP > LKEMPLLFFBJ;
		}
	}
}
