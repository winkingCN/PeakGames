using System;
using Org.BouncyCastle.Math;

internal class DEHIGCEHECB : KBINBLGGLNE
{
	public static readonly BigInteger FNPELDEHJKL = FMDAALCCDEP.OKDPJHOEPBJ;

	protected internal readonly uint[] AMFCENFNAJJ;

	public override bool EJJHHCOFAAI
	{
		get
		{
			return PHEKPHCPKLA.EJJHHCOFAAI(AMFCENFNAJJ);
		}
	}

	public override bool EOJCHPEGABD
	{
		get
		{
			return PHEKPHCPKLA.EOJCHPEGABD(AMFCENFNAJJ);
		}
	}

	public override string DALLCADGMKK
	{
		get
		{
			return "SecP192K1Field";
		}
	}

	public override int PJNLBAHOKGC
	{
		get
		{
			return FNPELDEHJKL.BitLength;
		}
	}

	public DEHIGCEHECB(BigInteger AMFCENFNAJJ)
	{
		if (AMFCENFNAJJ == null || AMFCENFNAJJ.SignValue < 0 || AMFCENFNAJJ.JLPDKNFCNPO(FNPELDEHJKL) >= 0)
		{
			throw new ArgumentException("value invalid for SecP192K1FieldElement", "x");
		}
		this.AMFCENFNAJJ = AJGCHNBEMAE.HFENNGHNFLF(AMFCENFNAJJ);
	}

	public DEHIGCEHECB()
	{
		AMFCENFNAJJ = PHEKPHCPKLA.PLIFFMMBNPM();
	}

	protected internal DEHIGCEHECB(uint[] AMFCENFNAJJ)
	{
		this.AMFCENFNAJJ = AMFCENFNAJJ;
	}

	public override bool OFGNPBCCHAA()
	{
		return PHEKPHCPKLA.DOFLEKCIDCA(AMFCENFNAJJ, 0) == 1;
	}

	public override BigInteger DOJBPIFPALJ()
	{
		return PHEKPHCPKLA.DOJBPIFPALJ(AMFCENFNAJJ);
	}

	public override KBINBLGGLNE JEACJNAKLDJ(KBINBLGGLNE BCIHLCMFAEK)
	{
		uint[] array = PHEKPHCPKLA.PLIFFMMBNPM();
		AJGCHNBEMAE.JEACJNAKLDJ(AMFCENFNAJJ, ((DEHIGCEHECB)BCIHLCMFAEK).AMFCENFNAJJ, array);
		return new DEHIGCEHECB(array);
	}

	public override KBINBLGGLNE AOAINNMNBHC()
	{
		uint[] array = PHEKPHCPKLA.PLIFFMMBNPM();
		AJGCHNBEMAE.AOAINNMNBHC(AMFCENFNAJJ, array);
		return new DEHIGCEHECB(array);
	}

	public override KBINBLGGLNE FBGIHKPECCO(KBINBLGGLNE BCIHLCMFAEK)
	{
		uint[] array = PHEKPHCPKLA.PLIFFMMBNPM();
		AJGCHNBEMAE.FBGIHKPECCO(AMFCENFNAJJ, ((DEHIGCEHECB)BCIHLCMFAEK).AMFCENFNAJJ, array);
		return new DEHIGCEHECB(array);
	}

	public override KBINBLGGLNE IBJBIGNPNEM(KBINBLGGLNE BCIHLCMFAEK)
	{
		uint[] array = PHEKPHCPKLA.PLIFFMMBNPM();
		AJGCHNBEMAE.IBJBIGNPNEM(AMFCENFNAJJ, ((DEHIGCEHECB)BCIHLCMFAEK).AMFCENFNAJJ, array);
		return new DEHIGCEHECB(array);
	}

	public override KBINBLGGLNE MCPDGENJCDB(KBINBLGGLNE BCIHLCMFAEK)
	{
		uint[] array = PHEKPHCPKLA.PLIFFMMBNPM();
		JHJKFDMNDBP.LEIECFOMCNL(AJGCHNBEMAE.MBIJHANOCOC, ((DEHIGCEHECB)BCIHLCMFAEK).AMFCENFNAJJ, array);
		AJGCHNBEMAE.IBJBIGNPNEM(array, AMFCENFNAJJ, array);
		return new DEHIGCEHECB(array);
	}

	public override KBINBLGGLNE BHKOFHMDACN()
	{
		uint[] array = PHEKPHCPKLA.PLIFFMMBNPM();
		AJGCHNBEMAE.BHKOFHMDACN(AMFCENFNAJJ, array);
		return new DEHIGCEHECB(array);
	}

	public override KBINBLGGLNE MIOEHGDPGAG()
	{
		uint[] array = PHEKPHCPKLA.PLIFFMMBNPM();
		AJGCHNBEMAE.MIOEHGDPGAG(AMFCENFNAJJ, array);
		return new DEHIGCEHECB(array);
	}

