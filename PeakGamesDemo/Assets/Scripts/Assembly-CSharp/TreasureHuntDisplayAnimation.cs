using UnityEngine;

public class TreasureHuntDisplayAnimation : MonoBehaviour
{
	public Animator CurrentAnimator;

	[HideInInspector]
	public bool KeyCollectAnimationChosen;

	private readonly int LJPMGPOLOPN = Animator.StringToHash("Base Layer.TreasureHuntDisplayIdleAnimation");

	private readonly int CIEHDNNOAPF = Animator.StringToHash("Base Layer.TreasureHuntDisplayHitAnimation");

	private readonly int ELEACLEABAP = Animator.StringToHash("Base Layer.TreasureHuntDisplayOpenHit");

	private readonly int CPCGDGACNIH = Animator.StringToHash("Base Layer.TreasureHuntDisplayIdleRotateAnimation");

	private readonly int EJNFKHLKLPG = Animator.StringToHash("Base Layer.TreasureHuntDisplayOpenAnimation");

	private bool GGFCNCGFKPL;

	public void StartKeyAnimation(bool HMPGECLFCOA)
	{
		if (HMPGECLFCOA)
		{
			CurrentAnimator.Play(EJNFKHLKLPG, 0, 0f);
		}
		else
		{
			CurrentAnimator.Play(CPCGDGACNIH, 0, 0f);
		}
	}

	public void PlayHitAnimation(bool OGAEECANDHB)
	{
		if (OGAEECANDHB)
		{
			CurrentAnimator.Play(ELEACLEABAP, 0, 0f);
		}
		else if (!GGFCNCGFKPL)
		{
			CurrentAnimator.Play(CIEHDNNOAPF, 0, 0f);
		}
	}

	public void StopAllAnimations()
	{
		GGFCNCGFKPL = true;
		CurrentAnimator.Play(LJPMGPOLOPN, 0, 0f);
	}

	public void PlayRotateAnimationIfNeeded(int FOMFDLLOADK)
	{
		if (!KeyCollectAnimationChosen)
		{
			StartKeyAnimation(FOMFDLLOADK == 2);
		}
	}
}
