using System;
using Org.BouncyCastle.Crypto;

public class AEKEOPNNPMH : DGCIOOEELCP
{
	private byte[] KBGOMNHHHDE;

	private BJLAMONNNDD AIELCDIFLFB;

	private BJLAMONNNDD INENACIIOLK;

	private DGCIOOEELCP MFMIFDMEPPO;

	private FBIJJFGLKMK GECCLOFELEC;

	private bool MAEALKEJALK;

	public string KFKMEPMEBND
	{
		get
		{
			return MFMIFDMEPPO.KFKMEPMEBND + "/OAEPPadding";
		}
	}

	public AEKEOPNNPMH(DGCIOOEELCP IEDPBFAFGGJ)
		: this(IEDPBFAFGGJ, new KALMDEHGEAC(), null)
	{
	}

	public AEKEOPNNPMH(DGCIOOEELCP IEDPBFAFGGJ, BJLAMONNNDD AIELCDIFLFB)
		: this(IEDPBFAFGGJ, AIELCDIFLFB, null)
	{
	}

	public AEKEOPNNPMH(DGCIOOEELCP IEDPBFAFGGJ, BJLAMONNNDD AIELCDIFLFB, byte[] ILLIOLALFDP)
		: this(IEDPBFAFGGJ, AIELCDIFLFB, AIELCDIFLFB, ILLIOLALFDP)
	{
	}

	public AEKEOPNNPMH(DGCIOOEELCP IEDPBFAFGGJ, BJLAMONNNDD AIELCDIFLFB, BJLAMONNNDD INENACIIOLK, byte[] ILLIOLALFDP)
	{
		MFMIFDMEPPO = IEDPBFAFGGJ;
		this.AIELCDIFLFB = AIELCDIFLFB;
		this.INENACIIOLK = INENACIIOLK;
		KBGOMNHHHDE = new byte[AIELCDIFLFB.EEMLLAMENHO()];
		if (ILLIOLALFDP != null)
		{
			AIELCDIFLFB.GONEEEFEDGF(ILLIOLALFDP, 0, ILLIOLALFDP.Length);
		}
		AIELCDIFLFB.LCNOFBMOHHM(KBGOMNHHHDE, 0);
	}

	public DGCIOOEELCP GBHNDFALCDC()
	{
		return MFMIFDMEPPO;
	}

