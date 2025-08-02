using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using GamePlayScene.Mechanics;
using UnityEngine;

public class SoapItem : Item
{
	public SpriteRenderer[] SpriteRenderers;

	private CKKKELDIOLD IFIDCMMCNLE;

	private bool PIGCJDKPMFL;

	private bool PHFMLILLELO = true;

	private Vector3 KDPDJDMKBMB { get; set; }

	public override NOALGNJECAD GetItemType()
	{
		return NOALGNJECAD.Soap;
	}

	public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
	{
		IFIDCMMCNLE = IBBBMACIBGK;
		for (int i = 0; i < SpriteRenderers.Length; i++)
		{
			SpriteRenderer spriteRenderer = SpriteRenderers[i];
			spriteRenderer.sortingLayerID = IFIDCMMCNLE.MMFFDANAEEI;
			spriteRenderer.sortingOrder = IFIDCMMCNLE.BHIJCAOHDCM + i;
		}
	}

	public override CKKKELDIOLD GetSorting()
	{
		return IFIDCMMCNLE;
	}

	public override bool CanBeTapped()
	{
		return true;
	}

	public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
	{
		return true;
	}

	public override bool CanGenerateScoreOnEachTryExplode()
	{
		return PHFMLILLELO;
	}

	public override void PlayExplodeAudio()
	{
	}

	public override bool TryExplode(APBDPLNCDIJ CCPAJBOJDMN)
	{
		if (PIGCJDKPMFL)
		{
			return false;
		}
		if (!LAGEBFBEINC(CCPAJBOJDMN))
		{
			return false;
		}
		PHFMLILLELO = false;
		PIGCJDKPMFL = true;
		KDPDJDMKBMB = base.transform.position;
		ScoreManager.RaiseScore(GetScore());
		StartCoroutine(MGHAKELDMOK());
		return false;
	}

	private IEnumerator MGHAKELDMOK()
	{
		yield return null;
		CFOIPDKEFMM jHDMFHDHIFN = ELFBOKDHKGG.JHDMFHDHIFN;
		List<Cell> FFPHKNJCCIE = new List<Cell>
		{
			jHDMFHDHIFN.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Up),
			jHDMFHDHIFN.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.RightUp),
			jHDMFHDHIFN.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Right),
			jHDMFHDHIFN.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.RightDown),
			jHDMFHDHIFN.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Down),
			jHDMFHDHIFN.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.LeftDown),
			jHDMFHDHIFN.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.Left),
			jHDMFHDHIFN.PHOOMEOBJCB(ENCFFNKONOO, IEKBFJBLGFM.LeftUp),
			ENCFFNKONOO
		};
		LLJLGKECBBE.GABGKBAKHDP.MEBOIANIOCH(ref FFPHKNJCCIE);
		MNDFGCNLHHA(FFPHKNJCCIE);
	}

	private void MNDFGCNLHHA(List<Cell> FFPHKNJCCIE)
	{
		int count = FFPHKNJCCIE.Count;
		for (int i = 0; i < count; i++)
		{
			Cell cell = FFPHKNJCCIE[i];
			cell.AddBubble(true);
			GameObject gameObject = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Animators[0].JOBDHIPIMAG();
			gameObject.transform.position = base.transform.position;
			SoapBubbleAnimation component = gameObject.GetComponent<SoapBubbleAnimation>();
			component.Prepare(cell);
			ELFBOKDHKGG.JPAFPKIDJDJ(NOALGNJECAD.Bubble);
		}
		ELFBOKDHKGG.DJNEAFJLFIH(GetItemType());
		ELFBOKDHKGG.ACJOALJFMHN(GetItemType(), false);
		if (count != 0)
		{
			AudioManager.PlayAudioPropsLater(0.55f, ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[0]);
		}
		StartExplode();
	}

	protected override void EJCFANPAMMK()
	{
		if (ItemResourcesManager.GABGKBAKHDP != null)
		{
			ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[0], KDPDJDMKBMB);
			AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[1]);
		}
	}

	public override int GetScore()
	{
		return 0;
	}

	public override bool CanCastShadow()
	{
		return true;
	}

	public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
	{
		PNINCDLIDLL.EEFMIHDPJPG = 76;
	}
}
