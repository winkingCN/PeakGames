using System;
using System.Collections;

public class KBOHOKHJFBA : KOGPLMALOEH
{
	public new static readonly KBOHOKHJFBA JIKOOGGLMBO = new KBOHOKHJFBA();

	public KBOHOKHJFBA()
	{
	}

	public KBOHOKHJFBA(LNKPCJLANAO NEMEKIOEOLC)
		: base(NEMEKIOEOLC)
	{
	}

	public KBOHOKHJFBA(params LNKPCJLANAO[] AAIEJDNAODP)
		: base(AAIEJDNAODP)
	{
	}

	public KBOHOKHJFBA(DLDBGGDLOOO AAIEJDNAODP)
		: base(AAIEJDNAODP)
	{
	}

	public new static KBOHOKHJFBA CGMEKNCLBKE(DLDBGGDLOOO AAIEJDNAODP)
	{
		return (AAIEJDNAODP.GMCGMPEEHJP >= 1) ? new KBOHOKHJFBA(AAIEJDNAODP) : JIKOOGGLMBO;
	}

	internal override void LMDBBPLCJDM(JBLJHINPLMC NMHOOGAGLOA)
	{
		if (NMHOOGAGLOA is KDNENBIPFBJ || NMHOOGAGLOA is OPNGAMEJCPK)
		{
			NMHOOGAGLOA.WriteByte(48);
			NMHOOGAGLOA.WriteByte(128);
			{
				IEnumerator enumerator = GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						LNKPCJLANAO nEMEKIOEOLC = (LNKPCJLANAO)enumerator.Current;
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
