using System;
using System.Collections;
using System.IO;

public abstract class HEMGBKNMOKB
{
	internal class OLCIAJEPOLP : MemoryStream
	{
		internal OLCIAJEPOLP(byte OCDOJFFGKAI)
			: this(OCDOJFFGKAI, 60)
		{
		}

		internal OLCIAJEPOLP(byte OCDOJFFGKAI, int EOFAGACBNFP)
			: base(EOFAGACBNFP + 4)
		{
			KINEBFNENMB.JBOHOOBEPAM(OCDOJFFGKAI, this);
			KINEBFNENMB.HKPEAEDPGAD(0, this);
		}

		internal void KBMOJGCCCEN(byte[] MBBPBGHKLJM)
		{
			Write(MBBPBGHKLJM, 0, MBBPBGHKLJM.Length);
		}

		internal void PGOHFLKIFHM(HEMGBKNMOKB JAAFPJHBGEA)
		{
			long num = Length - 4;
			KINEBFNENMB.CJIFBMOJIBB(num);
			Position = 1L;
			KINEBFNENMB.HKPEAEDPGAD((int)num, this);
			byte[] buffer = GetBuffer();
			int nBEDPKHALCN = (int)Length;
			JAAFPJHBGEA.LBFCPCILGNN(buffer, 0, nBEDPKHALCN);
			LHFGHNFJIKM.PCHCAFHEJJM(this);
		}
	}

	private static readonly string IDMNNLHIDNH = "Internal TLS error, this could be an attack";

	protected const short NPMJHDJJPHE = 0;

	protected const short BNJNHGLFFNC = 1;

	protected const short EHDGELBKEOL = 2;

	protected const short FFNGOHJMNOM = 3;

	protected const short MLJDLPCKLNP = 4;

	protected const short CPEPGHLKCFO = 5;

	protected const short FELBECLAAEC = 6;

	protected const short KFOHIAJIPFI = 7;

	protected const short DLCFNOPHOON = 8;

	protected const short IEAFBBPKBBP = 9;

	protected const short ECAHFGLIIGP = 10;

	protected const short GFHPLPPCLCN = 11;

	protected const short PAAFJKJOGKL = 12;

	protected const short KGCEINPKOIB = 13;

	protected const short AKHEDPCPCIO = 14;

	protected const short BCOFJINFIAL = 15;

	protected const short DOJINBAHBBD = 16;

	protected const short EOLGJBHIOJN = 0;

	protected const short NOBDHOPBAAG = 1;

	protected const short HBKPJAGKMNO = 2;

	private AOIEPNLGJDJ NNBDFBOJELJ = new AOIEPNLGJDJ();

	private AOIEPNLGJDJ KPGFDNKDMNN = new AOIEPNLGJDJ(2);

	private AOIEPNLGJDJ JIBIMNCMNGE = new AOIEPNLGJDJ();

	internal PNIFFFAPCCI LHNFFJBDNBG;

	protected FBIJJFGLKMK BECLOCCFICG;

	private ONDPHGOFOFO FIHEFKDPHLL;

	private volatile bool BMMHJNBCCNA;

	private volatile bool PBLBHFFKMIC;

	private volatile bool FNPBKMHGIIC;

	private volatile bool ENEBLIMJOGL = true;

	private volatile int IMOPLKACPOI;

	private byte[] FBJMGCFEEBP;

	protected POBPBLILLLP FMIPBLFOKFG;

	protected CBKKCJFENJM KBNPIGOEJEE;

	protected PDCALMCFKGD CGEBPLCBCCP;

	protected PAJJBHMEFKE HOFDFNMIALD;

	protected int[] GPDCOOCEGJH;

	protected byte[] FFJFJNKMGNE;

	protected IDictionary LCAFLJDMMPB;

	protected IDictionary PENJPGNIDJC;

	protected short LNHCCIAMIMK;

	protected bool EEBLPIHKADI;

	protected bool AOMCENJJEBN;

	protected bool DPJCPMCFAEJ;

	protected bool AGDDELNONDJ;

	protected bool MKHIKOCPNPA;

	protected bool IPADOBJGOED = true;

	protected IONBDAJAGNJ HKKPJPMALNK;

	protected IONBDAJAGNJ BNBGAAIDDAG;

	protected abstract CGDEGBGOKJO GMHPAPJFFNC { get; }

	internal abstract KPKGCNEJIAM EMKADIHPAHJ { get; }

	protected abstract NGBFPFEHHNG AHPIDFAOOPF { get; }

	public virtual Stream LCEEJHJNOCD
	{
		get
		{
			if (!IPADOBJGOED)
			{
				throw new InvalidOperationException("Cannot use Stream in non-blocking mode! Use OfferInput()/OfferOutput() instead.");
			}
			return FIHEFKDPHLL;
		}
	}