	public void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK BOFHHECPKNF)
	{
		if (BOFHHECPKNF is MDAKJDOFCEP)
		{
			MDAKJDOFCEP mDAKJDOFCEP = (MDAKJDOFCEP)BOFHHECPKNF;
			GECCLOFELEC = mDAKJDOFCEP.IPFKDIJBGIM;
		}
		else
		{
			GECCLOFELEC = new FBIJJFGLKMK();
		}
		MFMIFDMEPPO.DIOELAHNLKJ(MAEALKEJALK, BOFHHECPKNF);
		this.MAEALKEJALK = MAEALKEJALK;
	}

	public int IBGFCPAGGON()
	{
		int num = MFMIFDMEPPO.IBGFCPAGGON();
		if (MAEALKEJALK)
		{
			return num - 1 - 2 * KBGOMNHHHDE.Length;
		}
		return num;
	}

	public int JOKDJPBGMFH()
	{
		int num = MFMIFDMEPPO.JOKDJPBGMFH();
		if (MAEALKEJALK)
		{
			return num;
		}
		return num - 1 - 2 * KBGOMNHHHDE.Length;
	}

	public byte[] DPACJDFHLKB(byte[] AIFKJBMJOMK, int ELICNEDIBGB, int DBGBBFPPDCE)
	{
		if (MAEALKEJALK)
		{
			return KFCHAKENJOM(AIFKJBMJOMK, ELICNEDIBGB, DBGBBFPPDCE);
		}
		return APBCDPDBFPO(AIFKJBMJOMK, ELICNEDIBGB, DBGBBFPPDCE);
	}

	private byte[] KFCHAKENJOM(byte[] AIFKJBMJOMK, int ELICNEDIBGB, int DBGBBFPPDCE)
	{
		byte[] array = new byte[IBGFCPAGGON() + 1 + 2 * KBGOMNHHHDE.Length];
		Array.Copy(AIFKJBMJOMK, ELICNEDIBGB, array, array.Length - DBGBBFPPDCE, DBGBBFPPDCE);
		array[array.Length - DBGBBFPPDCE - 1] = 1;
		Array.Copy(KBGOMNHHHDE, 0, array, KBGOMNHHHDE.Length, KBGOMNHHHDE.Length);
		byte[] array2 = FBIJJFGLKMK.EABAFEKGFMC(GECCLOFELEC, KBGOMNHHHDE.Length);
		byte[] array3 = HOMHAKAOCHC(array2, 0, array2.Length, array.Length - KBGOMNHHHDE.Length);
		for (int i = KBGOMNHHHDE.Length; i != array.Length; i++)
		{
			array[i] ^= array3[i - KBGOMNHHHDE.Length];
		}
		Array.Copy(array2, 0, array, 0, KBGOMNHHHDE.Length);
		array3 = HOMHAKAOCHC(array, KBGOMNHHHDE.Length, array.Length - KBGOMNHHHDE.Length, KBGOMNHHHDE.Length);
		for (int j = 0; j != KBGOMNHHHDE.Length; j++)
		{
			array[j] ^= array3[j];
		}
		return MFMIFDMEPPO.DPACJDFHLKB(array, 0, array.Length);
	}

	private byte[] APBCDPDBFPO(byte[] AIFKJBMJOMK, int ELICNEDIBGB, int DBGBBFPPDCE)
	{
		byte[] array = MFMIFDMEPPO.DPACJDFHLKB(AIFKJBMJOMK, ELICNEDIBGB, DBGBBFPPDCE);
		byte[] array2;
		if (array.Length < MFMIFDMEPPO.JOKDJPBGMFH())
		{
			array2 = new byte[MFMIFDMEPPO.JOKDJPBGMFH()];
			Array.Copy(array, 0, array2, array2.Length - array.Length, array.Length);
		}
		else
		{
			array2 = array;
		}
		if (array2.Length < 2 * KBGOMNHHHDE.Length + 1)
		{
			throw new InvalidCipherTextException("data too short");
		}
		byte[] array3 = HOMHAKAOCHC(array2, KBGOMNHHHDE.Length, array2.Length - KBGOMNHHHDE.Length, KBGOMNHHHDE.Length);
		for (int i = 0; i != KBGOMNHHHDE.Length; i++)
		{
			array2[i] ^= array3[i];
		}
		array3 = HOMHAKAOCHC(array2, 0, KBGOMNHHHDE.Length, array2.Length - KBGOMNHHHDE.Length);
		for (int j = KBGOMNHHHDE.Length; j != array2.Length; j++)
		{
			array2[j] ^= array3[j - KBGOMNHHHDE.Length];
		}
		int num = 0;
		for (int k = 0; k < KBGOMNHHHDE.Length; k++)
		{
			num |= (byte)(KBGOMNHHHDE[k] ^ array2[KBGOMNHHHDE.Length + k]);
		}
		if (num != 0)
		{
			throw new InvalidCipherTextException("data hash wrong");
		}
		int l;
		for (l = 2 * KBGOMNHHHDE.Length; l != array2.Length && array2[l] == 0; l++)
		{
		}
		if (l > array2.Length - 1 || array2[l] != 1)
		{
			throw new InvalidCipherTextException("data start wrong " + l);
		}
		l++;
		byte[] array4 = new byte[array2.Length - l];
		Array.Copy(array2, l, array4, 0, array4.Length);
		return array4;
	}

	private void IMOMLPKFALE(int PLCFEOMGCFK, byte[] ELHJELHHEFJ)
	{
		ELHJELHHEFJ[0] = (byte)((uint)PLCFEOMGCFK >> 24);
		ELHJELHHEFJ[1] = (byte)((uint)PLCFEOMGCFK >> 16);
		ELHJELHHEFJ[2] = (byte)((uint)PLCFEOMGCFK >> 8);
		ELHJELHHEFJ[3] = (byte)((uint)PLCFEOMGCFK >> 0);
	}

	private byte[] HOMHAKAOCHC(byte[] NMLDCCMBKAD, int NDAAKFPMLOL, int DIDEHKCMHBA, int EOFAGACBNFP)
	{
		byte[] array = new byte[EOFAGACBNFP];
		byte[] array2 = new byte[INENACIIOLK.EEMLLAMENHO()];
		byte[] array3 = new byte[4];
		int num = 0;
		AIELCDIFLFB.OMOKOKFNBKI();
		do
		{
			IMOMLPKFALE(num, array3);
			INENACIIOLK.GONEEEFEDGF(NMLDCCMBKAD, NDAAKFPMLOL, DIDEHKCMHBA);
			INENACIIOLK.GONEEEFEDGF(array3, 0, array3.Length);
			INENACIIOLK.LCNOFBMOHHM(array2, 0);
			Array.Copy(array2, 0, array, num * array2.Length, array2.Length);
		}
		while (++num < EOFAGACBNFP / array2.Length);
		if (num * array2.Length < EOFAGACBNFP)
		{
			IMOMLPKFALE(num, array3);
			INENACIIOLK.GONEEEFEDGF(NMLDCCMBKAD, NDAAKFPMLOL, DIDEHKCMHBA);
			INENACIIOLK.GONEEEFEDGF(array3, 0, array3.Length);
			INENACIIOLK.LCNOFBMOHHM(array2, 0);
			Array.Copy(array2, 0, array, num * array2.Length, array.Length - num * array2.Length);
		}
		return array;
	}
}
