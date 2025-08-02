using System;
using System.Collections;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.MapScene;
using CasualTools.Dialogs;
using MapScene;
using UnityEngine;

namespace NewMapScene
{
	public class NewMapPage : MonoBehaviour
	{
		public static Vector3 CoinAnimationStartPosition;

		public bool IsReady;

		public SpriteRenderer BackgroundImage;

		public Transform Container;

		public MapManager CurrentMapManager;

		public LevelButton LevelButton;

		public Transform BottomContainer;

		public Transform TopContainer;

		public ToonChestDisplay ToonChestDisplay;

		public CLStageButton CLStageButton;

		public CLRankDisplay CLRankDisplay;

		public CrownRushDisplay CrownRushDisplay;

		public DailyBonusDisplay DailyBonusDisplay;

		public TeamChestDisplay TeamChestDisplay;

		public StarTournamentDisplay StarTournamentDisplay;

		public TeamTournamentDisplay TeamTournamentDisplay;

		public TreasureHuntDisplay TreasureHuntDisplay;

		private float HPDLLEPFGPC;

		public Sprite EINEBDMKFPJ { get; private set; }

		public LevelButton DOBKHAACPNP
		{
			get
			{
				return (!CLStageButton.gameObject.activeInHierarchy) ? LevelButton : CLStageButton;
			}
		}

		public void LoadMapAsset(int BDKFNEDHAOJ, Action<bool> HLOAGGCGKEG)
		{
			IsReady = false;
			string text = BDKFNEDHAOJ.ToString();
			if (EINEBDMKFPJ != null && EINEBDMKFPJ.name == text)
			{
				if (HLOAGGCGKEG != null)
				{
					HLOAGGCGKEG(false);
				}
				IsReady = true;
			}
			else
			{
				StartCoroutine(PIDCNIFENDA(text, HLOAGGCGKEG));
			}
		}

		private IEnumerator PIDCNIFENDA(string CHHHPCOIFJJ, Action<bool> IMHLFAHONPP)
		{
			IMINNGDLCCE iMINNGDLCCE = new IMINNGDLCCE();
			iMINNGDLCCE.FBOLKDLOGKP(CHHHPCOIFJJ);
			while (!iMINNGDLCCE.DCKHOAHIFDH)
			{
				yield return null;
			}
			OCJIMKMCCPD oCJIMKMCCPD = OCJIMKMCCPD.CGPEONBEMMM(CHHHPCOIFJJ, "NewMap");
			while (!oCJIMKMCCPD.DCKHOAHIFDH)
			{
				yield return null;
			}
			UnityEngine.Object.Destroy(EINEBDMKFPJ);
			AsyncOperation asyncOperation = Resources.UnloadUnusedAssets();
			while (!asyncOperation.isDone)
			{
				yield return null;
			}
			EINEBDMKFPJ = oCJIMKMCCPD.BBOBCJAHPJM;
			MapManager.CurrentMapId = EINEBDMKFPJ.name;
			if (IMHLFAHONPP != null)
			{
				IMHLFAHONPP(true);
			}
			IsReady = true;
		}

		public void Prepare(int KIGOGMKCDKN, float HJLOCAEAFMJ)
		{
			HPDLLEPFGPC = HJLOCAEAFMJ;
			Container.transform.localScale = Vector3.one * HPDLLEPFGPC;
			LevelButton.PrepareButton(KIGOGMKCDKN, CurrentMapManager);
			LevelButton.UpdateLevelButton(!LevelBuilder.LastLevel.HLFNDDEDJOI || IDFPAFEJPPH.GABGKBAKHDP.HGNJBHGBLIN || ELBMHNOBHPN.DJGMHLLAGLE);
			TopContainer.localScale = Vector3.one * HJLOCAEAFMJ;
			BottomContainer.localScale = Vector3.one * HJLOCAEAFMJ;
			float heightOfTopPanel = MapManager.Instance.CurrentCameraSizer.HeightOfTopPanel;
			float heightOfBottomPanel = MapManager.Instance.CurrentCameraSizer.HeightOfBottomPanel;
			heightOfTopPanel += ONCMBJKLKIL.GNGIGAPBFCN.ECLBGPBLGMD;
			heightOfBottomPanel += ONCMBJKLKIL.GNGIGAPBFCN.HINDAIPFFJL;
			float y = 0f - CurrentMapManager.CurrentCamera.orthographicSize + heightOfBottomPanel + 0.72f;
			float y2 = CurrentMapManager.CurrentCamera.orthographicSize - heightOfTopPanel + ((!ONCMBJKLKIL.PEFHCKMBHOM) ? 0.1f : (-0.1f));
			BottomContainer.transform.localPosition = new Vector3(0f, y, 0f);
			TopContainer.transform.localPosition = new Vector3(0f, y2, 0f);
			float y3 = ONCMBJKLKIL.FHAMOHDEGMK / HJLOCAEAFMJ - (CurrentMapManager.CurrentCameraSizer.HeightOfTopPanel - CurrentMapManager.CurrentCameraSizer.HeightOfBottomPanel) - 9f;
			BoxCollider2D component = BackgroundImage.GetComponent<BoxCollider2D>();
			component.size = new Vector2(10.24f, y3);
			component.offset = new Vector2(0f, 0.4f);
			CMEIBJNPAAF();
		}

		public void PrepareMapDisplays(bool MKKIIJLAKNP)
		{
			CrownRushDisplay.Prepare();
			DailyBonusDisplay.Prepare();
			TeamChestDisplay.Prepare();
			StarTournamentDisplay.Prepare();
			TeamTournamentDisplay.Prepare();
			TreasureHuntDisplay.Prepare();
			if (!CurrentMapManager.CurrentNewMapAnimationController.LPIEKIDOGNI)
			{
				PrepareChampionsLeagueDisplay(MKKIIJLAKNP);
			}
		}

		public void PrepareChampionsLeagueDisplay(bool MKKIIJLAKNP)
		{
			IDFPAFEJPPH iDFPAFEJPPH = IDFPAFEJPPH.GABGKBAKHDP;
			LevelButton.gameObject.SetActive(!MKKIIJLAKNP);
			CLStageButton.gameObject.SetActive(MKKIIJLAKNP);
			if (MKKIIJLAKNP || iDFPAFEJPPH.OFGLLFMFMHB())
			{
				CLRankDisplay.Activate(true, MKKIIJLAKNP);
				ToonChestDisplay.gameObject.SetActive(false);
			}
			else
			{
				CLRankDisplay.Activate(false, false);
				ToonChestDisplay.gameObject.SetActive(true);
			}
			if (!MKKIIJLAKNP)
			{
				LevelButton.UpdateLevelButton(!LevelBuilder.LastLevel.HLFNDDEDJOI || ELBMHNOBHPN.DJGMHLLAGLE);
				return;
			}
			CLStageButton.PrepareButton(iDFPAFEJPPH.PDGLECFDLJJ, CurrentMapManager);
			CLStageButton.UpdateLevelButton(!LevelBuilder.LastLevel.HLFNDDEDJOI || ELBMHNOBHPN.DJGMHLLAGLE);
		}

		private void CMEIBJNPAAF()
		{
			CoinAnimationStartPosition = LevelButton.transform.position;
			CoinAnimationStartPosition.y += 2.5f;
		}

		private void OnApplicationPause(bool APMMLLCMAKI)
		{
			if (!APMMLLCMAKI)
			{
				PrepareMapDisplays(IDFPAFEJPPH.GABGKBAKHDP.HGNJBHGBLIN);
			}
		}
	}
}
