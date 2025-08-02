using System;
using System.Collections;

public class DMAOKHPCPIA : LKBPEOBFKMJ, ICollection, IEnumerable
{
	private readonly IDictionary LJBDGPIHDIC = LHFGHNFJIKM.JBEOCJEMGCE();

	public virtual int GMCGMPEEHJP
	{
		get
		{
			return LJBDGPIHDIC.Count;
		}
	}

	public virtual bool DHIKCKFGKID
	{
		get
		{
			return LJBDGPIHDIC.Count == 0;
		}
	}

	public virtual bool NEEAAJLLAGM
	{
		get
		{
			return LJBDGPIHDIC.IsFixedSize;
		}
	}

	public virtual bool ILMKNJIIHIJ
	{
		get
		{
			return LJBDGPIHDIC.IsReadOnly;
		}
	}

	public virtual bool CELEJFDNOOP
	{
		get
		{
			return LJBDGPIHDIC.IsSynchronized;
		}
	}

	public virtual object GAILGFEKIEK
	{
		get
		{
			return LJBDGPIHDIC.SyncRoot;
		}
	}

	public DMAOKHPCPIA()
	{
	}

	public DMAOKHPCPIA(IEnumerable IBBBMACIBGK)
	{
		foreach (object item in IBBBMACIBGK)
		{
			JEACJNAKLDJ(item);
		}
	}

	public virtual void JEACJNAKLDJ(object AACCPLMFDIE)
	{
		LJBDGPIHDIC[AACCPLMFDIE] = null;
	}

	public virtual void OEFBPEBHEGN(IEnumerable EKFOKNPODBK)
	{
		foreach (object item in EKFOKNPODBK)
		{
			JEACJNAKLDJ(item);
		}
	}

	public virtual void BOPEPLONIFL()
	{
		LJBDGPIHDIC.Clear();
	}

	public virtual bool KMDACNACKII(object AACCPLMFDIE)
	{
		return LJBDGPIHDIC.Contains(AACCPLMFDIE);
	}

	public virtual void CopyTo(Array KDOGMDCDCEN, int EHJNMODJEAN)
	{
		LJBDGPIHDIC.Keys.CopyTo(KDOGMDCDCEN, EHJNMODJEAN);
	}

	public virtual IEnumerator GetEnumerator()
	{
		return LJBDGPIHDIC.Keys.GetEnumerator();
	}

	public virtual void CJOHLENDJGO(object AACCPLMFDIE)
	{
		LJBDGPIHDIC.Remove(AACCPLMFDIE);
	}

	public virtual void BBGLCADIONK(IEnumerable EKFOKNPODBK)
	{
		foreach (object item in EKFOKNPODBK)
		{
			CJOHLENDJGO(item);
		}
	}
}
