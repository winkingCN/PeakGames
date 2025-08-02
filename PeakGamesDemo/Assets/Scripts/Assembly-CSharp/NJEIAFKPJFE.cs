using System;
using Org.BouncyCastle.Math;

public class NJEIAFKPJFE : KBINBLGGLNE
{
	private readonly BigInteger OKDPJHOEPBJ;

	private readonly BigInteger GPGDCCMECGF;

	private readonly BigInteger AMFCENFNAJJ;

	public override string DALLCADGMKK
	{
		get
		{
			return "Fp";
		}
	}

	public override int PJNLBAHOKGC
	{
		get
		{
			return OKDPJHOEPBJ.BitLength;
		}
	}

	public BigInteger FNPELDEHJKL
	{
		get
		{
			return OKDPJHOEPBJ;
		}
	}

	public NJEIAFKPJFE(BigInteger OKDPJHOEPBJ, BigInteger AMFCENFNAJJ)
		: this(OKDPJHOEPBJ, GGBBFNDKLPA(OKDPJHOEPBJ), AMFCENFNAJJ)
	{
	}

	internal NJEIAFKPJFE(BigInteger OKDPJHOEPBJ, BigInteger GPGDCCMECGF, BigInteger AMFCENFNAJJ)
	{
		if (AMFCENFNAJJ == null || AMFCENFNAJJ.SignValue < 0 || AMFCENFNAJJ.JLPDKNFCNPO(OKDPJHOEPBJ) >= 0)
		{
			throw new ArgumentException("value invalid in Fp field element", "x");
		}
		this.OKDPJHOEPBJ = OKDPJHOEPBJ;
		this.GPGDCCMECGF = GPGDCCMECGF;
		this.AMFCENFNAJJ = AMFCENFNAJJ;
	}

	internal static BigInteger GGBBFNDKLPA(BigInteger HPHBDNBJPHB)
	{
		int bitLength = HPHBDNBJPHB.BitLength;
		if (bitLength >= 96)
		{
			BigInteger bigInteger = HPHBDNBJPHB.ABOIOKBIANB(bitLength - 64);
			if (bigInteger.LongValue == -1)
			{
				return BigInteger.One.DOKHFLENGLF(bitLength).FBGIHKPECCO(HPHBDNBJPHB);
			}
			if ((bitLength & 7) == 0)
			{
				return BigInteger.One.DOKHFLENGLF(bitLength << 1).MCPDGENJCDB(HPHBDNBJPHB).BHKOFHMDACN();
			}
		}
		return null;
	}

	public override BigInteger DOJBPIFPALJ()
	{
		return AMFCENFNAJJ;
	}

	public override KBINBLGGLNE JEACJNAKLDJ(KBINBLGGLNE BCIHLCMFAEK)
	{
		return new NJEIAFKPJFE(OKDPJHOEPBJ, GPGDCCMECGF, LHNHACJKBEA(AMFCENFNAJJ, BCIHLCMFAEK.DOJBPIFPALJ()));
	}

	public override KBINBLGGLNE AOAINNMNBHC()
	{
		BigInteger bigInteger = AMFCENFNAJJ.JEACJNAKLDJ(BigInteger.One);
		if (bigInteger.JLPDKNFCNPO(OKDPJHOEPBJ) == 0)
		{
			bigInteger = BigInteger.Zero;
		}
		return new NJEIAFKPJFE(OKDPJHOEPBJ, GPGDCCMECGF, bigInteger);
	}

	public override KBINBLGGLNE FBGIHKPECCO(KBINBLGGLNE BCIHLCMFAEK)
	{
		return new NJEIAFKPJFE(OKDPJHOEPBJ, GPGDCCMECGF, AHMEGKMJJEI(AMFCENFNAJJ, BCIHLCMFAEK.DOJBPIFPALJ()));
	}

	public override KBINBLGGLNE IBJBIGNPNEM(KBINBLGGLNE BCIHLCMFAEK)
	{
		return new NJEIAFKPJFE(OKDPJHOEPBJ, GPGDCCMECGF, PMBBDCCINDD(AMFCENFNAJJ, BCIHLCMFAEK.DOJBPIFPALJ()));
	}

