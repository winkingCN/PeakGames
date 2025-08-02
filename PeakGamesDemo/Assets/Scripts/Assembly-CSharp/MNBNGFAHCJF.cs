using System;

public abstract class MNBNGFAHCJF : GHJCJIBGEMA
{
	protected abstract HLAHBGANIKK AGCFPJCKBCI();

	protected virtual LKBPEOBFKMJ MPAJBFANLKP(bool FAGCDIIJFAB)
	{
		HLAHBGANIKK hLAHBGANIKK = AGCFPJCKBCI();
		if (hLAHBGANIKK != null)
		{
			DMAOKHPCPIA dMAOKHPCPIA = new DMAOKHPCPIA();
			{
				foreach (KLKJHFKJLEM item in hLAHBGANIKK.OCIDJJFCKOB)
				{
					BJHANHIGLGB bJHANHIGLGB = hLAHBGANIKK.GLMCDHHLBOB(item);
					if (bJHANHIGLGB.JFCNIPIMMAL == FAGCDIIJFAB)
					{
						dMAOKHPCPIA.JEACJNAKLDJ(item.EEFMIHDPJPG);
					}
				}
				return dMAOKHPCPIA;
			}
		}
		return null;
	}

	public virtual LKBPEOBFKMJ IOKDFBODOND()
	{
		return MPAJBFANLKP(false);
	}

	public virtual LKBPEOBFKMJ IPFANOLHHAK()
	{
		return MPAJBFANLKP(true);
	}

	[Obsolete("Use version taking a DerObjectIdentifier instead")]
	public PJGIGKJFGFI NMBKKGMJOBA(string GDFLIKNMBCL)
	{
		return NMBKKGMJOBA(new KLKJHFKJLEM(GDFLIKNMBCL));
	}

	public virtual PJGIGKJFGFI NMBKKGMJOBA(KLKJHFKJLEM GDFLIKNMBCL)
	{
		HLAHBGANIKK hLAHBGANIKK = AGCFPJCKBCI();
		if (hLAHBGANIKK != null)
		{
			BJHANHIGLGB bJHANHIGLGB = hLAHBGANIKK.GLMCDHHLBOB(GDFLIKNMBCL);
			if (bJHANHIGLGB != null)
			{
				return bJHANHIGLGB.JBGOANMLBFA;
			}
		}
		return null;
	}
}
