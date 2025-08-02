using System;
using System.Collections.Generic;

public class GNABKMFJFED<A, B, C>
{
	private LinkedList<Action<A, B, C>> JDIPKLKPAEH = new LinkedList<Action<A, B, C>>();

	private Dictionary<Action<A, B, C>, LinkedListNode<Action<A, B, C>>> AJLGBLFLNPM = new Dictionary<Action<A, B, C>, LinkedListNode<Action<A, B, C>>>();

	public void JEACJNAKLDJ(Action<A, B, C> BJBOEIMJCPE)
	{
		if (!AJLGBLFLNPM.ContainsKey(BJBOEIMJCPE))
		{
			AJLGBLFLNPM[BJBOEIMJCPE] = JDIPKLKPAEH.AddLast(BJBOEIMJCPE);
		}
	}

	public void CJOHLENDJGO(Action<A, B, C> BJBOEIMJCPE)
	{
		LinkedListNode<Action<A, B, C>> value;
		if (AJLGBLFLNPM.TryGetValue(BJBOEIMJCPE, out value))
		{
			AJLGBLFLNPM.Remove(BJBOEIMJCPE);
			JDIPKLKPAEH.Remove(value);
		}
	}

	public void HDEFIBPNIFH(A MNIMEAMHNMI, B BCIHLCMFAEK, C FMFABAKPMLB)
	{
		for (LinkedListNode<Action<A, B, C>> linkedListNode = JDIPKLKPAEH.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
		{
			linkedListNode.Value(MNIMEAMHNMI, BCIHLCMFAEK, FMFABAKPMLB);
		}
	}
}
