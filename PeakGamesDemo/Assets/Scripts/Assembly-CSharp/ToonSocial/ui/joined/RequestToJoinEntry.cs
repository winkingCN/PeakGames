using Assets.Scripts.CasualTools.Dialogs;

namespace ToonSocial.ui.joined
{
	public class RequestToJoinEntry : ChatEntry
	{
		public long FromUserId;

		public EventBasedSpriteButton YesButton;

		public EventBasedSpriteButton NoButton;

		public void Accepted()
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.RequestToJoinEntry, "Request accepted for: {0}", FromUserId);
			IPCAELIMIBN.CurrentSession.NMGBGAGMOGI.ADEPCGKPKLC(FromUserId);
		}

		public void Rejected()
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.RequestToJoinEntry, "Request rejected for: {0}", FromUserId);
			IPCAELIMIBN.CurrentSession.NMGBGAGMOGI.PLNJECGIDAI(FromUserId);
		}
	}
}
