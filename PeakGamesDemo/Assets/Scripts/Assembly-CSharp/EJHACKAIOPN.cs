using System;
using Org.BouncyCastle.Math;

internal class EJHACKAIOPN : KBINBLGGLNE
{
	public static readonly BigInteger FNPELDEHJKL = NLCOIEFDMJF.OKDPJHOEPBJ;

	protected internal readonly uint[] AMFCENFNAJJ;

	public override bool EJJHHCOFAAI
	{
		get
		{
			return EJJGNFBFKIJ.EJJHHCOFAAI(AMFCENFNAJJ);
		}
	}

	public override bool EOJCHPEGABD
	{
		get
		{
			return EJJGNFBFKIJ.EOJCHPEGABD(AMFCENFNAJJ);
		}
	}

	public override string DALLCADGMKK
	{
		get
		{
			return "SecP160R1Field";
		}
	}

	public override int PJNLBAHOKGC
	{
		get
		{
			return FNPELDEHJKL.BitLength;
		}
	}

	public EJHACKAIOPN(BigInteger AMFCENFNAJJ)
	{
		if (AMFCENFNAJJ == null || AMFCENFNAJJ.SignValue < 0 || AMFCENFNAJJ.JLPDKNFCNPO(FNPELDEHJKL) >= 0)
		{
			throw new ArgumentException("value invalid for SecP160R1FieldElement", "x");
		}
		this.AMFCENFNAJJ = FKAFCHAAOMJ.HFENNGHNFLF(AMFCENFNAJJ);
	}

	public EJHACKAIOPN()
	{
		AMFCENFNAJJ = EJJGNFBFKIJ.PLIFFMMBNPM();
	}

	protected internal EJHACKAIOPN(uint[] AMFCENFNAJJ)
	{
		this.AMFCENFNAJJ = AMFCENFNAJJ;
	}

	public override bool OFGNPBCCHAA()
	{
		return EJJGNFBFKIJ.DOFLEKCIDCA(AMFCENFNAJJ, 0) == 1;
	}

	public override BigInteger DOJBPIFPALJ()
	{
		return EJJGNFBFKIJ.DOJBPIFPALJ(AMFCENFNAJJ);
	}

	public override KBINBLGGLNE JEACJNAKLDJ(KBINBLGGLNE BCIHLCMFAEK)
	{
		uint[] array = EJJGNFBFKIJ.PLIFFMMBNPM();
		FKAFCHAAOMJ.JEACJNAKLDJ(AMFCENFNAJJ, ((EJHACKAIOPN)BCIHLCMFAEK).AMFCENFNAJJ, array);
		return new EJHACKAIOPN(array);
	}

	public override KBINBLGGLNE AOAINNMNBHC()
	{
		uint[] array = EJJGNFBFKIJ.PLIFFMMBNPM();
		FKAFCHAAOMJ.AOAINNMNBHC(AMFCENFNAJJ, array);
		return new EJHACKAIOPN(array);
	}

	public override KBINBLGGLNE FBGIHKPECCO(KBINBLGGLNE BCIHLCMFAEK)
	{
		uint[] array = EJJGNFBFKIJ.PLIFFMMBNPM();
		FKAFCHAAOMJ.FBGIHKPECCO(AMFCENFNAJJ, ((EJHACKAIOPN)BCIHLCMFAEK).AMFCENFNAJJ, array);
		return new EJHACKAIOPN(array);
	}

	public override KBINBLGGLNE IBJBIGNPNEM(KBINBLGGLNE BCIHLCMFAEK)
	{
		uint[] array = EJJGNFBFKIJ.PLIFFMMBNPM();
		FKAFCHAAOMJ.IBJBIGNPNEM(AMFCENFNAJJ, ((EJHACKAIOPN)BCIHLCMFAEK).AMFCENFNAJJ, array);
		return new EJHACKAIOPN(array);
	}

	public override KBINBLGGLNE MCPDGENJCDB(KBINBLGGLNE BCIHLCMFAEK)
	{
		uint[] array = EJJGNFBFKIJ.PLIFFMMBNPM();
		JHJKFDMNDBP.LEIECFOMCNL(FKAFCHAAOMJ.MBIJHANOCOC, ((EJHACKAIOPN)BCIHLCMFAEK).AMFCENFNAJJ, array);
		FKAFCHAAOMJ.IBJBIGNPNEM(array, AMFCENFNAJJ, array);
		return new EJHACKAIOPN(array);
	}

