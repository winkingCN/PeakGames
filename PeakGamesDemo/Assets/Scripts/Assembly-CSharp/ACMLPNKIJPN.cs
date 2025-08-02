using System;
using System.Collections;

public class ACMLPNKIJPN : CDHAHIDPGBP
{
	public new static readonly ACMLPNKIJPN JIKOOGGLMBO = new ACMLPNKIJPN();

	public ACMLPNKIJPN()
	{
	}

	public ACMLPNKIJPN(LNKPCJLANAO NEMEKIOEOLC)
		: base(NEMEKIOEOLC)
	{
	}

	public ACMLPNKIJPN(DLDBGGDLOOO AAIEJDNAODP)
		: base(AAIEJDNAODP, false)
	{
	}

	internal ACMLPNKIJPN(DLDBGGDLOOO AAIEJDNAODP, bool KGGNPPNNLFD)
		: base(AAIEJDNAODP, KGGNPPNNLFD)
	{
	}

	public new static ACMLPNKIJPN CGMEKNCLBKE(DLDBGGDLOOO AAIEJDNAODP)
	{
		return (AAIEJDNAODP.GMCGMPEEHJP >= 1) ? new ACMLPNKIJPN(AAIEJDNAODP) : JIKOOGGLMBO;
	}

	internal new static ACMLPNKIJPN CGMEKNCLBKE(DLDBGGDLOOO AAIEJDNAODP, bool KGGNPPNNLFD)
	{
		return (AAIEJDNAODP.GMCGMPEEHJP >= 1) ? new ACMLPNKIJPN(AAIEJDNAODP, KGGNPPNNLFD) : JIKOOGGLMBO;
	}

	internal override void LMDBBPLCJDM(JBLJHINPLMC NMHOOGAGLOA)
	{
		if (NMHOOGAGLOA is KDNENBIPFBJ || NMHOOGAGLOA is OPNGAMEJCPK)
		{
			NMHOOGAGLOA.WriteByte(49);
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
