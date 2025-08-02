using System;

public class INPJACNELFB : PHFBFDEAHMD
{
	private const int OBDGIDCKDFM = 16;

	private readonly JMPFLJGHAIM IEDPBFAFGGJ;

	private readonly byte[] CJAFJOFGNIJ = new byte[1];

	private uint HAEPCALPHIP;

	private uint GJFHKGIGIMO;

	private uint FHPFAEDHEGG;

	private uint FGHMAAJPGKM;

	private uint ICOAMBFCGNF;

	private uint JPFGFFOAJAA;

	private uint FDGEPLGMMBA;

	private uint KPDGOHKEOHK;

	private uint KJFGMKGJAJM;

	private uint HPBFFKICLDA;

	private uint KDFFDKFCDKK;

	private uint FKOBMEPIABG;

	private uint KHNDCPCHOEM;

	private byte[] FFIPNJPKIAL = new byte[16];

	private int MMHJJCIGHOD;

	private uint DLEPKHNKHNE;

	private uint BANOLCOJOPE;

	private uint ICEGMDKHCKH;

	private uint PEFJBKEPLHF;

	private uint ILBJKCBEFBI;

	public string KFKMEPMEBND
	{
		get
		{
			return (IEDPBFAFGGJ != null) ? ("Poly1305-" + IEDPBFAFGGJ.KFKMEPMEBND) : "Poly1305";
		}
	}

	public INPJACNELFB()
	{
		IEDPBFAFGGJ = null;
	}

	public INPJACNELFB(JMPFLJGHAIM IEDPBFAFGGJ)
	{
		if (IEDPBFAFGGJ.BDIGGHEPIIP() != 16)
		{
			throw new ArgumentException("Poly1305 requires a 128 bit block cipher.");
		}
		this.IEDPBFAFGGJ = IEDPBFAFGGJ;
	}

	public void DIOELAHNLKJ(IGMAJHKIIPK IJJHBEECMBP)
	{
		byte[] fHCDMEEPPFG = null;
		if (IEDPBFAFGGJ != null)
		{
			if (!(IJJHBEECMBP is CHCELGDKEJG))
			{
				throw new ArgumentException("Poly1305 requires an IV when used with a block cipher.", "parameters");
			}
			CHCELGDKEJG cHCELGDKEJG = (CHCELGDKEJG)IJJHBEECMBP;
			fHCDMEEPPFG = cHCELGDKEJG.OLAEDCABKDH();
			IJJHBEECMBP = cHCELGDKEJG.KPJHHAAOFOH;
		}
		if (!(IJJHBEECMBP is JEMNCGMEABF))
		{
			throw new ArgumentException("Poly1305 requires a key.");
		}
		JEMNCGMEABF jEMNCGMEABF = (JEMNCGMEABF)IJJHBEECMBP;
		KBEFMBDOIJH(jEMNCGMEABF.MEGBFHFMBFI(), fHCDMEEPPFG);
		OMOKOKFNBKI();
	}

	private void KBEFMBDOIJH(byte[] IKNCPEPOKGJ, byte[] FHCDMEEPPFG)
	{
		if (IKNCPEPOKGJ.Length != 32)
		{
			throw new ArgumentException("Poly1305 key must be 256 bits.");
		}
		if (IEDPBFAFGGJ != null && (FHCDMEEPPFG == null || FHCDMEEPPFG.Length != 16))
		{
			throw new ArgumentException("Poly1305 requires a 128 bit IV.");
		}
		uint num = PGOKFBKEOAB.LAJPMLKCDOH(IKNCPEPOKGJ, 0);
		uint num2 = PGOKFBKEOAB.LAJPMLKCDOH(IKNCPEPOKGJ, 4);
		uint num3 = PGOKFBKEOAB.LAJPMLKCDOH(IKNCPEPOKGJ, 8);
		uint num4 = PGOKFBKEOAB.LAJPMLKCDOH(IKNCPEPOKGJ, 12);
		HAEPCALPHIP = num & 0x3FFFFFFu;
		GJFHKGIGIMO = ((num >> 26) | (num2 << 6)) & 0x3FFFF03u;
		FHPFAEDHEGG = ((num2 >> 20) | (num3 << 12)) & 0x3FFC0FFu;
		FGHMAAJPGKM = ((num3 >> 14) | (num4 << 18)) & 0x3F03FFFu;
		ICOAMBFCGNF = (num4 >> 8) & 0xFFFFFu;
		JPFGFFOAJAA = GJFHKGIGIMO * 5;
		FDGEPLGMMBA = FHPFAEDHEGG * 5;
		KPDGOHKEOHK = FGHMAAJPGKM * 5;
		KJFGMKGJAJM = ICOAMBFCGNF * 5;
		byte[] array;
		int num5;
		if (IEDPBFAFGGJ == null)
		{
			array = IKNCPEPOKGJ;
			num5 = 16;
		}
		else
		{
			array = new byte[16];
			num5 = 0;
			IEDPBFAFGGJ.DIOELAHNLKJ(true, new JEMNCGMEABF(IKNCPEPOKGJ, 16, 16));
			IEDPBFAFGGJ.DPACJDFHLKB(FHCDMEEPPFG, 0, array, 0);
		}
		HPBFFKICLDA = PGOKFBKEOAB.LAJPMLKCDOH(array, num5);
		KDFFDKFCDKK = PGOKFBKEOAB.LAJPMLKCDOH(array, num5 + 4);
		FKOBMEPIABG = PGOKFBKEOAB.LAJPMLKCDOH(array, num5 + 8);
		KHNDCPCHOEM = PGOKFBKEOAB.LAJPMLKCDOH(array, num5 + 12);
	}

