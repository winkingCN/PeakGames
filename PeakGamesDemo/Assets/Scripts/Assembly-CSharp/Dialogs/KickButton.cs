using UnityEngine;

namespace Dialogs
{
	public class KickButton : MonoBehaviour
	{
		private Camera MDGJEJCILMI;

		public GameObject Up;

		public GameObject Down;

		private void Start()
		{
			MDGJEJCILMI = Camera.main;
			Hide();
		}

		private void Update()
		{
			if (Input.touchCount > 0)
			{
				Touch touch = Input.touches[0];
				if (touch.phase == TouchPhase.Began)
				{
					NDOHJJMKMEO(touch.position);
				}
			}
		}

		private void NDOHJJMKMEO(Vector2 LDMDBPLADGD)
		{
			Collider2D collider2D = Physics2D.OverlapPoint(MDGJEJCILMI.ScreenToWorldPoint(LDMDBPLADGD));
			if (collider2D == null || (collider2D != null && !collider2D.name.Equals("KickButton")))
			{
				Hide();
			}
		}

		public void Show(bool OBAEIDMHDMF = true)
		{
			base.gameObject.SetActive(true);
			Up.SetActive(OBAEIDMHDMF);
			Down.SetActive(!OBAEIDMHDMF);
		}

		public void Hide()
		{
			base.gameObject.SetActive(false);
		}

		public bool IsActive()
		{
			return base.gameObject.activeSelf;
		}
	}
}