	public override KBINBLGGLNE LEIECFOMCNL()
	{
		uint[] array = PHEKPHCPKLA.PLIFFMMBNPM();
		JHJKFDMNDBP.LEIECFOMCNL(AJGCHNBEMAE.MBIJHANOCOC, AMFCENFNAJJ, array);
		return new DEHIGCEHECB(array);
	}

	public override KBINBLGGLNE PAEDNKEIDOM()
	{
		uint[] aMFCENFNAJJ = AMFCENFNAJJ;
		if (PHEKPHCPKLA.EJJHHCOFAAI(aMFCENFNAJJ) || PHEKPHCPKLA.EOJCHPEGABD(aMFCENFNAJJ))
		{
			return this;
		}
		uint[] array = PHEKPHCPKLA.PLIFFMMBNPM();
		AJGCHNBEMAE.MIOEHGDPGAG(aMFCENFNAJJ, array);
		AJGCHNBEMAE.IBJBIGNPNEM(array, aMFCENFNAJJ, array);
		uint[] array2 = PHEKPHCPKLA.PLIFFMMBNPM();
		AJGCHNBEMAE.MIOEHGDPGAG(array, array2);
		AJGCHNBEMAE.IBJBIGNPNEM(array2, aMFCENFNAJJ, array2);
		uint[] array3 = PHEKPHCPKLA.PLIFFMMBNPM();
		AJGCHNBEMAE.OIEFGPHNOFN(array2, 3, array3);
		AJGCHNBEMAE.IBJBIGNPNEM(array3, array2, array3);
		uint[] array4 = array3;
		AJGCHNBEMAE.OIEFGPHNOFN(array3, 2, array4);
		AJGCHNBEMAE.IBJBIGNPNEM(array4, array, array4);
		uint[] array5 = array;
		AJGCHNBEMAE.OIEFGPHNOFN(array4, 8, array5);
		AJGCHNBEMAE.IBJBIGNPNEM(array5, array4, array5);
		uint[] array6 = array4;
		AJGCHNBEMAE.OIEFGPHNOFN(array5, 3, array6);
		AJGCHNBEMAE.IBJBIGNPNEM(array6, array2, array6);
		uint[] array7 = PHEKPHCPKLA.PLIFFMMBNPM();
		AJGCHNBEMAE.OIEFGPHNOFN(array6, 16, array7);
		AJGCHNBEMAE.IBJBIGNPNEM(array7, array5, array7);
		uint[] array8 = array5;
		AJGCHNBEMAE.OIEFGPHNOFN(array7, 35, array8);
		AJGCHNBEMAE.IBJBIGNPNEM(array8, array7, array8);
		uint[] array9 = array7;
		AJGCHNBEMAE.OIEFGPHNOFN(array8, 70, array9);
		AJGCHNBEMAE.IBJBIGNPNEM(array9, array8, array9);
		uint[] array10 = array8;
		AJGCHNBEMAE.OIEFGPHNOFN(array9, 19, array10);
		AJGCHNBEMAE.IBJBIGNPNEM(array10, array6, array10);
		uint[] array11 = array10;
		AJGCHNBEMAE.OIEFGPHNOFN(array11, 20, array11);
		AJGCHNBEMAE.IBJBIGNPNEM(array11, array6, array11);
		AJGCHNBEMAE.OIEFGPHNOFN(array11, 4, array11);
		AJGCHNBEMAE.IBJBIGNPNEM(array11, array2, array11);
		AJGCHNBEMAE.OIEFGPHNOFN(array11, 6, array11);
		AJGCHNBEMAE.IBJBIGNPNEM(array11, array2, array11);
		AJGCHNBEMAE.MIOEHGDPGAG(array11, array11);
		uint[] array12 = array2;
		AJGCHNBEMAE.MIOEHGDPGAG(array11, array12);
		return (!PHEKPHCPKLA.HIPMIOOIEJO(aMFCENFNAJJ, array12)) ? null : new DEHIGCEHECB(array11);
	}

	public virtual bool KIFDKLPDKMD(object NEMEKIOEOLC)
	{
		return KIFDKLPDKMD(NEMEKIOEOLC as DEHIGCEHECB);
	}

	public override bool KIFDKLPDKMD(KBINBLGGLNE CJHEIBNHNNE)
	{
		return KIFDKLPDKMD(CJHEIBNHNNE as DEHIGCEHECB);
	}

	public virtual bool KIFDKLPDKMD(DEHIGCEHECB CJHEIBNHNNE)
	{
		if (this == CJHEIBNHNNE)
		{
			return true;
		}
		if (CJHEIBNHNNE == null)
		{
			return false;
		}
		return PHEKPHCPKLA.HIPMIOOIEJO(AMFCENFNAJJ, CJHEIBNHNNE.AMFCENFNAJJ);
	}

	public override int GetHashCode()
	{
		return FNPELDEHJKL.GetHashCode() ^ NOGCEBKPPJE.ILMFICENEMK(AMFCENFNAJJ, 0, 6);
	}
}
