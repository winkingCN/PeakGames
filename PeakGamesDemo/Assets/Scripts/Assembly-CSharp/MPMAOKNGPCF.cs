using System;
using System.Collections;
using System.Text;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Security.Certificates;

public class MPMAOKNGPCF : MNBNGFAHCJF
{
	private readonly NGNPCPDMGBC FMFABAKPMLB;

	private readonly HJOMJKFAIKH LACLBHHFANM;

	private readonly bool[] CKIGNPLFFNC;

	private bool FHLBPCKOLJA;

	private int FMDMKLBKFJP;

	public virtual NGNPCPDMGBC PJPPJAHKADA
	{
		get
		{
			return FMFABAKPMLB;
		}
	}

	public virtual bool KJKICJDADPN
	{
		get
		{
			return NAFCDEECGEF(DateTime.UtcNow);
		}
	}

	public virtual int AMEDMLOCCBG
	{
		get
		{
			return FMFABAKPMLB.AMEDMLOCCBG;
		}
	}

	public virtual BigInteger LELIDHBEDHP
	{
		get
		{
			return FMFABAKPMLB.LELIDHBEDHP.JBGOANMLBFA;
		}
	}

	public virtual HMMHEPKCKCP MCLAGHDKIOG
	{
		get
		{
			return FMFABAKPMLB.HDLJKFNEDDK;
		}
	}

	public virtual HMMHEPKCKCP HMCALMJBMKC
	{
		get
		{
			return FMFABAKPMLB.LNJLMJPFGNK;
		}
	}

	public virtual DateTime GFPHCMLDGLB
	{
		get
		{
			return FMFABAKPMLB.MMNIBJHEOKC.EMPBKDFFLFI();
		}
	}

	public virtual DateTime MCBIFNHEMMP
	{
		get
		{
			return FMFABAKPMLB.CANALEFHNCI.EMPBKDFFLFI();
		}
	}

	public virtual string HPJLBBFNBDJ
	{
		get
		{
			return FLMLLBCHPNI.LCNAJOHCAII(FMFABAKPMLB.EPJPGEHMICN.GOFDFGBGLFC);
		}
	}

	public virtual string JEKEKEKHNFM
	{
		get
		{
			return FMFABAKPMLB.EPJPGEHMICN.GOFDFGBGLFC.EEFMIHDPJPG;
		}
	}

	public virtual FJMKMKNJKOI LHMACLHPHPJ
	{
		get
		{
			return FMFABAKPMLB.LCNGICNPPPP.LHMACLHPHPJ;
		}
	}

	public virtual FJMKMKNJKOI PJFJJPCOFDB
	{
		get
		{
			return FMFABAKPMLB.LCNGICNPPPP.PJFJJPCOFDB;
		}
	}

	protected MPMAOKNGPCF()
	{
	}

	public MPMAOKNGPCF(NGNPCPDMGBC FMFABAKPMLB)
	{
		this.FMFABAKPMLB = FMFABAKPMLB;
		try
		{
			PJGIGKJFGFI pJGIGKJFGFI = NMBKKGMJOBA(new KLKJHFKJLEM("2.5.29.19"));
			if (pJGIGKJFGFI != null)
			{
				LACLBHHFANM = HJOMJKFAIKH.BJLJCGFMFOO(PIFGBCCBEPG.MEGDDHGGCFJ(pJGIGKJFGFI));
			}
		}
		catch (Exception ex)
		{
			throw new CertificateParsingException("cannot construct BasicConstraints: " + ex);
		}
		try
		{
			PJGIGKJFGFI pJGIGKJFGFI2 = NMBKKGMJOBA(new KLKJHFKJLEM("2.5.29.15"));
			if (pJGIGKJFGFI2 != null)
			{
				FJMKMKNJKOI fJMKMKNJKOI = FJMKMKNJKOI.BJLJCGFMFOO(PIFGBCCBEPG.MEGDDHGGCFJ(pJGIGKJFGFI2));
				byte[] array = fJMKMKNJKOI.MIBPLNJNEGA();
				int num = array.Length * 8 - fJMKMKNJKOI.KOHPFEHKIPK;
				CKIGNPLFFNC = new bool[(num >= 9) ? num : 9];
				for (int i = 0; i != num; i++)
				{
					CKIGNPLFFNC[i] = (array[i / 8] & (128 >> i % 8)) != 0;
				}
			}
			else
			{
				CKIGNPLFFNC = null;
			}
		}
		catch (Exception ex2)
		{
			throw new CertificateParsingException("cannot construct KeyUsage: " + ex2);
		}
	}

