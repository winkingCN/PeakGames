using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Utils;
using BestHTTP;
using BestHTTP.SocketIO;
using BestHTTP.SocketIO.JsonEncoders;
using BestHTTP.SocketIO.Transports;
using ToonSocial;
using ToonSocial.ui.joined;
using UnityEngine;
using caravan.protobuf.messages;

public class EIPCLBONPLC
{
	public static bool FLBLFCFFBNM;

	private const int DAFOAPKDKPE = 10;

	private const int CKLHGCHDJPG = 1;

	private SocketManager NLFNJGBPDEL;

	private int KFPBGFMFIGM;

	private bool LIKACEODMDK;

	private Error BBAJGENKOIE;

	public string HNOMLCAEBJP;

	public JHDPFMPOPKD NHHCGMIDPDK;

	public KOPGKODCMFF NMGBGAGMOGI;

	public LEBMDIEHDMG BDHGGKCDJLE;

	public SocialHelper IPCAELIMIBN;

	private bool ONHACJBIILP;

	private int BGPJDFICKBL;

	private int KNGJLJKMDHM;

	public bool PLNDKBKHDHA { get; private set; }

	public AKGIJAMHMNA ADCMNJCINBO { get; set; }

	public bool NNEADDLACCA { get; set; }

	public DKBEJLGEAOA COPDAKACHFM { get; set; }

	public HashSet<AKGIJAMHMNA> FPILBAGGALI { get; set; }

	public EIPCLBONPLC(SocialHelper BHCIBOMDAIE)
	{
		IPCAELIMIBN = BHCIBOMDAIE;
	}

	private void BCBPLNJJCKG()
	{
		long num = LECPGNKOABP.GABGKBAKHDP.OADDPGNIINO;
		if (FLBLFCFFBNM)
		{
			long num2 = num;
			if (num2 == 0)
			{
				num2 = LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM;
			}
			if (num2 == 0)
			{
				num2 = new System.Random().Next(1, 100);
			}
			HIJKJHKCFIB("https://social.toonblast.net/" + num2);
		}
		else
		{
			int num3;
			if (num == 0 || KNGJLJKMDHM >= 2)
			{
				KNGJLJKMDHM = 0;
				num3 = new System.Random().Next(0, MCJHHDACJBG.ODIGKOODMGA.Length);
			}
			else
			{
				num3 = (int)(num % MCJHHDACJBG.ODIGKOODMGA.Length);
			}
			HIJKJHKCFIB(MCJHHDACJBG.ODIGKOODMGA[num3]);
		}
	}

