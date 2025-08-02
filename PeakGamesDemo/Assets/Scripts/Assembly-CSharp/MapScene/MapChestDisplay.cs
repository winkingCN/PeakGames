using System;
using CasualTools.Dialogs;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace MapScene
{
	public abstract class MapChestDisplay : MonoBehaviour
	{
		public enum KMEIGFENLNO
		{
			Initial = 0,
			Collect = 1,
			Open = 2
		}

		public MapChestButton OpenButton;

		public GameObject OpenContent;

		public GameObject CollectContainer;

		public SpriteRenderer OuterGlow;

		public SpriteRenderer FlashSprite;

		public ParticleSystem OpenParticle;

		public SpriteRenderer[] SpriteRenderers;

		public TextMeshPro[] TextRenderers;

		protected KMEIGFENLNO AJGPGBIEPJC;

		private Action KFNJMBFFIFK;

		public abstract void UpdateDisplay();

		public void SetClickOnceCallback(Action HNJJMFOGAMG)
		{
			KFNJMBFFIFK = HNJJMFOGAMG;
		}

		protected void CFPKNHKNFOH()
		{
			if (KFNJMBFFIFK != null)
			{
				KFNJMBFFIFK();
				KFNJMBFFIFK = null;
			}
		}

		public void OnApplicationPause(bool APMMLLCMAKI)
		{
			if (!APMMLLCMAKI)
			{
				UpdateDisplay();
			}
		}

		public void ChangeButtonDepth(float IGNEOOOFEMO)
		{
			Vector3 localPosition = OpenButton.gameObject.transform.localPosition;
			localPosition.z = IGNEOOOFEMO;
			OpenButton.gameObject.transform.localPosition = localPosition;
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
			num = TextRenderers.Length;
			for (int j = 0; j < num; j++)
			{
				TextMeshPro textMeshPro = TextRenderers[j];
				if (textMeshPro != null)
				{
					textMeshPro.GDDGFAKOCIL += NNIDKMJGAJO;
				}
			}
		}

		protected void IBKKMOCAGFF()
		{
			base.gameObject.transform.localScale = Vector3.one;
			if (OuterGlow.gameObject.activeSelf)
			{
				OuterGlow.gameObject.SetActive(false);
			}
			OuterGlow.DOKill();
			OuterGlow.transform.DOKill();
			OuterGlow.color = new Color(1f, 1f, 1f, 0f);
			base.gameObject.transform.DOKill();
			base.gameObject.transform.localScale = Vector3.one;
		}

		protected void LDOFPOJOALI(bool LMCMBDHKBAD = false)
		{
			if (!OuterGlow.gameObject.activeSelf)
			{
				OuterGlow.gameObject.SetActive(true);
			}
			bool flag = false;
			OuterGlow.color = Color.white;
			if (LMCMBDHKBAD)
			{
				flag = true;
				OuterGlow.DOFade(0.4f, 0.6f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.OutSine);
			}
			else
			{
				OuterGlow.DOKill();
				OuterGlow.DOFade(0f, 0.35f);
			}
			if (flag)
			{
				base.gameObject.transform.DOScaleX(0.9f, 0.6f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.OutSine);
				base.gameObject.transform.DOScaleY(0.9f, 0.6f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.OutSine);
			}
		}
	}
}
