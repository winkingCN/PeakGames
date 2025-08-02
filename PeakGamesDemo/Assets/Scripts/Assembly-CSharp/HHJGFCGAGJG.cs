using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items.SpecialItems;
using Assets.Scripts.GamePlayScene.Tutorials;
using UnityEngine;

public class HHJGFCGAGJG : BIMAONBKNOP
{
	public const string OHKPMOBDLJH = "TutorialCombo";

	private readonly HashSet<SpecialItem> FCNIAAHFJMI = new HashSet<SpecialItem>();

	private readonly CKKKELDIOLD KKCPOOALFAD = new CKKKELDIOLD(SortingLayer.NameToID("Dialogs"), 900);

	private readonly Dictionary<SpecialItem, CKKKELDIOLD> IJFCDOJEFCG = new Dictionary<SpecialItem, CKKKELDIOLD>();

	private readonly List<ParticleSystemRenderer> PPNFMACEHDM = new List<ParticleSystemRenderer>();

	private int DOLDPJNDPJG;

	private Cell MFDIJEHOMBG;

	private readonly Dictionary<NOALGNJECAD, int> MKBDFNMJADI = new Dictionary<NOALGNJECAD, int>
	{
		{
			NOALGNJECAD.DiscoBall,
			3000
		},
		{
			NOALGNJECAD.Bomb,
			2000
		},
		{
			NOALGNJECAD.Rocket,
			1000
		}
	};

	public HHJGFCGAGJG(PBLOIKDOPAJ CNKHNFDJJBB)
	{
		EEABKKPJAOO = new string[1] { "Tutorial_0005" };
		int i = 0;
		for (int count = CNKHNFDJJBB.OABGDODKPKM.Count; i < count; i++)
		{
			Cell cell = CNKHNFDJJBB.OABGDODKPKM[i];
			if (cell.EAILOFHFNJO && cell.LBFCDKPCDPB is SpecialItem)
			{
				if (MFDIJEHOMBG == null)
				{
					MFDIJEHOMBG = cell;
				}
				SpecialItem specialItem = (SpecialItem)cell.LBFCDKPCDPB;
				FCNIAAHFJMI.Add(specialItem);
				IJFCDOJEFCG.Add(specialItem, specialItem.GetSorting());
			}
		}
	}

	public override void GDGINCNCMDD(Cell BBJPFHPBOHC)
	{
		int jCLBCFCCPGG = JCLBCFCCPGG;
		if (jCLBCFCCPGG == 1)
		{
			TutorialManager.IsThereComboTutorial = true;
			CGECKLIKPGE.HideBackground();
			CGECKLIKPGE.HideDialog();
			CNFHIFJHOBL = false;
			new LLCJMMBBLEH(NKPJBCMPJMM());
		}
		else
		{
			TutorialManager.IsThereComboTutorial = false;
			HintManager.Instance.ShouldCheckComboTutorial = false;
			HJBLKNBHMFJ.GABGKBAKHDP.JGMDDMNGDJO("TutorialCombo", "1");
			PMOHDCMJAFD();
			ECMJGGMIOJJ();
		}
	}

