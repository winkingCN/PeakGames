using System;
using System.IO;

internal class PNIFFFAPCCI
{
	private const int KOIFEIDLNKK = 16384;

	internal const int NPJIBOBKIKH = 5;

	internal const int NIONDNHNBBP = 0;

	internal const int ENLCLLIHGIO = 1;

	internal const int POKKOIJIDPP = 3;

	private HEMGBKNMOKB DAIIFBOBPEN;

	private Stream ELCDGJDOELN;

	private Stream JJOPEJKLKCE;

	private EIMOMMNKKEG BEDCEDAMBPJ;

	private EIMOMMNKKEG INNNKFODNLJ;

	private EIMOMMNKKEG NIEEBFKHGIG;

	private ECBKNMOGLEG GCPKEJBBGFP;

	private ECBKNMOGLEG GDHEDKCFNIP;

	private ECBKNMOGLEG HAIBAAHLANG;

	private long CKAGALMGOEC;

	private long BNCNJJNAGOH;

	private MemoryStream GLNPFOPEIGP = new MemoryStream();

	private KKMFHDBDNLF GNLHAOBBMLD;

	private OBDIBELBBEO PPIALHMPECM;

	private OBDIBELBBEO JMFHFKABIOM;

	private bool FKLFEAILHLG = true;

	private int CMFLCNPMODI;

	private int DHFCANDFBDG;

	private int COBENLOHKIJ;

	internal virtual OBDIBELBBEO NGLBPHAOKHO
	{
		get
		{
			return PPIALHMPECM;
		}
		set
		{
			PPIALHMPECM = value;
		}
	}

	internal virtual KKMFHDBDNLF OPLLOBGPFNO
	{
		get
		{
			return GNLHAOBBMLD;
		}
	}

	internal PNIFFFAPCCI(HEMGBKNMOKB ACBFAFJINMJ, Stream MOPCLEEGDFB, Stream BILGCJNPJGJ)
	{
		DAIIFBOBPEN = ACBFAFJINMJ;
		ELCDGJDOELN = MOPCLEEGDFB;
		JJOPEJKLKCE = BILGCJNPJGJ;
		INNNKFODNLJ = new DGELJFKJOPB();
		NIEEBFKHGIG = INNNKFODNLJ;
	}

	internal virtual void DIOELAHNLKJ(CGDEGBGOKJO MBEMNOCDDBC)
	{
		GDHEDKCFNIP = new HIKKGKGPJII(MBEMNOCDDBC);
		HAIBAAHLANG = GDHEDKCFNIP;
		GNLHAOBBMLD = new OHMCIMBDOPP();
		GNLHAOBBMLD.DIOELAHNLKJ(MBEMNOCDDBC);
		JDAIPDCPMFB(16384);
	}

	internal virtual int LBEOGHDBCJM()
	{
		return CMFLCNPMODI;
	}

	internal virtual void JDAIPDCPMFB(int FIFOEKCNFBH)
	{
		CMFLCNPMODI = FIFOEKCNFBH;
		DHFCANDFBDG = CMFLCNPMODI + 1024;
		COBENLOHKIJ = DHFCANDFBDG + 1024;
	}

	internal virtual void PLIGEMIADFP(OBDIBELBBEO OBMPKFDAMIA)
	{
		JMFHFKABIOM = OBMPKFDAMIA;
	}

	internal virtual void OPEOGAPNLHE(bool IEGIOBJMGKJ)
	{
		FKLFEAILHLG = IEGIOBJMGKJ;
	}

	internal virtual void MDHHAEHPIGF(EIMOMMNKKEG GBGKNOJJELI, ECBKNMOGLEG ODDCAGNOLOA)
	{
		BEDCEDAMBPJ = GBGKNOJJELI;
		GCPKEJBBGFP = ODDCAGNOLOA;
	}

