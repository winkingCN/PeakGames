using System;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	public class TMP_ColorGradient : ScriptableObject
	{
		public Color topLeft;

		public Color topRight;

		public Color bottomLeft;

		public Color bottomRight;

		public TMP_ColorGradient()
		{
			bottomRight = (bottomLeft = (topRight = (topLeft = Color.white)));
		}

		public TMP_ColorGradient(Color MFODILBOMGD)
		{
			topLeft = MFODILBOMGD;
			topRight = MFODILBOMGD;
			bottomLeft = MFODILBOMGD;
			bottomRight = MFODILBOMGD;
		}

		public TMP_ColorGradient(Color NCLDEMHELGM, Color CHHKFHFCDHP, Color PJNBMNFHMPC, Color OENFOHCGDOG)
		{
			topLeft = NCLDEMHELGM;
			topRight = CHHKFHFCDHP;
			bottomLeft = PJNBMNFHMPC;
			bottomRight = OENFOHCGDOG;
		}
	}
}