	public int BKGLOJPPBIG()
	{
		return 16;
	}

	public void BPAJGOINFNL(byte MOPCLEEGDFB)
	{
		CJAFJOFGNIJ[0] = MOPCLEEGDFB;
		GONEEEFEDGF(CJAFJOFGNIJ, 0, 1);
	}

	public void GONEEEFEDGF(byte[] MOPCLEEGDFB, int ELICNEDIBGB, int NBEDPKHALCN)
	{
		int num = 0;
		while (NBEDPKHALCN > num)
		{
			if (MMHJJCIGHOD == 16)
			{
				DPACJDFHLKB();
				MMHJJCIGHOD = 0;
			}
			int num2 = Math.Min(NBEDPKHALCN - num, 16 - MMHJJCIGHOD);
			Array.Copy(MOPCLEEGDFB, num + ELICNEDIBGB, FFIPNJPKIAL, MMHJJCIGHOD, num2);
			num += num2;
			MMHJJCIGHOD += num2;
		}
	}

	private void DPACJDFHLKB()
	{
		if (MMHJJCIGHOD < 16)
		{
			FFIPNJPKIAL[MMHJJCIGHOD] = 1;
			for (int i = MMHJJCIGHOD + 1; i < 16; i++)
			{
				FFIPNJPKIAL[i] = 0;
			}
		}
		ulong num = PGOKFBKEOAB.LAJPMLKCDOH(FFIPNJPKIAL, 0);
		ulong num2 = PGOKFBKEOAB.LAJPMLKCDOH(FFIPNJPKIAL, 4);
		ulong num3 = PGOKFBKEOAB.LAJPMLKCDOH(FFIPNJPKIAL, 8);
		ulong num4 = PGOKFBKEOAB.LAJPMLKCDOH(FFIPNJPKIAL, 12);
		DLEPKHNKHNE += (uint)(int)(num & 0x3FFFFFF);
		BANOLCOJOPE += (uint)(int)((((num2 << 32) | num) >> 26) & 0x3FFFFFF);
		ICEGMDKHCKH += (uint)(int)((((num3 << 32) | num2) >> 20) & 0x3FFFFFF);
		PEFJBKEPLHF += (uint)(int)((((num4 << 32) | num3) >> 14) & 0x3FFFFFF);
		ILBJKCBEFBI += (uint)(int)(num4 >> 8);
		if (MMHJJCIGHOD == 16)
		{
			ILBJKCBEFBI += 16777216u;
		}
		ulong num5 = DANPMLEOCJK(DLEPKHNKHNE, HAEPCALPHIP) + DANPMLEOCJK(BANOLCOJOPE, KJFGMKGJAJM) + DANPMLEOCJK(ICEGMDKHCKH, KPDGOHKEOHK) + DANPMLEOCJK(PEFJBKEPLHF, FDGEPLGMMBA) + DANPMLEOCJK(ILBJKCBEFBI, JPFGFFOAJAA);
		ulong num6 = DANPMLEOCJK(DLEPKHNKHNE, GJFHKGIGIMO) + DANPMLEOCJK(BANOLCOJOPE, HAEPCALPHIP) + DANPMLEOCJK(ICEGMDKHCKH, KJFGMKGJAJM) + DANPMLEOCJK(PEFJBKEPLHF, KPDGOHKEOHK) + DANPMLEOCJK(ILBJKCBEFBI, FDGEPLGMMBA);
		ulong num7 = DANPMLEOCJK(DLEPKHNKHNE, FHPFAEDHEGG) + DANPMLEOCJK(BANOLCOJOPE, GJFHKGIGIMO) + DANPMLEOCJK(ICEGMDKHCKH, HAEPCALPHIP) + DANPMLEOCJK(PEFJBKEPLHF, KJFGMKGJAJM) + DANPMLEOCJK(ILBJKCBEFBI, KPDGOHKEOHK);
		ulong num8 = DANPMLEOCJK(DLEPKHNKHNE, FGHMAAJPGKM) + DANPMLEOCJK(BANOLCOJOPE, FHPFAEDHEGG) + DANPMLEOCJK(ICEGMDKHCKH, GJFHKGIGIMO) + DANPMLEOCJK(PEFJBKEPLHF, HAEPCALPHIP) + DANPMLEOCJK(ILBJKCBEFBI, KJFGMKGJAJM);
		ulong num9 = DANPMLEOCJK(DLEPKHNKHNE, ICOAMBFCGNF) + DANPMLEOCJK(BANOLCOJOPE, FGHMAAJPGKM) + DANPMLEOCJK(ICEGMDKHCKH, FHPFAEDHEGG) + DANPMLEOCJK(PEFJBKEPLHF, GJFHKGIGIMO) + DANPMLEOCJK(ILBJKCBEFBI, HAEPCALPHIP);
		DLEPKHNKHNE = (uint)(int)num5 & 0x3FFFFFFu;
		ulong num10 = num5 >> 26;
		num6 += num10;
		BANOLCOJOPE = (uint)(int)num6 & 0x3FFFFFFu;
		num10 = num6 >> 26;
		num7 += num10;
		ICEGMDKHCKH = (uint)(int)num7 & 0x3FFFFFFu;
		num10 = num7 >> 26;
		num8 += num10;
		PEFJBKEPLHF = (uint)(int)num8 & 0x3FFFFFFu;
		num10 = num8 >> 26;
		num9 += num10;
		ILBJKCBEFBI = (uint)(int)num9 & 0x3FFFFFFu;
		num10 = num9 >> 26;
		DLEPKHNKHNE += (uint)(int)(num10 * 5);
	}

