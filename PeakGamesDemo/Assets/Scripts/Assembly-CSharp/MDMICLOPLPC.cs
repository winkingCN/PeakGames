using System;

public class MDMICLOPLPC
{
	private int JMHEECCCKIP;

	private readonly byte[] JCCIHFEPIID;

	private readonly int DJHNPLLAOGM;

	public MDMICLOPLPC(byte[] MBBPBGHKLJM)
	{
		JCCIHFEPIID = MBBPBGHKLJM;
		JMHEECCCKIP = 0;
		DJHNPLLAOGM = JCCIHFEPIID.Length;
	}

	public bool NICGJDCKMNP()
	{
		return JMHEECCCKIP >= DJHNPLLAOGM;
	}

	public short PENAHNOJCGF(bool MKHNPKBFKJI)
	{
		byte[] value = new byte[2]
		{
			JCCIHFEPIID[JMHEECCCKIP + (BitConverter.IsLittleEndian ? 1 : 0)],
			JCCIHFEPIID[JMHEECCCKIP + ((!BitConverter.IsLittleEndian) ? 1 : 0)]
		};
		if (MKHNPKBFKJI)
		{
			JMHEECCCKIP += 2;
		}
		return BitConverter.ToInt16(value, 0);
	}

	public byte GNNOGGGHPLA()
	{
		return JCCIHFEPIID[JMHEECCCKIP++];
	}

	public void HAPECLIMPAI(int IBNDGNOIEEF)
	{
		JMHEECCCKIP += IBNDGNOIEEF;
	}
}
