public class CFMCPELOOJN : MFAGLJBAHJO
{
	public override string KFKMEPMEBND
	{
		get
		{
			return "VMPC-KSA3";
		}
	}

	protected override void DKCFCKLGLII(byte[] EGJBACEEHAK, byte[] MIMCBAKIPJC)
	{
		IBBBMACIBGK = 0;
		MBIJHANOCOC = new byte[256];
		for (int i = 0; i < 256; i++)
		{
			MBIJHANOCOC[i] = (byte)i;
		}
		for (int j = 0; j < 768; j++)
		{
			IBBBMACIBGK = MBIJHANOCOC[(IBBBMACIBGK + MBIJHANOCOC[j & 0xFF] + EGJBACEEHAK[j % EGJBACEEHAK.Length]) & 0xFF];
			byte b = MBIJHANOCOC[j & 0xFF];
			MBIJHANOCOC[j & 0xFF] = MBIJHANOCOC[IBBBMACIBGK & 0xFF];
			MBIJHANOCOC[IBBBMACIBGK & 0xFF] = b;
		}
		for (int k = 0; k < 768; k++)
		{
			IBBBMACIBGK = MBIJHANOCOC[(IBBBMACIBGK + MBIJHANOCOC[k & 0xFF] + MIMCBAKIPJC[k % MIMCBAKIPJC.Length]) & 0xFF];
			byte b2 = MBIJHANOCOC[k & 0xFF];
			MBIJHANOCOC[k & 0xFF] = MBIJHANOCOC[IBBBMACIBGK & 0xFF];
			MBIJHANOCOC[IBBBMACIBGK & 0xFF] = b2;
		}
		for (int l = 0; l < 768; l++)
		{
			IBBBMACIBGK = MBIJHANOCOC[(IBBBMACIBGK + MBIJHANOCOC[l & 0xFF] + EGJBACEEHAK[l % EGJBACEEHAK.Length]) & 0xFF];
			byte b3 = MBIJHANOCOC[l & 0xFF];
			MBIJHANOCOC[l & 0xFF] = MBIJHANOCOC[IBBBMACIBGK & 0xFF];
			MBIJHANOCOC[IBBBMACIBGK & 0xFF] = b3;
		}
		IDHLPOFDLKJ = 0;
	}
}
