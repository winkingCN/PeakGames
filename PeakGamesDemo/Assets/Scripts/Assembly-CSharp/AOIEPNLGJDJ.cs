using System;

public class AOIEPNLGJDJ
{
	private const int IPALGLBDFLN = 1024;

	private byte[] GHIINLLICPL;

	private int IAFBAIEHCAJ;

	private int PMMJAMFDENL;

	public int AJFPKOAKJOD
	{
		get
		{
			return PMMJAMFDENL;
		}
	}

	public AOIEPNLGJDJ()
		: this(1024)
	{
	}

	public AOIEPNLGJDJ(int MDPEMCMPAMB)
	{
		GHIINLLICPL = new byte[MDPEMCMPAMB];
	}

	public static int MMMCFHJBGAE(int PLCFEOMGCFK)
	{
		PLCFEOMGCFK |= PLCFEOMGCFK >> 1;
		PLCFEOMGCFK |= PLCFEOMGCFK >> 2;
		PLCFEOMGCFK |= PLCFEOMGCFK >> 4;
		PLCFEOMGCFK |= PLCFEOMGCFK >> 8;
		PLCFEOMGCFK |= PLCFEOMGCFK >> 16;
		return PLCFEOMGCFK + 1;
	}

	public void CELOEBEMCKP(byte[] GHPCHPOHELF, int IBNDGNOIEEF, int NBEDPKHALCN, int NDIFELHKLOP)
	{
		if (GHPCHPOHELF.Length - IBNDGNOIEEF < NBEDPKHALCN)
		{
			throw new ArgumentException("Buffer size of " + GHPCHPOHELF.Length + " is too small for a read of " + NBEDPKHALCN + " bytes");
		}
		if (PMMJAMFDENL - NDIFELHKLOP < NBEDPKHALCN)
		{
			throw new InvalidOperationException("Not enough data to read");
		}
		Array.Copy(GHIINLLICPL, IAFBAIEHCAJ + NDIFELHKLOP, GHPCHPOHELF, IBNDGNOIEEF, NBEDPKHALCN);
	}

	public void ECGMPBCCBLB(byte[] MBBPBGHKLJM, int IBNDGNOIEEF, int NBEDPKHALCN)
	{
		if (IAFBAIEHCAJ + PMMJAMFDENL + NBEDPKHALCN > GHIINLLICPL.Length)
		{
			int num = MMMCFHJBGAE(PMMJAMFDENL + NBEDPKHALCN);
			if (num > GHIINLLICPL.Length)
			{
				byte[] array = new byte[num];
				Array.Copy(GHIINLLICPL, IAFBAIEHCAJ, array, 0, PMMJAMFDENL);
				GHIINLLICPL = array;
			}
			else
			{
				Array.Copy(GHIINLLICPL, IAFBAIEHCAJ, GHIINLLICPL, 0, PMMJAMFDENL);
			}
			IAFBAIEHCAJ = 0;
		}
		Array.Copy(MBBPBGHKLJM, IBNDGNOIEEF, GHIINLLICPL, IAFBAIEHCAJ + PMMJAMFDENL, NBEDPKHALCN);
		PMMJAMFDENL += NBEDPKHALCN;
	}

	public void LNFLLAIGBIO(int PLCFEOMGCFK)
	{
		if (PLCFEOMGCFK > PMMJAMFDENL)
		{
			throw new InvalidOperationException("Cannot remove " + PLCFEOMGCFK + " bytes, only got " + PMMJAMFDENL);
		}
		PMMJAMFDENL -= PLCFEOMGCFK;
		IAFBAIEHCAJ += PLCFEOMGCFK;
	}

	public void LNFLLAIGBIO(byte[] GHPCHPOHELF, int JBAJPGIAPFF, int NBEDPKHALCN, int NDIFELHKLOP)
	{
		CELOEBEMCKP(GHPCHPOHELF, JBAJPGIAPFF, NBEDPKHALCN, NDIFELHKLOP);
		LNFLLAIGBIO(NDIFELHKLOP + NBEDPKHALCN);
	}

	public byte[] LNFLLAIGBIO(int NBEDPKHALCN, int NDIFELHKLOP)
	{
		byte[] array = new byte[NBEDPKHALCN];
		LNFLLAIGBIO(array, 0, NBEDPKHALCN, NDIFELHKLOP);
		return array;
	}
}
