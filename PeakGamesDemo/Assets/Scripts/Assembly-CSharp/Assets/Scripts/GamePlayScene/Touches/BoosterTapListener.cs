using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Tutorials;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Touches
{
	public class BoosterTapListener : AbstractTapListener
	{
		public static BoosterTapListener Instance;

		public BoosterManager CurrentBoosterManager;

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
			Cell cell = PBOLDKFFGMP(NPGMHNONCGO);
			if (GIHALIPPNHL != null)
			{
				if (GIHALIPPNHL.CanClick(cell))
				{
					CurrentBoosterManager.CellTapped(cell);
					GIHALIPPNHL.Next(cell);
				}
			}
			else if (cell != null)
			{
				CurrentBoosterManager.CellTapped(cell);
			}
		}

		protected override void NKPMGDHHBPB(Vector2 NPGMHNONCGO)
		{
		}

		protected override void KPCKCDGGBMF(Vector2 NPGMHNONCGO)
		{
		}

		public void RegisterTutorial(TutorialManager NGIFIPBOMBO)
		{
			GIHALIPPNHL = NGIFIPBOMBO;
		}
	}
}
