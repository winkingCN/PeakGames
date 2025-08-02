using System;
using System.Collections;
using Org.BouncyCastle.Math;

public abstract class BHPIABAGAPB
{
	public class DBCNNMNJOMB
	{
		protected BHPIABAGAPB ADHOAIJECKE;

		protected int FOOJPIGHMKH;

		protected EEDGOJILEDE GOCHGIFNLLN;

		protected FFPNOKBELNH AGFONDKEPFO;

		internal DBCNNMNJOMB(BHPIABAGAPB ADHOAIJECKE, int FOOJPIGHMKH, EEDGOJILEDE GOCHGIFNLLN, FFPNOKBELNH AGFONDKEPFO)
		{
			this.ADHOAIJECKE = ADHOAIJECKE;
			this.FOOJPIGHMKH = FOOJPIGHMKH;
			this.GOCHGIFNLLN = GOCHGIFNLLN;
			this.AGFONDKEPFO = AGFONDKEPFO;
		}

		public DBCNNMNJOMB BMLPMBHCNFJ(int FOOJPIGHMKH)
		{
			this.FOOJPIGHMKH = FOOJPIGHMKH;
			return this;
		}

		public DBCNNMNJOMB NABAGOHDHKP(EEDGOJILEDE GOCHGIFNLLN)
		{
			this.GOCHGIFNLLN = GOCHGIFNLLN;
			return this;
		}

		public DBCNNMNJOMB MAKECGEGLCM(FFPNOKBELNH AGFONDKEPFO)
		{
			this.AGFONDKEPFO = AGFONDKEPFO;
			return this;
		}

		public BHPIABAGAPB PLIFFMMBNPM()
		{
			if (!ADHOAIJECKE.ELIMDCKLHCJ(FOOJPIGHMKH))
			{
				throw new InvalidOperationException("unsupported coordinate system");
			}
			BHPIABAGAPB bHPIABAGAPB = ADHOAIJECKE.LNLMICLEEPK();
			if (bHPIABAGAPB == ADHOAIJECKE)
			{
				throw new InvalidOperationException("implementation returned current curve");
			}
			bHPIABAGAPB.NHKGIJJFPEK = FOOJPIGHMKH;
			bHPIABAGAPB.EGHPBBOELOA = GOCHGIFNLLN;
			bHPIABAGAPB.LEHHFADIANL = AGFONDKEPFO;
			return bHPIABAGAPB;
		}
	}

	public const int AHPBJHEGLBK = 0;

	public const int EHLPEHJGGNC = 1;

	public const int IBLADKHIIFE = 2;

	public const int IALLOKIHACG = 3;

	public const int ALBGKFPPHJN = 4;

	public const int JADIJEMBFKE = 5;

	public const int DJJGKFLILOA = 6;

	public const int BNHBOOKMBEJ = 7;

	protected readonly AGBPCEHDLOH HBGDCBEOMIO;

	protected KBINBLGGLNE CFJANGMBPML;

	protected KBINBLGGLNE MPDGCILOEML;

	protected BigInteger NNGLKCDBIBE;

	protected BigInteger LDKJJAOPAAP;

	protected int NHKGIJJFPEK;

	protected EEDGOJILEDE EGHPBBOELOA;

	protected FFPNOKBELNH LEHHFADIANL;

	public abstract int PJNLBAHOKGC { get; }

	public abstract JGAFKLGGBGF EFOLNCNGADB { get; }

	public virtual AGBPCEHDLOH LLHBLBINBOA
	{
		get
		{
			return HBGDCBEOMIO;
		}
	}

	public virtual KBINBLGGLNE JEHECJGFJEB
	{
		get
		{
			return CFJANGMBPML;
		}
	}

	public virtual KBINBLGGLNE FPKDKHJKEEF
	{
		get
		{
			return MPDGCILOEML;
		}
	}

	public virtual BigInteger BHIJCAOHDCM
	{
		get
		{
			return NNGLKCDBIBE;
		}
	}

	public virtual BigInteger PPPAFJOLKPD
	{
		get
		{
			return LDKJJAOPAAP;
		}
	}

	public virtual int DHBHKHGFIKI
	{
		get
		{
			return NHKGIJJFPEK;
		}
	}

	protected BHPIABAGAPB(AGBPCEHDLOH FCHMGNNHJAN)
	{
		HBGDCBEOMIO = FCHMGNNHJAN;
	}

