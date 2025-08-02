using System;
using Org.BouncyCastle.Math;

internal class CKDMEPGJMAC : KBINBLGGLNE
{
	public static readonly BigInteger FNPELDEHJKL = HKOMECIGNHE.OKDPJHOEPBJ;

	protected internal readonly uint[] AMFCENFNAJJ;

	public override bool EJJHHCOFAAI
	{
		get
		{
			return LAFMGEKEGBF.EJJHHCOFAAI(AMFCENFNAJJ);
		}
	}

	public override bool EOJCHPEGABD
	{
		get
		{
			return LAFMGEKEGBF.EOJCHPEGABD(AMFCENFNAJJ);
		}
	}

	public override string DALLCADGMKK
	{
		get
		{
			return "SecP128R1Field";
		}
	}

	public override int PJNLBAHOKGC
	{
		get
		{
			return FNPELDEHJKL.BitLength;
		}
	}

	public CKDMEPGJMAC(BigInteger AMFCENFNAJJ)
	{
		if (AMFCENFNAJJ == null || AMFCENFNAJJ.SignValue < 0 || AMFCENFNAJJ.JLPDKNFCNPO(FNPELDEHJKL) >= 0)
		{
			throw new ArgumentException("value invalid for SecP128R1FieldElement", "x");
		}
		this.AMFCENFNAJJ = BOKPIHHFBKJ.HFENNGHNFLF(AMFCENFNAJJ);
	}

	public CKDMEPGJMAC()
	{
		AMFCENFNAJJ = LAFMGEKEGBF.PLIFFMMBNPM();
	}

	protected internal CKDMEPGJMAC(uint[] AMFCENFNAJJ)
	{
		this.AMFCENFNAJJ = AMFCENFNAJJ;
	}

	public override bool OFGNPBCCHAA()
	{
		return LAFMGEKEGBF.DOFLEKCIDCA(AMFCENFNAJJ, 0) == 1;
	}

	public override BigInteger DOJBPIFPALJ()
	{
		return LAFMGEKEGBF.DOJBPIFPALJ(AMFCENFNAJJ);
	}

	public override KBINBLGGLNE JEACJNAKLDJ(KBINBLGGLNE BCIHLCMFAEK)
	{
		uint[] array = LAFMGEKEGBF.PLIFFMMBNPM();
		BOKPIHHFBKJ.JEACJNAKLDJ(AMFCENFNAJJ, ((CKDMEPGJMAC)BCIHLCMFAEK).AMFCENFNAJJ, array);
		return new CKDMEPGJMAC(array);
	}

	public override KBINBLGGLNE AOAINNMNBHC()
	{
		uint[] array = LAFMGEKEGBF.PLIFFMMBNPM();
		BOKPIHHFBKJ.AOAINNMNBHC(AMFCENFNAJJ, array);
		return new CKDMEPGJMAC(array);
	}

	public override KBINBLGGLNE FBGIHKPECCO(KBINBLGGLNE BCIHLCMFAEK)
	{
		uint[] array = LAFMGEKEGBF.PLIFFMMBNPM();
		BOKPIHHFBKJ.FBGIHKPECCO(AMFCENFNAJJ, ((CKDMEPGJMAC)BCIHLCMFAEK).AMFCENFNAJJ, array);
		return new CKDMEPGJMAC(array);
	}

	public override KBINBLGGLNE IBJBIGNPNEM(KBINBLGGLNE BCIHLCMFAEK)
	{
		uint[] array = LAFMGEKEGBF.PLIFFMMBNPM();
		BOKPIHHFBKJ.IBJBIGNPNEM(AMFCENFNAJJ, ((CKDMEPGJMAC)BCIHLCMFAEK).AMFCENFNAJJ, array);
		return new CKDMEPGJMAC(array);
	}

	public override KBINBLGGLNE MCPDGENJCDB(KBINBLGGLNE BCIHLCMFAEK)
	{
		uint[] array = LAFMGEKEGBF.PLIFFMMBNPM();
		JHJKFDMNDBP.LEIECFOMCNL(BOKPIHHFBKJ.MBIJHANOCOC, ((CKDMEPGJMAC)BCIHLCMFAEK).AMFCENFNAJJ, array);
		BOKPIHHFBKJ.IBJBIGNPNEM(array, AMFCENFNAJJ, array);
		return new CKDMEPGJMAC(array);
	}

