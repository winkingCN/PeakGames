using System;
using System.Collections.Generic;

public class BJCEGANEBOJ<A>
{
	private LinkedList<Action<A>> JDIPKLKPAEH = new LinkedList<Action<A>>();

	private Dictionary<Action<A>, LinkedListNode<Action<A>>> AJLGBLFLNPM = new Dictionary<Action<A>, LinkedListNode<Action<A>>>();

	public void JEACJNAKLDJ(Action<A> BJBOEIMJCPE)
	{
		if (!AJLGBLFLNPM.ContainsKey(BJBOEIMJCPE))
		{
			AJLGBLFLNPM[BJBOEIMJCPE] = JDIPKLKPAEH.AddLast(BJBOEIMJCPE);
		}
	}

	public void CJOHLENDJGO(Action<A> BJBOEIMJCPE)
	{
		LinkedListNode<Action<A>> value;
		if (AJLGBLFLNPM.TryGetValue(BJBOEIMJCPE, out value))
		{
			AJLGBLFLNPM.Remove(BJBOEIMJCPE);
			JDIPKLKPAEH.Remove(value);
		}
	}

	public void HDEFIBPNIFH(A MNIMEAMHNMI)
	{
		for (LinkedListNode<Action<A>> linkedListNode = JDIPKLKPAEH.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
		{
			linkedListNode.Value(MNIMEAMHNMI);
		}
	}
}
