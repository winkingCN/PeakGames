using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	public class InlineGraphic : MaskableGraphic
	{
		public Texture texture;

		private InlineGraphicManager AAKMKNGLFOD;

		private RectTransform CCAABNCMJAB;

		private RectTransform IJCJPENFEDD;

		public override Texture CJNCIEDBHNM
		{
			get
			{
				if (texture == null)
				{
					return Graphic.s_WhiteTexture;
				}
				return texture;
			}
		}

		protected override void Awake()
		{
			AAKMKNGLFOD = GetComponentInParent<InlineGraphicManager>();
		}

		protected override void OnEnable()
		{
			if (CCAABNCMJAB == null)
			{
				CCAABNCMJAB = base.gameObject.GetComponent<RectTransform>();
			}
			if (AAKMKNGLFOD != null && AAKMKNGLFOD.GKDEMJDOOLB != null)
			{
				texture = AAKMKNGLFOD.GKDEMJDOOLB.spriteSheet;
			}
		}

		protected override void OnDisable()
		{
			base.OnDisable();
		}

		protected override void OnTransformParentChanged()
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
			if (CCAABNCMJAB == null)
			{
				CCAABNCMJAB = base.gameObject.GetComponent<RectTransform>();
			}
			if (IJCJPENFEDD == null)
			{
				IJCJPENFEDD = CCAABNCMJAB.parent.GetComponent<RectTransform>();
			}
			if (CCAABNCMJAB.pivot != IJCJPENFEDD.pivot)
			{
				CCAABNCMJAB.pivot = IJCJPENFEDD.pivot;
			}
		}

		public new void UpdateMaterial()
		{
			base.UpdateMaterial();
		}

		protected override void UpdateGeometry()
		{
		}
	}
}
