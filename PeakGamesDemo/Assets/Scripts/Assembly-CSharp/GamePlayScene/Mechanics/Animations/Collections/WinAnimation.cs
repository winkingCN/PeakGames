using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Assets.Scripts.GamePlayScene;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Mechanics.Items;
using Assets.Scripts.GamePlayScene.Mechanics.Items.SpecialItems;
using Assets.Scripts.GamePlayScene.UI;
using Assets.Scripts.Utils;
using DG.Tweening;
using GamePlayScene.Mechanics.Items.SpecialItems;
using UnityEngine;

namespace GamePlayScene.Mechanics.Animations.Collections
{
	public class WinAnimation : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class HPKIDICAJFP
		{
			private sealed class CGJAPDKBBON
			{
				internal Item MFLAFJACJPO;

				internal HorizontalRocketItem ALAJBEFFOKB;

				internal Cell FOEGDBHDKOC;

				internal HPKIDICAJFP OMKIMGJICPM;

				private static TweenCallback EBCOMJBLIPP;

				internal void AGFNGEFDHLA()
				{
					UnityEngine.Object.Destroy(MFLAFJACJPO.gameObject);
					int sortingOrder = ALAJBEFFOKB.CurrentSpriteRenderer.sortingOrder;
					ALAJBEFFOKB.CurrentSpriteRenderer.sortingOrder = sortingOrder + 200;
					SortingParticlePlayer sortingParticlePlayer = ParticlePool.Instance.PlayParticle(ParticlePool.Instance.RemainingMoveReplaceParticle, OMKIMGJICPM.LBHDELJBONF.GetFrozenPosition(), false) as SortingParticlePlayer;
					sortingParticlePlayer.Play();
					if (ALAJBEFFOKB.GetShadowCaster() != null)
					{
						if (FOEGDBHDKOC != null && FOEGDBHDKOC.Exists && FOEGDBHDKOC.EAILOFHFNJO && FOEGDBHDKOC.LBFCDKPCDPB.CanShadowDrop())
						{
							ALAJBEFFOKB.GetShadowCaster().CastShadow();
						}
						else
						{
							ALAJBEFFOKB.GetShadowCaster().HideShadow();
						}
					}
					Sequence sequence = DOTween.Sequence();
					sequence.AppendCallback(delegate
					{
						AudioManager.Play(KOOGPFAPGGD.RemainingPlace);
					});
					sequence.Append(ALAJBEFFOKB.transform.DOScale(1.2f, 0.15f).SetEase(Ease.OutQuad));
					sequence.Append(ALAJBEFFOKB.transform.DOScale(1f, 0.08f).SetEase(Ease.OutQuad));
					sequence.OnComplete(delegate
					{
						OMKIMGJICPM.PDAPIGLEPGC.ENHCICFMBPL++;
						ScoreManager.RaiseScore(2000);
					});
				}

				private static void KDACLOKGNAM()
				{
					AudioManager.Play(KOOGPFAPGGD.RemainingPlace);
				}

				internal void DBLIJBPNCAN()
				{
					OMKIMGJICPM.PDAPIGLEPGC.ENHCICFMBPL++;
					ScoreManager.RaiseScore(2000);
				}
			}

			internal Cell LBHDELJBONF;

			internal ParticlePlayer FECHJKBIHAI;

			internal WinAnimation PDAPIGLEPGC;