	public virtual bool NAFCDEECGEF(DateTime HFLODNLEGFL)
	{
		return HFLODNLEGFL.CompareTo(GFPHCMLDGLB) >= 0 && HFLODNLEGFL.CompareTo(MCBIFNHEMMP) <= 0;
	}

	public virtual void LICNFHKBMHB()
	{
		LICNFHKBMHB(DateTime.UtcNow);
	}

	public virtual void LICNFHKBMHB(DateTime HFLODNLEGFL)
	{
		if (HFLODNLEGFL.CompareTo(MCBIFNHEMMP) > 0)
		{
			throw new CertificateExpiredException("certificate expired on " + FMFABAKPMLB.CANALEFHNCI.FPLOJBLADJG());
		}
		if (HFLODNLEGFL.CompareTo(GFPHCMLDGLB) < 0)
		{
			throw new CertificateNotYetValidException("certificate not valid until " + FMFABAKPMLB.MMNIBJHEOKC.FPLOJBLADJG());
		}
	}

	public virtual byte[] DNJENHMBOGJ()
	{
		return FMFABAKPMLB.LCNGICNPPPP.KMBJLPOKIAC();
	}

	public virtual byte[] GMEMALOEKHM()
	{
		return FMFABAKPMLB.BKNINFICFPF();
	}

	public virtual byte[] BKPMFEAMCFK()
	{
		if (FMFABAKPMLB.EPJPGEHMICN.KPJHHAAOFOH != null)
		{
			return FMFABAKPMLB.EPJPGEHMICN.KPJHHAAOFOH.KMBJLPOKIAC();
		}
		return null;
	}

	public virtual bool[] LIBMAOLBLEE()
	{
		return (CKIGNPLFFNC != null) ? ((bool[])CKIGNPLFFNC.Clone()) : null;
	}

	public virtual IList KOOLKOKBENB()
	{
		PJGIGKJFGFI pJGIGKJFGFI = NMBKKGMJOBA(new KLKJHFKJLEM("2.5.29.37"));
		if (pJGIGKJFGFI == null)
		{
			return null;
		}
		try
		{
			ALLINHNNNJN aLLINHNNNJN = ALLINHNNNJN.BJLJCGFMFOO(PIFGBCCBEPG.MEGDDHGGCFJ(pJGIGKJFGFI));
			IList list = LHFGHNFJIKM.PPPFFFBMGML();
			foreach (KLKJHFKJLEM item in aLLINHNNNJN)
			{
				list.Add(item.EEFMIHDPJPG);
			}
			return list;
		}
		catch (Exception fGDHECKFFDP)
		{
			throw new CertificateParsingException("error processing extended key usage extension", fGDHECKFFDP);
		}
	}

	public virtual int DNBICEIFIBG()
	{
		if (LACLBHHFANM != null && LACLBHHFANM.GOIBKHNKGED())
		{
			if (LACLBHHFANM.PMLJMLAPMJD == null)
			{
				return int.MaxValue;
			}
			return LACLBHHFANM.PMLJMLAPMJD.IntValue;
		}
		return -1;
	}

	public virtual ICollection GLKGAHALPAD()
	{
		return NNDEHGLFHLF("2.5.29.17");
	}

	public virtual ICollection BNEAMPGPENK()
	{
		return NNDEHGLFHLF("2.5.29.18");
	}

	protected virtual ICollection NNDEHGLFHLF(string GDFLIKNMBCL)
	{
		PJGIGKJFGFI pJGIGKJFGFI = NMBKKGMJOBA(new KLKJHFKJLEM(GDFLIKNMBCL));
		if (pJGIGKJFGFI == null)
		{
			return null;
		}
		EDOEBJJFOBM nEMEKIOEOLC = PIFGBCCBEPG.MEGDDHGGCFJ(pJGIGKJFGFI);
		MCPMNHLFDME mCPMNHLFDME = MCPMNHLFDME.BJLJCGFMFOO(nEMEKIOEOLC);
		IList list = LHFGHNFJIKM.PPPFFFBMGML();
		GGHMCHAHOCN[] array = mCPMNHLFDME.IHJHGEPHIOI();
		foreach (GGHMCHAHOCN gGHMCHAHOCN in array)
		{
			IList list2 = LHFGHNFJIKM.PPPFFFBMGML();
			list2.Add(gGHMCHAHOCN.JPBIKBDCEKC);
			list2.Add(gGHMCHAHOCN.PNGPLGHKFDI.ToString());
			list.Add(list2);
		}
		return list;
	}

