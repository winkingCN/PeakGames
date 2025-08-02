using System;
using System.IO;

public class FDKPILMKDDG
{
	private const int BOMHKIGADAI = 64;

	private readonly TextWriter GHLABECMBPB;

	private readonly int KJOBNFGCBCA;

	private char[] GHPCHPOHELF = new char[64];

	public TextWriter KMCEPAFJOJI
	{
		get
		{
			return GHLABECMBPB;
		}
	}

	public FDKPILMKDDG(TextWriter GHLABECMBPB)
	{
		if (GHLABECMBPB == null)
		{
			throw new ArgumentNullException("writer");
		}
		this.GHLABECMBPB = GHLABECMBPB;
		KJOBNFGCBCA = LHFGHNFJIKM.IAHDCIONPPF.Length;
	}

	public int ACLDAECDPFN(KBDIPFFPFME NEMEKIOEOLC)
	{
		int num = 2 * (NEMEKIOEOLC.ENBPGGCIADN.Length + 10 + KJOBNFGCBCA) + 6 + 4;
		if (NEMEKIOEOLC.NCIBPAPPIGO.Count > 0)
		{
			foreach (APGKAIHJJLB item in NEMEKIOEOLC.NCIBPAPPIGO)
			{
				num += item.PNGPLGHKFDI.Length + ": ".Length + item.JBGOANMLBFA.Length + KJOBNFGCBCA;
			}
			num += KJOBNFGCBCA;
		}
		int num2 = (NEMEKIOEOLC.IFLICJGCCNM.Length + 2) / 3 * 4;
		return num + (num2 + (num2 + 64 - 1) / 64 * KJOBNFGCBCA);
	}

	public void ELPOLPFGCHA(LOIDFKPLHAJ AADJDFMENDN)
	{
		KBDIPFFPFME kBDIPFFPFME = AADJDFMENDN.POPAMDKJBPE();
		OABHPPFNLFK(kBDIPFFPFME.ENBPGGCIADN);
		if (kBDIPFFPFME.NCIBPAPPIGO.Count > 0)
		{
			foreach (APGKAIHJJLB item in kBDIPFFPFME.NCIBPAPPIGO)
			{
				GHLABECMBPB.Write(item.PNGPLGHKFDI);
				GHLABECMBPB.Write(": ");
				GHLABECMBPB.WriteLine(item.JBGOANMLBFA);
			}
			GHLABECMBPB.WriteLine();
		}
		AGNEJPEMPAP(kBDIPFFPFME.IFLICJGCCNM);
		EBLBKDPGMBO(kBDIPFFPFME.ENBPGGCIADN);
	}

	private void AGNEJPEMPAP(byte[] DIPNEDDIHBK)
	{
		DIPNEDDIHBK = LIGLKPHJDKH.LMDBBPLCJDM(DIPNEDDIHBK);
		for (int i = 0; i < DIPNEDDIHBK.Length; i += GHPCHPOHELF.Length)
		{
			int j;
			for (j = 0; j != GHPCHPOHELF.Length && i + j < DIPNEDDIHBK.Length; j++)
			{
				GHPCHPOHELF[j] = (char)DIPNEDDIHBK[i + j];
			}
			GHLABECMBPB.WriteLine(GHPCHPOHELF, 0, j);
		}
	}

	private void OABHPPFNLFK(string NBFBPNNEKMN)
	{
		GHLABECMBPB.WriteLine("-----BEGIN " + NBFBPNNEKMN + "-----");
	}

	private void EBLBKDPGMBO(string NBFBPNNEKMN)
	{
		GHLABECMBPB.WriteLine("-----END " + NBFBPNNEKMN + "-----");
	}
}
