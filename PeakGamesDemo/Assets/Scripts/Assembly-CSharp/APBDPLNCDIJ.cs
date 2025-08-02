public struct APBDPLNCDIJ
{
	public readonly int ENBPGGCIADN;

	public readonly int EEFMIHDPJPG;

	public bool MCMDJCBFENO
	{
		get
		{
			return ENBPGGCIADN == 6 || ENBPGGCIADN == 8 || ENBPGGCIADN == 10 || ENBPGGCIADN == 12 || ENBPGGCIADN == 7 || ENBPGGCIADN == 9 || ENBPGGCIADN == 11 || ENBPGGCIADN == 14 || ENBPGGCIADN == 15 || ENBPGGCIADN == 13;
		}
	}

	public bool JKJHJDLHCMD
	{
		get
		{
			return ENBPGGCIADN == 5 || ENBPGGCIADN == 3 || ENBPGGCIADN == 4;
		}
	}

	public bool AFAAILGMEBN
	{
		get
		{
			return ENBPGGCIADN == 2 || ENBPGGCIADN == 10;
		}
	}

	public APBDPLNCDIJ(int NBFBPNNEKMN, int BDKFNEDHAOJ)
	{
		ENBPGGCIADN = NBFBPNNEKMN;
		EEFMIHDPJPG = BDKFNEDHAOJ;
	}

	public override string ToString()
	{
		return ENBPGGCIADN + "_" + EEFMIHDPJPG;
	}
}
