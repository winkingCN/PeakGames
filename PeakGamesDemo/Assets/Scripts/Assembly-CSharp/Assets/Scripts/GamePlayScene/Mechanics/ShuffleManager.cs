using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics
{
	public class ShuffleManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class FBPPEFFHFDD
		{
			internal LEDBLDKJBAI GHOFJGDALMF;

			internal List<Cell> HOEPJEMJABD;
		}

		[CompilerGenerated]
		private sealed class JLLGNGGJNOC
		{
			internal int CENDLOCLJBE;

			internal FBPPEFFHFDD FIABJICDDMO;

			internal bool AGFNGEFDHLA(APPKPDBOJIP AMFCENFNAJJ)
			{
				return AMFCENFNAJJ.LBFCDKPCDPB.GetMatchType() == FIABJICDDMO.GHOFJGDALMF;
			}

			internal bool KDACLOKGNAM(APPKPDBOJIP AMFCENFNAJJ)
			{
				return AMFCENFNAJJ.LBFCDKPCDPB.GetMatchType() == FIABJICDDMO.HOEPJEMJABD[CENDLOCLJBE].LBFCDKPCDPB.GetMatchType();
			}
		}

		private static ShuffleManager KNPOFJNFLJB;

		[CompilerGenerated]
		private static TweenCallback EBCOMJBLIPP;

		public void Awake()
		{
			KNPOFJNFLJB = this;
		}

		public void OnDestroy()
		{
			ResetSelf();
		}

		public void ResetSelf()
		{
			KNPOFJNFLJB = null;
		}

		public static bool TryShuffle(CFOIPDKEFMM GOAELFDHDGD)
		{
			return KNPOFJNFLJB != null && KNPOFJNFLJB.Shuffle(GOAELFDHDGD);
		}

		public bool Shuffle(CFOIPDKEFMM GOAELFDHDGD)
		{
			Dictionary<LEDBLDKJBAI, int> dictionary = new Dictionary<LEDBLDKJBAI, int>(new IIHIJPBAIHD());
			List<Cell> list = new List<Cell>();
			List<APPKPDBOJIP> list2 = new List<APPKPDBOJIP>();
			IEnumerator<Cell> enumerator = GOAELFDHDGD.IOFOFDLJDAA().GetEnumerator();
			while (enumerator.MoveNext())
			{
				Cell current = enumerator.Current;
				if (current.HasCellItem() || current.CGLFCDDLOKA || !current.EAILOFHFNJO || !current.LBFCDKPCDPB.CanShuffle())
				{
					continue;
				}
				list.Add(current);
				list2.Add(new APPKPDBOJIP(current.LBFCDKPCDPB, current));
				Item currentItem = current.LBFCDKPCDPB;
				LEDBLDKJBAI matchType = currentItem.GetMatchType();
				if (matchType != LEDBLDKJBAI.None)
				{
					if (!dictionary.ContainsKey(matchType))
					{
						dictionary[matchType] = 1;
					}
					else
					{
						dictionary[matchType]++;
					}
				}
			}
			LEDBLDKJBAI GHOFJGDALMF = LEDBLDKJBAI.None;
			List<LEDBLDKJBAI> list3 = new List<LEDBLDKJBAI>();
			bool flag = false;
			foreach (KeyValuePair<LEDBLDKJBAI, int> item3 in dictionary)
			{
				if (item3.Value >= 2)
				{
					list3.Add(item3.Key);
				}
			}
			int count = list3.Count;
			if (count > 0)
			{
				GHOFJGDALMF = list3[BFGGHJGIHLJ.FDFDDKBDPEG(0, count, 9)];
			}
			else
			{
				flag = true;
			}
			list.KFGEEKGAPDP(9);
			List<Cell> HOEPJEMJABD = new List<Cell>();
			bool flag2 = false;
			for (int i = 0; i < list.Count; i++)
			{
				if (flag2)
				{
					break;
				}
				Cell cell = list[i];
				Cell[] cachedNeigbours = cell.GetCachedNeigbours(false);
				if (cachedNeigbours.Length < 1)
				{
					continue;
				}
				HOEPJEMJABD.Clear();
				HOEPJEMJABD.Add(cell);
				int j = 0;
				for (int num = cachedNeigbours.Length; j < num; j++)
				{
					Cell cell2 = cachedNeigbours[j];
					if (!cell2.HasCellItem() && !cell2.CGLFCDDLOKA && cell2.EAILOFHFNJO && cell2.LBFCDKPCDPB.CanShuffle())
					{
						HOEPJEMJABD.Add(cell2);
						flag2 = true;
						break;
					}
				}
			}
			if (!flag2)
			{
				return false;
			}
			if (flag)
			{
				bool flag3 = HOEPJEMJABD[0].Y > HOEPJEMJABD[1].Y;
				int CENDLOCLJBE = ((!flag3) ? 1 : 0);
				int index = (flag3 ? 1 : 0);
				GHOFJGDALMF = HOEPJEMJABD[index].LBFCDKPCDPB.GetMatchType();
				APPKPDBOJIP item = list2.Find((APPKPDBOJIP AMFCENFNAJJ) => AMFCENFNAJJ.LBFCDKPCDPB.GetMatchType() == GHOFJGDALMF);
				APPKPDBOJIP item2 = list2.Find((APPKPDBOJIP AMFCENFNAJJ) => AMFCENFNAJJ.LBFCDKPCDPB.GetMatchType() == HOEPJEMJABD[CENDLOCLJBE].LBFCDKPCDPB.GetMatchType());
				item.LBFCDKPCDPB.DoShuffleAnimation(HOEPJEMJABD[CENDLOCLJBE], item.FKLPMDHOIJC, LEDBLDKJBAI.None);
				item2.LBFCDKPCDPB.DoShuffleAnimation(HOEPJEMJABD[index], item2.FKLPMDHOIJC, GHOFJGDALMF);
				list2.Remove(item);
				list2.Remove(item2);
			}
			else
			{
				foreach (Cell item4 in HOEPJEMJABD)
				{
					for (int num2 = list2.Count - 1; num2 >= 0; num2--)
					{
						if (list2[num2].LBFCDKPCDPB.GetMatchType() == GHOFJGDALMF)
						{
							list2[num2].LBFCDKPCDPB.DoShuffleAnimation(item4, list2[num2].FKLPMDHOIJC, LEDBLDKJBAI.None);
							list2.RemoveAt(num2);
							break;
						}
					}
				}
			}
			list.Remove(HOEPJEMJABD[0]);
			list.Remove(HOEPJEMJABD[1]);
			list2.KFGEEKGAPDP(9);
			if (list2.Count > 1)
			{
				for (int k = 0; k < list2.Count; k++)
				{
					if (list2[k].FKLPMDHOIJC == list[k])
					{
						int num3 = ((k <= 0) ? 1 : (-1));
						Cell value = list[k];
						list[k] = list[k + num3];
						list[k + num3] = value;
					}
				}
			}
			for (int l = 0; l < list2.Count; l++)
			{
				list2[l].LBFCDKPCDPB.DoShuffleAnimation(list[l], list2[l].FKLPMDHOIJC, list2[l].NBADKFFDBAD);
			}
			Sequence s = DOTween.Sequence();
			s.InsertCallback(0.8f, delegate
			{
				HintManager.Instance.EnableHints();
			});
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ShuffleManager, "Shuffle completed.");
			return true;
		}

		[CompilerGenerated]
		private static void FHNDALNNANN()
		{
			HintManager.Instance.EnableHints();
		}
	}
}
