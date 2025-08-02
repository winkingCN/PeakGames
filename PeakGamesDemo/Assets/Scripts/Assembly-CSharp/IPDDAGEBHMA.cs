using System.IO;

internal class IPDDAGEBHMA : HGJIPGDINJI
{
	private readonly MKNDIEHOMOI IGCEJBIEACI;

	private bool PDNEBAONJEP = true;

	private Stream GPKKJFJPFID;

	internal IPDDAGEBHMA(MKNDIEHOMOI BKOBLIALKKC)
	{
		IGCEJBIEACI = BKOBLIALKKC;
	}

	public override int Read(byte[] DJDKLOJBJCO, int IBNDGNOIEEF, int ENMLICFLHAO)
	{
		if (GPKKJFJPFID == null)
		{
			if (!PDNEBAONJEP)
			{
				return 0;
			}
			FBDCBBCMCLK fBDCBBCMCLK = (FBDCBBCMCLK)IGCEJBIEACI.DMHLIGLGJGI();
			if (fBDCBBCMCLK == null)
			{
				return 0;
			}
			PDNEBAONJEP = false;
			GPKKJFJPFID = fBDCBBCMCLK.PKLNGAOHLDC();
		}
		int num = 0;
		while (true)
		{
			int num2 = GPKKJFJPFID.Read(DJDKLOJBJCO, IBNDGNOIEEF + num, ENMLICFLHAO - num);
			if (num2 > 0)
			{
				num += num2;
				if (num == ENMLICFLHAO)
				{
					return num;
				}
				continue;
			}
			FBDCBBCMCLK fBDCBBCMCLK2 = (FBDCBBCMCLK)IGCEJBIEACI.DMHLIGLGJGI();
			if (fBDCBBCMCLK2 == null)
			{
				break;
			}
			GPKKJFJPFID = fBDCBBCMCLK2.PKLNGAOHLDC();
		}
		GPKKJFJPFID = null;
		return num;
	}

	public override int ReadByte()
	{
		if (GPKKJFJPFID == null)
		{
			if (!PDNEBAONJEP)
			{
				return 0;
			}
			FBDCBBCMCLK fBDCBBCMCLK = (FBDCBBCMCLK)IGCEJBIEACI.DMHLIGLGJGI();
			if (fBDCBBCMCLK == null)
			{
				return 0;
			}
			PDNEBAONJEP = false;
			GPKKJFJPFID = fBDCBBCMCLK.PKLNGAOHLDC();
		}
		while (true)
		{
			int num = GPKKJFJPFID.ReadByte();
			if (num >= 0)
			{
				return num;
			}
			FBDCBBCMCLK fBDCBBCMCLK2 = (FBDCBBCMCLK)IGCEJBIEACI.DMHLIGLGJGI();
			if (fBDCBBCMCLK2 == null)
			{
				break;
			}
			GPKKJFJPFID = fBDCBBCMCLK2.PKLNGAOHLDC();
		}
		GPKKJFJPFID = null;
		return -1;
	}
}
