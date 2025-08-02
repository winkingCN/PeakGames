using System;
using System.Collections.Generic;

public class OJLJBEODDIM
{
	private LinkedList<Action> JDIPKLKPAEH = new LinkedList<Action>();

	private Dictionary<Action, LinkedListNode<Action>> AJLGBLFLNPM = new Dictionary<Action, LinkedListNode<Action>>();

	public void JEACJNAKLDJ(Action BJBOEIMJCPE)
	{
		if (!AJLGBLFLNPM.ContainsKey(BJBOEIMJCPE))
		{
			AJLGBLFLNPM[BJBOEIMJCPE] = JDIPKLKPAEH.AddLast(BJBOEIMJCPE);
		}
	}

	public void CJOHLENDJGO(Action BJBOEIMJCPE)
	{
		LinkedListNode<Action> value;
		if (AJLGBLFLNPM.TryGetValue(BJBOEIMJCPE, out value))
		{
			AJLGBLFLNPM.Remove(BJBOEIMJCPE);
			JDIPKLKPAEH.Remove(value);
		}
	}

	public void HDEFIBPNIFH()
	{
		for (LinkedListNode<Action> linkedListNode = JDIPKLKPAEH.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
		{
			linkedListNode.Value();
		}
	}
}
