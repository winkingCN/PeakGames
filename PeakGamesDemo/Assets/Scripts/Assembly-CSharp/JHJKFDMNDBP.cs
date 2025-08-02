using System;

internal abstract class JHJKFDMNDBP
{
	private static readonly FBIJJFGLKMK NCJNJAOLOAK = new FBIJJFGLKMK();

	public static void LEIECFOMCNL(uint[] HPHBDNBJPHB, uint[] AMFCENFNAJJ, uint[] IGNEOOOFEMO)
	{
		int num = HPHBDNBJPHB.Length;
		if (BCMDHIIJKJE.EJJHHCOFAAI(num, AMFCENFNAJJ))
		{
			throw new ArgumentException("cannot be 0", "x");
		}
		if (BCMDHIIJKJE.EOJCHPEGABD(num, AMFCENFNAJJ))
		{
			Array.Copy(AMFCENFNAJJ, 0, IGNEOOOFEMO, 0, num);
			return;
		}
		uint[] array = BCMDHIIJKJE.FDCFKGAEJFF(num, AMFCENFNAJJ);
		uint[] array2 = BCMDHIIJKJE.PLIFFMMBNPM(num);
		array2[0] = 1u;
		int OPFLAMGBHDJ = 0;
		if ((array[0] & 1) == 0)
		{
			AJNFJLCKLNG(HPHBDNBJPHB, array, num, array2, ref OPFLAMGBHDJ);
		}
		if (BCMDHIIJKJE.EOJCHPEGABD(num, array))
		{
			AILPLEBOGMA(HPHBDNBJPHB, OPFLAMGBHDJ, array2, IGNEOOOFEMO);
			return;
		}
		uint[] array3 = BCMDHIIJKJE.FDCFKGAEJFF(num, HPHBDNBJPHB);
		uint[] array4 = BCMDHIIJKJE.PLIFFMMBNPM(num);
		int OPFLAMGBHDJ2 = 0;
		int num2 = num;
		while (true)
		{
			if (array[num2 - 1] == 0 && array3[num2 - 1] == 0)
			{
				num2--;
			}
			else if (BCMDHIIJKJE.CHCGDEIGIIA(num, array, array3))
			{
				BCMDHIIJKJE.DKAMAFLMHEJ(num, array3, array);
				OPFLAMGBHDJ += BCMDHIIJKJE.DKAMAFLMHEJ(num, array4, array2) - OPFLAMGBHDJ2;
				AJNFJLCKLNG(HPHBDNBJPHB, array, num2, array2, ref OPFLAMGBHDJ);
				if (BCMDHIIJKJE.EOJCHPEGABD(num, array))
				{
					AILPLEBOGMA(HPHBDNBJPHB, OPFLAMGBHDJ, array2, IGNEOOOFEMO);
					return;
				}
			}
			else
			{
				BCMDHIIJKJE.DKAMAFLMHEJ(num, array, array3);
				OPFLAMGBHDJ2 += BCMDHIIJKJE.DKAMAFLMHEJ(num, array2, array4) - OPFLAMGBHDJ;
				AJNFJLCKLNG(HPHBDNBJPHB, array3, num2, array4, ref OPFLAMGBHDJ2);
				if (BCMDHIIJKJE.EOJCHPEGABD(num, array3))
				{
					break;
				}
			}
		}
		AILPLEBOGMA(HPHBDNBJPHB, OPFLAMGBHDJ2, array4, IGNEOOOFEMO);
	}

	public static uint[] IPFKDIJBGIM(uint[] HPHBDNBJPHB)
	{
		int num = HPHBDNBJPHB.Length;
		uint[] array = BCMDHIIJKJE.PLIFFMMBNPM(num);
		uint num2 = HPHBDNBJPHB[num - 1];
		num2 |= num2 >> 1;
		num2 |= num2 >> 2;
		num2 |= num2 >> 4;
		num2 |= num2 >> 8;
		num2 |= num2 >> 16;
		do
		{
			byte[] array2 = new byte[num << 2];
			NCJNJAOLOAK.NextBytes(array2);
			PGOKFBKEOAB.EFODDMAJNOA(array2, 0, array);
			array[num - 1] &= num2;
		}
		while (BCMDHIIJKJE.CHCGDEIGIIA(num, array, HPHBDNBJPHB));
		return array;
	}

