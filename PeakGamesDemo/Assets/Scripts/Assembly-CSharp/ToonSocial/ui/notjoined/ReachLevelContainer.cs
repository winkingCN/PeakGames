using TMPro;
using UnityEngine;

namespace ToonSocial.ui.notjoined
{
	public class ReachLevelContainer : MonoBehaviour
	{
		public Transform UnlockTextContainer;

		public Transform PassTextContainer;

		public Transform BottomContainer;

		public TextMeshPro PassText;

		public TextMeshPro LevelText;

		public TextMeshPro UnlockText;

		public TextMeshPro TeamsText;

		public TextMeshPro[] BottomTexts;

		private bool OCOAHBEFJAA;

		private void OnEnable()
		{
			LevelText.SetText(NKILHODNBDE.GHBGCADFLFB("Level") + 20);
			if (!OCOAHBEFJAA)
			{
				ALLOFJJMHAK();
			}
		}

		private void ALLOFJJMHAK()
		{
			OCOAHBEFJAA = true;
			float num = (NPGMJPNMMEF(TeamsText) - NPGMJPNMMEF(UnlockText)) / 2f;
			UnlockTextContainer.localPosition += Vector3.right * num;
			float num2 = (NPGMJPNMMEF(LevelText) - NPGMJPNMMEF(PassText)) / 2f;
			PassTextContainer.localPosition += Vector3.right * num2;
			if (BottomTexts != null)
			{
				float x = BottomTexts[0].GPPKOGCLKPL.sizeDelta.x;
				float num3 = x;
				int i = 0;
				for (int num4 = BottomTexts.Length; i < num4; i++)
				{
					num3 = Mathf.Max(BottomTexts[i].GetPreferredValues().x, num3);
				}
				float num5 = (x - num3) / 2f;
				BottomContainer.localPosition += Vector3.right * num5;
			}
		}

		private float NPGMJPNMMEF(TextMeshPro KBINGMPHHOG)
		{
			float width = KBINGMPHHOG.GPPKOGCLKPL.rect.width;
			float num = Mathf.Min(KBINGMPHHOG.GetPreferredValues().x, width);
			return width - num;
		}
	}
}