	private IEnumerator NKPJBCMPJMM()
	{
		yield return MCJHHDACJBG.CNDGGNLKOOC;
		while (FallManager.AreThereFallingItems() || FallManager.AreThereActiveAnimations())
		{
			yield return MCJHHDACJBG.CNDGGNLKOOC;
		}
		yield return NHEHBGHGEIP(FCNIAAHFJMI);
		while (FallManager.AreThereFallingItems() || FallManager.AreThereActiveAnimations())
		{
			yield return MCJHHDACJBG.CNDGGNLKOOC;
		}
		PKOIDACHFJF pKOIDACHFJF = new PKOIDACHFJF(MFDIJEHOMBG.CurrentGrid);
		PBLOIKDOPAJ pBLOIKDOPAJ = pKOIDACHFJF.IBJBJENCOAB(MFDIJEHOMBG);
		HashSet<SpecialItem> hashSet = new HashSet<SpecialItem>();
		int i = 0;
		for (int count = pBLOIKDOPAJ.OABGDODKPKM.Count; i < count; i++)
		{
			Cell cell = pBLOIKDOPAJ.OABGDODKPKM[i];
			if (cell.Exists && cell.EAILOFHFNJO && cell.LBFCDKPCDPB is SpecialItem)
			{
				SpecialItem specialItem = (SpecialItem)cell.LBFCDKPCDPB;
				if (!FCNIAAHFJMI.Contains(specialItem) && !hashSet.Contains(specialItem))
				{
					hashSet.Add(specialItem);
					IJFCDOJEFCG.Add(specialItem, specialItem.GetSorting());
				}
			}
		}
		yield return NHEHBGHGEIP(hashSet);
		FCNIAAHFJMI.UnionWith(hashSet);
		int num = 1000;
		int num2 = -1000;
		int count2 = FCNIAAHFJMI.Count;
		int num3 = 0;
		int[] array = new int[count2 * 2];
		Cell cell2 = null;
		int num4 = 0;
		foreach (SpecialItem item in FCNIAAHFJMI)
		{
			Cell currentCell = item.ENCFFNKONOO;
			int num5 = num3 * 2;
			array[num5] = currentCell.X;
			array[num5 + 1] = currentCell.Y;
			if (currentCell.Y < num)
			{
				num = currentCell.Y;
			}
			if (currentCell.Y > num2)
			{
				num2 = currentCell.Y;
			}
			if (!currentCell.EAILOFHFNJO || !(currentCell.LBFCDKPCDPB is SpecialItem))
			{
				continue;
			}
			if (cell2 == null)
			{
				cell2 = currentCell;
				num4 = OMCCOKLEJHJ(item, currentCell);
			}
			else
			{
				int num6 = OMCCOKLEJHJ(item, currentCell);
				if (num6 > num4)
				{
					num4 = num6;
					cell2 = currentCell;
				}
			}
			num3++;
		}
		Vector2 zero = Vector2.zero;
		if (cell2 != null)
		{
			CFOIPDKEFMM currentGrid = cell2.CurrentGrid;
			int num7 = currentGrid.FHAMOHDEGMK - num2;
			int num8 = num;
			zero.x = (float)(currentGrid.EMFKAPJMDCC - 1) * 0.5f;
			zero.y = ((num7 <= num8) ? ((float)num - 4f) : ((float)num2 + 2f));
		}
		OBEJDLFFIPA(array);
		CGECKLIKPGE.ShowDialog(NKILHODNBDE.GHBGCADFLFB(EEABKKPJAOO[0]), new float[2] { zero.x, zero.y }, false);
		CGECKLIKPGE.BackgroundFadeIn();
		CGECKLIKPGE.ShowFingerAnimation(ONCMBJKLKIL.HINDAIPFFJL, CGECKLIKPGE.GetGlobalCellPosition(cell2.X, cell2.Y));
		yield return null;
	}

	private int OMCCOKLEJHJ(SpecialItem ALAJBEFFOKB, Cell LBHDELJBONF)
	{
		return MKBDFNMJADI[ALAJBEFFOKB.GetItemType()] + (9 - LBHDELJBONF.Y) * 100 + LBHDELJBONF.X * 10;
	}

	private IEnumerator NHEHBGHGEIP(HashSet<SpecialItem> IEECOIONEJM)
	{
		float time = Time.time;
		foreach (SpecialItem item in IEECOIONEJM)
		{
			item.ChangeSorting(KKCPOOALFAD);
			while (Time.time - time < 0.1f && item.CurrentComboHintParticle == null)
			{
				yield return MCJHHDACJBG.CNDGGNLKOOC;
			}
			if (item.CurrentComboHintParticle == null)
			{
				foreach (KeyValuePair<SpecialItem, CKKKELDIOLD> item2 in IJFCDOJEFCG)
				{
					item2.Key.ChangeSorting(item2.Value);
				}
				TutorialManager.IsThereComboTutorial = false;
				PMOHDCMJAFD();
				ECMJGGMIOJJ();
				HintManager.Instance.ResetComboFlag();
				break;
			}
			if (DOLDPJNDPJG == 0)
			{
				DOLDPJNDPJG = item.CurrentComboHintParticle.FirstParticle.sortingLayerID;
			}
			ParticleSystemRenderer firstParticle = item.CurrentComboHintParticle.FirstParticle;
			CKKKELDIOLD kKCPOOALFAD = KKCPOOALFAD;
			firstParticle.sortingLayerID = kKCPOOALFAD.MMFFDANAEEI;
			ParticleSystemRenderer secondParticle = item.CurrentComboHintParticle.SecondParticle;
			CKKKELDIOLD kKCPOOALFAD2 = KKCPOOALFAD;
			secondParticle.sortingLayerID = kKCPOOALFAD2.MMFFDANAEEI;
			PPNFMACEHDM.Add(item.CurrentComboHintParticle.FirstParticle);
			PPNFMACEHDM.Add(item.CurrentComboHintParticle.SecondParticle);
		}
	}

	private void PMOHDCMJAFD()
	{
		for (int i = 0; i < PPNFMACEHDM.Count; i++)
		{
			PPNFMACEHDM[i].sortingLayerID = DOLDPJNDPJG;
		}
	}
}
