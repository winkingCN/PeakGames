using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Assets.Scripts.Utils;
using UnityEngine;

public class Last5MovesController : MonoBehaviour
{
	public Animator CurrentAnimator;

	public Last5MovesAnimation CurrentAnimation;

	private int BFPEDCPMBOB;

	private int LJPMGPOLOPN;

	private bool CPOBLBCGAJO;

	[CompilerGenerated]
	private static Action EBCOMJBLIPP;

	[CompilerGenerated]
	private static Action DNBOPLHGMHA;

	private void Awake()
	{
		CurrentAnimator.gameObject.SetActive(false);
		BFPEDCPMBOB = Animator.StringToHash("Base Layer.Last5MovesShowAnimation");
		LJPMGPOLOPN = Animator.StringToHash("Base Layer.Last5MovesIdleAnimation");
		CurrentAnimation.OnPlayInSound = delegate
		{
			AudioManager.Play(KOOGPFAPGGD.Last5MovesIn);
		};
		CurrentAnimation.OnPlayOutSound = delegate
		{
			AudioManager.Play(KOOGPFAPGGD.Last5MovesOut);
		};
	}

	public void ResetLast5MovesWarning()
	{
		if (CurrentAnimator.gameObject.activeInHierarchy)
		{
			CurrentAnimator.Play(LJPMGPOLOPN, 0, 0f);
			CurrentAnimator.gameObject.SetActive(false);
		}
		CPOBLBCGAJO = true;
	}

	public void StartLast5MovesAnimation()
	{
		if (CPOBLBCGAJO)
		{
			StartCoroutine(CCCBGOKINNB());
		}
	}

	private IEnumerator CCCBGOKINNB()
	{
		yield return null;
		if (CPOBLBCGAJO)
		{
			CurrentAnimator.gameObject.SetActive(true);
			if (ONCMBJKLKIL.PEFHCKMBHOM)
			{
				CurrentAnimator.transform.localScale = Vector3.one * 0.7f;
				CurrentAnimator.transform.localPosition = new Vector3(0f, -0.2f);
			}
			else
			{
				CurrentAnimator.transform.localScale = Vector3.one;
				CurrentAnimator.transform.localPosition = Vector3.zero;
			}
			CurrentAnimator.Play(BFPEDCPMBOB, 0, 0f);
		}
	}

	public void StopLast5Moves()
	{
		CPOBLBCGAJO = false;
	}

	[CompilerGenerated]
	private static void MLPGDOGDJHG()
	{
		AudioManager.Play(KOOGPFAPGGD.Last5MovesIn);
	}

	[CompilerGenerated]
	private static void DKLNJJEHHFI()
	{
		AudioManager.Play(KOOGPFAPGGD.Last5MovesOut);
	}
}
