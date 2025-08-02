using System;
using System.Collections;
using System.IO;
using System.Reflection;

[DefaultMember("Item")]
public abstract class FAGODOKGMEH : EDOEBJJFOBM, IEnumerable
{
	private class JFJCBLOFEDE : JBMFHKBENEK, HGIAHEKANFO
	{
		private readonly FAGODOKGMEH ADHOAIJECKE;

		private readonly int NHLJFKPLKLI;

		private int EHJNMODJEAN;

		public JFJCBLOFEDE(FAGODOKGMEH ADHOAIJECKE)
		{
			this.ADHOAIJECKE = ADHOAIJECKE;
			NHLJFKPLKLI = ADHOAIJECKE.GMCGMPEEHJP;
		}

		public HGIAHEKANFO DMHLIGLGJGI()
		{
			if (EHJNMODJEAN == NHLJFKPLKLI)
			{
				return null;
			}
			LNKPCJLANAO lNKPCJLANAO = ADHOAIJECKE.ECNCPJGHBIG(EHJNMODJEAN++);
			if (lNKPCJLANAO is ALLINHNNNJN)
			{
				return ((ALLINHNNNJN)lNKPCJLANAO).NIJNIHGOKCA;
			}
			if (lNKPCJLANAO is FAGODOKGMEH)
			{
				return ((FAGODOKGMEH)lNKPCJLANAO).NIJNIHGOKCA;
			}
			return lNKPCJLANAO;
		}

		public virtual EDOEBJJFOBM IIHKEACDNID()
		{
			return ADHOAIJECKE;
		}
	}

	private class FJOKKIMFJOK : IComparer
	{
		public int Compare(object AMFCENFNAJJ, object CNLILOEEBOJ)
		{
			byte[] array = (byte[])AMFCENFNAJJ;
			byte[] array2 = (byte[])CNLILOEEBOJ;
			int num = Math.Min(array.Length, array2.Length);
			for (int i = 0; i != num; i++)
			{
				byte b = array[i];
				byte b2 = array2[i];
				if (b != b2)
				{
					return (b >= b2) ? 1 : (-1);
				}
			}
			if (array.Length > array2.Length)
			{
				return (!HGPMGDMPAJN(array, num)) ? 1 : 0;
			}
			if (array.Length < array2.Length)
			{
				return (!HGPMGDMPAJN(array2, num)) ? (-1) : 0;
			}
			return 0;
		}

		private bool HGPMGDMPAJN(byte[] FAPGOCDNGIB, int FADJPCHMMBH)
		{
			while (FADJPCHMMBH < FAPGOCDNGIB.Length)
			{
				if (FAPGOCDNGIB[FADJPCHMMBH++] != 0)
				{
					return false;
				}
			}
			return true;
		}
	}

	private readonly IList PPFHKHBDOFP;

	public virtual LNKPCJLANAO AHANCLBKKID
	{
		get
		{
			return (LNKPCJLANAO)PPFHKHBDOFP[EHJNMODJEAN];
		}
	}

	[Obsolete("Use 'Count' property instead")]
	public int PNBDAGKFOBN
	{
		get
		{
			return GMCGMPEEHJP;
		}
	}

	public virtual int GMCGMPEEHJP
	{
		get
		{
			return PPFHKHBDOFP.Count;
		}
	}

	public JBMFHKBENEK NIJNIHGOKCA
	{
		get
		{
			return new JFJCBLOFEDE(this);
		}
	}

	protected internal FAGODOKGMEH(int MDPEMCMPAMB)
	{
		PPFHKHBDOFP = LHFGHNFJIKM.PPPFFFBMGML(MDPEMCMPAMB);
	}

