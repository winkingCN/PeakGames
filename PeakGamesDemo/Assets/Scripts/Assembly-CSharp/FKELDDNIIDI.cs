using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.GamePlayScene.Tutorials;
using Assets.Scripts.MapScene;
using Assets.Scripts.Utils;
using DG.Tweening;
using NewMapScene;
using UnityEngine;

public class FKELDDNIIDI : OOHGOOPDAEM
{
	[CompilerGenerated]
	private sealed class BLDAGAHMGIN
	{
		internal MapTutorial AADBMFOIKKM;

		internal FKELDDNIIDI PDAPIGLEPGC;

		internal void AGFNGEFDHLA()
		{
			PDAPIGLEPGC.IOOJGJEKDMK(false);
			SpriteButtonListener.Instance.EnableClicks = false;
			if (PDAPIGLEPGC.CECMINAKHFJ != null)
			{
				PDAPIGLEPGC.CECMINAKHFJ(true);
			}
		}

		internal void KDACLOKGNAM()
		{
			AADBMFOIKKM.FadeInBackground();
		}

		internal void DBLIJBPNCAN()
		{
			PDAPIGLEPGC.IOOJGJEKDMK(false);
		}

		internal void EFLLCMEPAEM()
		{
			AADBMFOIKKM.ShowDialog();
			Vector3 position = PDAPIGLEPGC.KEDPOOIDHDI.StarChestDisplay.transform.position;
			position.x = 0.86f;
			position.y -= 2.1f;
			AADBMFOIKKM.ShowArrow(position, -22.5f);
			SpriteButtonListener.Instance.EnableClicks = true;
		}

		internal void NNINHCPIBHO()
		{
			AADBMFOIKKM.Remove();
		}

		internal void HFBABENGMDD()
		{
			AADBMFOIKKM.FadeInBackground();
			Vector3 position = PDAPIGLEPGC.KEDPOOIDHDI.StarChestDisplay.transform.position;
			position.y -= 2f;
			AADBMFOIKKM.ShowArrow(position);
			SpriteButtonListener.Instance.EnableClicks = true;
			PDAPIGLEPGC.KEDPOOIDHDI.StarChestDisplay.SetClickOnceCallback(delegate
			{
				AADBMFOIKKM.Remove();
				new LLCJMMBBLEH(PDAPIGLEPGC.NLEMACGPEDN(), true);
			});
		}

		internal void JJBKCOCNHNL()
		{
			if (PDAPIGLEPGC.CECMINAKHFJ != null)
			{
				PDAPIGLEPGC.CECMINAKHFJ(false);
			}
		}

		internal void MJJBIDJBGLE()
		{
			AADBMFOIKKM.Remove();
			new LLCJMMBBLEH(PDAPIGLEPGC.NLEMACGPEDN(), true);
		}
	}

	[CompilerGenerated]
	private sealed class PHDHKDBHFKC
	{
		internal int OBAOKEIDEBE;

		internal FKELDDNIIDI PDAPIGLEPGC;
	}

	[CompilerGenerated]
	private sealed class FGEIINPCLEH
	{
		internal LevelStar DGDJJMDCKOE;

		internal bool EEFDIIMFLNH;

		internal int BDKFNEDHAOJ;

		internal PHDHKDBHFKC HJAOPEBPGKJ;

		internal void AGFNGEFDHLA()
		{
			DGDJJMDCKOE.ShadowSpriteRenderer.enabled = true;
			DGDJJMDCKOE.StarSpriteRenderer.sprite = DGDJJMDCKOE.StarSprite;
		}

