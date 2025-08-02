using System;

public class KAMMIHKEGPK : HDNPEKKELBE
{
	private int[] CGHBNFCBFME;

	private int[] DNGPKGAPGMO;

	private int[] MGOJKMGCLJM;

	private bool MAEALKEJALK;

	public override string KFKMEPMEBND
	{
		get
		{
			return "DESede";
		}
	}

	public override void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		if (!(IJJHBEECMBP is JEMNCGMEABF))
		{
			throw new ArgumentException("invalid parameter passed to DESede init - " + LHFGHNFJIKM.JKHOEKAOLPM(IJJHBEECMBP));
		}
		byte[] array = ((JEMNCGMEABF)IJJHBEECMBP).MEGBFHFMBFI();
		if (array.Length != 24 && array.Length != 16)
		{
			throw new ArgumentException("key size must be 16 or 24 bytes.");
		}
		this.MAEALKEJALK = MAEALKEJALK;
		byte[] array2 = new byte[8];
		Array.Copy(array, 0, array2, 0, array2.Length);
		CGHBNFCBFME = HDNPEKKELBE.DNIOCLEEKMH(MAEALKEJALK, array2);
		byte[] array3 = new byte[8];
		Array.Copy(array, 8, array3, 0, array3.Length);
		DNGPKGAPGMO = HDNPEKKELBE.DNIOCLEEKMH(!MAEALKEJALK, array3);
		if (array.Length == 24)
		{
			byte[] array4 = new byte[8];
			Array.Copy(array, 16, array4, 0, array4.Length);
			MGOJKMGCLJM = HDNPEKKELBE.DNIOCLEEKMH(MAEALKEJALK, array4);
		}
		else
		{
			MGOJKMGCLJM = CGHBNFCBFME;
		}
	}

	public override int BDIGGHEPIIP()
	{
		return 8;
	}

	public override int DPACJDFHLKB(byte[] MOPCLEEGDFB, int ELICNEDIBGB, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		if (CGHBNFCBFME == null)
		{
			throw new InvalidOperationException("DESede engine not initialised");
		}
		AJLDFGNHDCA.OONDALLFPOP(MOPCLEEGDFB, ELICNEDIBGB, 8, "input buffer too short");
		AJLDFGNHDCA.KLPNFGNKNKB(BILGCJNPJGJ, EMAKNGBIFDC, 8, "output buffer too short");
		byte[] array = new byte[8];
		if (MAEALKEJALK)
		{
			HDNPEKKELBE.JMOHJLGLOBK(CGHBNFCBFME, MOPCLEEGDFB, ELICNEDIBGB, array, 0);
			HDNPEKKELBE.JMOHJLGLOBK(DNGPKGAPGMO, array, 0, array, 0);
			HDNPEKKELBE.JMOHJLGLOBK(MGOJKMGCLJM, array, 0, BILGCJNPJGJ, EMAKNGBIFDC);
		}
		else
		{
			HDNPEKKELBE.JMOHJLGLOBK(MGOJKMGCLJM, MOPCLEEGDFB, ELICNEDIBGB, array, 0);
			HDNPEKKELBE.JMOHJLGLOBK(DNGPKGAPGMO, array, 0, array, 0);
			HDNPEKKELBE.JMOHJLGLOBK(CGHBNFCBFME, array, 0, BILGCJNPJGJ, EMAKNGBIFDC);
		}
		return 8;
	}

	public override void OMOKOKFNBKI()
	{
	}
}