	public override KBINBLGGLNE MEBMJLIHOEJ(KBINBLGGLNE BCIHLCMFAEK, KBINBLGGLNE AMFCENFNAJJ, KBINBLGGLNE CNLILOEEBOJ)
	{
		BigInteger aMFCENFNAJJ = this.AMFCENFNAJJ;
		BigInteger hIMINGHNIKN = BCIHLCMFAEK.DOJBPIFPALJ();
		BigInteger bigInteger = AMFCENFNAJJ.DOJBPIFPALJ();
		BigInteger hIMINGHNIKN2 = CNLILOEEBOJ.DOJBPIFPALJ();
		BigInteger bigInteger2 = aMFCENFNAJJ.IBJBIGNPNEM(hIMINGHNIKN);
		BigInteger iDHLPOFDLKJ = bigInteger.IBJBIGNPNEM(hIMINGHNIKN2);
		return new NJEIAFKPJFE(OKDPJHOEPBJ, GPGDCCMECGF, JDFEMDLEJGP(bigInteger2.FBGIHKPECCO(iDHLPOFDLKJ)));
	}

	public override KBINBLGGLNE CIDGMJAFLHM(KBINBLGGLNE BCIHLCMFAEK, KBINBLGGLNE AMFCENFNAJJ, KBINBLGGLNE CNLILOEEBOJ)
	{
		BigInteger aMFCENFNAJJ = this.AMFCENFNAJJ;
		BigInteger hIMINGHNIKN = BCIHLCMFAEK.DOJBPIFPALJ();
		BigInteger bigInteger = AMFCENFNAJJ.DOJBPIFPALJ();
		BigInteger hIMINGHNIKN2 = CNLILOEEBOJ.DOJBPIFPALJ();
		BigInteger bigInteger2 = aMFCENFNAJJ.IBJBIGNPNEM(hIMINGHNIKN);
		BigInteger eDDNOJDPMCF = bigInteger.IBJBIGNPNEM(hIMINGHNIKN2);
		BigInteger bigInteger3 = bigInteger2.JEACJNAKLDJ(eDDNOJDPMCF);
		if (GPGDCCMECGF != null && GPGDCCMECGF.SignValue < 0 && bigInteger3.BitLength > OKDPJHOEPBJ.BitLength << 1)
		{
			bigInteger3 = bigInteger3.FBGIHKPECCO(OKDPJHOEPBJ.DOKHFLENGLF(OKDPJHOEPBJ.BitLength));
		}
		return new NJEIAFKPJFE(OKDPJHOEPBJ, GPGDCCMECGF, JDFEMDLEJGP(bigInteger3));
	}

	public override KBINBLGGLNE MCPDGENJCDB(KBINBLGGLNE BCIHLCMFAEK)
	{
		return new NJEIAFKPJFE(OKDPJHOEPBJ, GPGDCCMECGF, PMBBDCCINDD(AMFCENFNAJJ, DDENLEMHHAM(BCIHLCMFAEK.DOJBPIFPALJ())));
	}

	public override KBINBLGGLNE BHKOFHMDACN()
	{
		return (AMFCENFNAJJ.SignValue != 0) ? new NJEIAFKPJFE(OKDPJHOEPBJ, GPGDCCMECGF, OKDPJHOEPBJ.FBGIHKPECCO(AMFCENFNAJJ)) : this;
	}

	public override KBINBLGGLNE MIOEHGDPGAG()
	{
		return new NJEIAFKPJFE(OKDPJHOEPBJ, GPGDCCMECGF, PMBBDCCINDD(AMFCENFNAJJ, AMFCENFNAJJ));
	}

	public override KBINBLGGLNE NGOGEEMPMGH(KBINBLGGLNE AMFCENFNAJJ, KBINBLGGLNE CNLILOEEBOJ)
	{
		BigInteger aMFCENFNAJJ = this.AMFCENFNAJJ;
		BigInteger bigInteger = AMFCENFNAJJ.DOJBPIFPALJ();
		BigInteger hIMINGHNIKN = CNLILOEEBOJ.DOJBPIFPALJ();
		BigInteger bigInteger2 = aMFCENFNAJJ.IBJBIGNPNEM(aMFCENFNAJJ);
		BigInteger iDHLPOFDLKJ = bigInteger.IBJBIGNPNEM(hIMINGHNIKN);
		return new NJEIAFKPJFE(OKDPJHOEPBJ, GPGDCCMECGF, JDFEMDLEJGP(bigInteger2.FBGIHKPECCO(iDHLPOFDLKJ)));
	}

