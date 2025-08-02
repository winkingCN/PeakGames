using UnityEngine;

namespace Assets.Scripts.GamePlayScene.Mechanics.Items
{
	public class SafeGold : MonoBehaviour
	{
		public SpriteRenderer CurrentSpriteRenderer;

		public Animator CurrentAnimator;

		[HideInInspector]
		public int Id;

		private readonly int[] DNICNDODLCP = new int[3]
		{
			Animator.StringToHash("Base Layer.SafeGoldShakeUp1"),
			Animator.StringToHash("Base Layer.SafeGoldShakeUp2"),
			Animator.StringToHash("Base Layer.SafeGoldShakeUp3")
		};

		private readonly int[] EGCJCOOLBID = new int[3]
		{
			Animator.StringToHash("Base Layer.SafeGoldShakeDown1"),
			Animator.StringToHash("Base Layer.SafeGoldShakeDown2"),
			Animator.StringToHash("Base Layer.SafeGoldShakeDown3")
		};

		public void PlayShakeAnimation(int PKHFDMGGGJN, int EHJNMODJEAN)
		{
			int[] array = ((!GHHKOLHPOKC(PKHFDMGGGJN)) ? DNICNDODLCP : EGCJCOOLBID);
			int num = (EHJNMODJEAN + Id) % array.Length;
			CurrentAnimator.Play(array[num], 0, 0f);
		}

		private bool GHHKOLHPOKC(int PKHFDMGGGJN)
		{
			switch (PKHFDMGGGJN)
			{
			case 3:
				return Id != 3;
			case 4:
			case 5:
				return Id != 1 && Id != 2;
			default:
				return false;
			}
		}

		public void Remove()
		{
			CurrentAnimator.StopPlayback();
			Object.Destroy(base.gameObject);
		}
	}
}
