using System;

public class KNLPDBACFGB : NADPOFCHCON
{
	private readonly Action<bool> NMILJNLPIKF;

	public KNLPDBACFGB(MFODECOOJLA KAGBOIDKAED, Action<bool> LAMLCODHKBO, GBJNCLLOCJB KFNJHBPIHOI)
		: base(KAGBOIDKAED, KFNJHBPIHOI)
	{
		NMILJNLPIKF = LAMLCODHKBO;
	}

	public override void JLECFJEAFCD()
	{
		if (NMILJNLPIKF != null)
		{
			NMILJNLPIKF(true);
		}
	}

	public override void AIGOFKAJFBM()
	{
		if (NMILJNLPIKF != null)
		{
			NMILJNLPIKF(false);
		}
	}
}