	public override KBINBLGGLNE FGLCIBKKKFF(KBINBLGGLNE AMFCENFNAJJ, KBINBLGGLNE CNLILOEEBOJ)
	{
		BigInteger aMFCENFNAJJ = this.AMFCENFNAJJ;
		BigInteger bigInteger = AMFCENFNAJJ.DOJBPIFPALJ();
		BigInteger hIMINGHNIKN = CNLILOEEBOJ.DOJBPIFPALJ();
		BigInteger bigInteger2 = aMFCENFNAJJ.IBJBIGNPNEM(aMFCENFNAJJ);
		BigInteger eDDNOJDPMCF = bigInteger.IBJBIGNPNEM(hIMINGHNIKN);
		BigInteger bigInteger3 = bigInteger2.JEACJNAKLDJ(eDDNOJDPMCF);
		if (GPGDCCMECGF != null && GPGDCCMECGF.SignValue < 0 && bigInteger3.BitLength > OKDPJHOEPBJ.BitLength << 1)
		{
			bigInteger3 = bigInteger3.FBGIHKPECCO(OKDPJHOEPBJ.DOKHFLENGLF(OKDPJHOEPBJ.BitLength));
		}
		return new NJEIAFKPJFE(OKDPJHOEPBJ, GPGDCCMECGF, JDFEMDLEJGP(bigInteger3));
	}

	public override KBINBLGGLNE LEIECFOMCNL()
	{
		return new NJEIAFKPJFE(OKDPJHOEPBJ, GPGDCCMECGF, DDENLEMHHAM(AMFCENFNAJJ));
	}

	public override KBINBLGGLNE PAEDNKEIDOM()
	{
		if (EJJHHCOFAAI || EOJCHPEGABD)
		{
			return this;
		}
		if (!OKDPJHOEPBJ.NJHNJHGDCIJ(0))
		{
			throw LHFGHNFJIKM.HOAJHBJIAIC("even value of q");
		}
		if (OKDPJHOEPBJ.NJHNJHGDCIJ(1))
		{
			BigInteger eKFOKNPODBK = OKDPJHOEPBJ.ABOIOKBIANB(2).JEACJNAKLDJ(BigInteger.One);
			return OLJGPCPBNNC(new NJEIAFKPJFE(OKDPJHOEPBJ, GPGDCCMECGF, AMFCENFNAJJ.ICEOCBALAGC(eKFOKNPODBK, OKDPJHOEPBJ)));
		}
		if (OKDPJHOEPBJ.NJHNJHGDCIJ(2))
		{
			BigInteger bigInteger = AMFCENFNAJJ.ICEOCBALAGC(OKDPJHOEPBJ.ABOIOKBIANB(3), OKDPJHOEPBJ);
			BigInteger bigInteger2 = PMBBDCCINDD(bigInteger, AMFCENFNAJJ);
			BigInteger bigInteger3 = PMBBDCCINDD(bigInteger2, bigInteger);
			if (bigInteger3.Equals(BigInteger.One))
			{
				return OLJGPCPBNNC(new NJEIAFKPJFE(OKDPJHOEPBJ, GPGDCCMECGF, bigInteger2));
			}
			BigInteger dPGEOPKDNPM = BigInteger.Two.ICEOCBALAGC(OKDPJHOEPBJ.ABOIOKBIANB(2), OKDPJHOEPBJ);
			BigInteger aMFCENFNAJJ = PMBBDCCINDD(bigInteger2, dPGEOPKDNPM);
			return OLJGPCPBNNC(new NJEIAFKPJFE(OKDPJHOEPBJ, GPGDCCMECGF, aMFCENFNAJJ));
		}
		BigInteger bigInteger4 = OKDPJHOEPBJ.ABOIOKBIANB(1);
		if (!AMFCENFNAJJ.ICEOCBALAGC(bigInteger4, OKDPJHOEPBJ).Equals(BigInteger.One))
		{
			return null;
		}
		BigInteger aMFCENFNAJJ2 = AMFCENFNAJJ;
		BigInteger bigInteger5 = GLEAMFIOEJD(GLEAMFIOEJD(aMFCENFNAJJ2));
		BigInteger bENKLGPHLGI = bigInteger4.JEACJNAKLDJ(BigInteger.One);
		BigInteger obj = OKDPJHOEPBJ.FBGIHKPECCO(BigInteger.One);
		while (true)
		{
			BigInteger bigInteger6 = BigInteger.HHFOMHMDAKH(OKDPJHOEPBJ.BitLength);
			if (bigInteger6.JLPDKNFCNPO(OKDPJHOEPBJ) < 0 && JDFEMDLEJGP(bigInteger6.IBJBIGNPNEM(bigInteger6).FBGIHKPECCO(bigInteger5)).ICEOCBALAGC(bigInteger4, OKDPJHOEPBJ).Equals(obj))
			{
				BigInteger[] array = HGILDLIKKPP(bigInteger6, aMFCENFNAJJ2, bENKLGPHLGI);
				BigInteger bigInteger7 = array[0];
				BigInteger bigInteger8 = array[1];
				if (PMBBDCCINDD(bigInteger8, bigInteger8).Equals(bigInteger5))
				{
					return new NJEIAFKPJFE(OKDPJHOEPBJ, GPGDCCMECGF, NPOJJOALCEJ(bigInteger8));
				}
				if (!bigInteger7.Equals(BigInteger.One) && !bigInteger7.Equals(obj))
				{
					break;
				}
			}
		}
		return null;
	}

