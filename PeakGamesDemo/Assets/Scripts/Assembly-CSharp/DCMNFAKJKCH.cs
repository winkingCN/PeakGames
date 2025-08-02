using System.Collections.Generic;
using System.Reflection;

[DefaultMember("Item")]
public class DCMNFAKJKCH : Dictionary<string, object>
{
	public object AHANCLBKKID
	{
		get
		{
			if (ContainsKey(NMPJCKJIOKL))
			{
				return base[NMPJCKJIOKL];
			}
			return null;
		}
		set
		{
			if (ContainsKey(NMPJCKJIOKL))
			{
				base[NMPJCKJIOKL] = value;
			}
			else
			{
				Add(NMPJCKJIOKL, value);
			}
		}
	}

	public DCMNFAKJKCH(int MDPEMCMPAMB)
		: base(MDPEMCMPAMB)
	{
	}
}
