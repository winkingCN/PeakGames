using System;
using Spine;
using UnityEngine;

public class BINFNGNPCFJ : IDisposable
{
	public class FGNAEHNOBLF : IDisposable
	{
		public Mesh IJKCGGPJDIG = LNMACOPDENA.ALDHFNJGLPP();

		public OOBEMJJCEGO FHHJCFPBCPD = new OOBEMJJCEGO();

		public void Dispose()
		{
			if (IJKCGGPJDIG != null)
			{
				UnityEngine.Object.Destroy(IJKCGGPJDIG);
			}
			IJKCGGPJDIG = null;
		}
	}

	private global::ACEOIDJCHFL<FGNAEHNOBLF> DOGKIOBCFPH;

	internal readonly ExposedList<Material> ODNCFLGIJDN = new ExposedList<Material>();

	internal Material[] EHKPJPFNLHN = new Material[0];

	public void JPLFFCHJICB()
	{
		DOGKIOBCFPH = new global::ACEOIDJCHFL<FGNAEHNOBLF>();
	}

	public Material[] OJDOIDGNNLP()
	{
		if (ODNCFLGIJDN.Count == EHKPJPFNLHN.Length)
		{
			ODNCFLGIJDN.BACJEDDPKIJ(EHKPJPFNLHN);
		}
		else
		{
			EHKPJPFNLHN = ODNCFLGIJDN.GDPLKNIEGDB();
		}
		return EHKPJPFNLHN;
	}

	public bool OMPHFIEOOAM()
	{
		int count = ODNCFLGIJDN.Count;
		Material[] eHKPJPFNLHN = EHKPJPFNLHN;
		if (count != eHKPJPFNLHN.Length)
		{
			return true;
		}
		Material[] items = ODNCFLGIJDN.Items;
		for (int i = 0; i < count; i++)
		{
			if (!object.ReferenceEquals(items[i], eHKPJPFNLHN[i]))
			{
				return true;
			}
		}
		return false;
	}

	public void FCLCFDNLKDA(ExposedList<OFMBOEDKGMI> NFGCPEEIEJN)
	{
		int count = NFGCPEEIEJN.Count;
		if (count > ODNCFLGIJDN.Items.Length)
		{
			Array.Resize(ref ODNCFLGIJDN.Items, count);
		}
		ODNCFLGIJDN.Count = count;
		Material[] items = ODNCFLGIJDN.Items;
		OFMBOEDKGMI[] items2 = NFGCPEEIEJN.Items;
		for (int i = 0; i < count; i++)
		{
			items[i] = items2[i].GHPFOPNNJOB;
		}
	}

	public FGNAEHNOBLF HNNIMBHJGCO()
	{
		return DOGKIOBCFPH.ALEKLIDGIEI();
	}

	public void BOPEPLONIFL()
	{
		EHKPJPFNLHN = new Material[0];
		ODNCFLGIJDN.BOPEPLONIFL();
	}

	public void Dispose()
	{
		if (DOGKIOBCFPH != null)
		{
			DOGKIOBCFPH.ALEKLIDGIEI().Dispose();
			DOGKIOBCFPH.ALEKLIDGIEI().Dispose();
			DOGKIOBCFPH = null;
		}
	}
}
