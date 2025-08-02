using TMPro;
using UnityEngine;

namespace NewMapScene
{
	public class ChatHelpNotificationIcon : MonoBehaviour
	{
		public TextMeshPro CountText;

		public SpriteRenderer Background;

		public void UpdateCount(int ENMLICFLHAO)
		{
			CountText.FCJBBPHFNPJ = ENMLICFLHAO.ToString();
		}

		public void Hide()
		{
			if (base.gameObject.activeSelf)
			{
				base.gameObject.SetActive(false);
			}
		}

		public void Show()
		{
			if (!base.gameObject.activeSelf)
			{
				base.gameObject.SetActive(true);
			}
		}
	}
}