	public static int[] CIIGMDMAGKG()
	{
		return new int[8] { 0, 1, 2, 3, 4, 5, 6, 7 };
	}

	public abstract KBINBLGGLNE HFENNGHNFLF(BigInteger AMFCENFNAJJ);

	public abstract bool DBFKLCPIHOI(BigInteger AMFCENFNAJJ);

	public virtual DBCNNMNJOMB DBFJMBNJPAD()
	{
		return new DBCNNMNJOMB(this, NHKGIJJFPEK, EGHPBBOELOA, LEHHFADIANL);
	}

	public virtual JGAFKLGGBGF BOHLCKHAGJO(BigInteger AMFCENFNAJJ, BigInteger CNLILOEEBOJ)
	{
		JGAFKLGGBGF jGAFKLGGBGF = IIDKCEOFIBH(AMFCENFNAJJ, CNLILOEEBOJ);
		if (!jGAFKLGGBGF.NAFCDEECGEF())
		{
			throw new ArgumentException("Invalid point coordinates");
		}
		return jGAFKLGGBGF;
	}

	public virtual JGAFKLGGBGF BOHLCKHAGJO(BigInteger AMFCENFNAJJ, BigInteger CNLILOEEBOJ, bool HPGABKNMEAG)
	{
		JGAFKLGGBGF jGAFKLGGBGF = IIDKCEOFIBH(AMFCENFNAJJ, CNLILOEEBOJ, HPGABKNMEAG);
		if (!jGAFKLGGBGF.NAFCDEECGEF())
		{
			throw new ArgumentException("Invalid point coordinates");
		}
		return jGAFKLGGBGF;
	}

	public virtual JGAFKLGGBGF IIDKCEOFIBH(BigInteger AMFCENFNAJJ, BigInteger CNLILOEEBOJ)
	{
		return IIDKCEOFIBH(AMFCENFNAJJ, CNLILOEEBOJ, false);
	}

	public virtual JGAFKLGGBGF IIDKCEOFIBH(BigInteger AMFCENFNAJJ, BigInteger CNLILOEEBOJ, bool HPGABKNMEAG)
	{
		return IMOPAOHAOAN(HFENNGHNFLF(AMFCENFNAJJ), HFENNGHNFLF(CNLILOEEBOJ), HPGABKNMEAG);
	}

	protected abstract BHPIABAGAPB LNLMICLEEPK();

	protected internal abstract JGAFKLGGBGF IMOPAOHAOAN(KBINBLGGLNE AMFCENFNAJJ, KBINBLGGLNE CNLILOEEBOJ, bool HPGABKNMEAG);

	protected internal abstract JGAFKLGGBGF IMOPAOHAOAN(KBINBLGGLNE AMFCENFNAJJ, KBINBLGGLNE CNLILOEEBOJ, KBINBLGGLNE[] IJGNIJAMCML, bool HPGABKNMEAG);

	protected virtual FFPNOKBELNH EGMDJDFBANH()
	{
		BBIBEHOGPHK bBIBEHOGPHK = EGHPBBOELOA as BBIBEHOGPHK;
		if (bBIBEHOGPHK != null)
		{
			return new KEBOFNHLGOE(this, bBIBEHOGPHK);
		}
		return new PKPHMAKJNLI();
	}

	public virtual bool ELIMDCKLHCJ(int FOOJPIGHMKH)
	{
		return FOOJPIGHMKH == 0;
	}

	public virtual LJCCHFLFGJG IBLDMGPNNBD(JGAFKLGGBGF KJPPPBMDJKG, string IOCMOCCFALN)
	{
		CFANGMOCOOL(KJPPPBMDJKG);
		lock (KJPPPBMDJKG)
		{
			IDictionary cGMGNKDNOIO = KJPPPBMDJKG.CGMGNKDNOIO;
			return (cGMGNKDNOIO != null) ? ((LJCCHFLFGJG)cGMGNKDNOIO[IOCMOCCFALN]) : null;
		}
	}

	public virtual void OOGGMOCFMHH(JGAFKLGGBGF KJPPPBMDJKG, string IOCMOCCFALN, LJCCHFLFGJG DAPLBLGNCPK)
	{
		CFANGMOCOOL(KJPPPBMDJKG);
		lock (KJPPPBMDJKG)
		{
			IDictionary dictionary = KJPPPBMDJKG.CGMGNKDNOIO;
			if (dictionary == null)
			{
				dictionary = (KJPPPBMDJKG.CGMGNKDNOIO = LHFGHNFJIKM.JBEOCJEMGCE(4));
			}
			dictionary[IOCMOCCFALN] = DAPLBLGNCPK;
		}
	}

