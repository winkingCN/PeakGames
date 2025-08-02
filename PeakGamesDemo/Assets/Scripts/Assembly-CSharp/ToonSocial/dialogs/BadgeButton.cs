using Assets.Scripts.CasualTools.Dialogs;
using UnityEngine;

namespace ToonSocial.dialogs
{
	public class BadgeButton : EventBasedSpriteButton
	{
		public SocialSelectBadgeDialog CurrentDialog;

		public SpriteRenderer BadgeSpriteRenderer;

		public void Clicked()
		{
			if (CurrentDialog != null)
			{
				CurrentDialog.BadgeSelected(BadgeSpriteRenderer.sprite.name);
			}
		}
	}
}
