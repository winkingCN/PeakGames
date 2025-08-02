using System;
using UnityEngine;

namespace Medvedya.SpriteDeformerTools
{
	[Serializable]
	public class Edge
	{
		public SpritePoint point1;

		public SpritePoint point2;

		public Edge(SpritePoint BEGCLEDLFOO, SpritePoint LGKCEADGHNL)
		{
			point1 = BEGCLEDLFOO;
			point2 = LGKCEADGHNL;
		}

		public Vector2 GOEBMAFKEEG(Vector2 KJPPPBMDJKG)
		{
			Vector2 vector = point2.spritePosition - point1.spritePosition;
			float num = vector.x * vector.x + vector.y * vector.y;
			float num2 = Mathf.Clamp01(((KJPPPBMDJKG.x - point1.spritePosition.x) * vector.x + (KJPPPBMDJKG.y - point1.spritePosition.y) * vector.y) / num);
			return point1.spritePosition + num2 * vector;
		}

		public bool GKMPJGIJPPO(SpritePoint HPHBDNBJPHB)
		{
			return HPHBDNBJPHB == point1 || HPHBDNBJPHB == point2;
		}
	}
}
