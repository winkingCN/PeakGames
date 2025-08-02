using System;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.UI;

public class IIGHOCGOAID
{
	private static IIGHOCGOAID KNPOFJNFLJB;

	private static readonly short PGMCBKCAEME = 16384;

	private CFOIPDKEFMM OELBDGFEGOI;

	private LevelBuilder IDJEJKNPHFH;

	private byte[] BFCGNEEAMHM;

	private int BFNJHIPCMHM;

	private EFKAKDCJCCK CEHNCGHHOPA = new EFKAKDCJCCK();

	private List<byte[]> HJFLNAGDLKB;

	public static IIGHOCGOAID GABGKBAKHDP
	{
		get
		{
			if (KNPOFJNFLJB == null)
			{
				KNPOFJNFLJB = new IIGHOCGOAID();
			}
			return KNPOFJNFLJB;
		}
	}

	public List<byte[]> JNOMGIGLKFO { get; private set; }

	public void HLNNJCCFIJI(KFCEILFGADG GIOFHACJEGA)
	{
		OELBDGFEGOI = GIOFHACJEGA.JHDMFHDHIFN;
		IDJEJKNPHFH = GIOFHACJEGA.GIMBEKBFKMJ;
		BFCGNEEAMHM = new byte[1000];
		JNOMGIGLKFO = new List<byte[]>();
		IMHBNCKPHIF();
		JNOMGIGLKFO.Clear();
	}

	private void GPMFBNIEEKK()
	{
		BFNJHIPCMHM = 0;
		BFCGNEEAMHM[BFNJHIPCMHM++] = (byte)OELBDGFEGOI.ELFBOKDHKGG.EBMFPDNPIEM;
		List<OGIFMLFEAEM> jKKJLDLMIOG = IDJEJKNPHFH.CurrentLevel.JKKJLDLMIOG;
		for (int i = 0; i < jKKJLDLMIOG.Count; i++)
		{
			LIKKMKAIENF((short)jKKJLDLMIOG[i].GMCGMPEEHJP);
		}
		CEHNCGHHOPA.BOPEPLONIFL();
		foreach (Cell item in OELBDGFEGOI.IOFOFDLJDAA())
		{
			short num = 0;
			if (item.EAILOFHFNJO)
			{
				item.LBFCDKPCDPB.GetItemSnapshotData(CEHNCGHHOPA);
				num = CEHNCGHHOPA.EEFMIHDPJPG;
			}
			if (item.HasBubble)
			{
				num |= PGMCBKCAEME;
			}
			LIKKMKAIENF(num);
			for (int j = 0; j < CEHNCGHHOPA.IGCNDEKPCMJ; j++)
			{
				BFCGNEEAMHM[BFNJHIPCMHM++] = CEHNCGHHOPA.AJNABJBFBJL[j];
			}
			CEHNCGHHOPA.BOPEPLONIFL();
			if (item.HasCellItem())
			{
				item.FEMFMBLMKHP.GetItemSnapshotData(CEHNCGHHOPA);
				LIKKMKAIENF(CEHNCGHHOPA.EEFMIHDPJPG);
				for (int k = 0; k < CEHNCGHHOPA.IGCNDEKPCMJ; k++)
				{
					BFCGNEEAMHM[BFNJHIPCMHM++] = CEHNCGHHOPA.AJNABJBFBJL[k];
				}
				CEHNCGHHOPA.BOPEPLONIFL();
			}
		}
	}

	private void LIKKMKAIENF(short EDDNOJDPMCF)
	{
		byte[] bytes = BitConverter.GetBytes(EDDNOJDPMCF);
		BFCGNEEAMHM[BFNJHIPCMHM++] = bytes[BitConverter.IsLittleEndian ? 1 : 0];
		BFCGNEEAMHM[BFNJHIPCMHM++] = bytes[(!BitConverter.IsLittleEndian) ? 1u : 0u];
	}

