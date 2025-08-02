using DG.Tweening;
using UnityEngine;

public class TutorialAnimationEvents : MonoBehaviour
{
	public ParticleSystem FingerParticle1;

	public ParticleSystem FingerParticle2;

	public void PlayParticleAnimation()
	{
		FingerParticle1.Play();
		FingerParticle2.Play();
	}

	public void MoveFinger()
	{
		Sequence s = DOTween.Sequence();
		s.Append(base.transform.DOLocalMoveY(0f, 0.3f));
		s.Append(base.transform.DOLocalMoveY(-0.5f, 0.3f));
	}
}
