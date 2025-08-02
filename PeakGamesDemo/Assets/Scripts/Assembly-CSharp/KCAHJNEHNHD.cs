using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using UnityEngine;
using Utils.Game;

internal class KCAHJNEHNHD
{
	private readonly object KNJOLPIEHHA = new object();

	private readonly int GBKOCCHCKEO = 100;

	private readonly Thread JNBIJKHDNOO;

	private List<object> BKHGLMHPKFN = new List<object>();

	private volatile bool JGMLKGCLMME;

	private List<object> FDEJLCODMBB = new List<object>();

	protected int LPAJEIFHEDA = 1000;

	public StringBuilder LOGBJEBNPFO = new StringBuilder(6000);

	public bool DHIOLFKEALL;

	protected MJCGFFMHEDC KMCEPAFJOJI;

	private const string EJGHOAEKAIA = "Log";

	private const string GAFBJJPMHIK = "Warning";

	private const string BMHKGJCIJCN = "Exception";

	private const string IIALIHCHDGK = "Error";

	private readonly string[] DJGJMELBODD;

	private bool INHJFGIDKDO;

	public KCAHJNEHNHD(string LCCKDPIBKPJ)
	{
		IEnumerable<PBIIDJOKNEK> source = Enum.GetValues(typeof(PBIIDJOKNEK)).Cast<PBIIDJOKNEK>();
		DJGJMELBODD = new string[source.Count()];
		KMCEPAFJOJI = new MJCGFFMHEDC(LCCKDPIBKPJ);
		JNBIJKHDNOO = new Thread(NPCPALFEGAE);
		JGMLKGCLMME = true;
		JNBIJKHDNOO.Start();
	}

	public void ILNNDCGJCKG(PBIIDJOKNEK MOKLDCMGFFB, string OEFCOJLNCKP, object[] GLGKHJMHOFP = null, DGLNAIKJGHP NBFBPNNEKMN = DGLNAIKJGHP.Log, GamePlayRecord HPFPDJHBNIE = null)
	{
		lock (KNJOLPIEHHA)
		{
			LOGBJEBNPFO.Length = 0;
			LOGBJEBNPFO.Append(DateTime.UtcNow.ToString("dd-MM-yyyy | HH:mm:ss.fff"));
			LOGBJEBNPFO.Append(" | ").Append(FDKPOPIAAAC(NBFBPNNEKMN)).Append(" | ")
				.Append(FDKPOPIAAAC(MOKLDCMGFFB))
				.Append(":");
			if (HPFPDJHBNIE != null)
			{
				BKHGLMHPKFN.Add(new DFPBMFGIFHE(LOGBJEBNPFO.ToString(), HPFPDJHBNIE));
			}
			else
			{
				if (GLGKHJMHOFP != null && GLGKHJMHOFP.Length > 0)
				{
					LOGBJEBNPFO.AppendFormat(OEFCOJLNCKP, GLGKHJMHOFP);
				}
				else
				{
					LOGBJEBNPFO.Append(OEFCOJLNCKP);
				}
				string item = LOGBJEBNPFO.ToString();
				BKHGLMHPKFN.Add(item);
			}
			if (BKHGLMHPKFN.Count >= GBKOCCHCKEO)
			{
				Monitor.Pulse(KNJOLPIEHHA);
			}
		}
	}

	private string FDKPOPIAAAC(PBIIDJOKNEK NBFBPNNEKMN)
	{
		string text = DJGJMELBODD[(int)NBFBPNNEKMN];
		if (text != null)
		{
			return text;
		}
		text = NBFBPNNEKMN.ToString();
		DJGJMELBODD[(int)NBFBPNNEKMN] = text;
		return text;
	}

	private static string FDKPOPIAAAC(DGLNAIKJGHP NBFBPNNEKMN)
	{
		switch (NBFBPNNEKMN)
		{
		case DGLNAIKJGHP.Log:
			return "Log";
		case DGLNAIKJGHP.Warning:
			return "Warning";
		case DGLNAIKJGHP.Exception:
			return "Exception";
		default:
			return "Error";
		}
	}

	public void CPGJCKCOABM()
	{
		if (!DHIOLFKEALL)
		{
			DHIOLFKEALL = true;
			if (!Application.isEditor)
			{
				Application.logMessageReceivedThreaded += MIECEDFIOFB;
			}
		}
	}

	public void IGDBIMMIMBE(int HJLKIKDFKBH)
	{
		if (HJLKIKDFKBH > 0)
		{
			LPAJEIFHEDA = HJLKIKDFKBH;
		}
	}

	public void EMPALCMOADM(NCHDGFIAHLI MJAHNNPOLHL)
	{
		KMCEPAFJOJI.LMFHLALOCMD(MJAHNNPOLHL);
	}

	private void NPCPALFEGAE()
	{
		while (JGMLKGCLMME)
		{
			lock (KNJOLPIEHHA)
			{
				Monitor.Wait(KNJOLPIEHHA, LPAJEIFHEDA);
				List<object> bKHGLMHPKFN = BKHGLMHPKFN;
				BKHGLMHPKFN = FDEJLCODMBB;
				FDEJLCODMBB = bKHGLMHPKFN;
			}
			try
			{
				for (int i = 0; i < FDEJLCODMBB.Count; i++)
				{
					KMCEPAFJOJI.KBMOJGCCCEN(FDEJLCODMBB[i].ToString());
				}
			}
			catch
			{
			}
			finally
			{
				FDEJLCODMBB.Clear();
			}
		}
		try
		{
			KMCEPAFJOJI.Dispose();
			JNBIJKHDNOO.Abort();
		}
		catch (Exception ex)
		{
			Debug.LogWarning("Clear platform:" + ex.Message);
		}
	}

	private void MIECEDFIOFB(string OEFCOJLNCKP, string MECGPCLCGKG, LogType NBFBPNNEKMN)
	{
		if (NBFBPNNEKMN != LogType.Log)
		{
			DGLNAIKJGHP nBFBPNNEKMN = DGLNAIKJGHP.Log;
			switch (NBFBPNNEKMN)
			{
			case LogType.Warning:
				nBFBPNNEKMN = DGLNAIKJGHP.Warning;
				break;
			case LogType.Exception:
				nBFBPNNEKMN = DGLNAIKJGHP.Exception;
				break;
			case LogType.Error:
				CMPBCFBIFNP(OEFCOJLNCKP, MECGPCLCGKG);
				nBFBPNNEKMN = DGLNAIKJGHP.Error;
				break;
			}
			if (MECGPCLCGKG.Length > 0)
			{
				OEFCOJLNCKP = OEFCOJLNCKP + "\n" + MECGPCLCGKG;
			}
			ILNNDCGJCKG(PBIIDJOKNEK.LogManager, OEFCOJLNCKP, null, nBFBPNNEKMN);
		}
	}

	private void CMPBCFBIFNP(string LENFKJMEBFP, string MECGPCLCGKG)
	{
		if (!INHJFGIDKDO && LENFKJMEBFP.Contains("file zip crc"))
		{
			NHNBFBDHKGN.JFPLDMEBIJH("Compression Error", LENFKJMEBFP, MECGPCLCGKG);
			INHJFGIDKDO = true;
		}
	}

	public void KIFBCOFOBAE()
	{
		JGMLKGCLMME = false;
	}

	public void NMCJJLGANMC()
	{
		KIFBCOFOBAE();
		KMCEPAFJOJI.GIOCEEGBFKL();
	}
}
