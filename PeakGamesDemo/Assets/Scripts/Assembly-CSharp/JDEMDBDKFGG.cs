using System;

public class JDEMDBDKFGG : IPMKHEFLFNC
{
	private readonly Random ACMDHKODAEC;

	public JDEMDBDKFGG()
	{
		ACMDHKODAEC = new Random();
	}

	public JDEMDBDKFGG(int HJBOEOOLOOE)
	{
		ACMDHKODAEC = new Random(HJBOEOOLOOE);
	}

	public int BDAKKAIBMIM()
	{
		return ACMDHKODAEC.Next();
	}

	public int BDAKKAIBMIM(int IJHGDODBFCD, int NHLJFKPLKLI)
	{
		return ACMDHKODAEC.Next(IJHGDODBFCD, NHLJFKPLKLI);
	}

	public double IJMGAMPJIAL()
	{
		return ACMDHKODAEC.NextDouble();
	}

	public IPMKHEFLFNC[] DOEJJMHNNNI(int AFKEAHDLGOC)
	{
		IPMKHEFLFNC[] array = new IPMKHEFLFNC[AFKEAHDLGOC];
		int num = BDAKKAIBMIM();
		for (int i = 0; i < AFKEAHDLGOC; i++)
		{
			array[i] = new JDEMDBDKFGG(num + i);
		}
		return array;
	}
}
