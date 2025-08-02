using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
public class DLDBGGDLOOO : IEnumerable
{
	private IList AAIEJDNAODP = LHFGHNFJIKM.PPPFFFBMGML();

	public LNKPCJLANAO AHANCLBKKID
	{
		get
		{
			return (LNKPCJLANAO)AAIEJDNAODP[EHJNMODJEAN];
		}
	}

	[Obsolete("Use 'Count' property instead")]
	public int PNBDAGKFOBN
	{
		get
		{
			return AAIEJDNAODP.Count;
		}
	}

	public int GMCGMPEEHJP
	{
		get
		{
			return AAIEJDNAODP.Count;
		}
	}

	public DLDBGGDLOOO(params LNKPCJLANAO[] AAIEJDNAODP)
	{
		JEACJNAKLDJ(AAIEJDNAODP);
	}

	public static DLDBGGDLOOO CNBGHHJJEJM(IEnumerable EKFOKNPODBK)
	{
		DLDBGGDLOOO dLDBGGDLOOO = new DLDBGGDLOOO();
		foreach (LNKPCJLANAO item in EKFOKNPODBK)
		{
			dLDBGGDLOOO.JEACJNAKLDJ(item);
		}
		return dLDBGGDLOOO;
	}

	public void JEACJNAKLDJ(params LNKPCJLANAO[] IALHHDFFAJK)
	{
		foreach (LNKPCJLANAO value in IALHHDFFAJK)
		{
			AAIEJDNAODP.Add(value);
		}
	}

	public void GCJCILJMBJF(params LNKPCJLANAO[] IALHHDFFAJK)
	{
		if (IALHHDFFAJK == null)
		{
			return;
		}
		foreach (LNKPCJLANAO lNKPCJLANAO in IALHHDFFAJK)
		{
			if (lNKPCJLANAO != null)
			{
				AAIEJDNAODP.Add(lNKPCJLANAO);
			}
		}
	}

	[Obsolete("Use 'object[index]' syntax instead")]
	public LNKPCJLANAO GHBGCADFLFB(int EHJNMODJEAN)
	{
		return this.ECNCPJGHBIG(EHJNMODJEAN);
	}

	public IEnumerator GetEnumerator()
	{
		return AAIEJDNAODP.GetEnumerator();
	}
}