		internal void KDACLOKGNAM()
		{
			DGDJJMDCKOE.transform.localScale = Vector3.zero;
			HJAOPEBPGKJ.PDAPIGLEPGC.KEDPOOIDHDI.StarChestDisplay.IncreaseStarCount(EEFDIIMFLNH);
			KOOGPFAPGGD mOKLDCMGFFB = KOOGPFAPGGD.StarChestOpen1;
			if (HJAOPEBPGKJ.OBAOKEIDEBE == 3)
			{
				if (BDKFNEDHAOJ == 0)
				{
					mOKLDCMGFFB = KOOGPFAPGGD.StarChestOpen1;
				}
				else if (BDKFNEDHAOJ == 1)
				{
					mOKLDCMGFFB = KOOGPFAPGGD.StarChestOpen2;
				}
				else if (BDKFNEDHAOJ == 2)
				{
					mOKLDCMGFFB = KOOGPFAPGGD.StarChestOpen3;
				}
			}
			else if (HJAOPEBPGKJ.OBAOKEIDEBE == 2)
			{
				if (BDKFNEDHAOJ == 0)
				{
					mOKLDCMGFFB = KOOGPFAPGGD.StarChestOpen2;
				}
				else if (BDKFNEDHAOJ == 1)
				{
					mOKLDCMGFFB = KOOGPFAPGGD.StarChestOpen3;
				}
			}
			else if (HJAOPEBPGKJ.OBAOKEIDEBE == 1 && BDKFNEDHAOJ == 0)
			{
				mOKLDCMGFFB = KOOGPFAPGGD.StarChestOpen3;
			}
			AudioManager.Play(mOKLDCMGFFB);
		}
	}

	private readonly Vector3 NLHJNNLLFDI;

	private readonly NewMapAnimationController KEDPOOIDHDI;

	[CompilerGenerated]
	private static TweenCallback EBCOMJBLIPP;

	public FKELDDNIIDI(NewMapAnimationController FOLPGENLEFE, Vector3 NBOLDLDHNGE, Action<bool> IMHLFAHONPP)
		: base(IMHLFAHONPP)
	{
		CENGNKJGOGP = "StaticMapStarCollectAnimation";
		KEDPOOIDHDI = FOLPGENLEFE;
		NLHJNNLLFDI = NBOLDLDHNGE;
	}

	public override void GDGINCNCMDD(bool ODCADGABBHJ, bool DEIGFPCALOJ)
	{
		if (NDGOJGLPIJF.GABGKBAKHDP.AEFOGGAOFEE() && NDGOJGLPIJF.GABGKBAKHDP.AMKOJOKCELO > 0)
		{
			Sequence sequence = DOTween.Sequence();
			sequence.SetEase(Ease.Linear);
			bool flag = MapTutorial.ShouldDisplayStarChestStarTutorial();
			bool flag2 = MapTutorial.ShouldDisplayStarChestOpenTutorial();
			int aMKOJOKCELO = NDGOJGLPIJF.GABGKBAKHDP.AMKOJOKCELO;
			NDGOJGLPIJF.GABGKBAKHDP.AMKOJOKCELO = 0;
			MapTutorial AADBMFOIKKM = null;
			if (flag)
			{
				MapTutorial.CompleteStarChestStartTutorial();
				AADBMFOIKKM = UnityEngine.Object.Instantiate(KEDPOOIDHDI.MapTutorialReference).GetComponent<MapTutorial>();
				AADBMFOIKKM.Init(string.Format(NKILHODNBDE.GHBGCADFLFB("starChestStartTutorial"), NDGOJGLPIJF.DGIKLPPBGHJ), new Vector3(0f, KEDPOOIDHDI.StarChestDisplay.transform.position.y - 4.57f, 0f), delegate
				{
					IOOJGJEKDMK(false);
					SpriteButtonListener.Instance.EnableClicks = false;
					if (CECMINAKHFJ != null)
					{
						CECMINAKHFJ(true);
					}
				});
				IOOJGJEKDMK(true);
				sequence.InsertCallback(0f, delegate
				{
					AADBMFOIKKM.FadeInBackground();
				});
			}
			else if (flag2)
			{
				AADBMFOIKKM = UnityEngine.Object.Instantiate(KEDPOOIDHDI.MapTutorialReference).GetComponent<MapTutorial>();
				AADBMFOIKKM.Init(string.Empty, Vector3.zero, delegate
				{
					IOOJGJEKDMK(false);
				});
				IOOJGJEKDMK(true);
			}
			float iBNDGNOIEEF = ((!MapTutorial.ShouldDisplayStarChestStarTutorial()) ? (-0.2f) : 0.1f);
			FLCLPOOCNFA(sequence, aMKOJOKCELO, NLHJNNLLFDI, iBNDGNOIEEF);
			if (flag)
			{
				sequence.InsertCallback(sequence.Duration() + 0.3f, delegate
				{
					AADBMFOIKKM.ShowDialog();
					Vector3 position2 = KEDPOOIDHDI.StarChestDisplay.transform.position;
					position2.x = 0.86f;
					position2.y -= 2.1f;
					AADBMFOIKKM.ShowArrow(position2, -22.5f);
					SpriteButtonListener.Instance.EnableClicks = true;
				});
				KEDPOOIDHDI.StarChestDisplay.SetClickOnceCallback(delegate
				{
					AADBMFOIKKM.Remove();
				});
				return;
			}
			if (flag2)
			{
				sequence.InsertCallback(sequence.Duration() + 0.3f, delegate
				{
					AADBMFOIKKM.FadeInBackground();
					Vector3 position = KEDPOOIDHDI.StarChestDisplay.transform.position;
					position.y -= 2f;
					AADBMFOIKKM.ShowArrow(position);
					SpriteButtonListener.Instance.EnableClicks = true;
					KEDPOOIDHDI.StarChestDisplay.SetClickOnceCallback(delegate
					{
						AADBMFOIKKM.Remove();
						new LLCJMMBBLEH(NLEMACGPEDN(), true);
					});
				});
				return;
			}
			sequence.InsertCallback(sequence.Duration() - 0.3f, delegate
			{
				if (CECMINAKHFJ != null)
				{
					CECMINAKHFJ(false);
				}
			});
		}
		else if (CECMINAKHFJ != null)
		{
			CECMINAKHFJ(false);
		}
	}

