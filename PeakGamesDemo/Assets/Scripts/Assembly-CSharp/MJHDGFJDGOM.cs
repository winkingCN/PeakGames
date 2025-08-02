internal struct MJHDGFJDGOM
{
	public int PENJCGPCHHD;

	public int EMNDJNDGANP;

	public MJHDGFJDGOM(string EDDNOJDPMCF)
	{
		this = default(MJHDGFJDGOM);
		DIOELAHNLKJ();
		if (!string.IsNullOrEmpty(EDDNOJDPMCF))
		{
			string[] array = EDDNOJDPMCF.Split(':');
			switch (array.Length)
			{
			case 1:
				int.TryParse(array[0], out PENJCGPCHHD);
				break;
			case 2:
				int.TryParse(array[0], out PENJCGPCHHD);
				int.TryParse(array[1], out EMNDJNDGANP);
				break;
			}
		}
	}

	public override string ToString()
	{
		return PENJCGPCHHD.ToString() + ':' + EMNDJNDGANP;
	}

	private void DIOELAHNLKJ()
	{
		PENJCGPCHHD = 0;
		EMNDJNDGANP = 0;
	}
}
