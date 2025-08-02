using System;
using System.Collections;
using System.IO;

public class PAJJBHMEFKE
{
	public static readonly PAJJBHMEFKE PGOFIDPLOAA = new PAJJBHMEFKE(new NGNPCPDMGBC[0]);

	protected readonly NGNPCPDMGBC[] NKNPPLKDKBE;

	public virtual int EJIAJLPHOGC
	{
		get
		{
			return NKNPPLKDKBE.Length;
		}
	}

	public virtual bool DHIKCKFGKID
	{
		get
		{
			return NKNPPLKDKBE.Length == 0;
		}
	}

	public PAJJBHMEFKE(NGNPCPDMGBC[] MNDLODHMKKK)
	{
		if (MNDLODHMKKK == null)
		{
			throw new ArgumentNullException("certificateList");
		}
		NKNPPLKDKBE = MNDLODHMKKK;
	}

	public virtual NGNPCPDMGBC[] ELCOAJMCEMD()
	{
		return LEHJJEBHPFK();
	}

	public virtual NGNPCPDMGBC IGGCPKOFOMP(int EHJNMODJEAN)
	{
		return NKNPPLKDKBE[EHJNMODJEAN];
	}

	public virtual void LMDBBPLCJDM(Stream BILGCJNPJGJ)
	{
		IList list = LHFGHNFJIKM.PPPFFFBMGML(NKNPPLKDKBE.Length);
		int num = 0;
		NGNPCPDMGBC[] nKNPPLKDKBE = NKNPPLKDKBE;
		foreach (LNKPCJLANAO lNKPCJLANAO in nKNPPLKDKBE)
		{
			byte[] array = lNKPCJLANAO.PPCPBIEGJKM("DER");
			list.Add(array);
			num += array.Length + 3;
		}
		KINEBFNENMB.CJIFBMOJIBB(num);
		KINEBFNENMB.HKPEAEDPGAD(num, BILGCJNPJGJ);
		foreach (byte[] item in list)
		{
			KINEBFNENMB.GHMOBMODGDF(item, BILGCJNPJGJ);
		}
	}

	public static PAJJBHMEFKE DHCLOMIANOE(Stream MOPCLEEGDFB)
	{
		int num = KINEBFNENMB.MFIAOJHGMHG(MOPCLEEGDFB);
		if (num == 0)
		{
			return PGOFIDPLOAA;
		}
		byte[] buffer = KINEBFNENMB.PCNDKGFHPJN(num, MOPCLEEGDFB);
		MemoryStream memoryStream = new MemoryStream(buffer, false);
		IList list = LHFGHNFJIKM.PPPFFFBMGML();
		while (memoryStream.Position < memoryStream.Length)
		{
			byte[] nJPMJNHGDNE = KINEBFNENMB.MCBPCLGJPGF(memoryStream);
			EDOEBJJFOBM nEMEKIOEOLC = KINEBFNENMB.LCEOAGADAFB(nJPMJNHGDNE);
			list.Add(NGNPCPDMGBC.BJLJCGFMFOO(nEMEKIOEOLC));
		}
		NGNPCPDMGBC[] array = new NGNPCPDMGBC[list.Count];
		for (int i = 0; i < list.Count; i++)
		{
			array[i] = (NGNPCPDMGBC)list[i];
		}
		return new PAJJBHMEFKE(array);
	}

	protected virtual NGNPCPDMGBC[] LEHJJEBHPFK()
	{
		return (NGNPCPDMGBC[])NKNPPLKDKBE.Clone();
	}
}
