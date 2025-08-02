using System;
using System.Collections.Generic;
using UnityEngine;
using Utils.Game;

public class MLPHFMDIMLB
{
	public const int AMEDMLOCCBG = 4;

	private readonly GamePlayRecord JCCIHFEPIID;

	private float DOGFOMOIBJG;

	private readonly bool DPJEEOHAJPL;

	public static GamePlayRecord LLPBJPNDKIA { get; private set; }

	public MLPHFMDIMLB(int HJBOEOOLOOE, bool NIEHLOMGPLC)
	{
		DPJEEOHAJPL = NIEHLOMGPLC;
		JCCIHFEPIID = new GamePlayRecord(HJBOEOOLOOE);
	}

	public void JBEKBJHJBKD(int AMFCENFNAJJ, int CNLILOEEBOJ)
	{
		if (DOGFOMOIBJG > 0f)
		{
			int val = Mathf.RoundToInt((Time.time - DOGFOMOIBJG) * 100f + 0.051f);
			val = Math.Min(1000, val);
			JCCIHFEPIID.w.Add(val);
		}
		DOGFOMOIBJG = Time.time;
		JCCIHFEPIID.m.Add(AMFCENFNAJJ);
		JCCIHFEPIID.m.Add(CNLILOEEBOJ);
		BFGGHJGIHLJ.GMAIJJHDBJL();
		IIGHOCGOAID.GABGKBAKHDP.IMHBNCKPHIF();
	}

	public void PACCFEDLNAL(KFCEILFGADG GIOFHACJEGA)
	{
		JCCIHFEPIID.l = GIOFHACJEGA.PDGLECFDLJJ;
		JCCIHFEPIID.n = GIOFHACJEGA.PNGPLGHKFDI;
		IIGHOCGOAID.GABGKBAKHDP.HLNNJCCFIJI(GIOFHACJEGA);
	}

	public void HMCHBHEIDNJ(int GBOHNGGEMFE)
	{
		JCCIHFEPIID.c = GBOHNGGEMFE;
	}

	public void CGGNCAIKEGN(List<NOALGNJECAD> GFCOBGFMGKG)
	{
		using (List<NOALGNJECAD>.Enumerator enumerator = GFCOBGFMGKG.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				switch (enumerator.Current)
				{
				case NOALGNJECAD.Rocket:
					CCJBDEGNEAL.NCNOKALAALL(ref JCCIHFEPIID.p, 0, true);
					break;
				case NOALGNJECAD.Bomb:
					CCJBDEGNEAL.NCNOKALAALL(ref JCCIHFEPIID.p, 1, true);
					break;
				case NOALGNJECAD.DiscoBall:
					CCJBDEGNEAL.NCNOKALAALL(ref JCCIHFEPIID.p, 2, true);
					break;
				}
			}
		}
	}

	public void FJOBHOMJDBH(int AMFCENFNAJJ, int CNLILOEEBOJ, NAAHKHPBAPA MCOBEOPCNCG)
	{
		JCCIHFEPIID.b.Add(JCCIHFEPIID.m.Count);
		JCCIHFEPIID.b.Add(AMFCENFNAJJ);
		JCCIHFEPIID.b.Add(CNLILOEEBOJ);
		JCCIHFEPIID.b.Add((int)MCOBEOPCNCG);
	}

	public void PHPICMEFNAI()
	{
		JCCIHFEPIID.e.Add(JCCIHFEPIID.m.Count);
	}

	public void GAMDCIKLKJC(bool ODBENCHMFIJ)
	{
		if (!DPJEEOHAJPL && JCCIHFEPIID.m.Count > 5)
		{
			if (MCJHHDACJBG.DGDIEBKEMOL)
			{
				LLPBJPNDKIA = JCCIHFEPIID;
			}
			if (ODBENCHMFIJ)
			{
				IIGHOCGOAID.GABGKBAKHDP.IMHBNCKPHIF();
			}
			JCCIHFEPIID.snapshots = IIGHOCGOAID.GABGKBAKHDP.JNOMGIGLKFO;
			GBFAPADEBEC.HGGCKNOEIOM(PBIIDJOKNEK.Replay, JCCIHFEPIID);
		}
	}
}
