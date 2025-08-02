using System;
using System.Collections;

public class KJONDCLCMHK : OOHGOOPDAEM
{
	public KJONDCLCMHK(Action<bool> IMHLFAHONPP)
		: base(IMHLFAHONPP)
	{
		CENGNKJGOGP = "ConsentPopupAnimation";
	}

	public override void GDGINCNCMDD(bool ODCADGABBHJ, bool DEIGFPCALOJ)
	{
		if (FJPHLKFHDOG.GABGKBAKHDP.FMPALJDNDEN())
		{
			new LLCJMMBBLEH(KIIIEELPLCJ(), true);
		}
		else if (CECMINAKHFJ != null)
		{
			FJPHLKFHDOG.GABGKBAKHDP.PHHBNNGIKFF();
			CECMINAKHFJ(false);
		}
	}

	private IEnumerator KIIIEELPLCJ()
	{
		yield return MCJHHDACJBG.CHFOIGLAMPN;
		FJPHLKFHDOG fJPHLKFHDOG = FJPHLKFHDOG.GABGKBAKHDP;
		fJPHLKFHDOG.NPNAMAGJCIM(delegate
		{
			if (CECMINAKHFJ != null)
			{
				CECMINAKHFJ(true);
			}
		});
		fJPHLKFHDOG.EFBEHJNKFCD();
	}

	public override bool PPOCOCCKKFF()
	{
		return FJPHLKFHDOG.GABGKBAKHDP.FMPALJDNDEN();
	}

	public override bool HDLHHPFDHIK()
	{
		return true;
	}
}
