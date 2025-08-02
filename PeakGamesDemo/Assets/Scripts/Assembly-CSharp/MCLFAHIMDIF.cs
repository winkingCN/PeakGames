using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using UnityEngine;

public struct MCLFAHIMDIF
{
	private readonly int[] KPNBNKEBALD;

	private readonly Cell JFALKIIHHIF;

	private readonly Cell CDIFKOCLGAK;

	private readonly Cell OLBDPHOFKMN;

	private readonly Cell NPJPAKBIHPC;

	public int BFBEDEPAOLB;

	public int ADODLKFEBOH;

	public int DGMLPAAGIJF;

	public int GIFMPDOHNCL;

	public bool CHHIMPENGBG;

	public bool NPGABPICIAD;

	public bool EOHKAAHIAEO;

	public MCLFAHIMDIF(List<BlasterCollectAnimation> FJKCLOMALBC, Vector3 HBKDNOHDOFG)
	{
		CHHIMPENGBG = true;
		BFBEDEPAOLB = -1000;
		ADODLKFEBOH = -1000;
		DGMLPAAGIJF = 1000;
		GIFMPDOHNCL = 1000;
		JFALKIIHHIF = null;
		CDIFKOCLGAK = null;
		OLBDPHOFKMN = null;
		NPJPAKBIHPC = null;
		KPNBNKEBALD = new int[9] { 10, 10, 10, 10, 10, 10, 10, 10, 10 };
		int i = 0;
		for (int count = FJKCLOMALBC.Count; i < count; i++)
		{
			Cell referencedCell = FJKCLOMALBC[i].HLOBGGHBOIM;
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
				NPJPAKBIHPC = referencedCell;
			}
			if (ADODLKFEBOH < referencedCell.Y)
			{
				ADODLKFEBOH = referencedCell.Y;
				OLBDPHOFKMN = referencedCell;
			}
			KPNBNKEBALD[referencedCell.X] = ((KPNBNKEBALD[referencedCell.X] <= referencedCell.Y) ? KPNBNKEBALD[referencedCell.X] : referencedCell.Y);
		}
		NPGABPICIAD = Vector3.Distance(HBKDNOHDOFG, JFALKIIHHIF.GetFrozenPosition()) <= Vector3.Distance(HBKDNOHDOFG, CDIFKOCLGAK.GetFrozenPosition());
		EOHKAAHIAEO = Vector3.Distance(HBKDNOHDOFG, OLBDPHOFKMN.GetFrozenPosition()) <= Vector3.Distance(HBKDNOHDOFG, NPJPAKBIHPC.GetFrozenPosition());
	}

	public int FGMDLNBGFJB(int AMFCENFNAJJ)
	{
		return KPNBNKEBALD[AMFCENFNAJJ];
	}
}
