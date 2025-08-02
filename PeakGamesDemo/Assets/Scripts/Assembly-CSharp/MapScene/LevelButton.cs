using Assets.Scripts.MapScene;
using TMPro;
using UnityEngine;
using Utils;

namespace MapScene
{
	public class LevelButton : MonoBehaviour
	{
		private MapManager HDHCLKHLCEB;

		protected int EADEMDIHGHE;

		public TextMeshPro LevelButtonText;

		public Animator CurrentAnimator;

		public Animator CurrentCrownAnimator;

		public ParticleSystem CurrentParticle;

		public CrownDisplay CrownDisplay;

		private readonly int HNHPBOOPHLK = Animator.StringToHash("Base Layer.LevelButtonUnlockAnimation");

		private readonly int HFBAAIGHGPK = Animator.StringToHash("Base Layer.LevelButtonCrownStage1Animation");

		private readonly int IPHLGBBBDMH = Animator.StringToHash("Base Layer.LevelButtonCrownStage2Animation");

		private readonly int IGIMGOLKCMP = Animator.StringToHash("Base Layer.LevelButtonCrownStage3Animation");

		private readonly int LIKJICAPKDB = Animator.StringToHash("Base Layer.LevelButtonBoosterHitAnimation");

		public void PrepareButton(int KIGOGMKCDKN, MapManager GCONMABJKBG)
		{
			EADEMDIHGHE = KIGOGMKCDKN;
			HDHCLKHLCEB = GCONMABJKBG;
		}

		public void UpdateLevelButton(bool HPDIJAMMMNO)
		{
			UpdateLevelButtonText(HPDIJAMMMNO);
			UpdateCrownStage(HPDIJAMMMNO);
		}

		public void UpdateLevelButtonText(bool HPDIJAMMMNO)
		{
			if (HPDIJAMMMNO)
			{
				LevelButtonText.FCJBBPHFNPJ = AAGBDALMKEA(EADEMDIHGHE);
			}
			else
			{
				LevelButtonText.FCJBBPHFNPJ = AAGBDALMKEA(EADEMDIHGHE - 1);
			}
		}

		public void UpdateCrownStage(bool HPDIJAMMMNO)
		{
			if (HPDIJAMMMNO)
			{
				CrownDisplay.PrepareCrown(CrownDisplay.GetCrownStage());
			}
			else
			{
				CrownDisplay.PrepareCrown(CrownDisplay.GetPreviousCrownStage());
			}
		}

		public void PlayButtonAnimation()
		{
			CurrentAnimator.Play(HNHPBOOPHLK, 0, 0f);
			if (DIGGBGADIGJ.DFGKPMCBFNL)
			{
				switch (DIGGBGADIGJ.GABGKBAKHDP.GKKBMMHNFLE)
				{
				case 0:
					CurrentCrownAnimator.Play(HFBAAIGHGPK, 0, 0f);
					break;
				case 1:
					CurrentCrownAnimator.Play(IPHLGBBBDMH, 0, 0f);
					break;
				case 2:
					CurrentCrownAnimator.Play(IPHLGBBBDMH, 0, 0f);
					break;
				case 3:
					CurrentCrownAnimator.Play(IGIMGOLKCMP, 0, 0f);
					break;
				}
			}
		}

		public virtual void OnLevelButtonClick()
		{
			if (EADEMDIHGHE > 2850)
			{
				int num = IMLNKMACKMF.GABGKBAKHDP.PCBNDMDMAHJ;
				FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK((num <= EADEMDIHGHE) ? DialogLibrary.GABGKBAKHDP.MoreLevelsDialog : DialogLibrary.GABGKBAKHDP.NewLevelsDialog, false);
			}
			else
			{
				HDHCLKHLCEB.OnLevelStopClick(EADEMDIHGHE);
			}
		}

		public bool IsCrownEventAvailable()
		{
			return DIGGBGADIGJ.GABGKBAKHDP.BGKIIAJNHLL > 0;
		}

		protected virtual string AAGBDALMKEA(int GIOFHACJEGA)
		{
			return NKILHODNBDE.GHBGCADFLFB("Level") + GIOFHACJEGA;
		}

		public void PlayBoosterHitAnimation()
		{
			if (base.gameObject.activeSelf)
			{
				CurrentAnimator.Play(LIKJICAPKDB, 0, 0f);
			}
		}
	}
}
