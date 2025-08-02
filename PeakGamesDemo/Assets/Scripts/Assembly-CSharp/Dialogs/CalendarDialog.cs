using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.MapScene;
using DG.Tweening;
using DataHelpers;
using NewMapScene;
using TMPro;
using UnityEngine;

namespace Dialogs
{
	public class CalendarDialog : OnCloseCallbackDialog, CCGJIPEFOEL
	{
		[CompilerGenerated]
		private sealed class AACICHMDHEK
		{
			internal Dictionary<NAAHKHPBAPA, int> JEAHDBDNJOA;

			internal CalendarDialog PDAPIGLEPGC;

			internal void AGFNGEFDHLA()
			{
				PDAPIGLEPGC.MBEBGNDIKCM(JEAHDBDNJOA[NAAHKHPBAPA.Coins]);
			}

			internal void KDACLOKGNAM()
			{
				PDAPIGLEPGC.FICFHHEBEDO(JEAHDBDNJOA);
			}
		}

		public TextMeshPro TimeLeft;

		public Transform ClockHand;

		public Transform ClaimedBackground;

		public Transform LongClaimedBackground;

		public ParticleSystem UnlockParticlePrefab;

		public ParticleSystem LongUnlockParticlePrefab;

		public CalendarItem[] RewardDays;

		public SpriteRenderer[] ClaimedBackgroundRenderers;

		public SpriteRenderer[] LongClaimedBackgroundRenderers;

		public Sprite[] ClaimedSprites;

		private Action JBJKNCHCDOK;

		private bool AHKJIHENDDJ;

		private float MNGFOOGIKKO;

		public override void OnDialogClosed()
		{
			TimerHelper.GABGKBAKHDP.DeregisterTimer(this);
			base.OnDialogClosed();
		}

		public override void DialogCreated()
		{
			base.DialogCreated();
			int num = BPPNANHCLJI.GABGKBAKHDP.GNJKGLPMMLL;
			int num2 = RewardDays.Length;
			for (int i = 0; i < num2; i++)
			{
				CalendarItem calendarItem = RewardDays[i];
				calendarItem.PrepareCalendarItem();
				if (i < num)
				{
					calendarItem.EnableCalendarItem(this, i == num - 1);
				}
			}
			IOPCENJILNF();
			Dictionary<NAAHKHPBAPA, int> dictionary = BPPNANHCLJI.GABGKBAKHDP.COMIIPHMBGK();
			if (!dictionary.ContainsKey(NAAHKHPBAPA.Coins) && MapManager.Instance != null)
			{
				MapManager.Instance.CurrentContainerManager.SlideToPosition(0);
			}
		}

		public void PrepareDialog(Action IMHLFAHONPP, bool MKEEGFKIOMM)
		{
			SetOnDialogClosedCallback(IMHLFAHONPP);
			AHKJIHENDDJ = MKEEGFKIOMM;
		}

		public void ClaimReward()
		{
			BPPNANHCLJI.GABGKBAKHDP.FOBPKLDNMGN();
			Dictionary<NAAHKHPBAPA, int> JEAHDBDNJOA = BPPNANHCLJI.GABGKBAKHDP.COMIIPHMBGK();
			AFJPGLHKOID.HNPNNHONACO(JEAHDBDNJOA, BPPNANHCLJI.GABGKBAKHDP.GNJKGLPMMLL);
			JBJKNCHCDOK = AMFCLGFBDJI;
			if (JEAHDBDNJOA.ContainsKey(NAAHKHPBAPA.Coins))
			{
				SetOnDialogClosedCallback(delegate
				{
					MBEBGNDIKCM(JEAHDBDNJOA[NAAHKHPBAPA.Coins]);
				});
			}
			else
			{
				SetOnDialogClosedCallback(delegate
				{
					FICFHHEBEDO(JEAHDBDNJOA);
				});
			}
			JBLHLNCOLHD();
			Close();
		}

		private void MBEBGNDIKCM(int NNIDKMJGAJO)
		{
			if (AHKJIHENDDJ)
			{
				SpriteButtonListener.Instance.EnableClicks = false;
			}
			IJIMKNBDAKJ(NNIDKMJGAJO, JBJKNCHCDOK);
		}

		private void FICFHHEBEDO(Dictionary<NAAHKHPBAPA, int> JEAHDBDNJOA)
		{
			if (AHKJIHENDDJ)
			{
				SpriteButtonListener.Instance.EnableClicks = false;
			}
			FOLKKFOJFAG(JEAHDBDNJOA, JBJKNCHCDOK);
		}

		private static void IJIMKNBDAKJ(int NNIDKMJGAJO, Action IMHLFAHONPP)
		{
			MapUIAnimationController instance = MapUIAnimationController.Instance;
			if (instance == null)
			{
				if (IMHLFAHONPP != null)
				{
					IMHLFAHONPP();
				}
			}
			else
			{
				instance.StartCoinCollectAnimation(NNIDKMJGAJO, IMHLFAHONPP, NNIDKMJGAJO / 5, NewMapPage.CoinAnimationStartPosition);
			}
		}

		private static void FOLKKFOJFAG(Dictionary<NAAHKHPBAPA, int> JEAHDBDNJOA, Action IMHLFAHONPP)
		{
			MapUIAnimationController instance = MapUIAnimationController.Instance;
			if (instance == null)
			{
				if (IMHLFAHONPP != null)
				{
					IMHLFAHONPP();
				}
			}
			else
			{
				instance.StartMultipleRewardCollectAnimation(JEAHDBDNJOA, IMHLFAHONPP);
			}
		}

		private void IOPCENJILNF()
		{
			MNGFOOGIKKO = BPPNANHCLJI.GABGKBAKHDP.JGKCEBEAFDP;
			if (MNGFOOGIKKO > 0f)
			{
				TimerHelper.GABGKBAKHDP.RegisterTimer(this);
			}
			DPOOABPAMFO();
		}

		public void UpdateTimeLeft()
		{
			MNGFOOGIKKO = BPPNANHCLJI.GABGKBAKHDP.JGKCEBEAFDP;
			DPOOABPAMFO();
		}

		public void DecreaseTimeLeft()
		{
			MNGFOOGIKKO -= 1f;
			DPOOABPAMFO();
		}

		private void DPOOABPAMFO()
		{
			if (MNGFOOGIKKO <= 0f)
			{
				TimerHelper.GABGKBAKHDP.DeregisterTimer(this);
				Close();
			}
			else
			{
				TimeLeft.FCJBBPHFNPJ = GJEIMLMEHIN.FLANACEGNEO((int)MNGFOOGIKKO, true);
				ClockHand.DORotate(new Vector3(0f, 0f, MNGFOOGIKKO % 4f * 90f), 0.2f).SetEase(Ease.OutBack);
			}
		}

		public override bool CanCloseOnBlackPanelTouch()
		{
			return false;
		}

		public override bool CanHandleBackButton()
		{
			return false;
		}
	}
}
