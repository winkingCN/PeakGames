using System;
using System.Collections;
using System.IO;

public abstract class APHMHGMCEML
{
	public static IDictionary GHEDPOHNGFO(IDictionary GPFBAMMMLIA)
	{
		return (GPFBAMMMLIA != null) ? GPFBAMMMLIA : LHFGHNFJIKM.JBEOCJEMGCE();
	}

	public static void JPBNJCGMFGN(IDictionary GPFBAMMMLIA)
	{
		GPFBAMMMLIA[22] = KNBDLPFANCC();
	}

	public static void MBOOOHGMOGB(IDictionary GPFBAMMMLIA)
	{
		GPFBAMMMLIA[23] = PINJJGLLDHC();
	}

	public static void HFMHGFCBNNL(IDictionary GPFBAMMMLIA, FDGGAMHFHND MIGGOLEOCFJ)
	{
		GPFBAMMMLIA[15] = DABPIDFCEJP(MIGGOLEOCFJ);
	}

	public static void ELMPMPIMIEM(IDictionary GPFBAMMMLIA, byte GBGOFJPGDJM)
	{
		GPFBAMMMLIA[1] = GMKBFIGGIMP(GBGOFJPGDJM);
	}

	public static void CANNGHPIFEJ(IDictionary GPFBAMMMLIA, int ADEBKKPPGNE)
	{
		GPFBAMMMLIA[21] = GBKACIAFKMA(ADEBKKPPGNE);
	}

	public static void FBAMBBMFJAL(IDictionary GPFBAMMMLIA, IGNCGHEOJIP IOMLIAKDCIM)
	{
		GPFBAMMMLIA[0] = JGABMIELBPO(IOMLIAKDCIM);
	}

	public static void OKFLDNLELGL(IDictionary GPFBAMMMLIA, FNLGCDLPPJJ ILBDPPCPJBB)
	{
		GPFBAMMMLIA[5] = MINNLNLFICN(ILBDPPCPJBB);
	}

	public static void FMDBGPHJFPO(IDictionary GPFBAMMMLIA)
	{
		GPFBAMMMLIA[4] = AOLOGIIPCIG();
	}

	public static FDGGAMHFHND GEKNNOPILCF(IDictionary GPFBAMMMLIA)
	{
		byte[] array = KINEBFNENMB.MHMMGPFEAJM(GPFBAMMMLIA, 15);
		return (array != null) ? OJKBPMAOPHD(array) : null;
	}

	public static short NLFBMFLGDIO(IDictionary GPFBAMMMLIA)
	{
		byte[] array = KINEBFNENMB.MHMMGPFEAJM(GPFBAMMMLIA, 1);
		return (short)((array != null) ? AMICGAEFKDC(array) : (-1));
	}

	public static int JCIMFCPCHJC(IDictionary GPFBAMMMLIA)
	{
		byte[] array = KINEBFNENMB.MHMMGPFEAJM(GPFBAMMMLIA, 21);
		return (array != null) ? GAADKMOEEFJ(array) : (-1);
	}

	public static IGNCGHEOJIP BABCMPPGPDO(IDictionary GPFBAMMMLIA)
	{
		byte[] array = KINEBFNENMB.MHMMGPFEAJM(GPFBAMMMLIA, 0);
		return (array != null) ? DLMLKNIHNKP(array) : null;
	}

	public static FNLGCDLPPJJ JNNHDJBEDNI(IDictionary GPFBAMMMLIA)
	{
		byte[] array = KINEBFNENMB.MHMMGPFEAJM(GPFBAMMMLIA, 5);
		return (array != null) ? JFCAOEEKLCK(array) : null;
	}

	public static bool DINFPLKCLDM(IDictionary GPFBAMMMLIA)
	{
		byte[] array = KINEBFNENMB.MHMMGPFEAJM(GPFBAMMMLIA, 22);
		return array != null && AMDNIIIBBHA(array);
	}

	public static bool EBNICMCJKPK(IDictionary GPFBAMMMLIA)
	{
		byte[] array = KINEBFNENMB.MHMMGPFEAJM(GPFBAMMMLIA, 23);
		return array != null && JAIGFKCJCDL(array);
	}

	public static bool FAFAJFGALEB(IDictionary GPFBAMMMLIA)
	{
		byte[] array = KINEBFNENMB.MHMMGPFEAJM(GPFBAMMMLIA, 4);
		return array != null && KNDCFJNPPFL(array);
	}

	public static byte[] JAPCBKKIGHP()
	{
		return KINEBFNENMB.JBCONIFELBM;
	}

	public static byte[] KNBDLPFANCC()
	{
		return JAPCBKKIGHP();
	}

