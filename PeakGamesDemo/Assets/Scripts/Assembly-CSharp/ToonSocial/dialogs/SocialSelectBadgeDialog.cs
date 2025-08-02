using System;
using Assets.Scripts.Dialogs;
using ToonSocial.ui.notjoined;
using Ui.VerticalScroll;
using UnityEngine;

namespace ToonSocial.dialogs
{
	public class SocialSelectBadgeDialog : SimpleDialog
	{
		public VerticalScrollController ScrollContoller;

		public GameObject RowPrefab;

		public SpriteMask MyMask;

		public Action<string> OnBadgeSelected;

		public void Prepare(Camera LFCBBKIFIJA, SocialHelper JANPCBNIGFG)
		{
			DialogCreated();
			ScrollContoller.CurrentCamera = LFCBBKIFIJA;
			ScrollContoller.Init();
			Sprite[] badgeSprites = JANPCBNIGFG.BadgesDictionary.BadgeSprites;
			int num = badgeSprites.Length / 5;
			for (int i = 0; i < num; i++)
			{
				GameObject gameObject = ScrollContoller.AddPrefab(new Vector3(-3.36f, -1.85f * (float)i + 0.66f, 0f), RowPrefab);
				SelectBadgeRow component = gameObject.GetComponent<SelectBadgeRow>();
				for (int j = 0; j < 5; j++)
				{
					int num2 = i * 5 + j;
					if (num2 >= badgeSprites.Length)
					{
						component.BadgeInners[j].gameObject.SetActive(false);
						continue;
					}
					component.BadgeButtons[j].CurrentDialog = this;
					component.BadgeInners[j].gameObject.SetActive(true);
					component.BadgeInners[j].sprite = badgeSprites[num2];
				}
			}
			ScrollContoller.SetContentSize(1.85f * (float)num + 0.33f);
			ScrollContoller.JBOFOOHGDGC();
			MyMask.update();
		}

		public void BadgeSelected(string IOCMOCCFALN)
		{
			if (OnBadgeSelected != null)
			{
				OnBadgeSelected(IOCMOCCFALN);
			}
			Close();
		}
	}
}
