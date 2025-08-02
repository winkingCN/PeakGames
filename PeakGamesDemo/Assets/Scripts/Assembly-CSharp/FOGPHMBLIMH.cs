using System.Collections;

public class FOGPHMBLIMH : JIHIOOKBBLB
{
	public FOGPHMBLIMH(int LGPKPEMILHA, LNKPCJLANAO NEMEKIOEOLC)
		: base(LGPKPEMILHA, NEMEKIOEOLC)
	{
	}

	public FOGPHMBLIMH(bool DHGLJHFEJFL, int LGPKPEMILHA, LNKPCJLANAO NEMEKIOEOLC)
		: base(DHGLJHFEJFL, LGPKPEMILHA, NEMEKIOEOLC)
	{
	}

	public FOGPHMBLIMH(int LGPKPEMILHA)
		: base(false, LGPKPEMILHA, KBOHOKHJFBA.JIKOOGGLMBO)
	{
	}

	internal override void LMDBBPLCJDM(JBLJHINPLMC NMHOOGAGLOA)
	{
		if (NMHOOGAGLOA is KDNENBIPFBJ || NMHOOGAGLOA is OPNGAMEJCPK)
		{
			NMHOOGAGLOA.DCFAKMDJNLN(160, LGPKPEMILHA);
			NMHOOGAGLOA.WriteByte(128);
			if (!DHIKCKFGKID())
			{
				if (!DHGLJHFEJFL)
				{
					IEnumerable enumerable;
					if (NEMEKIOEOLC is PJGIGKJFGFI)
					{
						if (NEMEKIOEOLC is OHNBHCLIOEI)
						{
							enumerable = (OHNBHCLIOEI)NEMEKIOEOLC;
						}
						else
						{
							PJGIGKJFGFI pJGIGKJFGFI = (PJGIGKJFGFI)NEMEKIOEOLC;
							enumerable = new OHNBHCLIOEI(pJGIGKJFGFI.KLHNEKMCKKI());
						}
					}
					else if (NEMEKIOEOLC is ALLINHNNNJN)
					{
						enumerable = (ALLINHNNNJN)NEMEKIOEOLC;
					}
					else
					{
						if (!(NEMEKIOEOLC is FAGODOKGMEH))
						{
							throw LHFGHNFJIKM.HOAJHBJIAIC(LHFGHNFJIKM.JKHOEKAOLPM(NEMEKIOEOLC));
						}
						enumerable = (FAGODOKGMEH)NEMEKIOEOLC;
					}
					foreach (LNKPCJLANAO item in enumerable)
					{
						NMHOOGAGLOA.ELPOLPFGCHA(item);
					}
				}
				else
				{
					NMHOOGAGLOA.ELPOLPFGCHA(NEMEKIOEOLC);
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
