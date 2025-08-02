using System;
using I2.Loc;
using TMPro;
using UnityEngine;

public class LHLPHMJDAPM : global::BCFJOAHKHMI<TextMeshPro>
{
	public KNOECCJHIDP IEBKDDMCMHE = KNOECCJHIDP.Right;

	public KNOECCJHIDP MHFOJDIAONJ = KNOECCJHIDP.Left;

	public bool BLDHJCEJMJO;

	public bool ADFEFNHGHMJ = true;

	static LHLPHMJDAPM()
	{
		KFONLJMIOIB();
	}

	[KGHIPLIMGAG]
	private static void KFONLJMIOIB()
	{
		PNAJOCHGJFO.JNCGFCADPNN(new LHLPHMJDAPM());
	}

	public override string CILJKDELPFP()
	{
		return "TextMeshPro Label";
	}

	public override LPNCMDLKPHE MHNAGNJBHNI(Localize HNKFIOBAHOB)
	{
		return LPNCMDLKPHE.Text;
	}

	public override LPNCMDLKPHE KPFEGOEPPND(Localize HNKFIOBAHOB)
	{
		return LPNCMDLKPHE.Font;
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
		TextMeshPro textMeshPro = LDGBMPEMHEI(HNKFIOBAHOB);
		FDNJMNMHGEG = textMeshPro.FCJBBPHFNPJ;
		ENOPBIOGPCL = ((!(textMeshPro.ELKNHALJKNI != null)) ? string.Empty : textMeshPro.ELKNHALJKNI.name);
	}

	public override void FPJOJNKLJHL(Localize HNKFIOBAHOB, string JJMAEFKBEIL, string NAIBKJDAOHL)
	{
		TextMeshPro textMeshPro = LDGBMPEMHEI(HNKFIOBAHOB);
		TMP_FontAsset tMP_FontAsset = HNKFIOBAHOB.FDCNEPAOCIA<TMP_FontAsset>(ref JJMAEFKBEIL, ref NAIBKJDAOHL);
		if (tMP_FontAsset != null)
		{
			if (textMeshPro.ELKNHALJKNI != tMP_FontAsset)
			{
				textMeshPro.ELKNHALJKNI = tMP_FontAsset;
			}
		}
		else
		{
			Material material = HNKFIOBAHOB.FDCNEPAOCIA<Material>(ref JJMAEFKBEIL, ref NAIBKJDAOHL);
			if (material != null && textMeshPro.ODDEOOFJENH != material)
			{
				if (!material.name.StartsWith(textMeshPro.ELKNHALJKNI.name, StringComparison.Ordinal))
				{
					tMP_FontAsset = ONCBNHILBOB(HNKFIOBAHOB, (!NAIBKJDAOHL.EndsWith(material.name, StringComparison.Ordinal)) ? material.name : NAIBKJDAOHL);
					if (tMP_FontAsset != null)
					{
						textMeshPro.ELKNHALJKNI = tMP_FontAsset;
					}
				}
				textMeshPro.AENJCFJNHDP = material;
			}
		}
		if (ADFEFNHGHMJ)
		{
			ADFEFNHGHMJ = false;
			BLDHJCEJMJO = PNAJOCHGJFO.MNHBNGFDIPC;
			COMGGFPEKJJ(BLDHJCEJMJO, textMeshPro.JOPPDFNGJBM, out MHFOJDIAONJ, out IEBKDDMCMHE);
		}
		else
		{
			KNOECCJHIDP NDCOKDJFNDJ;
			KNOECCJHIDP KPOBNLIOGGH;
			COMGGFPEKJJ(BLDHJCEJMJO, textMeshPro.JOPPDFNGJBM, out NDCOKDJFNDJ, out KPOBNLIOGGH);
			if ((BLDHJCEJMJO && IEBKDDMCMHE != KPOBNLIOGGH) || (!BLDHJCEJMJO && MHFOJDIAONJ != NDCOKDJFNDJ))
			{
				MHFOJDIAONJ = NDCOKDJFNDJ;
				IEBKDDMCMHE = KPOBNLIOGGH;
			}
			BLDHJCEJMJO = PNAJOCHGJFO.MNHBNGFDIPC;
		}
		if (JJMAEFKBEIL == null || !(textMeshPro.FCJBBPHFNPJ != JJMAEFKBEIL))
		{
			return;
		}
		if (HNKFIOBAHOB.CorrectAlignmentForRTL)
		{
			textMeshPro.JOPPDFNGJBM = ((!PNAJOCHGJFO.MNHBNGFDIPC) ? MHFOJDIAONJ : IEBKDDMCMHE);
			textMeshPro.GKDPFEGNICI = PNAJOCHGJFO.MNHBNGFDIPC;
			if (PNAJOCHGJFO.MNHBNGFDIPC)
			{
				JJMAEFKBEIL = ODIHEPBMAPE.KAKEHGGBOBK(JJMAEFKBEIL);
			}
		}
		textMeshPro.FCJBBPHFNPJ = JJMAEFKBEIL;
	}

