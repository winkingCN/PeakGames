using System.Collections;
using System.Collections.Generic;

public class IMINNGDLCCE
{
	private const int KFLONILOAJM = 10;

	private LLCJMMBBLEH PFLNAKCAFNH;

	private readonly PNBPNBCJFEO AMKHHDDCOEN;

	private static readonly List<HCNJNGAJOFI> HDFLCEDCMGJ = new List<HCNJNGAJOFI>
	{
		new HCNJNGAJOFI(31, "1", "1", true),
		new HCNJNGAJOFI(32, "1", "1", true),
		new HCNJNGAJOFI(33, "1", "1", true),
		new HCNJNGAJOFI(34, "1", "1", true),
		new HCNJNGAJOFI(35, "1", "1", true),
		new HCNJNGAJOFI(36, "1", "1", true),
		new HCNJNGAJOFI(37, "1", "1", true),
		new HCNJNGAJOFI(38, "1", "1", true),
		new HCNJNGAJOFI(39, "1", "1", true),
		new HCNJNGAJOFI(40, "1", "1", true),
		new HCNJNGAJOFI(41, "1", "1", true),
		new HCNJNGAJOFI(42, "1", "1", true),
		new HCNJNGAJOFI(43, "1", "1", true),
		new HCNJNGAJOFI(44, "1", "1", true),
		new HCNJNGAJOFI(45, "1", "1", true),
		new HCNJNGAJOFI(46, "1", "1", true),
		new HCNJNGAJOFI(47, "1", "1", true),
		new HCNJNGAJOFI(48, "1", "1", true),
		new HCNJNGAJOFI(49, "1", "1", true),
		new HCNJNGAJOFI(50, "1", "1", true),
		new HCNJNGAJOFI(51, "1", "1", true),
		new HCNJNGAJOFI(52, "1", "1", true),
		new HCNJNGAJOFI(53, "1", "1", true),
		new HCNJNGAJOFI(54, "1", "1", true),
		new HCNJNGAJOFI(55, "1", "1", true)
	};

	public bool DCKHOAHIFDH { get; private set; }

	public IMINNGDLCCE()
	{
		AMKHHDDCOEN = new PNBPNBCJFEO();
	}

	public void FBOLKDLOGKP(string NGLMGLNHLEM)
	{
		int result = 0;
		int.TryParse(NGLMGLNHLEM, out result);
		HCNJNGAJOFI hCNJNGAJOFI = HDFLCEDCMGJ[HDFLCEDCMGJ.Count - 1];
		if (result > hCNJNGAJOFI.EEFMIHDPJPG)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Requested id = {0} is bigger than last download id = {1}.", result, hCNJNGAJOFI.EEFMIHDPJPG);
			DCKHOAHIFDH = true;
			return;
		}
		HCNJNGAJOFI hCNJNGAJOFI2 = HDFLCEDCMGJ[0];
		if (result < hCNJNGAJOFI2.EEFMIHDPJPG - 10)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Requested id = {0} is lower than threshold id = {1}.", result, hCNJNGAJOFI2.EEFMIHDPJPG - 10);
			DCKHOAHIFDH = true;
			return;
		}
		if (result < hCNJNGAJOFI2.EEFMIHDPJPG && result >= hCNJNGAJOFI2.EEFMIHDPJPG - 10)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Requested id = {0} is lower than first download id = {1}. Downloads will start.", result, hCNJNGAJOFI2.EEFMIHDPJPG);
			DCKHOAHIFDH = true;
			NLPAMGJNDPC(result);
			return;
		}
		LLCJMMBBLEH lLCJMMBBLEH = null;
		for (int i = 0; i < HDFLCEDCMGJ.Count; i++)
		{
			HCNJNGAJOFI mDBFIFLKPKP = HDFLCEDCMGJ[i];
			if (result == mDBFIFLKPKP.EEFMIHDPJPG)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Start background download for id: {0}.", result);
				GICLJILCNPC(mDBFIFLKPKP);
				lLCJMMBBLEH = new LLCJMMBBLEH(GIPDAOFFKFH(result));
				break;
			}
		}
		if (lLCJMMBBLEH == null)
		{
			DCKHOAHIFDH = true;
		}
	}

	public static bool EHFANHPHHEB(int CHHHPCOIFJJ)
	{
		if (CHHHPCOIFJJ < HDFLCEDCMGJ[0].EEFMIHDPJPG)
		{
			return true;
		}
		if (CHHHPCOIFJJ > HDFLCEDCMGJ[HDFLCEDCMGJ.Count - 1].EEFMIHDPJPG)
		{
			return true;
		}
		return PNBPNBCJFEO.FGEFBNBMOOE(CHHHPCOIFJJ);
	}

	private void GICLJILCNPC(HCNJNGAJOFI MDBFIFLKPKP)
	{
		string cHHHPCOIFJJ = MDBFIFLKPKP.EEFMIHDPJPG.ToString();
		string gNBGNEDNJIE = HLKAEJCPMEB.JDALCCECHEE(cHHHPCOIFJJ, "NewMap");
		string gNBGNEDNJIE2 = HLKAEJCPMEB.JDALCCECHEE(cHHHPCOIFJJ, "NewMapGame");
		PPMCKIKDOLO(gNBGNEDNJIE, MDBFIFLKPKP.MNPFENCILFB, MDBFIFLKPKP.KFFIKEFIOOG);
		PPMCKIKDOLO(gNBGNEDNJIE2, MDBFIFLKPKP.IIBMGAJFCOC, MDBFIFLKPKP.KFFIKEFIOOG);
	}

	private void PPMCKIKDOLO(string GNBGNEDNJIE, string DFCJKBHFPMG, bool FHFHAIGLEJE)
	{
		string lNCBFPEKHDJ = HLKAEJCPMEB.CAHJPAECDMJ(GNBGNEDNJIE, DFCJKBHFPMG, FHFHAIGLEJE);
		AMKHHDDCOEN.PPMCKIKDOLO(GNBGNEDNJIE, lNCBFPEKHDJ, DFCJKBHFPMG, FHFHAIGLEJE);
	}

	private IEnumerator GIPDAOFFKFH(int CHHHPCOIFJJ)
	{
		float num = 0f;
		while (!PNBPNBCJFEO.FGEFBNBMOOE(CHHHPCOIFJJ) && !(num >= 3f))
		{
			num += 0.1f;
			yield return MCJHHDACJBG.CNDGGNLKOOC;
		}
		GMMNKGCHMBM(CHHHPCOIFJJ.ToString(), num);
	}

	private void GMMNKGCHMBM(string CHHHPCOIFJJ, float DDOFEMKGGHK)
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Download, "Waiting stopped for id: {0}. Wait time: {1}", CHHHPCOIFJJ, DDOFEMKGGHK);
		DCKHOAHIFDH = true;
		int result = 0;
		int.TryParse(CHHHPCOIFJJ, out result);
		NLPAMGJNDPC(result);
	}

	private void NLPAMGJNDPC(int CHHHPCOIFJJ)
	{
		for (int i = 0; i < HDFLCEDCMGJ.Count; i++)
		{
			HCNJNGAJOFI mDBFIFLKPKP = HDFLCEDCMGJ[i];
			if (CHHHPCOIFJJ < mDBFIFLKPKP.EEFMIHDPJPG)
			{
				GICLJILCNPC(mDBFIFLKPKP);
			}
		}
	}
}
