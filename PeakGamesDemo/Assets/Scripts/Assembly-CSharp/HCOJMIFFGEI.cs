using System;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.GamePlayScene.Tutorials;
using GamePlayScene.Mechanics.Items.SpecialItems;
using UnityEngine;

public class HCOJMIFFGEI : BIMAONBKNOP
{
	private Item CFNGLJOCEHP;

	private CKKKELDIOLD KKCPOOALFAD;

	private ParticleSystemRenderer PBMLDFAONOF;

	private ParticleSystemRenderer KFBEFFLDPAA;

	private ParticleSystemRenderer IGEPPJLAPMP;

	private ParticleSystemRenderer JNAMGAMIJHE;

	private int KAAANBDLLMA;

	public override void DIOELAHNLKJ(TutorialManager NGIFIPBOMBO)
	{
		base.DIOELAHNLKJ(NGIFIPBOMBO);
		EEABKKPJAOO = new string[1] { "Tutorial_0005" };
		KKCPOOALFAD = new CKKKELDIOLD(SortingLayer.NameToID("Dialogs"), 900);
	}

	public override void GDGINCNCMDD(Cell BBJPFHPBOHC)
	{
		try
		{
			if (JCLBCFCCPGG == 1)
			{
				int[] fFPHKNJCCIE = new int[4] { 3, 4, 4, 4 };
				OBEJDLFFIPA(fFPHKNJCCIE);
				CGECKLIKPGE.BackgroundFadeIn();
				CNFHIFJHOBL = false;
				CGECKLIKPGE.ShowDialog(NKILHODNBDE.GHBGCADFLFB(EEABKKPJAOO[JCLBCFCCPGG - 1]), new float[2] { 4f, 6f }, false);
				HorizontalRocketItem horizontalRocketItem = CGECKLIKPGE.GIMBEKBFKMJ.CurrentLevel.JHDMFHDHIFN.ECNCPJGHBIG(3, 4).LBFCDKPCDPB as HorizontalRocketItem;
				DiscoBallItem discoBallItem = CGECKLIKPGE.GIMBEKBFKMJ.CurrentLevel.JHDMFHDHIFN.ECNCPJGHBIG(4, 4).LBFCDKPCDPB as DiscoBallItem;
				horizontalRocketItem.ChangeSorting(KKCPOOALFAD);
				discoBallItem.ChangeSorting(KKCPOOALFAD);
				PBMLDFAONOF = horizontalRocketItem.CurrentComboHintParticle.FirstParticle;
				KFBEFFLDPAA = horizontalRocketItem.CurrentComboHintParticle.SecondParticle;
				IGEPPJLAPMP = discoBallItem.CurrentComboHintParticle.FirstParticle;
				JNAMGAMIJHE = discoBallItem.CurrentComboHintParticle.SecondParticle;
				KAAANBDLLMA = PBMLDFAONOF.sortingLayerID;
				PBMLDFAONOF.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
				KFBEFFLDPAA.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
				IGEPPJLAPMP.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
				JNAMGAMIJHE.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
				CGECKLIKPGE.ShowFingerAnimation(ONCMBJKLKIL.HINDAIPFFJL, CGECKLIKPGE.GetGlobalCellPosition(4f, 4f));
			}
			else
			{
				ECEDFDFBDNJ();
				ECMJGGMIOJJ();
			}
		}
		catch (Exception ex)
		{
			ECEDFDFBDNJ();
			ECMJGGMIOJJ();
			GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.Tutorial, "Tutorial ID: 5 Error: {0} " + ex);
		}
	}

	private void ECEDFDFBDNJ()
	{
		PBMLDFAONOF.sortingLayerID = KAAANBDLLMA;
		KFBEFFLDPAA.sortingLayerID = KAAANBDLLMA;
		IGEPPJLAPMP.sortingLayerID = KAAANBDLLMA;
		JNAMGAMIJHE.sortingLayerID = KAAANBDLLMA;
	}
}