	public void IMHBNCKPHIF()
	{
		try
		{
			GPMFBNIEEKK();
			byte[] array = new byte[BFNJHIPCMHM];
			Array.Copy(BFCGNEEAMHM, array, BFNJHIPCMHM);
			JNOMGIGLKFO.Add(array);
		}
		catch (Exception ex)
		{
			string text = string.Format("{0} - At Level: {1}", ex.Message, LevelBuilder.ActiveLevel.PDGLECFDLJJ);
			NHNBFBDHKGN.JFPLDMEBIJH("Snapshot Record", text, ex.StackTrace);
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Replay, "Snapshot Record Exception. Reason: {0} Stack: {1}", text, ex.StackTrace);
		}
	}

	public void KNHLPBAIDLO(List<byte[]> ACHCIOHJJNP)
	{
		HJFLNAGDLKB = ACHCIOHJJNP;
	}

	private byte[] OOOCIDCKEJL(int CCHAAJBNJHL)
	{
		return NPFEFGADBGN(CCHAAJBNJHL) ? HJFLNAGDLKB[CCHAAJBNJHL] : null;
	}

	public bool NPFEFGADBGN(int CCHAAJBNJHL)
	{
		return CCHAAJBNJHL < HJFLNAGDLKB.Count && CCHAAJBNJHL >= 0;
	}

	public bool IJIHJNDEEBK(int CCHAAJBNJHL)
	{
		GPMFBNIEEKK();
		byte[] array = OOOCIDCKEJL(CCHAAJBNJHL);
		if (array.Length != BFNJHIPCMHM)
		{
			return false;
		}
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != BFCGNEEAMHM[i])
			{
				return false;
			}
		}
		return true;
	}

	public void GIFOFCNGKAI(int CCHAAJBNJHL)
	{
		IDJEJKNPHFH.ClearGridForSnapshot();
		MDMICLOPLPC dJDKLOJBJCO = new MDMICLOPLPC(OOOCIDCKEJL(CCHAAJBNJHL));
		GGPFBNBNEHD(dJDKLOJBJCO);
		MGAIAJNNEBP(dJDKLOJBJCO);
		DAPAPKGMDPC(dJDKLOJBJCO);
		IDJEJKNPHFH.ProcessGridForSnapshot();
		KMPJLPGKNDD();
	}

	private void GGPFBNBNEHD(MDMICLOPLPC DJDKLOJBJCO)
	{
		OELBDGFEGOI.ELFBOKDHKGG.CBHLJLCDHJK(DJDKLOJBJCO.GNNOGGGHPLA());
	}

	private void KMPJLPGKNDD()
	{
		List<OGIFMLFEAEM> jKKJLDLMIOG = IDJEJKNPHFH.CurrentLevel.JKKJLDLMIOG;
		int[] nJHCINMDGKB = IDJEJKNPHFH.CurrentLevel.NJHCINMDGKB;
		for (int i = 0; i < jKKJLDLMIOG.Count; i++)
		{
			TopPanelGoalUI topPanelGoalUI = IDJEJKNPHFH.CurrentLevel.BJEPPNGPMKO.GoalUIList[i];
			topPanelGoalUI.RevertCheckMarkForSnapshot();
			bool flag = jKKJLDLMIOG[i].ENBPGGCIADN == NOALGNJECAD.Bubble && (nJHCINMDGKB[44] > 0 || nJHCINMDGKB[61] > 0);
			bool flag2 = jKKJLDLMIOG[i].ENBPGGCIADN == NOALGNJECAD.Ivy && nJHCINMDGKB[65] > 0;
			topPanelGoalUI.UpdateGoalCount(jKKJLDLMIOG[i].GMCGMPEEHJP, flag || flag2);
		}
	}

	private void DAPAPKGMDPC(MDMICLOPLPC DJDKLOJBJCO)
	{
		foreach (Cell item in OELBDGFEGOI.IOFOFDLJDAA())
		{
			short hBMKHCHGHHF = DJDKLOJBJCO.PENAHNOJCGF(true);
			hBMKHCHGHHF = GECAOCGLHIC(hBMKHCHGHHF, item);
			IDJEJKNPHFH.CreateSnapshotItem(item, hBMKHCHGHHF, DJDKLOJBJCO);
			if (DJDKLOJBJCO.NICGJDCKMNP())
			{
				break;
			}
			short num = DJDKLOJBJCO.PENAHNOJCGF(false);
			if (BJEEGFJMGAO(num))
			{
				DJDKLOJBJCO.HAPECLIMPAI(2);
				IDJEJKNPHFH.CreateSnapshotItem(item, num, DJDKLOJBJCO, true);
			}
		}
	}

	private void MGAIAJNNEBP(MDMICLOPLPC DJDKLOJBJCO)
	{
		List<OGIFMLFEAEM> jKKJLDLMIOG = IDJEJKNPHFH.CurrentLevel.JKKJLDLMIOG;
		for (int i = 0; i < jKKJLDLMIOG.Count; i++)
		{
			IDJEJKNPHFH.CurrentLevel.LMHAIBOEDKI(i, DJDKLOJBJCO.PENAHNOJCGF(true));
			if (jKKJLDLMIOG[i].ENBPGGCIADN == NOALGNJECAD.Jelly)
			{
				IDJEJKNPHFH.CurrentLevel.LMHAIBOEDKI(i, 0);
			}
		}
		OGIFMLFEAEM oGIFMLFEAEM = IDJEJKNPHFH.CurrentLevel.HEHOGLHPCGH(NOALGNJECAD.Bubble);
		if (oGIFMLFEAEM != null)
		{
			OGIFMLFEAEM oGIFMLFEAEM2 = IDJEJKNPHFH.CurrentLevel.HEHOGLHPCGH(NOALGNJECAD.Soap);
			OGIFMLFEAEM oGIFMLFEAEM3 = IDJEJKNPHFH.CurrentLevel.HEHOGLHPCGH(NOALGNJECAD.Washer);
			if (oGIFMLFEAEM2 == null && oGIFMLFEAEM3 == null)
			{
				LLJLGKECBBE.GABGKBAKHDP.KOBIBAJNFCO = oGIFMLFEAEM.BNNIJEPHLBJ - oGIFMLFEAEM.GMCGMPEEHJP;
			}
		}
	}

	private short GECAOCGLHIC(short HBMKHCHGHHF, Cell LBHDELJBONF)
	{
		if ((HBMKHCHGHHF & PGMCBKCAEME) == 0)
		{
			return HBMKHCHGHHF;
		}
		HBMKHCHGHHF = (short)(HBMKHCHGHHF & ~PGMCBKCAEME);
		LBHDELJBONF.AddBubble();
		return HBMKHCHGHHF;
	}

	private bool BJEEGFJMGAO(short DOGMNEKGKBP)
	{
		return DOGMNEKGKBP == 68 || DOGMNEKGKBP == 34;
	}
}