	public static void JEACJNAKLDJ(uint[] HPHBDNBJPHB, uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		int nBEDPKHALCN = HPHBDNBJPHB.Length;
		if (BCMDHIIJKJE.JEACJNAKLDJ(nBEDPKHALCN, AMFCENFNAJJ, CNLILOEEBOJ, IGNEOOOFEMO) != 0)
		{
			BCMDHIIJKJE.DKAMAFLMHEJ(nBEDPKHALCN, HPHBDNBJPHB, IGNEOOOFEMO);
		}
	}

	public static void FBGIHKPECCO(uint[] HPHBDNBJPHB, uint[] AMFCENFNAJJ, uint[] CNLILOEEBOJ, uint[] IGNEOOOFEMO)
	{
		int nBEDPKHALCN = HPHBDNBJPHB.Length;
		if (BCMDHIIJKJE.EAEONHFLEEN(nBEDPKHALCN, AMFCENFNAJJ, CNLILOEEBOJ, IGNEOOOFEMO) != 0)
		{
			BCMDHIIJKJE.MAALDEFJPJA(nBEDPKHALCN, HPHBDNBJPHB, IGNEOOOFEMO);
		}
	}

	private static void AILPLEBOGMA(uint[] HPHBDNBJPHB, int NMPOGEGPHCO, uint[] MNIMEAMHNMI, uint[] IGNEOOOFEMO)
	{
		if (NMPOGEGPHCO < 0)
		{
			BCMDHIIJKJE.JEACJNAKLDJ(HPHBDNBJPHB.Length, MNIMEAMHNMI, HPHBDNBJPHB, IGNEOOOFEMO);
		}
		else
		{
			Array.Copy(MNIMEAMHNMI, 0, IGNEOOOFEMO, 0, HPHBDNBJPHB.Length);
		}
	}

	private static void AJNFJLCKLNG(uint[] HPHBDNBJPHB, uint[] OJOAGEHFPNP, int KNEJCJAIPBG, uint[] AMFCENFNAJJ, ref int OPFLAMGBHDJ)
	{
		int nBEDPKHALCN = HPHBDNBJPHB.Length;
		int num = 0;
		while (OJOAGEHFPNP[0] == 0)
		{
			BCMDHIIJKJE.HDHPODLDFNA(KNEJCJAIPBG, OJOAGEHFPNP, 0u);
			num += 32;
		}
		int num2 = IDPIPDELCAC(OJOAGEHFPNP[0]);
		if (num2 > 0)
		{
			BCMDHIIJKJE.HKHBMKOABPB(KNEJCJAIPBG, OJOAGEHFPNP, num2, 0u);
			num += num2;
		}
		for (int i = 0; i < num; i++)
		{
			if ((AMFCENFNAJJ[0] & (true ? 1u : 0u)) != 0)
			{
				if (OPFLAMGBHDJ < 0)
				{
					OPFLAMGBHDJ += (int)BCMDHIIJKJE.MAALDEFJPJA(nBEDPKHALCN, HPHBDNBJPHB, AMFCENFNAJJ);
				}
				else
				{
					OPFLAMGBHDJ += BCMDHIIJKJE.DKAMAFLMHEJ(nBEDPKHALCN, HPHBDNBJPHB, AMFCENFNAJJ);
				}
			}
			BCMDHIIJKJE.POFAGJIFAIH(nBEDPKHALCN, AMFCENFNAJJ, (uint)OPFLAMGBHDJ);
		}
	}

	private static int IDPIPDELCAC(uint AMFCENFNAJJ)
	{
		int num = 0;
		while ((AMFCENFNAJJ & 1) == 0)
		{
			AMFCENFNAJJ >>= 1;
			num++;
		}
		return num;
	}
}
