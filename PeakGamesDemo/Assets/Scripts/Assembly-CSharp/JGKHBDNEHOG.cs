using System;

public class JGKHBDNEHOG : NDIFOGFDKLL
{
	public override string KFKMEPMEBND
	{
		get
		{
			return "ChaCha" + DFKIEEIDJNM;
		}
	}

	protected override int BMPJMJODKPP
	{
		get
		{
			return 12;
		}
	}

	protected override void PFOIANPLIKG()
	{
		if (++EMECPLDAING[12] == 0)
		{
			throw new InvalidOperationException("attempt to increase counter past 2^32.");
		}
	}

	protected override void IFCPCMANPPN()
	{
		EMECPLDAING[12] = 0u;
	}

	protected override void KBEFMBDOIJH(byte[] EGJBACEEHAK, byte[] MIMCBAKIPJC)
	{
		if (EGJBACEEHAK != null)
		{
			if (EGJBACEEHAK.Length != 32)
			{
				throw new ArgumentException(KFKMEPMEBND + " requires 256 bit key");
			}
			HIMDNDGCMAP(EGJBACEEHAK.Length, EMECPLDAING, 0);
			PGOKFBKEOAB.LAJPMLKCDOH(EGJBACEEHAK, 0, EMECPLDAING, 4, 8);
		}
		PGOKFBKEOAB.LAJPMLKCDOH(MIMCBAKIPJC, 0, EMECPLDAING, 13, 3);
	}

	protected override void EJPOGNHMIMH(byte[] BILGCJNPJGJ)
	{
		HEHOKHDBPME.OEMMEMGGABO(DFKIEEIDJNM, EMECPLDAING, AMFCENFNAJJ);
		PGOKFBKEOAB.LGJFKMLLKLN(AMFCENFNAJJ, BILGCJNPJGJ, 0);
	}
}
