using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PNBPNBCJFEO
{
	[CompilerGenerated]
	private sealed class BOPCCLLEHPM : IEnumerator, IDisposable, IEnumerator<object>
	{
		internal string LCCKDPIBKPJ;

		internal WWW HGOOIOHAIOK;

		internal string IOCMOCCFALN;

		internal string DFCJKBHFPMG;

		internal object ACLDFCNKEBA;

		internal bool LPBBDEOBEKI;

		internal int FLBKIGMFIOG;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return ACLDFCNKEBA;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return ACLDFCNKEBA;
			}
		}

		[DebuggerHidden]
		public BOPCCLLEHPM()
		{
		}

		public bool MoveNext()
		{
			uint num = (uint)FLBKIGMFIOG;
			FLBKIGMFIOG = -1;
			bool flag = false;
			switch (num)
			{
			case 0u:
				HGOOIOHAIOK = new WWW(LCCKDPIBKPJ);
				num = 4294967293u;
				goto case 1u;
			case 1u:
				try
				{
					switch (num)
					{
					default:
						if (HGOOIOHAIOK.isDone)
						{
							if (string.IsNullOrEmpty(HGOOIOHAIOK.error))
							{
								GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Download with www path: {0}", LCCKDPIBKPJ);
								File.WriteAllBytes(Path.Combine(JMFBBJHFMIM.PPENNIADOEL, IOCMOCCFALN), HGOOIOHAIOK.bytes);
								CDAKABCMLGA lLIEHCKNJEM = new CDAKABCMLGA
								{
									BEBMJGNKAPG = LCCKDPIBKPJ,
									IKNGODJEKEA = HGOOIOHAIOK.bytesDownloaded,
									BJMDAELAELI = HGOOIOHAIOK.bytesDownloaded,
									FOIACLCGMLF = FIBJIOBINHL.CFBJBKEPGAN().ToString(),
									DMAGNMIOAEJ = IOCMOCCFALN,
									AEPLIGFCGIF = 2,
									AMEDMLOCCBG = DFCJKBHFPMG
								};
								FCJAAJLPCMB.GABGKBAKHDP.LFHHPPDJGDC(lLIEHCKNJEM);
							}
							else
							{
								GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Download, "Download with www exception: {0}", HGOOIOHAIOK.error);
							}
							break;
						}
						ACLDFCNKEBA = null;
						if (!LPBBDEOBEKI)
						{
							FLBKIGMFIOG = 1;
						}
						flag = true;
						goto end_IL_0037;
					}
					goto IL_0174;
					end_IL_0037:;
				}
				finally
				{
					if (!flag)
					{
						FOHHLBAKLBP();
					}
				}
				return true;
			default:
				{
					return false;
				}
				IL_0174:
				FLBKIGMFIOG = -1;
				goto default;
			}
		}

		[DebuggerHidden]
		public void Dispose()
		{
			uint fLBKIGMFIOG = (uint)FLBKIGMFIOG;
			LPBBDEOBEKI = true;
			FLBKIGMFIOG = -1;
			switch (fLBKIGMFIOG)
			{
			case 1u:
				try
				{
					break;
				}
				finally
				{
					FOHHLBAKLBP();
				}
			case 0u:
				break;
			}
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		private void FOHHLBAKLBP()
		{
			if (HGOOIOHAIOK != null)
			{
				((IDisposable)HGOOIOHAIOK).Dispose();
			}
		}
	}

	private readonly JMFBBJHFMIM KHGHPJCEJBE;

	public PNBPNBCJFEO()
	{
		KHGHPJCEJBE = JMFBBJHFMIM.GABGKBAKHDP;
	}

	public void PPMCKIKDOLO(string IOCMOCCFALN, string LNCBFPEKHDJ, string DFCJKBHFPMG, bool LBGMDNNDPJL)
	{
		if (MCJHHDACJBG.MCPELNPBPIF && !MCJHHDACJBG.OCLBKDOFADM && LBGMDNNDPJL)
		{
			if (KHGHPJCEJBE.FGEFBNBMOOE(IOCMOCCFALN))
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "No need to download {0}", LNCBFPEKHDJ);
			}
			else
			{
				new LLCJMMBBLEH(IJCHGKOGFPK(IOCMOCCFALN, LNCBFPEKHDJ, DFCJKBHFPMG));
			}
		}
		else
		{
			KHGHPJCEJBE.DKNOFPLNNLI(IOCMOCCFALN, LNCBFPEKHDJ, DFCJKBHFPMG);
		}
	}

	public static bool FGEFBNBMOOE(int BDKFNEDHAOJ)
	{
		string cHHHPCOIFJJ = BDKFNEDHAOJ.ToString();
		string lOKMKDKABPI = HLKAEJCPMEB.JDALCCECHEE(cHHHPCOIFJJ, "NewMap");
		string lOKMKDKABPI2 = HLKAEJCPMEB.JDALCCECHEE(cHHHPCOIFJJ, "NewMapGame");
		return JMFBBJHFMIM.GABGKBAKHDP.FGEFBNBMOOE(lOKMKDKABPI) && JMFBBJHFMIM.GABGKBAKHDP.FGEFBNBMOOE(lOKMKDKABPI2);
	}

	public static void MCJNJLLHIIH(string BDKFNEDHAOJ)
	{
		string lOKMKDKABPI = HLKAEJCPMEB.JDALCCECHEE(BDKFNEDHAOJ, "NewMap");
		string lOKMKDKABPI2 = HLKAEJCPMEB.JDALCCECHEE(BDKFNEDHAOJ, "NewMapGame");
		JMFBBJHFMIM.GABGKBAKHDP.DBIBKMMPJBM(lOKMKDKABPI);
		JMFBBJHFMIM.GABGKBAKHDP.DBIBKMMPJBM(lOKMKDKABPI2);
	}

	private IEnumerator IJCHGKOGFPK(string IOCMOCCFALN, string LCCKDPIBKPJ, string DFCJKBHFPMG)
	{
		WWW wWW = new WWW(LCCKDPIBKPJ);
		try
		{
			while (!wWW.isDone)
			{
				yield return null;
			}
			if (string.IsNullOrEmpty(wWW.error))
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Download with www path: {0}", LCCKDPIBKPJ);
				File.WriteAllBytes(Path.Combine(JMFBBJHFMIM.PPENNIADOEL, IOCMOCCFALN), wWW.bytes);
				CDAKABCMLGA cDAKABCMLGA = new CDAKABCMLGA();
				cDAKABCMLGA.BEBMJGNKAPG = LCCKDPIBKPJ;
				cDAKABCMLGA.IKNGODJEKEA = wWW.bytesDownloaded;
				cDAKABCMLGA.BJMDAELAELI = wWW.bytesDownloaded;
				cDAKABCMLGA.FOIACLCGMLF = FIBJIOBINHL.CFBJBKEPGAN().ToString();
				cDAKABCMLGA.DMAGNMIOAEJ = IOCMOCCFALN;
				cDAKABCMLGA.AEPLIGFCGIF = 2;
				cDAKABCMLGA.AMEDMLOCCBG = DFCJKBHFPMG;
				CDAKABCMLGA lLIEHCKNJEM = cDAKABCMLGA;
				FCJAAJLPCMB.GABGKBAKHDP.LFHHPPDJGDC(lLIEHCKNJEM);
			}
			else
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Download, "Download with www exception: {0}", wWW.error);
			}
		}
		finally
		{
			((BOPCCLLEHPM)this).FOHHLBAKLBP();
		}
	}
}