	internal static TMP_FontAsset ONCBNHILBOB(Localize HNKFIOBAHOB, string LNCOHODLLFF)
	{
		string text = " .\\/-[]()";
		int num = LNCOHODLLFF.Length - 1;
		while (num > 0)
		{
			while (num > 0 && text.IndexOf(LNCOHODLLFF[num]) >= 0)
			{
				num--;
			}
			if (num <= 0)
			{
				break;
			}
			string oCLDJACNGED = LNCOHODLLFF.Substring(0, num + 1);
			TMP_FontAsset tMP_FontAsset = HNKFIOBAHOB.NFMFKPLPLLH<TMP_FontAsset>(oCLDJACNGED);
			if (tMP_FontAsset != null)
			{
				return tMP_FontAsset;
			}
			while (num > 0 && text.IndexOf(LNCOHODLLFF[num]) < 0)
			{
				num--;
			}
		}
		return null;
	}

	internal static void COMGGFPEKJJ(bool DKOOKENNHDF, KNOECCJHIDP JOPPDFNGJBM, out KNOECCJHIDP NDCOKDJFNDJ, out KNOECCJHIDP KPOBNLIOGGH)
	{
		NDCOKDJFNDJ = (KPOBNLIOGGH = JOPPDFNGJBM);
		if (DKOOKENNHDF)
		{
			switch (JOPPDFNGJBM)
			{
			case KNOECCJHIDP.TopRight:
				NDCOKDJFNDJ = KNOECCJHIDP.TopLeft;
				break;
			case KNOECCJHIDP.Right:
				NDCOKDJFNDJ = KNOECCJHIDP.Left;
				break;
			case KNOECCJHIDP.BottomRight:
				NDCOKDJFNDJ = KNOECCJHIDP.BottomLeft;
				break;
			case KNOECCJHIDP.BaselineRight:
				NDCOKDJFNDJ = KNOECCJHIDP.BaselineLeft;
				break;
			case KNOECCJHIDP.MidlineRight:
				NDCOKDJFNDJ = KNOECCJHIDP.MidlineLeft;
				break;
			case KNOECCJHIDP.CaplineRight:
				NDCOKDJFNDJ = KNOECCJHIDP.CaplineLeft;
				break;
			case KNOECCJHIDP.TopLeft:
				NDCOKDJFNDJ = KNOECCJHIDP.TopRight;
				break;
			case KNOECCJHIDP.Left:
				NDCOKDJFNDJ = KNOECCJHIDP.Right;
				break;
			case KNOECCJHIDP.BottomLeft:
				NDCOKDJFNDJ = KNOECCJHIDP.BottomRight;
				break;
			case KNOECCJHIDP.BaselineLeft:
				NDCOKDJFNDJ = KNOECCJHIDP.BaselineRight;
				break;
			case KNOECCJHIDP.MidlineLeft:
				NDCOKDJFNDJ = KNOECCJHIDP.MidlineRight;
				break;
			case KNOECCJHIDP.CaplineLeft:
				NDCOKDJFNDJ = KNOECCJHIDP.CaplineRight;
				break;
			}
		}
		else
		{
			switch (JOPPDFNGJBM)
			{
			case KNOECCJHIDP.TopRight:
				KPOBNLIOGGH = KNOECCJHIDP.TopLeft;
				break;
			case KNOECCJHIDP.Right:
				KPOBNLIOGGH = KNOECCJHIDP.Left;
				break;
			case KNOECCJHIDP.BottomRight:
				KPOBNLIOGGH = KNOECCJHIDP.BottomLeft;
				break;
			case KNOECCJHIDP.BaselineRight:
				KPOBNLIOGGH = KNOECCJHIDP.BaselineLeft;
				break;
			case KNOECCJHIDP.MidlineRight:
				KPOBNLIOGGH = KNOECCJHIDP.MidlineLeft;
				break;
			case KNOECCJHIDP.CaplineRight:
				KPOBNLIOGGH = KNOECCJHIDP.CaplineLeft;
				break;
			case KNOECCJHIDP.TopLeft:
				KPOBNLIOGGH = KNOECCJHIDP.TopRight;
				break;
			case KNOECCJHIDP.Left:
				KPOBNLIOGGH = KNOECCJHIDP.Right;
				break;
			case KNOECCJHIDP.BottomLeft:
				KPOBNLIOGGH = KNOECCJHIDP.BottomRight;
				break;
			case KNOECCJHIDP.BaselineLeft:
				KPOBNLIOGGH = KNOECCJHIDP.BaselineRight;
				break;
			case KNOECCJHIDP.MidlineLeft:
				KPOBNLIOGGH = KNOECCJHIDP.MidlineRight;
				break;
			case KNOECCJHIDP.CaplineLeft:
				KPOBNLIOGGH = KNOECCJHIDP.CaplineRight;
				break;
			}
		}
	}
}
