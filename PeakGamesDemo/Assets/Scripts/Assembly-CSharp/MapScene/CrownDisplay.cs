using UnityEngine;

namespace MapScene
{
	public class CrownDisplay : MonoBehaviour
	{
		public SpriteRenderer Shadow;

		public SpriteRenderer[] Crowns;

		public void PrepareCrown(int GEMCBIEANPE)
		{
			Shadow.enabled = GEMCBIEANPE != 0;
			for (int i = 0; i < Crowns.Length; i++)
			{
				Crowns[i].enabled = i < GEMCBIEANPE;
			}
		}

		public static int GetCrownStage()
		{
			return DIGGBGADIGJ.GABGKBAKHDP.BGKIIAJNHLL;
		}

		public static int GetPreviousCrownStage()
		{
			return DIGGBGADIGJ.GABGKBAKHDP.GKKBMMHNFLE;
		}
	}
}
