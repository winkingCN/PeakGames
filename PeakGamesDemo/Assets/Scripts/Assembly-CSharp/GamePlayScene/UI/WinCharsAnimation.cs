using System;
using System.Collections;
using Assets.Scripts.Utils;
using Spine.Unity;
using UnityEngine;
using Utils;

namespace GamePlayScene.UI
{
	public class WinCharsAnimation : MonoBehaviour
	{
		public SkeletonAnimation WinAnimation;

		public GameObject Particles;

		public GameObject LevelCompletedTitle;

		private Action JCOKJJGCPHI;

		public void SkipAnimation()
		{
			JCOKJJGCPHI = null;
			StopAllCoroutines();
			WinAnimation.gameObject.SetActive(false);
			LevelCompletedTitle.SetActive(false);
			Particles.SetActive(false);
		}

		public void Start()
		{
			Particles.SetActive(false);
			WinAnimation.Initialize(false);
		}

		public void StartWinChars(Action IMHLFAHONPP)
		{
			JCOKJJGCPHI = IMHLFAHONPP;
			StartCoroutine(ONHCPMCEPFF());
		}

		private IEnumerator ONHCPMCEPFF()
		{
			ResourceRequest resourceRequest = Resources.LoadAsync<SkeletonDataAsset>("SpineAnimations/Celebration/celebration_SkeletonData");
			resourceRequest.priority = 0;
			yield return resourceRequest;
			WinAnimation.skeletonDataAsset = resourceRequest.asset as SkeletonDataAsset;
			WinAnimation.CENGNKJGOGP = "animation3";
			WinAnimation.loop = false;
			WinAnimation.Initialize(true);
			AudioManager.PlayStinger(KOOGPFAPGGD.StingerCelebration);
			StartCoroutine(LLDMEALPMOH());
			StartCoroutine(AOEALJHFMEH());
		}

		private static IEnumerator LLDMEALPMOH()
		{
			yield return new WaitForSeconds(0.4f);
			AudioManager.Play(KOOGPFAPGGD.FireworkUp1);
			yield return MCJHHDACJBG.IONDKKIFPHN;
			AudioManager.Play(KOOGPFAPGGD.FireworkUp2);
			yield return new WaitForSeconds(0.37f);
			AudioManager.Play(KOOGPFAPGGD.FireworkExplode1);
			yield return MCJHHDACJBG.IONDKKIFPHN;
			AudioManager.Play(KOOGPFAPGGD.FireworkExplode1);
			yield return MCJHHDACJBG.IONDKKIFPHN;
			AudioManager.Play(KOOGPFAPGGD.FireworkExplode1);
		}

		private IEnumerator AOEALJHFMEH()
		{
			DialogLibrary.GABGKBAKHDP.ShowDialogBackground(false, 0.5f);
			Particles.SetActive(true);
			yield return MCJHHDACJBG.KNLADMIBAAD;
			WinAnimation.gameObject.SetActive(true);
			LevelCompletedTitle.SetActive(true);
			WinAnimation.state.DHOFLMAIDKL += ALBEECHKMAL;
			yield return null;
		}

		private void ALBEECHKMAL(JHFLAELBLPM JKFDBAEMGMJ)
		{
			WinAnimation.gameObject.SetActive(false);
			if (JCOKJJGCPHI != null)
			{
				JCOKJJGCPHI();
			}
		}
	}
}
