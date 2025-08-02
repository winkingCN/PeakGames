public class CHJPDADMMGA : JABKGMPDKHJ
{
	private byte[] JGOHMOHEFMJ;

	private uint[][][] IGBPKOOBCMA;

	public void DIOELAHNLKJ(byte[] JGOHMOHEFMJ)
	{
		if (IGBPKOOBCMA == null)
		{
			IGBPKOOBCMA = new uint[32][][];
		}
		else if (NOGCEBKPPJE.ICKLINNFHKK(this.JGOHMOHEFMJ, JGOHMOHEFMJ))
		{
			return;
		}
		this.JGOHMOHEFMJ = NOGCEBKPPJE.IKBFGGABMKP(JGOHMOHEFMJ);
		IGBPKOOBCMA[0] = new uint[16][];
		IGBPKOOBCMA[1] = new uint[16][];
		IGBPKOOBCMA[0][0] = new uint[4];
		IGBPKOOBCMA[1][0] = new uint[4];
		IGBPKOOBCMA[1][8] = HIHDNGIBEPL.BGPMEOHBNNA(JGOHMOHEFMJ);
		for (int num = 4; num >= 1; num >>= 1)
		{
			uint[] array = (uint[])IGBPKOOBCMA[1][num + num].Clone();
			HIHDNGIBEPL.EAKOALEEBHG(array);
			IGBPKOOBCMA[1][num] = array;
		}
		uint[] array2 = (uint[])IGBPKOOBCMA[1][1].Clone();
		HIHDNGIBEPL.EAKOALEEBHG(array2);
		IGBPKOOBCMA[0][8] = array2;
		for (int num2 = 4; num2 >= 1; num2 >>= 1)
		{
			uint[] array3 = (uint[])IGBPKOOBCMA[0][num2 + num2].Clone();
			HIHDNGIBEPL.EAKOALEEBHG(array3);
			IGBPKOOBCMA[0][num2] = array3;
		}
		int num3 = 0;
		while (true)
		{
			for (int i = 2; i < 16; i += i)
			{
				for (int j = 1; j < i; j++)
				{
					uint[] array4 = (uint[])IGBPKOOBCMA[num3][i].Clone();
					HIHDNGIBEPL.FHLALGENPPH(array4, IGBPKOOBCMA[num3][j]);
					IGBPKOOBCMA[num3][i + j] = array4;
				}
			}
			if (++num3 == 32)
			{
				break;
			}
			if (num3 > 1)
			{
				IGBPKOOBCMA[num3] = new uint[16][];
				IGBPKOOBCMA[num3][0] = new uint[4];
				for (int num4 = 8; num4 > 0; num4 >>= 1)
				{
					uint[] array5 = (uint[])IGBPKOOBCMA[num3 - 2][num4].Clone();
					HIHDNGIBEPL.BOOLMKNPOON(array5);
					IGBPKOOBCMA[num3][num4] = array5;
				}
			}
		}
	}

	public void BJCNKBAIJHD(byte[] AMFCENFNAJJ)
	{
		uint[] array = new uint[4];
		for (int num = 15; num >= 0; num--)
		{
			uint[] array2 = IGBPKOOBCMA[num + num][AMFCENFNAJJ[num] & 0xF];
			array[0] ^= array2[0];
			array[1] ^= array2[1];
			array[2] ^= array2[2];
			array[3] ^= array2[3];
			array2 = IGBPKOOBCMA[num + num + 1][(AMFCENFNAJJ[num] & 0xF0) >> 4];
			array[0] ^= array2[0];
			array[1] ^= array2[1];
			array[2] ^= array2[2];
			array[3] ^= array2[3];
		}
		PGOKFBKEOAB.MPMAFPANDLC(array, AMFCENFNAJJ, 0);
	}
}
