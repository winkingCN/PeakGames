using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Tutorials;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Touches
{
	public class TapListener : AbstractTapListener
	{
		public static TapListener Instance;

		private Cell IFIJNBKDACP;

		private Cell JHHBPDOCEIJ;

		private TutorialManager GIHALIPPNHL;

		public void Awake()
		{
			Instance = this;
		}

		public void OnDestroy()
		{
			Instance = null;
		}

		protected override void EFECEAIKDLA(Vector2 NPGMHNONCGO)
		{
			if (JHDMFHDHIFN == null)
			{
				return;
			}
			JHDMFHDHIFN.JCNFICLCFOB();
			Cell cell = PBOLDKFFGMP(NPGMHNONCGO);
			if (GIHALIPPNHL != null)
			{
				if (!GIHALIPPNHL.CanClick(cell))
				{
					IFIJNBKDACP = null;
					return;
				}
				JHDMFHDHIFN.ELHPMMGOKMF(cell);
				IFIJNBKDACP = null;
				GIHALIPPNHL.Next(cell);
				return;
			}
			JHDMFHDHIFN.ELHPMMGOKMF(cell);
			IFIJNBKDACP = null;
			if (JHHBPDOCEIJ != null && JHHBPDOCEIJ != cell)
			{
				JHDMFHDHIFN.NLOHEBDFPCP();
				JHHBPDOCEIJ = null;
			}
		}

		protected override void NKPMGDHHBPB(Vector2 NPGMHNONCGO)
		{
			if (JHDMFHDHIFN == null || GIHALIPPNHL != null)
			{
				return;
			}
			Cell cell = PBOLDKFFGMP(NPGMHNONCGO);
			if (!(cell == IFIJNBKDACP))
			{
				JHDMFHDHIFN.JCNFICLCFOB();
				IFIJNBKDACP = cell;
				if (IFIJNBKDACP != null)
				{
					IFIJNBKDACP.ShowHighlight();
				}
			}
		}

		protected override void KPCKCDGGBMF(Vector2 NPGMHNONCGO)
		{
			if (JHDMFHDHIFN != null)
			{
				IFIJNBKDACP = PBOLDKFFGMP(NPGMHNONCGO);
				JHHBPDOCEIJ = IFIJNBKDACP;
				if (!(GIHALIPPNHL != null) && IFIJNBKDACP != null)
				{
					IFIJNBKDACP.ShowHighlight();
				}
			}
		}

		public void RegisterTutorial(TutorialManager NGIFIPBOMBO)
		{
			GIHALIPPNHL = NGIFIPBOMBO;
		}
	}
}
