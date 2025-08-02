using System;
using System.Collections.Generic;

public class JPAALKCPGNB
{
	public struct CNCHOJOHBLN
	{
		public readonly int PBPEMFGPGFC;

		public readonly string IOCMOCCFALN;

		internal readonly int ABLDGMBADCH;

		public CNCHOJOHBLN(int PBPEMFGPGFC, string IOCMOCCFALN)
		{
			this.PBPEMFGPGFC = PBPEMFGPGFC;
			this.IOCMOCCFALN = IOCMOCCFALN;
			ABLDGMBADCH = this.IOCMOCCFALN.GetHashCode();
		}
	}

	private class EIOEPBAPLAB : IEqualityComparer<CNCHOJOHBLN>
	{
		internal static readonly EIOEPBAPLAB GABGKBAKHDP = new EIOEPBAPLAB();

		bool IEqualityComparer<CNCHOJOHBLN>.Equals(CNCHOJOHBLN FOGAOEIPDFF, CNCHOJOHBLN KCOHLFCFOOE)
		{
			return FOGAOEIPDFF.PBPEMFGPGFC == KCOHLFCFOOE.PBPEMFGPGFC && FOGAOEIPDFF.ABLDGMBADCH == KCOHLFCFOOE.ABLDGMBADCH && FOGAOEIPDFF.IOCMOCCFALN == KCOHLFCFOOE.IOCMOCCFALN;
		}

		int IEqualityComparer<CNCHOJOHBLN>.GetHashCode(CNCHOJOHBLN AACCPLMFDIE)
		{
			return AACCPLMFDIE.PBPEMFGPGFC;
		}
	}

	internal string IOCMOCCFALN;

	private Dictionary<CNCHOJOHBLN, OAMNGFLKEFI> MLPNEHCDBOD = new Dictionary<CNCHOJOHBLN, OAMNGFLKEFI>(EIOEPBAPLAB.GABGKBAKHDP);

	public string PNGPLGHKFDI
	{
		get
		{
			return IOCMOCCFALN;
		}
	}

	public Dictionary<CNCHOJOHBLN, OAMNGFLKEFI> NLADLMOLKLK
	{
		get
		{
			return MLPNEHCDBOD;
		}
	}

	public JPAALKCPGNB(string IOCMOCCFALN)
	{
		if (IOCMOCCFALN == null)
		{
			throw new ArgumentNullException("name", "name cannot be null.");
		}
		this.IOCMOCCFALN = IOCMOCCFALN;
	}

	public void DJJIHPJOEBF(int PBPEMFGPGFC, string IOCMOCCFALN, OAMNGFLKEFI DFHHMKMLCFF)
	{
		if (DFHHMKMLCFF == null)
		{
			throw new ArgumentNullException("attachment", "attachment cannot be null.");
		}
		MLPNEHCDBOD[new CNCHOJOHBLN(PBPEMFGPGFC, IOCMOCCFALN)] = DFHHMKMLCFF;
	}

	public OAMNGFLKEFI JGHJDGIANDD(int PBPEMFGPGFC, string IOCMOCCFALN)
	{
		OAMNGFLKEFI value;
		MLPNEHCDBOD.TryGetValue(new CNCHOJOHBLN(PBPEMFGPGFC, IOCMOCCFALN), out value);
		return value;
	}

	public void IDPNBGBLJGL(int PBPEMFGPGFC, List<string> ANNGLDLKCBL)
	{
		if (ANNGLDLKCBL == null)
		{
			throw new ArgumentNullException("names", "names cannot be null.");
		}
		foreach (CNCHOJOHBLN key in MLPNEHCDBOD.Keys)
		{
			if (key.PBPEMFGPGFC == PBPEMFGPGFC)
			{
				ANNGLDLKCBL.Add(key.IOCMOCCFALN);
			}
		}
	}

	public void ELMEPCJAHJN(int PBPEMFGPGFC, List<OAMNGFLKEFI> MLPNEHCDBOD)
	{
		if (MLPNEHCDBOD == null)
		{
			throw new ArgumentNullException("attachments", "attachments cannot be null.");
		}
		foreach (KeyValuePair<CNCHOJOHBLN, OAMNGFLKEFI> item in this.MLPNEHCDBOD)
		{
			if (item.Key.PBPEMFGPGFC == PBPEMFGPGFC)
			{
				MLPNEHCDBOD.Add(item.Value);
			}
		}
	}

	public override string ToString()
	{
		return IOCMOCCFALN;
	}

	internal void MDFDKLHNHNK(GCJKICAPOFL GDNININLMFD, JPAALKCPGNB MOHEMJGBDDE)
	{
		foreach (KeyValuePair<CNCHOJOHBLN, OAMNGFLKEFI> item in MOHEMJGBDDE.MLPNEHCDBOD)
		{
			int pBPEMFGPGFC = item.Key.PBPEMFGPGFC;
			LBBAMMPJKDA lBBAMMPJKDA = GDNININLMFD.MAKCMFCFDLP.Items[pBPEMFGPGFC];
			if (lBBAMMPJKDA.AIKFOHCPLKG == item.Value)
			{
				OAMNGFLKEFI oAMNGFLKEFI = JGHJDGIANDD(pBPEMFGPGFC, item.Key.IOCMOCCFALN);
				if (oAMNGFLKEFI != null)
				{
					lBBAMMPJKDA.AIKFOHCPLKG = oAMNGFLKEFI;
				}
			}
		}
	}
}