	public virtual bool GGKOJOMPGEK
	{
		get
		{
			return BMMHJNBCCNA;
		}
	}

	public HEMGBKNMOKB(Stream JKKFADEOBOG, FBIJJFGLKMK ENKGBJPFHAO)
		: this(JKKFADEOBOG, JKKFADEOBOG, ENKGBJPFHAO)
	{
	}

	public HEMGBKNMOKB(Stream MOPCLEEGDFB, Stream BILGCJNPJGJ, FBIJJFGLKMK ENKGBJPFHAO)
	{
		LHNFFJBDNBG = new PNIFFFAPCCI(this, MOPCLEEGDFB, BILGCJNPJGJ);
		BECLOCCFICG = ENKGBJPFHAO;
	}

	public HEMGBKNMOKB(FBIJJFGLKMK ENKGBJPFHAO)
	{
		IPADOBJGOED = false;
		HKKPJPMALNK = new IONBDAJAGNJ();
		BNBGAAIDDAG = new IONBDAJAGNJ();
		LHNFFJBDNBG = new PNIFFFAPCCI(this, HKKPJPMALNK, BNBGAAIDDAG);
		BECLOCCFICG = ENKGBJPFHAO;
	}

	protected virtual void MAGLEFBJADF()
	{
	}

	protected abstract void JOBBGIDBDLD(byte NBFBPNNEKMN, byte[] GHPCHPOHELF);

	protected virtual void HPGMDOAAMCK(byte DGDILOMFNFA)
	{
	}

	protected virtual void EJLNOELJHMP()
	{
		if (CGEBPLCBCCP.GBGOFJPGDJM >= 0)
		{
			if (!NLMBLHFBPNL.NAFCDEECGEF((byte)CGEBPLCBCCP.GBGOFJPGDJM))
			{
				throw new DEIDBCPPCMB(80);
			}
			int fIFOEKCNFBH = 1 << 8 + CGEBPLCBCCP.GBGOFJPGDJM;
			LHNFFJBDNBG.JDAIPDCPMFB(fIFOEKCNFBH);
		}
	}

	protected virtual void JOJGEKHBFGJ(bool GGFLAFELKOM)
	{
		if (GGFLAFELKOM != AOMCENJJEBN)
		{
			throw new DEIDBCPPCMB(10);
		}
	}

	protected virtual void JCDEHOJAGIM()
	{
		if (FBJMGCFEEBP != null)
		{
			NOGCEBKPPJE.MEBLOMPDLEJ(FBJMGCFEEBP, 0);
			FBJMGCFEEBP = null;
		}
		CGEBPLCBCCP.BOPEPLONIFL();
		HOFDFNMIALD = null;
		GPDCOOCEGJH = null;
		FFJFJNKMGNE = null;
		LCAFLJDMMPB = null;
		PENJPGNIDJC = null;
		EEBLPIHKADI = false;
		AOMCENJJEBN = false;
		DPJCPMCFAEJ = false;
		AGDDELNONDJ = false;
		MKHIKOCPNPA = false;
	}

	protected virtual void PNLFKFJGJAG()
	{
		if (!IPADOBJGOED)
		{
			return;
		}
		while (LNHCCIAMIMK != 16)
		{
			if (BMMHJNBCCNA)
			{
			}
			FEJDFBIGPPH();
		}
	}

	protected virtual void GGGEFIHCFHI()
	{
		try
		{
			LHNFFJBDNBG.GPGDHBAOLAI();
			ENEBLIMJOGL = !KINEBFNENMB.IJOEFFKABJB(GMHPAPJFFNC);
			if (!FNPBKMHGIIC)
			{
				FNPBKMHGIIC = true;
				if (IPADOBJGOED)
				{
					FIHEFKDPHLL = new ONDPHGOFOFO(this);
				}
			}
			if (FMIPBLFOKFG != null)
			{
				if (KBNPIGOEJEE == null)
				{
					KBNPIGOEJEE = new CBKKCJFENJM.NPKMNFBOOBJ().JKHOIOIHKJL(CGEBPLCBCCP.LKCGPEEINAA).KJGPOFCIOJD(CGEBPLCBCCP.OEFPAPDGGKJ).JDKFOEELJEL(CGEBPLCBCCP.EFKBHGKOMBB)
						.BHJNGMMIGDM(HOFDFNMIALD)
						.FGCCCHPAHHC(CGEBPLCBCCP.HPLBKGHNLMB)
						.BHPEOAMFLEA(CGEBPLCBCCP.MIMODMJNDFP)
						.LCNBALCMHOF(PENJPGNIDJC)
						.HOEJFJPHGDO();
					FMIPBLFOKFG = new IIFHCHFCCDK(FMIPBLFOKFG.GLPODMDPMAK, KBNPIGOEJEE);
				}
				EMKADIHPAHJ.IMMNFAHMDOB(FMIPBLFOKFG);
			}
			AHPIDFAOOPF.FKGPFELMJKH();
		}
		finally
		{
			JCDEHOJAGIM();
		}
	}