	private void HIJKJHKCFIB(string LNCBFPEKHDJ)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SocialSession, "Connecting to {0}", LNCBFPEKHDJ);
		SocketOptions socketOptions = new SocketOptions();
		socketOptions.Timeout = TimeSpan.FromSeconds(10.0);
		socketOptions.ReconnectionDelay = TimeSpan.FromSeconds(1.0);
		socketOptions.ConnectWith = TransportTypes.WebSocket;
		SocketOptions options = socketOptions;
		NLFNJGBPDEL = new SocketManager(new Uri(LNCBFPEKHDJ), options);
		NLFNJGBPDEL.Encoder = new LitJsonEncoder();
		NHHCGMIDPDK = new JHDPFMPOPKD(NLFNJGBPDEL, this);
		NMGBGAGMOGI = new KOPGKODCMFF(NLFNJGBPDEL, this);
		BDHGGKCDJLE = new LEBMDIEHDMG(NLFNJGBPDEL, this);
		ADCMNJCINBO = null;
		NNEADDLACCA = false;
		COPDAKACHFM = null;
		FPILBAGGALI = null;
		KFPBGFMFIGM = 0;
		NLFNJGBPDEL.Socket.On("connect", NPPBDKKGIKE);
		NLFNJGBPDEL.Socket.On("disconnect", MJDNHECJGPH);
		NLFNJGBPDEL.Socket.On(SocketIOEventTypes.Error, BOBBLAPLOKK);
		NLFNJGBPDEL.Open();
		new LLCJMMBBLEH(JKDHHIIMPNG(), true);
	}

	private IEnumerator JKDHHIIMPNG()
	{
		yield return MCJHHDACJBG.DBKEKNNJLNO;
		if (PLNDKBKHDHA)
		{
			yield break;
		}
		yield return MCJHHDACJBG.DBKEKNNJLNO;
		if (!PLNDKBKHDHA)
		{
			if (BGPJDFICKBL != 1)
			{
				IPCAELIMIBN.SwitchState(MGGEJMGBEBE.NoConnection);
			}
			NDAIFGNIADD();
		}
	}

	private static void NDAIFGNIADD()
	{
		if (GFIEJLKCDDD.GABGKBAKHDP != null)
		{
			GFIEJLKCDDD.GABGKBAKHDP.NDAIFGNIADD(false);
		}
	}

	private void BOBBLAPLOKK(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		if (MIDCNFGAIFA == null || MIDCNFGAIFA.Length <= 0)
		{
			return;
		}
		BBAJGENKOIE = (Error)MIDCNFGAIFA[0];
		if (LGLKGEEIFHO())
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SocketHelper, "Socket Error After Focus Out/In: {0}", BBAJGENKOIE.Code);
		}
		else
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.SocketHelper, "Socket Error: {0}/{1}", BBAJGENKOIE.Code, BBAJGENKOIE.Message);
		}
		MGPFMNIMHOL();
		if (KFPBGFMFIGM++ < 1)
		{
			if (!PCAOOMAAMBE.IsOpen)
			{
				AFJPGLHKOID.OEFHHOFLGFN(10);
			}
		}
		else
		{
			IPCAELIMIBN.SwitchState(MGGEJMGBEBE.NoConnection);
			NDAIFGNIADD();
		}
	}

	private void MGPFMNIMHOL()
	{
		switch (BGPJDFICKBL)
		{
		case 0:
		{
			BGPJDFICKBL = -1;
			Uri uri = new Uri("https://social-api.toonblast.net/status/");
			HTTPRequest hTTPRequest = new HTTPRequest(uri, ECDJIICFGNN);
			hTTPRequest.Send();
			break;
		}
		case 1:
			IPCAELIMIBN.SwitchState(MGGEJMGBEBE.Maintenance);
			break;
		}
	}

	private void ECDJIICFGNN(HTTPRequest HADMIDEJOLI, HTTPResponse EAHCAACAHAA)
	{
		if (EAHCAACAHAA != null && EAHCAACAHAA.IsSuccess && EAHCAACAHAA.DataAsText.Contains("\"error\":99"))
		{
			BGPJDFICKBL = 1;
			if (NLFNJGBPDEL != null)
			{
				NLFNJGBPDEL.Close();
			}
			IPCAELIMIBN.SwitchState(MGGEJMGBEBE.Maintenance);
		}
	}

	public void BDPBBCELEBN()
	{
		if (BGPJDFICKBL == 1)
		{
			FFBLPBHGFOD();
		}
		BGPJDFICKBL = 0;
	}

	public void LOMBPFAIGKF()
	{
		if (NLFNJGBPDEL != null)
		{
			NLFNJGBPDEL.Socket.Emit("request-show-my-help");
		}
	}

	public void NKKOEHGDNKD()
	{
		LIKACEODMDK = true;
		if (NLFNJGBPDEL != null)
		{
			NLFNJGBPDEL.Close();
		}
		NLFNJGBPDEL = null;
	}

	private void NPPBDKKGIKE(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		ONHACJBIILP = false;
		PLNDKBKHDHA = true;
		BGPJDFICKBL = 0;
	}

	private void MJDNHECJGPH(Socket PCAOOMAAMBE, Packet DFNAOGFJDMF, object[] MIDCNFGAIFA)
	{
		MDMLFPDLFLE.JGCHLLMLCNI = false;
		if (ONHACJBIILP)
		{
			IPCAELIMIBN.SwitchState(MGGEJMGBEBE.ChangingHost);
		}
		else
		{
			IPCAELIMIBN.SwitchState(MGGEJMGBEBE.NoConnection);
		}
		IPCAELIMIBN.Disconnectted();
		PLNDKBKHDHA = false;
		ADCMNJCINBO = null;
		NNEADDLACCA = false;
		COPDAKACHFM = null;
		if (!LIKACEODMDK && !ONHACJBIILP && !LGLKGEEIFHO())
		{
			AFJPGLHKOID.LCACHLKLPCO(BBAJGENKOIE);
		}
	}

	public void FGEGJIFABCO(string ENFGCENCBAJ)
	{
		ONHACJBIILP = true;
		HNOMLCAEBJP = ENFGCENCBAJ;
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SocialSession, "Changing host to {0}", ENFGCENCBAJ);
		if (NLFNJGBPDEL != null)
		{
			NLFNJGBPDEL.Close();
		}
		PLNDKBKHDHA = false;
		HIJKJHKCFIB("https://" + ENFGCENCBAJ + "/socket.io/");
	}

	public void FFBLPBHGFOD()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SocialSession, "Reconnectting...");
		if (NLFNJGBPDEL != null)
		{
			NLFNJGBPDEL.Close();
		}
		PLNDKBKHDHA = false;
		KNGJLJKMDHM++;
		BCBPLNJJCKG();
	}

	public void FOEGMMJDPCK(AKGIJAMHMNA GABGELEBKEC)
	{
		if (FPILBAGGALI == null)
		{
			FPILBAGGALI = new HashSet<AKGIJAMHMNA>();
		}
		FPILBAGGALI.Add(GABGELEBKEC);
		JoinedContainer currentJoinedContainer = IPCAELIMIBN.CurrentJoinedContainer;
		if (currentJoinedContainer != null)
		{
			currentJoinedContainer.UpdateOnlineUserCounts();
		}
	}

	public void EAMBNIGLELH(AKGIJAMHMNA GABGELEBKEC)
	{
		if (FPILBAGGALI != null)
		{
			FPILBAGGALI.Remove(GABGELEBKEC);
			JoinedContainer currentJoinedContainer = IPCAELIMIBN.CurrentJoinedContainer;
			if (currentJoinedContainer != null)
			{
				currentJoinedContainer.UpdateOnlineUserCounts();
			}
		}
	}

	public void EOKBHHMLONF(AKGIJAMHMNA GABGELEBKEC)
	{
		if (COPDAKACHFM != null)
		{
			if (!COPDAKACHFM.HOINIMJNGFK.ContainsKey(GABGELEBKEC.EEFMIHDPJPG))
			{
				COPDAKACHFM.GMCGMPEEHJP++;
			}
			COPDAKACHFM.HOINIMJNGFK[GABGELEBKEC.EEFMIHDPJPG] = GABGELEBKEC;
			JoinedContainer currentJoinedContainer = IPCAELIMIBN.CurrentJoinedContainer;
			if (currentJoinedContainer != null)
			{
				currentJoinedContainer.UpdateOfflineUserCounts();
				NEAAGPPFKNA(GABGELEBKEC);
			}
			COPDAKACHFM.PDHFJLNGDOL = Time.frameCount;
		}
	}

	public void JFANMFMKOIP(AKGIJAMHMNA GABGELEBKEC)
	{
		if (COPDAKACHFM == null)
		{
			return;
		}
		long eEFMIHDPJPG = GABGELEBKEC.EEFMIHDPJPG;
		if (COPDAKACHFM.HOINIMJNGFK.ContainsKey(eEFMIHDPJPG))
		{
			COPDAKACHFM.PDHFJLNGDOL = Time.frameCount;
			COPDAKACHFM.HOINIMJNGFK.Remove(eEFMIHDPJPG);
			COPDAKACHFM.GMCGMPEEHJP--;
			JoinedContainer currentJoinedContainer = IPCAELIMIBN.CurrentJoinedContainer;
			if (currentJoinedContainer != null)
			{
				currentJoinedContainer.UpdateOfflineUserCounts();
				currentJoinedContainer.MyTeamTab.UpdateIfActive();
			}
		}
	}

	public void LFGIBEDPLJG(bool OBAEIDMHDMF)
	{
		if (OBAEIDMHDMF)
		{
			if (NLFNJGBPDEL == null)
			{
				BCBPLNJJCKG();
			}
		}
		else if (NLFNJGBPDEL != null)
		{
			ONHACJBIILP = false;
			NKKOEHGDNKD();
		}
	}

	private void NEAAGPPFKNA(AKGIJAMHMNA EBKKHFPGDEK)
	{
		if (EBKKHFPGDEK == null)
		{
			IPCAELIMIBN.CurrentJoinedContainer.MyTeamTab.UpdateIfActive();
			return;
		}
		List<long> list = new List<long>();
		list.Add(EBKKHFPGDEK.EEFMIHDPJPG);
		NCJDJEAGMLL item = new NCJDJEAGMLL(list, delegate(bool EEKJMDHEJCK, ClUserScoresResponseMessage OMJOIIOONMO)
		{
			if (!EEKJMDHEJCK || OMJOIIOONMO.member == null || OMJOIIOONMO.member.Count <= 0)
			{
				IPCAELIMIBN.CurrentJoinedContainer.MyTeamTab.UpdateIfActive();
			}
			else
			{
				foreach (ClMember item2 in OMJOIIOONMO.member)
				{
					long result;
					long.TryParse(item2.id, out result);
					if (result != 0 && COPDAKACHFM != null && COPDAKACHFM.HOINIMJNGFK != null && COPDAKACHFM.HOINIMJNGFK.ContainsKey(result))
					{
						COPDAKACHFM.HOINIMJNGFK[result].GGBEMNJNAEE = item2.score;
					}
				}
				IPCAELIMIBN.CurrentJoinedContainer.MyTeamTab.UpdateIfActive();
			}
		});
		KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH> { item });
	}

	private static bool LGLKGEEIFHO()
	{
		return Time.time - FocusListener.LastTimeFocused < 4f;
	}

	[CompilerGenerated]
	private void EBCAJEGLFMA(bool EEKJMDHEJCK, ClUserScoresResponseMessage OMJOIIOONMO)
	{
		if (!EEKJMDHEJCK || OMJOIIOONMO.member == null || OMJOIIOONMO.member.Count <= 0)
		{
			IPCAELIMIBN.CurrentJoinedContainer.MyTeamTab.UpdateIfActive();
			return;
		}
		foreach (ClMember item in OMJOIIOONMO.member)
		{
			long result;
			long.TryParse(item.id, out result);
			if (result != 0 && COPDAKACHFM != null && COPDAKACHFM.HOINIMJNGFK != null && COPDAKACHFM.HOINIMJNGFK.ContainsKey(result))
			{
				COPDAKACHFM.HOINIMJNGFK[result].GGBEMNJNAEE = item.score;
			}
		}
		IPCAELIMIBN.CurrentJoinedContainer.MyTeamTab.UpdateIfActive();
	}
}
