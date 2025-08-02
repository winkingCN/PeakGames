using System;
using Assets.Scripts.Dialogs;
using UnityEngine;
using Utils;

namespace MapScene
{
	public class DailyBonusDisplay : MapDisplay
	{
		public SpriteRenderer[] SpriteRenderers;

		private Action KFNJMBFFIFK;

		private Action NAFKELLKIKO;

		public void SetClickOnceCallback(Action FFFINJKEBGO, Action ADBCFBIKKCP)
		{
			KFNJMBFFIFK = FFFINJKEBGO;
			NAFKELLKIKO = ADBCFBIKKCP;
		}

		public void Prepare()
		{
			if (MOPHKBIGBPD())
			{
				base.gameObject.SetActive(true);
			}
			else
			{
				base.gameObject.SetActive(false);
			}
		}

		private bool MOPHKBIGBPD()
		{
			return DJFEHCGIDGC.GABGKBAKHDP.NPDHFFPKPLF();
		}

		public void OnClick()
		{
			GameObject gameObject = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.DailyBonusDialog, false);
			if (KFNJMBFFIFK != null)
			{
				KFNJMBFFIFK();
				KFNJMBFFIFK = null;
				if (NAFKELLKIKO != null)
				{
					gameObject.GetComponent<DailyBonusDialog>().SetOnDialogClosedCallback(NAFKELLKIKO);
					NAFKELLKIKO = null;
				}
			}
		}

		public void ChangeButtonDepth(float IGNEOOOFEMO)
		{
			Vector3 localPosition = base.transform.localPosition;
			localPosition.z = IGNEOOOFEMO;
			base.transform.localPosition = localPosition;
		}

		public void IncreaseSortingOrder(int NNIDKMJGAJO)
		{
			int num = SpriteRenderers.Length;
			for (int i = 0; i < num; i++)
			{
				SpriteRenderer spriteRenderer = SpriteRenderers[i];
				if (spriteRenderer != null)
				{
					spriteRenderer.sortingOrder += NNIDKMJGAJO;
				}
			}
		}
	}
}
