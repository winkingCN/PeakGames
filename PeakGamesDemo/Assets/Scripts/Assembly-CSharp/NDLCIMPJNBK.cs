using System;
using Org.BouncyCastle.Crypto;

public class NDLCIMPJNBK : ELPLEOMOHKE, OHPHNNNHCOO
{
	[Obsolete("Use 'IsoTrailers' instead")]
	public const int CJEMBIDPFHM = 188;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int LNHDCJNILNM = 12748;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int DOHINCGONNA = 13004;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int KLFJBJPLDAO = 13260;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int NPAGJFHJOME = 13516;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int HCFKJDPCKFJ = 13772;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int OPLECMFLFDL = 14028;

	[Obsolete("Use 'IsoTrailers' instead")]
	public const int LEOOGAIGKHG = 14284;

	private BJLAMONNNDD HABFKBCEIBN;

	private DGCIOOEELCP IEDPBFAFGGJ;

	private int EHGIDJJNLAM;

	private int FBLNDPJFNJB;

	private byte[] OJEJPICFOOJ;

	private byte[] ELMKEGBBDON;

	private int NEKAMHFGANJ;

	private bool PEIBGJNCCPN;

	private byte[] PFFMOHBAJKM;

	private byte[] FPGCDNDMFLE;

	private byte[] GMHEAKNNACB;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return HABFKBCEIBN.KFKMEPMEBND + "withISO9796-2S1";
		}
	}

	public NDLCIMPJNBK(DGCIOOEELCP IEDPBFAFGGJ, BJLAMONNNDD HABFKBCEIBN, bool DNLBBOCJHCM)
	{
		this.IEDPBFAFGGJ = IEDPBFAFGGJ;
		this.HABFKBCEIBN = HABFKBCEIBN;
		if (DNLBBOCJHCM)
		{
			EHGIDJJNLAM = 188;
			return;
		}
		if (LLINHKMIBFP.PMLGCANEMIO(HABFKBCEIBN))
		{
			throw new ArgumentException("no valid trailer", "digest");
		}
		EHGIDJJNLAM = LLINHKMIBFP.LFDPFEKIKII(HABFKBCEIBN);
	}

	public NDLCIMPJNBK(DGCIOOEELCP IEDPBFAFGGJ, BJLAMONNNDD HABFKBCEIBN)
		: this(IEDPBFAFGGJ, HABFKBCEIBN, false)
	{
	}

	public byte[] ADMOEDKFFKF()
	{
		return PFFMOHBAJKM;
	}

	public virtual void DIOELAHNLKJ(bool KGPBDABMHKH, IGMAJHKIIPK IJJHBEECMBP)
	{
		PLGGNEJEIIP pLGGNEJEIIP = (PLGGNEJEIIP)IJJHBEECMBP;
		IEDPBFAFGGJ.DIOELAHNLKJ(KGPBDABMHKH, pLGGNEJEIIP);
		FBLNDPJFNJB = pLGGNEJEIIP.FILOMPHGFKD.BitLength;
		OJEJPICFOOJ = new byte[(FBLNDPJFNJB + 7) / 8];
		if (EHGIDJJNLAM == 188)
		{
			ELMKEGBBDON = new byte[OJEJPICFOOJ.Length - HABFKBCEIBN.EEMLLAMENHO() - 2];
		}
		else
		{
			ELMKEGBBDON = new byte[OJEJPICFOOJ.Length - HABFKBCEIBN.EEMLLAMENHO() - 3];
		}
		OMOKOKFNBKI();
	}

	private bool DODLHJDJNHO(byte[] MNIMEAMHNMI, byte[] BCIHLCMFAEK)
	{
		int num;
		if (NEKAMHFGANJ > ELMKEGBBDON.Length)
		{
			if (ELMKEGBBDON.Length > BCIHLCMFAEK.Length)
			{
				return false;
			}
			num = ELMKEGBBDON.Length;
		}
		else
		{
			if (NEKAMHFGANJ != BCIHLCMFAEK.Length)
			{
				return false;
			}
			num = BCIHLCMFAEK.Length;
		}
		bool result = true;
		for (int i = 0; i != num; i++)
		{
			if (MNIMEAMHNMI[i] != BCIHLCMFAEK[i])
			{
				result = false;
			}
		}
		return result;
	}

	private void JKBFMHJLGDI(byte[] OJEJPICFOOJ)
	{
		Array.Clear(OJEJPICFOOJ, 0, OJEJPICFOOJ.Length);
	}

	public virtual void LCDJEAPCAHC(byte[] PINNJBGMGOA)
	{
		byte[] array = IEDPBFAFGGJ.DPACJDFHLKB(PINNJBGMGOA, 0, PINNJBGMGOA.Length);
		if (((array[0] & 0xC0u) ^ 0x40u) != 0)
		{
			throw new InvalidCipherTextException("malformed signature");
		}
		if (((array[array.Length - 1] & 0xFu) ^ 0xCu) != 0)
		{
			throw new InvalidCipherTextException("malformed signature");
		}
		int num = 0;
		if (((array[array.Length - 1] & 0xFF) ^ 0xBC) == 0)
		{
			num = 1;
		}
		else
		{
			int num2 = ((array[array.Length - 2] & 0xFF) << 8) | (array[array.Length - 1] & 0xFF);
			if (LLINHKMIBFP.PMLGCANEMIO(HABFKBCEIBN))
			{
				throw new ArgumentException("unrecognised hash in signature");
			}
			if (num2 != LLINHKMIBFP.LFDPFEKIKII(HABFKBCEIBN))
			{
				throw new InvalidOperationException("signer initialised with wrong digest for trailer " + num2);
			}
			num = 2;
		}
		int num3 = 0;
		for (num3 = 0; num3 != array.Length && ((array[num3] & 0xFu) ^ 0xAu) != 0; num3++)
		{
		}
		num3++;
		int num4 = array.Length - num - HABFKBCEIBN.EEMLLAMENHO();
		if (num4 - num3 <= 0)
		{
			throw new InvalidCipherTextException("malformed block");
		}
		if ((array[0] & 0x20) == 0)
		{
			PEIBGJNCCPN = true;
			PFFMOHBAJKM = new byte[num4 - num3];
			Array.Copy(array, num3, PFFMOHBAJKM, 0, PFFMOHBAJKM.Length);
		}
		else
		{
			PEIBGJNCCPN = false;
			PFFMOHBAJKM = new byte[num4 - num3];
			Array.Copy(array, num3, PFFMOHBAJKM, 0, PFFMOHBAJKM.Length);
		}
		FPGCDNDMFLE = PINNJBGMGOA;
		GMHEAKNNACB = array;
		HABFKBCEIBN.GONEEEFEDGF(PFFMOHBAJKM, 0, PFFMOHBAJKM.Length);
		NEKAMHFGANJ = PFFMOHBAJKM.Length;
		PFFMOHBAJKM.CopyTo(ELMKEGBBDON, 0);
	}

	public virtual void BPAJGOINFNL(byte MOPCLEEGDFB)
	{
		HABFKBCEIBN.BPAJGOINFNL(MOPCLEEGDFB);
		if (NEKAMHFGANJ < ELMKEGBBDON.Length)
		{
			ELMKEGBBDON[NEKAMHFGANJ] = MOPCLEEGDFB;
		}
		NEKAMHFGANJ++;
	}

	public virtual void GONEEEFEDGF(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int EOFAGACBNFP)
	{
		while (EOFAGACBNFP > 0 && NEKAMHFGANJ < ELMKEGBBDON.Length)
		{
			BPAJGOINFNL(MOPCLEEGDFB[ELICNEDIBGB]);
			ELICNEDIBGB++;
			EOFAGACBNFP--;
		}
		HABFKBCEIBN.GONEEEFEDGF(MOPCLEEGDFB, ELICNEDIBGB, EOFAGACBNFP);
		NEKAMHFGANJ += EOFAGACBNFP;
	}

	public virtual void OMOKOKFNBKI()
	{
		HABFKBCEIBN.OMOKOKFNBKI();
		NEKAMHFGANJ = 0;
		JKBFMHJLGDI(ELMKEGBBDON);
		if (PFFMOHBAJKM != null)
		{
			JKBFMHJLGDI(PFFMOHBAJKM);
		}
		PFFMOHBAJKM = null;
		PEIBGJNCCPN = false;
		if (FPGCDNDMFLE != null)
		{
			FPGCDNDMFLE = null;
			JKBFMHJLGDI(GMHEAKNNACB);
			GMHEAKNNACB = null;
		}
	}

	public virtual byte[] HMJHAKCMGHC()
	{
		int num = HABFKBCEIBN.EEMLLAMENHO();
		int num2 = 0;
		int num3 = 0;
		if (EHGIDJJNLAM == 188)
		{
			num2 = 8;
			num3 = OJEJPICFOOJ.Length - num - 1;
			HABFKBCEIBN.LCNOFBMOHHM(OJEJPICFOOJ, num3);
			OJEJPICFOOJ[OJEJPICFOOJ.Length - 1] = 188;
		}
		else
		{
			num2 = 16;
			num3 = OJEJPICFOOJ.Length - num - 2;
			HABFKBCEIBN.LCNOFBMOHHM(OJEJPICFOOJ, num3);
			OJEJPICFOOJ[OJEJPICFOOJ.Length - 2] = (byte)((uint)EHGIDJJNLAM >> 8);
			OJEJPICFOOJ[OJEJPICFOOJ.Length - 1] = (byte)EHGIDJJNLAM;
		}
		byte b = 0;
		int num4 = (num + NEKAMHFGANJ) * 8 + num2 + 4 - FBLNDPJFNJB;
		if (num4 > 0)
		{
			int num5 = NEKAMHFGANJ - (num4 + 7) / 8;
			b = 96;
			num3 -= num5;
			Array.Copy(ELMKEGBBDON, 0, OJEJPICFOOJ, num3, num5);
		}
		else
		{
			b = 64;
			num3 -= NEKAMHFGANJ;
			Array.Copy(ELMKEGBBDON, 0, OJEJPICFOOJ, num3, NEKAMHFGANJ);
		}
		if (num3 - 1 > 0)
		{
			for (int num6 = num3 - 1; num6 != 0; num6--)
			{
				OJEJPICFOOJ[num6] = 187;
			}
			OJEJPICFOOJ[num3 - 1] ^= 1;
			OJEJPICFOOJ[0] = 11;
			OJEJPICFOOJ[0] |= b;
		}
		else
		{
			OJEJPICFOOJ[0] = 10;
			OJEJPICFOOJ[0] |= b;
		}
		byte[] result = IEDPBFAFGGJ.DPACJDFHLKB(OJEJPICFOOJ, 0, OJEJPICFOOJ.Length);
		JKBFMHJLGDI(ELMKEGBBDON);
		JKBFMHJLGDI(OJEJPICFOOJ);
		return result;
	}

	public virtual bool HLJBBONKPDG(byte[] PINNJBGMGOA)
	{
		byte[] array;
		if (FPGCDNDMFLE == null)
		{
			try
			{
				array = IEDPBFAFGGJ.DPACJDFHLKB(PINNJBGMGOA, 0, PINNJBGMGOA.Length);
			}
			catch (Exception)
			{
				return false;
			}
		}
		else
		{
			if (!NOGCEBKPPJE.ICKLINNFHKK(FPGCDNDMFLE, PINNJBGMGOA))
			{
				throw new InvalidOperationException("updateWithRecoveredMessage called on different signature");
			}
			array = GMHEAKNNACB;
			FPGCDNDMFLE = null;
			GMHEAKNNACB = null;
		}
		if (((array[0] & 0xC0u) ^ 0x40u) != 0)
		{
			return HNCPKONGJOB(array);
		}
		if (((array[array.Length - 1] & 0xFu) ^ 0xCu) != 0)
		{
			return HNCPKONGJOB(array);
		}
		int num = 0;
		if (((array[array.Length - 1] & 0xFF) ^ 0xBC) == 0)
		{
			num = 1;
		}
		else
		{
			int num2 = ((array[array.Length - 2] & 0xFF) << 8) | (array[array.Length - 1] & 0xFF);
			if (LLINHKMIBFP.PMLGCANEMIO(HABFKBCEIBN))
			{
				throw new ArgumentException("unrecognised hash in signature");
			}
			if (num2 != LLINHKMIBFP.LFDPFEKIKII(HABFKBCEIBN))
			{
				throw new InvalidOperationException("signer initialised with wrong digest for trailer " + num2);
			}
			num = 2;
		}
		int i;
		for (i = 0; i != array.Length && ((array[i] & 0xFu) ^ 0xAu) != 0; i++)
		{
		}
		i++;
		byte[] array2 = new byte[HABFKBCEIBN.EEMLLAMENHO()];
		int num3 = array.Length - num - array2.Length;
		if (num3 - i <= 0)
		{
			return HNCPKONGJOB(array);
		}
		if ((array[0] & 0x20) == 0)
		{
			PEIBGJNCCPN = true;
			if (NEKAMHFGANJ > num3 - i)
			{
				return HNCPKONGJOB(array);
			}
			HABFKBCEIBN.OMOKOKFNBKI();
			HABFKBCEIBN.GONEEEFEDGF(array, i, num3 - i);
			HABFKBCEIBN.LCNOFBMOHHM(array2, 0);
			bool flag = true;
			for (int j = 0; j != array2.Length; j++)
			{
				array[num3 + j] ^= array2[j];
				if (array[num3 + j] != 0)
				{
					flag = false;
				}
			}
			if (!flag)
			{
				return HNCPKONGJOB(array);
			}
			PFFMOHBAJKM = new byte[num3 - i];
			Array.Copy(array, i, PFFMOHBAJKM, 0, PFFMOHBAJKM.Length);
		}
		else
		{
			PEIBGJNCCPN = false;
			HABFKBCEIBN.LCNOFBMOHHM(array2, 0);
			bool flag2 = true;
			for (int k = 0; k != array2.Length; k++)
			{
				array[num3 + k] ^= array2[k];
				if (array[num3 + k] != 0)
				{
					flag2 = false;
				}
			}
			if (!flag2)
			{
				return HNCPKONGJOB(array);
			}
			PFFMOHBAJKM = new byte[num3 - i];
			Array.Copy(array, i, PFFMOHBAJKM, 0, PFFMOHBAJKM.Length);
		}
		if (NEKAMHFGANJ != 0 && !DODLHJDJNHO(ELMKEGBBDON, PFFMOHBAJKM))
		{
			return HNCPKONGJOB(array);
		}
		JKBFMHJLGDI(ELMKEGBBDON);
		JKBFMHJLGDI(array);
		return true;
	}

	private bool HNCPKONGJOB(byte[] OJEJPICFOOJ)
	{
		JKBFMHJLGDI(ELMKEGBBDON);
		JKBFMHJLGDI(OJEJPICFOOJ);
		return false;
	}

	public virtual bool CMOOBBBJFMN()
	{
		return PEIBGJNCCPN;
	}
}
