using System;
using UnityEngine;

namespace ToonSocial.ui.joined
{
	public class TeamActionEntry : ChatEntry
	{
		public SpriteRenderer[] BarSpriteRenderers;

		public Sprite[] BarSprites;

		private readonly Color[] GIEMNFGBMII = new Color[3]
		{
			new Color(0.3019608f, 0.36078432f, 0.40784314f),
			new Color(25f / 51f, 0.28627452f, 0.29803923f),
			new Color(1f, 1f, 1f)
		};

		public override void Prepare(EKPAJFBBAJC KINKOCNMOMJ, SocialHelper JANPCBNIGFG)
		{
			base.Prepare(KINKOCNMOMJ, JANPCBNIGFG);
			switch (KINKOCNMOMJ.ENBPGGCIADN)
			{
			case ABAPNBACABK.JoinRoom:
			case ABAPNBACABK.AcceptedToTeam:
				OFKBFLKCMKG(0);
				break;
			case ABAPNBACABK.LeftRoom:
				OFKBFLKCMKG(1);
				break;
			case ABAPNBACABK.UserIsKicked:
				OFKBFLKCMKG(2);
				break;
			default:
				throw new ArgumentOutOfRangeException();
			}
		}

		private void OFKBFLKCMKG(int EHJNMODJEAN)
		{
			Message.color = GIEMNFGBMII[EHJNMODJEAN];
			BarSpriteRenderers[0].sprite = BarSprites[EHJNMODJEAN];
			BarSpriteRenderers[1].sprite = BarSprites[EHJNMODJEAN];
		}
	}
}
