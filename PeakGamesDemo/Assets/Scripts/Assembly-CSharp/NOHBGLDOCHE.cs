using System;
using Org.BouncyCastle.Math;

internal class NOHBGLDOCHE : KBINBLGGLNE
{
	public static readonly BigInteger FNPELDEHJKL = NINLMCBGMII.OKDPJHOEPBJ;

	private static readonly uint[] GLGMCMPINME = new uint[8] { 1242472624u, 3303938855u, 2905597048u, 792926214u, 1039914919u, 726466713u, 1338105611u, 730014848u };

	protected internal readonly uint[] AMFCENFNAJJ;

	public override bool EJJHHCOFAAI
	{
		get
		{
			return AKOICJCJNFB.EJJHHCOFAAI(AMFCENFNAJJ);
		}
	}

	public override bool EOJCHPEGABD
	{
		get
		{
			return AKOICJCJNFB.EOJCHPEGABD(AMFCENFNAJJ);
		}
	}

	public override string DALLCADGMKK
	{
		get
		{
			return "Curve25519Field";
		}
	}

	public override int PJNLBAHOKGC
	{
		get
		{
			return FNPELDEHJKL.BitLength;
		}
	}

	public NOHBGLDOCHE(BigInteger AMFCENFNAJJ)
	{
		if (AMFCENFNAJJ == null || AMFCENFNAJJ.SignValue < 0 || AMFCENFNAJJ.JLPDKNFCNPO(FNPELDEHJKL) >= 0)
		{
			throw new ArgumentException("value invalid for Curve25519FieldElement", "x");
		}
		this.AMFCENFNAJJ = ACMDHOEGCJN.HFENNGHNFLF(AMFCENFNAJJ);
	}

	public NOHBGLDOCHE()
	{
		AMFCENFNAJJ = AKOICJCJNFB.PLIFFMMBNPM();
	}

	protected internal NOHBGLDOCHE(uint[] AMFCENFNAJJ)
	{
		this.AMFCENFNAJJ = AMFCENFNAJJ;
	}

	public override bool OFGNPBCCHAA()
	{
		return AKOICJCJNFB.DOFLEKCIDCA(AMFCENFNAJJ, 0) == 1;
	}

	public override BigInteger DOJBPIFPALJ()
	{
		return AKOICJCJNFB.DOJBPIFPALJ(AMFCENFNAJJ);
	}

	public override KBINBLGGLNE JEACJNAKLDJ(KBINBLGGLNE BCIHLCMFAEK)
	{
		uint[] array = AKOICJCJNFB.PLIFFMMBNPM();
		ACMDHOEGCJN.JEACJNAKLDJ(AMFCENFNAJJ, ((NOHBGLDOCHE)BCIHLCMFAEK).AMFCENFNAJJ, array);
		return new NOHBGLDOCHE(array);
	}

	public override KBINBLGGLNE AOAINNMNBHC()
	{
		uint[] array = AKOICJCJNFB.PLIFFMMBNPM();
		ACMDHOEGCJN.AOAINNMNBHC(AMFCENFNAJJ, array);
		return new NOHBGLDOCHE(array);
	}

	public override KBINBLGGLNE FBGIHKPECCO(KBINBLGGLNE BCIHLCMFAEK)
	{
		uint[] array = AKOICJCJNFB.PLIFFMMBNPM();
		ACMDHOEGCJN.FBGIHKPECCO(AMFCENFNAJJ, ((NOHBGLDOCHE)BCIHLCMFAEK).AMFCENFNAJJ, array);
		return new NOHBGLDOCHE(array);
	}

	public override KBINBLGGLNE IBJBIGNPNEM(KBINBLGGLNE BCIHLCMFAEK)
	{
		uint[] array = AKOICJCJNFB.PLIFFMMBNPM();
		ACMDHOEGCJN.IBJBIGNPNEM(AMFCENFNAJJ, ((NOHBGLDOCHE)BCIHLCMFAEK).AMFCENFNAJJ, array);
		return new NOHBGLDOCHE(array);
	}

	public override KBINBLGGLNE MCPDGENJCDB(KBINBLGGLNE BCIHLCMFAEK)
	{
		uint[] array = AKOICJCJNFB.PLIFFMMBNPM();
		JHJKFDMNDBP.LEIECFOMCNL(ACMDHOEGCJN.MBIJHANOCOC, ((NOHBGLDOCHE)BCIHLCMFAEK).AMFCENFNAJJ, array);
		ACMDHOEGCJN.IBJBIGNPNEM(array, AMFCENFNAJJ, array);
		return new NOHBGLDOCHE(array);
	}

	public override KBINBLGGLNE BHKOFHMDACN()
	{
		uint[] array = AKOICJCJNFB.PLIFFMMBNPM();
		ACMDHOEGCJN.BHKOFHMDACN(AMFCENFNAJJ, array);
		return new NOHBGLDOCHE(array);
	}

	public override KBINBLGGLNE MIOEHGDPGAG()
	{
		uint[] array = AKOICJCJNFB.PLIFFMMBNPM();
		ACMDHOEGCJN.MIOEHGDPGAG(AMFCENFNAJJ, array);
		return new NOHBGLDOCHE(array);
	}

