using System.Collections.Generic;

public class PONCCEHNOOM : MGAOAPKCDHP
{
	public long EEFMIHDPJPG;

	public string EALJKKBHDHK;

	public PONCCEHNOOM(Dictionary<string, object> ECBDGMPPBKF)
	{
		EEFMIHDPJPG = MGAOAPKCDHP.EICLJDHEHHP("id", ECBDGMPPBKF, 0L);
		EALJKKBHDHK = MGAOAPKCDHP.JDANMONKNGD("nick", ECBDGMPPBKF);
	}

	protected bool KIFDKLPDKMD(AKGIJAMHMNA CJHEIBNHNNE)
	{
		return EEFMIHDPJPG == CJHEIBNHNNE.EEFMIHDPJPG;
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (object.ReferenceEquals(null, NEMEKIOEOLC))
		{
			return false;
		}
		if (object.ReferenceEquals(this, NEMEKIOEOLC))
		{
			return true;
		}
		return NEMEKIOEOLC.GetType() == GetType() && KIFDKLPDKMD((AKGIJAMHMNA)NEMEKIOEOLC);
	}

	public override int GetHashCode()
	{
		return (int)EEFMIHDPJPG;
	}
}
