using System;
using Org.BouncyCastle.Crypto;

public class ODMDKFPOHIL : DGCIOOEELCP
{
	public const string LAFNIJMDGOB = "Org.BouncyCastle.Pkcs1.Strict";

	private const int ILHAIOIMAFJ = 10;

	private static readonly bool[] ACGOOOKBOGP;

	private FBIJJFGLKMK GECCLOFELEC;

	private DGCIOOEELCP MFMIFDMEPPO;

	private bool MAEALKEJALK;

	private bool DIIGJDBCMEG;

	private bool OCIAFNHPELL;

	private int JMJDLLFPBOH = -1;

	private byte[] AHBMIKDPNJC;

	public static bool IGMIKLGEOFD
	{
		get
		{
			return ACGOOOKBOGP[0];
		}
		set
		{
			ACGOOOKBOGP[0] = value;
		}
	}

	public string KFKMEPMEBND
	{
		get
		{
			return MFMIFDMEPPO.KFKMEPMEBND + "/PKCS1Padding";
		}
	}

	static ODMDKFPOHIL()
	{
		string text = LHFGHNFJIKM.IOBDBEEBKEA("Org.BouncyCastle.Pkcs1.Strict");
		ACGOOOKBOGP = new bool[1] { text == null || text.Equals("true") };
	}

	public ODMDKFPOHIL(DGCIOOEELCP IEDPBFAFGGJ)
	{
		MFMIFDMEPPO = IEDPBFAFGGJ;
		OCIAFNHPELL = IGMIKLGEOFD;
	}

	public ODMDKFPOHIL(DGCIOOEELCP IEDPBFAFGGJ, int JMJDLLFPBOH)
	{
		MFMIFDMEPPO = IEDPBFAFGGJ;
		OCIAFNHPELL = IGMIKLGEOFD;
		this.JMJDLLFPBOH = JMJDLLFPBOH;
	}

	public ODMDKFPOHIL(DGCIOOEELCP IEDPBFAFGGJ, byte[] AHBMIKDPNJC)
	{
		MFMIFDMEPPO = IEDPBFAFGGJ;
		OCIAFNHPELL = IGMIKLGEOFD;
		this.AHBMIKDPNJC = AHBMIKDPNJC;
		JMJDLLFPBOH = AHBMIKDPNJC.Length;
	}

	public DGCIOOEELCP GBHNDFALCDC()
	{
		return MFMIFDMEPPO;
	}

