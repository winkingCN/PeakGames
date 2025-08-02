using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.Dialogs;
using Assets.Scripts.Utils;
using DG.Tweening;
using UnityEngine;

namespace Dialogs
{
	public class CrownRushInfoDialog : SimpleDialog
	{
		public CrownRushInfoDialogStage[] Stages;

		public Transform Handle;

		public SpriteRenderer BarBottom;

		public AnimationCurve AnimationCurve;

		public float AnimationDuration = 0.7f;

		public float FadeDelay = 0.2f;

		public SpriteRenderer BarUp;

		public ParticleSystem[] UnlockParticles;

		public ParticleSystem[] CrownParticles;

		private int ENKOOGOCIOG;

		private int OLCIGAMCDOD;

		private long MNGFOOGIKKO;

		private Action JCOKJJGCPHI;

		private readonly float[] DPPGJAGPEME = new float[4] { -1.1f, -0.445f, 1.003f, 2.417f };

		private readonly float[] JAOGMLEMMFD = new float[4] { 0f, -0.65f, 0.895f, 2.455f };

		public void PrepareDialog(Action IMHLFAHONPP)
		{
			JCOKJJGCPHI = IMHLFAHONPP;
		}

		private void MGLDEFMHKAG(int HHGJAPDCLNA, int GADFFIINEPM)
		{
			if (GADFFIINEPM == 0)
			{
				BarBottom.enabled = false;
				Handle.gameObject.SetActive(false);
			}
			ENKOOGOCIOG = Mathf.Clamp(HHGJAPDCLNA, 0, 3);
			OLCIGAMCDOD = Mathf.Clamp(GADFFIINEPM, 0, 3);
			HLBKOJHHMHH(HHGJAPDCLNA, false);
			Vector3 localPosition = Handle.transform.localPosition;
			localPosition.y = DPPGJAGPEME[ENKOOGOCIOG];
			Handle.transform.localPosition = localPosition;
			DGDIJBNPHPH();
		}

		public override void DialogCreated()
		{
			base.DialogCreated();
			DIGGBGADIGJ dIGGBGADIGJ = DIGGBGADIGJ.GABGKBAKHDP;
			if (!DIGGBGADIGJ.DFGKPMCBFNL)
			{
				MGLDEFMHKAG(0, 0);
			}
			else if (dIGGBGADIGJ.ICNIGMDCCLN)
			{
				dIGGBGADIGJ.LGDBADICPEN();
				MGLDEFMHKAG(dIGGBGADIGJ.GKKBMMHNFLE, dIGGBGADIGJ.BGKIIAJNHLL);
			}
			else
			{
				MGLDEFMHKAG(dIGGBGADIGJ.BGKIIAJNHLL, dIGGBGADIGJ.BGKIIAJNHLL);
			}
		}

		public override void OnDialogClosed()
		{
			if (JCOKJJGCPHI != null)
			{
				JCOKJJGCPHI();
			}
			base.OnDialogClosed();
		}

		protected override void BLELAMHLLNN()
		{
			base.BLELAMHLLNN();
			if (OLCIGAMCDOD > 0)
			{
				if (ENKOOGOCIOG == OLCIGAMCDOD)
				{
					FHLDIBHNLCB();
				}
				else
				{
					PHOPGBPFOBB();
				}
			}
		}

		private void PHOPGBPFOBB()
		{
			AudioManager.Play(KOOGPFAPGGD.CrownInfoDialogFill);
			Sequence s = DOTween.Sequence();
			s.Insert(0f, Handle.DOLocalMoveY(DPPGJAGPEME[OLCIGAMCDOD], AnimationDuration).SetEase(AnimationCurve).OnUpdate(DGDIJBNPHPH));
			s.InsertCallback(FadeDelay, delegate
			{
				HLBKOJHHMHH(OLCIGAMCDOD, true);
			});
			s.InsertCallback(AnimationDuration * 0.75f, delegate
			{
				if (OLCIGAMCDOD == 3)
				{
					BarUp.enabled = true;
				}
				AudioManager.Play(KOOGPFAPGGD.CrownInfoDialogParticle);
				Vector3 localPosition = UnlockParticles[0].transform.localPosition;
				localPosition.y = JAOGMLEMMFD[OLCIGAMCDOD];
				for (int i = 0; i < UnlockParticles.Length; i++)
				{
					UnlockParticles[i].transform.localPosition = localPosition;
					UnlockParticles[i].Play();
				}
				Stages[ENKOOGOCIOG].PlayBounceAnimation();
				FHLDIBHNLCB();
			});
		}

		private void HLBKOJHHMHH(int EGEPICBFDAE, bool IJBFBKHPEMK)
		{
			for (int i = 0; i < 3; i++)
			{
				Stages[i].SetStatus(i + 1 == EGEPICBFDAE, IJBFBKHPEMK);
			}
			if (!IJBFBKHPEMK && EGEPICBFDAE == 3)
			{
				BarUp.enabled = true;
			}
		}

		private void DGDIJBNPHPH()
		{
			Vector2 size = BarBottom.size;
			size.y = 0.71f + (Handle.localPosition.y - DPPGJAGPEME[1]);
			BarBottom.size = size;
			Vector3 localPosition = BarBottom.transform.localPosition;
			localPosition.y = -1.02f + size.y * 0.5f;
			BarBottom.transform.localPosition = localPosition;
		}

		private void FHLDIBHNLCB()
		{
			Vector3 localPosition = CrownParticles[0].transform.localPosition;
			localPosition.y = JAOGMLEMMFD[OLCIGAMCDOD];
			for (int i = 0; i < CrownParticles.Length; i++)
			{
				CrownParticles[i].transform.localPosition = localPosition;
				CrownParticles[i].Play();
			}
		}

		[CompilerGenerated]
		private void KMBOCKAKCCC()
		{
			HLBKOJHHMHH(OLCIGAMCDOD, true);
		}

		[CompilerGenerated]
		private void MDNMCDIIPHP()
		{
			if (OLCIGAMCDOD == 3)
			{
				BarUp.enabled = true;
			}
			AudioManager.Play(KOOGPFAPGGD.CrownInfoDialogParticle);
			Vector3 localPosition = UnlockParticles[0].transform.localPosition;
			localPosition.y = JAOGMLEMMFD[OLCIGAMCDOD];
			for (int i = 0; i < UnlockParticles.Length; i++)
			{
				UnlockParticles[i].transform.localPosition = localPosition;
				UnlockParticles[i].Play();
			}
			Stages[ENKOOGOCIOG].PlayBounceAnimation();
			FHLDIBHNLCB();
		}
	}
}
