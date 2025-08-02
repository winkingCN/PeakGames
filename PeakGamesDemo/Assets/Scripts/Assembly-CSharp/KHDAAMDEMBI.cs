using System;
using MapScene;
using NewMapScene;
using UnityEngine;

public class KHDAAMDEMBI : OOHGOOPDAEM
{
	private readonly TreasureHuntDisplay IKLGCFCPGIJ;

	private readonly Vector3 BFBADJCPCNM;

	public KHDAAMDEMBI(TreasureHuntDisplay GACEHBKCPNN, Vector3 KKAHENNAJJD, Action<bool> IMHLFAHONPP)
		: base(IMHLFAHONPP)
	{
		CENGNKJGOGP = "TreasureKeyCollectAnimation";
		IKLGCFCPGIJ = GACEHBKCPNN;
		BFBADJCPCNM = KKAHENNAJJD;
	}

	public override void GDGINCNCMDD(bool ODCADGABBHJ, bool DEIGFPCALOJ)
	{
		CFNKECEHDIC cFNKECEHDIC = DGOMNDMPMBG.GABGKBAKHDP.OEPCIADENMH;
		if (cFNKECEHDIC != null && cFNKECEHDIC.FBKLBPKOOPG && cFNKECEHDIC.NPHPMJFFPGB)
		{
			cFNKECEHDIC.ALIDHGIHPGF();
			CollectTreasureKey collectTreasureKey = UnityEngine.Object.Instantiate(IKLGCFCPGIJ.CollectTreasureKeyPrefab, BFBADJCPCNM, Quaternion.identity);
			IKLGCFCPGIJ.TreasureHuntDisplayAnimation.KeyCollectAnimationChosen = true;
			collectTreasureKey.StartCollectAnimation(IKLGCFCPGIJ.transform.position, IKLGCFCPGIJ.PlayHitAnimation, CECMINAKHFJ);
		}
		else if (CECMINAKHFJ != null)
		{
			CECMINAKHFJ(false);
		}
	}

	public override bool PPOCOCCKKFF()
	{
		return DGOMNDMPMBG.GABGKBAKHDP.OEPCIADENMH != null;
	}
}