			internal void AGFNGEFDHLA()
			{
				PDAPIGLEPGC.DKEOEOPLBBM++;
				Item MFLAFJACJPO = LBHDELJBONF.LBFCDKPCDPB;
				HorizontalRocketItem ALAJBEFFOKB = PDAPIGLEPGC.CBOLAKAOMJK.CreateRandomRocket(LBHDELJBONF.GetFrozenPosition());
				LBHDELJBONF.LBFCDKPCDPB = ALAJBEFFOKB;
				Cell FOEGDBHDKOC = LBHDELJBONF.CurrentGrid.PHOOMEOBJCB(LBHDELJBONF, IEKBFJBLGFM.Down);
				ALAJBEFFOKB.transform.localScale = Vector3.zero;
				if (LBHDELJBONF.EAILOFHFNJO)
				{
					MFLAFJACJPO.transform.DOScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f).OnComplete(delegate
					{
						UnityEngine.Object.Destroy(MFLAFJACJPO.gameObject);
						int sortingOrder = ALAJBEFFOKB.CurrentSpriteRenderer.sortingOrder;
						ALAJBEFFOKB.CurrentSpriteRenderer.sortingOrder = sortingOrder + 200;
						SortingParticlePlayer sortingParticlePlayer = ParticlePool.Instance.PlayParticle(ParticlePool.Instance.RemainingMoveReplaceParticle, LBHDELJBONF.GetFrozenPosition(), false) as SortingParticlePlayer;
						sortingParticlePlayer.Play();
						if (ALAJBEFFOKB.GetShadowCaster() != null)
						{
							if (FOEGDBHDKOC != null && FOEGDBHDKOC.Exists && FOEGDBHDKOC.EAILOFHFNJO && FOEGDBHDKOC.LBFCDKPCDPB.CanShadowDrop())
							{
								ALAJBEFFOKB.GetShadowCaster().CastShadow();
							}
							else
							{
								ALAJBEFFOKB.GetShadowCaster().HideShadow();
							}
						}
						Sequence sequence = DOTween.Sequence();
						sequence.AppendCallback(delegate
						{
							AudioManager.Play(KOOGPFAPGGD.RemainingPlace);
						});
						sequence.Append(ALAJBEFFOKB.transform.DOScale(1.2f, 0.15f).SetEase(Ease.OutQuad));
						sequence.Append(ALAJBEFFOKB.transform.DOScale(1f, 0.08f).SetEase(Ease.OutQuad));
						sequence.OnComplete(delegate
						{
							PDAPIGLEPGC.ENHCICFMBPL++;
							ScoreManager.RaiseScore(2000);
						});
					});
				}
				FECHJKBIHAI.SoftStop();
			}
		}

		private CFOIPDKEFMM ODEJCIOOEHC;

		private KFCEILFGADG NLKHKDBCLMB;

		private LevelBuilder CBOLAKAOMJK;

		private CaravanTopPanel ANNJCOELDLM;

		private Sequence BDEOEFKOMIL;

		private Coroutine GOFDKMFAOOO;

		private int ENHCICFMBPL;

		private int DKEOEOPLBBM;

		[CompilerGenerated]
		private static Func<Cell, bool> EBCOMJBLIPP;

		public void Prepare(CaravanTopPanel FNMEHJJAFCF, CFOIPDKEFMM CLCHKLJBIFH)
		{
			ANNJCOELDLM = FNMEHJJAFCF;
			ODEJCIOOEHC = CLCHKLJBIFH;
			CBOLAKAOMJK = ANNJCOELDLM.CurrentlLevelBuilder;
			NLKHKDBCLMB = CBOLAKAOMJK.CurrentLevel;
		}

		public void SkipAnimations()
		{
			BDEOEFKOMIL.Kill();
			if (GOFDKMFAOOO != null)
			{
				StopCoroutine(GOFDKMFAOOO);
			}
			int num = NLKHKDBCLMB.KOJNPMCHBAE - NLKHKDBCLMB.PPHBPKCJGMC - ENHCICFMBPL;
			ScoreManager.RaiseSudden(num * 2300);
		}

		public void StartMovesLeft()
		{
			HintManager.Instance.DisableComboHints();
			int num = ODEJCIOOEHC.ELFBOKDHKGG.EBMFPDNPIEM;
			ParticlePool instance = ParticlePool.Instance;
			if (num > 0)
			{
				Vector3 position = ANNJCOELDLM.MovesLeftText.ANLKLKAINEO.position;
				List<Cell> list = NHPKHHKPFBC();
				int num2 = Mathf.Min(num, list.Count);
				BDEOEFKOMIL = DOTween.Sequence();
				DKEOEOPLBBM = 0;
				for (int i = 0; i < num2; i++)
				{
					Cell cell = list[i];
					Vector3 frozenPosition = cell.GetFrozenPosition();
					float num3 = Vector3.Distance(position, frozenPosition);
					ParticlePlayer particlePlayer = instance.PlayParticle(instance.RemainingMoveRayParticle, position);
					float duration = 0.075f * num3;
					ParticlePlayer component = particlePlayer.GetComponent<ParticlePlayer>();
					BDEOEFKOMIL.Insert(0.2f * (float)i, particlePlayer.transform.DOMove(frozenPosition, duration).SetEase(Ease.OutSine).OnStart(GLLHCBDOBKL)
						.OnComplete(FLILCDMGOCC(cell, component)));
					component.Play();
				}
				GOFDKMFAOOO = StartCoroutine(PKLCPJELMJF(num2));
			}
			else
			{
				GOFDKMFAOOO = StartCoroutine(PKLCPJELMJF(0));
			}
		}

		private void GLLHCBDOBKL()
		{
			AudioManager.Play(KOOGPFAPGGD.RemainingThrow);
			ODEJCIOOEHC.ELFBOKDHKGG.AMFPKLEIMBO();
		}

		private TweenCallback FLILCDMGOCC(Cell LBHDELJBONF, ParticlePlayer FECHJKBIHAI)
		{
			return delegate
			{
				DKEOEOPLBBM++;
				Item MFLAFJACJPO = LBHDELJBONF.LBFCDKPCDPB;
				HorizontalRocketItem ALAJBEFFOKB = CBOLAKAOMJK.CreateRandomRocket(LBHDELJBONF.GetFrozenPosition());
				LBHDELJBONF.LBFCDKPCDPB = ALAJBEFFOKB;
				Cell FOEGDBHDKOC = LBHDELJBONF.CurrentGrid.PHOOMEOBJCB(LBHDELJBONF, IEKBFJBLGFM.Down);
				ALAJBEFFOKB.transform.localScale = Vector3.zero;
				if (LBHDELJBONF.EAILOFHFNJO)
				{
					MFLAFJACJPO.transform.DOScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f).OnComplete(delegate
					{
						UnityEngine.Object.Destroy(MFLAFJACJPO.gameObject);
						int sortingOrder = ALAJBEFFOKB.CurrentSpriteRenderer.sortingOrder;
						ALAJBEFFOKB.CurrentSpriteRenderer.sortingOrder = sortingOrder + 200;
						SortingParticlePlayer sortingParticlePlayer = ParticlePool.Instance.PlayParticle(ParticlePool.Instance.RemainingMoveReplaceParticle, LBHDELJBONF.GetFrozenPosition(), false) as SortingParticlePlayer;
						sortingParticlePlayer.Play();
						if (ALAJBEFFOKB.GetShadowCaster() != null)
						{
							if (FOEGDBHDKOC != null && FOEGDBHDKOC.Exists && FOEGDBHDKOC.EAILOFHFNJO && FOEGDBHDKOC.LBFCDKPCDPB.CanShadowDrop())
							{
								ALAJBEFFOKB.GetShadowCaster().CastShadow();
							}
							else
							{
								ALAJBEFFOKB.GetShadowCaster().HideShadow();
							}
						}
						Sequence sequence = DOTween.Sequence();
						sequence.AppendCallback(delegate
						{
							AudioManager.Play(KOOGPFAPGGD.RemainingPlace);
						});
						sequence.Append(ALAJBEFFOKB.transform.DOScale(1.2f, 0.15f).SetEase(Ease.OutQuad));
						sequence.Append(ALAJBEFFOKB.transform.DOScale(1f, 0.08f).SetEase(Ease.OutQuad));
						sequence.OnComplete(delegate
						{
							ENHCICFMBPL++;
							ScoreManager.RaiseScore(2000);
						});
					});
				}
				FECHJKBIHAI.SoftStop();
			};
		}

		private IEnumerator PKLCPJELMJF(int NMOLFCKNKKI)
		{
			while (DKEOEOPLBBM < NMOLFCKNKKI)
			{
				yield return null;
			}
			yield return MCJHHDACJBG.KNLADMIBAAD;
			int num = 0;
			bool flag = true;
			for (int num2 = ODEJCIOOEHC.FHAMOHDEGMK - 1; num2 >= 0; num2--)
			{
				for (int i = 0; i < ODEJCIOOEHC.EMFKAPJMDCC; i++)
				{
					Cell cell = ODEJCIOOEHC.ECNCPJGHBIG(i, num2);
					if (cell.Exists && cell.EAILOFHFNJO && cell.LBFCDKPCDPB.IsSpecialItem())
					{
						SpecialItem specialItem = (SpecialItem)cell.LBFCDKPCDPB;
						specialItem.CanNotJoinToCombo = true;
						if (specialItem.GetItemType() == NOALGNJECAD.Rocket)
						{
							((HorizontalRocketItem)specialItem).AllowBlockFalls();
						}
						num++;
						if (num >= 3 && flag)
						{
							flag = false;
							SettingsPanel.Instance.HideBottomPanel();
						}
						IEnumerator enumerator = specialItem.StartAutoExplode(MLENMAIAOHJ.BDAKKAIBMIM(0));
						while (enumerator.MoveNext())
						{
							yield return enumerator.Current;
						}
					}
				}
			}
			if (flag)
			{
				SettingsPanel.Instance.HideBottomPanel();
			}
			while (ODEJCIOOEHC.ELFBOKDHKGG.EBMFPDNPIEM > 0)
			{
				ODEJCIOOEHC.ELFBOKDHKGG.AMFPKLEIMBO();
				ScoreManager.RaiseSudden(2000);
				yield return 0.3f;
			}
			while (FallManager.AreThereActiveAnimations())
			{
				yield return null;
			}
			NLKHKDBCLMB.LNPKMGADMHD();
		}

		private List<Cell> NHPKHHKPFBC()
		{
			List<Cell> list = new List<Cell>(85);
			list.AddRange(from LBHDELJBONF in ODEJCIOOEHC.IOFOFDLJDAA()
				where !LBHDELJBONF.HasCellItem() && LBHDELJBONF.EAILOFHFNJO && LBHDELJBONF.LBFCDKPCDPB.CanBeReplacedByPreLevelBooster()
				select LBHDELJBONF);
			list.KFGEEKGAPDP();
			return list;
		}

		[CompilerGenerated]
		private static bool KOMBHEFEDAN(Cell LBHDELJBONF)
		{
			return !LBHDELJBONF.HasCellItem() && LBHDELJBONF.EAILOFHFNJO && LBHDELJBONF.LBFCDKPCDPB.CanBeReplacedByPreLevelBooster();
		}
	}
}
