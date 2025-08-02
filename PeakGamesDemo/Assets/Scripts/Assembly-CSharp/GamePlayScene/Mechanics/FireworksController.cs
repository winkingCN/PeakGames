using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using GamePlayScene.Mechanics.Items;
using UnityEngine;

namespace GamePlayScene.Mechanics
{
	public class FireworksController : MonoBehaviour
	{
		private static FireworksController KNPOFJNFLJB;

		public const int NA = -1;

		public const int P0 = 0;

		public const int P0_Hinted = 1;

		public const int P1 = 2;

		public const int P1_Hinted = 3;

		public const int P2 = 4;

		public const int P2_Hinted = 5;

		private long IIDGGCLDMAJ;

		private CFOIPDKEFMM OELBDGFEGOI;

		private readonly List<Item> ONKOGFBFIML = new List<Item>();

		private readonly List<FireworksRocket> BGNBHNPBMAO = new List<FireworksRocket>();

		private readonly List<List<Item>> FDDEFBLIBCL = new List<List<Item>>
		{
			new List<Item>(),
			new List<Item>(),
			new List<Item>(),
			new List<Item>(),
			new List<Item>(),
			new List<Item>()
		};

		public CFOIPDKEFMM AHPHKOBCJHP
		{
			set
			{
				if (OELBDGFEGOI == null)
				{
					OELBDGFEGOI = value;
				}
			}
		}

		public static FireworksController GABGKBAKHDP
		{
			get
			{
				if (KNPOFJNFLJB != null)
				{
					return KNPOFJNFLJB;
				}
				GameObject gameObject = new GameObject();
				gameObject.AddComponent<FireworksController>();
				KNPOFJNFLJB = gameObject.GetComponent<FireworksController>();
				return KNPOFJNFLJB;
			}
		}

		public void RegisterToy(Item EJCNAJOHBFI)
		{
			ONKOGFBFIML.Add(EJCNAJOHBFI);
		}

		public bool IsUnderToy(Cell LBHDELJBONF)
		{
			int i = 0;
			for (int count = ONKOGFBFIML.Count; i < count; i++)
			{
				Item item = ONKOGFBFIML[i];
				if (!(item == null))
				{
					Cell currentCell = item.ENCFFNKONOO;
					if (!(currentCell == null) && currentCell.X == LBHDELJBONF.X && currentCell.Y > LBHDELJBONF.Y)
					{
						return true;
					}
				}
			}
			return false;
		}

		public void RegisterRocket(FireworksRocket JACLFODHGCK)
		{
			Item item = INDKJKONOFA();
			if (item == null)
			{
				JACLFODHGCK.Recycle();
				return;
			}
			BGNBHNPBMAO.Add(JACLFODHGCK);
			Item masterTarget = item.GetMasterTarget();
			if (masterTarget == null)
			{
				JACLFODHGCK.SetTargetCell(item.ENCFFNKONOO);
			}
			else
			{
				JACLFODHGCK.SetTargetItem(masterTarget);
			}
		}

		private Item INDKJKONOFA()
		{
			if (IIDGGCLDMAJ != Time.frameCount)
			{
				DAEMDCHPLDJ();
			}
			for (int i = 0; i <= 5; i++)
			{
				List<Item> list = FDDEFBLIBCL[i];
				if (list.Count > 0)
				{
					Item item = IGCIPDBHBEF(i, list);
					if (!(item == null))
					{
						return item;
					}
				}
			}
			return null;
		}

		private Item IGCIPDBHBEF(int JCAPEOMBCIB, List<Item> PNKBIONHGEJ)
		{
			int count = PNKBIONHGEJ.Count;
			int index = BFGGHJGIHLJ.FDFDDKBDPEG(0, count, 14);
			Item item = PNKBIONHGEJ[index];
			for (int fireworksPriority = item.GetFireworksPriority(); fireworksPriority != JCAPEOMBCIB; fireworksPriority = item.GetFireworksPriority())
			{
				PNKBIONHGEJ.RemoveAt(index);
				BOHEJMABOMA(fireworksPriority, item);
				count = PNKBIONHGEJ.Count;
				if (count <= 0)
				{
					return null;
				}
				index = BFGGHJGIHLJ.FDFDDKBDPEG(0, count, 14);
				item = PNKBIONHGEJ[index];
			}
			int num = item.SelectedByFireworks();
			if (num != JCAPEOMBCIB)
			{
				PNKBIONHGEJ.RemoveAt(index);
				BOHEJMABOMA(num, item);
			}
			return item;
		}

		private void DAEMDCHPLDJ()
		{
			AAFBIJOCEEP();
			foreach (Cell item in OELBDGFEGOI.IOFOFDLJDAA())
			{
				if (item.HasCellItem())
				{
					BOHEJMABOMA(item.FEMFMBLMKHP);
				}
				else if (item.EAILOFHFNJO)
				{
					BOHEJMABOMA(item.LBFCDKPCDPB);
				}
			}
			IIDGGCLDMAJ = Time.frameCount;
		}

		private void BOHEJMABOMA(Item EJCNAJOHBFI)
		{
			BOHEJMABOMA(EJCNAJOHBFI.GetFireworksPriority(), EJCNAJOHBFI);
		}

		private void BOHEJMABOMA(int DDEFKNMBKKI, Item EJCNAJOHBFI)
		{
			if (DDEFKNMBKKI != -1)
			{
				FDDEFBLIBCL[DDEFKNMBKKI].Add(EJCNAJOHBFI);
			}
		}

		private void Update()
		{
			if (SlowCheckTime.ShouldPass())
			{
				return;
			}
			for (int num = BGNBHNPBMAO.Count - 1; num >= 0; num--)
			{
				FireworksRocket fireworksRocket = BGNBHNPBMAO[num];
				if (!(fireworksRocket == null) && fireworksRocket.UpdateRocket())
				{
					BGNBHNPBMAO.RemoveAt(num);
				}
			}
		}

		private void AAFBIJOCEEP()
		{
			for (int i = 0; i <= 5; i++)
			{
				FDDEFBLIBCL[i].Clear();
			}
		}

		private void Reset()
		{
			ONKOGFBFIML.Clear();
			BGNBHNPBMAO.Clear();
			OELBDGFEGOI = null;
		}

		public static void ResetSelf()
		{
			if (!(KNPOFJNFLJB == null))
			{
				KNPOFJNFLJB.Reset();
			}
		}

		public void ClearRockets()
		{
			for (int num = BGNBHNPBMAO.Count - 1; num >= 0; num--)
			{
				FireworksRocket fireworksRocket = BGNBHNPBMAO[num];
				if (!(fireworksRocket == null))
				{
					fireworksRocket.Recycle();
				}
			}
		}
	}
}
