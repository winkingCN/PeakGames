using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
internal class PIBKMEGHMOC : CDHAHIDPGBP
{
	private byte[] AJDDGHDGHDC;

	public override LNKPCJLANAO AHANCLBKKID
	{
		get
		{
			DHCLOMIANOE();
			return ((FAGODOKGMEH)this).ECNCPJGHBIG(EHJNMODJEAN);
		}
	}

	public override int GMCGMPEEHJP
	{
		get
		{
			DHCLOMIANOE();
			return base.GMCGMPEEHJP;
		}
	}

	internal PIBKMEGHMOC(byte[] AJDDGHDGHDC)
	{
		this.AJDDGHDGHDC = AJDDGHDGHDC;
	}

	private void DHCLOMIANOE()
	{
		lock (this)
		{
			if (AJDDGHDGHDC != null)
			{
				AOKAOIHEKIH aOKAOIHEKIH = new AAHBFGFDINE(AJDDGHDGHDC);
				EDOEBJJFOBM nEMEKIOEOLC;
				while ((nEMEKIOEOLC = aOKAOIHEKIH.DMHLIGLGJGI()) != null)
				{
					HIJCJONMAJO(nEMEKIOEOLC);
				}
				AJDDGHDGHDC = null;
			}
		}
	}

	public override IEnumerator GetEnumerator()
	{
		DHCLOMIANOE();
		return base.GetEnumerator();
	}

	internal override void LMDBBPLCJDM(JBLJHINPLMC NMHOOGAGLOA)
	{
		lock (this)
		{
			if (AJDDGHDGHDC == null)
			{
				base.LMDBBPLCJDM(NMHOOGAGLOA);
			}
			else
			{
				NMHOOGAGLOA.AGNEJPEMPAP(49, AJDDGHDGHDC);
			}
		}
	}
}
