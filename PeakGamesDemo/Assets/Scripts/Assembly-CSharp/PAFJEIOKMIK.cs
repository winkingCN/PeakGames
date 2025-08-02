using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Facebook.Unity;

public class PAFJEIOKMIK
{
	private class HOJFBGNKPGK
	{
		public readonly string EHNKLBBAKCA;

		public readonly string MJCBDBIDMGF;

		public readonly Action<string, bool> CECMINAKHFJ;

		public readonly bool HAOHFJKKHBO;

		public readonly string EGJMCCKEMLD;

		public int DNJGCGBEBFG;

		public HOJFBGNKPGK(string FAHBFGOFJGI, string LCCKDPIBKPJ, Action<string, bool> IMHLFAHONPP, bool GKGOFPKOBON, bool JDODJIBJPFH)
		{
			EHNKLBBAKCA = FAHBFGOFJGI;
			MJCBDBIDMGF = LCCKDPIBKPJ;
			CECMINAKHFJ = IMHLFAHONPP;
			HAOHFJKKHBO = JDODJIBJPFH;
			EGJMCCKEMLD = DILKBHCCINN.FHKPGGMPOGL(FAHBFGOFJGI);
		}

		public override bool Equals(object NEMEKIOEOLC)
		{
			return this == NEMEKIOEOLC || EHNKLBBAKCA.Equals(((HOJFBGNKPGK)NEMEKIOEOLC).EHNKLBBAKCA);
		}

		public override int GetHashCode()
		{
			return EHNKLBBAKCA.GetHashCode();
		}
	}

	[CompilerGenerated]
	private sealed class DNHFIKDPHMP
	{
		internal HOJFBGNKPGK EJCNAJOHBFI;

		internal PAFJEIOKMIK PDAPIGLEPGC;

		internal void AGFNGEFDHLA(bool ILOJNBKMEJA)
		{
			if (ILOJNBKMEJA)
			{
				GLPICIAEDKE.DNOMDLMKDHP(EJCNAJOHBFI.EHNKLBBAKCA, EJCNAJOHBFI.CECMINAKHFJ, EJCNAJOHBFI.HAOHFJKKHBO);
			}
			else if (EJCNAJOHBFI.DNJGCGBEBFG < 2)
			{
				EJCNAJOHBFI.DNJGCGBEBFG++;
				PDAPIGLEPGC.MPBCCPDACFO(EJCNAJOHBFI);
			}
			else if (EJCNAJOHBFI.CECMINAKHFJ != null)
			{
				EJCNAJOHBFI.CECMINAKHFJ(EJCNAJOHBFI.EHNKLBBAKCA, false);
			}
		}
	}

	private readonly JMFBBJHFMIM LGBGLDOFOII;

	private static PAFJEIOKMIK KNPOFJNFLJB;

	private string HOJJEIPAAJO;

	private Dictionary<string, LLCJMMBBLEH> LGBKOONGNLD;

