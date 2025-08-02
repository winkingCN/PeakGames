using System;

public class JOHKKFDDOBA : KPMKFMEEJCJ
{
	private uint[] HPHBDNBJPHB = new uint[1024];

	private uint[] OKDPJHOEPBJ = new uint[1024];

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
			return "HC-256";
		}
	}

	private uint IJAKCGOLDGK()
	{
		uint num = HKNBMOKPJBM & 0x3FFu;
		uint result;
		if (HKNBMOKPJBM < 1024)
		{
			uint num2 = HPHBDNBJPHB[(num - 3) & 0x3FF];
			uint num3 = HPHBDNBJPHB[(num - 1023) & 0x3FF];
			HPHBDNBJPHB[num] += HPHBDNBJPHB[(num - 10) & 0x3FF] + (AIFAMJPHAAF(num2, 10) ^ AIFAMJPHAAF(num3, 23)) + OKDPJHOEPBJ[(num2 ^ num3) & 0x3FF];
			num2 = HPHBDNBJPHB[(num - 12) & 0x3FF];
			result = (OKDPJHOEPBJ[num2 & 0xFF] + OKDPJHOEPBJ[((num2 >> 8) & 0xFF) + 256] + OKDPJHOEPBJ[((num2 >> 16) & 0xFF) + 512] + OKDPJHOEPBJ[((num2 >> 24) & 0xFF) + 768]) ^ HPHBDNBJPHB[num];
		}
		else
		{
			uint num4 = OKDPJHOEPBJ[(num - 3) & 0x3FF];
			uint num5 = OKDPJHOEPBJ[(num - 1023) & 0x3FF];
			OKDPJHOEPBJ[num] += OKDPJHOEPBJ[(num - 10) & 0x3FF] + (AIFAMJPHAAF(num4, 10) ^ AIFAMJPHAAF(num5, 23)) + HPHBDNBJPHB[(num4 ^ num5) & 0x3FF];
			num4 = OKDPJHOEPBJ[(num - 12) & 0x3FF];
			result = (HPHBDNBJPHB[num4 & 0xFF] + HPHBDNBJPHB[((num4 >> 8) & 0xFF) + 256] + HPHBDNBJPHB[((num4 >> 16) & 0xFF) + 512] + HPHBDNBJPHB[((num4 >> 24) & 0xFF) + 768]) ^ OKDPJHOEPBJ[num];
		}
		HKNBMOKPJBM = (HKNBMOKPJBM + 1) & 0x7FFu;
		return result;
	}

	private void DIOELAHNLKJ()
	{
		if (IKNCPEPOKGJ.Length != 32 && IKNCPEPOKGJ.Length != 16)
		{
			throw new ArgumentException("The key must be 128/256 bits long");
		}
		if (NDEFBOJOALL.Length < 16)
		{
			throw new ArgumentException("The IV must be at least 128 bits long");
		}
		if (IKNCPEPOKGJ.Length != 32)
		{
			byte[] array = new byte[32];
			Array.Copy(IKNCPEPOKGJ, 0, array, 0, IKNCPEPOKGJ.Length);
			Array.Copy(IKNCPEPOKGJ, 0, array, 16, IKNCPEPOKGJ.Length);
			IKNCPEPOKGJ = array;
		}
		if (NDEFBOJOALL.Length < 32)
		{
			byte[] array2 = new byte[32];
			Array.Copy(NDEFBOJOALL, 0, array2, 0, NDEFBOJOALL.Length);
			Array.Copy(NDEFBOJOALL, 0, array2, NDEFBOJOALL.Length, array2.Length - NDEFBOJOALL.Length);
			NDEFBOJOALL = array2;
		}
		MMLIOLEILLO = 0;
		HKNBMOKPJBM = 0u;
		uint[] array3 = new uint[2560];
		for (int i = 0; i < 32; i++)
		{
			array3[i >> 2] |= (uint)(IKNCPEPOKGJ[i] << 8 * (i & 3));
		}
		for (int j = 0; j < 32; j++)
		{
			array3[(j >> 2) + 8] |= (uint)(NDEFBOJOALL[j] << 8 * (j & 3));
		}
		for (uint num = 16u; num < 2560; num++)
		{
			uint num2 = array3[num - 2];
			uint num3 = array3[num - 15];
			array3[num] = (AIFAMJPHAAF(num2, 17) ^ AIFAMJPHAAF(num2, 19) ^ (num2 >> 10)) + array3[num - 7] + (AIFAMJPHAAF(num3, 7) ^ AIFAMJPHAAF(num3, 18) ^ (num3 >> 3)) + array3[num - 16] + num;
		}
		Array.Copy(array3, 512, HPHBDNBJPHB, 0, 1024);
		Array.Copy(array3, 1536, OKDPJHOEPBJ, 0, 1024);
		for (int k = 0; k < 4096; k++)
		{
			IJAKCGOLDGK();
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
		throw new ArgumentException("Invalid parameter passed to HC256 init - " + LHFGHNFJIKM.JKHOEKAOLPM(IJJHBEECMBP), "parameters");
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

	private static uint AIFAMJPHAAF(uint AMFCENFNAJJ, int IODPDKHNDIE)
	{
		return (AMFCENFNAJJ >> IODPDKHNDIE) | (AMFCENFNAJJ << -IODPDKHNDIE);
	}
}
