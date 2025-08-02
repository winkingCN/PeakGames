using System;
using System.Collections;
using System.IO;
using System.Reflection;

[DefaultMember("Item")]
public abstract class ALLINHNNNJN : EDOEBJJFOBM, IEnumerable
{
	private class CAHNGMFGGBM : GDHBILADCFG, HGIAHEKANFO
	{
		private readonly ALLINHNNNJN ADHOAIJECKE;

		private readonly int NHLJFKPLKLI;

		private int EHJNMODJEAN;

		public CAHNGMFGGBM(ALLINHNNNJN ADHOAIJECKE)
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

		public EDOEBJJFOBM IIHKEACDNID()
		{
			return ADHOAIJECKE;
		}
	}

	private readonly IList MIABODPHOIP;

	public virtual GDHBILADCFG NIJNIHGOKCA
	{
		get
		{
			return new CAHNGMFGGBM(this);
		}
	}

	public virtual LNKPCJLANAO AHANCLBKKID
	{
		get
		{
			return (LNKPCJLANAO)MIABODPHOIP[EHJNMODJEAN];
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
			return MIABODPHOIP.Count;
		}
	}

	protected internal ALLINHNNNJN(int MDPEMCMPAMB)
	{
		MIABODPHOIP = LHFGHNFJIKM.PPPFFFBMGML(MDPEMCMPAMB);
	}

	public static ALLINHNNNJN BJLJCGFMFOO(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null || NEMEKIOEOLC is ALLINHNNNJN)
		{
			return (ALLINHNNNJN)NEMEKIOEOLC;
		}
		if (NEMEKIOEOLC is GDHBILADCFG)
		{
			return BJLJCGFMFOO(((GDHBILADCFG)NEMEKIOEOLC).IIHKEACDNID());
		}
		if (NEMEKIOEOLC is byte[])
		{
			try
			{
				return BJLJCGFMFOO(EDOEBJJFOBM.HPDCKMOPEMM((byte[])NEMEKIOEOLC));
			}
			catch (IOException ex)
			{
				throw new ArgumentException("failed to construct sequence from byte[]: " + ex.Message);
			}
		}
		if (NEMEKIOEOLC is LNKPCJLANAO)
		{
			EDOEBJJFOBM eDOEBJJFOBM = ((LNKPCJLANAO)NEMEKIOEOLC).IIHKEACDNID();
			if (eDOEBJJFOBM is ALLINHNNNJN)
			{
				return (ALLINHNNNJN)eDOEBJJFOBM;
			}
		}
		throw new ArgumentException("Unknown object in GetInstance: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC), "obj");
	}

	public static ALLINHNNNJN BJLJCGFMFOO(PAANMJLACEF NEMEKIOEOLC, bool DHGLJHFEJFL)
	{
		EDOEBJJFOBM eDOEBJJFOBM = NEMEKIOEOLC.NFMFKPLPLLH();
		if (DHGLJHFEJFL)
		{
			if (!NEMEKIOEOLC.PEMPMPFCPFN())
			{
				throw new ArgumentException("object implicit - explicit expected.");
			}
			return (ALLINHNNNJN)eDOEBJJFOBM;
		}
		if (NEMEKIOEOLC.PEMPMPFCPFN())
		{
			if (NEMEKIOEOLC is FOGPHMBLIMH)
			{
				return new KBOHOKHJFBA(eDOEBJJFOBM);
			}
			return new KOGPLMALOEH(eDOEBJJFOBM);
		}
		if (eDOEBJJFOBM is ALLINHNNNJN)
		{
			return (ALLINHNNNJN)eDOEBJJFOBM;
		}
		throw new ArgumentException("Unknown object in GetInstance: " + LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC), "obj");
	}

	public virtual IEnumerator GetEnumerator()
	{
		return MIABODPHOIP.GetEnumerator();
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
		ALLINHNNNJN aLLINHNNNJN = LABMKGMAEGK as ALLINHNNNJN;
		if (aLLINHNNNJN == null)
		{
			return false;
		}
		if (GMCGMPEEHJP != aLLINHNNNJN.GMCGMPEEHJP)
		{
			return false;
		}
		IEnumerator enumerator = GetEnumerator();
		IEnumerator enumerator2 = aLLINHNNNJN.GetEnumerator();
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

	protected internal void HIJCJONMAJO(LNKPCJLANAO NEMEKIOEOLC)
	{
		MIABODPHOIP.Add(NEMEKIOEOLC);
	}

	public override string ToString()
	{
		return FKHLBMJPCIM.NHMGCGBMCNM(MIABODPHOIP);
	}
}
