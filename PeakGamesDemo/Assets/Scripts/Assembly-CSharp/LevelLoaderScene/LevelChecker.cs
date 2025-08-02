using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Dialogs;
using Assets.Scripts.GamePlayScene.Mechanics;
using Assets.Scripts.GamePlayScene.Tutorials;
using Assets.Scripts.SceneTransitions;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LevelLoaderScene
{
	public class LevelChecker : MonoBehaviour
	{
		private int KBCCALFCDPL;

		private int NLKHKDBCLMB;

		private const bool CJCNJJMJKCO = true;

		private static readonly int[] AKIKCCOCIMC = new int[47]
		{
			6, 9, 11, 15, 21, 31, 41, 51, 61, 71,
			81, 101, 121, 141, 161, 181, 201, 241, 281, 321,
			351, 401, 451, 501, 551, 601, 651, 701, 751, 801,
			851, 901, 951, 1001, 1101, 1201, 1301, 1401, 1501, 1601,
			1701, 1801, 1901, 2001, 2201, 2401, 2601
		};

		private void Start()
		{
			NLKHKDBCLMB = AKIKCCOCIMC[0];
			SceneManager.sceneLoaded += MHCHGPIJAGF;
			TutorialManager.ForceShowTutorials = false;
			JANPFCNBPMF();
		}

		private void JANPFCNBPMF()
		{
			LevelLoaderController.IsMarketingLevel = true;
			LevelBuilder.CurrentLevelNo = NLKHKDBCLMB;
			LevelBuilder.KDBDBMBAKEL = "Map";
			CaravanSceneManager.Load(GKBHIKONCKJ.GamePlay);
		}

		private void MHCHGPIJAGF(Scene KCDIHPFACAP, LoadSceneMode ODPAKGONNIO)
		{
			if (KCDIHPFACAP.name.Equals("GamePlayScene"))
			{
				StartCoroutine(LIHGLLMEPHK());
			}
		}

		private IEnumerator LIHGLLMEPHK()
		{
			yield return MCJHHDACJBG.CHFOIGLAMPN;
			GoalsBannerDialog.Instance.SkipAnimation();
			int num = 0;
			CFOIPDKEFMM jHDMFHDHIFN = LevelBuilder.ActiveLevel.JHDMFHDHIFN;
			for (int i = 0; i < 10; i++)
			{
				yield return MCJHHDACJBG.CHFOIGLAMPN;
				float num2 = 0f;
				while (FallManager.AreThereMechanicAnimations() && num2 < 5f)
				{
					num2 += 0.1f;
					yield return MCJHHDACJBG.CNDGGNLKOOC;
				}
				Cell cell = HFJMGLPLGBB(jHDMFHDHIFN);
				if (cell != null)
				{
					jHDMFHDHIFN.ELHPMMGOKMF(cell);
					num++;
				}
			}
			LevelBuilder.Recorder.GAMDCIKLKJC(false);
			Debug.Log(string.Format("---- {0} Moves Made at Level {1}", num, NLKHKDBCLMB));
			KBCCALFCDPL++;
			if (KBCCALFCDPL < AKIKCCOCIMC.Length)
			{
				NLKHKDBCLMB = AKIKCCOCIMC[KBCCALFCDPL];
				if (NLKHKDBCLMB < 2850)
				{
					Invoke("JANPFCNBPMF", 0.5f);
				}
				else
				{
					Debug.Log("Level Check is over.");
				}
			}
			else
			{
				Debug.Log("Tutorial Levels are over.");
			}
		}

		private Cell HFJMGLPLGBB(CFOIPDKEFMM GOAELFDHDGD)
		{
			List<Cell> list = new List<Cell>();
			for (int i = 0; i < GOAELFDHDGD.EMFKAPJMDCC; i++)
			{
				for (int j = 0; j < GOAELFDHDGD.FHAMOHDEGMK; j++)
				{
					Cell cell = GOAELFDHDGD.ECNCPJGHBIG(i, j);
					if (cell.Exists)
					{
						PBLOIKDOPAJ pBLOIKDOPAJ = GOAELFDHDGD.ELPGGJBDALH(cell);
						if (pBLOIKDOPAJ != null && pBLOIKDOPAJ.PNBDAGKFOBN > 1)
						{
							list.Add(cell);
						}
					}
				}
			}
			if (list.Count > 0)
			{
				return list[Random.Range(0, list.Count)];
			}
			return null;
		}
	}
}
