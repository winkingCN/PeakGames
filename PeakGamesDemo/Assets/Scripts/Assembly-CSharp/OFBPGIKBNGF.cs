using System;
using System.Collections;
using System.Text;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Security.Certificates;

public class OFBPGIKBNGF : MNBNGFAHCJF
{
	private readonly MEJFHBGOPAE FMFABAKPMLB;

	private readonly string EEFPLEKMPPO;

	private readonly byte[] MMJCKLPLFDK;

	private readonly bool NDOPBIKFIFI;

	public virtual int AMEDMLOCCBG
	{
		get
		{
			return FMFABAKPMLB.AMEDMLOCCBG;
		}
	}

	public virtual HMMHEPKCKCP MCLAGHDKIOG
	{
		get
		{
			return FMFABAKPMLB.HDLJKFNEDDK;
		}
	}

	public virtual DateTime NIFOIJHFKBA
	{
		get
		{
			return FMFABAKPMLB.NIFOIJHFKBA.EMPBKDFFLFI();
		}
	}

	public virtual FFFNEHOKHFO BLEHAGOOGEJ
	{
		get
		{
			return (FMFABAKPMLB.BLEHAGOOGEJ != null) ? new FFFNEHOKHFO(FMFABAKPMLB.BLEHAGOOGEJ.EMPBKDFFLFI()) : null;
		}
	}

	public virtual string HPJLBBFNBDJ
	{
		get
		{
			return EEFPLEKMPPO;
		}
	}

	public virtual string JEKEKEKHNFM
	{
		get
		{
			return FMFABAKPMLB.EPJPGEHMICN.GOFDFGBGLFC.EEFMIHDPJPG;
		}
	}

	protected virtual bool KBKDMCLPFBJ
	{
		get
		{
			PJGIGKJFGFI pJGIGKJFGFI = NMBKKGMJOBA(HLAHBGANIKK.FJIPBEMCOAP);
			bool result = false;
			try
			{
				if (pJGIGKJFGFI != null)
				{
					result = LBLHMEIMNED.BJLJCGFMFOO(PIFGBCCBEPG.MEGDDHGGCFJ(pJGIGKJFGFI)).KBKDMCLPFBJ;
				}
			}
			catch (Exception ex)
			{
				throw new CrlException("Exception reading IssuingDistributionPoint" + ex);
			}
			return result;
		}
	}

	public OFBPGIKBNGF(MEJFHBGOPAE FMFABAKPMLB)
	{
		this.FMFABAKPMLB = FMFABAKPMLB;
		try
		{
			EEFPLEKMPPO = MICLEIODIAH.PPPAACNJBIC(FMFABAKPMLB.EPJPGEHMICN);
			if (FMFABAKPMLB.EPJPGEHMICN.KPJHHAAOFOH != null)
			{
				MMJCKLPLFDK = FMFABAKPMLB.EPJPGEHMICN.KPJHHAAOFOH.KMBJLPOKIAC();
			}
			else
			{
				MMJCKLPLFDK = null;
			}
			NDOPBIKFIFI = KBKDMCLPFBJ;
		}
		catch (Exception ex)
		{
			throw new CrlException("CRL contents invalid: " + ex);
		}
	}

	protected override HLAHBGANIKK AGCFPJCKBCI()
	{
		return (FMFABAKPMLB.AMEDMLOCCBG < 2) ? null : FMFABAKPMLB.IGNPDBBGGIG.GBGIDCHPICA;
	}

	public virtual byte[] PPCPBIEGJKM()
	{
		try
		{
			return FMFABAKPMLB.KMBJLPOKIAC();
		}
		catch (Exception ex)
		{
			throw new CrlException(ex.ToString());
		}
	}

	public virtual void GALFIOKAGHG(COEMJAGOFJJ ECPKCNOAOAJ)
	{
		GALFIOKAGHG(new JBLIFDPAJGO(ECPKCNOAOAJ));
	}

	public virtual void GALFIOKAGHG(KHBOIMGJNEN OBEFMOCFLGL)
	{
		ENGKMFIBOPI(OBEFMOCFLGL.POKFAOGOBOF(FMFABAKPMLB.EPJPGEHMICN));
	}

