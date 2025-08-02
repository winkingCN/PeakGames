public abstract class NJDFMFJGDDJ : DIDKFJGJDPC
{
	public NJDFMFJGDDJ()
	{
	}

	public NJDFMFJGDDJ(CJCKDELDNLB HOPNNDNDFMC)
		: base(HOPNNDNDFMC)
	{
	}

	public override int[] JJABFAMPIIB()
	{
		return new int[15]
		{
			49195, 49187, 49161, 49199, 49191, 49171, 162, 64, 50, 158,
			103, 51, 156, 60, 47
		};
	}

	public override HMPLNBAPPNE CNJBDCLEKNL()
	{
		int num = KINEBFNENMB.DPIKBAJJABM(HOGFBOADFJJ);
		switch (num)
		{
		case 7:
		case 9:
			return HDCHLPJFACC(num);
		case 3:
		case 5:
			return CMHBEBCBPHK(num);
		case 16:
		case 18:
		case 20:
			return DNNGIIJMOBG(num);
		case 17:
		case 19:
			return DGLIGIGNPNL(num);
		case 1:
			return KIOMCCGLLLG();
		default:
			throw new DEIDBCPPCMB(80);
		}
	}

	protected virtual HMPLNBAPPNE HDCHLPJFACC(int EBOOFBMGNDI)
	{
		return new ABFMEJBCEFO(EBOOFBMGNDI, CFGIHFFACPK, null);
	}

	protected virtual HMPLNBAPPNE CMHBEBCBPHK(int EBOOFBMGNDI)
	{
		return new EFENHHBJKEL(EBOOFBMGNDI, CFGIHFFACPK, null);
	}

	protected virtual HMPLNBAPPNE DNNGIIJMOBG(int EBOOFBMGNDI)
	{
		return new AKBAHAJEILE(EBOOFBMGNDI, CFGIHFFACPK, AJMLOOJHBBO, HLPGDFLIDKC, OEOBANOOGDJ);
	}

	protected virtual HMPLNBAPPNE DGLIGIGNPNL(int EBOOFBMGNDI)
	{
		return new DDDFEMJOONH(EBOOFBMGNDI, CFGIHFFACPK, AJMLOOJHBBO, HLPGDFLIDKC, OEOBANOOGDJ);
	}

	protected virtual HMPLNBAPPNE KIOMCCGLLLG()
	{
		return new OCLDHIDJHBP(CFGIHFFACPK);
	}
}
