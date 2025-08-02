using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

[DefaultMember("Item")]
public class OMOOJCDPFEL : DPKJGBCDECA, IEnumerable
{
	private List<DPKJGBCDECA> AHECINMBEGF = new List<DPKJGBCDECA>();

	public override DPKJGBCDECA AHANCLBKKID
	{
		get
		{
			if (LHOJEJCFKCN < 0 || LHOJEJCFKCN >= AHECINMBEGF.Count)
			{
				return new CNDAJPPEAPE(this);
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

	public override DPKJGBCDECA AHANCLBKKID
	{
		get
		{
			return new CNDAJPPEAPE(this);
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

	public override IEnumerable<DPKJGBCDECA> JHEDPFKFFJB
	{
		get
		{
			foreach (DPKJGBCDECA item in AHECINMBEGF)
			{
				yield return item;
			}
		}
	}

	public override void JEACJNAKLDJ(string OMGPFPGELOM, DPKJGBCDECA GFADEOLDFDI)
	{
		AHECINMBEGF.Add(GFADEOLDFDI);
	}

	public override DPKJGBCDECA CJOHLENDJGO(int LHOJEJCFKCN)
	{
		if (LHOJEJCFKCN < 0 || LHOJEJCFKCN >= AHECINMBEGF.Count)
		{
			return null;
		}
		DPKJGBCDECA result = AHECINMBEGF[LHOJEJCFKCN];
		AHECINMBEGF.RemoveAt(LHOJEJCFKCN);
		return result;
	}

	public override DPKJGBCDECA CJOHLENDJGO(DPKJGBCDECA LELOKDCLJMD)
	{
		AHECINMBEGF.Remove(LELOKDCLJMD);
		return LELOKDCLJMD;
	}

	public IEnumerator GetEnumerator()
	{
		foreach (DPKJGBCDECA item in AHECINMBEGF)
		{
			yield return item;
		}
	}

	public override string ToString()
	{
		string text = "[ ";
		foreach (DPKJGBCDECA item in AHECINMBEGF)
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
		foreach (DPKJGBCDECA item in AHECINMBEGF)
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