	public override KBINBLGGLNE BHKOFHMDACN()
	{
		uint[] array = EJJGNFBFKIJ.PLIFFMMBNPM();
		FKAFCHAAOMJ.BHKOFHMDACN(AMFCENFNAJJ, array);
		return new EJHACKAIOPN(array);
	}

	public override KBINBLGGLNE MIOEHGDPGAG()
	{
		uint[] array = EJJGNFBFKIJ.PLIFFMMBNPM();
		FKAFCHAAOMJ.MIOEHGDPGAG(AMFCENFNAJJ, array);
		return new EJHACKAIOPN(array);
	}

	public override KBINBLGGLNE LEIECFOMCNL()
	{
		uint[] array = EJJGNFBFKIJ.PLIFFMMBNPM();
		JHJKFDMNDBP.LEIECFOMCNL(FKAFCHAAOMJ.MBIJHANOCOC, AMFCENFNAJJ, array);
		return new EJHACKAIOPN(array);
	}

	public override KBINBLGGLNE PAEDNKEIDOM()
	{
		uint[] aMFCENFNAJJ = AMFCENFNAJJ;
		if (EJJGNFBFKIJ.EJJHHCOFAAI(aMFCENFNAJJ) || EJJGNFBFKIJ.EOJCHPEGABD(aMFCENFNAJJ))
		{
			return this;
		}
		uint[] array = EJJGNFBFKIJ.PLIFFMMBNPM();
		FKAFCHAAOMJ.MIOEHGDPGAG(aMFCENFNAJJ, array);
		FKAFCHAAOMJ.IBJBIGNPNEM(array, aMFCENFNAJJ, array);
		uint[] array2 = EJJGNFBFKIJ.PLIFFMMBNPM();
		FKAFCHAAOMJ.OIEFGPHNOFN(array, 2, array2);
		FKAFCHAAOMJ.IBJBIGNPNEM(array2, array, array2);
		uint[] array3 = array;
		FKAFCHAAOMJ.OIEFGPHNOFN(array2, 4, array3);
		FKAFCHAAOMJ.IBJBIGNPNEM(array3, array2, array3);
		uint[] array4 = array2;
		FKAFCHAAOMJ.OIEFGPHNOFN(array3, 8, array4);
		FKAFCHAAOMJ.IBJBIGNPNEM(array4, array3, array4);
		uint[] array5 = array3;
		FKAFCHAAOMJ.OIEFGPHNOFN(array4, 16, array5);
		FKAFCHAAOMJ.IBJBIGNPNEM(array5, array4, array5);
		uint[] array6 = array4;
		FKAFCHAAOMJ.OIEFGPHNOFN(array5, 32, array6);
		FKAFCHAAOMJ.IBJBIGNPNEM(array6, array5, array6);
		uint[] array7 = array5;
		FKAFCHAAOMJ.OIEFGPHNOFN(array6, 64, array7);
		FKAFCHAAOMJ.IBJBIGNPNEM(array7, array6, array7);
		uint[] array8 = array6;
		FKAFCHAAOMJ.MIOEHGDPGAG(array7, array8);
		FKAFCHAAOMJ.IBJBIGNPNEM(array8, aMFCENFNAJJ, array8);
		uint[] array9 = array8;
		FKAFCHAAOMJ.OIEFGPHNOFN(array9, 29, array9);
		uint[] array10 = array7;
		FKAFCHAAOMJ.MIOEHGDPGAG(array9, array10);
		return (!EJJGNFBFKIJ.HIPMIOOIEJO(aMFCENFNAJJ, array10)) ? null : new EJHACKAIOPN(array9);
	}

	public virtual bool KIFDKLPDKMD(object NEMEKIOEOLC)
	{
		return KIFDKLPDKMD(NEMEKIOEOLC as EJHACKAIOPN);
	}

	public override bool KIFDKLPDKMD(KBINBLGGLNE CJHEIBNHNNE)
	{
		return KIFDKLPDKMD(CJHEIBNHNNE as EJHACKAIOPN);
	}

	public virtual bool KIFDKLPDKMD(EJHACKAIOPN CJHEIBNHNNE)
	{
		if (this == CJHEIBNHNNE)
		{
			return true;
		}
		if (CJHEIBNHNNE == null)
		{
			return false;
		}
		return EJJGNFBFKIJ.HIPMIOOIEJO(AMFCENFNAJJ, CJHEIBNHNNE.AMFCENFNAJJ);
	}

	public override int GetHashCode()
	{
		return FNPELDEHJKL.GetHashCode() ^ NOGCEBKPPJE.ILMFICENEMK(AMFCENFNAJJ, 0, 5);
	}
}
