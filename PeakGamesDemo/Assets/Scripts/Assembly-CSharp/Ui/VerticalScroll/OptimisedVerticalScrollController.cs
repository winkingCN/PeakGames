using UnityEngine;

namespace Ui.VerticalScroll
{
	public class OptimisedVerticalScrollController : VerticalScrollController
	{
		private float NAINHDJMFDH = 10f;

		private float LBGBIDHJCDN = -10f;

		public bool ShouldOptimise = true;

		public void SetPoolDimensions(float NHLJFKPLKLI, float IJHGDODBFCD)
		{
			NAINHDJMFDH = NHLJFKPLKLI;
			LBGBIDHJCDN = IJHGDODBFCD;
		}

		protected override void LJPLGIKDFGM()
		{
			if (!ShouldOptimise)
			{
				return;
			}
			int count = NDPMKJIDBOM.Count;
			for (int i = 0; i < count; i++)
			{
				GameObject gameObject = NDPMKJIDBOM[i];
				if (!(gameObject != null))
				{
					continue;
				}
				float num = gameObject.transform.localPosition.y + Content.transform.localPosition.y;
				if (num > LBGBIDHJCDN && num < NAINHDJMFDH)
				{
					if (!gameObject.gameObject.activeSelf)
					{
						gameObject.gameObject.SetActive(true);
					}
				}
				else if (gameObject.gameObject.activeSelf)
				{
					gameObject.gameObject.SetActive(false);
				}
			}
		}
	}
}
