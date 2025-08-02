using System;
using System.Collections.Generic;
using Assets.Scripts.MapScene;
using BestHTTP.SocketIO;
using ToonSocial;
using ToonSocial.dialogs;

public class JHDPFMPOPKD : MJLNBKKHIPP
{
	public Action<string, string> EHAOMKKHEOG;

	private readonly SocketManager NLFNJGBPDEL;

	private readonly EIPCLBONPLC LNDFJKGAJAK;

	public JHDPFMPOPKD(SocketManager BMJLBDOKDPD, EIPCLBONPLC PEBICCFPCFE)
	{
		NLFNJGBPDEL = BMJLBDOKDPD;
		LNDFJKGAJAK = PEBICCFPCFE;
		if (NLFNJGBPDEL != null)
		{
			NLFNJGBPDEL.Socket.On("do-Authenticate", LFAPEHADCHD);
			NLFNJGBPDEL.Socket.On("do-Authenticate-Result", FIDBEIOBPKA);
			NLFNJGBPDEL.Socket.On("response-create-user", JMPLOFGKHHI);
			NLFNJGBPDEL.Socket.On("response-update-user-level", GLDOKAFHDFE);
			NLFNJGBPDEL.Socket.On("throttled", GNLCPCPBELA);
		}
	}

	private void GNLCPCPBELA(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.UserModule, "Too much commands send!");
	}

	private void GLDOKAFHDFE(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		NKILAONHNNE nKILAONHNNE = ADBKCDPFMGN(MIDCNFGAIFA);
		if (nKILAONHNNE != null)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.UserModule, "Max level social update failed. Error:{0}", nKILAONHNNE);
		}
	}

	public void MJIFKABFNAD(string PDEKHNLNOLA)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add("nick", PDEKHNLNOLA);
		dictionary.Add("level", HBIIHGPDLCM());
		NLFNJGBPDEL.Socket.Emit("request-create-user", dictionary);
	}

	private void LFAPEHADCHD(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		string text = LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString();
		string text2 = LECPGNKOABP.GABGKBAKHDP.FIPPLABNDON;
		string text3 = ((!MCJHHDACJBG.OCLBKDOFADM) ? "4161" : "2096");
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("userId", text);
		dictionary.Add("token", text2);
		dictionary.Add("version", text3);
		Dictionary<string, string> dictionary2 = dictionary;
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.UserModule, "Social OnDoAuthenticate > Reply Authenticate > UserId:{0} Token:{1} Version:{2}", text, text2, text3);
		NLFNJGBPDEL.Socket.Emit("reply-Authenticate", dictionary2);
	}

	private void FIDBEIOBPKA(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		if (MIDCNFGAIFA == null)
		{
			return;
		}
		bool flag = (bool)MIDCNFGAIFA[0];
		if (flag)
		{
			LNDFJKGAJAK.NNEADDLACCA = flag;
			LNDFJKGAJAK.IPCAELIMIBN.RequestLevelUpdate();
			if (MIDCNFGAIFA.Length >= 2)
			{
				Dictionary<string, object> dictionary = MIDCNFGAIFA[1] as Dictionary<string, object>;
				if (dictionary != null)
				{
					LNDFJKGAJAK.ADCMNJCINBO = new AKGIJAMHMNA(dictionary);
					LNDFJKGAJAK.IPCAELIMIBN.RequestInbox();
					LECPGNKOABP.GABGKBAKHDP.MHBOHLJEBOE(LNDFJKGAJAK.ADCMNJCINBO.EALJKKBHDHK);
					long oADDPGNIINO = LNDFJKGAJAK.ADCMNJCINBO.OADDPGNIINO;
					if (oADDPGNIINO > 0)
					{
						LNDFJKGAJAK.IPCAELIMIBN.JoinToTeam(oADDPGNIINO, null);
						SocialHelper.AKIJLCCOAPB = true;
						return;
					}
					PLMEHPJHAKC();
					LNDFJKGAJAK.IPCAELIMIBN.CurrentJoinedContainer.ChatTab.UpdateSocialNoticeMark();
				}
			}
			LNDFJKGAJAK.IPCAELIMIBN.SwitchState(MGGEJMGBEBE.NotJoinedToAnyTeam);
		}
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.UserModule, "OnDoAuthenticateResult Result:{0}", flag);
	}

	private static void PLMEHPJHAKC()
	{
		AAPMDEEMEMM aAPMDEEMEMM = DGOMNDMPMBG.GABGKBAKHDP.BHGCBNAMEFK;
		if (aAPMDEEMEMM != null)
		{
			aAPMDEEMEMM.LCBIJOLOHKM(false);
		}
		KCKDNJOMPJH kCKDNJOMPJH = DGOMNDMPMBG.GABGKBAKHDP.FABKMFCBELE;
		if (kCKDNJOMPJH != null)
		{
			kCKDNJOMPJH.LCBIJOLOHKM();
		}
		LECPGNKOABP.GABGKBAKHDP.AIFPMKNFFJI(0L, string.Empty, 0);
	}

	private void JMPLOFGKHHI(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		MDMLFPDLFLE.JGCHLLMLCNI = false;
		if (MIDCNFGAIFA == null || !MPDHPEIDDOO(MIDCNFGAIFA))
		{
			MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_TryAgain"));
			SocialCreateUserDialog.CloseActiveOne();
			return;
		}
		Dictionary<string, object> jLKANDLHAOM = MIDCNFGAIFA[1] as Dictionary<string, object>;
		AKGIJAMHMNA eDDNOJDPMCF = new AKGIJAMHMNA(jLKANDLHAOM);
		LNDFJKGAJAK.ADCMNJCINBO = eDDNOJDPMCF;
		SocialCreateUserDialog.CloseActiveOne();
		LNDFJKGAJAK.IPCAELIMIBN.CurrentNotJoinedContainer.CurrentCreateTeamTab.LockFields();
		if (GFIEJLKCDDD.GABGKBAKHDP != null)
		{
			GFIEJLKCDDD.GABGKBAKHDP.NDAIFGNIADD();
		}
		LECPGNKOABP.GABGKBAKHDP.MHBOHLJEBOE(LNDFJKGAJAK.ADCMNJCINBO.EALJKKBHDHK);
	}

	public void NHNHFBFJMNF()
	{
		int num = HBIIHGPDLCM();
		if (LNDFJKGAJAK.ADCMNJCINBO != null && LNDFJKGAJAK.ADCMNJCINBO.CALJBGILMOL < num)
		{
			NLFNJGBPDEL.Socket.Emit("request-update-user-level", num);
		}
	}

	public static int HBIIHGPDLCM()
	{
		int num = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1;
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.UserModule, "Updating user level as {0}", num);
		return num;
	}
}
