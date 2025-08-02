using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

[DefaultMember("Item")]
public class DGFIHEEHLKF : JLODNMAAHAC, IEnumerable
{
	private List<JLODNMAAHAC> AHECINMBEGF = new List<JLODNMAAHAC>();

	public override JLODNMAAHAC AHANCLBKKID
	{
		get
		{
			if (LHOJEJCFKCN < 0 || LHOJEJCFKCN >= AHECINMBEGF.Count)
			{
				return new MPHIIHDHBBF(this);
			}
			return AHECINMBEGF[LHOJEJCFKCN];
		}
		set
		{
			if (LHOJEJCFKCN < 0 || LHOJEJCFKCN >= AHECINMBEGF.Count)
			{
				AHECINMBEGF.Add(value);
			}
			else
			{
				AHECINMBEGF[LHOJEJCFKCN] = value;
			}
		}
	}

	public override JLODNMAAHAC AHANCLBKKID
	{
		get
		{
			return new MPHIIHDHBBF(this);
		}
		set
		{
			AHECINMBEGF.Add(value);
		}
	}

	public override int GMCGMPEEHJP
	{
		get
		{
			return AHECINMBEGF.Count;
		}
	}

	public override IEnumerable<JLODNMAAHAC> JHEDPFKFFJB
	{
		get
		{
			foreach (JLODNMAAHAC item in AHECINMBEGF)
			{
				yield return item;
			}
		}
	}

	public override void JEACJNAKLDJ(string OMGPFPGELOM, JLODNMAAHAC GFADEOLDFDI)
	{
		AHECINMBEGF.Add(GFADEOLDFDI);
	}

	public override JLODNMAAHAC CJOHLENDJGO(int LHOJEJCFKCN)
	{
		if (LHOJEJCFKCN < 0 || LHOJEJCFKCN >= AHECINMBEGF.Count)
		{
			return null;
		}
		JLODNMAAHAC result = AHECINMBEGF[LHOJEJCFKCN];
		AHECINMBEGF.RemoveAt(LHOJEJCFKCN);
		return result;
	}

	public override JLODNMAAHAC CJOHLENDJGO(JLODNMAAHAC LELOKDCLJMD)
	{
		AHECINMBEGF.Remove(LELOKDCLJMD);
		return LELOKDCLJMD;
	}

	public IEnumerator GetEnumerator()
	{
		foreach (JLODNMAAHAC item in AHECINMBEGF)
		{
			yield return item;
		}
	}

	public override string ToString()
	{
		string text = "[ ";
		foreach (JLODNMAAHAC item in AHECINMBEGF)
		{
			if (text.Length > 2)
			{
				text += ", ";
			}
			text += item.ToString();
		}
		return text + " ]";
	}

	public override string NHMGCGBMCNM(string KECKLEJAGKP)
	{
		string text = "[ ";
		foreach (JLODNMAAHAC item in AHECINMBEGF)
		{
			if (text.Length > 3)
			{
				text += ", ";
			}
			text = text + "\n" + KECKLEJAGKP + "   ";
			text += item.NHMGCGBMCNM(KECKLEJAGKP + "   ");
		}
		return text + "\n" + KECKLEJAGKP + "]";
	}

	public override void LFIJNCAPDMO(BinaryWriter DOLOAHGOLMI)
	{
		DOLOAHGOLMI.Write((byte)1);
		DOLOAHGOLMI.Write(AHECINMBEGF.Count);
		for (int i = 0; i < AHECINMBEGF.Count; i++)
		{
			AHECINMBEGF[i].LFIJNCAPDMO(DOLOAHGOLMI);
		}
	}
}