	internal virtual void JLEPJHGEDPN()
	{
		if (BEDCEDAMBPJ == null || GCPKEJBBGFP == null)
		{
			throw new DEIDBCPPCMB(40);
		}
		NIEEBFKHGIG = BEDCEDAMBPJ;
		HAIBAAHLANG = GCPKEJBBGFP;
		BNCNJJNAGOH = 0L;
	}

	internal virtual void IBIOJGLMLCE()
	{
		if (BEDCEDAMBPJ == null || GCPKEJBBGFP == null)
		{
			throw new DEIDBCPPCMB(40);
		}
		INNNKFODNLJ = BEDCEDAMBPJ;
		GDHEDKCFNIP = GCPKEJBBGFP;
		CKAGALMGOEC = 0L;
	}

	internal virtual void GPGDHBAOLAI()
	{
		if (INNNKFODNLJ != BEDCEDAMBPJ || NIEEBFKHGIG != BEDCEDAMBPJ || GDHEDKCFNIP != GCPKEJBBGFP || HAIBAAHLANG != GCPKEJBBGFP)
		{
			throw new DEIDBCPPCMB(40);
		}
		BEDCEDAMBPJ = null;
		GCPKEJBBGFP = null;
	}

	internal virtual bool HNCNDGABFPN()
	{
		byte[] array = KINEBFNENMB.FAPOJPGMEMJ(5, ELCDGJDOELN);
		if (array == null)
		{
			return false;
		}
		byte b = KINEBFNENMB.HEEOKPLLJMG(array, 0);
		HNHPLAHDBPM(b, 10);
		if (!FKLFEAILHLG)
		{
			int num = KINEBFNENMB.LBFNBPLKGIM(array, 1);
			if ((num & 0xFFFFFF00u) != 768)
			{
				throw new DEIDBCPPCMB(47);
			}
		}
		else
		{
			OBDIBELBBEO oBDIBELBBEO = KINEBFNENMB.NGLBPHAOKHO(array, 1);
			if (PPIALHMPECM == null)
			{
				PPIALHMPECM = oBDIBELBBEO;
			}
			else if (!oBDIBELBBEO.KIFDKLPDKMD(PPIALHMPECM))
			{
				throw new DEIDBCPPCMB(47);
			}
		}
		int nBEDPKHALCN = KINEBFNENMB.DMHJEBHACNN(array, 3);
		byte[] array2 = LMCPMDAEBNO(b, ELCDGJDOELN, nBEDPKHALCN);
		DAIIFBOBPEN.ODNGHLHLLIB(b, array2, 0, array2.Length);
		return true;
	}

	internal virtual byte[] LMCPMDAEBNO(byte NBFBPNNEKMN, Stream MOPCLEEGDFB, int NBEDPKHALCN)
	{
		JDOPMMJOAIH(NBEDPKHALCN, COBENLOHKIJ, 22);
		byte[] array = KINEBFNENMB.PCNDKGFHPJN(NBEDPKHALCN, MOPCLEEGDFB);
		byte[] array2 = GDHEDKCFNIP.OBMCLFEIPBL(CKAGALMGOEC++, NBFBPNNEKMN, array, 0, array.Length);
		JDOPMMJOAIH(array2.Length, DHFCANDFBDG, 22);
		Stream stream = INNNKFODNLJ.GLOBHILMJCN(GLNPFOPEIGP);
		if (stream != GLNPFOPEIGP)
		{
			stream.Write(array2, 0, array2.Length);
			stream.Flush();
			array2 = AMHNEPFCFLO();
		}
		JDOPMMJOAIH(array2.Length, CMFLCNPMODI, 30);
		if (array2.Length < 1 && NBFBPNNEKMN != 23)
		{
			throw new DEIDBCPPCMB(47);
		}
		return array2;
	}

