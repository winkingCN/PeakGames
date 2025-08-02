using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Animations;
using UnityEngine;

public struct HMPAMDCECFJ
{
	private readonly int[] KPNBNKEBALD;

	private readonly Cell JFALKIIHHIF;

	private readonly Cell CDIFKOCLGAK;

	public int BFBEDEPAOLB;

	public int ADODLKFEBOH;

	public int DGMLPAAGIJF;

	public int GIFMPDOHNCL;

	public bool CHHIMPENGBG;

	public bool NPGABPICIAD;

	public HMPAMDCECFJ(List<CollectAnimation> FJKCLOMALBC, Vector3 HBKDNOHDOFG)
	{
		CHHIMPENGBG = true;
		BFBEDEPAOLB = -1000;
		ADODLKFEBOH = -1000;
		DGMLPAAGIJF = 1000;
		GIFMPDOHNCL = 1000;
		JFALKIIHHIF = null;
		CDIFKOCLGAK = null;
		KPNBNKEBALD = new int[9] { 10, 10, 10, 10, 10, 10, 10, 10, 10 };
		int i = 0;
		for (int count = FJKCLOMALBC.Count; i < count; i++)
		{
			Cell referencedCell = FJKCLOMALBC[i].ReferencedCell;
			if (DGMLPAAGIJF > referencedCell.X)
			{
				DGMLPAAGIJF = referencedCell.X;
				JFALKIIHHIF = referencedCell;
			}
			if (BFBEDEPAOLB < referencedCell.X)
			{
				BFBEDEPAOLB = referencedCell.X;
				CDIFKOCLGAK = referencedCell;
			}
			if (GIFMPDOHNCL > referencedCell.Y)
			{
				GIFMPDOHNCL = referencedCell.Y;
			}
			ADODLKFEBOH = ((ADODLKFEBOH >= referencedCell.Y) ? ADODLKFEBOH : referencedCell.Y);
			KPNBNKEBALD[referencedCell.X] = ((KPNBNKEBALD[referencedCell.X] <= referencedCell.Y) ? KPNBNKEBALD[referencedCell.X] : referencedCell.Y);
		}
		NPGABPICIAD = Vector3.Distance(HBKDNOHDOFG, JFALKIIHHIF.GetFrozenPosition()) <= Vector3.Distance(HBKDNOHDOFG, CDIFKOCLGAK.GetFrozenPosition());
	}

	public int FGMDLNBGFJB(int AMFCENFNAJJ)
	{
		return KPNBNKEBALD[AMFCENFNAJJ];
	}
}
