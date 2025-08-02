using System.Collections;
using System.Collections.Generic;

internal class FPIGGKDFOPK : IDictionaryEnumerator, IEnumerator
{
	private IEnumerator<KeyValuePair<string, FMHLMKJKDEG>> IKKEPKGBJMG;

	public object DCBEHIGDMDP
	{
		get
		{
			return JOLEIBNDDEG;
		}
	}

	public DictionaryEntry JOLEIBNDDEG
	{
		get
		{
			KeyValuePair<string, FMHLMKJKDEG> current = IKKEPKGBJMG.Current;
			return new DictionaryEntry(current.Key, current.Value);
		}
	}

	public object CDEOGMLENPN
	{
		get
		{
			return IKKEPKGBJMG.Current.Key;
		}
	}

	public object JBGOANMLBFA
	{
		get
		{
			return IKKEPKGBJMG.Current.Value;
		}
	}

	public FPIGGKDFOPK(IEnumerator<KeyValuePair<string, FMHLMKJKDEG>> JLEFEDIIJKH)
	{
		IKKEPKGBJMG = JLEFEDIIJKH;
	}

	public bool MoveNext()
	{
		return IKKEPKGBJMG.MoveNext();
	}

	public void Reset()
	{
		IKKEPKGBJMG.Reset();
	}
}
