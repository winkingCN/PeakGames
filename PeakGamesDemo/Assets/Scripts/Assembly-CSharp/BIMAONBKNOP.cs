using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Tutorials;
using UnityEngine;

public abstract class BIMAONBKNOP
{
	public string[] EEABKKPJAOO;

	public List<Cell> BALIENJLCLB;

	protected TutorialManager CGECKLIKPGE;

	protected int JCLBCFCCPGG;

	public bool CNFHIFJHOBL = true;

	protected float JAPIODJLBKJ;

	protected readonly float JEONAPJKCAI = 2f;

	public virtual void DIOELAHNLKJ(TutorialManager NGIFIPBOMBO)
	{
		CGECKLIKPGE = NGIFIPBOMBO;
		JAPIODJLBKJ = Time.time;
	}

	public virtual void BDAKKAIBMIM(Cell BBJPFHPBOHC = null, bool AEGOANBPCGB = false, bool PCCBMIJAFPK = false)
	{
		if ((CNFHIFJHOBL || AEGOANBPCGB) && (!PCCBMIJAFPK || !(Time.time - JAPIODJLBKJ < JEONAPJKCAI)))
		{
			JCLBCFCCPGG++;
			GDGINCNCMDD(BBJPFHPBOHC);
		}
	}

	public abstract void GDGINCNCMDD(Cell BBJPFHPBOHC);

	protected void OBEJDLFFIPA(int[] FFPHKNJCCIE)
	{
		if (FFPHKNJCCIE != null && FFPHKNJCCIE.Length != 0)
		{
			int num = FFPHKNJCCIE.Length;
			BALIENJLCLB = new List<Cell>();
			for (int i = 0; i < num; i += 2)
			{
				int aMFCENFNAJJ = FFPHKNJCCIE[i];
				int cNLILOEEBOJ = FFPHKNJCCIE[i + 1];
				BALIENJLCLB.Add(CGECKLIKPGE.GIMBEKBFKMJ.CurrentLevel.JHDMFHDHIFN.ECNCPJGHBIG(aMFCENFNAJJ, cNLILOEEBOJ));
			}
		}
	}

	protected void CHIPOHEMKEG()
	{
		BALIENJLCLB = null;
	}

	protected void ECMJGGMIOJJ()
	{
		CNFHIFJHOBL = false;
		new LLCJMMBBLEH(IAJFFKHPBHP());
	}

	protected IEnumerator IAJFFKHPBHP()
	{
		yield return null;
		CGECKLIKPGE.RemoveSelf();
	}
}
