using Assets.Scripts.GamePlayScene.Mechanics;
using UnityEngine;

public class IGNOFJEBDOM
{
	private readonly CFOIPDKEFMM OELBDGFEGOI;

	public Sprite[] LHLAGCOEMCF { get; set; }

	public IGNOFJEBDOM(CFOIPDKEFMM GOAELFDHDGD, Sprite[] GNOKMPCABEL)
	{
		LHLAGCOEMCF = GNOKMPCABEL;
		OELBDGFEGOI = GOAELFDHDGD;
	}

	public void HOEJFJPHGDO()
	{
		int eMFKAPJMDCC = OELBDGFEGOI.EMFKAPJMDCC;
		int fHAMOHDEGMK = OELBDGFEGOI.FHAMOHDEGMK;
		for (int i = 0; i < eMFKAPJMDCC; i++)
		{
			for (int j = 0; j < fHAMOHDEGMK; j++)
			{
				bool exists = OELBDGFEGOI.ECNCPJGHBIG(i, j).Exists;
				bool flag = j - 1 >= 0 && OELBDGFEGOI.ECNCPJGHBIG(i, j - 1).Exists;
				bool flag2 = i - 1 >= 0 && OELBDGFEGOI.ECNCPJGHBIG(i - 1, j).Exists;
				bool kMANBNCHKDE = i - 1 >= 0 && j - 1 >= 0 && OELBDGFEGOI.ECNCPJGHBIG(i - 1, j - 1).Exists;
				Cell lBHDELJBONF = OELBDGFEGOI.ECNCPJGHBIG(i, j);
				if (exists)
				{
					JFGOGOHJNGE(lBHDELJBONF, 5, LHLAGCOEMCF[4]);
				}
				JFGOGOHJNGE(lBHDELJBONF, 2, CAALHACICHK(exists, flag));
				JFGOGOHJNGE(lBHDELJBONF, 4, GCPFIHNKGFF(flag2, exists));
				JFGOGOHJNGE(lBHDELJBONF, 1, FCNDGOPPIFF(exists, flag, flag2, kMANBNCHKDE));
				if (i == eMFKAPJMDCC - 1)
				{
					if (j == fHAMOHDEGMK - 1 && exists)
					{
						JFGOGOHJNGE(lBHDELJBONF, 9, LHLAGCOEMCF[8]);
					}
					bool flag3 = i + 1 < eMFKAPJMDCC && OELBDGFEGOI.ECNCPJGHBIG(i + 1, j).Exists;
					bool iOBAGMMGDKN = i + 1 < eMFKAPJMDCC && j - 1 >= 0 && OELBDGFEGOI.ECNCPJGHBIG(i + 1, j - 1).Exists;
					JFGOGOHJNGE(lBHDELJBONF, 6, GCPFIHNKGFF(exists, flag3));
					JFGOGOHJNGE(lBHDELJBONF, 3, FCNDGOPPIFF(flag3, iOBAGMMGDKN, exists, flag));
				}
				if (j != fHAMOHDEGMK - 1)
				{
					HBGNHFJOEGP(lBHDELJBONF);
					continue;
				}
				bool flag4 = j + 1 < fHAMOHDEGMK && OELBDGFEGOI.ECNCPJGHBIG(i, j + 1).Exists;
				bool gEPLOMIILNL = j + 1 < fHAMOHDEGMK && i - 1 >= 0 && OELBDGFEGOI.ECNCPJGHBIG(i - 1, j + 1).Exists;
				JFGOGOHJNGE(lBHDELJBONF, 8, CAALHACICHK(flag4, exists));
				JFGOGOHJNGE(lBHDELJBONF, 7, FCNDGOPPIFF(flag4, exists, gEPLOMIILNL, flag2));
				HBGNHFJOEGP(lBHDELJBONF);
			}
		}
	}

