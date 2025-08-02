using System;
using System.Collections;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.Utils;
using UnityEngine;
using UnityEngine.Rendering;

namespace GamePlayScene.Mechanics.Items
{
	public class MoleItem : Item, JFIEHOCCBNG
	{
		public Animator CurrentAnimator;

		public SortingGroup MoleSortingGroup;

		private int LKFKKIFGDEF;

		private int HMKKJHHEEOC;

		private CKKKELDIOLD KKCPOOALFAD;

		private int JEDDCLEDIPI = -1;

		private int OIMJNGAAAND;

		private int AHEAGFKDBHP;

		private bool PIGCJDKPMFL;

		private readonly WaitForSeconds JHLDECOOBKH = new WaitForSeconds(0.3f);

		private void Awake()
		{
			LKFKKIFGDEF = Animator.StringToHash("Base Layer.MoleUpAnimation");
			HMKKJHHEEOC = Animator.StringToHash("Base Layer.MoleDownAnimation");
		}

		public override void OnItemCreated(KFCEILFGADG MGOFDOMDLCO)
		{
			base.OnItemCreated(MGOFDOMDLCO);
			ELFBOKDHKGG.OGIJEDJHMNG.Add(this);
		}

		public override NOALGNJECAD GetItemType()
		{
			return NOALGNJECAD.Mole;
		}

		public override int GetScore()
		{
			return 500;
		}

		public override bool CanCastShadow()
		{
			return false;
		}

		public override bool CanFall()
		{
			return false;
		}

		public override bool CanExplodeDueToExplodeInNeigbour(LEDBLDKJBAI KOINNGEBMJI)
		{
			return true;
		}

		public override void ChangeSorting(CKKKELDIOLD IBBBMACIBGK)
		{
			KKCPOOALFAD = IBBBMACIBGK;
			MoleSortingGroup.sortingLayerID = KKCPOOALFAD.MMFFDANAEEI;
			MoleSortingGroup.sortingOrder = KKCPOOALFAD.BHIJCAOHDCM;
		}

		public override CKKKELDIOLD GetSorting()
		{
			return KKCPOOALFAD;
		}

		public override int GetLayerCount()
		{
			return (AHEAGFKDBHP != 0) ? 1 : 2;
		}

		public override void ExplodeByBlasterItem(APBDPLNCDIJ CCPAJBOJDMN)
		{
			if (!PIGCJDKPMFL)
			{
				JEDDCLEDIPI = ELFBOKDHKGG.EBMFPDNPIEM + 1;
				AHEAGFKDBHP = 1;
				base.ExplodeByBlasterItem(CCPAJBOJDMN);
			}
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
			int jEDDCLEDIPI = JEDDCLEDIPI;
			JEDDCLEDIPI = ELFBOKDHKGG.EBMFPDNPIEM;
			if (AHEAGFKDBHP == 0)
			{
				MJHIKOODBMD(1);
				return false;
			}
			PIGCJDKPMFL = jEDDCLEDIPI - JEDDCLEDIPI <= 1;
			return PIGCJDKPMFL;
		}

		protected override void EJCFANPAMMK()
		{
			if (ParticlePool.Instance != null && ItemResourcesManager.GABGKBAKHDP != null)
			{
				ParticlePool.Instance.PlayParticle(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).Particles[0], base.transform.position);
			}
		}

		public override void PlayExplodeAudio()
		{
			if (ItemResourcesManager.GABGKBAKHDP != null)
			{
				AudioManager.PlayAudioProps(ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType()).AudioClips[1]);
			}
		}

		public override void OnCellItemExploded()
		{
			base.OnCellItemExploded();
			OIMJNGAAAND = ELFBOKDHKGG.EBMFPDNPIEM;
		}

		public void ExplosionOccured(int CIDKKPKJJAE)
		{
			if (ENCFFNKONOO != null && (ENCFFNKONOO.HasCellItem() || ENCFFNKONOO.CGLFCDDLOKA))
			{
				JEDDCLEDIPI = CIDKKPKJJAE;
			}
			else if (OIMJNGAAAND == CIDKKPKJJAE)
			{
				JEDDCLEDIPI = CIDKKPKJJAE;
			}
			else if (CIDKKPKJJAE != JEDDCLEDIPI)
			{
				MJHIKOODBMD(0);
			}
		}

		private void MJHIKOODBMD(int PLCFEOMGCFK)
		{
			try
			{
				if (!PIGCJDKPMFL && AHEAGFKDBHP != PLCFEOMGCFK)
				{
					ItemResources itemResources = null;
					if (ItemResourcesManager.GABGKBAKHDP != null)
					{
						itemResources = ItemResourcesManager.GABGKBAKHDP.GetResources(GetItemType());
					}
					AHEAGFKDBHP = PLCFEOMGCFK;
					switch (AHEAGFKDBHP)
					{
					case 0:
						CurrentAnimator.Play(HMKKJHHEEOC, 0, 0f);
						StartCoroutine(MKAHADMMLHK());
						break;
					case 1:
						CurrentAnimator.Play(LKFKKIFGDEF, 0, 0f);
						StartCoroutine(MKAHADMMLHK());
						AudioManager.PlayAudioProps(itemResources.AudioClips[0]);
						break;
					}
				}
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.KIFFBFPEMGP(PBIIDJOKNEK.GamePlay, "Mole Item Move to state:{0} Error:{1} Stack:{2}", PLCFEOMGCFK, ex.Message, ex.StackTrace);
			}
		}

		private IEnumerator MKAHADMMLHK()
		{
			int sortingOrder = 1200 + (8 - ENCFFNKONOO.Y) * 20;
			MoleSortingGroup.sortingOrder = sortingOrder;
			yield return JHLDECOOBKH;
			MoleSortingGroup.sortingOrder = KKCPOOALFAD.BHIJCAOHDCM;
		}

		public override void GetItemSnapshotData(EFKAKDCJCCK PNINCDLIDLL)
		{
			PNINCDLIDLL.EEFMIHDPJPG = 77;
			byte aINNOPBDDGL = (byte)AHEAGFKDBHP;
			PNINCDLIDLL.DKJDLMNKFGM(aINNOPBDDGL);
		}

		protected void DFBDGLFPFAB(int BGEDKGLJIGM)
		{
			AHEAGFKDBHP = BGEDKGLJIGM;
			if (AHEAGFKDBHP == 1)
			{
				JEDDCLEDIPI = ELFBOKDHKGG.EBMFPDNPIEM;
			}
		}

		protected int FHKKKAKGKFH()
		{
			return LKFKKIFGDEF;
		}
	}
}
