using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Animations
{
	public class CollectManager : MonoBehaviour
	{
		public List<CollectAnimation>[] _collects = new List<CollectAnimation>[4];

		public static CollectManager Instance;

		private bool FIEAKGKJJBP;

		public CollectManager()
		{
			for (int i = 0; i < 4; i++)
			{
				_collects[i] = new List<CollectAnimation>(90);
			}
		}

		public void Awake()
		{
			Instance = this;
		}

		public void OnDestroy()
		{
			ResetSelf();
		}

		public static void ResetSelf()
		{
			Instance = null;
		}

		public void LateUpdate()
		{
			if (!FIEAKGKJJBP)
			{
				return;
			}
			for (int i = 0; i < _collects.Length; i++)
			{
				List<CollectAnimation> list = _collects[i];
				if (list.Count != 0)
				{
					HMPAMDCECFJ fMFABAKPMLB = new HMPAMDCECFJ(list, list[0].TargetPosition);
					for (int j = 0; j < list.Count; j++)
					{
						CollectAnimation collectAnimation = list[j];
						collectAnimation.InsertDelays(fMFABAKPMLB, collectAnimation.ReferencedCell);
					}
					list.Clear();
				}
			}
			FIEAKGKJJBP = false;
		}

		public void Register(CollectAnimation DAGBIEOKGGA)
		{
			FIEAKGKJJBP = true;
			int topPanelGoalId = DAGBIEOKGGA.TopPanelGoalId;
			_collects[topPanelGoalId].Add(DAGBIEOKGGA);
		}
	}
}
