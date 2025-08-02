using System;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	public struct VertexGradient
	{
		public Color topLeft;

		public Color topRight;

		public Color bottomLeft;

		public Color bottomRight;

		public VertexGradient(Color MFODILBOMGD)
		{
			topLeft = MFODILBOMGD;
			topRight = MFODILBOMGD;
			bottomLeft = MFODILBOMGD;
			bottomRight = MFODILBOMGD;
		}

		public VertexGradient(Color NCLDEMHELGM, Color CHHKFHFCDHP, Color PJNBMNFHMPC, Color OENFOHCGDOG)
		{
			topLeft = NCLDEMHELGM;
			topRight = CHHKFHFCDHP;
			bottomLeft = PJNBMNFHMPC;
			bottomRight = OENFOHCGDOG;
		}
	}
}
