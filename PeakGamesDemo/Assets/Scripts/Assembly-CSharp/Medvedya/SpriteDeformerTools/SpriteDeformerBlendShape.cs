using System;
using UnityEngine;

namespace Medvedya.SpriteDeformerTools
{
	[AddComponentMenu("Sprite Deformer/Sprite deformer blend shape")]
	[ExecuteInEditMode]
	public class SpriteDeformerBlendShape : SpriteDeformerWithMaterialPropertyBlock
	{
		[SerializeField]
		private int _countOfShapes = 1;

		[SerializeField]
		private float[] _blendValues = new float[1];

		public int DPAJBIPHGEO
		{
			get
			{
				return _countOfShapes;
			}
			set
			{
				if (value != _countOfShapes)
				{
					Array.Resize(ref _blendValues, value);
					_countOfShapes = value;
				}
			}
		}

		public float[] CGNICGNBICP
		{
			get
			{
				return _blendValues;
			}
		}

		public override void AddPoint(SpritePoint KJPPPBMDJKG, bool NJMABEFFHDM = false)
		{
			KJPPPBMDJKG.countOfOfsset = DPAJBIPHGEO;
			int index = 0;
			if (base.JJJGMPMMJIN.Count > 0)
			{
				index = base.JJJGMPMMJIN[0].index;
			}
			KJPPPBMDJKG.index = index;
			base.AddPoint(KJPPPBMDJKG, NJMABEFFHDM);
		}

		protected override void Awake()
		{
			base.Awake();
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
		}

		protected override void OnEnable()
		{
			base.OnEnable();
		}

		protected override void OnDisable()
		{
			base.OnDisable();
		}

		protected override void Update()
		{
			base.Update();
		}

		public Vector2 getPointBlendOffset(SpritePoint KJPPPBMDJKG)
		{
			Vector2 result = KJPPPBMDJKG.offsets[0];
			for (int i = 0; i < DPAJBIPHGEO; i++)
			{
				float t = _blendValues[i];
				result += Vector2.Lerp(KJPPPBMDJKG.offsets[0], KJPPPBMDJKG.offsets[i + 1], t) - (Vector2)KJPPPBMDJKG.offsets[0];
			}
			return result;
		}

		public void SetBlendShapeWeight(int EHJNMODJEAN, float EDDNOJDPMCF)
		{
			if (_blendValues[EHJNMODJEAN] != EDDNOJDPMCF)
			{
				_blendValues[EHJNMODJEAN] = EDDNOJDPMCF;
				dirty_offset = true;
				dirty_collider = true;
			}
		}

		public override Vector2 getSpritePositionOfSpritePoint(SpritePoint KJPPPBMDJKG)
		{
			KJPPPBMDJKG.countOfOfsset = DPAJBIPHGEO + 1;
			return KJPPPBMDJKG.spritePosition + getPointBlendOffset(KJPPPBMDJKG);
		}
	}
}