	public virtual JGAFKLGGBGF PHDNPDCNJJA(JGAFKLGGBGF HPHBDNBJPHB)
	{
		if (this == HPHBDNBJPHB.ECFGFKNLLGH)
		{
			return HPHBDNBJPHB;
		}
		if (HPHBDNBJPHB.IFCDKFANPBO)
		{
			return EFOLNCNGADB;
		}
		HPHBDNBJPHB = HPHBDNBJPHB.MIHJHLFLHNA();
		return BOHLCKHAGJO(HPHBDNBJPHB.OBCJFNBLIPG.DOJBPIFPALJ(), HPHBDNBJPHB.LGFGMGPDEIB.DOJBPIFPALJ(), HPHBDNBJPHB.BPGGHHMMCCB);
	}

	public virtual void NPDHPEDPAPA(JGAFKLGGBGF[] JJJGMPMMJIN)
	{
		NPDHPEDPAPA(JJJGMPMMJIN, 0, JJJGMPMMJIN.Length, null);
	}

	public virtual void NPDHPEDPAPA(JGAFKLGGBGF[] JJJGMPMMJIN, int JBAJPGIAPFF, int NBEDPKHALCN, KBINBLGGLNE KGLMJGABMML)
	{
		LKNLPAEBDHP(JJJGMPMMJIN, JBAJPGIAPFF, NBEDPKHALCN);
		int num = DHBHKHGFIKI;
		if (num == 0 || num == 5)
		{
			if (KGLMJGABMML != null)
			{
				throw new ArgumentException("not valid for affine coordinates", "iso");
			}
			return;
		}
		KBINBLGGLNE[] array = new KBINBLGGLNE[NBEDPKHALCN];
		int[] array2 = new int[NBEDPKHALCN];
		int num2 = 0;
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			JGAFKLGGBGF jGAFKLGGBGF = JJJGMPMMJIN[JBAJPGIAPFF + i];
			if (jGAFKLGGBGF != null && (KGLMJGABMML != null || !jGAFKLGGBGF.OFFNNOKHJCM()))
			{
				array[num2] = jGAFKLGGBGF.NOIPJPPAFOH(0);
				array2[num2++] = JBAJPGIAPFF + i;
			}
		}
		if (num2 != 0)
		{
			KHJLHEJBLOA.BHABNEODMGI(array, 0, num2, KGLMJGABMML);
			for (int j = 0; j < num2; j++)
			{
				int num3 = array2[j];
				JJJGMPMMJIN[num3] = JJJGMPMMJIN[num3].MIHJHLFLHNA(array[j]);
			}
		}
	}

	protected virtual void CFANGMOCOOL(JGAFKLGGBGF KJPPPBMDJKG)
	{
		if (KJPPPBMDJKG == null || this != KJPPPBMDJKG.ECFGFKNLLGH)
		{
			throw new ArgumentException("must be non-null and on this curve", "point");
		}
	}

	protected virtual void LKNLPAEBDHP(JGAFKLGGBGF[] JJJGMPMMJIN)
	{
		LKNLPAEBDHP(JJJGMPMMJIN, 0, JJJGMPMMJIN.Length);
	}

	protected virtual void LKNLPAEBDHP(JGAFKLGGBGF[] JJJGMPMMJIN, int JBAJPGIAPFF, int NBEDPKHALCN)
	{
		if (JJJGMPMMJIN == null)
		{
			throw new ArgumentNullException("points");
		}
		if (JBAJPGIAPFF < 0 || NBEDPKHALCN < 0 || JBAJPGIAPFF > JJJGMPMMJIN.Length - NBEDPKHALCN)
		{
			throw new ArgumentException("invalid range specified", "points");
		}
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			JGAFKLGGBGF jGAFKLGGBGF = JJJGMPMMJIN[JBAJPGIAPFF + i];
			if (jGAFKLGGBGF != null && this != jGAFKLGGBGF.ECFGFKNLLGH)
			{
				throw new ArgumentException("entries must be null or on this curve", "points");
			}
		}
	}

	public virtual bool KIFDKLPDKMD(BHPIABAGAPB CJHEIBNHNNE)
	{
		if (this == CJHEIBNHNNE)
		{
			return true;
		}
		if (CJHEIBNHNNE == null)
		{
			return false;
		}
		return LLHBLBINBOA.Equals(CJHEIBNHNNE.LLHBLBINBOA) && JEHECJGFJEB.DOJBPIFPALJ().Equals(CJHEIBNHNNE.JEHECJGFJEB.DOJBPIFPALJ()) && FPKDKHJKEEF.DOJBPIFPALJ().Equals(CJHEIBNHNNE.FPKDKHJKEEF.DOJBPIFPALJ());
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		return KIFDKLPDKMD(NEMEKIOEOLC as BHPIABAGAPB);
	}

	public override int GetHashCode()
	{
		return LLHBLBINBOA.GetHashCode() ^ MKDODBDPJII.MBBDJFKAACD(JEHECJGFJEB.DOJBPIFPALJ().GetHashCode(), 8) ^ MKDODBDPJII.MBBDJFKAACD(FPKDKHJKEEF.DOJBPIFPALJ().GetHashCode(), 16);
	}

	protected abstract JGAFKLGGBGF FMLLIJEENJJ(int ICNNEMMNLHC, BigInteger JCJOMANHEBB);

	public virtual EEDGOJILEDE JHKAENBDIGO()
	{
		return EGHPBBOELOA;
	}

	public virtual FFPNOKBELNH FMFCODCKFAE()
	{
		lock (this)
		{
			if (LEHHFADIANL == null)
			{
				LEHHFADIANL = EGMDJDFBANH();
			}
			return LEHHFADIANL;
		}
	}

	public virtual JGAFKLGGBGF BJBGPDHADCH(byte[] AJDDGHDGHDC)
	{
		JGAFKLGGBGF jGAFKLGGBGF = null;
		int num = (PJNLBAHOKGC + 7) / 8;
		byte b = AJDDGHDGHDC[0];
		switch (b)
		{
		case 0:
			if (AJDDGHDGHDC.Length != 1)
			{
				throw new ArgumentException("Incorrect length for infinity encoding", "encoded");
			}
			jGAFKLGGBGF = EFOLNCNGADB;
			break;
		case 2:
		case 3:
		{
			if (AJDDGHDGHDC.Length != num + 1)
			{
				throw new ArgumentException("Incorrect length for compressed encoding", "encoded");
			}
			int iCNNEMMNLHC = b & 1;
			BigInteger jCJOMANHEBB = new BigInteger(1, AJDDGHDGHDC, 1, num);
			jGAFKLGGBGF = FMLLIJEENJJ(iCNNEMMNLHC, jCJOMANHEBB);
			if (!jGAFKLGGBGF.CBICFFCIJPC())
			{
				throw new ArgumentException("Invalid point");
			}
			break;
		}
		case 4:
		{
			if (AJDDGHDGHDC.Length != 2 * num + 1)
			{
				throw new ArgumentException("Incorrect length for uncompressed encoding", "encoded");
			}
			BigInteger aMFCENFNAJJ2 = new BigInteger(1, AJDDGHDGHDC, 1, num);
			BigInteger cNLILOEEBOJ = new BigInteger(1, AJDDGHDGHDC, 1 + num, num);
			jGAFKLGGBGF = BOHLCKHAGJO(aMFCENFNAJJ2, cNLILOEEBOJ);
			break;
		}
		case 6:
		case 7:
		{
			if (AJDDGHDGHDC.Length != 2 * num + 1)
			{
				throw new ArgumentException("Incorrect length for hybrid encoding", "encoded");
			}
			BigInteger aMFCENFNAJJ = new BigInteger(1, AJDDGHDGHDC, 1, num);
			BigInteger bigInteger = new BigInteger(1, AJDDGHDGHDC, 1 + num, num);
			if (bigInteger.NJHNJHGDCIJ(0) != (b == 7))
			{
				throw new ArgumentException("Inconsistent Y coordinate in hybrid encoding", "encoded");
			}
			jGAFKLGGBGF = BOHLCKHAGJO(aMFCENFNAJJ, bigInteger);
			break;
		}
		default:
			throw new FormatException("Invalid point encoding " + b);
		}
		if (b != 0 && jGAFKLGGBGF.IFCDKFANPBO)
		{
			throw new ArgumentException("Invalid infinity encoding", "encoded");
		}
		return jGAFKLGGBGF;
	}
}
