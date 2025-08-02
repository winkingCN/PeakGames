using System;
using System.Collections;
using System.Text;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security.Certificates;

public class IMPOKNMAFGA : MNBNGFAHCJF
{
	private FNPNLKNFAMA FMFABAKPMLB;

	private bool NDOPBIKFIFI;

	private HMMHEPKCKCP DOGGGHINOFJ;

	private HMMHEPKCKCP OAOEGGEGIKI;

	public BigInteger LELIDHBEDHP
	{
		get
		{
			return FMFABAKPMLB.OCKLOHPFNKG.JBGOANMLBFA;
		}
	}

	public DateTime FHNDBMIJJJF
	{
		get
		{
			return FMFABAKPMLB.FHNDBMIJJJF.EMPBKDFFLFI();
		}
	}

	public bool MPGOINGJJIO
	{
		get
		{
			return FMFABAKPMLB.GBGIDCHPICA != null;
		}
	}

	public IMPOKNMAFGA(FNPNLKNFAMA FMFABAKPMLB)
	{
		this.FMFABAKPMLB = FMFABAKPMLB;
		OAOEGGEGIKI = AKNPONCELKA();
	}

	public IMPOKNMAFGA(FNPNLKNFAMA FMFABAKPMLB, bool NDOPBIKFIFI, HMMHEPKCKCP DOGGGHINOFJ)
	{
		this.FMFABAKPMLB = FMFABAKPMLB;
		this.NDOPBIKFIFI = NDOPBIKFIFI;
		this.DOGGGHINOFJ = DOGGGHINOFJ;
		OAOEGGEGIKI = AKNPONCELKA();
	}

	private HMMHEPKCKCP AKNPONCELKA()
	{
		if (!NDOPBIKFIFI)
		{
			return null;
		}
		PJGIGKJFGFI pJGIGKJFGFI = NMBKKGMJOBA(HLAHBGANIKK.EHEFIEOAIFF);
		if (pJGIGKJFGFI == null)
		{
			return DOGGGHINOFJ;
		}
		try
		{
			GGHMCHAHOCN[] array = MCPMNHLFDME.BJLJCGFMFOO(PIFGBCCBEPG.MEGDDHGGCFJ(pJGIGKJFGFI)).IHJHGEPHIOI();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].JPBIKBDCEKC == 4)
				{
					return HMMHEPKCKCP.BJLJCGFMFOO(array[i].PNGPLGHKFDI);
				}
			}
		}
		catch (Exception)
		{
		}
		return null;
	}

	public HMMHEPKCKCP NDNPIDCKMBH()
	{
		return OAOEGGEGIKI;
	}

	protected override HLAHBGANIKK AGCFPJCKBCI()
	{
		return FMFABAKPMLB.GBGIDCHPICA;
	}

	public byte[] PPCPBIEGJKM()
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

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		string iAHDCIONPPF = LHFGHNFJIKM.IAHDCIONPPF;
		stringBuilder.Append("        userCertificate: ").Append(LELIDHBEDHP).Append(iAHDCIONPPF);
		stringBuilder.Append("         revocationDate: ").Append(FHNDBMIJJJF).Append(iAHDCIONPPF);
		stringBuilder.Append("      certificateIssuer: ").Append(NDNPIDCKMBH()).Append(iAHDCIONPPF);
		HLAHBGANIKK hLAHBGANIKK = FMFABAKPMLB.GBGIDCHPICA;
		if (hLAHBGANIKK != null)
		{
			IEnumerator enumerator = hLAHBGANIKK.OCIDJJFCKOB.GetEnumerator();
			if (enumerator.MoveNext())
			{
				stringBuilder.Append("   crlEntryExtensions:").Append(iAHDCIONPPF);
				do
				{
					KLKJHFKJLEM kLKJHFKJLEM = (KLKJHFKJLEM)enumerator.Current;
					BJHANHIGLGB bJHANHIGLGB = hLAHBGANIKK.GLMCDHHLBOB(kLKJHFKJLEM);
					if (bJHANHIGLGB.JBGOANMLBFA != null)
					{
						EDOEBJJFOBM eDOEBJJFOBM = EDOEBJJFOBM.HPDCKMOPEMM(bJHANHIGLGB.JBGOANMLBFA.KLHNEKMCKKI());
						stringBuilder.Append("                       critical(").Append(bJHANHIGLGB.JFCNIPIMMAL).Append(") ");
						try
						{
							if (kLKJHFKJLEM.Equals(HLAHBGANIKK.BAMIEHOIKJK))
							{
								stringBuilder.Append(new POKNIFKGIOJ(DLICBBHNDFH.BJLJCGFMFOO(eDOEBJJFOBM)));
							}
							else if (kLKJHFKJLEM.Equals(HLAHBGANIKK.EHEFIEOAIFF))
							{
								stringBuilder.Append("Certificate issuer: ").Append(MCPMNHLFDME.BJLJCGFMFOO((ALLINHNNNJN)eDOEBJJFOBM));
							}
							else
							{
								stringBuilder.Append(kLKJHFKJLEM.EEFMIHDPJPG);
								stringBuilder.Append(" value = ").Append(CIOOBJICIFI.AOLOOAAFAIH(eDOEBJJFOBM));
							}
							stringBuilder.Append(iAHDCIONPPF);
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
		}
		return stringBuilder.ToString();
	}
}
