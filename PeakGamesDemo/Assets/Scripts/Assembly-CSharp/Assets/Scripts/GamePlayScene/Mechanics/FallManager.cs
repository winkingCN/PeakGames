using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics
{
	public class FallManager : MonoBehaviour
	{
		public Transform FallReference;

		public HintManager CurrentHintManager;

		public LevelBuilder CurrentLevelBuilder;

		public static FallManager Instance;

		private CFOIPDKEFMM ODEJCIOOEHC;

		private KFCEILFGADG NLKHKDBCLMB;

		private Cell[] PCNJDGLALEA;

		private Cell[] KFOGAMACJBL;

		private int JBLLNCPMMJL;

		private int AKMKGKINHIG;

		private int GNFDHEGLIAD;

		private int BKLJLCPLJDE;

		private bool KODFEEABHNL;

		private float EAIBIGCLGPF;

		private float KNCPHAJDLAH;

		public void Awake()
		{
			Instance = this;
		}

		public void Start()
		{
			EAIBIGCLGPF = FallReference.position.y;
			KNCPHAJDLAH = EAIBIGCLGPF - 0.2f;
		}

		public static void ResetSelf()
		{
			Instance = null;
		}

		public static bool AreFallsBlocked()
		{
			if (Instance == null)
			{
				return false;
			}
			return Instance.BKLJLCPLJDE > 0;
		}

		public void OnDestroy()
		{
			ResetSelf();
		}

		public void SceneReloadedSetups()
		{
			NLKHKDBCLMB = CurrentLevelBuilder.CurrentLevel;
			ODEJCIOOEHC = NLKHKDBCLMB.JHDMFHDHIFN;
			KODFEEABHNL = false;
			BKLJLCPLJDE = 0;
			GNFDHEGLIAD = 0;
			AKMKGKINHIG = 0;
			JBLLNCPMMJL = 0;
			List<Cell> list = new List<Cell>(90);
			List<Cell> list2 = new List<Cell>(45);
			foreach (Cell item in ODEJCIOOEHC.IOFOFDLJDAA())
			{
				list.Add(item);
				if (item.IsFilling)
				{
					list2.Add(item);
				}
			}
			KFOGAMACJBL = list.ToArray();
			PCNJDGLALEA = list2.ToArray();
		}

		public static void SnapshotRecoveredSetups()
		{
			if (!(Instance == null))
			{
				Instance.JBLLNCPMMJL = 0;
				Instance.AKMKGKINHIG = 0;
			}
		}

		public void Update()
		{
			if (!KODFEEABHNL || NLKHKDBCLMB == null || BKLJLCPLJDE > 0)
			{
				return;
			}
			for (int i = 0; i < KFOGAMACJBL.Length; i++)
			{
				Cell cell = KFOGAMACJBL[i];
				if (cell.EAILOFHFNJO && cell.CanItemFallFromThisCell())
				{
					Cell firstExistingBottomCell = cell.FirstExistingBottomCell;
					if (DPKPCPHOILG(firstExistingBottomCell) && !firstExistingBottomCell.EAILOFHFNJO && firstExistingBottomCell.CanItemsFallInside())
					{
						GPEEPAILONB(cell, firstExistingBottomCell);
					}
				}
			}
			for (int j = 0; j < PCNJDGLALEA.Length; j++)
			{
				Cell cell2 = PCNJDGLALEA[j];
				if (cell2.EAILOFHFNJO || !cell2.CanItemFallFromThisCell() || !cell2.CanItemsFallInside())
				{
					continue;
				}
				Item item = cell2.CreateRefillItem();
				if (item == null || item.ReCycled)
				{
					continue;
				}
				cell2.LBFCDKPCDPB = item;
				item.FilledNewly = true;
				Vector3 frozenPosition = cell2.GetFrozenPosition();
				Cell firstExistingBottomCell2 = cell2.FirstExistingBottomCell;
				bool flag = true;
				if (firstExistingBottomCell2 != null && firstExistingBottomCell2.EAILOFHFNJO && firstExistingBottomCell2.LBFCDKPCDPB.IsFalling && firstExistingBottomCell2.LBFCDKPCDPB.FilledNewly)
				{
					FallAnimation currentFallAnimation = firstExistingBottomCell2.LBFCDKPCDPB.CurrentFallAnimation;
					if (currentFallAnimation != null)
					{
						Vector3 position = firstExistingBottomCell2.LBFCDKPCDPB.transform.position;
						if (position.y > KNCPHAJDLAH)
						{
							flag = false;
							frozenPosition.y = position.y + 1f;
							item.transform.position = frozenPosition;
							item.AppendFallAnimation(cell2);
						}
					}
				}
				if (flag)
				{
					frozenPosition.y = EAIBIGCLGPF;
					item.transform.position = frozenPosition;
					item.AppendFallAnimation(cell2);
				}
			}
		}

		private void GPEEPAILONB(Cell JHCKBLCPDPP, Cell FIICENBDLDC)
		{
			JHCKBLCPDPP.UpdateFall(FIICENBDLDC);
			JHCKBLCPDPP.LBFCDKPCDPB.IsFalling = true;
			JHCKBLCPDPP.LBFCDKPCDPB.AppendFallAnimation(FIICENBDLDC);
			FIICENBDLDC.LBFCDKPCDPB = JHCKBLCPDPP.LBFCDKPCDPB;
		}

		private static bool DPKPCPHOILG(Cell EAPKIIBJENG)
		{
			return EAPKIIBJENG != null && EAPKIIBJENG.Exists;
		}

		public static bool AreThereFallingItems()
		{
			if (Instance == null)
			{
				return false;
			}
			return Instance.GNFDHEGLIAD > 0;
		}

		public static bool AreThereMechanicAnimations()
		{
			if (Instance == null)
			{
				return false;
			}
			return Instance.JBLLNCPMMJL > 0;
		}

		public static bool AreThereActiveAnimations()
		{
			if (Instance == null)
			{
				return false;
			}
			return Instance.GNFDHEGLIAD > 0 || Instance.JBLLNCPMMJL > 0 || Instance.AKMKGKINHIG > 0;
		}

		public static void DecreaseMechanicAnimation()
		{
			if (Instance != null)
			{
				Instance.JBLLNCPMMJL--;
			}
		}

		public static void IncreaseMechanicAnimation()
		{
			if (Instance != null)
			{
				Instance.JBLLNCPMMJL++;
			}
		}

		public static void DecreaseStatAnimation()
		{
			if (Instance != null)
			{
				Instance.AKMKGKINHIG--;
			}
		}

		public static void IncreaseStatAnimation()
		{
			if (Instance != null)
			{
				Instance.AKMKGKINHIG++;
			}
		}

		public static void AddOneFall()
		{
			if (Instance != null)
			{
				Instance.GNFDHEGLIAD++;
			}
		}

		public static void RemoveOneFall()
		{
			if (!(Instance == null))
			{
				Instance.GNFDHEGLIAD--;
				if (Instance.GNFDHEGLIAD < 0)
				{
					Instance.GNFDHEGLIAD = 0;
				}
			}
		}

		public static void IncreaseWaitingFallBlocker()
		{
			if (Instance != null)
			{
				Instance.BKLJLCPLJDE++;
			}
		}

		public static void DecreaseWaitingFallBlocker()
		{
			if (!(Instance == null))
			{
				Instance.BKLJLCPLJDE--;
				if (Instance.BKLJLCPLJDE < 0)
				{
					Instance.BKLJLCPLJDE = 0;
				}
			}
		}

		public static void StartRunning()
		{
			if (!(Instance == null))
			{
				Instance.KODFEEABHNL = true;
			}
		}
	}
}
