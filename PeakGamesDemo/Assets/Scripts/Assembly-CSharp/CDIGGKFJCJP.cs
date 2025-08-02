using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Assets.Scripts.MapScene;
using Assets.Scripts.SceneTransitions;
using Assets.Scripts.Utils.Analytics;
using BestHTTP;
using UnityEngine;
using UnityEngine.SceneManagement;
using caravan.protobuf.messages;

public class CDIGGKFJCJP
{
	private readonly List<IKDMCJPBBIH> ELGIHGBNEEL;

	private readonly long ILBPALAECIG;

	private LLCJMMBBLEH CLBLHMOGKGP;

	[CompilerGenerated]
	private static Action<bool, bool> JANLDOMIIEF;

	public CDIGGKFJCJP(List<IKDMCJPBBIH> HDECNOABBDG, long CLDNFEGFEMB)
	{
		ELGIHGBNEEL = HDECNOABBDG;
		ILBPALAECIG = CLDNFEGFEMB;
	}

	public void ECDJIICFGNN(HTTPRequest MONIIALMCBH, HTTPResponse OMJOIIOONMO)
	{
		KIHMBFDKLJM.GABGKBAKHDP.ADFOMINAMIM();
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Backend, "Waiting for request {0} ended.", ILBPALAECIG);
		bool flag = false;
		bool fCFNMGAMKCJ = false;
		bool flag2 = false;
		switch (MONIIALMCBH.State)
		{
		case HTTPRequestStates.Finished:
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Backend, "Backend responded to request {0}", ILBPALAECIG);
			flag = true;
			fCFNMGAMKCJ = true;
			break;
		case HTTPRequestStates.Error:
		{
			string text = ((MONIIALMCBH.Exception == null) ? "No Exception" : (MONIIALMCBH.Exception.Message + "\n" + MONIIALMCBH.Exception.StackTrace));
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Backend, "Backend failed for request {0} with reason {1} ", ILBPALAECIG, text);
			AFJPGLHKOID.KKMLABPMGIB(ELGIHGBNEEL, text);
			break;
		}
		case HTTPRequestStates.Aborted:
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Backend, "User aborted waiting backend request {0}", ILBPALAECIG);
			fCFNMGAMKCJ = true;
			AFJPGLHKOID.FCAEELLNLFA(ELGIHGBNEEL);
			break;
		case HTTPRequestStates.ConnectionTimedOut:
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Backend, "Backend timed out for request {0}", ILBPALAECIG);
			AFJPGLHKOID.GGEHLGGLMLP(ELGIHGBNEEL);
			break;
		case HTTPRequestStates.TimedOut:
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Backend, "Backend processing the Request {0} timed Out!", ILBPALAECIG);
			fCFNMGAMKCJ = true;
			AFJPGLHKOID.GGEHLGGLMLP(ELGIHGBNEEL);
			break;
		default:
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Backend, "Unexpected state for Request {0}. State: {1}.", ILBPALAECIG, MONIIALMCBH.State);
			AFJPGLHKOID.KKMLABPMGIB(ELGIHGBNEEL, MONIIALMCBH.State.ToString());
			break;
		}
		GBJNCLLOCJB gBJNCLLOCJB = MONIIALMCBH.State.KMJBHHCCJFD();
		if (flag)
		{
			Response response = PFBEOMAIIII(OMJOIIOONMO.Data);
			if (response == null)
			{
				flag = false;
			}
			else
			{
				LECPGNKOABP lECPGNKOABP = LECPGNKOABP.GABGKBAKHDP;
				ResultCodes resultCode = response.resultCode;
				gBJNCLLOCJB = resultCode.KMJBHHCCJFD();
				switch (resultCode)
				{
				case ResultCodes.RESULT_SUCCESS:
					GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Backend, "Backend confirms request {0} was recieved. SyncId:{1}", ILBPALAECIG, response.syncId);
					if (response.syncId >= 0)
					{
						GFHPEDILAJG.GABGKBAKHDP.OMBKMIINHMF = response.syncId;
					}
					NBJCLOLDJLJ(response);
					break;
				case ResultCodes.RESULT_UNDER_MAINTENANCE:
					GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Backend, "Backend rejects request {0} due to maintenance.", ILBPALAECIG);
					flag = false;
					fCFNMGAMKCJ = false;
					break;
				case ResultCodes.RESULT_NO_SUCH_USER:
				case ResultCodes.RESULT_INVALID_TOKEN:
					flag = false;
					fCFNMGAMKCJ = false;
					GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Backend, "Backend rejects due to authentication failure. UserId:{0} Reason:{1}", lECPGNKOABP.GDMECFECCOM, gBJNCLLOCJB);
					lECPGNKOABP.GDMECFECCOM = 0L;
					lECPGNKOABP.FIPPLABNDON = null;
					break;
				case ResultCodes.RESULT_OUT_OF_SYNC:
					GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Backend, "Backend rejects request {0} due to out of sync.", ILBPALAECIG);
					flag = false;
					fCFNMGAMKCJ = false;
					flag2 = true;
					if (lECPGNKOABP.MPIDFEMEEIJ.Equals(response.lastDeviceId))
					{
						if (PeakAnalytics.GetDeviceId() == PlayerPrefs.GetString("LastDeviceId", string.Empty))
						{
							GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Backend, "Ignoring out of sync for request {0}; same client: {1}. Commands will be re-requested. SyncId:{2}", ILBPALAECIG, response.lastDeviceId, response.syncId);
							GFHPEDILAJG.GABGKBAKHDP.OMBKMIINHMF = response.syncId;
							KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(ELGIHGBNEEL);
							return;
						}
						lECPGNKOABP.AEMKFKIBDGO(true);
					}
					break;
				case ResultCodes.RESULT_DELETED_USER:
					if (CLBLHMOGKGP == null)
					{
						CLBLHMOGKGP = new LLCJMMBBLEH(PGMMBGIAJGJ(), true, IAJNLGPHGLO.App);
						GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Backend, "Backend Request {0} failed: Wipe User. (resultCode:{1})", ILBPALAECIG, resultCode);
					}
					break;
				case ResultCodes.RESULT_DEVICE_BAN:
					flag = false;
					fCFNMGAMKCJ = false;
					LECPGNKOABP.GABGKBAKHDP.FBJPAPPABGJ = true;
					GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Backend, "Backend Request {0} failed: Device Ban. (resultCode:{1})", ILBPALAECIG, resultCode);
					break;
				default:
					flag = false;
					fCFNMGAMKCJ = false;
					GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Backend, "Backend Request {0} failed: Unknown problem. (resultCode:{1})", ILBPALAECIG, resultCode);
					break;
				}
			}
		}
		if (ELGIHGBNEEL == null)
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Backend, "No commands found!");
		}
		else if (ELGIHGBNEEL.Count > 0)
		{
			foreach (IKDMCJPBBIH item in ELGIHGBNEEL)
			{
				try
				{
					if (flag)
					{
						try
						{
							item.IPAKPIGIJHK();
						}
						catch (Exception ex)
						{
							GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Backend, "Response success; but client can not handle it! {0}:{1}", ex.Message, ex.StackTrace);
							item.HBCDLJHLOMK(true, gBJNCLLOCJB);
						}
					}
					else
					{
						item.HBCDLJHLOMK(fCFNMGAMKCJ, gBJNCLLOCJB);
					}
				}
				catch (Exception ex2)
				{
					GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Backend, "Executing a command reply failed. Command server status: {0}, Error Message: {1}, Type:{2}, Stack:{3}", flag, ex2.Message, item.LOICNFDHCJK, ex2.StackTrace);
				}
			}
		}
		else
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Backend, "Command list was empty!");
		}
		if (flag2)
		{
			List<IKDMCJPBBIH> list = new List<IKDMCJPBBIH>();
			list.Add(new OHOMECJJEFI(CCBPMBBOAKE));
			List<IKDMCJPBBIH> hDECNOABBDG = list;
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(hDECNOABBDG);
		}
		CBNMJCLPKPB.HOPBPAIJNNH(MONIIALMCBH.Uri, flag);
	}

	public void NBJCLOLDJLJ(Response OMJOIIOONMO)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Backend, "Message count in response for Request {0} is:{1}", ILBPALAECIG, OMJOIIOONMO.messages.Count);
		if (ELGIHGBNEEL == null)
		{
			return;
		}
		foreach (IKDMCJPBBIH item in ELGIHGBNEEL)
		{
			bool flag = false;
			foreach (GenericMessage message in OMJOIIOONMO.messages)
			{
				if (item.EEFMIHDPJPG != message.id)
				{
					continue;
				}
				item.GKPOLPBJIBG(message);
				flag = true;
				break;
			}
			if (!flag)
			{
				item.GKPOLPBJIBG(null);
			}
		}
	}

	private Response PFBEOMAIIII(byte[] MBBPBGHKLJM)
	{
		try
		{
			using (Stream source = new MemoryStream(MBBPBGHKLJM))
			{
				return KIHMBFDKLJM.GABGKBAKHDP.BGGEDOONAPL.Deserialize(source, null, typeof(Response)) as Response;
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Backend, "Can not parse response: {0} for {1}", ex.Message, ILBPALAECIG);
			return null;
		}
	}

	public void FEAMHPDCHGF(GBJNCLLOCJB OJCKIOENBEL)
	{
		if (ELGIHGBNEEL == null)
		{
			GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.Backend, "No commands found!(2)");
			return;
		}
		foreach (IKDMCJPBBIH item in ELGIHGBNEEL)
		{
			try
			{
				item.HBCDLJHLOMK(false, OJCKIOENBEL);
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Backend, "Executing a command  with 'FastFail' failed ({0}). Type:{1}", ex.Message, item.LOICNFDHCJK);
			}
		}
	}

	private IEnumerator PGMMBGIAJGJ()
	{
		while (CaravanSceneManager.GDLJAINDFOJ || LoadingScreenDisplayer.Instance.CDIJIMCMCOE)
		{
			yield return MCJHHDACJBG.KNLADMIBAAD;
		}
		yield return null;
		PPGOIFOCOAK.JOCMJBFJGON();
		PJPPADHKGHN.GABGKBAKHDP.MMECFKDOBDC();
		SceneManager.LoadScene("InitialScene");
		CLBLHMOGKGP = null;
	}

	public static void CCBPMBBOAKE(bool EEKJMDHEJCK, bool EPDLOFHNAKE)
	{
		if (ELBMHNOBHPN.DJGMHLLAGLE || (EEKJMDHEJCK && !EPDLOFHNAKE))
		{
			new LLCJMMBBLEH(HLLFGNAJJJH());
		}
		else
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Backend, "This device's progress has been chosen by server.");
		}
	}

	private static IEnumerator HLLFGNAJJJH()
	{
		while (CaravanSceneManager.GDLJAINDFOJ || LoadingScreenDisplayer.Instance.CDIJIMCMCOE || (MapManager.Instance != null && !MapManager.Instance.LMMGPLJKJHG))
		{
			yield return new WaitForSeconds(0.25f);
		}
		yield return null;
		CaravanSceneManager.Load(GKBHIKONCKJ.Map, "Refreshing");
	}
}
