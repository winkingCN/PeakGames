using UnityEngine;

namespace Assets.Scripts.Utils
{
	public class BlurFollower : MonoBehaviour
	{
		public int DelayInFrames;

		public SpriteRenderer TargetSpriteRenderer;

		public SpriteRenderer GhostSpriteRenderer;

		private Vector3[] MCLCBAKPMMI;

		private Vector3[] KLAHOMDDKIB;

		private Quaternion[] JFFCLFOOOKH;

		private bool OPDNBMKIPMG;

		private int ENMLICFLHAO;

		private void Awake()
		{
			GhostSpriteRenderer.enabled = false;
			MCLCBAKPMMI = new Vector3[DelayInFrames];
			KLAHOMDDKIB = new Vector3[DelayInFrames];
			JFFCLFOOOKH = new Quaternion[DelayInFrames];
		}

		private void Update()
		{
			MCLCBAKPMMI[ENMLICFLHAO] = TargetSpriteRenderer.transform.position;
			JFFCLFOOOKH[ENMLICFLHAO] = TargetSpriteRenderer.transform.localRotation;
			KLAHOMDDKIB[ENMLICFLHAO] = TargetSpriteRenderer.transform.localScale;
			ENMLICFLHAO++;
			if (ENMLICFLHAO == DelayInFrames)
			{
				ENMLICFLHAO = 0;
				if (!OPDNBMKIPMG)
				{
					OPDNBMKIPMG = true;
					GhostSpriteRenderer.enabled = true;
				}
			}
			if (OPDNBMKIPMG)
			{
				Vector3 position = MCLCBAKPMMI[ENMLICFLHAO];
				position.z += (float)DelayInFrames / 100f;
				GhostSpriteRenderer.transform.position = position;
				GhostSpriteRenderer.transform.localRotation = JFFCLFOOOKH[ENMLICFLHAO];
				GhostSpriteRenderer.transform.localScale = KLAHOMDDKIB[ENMLICFLHAO];
			}
		}
	}
}