	public override KBINBLGGLNE BHKOFHMDACN()
	{
		uint[] array = LAFMGEKEGBF.PLIFFMMBNPM();
		BOKPIHHFBKJ.BHKOFHMDACN(AMFCENFNAJJ, array);
		return new CKDMEPGJMAC(array);
	}

	public override KBINBLGGLNE MIOEHGDPGAG()
	{
		uint[] array = LAFMGEKEGBF.PLIFFMMBNPM();
		BOKPIHHFBKJ.MIOEHGDPGAG(AMFCENFNAJJ, array);
		return new CKDMEPGJMAC(array);
	}

	public override KBINBLGGLNE LEIECFOMCNL()
	{
		uint[] array = LAFMGEKEGBF.PLIFFMMBNPM();
		JHJKFDMNDBP.LEIECFOMCNL(BOKPIHHFBKJ.MBIJHANOCOC, AMFCENFNAJJ, array);
		return new CKDMEPGJMAC(array);
	}

	public override KBINBLGGLNE PAEDNKEIDOM()
	{
		uint[] aMFCENFNAJJ = AMFCENFNAJJ;
		if (LAFMGEKEGBF.EJJHHCOFAAI(aMFCENFNAJJ) || LAFMGEKEGBF.EOJCHPEGABD(aMFCENFNAJJ))
		{
			return this;
		}
		uint[] array = LAFMGEKEGBF.PLIFFMMBNPM();
		BOKPIHHFBKJ.MIOEHGDPGAG(aMFCENFNAJJ, array);
		BOKPIHHFBKJ.IBJBIGNPNEM(array, aMFCENFNAJJ, array);
		uint[] array2 = LAFMGEKEGBF.PLIFFMMBNPM();
		BOKPIHHFBKJ.OIEFGPHNOFN(array, 2, array2);
		BOKPIHHFBKJ.IBJBIGNPNEM(array2, array, array2);
		uint[] array3 = LAFMGEKEGBF.PLIFFMMBNPM();
		BOKPIHHFBKJ.OIEFGPHNOFN(array2, 4, array3);
		BOKPIHHFBKJ.IBJBIGNPNEM(array3, array2, array3);
		uint[] array4 = array2;
		BOKPIHHFBKJ.OIEFGPHNOFN(array3, 2, array4);
		BOKPIHHFBKJ.IBJBIGNPNEM(array4, array, array4);
		uint[] array5 = array;
		BOKPIHHFBKJ.OIEFGPHNOFN(array4, 10, array5);
		BOKPIHHFBKJ.IBJBIGNPNEM(array5, array4, array5);
		uint[] array6 = array3;
		BOKPIHHFBKJ.OIEFGPHNOFN(array5, 10, array6);
		BOKPIHHFBKJ.IBJBIGNPNEM(array6, array4, array6);
		uint[] array7 = array4;
		BOKPIHHFBKJ.MIOEHGDPGAG(array6, array7);
		BOKPIHHFBKJ.IBJBIGNPNEM(array7, aMFCENFNAJJ, array7);
		uint[] array8 = array7;
		BOKPIHHFBKJ.OIEFGPHNOFN(array8, 95, array8);
		uint[] array9 = array6;
		BOKPIHHFBKJ.MIOEHGDPGAG(array8, array9);
		return (!LAFMGEKEGBF.HIPMIOOIEJO(aMFCENFNAJJ, array9)) ? null : new CKDMEPGJMAC(array8);
	}

	public virtual bool KIFDKLPDKMD(object NEMEKIOEOLC)
	{
		return KIFDKLPDKMD(NEMEKIOEOLC as CKDMEPGJMAC);
	}

	public override bool KIFDKLPDKMD(KBINBLGGLNE CJHEIBNHNNE)
	{
		return KIFDKLPDKMD(CJHEIBNHNNE as CKDMEPGJMAC);
	}

	public virtual bool KIFDKLPDKMD(CKDMEPGJMAC CJHEIBNHNNE)
	{
		if (this == CJHEIBNHNNE)
		{
			return true;
		}
		if (CJHEIBNHNNE == null)
		{
			return false;
		}
		return LAFMGEKEGBF.HIPMIOOIEJO(AMFCENFNAJJ, CJHEIBNHNNE.AMFCENFNAJJ);
	}

	public override int GetHashCode()
	{
		return FNPELDEHJKL.GetHashCode() ^ NOGCEBKPPJE.ILMFICENEMK(AMFCENFNAJJ, 0, 4);
	}
}
