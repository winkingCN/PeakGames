using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Items
{
	public class CanBox : MonoBehaviour
	{
		public SpriteRenderer CurrentSpriteRenderer;

		public Animator CurrentAnimator;

		[HideInInspector]
		public int Id;

		private bool AKANCHEKDCG;

		private int[] DNICNDODLCP;

		private int[] EGCJCOOLBID;

		public void Awake()
		{
			DNICNDODLCP = new int[3]
			{
				Animator.StringToHash("Base Layer.CanItemShakeUp1"),
				Animator.StringToHash("Base Layer.CanItemShakeUp2"),
				Animator.StringToHash("Base Layer.CanItemShakeUp3")
			};
			EGCJCOOLBID = new int[5]
			{
				Animator.StringToHash("Base Layer.CanItemShakeDown1"),
				Animator.StringToHash("Base Layer.CanItemShakeDown2"),
				Animator.StringToHash("Base Layer.CanItemShakeDown3"),
				Animator.StringToHash("Base Layer.CanItemShakeDown4"),
				Animator.StringToHash("Base Layer.CanItemShakeDown5")
			};
		}

		public void PlayShakeAnimation(int FGFEGHLBFNP = 8)
		{
			if (!AKANCHEKDCG)
			{
				int num = 0;
				num = ((Id < 3) ? DNICNDODLCP[Random.Range(0, DNICNDODLCP.Length)] : ((Id < 6 && FGFEGHLBFNP < 8) ? DNICNDODLCP[Random.Range(0, DNICNDODLCP.Length)] : ((Id >= 9 || FGFEGHLBFNP >= 5) ? EGCJCOOLBID[Random.Range(0, EGCJCOOLBID.Length)] : DNICNDODLCP[Random.Range(0, DNICNDODLCP.Length)])));
				CurrentAnimator.Play(num, 0, 0f);
			}
		}

		public void Remove()
		{
			AKANCHEKDCG = true;
			CurrentSpriteRenderer.enabled = false;
			CurrentAnimator.StopPlayback();
		}

		public void OnDestroy()
		{
			Remove();
		}
	}
}
