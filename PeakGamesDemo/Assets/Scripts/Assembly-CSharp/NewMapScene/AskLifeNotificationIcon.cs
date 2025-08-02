using System;
using TMPro;
using UnityEngine;

namespace NewMapScene
{
	public class AskLifeNotificationIcon : MonoBehaviour
	{
		public TextMeshPro CountText;

		public SpriteRenderer CountBackground;

		public void Awake()
		{
			UpdateCount(0);
			if (GFHPEDILAJG.GABGKBAKHDP.ODMCGBLJFKM)
			{
				int num = GFHPEDILAJG.GABGKBAKHDP.DIHIHGCLEKI();
				if (num != 0 && DateTime.Now.GMEBBNOHJFJ() > num)
				{
					UpdateCount(1);
				}
			}
		}

		public void UpdateCount(int ENMLICFLHAO)
		{
			if (!GFHPEDILAJG.GABGKBAKHDP.ODMCGBLJFKM)
			{
				ENMLICFLHAO = 0;
			}
			CountText.FCJBBPHFNPJ = ENMLICFLHAO.ToString();
			CountText.gameObject.SetActive(ENMLICFLHAO > 0);
			CountBackground.enabled = ENMLICFLHAO > 0;
		}
	}
}