	private KBINBLGGLNE OLJGPCPBNNC(KBINBLGGLNE IGNEOOOFEMO)
	{
		return (!IGNEOOOFEMO.MIOEHGDPGAG().KIFDKLPDKMD(this)) ? null : IGNEOOOFEMO;
	}

	private BigInteger[] HGILDLIKKPP(BigInteger MBIJHANOCOC, BigInteger FNPELDEHJKL, BigInteger BENKLGPHLGI)
	{
		int bitLength = BENKLGPHLGI.BitLength;
		int num = BENKLGPHLGI.MGJLILGHLEA();
		BigInteger bigInteger = BigInteger.One;
		BigInteger bigInteger2 = BigInteger.Two;
		BigInteger bigInteger3 = MBIJHANOCOC;
		BigInteger bigInteger4 = BigInteger.One;
		BigInteger bigInteger5 = BigInteger.One;
		for (int num2 = bitLength - 1; num2 >= num + 1; num2--)
		{
			bigInteger4 = PMBBDCCINDD(bigInteger4, bigInteger5);
			if (BENKLGPHLGI.NJHNJHGDCIJ(num2))
			{
				bigInteger5 = PMBBDCCINDD(bigInteger4, FNPELDEHJKL);
				bigInteger = PMBBDCCINDD(bigInteger, bigInteger3);
				bigInteger2 = JDFEMDLEJGP(bigInteger3.IBJBIGNPNEM(bigInteger2).FBGIHKPECCO(MBIJHANOCOC.IBJBIGNPNEM(bigInteger4)));
				bigInteger3 = JDFEMDLEJGP(bigInteger3.IBJBIGNPNEM(bigInteger3).FBGIHKPECCO(bigInteger5.DOKHFLENGLF(1)));
			}
			else
			{
				bigInteger5 = bigInteger4;
				bigInteger = JDFEMDLEJGP(bigInteger.IBJBIGNPNEM(bigInteger2).FBGIHKPECCO(bigInteger4));
				bigInteger3 = JDFEMDLEJGP(bigInteger3.IBJBIGNPNEM(bigInteger2).FBGIHKPECCO(MBIJHANOCOC.IBJBIGNPNEM(bigInteger4)));
				bigInteger2 = JDFEMDLEJGP(bigInteger2.IBJBIGNPNEM(bigInteger2).FBGIHKPECCO(bigInteger4.DOKHFLENGLF(1)));
			}
		}
		bigInteger4 = PMBBDCCINDD(bigInteger4, bigInteger5);
		bigInteger5 = PMBBDCCINDD(bigInteger4, FNPELDEHJKL);
		bigInteger = JDFEMDLEJGP(bigInteger.IBJBIGNPNEM(bigInteger2).FBGIHKPECCO(bigInteger4));
		bigInteger2 = JDFEMDLEJGP(bigInteger3.IBJBIGNPNEM(bigInteger2).FBGIHKPECCO(MBIJHANOCOC.IBJBIGNPNEM(bigInteger4)));
		bigInteger4 = PMBBDCCINDD(bigInteger4, bigInteger5);
		for (int i = 1; i <= num; i++)
		{
			bigInteger = PMBBDCCINDD(bigInteger, bigInteger2);
			bigInteger2 = JDFEMDLEJGP(bigInteger2.IBJBIGNPNEM(bigInteger2).FBGIHKPECCO(bigInteger4.DOKHFLENGLF(1)));
			bigInteger4 = PMBBDCCINDD(bigInteger4, bigInteger4);
		}
		return new BigInteger[2] { bigInteger, bigInteger2 };
	}

