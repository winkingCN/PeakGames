using System.Collections.Generic;
using Assets.Scripts.Utils;
using DG.Tweening;
using TMPro;
using UnityEngine;
using Utils;

namespace Assets.Scripts.Dialogs
{
	public class PrelevelDialogBooster : MonoBehaviour
	{
		private int GMFKFCNPDKF;

		private bool LCIMCNABGLF;

		private NAAHKHPBAPA HCEHJCHHNFE;

		public SpriteRenderer ButtonBack;

		public Sprite ButtonDefault;

		public Sprite ButtonSelected;

		public GameObject CheckBox;

		public BoxCollider2D Collider;

		public TextMeshPro CountText;

		public SpriteRenderer Icon;

		public SpriteRenderer Lock;

		private BoosterSelectDialog GKDGMJJDHKK;

		private Tweener EOOCHMBIFFJ;

		private const string AHIFGBNLHON = "+";

		public NAAHKHPBAPA ENBPGGCIADN
		{
			get
			{
				return HCEHJCHHNFE;
			}
		}

		public bool EMHPOLAIJOK
		{
			get
			{
				return !LCIMCNABGLF && !CountText.enabled;
			}
		}

		public void Init(NAAHKHPBAPA NBFBPNNEKMN, bool MHDCKCCCBAM, BoosterSelectDialog LIMMFGDCLAB)
		{
			GKDGMJJDHKK = LIMMFGDCLAB;
			LCIMCNABGLF = MHDCKCCCBAM;
			HCEHJCHHNFE = NBFBPNNEKMN;
			GMFKFCNPDKF = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(HCEHJCHHNFE);
			if (MHDCKCCCBAM)
			{
				Collider.enabled = false;
				ButtonBack.enabled = false;
				CountText.enabled = false;
				Lock.enabled = true;
				Icon.enabled = false;
			}
			else
			{
				Lock.enabled = false;
				Collider.enabled = true;
				ButtonBack.enabled = true;
				Icon.enabled = true;
				CountText.FCJBBPHFNPJ = ((GMFKFCNPDKF != 0) ? GMFKFCNPDKF.ToString() : "+");
			}
		}

		public void UpdateBoosterCounts()
		{
			GMFKFCNPDKF = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(ENBPGGCIADN);
			CountText.FCJBBPHFNPJ = ((GMFKFCNPDKF != 0) ? GMFKFCNPDKF.ToString() : "+");
		}

		public void SwitchBoosterStatusByItemType(List<NOALGNJECAD> CKGGOKBPOJP)
		{
			if ((HCEHJCHHNFE == NAAHKHPBAPA.Rocket && CKGGOKBPOJP.Contains(NOALGNJECAD.Rocket)) || (HCEHJCHHNFE == NAAHKHPBAPA.Bomb && CKGGOKBPOJP.Contains(NOALGNJECAD.Bomb)) || (HCEHJCHHNFE == NAAHKHPBAPA.DiscoBall && CKGGOKBPOJP.Contains(NOALGNJECAD.DiscoBall)))
			{
				SwitchBoosterStatus();
			}
		}

		public void SwitchBoosterStatus()
		{
			AudioManager.Play(KOOGPFAPGGD.UiClick, GCEAKOOGDJK.Multiple);
			DCOIFEIGMJF();
			if (GMFKFCNPDKF > 0)
			{
				if (CountText.enabled)
				{
					CountText.enabled = false;
					CheckBox.SetActive(true);
					ButtonBack.sprite = ButtonSelected;
				}
				else
				{
					ButtonBack.sprite = ButtonDefault;
					CountText.enabled = true;
					CheckBox.SetActive(false);
				}
			}
			else
			{
				GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.BuyResourcesDialog, false);
				BuyResourcesDialog component = gameObject.GetComponent<BuyResourcesDialog>();
				if (component != null)
				{
					component.SetResourceItem(HCEHJCHHNFE, BOKGFGFPOHD.DNCLFKKHEPL(HCEHJCHHNFE), KNIGGOPNGHD);
				}
			}
		}

		private void DCOIFEIGMJF()
		{
			if (EOOCHMBIFFJ != null)
			{
				EOOCHMBIFFJ.Complete();
			}
			EOOCHMBIFFJ = base.transform.DOPunchScale(Vector3.one * 0.1f, 0.3f);
		}

		private void KNIGGOPNGHD(NAAHKHPBAPA HBBIFNLDKPO)
		{
			GMFKFCNPDKF = GEBAAFFGKJG.GABGKBAKHDP.JFGLEMPLBKE(HCEHJCHHNFE);
			CountText.FCJBBPHFNPJ = ((GMFKFCNPDKF != 0) ? GMFKFCNPDKF.ToString() : "+");
			if (GMFKFCNPDKF > 0 && !EMHPOLAIJOK)
			{
				SwitchBoosterStatus();
			}
			GKDGMJJDHKK.UpdateBoosterCounts();
		}
	}
}
