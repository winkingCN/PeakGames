using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class GFNFFCGAGEH : IEnumerable<FCPKAKFLFEG>, IEnumerable
{
	private readonly List<LLLHGJNHPML> ACGJBEONLMF = new List<LLLHGJNHPML>();

	private List<FCPKAKFLFEG> LAIMNJJAFLO = new List<FCPKAKFLFEG>();

	private LLFEBPNBNPD CDPJHLAKMOK;

	public GFNFFCGAGEH(TextReader JIGJDAHIIBA, string FBDOPOCKCJD, LLFEBPNBNPD CDPJHLAKMOK)
	{
		JIKNLJNFPFG(JIGJDAHIIBA, FBDOPOCKCJD, CDPJHLAKMOK);
	}

	public GFNFFCGAGEH(List<LLLHGJNHPML> ACGJBEONLMF, List<FCPKAKFLFEG> LAIMNJJAFLO)
	{
		this.ACGJBEONLMF = ACGJBEONLMF;
		this.LAIMNJJAFLO = LAIMNJJAFLO;
		CDPJHLAKMOK = null;
	}

	public IEnumerator<FCPKAKFLFEG> GetEnumerator()
	{
		return LAIMNJJAFLO.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return LAIMNJJAFLO.GetEnumerator();
	}

	private void JIKNLJNFPFG(TextReader JIGJDAHIIBA, string FEEFFPCEGGK, LLFEBPNBNPD CDPJHLAKMOK)
	{
		if (CDPJHLAKMOK == null)
		{
			throw new ArgumentNullException("textureLoader", "textureLoader cannot be null.");
		}
		this.CDPJHLAKMOK = CDPJHLAKMOK;
		string[] array = new string[4];
		LLLHGJNHPML lLLHGJNHPML = null;
		while (true)
		{
			string text = JIGJDAHIIBA.ReadLine();
			if (text == null)
			{
				break;
			}
			if (text.Trim().Length == 0)
			{
				lLLHGJNHPML = null;
				continue;
			}
			if (lLLHGJNHPML == null)
			{
				lLLHGJNHPML = new LLLHGJNHPML();
				lLLHGJNHPML.IOCMOCCFALN = text;
				if (NFFMGKDAIGI(JIGJDAHIIBA, array) == 2)
				{
					lLLHGJNHPML.HHHMOGOKFHF = int.Parse(array[0]);
					lLLHGJNHPML.JKNPBEOPMPK = int.Parse(array[1]);
					NFFMGKDAIGI(JIGJDAHIIBA, array);
				}
				lLLHGJNHPML.MIIBBFPMFLH = (FPKBHJDENLL)Enum.Parse(typeof(FPKBHJDENLL), array[0], false);
				NFFMGKDAIGI(JIGJDAHIIBA, array);
				lLLHGJNHPML.KOAHCFNOCII = (OJNJAENHLDC)Enum.Parse(typeof(OJNJAENHLDC), array[0], false);
				lLLHGJNHPML.GNNCGBHEEHM = (OJNJAENHLDC)Enum.Parse(typeof(OJNJAENHLDC), array[1], false);
				string text2 = PGMJGDOBNGL(JIGJDAHIIBA);
				lLLHGJNHPML.AEJMNBDDDLL = DHEAGKNEONI.ClampToEdge;
				lLLHGJNHPML.APGBHBKMKKN = DHEAGKNEONI.ClampToEdge;
				switch (text2)
				{
				case "x":
					lLLHGJNHPML.AEJMNBDDDLL = DHEAGKNEONI.Repeat;
					break;
				case "y":
					lLLHGJNHPML.APGBHBKMKKN = DHEAGKNEONI.Repeat;
					break;
				case "xy":
					lLLHGJNHPML.AEJMNBDDDLL = (lLLHGJNHPML.APGBHBKMKKN = DHEAGKNEONI.Repeat);
					break;
				}
				CDPJHLAKMOK.JIKNLJNFPFG(lLLHGJNHPML, Path.Combine(FEEFFPCEGGK, text));
				ACGJBEONLMF.Add(lLLHGJNHPML);
				continue;
			}
			FCPKAKFLFEG fCPKAKFLFEG = new FCPKAKFLFEG();
			fCPKAKFLFEG.IOCMOCCFALN = text;
			fCPKAKFLFEG.CPIKPMLODAK = lLLHGJNHPML;
			fCPKAKFLFEG.BBMMCOJNJHE = bool.Parse(PGMJGDOBNGL(JIGJDAHIIBA));
			NFFMGKDAIGI(JIGJDAHIIBA, array);
			int num = int.Parse(array[0]);
			int num2 = int.Parse(array[1]);
			NFFMGKDAIGI(JIGJDAHIIBA, array);
			int num3 = int.Parse(array[0]);
			int num4 = int.Parse(array[1]);
			fCPKAKFLFEG.OJOAGEHFPNP = (float)num / (float)lLLHGJNHPML.HHHMOGOKFHF;
			fCPKAKFLFEG.AAIEJDNAODP = (float)num2 / (float)lLLHGJNHPML.JKNPBEOPMPK;
			if (fCPKAKFLFEG.BBMMCOJNJHE)
			{
				fCPKAKFLFEG.ECKFKMJFOCI = (float)(num + num4) / (float)lLLHGJNHPML.HHHMOGOKFHF;
				fCPKAKFLFEG.OFFFLJCPAJE = (float)(num2 + num3) / (float)lLLHGJNHPML.JKNPBEOPMPK;
			}
			else
			{
				fCPKAKFLFEG.ECKFKMJFOCI = (float)(num + num3) / (float)lLLHGJNHPML.HHHMOGOKFHF;
				fCPKAKFLFEG.OFFFLJCPAJE = (float)(num2 + num4) / (float)lLLHGJNHPML.JKNPBEOPMPK;
			}
			fCPKAKFLFEG.AMFCENFNAJJ = num;
			fCPKAKFLFEG.CNLILOEEBOJ = num2;
			fCPKAKFLFEG.HHHMOGOKFHF = Math.Abs(num3);
			fCPKAKFLFEG.JKNPBEOPMPK = Math.Abs(num4);
			if (NFFMGKDAIGI(JIGJDAHIIBA, array) == 4)
			{
				fCPKAKFLFEG.BLLAOIDNMPJ = new int[4]
				{
					int.Parse(array[0]),
					int.Parse(array[1]),
					int.Parse(array[2]),
					int.Parse(array[3])
				};
				if (NFFMGKDAIGI(JIGJDAHIIBA, array) == 4)
				{
					fCPKAKFLFEG.BMMMLGDNCFB = new int[4]
					{
						int.Parse(array[0]),
						int.Parse(array[1]),
						int.Parse(array[2]),
						int.Parse(array[3])
					};
					NFFMGKDAIGI(JIGJDAHIIBA, array);
				}
			}
			fCPKAKFLFEG.OMHIBPLGBME = int.Parse(array[0]);
			fCPKAKFLFEG.JMEGIPJIGMK = int.Parse(array[1]);
			NFFMGKDAIGI(JIGJDAHIIBA, array);
			fCPKAKFLFEG.MLKPDGNHNAE = int.Parse(array[0]);
			fCPKAKFLFEG.INDIJOFPNGA = int.Parse(array[1]);
			fCPKAKFLFEG.EHJNMODJEAN = int.Parse(PGMJGDOBNGL(JIGJDAHIIBA));
			LAIMNJJAFLO.Add(fCPKAKFLFEG);
		}
	}

	private static string PGMJGDOBNGL(TextReader JIGJDAHIIBA)
	{
		string text = JIGJDAHIIBA.ReadLine();
		int num = text.IndexOf(':');
		if (num == -1)
		{
			throw new Exception("Invalid line: " + text);
		}
		return text.Substring(num + 1).Trim();
	}

	private static int NFFMGKDAIGI(TextReader JIGJDAHIIBA, string[] HJCMONHFFPG)
	{
		string text = JIGJDAHIIBA.ReadLine();
		int num = text.IndexOf(':');
		if (num == -1)
		{
			throw new Exception("Invalid line: " + text);
		}
		int i = 0;
		int num2 = num + 1;
		for (; i < 3; i++)
		{
			int num3 = text.IndexOf(',', num2);
			if (num3 == -1)
			{
				break;
			}
			HJCMONHFFPG[i] = text.Substring(num2, num3 - num2).Trim();
			num2 = num3 + 1;
		}
		HJCMONHFFPG[i] = text.Substring(num2).Trim();
		return i + 1;
	}

	public void OACJKGINKAK()
	{
		int i = 0;
		for (int count = LAIMNJJAFLO.Count; i < count; i++)
		{
			FCPKAKFLFEG fCPKAKFLFEG = LAIMNJJAFLO[i];
			fCPKAKFLFEG.AAIEJDNAODP = 1f - fCPKAKFLFEG.AAIEJDNAODP;
			fCPKAKFLFEG.OFFFLJCPAJE = 1f - fCPKAKFLFEG.OFFFLJCPAJE;
		}
	}

	public FCPKAKFLFEG GIGKGEPPBCG(string IOCMOCCFALN)
	{
		int i = 0;
		for (int count = LAIMNJJAFLO.Count; i < count; i++)
		{
			if (LAIMNJJAFLO[i].IOCMOCCFALN == IOCMOCCFALN)
			{
				return LAIMNJJAFLO[i];
			}
		}
		return null;
	}

	public void PCHCAFHEJJM()
	{
		if (CDPJHLAKMOK != null)
		{
			int i = 0;
			for (int count = ACGJBEONLMF.Count; i < count; i++)
			{
				CDPJHLAKMOK.ILKDHGENJLB(ACGJBEONLMF[i].FDCGLBIAFPB);
			}
		}
	}
}