	public static PAFJEIOKMIK GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new PAFJEIOKMIK();
			}
			return KNPOFJNFLJB;
		}
	}

	private PAFJEIOKMIK()
	{
		LGBGLDOFOII = JMFBBJHFMIM.GABGKBAKHDP;
	}

	public void NNMEBAOIJAM(string FAHBFGOFJGI, string LCCKDPIBKPJ, Action<string, bool> PHNLPMINNAE, bool GKGOFPKOBON = true, bool JDODJIBJPFH = false)
	{
		string lOKMKDKABPI = DILKBHCCINN.FHKPGGMPOGL(FAHBFGOFJGI);
		if (GLPICIAEDKE.AONKBLIBOCE(lOKMKDKABPI) && GKGOFPKOBON)
		{
			PHNLPMINNAE(FAHBFGOFJGI, true);
			return;
		}
		HOJFBGNKPGK hOJFBGNKPGK = new HOJFBGNKPGK(FAHBFGOFJGI, LCCKDPIBKPJ, PHNLPMINNAE, GKGOFPKOBON, JDODJIBJPFH);
		if (LGBGLDOFOII.FGEFBNBMOOE(hOJFBGNKPGK.EGJMCCKEMLD))
		{
			GLPICIAEDKE.DNOMDLMKDHP(hOJFBGNKPGK.EHNKLBBAKCA, hOJFBGNKPGK.CECMINAKHFJ, JDODJIBJPFH);
		}
		else
		{
			MPBCCPDACFO(hOJFBGNKPGK);
		}
	}

	public void NMEGHFKDDNO()
	{
		try
		{
			if (LGBGLDOFOII != null)
			{
				LGBGLDOFOII.DMOHBEFHPFP();
			}
			if (LGBKOONGNLD != null && LGBKOONGNLD.Count > 0)
			{
				foreach (LLCJMMBBLEH value in LGBKOONGNLD.Values)
				{
					if (value != null)
					{
						value.BPPFBMCJOAH();
					}
				}
			}
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.FBImagesManager, "Unexpected error: {0}", ex.Message);
		}
		if (LGBKOONGNLD != null)
		{
			LGBKOONGNLD.Clear();
		}
	}

	private void MPBCCPDACFO(HOJFBGNKPGK EJCNAJOHBFI)
	{
		if (LGBKOONGNLD == null)
		{
			LGBKOONGNLD = new Dictionary<string, LLCJMMBBLEH>();
		}
		if (HOJJEIPAAJO == null && AccessToken.CurrentAccessToken != null && (AccessToken.CurrentAccessToken.ExpirationTime - DateTime.Now).TotalMinutes > 1.0)
		{
			HOJJEIPAAJO = AccessToken.CurrentAccessToken.TokenString;
		}
		string text = HOJJEIPAAJO ?? string.Empty;
		string text2 = EJCNAJOHBFI.MJCBDBIDMGF ?? ("https://graph.facebook.com/" + EJCNAJOHBFI.EHNKLBBAKCA + "/picture?type=large&access_token=" + text);
		LGBGLDOFOII.DKNOFPLNNLI(EJCNAJOHBFI.EGJMCCKEMLD, text2, text2);
		LLCJMMBBLEH value = new LLCJMMBBLEH(LGBGLDOFOII.IOOJFNBMNDJ(null, KCHMHOAELIA(EJCNAJOHBFI), EJCNAJOHBFI.EGJMCCKEMLD), true, IAJNLGPHGLO.App);
		LGBKOONGNLD.Add(EJCNAJOHBFI.EGJMCCKEMLD, value);
	}

	private Action<bool> KCHMHOAELIA(HOJFBGNKPGK EJCNAJOHBFI)
	{
		if (LGBKOONGNLD.ContainsKey(EJCNAJOHBFI.EGJMCCKEMLD))
		{
			LGBKOONGNLD.Remove(EJCNAJOHBFI.EGJMCCKEMLD);
		}
		return delegate(bool ILOJNBKMEJA)
		{
			if (ILOJNBKMEJA)
			{
				GLPICIAEDKE.DNOMDLMKDHP(EJCNAJOHBFI.EHNKLBBAKCA, EJCNAJOHBFI.CECMINAKHFJ, EJCNAJOHBFI.HAOHFJKKHBO);
			}
			else if (EJCNAJOHBFI.DNJGCGBEBFG < 2)
			{
				EJCNAJOHBFI.DNJGCGBEBFG++;
				MPBCCPDACFO(EJCNAJOHBFI);
			}
			else if (EJCNAJOHBFI.CECMINAKHFJ != null)
			{
				EJCNAJOHBFI.CECMINAKHFJ(EJCNAJOHBFI.EHNKLBBAKCA, false);
			}
		};
	}

	public string MIBANEDNLOA(string FAHBFGOFJGI)
	{
		string lOKMKDKABPI = DILKBHCCINN.FHKPGGMPOGL(FAHBFGOFJGI);
		return JMFBBJHFMIM.GABGKBAKHDP.BGCJPEAMBIP(lOKMKDKABPI);
	}
}
