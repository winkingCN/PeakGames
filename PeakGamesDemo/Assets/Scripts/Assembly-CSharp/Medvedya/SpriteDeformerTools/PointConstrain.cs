using System.Collections.Generic;
using UnityEngine;

namespace Medvedya.SpriteDeformerTools
{
	[AddComponentMenu("Sprite Deformer/Point Constrain")]
	[ExecuteInEditMode]
	public class PointConstrain : MonoBehaviour
	{
		public string pointsName;

		private List<SpritePoint> JJJGMPMMJIN = new List<SpritePoint>();

		public Vector2 localOffset;

		public SpriteDeformer spriteDeformer;

		private void Start()
		{
			if (!(spriteDeformer == null))
			{
				EJDMPJCNCJB();
			}
		}

		private void EJDMPJCNCJB()
		{
			JJJGMPMMJIN.Clear();
			for (int i = 0; i < spriteDeformer.JJJGMPMMJIN.Count; i++)
			{
				SpritePoint spritePoint = spriteDeformer.JJJGMPMMJIN[i];
				if (spritePoint.name == pointsName)
				{
					JJJGMPMMJIN.Add(spritePoint);
				}
			}
		}

		private void Update()
		{
			if (spriteDeformer == null)
			{
				return;
			}
			if (Application.isEditor && !Application.isPlaying)
			{
				EJDMPJCNCJB();
			}
			if (JJJGMPMMJIN.Count != 0)
			{
				Vector2 zero = Vector2.zero;
				for (int i = 0; i < JJJGMPMMJIN.Count; i++)
				{
					SpritePoint spritePoint = JJJGMPMMJIN[i];
					zero += spriteDeformer.SpritePositionToLocal(spritePoint.spritePosition + spritePoint.offset2d);
				}
				zero /= (float)JJJGMPMMJIN.Count;
				zero += localOffset;
				Vector3 position = spriteDeformer.transform.TransformPoint(zero);
				position.z = base.transform.position.z;
				base.transform.position = position;
			}
		}
	}
}
