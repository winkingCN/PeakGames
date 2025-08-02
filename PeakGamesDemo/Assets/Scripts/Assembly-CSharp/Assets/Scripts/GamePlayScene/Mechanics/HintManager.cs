using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.GamePlayScene.Mechanics.Items.SpecialItems;
using Assets.Scripts.GamePlayScene.Tutorials;
using Assets.Scripts.Utils;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics
{
	public class HintManager : MonoBehaviour
	{
		public static HintManager Instance;

		public LevelBuilder CurrentLevelBuilder;

		private readonly List<PBLOIKDOPAJ> EFLEMLKEDHC = new List<PBLOIKDOPAJ>(100);

		private KFCEILFGADG NLKHKDBCLMB;

		private bool FNABKLMJLBL = true;

		private bool NOOOJAGCLJC = true;

		private int CCABGAFOEAI;

		private bool GGDFKNPNNMO;

		private List<LEDBLDKJBAI> HEAOPNHKFJF;

		private int OJEDFIMPIEJ;

		private bool KCGAEFMKBLP;

		[HideInInspector]
		public bool ShouldCheckComboTutorial;

		public void IncreaseShuffleBlocker()
		{
			OJEDFIMPIEJ++;
		}

		public void DecreaseShuffleBlocker()
		{
			OJEDFIMPIEJ--;
		}

		public void Reset()
		{
			KCGAEFMKBLP = false;
			OJEDFIMPIEJ = 0;
		}

		public void Awake()
		{
			Instance = this;
			KCGAEFMKBLP = FNBPLBGNBNF.DMHOKIGLECN();
		}

		public void OnDestroy()
		{
			Instance = null;
		}

		internal static void INJHFIFHKOB()
		{
			Instance = null;
		}

		public void SceneReloadedSetups()
		{
			EFLEMLKEDHC.Clear();
			NLKHKDBCLMB = CurrentLevelBuilder.CurrentLevel;
			FNABKLMJLBL = true;
			NOOOJAGCLJC = true;
			CCABGAFOEAI = 0;
			GGDFKNPNNMO = NLKHKDBCLMB.PDGLECFDLJJ <= 5;
			UpdateGoalHints();
		}

		public void UpdateGoalHints()
		{
			if (!GGDFKNPNNMO)
			{
				return;
			}
			int count = NLKHKDBCLMB.JKKJLDLMIOG.Count;
			HEAOPNHKFJF = new List<LEDBLDKJBAI>(count);
			for (int i = 0; i < count; i++)
			{
				OGIFMLFEAEM oGIFMLFEAEM = NLKHKDBCLMB.JKKJLDLMIOG[i];
				if (oGIFMLFEAEM.GMCGMPEEHJP > 0)
				{
					HEAOPNHKFJF.Add(oGIFMLFEAEM.ENBPGGCIADN.OFBMGJCGHFE());
				}
			}
		}

		public void DisableHints()
		{
			FNABKLMJLBL = false;
		}

		public void EnableHints()
		{
			FNABKLMJLBL = true;
		}

		public void Update()
		{
			if (!FNABKLMJLBL || SlowCheckTime.ShouldPass() || (TutorialManager.TutorialActive && !TutorialManager.IsThereComboTutorial) || !LevelBuilder.IsLevelDataLoaded)
			{
				return;
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			try
			{
				CurrentLevelBuilder.CurrentLevel.JHDMFHDHIFN.DGINICFFFFP(EFLEMLKEDHC);
				int count = EFLEMLKEDHC.Count;
				for (int i = 0; i < count; i++)
				{
					PBLOIKDOPAJ pBLOIKDOPAJ = EFLEMLKEDHC[i];
					if (pBLOIKDOPAJ.IJILFJHCFKM)
					{
						num++;
					}
					if (pBLOIKDOPAJ.BFCMNIPBDIE.EAILOFHFNJO && pBLOIKDOPAJ.BFCMNIPBDIE.LBFCDKPCDPB.IsSpecialItem() && pBLOIKDOPAJ.BFCMNIPBDIE.LBFCDKPCDPB.IsActive)
					{
						num3++;
					}
					List<Cell> oABGDODKPKM = pBLOIKDOPAJ.OABGDODKPKM;
					bool flag = false;
					int j = 0;
					for (int count2 = oABGDODKPKM.Count; j < count2; j++)
					{
						Cell cell = oABGDODKPKM[j];
						if (!cell.EAILOFHFNJO)
						{
							continue;
						}
						if (NOOOJAGCLJC && cell.LBFCDKPCDPB.IsSpecialItem() && !cell.LBFCDKPCDPB.IsFalling)
						{
							((SpecialItem)cell.LBFCDKPCDPB).DisplayComboHint(pBLOIKDOPAJ.CPDGPBNOADK);
							flag = pBLOIKDOPAJ.CPDGPBNOADK;
							if (ShouldCheckComboTutorial && !KCGAEFMKBLP && !pBLOIKDOPAJ.GAPCCIILKLL && pBLOIKDOPAJ.CDAJIPHMCDN != 0 && pBLOIKDOPAJ.CDAJIPHMCDN != NOALGNJECAD.DoubleRocket)
							{
								KCGAEFMKBLP = true;
								NLKHKDBCLMB.GIMBEKBFKMJ.TryPlayComboItemTutorial(pBLOIKDOPAJ);
							}
						}
						if (!cell.LBFCDKPCDPB.CanBeMatchable())
						{
							continue;
						}
						SolidColorItem solidColorItem = cell.LBFCDKPCDPB as SolidColorItem;
						if (solidColorItem == null)
						{
							continue;
						}
						if (pBLOIKDOPAJ.FGOGPEOCNCK)
						{
							if (!pBLOIKDOPAJ.GAPCCIILKLL)
							{
								solidColorItem.UpdateSprites(pBLOIKDOPAJ.PNAMGKGHNCG);
							}
						}
						else
						{
							solidColorItem.UpdateSprites(NOALGNJECAD.None);
						}
					}
					if (flag)
					{
						num2++;
					}
				}
				num -= num2;
				if (NLKHKDBCLMB.NPMIKDPNBIA || FallManager.AreThereActiveAnimations() || FallManager.AreFallsBlocked() || NLMLKADGECN.GABGKBAKHDP.BPHMPBKJJOO().LBGEOEHBJNF() != 0)
				{
					return;
				}
				if (num == 0)
				{
					bool flag2 = OJEDFIMPIEJ == 0;
					foreach (Cell item in NLKHKDBCLMB.JHDMFHDHIFN.IOFOFDLJDAA())
					{
						if (item.CanItemsFallInside())
						{
							continue;
						}
						flag2 = false;
						break;
					}
					if (!flag2)
					{
						return;
					}
					DisableHints();
					if (!ShuffleManager.TryShuffle(NLKHKDBCLMB.JHDMFHDHIFN))
					{
						if (num3 > 0)
						{
							if (NLKHKDBCLMB.EBMFPDNPIEM > 0)
							{
								EnableHints();
							}
							else
							{
								NLKHKDBCLMB.DJFBMDLNFEC();
							}
						}
						else
						{
							NLKHKDBCLMB.BJNCBHLLIGH();
						}
					}
					else
					{
						LevelBuilder.LastLevel.KMBHLPKMOEC.JMIJKDGBCFP++;
					}
				}
				else if (NLKHKDBCLMB.EBMFPDNPIEM <= 0)
				{
					if (CCABGAFOEAI == Time.frameCount - 1)
					{
						DisableHints();
						NLKHKDBCLMB.DJFBMDLNFEC();
					}
					else
					{
						CCABGAFOEAI = Time.frameCount;
					}
				}
			}
			finally
			{
				int k = 0;
				for (int count3 = EFLEMLKEDHC.Count; k < count3; k++)
				{
					if (EFLEMLKEDHC[k] != null)
					{
						PBLOIKDOPAJ.HMKJAFHJMGN(EFLEMLKEDHC[k]);
					}
				}
				EFLEMLKEDHC.Clear();
			}
		}

		public void DisableComboHints()
		{
			NOOOJAGCLJC = false;
			foreach (Cell item in NLKHKDBCLMB.JHDMFHDHIFN.IOFOFDLJDAA())
			{
				if (item.EAILOFHFNJO && item.LBFCDKPCDPB.IsSpecialItem())
				{
					((SpecialItem)item.LBFCDKPCDPB).DisplayComboHint(false);
				}
			}
		}

		public void StopSpecialItemMarks()
		{
			foreach (Cell item in NLKHKDBCLMB.JHDMFHDHIFN.IOFOFDLJDAA())
			{
				if (item.EAILOFHFNJO)
				{
					SolidColorItem solidColorItem = item.LBFCDKPCDPB as SolidColorItem;
					if (!(solidColorItem == null))
					{
						solidColorItem.CurrentSpriteRenderer.sprite = SharedImageLibrary.Instance.SolidColorSprites[(int)solidColorItem.GetMatchType()];
					}
				}
			}
		}

		public void ResetComboFlag()
		{
			KCGAEFMKBLP = false;
		}
	}
}
