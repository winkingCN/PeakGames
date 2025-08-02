using System;
using System.IO;

public class OPNGAMEJCPK : JBLJHINPLMC
{
	public OPNGAMEJCPK(Stream EDKDOJFEFMD)
		: base(EDKDOJFEFMD)
	{
	}

	[Obsolete("Use version taking an Asn1Encodable arg instead")]
	public override void ELPOLPFGCHA(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == null)
		{
			DPPBMODABNA();
			return;
		}
		if (NEMEKIOEOLC is EDOEBJJFOBM)
		{
			((EDOEBJJFOBM)NEMEKIOEOLC).LMDBBPLCJDM(this);
			return;
		}
		if (NEMEKIOEOLC is LNKPCJLANAO)
		{
			((LNKPCJLANAO)NEMEKIOEOLC).IIHKEACDNID().LMDBBPLCJDM(this);
			return;
		}
		throw new IOException("object not BerEncodable");
	}
}
