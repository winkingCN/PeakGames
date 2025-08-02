using System;
using System.Collections;
using ToonSocial.dialogs;
using UnityEngine;
using Utils;

public abstract class MDMLFPDLFLE
{
	private bool CHPLICIPAHD;

	protected string ECCJDODDJMI;

	protected EIPCLBONPLC JDFMMECNFKB;

	private readonly bool BLKGFNPCPFF;

	private readonly bool NNEGPEGMODB;

	private bool CECEGEBGOAD;

	public static bool JGCHLLMLCNI;

	public static bool OMHOPHKCJNI;

	protected MDMLFPDLFLE(EIPCLBONPLC BPDHKFDOCPB, bool JCEKCACCCLK, bool DNHKKLOJBAP = true)
	{
		NNEGPEGMODB = DNHKKLOJBAP;
		BLKGFNPCPFF = JCEKCACCCLK;
		JDFMMECNFKB = BPDHKFDOCPB;
	}

	public void FDNNLJLFMKI(params object[] MIDCNFGAIFA)
	{
		CECEGEBGOAD = false;
		if (CHPLICIPAHD)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.OneAction, "Already running, ignoring: {0}", ECCJDODDJMI);
			return;
		}
		CHPLICIPAHD = true;
		if (NNEGPEGMODB)
		{
			JDFMMECNFKB.IPCAELIMIBN.LoadingIcon.Display();
		}
		if (JDFMMECNFKB.PLNDKBKHDHA && JDFMMECNFKB.NNEADDLACCA && (!BLKGFNPCPFF || JDFMMECNFKB.ADCMNJCINBO != null))
		{
			try
			{
				JFLAAOOBKJD(MIDCNFGAIFA);
				return;
			}
			catch (Exception ex)
			{
				if (NNEGPEGMODB)
				{
					JDFMMECNFKB.IPCAELIMIBN.LoadingIcon.Display();
				}
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.OneAction, "Can not begin one action (1): {0}:{1}", ex.Message, ex.StackTrace);
				return;
			}
		}
		new LLCJMMBBLEH(CAFOOMEPKJA(MIDCNFGAIFA));
	}

	private IEnumerator CAFOOMEPKJA(params object[] MIDCNFGAIFA)
	{
		while (!JDFMMECNFKB.PLNDKBKHDHA || !JDFMMECNFKB.NNEADDLACCA)
		{
			if (CECEGEBGOAD)
			{
				AONDNIEFKII();
				yield break;
			}
			yield return null;
		}
		if (BLKGFNPCPFF && JDFMMECNFKB.ADCMNJCINBO == null)
		{
			GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.SocialCreateUserDialog, false);
			SocialCreateUserDialog component = gameObject.GetComponent<SocialCreateUserDialog>();
			component.SetSession(JDFMMECNFKB);
			while (component.IsInProgress)
			{
				yield return null;
			}
			if (!component.IsPostSent())
			{
				JGCHLLMLCNI = false;
				AONDNIEFKII();
				yield break;
			}
			while (JGCHLLMLCNI)
			{
				if (CECEGEBGOAD)
				{
					JGCHLLMLCNI = false;
					AONDNIEFKII();
					yield break;
				}
				yield return null;
			}
			if (JDFMMECNFKB.ADCMNJCINBO == null)
			{
				AONDNIEFKII();
				yield break;
			}
			OMHOPHKCJNI = true;
		}
		try
		{
			JFLAAOOBKJD(MIDCNFGAIFA);
		}
		catch (Exception ex)
		{
			AONDNIEFKII();
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.OneAction, "Can not begin one action (2): {0}:{1}", ex.Message, ex.StackTrace);
		}
	}

	protected abstract void JFLAAOOBKJD(params object[] MIDCNFGAIFA);

	protected abstract void DFGLIIBBFEI(params object[] MIDCNFGAIFA);

	protected virtual void AONDNIEFKII()
	{
		GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.OneAction, "Action cancelled.");
		CHPLICIPAHD = false;
		if (NNEGPEGMODB)
		{
			JDFMMECNFKB.IPCAELIMIBN.LoadingIcon.Hide();
		}
	}

	public void GPGKHODHINM(params object[] MIDCNFGAIFA)
	{
		CHPLICIPAHD = false;
		if (NNEGPEGMODB)
		{
			JDFMMECNFKB.IPCAELIMIBN.LoadingIcon.Hide();
		}
		try
		{
			DFGLIIBBFEI(MIDCNFGAIFA);
		}
		catch (Exception ex)
		{
			AONDNIEFKII();
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.OneAction, "Can not perform action:{1}:{0}", ex.Message, ex.StackTrace);
		}
	}

	public void AHDHEMJOMGB()
	{
		CECEGEBGOAD = true;
		if (CHPLICIPAHD)
		{
			AONDNIEFKII();
		}
	}
}