	protected virtual BigInteger LHNHACJKBEA(BigInteger CMJGCHCINDK, BigInteger DPGEOPKDNPM)
	{
		BigInteger bigInteger = CMJGCHCINDK.JEACJNAKLDJ(DPGEOPKDNPM);
		if (bigInteger.JLPDKNFCNPO(OKDPJHOEPBJ) >= 0)
		{
			bigInteger = bigInteger.FBGIHKPECCO(OKDPJHOEPBJ);
		}
		return bigInteger;
	}

	protected virtual BigInteger GLEAMFIOEJD(BigInteger AMFCENFNAJJ)
	{
		BigInteger bigInteger = AMFCENFNAJJ.DOKHFLENGLF(1);
		if (bigInteger.JLPDKNFCNPO(OKDPJHOEPBJ) >= 0)
		{
			bigInteger = bigInteger.FBGIHKPECCO(OKDPJHOEPBJ);
		}
		return bigInteger;
	}

	protected virtual BigInteger IJJNDGBLIDE(BigInteger AMFCENFNAJJ)
	{
		if (AMFCENFNAJJ.NJHNJHGDCIJ(0))
		{
			AMFCENFNAJJ = OKDPJHOEPBJ.JEACJNAKLDJ(AMFCENFNAJJ);
		}
		return AMFCENFNAJJ.ABOIOKBIANB(1);
	}

	protected virtual BigInteger NPOJJOALCEJ(BigInteger AMFCENFNAJJ)
	{
		if (AMFCENFNAJJ.NJHNJHGDCIJ(0))
		{
			AMFCENFNAJJ = OKDPJHOEPBJ.FBGIHKPECCO(AMFCENFNAJJ);
		}
		return AMFCENFNAJJ.ABOIOKBIANB(1);
	}

	protected virtual BigInteger DDENLEMHHAM(BigInteger AMFCENFNAJJ)
	{
		int num = PJNLBAHOKGC;
		int nBEDPKHALCN = num + 31 >> 5;
		uint[] hPHBDNBJPHB = BCMDHIIJKJE.HFENNGHNFLF(num, OKDPJHOEPBJ);
		uint[] aMFCENFNAJJ = BCMDHIIJKJE.HFENNGHNFLF(num, AMFCENFNAJJ);
		uint[] array = BCMDHIIJKJE.PLIFFMMBNPM(nBEDPKHALCN);
		JHJKFDMNDBP.LEIECFOMCNL(hPHBDNBJPHB, aMFCENFNAJJ, array);
		return BCMDHIIJKJE.DOJBPIFPALJ(nBEDPKHALCN, array);
	}

	protected virtual BigInteger PMBBDCCINDD(BigInteger CMJGCHCINDK, BigInteger DPGEOPKDNPM)
	{
		return JDFEMDLEJGP(CMJGCHCINDK.IBJBIGNPNEM(DPGEOPKDNPM));
	}

