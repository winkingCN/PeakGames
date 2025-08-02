using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using caravan.protobuf.messages;

public class AGLOLLABINO : DLDDFKDFKEF
{
	private readonly global::POILBKFNKHN<int, List<FriendScore>> JNPCHPPBKEA;

	private static AGLOLLABINO KNPOFJNFLJB;

	public bool IDEADKGADDA;

	public static AGLOLLABINO GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB != null)
			{
				return KNPOFJNFLJB;
			}
			KNPOFJNFLJB = new AGLOLLABINO();
			return KNPOFJNFLJB;
		}
	}

	private AGLOLLABINO()
	{
		JNPCHPPBKEA = new global::POILBKFNKHN<int, List<FriendScore>>(1000);
		string path = Path.Combine(Application.persistentDataPath, "latestlevels.cache");
		if (File.Exists(path))
		{
			File.Delete(path);
		}
	}

	public void DIHCNJLKMGP(int KIGOGMKCDKN, List<FriendScore> INONGLBMLJK)
	{
		JNPCHPPBKEA.HMKJAFHJMGN(KIGOGMKCDKN, INONGLBMLJK);
	}

	public List<FriendScore> FEACIPKPDDF(int KIGOGMKCDKN)
	{
		return JNPCHPPBKEA.GHBGCADFLFB(KIGOGMKCDKN);
	}

	public void OMOKOKFNBKI()
	{
		try
		{
			JNPCHPPBKEA.BOPEPLONIFL();
			KNPOFJNFLJB = null;
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.FacebookFriendsHelper, "Could not reset Facebook Friends : {0}", ex);
			throw;
		}
	}
}
