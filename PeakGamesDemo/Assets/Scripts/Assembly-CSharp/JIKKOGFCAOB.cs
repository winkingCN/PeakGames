using System.Runtime.CompilerServices;
using Facebook.Unity;

public class JIKKOGFCAOB
{
	[CompilerGenerated]
	private sealed class FFLNKKAPFFE
	{
		internal FacebookDelegate<IAppRequestResult> IMHLFAHONPP;

		internal void AGFNGEFDHLA(IAppRequestResult DIDHNNMKJFE)
		{
			if (DIDHNNMKJFE.Error != null)
			{
				PGACJHKJAHA.GABGKBAKHDP.BJPLENOEKKK(DIDHNNMKJFE);
			}
			if (IMHLFAHONPP != null)
			{
				IMHLFAHONPP(DIDHNNMKJFE);
			}
		}
	}

	private static JIKKOGFCAOB KNPOFJNFLJB;

	public static JIKKOGFCAOB GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new JIKKOGFCAOB();
			}
			return KNPOFJNFLJB;
		}
	}

	private JIKKOGFCAOB()
	{
	}

	public void FODCFKMHJID(string[] OCBMACAOCKC, FacebookDelegate<IAppRequestResult> HDHIDFIMPOO)
	{
		string fCEEGNFABAF = NKILHODNBDE.GHBGCADFLFB("InviteTitle");
		string oEFCOJLNCKP = NKILHODNBDE.GHBGCADFLFB("InviteMessage");
		OHNPIBGHFKL(fCEEGNFABAF, oEFCOJLNCKP, OCBMACAOCKC, HDHIDFIMPOO, "invite");
	}

	private static void OHNPIBGHFKL(string FCEEGNFABAF, string OEFCOJLNCKP, string[] OCBMACAOCKC, FacebookDelegate<IAppRequestResult> IMHLFAHONPP, string MBBPBGHKLJM)
	{
		FB.AppRequest(OEFCOJLNCKP, OCBMACAOCKC, null, null, null, MBBPBGHKLJM, FCEEGNFABAF, delegate(IAppRequestResult DIDHNNMKJFE)
		{
			if (DIDHNNMKJFE.Error != null)
			{
				PGACJHKJAHA.GABGKBAKHDP.BJPLENOEKKK(DIDHNNMKJFE);
			}
			if (IMHLFAHONPP != null)
			{
				IMHLFAHONPP(DIDHNNMKJFE);
			}
		});
	}
}
