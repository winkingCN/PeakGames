using System;

namespace TMPro
{
	[Serializable]
	public class KerningPair
	{
		public int AscII_Left;

		public int AscII_Right;

		public float XadvanceOffset;

		public KerningPair(int BICBELADBDI, int MPOPLONGCDK, float IBNDGNOIEEF)
		{
			AscII_Left = BICBELADBDI;
			AscII_Right = MPOPLONGCDK;
			XadvanceOffset = IBNDGNOIEEF;
		}
	}
}
