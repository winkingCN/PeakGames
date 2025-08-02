using System;
using UnityEngine;

namespace Medvedya.SpriteDeformerTools
{
	[Serializable]
	public class SpritePoint
	{
		[SerializeField]
		private int _countOfOfsset = 1;

		[SerializeField]
		private int _index;

		public Vector2 spritePosition;

		public Color color;

		public Vector3 normal;

		public string name = "point";

		public Vector3[] offsets = new Vector3[1];

		public Vector2 colliderOffset = Vector2.zero;

		public int id;

		public int countOfOfsset
		{
			get
			{
				return _countOfOfsset;
			}
			set
			{
				if (value != _countOfOfsset)
				{
					Array.Resize(ref offsets, value);
					if (value > countOfOfsset && value > 1)
					{
						offsets[value - 1] = offsets[value - 2];
					}
					_countOfOfsset = value;
				}
			}
		}

		public int index
		{
			get
			{
				return _index;
			}
			set
			{
				_index = value;
			}
		}

		public Vector3 offset
		{
			get
			{
				return offsets[_index];
			}
			set
			{
				offsets[_index] = value;
			}
		}

		public Vector2 offset2d
		{
			get
			{
				return offsets[_index];
			}
			set
			{
				Vector3 vector = offsets[_index];
				vector.x = value.x;
				vector.y = value.y;
				offsets[_index] = vector;
			}
		}

		public SpritePoint(Vector2 LDMDBPLADGD, Color? MFODILBOMGD = null)
		{
			spritePosition = LDMDBPLADGD;
			color = ((!MFODILBOMGD.HasValue) ? Color.white : MFODILBOMGD.Value);
		}

		public SpritePoint(float AMFCENFNAJJ, float CNLILOEEBOJ)
		{
			spritePosition = new Vector2(AMFCENFNAJJ, CNLILOEEBOJ);
			color = Color.white;
		}
	}
}
