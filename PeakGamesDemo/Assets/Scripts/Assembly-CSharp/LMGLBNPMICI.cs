using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

public class LMGLBNPMICI : MDMLFPDLFLE
{
	[CompilerGenerated]
	private static Func<BGMENKMNLCH, long> EBCOMJBLIPP;

	public LMGLBNPMICI(EIPCLBONPLC JDFMMECNFKB)
		: base(JDFMMECNFKB, false)
	{
		ECCJDODDJMI = "SearchTeamAction";
	}

	protected override void JFLAAOOBKJD(params object[] MIDCNFGAIFA)
	{
		string text = (string)MIDCNFGAIFA[0];
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.PeakAnalytics, "Event Triggered Search >Text:{0}", text);
		AFJPGLHKOID.CPIGOAGGLBM("Search", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, null, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), text);
		JDFMMECNFKB.NMGBGAGMOGI.OJIIDKOGKDC(text);
	}

	protected override void DFGLIIBBFEI(params object[] MIDCNFGAIFA)
	{
		if ((bool)MIDCNFGAIFA[0])
		{
			List<BGMENKMNLCH> list = (List<BGMENKMNLCH>)MIDCNFGAIFA[1];
			if (list != null && list.Count > 0)
			{
				long num = list.Max((BGMENKMNLCH IBBBMACIBGK) => IBBBMACIBGK.KEMNAAPNAPA);
				foreach (BGMENKMNLCH item in list)
				{
					if (item.KEMNAAPNAPA < num)
					{
						item.KFBCFDALGBB = 0L;
					}
				}
			}
			JDFMMECNFKB.IPCAELIMIBN.CurrentNotJoinedContainer.CurrentSearchTab.CreateEntries(list);
		}
		else
		{
			NKILAONHNNE nKILAONHNNE = (NKILAONHNNE)MIDCNFGAIFA[2];
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.SearchTeamAction, "Can not fetch searches:{0}", nKILAONHNNE);
			JDFMMECNFKB.IPCAELIMIBN.CurrentNotJoinedContainer.CurrentSearchTab.ShowError();
		}
	}

	protected override void AONDNIEFKII()
	{
		base.AONDNIEFKII();
		JDFMMECNFKB.IPCAELIMIBN.CurrentNotJoinedContainer.CurrentSearchTab.ShowError();
	}

	[CompilerGenerated]
	private static long NDLAHJJNLML(BGMENKMNLCH IBBBMACIBGK)
	{
		return IBBBMACIBGK.KEMNAAPNAPA;
	}
}
