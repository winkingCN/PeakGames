using System;

public class BJHANHIGLGB
{
	internal bool FAGCDIIJFAB;

	internal PJGIGKJFGFI EDDNOJDPMCF;

	public bool JFCNIPIMMAL
	{
		get
		{
			return FAGCDIIJFAB;
		}
	}

	public PJGIGKJFGFI JBGOANMLBFA
	{
		get
		{
			return EDDNOJDPMCF;
		}
	}

	public BJHANHIGLGB(PNKAJJJPEPA FAGCDIIJFAB, PJGIGKJFGFI EDDNOJDPMCF)
	{
		if (FAGCDIIJFAB == null)
		{
			throw new ArgumentNullException("critical");
		}
		this.FAGCDIIJFAB = FAGCDIIJFAB.ELAOLKPILED;
		this.EDDNOJDPMCF = EDDNOJDPMCF;
	}

	public BJHANHIGLGB(bool FAGCDIIJFAB, PJGIGKJFGFI EDDNOJDPMCF)
	{
		this.FAGCDIIJFAB = FAGCDIIJFAB;
		this.EDDNOJDPMCF = EDDNOJDPMCF;
	}

	public LNKPCJLANAO GMHDCFNAJON()
	{
		return FCELHPADEGC(this);
	}

	public override int GetHashCode()
	{
		int hashCode = JBGOANMLBFA.GetHashCode();
		return (!JFCNIPIMMAL) ? (~hashCode) : hashCode;
	}

	public override bool Equals(object NEMEKIOEOLC)
	{
		BJHANHIGLGB bJHANHIGLGB = NEMEKIOEOLC as BJHANHIGLGB;
		if (bJHANHIGLGB == null)
		{
			return false;
		}
		return JBGOANMLBFA.Equals(bJHANHIGLGB.JBGOANMLBFA) && JFCNIPIMMAL == bJHANHIGLGB.JFCNIPIMMAL;
	}

	public static EDOEBJJFOBM FCELHPADEGC(BJHANHIGLGB ABGDMAIDMAD)
	{
		try
		{
			return EDOEBJJFOBM.HPDCKMOPEMM(ABGDMAIDMAD.JBGOANMLBFA.KLHNEKMCKKI());
		}
		catch (Exception innerException)
		{
			throw new ArgumentException("can't convert extension", innerException);
		}
	}
}