	private static void HBGNHFJOEGP(Cell LBHDELJBONF)
	{
		for (int i = 0; i < LBHDELJBONF.Borders.Length; i++)
		{
			SpriteRenderer spriteRenderer = LBHDELJBONF.Borders[i];
			if (!(spriteRenderer == null))
			{
				GameObject gameObject = spriteRenderer.gameObject;
				if (gameObject != null && !gameObject.activeSelf)
				{
					Object.Destroy(gameObject);
				}
			}
		}
	}

	private static void JFGOGOHJNGE(Cell LBHDELJBONF, int IPMLMBIHKCK, Sprite MJOJAOIHCIO)
	{
		if (!(MJOJAOIHCIO == null))
		{
			LBHDELJBONF.Borders[IPMLMBIHKCK].gameObject.SetActive(true);
			LBHDELJBONF.Borders[IPMLMBIHKCK].sprite = MJOJAOIHCIO;
		}
	}

	private Sprite CAALHACICHK(bool NGGFBBGNODJ, bool NFJIJCMIPDJ)
	{
		if (NGGFBBGNODJ && NFJIJCMIPDJ)
		{
			return LHLAGCOEMCF[4];
		}
		if (NFJIJCMIPDJ)
		{
			return LHLAGCOEMCF[7];
		}
		return (!NGGFBBGNODJ) ? null : LHLAGCOEMCF[1];
	}

	private Sprite GCPFIHNKGFF(bool BICBELADBDI, bool MPOPLONGCDK)
	{
		if (BICBELADBDI && MPOPLONGCDK)
		{
			return LHLAGCOEMCF[4];
		}
		if (BICBELADBDI)
		{
			return LHLAGCOEMCF[5];
		}
		return (!MPOPLONGCDK) ? null : LHLAGCOEMCF[3];
	}

	private Sprite FCNDGOPPIFF(bool EHOFGKHIPGL, bool IOBAGMMGDKN, bool GEPLOMIILNL, bool KMANBNCHKDE)
	{
		if (EHOFGKHIPGL && IOBAGMMGDKN && GEPLOMIILNL && KMANBNCHKDE)
		{
			return LHLAGCOEMCF[4];
		}
		if (EHOFGKHIPGL && IOBAGMMGDKN && GEPLOMIILNL)
		{
			return LHLAGCOEMCF[11];
		}
		if (EHOFGKHIPGL && IOBAGMMGDKN && KMANBNCHKDE)
		{
			return LHLAGCOEMCF[13];
		}
		if (EHOFGKHIPGL && IOBAGMMGDKN)
		{
			return LHLAGCOEMCF[3];
		}
		if (EHOFGKHIPGL && GEPLOMIILNL && KMANBNCHKDE)
		{
			return LHLAGCOEMCF[12];
		}
		if (EHOFGKHIPGL && GEPLOMIILNL)
		{
			return LHLAGCOEMCF[1];
		}
		if (EHOFGKHIPGL && KMANBNCHKDE)
		{
			return LHLAGCOEMCF[10];
		}
		if (EHOFGKHIPGL)
		{
			return LHLAGCOEMCF[0];
		}
		if (IOBAGMMGDKN && GEPLOMIILNL && KMANBNCHKDE)
		{
			return LHLAGCOEMCF[14];
		}
		if (IOBAGMMGDKN && GEPLOMIILNL)
		{
			return LHLAGCOEMCF[9];
		}
		if (IOBAGMMGDKN && KMANBNCHKDE)
		{
			return LHLAGCOEMCF[7];
		}
		if (IOBAGMMGDKN)
		{
			return LHLAGCOEMCF[6];
		}
		if (GEPLOMIILNL && KMANBNCHKDE)
		{
			return LHLAGCOEMCF[5];
		}
		if (GEPLOMIILNL)
		{
			return LHLAGCOEMCF[2];
		}
		return (!KMANBNCHKDE) ? null : LHLAGCOEMCF[8];
	}
}
