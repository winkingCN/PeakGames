using System;
using System.Collections;
using System.IO;

public class OHNBHCLIOEI : CFMJBFILJCB, IEnumerable
{
	private const int JKHMJHPKOKA = 1000;

	private readonly IEnumerable EEEFJGLFOEE;

	public OHNBHCLIOEI(byte[] GFPBBLPMOOL)
		: base(GFPBBLPMOOL)
	{
	}

	public OHNBHCLIOEI(IEnumerable KBOOEAPJGEL)
		: base(HPCPIFHDBGL(KBOOEAPJGEL))
	{
		EEEFJGLFOEE = KBOOEAPJGEL;
	}

	public OHNBHCLIOEI(EDOEBJJFOBM NEMEKIOEOLC)
		: base(NEMEKIOEOLC)
	{
	}

	public OHNBHCLIOEI(LNKPCJLANAO NEMEKIOEOLC)
		: base(NEMEKIOEOLC.IIHKEACDNID())
	{
	}

	public static OHNBHCLIOEI PNDOAFIAFOE(ALLINHNNNJN MIABODPHOIP)
	{
		IList list = LHFGHNFJIKM.PPPFFFBMGML();
		foreach (LNKPCJLANAO item in MIABODPHOIP)
		{
			list.Add(item);
		}
		return new OHNBHCLIOEI(list);
	}

	private static byte[] HPCPIFHDBGL(IEnumerable EEEFJGLFOEE)
	{
		MemoryStream memoryStream = new MemoryStream();
		foreach (CFMJBFILJCB item in EEEFJGLFOEE)
		{
			byte[] array = item.KLHNEKMCKKI();
			memoryStream.Write(array, 0, array.Length);
		}
		return memoryStream.ToArray();
	}

	public override byte[] KLHNEKMCKKI()
	{
		return GFPBBLPMOOL;
	}

	public IEnumerator GetEnumerator()
	{
		if (EEEFJGLFOEE == null)
		{
			return EDFJPOJCJDK().GetEnumerator();
		}
		return EEEFJGLFOEE.GetEnumerator();
	}

	[Obsolete("Use GetEnumerator() instead")]
	public IEnumerator NELJFJIOJEI()
	{
		return GetEnumerator();
	}

	private IList EDFJPOJCJDK()
	{
		IList list = LHFGHNFJIKM.PPPFFFBMGML();
		for (int i = 0; i < GFPBBLPMOOL.Length; i += 1000)
		{
			int num = Math.Min(GFPBBLPMOOL.Length, i + 1000);
			byte[] array = new byte[num - i];
			Array.Copy(GFPBBLPMOOL, i, array, 0, array.Length);
			list.Add(new CFMJBFILJCB(array));
		}
		return list;
	}

	internal override void LMDBBPLCJDM(JBLJHINPLMC NMHOOGAGLOA)
	{
		if (NMHOOGAGLOA is KDNENBIPFBJ || NMHOOGAGLOA is OPNGAMEJCPK)
		{
			NMHOOGAGLOA.WriteByte(36);
			NMHOOGAGLOA.WriteByte(128);
			{
				IEnumerator enumerator = GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						CFMJBFILJCB nEMEKIOEOLC = (CFMJBFILJCB)enumerator.Current;
						NMHOOGAGLOA.ELPOLPFGCHA(nEMEKIOEOLC);
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
			}
			NMHOOGAGLOA.WriteByte(0);
			NMHOOGAGLOA.WriteByte(0);
		}
		else
		{
			base.LMDBBPLCJDM(NMHOOGAGLOA);
		}
	}
}
