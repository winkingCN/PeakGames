using System;
using System.Collections.Generic;
using Assets.Scripts.CasualTools.Common.Pooling;
using UnityEngine;

public static class DKOOJCOOKEM
{
	public static void FLFDKMOOIFL<T>(this T AGIOLFBGANM) where T : Component
	{
		ObjectPool.CreatePool(AGIOLFBGANM, 0);
	}

	public static void FLFDKMOOIFL<T>(this T AGIOLFBGANM, int KMCCJKEKLEA) where T : Component
	{
		ObjectPool.CreatePool(AGIOLFBGANM, KMCCJKEKLEA);
	}

	public static void FLFDKMOOIFL(this GameObject AGIOLFBGANM)
	{
		ObjectPool.CreatePool(AGIOLFBGANM, 0);
	}

	public static void FLFDKMOOIFL(this GameObject AGIOLFBGANM, int KMCCJKEKLEA)
	{
		ObjectPool.CreatePool(AGIOLFBGANM, KMCCJKEKLEA);
	}

	public static void LAOADDPHIAE(this GameObject AGIOLFBGANM, Action<GameObject> GPLIOLJFDPM)
	{
		ObjectPool.DoActionInPool(AGIOLFBGANM, GPLIOLJFDPM);
	}

	public static T JOBDHIPIMAG<T>(this T AGIOLFBGANM, Vector3 LDMDBPLADGD, Quaternion ODLHFMOPCHL) where T : Component
	{
		return ObjectPool.Spawn(AGIOLFBGANM, LDMDBPLADGD, ODLHFMOPCHL);
	}

	public static T JOBDHIPIMAG<T>(this T AGIOLFBGANM, Vector3 LDMDBPLADGD) where T : Component
	{
		return ObjectPool.Spawn(AGIOLFBGANM, LDMDBPLADGD, Quaternion.identity);
	}

	public static T JOBDHIPIMAG<T>(this T AGIOLFBGANM) where T : Component
	{
		return ObjectPool.Spawn(AGIOLFBGANM, Vector3.zero, Quaternion.identity);
	}

	public static GameObject JOBDHIPIMAG(this GameObject AGIOLFBGANM, Vector3 LDMDBPLADGD, Quaternion ODLHFMOPCHL)
	{
		return ObjectPool.Spawn(AGIOLFBGANM, LDMDBPLADGD, ODLHFMOPCHL);
	}

	public static GameObject JOBDHIPIMAG(this GameObject AGIOLFBGANM, Vector3 LDMDBPLADGD)
	{
		return ObjectPool.Spawn(AGIOLFBGANM, LDMDBPLADGD, Quaternion.identity);
	}

	public static GameObject JOBDHIPIMAG(this GameObject AGIOLFBGANM)
	{
		return ObjectPool.Spawn(AGIOLFBGANM, Vector3.zero, Quaternion.identity);
	}

	public static void MEJPNNFDEBD<T>(this T NEMEKIOEOLC) where T : Component
	{
		ObjectPool.Recycle(NEMEKIOEOLC);
	}

	public static void MEJPNNFDEBD(this GameObject NEMEKIOEOLC)
	{
		ObjectPool.Recycle(NEMEKIOEOLC);
	}

	public static void AACDKEGKCOL<T>(this T AGIOLFBGANM) where T : Component
	{
		ObjectPool.RecycleAll(AGIOLFBGANM);
	}