	public override KBINBLGGLNE LEIECFOMCNL()
	{
		uint[] array = AKOICJCJNFB.PLIFFMMBNPM();
		JHJKFDMNDBP.LEIECFOMCNL(ACMDHOEGCJN.MBIJHANOCOC, AMFCENFNAJJ, array);
		return new NOHBGLDOCHE(array);
	}

	public override KBINBLGGLNE PAEDNKEIDOM()
	{
		uint[] aMFCENFNAJJ = AMFCENFNAJJ;
		if (AKOICJCJNFB.EJJHHCOFAAI(aMFCENFNAJJ) || AKOICJCJNFB.EOJCHPEGABD(aMFCENFNAJJ))
		{
			return this;
		}
		uint[] array = AKOICJCJNFB.PLIFFMMBNPM();
		ACMDHOEGCJN.MIOEHGDPGAG(aMFCENFNAJJ, array);
		ACMDHOEGCJN.IBJBIGNPNEM(array, aMFCENFNAJJ, array);
		uint[] array2 = array;
		ACMDHOEGCJN.MIOEHGDPGAG(array, array2);
		ACMDHOEGCJN.IBJBIGNPNEM(array2, aMFCENFNAJJ, array2);
		uint[] array3 = AKOICJCJNFB.PLIFFMMBNPM();
		ACMDHOEGCJN.MIOEHGDPGAG(array2, array3);
		ACMDHOEGCJN.IBJBIGNPNEM(array3, aMFCENFNAJJ, array3);
		uint[] array4 = AKOICJCJNFB.PLIFFMMBNPM();
		ACMDHOEGCJN.OIEFGPHNOFN(array3, 3, array4);
		ACMDHOEGCJN.IBJBIGNPNEM(array4, array2, array4);
		uint[] array5 = array2;
		ACMDHOEGCJN.OIEFGPHNOFN(array4, 4, array5);
		ACMDHOEGCJN.IBJBIGNPNEM(array5, array3, array5);
		uint[] array6 = array4;
		ACMDHOEGCJN.OIEFGPHNOFN(array5, 4, array6);
		ACMDHOEGCJN.IBJBIGNPNEM(array6, array3, array6);
		uint[] array7 = array3;
		ACMDHOEGCJN.OIEFGPHNOFN(array6, 15, array7);
		ACMDHOEGCJN.IBJBIGNPNEM(array7, array6, array7);
		uint[] array8 = array6;
		ACMDHOEGCJN.OIEFGPHNOFN(array7, 30, array8);
		ACMDHOEGCJN.IBJBIGNPNEM(array8, array7, array8);
		uint[] array9 = array7;
		ACMDHOEGCJN.OIEFGPHNOFN(array8, 60, array9);
		ACMDHOEGCJN.IBJBIGNPNEM(array9, array8, array9);
		uint[] array10 = array8;
		ACMDHOEGCJN.OIEFGPHNOFN(array9, 11, array10);
		ACMDHOEGCJN.IBJBIGNPNEM(array10, array5, array10);
		uint[] array11 = array5;
		ACMDHOEGCJN.OIEFGPHNOFN(array10, 120, array11);
		ACMDHOEGCJN.IBJBIGNPNEM(array11, array9, array11);
		uint[] array12 = array11;
		ACMDHOEGCJN.MIOEHGDPGAG(array12, array12);
		uint[] array13 = array9;
		ACMDHOEGCJN.MIOEHGDPGAG(array12, array13);
		if (AKOICJCJNFB.HIPMIOOIEJO(aMFCENFNAJJ, array13))
		{
			return new NOHBGLDOCHE(array12);
		}
		ACMDHOEGCJN.IBJBIGNPNEM(array12, GLGMCMPINME, array12);
		ACMDHOEGCJN.MIOEHGDPGAG(array12, array13);
		if (AKOICJCJNFB.HIPMIOOIEJO(aMFCENFNAJJ, array13))
		{
			return new NOHBGLDOCHE(array12);
		}
		return null;
	}

	public virtual bool KIFDKLPDKMD(object NEMEKIOEOLC)
	{
		return KIFDKLPDKMD(NEMEKIOEOLC as NOHBGLDOCHE);
	}

	public override bool KIFDKLPDKMD(KBINBLGGLNE CJHEIBNHNNE)
	{
		return KIFDKLPDKMD(CJHEIBNHNNE as NOHBGLDOCHE);
	}

	public virtual bool KIFDKLPDKMD(NOHBGLDOCHE CJHEIBNHNNE)
	{
		if (this == CJHEIBNHNNE)
		{
			return true;
		}
		if (CJHEIBNHNNE == null)
		{
			return false;
		}
		return AKOICJCJNFB.HIPMIOOIEJO(AMFCENFNAJJ, CJHEIBNHNNE.AMFCENFNAJJ);
	}

	public override int GetHashCode()
	{
		return FNPELDEHJKL.GetHashCode() ^ NOGCEBKPPJE.ILMFICENEMK(AMFCENFNAJJ, 0, 8);
	}
}