	protected internal void ODNGHLHLLIB(byte JAAFPJHBGEA, byte[] GHPCHPOHELF, int IBNDGNOIEEF, int NBEDPKHALCN)
	{
		switch (JAAFPJHBGEA)
		{
		case 21:
			KPGFDNKDMNN.ECGMPBCCBLB(GHPCHPOHELF, IBNDGNOIEEF, NBEDPKHALCN);
			NJAOJDBHNAP();
			break;
		case 23:
			if (!FNPBKMHGIIC)
			{
				throw new DEIDBCPPCMB(10);
			}
			NNBDFBOJELJ.ECGMPBCCBLB(GHPCHPOHELF, IBNDGNOIEEF, NBEDPKHALCN);
			JLDHCCOOEPL();
			break;
		case 20:
			NIIHDOGNCFK(GHPCHPOHELF, IBNDGNOIEEF, NBEDPKHALCN);
			break;
		case 22:
			JIBIMNCMNGE.ECGMPBCCBLB(GHPCHPOHELF, IBNDGNOIEEF, NBEDPKHALCN);
			KECIPHPLMJG();
			break;
		case 24:
			if (!FNPBKMHGIIC)
			{
				throw new DEIDBCPPCMB(10);
			}
			break;
		}
	}

	private void KECIPHPLMJG()
	{
		bool flag;
		do
		{
			flag = false;
			if (JIBIMNCMNGE.AJFPKOAKJOD < 4)
			{
				continue;
			}
			byte[] array = new byte[4];
			JIBIMNCMNGE.CELOEBEMCKP(array, 0, 4, 0);
			byte b = KINEBFNENMB.HEEOKPLLJMG(array, 0);
			int num = KINEBFNENMB.MFIAOJHGMHG(array, 1);
			if (JIBIMNCMNGE.AJFPKOAKJOD < num + 4)
			{
				continue;
			}
			byte[] array2 = JIBIMNCMNGE.LNFLLAIGBIO(num, 4);
			JOJGEKHBFGJ(LNHCCIAMIMK == 16 || b == 20);
			switch (b)
			{
			default:
			{
				CGDEGBGOKJO cGDEGBGOKJO = GMHPAPJFFNC;
				if (b == 20 && FBJMGCFEEBP == null && cGDEGBGOKJO.HFMNBFOAPOP.EFKBHGKOMBB != null)
				{
					FBJMGCFEEBP = BPECONDKJHC(!cGDEGBGOKJO.DLHCCNKGKJP);
				}
				LHNFFJBDNBG.ALHKBMCPCIB(array, 0, 4);
				LHNFFJBDNBG.ALHKBMCPCIB(array2, 0, num);
				break;
			}
			case 0:
				break;
			}
			JOBBGIDBDLD(b, array2);
			flag = true;
		}
		while (flag);
	}

	private void JLDHCCOOEPL()
	{
	}

	private void NJAOJDBHNAP()
	{
		while (KPGFDNKDMNN.AJFPKOAKJOD >= 2)
		{
			byte[] array = KPGFDNKDMNN.LNFLLAIGBIO(2, 0);
			byte b = array[0];
			byte b2 = array[1];
			AHPIDFAOOPF.EEFFPKOOHJM(b, b2);
			if (b == 2)
			{
				GDHEECDEMPM();
				PBLBHFFKMIC = true;
				BMMHJNBCCNA = true;
				LHNFFJBDNBG.LAHDPEAHJBO();
				throw new IOException(IDMNNLHIDNH);
			}
			if (b2 == 0)
			{
				GJAAOBKGHJP(false);
			}
			HPGMDOAAMCK(b2);
		}
	}

