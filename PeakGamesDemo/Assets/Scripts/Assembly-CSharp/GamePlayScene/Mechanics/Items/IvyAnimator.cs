using UnityEngine;

namespace GamePlayScene.Mechanics.Items
{
	public class IvyAnimator : MonoBehaviour
	{
		public Animator CurrentAnimator;

		public GameObject AnimatorParent;

		public SpriteRenderer TopSprite;

		public SpriteRenderer[] SpriteRenderers;

		private int JHIABECKOLP;

		private const int DDAMBJHDPOG = 13;

		private static readonly int[,] MIINKNOIAFF = new int[2, 3]
		{
			{
				Animator.StringToHash("Base Layer.IvyItemIdleAnimation1"),
				Animator.StringToHash("Base Layer.IvyItemShakeAnimation1-1"),
				Animator.StringToHash("Base Layer.IvyItemShakeAnimation1-2")
			},
			{
				Animator.StringToHash("Base Layer.IvyItemIdleAnimation2"),
				Animator.StringToHash("Base Layer.IvyItemShakeAnimation2-1"),
				Animator.StringToHash("Base Layer.IvyItemShakeAnimation2-2")
			}
		};

		public void Prepare(int PODJBFDIHJO, bool MGHJIHIPMKC)
		{
			JHIABECKOLP = PODJBFDIHJO;
			TopSprite.enabled = MGHJIHIPMKC;
			base.transform.localPosition = Vector3.zero;
			CurrentAnimator.Play(MIINKNOIAFF[JHIABECKOLP, 0], -1, 0f);
		}

		public void PlayShakeAnimation()
		{
			CurrentAnimator.Play(MIINKNOIAFF[JHIABECKOLP, Random.Range(1, 3)], -1, 0f);
		}

		public void ChangeSorting(CKKKELDIOLD KHFBHDLBLJH)
		{
			int i = 0;
			for (int num = SpriteRenderers.Length; i < num; i++)
			{
				int num2 = ((JHIABECKOLP != 0) ? 13 : 0);
				SpriteRenderer spriteRenderer = SpriteRenderers[i];
				spriteRenderer.sortingOrder = KHFBHDLBLJH.BHIJCAOHDCM + i + num2;
				spriteRenderer.sortingLayerID = KHFBHDLBLJH.MMFFDANAEEI;
			}
		}

		public void Recycle()
		{
			base.transform.SetParent(null);
			TopSprite.enabled = false;
			AnimatorParent.transform.localScale = Vector3.one;
			AnimatorParent.transform.localPosition = Vector3.zero;
			base.gameObject.MEJPNNFDEBD();
		}
	}
}
