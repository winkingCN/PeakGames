using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class FakeItem<T> : Item where T : Item
	{
		public T MasterItem;

		public override NOALGNJECAD GetItemType()
		{
			return MasterItem.GetItemType();
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
		}

		public override CKKKELDIOLD GetSorting()
		{
			return MasterItem.GetSorting();
		}

		public override bool CanFall()
		{
			return MasterItem.CanFall();
		}

		public override int GetLayerCount()
		{
			return MasterItem.GetLayerCount();
		}

		public override int GetScore()
		{
			return MasterItem.GetScore();
		}

		public override void PlayWrongMove()
		{
			MasterItem.PlayWrongMove();
		}

		public override bool CanShadowDrop()
		{
			return MasterItem.CanShadowDrop();
		}

		public override void SetExplodeDirection(IEKBFJBLGFM AJLDJAHHGOJ)
		{
			MasterItem.SetExplodeDirection(AJLDJAHHGOJ);
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return MasterItem.CanExplodeDueToExplodeInNeigbour(KOINNGEBMJI);
		}

		public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
		{
			return MasterItem.TryExplode(CCPAJBOJDMN);
		}

		public override void StartExplode()
		{
			MasterItem.StartExplode();
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			MasterItem.ExplodeByBlasterItem(CCPAJBOJDMN);
		}

		public override bool CanBeCollectedWithAnimation()
		{
			return MasterItem.CanBeCollectedWithAnimation();
		}

		public override bool CanGenerateScoreThisTurn()
		{
			return MasterItem.CanGenerateScoreThisTurn();
		}

		public override bool CanGenerateScoreOnEachTryExplode()
		{
			return MasterItem.CanGenerateScoreOnEachTryExplode();
		}

		public override bool CanBeInsideBubble()
		{
			return MasterItem.CanBeInsideBubble();
		}

		public override bool CanBeExplodedBySpecialItem()
		{
			return MasterItem.CanBeExplodedBySpecialItem();
		}

		public override bool CanBeExplodedByBooster()
		{
			return MasterItem.CanBeExplodedByBooster();
		}

		public override bool CanBeTapped()
		{
			return MasterItem.CanBeTapped();
		}

		public override bool CanCastShadow()
		{
			return MasterItem.CanCastShadow();
		}

		public override Vector3 GetCenterPositionOffset(APBDPLNCDIJ CCPAJBOJDMN)
		{
			return MasterItem.GetCenterPositionOffset(CCPAJBOJDMN);
		}

		public override int GetFireworksPriority()
		{
			return MasterItem.GetFireworksPriority();
		}

		public override int SelectedByFireworks()
		{
			return MasterItem.SelectedByFireworks();
		}

		public override void HitByFireworks()
		{
			MasterItem.HitByFireworks();
		}

		public override Item GetMasterTarget()
		{
			return MasterItem.GetMasterTarget();
		}

		public override void RemoveAllLayers()
		{
			MasterItem.RemoveAllLayers();
		}

		public override bool BoosterAnvilCanBeUsed()
		{
			return MasterItem.BoosterAnvilCanBeUsed();
		}

		public override bool BoosterBoxingGloveCanBeUsed()
		{
			return MasterItem.BoosterBoxingGloveCanBeUsed();
		}

		public override bool BoosterHammerCanBeUsed()
		{
			return MasterItem.BoosterHammerCanBeUsed();
		}

		public override void AddToExploders(HashSet<int> IAMPDPOIEOC)
		{
			MasterItem.AddToExploders(IAMPDPOIEOC);
		}

		public override bool CanBeInsideCellItem()
		{
			return MasterItem.CanBeInsideCellItem();
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 0;
		}
	}
}