	internal virtual void KHNMCLEHIFL(byte NBFBPNNEKMN, byte[] NEOIPBBDIMB, int AGDENLHDCKF, int JLCLJBAMMLO)
	{
		if (JMFHFKABIOM != null)
		{
			HNHPLAHDBPM(NBFBPNNEKMN, 80);
			JDOPMMJOAIH(JLCLJBAMMLO, CMFLCNPMODI, 80);
			if (JLCLJBAMMLO < 1 && NBFBPNNEKMN != 23)
			{
				throw new DEIDBCPPCMB(80);
			}
			if (NBFBPNNEKMN == 22)
			{
				ALHKBMCPCIB(NEOIPBBDIMB, AGDENLHDCKF, JLCLJBAMMLO);
			}
			Stream stream = NIEEBFKHGIG.CMBDCJOOPPK(GLNPFOPEIGP);
			byte[] array;
			if (stream == GLNPFOPEIGP)
			{
				array = HAIBAAHLANG.BIIKEIOAPCJ(BNCNJJNAGOH++, NBFBPNNEKMN, NEOIPBBDIMB, AGDENLHDCKF, JLCLJBAMMLO);
			}
			else
			{
				stream.Write(NEOIPBBDIMB, AGDENLHDCKF, JLCLJBAMMLO);
				stream.Flush();
				byte[] array2 = AMHNEPFCFLO();
				JDOPMMJOAIH(array2.Length, JLCLJBAMMLO + 1024, 80);
				array = HAIBAAHLANG.BIIKEIOAPCJ(BNCNJJNAGOH++, NBFBPNNEKMN, array2, 0, array2.Length);
			}
			JDOPMMJOAIH(array.Length, COBENLOHKIJ, 80);
			byte[] array3 = new byte[array.Length + 5];
			KINEBFNENMB.JBOHOOBEPAM(NBFBPNNEKMN, array3, 0);
			KINEBFNENMB.PPCDKILMGFD(JMFHFKABIOM, array3, 1);
			KINEBFNENMB.PGBAOHFKNHN(array.Length, array3, 3);
			Array.Copy(array, 0, array3, 5, array.Length);
			JJOPEJKLKCE.Write(array3, 0, array3.Length);
			JJOPEJKLKCE.Flush();
		}
	}

	internal virtual void HIDDHBFMDNF()
	{
		GNLHAOBBMLD = GNLHAOBBMLD.NFEDILFGOFB();
	}

	internal virtual KKMFHDBDNLF JNFCHMHNLEB()
	{
		KKMFHDBDNLF gNLHAOBBMLD = GNLHAOBBMLD;
		GNLHAOBBMLD = GNLHAOBBMLD.ANPICCCJCIH();
		return gNLHAOBBMLD;
	}

	internal virtual void ALHKBMCPCIB(byte[] OEFCOJLNCKP, int IBNDGNOIEEF, int NBEDPKHALCN)
	{
		GNLHAOBBMLD.GONEEEFEDGF(OEFCOJLNCKP, IBNDGNOIEEF, NBEDPKHALCN);
	}

	internal virtual void LAHDPEAHJBO()
	{
		try
		{
			LHFGHNFJIKM.PCHCAFHEJJM(ELCDGJDOELN);
		}
		catch (IOException)
		{
		}
		try
		{
			LHFGHNFJIKM.PCHCAFHEJJM(JJOPEJKLKCE);
		}
		catch (IOException)
		{
		}
	}

	internal virtual void COGIEDKOBPC()
	{
		JJOPEJKLKCE.Flush();
	}

	private byte[] AMHNEPFCFLO()
	{
		byte[] result = GLNPFOPEIGP.ToArray();
		GLNPFOPEIGP.SetLength(0L);
		return result;
	}

	private static void HNHPLAHDBPM(byte NBFBPNNEKMN, byte LHIDNPKMPPJ)
	{
		switch (NBFBPNNEKMN)
		{
		case 20:
		case 21:
		case 22:
		case 23:
		case 24:
			return;
		}
		throw new DEIDBCPPCMB(LHIDNPKMPPJ);
	}

	private static void JDOPMMJOAIH(int EOFAGACBNFP, int GJHEBCMICMA, byte LHIDNPKMPPJ)
	{
		if (EOFAGACBNFP > GJHEBCMICMA)
		{
			throw new DEIDBCPPCMB(LHIDNPKMPPJ);
		}
	}
}
