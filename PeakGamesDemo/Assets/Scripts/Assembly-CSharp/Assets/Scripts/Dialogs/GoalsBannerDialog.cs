using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Assets.Scripts.Utils;
using DG.Tweening;
using Spine.Unity;
using UnityEngine;
using Utils;

namespace Assets.Scripts.Dialogs
{
	public class GoalsBannerDialog : SimpleDialog
	{
		public static GoalsBannerDialog Instance;

		public SkeletonAnimation GoalAnimationSpine;

		private readonly float NCJPJDBCBCJ = 1f;

		private readonly float JFMIMODGKBP = 0.2f;

		private readonly float NKHGFKLLFAL = 1.8f;

		private readonly float PCHAGBCMODO = 0.3f;

		private readonly float NCHHBAFMHIG = 0.2f;

		private readonly float FMDMDDHABHE = 0.25f;

		private readonly float FMIIPHPNBIB = 5f;

		private Action AFLFAKIIMCH;

		private Sequence HOGANFNKDJM;

		private float ABJLIOKICLP;

		private bool EBFPBAEFPGO;

		public void Awake()
		{
			Instance = this;
			GoalAnimationSpine.gameObject.SetActive(false);
			DialogLibrary.GABGKBAKHDP.SetBackgroundColor(NCHHBAFMHIG, 0f);
		}

		public void OnDestroy()
		{
			Instance = null;
		}

		private IEnumerator ONHCPMCEPFF()
		{
			ResourceRequest resourceRequest = Resources.LoadAsync<SkeletonDataAsset>("SpineAnimations/GoalBanner/goalBannerAnimParts_SkeletonData");
			resourceRequest.priority = 0;
			yield return resourceRequest;
			yield return new WaitForSeconds(PCHAGBCMODO);
			GoalAnimationSpine.skeletonDataAsset = resourceRequest.asset as SkeletonDataAsset;
			GoalAnimationSpine.loop = false;
			GoalAnimationSpine.timeScale = NCJPJDBCBCJ;
			GoalAnimationSpine.Initialize(true);
			GoalAnimationSpine.ANLDIDIBHAM.LMHOONAMFIJ(0, "animation", false);
			GoalAnimationSpine.state.DHOFLMAIDKL += ALBEECHKMAL;
			GoalAnimationSpine.gameObject.SetActive(true);
			HOGANFNKDJM = DOTween.Sequence();
			HOGANFNKDJM.InsertCallback(NKHGFKLLFAL, delegate
			{
				AudioManager.Play(KOOGPFAPGGD.GoalBannerOut);
			});
			HOGANFNKDJM.SetEase(Ease.Linear);
			DOTween.Sequence().InsertCallback(JFMIMODGKBP, delegate
			{
				AudioManager.Play(KOOGPFAPGGD.GoalBannerIn);
			});
			ABJLIOKICLP = Time.realtimeSinceStartup;
			JNHCICHFNHL();
		}

		private void ALBEECHKMAL(JHFLAELBLPM JKFDBAEMGMJ)
		{
			if (Instance != null)
			{
				Close();
			}
		}

		public override void DialogCreated()
		{
			JBLHLNCOLHD();
		}

		public override void PlayDialogInAnimation()
		{
			StartCoroutine(ONHCPMCEPFF());
		}

		public override Sequence PlayDialogOutAnimation()
		{
			JBLHLNCOLHD();
			return DOTween.Sequence();
		}

		public override void OnDialogClosed()
		{
			base.OnDialogClosed();
			if (AFLFAKIIMCH != null)
			{
				AFLFAKIIMCH();
			}
		}

		public void SkipAnimation()
		{
			if (EBFPBAEFPGO)
			{
				return;
			}
			EBFPBAEFPGO = true;
			JBLHLNCOLHD();
			if (MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() != 0)
			{
				float num = Time.realtimeSinceStartup - ABJLIOKICLP;
				if (num >= FMDMDDHABHE)
				{
					ANAGFFIPAJH();
					return;
				}
				GoalAnimationSpine.timeScale = FMIIPHPNBIB;
				float atPosition = (FMDMDDHABHE - num) / FMIIPHPNBIB;
				DOTween.Sequence().InsertCallback(atPosition, ANAGFFIPAJH);
			}
		}

		private void ANAGFFIPAJH()
		{
			HOGANFNKDJM.Kill();
			GoalAnimationSpine.timeScale = 0f;
			GoalAnimationSpine.transform.DOLocalMoveX(20f, 0.4f).OnComplete(delegate
			{
				if (Instance != null)
				{
					Close();
				}
			}).SetEase(Ease.Linear);
		}

		public void AfterExit(Action GPLIOLJFDPM)
		{
			AFLFAKIIMCH = GPLIOLJFDPM;
		}

		public override bool CanHandleBackButton()
		{
			return false;
		}

		public override bool CanCloseOnBlackPanelTouch()
		{
			return false;
		}

		[CompilerGenerated]
		private void EFGHAPCEPHF()
		{
			if (Instance != null)
			{
				Close();
			}
		}
	}
}
