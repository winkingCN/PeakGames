using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.MapScene
{
	public class InboxTab : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class GPCADFDNCOD
		{
			internal ParticleSystem FLLHHHDFCKA;

			internal void AGFNGEFDHLA()
			{
				if (!(FLLHHHDFCKA == null))
				{
					FLLHHHDFCKA.Stop();
					FLLHHHDFCKA.gameObject.MEJPNNFDEBD();
				}
			}
		}

		public Transform InboxButton;

		public TextMeshPro InboxCountText;

		public SpriteRenderer InboxCountBackground;

		public GameObject LifeCollectParticle;

		private Sequence DGEFOEFAIIM;

		private int KIHPFKLBAHH;

		public void Awake()
		{
			UpdateToCurrentCount();
		}

		public void UpdateCount(int ENMLICFLHAO)
		{
			InboxCountText.FCJBBPHFNPJ = ENMLICFLHAO.ToString();
			InboxCountText.gameObject.SetActive(ENMLICFLHAO > 0);
			InboxCountBackground.enabled = ENMLICFLHAO > 0;
		}

		public void UpdateToCurrentCount()
		{
			UpdateCount(CAGBGIHKHEJ.GABGKBAKHDP.ELEKFHDLKJJ());
		}

		public void PlayHitAnimation()
		{
			int frameCount = Time.frameCount;
			if (frameCount - KIHPFKLBAHH < 2)
			{
				return;
			}
			KIHPFKLBAHH = frameCount;
			InboxButton.localScale = Vector3.one;
			DGEFOEFAIIM.Kill();
			DGEFOEFAIIM = DOTween.Sequence();
			DGEFOEFAIIM.SetRecyclable(false);
			DGEFOEFAIIM.Insert(0f, InboxButton.DOScale(Vector3.one * 0.9f, 0.1f));
			DGEFOEFAIIM.Insert(0.1f, InboxButton.DOScale(Vector3.one, 0.1f));
			ParticleSystem FLLHHHDFCKA = LifeCollectParticle.JOBDHIPIMAG().GetComponent<ParticleSystem>();
			if (!(FLLHHHDFCKA != null))
			{
				return;
			}
			FLLHHHDFCKA.transform.position = InboxButton.position;
			FLLHHHDFCKA.Play();
			Sequence sequence = DOTween.Sequence();
			sequence.SetRecyclable(false);
			sequence.AppendInterval(1f);
			sequence.OnComplete(delegate
			{
				if (!(FLLHHHDFCKA == null))
				{
					FLLHHHDFCKA.Stop();
					FLLHHHDFCKA.gameObject.MEJPNNFDEBD();
				}
			});
		}
	}
}
