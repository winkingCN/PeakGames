using System;
using System.Threading;

internal abstract class KPKGCNEJIAM : CGDEGBGOKJO
{
	private static long CKKJMJHIJBN = ONALFDLIJGB.HJDDGNCAKFG();

	private readonly ENDHCNJKMOL APCDPCCPOOO;

	private readonly FBIJJFGLKMK BECLOCCFICG;

	private readonly PDCALMCFKGD CGEBPLCBCCP;

	private OBDIBELBBEO DPCIPFDPFAF;

	private OBDIBELBBEO CJAFBBCOKCH;

	private POBPBLILLLP KDFDNFBEHEP;

	private object DNPNMNNNDFF;

	public virtual ENDHCNJKMOL EMBMHGPGOIP
	{
		get
		{
			return APCDPCCPOOO;
		}
	}

	public virtual FBIJJFGLKMK KMLKPFPCFLA
	{
		get
		{
			return BECLOCCFICG;
		}
	}

	public virtual PDCALMCFKGD HFMNBFOAPOP
	{
		get
		{
			return CGEBPLCBCCP;
		}
	}

	public abstract bool DLHCCNKGKJP { get; }

	public virtual OBDIBELBBEO BEHNDIMGDKM
	{
		get
		{
			return DPCIPFDPFAF;
		}
	}

	public virtual OBDIBELBBEO PJJKOIEAGJN
	{
		get
		{
			return CJAFBBCOKCH;
		}
	}

	public virtual POBPBLILLLP CFMLLFNCEJA
	{
		get
		{
			return KDFDNFBEHEP;
		}
	}

	public virtual object JJDKOCGPGLO
	{
		get
		{
			return DNPNMNNNDFF;
		}
		set
		{
			DNPNMNNNDFF = value;
		}
	}

	internal KPKGCNEJIAM(FBIJJFGLKMK ENKGBJPFHAO, PDCALMCFKGD BOHAELIJHGF)
	{
		BJLAMONNNDD bJLAMONNNDD = KINEBFNENMB.KNADNPDKLGD(4);
		byte[] array = new byte[bJLAMONNNDD.EEMLLAMENHO()];
		ENKGBJPFHAO.NextBytes(array);
		APCDPCCPOOO = new DABKMDDBDFE(bJLAMONNNDD);
		APCDPCCPOOO.GMFBMHLENMN(INCFLDPLLDF());
		APCDPCCPOOO.GMFBMHLENMN(ONALFDLIJGB.HJDDGNCAKFG());
		APCDPCCPOOO.GMFBMHLENMN(array);
		BECLOCCFICG = ENKGBJPFHAO;
		CGEBPLCBCCP = BOHAELIJHGF;
	}

	private static long INCFLDPLLDF()
	{
		return Interlocked.Increment(ref CKKJMJHIJBN);
	}

	internal virtual void MJFGAIIBHKB(OBDIBELBBEO ANFOFLFNDAK)
	{
		DPCIPFDPFAF = ANFOFLFNDAK;
	}

	internal virtual void JBFNLEHOPGK(OBDIBELBBEO AJKHHEOLCMD)
	{
		CJAFBBCOKCH = AJKHHEOLCMD;
	}

	internal virtual void IMMNFAHMDOB(POBPBLILLLP JDFMMECNFKB)
	{
		KDFDNFBEHEP = JDFMMECNFKB;
	}

	public virtual byte[] JHKCLNJBKHE(string FEHKBFBPJIF, byte[] ECPAMJCHIDK, int EOFAGACBNFP)
	{
		if (ECPAMJCHIDK != null && !KINEBFNENMB.BPOIEAFILAH(ECPAMJCHIDK.Length))
		{
			throw new ArgumentException("must have length less than 2^16 (or be null)", "context_value");
		}
		PDCALMCFKGD pDCALMCFKGD = HFMNBFOAPOP;
		byte[] array = pDCALMCFKGD.BABNEJKEAHH;
		byte[] array2 = pDCALMCFKGD.NGDLBBHPGPA;
		int num = array.Length + array2.Length;
		if (ECPAMJCHIDK != null)
		{
			num += 2 + ECPAMJCHIDK.Length;
		}
		byte[] array3 = new byte[num];
		int num2 = 0;
		Array.Copy(array, 0, array3, num2, array.Length);
		num2 += array.Length;
		Array.Copy(array2, 0, array3, num2, array2.Length);
		num2 += array2.Length;
		if (ECPAMJCHIDK != null)
		{
			KINEBFNENMB.PGBAOHFKNHN(ECPAMJCHIDK.Length, array3, num2);
			num2 += 2;
			Array.Copy(ECPAMJCHIDK, 0, array3, num2, ECPAMJCHIDK.Length);
			num2 += ECPAMJCHIDK.Length;
		}
		if (num2 != num)
		{
			throw new InvalidOperationException("error in calculation of seed for export");
		}
		return KINEBFNENMB.NHKMLDKHIIH(this, pDCALMCFKGD.EFKBHGKOMBB, FEHKBFBPJIF, array3, EOFAGACBNFP);
	}
}