	protected override HLAHBGANIKK AGCFPJCKBCI()
	{
		return (FMFABAKPMLB.AMEDMLOCCBG < 3) ? null : FMFABAKPMLB.LCNGICNPPPP.GBGIDCHPICA;
	}

	public virtual COEMJAGOFJJ DGEOLGIDGFE()
	{
		return JHGHHFDFJEG.HCBKCKKDGCP(FMFABAKPMLB.KBGJHCMPCGH);
	}

	public virtual byte[] PPCPBIEGJKM()
	{
		return FMFABAKPMLB.KMBJLPOKIAC();
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == this)
		{
			return true;
		}
		MPMAOKNGPCF mPMAOKNGPCF = NEMEKIOEOLC as MPMAOKNGPCF;
		if (mPMAOKNGPCF == null)
		{
			return false;
		}
		return FMFABAKPMLB.Equals(mPMAOKNGPCF.FMFABAKPMLB);
	}

	public override int GetHashCode()
	{
		lock (this)
		{
			if (!FHLBPCKOLJA)
			{
				FMDMKLBKFJP = FMFABAKPMLB.GetHashCode();
				FHLBPCKOLJA = true;
			}
		}
		return FMDMKLBKFJP;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		string iAHDCIONPPF = LHFGHNFJIKM.IAHDCIONPPF;
		stringBuilder.Append("  [0]         Version: ").Append(AMEDMLOCCBG).Append(iAHDCIONPPF);
		stringBuilder.Append("         SerialNumber: ").Append(LELIDHBEDHP).Append(iAHDCIONPPF);
		stringBuilder.Append("             IssuerDN: ").Append(MCLAGHDKIOG).Append(iAHDCIONPPF);
		stringBuilder.Append("           Start Date: ").Append(GFPHCMLDGLB).Append(iAHDCIONPPF);
		stringBuilder.Append("           Final Date: ").Append(MCBIFNHEMMP).Append(iAHDCIONPPF);
		stringBuilder.Append("            SubjectDN: ").Append(HMCALMJBMKC).Append(iAHDCIONPPF);
		stringBuilder.Append("           Public Key: ").Append(DGEOLGIDGFE()).Append(iAHDCIONPPF);
		stringBuilder.Append("  Signature Algorithm: ").Append(HPJLBBFNBDJ).Append(iAHDCIONPPF);
		byte[] array = GMEMALOEKHM();
		stringBuilder.Append("            Signature: ").Append(DCDJMDOEKHC.ALIGGGKEJEN(array, 0, 20)).Append(iAHDCIONPPF);
		for (int i = 20; i < array.Length; i += 20)
		{
			int eOFAGACBNFP = Math.Min(20, array.Length - i);
			stringBuilder.Append("                       ").Append(DCDJMDOEKHC.ALIGGGKEJEN(array, i, eOFAGACBNFP)).Append(iAHDCIONPPF);
		}
		HLAHBGANIKK hLAHBGANIKK = FMFABAKPMLB.LCNGICNPPPP.GBGIDCHPICA;
		if (hLAHBGANIKK != null)
		{
			IEnumerator enumerator = hLAHBGANIKK.OCIDJJFCKOB.GetEnumerator();
			if (enumerator.MoveNext())
			{
				stringBuilder.Append("       Extensions: \n");
			}
			do
			{
				KLKJHFKJLEM kLKJHFKJLEM = (KLKJHFKJLEM)enumerator.Current;
				BJHANHIGLGB bJHANHIGLGB = hLAHBGANIKK.GLMCDHHLBOB(kLKJHFKJLEM);
				if (bJHANHIGLGB.JBGOANMLBFA != null)
				{
					byte[] mBBPBGHKLJM = bJHANHIGLGB.JBGOANMLBFA.KLHNEKMCKKI();
					EDOEBJJFOBM eDOEBJJFOBM = EDOEBJJFOBM.HPDCKMOPEMM(mBBPBGHKLJM);
					stringBuilder.Append("                       critical(").Append(bJHANHIGLGB.JFCNIPIMMAL).Append(") ");
					try
					{
						if (kLKJHFKJLEM.Equals(HLAHBGANIKK.KPKNGFLECBB))
						{
							stringBuilder.Append(HJOMJKFAIKH.BJLJCGFMFOO(eDOEBJJFOBM));
						}
						else if (kLKJHFKJLEM.Equals(HLAHBGANIKK.CCBGCJNNMEA))
						{
							stringBuilder.Append(MNKJKHEBBOA.BJLJCGFMFOO(eDOEBJJFOBM));
						}
						else if (kLKJHFKJLEM.Equals(HLKNPKHFGOH.AJMECFJFFAD))
						{
							stringBuilder.Append(new MADJEKNNBHI((FJMKMKNJKOI)eDOEBJJFOBM));
						}
						else if (kLKJHFKJLEM.Equals(HLKNPKHFGOH.OAILILGOANG))
						{
							stringBuilder.Append(new HHFMFECAFHB((KCKEFHLLGIO)eDOEBJJFOBM));
						}
						else if (kLKJHFKJLEM.Equals(HLKNPKHFGOH.PEKDIEJCAJK))
						{
							stringBuilder.Append(new PGKPBAHPGHG((KCKEFHLLGIO)eDOEBJJFOBM));
						}
						else
						{
							stringBuilder.Append(kLKJHFKJLEM.EEFMIHDPJPG);
							stringBuilder.Append(" value = ").Append(CIOOBJICIFI.AOLOOAAFAIH(eDOEBJJFOBM));
						}
					}
					catch (Exception)
					{
						stringBuilder.Append(kLKJHFKJLEM.EEFMIHDPJPG);
						stringBuilder.Append(" value = ").Append("*****");
					}
				}
				stringBuilder.Append(iAHDCIONPPF);
			}
			while (enumerator.MoveNext());
		}
		return stringBuilder.ToString();
	}

	public virtual void GALFIOKAGHG(COEMJAGOFJJ IKNCPEPOKGJ)
	{
		ENGKMFIBOPI(new COBAFBMKAJE(FMFABAKPMLB.EPJPGEHMICN, IKNCPEPOKGJ));
	}

	public virtual void GALFIOKAGHG(KHBOIMGJNEN OBEFMOCFLGL)
	{
		ENGKMFIBOPI(OBEFMOCFLGL.POKFAOGOBOF(FMFABAKPMLB.EPJPGEHMICN));
	}

	protected virtual void ENGKMFIBOPI(KCBOLLFKMGG IAIDLMNHKBC)
	{
		if (!NNNGEOOFJGA(FMFABAKPMLB.EPJPGEHMICN, FMFABAKPMLB.LCNGICNPPPP.ACMDKLDPDLB))
		{
			throw new CertificateException("signature algorithm in TBS cert not same as outer cert");
		}
		DPGEGPIMHCH dPGEGPIMHCH = IAIDLMNHKBC.GBNGIELMFLJ();
		byte[] array = DNJENHMBOGJ();
		dPGEGPIMHCH.LCEEJHJNOCD.Write(array, 0, array.Length);
		LHFGHNFJIKM.PCHCAFHEJJM(dPGEGPIMHCH.LCEEJHJNOCD);
		if (!((FOFMEDAGLBG)dPGEGPIMHCH.ELFLJFDONFC()).LJILJHPCBNM(GMEMALOEKHM()))
		{
			throw new InvalidKeyException("Public key presented not for certificate signature");
		}
	}

	private static bool NNNGEOOFJGA(COCECKPDIKC NMNDMLPDBMJ, COCECKPDIKC PJJGGCLBGBA)
	{
		if (!NMNDMLPDBMJ.GOFDFGBGLFC.Equals(PJJGGCLBGBA.GOFDFGBGLFC))
		{
			return false;
		}
		LNKPCJLANAO lNKPCJLANAO = NMNDMLPDBMJ.KPJHHAAOFOH;
		LNKPCJLANAO lNKPCJLANAO2 = PJJGGCLBGBA.KPJHHAAOFOH;
		if (lNKPCJLANAO == null == (lNKPCJLANAO2 == null))
		{
			return object.Equals(lNKPCJLANAO, lNKPCJLANAO2);
		}
		return (lNKPCJLANAO != null) ? (lNKPCJLANAO.IIHKEACDNID() is OIONBALGCNP) : (lNKPCJLANAO2.IIHKEACDNID() is OIONBALGCNP);
	}
}