	private IEnumerator NLEMACGPEDN()
	{
		yield return MCJHHDACJBG.CNDGGNLKOOC;
		while (FHAAAFAAMDO.GABGKBAKHDP.COCNAAGPOMN)
		{
			yield return null;
		}
		SpriteButtonListener.Instance.EnableClicks = false;
		if (CECMINAKHFJ != null)
		{
			CECMINAKHFJ(true);
		}
	}

	private void IOOJGJEKDMK(bool HMLFIACPAAD)
	{
		int num = ((!HMLFIACPAAD) ? (-1) : (-11));
		int nNIDKMJGAJO = ((!HMLFIACPAAD) ? (-500) : 500);
		KEDPOOIDHDI.StarChestDisplay.ChangeButtonDepth(num);
		KEDPOOIDHDI.StarChestDisplay.IncreaseSortingOrder(nNIDKMJGAJO);
	}

	private void FLCLPOOCNFA(Sequence PGIHCKGJEHD, int OBAOKEIDEBE, Vector3 FADJPCHMMBH, float IBNDGNOIEEF)
	{
		AnimationCurve startScaleCurve = KEDPOOIDHDI.LevelStars[0].StartScaleCurve;
		AnimationCurve endMoveCurve = KEDPOOIDHDI.LevelStars[0].EndMoveCurve;
		Vector3[] array;
		float[] array2;
		float[] array3;
		float[] array4;
		if (OBAOKEIDEBE == 1)
		{
			array = new Vector3[1]
			{
				new Vector3(0f, -2.474f)
			};
			array2 = new float[1];
			array3 = new float[1] { -4f };
			array4 = new float[1] { 1.7f };
		}
		else if (OBAOKEIDEBE == 2)
		{
			array = new Vector3[2]
			{
				new Vector3(1.59f, -3.36f),
				new Vector3(-1.2f, -3.4f)
			};
			array2 = new float[2] { -9.63f, 5.86f };
			array3 = new float[2] { -8f, 6.8f };
			array4 = new float[2] { 1.68f, 1.68f };
		}
		else
		{
			array = new Vector3[3]
			{
				new Vector3(2.608f, -2.474f),
				new Vector3(0.13f, -3.42f),
				new Vector3(-2.776f, -3.41f)
			};
			array2 = new float[3] { 20f, 7.6f, 0f };
			array3 = new float[3] { 8.5f, 3f, -5.73f };
			array4 = new float[3] { 1.7f, 2f, 1.72f };
		}
		for (int i = 0; i < OBAOKEIDEBE; i++)
		{
			LevelStar DGDJJMDCKOE = KEDPOOIDHDI.LevelStars[i];
			DGDJJMDCKOE.gameObject.SetActive(true);
			DGDJJMDCKOE.transform.localScale = Vector3.zero;
			FADJPCHMMBH.y += 0.5f;
			DGDJJMDCKOE.transform.position = FADJPCHMMBH;
			Quaternion quaternion = default(Quaternion);
			quaternion.eulerAngles = new Vector3(0f, 0f, 22.5f);
			Quaternion rotation = quaternion;
			DGDJJMDCKOE.transform.rotation = rotation;
			DGDJJMDCKOE.StarSpriteRenderer.sprite = DGDJJMDCKOE.BlurSprite;
			DGDJJMDCKOE.ShadowSpriteRenderer.enabled = false;
			bool EEFDIIMFLNH = i == OBAOKEIDEBE - 1;
			Sequence sequence = DOTween.Sequence();
			sequence.InsertCallback(0.25f, delegate
			{
				AudioManager.Play(KOOGPFAPGGD.ChestCardTurn);
			});
			sequence.Insert(0f, DGDJJMDCKOE.transform.DOScale(array4[i], 0.7f).SetEase(startScaleCurve));
			sequence.Insert(0f, DGDJJMDCKOE.transform.DOMove(array[i], 0.7f).SetEase(startScaleCurve));
			sequence.Insert(0f, DGDJJMDCKOE.transform.DORotate(new Vector3(0f, 0f, array2[i]), 0.5f).SetEase(Ease.OutSine));
			sequence.InsertCallback(0.38f, delegate
			{
				DGDJJMDCKOE.ShadowSpriteRenderer.enabled = true;
				DGDJJMDCKOE.StarSpriteRenderer.sprite = DGDJJMDCKOE.StarSprite;
			});
			float num = 0.3f + 0.1f * (float)i;
			sequence.InsertCallback(num + 0.5f, DGDJJMDCKOE.TrailParticle.Play);
			sequence.Insert(num + 0.5f, DGDJJMDCKOE.transform.DORotate(new Vector3(0f, 0f, array3[i]), 0.15f).SetEase(Ease.OutSine));
			sequence.Insert(num + 0.6f, DGDJJMDCKOE.transform.DORotate(new Vector3(0f, 0f, 16.5f), 0.45f).SetEase(Ease.InSine));
			sequence.Insert(num + 0.5f, DGDJJMDCKOE.transform.DOScale(1f, 0.6f).SetEase(Ease.InSine));
			sequence.Insert(num + 0.5f, DGDJJMDCKOE.transform.DOMove(KEDPOOIDHDI.LevelStarTarget.position, 0.6f).SetEase(endMoveCurve));
			sequence.InsertCallback(num + 1.1f, DGDJJMDCKOE.TrailParticle.Stop);
			int BDKFNEDHAOJ = i;
			sequence.InsertCallback(num + 1.1f, delegate
			{
				DGDJJMDCKOE.transform.localScale = Vector3.zero;
				KEDPOOIDHDI.StarChestDisplay.IncreaseStarCount(EEFDIIMFLNH);
				KOOGPFAPGGD mOKLDCMGFFB = KOOGPFAPGGD.StarChestOpen1;
				if (OBAOKEIDEBE == 3)
				{
					if (BDKFNEDHAOJ == 0)
					{
						mOKLDCMGFFB = KOOGPFAPGGD.StarChestOpen1;
					}
					else if (BDKFNEDHAOJ == 1)
					{
						mOKLDCMGFFB = KOOGPFAPGGD.StarChestOpen2;
					}
					else if (BDKFNEDHAOJ == 2)
					{
						mOKLDCMGFFB = KOOGPFAPGGD.StarChestOpen3;
					}
				}
				else if (OBAOKEIDEBE == 2)
				{
					if (BDKFNEDHAOJ == 0)
					{
						mOKLDCMGFFB = KOOGPFAPGGD.StarChestOpen2;
					}
					else if (BDKFNEDHAOJ == 1)
					{
						mOKLDCMGFFB = KOOGPFAPGGD.StarChestOpen3;
					}
				}
				else if (OBAOKEIDEBE == 1 && BDKFNEDHAOJ == 0)
				{
					mOKLDCMGFFB = KOOGPFAPGGD.StarChestOpen3;
				}
				AudioManager.Play(mOKLDCMGFFB);
			});
			PGIHCKGJEHD.Insert(IBNDGNOIEEF + (float)i * 0.2f, sequence);
		}
	}

	[CompilerGenerated]
	private static void HMEHPAKNACB()
	{
		AudioManager.Play(KOOGPFAPGGD.ChestCardTurn);
	}
}
