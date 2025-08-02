using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

[DefaultMember("Item")]
public class FDKLGGOAFPJ : JLODNMAAHAC, IEnumerable
{
	[CompilerGenerated]
	private sealed class HBNFGMHLPND
	{
		internal JLODNMAAHAC LELOKDCLJMD;

		internal bool AGFNGEFDHLA(KeyValuePair<string, JLODNMAAHAC> BENKLGPHLGI)
		{
			return JLODNMAAHAC.OCAFFLHPIMM(BENKLGPHLGI.Value, LELOKDCLJMD);
		}
	}

	private Dictionary<string, JLODNMAAHAC> ADHKCFOJFBB = new Dictionary<string, JLODNMAAHAC>(StringComparer.Ordinal);

	public override JLODNMAAHAC AHANCLBKKID
	{
		get
		{
			if (ADHKCFOJFBB.ContainsKey(OMGPFPGELOM))
			{
				return ADHKCFOJFBB[OMGPFPGELOM];
			}
			return new MPHIIHDHBBF(this, OMGPFPGELOM);
		}
		set
		{
			if (ADHKCFOJFBB.ContainsKey(OMGPFPGELOM))
			{
				ADHKCFOJFBB[OMGPFPGELOM] = value;
			}
			else
			{
				ADHKCFOJFBB.Add(OMGPFPGELOM, value);
			}
		}
	}

	public override JLODNMAAHAC AHANCLBKKID
	{
		get
		{
			if (LHOJEJCFKCN < 0 || LHOJEJCFKCN >= ADHKCFOJFBB.Count)
			{
				return null;
			}
			return ADHKCFOJFBB.ElementAt(LHOJEJCFKCN).Value;
		}
		set
		{
			if (LHOJEJCFKCN >= 0 && LHOJEJCFKCN < ADHKCFOJFBB.Count)
			{
				string key = ADHKCFOJFBB.ElementAt(LHOJEJCFKCN).Key;
				ADHKCFOJFBB[key] = value;
			}
		}
	}

	public override int GMCGMPEEHJP
	{
		get
		{
			return ADHKCFOJFBB.Count;
		}
	}

	public override IEnumerable<JLODNMAAHAC> JHEDPFKFFJB
	{
		get
		{
			foreach (KeyValuePair<string, JLODNMAAHAC> item in ADHKCFOJFBB)
			{
				yield return item.Value;
			}
		}
	}

	public override void JEACJNAKLDJ(string OMGPFPGELOM, JLODNMAAHAC GFADEOLDFDI)
	{
		if (!string.IsNullOrEmpty(OMGPFPGELOM))
		{
			if (ADHKCFOJFBB.ContainsKey(OMGPFPGELOM))
			{
				ADHKCFOJFBB[OMGPFPGELOM] = GFADEOLDFDI;
			}
			else
			{
				ADHKCFOJFBB.Add(OMGPFPGELOM, GFADEOLDFDI);
			}
		}
		else
		{
			ADHKCFOJFBB.Add(Guid.NewGuid().ToString(), GFADEOLDFDI);
		}
	}

	public override JLODNMAAHAC CJOHLENDJGO(string OMGPFPGELOM)
	{
		if (!ADHKCFOJFBB.ContainsKey(OMGPFPGELOM))
		{
			return null;
		}
		JLODNMAAHAC result = ADHKCFOJFBB[OMGPFPGELOM];
		ADHKCFOJFBB.Remove(OMGPFPGELOM);
		return result;
	}

	public override JLODNMAAHAC CJOHLENDJGO(int LHOJEJCFKCN)
	{
		if (LHOJEJCFKCN < 0 || LHOJEJCFKCN >= ADHKCFOJFBB.Count)
		{
			return null;
		}
		KeyValuePair<string, JLODNMAAHAC> keyValuePair = ADHKCFOJFBB.ElementAt(LHOJEJCFKCN);
		ADHKCFOJFBB.Remove(keyValuePair.Key);
		return keyValuePair.Value;
	}

	public override JLODNMAAHAC CJOHLENDJGO(JLODNMAAHAC LELOKDCLJMD)
	{
		try
		{
			KeyValuePair<string, JLODNMAAHAC> keyValuePair = ADHKCFOJFBB.Where((KeyValuePair<string, JLODNMAAHAC> BENKLGPHLGI) => JLODNMAAHAC.OCAFFLHPIMM(BENKLGPHLGI.Value, LELOKDCLJMD)).First();
			ADHKCFOJFBB.Remove(keyValuePair.Key);
			return LELOKDCLJMD;
		}
		catch
		{
			return null;
		}
	}

	public IEnumerator GetEnumerator()
	{
		foreach (KeyValuePair<string, JLODNMAAHAC> item in ADHKCFOJFBB)
		{
			yield return item;
		}
	}

	public override string ToString()
	{
		string text = "{";
		foreach (KeyValuePair<string, JLODNMAAHAC> item in ADHKCFOJFBB)
		{
			if (text.Length > 2)
			{
				text += ", ";
			}
			string text2 = text;
			text = text2 + "\"" + JLODNMAAHAC.CDFEDEOOJDC(item.Key) + "\":" + item.Value.ToString();
		}
		return text + "}";
	}

	public override string NHMGCGBMCNM(string KECKLEJAGKP)
	{
		string text = "{ ";
		foreach (KeyValuePair<string, JLODNMAAHAC> item in ADHKCFOJFBB)
		{
			if (text.Length > 3)
			{
				text += ", ";
			}
			text = text + "\n" + KECKLEJAGKP + "   ";
			string text2 = text;
			text = text2 + "\"" + JLODNMAAHAC.CDFEDEOOJDC(item.Key) + "\" : " + item.Value.NHMGCGBMCNM(KECKLEJAGKP + "   ");
		}
		return text + "\n" + KECKLEJAGKP + "}";
	}

	public override void LFIJNCAPDMO(BinaryWriter DOLOAHGOLMI)
	{
		DOLOAHGOLMI.Write((byte)2);
		DOLOAHGOLMI.Write(ADHKCFOJFBB.Count);
		foreach (string key in ADHKCFOJFBB.Keys)
		{
			DOLOAHGOLMI.Write(key);
			ADHKCFOJFBB[key].LFIJNCAPDMO(DOLOAHGOLMI);
		}
	}
}
