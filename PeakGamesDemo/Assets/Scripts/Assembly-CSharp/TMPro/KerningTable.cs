using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TMPro
{
	[Serializable]
	public class KerningTable
	{
		[CompilerGenerated]
		private sealed class GHOLAFEAJIK
		{
			internal int BICBELADBDI;

			internal int MPOPLONGCDK;

			internal bool AGFNGEFDHLA(KerningPair EJCNAJOHBFI)
			{
				return EJCNAJOHBFI.AscII_Left == BICBELADBDI && EJCNAJOHBFI.AscII_Right == MPOPLONGCDK;
			}
		}

		[CompilerGenerated]
		private sealed class PKEFIKPBIPP
		{
			internal int BICBELADBDI;

			internal int MPOPLONGCDK;

			internal bool AGFNGEFDHLA(KerningPair EJCNAJOHBFI)
			{
				return EJCNAJOHBFI.AscII_Left == BICBELADBDI && EJCNAJOHBFI.AscII_Right == MPOPLONGCDK;
			}
		}

		public List<KerningPair> kerningPairs;

		public KerningTable()
		{
			kerningPairs = new List<KerningPair>();
		}

		public void CJJMHNKOLOJ()
		{
			if (kerningPairs.Count == 0)
			{
				kerningPairs.Add(new KerningPair(0, 0, 0f));
				return;
			}
			int ascII_Left = kerningPairs.Last().AscII_Left;
			int ascII_Right = kerningPairs.Last().AscII_Right;
			float xadvanceOffset = kerningPairs.Last().XadvanceOffset;
			kerningPairs.Add(new KerningPair(ascII_Left, ascII_Right, xadvanceOffset));
		}

		public int CJJMHNKOLOJ(int BICBELADBDI, int MPOPLONGCDK, float IBNDGNOIEEF)
		{
			int num = kerningPairs.FindIndex((KerningPair EJCNAJOHBFI) => EJCNAJOHBFI.AscII_Left == BICBELADBDI && EJCNAJOHBFI.AscII_Right == MPOPLONGCDK);
			if (num == -1)
			{
				kerningPairs.Add(new KerningPair(BICBELADBDI, MPOPLONGCDK, IBNDGNOIEEF));
				return 0;
			}
			return -1;
		}

		public void DNOODBHLBIB(int BICBELADBDI, int MPOPLONGCDK)
		{
			int num = kerningPairs.FindIndex((KerningPair EJCNAJOHBFI) => EJCNAJOHBFI.AscII_Left == BICBELADBDI && EJCNAJOHBFI.AscII_Right == MPOPLONGCDK);
			if (num != -1)
			{
				kerningPairs.RemoveAt(num);
			}
		}

		public void DNOODBHLBIB(int EHJNMODJEAN)
		{
			kerningPairs.RemoveAt(EHJNMODJEAN);
		}

		public void JEAJDHEAMCP()
		{
			if (kerningPairs.Count > 0)
			{
				kerningPairs = (from IBBBMACIBGK in kerningPairs
					orderby IBBBMACIBGK.AscII_Left, IBBBMACIBGK.AscII_Right
					select IBBBMACIBGK).ToList();
			}
		}

		[CompilerGenerated]
		private static int MJLMBDKJKIJ(KerningPair IBBBMACIBGK)
		{
			return IBBBMACIBGK.AscII_Left;
		}

		[CompilerGenerated]
		private static int EPLGPMNAGIF(KerningPair IBBBMACIBGK)
		{
			return IBBBMACIBGK.AscII_Right;
		}
	}
}
