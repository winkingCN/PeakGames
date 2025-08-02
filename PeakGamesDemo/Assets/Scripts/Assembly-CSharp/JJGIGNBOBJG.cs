using System.IO;
using System.Text;

internal class JJGIGNBOBJG
{
	private readonly string HPNENMOPOED;

	private readonly string PLCMJHIGMBG;

	private readonly string LPIDKABIABM;

	private readonly string FMCEFNIMMOJ;

	internal JJGIGNBOBJG(string NBFBPNNEKMN)
	{
		HPNENMOPOED = "-----BEGIN " + NBFBPNNEKMN + "-----";
		PLCMJHIGMBG = "-----BEGIN X509 " + NBFBPNNEKMN + "-----";
		LPIDKABIABM = "-----END " + NBFBPNNEKMN + "-----";
		FMCEFNIMMOJ = "-----END X509 " + NBFBPNNEKMN + "-----";
	}

	private string AHCILHLFIJG(Stream EPKPLBOMHJL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num;
		while (true)
		{
			if ((num = EPKPLBOMHJL.ReadByte()) != 13 && num != 10 && num >= 0)
			{
				if (num != 13)
				{
					stringBuilder.Append((char)num);
				}
			}
			else if (num < 0 || stringBuilder.Length != 0)
			{
				break;
			}
		}
		if (num < 0)
		{
			return null;
		}
		return stringBuilder.ToString();
	}

	internal ALLINHNNNJN LIMPKFOBIED(Stream EPKPLBOMHJL)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string jKHLMLIANAI;
		while ((jKHLMLIANAI = AHCILHLFIJG(EPKPLBOMHJL)) != null && !LHFGHNFJIKM.GNEPOHDBAEJ(jKHLMLIANAI, HPNENMOPOED) && !LHFGHNFJIKM.GNEPOHDBAEJ(jKHLMLIANAI, PLCMJHIGMBG))
		{
		}
		while ((jKHLMLIANAI = AHCILHLFIJG(EPKPLBOMHJL)) != null && !LHFGHNFJIKM.GNEPOHDBAEJ(jKHLMLIANAI, LPIDKABIABM) && !LHFGHNFJIKM.GNEPOHDBAEJ(jKHLMLIANAI, FMCEFNIMMOJ))
		{
			stringBuilder.Append(jKHLMLIANAI);
		}
		if (stringBuilder.Length != 0)
		{
			EDOEBJJFOBM eDOEBJJFOBM = EDOEBJJFOBM.HPDCKMOPEMM(LIGLKPHJDKH.ILOALOLANOL(stringBuilder.ToString()));
			if (!(eDOEBJJFOBM is ALLINHNNNJN))
			{
				throw new IOException("malformed PEM data encountered");
			}
			return (ALLINHNNNJN)eDOEBJJFOBM;
		}
		return null;
	}
}
