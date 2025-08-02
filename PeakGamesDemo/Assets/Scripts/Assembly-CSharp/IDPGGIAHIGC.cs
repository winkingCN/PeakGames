using TMPro;

public struct IDPGGIAHIGC
{
	public TMP_Text MHFABDJOCMG;

	public int CKFJKOFGBOL;

	public int PEFMNOMMFOA;

	public int IDBNHBEEAPI;

	public int HKBLAGGHCNK;

	public int IAJHNMEHLCA;

	internal char[] PCDJACBAHMN;

	internal void MLNFKBEPNFA(char[] FCJBBPHFNPJ, int KKMNKJJENIL, int EOFAGACBNFP)
	{
		if (PCDJACBAHMN == null || PCDJACBAHMN.Length < EOFAGACBNFP)
		{
			PCDJACBAHMN = new char[EOFAGACBNFP];
		}
		for (int i = 0; i < EOFAGACBNFP; i++)
		{
			PCDJACBAHMN[i] = FCJBBPHFNPJ[KKMNKJJENIL + i];
		}
	}

	public string DGADOGAFOII()
	{
		string text = string.Empty;
		TMP_TextInfo textInfo = MHFABDJOCMG.BIAHJAKEMLM;
		for (int i = HKBLAGGHCNK; i < HKBLAGGHCNK + IAJHNMEHLCA; i++)
		{
			text += textInfo.characterInfo[i].AONJCHFEHOM;
		}
		return text;
	}

	public string KJFPOHMDHJH()
	{
		if (MHFABDJOCMG == null)
		{
			return string.Empty;
		}
		return new string(PCDJACBAHMN, 0, IDBNHBEEAPI);
	}
}
