using System;
using System.Collections;
using System.IO;

public sealed class CBKKCJFENJM
{
	public sealed class NPKMNFBOOBJ
	{
		private int PEPFODJEEKK = -1;

		private short DFKNNDLMMNC = -1;

		private byte[] KKCHFFNALKO;

		private PAJJBHMEFKE HOFDFNMIALD;

		private byte[] BDLGALEIFIE;

		private byte[] IBAEFAPACBN;

		private byte[] BHBDNGNOKDF;

		public CBKKCJFENJM HOEJFJPHGDO()
		{
			PIBLOPJEGEL(PEPFODJEEKK >= 0, "cipherSuite");
			PIBLOPJEGEL(DFKNNDLMMNC >= 0, "compressionAlgorithm");
			PIBLOPJEGEL(KKCHFFNALKO != null, "masterSecret");
			return new CBKKCJFENJM(PEPFODJEEKK, (byte)DFKNNDLMMNC, KKCHFFNALKO, HOFDFNMIALD, BDLGALEIFIE, IBAEFAPACBN, BHBDNGNOKDF);
		}

		public NPKMNFBOOBJ JKHOIOIHKJL(int DHDNFGLNBGJ)
		{
			PEPFODJEEKK = DHDNFGLNBGJ;
			return this;
		}

		public NPKMNFBOOBJ KJGPOFCIOJD(byte KFCOFBMPANP)
		{
			DFKNNDLMMNC = KFCOFBMPANP;
			return this;
		}

		public NPKMNFBOOBJ JDKFOEELJEL(byte[] IENFDPCIFNJ)
		{
			KKCHFFNALKO = IENFDPCIFNJ;
			return this;
		}

		public NPKMNFBOOBJ BHJNGMMIGDM(PAJJBHMEFKE JNJFIEIKKHF)
		{
			HOFDFNMIALD = JNJFIEIKKHF;
			return this;
		}

		public NPKMNFBOOBJ FGCCCHPAHHC(byte[] ACHGIEJNJLJ)
		{
			BDLGALEIFIE = ACHGIEJNJLJ;
			return this;
		}

		public NPKMNFBOOBJ BHPEOAMFLEA(byte[] MNAJOGDKNIK)
		{
			IBAEFAPACBN = MNAJOGDKNIK;
			return this;
		}

		public NPKMNFBOOBJ LCNBALCMHOF(IDictionary LJDFGPJGHFH)
		{
			if (LJDFGPJGHFH == null)
			{
				BHBDNGNOKDF = null;
			}
			else
			{
				MemoryStream memoryStream = new MemoryStream();
				HEMGBKNMOKB.OIOOGHNFDII(memoryStream, LJDFGPJGHFH);
				BHBDNGNOKDF = memoryStream.ToArray();
			}
			return this;
		}

		private void PIBLOPJEGEL(bool CFGGBONGJNP, string FGPAPHKLKBL)
		{
			if (!CFGGBONGJNP)
			{
				throw new InvalidOperationException("Required session parameter '" + FGPAPHKLKBL + "' not configured");
			}
		}
	}

	private int PEPFODJEEKK;

	private byte DFKNNDLMMNC;

	private byte[] KKCHFFNALKO;

	private PAJJBHMEFKE HOFDFNMIALD;

	private byte[] BDLGALEIFIE;

	private byte[] IBAEFAPACBN;

	private byte[] BHBDNGNOKDF;

	public int LKCGPEEINAA
	{
		get
		{
			return PEPFODJEEKK;
		}
	}

	public byte OEFPAPDGGKJ
	{
		get
		{
			return DFKNNDLMMNC;
		}
	}

	public byte[] EFKBHGKOMBB
	{
		get
		{
			return KKCHFFNALKO;
		}
	}

	public PAJJBHMEFKE EFFPGMNMJBH
	{
		get
		{
			return HOFDFNMIALD;
		}
	}

	public byte[] HPLBKGHNLMB
	{
		get
		{
			return BDLGALEIFIE;
		}
	}

	public byte[] MIMODMJNDFP
	{
		get
		{
			return IBAEFAPACBN;
		}
	}

	private CBKKCJFENJM(int DHDNFGLNBGJ, byte KFCOFBMPANP, byte[] IENFDPCIFNJ, PAJJBHMEFKE JNJFIEIKKHF, byte[] ACHGIEJNJLJ, byte[] MNAJOGDKNIK, byte[] JMMECLNCLEG)
	{
		PEPFODJEEKK = DHDNFGLNBGJ;
		DFKNNDLMMNC = KFCOFBMPANP;
		KKCHFFNALKO = NOGCEBKPPJE.IKBFGGABMKP(IENFDPCIFNJ);
		HOFDFNMIALD = JNJFIEIKKHF;
		BDLGALEIFIE = NOGCEBKPPJE.IKBFGGABMKP(ACHGIEJNJLJ);
		IBAEFAPACBN = NOGCEBKPPJE.IKBFGGABMKP(MNAJOGDKNIK);
		BHBDNGNOKDF = JMMECLNCLEG;
	}

	public void BOPEPLONIFL()
	{
		if (KKCHFFNALKO != null)
		{
			NOGCEBKPPJE.MEBLOMPDLEJ(KKCHFFNALKO, 0);
		}
	}

	public CBKKCJFENJM FDCFKGAEJFF()
	{
		return new CBKKCJFENJM(PEPFODJEEKK, DFKNNDLMMNC, KKCHFFNALKO, HOFDFNMIALD, BDLGALEIFIE, IBAEFAPACBN, BHBDNGNOKDF);
	}

	public IDictionary IFGJJEBBBMJ()
	{
		if (BHBDNGNOKDF == null)
		{
			return null;
		}
		MemoryStream mOPCLEEGDFB = new MemoryStream(BHBDNGNOKDF, false);
		return HEMGBKNMOKB.JAOKJFGCGBB(mOPCLEEGDFB);
	}
}