	public static byte[] PINJJGLLDHC()
	{
		return JAPCBKKIGHP();
	}

	public static byte[] DABPIDFCEJP(FDGGAMHFHND MIGGOLEOCFJ)
	{
		if (MIGGOLEOCFJ == null)
		{
			throw new DEIDBCPPCMB(80);
		}
		MemoryStream memoryStream = new MemoryStream();
		MIGGOLEOCFJ.LMDBBPLCJDM(memoryStream);
		return memoryStream.ToArray();
	}

	public static byte[] GMKBFIGGIMP(byte GBGOFJPGDJM)
	{
		return new byte[1] { GBGOFJPGDJM };
	}

	public static byte[] GBKACIAFKMA(int ADEBKKPPGNE)
	{
		KINEBFNENMB.AKGIEBIEJJL(ADEBKKPPGNE);
		return new byte[ADEBKKPPGNE];
	}

	public static byte[] JGABMIELBPO(IGNCGHEOJIP IOMLIAKDCIM)
	{
		if (IOMLIAKDCIM == null)
		{
			throw new DEIDBCPPCMB(80);
		}
		MemoryStream memoryStream = new MemoryStream();
		IOMLIAKDCIM.LMDBBPLCJDM(memoryStream);
		return memoryStream.ToArray();
	}

	public static byte[] MINNLNLFICN(FNLGCDLPPJJ ILBDPPCPJBB)
	{
		if (ILBDPPCPJBB == null)
		{
			throw new DEIDBCPPCMB(80);
		}
		MemoryStream memoryStream = new MemoryStream();
		ILBDPPCPJBB.LMDBBPLCJDM(memoryStream);
		return memoryStream.ToArray();
	}

	public static byte[] AOLOGIIPCIG()
	{
		return JAPCBKKIGHP();
	}

	private static bool APGILLEPIDD(byte[] NIHLDDGDKGP)
	{
		if (NIHLDDGDKGP == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		if (NIHLDDGDKGP.Length != 0)
		{
			throw new DEIDBCPPCMB(47);
		}
		return true;
	}

	public static bool AMDNIIIBBHA(byte[] NIHLDDGDKGP)
	{
		return APGILLEPIDD(NIHLDDGDKGP);
	}

	public static bool JAIGFKCJCDL(byte[] NIHLDDGDKGP)
	{
		return APGILLEPIDD(NIHLDDGDKGP);
	}

	public static FDGGAMHFHND OJKBPMAOPHD(byte[] NIHLDDGDKGP)
	{
		if (NIHLDDGDKGP == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		MemoryStream memoryStream = new MemoryStream(NIHLDDGDKGP, false);
		FDGGAMHFHND result = FDGGAMHFHND.DHCLOMIANOE(memoryStream);
		HEMGBKNMOKB.JILHFDBGNGE(memoryStream);
		return result;
	}

	public static short AMICGAEFKDC(byte[] NIHLDDGDKGP)
	{
		if (NIHLDDGDKGP == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		if (NIHLDDGDKGP.Length != 1)
		{
			throw new DEIDBCPPCMB(50);
		}
		return NIHLDDGDKGP[0];
	}

	public static int GAADKMOEEFJ(byte[] NIHLDDGDKGP)
	{
		if (NIHLDDGDKGP == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		for (int i = 0; i < NIHLDDGDKGP.Length; i++)
		{
			if (NIHLDDGDKGP[i] != 0)
			{
				throw new DEIDBCPPCMB(47);
			}
		}
		return NIHLDDGDKGP.Length;
	}

	public static IGNCGHEOJIP DLMLKNIHNKP(byte[] NIHLDDGDKGP)
	{
		if (NIHLDDGDKGP == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		MemoryStream memoryStream = new MemoryStream(NIHLDDGDKGP, false);
		IGNCGHEOJIP result = IGNCGHEOJIP.DHCLOMIANOE(memoryStream);
		HEMGBKNMOKB.JILHFDBGNGE(memoryStream);
		return result;
	}

	public static FNLGCDLPPJJ JFCAOEEKLCK(byte[] NIHLDDGDKGP)
	{
		if (NIHLDDGDKGP == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		MemoryStream memoryStream = new MemoryStream(NIHLDDGDKGP, false);
		FNLGCDLPPJJ result = FNLGCDLPPJJ.DHCLOMIANOE(memoryStream);
		HEMGBKNMOKB.JILHFDBGNGE(memoryStream);
		return result;
	}

	public static bool KNDCFJNPPFL(byte[] NIHLDDGDKGP)
	{
		return APGILLEPIDD(NIHLDDGDKGP);
	}
}
