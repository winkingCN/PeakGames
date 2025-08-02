using System;
using System.Collections.Generic;

public class JPLIGBJJCOE : MGAOAPKCDHP
{
	public DKBEJLGEAOA NJHFLHNDFHH;

	public List<EKPAJFBBAJC> GEPCKJFBMGK = new List<EKPAJFBBAJC>();

	public HashSet<string> BPDHDONGANE = new HashSet<string>();

	public long FLPEILFNDPO;

	public JPLIGBJJCOE()
	{
	}

	public JPLIGBJJCOE(Dictionary<string, object> EAPGOBAJLJE)
	{
		if (!EAPGOBAJLJE.ContainsKey("team"))
		{
			return;
		}
		NJHFLHNDFHH = new DKBEJLGEAOA((Dictionary<string, object>)EAPGOBAJLJE["team"]);
		FLPEILFNDPO = MGAOAPKCDHP.EICLJDHEHHP("serverTime", EAPGOBAJLJE, 0L);
		object value;
		if (EAPGOBAJLJE.TryGetValue("reports", out value))
		{
			object[] array = (object[])value;
			long num = LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM;
			int i = 0;
			for (int num2 = array.Length; i < num2; i++)
			{
				Dictionary<string, object> dictionary = (Dictionary<string, object>)array[i];
				object value2;
				if (!dictionary.TryGetValue("reporter", out value2))
				{
					continue;
				}
				object[] array2 = (object[])value2;
				string item = MGAOAPKCDHP.JDANMONKNGD("msgId", dictionary);
				int j = 0;
				for (int num3 = array2.Length; j < num3; j++)
				{
					long num4 = Convert.ToInt64(array2[j]);
					if (num4 == num)
					{
						BPDHDONGANE.Add(item);
						break;
					}
				}
			}
		}
		object value3;
		if (!EAPGOBAJLJE.TryGetValue("history", out value3))
		{
			return;
		}
		object[] array3 = (object[])value3;
		for (int k = 0; k < array3.Length; k++)
		{
			EKPAJFBBAJC eKPAJFBBAJC = new EKPAJFBBAJC((Dictionary<string, object>)array3[k]);
			if (eKPAJFBBAJC.ENBPGGCIADN == ABAPNBACABK.HelpAsked)
			{
				if (eKPAJFBBAJC.DLDMKKEICMA.HEANMKDLPGF() || !NJHFLHNDFHH.MCDNAIGOMAK.ContainsKey(eKPAJFBBAJC.DLDMKKEICMA.OCHADBCJEDP))
				{
					continue;
				}
				eKPAJFBBAJC.DLDMKKEICMA = NJHFLHNDFHH.MCDNAIGOMAK[eKPAJFBBAJC.DLDMKKEICMA.OCHADBCJEDP];
				if (eKPAJFBBAJC.DLDMKKEICMA.HEANMKDLPGF())
				{
					continue;
				}
			}
			GEPCKJFBMGK.Add(eKPAJFBBAJC);
		}
	}
}
