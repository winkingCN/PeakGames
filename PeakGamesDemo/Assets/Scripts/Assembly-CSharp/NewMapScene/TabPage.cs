using UnityEngine;

namespace NewMapScene
{
	public class TabPage : MonoBehaviour
	{
		public virtual void Activate()
		{
			base.gameObject.SetActive(true);
		}

		public virtual void Deactivate()
		{
			base.gameObject.SetActive(false);
		}

		public virtual void Prepare()
		{
		}
	}
}