	public static void AACDKEGKCOL(this GameObject AGIOLFBGANM)
	{
		try
		{
			ObjectPool.RecycleAll(AGIOLFBGANM);
		}
		catch (Exception ex)
		{
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.ObjectPool, "---->{0} : {1}", ex.Message, ex.StackTrace);
		}
	}

	public static int IBEJCICEBIH<T>(this T AGIOLFBGANM) where T : Component
	{
		return ObjectPool.CountPooled(AGIOLFBGANM);
	}

	public static int IBEJCICEBIH(this GameObject AGIOLFBGANM)
	{
		return ObjectPool.CountPooled(AGIOLFBGANM);
	}

	public static int EEKDOONIFLD<T>(this T AGIOLFBGANM) where T : Component
	{
		return ObjectPool.CountSpawned(AGIOLFBGANM);
	}

	public static int EEKDOONIFLD(this GameObject AGIOLFBGANM)
	{
		return ObjectPool.CountSpawned(AGIOLFBGANM);
	}

	public static List<GameObject> IMJFPFCFEMD(this GameObject AGIOLFBGANM, List<GameObject> PNKBIONHGEJ, bool CCGMMLGPNMB)
	{
		return ObjectPool.GetSpawned(AGIOLFBGANM, PNKBIONHGEJ, CCGMMLGPNMB);
	}

	public static List<GameObject> IMJFPFCFEMD(this GameObject AGIOLFBGANM, List<GameObject> PNKBIONHGEJ)
	{
		return ObjectPool.GetSpawned(AGIOLFBGANM, PNKBIONHGEJ, false);
	}

	public static List<GameObject> IMJFPFCFEMD(this GameObject AGIOLFBGANM)
	{
		return ObjectPool.GetSpawned(AGIOLFBGANM, null, false);
	}

	public static List<T> IMJFPFCFEMD<T>(this T AGIOLFBGANM, List<T> PNKBIONHGEJ, bool CCGMMLGPNMB) where T : Component
	{
		return ObjectPool.GetSpawned(AGIOLFBGANM, PNKBIONHGEJ, CCGMMLGPNMB);
	}

	public static List<T> IMJFPFCFEMD<T>(this T AGIOLFBGANM, List<T> PNKBIONHGEJ) where T : Component
	{
		return ObjectPool.GetSpawned(AGIOLFBGANM, PNKBIONHGEJ, false);
	}

	public static List<T> IMJFPFCFEMD<T>(this T AGIOLFBGANM) where T : Component
	{
		return ObjectPool.GetSpawned(AGIOLFBGANM, null, false);
	}

	public static List<GameObject> HGDNGPLOJLC(this GameObject AGIOLFBGANM, List<GameObject> PNKBIONHGEJ, bool CCGMMLGPNMB)
	{
		return ObjectPool.GetPooled(AGIOLFBGANM, PNKBIONHGEJ, CCGMMLGPNMB);
	}

	public static List<GameObject> HGDNGPLOJLC(this GameObject AGIOLFBGANM, List<GameObject> PNKBIONHGEJ)
	{
		return ObjectPool.GetPooled(AGIOLFBGANM, PNKBIONHGEJ, false);
	}

	public static List<GameObject> HGDNGPLOJLC(this GameObject AGIOLFBGANM)
	{
		return ObjectPool.GetPooled(AGIOLFBGANM, null, false);
	}

	public static List<T> HGDNGPLOJLC<T>(this T AGIOLFBGANM, List<T> PNKBIONHGEJ, bool CCGMMLGPNMB) where T : Component
	{
		return ObjectPool.GetPooled(AGIOLFBGANM, PNKBIONHGEJ, CCGMMLGPNMB);
	}

	public static List<T> HGDNGPLOJLC<T>(this T AGIOLFBGANM, List<T> PNKBIONHGEJ) where T : Component
	{
		return ObjectPool.GetPooled(AGIOLFBGANM, PNKBIONHGEJ, false);
	}

	public static List<T> HGDNGPLOJLC<T>(this T AGIOLFBGANM) where T : Component
	{
		return ObjectPool.GetPooled(AGIOLFBGANM, null, false);
	}

	public static void ODHOIEKODOF(this GameObject AGIOLFBGANM)
	{
		ObjectPool.DestroyPooled(AGIOLFBGANM);
	}

	public static void ODHOIEKODOF<T>(this T AGIOLFBGANM) where T : Component
	{
		ObjectPool.DestroyPooled(AGIOLFBGANM.gameObject);
	}

	public static void EILCDHMOOGO(this GameObject AGIOLFBGANM)
	{
		ObjectPool.DestroyAll(AGIOLFBGANM);
	}

	public static void EILCDHMOOGO<T>(this T AGIOLFBGANM) where T : Component
	{
		ObjectPool.DestroyAll(AGIOLFBGANM.gameObject);
	}
}
