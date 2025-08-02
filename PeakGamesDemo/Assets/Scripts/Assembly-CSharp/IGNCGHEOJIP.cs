using System;
using System.Collections;
using System.IO;

public class IGNCGHEOJIP
{
	protected readonly IList AOGNIBMEODE;

	public virtual IList PPEANIKDHPM
	{
		get
		{
			return AOGNIBMEODE;
		}
	}

	public IGNCGHEOJIP(IList IOMLIAKDCIM)
	{
		if (IOMLIAKDCIM == null)
		{
			throw new ArgumentNullException("serverNameList");
		}
		AOGNIBMEODE = IOMLIAKDCIM;
	}

	public virtual void LMDBBPLCJDM(Stream BILGCJNPJGJ)
	{
		MemoryStream memoryStream = new MemoryStream();
		byte[] array = KINEBFNENMB.JBCONIFELBM;
		foreach (OAJOIGPAFEJ item in PPEANIKDHPM)
		{
			array = CFJCAIKLCMP(array, item.DMKHLENPOBD);
			if (array == null)
			{
				throw new DEIDBCPPCMB(80);
			}
			item.LMDBBPLCJDM(memoryStream);
		}
		KINEBFNENMB.AKGIEBIEJJL(memoryStream.Length);
		KINEBFNENMB.PGBAOHFKNHN((int)memoryStream.Length, BILGCJNPJGJ);
		memoryStream.WriteTo(BILGCJNPJGJ);
	}

	public static IGNCGHEOJIP DHCLOMIANOE(Stream MOPCLEEGDFB)
	{
		int num = KINEBFNENMB.DMHJEBHACNN(MOPCLEEGDFB);
		if (num < 1)
		{
			throw new DEIDBCPPCMB(50);
		}
		byte[] buffer = KINEBFNENMB.PCNDKGFHPJN(num, MOPCLEEGDFB);
		MemoryStream memoryStream = new MemoryStream(buffer, false);
		byte[] array = KINEBFNENMB.JBCONIFELBM;
		IList list = LHFGHNFJIKM.PPPFFFBMGML();
		while (memoryStream.Position < memoryStream.Length)
		{
			OAJOIGPAFEJ oAJOIGPAFEJ = OAJOIGPAFEJ.DHCLOMIANOE(memoryStream);
			array = CFJCAIKLCMP(array, oAJOIGPAFEJ.DMKHLENPOBD);
			if (array == null)
			{
				throw new DEIDBCPPCMB(47);
			}
			list.Add(oAJOIGPAFEJ);
		}
		return new IGNCGHEOJIP(list);
	}

	private static byte[] CFJCAIKLCMP(byte[] FHEGCHICLJB, byte OINILONPAGJ)
	{
		if (!OLPIOKOLFLB.NAFCDEECGEF(OINILONPAGJ) || NOGCEBKPPJE.KMDACNACKII(FHEGCHICLJB, OINILONPAGJ))
		{
			return null;
		}
		return NOGCEBKPPJE.GBKNDKCPBEH(FHEGCHICLJB, OINILONPAGJ);
	}
}
