using System;
using System.Collections;
using Assets.Scripts.Utils;
using Spine.Unity;
using UnityEngine;

namespace GamePlayScene.UI
{
	public class WinLogoAnimation : MonoBehaviour
	{
		public SkeletonAnimation LogoAnimation;

		private Action JCOKJJGCPHI;

		private Coroutine HAOCFJDANJF;

		public void Start()
		{
			LogoAnimation.Initialize(false);
		}

		public void StartWinLogo(Action IMHLFAHONPP, Action ALOPLMGGELJ)
		{
			HAOCFJDANJF = StartCoroutine(ONHCPMCEPFF(ALOPLMGGELJ));
			JCOKJJGCPHI = IMHLFAHONPP;
		}

		public void SkipAnimation()
		{
			StopCoroutine(HAOCFJDANJF);
			LogoAnimation.gameObject.SetActive(false);
			if (LogoAnimation.gameObject.activeSelf)
			{
				AudioManager.ForceStopAll();
			}
		}

		private IEnumerator ONHCPMCEPFF(Action ALOPLMGGELJ)
		{
			ResourceRequest resourceRequest = Resources.LoadAsync<SkeletonDataAsset>("SpineAnimations/Celebration/logo_animation_SkeletonData");
			resourceRequest.priority = 0;
			yield return resourceRequest;
			if (ALOPLMGGELJ != null)
			{
				ALOPLMGGELJ();
			}
			LogoAnimation.skeletonDataAsset = resourceRequest.asset as SkeletonDataAsset;
			LogoAnimation.CENGNKJGOGP = "logo_animation3";
			LogoAnimation.loop = false;
			LogoAnimation.Initialize(true);
			LogoAnimation.state.DHOFLMAIDKL += ALBEECHKMAL;
			LogoAnimation.gameObject.SetActive(true);
			AudioManager.PlayStinger(KOOGPFAPGGD.StingerLogo);
			base.transform.position = Vector3.zero;
		}

		private void ALBEECHKMAL(JHFLAELBLPM JKFDBAEMGMJ)
		{
			LogoAnimation.gameObject.SetActive(false);
			if (JCOKJJGCPHI != null)
			{
				JCOKJJGCPHI();
			}
		}
	}
}
