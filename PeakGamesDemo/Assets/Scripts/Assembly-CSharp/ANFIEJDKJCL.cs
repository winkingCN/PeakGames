using System;
using System.Collections.Generic;

public class ANFIEJDKJCL<A, B>
{
	private LinkedList<Action<A, B>> JDIPKLKPAEH = new LinkedList<Action<A, B>>();

	private Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>> AJLGBLFLNPM = new Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>>();

	public void JEACJNAKLDJ(Action<A, B> BJBOEIMJCPE)
	{
		if (!AJLGBLFLNPM.ContainsKey(BJBOEIMJCPE))
		{
			AJLGBLFLNPM[BJBOEIMJCPE] = JDIPKLKPAEH.AddLast(BJBOEIMJCPE);
		}
	}

	public void CJOHLENDJGO(Action<A, B> BJBOEIMJCPE)
	{
		LinkedListNode<Action<A, B>> value;
		if (AJLGBLFLNPM.TryGetValue(BJBOEIMJCPE, out value))
		{
			AJLGBLFLNPM.Remove(BJBOEIMJCPE);
			JDIPKLKPAEH.Remove(value);
		}
	}

	public void HDEFIBPNIFH(A MNIMEAMHNMI, B BCIHLCMFAEK)
	{
		for (LinkedListNode<Action<A, B>> linkedListNode = JDIPKLKPAEH.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
		{
			linkedListNode.Value(MNIMEAMHNMI, BCIHLCMFAEK);
		}
	}
}