	public int LCNOFBMOHHM(byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		AJLDFGNHDCA.OONDALLFPOP(BILGCJNPJGJ, EMAKNGBIFDC, 16, "Output buffer is too short.");
		if (MMHJJCIGHOD > 0)
		{
			DPACJDFHLKB();
		}
		uint num = DLEPKHNKHNE >> 26;
		DLEPKHNKHNE &= 67108863u;
		BANOLCOJOPE += num;
		num = BANOLCOJOPE >> 26;
		BANOLCOJOPE &= 67108863u;
		ICEGMDKHCKH += num;
		num = ICEGMDKHCKH >> 26;
		ICEGMDKHCKH &= 67108863u;
		PEFJBKEPLHF += num;
		num = PEFJBKEPLHF >> 26;
		PEFJBKEPLHF &= 67108863u;
		ILBJKCBEFBI += num;
		num = ILBJKCBEFBI >> 26;
		ILBJKCBEFBI &= 67108863u;
		DLEPKHNKHNE += num * 5;
		uint num2 = DLEPKHNKHNE + 5;
		num = num2 >> 26;
		num2 &= 0x3FFFFFFu;
		uint num3 = BANOLCOJOPE + num;
		num = num3 >> 26;
		num3 &= 0x3FFFFFFu;
		uint num4 = ICEGMDKHCKH + num;
		num = num4 >> 26;
		num4 &= 0x3FFFFFFu;
		uint num5 = PEFJBKEPLHF + num;
		num = num5 >> 26;
		num5 &= 0x3FFFFFFu;
		uint num6 = ILBJKCBEFBI + num - 67108864;
		num = (num6 >> 31) - 1;
		uint num7 = ~num;
		DLEPKHNKHNE = (DLEPKHNKHNE & num7) | (num2 & num);
		BANOLCOJOPE = (BANOLCOJOPE & num7) | (num3 & num);
		ICEGMDKHCKH = (ICEGMDKHCKH & num7) | (num4 & num);
		PEFJBKEPLHF = (PEFJBKEPLHF & num7) | (num5 & num);
		ILBJKCBEFBI = (ILBJKCBEFBI & num7) | (num6 & num);
		ulong num8 = (ulong)(DLEPKHNKHNE | (BANOLCOJOPE << 26)) + (ulong)HPBFFKICLDA;
		ulong num9 = (ulong)((BANOLCOJOPE >> 6) | (ICEGMDKHCKH << 20)) + (ulong)KDFFDKFCDKK;
		ulong num10 = (ulong)((ICEGMDKHCKH >> 12) | (PEFJBKEPLHF << 14)) + (ulong)FKOBMEPIABG;
		ulong num11 = (ulong)((PEFJBKEPLHF >> 18) | (ILBJKCBEFBI << 8)) + (ulong)KHNDCPCHOEM;
		PGOKFBKEOAB.LGJFKMLLKLN((uint)num8, BILGCJNPJGJ, EMAKNGBIFDC);
		num9 += num8 >> 32;
		PGOKFBKEOAB.LGJFKMLLKLN((uint)num9, BILGCJNPJGJ, EMAKNGBIFDC + 4);
		num10 += num9 >> 32;
		PGOKFBKEOAB.LGJFKMLLKLN((uint)num10, BILGCJNPJGJ, EMAKNGBIFDC + 8);
		num11 += num10 >> 32;
		PGOKFBKEOAB.LGJFKMLLKLN((uint)num11, BILGCJNPJGJ, EMAKNGBIFDC + 12);
		OMOKOKFNBKI();
		return 16;
	}

	public void OMOKOKFNBKI()
	{
		MMHJJCIGHOD = 0;
		DLEPKHNKHNE = (BANOLCOJOPE = (ICEGMDKHCKH = (PEFJBKEPLHF = (ILBJKCBEFBI = 0u))));
	}

	private static ulong DANPMLEOCJK(uint OECENGBDNDA, uint FAICHIHMKDK)
	{
		return (ulong)OECENGBDNDA * (ulong)FAICHIHMKDK;
	}
}
