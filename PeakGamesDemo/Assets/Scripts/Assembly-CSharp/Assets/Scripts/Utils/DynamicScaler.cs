using UnityEngine;

namespace Assets.Scripts.Utils
{
	public class DynamicScaler : MonoBehaviour
	{
		public float AssetWidth = 1f;

		private void Start()
		{
			float num = 1f / base.transform.parent.lossyScale.x;
			float y = base.gameObject.transform.localScale.y;
			base.gameObject.transform.localScale = new Vector3(ONCMBJKLKIL.EMFKAPJMDCC * num * (100f / AssetWidth), y, 1f);
		}
	}
}
