using System;
using System.Collections;

public sealed class FLJIAKGGJBO : IEnumerable
{
	private readonly IEnumerable KFPHDHHABPK;

	public FLJIAKGGJBO(IEnumerable KFPHDHHABPK)
	{
		if (KFPHDHHABPK == null)
		{
			throw new ArgumentNullException("inner");
		}
		this.KFPHDHHABPK = KFPHDHHABPK;
	}

	public IEnumerator GetEnumerator()
	{
		return KFPHDHHABPK.GetEnumerator();
	}
}
