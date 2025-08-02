using System.Collections;
using System.IO;

public class OOKLBMMBONO
{
	protected readonly byte[] DPKPENLKPOA;

	protected readonly IList CFGIHFFACPK;

	protected readonly IList CBECKPNIFLK;

	public virtual byte[] JBMMCGPHNBP
	{
		get
		{
			return DPKPENLKPOA;
		}
	}

	public virtual IList BGMFIEMDPBF
	{
		get
		{
			return CFGIHFFACPK;
		}
	}

	public virtual IList CLLPLGHDJMF
	{
		get
		{
			return CBECKPNIFLK;
		}
	}

	public OOKLBMMBONO(byte[] MOFPJJDCDFI, IList GMLLEBDADDP, IList ICGGJKOBGMN)
	{
		DPKPENLKPOA = MOFPJJDCDFI;
		CFGIHFFACPK = GMLLEBDADDP;
		CBECKPNIFLK = ICGGJKOBGMN;
	}

	public virtual void LMDBBPLCJDM(Stream BILGCJNPJGJ)
	{
		if (DPKPENLKPOA == null || DPKPENLKPOA.Length == 0)
		{
			KINEBFNENMB.JBOHOOBEPAM(0, BILGCJNPJGJ);
		}
		else
		{
			KINEBFNENMB.NKEAKKGFPGB(DPKPENLKPOA, BILGCJNPJGJ);
		}
		if (CFGIHFFACPK != null)
		{
			KINEBFNENMB.CCIJOGKGICD(CFGIHFFACPK, false, BILGCJNPJGJ);
		}
		if (CBECKPNIFLK == null || CBECKPNIFLK.Count < 1)
		{
			KINEBFNENMB.PGBAOHFKNHN(0, BILGCJNPJGJ);
			return;
		}
		IList list = LHFGHNFJIKM.PPPFFFBMGML(CBECKPNIFLK.Count);
		int num = 0;
		foreach (LNKPCJLANAO item in CBECKPNIFLK)
		{
			byte[] array = item.PPCPBIEGJKM("DER");
			list.Add(array);
			num += array.Length + 2;
		}
		KINEBFNENMB.AKGIEBIEJJL(num);
		KINEBFNENMB.PGBAOHFKNHN(num, BILGCJNPJGJ);
		foreach (byte[] item2 in list)
		{
			KINEBFNENMB.HIPJBHBLGEI(item2, BILGCJNPJGJ);
		}
	}

	public static OOKLBMMBONO DHCLOMIANOE(CGDEGBGOKJO MBEMNOCDDBC, Stream MOPCLEEGDFB)
	{
		int num = KINEBFNENMB.HEEOKPLLJMG(MOPCLEEGDFB);
		byte[] array = new byte[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = KINEBFNENMB.HEEOKPLLJMG(MOPCLEEGDFB);
		}
		IList gMLLEBDADDP = null;
		if (KINEBFNENMB.OHGCLELCPMD(MBEMNOCDDBC))
		{
			gMLLEBDADDP = KINEBFNENMB.GKPICDDIKHJ(false, MOPCLEEGDFB);
		}
		IList list = LHFGHNFJIKM.PPPFFFBMGML();
		byte[] buffer = KINEBFNENMB.HDGCNMILKAA(MOPCLEEGDFB);
		MemoryStream memoryStream = new MemoryStream(buffer, false);
		while (memoryStream.Position < memoryStream.Length)
		{
			byte[] nJPMJNHGDNE = KINEBFNENMB.HDGCNMILKAA(memoryStream);
			EDOEBJJFOBM nEMEKIOEOLC = KINEBFNENMB.LCEOAGADAFB(nJPMJNHGDNE);
			list.Add(HMMHEPKCKCP.BJLJCGFMFOO(nEMEKIOEOLC));
		}
		return new OOKLBMMBONO(array, gMLLEBDADDP, list);
	}
}
