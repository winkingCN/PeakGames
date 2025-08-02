using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Items.Features
{
	public class CanCastShadowComponent : MonoBehaviour
	{
		public Renderer ShadowBehindReference;

		public SpriteRenderer ShadowSpriteRenderer;

		public void CastShadow()
		{
			ShadowSpriteRenderer.sortingOrder = ShadowBehindReference.sortingOrder - 1;
			ShadowSpriteRenderer.sortingLayerID = ShadowBehindReference.sortingLayerID;
			ShadowSpriteRenderer.gameObject.SetActive(true);
		}

		public void HideShadow()
		{
			ShadowSpriteRenderer.gameObject.SetActive(false);
		}

		public static void HideShadowIfPossible(Cell EEABGAIFMCP)
		{
			if (!(EEABGAIFMCP == null))
			{
				Cell justAboveCell = EEABGAIFMCP.JustAboveCell;
				if (!(justAboveCell == null) && justAboveCell.EAILOFHFNJO && justAboveCell.LBFCDKPCDPB.CanCastShadow())
				{
					justAboveCell.LBFCDKPCDPB.GetShadowCaster().HideShadow();
				}
			}
		}

		public static void CastShadowIfPossible(Cell LBHDELJBONF)
		{
			if (CanCastShadow(LBHDELJBONF))
			{
				LBHDELJBONF.LBFCDKPCDPB.GetShadowCaster().CastShadow();
			}
		}

		public static bool CanCastShadow(Cell LBHDELJBONF)
		{
			if (LBHDELJBONF == null || !LBHDELJBONF.EAILOFHFNJO)
			{
				return false;
			}
			Item currentItem = LBHDELJBONF.LBFCDKPCDPB;
			Cell justBelowCell = LBHDELJBONF.JustBelowCell;
			if (justBelowCell == null || !justBelowCell.EAILOFHFNJO)
			{
				return false;
			}
			if (currentItem.CanCastShadow() && justBelowCell.LBFCDKPCDPB.CanShadowDrop())
			{
				return true;
			}
			return false;
		}
	}
}
