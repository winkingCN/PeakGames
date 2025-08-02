using System.Collections.Generic;

public class NNDDOJGCENC : MDMLFPDLFLE
{
	public NNDDOJGCENC(EIPCLBONPLC JDFMMECNFKB)
		: base(JDFMMECNFKB, false)
	{
		ECCJDODDJMI = "FetchTeamAction";
	}

	protected override void JFLAAOOBKJD(params object[] MIDCNFGAIFA)
	{
		JDFMMECNFKB.NMGBGAGMOGI.BHOIPLKJLFG();
	}

	protected override void DFGLIIBBFEI(params object[] MIDCNFGAIFA)
	{
		if (!(bool)MIDCNFGAIFA[0])
		{
			return;
		}
		int num = OIAJPMNJGLK.HOGCELOOGEP();
		List<BGMENKMNLCH> list = (List<BGMENKMNLCH>)MIDCNFGAIFA[1];
		if (list != null && list.Count > 0)
		{
			foreach (BGMENKMNLCH item in list)
			{
				if (num > item.KEMNAAPNAPA)
				{
					item.KFBCFDALGBB = 0L;
				}
			}
		}
		JDFMMECNFKB.IPCAELIMIBN.CurrentNotJoinedContainer.CurrentTeamsTab.CreateEntries(list);
	}
}
