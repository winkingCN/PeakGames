using System;
using System.Collections;
using System.IO;
using System.Text;

public class AEGKNBMCPHA
{
	private const string FGKHCNFGOOH = "-----BEGIN ";

	private const string BPCBFONHMEH = "-----END ";

	private readonly TextReader JIGJDAHIIBA;

	public TextReader KAFOOKMONJL
	{
		get
		{
			return JIGJDAHIIBA;
		}
	}

	public AEGKNBMCPHA(TextReader JIGJDAHIIBA)
	{
		if (JIGJDAHIIBA == null)
		{
			throw new ArgumentNullException("reader");
		}
		this.JIGJDAHIIBA = JIGJDAHIIBA;
	}

	public KBDIPFFPFME LIMPKFOBIED()
	{
		string text = JIGJDAHIIBA.ReadLine();
		if (text != null && LHFGHNFJIKM.GNEPOHDBAEJ(text, "-----BEGIN "))
		{
			text = text.Substring("-----BEGIN ".Length);
			int num = text.IndexOf('-');
			string nBFBPNNEKMN = text.Substring(0, num);
			if (num > 0)
			{
				return LDONNMIEPKL(nBFBPNNEKMN);
			}
		}
		return null;
	}

	private KBDIPFFPFME LDONNMIEPKL(string NBFBPNNEKMN)
	{
		string text = "-----END " + NBFBPNNEKMN;
		IList list = LHFGHNFJIKM.PPPFFFBMGML();
		StringBuilder stringBuilder = new StringBuilder();
		string text2;
		while ((text2 = JIGJDAHIIBA.ReadLine()) != null && LHFGHNFJIKM.NFLFPHCMIOK(text2, text) == -1)
		{
			int num = text2.IndexOf(':');
			if (num == -1)
			{
				stringBuilder.Append(text2.Trim());
				continue;
			}
			string text3 = text2.Substring(0, num).Trim();
			if (LHFGHNFJIKM.GNEPOHDBAEJ(text3, "X-"))
			{
				text3 = text3.Substring(2);
			}
			string hIMINGHNIKN = text2.Substring(num + 1).Trim();
			list.Add(new APGKAIHJJLB(text3, hIMINGHNIKN));
		}
		if (text2 == null)
		{
			throw new IOException(text + " not found");
		}
		if (stringBuilder.Length % 4 != 0)
		{
			throw new IOException("base64 data appears to be truncated");
		}
		return new KBDIPFFPFME(NBFBPNNEKMN, list, LIGLKPHJDKH.ILOALOLANOL(stringBuilder.ToString()));
	}
}
