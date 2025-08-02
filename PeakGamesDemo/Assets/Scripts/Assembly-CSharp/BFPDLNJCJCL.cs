using System.Collections;
using System.IO;

public class BFPDLNJCJCL
{
	protected readonly IList DJAFGNAHJAM;

	protected readonly HLAHBGANIKK IJKFPKMBCBP;

	public virtual IList NFPHOECIJHH
	{
		get
		{
			return DJAFGNAHJAM;
		}
	}

	public virtual HLAHBGANIKK FLNGACDKHDK
	{
		get
		{
			return IJKFPKMBCBP;
		}
	}

	public BFPDLNJCJCL(IList IELJAIGNIAK, HLAHBGANIKK BMOGGMEIMED)
	{
		DJAFGNAHJAM = IELJAIGNIAK;
		IJKFPKMBCBP = BMOGGMEIMED;
	}

	public virtual void LMDBBPLCJDM(Stream BILGCJNPJGJ)
	{
		if (DJAFGNAHJAM == null || DJAFGNAHJAM.Count < 1)
		{
			KINEBFNENMB.PGBAOHFKNHN(0, BILGCJNPJGJ);
		}
		else
		{
			MemoryStream memoryStream = new MemoryStream();
			for (int i = 0; i < DJAFGNAHJAM.Count; i++)
			{
				KHBPKJOOLPJ kHBPKJOOLPJ = (KHBPKJOOLPJ)DJAFGNAHJAM[i];
				byte[] gHPCHPOHELF = kHBPKJOOLPJ.PPCPBIEGJKM("DER");
				KINEBFNENMB.HIPJBHBLGEI(gHPCHPOHELF, memoryStream);
			}
			KINEBFNENMB.AKGIEBIEJJL(memoryStream.Length);
			KINEBFNENMB.PGBAOHFKNHN((int)memoryStream.Length, BILGCJNPJGJ);
			memoryStream.WriteTo(BILGCJNPJGJ);
		}
		if (IJKFPKMBCBP == null)
		{
			KINEBFNENMB.PGBAOHFKNHN(0, BILGCJNPJGJ);
			return;
		}
		byte[] array = IJKFPKMBCBP.PPCPBIEGJKM("DER");
		KINEBFNENMB.AKGIEBIEJJL(array.Length);
		KINEBFNENMB.PGBAOHFKNHN(array.Length, BILGCJNPJGJ);
		BILGCJNPJGJ.Write(array, 0, array.Length);
	}

	public static BFPDLNJCJCL DHCLOMIANOE(Stream MOPCLEEGDFB)
	{
		IList list = LHFGHNFJIKM.PPPFFFBMGML();
		int num = KINEBFNENMB.DMHJEBHACNN(MOPCLEEGDFB);
		if (num > 0)
		{
			byte[] buffer = KINEBFNENMB.PCNDKGFHPJN(num, MOPCLEEGDFB);
			MemoryStream memoryStream = new MemoryStream(buffer, false);
			do
			{
				byte[] nJPMJNHGDNE = KINEBFNENMB.HDGCNMILKAA(memoryStream);
				KHBPKJOOLPJ value = KHBPKJOOLPJ.BJLJCGFMFOO(KINEBFNENMB.LCEOAGADAFB(nJPMJNHGDNE));
				list.Add(value);
			}
			while (memoryStream.Position < memoryStream.Length);
		}
		HLAHBGANIKK bMOGGMEIMED = null;
		int num2 = KINEBFNENMB.DMHJEBHACNN(MOPCLEEGDFB);
		if (num2 > 0)
		{
			byte[] nJPMJNHGDNE2 = KINEBFNENMB.PCNDKGFHPJN(num2, MOPCLEEGDFB);
			bMOGGMEIMED = HLAHBGANIKK.BJLJCGFMFOO(KINEBFNENMB.LCEOAGADAFB(nJPMJNHGDNE2));
		}
		return new BFPDLNJCJCL(list, bMOGGMEIMED);
	}
}