	public void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		COEMJAGOFJJ cOEMJAGOFJJ;
		if (IJJHBEECMBP is MDAKJDOFCEP)
		{
			MDAKJDOFCEP mDAKJDOFCEP = (MDAKJDOFCEP)IJJHBEECMBP;
			GECCLOFELEC = mDAKJDOFCEP.IPFKDIJBGIM;
			cOEMJAGOFJJ = (COEMJAGOFJJ)mDAKJDOFCEP.KPJHHAAOFOH;
		}
		else
		{
			GECCLOFELEC = new FBIJJFGLKMK();
			cOEMJAGOFJJ = (COEMJAGOFJJ)IJJHBEECMBP;
		}
		MFMIFDMEPPO.DIOELAHNLKJ(MAEALKEJALK, IJJHBEECMBP);
		DIIGJDBCMEG = cOEMJAGOFJJ.CCLHEKOIIKM;
		this.MAEALKEJALK = MAEALKEJALK;
	}

	public int IBGFCPAGGON()
	{
		int num = MFMIFDMEPPO.IBGFCPAGGON();
		return (!MAEALKEJALK) ? num : (num - 10);
	}

	public int JOKDJPBGMFH()
	{
		int num = MFMIFDMEPPO.JOKDJPBGMFH();
		return (!MAEALKEJALK) ? (num - 10) : num;
	}

	public byte[] DPACJDFHLKB(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP)
	{
		return (!MAEALKEJALK) ? APBCDPDBFPO(MOPCLEEGDFB, ELICNEDIBGB, EOFAGACBNFP) : KFCHAKENJOM(MOPCLEEGDFB, ELICNEDIBGB, EOFAGACBNFP);
	}

	private byte[] KFCHAKENJOM(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int DBGBBFPPDCE)
	{
		if (DBGBBFPPDCE > IBGFCPAGGON())
		{
			throw new ArgumentException("input data too large", "inLen");
		}
		byte[] array = new byte[MFMIFDMEPPO.IBGFCPAGGON()];
		if (DIIGJDBCMEG)
		{
			array[0] = 1;
			for (int i = 1; i != array.Length - DBGBBFPPDCE - 1; i++)
			{
				array[i] = byte.MaxValue;
			}
		}
		else
		{
			GECCLOFELEC.NextBytes(array);
			array[0] = 2;
			for (int j = 1; j != array.Length - DBGBBFPPDCE - 1; j++)
			{
				while (array[j] == 0)
				{
					array[j] = (byte)GECCLOFELEC.LIFIMLDFLGI();
				}
			}
		}
		array[array.Length - DBGBBFPPDCE - 1] = 0;
		Array.Copy(MOPCLEEGDFB, ELICNEDIBGB, array, array.Length - DBGBBFPPDCE, DBGBBFPPDCE);
		return MFMIFDMEPPO.DPACJDFHLKB(array, 0, array.Length);
	}

	private static int FHOGNMGLPPC(byte[] AJDDGHDGHDC, int JMJDLLFPBOH)
	{
		int num = 0;
		num |= AJDDGHDGHDC[0] ^ 2;
		int num2 = AJDDGHDGHDC.Length - (JMJDLLFPBOH + 1);
		for (int i = 1; i < num2; i++)
		{
			int num3 = AJDDGHDGHDC[i];
			num3 |= num3 >> 1;
			num3 |= num3 >> 2;
			num3 |= num3 >> 4;
			num |= (num3 & 1) - 1;
		}
		num |= AJDDGHDGHDC[AJDDGHDGHDC.Length - (JMJDLLFPBOH + 1)];
		num |= num >> 1;
		num |= num >> 2;
		num |= num >> 4;
		return ~((num & 1) - 1);
	}

	private byte[] HIJEJPIIOLB(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int DBGBBFPPDCE)
	{
		if (!DIIGJDBCMEG)
		{
			throw new InvalidCipherTextException("sorry, this method is only for decryption, not for signing");
		}
		byte[] array = MFMIFDMEPPO.DPACJDFHLKB(MOPCLEEGDFB, ELICNEDIBGB, DBGBBFPPDCE);
		byte[] array2 = null;
		if (AHBMIKDPNJC == null)
		{
			array2 = new byte[JMJDLLFPBOH];
			GECCLOFELEC.NextBytes(array2);
		}
		else
		{
			array2 = AHBMIKDPNJC;
		}
		if (array.Length < JOKDJPBGMFH())
		{
			throw new InvalidCipherTextException("block truncated");
		}
		if (OCIAFNHPELL && array.Length != MFMIFDMEPPO.JOKDJPBGMFH())
		{
			throw new InvalidCipherTextException("block incorrect size");
		}
		int num = FHOGNMGLPPC(array, JMJDLLFPBOH);
		byte[] array3 = new byte[JMJDLLFPBOH];
		for (int i = 0; i < JMJDLLFPBOH; i++)
		{
			array3[i] = (byte)((array[i + (array.Length - JMJDLLFPBOH)] & ~num) | (array2[i] & num));
		}
		return array3;
	}

	private byte[] APBCDPDBFPO(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int DBGBBFPPDCE)
	{
		if (JMJDLLFPBOH != -1)
		{
			return HIJEJPIIOLB(MOPCLEEGDFB, ELICNEDIBGB, DBGBBFPPDCE);
		}
		byte[] array = MFMIFDMEPPO.DPACJDFHLKB(MOPCLEEGDFB, ELICNEDIBGB, DBGBBFPPDCE);
		if (array.Length < JOKDJPBGMFH())
		{
			throw new InvalidCipherTextException("block truncated");
		}
		byte b = array[0];
		if (b != 1 && b != 2)
		{
			throw new InvalidCipherTextException("unknown block type");
		}
		if (OCIAFNHPELL && array.Length != MFMIFDMEPPO.JOKDJPBGMFH())
		{
			throw new InvalidCipherTextException("block incorrect size");
		}
		int i;
		for (i = 1; i != array.Length; i++)
		{
			byte b2 = array[i];
			if (b2 == 0)
			{
				break;
			}
			if (b == 1 && b2 != byte.MaxValue)
			{
				throw new InvalidCipherTextException("block padding incorrect");
			}
		}
		i++;
		if (i > array.Length || i < 10)
		{
			throw new InvalidCipherTextException("no data in block");
		}
		byte[] array2 = new byte[array.Length - i];
		Array.Copy(array, i, array2, 0, array2.Length);
		return array2;
	}
}
