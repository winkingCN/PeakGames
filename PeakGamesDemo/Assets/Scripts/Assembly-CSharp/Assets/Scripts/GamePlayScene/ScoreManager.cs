using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.UI;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene
{
	public class ScoreManager : MonoBehaviour
	{
		[HideInInspector]
		public CaravanTopPanel CurrentTopPanel;

		public static ScoreManager Instance;

		private int HMFDCKOHHFG;

		private KFCEILFGADG ELFBOKDHKGG;

		public int PBGCHJEPCIE
		{
			get
			{
				return HMFDCKOHHFG;
			}
			set
			{
				HMFDCKOHHFG = value;
				Instance.CurrentTopPanel.UpdateScoreBar(HMFDCKOHHFG);
			}
		}

		public static int DJADMBLKBKJ
		{
			get
			{
				if (Instance != null)
				{
					return Instance.PBGCHJEPCIE;
				}
				return -1;
			}
		}

		public void Awake()
		{
			Instance = this;
		}

		public static void RaiseScore(int MGCMMJPNJPH)
		{
			if (Instance == null)
			{
				return;
			}
			if (Instance.ELFBOKDHKGG == null)
			{
				if (Instance == null)
				{
					return;
				}
				CaravanTopPanel currentTopPanel = Instance.CurrentTopPanel;
				if (currentTopPanel == null)
				{
					return;
				}
				LevelBuilder currentlLevelBuilder = currentTopPanel.CurrentlLevelBuilder;
				if (currentlLevelBuilder == null)
				{
					return;
				}
				Instance.ELFBOKDHKGG = currentlLevelBuilder.CurrentLevel;
				if (Instance.ELFBOKDHKGG == null)
				{
					return;
				}
			}
			if (!(Instance == null) && MGCMMJPNJPH != 0 && !Instance.ELFBOKDHKGG.BKBFKFGBKDP)
			{
				Instance.PBGCHJEPCIE += MGCMMJPNJPH;
			}
		}

		public static void RaiseSudden(int MGCMMJPNJPH)
		{
			if (Instance != null)
			{
				Instance.PBGCHJEPCIE += MGCMMJPNJPH;
			}
		}

		public void OnDestroy()
		{
			ResetSelf();
		}

		public static void ResetSelf()
		{
			Instance = null;
		}

		public void SceneReloadedSetups(KFCEILFGADG GIOFHACJEGA)
		{
			ELFBOKDHKGG = GIOFHACJEGA;
			HMFDCKOHHFG = 0;
		}
	}
}
