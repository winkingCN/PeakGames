using System.IO;

public class KIGEMNPNCBN : HHFIFCOHIFL
{
	private bool KIIDLMIJMGH;

	private bool OJGMJIAIBBI;

	private int OFJNLGKHCMB;

	protected KIGEMNPNCBN(Stream OMCALCLJPOD)
		: base(OMCALCLJPOD)
	{
	}

	public KIGEMNPNCBN(Stream OMCALCLJPOD, int LGPKPEMILHA, bool DNBCBHLACCP)
		: base(OMCALCLJPOD)
	{
		KIIDLMIJMGH = true;
		OJGMJIAIBBI = DNBCBHLACCP;
		OFJNLGKHCMB = LGPKPEMILHA;
	}

	public override void HIJCJONMAJO(LNKPCJLANAO NEMEKIOEOLC)
	{
		new OPNGAMEJCPK(base.CLDOFILJLHP).ELPOLPFGCHA(NEMEKIOEOLC);
	}

	public override Stream ENJAKPDFHAM()
	{
		return base.CLDOFILJLHP;
	}

	public override void NKKOEHGDNKD()
	{
		PPKFLJECGNE();
	}

	private void FOKLNMNBIKI(int MOKLDCMGFFB)
	{
		base.CLDOFILJLHP.WriteByte((byte)MOKLDCMGFFB);
		base.CLDOFILJLHP.WriteByte(128);
	}

	protected void HICECABJALK(int MOKLDCMGFFB)
	{
		if (KIIDLMIJMGH)
		{
			int num = OFJNLGKHCMB | 0x80;
			if (OJGMJIAIBBI)
			{
				FOKLNMNBIKI(num | 0x20);
				FOKLNMNBIKI(MOKLDCMGFFB);
			}
			else if (((uint)MOKLDCMGFFB & 0x20u) != 0)
			{
				FOKLNMNBIKI(num | 0x20);
			}
			else
			{
				FOKLNMNBIKI(num);
			}
		}
		else
		{
			FOKLNMNBIKI(MOKLDCMGFFB);
		}
	}

	protected void DAPFBGDDEFL(Stream KPHHLMBMHEC)
	{
		NPBFDBCHIGL.CDMHFNBBNIF(KPHHLMBMHEC, base.CLDOFILJLHP);
	}

	protected void PPKFLJECGNE()
	{
		base.CLDOFILJLHP.WriteByte(0);
		base.CLDOFILJLHP.WriteByte(0);
		if (KIIDLMIJMGH && OJGMJIAIBBI)
		{
			base.CLDOFILJLHP.WriteByte(0);
			base.CLDOFILJLHP.WriteByte(0);
		}
	}
}
