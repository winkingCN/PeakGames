using System.Collections.Generic;
using GamePlayScene.Mechanics.Items;

public class HHNDNFBNICP<T> where T : CollectorItem
{
	private Dictionary<LEDBLDKJBAI, SortedList<int, T>> FCNIAAHFJMI;

	private readonly Queue<int> GNGBAILBAID = new Queue<int>();

	private int FIGOJIJBBCM = -1;

	private int AJCCJFPAPPP;

	public int MAKEJBOJNOL
	{
		get
		{
			return FIGOJIJBBCM;
		}
	}

	public void OMOKOKFNBKI()
	{
		if (FCNIAAHFJMI != null)
		{
			FCNIAAHFJMI.Clear();
		}
		GNGBAILBAID.Clear();
		FIGOJIJBBCM = -1;
		AJCCJFPAPPP = 0;
	}

	public int HNCEPKJKAMC(T EJCNAJOHBFI)
	{
		if (FCNIAAHFJMI == null)
		{
			FCNIAAHFJMI = new Dictionary<LEDBLDKJBAI, SortedList<int, T>>();
		}
		if (!FCNIAAHFJMI.ContainsKey(EJCNAJOHBFI.BPLHOCDDLCG))
		{
			FCNIAAHFJMI.Add(EJCNAJOHBFI.BPLHOCDDLCG, new SortedList<int, T>());
		}
		FCNIAAHFJMI[EJCNAJOHBFI.BPLHOCDDLCG].Add(EJCNAJOHBFI.BHIJCAOHDCM, EJCNAJOHBFI);
		return NLMLKADGECN.GABGKBAKHDP.GGLGBLDNMGO;
	}

	public void HLFFHLAOIAJ(T EJCNAJOHBFI)
	{
		if (FCNIAAHFJMI != null && FCNIAAHFJMI.ContainsKey(EJCNAJOHBFI.BPLHOCDDLCG))
		{
			if (FCNIAAHFJMI[EJCNAJOHBFI.BPLHOCDDLCG].ContainsKey(EJCNAJOHBFI.BHIJCAOHDCM))
			{
				FCNIAAHFJMI[EJCNAJOHBFI.BPLHOCDDLCG].Remove(EJCNAJOHBFI.BHIJCAOHDCM);
			}
			if (FCNIAAHFJMI[EJCNAJOHBFI.BPLHOCDDLCG].Count == 0)
			{
				FCNIAAHFJMI.Remove(EJCNAJOHBFI.BPLHOCDDLCG);
			}
		}
	}

	public T DLGLMDDEOEG(LEDBLDKJBAI JOCKKMJBJLL)
	{
		if (FCNIAAHFJMI == null || !FCNIAAHFJMI.ContainsKey(JOCKKMJBJLL) || FCNIAAHFJMI[JOCKKMJBJLL] == null || FCNIAAHFJMI[JOCKKMJBJLL].Values.Count == 0)
		{
			return (T)null;
		}
		T val = FCNIAAHFJMI[JOCKKMJBJLL].Values[0];
		bool flag = FCNIAAHFJMI[JOCKKMJBJLL].Values.Count > 1;
		if (!val.IsAvailable() && flag)
		{
			FCNIAAHFJMI[val.BPLHOCDDLCG].Remove(val.BHIJCAOHDCM);
			if (FCNIAAHFJMI[JOCKKMJBJLL].Values.Count == 0)
			{
				return (T)null;
			}
		}
		return FCNIAAHFJMI[JOCKKMJBJLL].Values[0];
	}

	public bool NODDCJJNJEC(LEDBLDKJBAI JOCKKMJBJLL)
	{
		return FCNIAAHFJMI != null && FCNIAAHFJMI.ContainsKey(JOCKKMJBJLL) && FCNIAAHFJMI[JOCKKMJBJLL] != null;
	}

	public void JLJGBGFPKKC(int KAGMCIGFJBL)
	{
		if (!GNGBAILBAID.Contains(KAGMCIGFJBL))
		{
			GNGBAILBAID.Enqueue(KAGMCIGFJBL);
			FIGOJIJBBCM = GNGBAILBAID.Peek();
			AJCCJFPAPPP++;
		}
	}

	public int LBGEOEHBJNF()
	{
		return AJCCJFPAPPP;
	}

	public void GAHKKABDHGD()
	{
		if (GNGBAILBAID.Count != 0)
		{
			GNGBAILBAID.Dequeue();
			if (GNGBAILBAID.Count > 0)
			{
				FIGOJIJBBCM = GNGBAILBAID.Peek();
			}
			AJCCJFPAPPP--;
		}
	}
}
