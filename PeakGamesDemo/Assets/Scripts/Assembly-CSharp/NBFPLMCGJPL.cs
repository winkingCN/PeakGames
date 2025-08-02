using System;

public class NBFPLMCGJPL : KPMKFMEEJCJ
{
	private uint[] HPHBDNBJPHB = new uint[512];

	private uint[] OKDPJHOEPBJ = new uint[512];

	private uint HKNBMOKPJBM;

	private byte[] IKNCPEPOKGJ;

	private byte[] NDEFBOJOALL;

	private bool HJBGFGMEOOD;

	private byte[] GHPCHPOHELF = new byte[4];

	private int MMLIOLEILLO;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return "HC-128";
		}
	}

	private static uint HBFJAOFJIFP(uint AMFCENFNAJJ)
	{
		return AIFAMJPHAAF(AMFCENFNAJJ, 7) ^ AIFAMJPHAAF(AMFCENFNAJJ, 18) ^ (AMFCENFNAJJ >> 3);
	}

	private static uint IKKGCFMJODC(uint AMFCENFNAJJ)
	{
		return AIFAMJPHAAF(AMFCENFNAJJ, 17) ^ AIFAMJPHAAF(AMFCENFNAJJ, 19) ^ (AMFCENFNAJJ >> 10);
	}

	private uint OENMHODKPOE(uint AMFCENFNAJJ, uint CNLILOEEBOJ, uint IGNEOOOFEMO)
	{
		return (AIFAMJPHAAF(AMFCENFNAJJ, 10) ^ AIFAMJPHAAF(IGNEOOOFEMO, 23)) + AIFAMJPHAAF(CNLILOEEBOJ, 8);
	}

	private uint ACBLCPEFOMO(uint AMFCENFNAJJ, uint CNLILOEEBOJ, uint IGNEOOOFEMO)
	{
		return (MBBDJFKAACD(AMFCENFNAJJ, 10) ^ MBBDJFKAACD(IGNEOOOFEMO, 23)) + MBBDJFKAACD(CNLILOEEBOJ, 8);
	}

	private static uint MBBDJFKAACD(uint AMFCENFNAJJ, int IODPDKHNDIE)
	{
		return (AMFCENFNAJJ << IODPDKHNDIE) | (AMFCENFNAJJ >> -IODPDKHNDIE);
	}

	private static uint AIFAMJPHAAF(uint AMFCENFNAJJ, int IODPDKHNDIE)
	{
		return (AMFCENFNAJJ >> IODPDKHNDIE) | (AMFCENFNAJJ << -IODPDKHNDIE);
	}

	private uint NAHACOBOKIM(uint AMFCENFNAJJ)
	{
		return OKDPJHOEPBJ[AMFCENFNAJJ & 0xFF] + OKDPJHOEPBJ[((AMFCENFNAJJ >> 16) & 0xFF) + 256];
	}

	private uint MPNNHCHGEGL(uint AMFCENFNAJJ)
	{
		return HPHBDNBJPHB[AMFCENFNAJJ & 0xFF] + HPHBDNBJPHB[((AMFCENFNAJJ >> 16) & 0xFF) + 256];
	}

	private static uint AHPKNANNOGL(uint AMFCENFNAJJ)
	{
		return AMFCENFNAJJ & 0x3FFu;
	}

	private static uint ENOBFJILOAM(uint AMFCENFNAJJ)
	{
		return AMFCENFNAJJ & 0x1FFu;
	}

	private static uint DOEFBJMBEMB(uint AMFCENFNAJJ, uint CNLILOEEBOJ)
	{
		return ENOBFJILOAM(AMFCENFNAJJ - CNLILOEEBOJ);
	}

	private uint IJAKCGOLDGK()
	{
		uint num = ENOBFJILOAM(HKNBMOKPJBM);
		uint result;
		if (HKNBMOKPJBM < 512)
		{
			HPHBDNBJPHB[num] += OENMHODKPOE(HPHBDNBJPHB[DOEFBJMBEMB(num, 3u)], HPHBDNBJPHB[DOEFBJMBEMB(num, 10u)], HPHBDNBJPHB[DOEFBJMBEMB(num, 511u)]);
			result = NAHACOBOKIM(HPHBDNBJPHB[DOEFBJMBEMB(num, 12u)]) ^ HPHBDNBJPHB[num];
		}
		else
		{
			OKDPJHOEPBJ[num] += ACBLCPEFOMO(OKDPJHOEPBJ[DOEFBJMBEMB(num, 3u)], OKDPJHOEPBJ[DOEFBJMBEMB(num, 10u)], OKDPJHOEPBJ[DOEFBJMBEMB(num, 511u)]);
			result = MPNNHCHGEGL(OKDPJHOEPBJ[DOEFBJMBEMB(num, 12u)]) ^ OKDPJHOEPBJ[num];
		}
		HKNBMOKPJBM = AHPKNANNOGL(HKNBMOKPJBM + 1);
		return result;
	}

	private void DIOELAHNLKJ()
	{
		if (IKNCPEPOKGJ.Length != 16)
		{
			throw new ArgumentException("The key must be 128 bits long");
		}
		MMLIOLEILLO = 0;
		HKNBMOKPJBM = 0u;
		uint[] array = new uint[1280];
		for (int i = 0; i < 16; i++)
		{
			array[i >> 2] |= (uint)(IKNCPEPOKGJ[i] << 8 * (i & 3));
		}
		Array.Copy(array, 0, array, 4, 4);
		for (int j = 0; j < NDEFBOJOALL.Length && j < 16; j++)
		{
			array[(j >> 2) + 8] |= (uint)(NDEFBOJOALL[j] << 8 * (j & 3));
		}
		Array.Copy(array, 8, array, 12, 4);
		for (uint num = 16u; num < 1280; num++)
		{
			array[num] = IKKGCFMJODC(array[num - 2]) + array[num - 7] + HBFJAOFJIFP(array[num - 15]) + array[num - 16] + num;
		}
		Array.Copy(array, 256, HPHBDNBJPHB, 0, 512);
		Array.Copy(array, 768, OKDPJHOEPBJ, 0, 512);
		for (int k = 0; k < 512; k++)
		{
			HPHBDNBJPHB[k] = IJAKCGOLDGK();
		}
		for (int l = 0; l < 512; l++)
		{
			OKDPJHOEPBJ[l] = IJAKCGOLDGK();
		}
		HKNBMOKPJBM = 0u;
	}

	public virtual void DIOELAHNLKJ(bool MAEALKEJALK, IGMAJHKIIPK IJJHBEECMBP)
	{
		IGMAJHKIIPK iGMAJHKIIPK = IJJHBEECMBP;
		if (IJJHBEECMBP is CHCELGDKEJG)
		{
			NDEFBOJOALL = ((CHCELGDKEJG)IJJHBEECMBP).OLAEDCABKDH();
			iGMAJHKIIPK = ((CHCELGDKEJG)IJJHBEECMBP).KPJHHAAOFOH;
		}
		else
		{
			NDEFBOJOALL = new byte[0];
		}
		if (iGMAJHKIIPK is JEMNCGMEABF)
		{
			IKNCPEPOKGJ = ((JEMNCGMEABF)iGMAJHKIIPK).MEGBFHFMBFI();
			DIOELAHNLKJ();
			HJBGFGMEOOD = true;
			return;
		}
		throw new ArgumentException("Invalid parameter passed to HC128 init - " + LHFGHNFJIKM.JKHOEKAOLPM(IJJHBEECMBP), "parameters");
	}

	private byte NHNIFDEOFMI()
	{
		if (MMLIOLEILLO == 0)
		{
			PGOKFBKEOAB.LGJFKMLLKLN(IJAKCGOLDGK(), GHPCHPOHELF);
		}
		byte result = GHPCHPOHELF[MMLIOLEILLO];
		MMLIOLEILLO = (MMLIOLEILLO + 1) & 3;
		return result;
	}

	public virtual void POCAGALIPAI(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int NBEDPKHALCN, byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		if (!HJBGFGMEOOD)
		{
			throw new InvalidOperationException(KFKMEPMEBND + " not initialised");
		}
		AJLDFGNHDCA.OONDALLFPOP(MOPCLEEGDFB, ELICNEDIBGB, NBEDPKHALCN, "input buffer too short");
		AJLDFGNHDCA.KLPNFGNKNKB(BILGCJNPJGJ, EMAKNGBIFDC, NBEDPKHALCN, "output buffer too short");
		for (int i = 0; i < NBEDPKHALCN; i++)
		{
			BILGCJNPJGJ[EMAKNGBIFDC + i] = (byte)(MOPCLEEGDFB[ELICNEDIBGB + i] ^ NHNIFDEOFMI());
		}
	}

	public virtual void OMOKOKFNBKI()
	{
		DIOELAHNLKJ();
	}

	public virtual byte IODEANDNHIP(byte MOPCLEEGDFB)
	{
		return (byte)(MOPCLEEGDFB ^ NHNIFDEOFMI());
	}
}
