using Assets.Scripts.GamePlayScene.Mechanics.Items;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public abstract class CollectorItem : Item
	{
		[HideInInspector]
		public int CollectorId;

		public LEDBLDKJBAI BPLHOCDDLCG { get; protected set; }

		public int BHIJCAOHDCM { get; protected set; }

		public abstract void StartCollectingItem();

		public abstract void OnItemCollectCompleted();

		public abstract bool IsAvailable();
	}
}
