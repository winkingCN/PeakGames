using System;
using System.Collections.Generic;

public class ECEEFKLEDDE<T> where T : class, new()
{
	public interface BKBMDIPGIFI
	{
		void OMOKOKFNBKI();
	}

	public readonly int NHLJFKPLKLI;

	private readonly Stack<T> EDCNKIJJHJH;

	public int GMCGMPEEHJP
	{
		get
		{
			return EDCNKIJJHJH.Count;
		}
	}

	public int CKHINKNDOFG { get; private set; }

	public ECEEFKLEDDE(int CHBLLPDGLCN = 16, int NHLJFKPLKLI = int.MaxValue)
	{
		EDCNKIJJHJH = new Stack<T>(CHBLLPDGLCN);
		this.NHLJFKPLKLI = NHLJFKPLKLI;
	}

	public T KJAOIPMLKPO()
	{
		return (EDCNKIJJHJH.Count != 0) ? EDCNKIJJHJH.Pop() : new T();
	}

	public void CFPHGMEPNFK(T NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null)
		{
			throw new ArgumentNullException("obj", "obj cannot be null");
		}
		if (EDCNKIJJHJH.Count < NHLJFKPLKLI)
		{
			EDCNKIJJHJH.Push(NEMEKIOEOLC);
			CKHINKNDOFG = Math.Max(CKHINKNDOFG, EDCNKIJJHJH.Count);
		}
		OMOKOKFNBKI(NEMEKIOEOLC);
	}

	public void BOPEPLONIFL()
	{
		EDCNKIJJHJH.Clear();
	}

	protected void OMOKOKFNBKI(T NEMEKIOEOLC)
	{
		BKBMDIPGIFI bKBMDIPGIFI = NEMEKIOEOLC as BKBMDIPGIFI;
		if (bKBMDIPGIFI != null)
		{
			bKBMDIPGIFI.OMOKOKFNBKI();
		}
	}
}
