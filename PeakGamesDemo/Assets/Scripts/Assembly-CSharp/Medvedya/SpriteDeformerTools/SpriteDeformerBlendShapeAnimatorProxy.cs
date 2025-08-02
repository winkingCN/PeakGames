using UnityEngine;

namespace Medvedya.SpriteDeformerTools
{
	[ExecuteInEditMode]
	[AddComponentMenu("Sprite Deformer/Sprite deformer blend shape Animator proxy")]
	public class SpriteDeformerBlendShapeAnimatorProxy : MonoBehaviour
	{
		[Range(0f, 1f)]
		public float value_00;

		[Range(0f, 1f)]
		public float value_01;

		[Range(0f, 1f)]
		public float value_02;

		[Range(0f, 1f)]
		public float value_03;

		[Range(0f, 1f)]
		public float value_04;

		[Range(0f, 1f)]
		public float value_05;

		[Range(0f, 1f)]
		public float value_06;

		[Range(0f, 1f)]
		public float value_07;

		[Range(0f, 1f)]
		public float value_08;

		[Range(0f, 1f)]
		public float value_09;

		[Range(0f, 1f)]
		public float value_10;

		[Range(0f, 1f)]
		public float value_11;

		[Range(0f, 1f)]
		public float value_12;

		[Range(0f, 1f)]
		public float value_13;

		[Range(0f, 1f)]
		public float value_14;

		[Range(0f, 1f)]
		public float value_15;

		[Range(0f, 1f)]
		public float value_16;

		[Range(0f, 1f)]
		public float value_17;

		[Range(0f, 1f)]
		public float value_18;

		[Range(0f, 1f)]
		public float value_19;

		[Range(0f, 1f)]
		public float value_20;

		public SpriteDeformerBlendShape spriteDeformerBlendShape;

		private void Start()
		{
			spriteDeformerBlendShape = GetComponent<SpriteDeformerBlendShape>();
		}

		private void Update()
		{
			if (spriteDeformerBlendShape == null)
			{
				spriteDeformerBlendShape = GetComponent<SpriteDeformerBlendShape>();
				if (spriteDeformerBlendShape == null)
				{
					return;
				}
			}
			int num = spriteDeformerBlendShape.DPAJBIPHGEO;
			if (num > 20)
			{
				num = 20;
			}
			for (int i = 0; i < num; i++)
			{
				spriteDeformerBlendShape.SetBlendShapeWeight(i, getValueByIndex(i));
			}
			for (int j = num; j < 20; j++)
			{
				setValueByIndex(j, 0f);
			}
		}

		public void setValueByIndex(int EHJNMODJEAN, float EDDNOJDPMCF)
		{
			switch (EHJNMODJEAN)
			{
			case 0:
				value_00 = EDDNOJDPMCF;
				break;
			case 1:
				value_01 = EDDNOJDPMCF;
				break;
			case 2:
				value_02 = EDDNOJDPMCF;
				break;
			case 3:
				value_03 = EDDNOJDPMCF;
				break;
			case 4:
				value_04 = EDDNOJDPMCF;
				break;
			case 5:
				value_05 = EDDNOJDPMCF;
				break;
			case 6:
				value_06 = EDDNOJDPMCF;
				break;
			case 7:
				value_07 = EDDNOJDPMCF;
				break;
			case 8:
				value_08 = EDDNOJDPMCF;
				break;
			case 9:
				value_09 = EDDNOJDPMCF;
				break;
			case 10:
				value_10 = EDDNOJDPMCF;
				break;
			case 11:
				value_11 = EDDNOJDPMCF;
				break;
			case 12:
				value_12 = EDDNOJDPMCF;
				break;
			case 13:
				value_13 = EDDNOJDPMCF;
				break;
			case 14:
				value_14 = EDDNOJDPMCF;
				break;
			case 15:
				value_15 = EDDNOJDPMCF;
				break;
			case 16:
				value_16 = EDDNOJDPMCF;
				break;
			case 17:
				value_17 = EDDNOJDPMCF;
				break;
			case 18:
				value_18 = EDDNOJDPMCF;
				break;
			case 19:
				value_19 = EDDNOJDPMCF;
				break;
			case 20:
				value_20 = EDDNOJDPMCF;
				break;
			}
		}

		public float getValueByIndex(int EHJNMODJEAN)
		{
			switch (EHJNMODJEAN)
			{
			case 0:
				return value_00;
			case 1:
				return value_01;
			case 2:
				return value_02;
			case 3:
				return value_03;
			case 4:
				return value_04;
			case 5:
				return value_05;
			case 6:
				return value_06;
			case 7:
				return value_07;
			case 8:
				return value_08;
			case 9:
				return value_09;
			case 10:
				return value_10;
			case 11:
				return value_11;
			case 12:
				return value_12;
			case 13:
				return value_13;
			case 14:
				return value_14;
			case 15:
				return value_15;
			case 16:
				return value_16;
			case 17:
				return value_17;
			case 18:
				return value_18;
			case 19:
				return value_19;
			case 20:
				return value_20;
			default:
				return 0f;
			}
		}
	}
}
