using System;

public class INDJEDECBHE : PHFBFDEAHMD
{
	protected readonly int FMFABAKPMLB;

	protected readonly int ELNCCDELMMH;

	protected long HPBFFKICLDA;

	protected long KDFFDKFCDKK;

	protected long DAPAMJFACIE;

	protected long PKIBIMAALJE;

	protected long OFFFLJCPAJE;

	protected long FIOEFJJCLPN;

	protected long CEKMAJAHNAG;

	protected int KIIPNIIBEEP;

	protected int HGPDAPOOJMO;

	public virtual string KFKMEPMEBND
	{
		get
		{
			return "SipHash-" + FMFABAKPMLB + "-" + ELNCCDELMMH;
		}
	}

	public INDJEDECBHE()
		: this(2, 4)
	{
	}

	public INDJEDECBHE(int FMFABAKPMLB, int ELNCCDELMMH)
	{
		this.FMFABAKPMLB = FMFABAKPMLB;
		this.ELNCCDELMMH = ELNCCDELMMH;
	}

	public virtual int BKGLOJPPBIG()
	{
		return 8;
	}

	public virtual void DIOELAHNLKJ(IGMAJHKIIPK IJJHBEECMBP)
	{
		JEMNCGMEABF jEMNCGMEABF = IJJHBEECMBP as JEMNCGMEABF;
		if (jEMNCGMEABF == null)
		{
			throw new ArgumentException("must be an instance of KeyParameter", "parameters");
		}
		byte[] array = jEMNCGMEABF.MEGBFHFMBFI();
		if (array.Length != 16)
		{
			throw new ArgumentException("must be a 128-bit key", "parameters");
		}
		HPBFFKICLDA = (long)PGOKFBKEOAB.HLAFFGIFLEA(array, 0);
		KDFFDKFCDKK = (long)PGOKFBKEOAB.HLAFFGIFLEA(array, 8);
		OMOKOKFNBKI();
	}

	public virtual void BPAJGOINFNL(byte MOPCLEEGDFB)
	{
		CEKMAJAHNAG = (long)(((ulong)CEKMAJAHNAG >> 8) | ((ulong)MOPCLEEGDFB << 56));
		if (++KIIPNIIBEEP == 8)
		{
			NDCGNPNNMOH();
			KIIPNIIBEEP = 0;
		}
	}

	public virtual void GONEEEFEDGF(byte[] MOPCLEEGDFB, int IBNDGNOIEEF, int EOFAGACBNFP)
	{
		int i = 0;
		int num = EOFAGACBNFP & -8;
		if (KIIPNIIBEEP == 0)
		{
			for (; i < num; i += 8)
			{
				CEKMAJAHNAG = (long)PGOKFBKEOAB.HLAFFGIFLEA(MOPCLEEGDFB, IBNDGNOIEEF + i);
				NDCGNPNNMOH();
			}
			for (; i < EOFAGACBNFP; i++)
			{
				CEKMAJAHNAG = (long)(((ulong)CEKMAJAHNAG >> 8) | ((ulong)MOPCLEEGDFB[IBNDGNOIEEF + i] << 56));
			}
			KIIPNIIBEEP = EOFAGACBNFP - num;
			return;
		}
		int num2 = KIIPNIIBEEP << 3;
		for (; i < num; i += 8)
		{
			ulong num3 = PGOKFBKEOAB.HLAFFGIFLEA(MOPCLEEGDFB, IBNDGNOIEEF + i);
			CEKMAJAHNAG = (long)((num3 << num2) | ((ulong)CEKMAJAHNAG >> -num2));
			NDCGNPNNMOH();
			CEKMAJAHNAG = (long)num3;
		}
		for (; i < EOFAGACBNFP; i++)
		{
			CEKMAJAHNAG = (long)(((ulong)CEKMAJAHNAG >> 8) | ((ulong)MOPCLEEGDFB[IBNDGNOIEEF + i] << 56));
			if (++KIIPNIIBEEP == 8)
			{
				NDCGNPNNMOH();
				KIIPNIIBEEP = 0;
			}
		}
	}

	public virtual long LCNOFBMOHHM()
	{
		CEKMAJAHNAG = (long)((ulong)CEKMAJAHNAG >> (7 - KIIPNIIBEEP << 3));
		CEKMAJAHNAG = (long)((ulong)CEKMAJAHNAG >> 8);
		CEKMAJAHNAG |= (long)((HGPDAPOOJMO << 3) + KIIPNIIBEEP) << 56;
		NDCGNPNNMOH();
		OFFFLJCPAJE ^= 255L;
		KKGADAHBPKH(ELNCCDELMMH);
		long result = DAPAMJFACIE ^ PKIBIMAALJE ^ OFFFLJCPAJE ^ FIOEFJJCLPN;
		OMOKOKFNBKI();
		return result;
	}

	public virtual int LCNOFBMOHHM(byte[] BILGCJNPJGJ, int EMAKNGBIFDC)
	{
		long iDHLPOFDLKJ = LCNOFBMOHHM();
		PGOKFBKEOAB.ICLMPOAFJKJ((ulong)iDHLPOFDLKJ, BILGCJNPJGJ, EMAKNGBIFDC);
		return 8;
	}

	public virtual void OMOKOKFNBKI()
	{
		DAPAMJFACIE = HPBFFKICLDA ^ 0x736F6D6570736575L;
		PKIBIMAALJE = KDFFDKFCDKK ^ 0x646F72616E646F6DL;
		OFFFLJCPAJE = HPBFFKICLDA ^ 0x6C7967656E657261L;
		FIOEFJJCLPN = KDFFDKFCDKK ^ 0x7465646279746573L;
		CEKMAJAHNAG = 0L;
		KIIPNIIBEEP = 0;
		HGPDAPOOJMO = 0;
	}

	protected virtual void NDCGNPNNMOH()
	{
		HGPDAPOOJMO++;
		FIOEFJJCLPN ^= CEKMAJAHNAG;
		KKGADAHBPKH(FMFABAKPMLB);
		DAPAMJFACIE ^= CEKMAJAHNAG;
	}

	protected virtual void KKGADAHBPKH(int IDHLPOFDLKJ)
	{
		long num = DAPAMJFACIE;
		long num2 = PKIBIMAALJE;
		long num3 = OFFFLJCPAJE;
		long num4 = FIOEFJJCLPN;
		for (int i = 0; i < IDHLPOFDLKJ; i++)
		{
			num += num2;
			num3 += num4;
			num2 = MBBDJFKAACD(num2, 13);
			num4 = MBBDJFKAACD(num4, 16);
			num2 ^= num;
			num4 ^= num3;
			num = MBBDJFKAACD(num, 32);
			num3 += num2;
			num += num4;
			num2 = MBBDJFKAACD(num2, 17);
			num4 = MBBDJFKAACD(num4, 21);
			num2 ^= num3;
			num4 ^= num;
			num3 = MBBDJFKAACD(num3, 32);
		}
		DAPAMJFACIE = num;
		PKIBIMAALJE = num2;
		OFFFLJCPAJE = num3;
		FIOEFJJCLPN = num4;
	}

	protected static long MBBDJFKAACD(long AMFCENFNAJJ, int IDHLPOFDLKJ)
	{
		return (AMFCENFNAJJ << IDHLPOFDLKJ) | (long)((ulong)AMFCENFNAJJ >> -IDHLPOFDLKJ);
	}
}