	protected virtual BigInteger JDFEMDLEJGP(BigInteger AMFCENFNAJJ)
	{
		if (GPGDCCMECGF == null)
		{
			AMFCENFNAJJ = AMFCENFNAJJ.MODIHOCEKBK(OKDPJHOEPBJ);
		}
		else
		{
			bool flag = AMFCENFNAJJ.SignValue < 0;
			if (flag)
			{
				AMFCENFNAJJ = AMFCENFNAJJ.DKGOFCBJBPB();
			}
			int bitLength = OKDPJHOEPBJ.BitLength;
			if (GPGDCCMECGF.SignValue > 0)
			{
				BigInteger iDHLPOFDLKJ = BigInteger.One.DOKHFLENGLF(bitLength);
				bool flag2 = GPGDCCMECGF.Equals(BigInteger.One);
				while (AMFCENFNAJJ.BitLength > bitLength + 1)
				{
					BigInteger bigInteger = AMFCENFNAJJ.ABOIOKBIANB(bitLength);
					BigInteger eDDNOJDPMCF = AMFCENFNAJJ.FGLDMFGEDAD(iDHLPOFDLKJ);
					if (!flag2)
					{
						bigInteger = bigInteger.IBJBIGNPNEM(GPGDCCMECGF);
					}
					AMFCENFNAJJ = bigInteger.JEACJNAKLDJ(eDDNOJDPMCF);
				}
			}
			else
			{
				int num = ((bitLength - 1) & 0x1F) + 1;
				BigInteger bigInteger2 = GPGDCCMECGF.BHKOFHMDACN();
				BigInteger bigInteger3 = bigInteger2.IBJBIGNPNEM(AMFCENFNAJJ.ABOIOKBIANB(bitLength - num));
				BigInteger bigInteger4 = bigInteger3.ABOIOKBIANB(bitLength + num);
				BigInteger bigInteger5 = bigInteger4.IBJBIGNPNEM(OKDPJHOEPBJ);
				BigInteger bigInteger6 = BigInteger.One.DOKHFLENGLF(bitLength + num);
				bigInteger5 = bigInteger5.FGLDMFGEDAD(bigInteger6);
				AMFCENFNAJJ = AMFCENFNAJJ.FGLDMFGEDAD(bigInteger6);
				AMFCENFNAJJ = AMFCENFNAJJ.FBGIHKPECCO(bigInteger5);
				if (AMFCENFNAJJ.SignValue < 0)
				{
					AMFCENFNAJJ = AMFCENFNAJJ.JEACJNAKLDJ(bigInteger6);
				}
			}
			while (AMFCENFNAJJ.JLPDKNFCNPO(OKDPJHOEPBJ) >= 0)
			{
				AMFCENFNAJJ = AMFCENFNAJJ.FBGIHKPECCO(OKDPJHOEPBJ);
			}
			if (flag && AMFCENFNAJJ.SignValue != 0)
			{
				AMFCENFNAJJ = OKDPJHOEPBJ.FBGIHKPECCO(AMFCENFNAJJ);
			}
		}
		return AMFCENFNAJJ;
	}

	protected virtual BigInteger AHMEGKMJJEI(BigInteger CMJGCHCINDK, BigInteger DPGEOPKDNPM)
	{
		BigInteger bigInteger = CMJGCHCINDK.FBGIHKPECCO(DPGEOPKDNPM);
		if (bigInteger.SignValue < 0)
		{
			bigInteger = bigInteger.JEACJNAKLDJ(OKDPJHOEPBJ);
		}
		return bigInteger;
	}

	public virtual bool KIFDKLPDKMD(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == this)
		{
			return true;
		}
		NJEIAFKPJFE nJEIAFKPJFE = NEMEKIOEOLC as NJEIAFKPJFE;
		if (nJEIAFKPJFE == null)
		{
			return false;
		}
		return KIFDKLPDKMD(nJEIAFKPJFE);
	}

	public virtual bool KIFDKLPDKMD(NJEIAFKPJFE CJHEIBNHNNE)
	{
		return OKDPJHOEPBJ.Equals(CJHEIBNHNNE.OKDPJHOEPBJ) && base.KIFDKLPDKMD(CJHEIBNHNNE);
	}

	public override int GetHashCode()
	{
		return OKDPJHOEPBJ.GetHashCode() ^ base.GetHashCode();
	}
}