	protected virtual void ENGKMFIBOPI(KCBOLLFKMGG IAIDLMNHKBC)
	{
		if (!FMFABAKPMLB.EPJPGEHMICN.Equals(FMFABAKPMLB.IGNPDBBGGIG.ACMDKLDPDLB))
		{
			throw new CrlException("Signature algorithm on CertificateList does not match TbsCertList.");
		}
		DPGEGPIMHCH dPGEGPIMHCH = IAIDLMNHKBC.GBNGIELMFLJ();
		byte[] array = JKBCPHMJJDJ();
		dPGEGPIMHCH.LCEEJHJNOCD.Write(array, 0, array.Length);
		LHFGHNFJIKM.PCHCAFHEJJM(dPGEGPIMHCH.LCEEJHJNOCD);
		if (!((FOFMEDAGLBG)dPGEGPIMHCH.ELFLJFDONFC()).LJILJHPCBNM(GMEMALOEKHM()))
		{
			throw new InvalidKeyException("CRL does not verify with supplied public key.");
		}
	}

	private LKBPEOBFKMJ FGIDEONJNMM()
	{
		LKBPEOBFKMJ lKBPEOBFKMJ = new DMAOKHPCPIA();
		IEnumerable enumerable = FMFABAKPMLB.FLLBPMOPGJI();
		HMMHEPKCKCP dOGGGHINOFJ = MCLAGHDKIOG;
		foreach (FNPNLKNFAMA item in enumerable)
		{
			IMPOKNMAFGA iMPOKNMAFGA = new IMPOKNMAFGA(item, NDOPBIKFIFI, dOGGGHINOFJ);
			lKBPEOBFKMJ.JEACJNAKLDJ(iMPOKNMAFGA);
			dOGGGHINOFJ = iMPOKNMAFGA.NDNPIDCKMBH();
		}
		return lKBPEOBFKMJ;
	}

	public virtual IMPOKNMAFGA LFJEGDGHDPF(BigInteger JPGILNKJPDN)
	{
		IEnumerable enumerable = FMFABAKPMLB.FLLBPMOPGJI();
		HMMHEPKCKCP dOGGGHINOFJ = MCLAGHDKIOG;
		foreach (FNPNLKNFAMA item in enumerable)
		{
			IMPOKNMAFGA iMPOKNMAFGA = new IMPOKNMAFGA(item, NDOPBIKFIFI, dOGGGHINOFJ);
			if (JPGILNKJPDN.Equals(item.OCKLOHPFNKG.JBGOANMLBFA))
			{
				return iMPOKNMAFGA;
			}
			dOGGGHINOFJ = iMPOKNMAFGA.NDNPIDCKMBH();
		}
		return null;
	}

	public virtual LKBPEOBFKMJ OJNDIHEEKJK()
	{
		LKBPEOBFKMJ lKBPEOBFKMJ = FGIDEONJNMM();
		if (lKBPEOBFKMJ.Count > 0)
		{
			return lKBPEOBFKMJ;
		}
		return null;
	}

	public virtual byte[] JKBCPHMJJDJ()
	{
		try
		{
			return FMFABAKPMLB.IGNPDBBGGIG.KMBJLPOKIAC();
		}
		catch (Exception ex)
		{
			throw new CrlException(ex.ToString());
		}
	}

	public virtual byte[] GMEMALOEKHM()
	{
		return FMFABAKPMLB.BKNINFICFPF();
	}

	public virtual byte[] BKPMFEAMCFK()
	{
		return NOGCEBKPPJE.IKBFGGABMKP(MMJCKLPLFDK);
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		if (NEMEKIOEOLC == this)
		{
			return true;
		}
		OFBPGIKBNGF oFBPGIKBNGF = NEMEKIOEOLC as OFBPGIKBNGF;
		if (oFBPGIKBNGF == null)
		{
			return false;
		}
		return FMFABAKPMLB.Equals(oFBPGIKBNGF.FMFABAKPMLB);
	}

