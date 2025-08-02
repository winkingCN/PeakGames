using UnityEngine;

namespace Medvedya.SpriteDeformerTools
{
	public abstract class SpriteDeformerWithMaterialPropertyBlock : SpriteDeformer
	{
		private static Material OMCCKIDFAIN;

		private const string AMLFAPLODFE = "_MainTex";

		private MaterialPropertyBlock OLKPHNJCCHH;

		[SerializeField]
		private Material _referenceMaterial;

		private static Material BAGLHAMNAGC
		{
			get
			{
				if (OMCCKIDFAIN == null)
				{
					OMCCKIDFAIN = Resources.Load<Material>("SpriteDeformerStandartMaterial");
				}
				return OMCCKIDFAIN;
			}
		}

		private MaterialPropertyBlock JDPOHMEGBMB
		{
			get
			{
				OLKPHNJCCHH = new MaterialPropertyBlock();
				base.FJOOPODJMFC.SetPropertyBlock(OLKPHNJCCHH);
				return OLKPHNJCCHH;
			}
		}

		public Material GHPFOPNNJOB
		{
			get
			{
				return base.FJOOPODJMFC.sharedMaterial;
			}
			set
			{
				base.FJOOPODJMFC.sharedMaterial = value;
			}
		}

		protected override void Update()
		{
			base.Update();
		}

		protected override void Awake()
		{
			base.Awake();
			if (_referenceMaterial != null)
			{
				GHPFOPNNJOB = _referenceMaterial;
				_referenceMaterial = null;
			}
			if (GHPFOPNNJOB == null)
			{
				GHPFOPNNJOB = BAGLHAMNAGC;
			}
			BHFGLGPDLIC(MJOJAOIHCIO);
		}

		private void BHFGLGPDLIC(Sprite CHKPPIBGKFM)
		{
			if (CHKPPIBGKFM == null)
			{
				JDPOHMEGBMB.SetTexture("_MainTex", Texture2D.whiteTexture);
			}
			else
			{
				JDPOHMEGBMB.SetTexture("_MainTex", CHKPPIBGKFM.texture);
			}
			base.FJOOPODJMFC.SetPropertyBlock(OLKPHNJCCHH);
		}

		protected override void PJMPCKADKLI(Sprite IHPCGJBFPFP, Sprite GNHNPAMIEBN)
		{
			base.PJMPCKADKLI(IHPCGJBFPFP, GNHNPAMIEBN);
			if (!(IHPCGJBFPFP != null) || !(GNHNPAMIEBN != null) || !(IHPCGJBFPFP.texture == GNHNPAMIEBN.texture))
			{
				BHFGLGPDLIC(GNHNPAMIEBN);
			}
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
		}
	}
}