	private void NIIHDOGNCFK(byte[] GHPCHPOHELF, int JBAJPGIAPFF, int NBEDPKHALCN)
	{
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			byte b = KINEBFNENMB.HEEOKPLLJMG(GHPCHPOHELF, JBAJPGIAPFF + i);
			if (b != 1)
			{
				throw new DEIDBCPPCMB(50);
			}
			if (AOMCENJJEBN || KPGFDNKDMNN.AJFPKOAKJOD > 0 || JIBIMNCMNGE.AJFPKOAKJOD > 0)
			{
				throw new DEIDBCPPCMB(10);
			}
			LHNFFJBDNBG.IBIOJGLMLCE();
			AOMCENJJEBN = true;
			MAGLEFBJADF();
		}
	}

	protected internal virtual int DPCHHMAOCIC()
	{
		return NNBDFBOJELJ.AJFPKOAKJOD;
	}

	protected internal virtual int MOANMMEHBDL(byte[] GHPCHPOHELF, int IBNDGNOIEEF, int NBEDPKHALCN)
	{
		if (NBEDPKHALCN < 1)
		{
			return 0;
		}
		while (NNBDFBOJELJ.AJFPKOAKJOD == 0)
		{
			if (BMMHJNBCCNA)
			{
				if (PBLBHFFKMIC)
				{
					throw new IOException(IDMNNLHIDNH);
				}
				return 0;
			}
			FEJDFBIGPPH();
		}
		NBEDPKHALCN = Math.Min(NBEDPKHALCN, NNBDFBOJELJ.AJFPKOAKJOD);
		NNBDFBOJELJ.LNFLLAIGBIO(GHPCHPOHELF, IBNDGNOIEEF, NBEDPKHALCN, 0);
		return NBEDPKHALCN;
	}

	protected virtual void FEJDFBIGPPH()
	{
		try
		{
			if (!LHNFFJBDNBG.HNCNDGABFPN())
			{
				throw new EndOfStreamException();
			}
		}
		catch (DEIDBCPPCMB dEIDBCPPCMB)
		{
			if (!BMMHJNBCCNA)
			{
				HKMJPAAFPEP(2, dEIDBCPPCMB.AGKAPFCDDJP, "Failed to read record", dEIDBCPPCMB);
			}
			throw dEIDBCPPCMB;
		}
		catch (Exception ex)
		{
			if (!BMMHJNBCCNA)
			{
				HKMJPAAFPEP(2, 80, "Failed to read record", ex);
			}
			throw ex;
		}
	}

	protected virtual void ENFJGNGMPMB(byte NBFBPNNEKMN, byte[] GHPCHPOHELF, int IBNDGNOIEEF, int NBEDPKHALCN)
	{
		try
		{
			LHNFFJBDNBG.KHNMCLEHIFL(NBFBPNNEKMN, GHPCHPOHELF, IBNDGNOIEEF, NBEDPKHALCN);
		}
		catch (DEIDBCPPCMB dEIDBCPPCMB)
		{
			if (!BMMHJNBCCNA)
			{
				HKMJPAAFPEP(2, dEIDBCPPCMB.AGKAPFCDDJP, "Failed to write record", dEIDBCPPCMB);
			}
			throw dEIDBCPPCMB;
		}
		catch (Exception ex)
		{
			if (!BMMHJNBCCNA)
			{
				HKMJPAAFPEP(2, 80, "Failed to write record", ex);
			}
			throw ex;
		}
	}

	protected internal virtual void APDJGECJPIP(byte[] GHPCHPOHELF, int IBNDGNOIEEF, int NBEDPKHALCN)
	{
		if (BMMHJNBCCNA)
		{
			if (PBLBHFFKMIC)
			{
				throw new IOException(IDMNNLHIDNH);
			}
			throw new IOException("Sorry, connection has been closed, you cannot write more data");
		}
		while (NBEDPKHALCN > 0)
		{
			if (ENEBLIMJOGL)
			{
				switch (IMOPLKACPOI)
				{
				case 1:
					ENFJGNGMPMB(23, KINEBFNENMB.JBCONIFELBM, 0, 0);
					break;
				case 2:
					ENEBLIMJOGL = false;
					ENFJGNGMPMB(23, KINEBFNENMB.JBCONIFELBM, 0, 0);
					break;
				default:
					ENFJGNGMPMB(23, GHPCHPOHELF, IBNDGNOIEEF, 1);
					IBNDGNOIEEF++;
					NBEDPKHALCN--;
					break;
				}
			}
			if (NBEDPKHALCN > 0)
			{
				int num = Math.Min(NBEDPKHALCN, LHNFFJBDNBG.LBEOGHDBCJM());
				ENFJGNGMPMB(23, GHPCHPOHELF, IBNDGNOIEEF, num);
				IBNDGNOIEEF += num;
				NBEDPKHALCN -= num;
			}
		}
	}

	protected virtual void JDIBHMIAAIC(int JKIMKGAJNFF)
	{
		if (JKIMKGAJNFF < 0 || JKIMKGAJNFF > 2)
		{
			throw new ArgumentException("Illegal appDataSplitMode mode: " + JKIMKGAJNFF, "appDataSplitMode");
		}
		IMOPLKACPOI = JKIMKGAJNFF;
	}

	protected virtual void LBFCPCILGNN(byte[] GHPCHPOHELF, int JBAJPGIAPFF, int NBEDPKHALCN)
	{
		while (NBEDPKHALCN > 0)
		{
			int num = Math.Min(NBEDPKHALCN, LHNFFJBDNBG.LBEOGHDBCJM());
			ENFJGNGMPMB(22, GHPCHPOHELF, JBAJPGIAPFF, num);
			JBAJPGIAPFF += num;
			NBEDPKHALCN -= num;
		}
	}

	public virtual void PNMBCGOGOMF(byte[] MOPCLEEGDFB)
	{
		if (IPADOBJGOED)
		{
			throw new InvalidOperationException("Cannot use OfferInput() in blocking mode! Use Stream instead.");
		}
		if (BMMHJNBCCNA)
		{
			throw new IOException("Connection is closed, cannot accept any more input");
		}
		HKKPJPMALNK.KBMOJGCCCEN(MOPCLEEGDFB);
		while (HKKPJPMALNK.AJFPKOAKJOD >= 5)
		{
			byte[] gHPCHPOHELF = new byte[5];
			HKKPJPMALNK.DNMHOJNDABI(gHPCHPOHELF);
			int num = KINEBFNENMB.DMHJEBHACNN(gHPCHPOHELF, 3) + 5;
			if (HKKPJPMALNK.AJFPKOAKJOD < num)
			{
				break;
			}
			FEJDFBIGPPH();
		}
	}

	public virtual int MDCIGCGOBEJ()
	{
		if (IPADOBJGOED)
		{
			throw new InvalidOperationException("Cannot use GetAvailableInputBytes() in blocking mode! Use ApplicationDataAvailable() instead.");
		}
		return DPCHHMAOCIC();
	}

	public virtual int FFGPPKOAEIG(byte[] DJDKLOJBJCO, int IBNDGNOIEEF, int EOFAGACBNFP)
	{
		if (IPADOBJGOED)
		{
			throw new InvalidOperationException("Cannot use ReadInput() in blocking mode! Use Stream instead.");
		}
		return MOANMMEHBDL(DJDKLOJBJCO, IBNDGNOIEEF, Math.Min(EOFAGACBNFP, DPCHHMAOCIC()));
	}

	public virtual void FLKCPGMCHCD(byte[] DJDKLOJBJCO, int IBNDGNOIEEF, int EOFAGACBNFP)
	{
		if (IPADOBJGOED)
		{
			throw new InvalidOperationException("Cannot use OfferOutput() in blocking mode! Use Stream instead.");
		}
		if (!FNPBKMHGIIC)
		{
			throw new IOException("Application data cannot be sent until the handshake is complete!");
		}
		APDJGECJPIP(DJDKLOJBJCO, IBNDGNOIEEF, EOFAGACBNFP);
	}

	public virtual int BPJHLPILCAC()
	{
		if (IPADOBJGOED)
		{
			throw new InvalidOperationException("Cannot use GetAvailableOutputBytes() in blocking mode! Use Stream instead.");
		}
		return BNBGAAIDDAG.AJFPKOAKJOD;
	}

	public virtual int JHLGEJLEIAG(byte[] DJDKLOJBJCO, int IBNDGNOIEEF, int EOFAGACBNFP)
	{
		if (IPADOBJGOED)
		{
			throw new InvalidOperationException("Cannot use ReadOutput() in blocking mode! Use Stream instead.");
		}
		return BNBGAAIDDAG.Read(DJDKLOJBJCO, IBNDGNOIEEF, EOFAGACBNFP);
	}

	protected virtual void HKMJPAAFPEP(byte CBJOEMMBAOJ, byte LHIDNPKMPPJ, string OEFCOJLNCKP, Exception DGPFJIEAMIG)
	{
		if (!BMMHJNBCCNA)
		{
			BMMHJNBCCNA = true;
			if (CBJOEMMBAOJ == 2)
			{
				GDHEECDEMPM();
				PBLBHFFKMIC = true;
			}
			OFCEFLGMCEB(CBJOEMMBAOJ, LHIDNPKMPPJ, OEFCOJLNCKP, DGPFJIEAMIG);
			LHNFFJBDNBG.LAHDPEAHJBO();
			if (CBJOEMMBAOJ != 2)
			{
				return;
			}
		}
		throw new IOException(IDMNNLHIDNH);
	}

	protected virtual void GDHEECDEMPM()
	{
		if (KBNPIGOEJEE != null)
		{
			KBNPIGOEJEE.BOPEPLONIFL();
			KBNPIGOEJEE = null;
		}
		if (FMIPBLFOKFG != null)
		{
			FMIPBLFOKFG.OBDGHOPPKOJ();
			FMIPBLFOKFG = null;
		}
	}

	protected virtual void LPENIPIFLKN(MemoryStream GHPCHPOHELF)
	{
		if (FBJMGCFEEBP == null)
		{
			throw new DEIDBCPPCMB(80);
		}
		byte[] bCIHLCMFAEK = KINEBFNENMB.PCNDKGFHPJN(FBJMGCFEEBP.Length, GHPCHPOHELF);
		JILHFDBGNGE(GHPCHPOHELF);
		if (!NOGCEBKPPJE.PBBFCJBKJEN(FBJMGCFEEBP, bCIHLCMFAEK))
		{
			throw new DEIDBCPPCMB(51);
		}
	}

	protected virtual void OFCEFLGMCEB(byte CBJOEMMBAOJ, byte LHIDNPKMPPJ, string OEFCOJLNCKP, Exception DGPFJIEAMIG)
	{
		AHPIDFAOOPF.NGJJJECDDIG(CBJOEMMBAOJ, LHIDNPKMPPJ, OEFCOJLNCKP, DGPFJIEAMIG);
		byte[] gHPCHPOHELF = new byte[2] { CBJOEMMBAOJ, LHIDNPKMPPJ };
		ENFJGNGMPMB(21, gHPCHPOHELF, 0, 2);
	}

	protected virtual void CMGCLGOLHOF(byte LHIDNPKMPPJ, string OEFCOJLNCKP)
	{
		OFCEFLGMCEB(1, LHIDNPKMPPJ, OEFCOJLNCKP, null);
	}

	protected virtual void HICANOOKJEN(PAJJBHMEFKE JKJLDJDJBFO)
	{
		if (JKJLDJDJBFO == null)
		{
			JKJLDJDJBFO = PAJJBHMEFKE.PGOFIDPLOAA;
		}
		if (JKJLDJDJBFO.DHIKCKFGKID)
		{
			CGDEGBGOKJO cGDEGBGOKJO = GMHPAPJFFNC;
			if (!cGDEGBGOKJO.DLHCCNKGKJP)
			{
				OBDIBELBBEO oBDIBELBBEO = GMHPAPJFFNC.PJJKOIEAGJN;
				if (oBDIBELBBEO.NFEADLBGDGE)
				{
					string oEFCOJLNCKP = oBDIBELBBEO.ToString() + " client didn't provide credentials";
					CMGCLGOLHOF(41, oEFCOJLNCKP);
					return;
				}
			}
		}
		OLCIAJEPOLP oLCIAJEPOLP = new OLCIAJEPOLP(11);
		JKJLDJDJBFO.LMDBBPLCJDM(oLCIAJEPOLP);
		oLCIAJEPOLP.PGOHFLKIFHM(this);
	}

	protected virtual void DEKFADHFKIB()
	{
		byte[] array = new byte[1] { 1 };
		ENFJGNGMPMB(20, array, 0, array.Length);
		LHNFFJBDNBG.JLEPJHGEDPN();
	}

	protected virtual void GDCOIGLDHPP()
	{
		byte[] array = BPECONDKJHC(GMHPAPJFFNC.DLHCCNKGKJP);
		OLCIAJEPOLP oLCIAJEPOLP = new OLCIAJEPOLP(20, array.Length);
		oLCIAJEPOLP.Write(array, 0, array.Length);
		oLCIAJEPOLP.PGOHFLKIFHM(this);
	}

	protected virtual void ECJAMAOIAIN(IList PGLEFIHGGOM)
	{
		OLCIAJEPOLP oLCIAJEPOLP = new OLCIAJEPOLP(23);
		JJLNIJEOJHE(oLCIAJEPOLP, PGLEFIHGGOM);
		oLCIAJEPOLP.PGOHFLKIFHM(this);
	}

	protected virtual byte[] BPECONDKJHC(bool AEJKHNCCKFB)
	{
		CGDEGBGOKJO mBEMNOCDDBC = GMHPAPJFFNC;
		string fEHKBFBPJIF = ((!AEJKHNCCKFB) ? "client finished" : "server finished");
		byte[] fOLHCIJCIOC = ((!AEJKHNCCKFB) ? KINEBFNENMB.CKMGGIHOGCI : KINEBFNENMB.MEOEODKCGIG);
		byte[] eOPGFGOFODJ = EBJDALPFDKD(mBEMNOCDDBC, LHNFFJBDNBG.OPLLOBGPFNO, fOLHCIJCIOC);
		return KINEBFNENMB.NDGAINDDJCD(mBEMNOCDDBC, fEHKBFBPJIF, eOPGFGOFODJ);
	}

	public virtual void NKKOEHGDNKD()
	{
		GJAAOBKGHJP(true);
	}

	protected virtual void GJAAOBKGHJP(bool APGICKBKCMM)
	{
		if (!BMMHJNBCCNA)
		{
			if (APGICKBKCMM && !FNPBKMHGIIC)
			{
				CMGCLGOLHOF(90, "User canceled handshake");
			}
			HKMJPAAFPEP(1, 0, "Connection closed", null);
		}
	}

	protected internal virtual void COGIEDKOBPC()
	{
		LHNFFJBDNBG.COGIEDKOBPC();
	}

	protected virtual short HOFFPDHNKCK(IDictionary IIBBHNCCBCA, IDictionary LJDFGPJGHFH, byte LHIDNPKMPPJ)
	{
		short num = APHMHGMCEML.NLFBMFLGDIO(LJDFGPJGHFH);
		if (num >= 0 && (!NLMBLHFBPNL.NAFCDEECGEF((byte)num) || (!EEBLPIHKADI && num != APHMHGMCEML.NLFBMFLGDIO(IIBBHNCCBCA))))
		{
			throw new DEIDBCPPCMB(LHIDNPKMPPJ);
		}
		return num;
	}

	protected virtual void ACDFNEMNAHP()
	{
		if (KINEBFNENMB.NFEADLBGDGE(GMHPAPJFFNC))
		{
			throw new DEIDBCPPCMB(40);
		}
		CMGCLGOLHOF(100, "Renegotiation not supported");
	}

	protected internal static void JILHFDBGNGE(MemoryStream GHPCHPOHELF)
	{
		if (GHPCHPOHELF.Position < GHPCHPOHELF.Length)
		{
			throw new DEIDBCPPCMB(50);
		}
	}

	protected internal static byte[] NLKGEDCFIGA(bool FPCIMNKIMKH, ENDHCNJKMOL BLJFPMMEKDJ)
	{
		byte[] array = new byte[32];
		BLJFPMMEKDJ.GOADFPHGDJG(array);
		if (FPCIMNKIMKH)
		{
			KINEBFNENMB.FDLKFNBAEBP(array, 0);
		}
		return array;
	}

	protected internal static byte[] EKBFPCMCPNF(byte[] DNHDGHPCFLA)
	{
		return KINEBFNENMB.HICBNHCILFB(DNHDGHPCFLA);
	}

	protected internal static void AIOOLPKCFFJ(CGDEGBGOKJO MBEMNOCDDBC, HMPLNBAPPNE EBOOFBMGNDI)
	{
		byte[] array = EBOOFBMGNDI.CGMFKLNEDAP();
		try
		{
			MBEMNOCDDBC.HFMNBFOAPOP.IENFDPCIFNJ = KINEBFNENMB.JOAILMIJAHC(MBEMNOCDDBC, array);
		}
		finally
		{
			if (array != null)
			{
				NOGCEBKPPJE.MEBLOMPDLEJ(array, 0);
			}
		}
	}

	protected internal static byte[] EBJDALPFDKD(CGDEGBGOKJO MBEMNOCDDBC, KKMFHDBDNLF EOPGFGOFODJ, byte[] FOLHCIJCIOC)
	{
		BJLAMONNNDD bJLAMONNNDD = EOPGFGOFODJ.IFHHBFPJJHN();
		if (FOLHCIJCIOC != null && KINEBFNENMB.NFEADLBGDGE(MBEMNOCDDBC))
		{
			bJLAMONNNDD.GONEEEFEDGF(FOLHCIJCIOC, 0, FOLHCIJCIOC.Length);
		}
		return KDDIIEMIPKF.LCNOFBMOHHM(bJLAMONNNDD);
	}

	protected internal static IDictionary JAOKJFGCGBB(MemoryStream MOPCLEEGDFB)
	{
		if (MOPCLEEGDFB.Position >= MOPCLEEGDFB.Length)
		{
			return null;
		}
		byte[] buffer = KINEBFNENMB.HDGCNMILKAA(MOPCLEEGDFB);
		JILHFDBGNGE(MOPCLEEGDFB);
		MemoryStream memoryStream = new MemoryStream(buffer, false);
		IDictionary dictionary = LHFGHNFJIKM.JBEOCJEMGCE();
		while (memoryStream.Position < memoryStream.Length)
		{
			int num = KINEBFNENMB.DMHJEBHACNN(memoryStream);
			byte[] value = KINEBFNENMB.HDGCNMILKAA(memoryStream);
			if (dictionary.Contains(num))
			{
				throw new DEIDBCPPCMB(47);
			}
			dictionary.Add(num, value);
		}
		return dictionary;
	}

	protected internal static IList MDHJKJEAHOE(MemoryStream MOPCLEEGDFB)
	{
		byte[] buffer = KINEBFNENMB.MCBPCLGJPGF(MOPCLEEGDFB);
		JILHFDBGNGE(MOPCLEEGDFB);
		MemoryStream memoryStream = new MemoryStream(buffer, false);
		IList list = LHFGHNFJIKM.PPPFFFBMGML();
		while (memoryStream.Position < memoryStream.Length)
		{
			int dGFHOJEJLKG = KINEBFNENMB.DMHJEBHACNN(memoryStream);
			byte[] mBBPBGHKLJM = KINEBFNENMB.HDGCNMILKAA(memoryStream);
			list.Add(new ODKEDJOOPPK(dGFHOJEJLKG, mBBPBGHKLJM));
		}
		return list;
	}

	protected internal static void OIOOGHNFDII(Stream BILGCJNPJGJ, IDictionary GPFBAMMMLIA)
	{
		MemoryStream memoryStream = new MemoryStream();
		GDLKBEGALKA(memoryStream, GPFBAMMMLIA, true);
		GDLKBEGALKA(memoryStream, GPFBAMMMLIA, false);
		byte[] gHPCHPOHELF = memoryStream.ToArray();
		KINEBFNENMB.HIPJBHBLGEI(gHPCHPOHELF, BILGCJNPJGJ);
	}

	protected internal static void GDLKBEGALKA(Stream BILGCJNPJGJ, IDictionary GPFBAMMMLIA, bool JLCGGJJONBM)
	{
		foreach (int key in GPFBAMMMLIA.Keys)
		{
			byte[] array = (byte[])GPFBAMMMLIA[key];
			if (JLCGGJJONBM == (array.Length == 0))
			{
				KINEBFNENMB.AKGIEBIEJJL(key);
				KINEBFNENMB.PGBAOHFKNHN(key, BILGCJNPJGJ);
				KINEBFNENMB.HIPJBHBLGEI(array, BILGCJNPJGJ);
			}
		}
	}

	protected internal static void JJLNIJEOJHE(Stream BILGCJNPJGJ, IList PGLEFIHGGOM)
	{
		MemoryStream memoryStream = new MemoryStream();
		foreach (ODKEDJOOPPK item in PGLEFIHGGOM)
		{
			int pLCFEOMGCFK = item.DCNHILKFAOI;
			KINEBFNENMB.AKGIEBIEJJL(pLCFEOMGCFK);
			KINEBFNENMB.PGBAOHFKNHN(pLCFEOMGCFK, memoryStream);
			KINEBFNENMB.HIPJBHBLGEI(item.LJDLCPHOBHB, memoryStream);
		}
		byte[] gHPCHPOHELF = memoryStream.ToArray();
		KINEBFNENMB.GHMOBMODGDF(gHPCHPOHELF, BILGCJNPJGJ);
	}

	protected internal static int NGLLOCHMBIP(CGDEGBGOKJO MBEMNOCDDBC, int ANPNEODAJHA)
	{
		bool flag = KINEBFNENMB.OHGCLELCPMD(MBEMNOCDDBC);
		switch (ANPNEODAJHA)
		{
		case 59:
		case 60:
		case 61:
		case 62:
		case 63:
		case 64:
		case 103:
		case 104:
		case 105:
		case 106:
		case 107:
		case 156:
		case 158:
		case 160:
		case 162:
		case 164:
		case 168:
		case 170:
		case 172:
		case 186:
		case 187:
		case 188:
		case 189:
		case 190:
		case 191:
		case 192:
		case 193:
		case 194:
		case 195:
		case 196:
		case 197:
		case 49187:
		case 49189:
		case 49191:
		case 49193:
		case 49195:
		case 49197:
		case 49199:
		case 49201:
		case 49266:
		case 49268:
		case 49270:
		case 49272:
		case 49274:
		case 49276:
		case 49278:
		case 49280:
		case 49282:
		case 49284:
		case 49286:
		case 49288:
		case 49290:
		case 49292:
		case 49294:
		case 49296:
		case 49298:
		case 49308:
		case 49309:
		case 49310:
		case 49311:
		case 49312:
		case 49313:
		case 49314:
		case 49315:
		case 49316:
		case 49317:
		case 49318:
		case 49319:
		case 49320:
		case 49321:
		case 49322:
		case 49323:
		case 49324:
		case 49325:
		case 49326:
		case 49327:
		case 52392:
		case 52393:
		case 52394:
		case 52395:
		case 52396:
		case 52397:
		case 52398:
		case 65280:
		case 65281:
		case 65282:
		case 65283:
		case 65284:
		case 65285:
		case 65296:
		case 65297:
		case 65298:
		case 65299:
		case 65300:
		case 65301:
			if (flag)
			{
				return 1;
			}
			throw new DEIDBCPPCMB(47);
		case 157:
		case 159:
		case 161:
		case 163:
		case 165:
		case 169:
		case 171:
		case 173:
		case 49188:
		case 49190:
		case 49192:
		case 49194:
		case 49196:
		case 49198:
		case 49200:
		case 49202:
		case 49267:
		case 49269:
		case 49271:
		case 49273:
		case 49275:
		case 49277:
		case 49279:
		case 49281:
		case 49283:
		case 49285:
		case 49287:
		case 49289:
		case 49291:
		case 49293:
		case 49295:
		case 49297:
		case 49299:
			if (flag)
			{
				return 2;
			}
			throw new DEIDBCPPCMB(47);
		case 175:
		case 177:
		case 179:
		case 181:
		case 183:
		case 185:
		case 49208:
		case 49211:
		case 49301:
		case 49303:
		case 49305:
		case 49307:
			if (flag)
			{
				return 2;
			}
			return 0;
		default:
			if (flag)
			{
				return 1;
			}
			return 0;
		}
	}
}