	public static FAGODOKGMEH BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is FAGODOKGMEH)
		{
			return (FAGODOKGMEH)NEMEKIOEOLC;
		}
		if (NEMEKIOEOLC is JBMFHKBENEK)
		{
			return BJLJCGFMFOO(((JBMFHKBENEK)NEMEKIOEOLC).IIHKEACDNID());
		}
		if (NEMEKIOEOLC is byte[])
		{
			try
			{
				return BJLJCGFMFOO(EDOEBJJFOBM.HPDCKMOPEMM((byte[])NEMEKIOEOLC));
			}
			catch (IOException ex)
			{
				throw new ArgumentException("failed to construct set from byte[]: " + ex.Message);
			}
		}
		if (NEMEKIOEOLC is LNKPCJLANAO)
		{
			EDOEBJJFOBM eDOEBJJFOBM = ((LNKPCJLANAO)NEMEKIOEOLC).IIHKEACDNID();
			if (eDOEBJJFOBM is FAGODOKGMEH)
			{
				return (FAGODOKGMEH)eDOEBJJFOBM;
			}
		}
		throw new ArgumentException("Unknown object in GetInstance: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC), "obj");
	}

	public static FAGODOKGMEH BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DHGLJHFEJFL)
	{
		EDOEBJJFOBM eDOEBJJFOBM = NEMEKIOEOLC.NFMFKPLPLLH();
		if (DHGLJHFEJFL)
		{
			if (!NEMEKIOEOLC.PEMPMPFCPFN())
			{
				throw new ArgumentException("object implicit - explicit expected.");
			}
			return (FAGODOKGMEH)eDOEBJJFOBM;
		}
		if (NEMEKIOEOLC.PEMPMPFCPFN())
		{
			return new CDHAHIDPGBP(eDOEBJJFOBM);
		}
		if (eDOEBJJFOBM is FAGODOKGMEH)
		{
			return (FAGODOKGMEH)eDOEBJJFOBM;
		}
		if (eDOEBJJFOBM is ALLINHNNNJN)
		{
			DLDBGGDLOOO dLDBGGDLOOO = new DLDBGGDLOOO();
			ALLINHNNNJN aLLINHNNNJN = (ALLINHNNNJN)eDOEBJJFOBM;
			foreach (LNKPCJLANAO item in aLLINHNNNJN)
			{
				dLDBGGDLOOO.JEACJNAKLDJ(item);
			}
			return new CDHAHIDPGBP(dLDBGGDLOOO, false);
		}
		throw new ArgumentException("Unknown object in GetInstance: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC), "obj");
	}

	public virtual IEnumerator GetEnumerator()
	{
		return PPFHKHBDOFP.GetEnumerator();
	}

	[Obsolete("Use GetEnumerator() instead")]
	public IEnumerator NELJFJIOJEI()
	{
		return GetEnumerator();
	}

	[Obsolete("Use 'object[index]' syntax instead")]
	public LNKPCJLANAO IJLFFFFOKIB(int EHJNMODJEAN)
	{
		return this.ECNCPJGHBIG(EHJNMODJEAN);
	}

	public virtual LNKPCJLANAO[] GDPLKNIEGDB()
	{
		LNKPCJLANAO[] array = new LNKPCJLANAO[GMCGMPEEHJP];
		for (int i = 0; i < GMCGMPEEHJP; i++)
		{
			array[i] = this.ECNCPJGHBIG(i);
		}
		return array;
	}

	protected override int BGFGDLGFEPI()
	{
		int num = GMCGMPEEHJP;
		IEnumerator enumerator = GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object current = enumerator.Current;
				num *= 17;
				num = ((current != null) ? (num ^ current.GetHashCode()) : (num ^ HLAKNNHGPNP.GABGKBAKHDP.GetHashCode()));
			}
			return num;
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
	}

	protected override bool IMHPDJGGAGJ(EDOEBJJFOBM LABMKGMAEGK)
	{
		FAGODOKGMEH fAGODOKGMEH = LABMKGMAEGK as FAGODOKGMEH;
		if (fAGODOKGMEH == null)
		{
			return false;
		}
		if (GMCGMPEEHJP != fAGODOKGMEH.GMCGMPEEHJP)
		{
			return false;
		}
		IEnumerator enumerator = GetEnumerator();
		IEnumerator enumerator2 = fAGODOKGMEH.GetEnumerator();
		while (enumerator.MoveNext() && enumerator2.MoveNext())
		{
			EDOEBJJFOBM eDOEBJJFOBM = OAFAPDHKFLP(enumerator).IIHKEACDNID();
			EDOEBJJFOBM obj = OAFAPDHKFLP(enumerator2).IIHKEACDNID();
			if (!eDOEBJJFOBM.Equals(obj))
			{
				return false;
			}
		}
		return true;
	}

	private LNKPCJLANAO OAFAPDHKFLP(IEnumerator EKFOKNPODBK)
	{
		LNKPCJLANAO lNKPCJLANAO = (LNKPCJLANAO)EKFOKNPODBK.Current;
		if (lNKPCJLANAO == null)
		{
			return HLAKNNHGPNP.GABGKBAKHDP;
		}
		return lNKPCJLANAO;
	}

	protected internal void FCNOEDGGBBO()
	{
		if (PPFHKHBDOFP.Count >= 2)
		{
			LNKPCJLANAO[] array = new LNKPCJLANAO[PPFHKHBDOFP.Count];
			byte[][] array2 = new byte[PPFHKHBDOFP.Count][];
			for (int i = 0; i < PPFHKHBDOFP.Count; i++)
			{
				array2[i] = (array[i] = (LNKPCJLANAO)PPFHKHBDOFP[i]).PPCPBIEGJKM("DER");
			}
			Array.Sort(array2, array, new FJOKKIMFJOK());
			for (int j = 0; j < PPFHKHBDOFP.Count; j++)
			{
				PPFHKHBDOFP[j] = array[j];
			}
		}
	}

	protected internal void HIJCJONMAJO(LNKPCJLANAO NEMEKIOEOLC)
	{
		PPFHKHBDOFP.Add(NEMEKIOEOLC);
	}

	public override string ToString()
	{
		return FKHLBMJPCIM.NHMGCGBMCNM(PPFHKHBDOFP);
	}
}
