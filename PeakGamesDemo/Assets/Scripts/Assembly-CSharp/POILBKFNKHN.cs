using System.Collections.Generic;
using System.Linq;

public sealed class POILBKFNKHN<K, T>
{
	private readonly int JNKDBENJGFI;

	private readonly Queue<K> MBIDIDHEEAJ = new Queue<K>();

	private readonly Dictionary<K, T> FBFDMLLMIJH = new Dictionary<K, T>();

	public POILBKFNKHN(int MDPEMCMPAMB)
	{
		JNKDBENJGFI = MDPEMCMPAMB;
	}

	public bool KNKKEFGBIGG(K IKNCPEPOKGJ)
	{
		return FBFDMLLMIJH.ContainsKey(IKNCPEPOKGJ);
	}

	public void HMKJAFHJMGN(K IKNCPEPOKGJ, T EDDNOJDPMCF)
	{
		if (MBIDIDHEEAJ.Count >= JNKDBENJGFI)
		{
			K key = MBIDIDHEEAJ.Dequeue();
			FBFDMLLMIJH.Remove(key);
		}
		MBIDIDHEEAJ.Enqueue(IKNCPEPOKGJ);
		if (!FBFDMLLMIJH.ContainsKey(IKNCPEPOKGJ))
		{
			FBFDMLLMIJH.Add(IKNCPEPOKGJ, EDDNOJDPMCF);
		}
		else
		{
			FBFDMLLMIJH[IKNCPEPOKGJ] = EDDNOJDPMCF;
		}
	}

	public T GHBGCADFLFB(K IKNCPEPOKGJ)
	{
		T value = default(T);
		FBFDMLLMIJH.TryGetValue(IKNCPEPOKGJ, out value);
		return value;
	}

	public IEnumerable<KeyValuePair<K, T>> IHGDLOKFAMI()
	{
		return FBFDMLLMIJH.AsEnumerable();
	}

	public void BOPEPLONIFL()
	{
		FBFDMLLMIJH.Clear();
		MBIDIDHEEAJ.Clear();
	}
}