	public override int GetHashCode()
	{
		return FMFABAKPMLB.GetHashCode();
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		string iAHDCIONPPF = LHFGHNFJIKM.IAHDCIONPPF;
		stringBuilder.Append("              Version: ").Append(AMEDMLOCCBG).Append(iAHDCIONPPF);
		stringBuilder.Append("             IssuerDN: ").Append(MCLAGHDKIOG).Append(iAHDCIONPPF);
		stringBuilder.Append("          This update: ").Append(NIFOIJHFKBA).Append(iAHDCIONPPF);
		stringBuilder.Append("          Next update: ").Append(BLEHAGOOGEJ).Append(iAHDCIONPPF);
		stringBuilder.Append("  Signature Algorithm: ").Append(HPJLBBFNBDJ).Append(iAHDCIONPPF);
		byte[] array = GMEMALOEKHM();
		stringBuilder.Append("            Signature: ");
		stringBuilder.Append(DCDJMDOEKHC.ALIGGGKEJEN(array, 0, 20)).Append(iAHDCIONPPF);
		for (int i = 20; i < array.Length; i += 20)
		{
			int eOFAGACBNFP = Math.Min(20, array.Length - i);
			stringBuilder.Append("                       ");
			stringBuilder.Append(DCDJMDOEKHC.ALIGGGKEJEN(array, i, eOFAGACBNFP)).Append(iAHDCIONPPF);
		}
		HLAHBGANIKK hLAHBGANIKK = FMFABAKPMLB.IGNPDBBGGIG.GBGIDCHPICA;
		if (hLAHBGANIKK != null)
		{
			IEnumerator enumerator = hLAHBGANIKK.OCIDJJFCKOB.GetEnumerator();
			if (enumerator.MoveNext())
			{
				stringBuilder.Append("           Extensions: ").Append(iAHDCIONPPF);
			}
			do
			{
				KLKJHFKJLEM kLKJHFKJLEM = (KLKJHFKJLEM)enumerator.Current;
				BJHANHIGLGB bJHANHIGLGB = hLAHBGANIKK.GLMCDHHLBOB(kLKJHFKJLEM);
				if (bJHANHIGLGB.JBGOANMLBFA != null)
				{
					EDOEBJJFOBM eDOEBJJFOBM = PIFGBCCBEPG.MEGDDHGGCFJ(bJHANHIGLGB.JBGOANMLBFA);
					stringBuilder.Append("                       critical(").Append(bJHANHIGLGB.JFCNIPIMMAL).Append(") ");
					try
					{
						if (kLKJHFKJLEM.Equals(HLAHBGANIKK.IGBJHKHBGKP))
						{
							stringBuilder.Append(new GIHFAIFIMEK(GLFDIPNOLKN.BJLJCGFMFOO(eDOEBJJFOBM).DMPHAJNKNKB)).Append(iAHDCIONPPF);
							continue;
						}
						if (kLKJHFKJLEM.Equals(HLAHBGANIKK.LLHEPAKIEEI))
						{
							stringBuilder.Append("Base CRL: " + new GIHFAIFIMEK(GLFDIPNOLKN.BJLJCGFMFOO(eDOEBJJFOBM).DMPHAJNKNKB)).Append(iAHDCIONPPF);
							continue;
						}
						if (kLKJHFKJLEM.Equals(HLAHBGANIKK.FJIPBEMCOAP))
						{
							stringBuilder.Append(LBLHMEIMNED.BJLJCGFMFOO((ALLINHNNNJN)eDOEBJJFOBM)).Append(iAHDCIONPPF);
							continue;
						}
						if (kLKJHFKJLEM.Equals(HLAHBGANIKK.HCKLHHJNABE))
						{
							stringBuilder.Append(OGCOHFIOEED.BJLJCGFMFOO((ALLINHNNNJN)eDOEBJJFOBM)).Append(iAHDCIONPPF);
							continue;
						}
						if (kLKJHFKJLEM.Equals(HLAHBGANIKK.GNFGBKBBDMD))
						{
							stringBuilder.Append(OGCOHFIOEED.BJLJCGFMFOO((ALLINHNNNJN)eDOEBJJFOBM)).Append(iAHDCIONPPF);
							continue;
						}
						stringBuilder.Append(kLKJHFKJLEM.EEFMIHDPJPG);
						stringBuilder.Append(" value = ").Append(CIOOBJICIFI.AOLOOAAFAIH(eDOEBJJFOBM)).Append(iAHDCIONPPF);
					}
					catch (Exception)
					{
						stringBuilder.Append(kLKJHFKJLEM.EEFMIHDPJPG);
						stringBuilder.Append(" value = ").Append("*****").Append(iAHDCIONPPF);
					}
				}
				else
				{
					stringBuilder.Append(iAHDCIONPPF);
				}
			}
			while (enumerator.MoveNext());
		}
		LKBPEOBFKMJ lKBPEOBFKMJ = OJNDIHEEKJK();
		if (lKBPEOBFKMJ != null)
		{
			foreach (IMPOKNMAFGA item in lKBPEOBFKMJ)
			{
				stringBuilder.Append(item);
				stringBuilder.Append(iAHDCIONPPF);
			}
		}
		return stringBuilder.ToString();
	}

	public virtual bool ICGMAMKEBCH(MPMAOKNGPCF DDNIHGOJJGC)
	{
		FNPNLKNFAMA[] array = FMFABAKPMLB.OJNDIHEEKJK();
		if (array != null)
		{
			BigInteger obj = DDNIHGOJJGC.LELIDHBEDHP;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].OCKLOHPFNKG.JBGOANMLBFA.Equals(obj))
				{
					return true;
				}
			}
		}
		return false;
	}
}
