using System;
using I2.Loc;
using TMPro;
using UnityEngine;

public class FCCENAAJLMN : global::BCFJOAHKHMI<TextMeshProUGUI>
{
	public KNOECCJHIDP IEBKDDMCMHE = KNOECCJHIDP.Right;

	public KNOECCJHIDP MHFOJDIAONJ = KNOECCJHIDP.Left;

	public bool BLDHJCEJMJO;

	public bool ADFEFNHGHMJ = true;

	static FCCENAAJLMN()
	{
		KFONLJMIOIB();
	}

	[KGHIPLIMGAG]
	private static void KFONLJMIOIB()
	{
		PNAJOCHGJFO.JNCGFCADPNN(new FCCENAAJLMN());
	}

	public override string CILJKDELPFP()
	{
		return "TextMeshPro UGUI";
	}

	public override LPNCMDLKPHE MHNAGNJBHNI(Localize HNKFIOBAHOB)
	{
		return LPNCMDLKPHE.Text;
	}

	public override LPNCMDLKPHE KPFEGOEPPND(Localize HNKFIOBAHOB)
	{
		return LPNCMDLKPHE.TextMeshPFont;
	}

	public override bool BPGIAEEGAHG()
	{
		return true;
	}

	public override bool EPEEEAJJCEM()
	{
		return true;
	}

	public override bool ILELPLPENPA()
	{
		return false;
	}

	public override void HKKDHLOJLGN(Localize HNKFIOBAHOB, string AMMAIADJFIM, string HDNBPGDPDAJ, out string FDNJMNMHGEG, out string ENOPBIOGPCL)
	{
		TextMeshProUGUI textMeshProUGUI = LDGBMPEMHEI(HNKFIOBAHOB);
		FDNJMNMHGEG = textMeshProUGUI.FCJBBPHFNPJ;
		ENOPBIOGPCL = ((!(textMeshProUGUI.ELKNHALJKNI != null)) ? string.Empty : textMeshProUGUI.ELKNHALJKNI.name);
	}

	public override void FPJOJNKLJHL(Localize HNKFIOBAHOB, string JJMAEFKBEIL, string NAIBKJDAOHL)
	{
		TextMeshProUGUI textMeshProUGUI = LDGBMPEMHEI(HNKFIOBAHOB);
		TMP_FontAsset tMP_FontAsset = HNKFIOBAHOB.FDCNEPAOCIA<TMP_FontAsset>(ref JJMAEFKBEIL, ref NAIBKJDAOHL);
		if (tMP_FontAsset != null)
		{
			if (textMeshProUGUI.ELKNHALJKNI != tMP_FontAsset)
			{
				textMeshProUGUI.ELKNHALJKNI = tMP_FontAsset;
			}
		}
		else
		{
			Material material = HNKFIOBAHOB.FDCNEPAOCIA<Material>(ref JJMAEFKBEIL, ref NAIBKJDAOHL);
			if (material != null && textMeshProUGUI.ODDEOOFJENH != material)
			{
				if (!material.name.StartsWith(textMeshProUGUI.ELKNHALJKNI.name, StringComparison.Ordinal))
				{
					tMP_FontAsset = LHLPHMJDAPM.ONCBNHILBOB(HNKFIOBAHOB, (!NAIBKJDAOHL.EndsWith(material.name, StringComparison.Ordinal)) ? material.name : NAIBKJDAOHL);
					if (tMP_FontAsset != null)
					{
						textMeshProUGUI.ELKNHALJKNI = tMP_FontAsset;
					}
				}
				textMeshProUGUI.AENJCFJNHDP = material;
			}
		}
		if (ADFEFNHGHMJ)
		{
			ADFEFNHGHMJ = false;
			BLDHJCEJMJO = PNAJOCHGJFO.MNHBNGFDIPC;
			LHLPHMJDAPM.COMGGFPEKJJ(BLDHJCEJMJO, textMeshProUGUI.JOPPDFNGJBM, out MHFOJDIAONJ, out IEBKDDMCMHE);
		}
		else
		{
			KNOECCJHIDP NDCOKDJFNDJ;
			KNOECCJHIDP KPOBNLIOGGH;
			LHLPHMJDAPM.COMGGFPEKJJ(BLDHJCEJMJO, textMeshProUGUI.JOPPDFNGJBM, out NDCOKDJFNDJ, out KPOBNLIOGGH);
			if ((BLDHJCEJMJO && IEBKDDMCMHE != KPOBNLIOGGH) || (!BLDHJCEJMJO && MHFOJDIAONJ != NDCOKDJFNDJ))
			{
				MHFOJDIAONJ = NDCOKDJFNDJ;
				IEBKDDMCMHE = KPOBNLIOGGH;
			}
			BLDHJCEJMJO = PNAJOCHGJFO.MNHBNGFDIPC;
		}
		if (JJMAEFKBEIL == null || !(textMeshProUGUI.FCJBBPHFNPJ != JJMAEFKBEIL))
		{
			return;
		}
		if (HNKFIOBAHOB.CorrectAlignmentForRTL)
		{
			textMeshProUGUI.JOPPDFNGJBM = ((!PNAJOCHGJFO.MNHBNGFDIPC) ? MHFOJDIAONJ : IEBKDDMCMHE);
			textMeshProUGUI.GKDPFEGNICI = PNAJOCHGJFO.MNHBNGFDIPC;
			if (PNAJOCHGJFO.MNHBNGFDIPC)
			{
				JJMAEFKBEIL = ODIHEPBMAPE.KAKEHGGBOBK(JJMAEFKBEIL);
			}
		}
		textMeshProUGUI.FCJBBPHFNPJ = JJMAEFKBEIL;
	}
}
