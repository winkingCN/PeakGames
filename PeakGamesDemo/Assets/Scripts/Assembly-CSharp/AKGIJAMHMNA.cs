using System.Collections.Generic;

public class AKGIJAMHMNA : MGAOAPKCDHP
{
	public long EEFMIHDPJPG;

	public long ODELKLFOEDD;

	public string EALJKKBHDHK;

	public string NKOHDLBCJBK;

	public long OADDPGNIINO;

	public long KCAHGIBBHKJ;

	public long IGJMOKLIENL;

	public long KEMNAAPNAPA;

	public long KFBCFDALGBB;

	public long CALJBGILMOL;

	public int GGBEMNJNAEE;

	public AKGIJAMHMNA(Dictionary<string, object> JLKANDLHAOM)
	{
		EEFMIHDPJPG = MGAOAPKCDHP.EICLJDHEHHP("id", JLKANDLHAOM, 0L);
		ODELKLFOEDD = MGAOAPKCDHP.EICLJDHEHHP("campaigns", JLKANDLHAOM, 0L);
		OADDPGNIINO = MGAOAPKCDHP.EICLJDHEHHP("teamId", JLKANDLHAOM, 0L);
		KCAHGIBBHKJ = MGAOAPKCDHP.EICLJDHEHHP("orderNo", JLKANDLHAOM, 0L);
		KEMNAAPNAPA = MGAOAPKCDHP.EICLJDHEHHP("helpWeek", JLKANDLHAOM, 0L);
		KFBCFDALGBB = MGAOAPKCDHP.EICLJDHEHHP("helpCount", JLKANDLHAOM, 0L);
		IGJMOKLIENL = MGAOAPKCDHP.EICLJDHEHHP("kickedCount", JLKANDLHAOM, 0L);
		CALJBGILMOL = MGAOAPKCDHP.EICLJDHEHHP("maxLevelReached", JLKANDLHAOM, 0L);
		EALJKKBHDHK = MGAOAPKCDHP.JDANMONKNGD("nick", JLKANDLHAOM);
		NKOHDLBCJBK = MGAOAPKCDHP.JDANMONKNGD("country", JLKANDLHAOM);
	}

	public override string ToString()
	{
		return string.Format("Social User Id:{0}, Nick:{1}, Country:{2}, TeamId:{3}, OrderNo:{4}, KickedCount:{5}, Helps:{6}, CLScore:{7}", EEFMIHDPJPG, EALJKKBHDHK, NKOHDLBCJBK, OADDPGNIINO, KCAHGIBBHKJ, IGJMOKLIENL, KFBCFDALGBB, GGBEMNJNAEE);
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
