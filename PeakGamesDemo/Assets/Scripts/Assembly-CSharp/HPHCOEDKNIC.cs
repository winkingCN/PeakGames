using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal sealed class HPHCOEDKNIC : IList, IEnumerable, ICollection
{
	private readonly IList MDIMEPHMPLD;

	public int GMCGMPEEHJP
	{
		get
		{
			return MDIMEPHMPLD.Count;
		}
	}

	public bool ILMKNJIIHIJ
	{
		get
		{
			return true;
		}
	}

	public bool NEEAAJLLAGM
	{
		get
		{
			return true;
		}
	}

	public bool CELEJFDNOOP
	{
		get
		{
			return MDIMEPHMPLD.IsSynchronized;
		}
	}

	public object AHANCLBKKID
	{
		get
		{
			return MDIMEPHMPLD[EHJNMODJEAN];
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public object GAILGFEKIEK
	{
		get
		{
			return MDIMEPHMPLD.SyncRoot;
		}
	}

	internal HPHCOEDKNIC(IList PNKBIONHGEJ)
	{
		MDIMEPHMPLD = PNKBIONHGEJ;
	}

	public int Add(object EDDNOJDPMCF)
	{
		throw new NotSupportedException();
	}

	public void Clear()
	{
		throw new NotSupportedException();
	}

	public bool Contains(object EDDNOJDPMCF)
	{
		return MDIMEPHMPLD.Contains(EDDNOJDPMCF);
	}

	public void CopyTo(Array KDOGMDCDCEN, int EHJNMODJEAN)
	{
		MDIMEPHMPLD.CopyTo(KDOGMDCDCEN, EHJNMODJEAN);
	}

	public IEnumerator GetEnumerator()
	{
		return MDIMEPHMPLD.GetEnumerator();
	}

	public int IndexOf(object EDDNOJDPMCF)
	{
		return MDIMEPHMPLD.IndexOf(EDDNOJDPMCF);
	}

	public void Insert(int EHJNMODJEAN, object EDDNOJDPMCF)
	{
		throw new NotSupportedException();
	}

	public void Remove(object EDDNOJDPMCF)
	{
		throw new NotSupportedException();
	}

	public void RemoveAt(int EHJNMODJEAN)
	{
		throw new NotSupportedException();
	}
}
